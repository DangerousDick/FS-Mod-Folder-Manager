#!/usr/bin/python
# Author Richard Sayer
# Copyright (c) 2022 Richard Sayer

import logging
import webbrowser
import configparser
import os
from PyQt5 import QtCore, QtWidgets
from EditorGUI import Ui_MainWindow
from os.path import join as os_join
from os.path import abspath as os_abspath
from os.path import dirname as os_dirname
from os.path import exists as os_exists
from os import remove as os_remove
from platform import system as os_name


class ModsPathEditor(QtWidgets.QMainWindow):
    """
    Class ModsPathEditor
    Descrition:
        GUI application to manage farming simulator mods folders.
        * EditorGUI.py is created from EditorGUI.ui which was created using PyQT5
        * ModsPathEditor (this class) shows and handles events for EditorGUI
    """
    ############################################################################
    # PRIVATE MEMBER VARIABLES
    __APP_CONFIG = None
    __APP_VERSION = '3.0'
    __APPLICATION_ROOT = None
    __APP_GUI = None
    __FILE_OPEN_IN_PROGRESS = None
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
        ModsPathEditor.__init__()
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
        self.create_event_handlers()
        self.__FILE_OPEN_IN_PROGRESS = False
        #####################################
        # app icon workaround for Win7 #####
        if 'windows' == os_name().lower():
            import ctypes
            my_app_id = u'InitEditApp'  # arbitrary string
            ctypes.windll.shell32.SetCurrentProcessExplicitAppUserModelID(my_app_id)
        # end of workaround
        #####################################
        # set default paths
        self.__APP_CONFIG = self.__read_config_file()
        for key in self.__APP_CONFIG:
            self.Logger.debug("%s = %s", key, self.__APP_CONFIG[key])
            if self.__APP_CONFIG['MOD_FOLDER_PATH']:
                self.__APP_GUI.txtModFolders.setText(self.__APP_CONFIG['MOD_FOLDER_PATH'])
            if self.__APP_CONFIG['GAME_INSTALLATION_PATH']:
                self.__APP_GUI.txtGamePath.setText(self.__APP_CONFIG['GAME_INSTALLATION_PATH'])
        # set selected folder as top of list
        if self.__APP_GUI.lstModFolders.count():
            self.__APP_GUI.lstModFolders.setCurrentRow(0)
        self.__APP_GUI.lstModFolders.setFocus()
        self.populate_mods_list()

    def __read_config_file(self):
        """
                ModsPathEditor.__read_config_file()
                Description:
                    Read the config file and set values

                :return:
        """
        config = configparser.ConfigParser()
        config.read(os_abspath(os_join(self.__APPLICATION_ROOT, 'config.ini')))
        for section in config.sections():
            self.Logger.debug("Parsing config file - %s" % section)
            dict1 = {}
            options = config.options(section)
            for option in options:
                try:
                    dict1[option.upper()] = config.get(section, option)
                    if dict1[option.upper()] == -1:
                        print("skip: %s" % option)
                except:
                    print("exception on %s!" % option)
                    dict1[option.upper()] = None
            return dict1

    def create_event_handlers(self):
        """
        ModsPathEditor.create_event_handlers()
        Description:
            Creates the event handlers for interaction with the application UI

        :return:
        """
        # menu items
        self.__APP_GUI.mnuModsAddFolder.triggered.connect(self.mnu_mods_add_folder)
        self.__APP_GUI.mnuModsRemoveFolder.triggered.connect(self.mnu_mods_remove_folder)
        self.__APP_GUI.mnuModsAddItem.triggered.connect(self.mnu_mods_add_item)
        self.__APP_GUI.mnuModsRemoveItem.triggered.connect(self.mnu_mods_remove_item)

        #
        self.__APP_GUI.mnuHelpHelp.triggered.connect(self.mnu_help_clicked)
        self.__APP_GUI.mnuHelpAbout.triggered.connect(self.mnu_help_about_clicked)

        # menu shortcut keys
        self.__APP_GUI.mnFileExit.setShortcut('Ctrl+X')
        self.__APP_GUI.mnuHelpHelp.setShortcut('F1')
        self.__APP_GUI.mnuHelpAbout.setShortcut('Alt+A')
        # text widget
        self.__APP_GUI.txtModFolders.textChanged.connect(self.txt_mod_folder_path_changed)
        self.__APP_GUI.txtGamePath.textChanged.connect(self.txt_game_folder_path_changed)
        # list widgets
        self.__APP_GUI.lstModFolders.itemClicked.connect(self.mod_folders_clicked)
        self.__APP_GUI.lstModFolders.customContextMenuRequested.connect(self.mod_folders_context_menu)
        self.__APP_GUI.lstModsList.itemDoubleClicked.connect(self.mods_list_double_clicked)
        self.__APP_GUI.lstModsList.customContextMenuRequested.connect(self.mods_list_context_menus)
        # button widgets
        self.__APP_GUI.btnBrowseModPath.clicked.connect(self.mod_folder_browse_clicked)
        self.__APP_GUI.btnBrowseGamePath.clicked.connect(self.game_folder_browse_clicked)

    ############################################################################
    # EVENT OVERRIDES
    

    ############################################################################
    # EVENT HANDLERS
    def eventFilter(self, source, event):
        """
        ModsPathEditor.eventFilter
        Description:
            Catches drop events in the list boxes and marks the document as dirty
        
        :param source: 
        :param event: 
        :return: 
        """
        # for the headings QListWidget
        if event.type() == QtCore.QEvent.Drop and source is self.__APP_GUI.lstModFolders.viewport():
            self.__APP_GUI.lstModFolders.dropEvent(event)
            if event.isAccepted():
                self.mod_folders_drop_item()
            return True
        # for the check list QListWidget
        if event.type() == QtCore.QEvent.Drop and source is self.__APP_GUI.lstModsList.viewport():
            self.__APP_GUI.lstModsList.dropEvent(event)
            if event.isAccepted():
                self.mods_list_drop_item()
            return True
        return QtWidgets.QMainWindow.eventFilter(self, source, event)

    def populate_mod_folders_list(self):
        """
        ModsPathEditor.populate_mods_list()
        Description:
            Populate the mod folders list form the path in the mod folders text box

        :return:
        """
        if os.path.isdir(self.__APP_GUI.txtModFolders.text()):
            if self.__APP_GUI.lstModFolders.count() != 0:
                self.__APP_GUI.lstModFolders.clear()
            for d in os.listdir(self.__APP_GUI.txtModFolders.text()):
                self.__APP_GUI.lstModFolders.addItem(QtWidgets.QListWidgetItem(d))
        return

    def populate_mods_list(self):
        """
        ModsPathEditor.populate_mods_list()
        Description:
            Populate the mod folders list from the selected mod folder

        :return:
        """
        if self.__APP_GUI.lstModsList.count():
             self.__APP_GUI.lstModsList.clear()
        selected_dir = os_abspath(os_join(self.__APP_GUI.txtModFolders.text(),
                                          self.__APP_GUI.lstModFolders.currentItem().text()))
        if os.path.isdir(selected_dir):
            for d in os.listdir(selected_dir):
                self.__APP_GUI.lstModsList.addItem(QtWidgets.QListWidgetItem(d))
        return

    def mod_folders_context_menu(self, qpos):
        """
        ModsPathEditor.mod_folders_context_menu()
        Description:
            Displays the popup menu over the headings list widget
            
        :param qpos: 
        :return: 
        """
        # create menu
        self.__MOD_FOLDERS_POPUP_MENU = QtWidgets.QMenu()
        add_mod_folder = self.__MOD_FOLDERS_POPUP_MENU.addAction("Add Mod Folder")
        remove_mod_folder = self.__MOD_FOLDERS_POPUP_MENU.addAction("Remove mod folder")

        # show menu
        selected_action = self.__MOD_FOLDERS_POPUP_MENU.exec_(self.__APP_GUI.lstModFolders.mapToGlobal(QtCore.QPoint(0, 0)))
        if selected_action == add_mod_folder:
            self.mnu_mods_add_folder()
        if selected_action == remove_mod_folder:
            self.mnu_mods_remove_folder()

    def mods_list_context_menus(self, qpos):
        """
        ModsPathEditor.mods_list_context_menus()
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
        if selected_action == add_item:
            self.mnu_mods_add_item()
        if selected_action == remove_item:
            self.mnu_mods_remove_item()

    def mnu_mods_add_folder(self):
        """
        ModsPathEditor.mnu_mods_add_folder()
        Description:
            Create a new mods folder and add to list
            
        :return: 
        """
        self.add_mod_folder()
        return True

    def mnu_mods_remove_folder(self):
        """
        ModsPathEditor.mnu_mods_remove_folder()
        Description:
            Delete selected folder and remove from list

        :return: 
        """
        self.remove_mod_folder()
        return True

    def mnu_mods_add_item(self):
        """
        ModsPathEditor.mnu_mods_add_item()
        Description:
            Add an item to the mods list

        :return:
        """
        self.Logger.debug("TODO: Add mnu_mods_add_item functionality")
        return True

    def mnu_mods_remove_item(self):
        """
        ModsPathEditor.mnu_mods_remove_item()
        Description:
            Remove an item to the mods list

        :return:
        """
        self.Logger.debug("TODO: Add mnu_mods_remove_item functionality")
        return True

    def mnu_help_clicked(self):
        """
        ModsPathEditor.mnu_help_clicked()
        Description:
            Show the application help files
            
        :return: 
        """
        self.__APP_GUI.statusbar.showMessage("Show help files")
        tabs = 2  # open in a new tab, if possible
        url = "file://%s" % self.__APPLICATION_HELP_FILE
        webbrowser.open(url, new=tabs)

    def mnu_help_about_clicked(self):
        """
        ModsPathEditor.mnu_help_about_clicked()
        Description:
            Show application Help/About box
            
        :return: 
        """
        msg = QtWidgets.QMessageBox()
        msg.setIcon(QtWidgets.QMessageBox.Information)

        msg.setText("Mods Folder Editor V%s" % self.__APP_VERSION)
        msg.setInformativeText("Application to manage farming simulator mod folder location")
        msg.setWindowTitle("About Mods Path Editor")
        msg.setDetailedText("Email: richard@rasayer.uk\nCopyright Richard Sayer 2022")
        msg.setStandardButtons(QtWidgets.QMessageBox.Ok)
        msg.exec_()

    def txt_mod_folder_path_changed(self):
        """
        ModsPathEditor.txt_mod_folder_path_changed()
        Description:
            Mod Folders path has changed so update mods list
            
        :return: 
        """
        self.populate_mod_folders_list()
        if self.__APP_GUI.lstModFolders.count():
            self.__APP_GUI.lstModFolders.setCurrentRow(0)
        self.__APP_GUI.lstModFolders.setFocus()
        self.populate_mods_list()
        return

    def txt_game_folder_path_changed(self):
        """
        ModsPathEditor.txt_game_folder_path_changed()
        Description:
            Game Folder path has changed

        :return:
        """
        self.Logger.debug("TODO: Add txt_game_folder_path_changed functionality")
        return True

    def mod_folders_clicked(self):
        """
        ModsPathEditor.mod_folders_clicked()
        Description:
            Display check list for currently selected heading
            
        :return: 
        """
        self.populate_mods_list()
        return

    def mods_list_double_clicked(self):
        """
        ModsPathEditor.mods_list_double_clicked()
        Description:
            open mod zip file in its default application
            
        :return: 
        """
        self.show_mod_list_item()

    def add_mod_folder(self):
        """
        ModsPathEditor.add_mod_folder()
        Description:
            Add a new heading to the document

        :return: 
        """
        try:
            item = self.__get_text_input("Add Folder Name", "Please enter a folder name")
            if item:
                self.__APP_GUI.lstModFolders.addItem(("%s" % item).upper())
                self.__APP_GUI.lstModFolders.setCurrentRow(self.__APP_GUI.lstModFolders.count() - 1)
                self.Logger.debug("TODO: Create a new folder %s" % item)
        except Exception as e:
            self.Logger.error("FAILED TO ADD MOD FOLDER TO LIST: %s" % e.message)

    def remove_mod_folder(self):
        """
        ModsPathEditor.remove_mod_folder()
        Description:
            Remove the currently selected mod folder

        :return: 
        """
        try:
            # TODO: ADD REMOVE ITEM FUNTIONALITY
            remove_item = "%s" % self.__APP_GUI.lstModFolders.currentItem().text()
            if self.__APP_GUI.lstModFolders.count() <= 1:
                # This will leave folder and list empty
                if self.__ask_user("This will delete the folder from disk are you sure you wish to continue?"):
                    # os_remove("%s" % self.CurrentDocument.FileName)
                    # self.__APP_GUI.txtModFolders.setText("")
                    # self.__APP_GUI.lstModFolders.clear()
                    # self.__APP_GUI.lstModsList.clear()
                    # self.setWindowTitle("Check List Editor")
                    # self.mnu_file_open_clicked()
                    self.Logger.debug("TODO: Remove folder %s from list" % remove_item)
                    return True
            else:
                # this will remove the folder from the list
                if self.__ask_user("Are you sure you want to remove: %s?" % remove_item):
                    # result = self.CurrentDocument.remove_mod_folder(remove_item)
                    # if result['RESULT']:
                    #     self.__APP_GUI.lstModFolders.takeItem(self.__APP_GUI.lstModFolders.currentRow())
                    #     self.__show_mods_list()
                    #    self.__APP_GUI.statusbar.showMessage("Removed %s" % remove_item)
                    #     self.CurrentDocument.isDocumentDirty = True
                    # else:
                    #    self.__APP_GUI.statusbar.showMessage(result['MESSAGE'])
                    self.Logger.debug("TODO: Remove folder %s from list" % remove_item)
                    return True
        except Exception as e:
            if self.__APP_GUI.lstModFolders.count() <= 0:
                # all folders have been removed so clear the list
                self.__APP_GUI.lstModsList.clear()

    def show_mod_list_item(self):
        """
        ModsPathEditor.show_mod_list_item()
        Description:
            Show input box to get new text and update the document

        :return: 
        """
        try:
            # TODO: open mod in default zip application
            return True
        except Exception as e:
            self.Logger.error("FAILED TO SHOW LIST ITEM: %s" % e.message)

    def mod_folder_browse_clicked(self):
        """
        ModsPathEditor.mod_folder_browse_clicked()
        Description:
            Open file dialog to browse for path
        :return:
        """
        folder_path = (QtWidgets.QFileDialog.getExistingDirectory(self, 'Select Folder',
                                                                  self.__APP_GUI.txtModFolders.text()))
        if folder_path:
            print(folder_path)
            self.__APP_GUI.txtModFolders.setText(folder_path)
        return True

    def game_folder_browse_clicked(self):
        """
                ModsPathEditor.game_folder_browse_clicked()
                Description:
                    Open file dialog to browse for path

                :return:
                """
        # TODO: ADD GAME FOLDER BROWSE FUNCTIONALITY
        self.Logger.debug("TODO: Game folder browse event")
        return True

    def __ask_user(self, question):
        """
        ModsPathEditor.__ask_user()
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
        ModsPathEditor.__get_text_input()
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
        ModsPathEditor.__edit_item_text()
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
        ModsPathEditor.__create_logger()
        Description:
            Create a logging object for both stdout and a log file
        """
        logger_name = 'LoggerModsPathEditor'
        log_file = os_join(self.ApplicationRoot, 'ModsPathEditor.log')
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
# End of class ModsPathEditor


if __name__ == "__main__":
    import sys
    import argparse

    parser = argparse.ArgumentParser()
    parser.add_argument('--verbose', action='store_true', default=False, help='Switch on verbose messages')
    args = parser.parse_args()

    app = QtWidgets.QApplication(sys.argv)
    myapp = ModsPathEditor(verbose=args.verbose)
    myapp.show()
    sys.exit(app.exec_())
