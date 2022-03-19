#!/usr/bin/python
# Author Richard Sayer
# Copyright (c) 2022 Richard Sayer

import logging
import webbrowser
import configparser
import os
import pathlib
from shutil import rmtree as remove_directory
from shutil import copy as copy_file
from subprocess import run
from PyQt5 import QtCore, QtWidgets, QtGui
from ModsManagerGUI import Ui_MainWindow
from os.path import join as os_join
from os.path import abspath as os_abspath
from os.path import dirname as os_dirname
from os.path import exists as os_exists
from os import remove as os_remove
from platform import system as os_name
from xml.dom import minidom


class ModsManager(QtWidgets.QMainWindow):
    """
    Class ModsManager
    Descrition:
        GUI application to manage farming simulator mods folders.
        * ModsManagerGUI.py is created from ModsManagerGUI.ui which was created using PyQT5
        * ModsManager (this class) shows and handles events for ModsManagerGUI
    """
    ############################################################################
    # PRIVATE MEMBER VARIABLES
    __APP_CONFIG = {}
    __APP_VERSION = '1.3.2'
    __APPLICATION_ROOT = None
    __APP_GUI = None
    __APPLICATION_HELP_FILE = None

    ############################################################################
    # PUBLIC READ ONLY PROPERTIES
    @property
    def Logger(self):
        return self.__LOGGER

    @property
    def ApplicationRoot(self):
        return self.__APPLICATION_ROOT

    ############################################################################
    # APPLICATION INITIALISATION
    def __init__(self, parent=None, verbose=False):
        """
        ModsManager.__init__()
        Description:
            GUI initialisation
            
        :param parent: 
        """
        QtWidgets.QWidget.__init__(self, parent)
        self.__APPLICATION_ROOT = os_dirname(os_abspath(__file__))
        self.__APPLICATION_HELP_FILE = os_abspath(os_join(self.__APPLICATION_ROOT, 'help/help.html'))
        self.__create_logger(verbose)
        self.__APP_GUI = Ui_MainWindow()
        self.__APP_GUI.setupUi(self)
        self.__APP_GUI.lstModFolders.viewport().installEventFilter(self)
        self.__APP_GUI.lstModsList.viewport().installEventFilter(self)
        # set app icon
        self.setWindowIcon(QtGui.QIcon(os_abspath(os_join(self.__APPLICATION_ROOT, 'icon\\tractor_red.ico'))))
        # create event handlers
        self.create_event_handlers()
        # read and set application options
        self.__set_options_on_init()
        # override application options from gameSettings.xml
        self.__set_override_values()
        # populate lists
        self.__APP_GUI.lstModFolders.setFocus()
        self.populate_mods_list()
        self.set_override_status_label()
        self.__update_config_ini()
        self.__APP_GUI.statusbar.showMessage("")

    def __set_override_values(self):
        """
        ModsManager.__set_override_values()
        Description:
            Sets the options to values read from the config.ini file.
            Called on start up by self.__init__()

        :return
        """
        override_values = None
        if self.__APP_CONFIG['PATHS']['GAME_SETTINGS_FILE']:
            # if path does not exist check under the user directory
            if not os.path.isdir(str(pathlib.PurePath(self.__APP_CONFIG['PATHS']['GAME_SETTINGS_FILE']).parent)):
                user_path = os_abspath(os_join(pathlib.Path.home(), str(pathlib.PurePath(
                    self.__APP_CONFIG['PATHS']['GAME_SETTINGS_FILE']).parent)))
                if os.path.isdir(user_path):
                    self.__APP_GUI.txtGamePath.setText(user_path)
                    self.__APP_CONFIG['PATHS']['GAME_SETTINGS_FILE'] = os_abspath(os_join(user_path,
                                                                                          'gameSettings.xml'))
                else:
                    self.__APP_GUI.txtGamePath.setText(str(pathlib.PurePath(
                        self.__APP_CONFIG['PATHS']['GAME_SETTINGS_FILE']).parent))
            else:
                self.__APP_GUI.txtGamePath.setText(str(pathlib.PurePath(
                    self.__APP_CONFIG['PATHS']['GAME_SETTINGS_FILE']).parent))
        if self.__APP_CONFIG['PATHS']['GAME_EXE']:
            self.__APP_GUI.txtGameExePath.setText(self.__APP_CONFIG['PATHS']['GAME_EXE'])
        # get override vales from gameSettings.xml
        override_values = self.__get_mod_override_values()
        if override_values:
            if "true" == override_values['ACTIVE_VALUE'].lower():
                self.__APP_GUI.mnuOptOverrideActive.setChecked(True)
            else:
                self.__APP_GUI.mnuOptOverrideActive.setChecked(False)
            self.__APP_GUI.txtModFolders.setText(str(pathlib.PurePath(override_values['DIRECTORY_VALUE']).parent))
        elif self.__APP_CONFIG['PATHS']['MOD_FOLDER_PATH']:
            self.__APP_GUI.txtModFolders.setText(self.__APP_CONFIG['PATHS']['MOD_FOLDER_PATH'])
        if self.__APP_GUI.lstModFolders.count():
            if override_values:
                items = self.__APP_GUI.lstModFolders.findItems(
                    pathlib.PurePath(override_values['DIRECTORY_VALUE']).name, QtCore.Qt.MatchExactly)
                if len(items) > 0:
                    self.__APP_GUI.lstModFolders.setCurrentItem(items[0])
            else:
                self.__APP_GUI.lstModFolders.setCurrentRow(0)
        # get override values from game.xml
        self.Logger.debug("Reading game.xml for <controls> value")
        game_xml = os_abspath(os_join(
            self.__APP_GUI.txtGamePath.text(),
            'game.xml'))
        try:
            xml_doc = minidom.parse(game_xml)
            collection = xml_doc.documentElement
            ctrl_node = collection.getElementsByTagName("controls")
            if 'true' == ("%s" % ctrl_node[0].firstChild.nodeValue).lower():
                self.__APP_GUI.mnuOptInGameConsole.setChecked(True)
            else:
                self.__APP_GUI.mnuOptInGameConsole.setChecked(False)
            self.__APP_CONFIG['OPTIONS']['IN_GAME_CONSOLE'] = str(self.__APP_GUI.mnuOptInGameConsole.isChecked())
        except Exception:
            self.Logger.error("Failed to read game.xml")
            self.__APP_GUI.statusbar.showMessage("Failed to read game.xml")

    def __set_options_on_init(self):
        """
        ModsManager.___set_options()
        Description:
            Sets the options to values read from the config.ini file.
            Called on start up by self.__init__()

        :return:
        """
        self.__APP_CONFIG = self.__read_config_file()
        # set the menu options
        if 'true'== self.__APP_CONFIG['OPTIONS']['LAUNCH_ON_DOUBLE_CLICK'].lower() or \
                'checked' == self.__APP_CONFIG['OPTIONS']['LAUNCH_ON_DOUBLE_CLICK'].lower():
            self.__APP_GUI.mnuOptClickToLaunch.setChecked(True)
        else:
            self.__APP_GUI.mnuOptClickToLaunch.setChecked(False)
        if 'true' == self.__APP_CONFIG['OPTIONS']['OVERRIDE_ACTIVE_VALUE'].lower() or \
                'checked' == self.__APP_CONFIG['OPTIONS']['OVERRIDE_ACTIVE_VALUE'].lower():
            self.__APP_GUI.mnuOptOverrideActive.setChecked(True)
        else:
            self.__APP_GUI.mnuOptOverrideActive.setChecked(False)
        if 'true' == self.__APP_CONFIG['OPTIONS']['ASK_BEFORE_UPDATING_XML'].lower() or \
                'checked' == self.__APP_CONFIG['OPTIONS']['ASK_BEFORE_UPDATING_XML'].lower():
            self.__APP_GUI.mnuOptAskBeforeUpdate.setChecked(True)
        else:
            self.__APP_GUI.mnuOptAskBeforeUpdate.setChecked(False)
        if 'true' == self.__APP_CONFIG['OPTIONS']['IN_GAME_CONSOLE'].lower() or \
                'checked' == self.__APP_CONFIG['OPTIONS']['IN_GAME_CONSOLE'].lower():
            self.__APP_GUI.mnuOptInGameConsole.setChecked(True)
        else:
            self.__APP_GUI.mnuOptInGameConsole.setChecked(False)
        if 'true' == self.__APP_CONFIG['OPTIONS']['LAUNCH_WITH_CHEATS'].lower() or \
                'checked' == self.__APP_CONFIG['OPTIONS']['LAUNCH_WITH_CHEATS'].lower():
            self.__APP_GUI.mnuOptLaunchWithCheats.setChecked(True)
        else:
            self.__APP_GUI.mnuOptLaunchWithCheats.setChecked(False)
        if 'true' == self.__APP_CONFIG['OPTIONS']['LAUNCH_WITH_RESTART'].lower() or \
                'checked' == self.__APP_CONFIG['OPTIONS']['LAUNCH_WITH_RESTART'].lower():
            self.__APP_GUI.mnuOptLaunchWithRestart.setChecked(True)
        else:
            self.__APP_GUI.mnuOptLaunchWithRestart.setChecked(False)

    def __read_config_file(self):
        """
        ModsManager.__read_config_file()
        Description:
            Read the config file and set values

        :return:
        """
        config = configparser.ConfigParser()
        config.read(os_abspath(os_join(self.__APPLICATION_ROOT, 'config.ini')))
        cfg_opts = {}
        for section in config.sections():
            self.Logger.debug("Parsing config file - %s" % section)
            cfg_opts[section] = {}
            options = config.options(section)
            for option in options:
                try:
                    cfg_opts[section][option.upper()] = config.get(section, option)
                    if cfg_opts[section][option.upper()] == -1:
                        print("skip: %s" % option)
                except:
                    print("exception on %s!" % option)
                    cfg_opts[section][option.upper()] = None
        return cfg_opts

    def set_override_status_label(self):
        """
        ModsManager.set_override_status_label()
        Description:
            Writes the current override status to lblOverrideStatus

        :return:
        """
        or_active = 'OFF'
        override_values = self.__get_mod_override_values()
        if 'true' == override_values['ACTIVE_VALUE'].lower():
            or_active = 'ON'
        self.Logger.debug("override active: %s - %s" % (or_active, override_values['DIRECTORY_VALUE']))
        self.__APP_GUI.lblOverrideStatus.setText("Mod Folder Override is %s - %s" % (
            or_active, override_values['DIRECTORY_VALUE']))

    def create_event_handlers(self):
        """
        ModsManager.create_event_handlers()
        Description:
            Creates the event handlers for interaction with the application UI

        :return:
        """
        # menu items
        self.__APP_GUI.mnuOpenGameFolder.triggered.connect(self.mnu_file_open_fs_directory)
        self.__APP_GUI.mnuOptClickToLaunch.triggered.connect(self.mnu_opt_click_to_launch_clicked)
        self.__APP_GUI.mnuOptOverrideActive.triggered.connect(self.mnu_opt_override_active_clicked)
        self.__APP_GUI.mnuOptAskBeforeUpdate.triggered.connect(self.mnu_opt_ask_before_update_clicked)
        self.__APP_GUI.mnuOptInGameConsole.triggered.connect(self.mnu_opt_ingame_console_clicked)
        self.__APP_GUI.mnuOptLaunchWithRestart.triggered.connect(self.mnu_opt_launch_with_restart_clicked)
        self.__APP_GUI.mnuOptLaunchWithCheats.triggered.connect(self.mnu_opt_launch_with_cheats_clicked)
        self.__APP_GUI.mnuModsAddFolder.triggered.connect(self.mnu_mods_add_folder)
        self.__APP_GUI.mnuModsRemoveFolder.triggered.connect(self.mnu_mods_remove_folder)
        self.__APP_GUI.mnuModsAddItem.triggered.connect(self.mnu_mods_add_item)
        self.__APP_GUI.mnuModsRemoveItem.triggered.connect(self.mnu_mods_remove_item)
        self.__APP_GUI.mnuModsCopyMods.triggered.connect(self.mnu_mods_copy_to_folder)
        self.__APP_GUI.mnuModsCopyToAll.triggered.connect(self.mnu_mods_copy_to_all)
        self.__APP_GUI.mnuModsOpenModDirectory.triggered.connect(self.mnu_mods_open_mods_folder)
        self.__APP_GUI.mnuHelpHelp.triggered.connect(self.mnu_help_clicked)
        self.__APP_GUI.mnuHelpAbout.triggered.connect(self.mnu_help_about_clicked)
        # menu shortcut keys
        self.__APP_GUI.mnFileExit.setShortcut('Ctrl+X')
        self.__APP_GUI.mnuHelpHelp.setShortcut('F1')
        self.__APP_GUI.mnuHelpAbout.setShortcut('Alt+A')
        # text widget
        self.__APP_GUI.txtModFolders.textChanged.connect(self.txt_mod_folder_path_changed)
        self.__APP_GUI.txtGamePath.textChanged.connect(self.txt_game_folder_path_changed)
        self.__APP_GUI.txtGameExePath.textChanged.connect(self.txt_game_exe_path_changed)
        # list widgets
        self.__APP_GUI.lstModFolders.itemClicked.connect(self.lst_mod_folders_clicked)
        self.__APP_GUI.lstModFolders.itemDoubleClicked.connect(self.lst_mod_folders_double_clicked)
        self.__APP_GUI.lstModsList.itemDoubleClicked.connect(self.lst_mods_list_double_clicked)
        self.__APP_GUI.lstModFolders.customContextMenuRequested.connect(self.lst_mod_folders_context_menu)
        self.__APP_GUI.lstModsList.customContextMenuRequested.connect(self.lst_mods_list_context_menus)
        # button widgets
        self.__APP_GUI.btnBrowseModPath.clicked.connect(self.btn_browse_mod_folder_clicked)
        self.__APP_GUI.btnBrowseGamePath.clicked.connect(self.btn_browse_game_folder_clicked)
        self.__APP_GUI.btnBrowseGameExe.clicked.connect(self.btn_browse_game_exe_clicked)
        self.__APP_GUI.btnLaunchFS22.clicked.connect(self.btn_launch_game_clicked)
        self.__APP_GUI.btnSetModPath.clicked.connect(self.btn_set_mod_folder_clicked)

    ############################################################################
    # EVENT HANDLERS

    def lst_mod_folders_context_menu(self, qpos):
        """
        ModsManager.mod_folders_context_menu()
        Description:
            Displays the popup menu over the headings list widget

        :param qpos:
        :return:
        """
        # create menu
        self.__MOD_FOLDERS_POPUP_MENU = QtWidgets.QMenu()
        add_mod_folder = self.__MOD_FOLDERS_POPUP_MENU.addAction("Add Mod Folder")
        remove_mod_folder = self.__MOD_FOLDERS_POPUP_MENU.addAction("Remove mod folder")
        copy_mod_to_folder = self.__MOD_FOLDERS_POPUP_MENU.addAction("Copy Mod to Selected Folder")

        # show menu
        selected_action = self.__MOD_FOLDERS_POPUP_MENU.exec_(self.__APP_GUI.lstModFolders.mapToGlobal(QtCore.QPoint(0, 0)))
        if selected_action == add_mod_folder:
            self.mnu_mods_add_folder()
        if selected_action == remove_mod_folder:
            self.mnu_mods_remove_folder()
        if selected_action == copy_mod_to_folder:
            self.mnu_mods_copy_to_folder()

    def lst_mod_folders_clicked(self):
        """
        ModsManager.mod_folders_clicked()
        Description:
            Display check list for currently selected heading

        :return:
        """
        self.populate_mods_list()
        self.__APP_GUI.statusbar.showMessage("")
        return

    def lst_mod_folders_double_clicked(self):
        """
        ModsManager.lst_mod_folders_double_clicked()
        Description:
            Set selected folder in gameGettings.xml and launch the game

        :return:
        """
        if self.__APP_GUI.mnuOptClickToLaunch.isChecked():
            if True == self.btn_set_mod_folder_clicked():
                self.btn_launch_game_clicked()
            else:
                self.__APP_GUI.statusbar.showMessage("GameSettings.xml NOT updated")

    def lst_mods_list_context_menus(self, qpos):
        """
        ModsManager.mods_list_context_menus()
        Description:
            Displays the popup menu over the check list widget

        :param qpos:
        :return:
        """
        # create menu
        self.__MODS_LIST_POPUP_MENU = QtWidgets.QMenu()
        add_item = self.__MODS_LIST_POPUP_MENU.addAction("Add Item")
        remove_item = self.__MODS_LIST_POPUP_MENU.addAction("Remove Item")

        # show menu
        selected_action = self.__MODS_LIST_POPUP_MENU.exec_(self.__APP_GUI.lstModsList.mapToGlobal(QtCore.QPoint(0, 0)))
        if selected_action == remove_item:
            self.mnu_mods_remove_item()
        if selected_action == add_item:
            self.mnu_mods_add_item()

    def lst_mods_list_double_clicked(self):
        """
        ModsManager.mods_list_double_clicked()
        Description:
            open mod zip file in its default application

        :return:
        """
        file_name = os_join(self.__APP_GUI.txtModFolders.text(), self.__APP_GUI.lstModFolders.currentItem().text(),
                            self.__APP_GUI.lstModsList.currentItem().text())
        if os.path.isfile(file_name):
            try:
                os.startfile(file_name, 'open')
            except Exception as e:
                self.Logger.error("Failed to show zip file\n%s" % e.message)
        self.__APP_GUI.statusbar.showMessage("")

    def mnu_file_open_fs_directory(self):
        """
        ModsManager.mnu_file_open_fs_directory()
        Description:
            Open the farming simulator installation directory

        :return:
        """
        try:
            if len(self.__APP_GUI.txtGamePath.text()):
                if os.path.isdir(self.__APP_GUI.txtGamePath.text()):
                    self.Logger.debug("Opening mods folder")
                    os.startfile(self.__APP_GUI.txtGamePath.text(), 'open')
        except OSError as e:
            self.Logger.error("Failed to open Mod directory\n\t%s" % e.filename)

    def mnu_opt_click_to_launch_clicked(self):
        """
        ModsManager.mnu_opt_click_to_launch_clicked()
        Description:
            Set option value

        :return:
        """
        self.__APP_CONFIG['OPTIONS']['LAUNCH_ON_DOUBLE_CLICK'] = str(self.__APP_GUI.mnuOptClickToLaunch.isChecked())
        self.__update_config_ini()

    def mnu_opt_override_active_clicked(self):
        """
        ModsManager.mnu_opt_override_active_clicked()
        Description:
            Set option value

        :return:
        """
        self.__APP_CONFIG['OPTIONS']['OVERRIDE_ACTIVE_VALUE'] = str(self.__APP_GUI.mnuOptOverrideActive.isChecked())
        self.__update_config_ini()
        self.__set_active_override_option()

    def mnu_opt_ask_before_update_clicked(self):
        """
        ModsManager.mnu_opt_ask_before_update_clicked()
        Description:
            Set option value

        :return:
        """
        self.__APP_CONFIG['OPTIONS']['ASK_BEFORE_UPDATING_XML'] = str(self.__APP_GUI.mnuOptAskBeforeUpdate.isChecked())
        self.__update_config_ini()

    def mnu_opt_ingame_console_clicked(self):
        """
        ModsManager.mnu_opt_ingame_console_clicked()
        Description:
            Set option value

        :return:
        """
        self.__APP_CONFIG['OPTIONS']['IN_GAME_CONSOLE'] = str(self.__APP_GUI.mnuOptInGameConsole.isChecked())
        self.__update_config_ini()
        self.set_launch_with_console_in_xml()

    def mnu_opt_launch_with_cheats_clicked(self):
        """
        ModsManager.mnu_opt_launch_with_cheats_clicked()
        Description:
            Set option value

        :return:
        """
        self.__APP_CONFIG['OPTIONS']['LAUNCH_WITH_CHEATS'] = str(self.__APP_GUI.mnuOptLaunchWithCheats.isChecked())
        self.__update_config_ini()

    def mnu_opt_launch_with_restart_clicked(self):
        """
        ModsManager.mnu_opt_launch_with_cheats_clicked()
        Description:
            Set option value

        :return:
        """
        self.__APP_CONFIG['OPTIONS']['LAUNCH_WITH_RESTART'] = str(self.__APP_GUI.mnuOptLaunchWithRestart.isChecked())
        self.__update_config_ini()

    def mnu_mods_add_folder(self):
        """
        ModsManager.mnu_mods_add_folder()
        Description:
            Create a new mods folder and add to list
            
        :return: 
        """
        mod_dir = QtWidgets.QFileDialog.getExistingDirectory(self, 'Create a new Folder',
                                                             self.__APP_GUI.txtModFolders.text())
        self.Logger.debug("Created new folder: %s" % mod_dir)
        if mod_dir:
            self.populate_mod_folders_list()
            if self.__APP_GUI.lstModFolders.count():
                items = self.__APP_GUI.lstModFolders.findItems(pathlib.PurePath(mod_dir).name, QtCore.Qt.MatchExactly)
                if len(items) > 0:
                    self.__APP_GUI.lstModFolders.setCurrentItem(items[0])
            self.populate_mods_list()
            self.__APP_GUI.lstModFolders.setFocus()
            self.__APP_GUI.statusbar.showMessage("Added folder %s" % pathlib.PurePath(mod_dir).name)

    def mnu_mods_remove_folder(self):
        """
        ModsManager.mnu_mods_remove_folder()
        Description:
            Delete selected folder and remove from list

        :return: 
        """
        try:
            remove_item = os_join(self.__APP_GUI.txtModFolders.text(),
                                  self.__APP_GUI.lstModFolders.currentItem().text())
            if self.__APP_GUI.lstModFolders.count() == 1:
                # This will remove folder and leave list empty
                if self.__ask_user(
                        "This will delete the folder and all of it contents. Are you sure you wish to remove %s?" %
                        pathlib.PurePath(remove_item).name):
                    self.__APP_GUI.txtModFolders.setText("")
                    self.__APP_GUI.lstModFolders.clear()
                    self.__APP_GUI.lstModsList.clear()
                    try:
                        remove_directory(remove_item)
                        self.__APP_GUI.statusbar.showMessage("Removed %s" % pathlib.PurePath(remove_item).name)
                        self.Logger.debug("Removing folder %s from list" % remove_item)
                    except Exception as er:
                        self.Logger.error(er.message)
            elif self.__APP_GUI.lstModFolders.count() > 1:
                # this will remove the folder from the list
                if self.__ask_user(
                        "This will delete the folder and all of it contents. Are you sure you wish to remove %s?" %
                        pathlib.PurePath(remove_item).name):
                    self.__APP_GUI.lstModFolders.takeItem(self.__APP_GUI.lstModFolders.currentRow())
                    self.populate_mods_list()
                    try:
                        remove_directory(remove_item)
                        self.__APP_GUI.statusbar.showMessage("Removed %s" % pathlib.PurePath(remove_item).name)
                        self.Logger.debug("Removing folder %s from list" % remove_item)
                    except Exception as er:
                        self.Logger.error(er.message)
        except Exception as e:
            if self.__APP_GUI.lstModFolders.count() <= 0:
                # all folders have been removed so clear the list
                self.__APP_GUI.lstModsList.clear()
        return True

    def mnu_mods_add_item(self):
        """
        ModsManager.mnu_mods_add_item()
        Description:
            Add an item to the mods list

        :return:
        """
        try:
            mod_file = QtWidgets.QFileDialog.getOpenFileName(
                self, 'Select mod file(s) to add', os_join(self.__APP_GUI.txtModFolders.text(),
                                                           self.__APP_GUI.lstModFolders.currentItem().text()))[0]
            dest_dir = os_join(self.__APP_GUI.txtModFolders.text(), self.__APP_GUI.lstModFolders.currentItem().text())
            check_path = os_join(dest_dir, pathlib.PurePath(mod_file).name)
            if len(mod_file):
                if os.path.isfile(mod_file) and os.path.isdir(dest_dir):
                    if os.path.isfile(check_path):
                        self.statusBar().showMessage("file %s already exists in directory" %
                                                     pathlib.PurePath(mod_file).name)
                    else:
                        copy_file(mod_file, dest_dir)
                        self.statusBar().showMessage("Added file %s to directory" % pathlib.PurePath(mod_file).name)
                        self.Logger.debug("Adding new mod zip file %s" % pathlib.PurePath(mod_file, mod_file).name)
                        self.populate_mods_list()
        except Exception as e:
            self.Logger.error(e.message)

    def mnu_mods_remove_item(self):
        """
        ModsManager.mnu_mods_remove_item()
        Description:
            Remove an item to the mods list

        :return:
        """
        del_mod = os_join(self.__APP_GUI.txtModFolders.text(), self.__APP_GUI.lstModFolders.currentItem().text(),
                          self.__APP_GUI.lstModsList.currentItem().text())
        if self.__ask_user(
                "This will delete the file. Are you sure you wish to remove %s?" %
                pathlib.PurePath(del_mod).name):
            self.Logger.debug("Removing %s from folder" % del_mod)
            if os.path.exists(del_mod):
                os.remove(del_mod)
                self.__APP_GUI.statusbar.showMessage("Deleted file %s" % pathlib.PurePath(del_mod).name)
                self.populate_mods_list()
            else:
                self.__APP_GUI.statusbar.showMessage("The file %s not found" % pathlib.PurePath(del_mod).name)
        return True

    def mnu_mods_copy_to_folder(self):
        """
        ModsManager.mnu_mods_copy_to_folder()
        Description:
            Copy mods to the selected folder

        :return:
        """
        self.Logger.debug("copy mods to folder")
        try:
            mod_files = QtWidgets.QFileDialog.getOpenFileNames(
                self, 'Select mod file(s) to copy', os_join(self.__APP_GUI.txtModFolders.text(),
                                                     self.__APP_GUI.lstModFolders.currentItem().text()))[0]
            dest_dir = os_join(self.__APP_GUI.txtModFolders.text(), self.__APP_GUI.lstModFolders.currentItem().text())
            if len(mod_files):
                for f in mod_files:
                    check_path = os_join(dest_dir, pathlib.PurePath(f).name)
                    if os.path.isfile(f) and os.path.isdir(dest_dir):
                        if os.path.isfile(check_path):
                            self.Logger.debug("file %s already exists in directory" % pathlib.PurePath(f).name)
                        else:
                            copy_file(f, dest_dir)
                            self.statusBar().showMessage("Added files to directory")
                            self.populate_mods_list()
                            self.Logger.debug("Copy %s to %s" % (f, dest_dir))
        except Exception as e:
            self.Logger.error(e.message)

    def mnu_mods_open_mods_folder(self):
        """
        ModsManager.mnu_mods_open_mods_folder()
        Description:
            Open the mods folder

        :return:
        """
        try:
            if len(self.__APP_GUI.txtModFolders.text()):
                if os.path.isdir(self.__APP_GUI.txtModFolders.text()):
                    self.Logger.debug("Opening mods folder")
                    os.startfile(self.__APP_GUI.txtModFolders.text(), 'open')
        except OSError as e:
            self.Logger.error("Failed to open Mod directory\n\t%s" % e.filename)

    def mnu_mods_copy_to_all(self):
        """
        ModsManager.mnu_mods_copy_to_all()
        Description:
            Copy mod(s) to ALL folders

        :return:
        """
        self.Logger.debug("Copy mod to ALL folders")
        try:
            mod_files = QtWidgets.QFileDialog.getOpenFileNames(
                self, 'Select mod file(s) to copy', os_join(self.__APP_GUI.txtModFolders.text(),
                                                            self.__APP_GUI.lstModFolders.currentItem().text()))[0]
            overwrite_file = False
            if self.__ask_user("Would you like to overwrite existing files?"):
                if self.__ask_user("Are you sure?"):
                    overwrite_file = True
            mod_dirs = [self.__APP_GUI.lstModFolders.item(x).text() for x in range(self.__APP_GUI.lstModFolders.count())]
            if len(mod_files):
                for f in mod_files:
                    if len(mod_dirs):
                        for d in mod_dirs:
                            mod_dir = str(os_abspath(os_join(self.__APP_GUI.txtModFolders.text(), d)))
                            check_file = os_join(mod_dir, pathlib.PurePath(f).name)
                            if os.path.isfile(f) and os.path.isdir(mod_dir):
                                if os.path.isfile(check_file) and not overwrite_file:
                                    # if mod file exists in mod directory DO NOT overwrite
                                    self.Logger.debug("file %s already exists in directory %s" % (pathlib.PurePath(f).name, d))
                                else:
                                    if str(pathlib.PurePath(f).parent) == mod_dir:
                                        self.Logger.debug("Ignoring copying to source directory")
                                    else:
                                        self.Logger.debug("Copying %s to %s" % (f, mod_dir))
                                        copy_file(f, mod_dir)
                                        self.populate_mods_list()
        except Exception as e:
            self.Logger.error(e.message)

    def mnu_help_clicked(self):
        """
        ModsManager.mnu_help_clicked()
        Description:
            Show the application help files
            
        :return: 
        """
        self.__APP_GUI.statusbar.showMessage("Show help files")
        tabs = 2  # open in a new tab, if possible
        url = "file://%s" % self.__APPLICATION_HELP_FILE
        webbrowser.open(url, new=tabs)
        self.__APP_GUI.statusbar.showMessage("")

    def mnu_help_about_clicked(self):
        """
        ModsManager.mnu_help_about_clicked()
        Description:
            Show application Help/About box
            
        :return: 
        """
        msg = QtWidgets.QMessageBox()
        msg.setIcon(QtWidgets.QMessageBox.Information)

        msg.setText("Mods Folder Manager V%s" % self.__APP_VERSION)
        msg.setInformativeText("Application to manage farming simulator mod folders")
        msg.setWindowTitle("About Mods Manager")
        msg.setDetailedText("""Copyright Richard Sayer 2022
Farming Simulator 22 Mods Folder Manager.
Creates, deletes and managers content of game/map specific mod folders to avoid mod confilcts and simplify multiplayer mod content.
This application will change the Farming Simulator 2022 file gameSettings.xml to override the mod folder location.

Written with python3 and QT5.""")
        msg.setStandardButtons(QtWidgets.QMessageBox.Ok)
        msg.exec_()
        self.__APP_GUI.statusbar.showMessage("")

    def txt_mod_folder_path_changed(self):
        """
        ModsManager.txt_mod_folder_path_changed()
        Description:
            Mod Folders path has changed so update mods list
            
        :return: 
        """
        self.populate_mod_folders_list()
        if self.__APP_GUI.lstModFolders.count():
            self.__APP_GUI.lstModFolders.setCurrentRow(0)
            self.__APP_GUI.lstModFolders.setFocus()
            self.populate_mods_list()
        self.__APP_GUI.statusbar.showMessage("")
        return

    def txt_game_folder_path_changed(self):
        """
        ModsManager.txt_game_folder_path_changed()
        Description:
            Game Folder path has changed

        :return:
        """
        try:
            file_name = pathlib.PurePath(self.__APP_CONFIG['PATHS']['GAME_SETTINGS_FILE']).name
            self.__APP_CONFIG['PATHS']["GAME_SETTINGS_FILE"] = os_abspath(os_join(self.__APP_GUI.txtGamePath.text(),
                                                                                  file_name))
            self.__update_config_ini()
            self.__APP_GUI.statusbar.showMessage("")
            self.Logger.debug("Settings file path changed: %s" % self.__APP_CONFIG['PATHS']["GAME_SETTINGS_FILE"])
        except Exception:
            return

    def txt_game_exe_path_changed(self):
        """
        ModsManager.txt_game_exe_path_changed()
        Description:
            Game exe file path has changed

        :return:
        """
        try:
            self.__APP_CONFIG['PATHS']["GAME_EXE"] = self.__APP_GUI.txtGameExePath.text()
            self.__update_config_ini()
            self.__APP_GUI.statusbar.showMessage("")
            self.Logger.debug("Game exe file path changed: %s" % self.__APP_CONFIG['PATHS']["GAME_EXE"])
        except Exception:
            return

    def btn_browse_mod_folder_clicked(self):
        """
        ModsManager.mod_folder_browse_clicked()
        Description:
            Open file dialog to browse for path
        :return:
        """
        folder_path = (QtWidgets.QFileDialog.getExistingDirectory(self, 'Select mod folder',
                                                                  self.__APP_GUI.txtModFolders.text()))
        if 'windows' == os_name().lower():
            folder_path = folder_path.replace('/', '\\')
        if folder_path:
            self.Logger.debug(folder_path)
            self.__APP_GUI.txtModFolders.setText(folder_path)
            self.__APP_CONFIG['PATHS']['MOD_FOLDER_PATH'] = folder_path
            self.__update_config_ini()
        self.__APP_GUI.statusbar.showMessage("")

    def btn_browse_game_folder_clicked(self):
        """
        ModsManager.game_folder_browse_clicked()
        Description:
            Open file dialog to browse for path

        :return:
        """
        folder_path = (QtWidgets.QFileDialog.getExistingDirectory(self, 'Select game installation folder',
                                                                  self.__APP_GUI.txtGamePath.text()))
        if 'windows' == os_name().lower():
            folder_path = folder_path.replace('/', '\\')
        if folder_path:
            self.Logger.debug("Game folder set to %s", folder_path)
            self.__APP_GUI.txtGamePath.setText(folder_path)
            self.__APP_CONFIG['PATHS']['GAME_SETTINGS_FILE'] = os_abspath(os_join(folder_path, 'gameSettings.xml'))
        self.__APP_GUI.statusbar.showMessage("")

    def btn_browse_game_exe_clicked(self):
        """
        ModsManager.btn_browse_game_exe_clicked()
        Description:
            Open file dialog to browse for game exe file

        :return:
        """
        exe_path = str(pathlib.PurePath(self.__APP_CONFIG['PATHS']['GAME_EXE']).parent)
        game_exe_file = (QtWidgets.QFileDialog.getOpenFileName(self, 'Select game exe file to launch', exe_path))[0]
        if 'windows' == os_name().lower():
            game_exe_file = game_exe_file.replace('/', '\\')
        if game_exe_file:
            self.Logger.debug("Game exe set to %s", game_exe_file)
            self.__APP_GUI.txtGameExePath.setText(game_exe_file)
            self.__APP_CONFIG['PATHS']['GAME_EXE'] = os_abspath(os_join(game_exe_file, 'gameSettings.xml'))
        self.__APP_GUI.statusbar.showMessage("")

    def btn_launch_game_clicked(self):
        """
        ModsManager.btn_launch_game_clicked()
        Description:
            Uses the subprocess run method to launch the game.

            There is a true/false value in the FS22 game.xml file that will enable the in game console.
            <development>
                <controls>false</controls>
                <openDevConsole onWarnings="false" onErrors="false"/>
            </development>
            You can also add the -cheats switch to the launch command enable the cheats in the in game console.

        :return:
        """
        launch_command = self.__APP_CONFIG['PATHS']['GAME_EXE']
        try:
            if self.__APP_GUI.mnuOptLaunchWithCheats.isChecked():
                launch_command = "%s -cheats" % launch_command
                self.Logger.debug("Launching game with cheats")
            if self.__APP_GUI.mnuOptLaunchWithRestart.isChecked():
                launch_command = "%s -restart" % launch_command
                self.Logger.debug("Launching game with restart")
            run(launch_command)
            self.Logger.debug("Launching game")
            self.__APP_GUI.statusbar.showMessage("Game started")
        except Exception as e:
            raise Exception("ERROR: Message: %s\nstrerror: %s" % (e.message, e.strerror))

    def btn_set_mod_folder_clicked(self):
        """
        ModsManager.set_mod_folder_button_clicked()
        Description:
            Update game settings XML attributes and write it to file

        :return:
        """
        # check ask flag
        update_file = False
        if self.__APP_GUI.mnuOptAskBeforeUpdate.isChecked():
            if self.__ask_user(
                    "This will overwrite the gameSettings.xml file.\nAre you sure you wish to continue"):
                update_file = True
            else:
                return False
        else:
            update_file = True
        # get xml doc and set attributes
        if True == update_file:
            # current GUI values
            active_value = str(self.__APP_GUI.mnuOptOverrideActive.isChecked()).lower()
            directory_value = os_abspath(os_join(self.__APP_GUI.txtModFolders.text(),
                                                 self.__APP_GUI.lstModFolders.currentItem().text()))
            try:
                xml_doc = minidom.parse(self.__APP_CONFIG['PATHS']["GAME_SETTINGS_FILE"])
                collection = xml_doc.documentElement
                override_values = collection.getElementsByTagName("modsDirectoryOverride")
                attr = override_values[0].attributes.getNamedItem('active')
                attr.value = active_value
                attr = override_values[0].attributes.getNamedItem('directory')
                attr.value = directory_value
                fout = open(self.__APP_CONFIG['PATHS']["GAME_SETTINGS_FILE"], 'w', encoding='UTF-8')
                xml_doc.writexml(fout, encoding='UTF-8')
                fout.close()
                self.__APP_GUI.statusbar.showMessage("Game settings XML updated")
            except Exception:
                self.Logger.error("Failed to update xml %s" % self.__APP_CONFIG['PATHS']["GAME_SETTINGS_FILE"])
                self.__APP_GUI.statusbar.showMessage("Failed to update XML")
            self.Logger.debug("Set xml values\n\tactive = %s\n\tdirectory = %s", active_value, directory_value)
            self.set_override_status_label()
            return True

    ############################################################################
    # PUBLIC METHODS

    def set_launch_with_console_in_xml(self):
        """
        ModsManager.set_launch_with_console_in_xml()
        Description:
            Updates the game.xml file <control> attribute

        :return:
        """
        game_xml = os_abspath(os_join(
            self.__APP_GUI.txtGamePath.text(),
            'game.xml'))
        control_node_value = str(self.__APP_GUI.mnuOptInGameConsole.isChecked()).lower()
        try:
            xml_doc = minidom.parse(game_xml)
            collection = xml_doc.documentElement
            ctrl_node = collection.getElementsByTagName("controls")
            ctrl_node[0].firstChild.replaceWholeText(control_node_value)
            self.Logger.debug("Updating %s\n\t <control>%s</control>" % (game_xml, ctrl_node[0].firstChild.nodeValue))
            fout = open(game_xml, 'w', encoding='UTF-8')
            xml_doc.writexml(fout, encoding='UTF-8')
            fout.close()
            self.__APP_GUI.statusbar.showMessage("game.xml updated")
        except Exception:
            self.Logger.error("Failed to update game.xml")
            self.__APP_GUI.statusbar.showMessage("Failed to update game.xml")
        return True

    def populate_mod_folders_list(self):
        """
        ModsManager.populate_mods_list()
        Description:
            Populate the mod folders list form the path in the mod folders text box

        :return:
        """
        # self.Logger.debug("Mod folder path: %s" % self.__APP_GUI.txtModFolders.text())
        if os.path.isdir(self.__APP_GUI.txtModFolders.text()):
            if self.__APP_GUI.lstModFolders.count() != 0:
                self.__APP_GUI.lstModFolders.clear()
            for d in os.listdir(self.__APP_GUI.txtModFolders.text()):
                if os.path.isdir(os_join(self.__APP_GUI.txtModFolders.text(), d)):
                    self.__APP_GUI.lstModFolders.addItem(QtWidgets.QListWidgetItem(d))
        self.__APP_GUI.lblModFolderCount.setText("%s Mod Folders" % str(self.__APP_GUI.lstModFolders.count()))
        self.__APP_GUI.statusbar.showMessage("")

    def populate_mods_list(self):
        """
        ModsManager.populate_mods_list()
        Description:
            Populate the mod folders list from the selected mod folder

        :return:
        """
        try:
            # self.Logger.debug("Mod folder path: %s" % os_abspath(
            #     os_join(self.__APP_GUI.txtModFolders.text(), self.__APP_GUI.lstModFolders.currentItem().text())))
            if self.__APP_GUI.lstModsList.count():
                self.__APP_GUI.lstModsList.clear()
            selected_dir = os_abspath(os_join(self.__APP_GUI.txtModFolders.text(),
                                              self.__APP_GUI.lstModFolders.currentItem().text()))
            if os.path.isdir(selected_dir):
                if os.listdir(selected_dir):
                    for f in os.listdir(selected_dir):
                        self.__APP_GUI.lstModsList.addItem(QtWidgets.QListWidgetItem(f))
            self.__APP_GUI.lstModsList.setCurrentRow(0)
            self.__APP_GUI.lblModsListCount.setText("%s Mod Files" % str(self.__APP_GUI.lstModsList.count()))
            self.__APP_GUI.statusbar.showMessage("")
        except Exception as e:
            self.Logger.error("Failed to populate mod list")

    ############################################################################
    # PRIVATE METHODS

    def __set_active_override_option(self):
        """
        ModsManager.__set_active_override_option()
        Description:
            Update game settings XML attribute modsDirectoryOverride

        :return:
        """
        # check ask flag
        update_file = False
        if self.__APP_GUI.mnuOptAskBeforeUpdate.isChecked():
            if self.__ask_user(
                    "This will overwrite the gameSettings.xml file.\nAre you sure you wish to continue"):
                update_file = True
            else:
                return False
        else:
            update_file = True
        # get xml doc and set attributes
        if True == update_file:
            # current GUI values
            active_value = str(self.__APP_GUI.mnuOptOverrideActive.isChecked()).lower()
            try:
                xml_doc = minidom.parse(self.__APP_CONFIG['PATHS']["GAME_SETTINGS_FILE"])
                collection = xml_doc.documentElement
                override_values = collection.getElementsByTagName("modsDirectoryOverride")
                attr = override_values[0].attributes.getNamedItem('active')
                attr.value = active_value
                # write updated xml to file
                fout = open(self.__APP_CONFIG['PATHS']["GAME_SETTINGS_FILE"], 'w', encoding='UTF-8')
                xml_doc.writexml(fout, encoding='UTF-8')
                fout.close()
                self.__APP_GUI.statusbar.showMessage("Game settings XML updated")
            except Exception:
                self.Logger.error("Failed to update xml")
                self.__APP_GUI.statusbar.showMessage("Failed to update XML")
            self.Logger.debug("Set xml values\n\tactive = %s", active_value)
            self.set_override_status_label()
            return True

    def __update_config_ini(self):
        """
        ModsManager.__update_config_ini_option()
        Description:
            writes the current application options to the config.ini file

        :return:
        """
        # create configparser data structure
        config = configparser.ConfigParser()
        for section in self.__APP_CONFIG:
            config[str(section).upper()] = {}
            for option in self.__APP_CONFIG[section]:
                config[section][str(option).upper()] = self.__APP_CONFIG[section][option]
                self.Logger.debug("[%s]%s=%s" %(section, option, self.__APP_CONFIG[section][option]))
        self.Logger.debug("Writing option to config.ini file")
        try:
            with open(os_abspath(os_join(self.__APPLICATION_ROOT, 'config.ini')), 'w') as configfile:
                config.write(configfile)
        except OSError as e:
            self.Logger.error("Error writing to: %s" % e.filename)
            return False
        return True

    def __get_mod_override_values(self):
        """
        ModsManager.__get_mod_override_values()
        Description:
            Open game settings xml file and read values

        :return: active_value and directory_path as strings
        """
        try:
            xml_doc = minidom.parse(self.__APP_CONFIG['PATHS']["GAME_SETTINGS_FILE"])
            override_value = xml_doc.getElementsByTagName("modsDirectoryOverride")
            active_value = None
            directory_value = None
            for val in override_value:
                active_value = val.getAttribute('active')
                directory_value = val.getAttribute('directory')
            if active_value and directory_value:
                self.Logger.debug("Getting xml values\n\tactive = %s\n\tdirectory = %s", active_value, directory_value)
                return {'ACTIVE_VALUE': active_value,
                        'DIRECTORY_VALUE': directory_value}
        except OSError as e:
            self.Logger.error("Unable to read %s" % e.filename)
            return False

    def __ask_user(self, question):
        """
        ModsManager.__ask_user()
        Description:
            Ask the user a question and get the yes/no response

        :param question:
        :return:
        """
        if not question:
            question = "No question recieved!!!!"
        # show message box
        reply = QtWidgets.QMessageBox.question(self, 'Asking User', question,
                                               QtWidgets.QMessageBox.Yes, QtWidgets.QMessageBox.No)
        if reply == QtWidgets.QMessageBox.Yes:
            return True
        return False

    def __get_text_input(self, title, prompt, default_value=""):
        """
        ModsManager.__get_text_input()
        Description:
            Use the input box to get text input from the user
            
        :param title:
        :param prompt:
        :param default_value:
        :return:
        """
        text, ok = QtWidgets.QInputDialog().getText(self, title, prompt, text=default_value)
        if ok:
            return "%s" % text
        return None

    def __edit_item_text(self, title, prompt, text):
        """
        ModsManager.__edit_item_text()
        Description:
            Edit the text given using the QInputDialog box)
            
        :param text: 
        :return: 
        """
        text, ok = QtWidgets.QInputDialog().getText(self, title, prompt, text=text)
        if ok:
            return text
        return None

    def __create_logger(self, verbose=False):
        """
        ModsManager.__create_logger()
        Description:
            Create a logging object for both stdout and a log file
        """
        logger_name = 'LoggerModsManager'
        log_file = os_join(self.ApplicationRoot, 'ModsManager.log')
        try:
            # first remove the log file if it already exists otherwise it will append to it
            if os_exists(log_file):
                os_remove(log_file)
            # set log level
            if verbose:
                log_level = logging.DEBUG
            else:
                log_level = logging.INFO
            # create logger
            self.__LOGGER = logging.getLogger(logger_name)
            # remove handlers if they already exist
            for h in list(self.__LOGGER.handlers):
                self.__LOGGER.info('removing handler %s' % str(h))
                self.__LOGGER.removeHandler(h)
            self.__LOGGER.setLevel(log_level)
            formatter = logging.Formatter('%(levelname)s:%(message)s')
            # Setup console logging
            ch = logging.StreamHandler()
            ch.setLevel(log_level)
            ch.setFormatter(formatter)
            self.__LOGGER.addHandler(ch)
            # Setup file logging as well
            fh = logging.FileHandler(log_file)
            fh.setLevel(log_level)
            fh.setFormatter(formatter)
            self.__LOGGER.addHandler(fh)
            self.__LOGGER.debug('Created log file %s' % log_file)
        except (OSError, IOError) as e:
            raise Exception("ERROR: Logger creation failed\nMessage: %s\nstrerror: %s" % (e.message, e.strerror))
# End of class ModsManager


if __name__ == "__main__":
    import sys
    import argparse

    parser = argparse.ArgumentParser()
    parser.add_argument('--verbose', action='store_true', default=False, help='Switch on verbose messages')
    args = parser.parse_args()

    app = QtWidgets.QApplication(sys.argv)
    myapp = ModsManager(verbose=args.verbose)
    myapp.show()
    sys.exit(app.exec_())
