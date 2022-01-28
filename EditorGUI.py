# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'EditorGUI.ui'
#
# Created by: PyQt5 UI code generator 5.12.3
#
# WARNING! All changes made in this file will be lost!


from PyQt5 import QtCore, QtGui, QtWidgets


class Ui_MainWindow(object):
    def setupUi(self, MainWindow):
        MainWindow.setObjectName("MainWindow")
        MainWindow.resize(590, 555)
        icon = QtGui.QIcon()
        icon.addPixmap(QtGui.QPixmap("icon/icon_16x16.gif"), QtGui.QIcon.Normal, QtGui.QIcon.Off)
        MainWindow.setWindowIcon(icon)
        self.centralwidget = QtWidgets.QWidget(MainWindow)
        self.centralwidget.setObjectName("centralwidget")
        self.verticalLayout = QtWidgets.QVBoxLayout(self.centralwidget)
        self.verticalLayout.setObjectName("verticalLayout")
        self.fmeModFolders = QtWidgets.QFrame(self.centralwidget)
        self.fmeModFolders.setFrameShape(QtWidgets.QFrame.StyledPanel)
        self.fmeModFolders.setFrameShadow(QtWidgets.QFrame.Raised)
        self.fmeModFolders.setObjectName("fmeModFolders")
        self.horizontalLayout_2 = QtWidgets.QHBoxLayout(self.fmeModFolders)
        self.horizontalLayout_2.setObjectName("horizontalLayout_2")
        self.lblModFolders = QtWidgets.QLabel(self.fmeModFolders)
        self.lblModFolders.setObjectName("lblModFolders")
        self.horizontalLayout_2.addWidget(self.lblModFolders)
        self.txtModFolders = QtWidgets.QLineEdit(self.fmeModFolders)
        self.txtModFolders.setReadOnly(True)
        self.txtModFolders.setObjectName("txtModFolders")
        self.horizontalLayout_2.addWidget(self.txtModFolders)
        self.btnBrowseModPath = QtWidgets.QPushButton(self.fmeModFolders)
        self.btnBrowseModPath.setObjectName("btnBrowseModPath")
        self.horizontalLayout_2.addWidget(self.btnBrowseModPath)
        self.verticalLayout.addWidget(self.fmeModFolders)
        self.fmeGamePath = QtWidgets.QFrame(self.centralwidget)
        self.fmeGamePath.setMinimumSize(QtCore.QSize(0, 43))
        self.fmeGamePath.setFrameShape(QtWidgets.QFrame.StyledPanel)
        self.fmeGamePath.setFrameShadow(QtWidgets.QFrame.Raised)
        self.fmeGamePath.setObjectName("fmeGamePath")
        self.horizontalLayout_3 = QtWidgets.QHBoxLayout(self.fmeGamePath)
        self.horizontalLayout_3.setObjectName("horizontalLayout_3")
        self.lblGamePath = QtWidgets.QLabel(self.fmeGamePath)
        self.lblGamePath.setObjectName("lblGamePath")
        self.horizontalLayout_3.addWidget(self.lblGamePath)
        self.txtGamePath = QtWidgets.QLineEdit(self.fmeGamePath)
        self.txtGamePath.setReadOnly(True)
        self.txtGamePath.setObjectName("txtGamePath")
        self.horizontalLayout_3.addWidget(self.txtGamePath)
        self.btnBrowseGamePath = QtWidgets.QPushButton(self.fmeGamePath)
        self.btnBrowseGamePath.setObjectName("btnBrowseGamePath")
        self.horizontalLayout_3.addWidget(self.btnBrowseGamePath)
        self.verticalLayout.addWidget(self.fmeGamePath)
        self.fmeLists = QtWidgets.QFrame(self.centralwidget)
        self.fmeLists.setFrameShape(QtWidgets.QFrame.StyledPanel)
        self.fmeLists.setFrameShadow(QtWidgets.QFrame.Raised)
        self.fmeLists.setObjectName("fmeLists")
        self.horizontalLayout = QtWidgets.QHBoxLayout(self.fmeLists)
        self.horizontalLayout.setObjectName("horizontalLayout")
        self.grpModFolders = QtWidgets.QGroupBox(self.fmeLists)
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Maximum, QtWidgets.QSizePolicy.Preferred)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(self.grpModFolders.sizePolicy().hasHeightForWidth())
        self.grpModFolders.setSizePolicy(sizePolicy)
        self.grpModFolders.setObjectName("grpModFolders")
        self.verticalLayout_2 = QtWidgets.QVBoxLayout(self.grpModFolders)
        self.verticalLayout_2.setObjectName("verticalLayout_2")
        self.lstModFolders = QtWidgets.QListWidget(self.grpModFolders)
        font = QtGui.QFont()
        font.setFamily("Courier New")
        self.lstModFolders.setFont(font)
        self.lstModFolders.setContextMenuPolicy(QtCore.Qt.CustomContextMenu)
        self.lstModFolders.setAcceptDrops(False)
        self.lstModFolders.setDragEnabled(False)
        self.lstModFolders.setDragDropMode(QtWidgets.QAbstractItemView.InternalMove)
        self.lstModFolders.setObjectName("lstModFolders")
        self.verticalLayout_2.addWidget(self.lstModFolders)
        self.horizontalLayout.addWidget(self.grpModFolders)
        self.grpModsList = QtWidgets.QGroupBox(self.fmeLists)
        self.grpModsList.setObjectName("grpModsList")
        self.verticalLayout_3 = QtWidgets.QVBoxLayout(self.grpModsList)
        self.verticalLayout_3.setObjectName("verticalLayout_3")
        self.lstModsList = QtWidgets.QListWidget(self.grpModsList)
        font = QtGui.QFont()
        font.setFamily("Courier New")
        self.lstModsList.setFont(font)
        self.lstModsList.setContextMenuPolicy(QtCore.Qt.CustomContextMenu)
        self.lstModsList.setAcceptDrops(False)
        self.lstModsList.setDragEnabled(False)
        self.lstModsList.setDragDropMode(QtWidgets.QAbstractItemView.InternalMove)
        self.lstModsList.setObjectName("lstModsList")
        self.verticalLayout_3.addWidget(self.lstModsList)
        self.horizontalLayout.addWidget(self.grpModsList)
        self.verticalLayout.addWidget(self.fmeLists)
        self.fmeLauncher = QtWidgets.QFrame(self.centralwidget)
        self.fmeLauncher.setLayoutDirection(QtCore.Qt.RightToLeft)
        self.fmeLauncher.setFrameShape(QtWidgets.QFrame.StyledPanel)
        self.fmeLauncher.setFrameShadow(QtWidgets.QFrame.Raised)
        self.fmeLauncher.setObjectName("fmeLauncher")
        self.horizontalLayout_4 = QtWidgets.QHBoxLayout(self.fmeLauncher)
        self.horizontalLayout_4.setObjectName("horizontalLayout_4")
        self.btnLaunchFS22 = QtWidgets.QPushButton(self.fmeLauncher)
        self.btnLaunchFS22.setObjectName("btnLaunchFS22")
        self.horizontalLayout_4.addWidget(self.btnLaunchFS22)
        self.btnSetModPath = QtWidgets.QPushButton(self.fmeLauncher)
        self.btnSetModPath.setObjectName("btnSetModPath")
        self.horizontalLayout_4.addWidget(self.btnSetModPath)
        self.verticalLayout.addWidget(self.fmeLauncher)
        MainWindow.setCentralWidget(self.centralwidget)
        self.menubar = QtWidgets.QMenuBar(MainWindow)
        self.menubar.setGeometry(QtCore.QRect(0, 0, 590, 21))
        self.menubar.setObjectName("menubar")
        self.menuFile = QtWidgets.QMenu(self.menubar)
        self.menuFile.setObjectName("menuFile")
        self.menuHelp = QtWidgets.QMenu(self.menubar)
        self.menuHelp.setObjectName("menuHelp")
        self.menuMods = QtWidgets.QMenu(self.menubar)
        self.menuMods.setObjectName("menuMods")
        MainWindow.setMenuBar(self.menubar)
        self.statusbar = QtWidgets.QStatusBar(MainWindow)
        self.statusbar.setObjectName("statusbar")
        MainWindow.setStatusBar(self.statusbar)
        self.mnuFileOpen = QtWidgets.QAction(MainWindow)
        self.mnuFileOpen.setShortcut("")
        self.mnuFileOpen.setShortcutContext(QtCore.Qt.WindowShortcut)
        self.mnuFileOpen.setObjectName("mnuFileOpen")
        self.mnuFileSave = QtWidgets.QAction(MainWindow)
        self.mnuFileSave.setObjectName("mnuFileSave")
        self.mnFileExit = QtWidgets.QAction(MainWindow)
        self.mnFileExit.setObjectName("mnFileExit")
        self.mnuHelpAbout = QtWidgets.QAction(MainWindow)
        self.mnuHelpAbout.setObjectName("mnuHelpAbout")
        self.mnuFileSaveAs = QtWidgets.QAction(MainWindow)
        self.mnuFileSaveAs.setObjectName("mnuFileSaveAs")
        self.mnuFileNew = QtWidgets.QAction(MainWindow)
        self.mnuFileNew.setObjectName("mnuFileNew")
        self.mnuListReverseChecklist = QtWidgets.QAction(MainWindow)
        self.mnuListReverseChecklist.setObjectName("mnuListReverseChecklist")
        self.mnuHelpHelp = QtWidgets.QAction(MainWindow)
        self.mnuHelpHelp.setObjectName("mnuHelpHelp")
        self.mnuListRenumberChecklist = QtWidgets.QAction(MainWindow)
        self.mnuListRenumberChecklist.setObjectName("mnuListRenumberChecklist")
        self.mnuListReverseHeadings = QtWidgets.QAction(MainWindow)
        self.mnuListReverseHeadings.setObjectName("mnuListReverseHeadings")
        self.mnuFileAddFolder = QtWidgets.QAction(MainWindow)
        self.mnuFileAddFolder.setObjectName("mnuFileAddFolder")
        self.mnuFIleDeleteFolder = QtWidgets.QAction(MainWindow)
        self.mnuFIleDeleteFolder.setObjectName("mnuFIleDeleteFolder")
        self.mnuModsAddFolder = QtWidgets.QAction(MainWindow)
        self.mnuModsAddFolder.setObjectName("mnuModsAddFolder")
        self.mnuModsRemoveFolder = QtWidgets.QAction(MainWindow)
        self.mnuModsRemoveFolder.setObjectName("mnuModsRemoveFolder")
        self.mnuModsAddItem = QtWidgets.QAction(MainWindow)
        self.mnuModsAddItem.setObjectName("mnuModsAddItem")
        self.mnuModsRemoveItem = QtWidgets.QAction(MainWindow)
        self.mnuModsRemoveItem.setObjectName("mnuModsRemoveItem")
        self.menuFile.addAction(self.mnFileExit)
        self.menuHelp.addAction(self.mnuHelpHelp)
        self.menuHelp.addSeparator()
        self.menuHelp.addAction(self.mnuHelpAbout)
        self.menuMods.addAction(self.mnuModsAddFolder)
        self.menuMods.addAction(self.mnuModsRemoveFolder)
        self.menuMods.addSeparator()
        self.menuMods.addAction(self.mnuModsAddItem)
        self.menuMods.addAction(self.mnuModsRemoveItem)
        self.menubar.addAction(self.menuFile.menuAction())
        self.menubar.addAction(self.menuMods.menuAction())
        self.menubar.addAction(self.menuHelp.menuAction())

        self.retranslateUi(MainWindow)
        self.mnFileExit.triggered.connect(MainWindow.close)
        QtCore.QMetaObject.connectSlotsByName(MainWindow)

    def retranslateUi(self, MainWindow):
        _translate = QtCore.QCoreApplication.translate
        MainWindow.setWindowTitle(_translate("MainWindow", "FS Mods Path Editor"))
        self.lblModFolders.setText(_translate("MainWindow", "Mod Folders Path:"))
        self.txtModFolders.setText(_translate("MainWindow", "path to mod folders"))
        self.btnBrowseModPath.setText(_translate("MainWindow", "Browse"))
        self.lblGamePath.setText(_translate("MainWindow", "Game Folder Path:"))
        self.txtGamePath.setText(_translate("MainWindow", "path to game installtion folder"))
        self.btnBrowseGamePath.setText(_translate("MainWindow", "Browse"))
        self.grpModFolders.setTitle(_translate("MainWindow", "Mod Folders"))
        self.grpModsList.setTitle(_translate("MainWindow", "Mods List"))
        self.btnLaunchFS22.setText(_translate("MainWindow", "Launch FS22"))
        self.btnSetModPath.setText(_translate("MainWindow", "Set Mod Path in Game Settings"))
        self.menuFile.setTitle(_translate("MainWindow", "File"))
        self.menuHelp.setTitle(_translate("MainWindow", "Help"))
        self.menuMods.setTitle(_translate("MainWindow", "Mods"))
        self.mnuFileOpen.setText(_translate("MainWindow", "&Open"))
        self.mnuFileOpen.setToolTip(_translate("MainWindow", "Open a check list file"))
        self.mnuFileSave.setText(_translate("MainWindow", "&Save"))
        self.mnuFileSave.setToolTip(_translate("MainWindow", "Save current check list file"))
        self.mnFileExit.setText(_translate("MainWindow", "E&xit"))
        self.mnFileExit.setToolTip(_translate("MainWindow", "Exit check list editor"))
        self.mnuHelpAbout.setText(_translate("MainWindow", "&About"))
        self.mnuHelpAbout.setToolTip(_translate("MainWindow", "About the check list editor"))
        self.mnuFileSaveAs.setText(_translate("MainWindow", "Save &As..."))
        self.mnuFileSaveAs.setToolTip(_translate("MainWindow", "Save current file as..."))
        self.mnuFileNew.setText(_translate("MainWindow", "&New"))
        self.mnuFileNew.setToolTip(_translate("MainWindow", "Create a new check list file"))
        self.mnuListReverseChecklist.setText(_translate("MainWindow", "&Reverse Check List"))
        self.mnuListReverseChecklist.setIconText(_translate("MainWindow", "&Reverse Check List"))
        self.mnuListReverseChecklist.setToolTip(_translate("MainWindow", "Reverse the currently selected check list"))
        self.mnuHelpHelp.setText(_translate("MainWindow", "&Help"))
        self.mnuListRenumberChecklist.setText(_translate("MainWindow", "Renu&mber Check List"))
        self.mnuListRenumberChecklist.setToolTip(_translate("MainWindow", "Renumber the selected check list"))
        self.mnuListReverseHeadings.setText(_translate("MainWindow", "Reverse &Headings list"))
        self.mnuListReverseHeadings.setToolTip(_translate("MainWindow", "Reverse the list of headings"))
        self.mnuFileAddFolder.setText(_translate("MainWindow", "Add Mod Folder"))
        self.mnuFIleDeleteFolder.setText(_translate("MainWindow", "Delete Mod Folder"))
        self.mnuModsAddFolder.setText(_translate("MainWindow", "&Add Folder To List"))
        self.mnuModsRemoveFolder.setText(_translate("MainWindow", "&Remove Selected Folder"))
        self.mnuModsAddItem.setText(_translate("MainWindow", "Add Mod To List"))
        self.mnuModsRemoveItem.setText(_translate("MainWindow", "Remove Selected Mod"))
