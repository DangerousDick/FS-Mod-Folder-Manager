namespace FS22_Mod_Manager
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
            this.mnuModFolderRename = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopyAsNewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuModsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModFileRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModFileCopyToSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModFileCopyToAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuModsFolderOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModsRefreshLists = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModsLaunchModhub = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptMod = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptModDoubleClick = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptModOverride = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModLaunch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptLaunchConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptLaunchLaunchCheats = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptLaunchRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptionsOpenOptsDirectory = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuContextFolderAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextFolderRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextFolderRename = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextFolderSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextFolderCopyAsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextCopyToSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextFolderRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextFileList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuContexstFileRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextFileSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextModCopyToAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextFilesRefreshLists = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuApplicationMain.Size = new System.Drawing.Size(530, 24);
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
            this.MnuModsFile,
            this.mnuModsSeparator,
            this.mnuModsFolderOpen,
            this.mnuModsRefreshLists,
            this.mnuModsLaunchModhub});
            this.mnuMods.Name = "mnuMods";
            this.mnuMods.Size = new System.Drawing.Size(75, 20);
            this.mnuMods.Text = "Mods Files";
            // 
            // mnuModsFolder
            // 
            this.mnuModsFolder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuModFolderAdd,
            this.mnuModFolderRemove,
            this.mnuModFolderRename,
            this.mnuCopyAsNewFolder});
            this.mnuModsFolder.Name = "mnuModsFolder";
            this.mnuModsFolder.Size = new System.Drawing.Size(187, 22);
            this.mnuModsFolder.Text = "Mod Folder Actions";
            // 
            // mnuModFolderAdd
            // 
            this.mnuModFolderAdd.Name = "mnuModFolderAdd";
            this.mnuModFolderAdd.Size = new System.Drawing.Size(226, 22);
            this.mnuModFolderAdd.Text = "Add New Folder";
            this.mnuModFolderAdd.Click += new System.EventHandler(this.mnuModFolderAdd_Click);
            // 
            // mnuModFolderRemove
            // 
            this.mnuModFolderRemove.Name = "mnuModFolderRemove";
            this.mnuModFolderRemove.Size = new System.Drawing.Size(226, 22);
            this.mnuModFolderRemove.Text = "Remove Selected Folder";
            this.mnuModFolderRemove.Click += new System.EventHandler(this.mnuModFolderRemove_Click);
            // 
            // mnuModFolderRename
            // 
            this.mnuModFolderRename.Name = "mnuModFolderRename";
            this.mnuModFolderRename.Size = new System.Drawing.Size(226, 22);
            this.mnuModFolderRename.Text = "Rename Folder";
            this.mnuModFolderRename.Click += new System.EventHandler(this.mnuContextFolderRename_Click);
            // 
            // mnuCopyAsNewFolder
            // 
            this.mnuCopyAsNewFolder.Name = "mnuCopyAsNewFolder";
            this.mnuCopyAsNewFolder.Size = new System.Drawing.Size(226, 22);
            this.mnuCopyAsNewFolder.Text = "Copy Selected as New Folder";
            this.mnuCopyAsNewFolder.Click += new System.EventHandler(this.mnuModFolderCopyAsNewFolder_Click);
            // 
            // MnuModsFile
            // 
            this.MnuModsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuModFileRemove,
            this.mnuModFileCopyToSelected,
            this.mnuModFileCopyToAll});
            this.MnuModsFile.Name = "MnuModsFile";
            this.MnuModsFile.Size = new System.Drawing.Size(187, 22);
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
            // mnuModsSeparator
            // 
            this.mnuModsSeparator.Name = "mnuModsSeparator";
            this.mnuModsSeparator.Size = new System.Drawing.Size(184, 6);
            // 
            // mnuModsFolderOpen
            // 
            this.mnuModsFolderOpen.Name = "mnuModsFolderOpen";
            this.mnuModsFolderOpen.Size = new System.Drawing.Size(187, 22);
            this.mnuModsFolderOpen.Text = "Open Mods Directory";
            this.mnuModsFolderOpen.Click += new System.EventHandler(this.mnuModFolderOpen_Click);
            // 
            // mnuModsRefreshLists
            // 
            this.mnuModsRefreshLists.Name = "mnuModsRefreshLists";
            this.mnuModsRefreshLists.Size = new System.Drawing.Size(187, 22);
            this.mnuModsRefreshLists.Text = "Refresh Lists";
            this.mnuModsRefreshLists.Click += new System.EventHandler(this.mnuContextFolderRefresh_Click);
            // 
            // mnuModsLaunchModhub
            // 
            this.mnuModsLaunchModhub.Name = "mnuModsLaunchModhub";
            this.mnuModsLaunchModhub.Size = new System.Drawing.Size(187, 22);
            this.mnuModsLaunchModhub.Text = "Launch Mod Hub";
            this.mnuModsLaunchModhub.Click += new System.EventHandler(this.mnuModsLaunchModhub_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptMod,
            this.mnuModLaunch,
            this.mnuOptionsOpenOptsDirectory});
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
            this.mnuOptMod.Size = new System.Drawing.Size(225, 22);
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
            this.mnuModLaunch.Size = new System.Drawing.Size(225, 22);
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
            // mnuOptionsOpenOptsDirectory
            // 
            this.mnuOptionsOpenOptsDirectory.Name = "mnuOptionsOpenOptsDirectory";
            this.mnuOptionsOpenOptsDirectory.Size = new System.Drawing.Size(225, 22);
            this.mnuOptionsOpenOptsDirectory.Text = "Open User Settings Directory";
            this.mnuOptionsOpenOptsDirectory.Click += new System.EventHandler(this.mnuOptionsOpenOptsDirectory_Click);
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
            this.mnuHelpOpen.Size = new System.Drawing.Size(107, 22);
            this.mnuHelpOpen.Text = "Help";
            this.mnuHelpOpen.Click += new System.EventHandler(this.mnuHelpOpen_Click);
            // 
            // mnuHelpSeparator
            // 
            this.mnuHelpSeparator.Name = "mnuHelpSeparator";
            this.mnuHelpSeparator.Size = new System.Drawing.Size(104, 6);
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.mnuHelpAbout.Text = "About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // stsStatusBar
            // 
            this.stsStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsStatusLabel});
            this.stsStatusBar.Location = new System.Drawing.Point(0, 549);
            this.stsStatusBar.Name = "stsStatusBar";
            this.stsStatusBar.Size = new System.Drawing.Size(530, 22);
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
            this.pnlLists.Size = new System.Drawing.Size(518, 345);
            this.pnlLists.TabIndex = 4;
            // 
            // lblModFileCount
            // 
            this.lblModFileCount.AutoSize = true;
            this.lblModFileCount.Location = new System.Drawing.Point(246, 324);
            this.lblModFileCount.Name = "lblModFileCount";
            this.lblModFileCount.Size = new System.Drawing.Size(61, 15);
            this.lblModFileCount.TabIndex = 5;
            this.lblModFileCount.Text = "File Count";
            // 
            // lstModFiles
            // 
            this.lstModFiles.FormattingEnabled = true;
            this.lstModFiles.ItemHeight = 15;
            this.lstModFiles.Location = new System.Drawing.Point(246, 28);
            this.lstModFiles.Name = "lstModFiles";
            this.lstModFiles.Size = new System.Drawing.Size(261, 289);
            this.lstModFiles.TabIndex = 4;
            this.lstModFiles.DoubleClick += new System.EventHandler(this.lstModFiles_DoubleClick);
            this.lstModFiles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstModFiles_MouseUp);
            // 
            // lblModFiles
            // 
            this.lblModFiles.AutoSize = true;
            this.lblModFiles.Location = new System.Drawing.Point(246, 11);
            this.lblModFiles.Name = "lblModFiles";
            this.lblModFiles.Size = new System.Drawing.Size(58, 15);
            this.lblModFiles.TabIndex = 3;
            this.lblModFiles.Text = "Mod FIles";
            // 
            // lblModFolderCount
            // 
            this.lblModFolderCount.AutoSize = true;
            this.lblModFolderCount.Location = new System.Drawing.Point(12, 324);
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
            this.lstModFolders.Size = new System.Drawing.Size(220, 289);
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
            this.panel1.Location = new System.Drawing.Point(0, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 167);
            this.panel1.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(432, 136);
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
            this.txtModOverrideValues.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtModOverrideValues.Location = new System.Drawing.Point(104, 7);
            this.txtModOverrideValues.Name = "txtModOverrideValues";
            this.txtModOverrideValues.ReadOnly = true;
            this.txtModOverrideValues.Size = new System.Drawing.Size(403, 23);
            this.txtModOverrideValues.TabIndex = 11;
            this.txtModOverrideValues.Text = "Mod Override Values";
            this.txtModOverrideValues.WordWrap = false;
            this.txtModOverrideValues.TextChanged += new System.EventHandler(this.txtModOverrideValues_TextChanged);
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
            this.btnGameExeFile.Location = new System.Drawing.Point(432, 91);
            this.btnGameExeFile.Name = "btnGameExeFile";
            this.btnGameExeFile.Size = new System.Drawing.Size(75, 23);
            this.btnGameExeFile.TabIndex = 8;
            this.btnGameExeFile.Text = "Browse";
            this.btnGameExeFile.UseVisualStyleBackColor = true;
            this.btnGameExeFile.Click += new System.EventHandler(this.btnGameExeFile_Click);
            // 
            // txtGameExeFile
            // 
            this.txtGameExeFile.BackColor = System.Drawing.SystemColors.Info;
            this.txtGameExeFile.Location = new System.Drawing.Point(104, 92);
            this.txtGameExeFile.Name = "txtGameExeFile";
            this.txtGameExeFile.ReadOnly = true;
            this.txtGameExeFile.Size = new System.Drawing.Size(322, 23);
            this.txtGameExeFile.TabIndex = 7;
            this.txtGameExeFile.Text = "C:\\path\\to\\fs22.exe";
            this.txtGameExeFile.WordWrap = false;
            this.txtGameExeFile.TextChanged += new System.EventHandler(this.txtGameExeFile_TextChanged);
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
            this.btnUserDataPath.Location = new System.Drawing.Point(432, 62);
            this.btnUserDataPath.Name = "btnUserDataPath";
            this.btnUserDataPath.Size = new System.Drawing.Size(75, 23);
            this.btnUserDataPath.TabIndex = 5;
            this.btnUserDataPath.Text = "Browse";
            this.btnUserDataPath.UseVisualStyleBackColor = true;
            this.btnUserDataPath.Click += new System.EventHandler(this.btnUserDataPath_Click);
            // 
            // txtUserDataPath
            // 
            this.txtUserDataPath.BackColor = System.Drawing.SystemColors.Info;
            this.txtUserDataPath.Location = new System.Drawing.Point(105, 63);
            this.txtUserDataPath.Name = "txtUserDataPath";
            this.txtUserDataPath.ReadOnly = true;
            this.txtUserDataPath.Size = new System.Drawing.Size(322, 23);
            this.txtUserDataPath.TabIndex = 4;
            this.txtUserDataPath.Text = "C:\\User\\data\\path";
            this.txtUserDataPath.WordWrap = false;
            this.txtUserDataPath.TextChanged += new System.EventHandler(this.txtUserDataPath_TextChanged);
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
            this.btnModFolderPath.Location = new System.Drawing.Point(432, 33);
            this.btnModFolderPath.Name = "btnModFolderPath";
            this.btnModFolderPath.Size = new System.Drawing.Size(75, 23);
            this.btnModFolderPath.TabIndex = 2;
            this.btnModFolderPath.Text = "Browse";
            this.btnModFolderPath.UseVisualStyleBackColor = true;
            this.btnModFolderPath.Click += new System.EventHandler(this.btnModFolderPath_Click);
            // 
            // txtModFolderPath
            // 
            this.txtModFolderPath.BackColor = System.Drawing.SystemColors.Info;
            this.txtModFolderPath.Location = new System.Drawing.Point(105, 34);
            this.txtModFolderPath.Name = "txtModFolderPath";
            this.txtModFolderPath.ReadOnly = true;
            this.txtModFolderPath.Size = new System.Drawing.Size(322, 23);
            this.txtModFolderPath.TabIndex = 1;
            this.txtModFolderPath.Text = "C:\\path\\to\\mods\\folder";
            this.txtModFolderPath.WordWrap = false;
            this.txtModFolderPath.TextChanged += new System.EventHandler(this.txtModFolderPath_TextChanged);
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
            this.mnuContextFolderRemove,
            this.mnuContextFolderRename,
            this.mnuContextFolderSeparator,
            this.mnuContextFolderCopyAsNew,
            this.mnuContextCopyToSelected,
            this.mnuContextFolderRefresh});
            this.mnuContextFolderList.Name = "mnuContextFolderList";
            this.mnuContextFolderList.Size = new System.Drawing.Size(241, 142);
            // 
            // mnuContextFolderAdd
            // 
            this.mnuContextFolderAdd.Name = "mnuContextFolderAdd";
            this.mnuContextFolderAdd.Size = new System.Drawing.Size(240, 22);
            this.mnuContextFolderAdd.Text = "Add New Folder";
            this.mnuContextFolderAdd.Click += new System.EventHandler(this.mnuModFolderAdd_Click);
            // 
            // mnuContextFolderRemove
            // 
            this.mnuContextFolderRemove.Name = "mnuContextFolderRemove";
            this.mnuContextFolderRemove.Size = new System.Drawing.Size(240, 22);
            this.mnuContextFolderRemove.Text = "Remove Folder";
            this.mnuContextFolderRemove.Click += new System.EventHandler(this.mnuModFolderRemove_Click);
            // 
            // mnuContextFolderRename
            // 
            this.mnuContextFolderRename.Name = "mnuContextFolderRename";
            this.mnuContextFolderRename.Size = new System.Drawing.Size(240, 22);
            this.mnuContextFolderRename.Text = "Rename Folder";
            this.mnuContextFolderRename.Click += new System.EventHandler(this.mnuContextFolderRename_Click);
            // 
            // mnuContextFolderSeparator
            // 
            this.mnuContextFolderSeparator.Name = "mnuContextFolderSeparator";
            this.mnuContextFolderSeparator.Size = new System.Drawing.Size(237, 6);
            // 
            // mnuContextFolderCopyAsNew
            // 
            this.mnuContextFolderCopyAsNew.Name = "mnuContextFolderCopyAsNew";
            this.mnuContextFolderCopyAsNew.Size = new System.Drawing.Size(240, 22);
            this.mnuContextFolderCopyAsNew.Text = "Copy Selected as New Folder";
            this.mnuContextFolderCopyAsNew.Click += new System.EventHandler(this.mnuModFolderCopyAsNewFolder_Click);
            // 
            // mnuContextCopyToSelected
            // 
            this.mnuContextCopyToSelected.Name = "mnuContextCopyToSelected";
            this.mnuContextCopyToSelected.Size = new System.Drawing.Size(240, 22);
            this.mnuContextCopyToSelected.Text = "Copy Mod(s) to Selected Folder";
            this.mnuContextCopyToSelected.Click += new System.EventHandler(this.mnuModCopyToSelected_Click);
            // 
            // mnuContextFolderRefresh
            // 
            this.mnuContextFolderRefresh.Name = "mnuContextFolderRefresh";
            this.mnuContextFolderRefresh.Size = new System.Drawing.Size(240, 22);
            this.mnuContextFolderRefresh.Text = "Refresh Lists";
            this.mnuContextFolderRefresh.Click += new System.EventHandler(this.mnuContextFolderRefresh_Click);
            // 
            // mnuContextFileList
            // 
            this.mnuContextFileList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContexstFileRemove,
            this.mnuContextFileSeparator,
            this.mnuContextModCopyToAll,
            this.mnuContextFilesRefreshLists});
            this.mnuContextFileList.Name = "mnuContextFileList";
            this.mnuContextFileList.Size = new System.Drawing.Size(203, 76);
            // 
            // mnuContexstFileRemove
            // 
            this.mnuContexstFileRemove.Name = "mnuContexstFileRemove";
            this.mnuContexstFileRemove.Size = new System.Drawing.Size(202, 22);
            this.mnuContexstFileRemove.Text = "Remove Mod File";
            this.mnuContexstFileRemove.Click += new System.EventHandler(this.mnuModFileRemove_Click);
            // 
            // mnuContextFileSeparator
            // 
            this.mnuContextFileSeparator.Name = "mnuContextFileSeparator";
            this.mnuContextFileSeparator.Size = new System.Drawing.Size(199, 6);
            // 
            // mnuContextModCopyToAll
            // 
            this.mnuContextModCopyToAll.Name = "mnuContextModCopyToAll";
            this.mnuContextModCopyToAll.Size = new System.Drawing.Size(202, 22);
            this.mnuContextModCopyToAll.Text = "Copy Mod to All Folders";
            this.mnuContextModCopyToAll.Click += new System.EventHandler(this.mnuModFileCopyToAll_Click);
            // 
            // mnuContextFilesRefreshLists
            // 
            this.mnuContextFilesRefreshLists.Name = "mnuContextFilesRefreshLists";
            this.mnuContextFilesRefreshLists.Size = new System.Drawing.Size(202, 22);
            this.mnuContextFilesRefreshLists.Text = "Refresh Lists";
            this.mnuContextFilesRefreshLists.Click += new System.EventHandler(this.mnuContextFolderRefresh_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 571);
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
        private ToolStripMenuItem mnuContextModCopyToAll;
        private ToolStripMenuItem mnuContextFolderAdd;
        private ToolStripSeparator mnuContextFolderSeparator;
        private ToolStripMenuItem mnuContextFolderRefresh;
        private ToolStripMenuItem mnuCopyAsNewFolder;
        private ToolStripMenuItem mnuContextFolderCopyAsNew;
        private ToolStripMenuItem mnuContextFolderRename;
        private ToolStripMenuItem mnuOptionsOpenOptsDirectory;
        private ToolStripMenuItem mnuModFolderRename;
        private ToolStripMenuItem mnuModsFolderOpen;
        private ToolStripSeparator mnuModsSeparator;
        private ToolStripMenuItem mnuModsRefreshLists;
        private ToolStripMenuItem mnuContextFilesRefreshLists;
        private ToolStripMenuItem mnuModsLaunchModhub;
        private ToolStripMenuItem mnuContextCopyToSelected;
    }
}