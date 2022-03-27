﻿namespace FS22_Mod_Manager
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuApplicationMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenUserDataDir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenGameSettingsXml = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenGameXml = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMods = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModsFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModFolderAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModFolderRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModFolderOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuModsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModFileRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModFileCopyToSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModFileCopyToAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptMod = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptModDoubleClick = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptModOverride = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModLaunch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptLaunchConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptLaunchLaunchCheats = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptLaunchRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.stsStatusBar = new System.Windows.Forms.StatusStrip();
            this.stsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlLists = new System.Windows.Forms.Panel();
            this.lblModFileCount = new System.Windows.Forms.Label();
            this.lstModFiles = new System.Windows.Forms.ListBox();
            this.lblModFiles = new System.Windows.Forms.Label();
            this.lblModFolderCount = new System.Windows.Forms.Label();
            this.lstModFolders = new System.Windows.Forms.ListBox();
            this.lblModFolders = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblModOverrideValues = new System.Windows.Forms.Label();
            this.txtModOverrideValues = new System.Windows.Forms.TextBox();
            this.btnLaunchGame = new System.Windows.Forms.Button();
            this.btnSetModOverride = new System.Windows.Forms.Button();
            this.btnGameExeFile = new System.Windows.Forms.Button();
            this.txtGameExeFile = new System.Windows.Forms.TextBox();
            this.lblGameExeFile = new System.Windows.Forms.Label();
            this.btnUserDataPath = new System.Windows.Forms.Button();
            this.txtUserDataPath = new System.Windows.Forms.TextBox();
            this.lblUserDataPath = new System.Windows.Forms.Label();
            this.btnModFolderPath = new System.Windows.Forms.Button();
            this.txtModFolderPath = new System.Windows.Forms.TextBox();
            this.lblModFolderPath = new System.Windows.Forms.Label();
            this.mnuContextFolderList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuContextFolderRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextFileList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuContexstFileRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextFileSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextModCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextModCopyToAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextFolderAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuApplicationMain.SuspendLayout();
            this.stsStatusBar.SuspendLayout();
            this.pnlLists.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mnuContextFolderList.SuspendLayout();
            this.mnuContextFileList.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuApplicationMain
            // 
            this.mnuApplicationMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuMods,
            this.mnuOptions,
            this.mnuHelp});
            this.mnuApplicationMain.Location = new System.Drawing.Point(0, 0);
            this.mnuApplicationMain.Name = "mnuApplicationMain";
            this.mnuApplicationMain.Size = new System.Drawing.Size(670, 24);
            this.mnuApplicationMain.TabIndex = 0;
            this.mnuApplicationMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpenUserDataDir,
            this.mnuFileOpenGameSettingsXml,
            this.mnuFileOpenGameXml,
            this.mnuFileSeparator,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileOpenUserDataDir
            // 
            this.mnuFileOpenUserDataDir.Name = "mnuFileOpenUserDataDir";
            this.mnuFileOpenUserDataDir.Size = new System.Drawing.Size(207, 22);
            this.mnuFileOpenUserDataDir.Text = "Open User Data Directory";
            this.mnuFileOpenUserDataDir.Click += new System.EventHandler(this.mnuFileOpenUserDataDir_Click);
            // 
            // mnuFileOpenGameSettingsXml
            // 
            this.mnuFileOpenGameSettingsXml.Name = "mnuFileOpenGameSettingsXml";
            this.mnuFileOpenGameSettingsXml.Size = new System.Drawing.Size(207, 22);
            this.mnuFileOpenGameSettingsXml.Text = "Open gameSettings.xml";
            this.mnuFileOpenGameSettingsXml.Click += new System.EventHandler(this.mnuFileOpenGameSettingsXml_Click);
            // 
            // mnuFileOpenGameXml
            // 
            this.mnuFileOpenGameXml.Name = "mnuFileOpenGameXml";
            this.mnuFileOpenGameXml.Size = new System.Drawing.Size(207, 22);
            this.mnuFileOpenGameXml.Text = "Open game.xml";
            this.mnuFileOpenGameXml.Click += new System.EventHandler(this.mnuFileOpenGameXml_Click);
            // 
            // mnuFileSeparator
            // 
            this.mnuFileSeparator.Name = "mnuFileSeparator";
            this.mnuFileSeparator.Size = new System.Drawing.Size(204, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(207, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuMods
            // 
            this.mnuMods.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuModsFolder,
            this.MnuModsFile});
            this.mnuMods.Name = "mnuMods";
            this.mnuMods.Size = new System.Drawing.Size(75, 20);
            this.mnuMods.Text = "Mods Files";
            // 
            // mnuModsFolder
            // 
            this.mnuModsFolder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuModFolderAdd,
            this.mnuModFolderRemove,
            this.mnuModFolderOpen});
            this.mnuModsFolder.Name = "mnuModsFolder";
            this.mnuModsFolder.Size = new System.Drawing.Size(180, 22);
            this.mnuModsFolder.Text = "Mod Folder Actions";
            // 
            // mnuModFolderAdd
            // 
            this.mnuModFolderAdd.Name = "mnuModFolderAdd";
            this.mnuModFolderAdd.Size = new System.Drawing.Size(218, 22);
            this.mnuModFolderAdd.Text = "Add New Folder";
            this.mnuModFolderAdd.Click += new System.EventHandler(this.mnuModFolderAdd_Click);
            // 
            // mnuModFolderRemove
            // 
            this.mnuModFolderRemove.Name = "mnuModFolderRemove";
            this.mnuModFolderRemove.Size = new System.Drawing.Size(218, 22);
            this.mnuModFolderRemove.Text = "Remove Selected Folder";
            this.mnuModFolderRemove.Click += new System.EventHandler(this.mnuModFolderRemove_Click);
            // 
            // mnuModFolderOpen
            // 
            this.mnuModFolderOpen.Name = "mnuModFolderOpen";
            this.mnuModFolderOpen.Size = new System.Drawing.Size(218, 22);
            this.mnuModFolderOpen.Text = "Open Mod Folder Directory";
            this.mnuModFolderOpen.Click += new System.EventHandler(this.mnuModFolderOpen_Click);
            // 
            // MnuModsFile
            // 
            this.MnuModsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuModFileRemove,
            this.mnuModFileCopyToSelected,
            this.mnuModFileCopyToAll});
            this.MnuModsFile.Name = "MnuModsFile";
            this.MnuModsFile.Size = new System.Drawing.Size(180, 22);
            this.MnuModsFile.Text = "Mod File Actions";
            // 
            // mnuModFileRemove
            // 
            this.mnuModFileRemove.Name = "mnuModFileRemove";
            this.mnuModFileRemove.Size = new System.Drawing.Size(259, 22);
            this.mnuModFileRemove.Text = "Remove Selected Mod File";
            this.mnuModFileRemove.Click += new System.EventHandler(this.mnuModFileRemove_Click);
            // 
            // mnuModFileCopyToSelected
            // 
            this.mnuModFileCopyToSelected.Name = "mnuModFileCopyToSelected";
            this.mnuModFileCopyToSelected.Size = new System.Drawing.Size(259, 22);
            this.mnuModFileCopyToSelected.Text = "Copy Mod file(s) to Selected Folder";
            this.mnuModFileCopyToSelected.Click += new System.EventHandler(this.mnuModCopyToSelected_Click);
            // 
            // mnuModFileCopyToAll
            // 
            this.mnuModFileCopyToAll.Name = "mnuModFileCopyToAll";
            this.mnuModFileCopyToAll.Size = new System.Drawing.Size(259, 22);
            this.mnuModFileCopyToAll.Text = "Copy Mod to ALL Folders";
            this.mnuModFileCopyToAll.Click += new System.EventHandler(this.mnuModFileCopyToAll_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptMod,
            this.mnuModLaunch});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(61, 20);
            this.mnuOptions.Text = "Options";
            // 
            // mnuOptMod
            // 
            this.mnuOptMod.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptModDoubleClick,
            this.mnuOptModOverride});
            this.mnuOptMod.Name = "mnuOptMod";
            this.mnuOptMod.Size = new System.Drawing.Size(180, 22);
            this.mnuOptMod.Text = "Mod Options";
            // 
            // mnuOptModDoubleClick
            // 
            this.mnuOptModDoubleClick.CheckOnClick = true;
            this.mnuOptModDoubleClick.Name = "mnuOptModDoubleClick";
            this.mnuOptModDoubleClick.Size = new System.Drawing.Size(266, 22);
            this.mnuOptModDoubleClick.Text = "Allow Double Click Folder to Launch";
            // 
            // mnuOptModOverride
            // 
            this.mnuOptModOverride.CheckOnClick = true;
            this.mnuOptModOverride.Name = "mnuOptModOverride";
            this.mnuOptModOverride.Size = new System.Drawing.Size(266, 22);
            this.mnuOptModOverride.Text = "Mod Folder Override";
            // 
            // mnuModLaunch
            // 
            this.mnuModLaunch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptLaunchConsole,
            this.mnuOptLaunchLaunchCheats,
            this.mnuOptLaunchRestart});
            this.mnuModLaunch.Name = "mnuModLaunch";
            this.mnuModLaunch.Size = new System.Drawing.Size(180, 22);
            this.mnuModLaunch.Text = "Launch Options";
            // 
            // mnuOptLaunchConsole
            // 
            this.mnuOptLaunchConsole.CheckOnClick = true;
            this.mnuOptLaunchConsole.Name = "mnuOptLaunchConsole";
            this.mnuOptLaunchConsole.Size = new System.Drawing.Size(234, 22);
            this.mnuOptLaunchConsole.Text = "Launch with In-Game Console";
            this.mnuOptLaunchConsole.Click += new System.EventHandler(this.mnuOptLaunchConsole_Click);
            // 
            // mnuOptLaunchLaunchCheats
            // 
            this.mnuOptLaunchLaunchCheats.CheckOnClick = true;
            this.mnuOptLaunchLaunchCheats.Name = "mnuOptLaunchLaunchCheats";
            this.mnuOptLaunchLaunchCheats.Size = new System.Drawing.Size(234, 22);
            this.mnuOptLaunchLaunchCheats.Text = "Launch with Console Cheats";
            this.mnuOptLaunchLaunchCheats.Click += new System.EventHandler(this.mnuOptLaunchLaunchCheats_Click);
            // 
            // mnuOptLaunchRestart
            // 
            this.mnuOptLaunchRestart.CheckOnClick = true;
            this.mnuOptLaunchRestart.Name = "mnuOptLaunchRestart";
            this.mnuOptLaunchRestart.Size = new System.Drawing.Size(234, 22);
            this.mnuOptLaunchRestart.Text = "Launch as Restart";
            this.mnuOptLaunchRestart.Click += new System.EventHandler(this.mnuOptLaunchRestart_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpOpen,
            this.mnuHelpSeparator,
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuHelpOpen
            // 
            this.mnuHelpOpen.Name = "mnuHelpOpen";
            this.mnuHelpOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuHelpOpen.Text = "Help";
            this.mnuHelpOpen.Click += new System.EventHandler(this.mnuHelpOpen_Click);
            // 
            // mnuHelpSeparator
            // 
            this.mnuHelpSeparator.Name = "mnuHelpSeparator";
            this.mnuHelpSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(180, 22);
            this.mnuHelpAbout.Text = "About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // stsStatusBar
            // 
            this.stsStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsStatusLabel});
            this.stsStatusBar.Location = new System.Drawing.Point(0, 688);
            this.stsStatusBar.Name = "stsStatusBar";
            this.stsStatusBar.Size = new System.Drawing.Size(670, 22);
            this.stsStatusBar.TabIndex = 1;
            // 
            // stsStatusLabel
            // 
            this.stsStatusLabel.Name = "stsStatusLabel";
            this.stsStatusLabel.Size = new System.Drawing.Size(130, 17);
            this.stsStatusLabel.Text = "FS22 Mod File Manager";
            // 
            // pnlLists
            // 
            this.pnlLists.Controls.Add(this.lblModFileCount);
            this.pnlLists.Controls.Add(this.lstModFiles);
            this.pnlLists.Controls.Add(this.lblModFiles);
            this.pnlLists.Controls.Add(this.lblModFolderCount);
            this.pnlLists.Controls.Add(this.lstModFolders);
            this.pnlLists.Controls.Add(this.lblModFolders);
            this.pnlLists.Location = new System.Drawing.Point(0, 27);
            this.pnlLists.Name = "pnlLists";
            this.pnlLists.Size = new System.Drawing.Size(670, 479);
            this.pnlLists.TabIndex = 4;
            // 
            // lblModFileCount
            // 
            this.lblModFileCount.AutoSize = true;
            this.lblModFileCount.Location = new System.Drawing.Point(338, 459);
            this.lblModFileCount.Name = "lblModFileCount";
            this.lblModFileCount.Size = new System.Drawing.Size(61, 15);
            this.lblModFileCount.TabIndex = 5;
            this.lblModFileCount.Text = "File Count";
            // 
            // lstModFiles
            // 
            this.lstModFiles.FormattingEnabled = true;
            this.lstModFiles.ItemHeight = 15;
            this.lstModFiles.Location = new System.Drawing.Point(338, 28);
            this.lstModFiles.Name = "lstModFiles";
            this.lstModFiles.Size = new System.Drawing.Size(320, 424);
            this.lstModFiles.TabIndex = 4;
            this.lstModFiles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstModFiles_MouseUp);
            // 
            // lblModFiles
            // 
            this.lblModFiles.AutoSize = true;
            this.lblModFiles.Location = new System.Drawing.Point(338, 11);
            this.lblModFiles.Name = "lblModFiles";
            this.lblModFiles.Size = new System.Drawing.Size(58, 15);
            this.lblModFiles.TabIndex = 3;
            this.lblModFiles.Text = "Mod FIles";
            // 
            // lblModFolderCount
            // 
            this.lblModFolderCount.AutoSize = true;
            this.lblModFolderCount.Location = new System.Drawing.Point(12, 459);
            this.lblModFolderCount.Name = "lblModFolderCount";
            this.lblModFolderCount.Size = new System.Drawing.Size(76, 15);
            this.lblModFolderCount.TabIndex = 2;
            this.lblModFolderCount.Text = "Folder Count";
            // 
            // lstModFolders
            // 
            this.lstModFolders.FormattingEnabled = true;
            this.lstModFolders.ItemHeight = 15;
            this.lstModFolders.Location = new System.Drawing.Point(12, 28);
            this.lstModFolders.Name = "lstModFolders";
            this.lstModFolders.Size = new System.Drawing.Size(309, 424);
            this.lstModFolders.TabIndex = 1;
            this.lstModFolders.SelectedIndexChanged += new System.EventHandler(this.lstModFolders_SelectedIndexChanged);
            this.lstModFolders.DoubleClick += new System.EventHandler(this.lstModFolders_DoubleClick);
            this.lstModFolders.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstModFolders_MouseUp);
            // 
            // lblModFolders
            // 
            this.lblModFolders.AutoSize = true;
            this.lblModFolders.Location = new System.Drawing.Point(12, 11);
            this.lblModFolders.Name = "lblModFolders";
            this.lblModFolders.Size = new System.Drawing.Size(73, 15);
            this.lblModFolders.TabIndex = 0;
            this.lblModFolders.Text = "Mod Folders";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblModOverrideValues);
            this.panel1.Controls.Add(this.txtModOverrideValues);
            this.panel1.Controls.Add(this.btnLaunchGame);
            this.panel1.Controls.Add(this.btnSetModOverride);
            this.panel1.Controls.Add(this.btnGameExeFile);
            this.panel1.Controls.Add(this.txtGameExeFile);
            this.panel1.Controls.Add(this.lblGameExeFile);
            this.panel1.Controls.Add(this.btnUserDataPath);
            this.panel1.Controls.Add(this.txtUserDataPath);
            this.panel1.Controls.Add(this.lblUserDataPath);
            this.panel1.Controls.Add(this.btnModFolderPath);
            this.panel1.Controls.Add(this.txtModFolderPath);
            this.panel1.Controls.Add(this.lblModFolderPath);
            this.panel1.Location = new System.Drawing.Point(0, 512);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 167);
            this.panel1.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(579, 136);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblModOverrideValues
            // 
            this.lblModOverrideValues.AutoSize = true;
            this.lblModOverrideValues.Location = new System.Drawing.Point(8, 11);
            this.lblModOverrideValues.Name = "lblModOverrideValues";
            this.lblModOverrideValues.Size = new System.Drawing.Size(95, 15);
            this.lblModOverrideValues.TabIndex = 12;
            this.lblModOverrideValues.Text = "Current Override";
            // 
            // txtModOverrideValues
            // 
            this.txtModOverrideValues.Location = new System.Drawing.Point(104, 7);
            this.txtModOverrideValues.Name = "txtModOverrideValues";
            this.txtModOverrideValues.ReadOnly = true;
            this.txtModOverrideValues.Size = new System.Drawing.Size(469, 23);
            this.txtModOverrideValues.TabIndex = 11;
            this.txtModOverrideValues.Text = "Mod Override Values";
            // 
            // btnLaunchGame
            // 
            this.btnLaunchGame.Location = new System.Drawing.Point(145, 136);
            this.btnLaunchGame.Name = "btnLaunchGame";
            this.btnLaunchGame.Size = new System.Drawing.Size(123, 23);
            this.btnLaunchGame.TabIndex = 10;
            this.btnLaunchGame.Text = "Launch FS22";
            this.btnLaunchGame.UseVisualStyleBackColor = true;
            this.btnLaunchGame.Click += new System.EventHandler(this.btnLaunchGame_Click);
            // 
            // btnSetModOverride
            // 
            this.btnSetModOverride.Location = new System.Drawing.Point(10, 136);
            this.btnSetModOverride.Name = "btnSetModOverride";
            this.btnSetModOverride.Size = new System.Drawing.Size(123, 23);
            this.btnSetModOverride.TabIndex = 9;
            this.btnSetModOverride.Text = "Set Mod Override";
            this.btnSetModOverride.UseVisualStyleBackColor = true;
            this.btnSetModOverride.Click += new System.EventHandler(this.btnSetModOverride_Click);
            // 
            // btnGameExeFile
            // 
            this.btnGameExeFile.Location = new System.Drawing.Point(579, 92);
            this.btnGameExeFile.Name = "btnGameExeFile";
            this.btnGameExeFile.Size = new System.Drawing.Size(75, 23);
            this.btnGameExeFile.TabIndex = 8;
            this.btnGameExeFile.Text = "Browse";
            this.btnGameExeFile.UseVisualStyleBackColor = true;
            this.btnGameExeFile.Click += new System.EventHandler(this.btnGameExeFile_Click);
            // 
            // txtGameExeFile
            // 
            this.txtGameExeFile.Location = new System.Drawing.Point(105, 92);
            this.txtGameExeFile.Name = "txtGameExeFile";
            this.txtGameExeFile.ReadOnly = true;
            this.txtGameExeFile.Size = new System.Drawing.Size(468, 23);
            this.txtGameExeFile.TabIndex = 7;
            this.txtGameExeFile.Text = "C:\\path\\to\\fs22.exe";
            // 
            // lblGameExeFile
            // 
            this.lblGameExeFile.AutoSize = true;
            this.lblGameExeFile.Location = new System.Drawing.Point(15, 96);
            this.lblGameExeFile.Name = "lblGameExeFile";
            this.lblGameExeFile.Size = new System.Drawing.Size(89, 15);
            this.lblGameExeFile.TabIndex = 6;
            this.lblGameExeFile.Text = "Game .exe Path";
            // 
            // btnUserDataPath
            // 
            this.btnUserDataPath.Location = new System.Drawing.Point(579, 63);
            this.btnUserDataPath.Name = "btnUserDataPath";
            this.btnUserDataPath.Size = new System.Drawing.Size(75, 23);
            this.btnUserDataPath.TabIndex = 5;
            this.btnUserDataPath.Text = "Browse";
            this.btnUserDataPath.UseVisualStyleBackColor = true;
            this.btnUserDataPath.Click += new System.EventHandler(this.btnUserDataPath_Click);
            // 
            // txtUserDataPath
            // 
            this.txtUserDataPath.Location = new System.Drawing.Point(105, 63);
            this.txtUserDataPath.Name = "txtUserDataPath";
            this.txtUserDataPath.ReadOnly = true;
            this.txtUserDataPath.Size = new System.Drawing.Size(468, 23);
            this.txtUserDataPath.TabIndex = 4;
            this.txtUserDataPath.Text = "C:\\User\\data\\path";
            // 
            // lblUserDataPath
            // 
            this.lblUserDataPath.AutoSize = true;
            this.lblUserDataPath.Location = new System.Drawing.Point(20, 67);
            this.lblUserDataPath.Name = "lblUserDataPath";
            this.lblUserDataPath.Size = new System.Drawing.Size(84, 15);
            this.lblUserDataPath.TabIndex = 3;
            this.lblUserDataPath.Text = "User Data Path";
            // 
            // btnModFolderPath
            // 
            this.btnModFolderPath.Location = new System.Drawing.Point(579, 34);
            this.btnModFolderPath.Name = "btnModFolderPath";
            this.btnModFolderPath.Size = new System.Drawing.Size(75, 23);
            this.btnModFolderPath.TabIndex = 2;
            this.btnModFolderPath.Text = "Browse";
            this.btnModFolderPath.UseVisualStyleBackColor = true;
            this.btnModFolderPath.Click += new System.EventHandler(this.btnModFolderPath_Click);
            // 
            // txtModFolderPath
            // 
            this.txtModFolderPath.Location = new System.Drawing.Point(105, 34);
            this.txtModFolderPath.Name = "txtModFolderPath";
            this.txtModFolderPath.ReadOnly = true;
            this.txtModFolderPath.Size = new System.Drawing.Size(468, 23);
            this.txtModFolderPath.TabIndex = 1;
            this.txtModFolderPath.Text = "C:\\path\\to\\mods\\folder";
            // 
            // lblModFolderPath
            // 
            this.lblModFolderPath.AutoSize = true;
            this.lblModFolderPath.Location = new System.Drawing.Point(12, 38);
            this.lblModFolderPath.Name = "lblModFolderPath";
            this.lblModFolderPath.Size = new System.Drawing.Size(95, 15);
            this.lblModFolderPath.TabIndex = 0;
            this.lblModFolderPath.Text = "Mod Folder Path";
            // 
            // mnuContextFolderList
            // 
            this.mnuContextFolderList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContextFolderAdd,
            this.mnuContextFolderRemove});
            this.mnuContextFolderList.Name = "mnuContextFolderList";
            this.mnuContextFolderList.Size = new System.Drawing.Size(181, 70);
            // 
            // mnuContextFolderAdd
            // 
            this.mnuContextFolderAdd.Name = "mnuContextFolderAdd";
            this.mnuContextFolderAdd.Size = new System.Drawing.Size(180, 22);
            this.mnuContextFolderAdd.Text = "Add New Folder";
            this.mnuContextFolderAdd.Click += new System.EventHandler(this.mnuModFolderAdd_Click);
            // 
            // mnuContextFolderRemove
            // 
            this.mnuContextFolderRemove.Name = "mnuContextFolderRemove";
            this.mnuContextFolderRemove.Size = new System.Drawing.Size(180, 22);
            this.mnuContextFolderRemove.Text = "Remover Folder";
            this.mnuContextFolderRemove.Click += new System.EventHandler(this.mnuModFolderRemove_Click);
            // 
            // mnuContextFileList
            // 
            this.mnuContextFileList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContexstFileRemove,
            this.mnuContextFileSeparator,
            this.mnuContextModCopy,
            this.mnuContextModCopyToAll});
            this.mnuContextFileList.Name = "mnuContextFileList";
            this.mnuContextFileList.Size = new System.Drawing.Size(228, 76);
            // 
            // mnuContexstFileRemove
            // 
            this.mnuContexstFileRemove.Name = "mnuContexstFileRemove";
            this.mnuContexstFileRemove.Size = new System.Drawing.Size(227, 22);
            this.mnuContexstFileRemove.Text = "Remove Mod File";
            this.mnuContexstFileRemove.Click += new System.EventHandler(this.mnuModFileRemove_Click);
            // 
            // mnuContextFileSeparator
            // 
            this.mnuContextFileSeparator.Name = "mnuContextFileSeparator";
            this.mnuContextFileSeparator.Size = new System.Drawing.Size(224, 6);
            // 
            // mnuContextModCopy
            // 
            this.mnuContextModCopy.Name = "mnuContextModCopy";
            this.mnuContextModCopy.Size = new System.Drawing.Size(227, 22);
            this.mnuContextModCopy.Text = "Copy Mod to Selected Folder";
            this.mnuContextModCopy.Click += new System.EventHandler(this.mnuModCopyToSelected_Click);
            // 
            // mnuContextModCopyToAll
            // 
            this.mnuContextModCopyToAll.Name = "mnuContextModCopyToAll";
            this.mnuContextModCopyToAll.Size = new System.Drawing.Size(227, 22);
            this.mnuContextModCopyToAll.Text = "Copy Mod to All Folders";
            this.mnuContextModCopyToAll.Click += new System.EventHandler(this.mnuModFileCopyToAll_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLists);
            this.Controls.Add(this.stsStatusBar);
            this.Controls.Add(this.mnuApplicationMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuApplicationMain;
            this.Name = "frmMain";
            this.Text = "FS22 Mod FIle Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuApplicationMain.ResumeLayout(false);
            this.mnuApplicationMain.PerformLayout();
            this.stsStatusBar.ResumeLayout(false);
            this.stsStatusBar.PerformLayout();
            this.pnlLists.ResumeLayout(false);
            this.pnlLists.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnuContextFolderList.ResumeLayout(false);
            this.mnuContextFileList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mnuApplicationMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileOpenUserDataDir;
        private ToolStripSeparator mnuFileSeparator;
        private ToolStripMenuItem mnuFileExit;
        private ToolStripMenuItem mnuMods;
        private ToolStripMenuItem mnuModsFolder;
        private ToolStripMenuItem MnuModsFile;
        private ToolStripMenuItem mnuOptions;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuModFolderAdd;
        private ToolStripMenuItem mnuModFolderRemove;
        private ToolStripMenuItem mnuModFolderOpen;
        private ToolStripMenuItem mnuModFileRemove;
        private ToolStripMenuItem mnuModFileCopyToSelected;
        private ToolStripMenuItem mnuModFileCopyToAll;
        private ToolStripMenuItem mnuOptMod;
        private ToolStripMenuItem mnuOptModDoubleClick;
        private ToolStripMenuItem mnuModLaunch;
        private ToolStripMenuItem mnuHelpOpen;
        private ToolStripSeparator mnuHelpSeparator;
        private ToolStripMenuItem mnuHelpAbout;
        private ToolStripMenuItem mnuOptModOverride;
        private ToolStripMenuItem mnuOptLaunchConsole;
        private ToolStripMenuItem mnuOptLaunchLaunchCheats;
        private ToolStripMenuItem mnuOptLaunchRestart;
        private StatusStrip stsStatusBar;
        private ToolStripStatusLabel stsStatusLabel;
        private Panel pnlLists;
        private Label lblModFolderCount;
        private ListBox lstModFolders;
        private Label lblModFolders;
        private Label lblModFileCount;
        private ListBox lstModFiles;
        private Label lblModFiles;
        private Panel panel1;
        private Button btnModFolderPath;
        private TextBox txtModFolderPath;
        private Label lblModFolderPath;
        private Button btnGameExeFile;
        private TextBox txtGameExeFile;
        private Label lblGameExeFile;
        private Button btnUserDataPath;
        private TextBox txtUserDataPath;
        private Label lblUserDataPath;
        private Button btnLaunchGame;
        private Button btnSetModOverride;
        private Label lblModOverrideValues;
        private TextBox txtModOverrideValues;
        private Button btnExit;
        private ToolStripMenuItem mnuFileOpenGameSettingsXml;
        private ToolStripMenuItem mnuFileOpenGameXml;
        private ContextMenuStrip mnuContextFolderList;
        private ToolStripMenuItem mnuContextFolderRemove;
        private ContextMenuStrip mnuContextFileList;
        private ToolStripMenuItem mnuContexstFileRemove;
        private ToolStripSeparator mnuContextFileSeparator;
        private ToolStripMenuItem mnuContextModCopy;
        private ToolStripMenuItem mnuContextModCopyToAll;
        private ToolStripMenuItem mnuContextFolderAdd;
    }
}