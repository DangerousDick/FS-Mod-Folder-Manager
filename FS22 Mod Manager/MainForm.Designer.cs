namespace FS_Mod_Manager
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            mnuApplicationMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileOpenUserDataDir = new ToolStripMenuItem();
            mnuFileOpenGameSettingsXml = new ToolStripMenuItem();
            mnuFileOpenGameXml = new ToolStripMenuItem();
            mnuFileSeparator1 = new ToolStripSeparator();
            mnuFileRefresh = new ToolStripMenuItem();
            mnuFileOpenModMangerLog = new ToolStripMenuItem();
            mnuFileOpenGameLog = new ToolStripMenuItem();
            mnuFileOpenGameNotes = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuFileZipGameDataDirectory = new ToolStripMenuItem();
            mnuFileSeparator2 = new ToolStripSeparator();
            mnuFileExit = new ToolStripMenuItem();
            mnuMods = new ToolStripMenuItem();
            mnuModsFolder = new ToolStripMenuItem();
            mnuModFolderAdd = new ToolStripMenuItem();
            mnuModFolderRemove = new ToolStripMenuItem();
            mnuModFolderRename = new ToolStripMenuItem();
            mnuCopyAsNewFolder = new ToolStripMenuItem();
            MnuModsFile = new ToolStripMenuItem();
            mnuModFileRemove = new ToolStripMenuItem();
            mnuModFileCopyToSelected = new ToolStripMenuItem();
            mnuModFileCopyToAll = new ToolStripMenuItem();
            mnuModsSeparator = new ToolStripSeparator();
            mnuModsFolderOpen = new ToolStripMenuItem();
            mnuModsLaunchModhub = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            mnuModsCreateNewFolder = new ToolStripMenuItem();
            mnuOptions = new ToolStripMenuItem();
            mnuOptMod = new ToolStripMenuItem();
            mnuOptModDoubleClick = new ToolStripMenuItem();
            mnuOptModOverride = new ToolStripMenuItem();
            mnuOptOverwriteOnCopy = new ToolStripMenuItem();
            mnuOptdDleteToRecycleBin = new ToolStripMenuItem();
            mnuOptOnlyShowZips = new ToolStripMenuItem();
            mnuModLaunch = new ToolStripMenuItem();
            mnuOptLaunchConsole = new ToolStripMenuItem();
            mnuOptLaunchLaunchCheats = new ToolStripMenuItem();
            mnuOptLaunchRestart = new ToolStripMenuItem();
            mnuOptionsOpenOptsDirectory = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            mnuHelpOpen = new ToolStripMenuItem();
            mnuHelpSeparator = new ToolStripSeparator();
            mnuHelpAbout = new ToolStripMenuItem();
            stsStatusBar = new StatusStrip();
            stsStatusLabel = new ToolStripStatusLabel();
            pnlLists = new Panel();
            lblModFileCount = new Label();
            lstModFiles = new ListBox();
            lblModFiles = new Label();
            lblModFolderCount = new Label();
            lstModFolders = new ListBox();
            lblModFolders = new Label();
            panel1 = new Panel();
            lblUpdateMoney = new Label();
            btnUpdateMoney = new Button();
            txtMoney = new TextBox();
            cmbSavegameDirs = new ComboBox();
            btnChangeCharacterName = new Button();
            txtCharacterName = new TextBox();
            lblCharacterName = new Label();
            btnExit = new Button();
            lblModOverrideValues = new Label();
            txtModOverrideValues = new TextBox();
            btnLaunchGame = new Button();
            btnSetModOverride = new Button();
            btnGameExeFile = new Button();
            txtGameExeFile = new TextBox();
            lblGameExeFile = new Label();
            btnUserDataPath = new Button();
            txtUserDataPath = new TextBox();
            lblUserDataPath = new Label();
            btnModFolderPath = new Button();
            txtModFolderPath = new TextBox();
            lblModFolderPath = new Label();
            mnuContextFolderList = new ContextMenuStrip(components);
            mnuContextFolderAdd = new ToolStripMenuItem();
            mnuContextFolderRemove = new ToolStripMenuItem();
            mnuContextFolderRename = new ToolStripMenuItem();
            mnuContextFolderSeparator = new ToolStripSeparator();
            mnuContextCopyToSelected = new ToolStripMenuItem();
            mnuContextFolderCopyAsNew = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            mnuContextOpenGameNotes = new ToolStripMenuItem();
            mnuContextFileList = new ContextMenuStrip(components);
            mnuContexstFileRemove = new ToolStripMenuItem();
            mnuContextFileSeparator = new ToolStripSeparator();
            mnuContextModCopyToAll = new ToolStripMenuItem();
            mnuApplicationMain.SuspendLayout();
            stsStatusBar.SuspendLayout();
            pnlLists.SuspendLayout();
            panel1.SuspendLayout();
            mnuContextFolderList.SuspendLayout();
            mnuContextFileList.SuspendLayout();
            SuspendLayout();
            // 
            // mnuApplicationMain
            // 
            mnuApplicationMain.ImageScalingSize = new Size(24, 24);
            mnuApplicationMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuMods, mnuOptions, mnuHelp });
            mnuApplicationMain.Location = new Point(0, 0);
            mnuApplicationMain.Name = "mnuApplicationMain";
            mnuApplicationMain.Padding = new Padding(9, 3, 0, 3);
            mnuApplicationMain.Size = new Size(757, 35);
            mnuApplicationMain.TabIndex = 0;
            mnuApplicationMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileOpenUserDataDir, mnuFileOpenGameSettingsXml, mnuFileOpenGameXml, mnuFileSeparator1, mnuFileRefresh, mnuFileOpenModMangerLog, mnuFileOpenGameLog, mnuFileOpenGameNotes, toolStripMenuItem1, mnuFileZipGameDataDirectory, mnuFileSeparator2, mnuFileExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(54, 29);
            mnuFile.Text = "File";
            // 
            // mnuFileOpenUserDataDir
            // 
            mnuFileOpenUserDataDir.Name = "mnuFileOpenUserDataDir";
            mnuFileOpenUserDataDir.ShortcutKeys = Keys.F2;
            mnuFileOpenUserDataDir.Size = new Size(359, 34);
            mnuFileOpenUserDataDir.Text = "Open Game Data Directory";
            mnuFileOpenUserDataDir.Click += mnuFileOpenUserDataDir_Click;
            // 
            // mnuFileOpenGameSettingsXml
            // 
            mnuFileOpenGameSettingsXml.Name = "mnuFileOpenGameSettingsXml";
            mnuFileOpenGameSettingsXml.ShortcutKeys = Keys.F3;
            mnuFileOpenGameSettingsXml.Size = new Size(359, 34);
            mnuFileOpenGameSettingsXml.Text = "Open gameSettings.xml";
            mnuFileOpenGameSettingsXml.Click += mnuFileOpenGameSettingsXml_Click;
            // 
            // mnuFileOpenGameXml
            // 
            mnuFileOpenGameXml.Name = "mnuFileOpenGameXml";
            mnuFileOpenGameXml.ShortcutKeys = Keys.F4;
            mnuFileOpenGameXml.Size = new Size(359, 34);
            mnuFileOpenGameXml.Text = "Open game.xml";
            mnuFileOpenGameXml.Click += mnuFileOpenGameXml_Click;
            // 
            // mnuFileSeparator1
            // 
            mnuFileSeparator1.Name = "mnuFileSeparator1";
            mnuFileSeparator1.Size = new Size(356, 6);
            // 
            // mnuFileRefresh
            // 
            mnuFileRefresh.Name = "mnuFileRefresh";
            mnuFileRefresh.ShortcutKeys = Keys.F5;
            mnuFileRefresh.Size = new Size(359, 34);
            mnuFileRefresh.Text = "Refresh Data";
            mnuFileRefresh.Click += mnuFileRefresh_Click;
            // 
            // mnuFileOpenModMangerLog
            // 
            mnuFileOpenModMangerLog.Name = "mnuFileOpenModMangerLog";
            mnuFileOpenModMangerLog.Size = new Size(359, 34);
            mnuFileOpenModMangerLog.Text = "Open Mod Manager Log";
            mnuFileOpenModMangerLog.Click += mnuFileOpenModMangerLog_Click;
            // 
            // mnuFileOpenGameLog
            // 
            mnuFileOpenGameLog.Name = "mnuFileOpenGameLog";
            mnuFileOpenGameLog.Size = new Size(359, 34);
            mnuFileOpenGameLog.Text = "Open Game Log";
            mnuFileOpenGameLog.Click += mnuFileOpenGameLog_Click;
            // 
            // mnuFileOpenGameNotes
            // 
            mnuFileOpenGameNotes.Name = "mnuFileOpenGameNotes";
            mnuFileOpenGameNotes.Size = new Size(359, 34);
            mnuFileOpenGameNotes.Text = "Open Game notes";
            mnuFileOpenGameNotes.Click += mnuFileOpenGameNotes_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(356, 6);
            // 
            // mnuFileZipGameDataDirectory
            // 
            mnuFileZipGameDataDirectory.Name = "mnuFileZipGameDataDirectory";
            mnuFileZipGameDataDirectory.Size = new Size(359, 34);
            mnuFileZipGameDataDirectory.Text = "Zip Game Data Directory";
            mnuFileZipGameDataDirectory.Click += mnuFileZipGameDataDirectory_Click;
            // 
            // mnuFileSeparator2
            // 
            mnuFileSeparator2.Name = "mnuFileSeparator2";
            mnuFileSeparator2.Size = new Size(356, 6);
            // 
            // mnuFileExit
            // 
            mnuFileExit.Name = "mnuFileExit";
            mnuFileExit.ShortcutKeys = Keys.Alt | Keys.X;
            mnuFileExit.Size = new Size(359, 34);
            mnuFileExit.Text = "Exit";
            mnuFileExit.Click += mnuFileExit_Click;
            // 
            // mnuMods
            // 
            mnuMods.DropDownItems.AddRange(new ToolStripItem[] { mnuModsFolder, MnuModsFile, mnuModsSeparator, mnuModsFolderOpen, mnuModsLaunchModhub, toolStripMenuItem3, mnuModsCreateNewFolder });
            mnuMods.Name = "mnuMods";
            mnuMods.Size = new Size(113, 29);
            mnuMods.Text = "Mods Files";
            // 
            // mnuModsFolder
            // 
            mnuModsFolder.DropDownItems.AddRange(new ToolStripItem[] { mnuModFolderAdd, mnuModFolderRemove, mnuModFolderRename, mnuCopyAsNewFolder });
            mnuModsFolder.Name = "mnuModsFolder";
            mnuModsFolder.Size = new Size(310, 34);
            mnuModsFolder.Text = "Mod Folder Actions";
            // 
            // mnuModFolderAdd
            // 
            mnuModFolderAdd.Name = "mnuModFolderAdd";
            mnuModFolderAdd.Size = new Size(344, 34);
            mnuModFolderAdd.Text = "Add New Folder";
            mnuModFolderAdd.Click += mnuModFolderAdd_Click;
            // 
            // mnuModFolderRemove
            // 
            mnuModFolderRemove.Name = "mnuModFolderRemove";
            mnuModFolderRemove.Size = new Size(344, 34);
            mnuModFolderRemove.Text = "Remove Selected Folder";
            mnuModFolderRemove.Click += mnuModFolderRemove_Click;
            // 
            // mnuModFolderRename
            // 
            mnuModFolderRename.Name = "mnuModFolderRename";
            mnuModFolderRename.Size = new Size(344, 34);
            mnuModFolderRename.Text = "Rename Folder";
            mnuModFolderRename.Click += mnuContextFolderRename_Click;
            // 
            // mnuCopyAsNewFolder
            // 
            mnuCopyAsNewFolder.Name = "mnuCopyAsNewFolder";
            mnuCopyAsNewFolder.Size = new Size(344, 34);
            mnuCopyAsNewFolder.Text = "Copy Selected as New Folder";
            mnuCopyAsNewFolder.Click += mnuModFolderCopyAsNewFolder_Click;
            // 
            // MnuModsFile
            // 
            MnuModsFile.DropDownItems.AddRange(new ToolStripItem[] { mnuModFileRemove, mnuModFileCopyToSelected, mnuModFileCopyToAll });
            MnuModsFile.Name = "MnuModsFile";
            MnuModsFile.Size = new Size(310, 34);
            MnuModsFile.Text = "Mod File Actions";
            // 
            // mnuModFileRemove
            // 
            mnuModFileRemove.Name = "mnuModFileRemove";
            mnuModFileRemove.Size = new Size(393, 34);
            mnuModFileRemove.Text = "Remove Selected Mod File";
            mnuModFileRemove.Click += mnuModFileRemove_Click;
            // 
            // mnuModFileCopyToSelected
            // 
            mnuModFileCopyToSelected.Name = "mnuModFileCopyToSelected";
            mnuModFileCopyToSelected.Size = new Size(393, 34);
            mnuModFileCopyToSelected.Text = "Copy Mod file(s) to Selected Folder";
            mnuModFileCopyToSelected.Click += mnuModCopyToSelected_Click;
            // 
            // mnuModFileCopyToAll
            // 
            mnuModFileCopyToAll.Name = "mnuModFileCopyToAll";
            mnuModFileCopyToAll.Size = new Size(393, 34);
            mnuModFileCopyToAll.Text = "Copy Mod to ALL Folders";
            mnuModFileCopyToAll.Click += mnuModFileCopyToAll_Click;
            // 
            // mnuModsSeparator
            // 
            mnuModsSeparator.Name = "mnuModsSeparator";
            mnuModsSeparator.Size = new Size(307, 6);
            // 
            // mnuModsFolderOpen
            // 
            mnuModsFolderOpen.Name = "mnuModsFolderOpen";
            mnuModsFolderOpen.ShortcutKeys = Keys.F6;
            mnuModsFolderOpen.Size = new Size(310, 34);
            mnuModsFolderOpen.Text = "Open Mods Folder";
            mnuModsFolderOpen.Click += mnuModFolderOpen_Click;
            // 
            // mnuModsLaunchModhub
            // 
            mnuModsLaunchModhub.Name = "mnuModsLaunchModhub";
            mnuModsLaunchModhub.ShortcutKeys = Keys.F7;
            mnuModsLaunchModhub.Size = new Size(310, 34);
            mnuModsLaunchModhub.Text = "Launch Mod Hub";
            mnuModsLaunchModhub.Click += mnuModsLaunchModhub_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(307, 6);
            // 
            // mnuModsCreateNewFolder
            // 
            mnuModsCreateNewFolder.Name = "mnuModsCreateNewFolder";
            mnuModsCreateNewFolder.Size = new Size(310, 34);
            mnuModsCreateNewFolder.Text = "Create New Mods Folder";
            mnuModsCreateNewFolder.Click += mnuModsCreateNewFolder_Click;
            // 
            // mnuOptions
            // 
            mnuOptions.DropDownItems.AddRange(new ToolStripItem[] { mnuOptMod, mnuModLaunch, mnuOptionsOpenOptsDirectory });
            mnuOptions.Name = "mnuOptions";
            mnuOptions.Size = new Size(92, 29);
            mnuOptions.Text = "Options";
            // 
            // mnuOptMod
            // 
            mnuOptMod.DropDownItems.AddRange(new ToolStripItem[] { mnuOptModDoubleClick, mnuOptModOverride, mnuOptOverwriteOnCopy, mnuOptdDleteToRecycleBin, mnuOptOnlyShowZips });
            mnuOptMod.Name = "mnuOptMod";
            mnuOptMod.Size = new Size(344, 34);
            mnuOptMod.Text = "Mod Options";
            // 
            // mnuOptModDoubleClick
            // 
            mnuOptModDoubleClick.CheckOnClick = true;
            mnuOptModDoubleClick.Name = "mnuOptModDoubleClick";
            mnuOptModDoubleClick.Size = new Size(399, 34);
            mnuOptModDoubleClick.Text = "Allow Double Click Folder to Launch";
            // 
            // mnuOptModOverride
            // 
            mnuOptModOverride.CheckOnClick = true;
            mnuOptModOverride.Name = "mnuOptModOverride";
            mnuOptModOverride.Size = new Size(399, 34);
            mnuOptModOverride.Text = "Mod Folder Override";
            mnuOptModOverride.Click += mnuOptModOverride_Click;
            // 
            // mnuOptOverwriteOnCopy
            // 
            mnuOptOverwriteOnCopy.CheckOnClick = true;
            mnuOptOverwriteOnCopy.Name = "mnuOptOverwriteOnCopy";
            mnuOptOverwriteOnCopy.Size = new Size(399, 34);
            mnuOptOverwriteOnCopy.Text = "Overwrite on Copy";
            // 
            // mnuOptdDleteToRecycleBin
            // 
            mnuOptdDleteToRecycleBin.CheckOnClick = true;
            mnuOptdDleteToRecycleBin.Name = "mnuOptdDleteToRecycleBin";
            mnuOptdDleteToRecycleBin.Size = new Size(399, 34);
            mnuOptdDleteToRecycleBin.Text = "Delete to Recycle Bin";
            // 
            // mnuOptOnlyShowZips
            // 
            mnuOptOnlyShowZips.CheckOnClick = true;
            mnuOptOnlyShowZips.Name = "mnuOptOnlyShowZips";
            mnuOptOnlyShowZips.Size = new Size(399, 34);
            mnuOptOnlyShowZips.Text = "Only Show Zip Files";
            mnuOptOnlyShowZips.Click += mnuOptOnlyShowZips_Click;
            // 
            // mnuModLaunch
            // 
            mnuModLaunch.DropDownItems.AddRange(new ToolStripItem[] { mnuOptLaunchConsole, mnuOptLaunchLaunchCheats, mnuOptLaunchRestart });
            mnuModLaunch.Name = "mnuModLaunch";
            mnuModLaunch.Size = new Size(344, 34);
            mnuModLaunch.Text = "Launch Options";
            // 
            // mnuOptLaunchConsole
            // 
            mnuOptLaunchConsole.CheckOnClick = true;
            mnuOptLaunchConsole.Name = "mnuOptLaunchConsole";
            mnuOptLaunchConsole.Size = new Size(349, 34);
            mnuOptLaunchConsole.Text = "Launch with In-Game Console";
            mnuOptLaunchConsole.Click += mnuOptLaunchConsole_Click;
            // 
            // mnuOptLaunchLaunchCheats
            // 
            mnuOptLaunchLaunchCheats.CheckOnClick = true;
            mnuOptLaunchLaunchCheats.Name = "mnuOptLaunchLaunchCheats";
            mnuOptLaunchLaunchCheats.Size = new Size(349, 34);
            mnuOptLaunchLaunchCheats.Text = "Launch with Console Cheats";
            mnuOptLaunchLaunchCheats.Click += mnuOptLaunchLaunchCheats_Click;
            // 
            // mnuOptLaunchRestart
            // 
            mnuOptLaunchRestart.CheckOnClick = true;
            mnuOptLaunchRestart.Name = "mnuOptLaunchRestart";
            mnuOptLaunchRestart.Size = new Size(349, 34);
            mnuOptLaunchRestart.Text = "Launch as Restart";
            mnuOptLaunchRestart.Click += mnuOptLaunchRestart_Click;
            // 
            // mnuOptionsOpenOptsDirectory
            // 
            mnuOptionsOpenOptsDirectory.Name = "mnuOptionsOpenOptsDirectory";
            mnuOptionsOpenOptsDirectory.Size = new Size(344, 34);
            mnuOptionsOpenOptsDirectory.Text = "Open User Settings Directory";
            mnuOptionsOpenOptsDirectory.Click += mnuOptionsOpenOptsDirectory_Click;
            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuHelpOpen, mnuHelpSeparator, mnuHelpAbout });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(65, 29);
            mnuHelp.Text = "Help";
            // 
            // mnuHelpOpen
            // 
            mnuHelpOpen.Name = "mnuHelpOpen";
            mnuHelpOpen.ShortcutKeys = Keys.F1;
            mnuHelpOpen.Size = new Size(182, 34);
            mnuHelpOpen.Text = "Help";
            mnuHelpOpen.Click += mnuHelpOpen_Click;
            // 
            // mnuHelpSeparator
            // 
            mnuHelpSeparator.Name = "mnuHelpSeparator";
            mnuHelpSeparator.Size = new Size(179, 6);
            // 
            // mnuHelpAbout
            // 
            mnuHelpAbout.Name = "mnuHelpAbout";
            mnuHelpAbout.Size = new Size(182, 34);
            mnuHelpAbout.Text = "About";
            mnuHelpAbout.Click += mnuHelpAbout_Click;
            // 
            // stsStatusBar
            // 
            stsStatusBar.ImageScalingSize = new Size(24, 24);
            stsStatusBar.Items.AddRange(new ToolStripItem[] { stsStatusLabel });
            stsStatusBar.Location = new Point(0, 991);
            stsStatusBar.Name = "stsStatusBar";
            stsStatusBar.Padding = new Padding(1, 0, 20, 0);
            stsStatusBar.Size = new Size(757, 32);
            stsStatusBar.TabIndex = 1;
            // 
            // stsStatusLabel
            // 
            stsStatusLabel.Name = "stsStatusLabel";
            stsStatusLabel.Size = new Size(273, 25);
            stsStatusLabel.Text = "Farming simulator Mod Manager";
            // 
            // pnlLists
            // 
            pnlLists.Controls.Add(lblModFileCount);
            pnlLists.Controls.Add(lstModFiles);
            pnlLists.Controls.Add(lblModFiles);
            pnlLists.Controls.Add(lblModFolderCount);
            pnlLists.Controls.Add(lstModFolders);
            pnlLists.Controls.Add(lblModFolders);
            pnlLists.Location = new Point(0, 45);
            pnlLists.Margin = new Padding(4, 5, 4, 5);
            pnlLists.Name = "pnlLists";
            pnlLists.Size = new Size(740, 575);
            pnlLists.TabIndex = 4;
            // 
            // lblModFileCount
            // 
            lblModFileCount.AutoSize = true;
            lblModFileCount.Location = new Point(351, 540);
            lblModFileCount.Margin = new Padding(4, 0, 4, 0);
            lblModFileCount.Name = "lblModFileCount";
            lblModFileCount.Size = new Size(91, 25);
            lblModFileCount.TabIndex = 5;
            lblModFileCount.Text = "File Count";
            // 
            // lstModFiles
            // 
            lstModFiles.FormattingEnabled = true;
            lstModFiles.ItemHeight = 25;
            lstModFiles.Location = new Point(351, 47);
            lstModFiles.Margin = new Padding(4, 5, 4, 5);
            lstModFiles.Name = "lstModFiles";
            lstModFiles.Size = new Size(371, 479);
            lstModFiles.TabIndex = 4;
            lstModFiles.DoubleClick += lstModFiles_DoubleClick;
            lstModFiles.MouseUp += lstModFiles_MouseUp;
            // 
            // lblModFiles
            // 
            lblModFiles.AutoSize = true;
            lblModFiles.Location = new Point(351, 18);
            lblModFiles.Margin = new Padding(4, 0, 4, 0);
            lblModFiles.Name = "lblModFiles";
            lblModFiles.Size = new Size(90, 25);
            lblModFiles.TabIndex = 3;
            lblModFiles.Text = "Mod FIles";
            // 
            // lblModFolderCount
            // 
            lblModFolderCount.AutoSize = true;
            lblModFolderCount.Location = new Point(17, 540);
            lblModFolderCount.Margin = new Padding(4, 0, 4, 0);
            lblModFolderCount.Name = "lblModFolderCount";
            lblModFolderCount.Size = new Size(115, 25);
            lblModFolderCount.TabIndex = 2;
            lblModFolderCount.Text = "Folder Count";
            // 
            // lstModFolders
            // 
            lstModFolders.FormattingEnabled = true;
            lstModFolders.ItemHeight = 25;
            lstModFolders.Location = new Point(17, 47);
            lstModFolders.Margin = new Padding(4, 5, 4, 5);
            lstModFolders.Name = "lstModFolders";
            lstModFolders.Size = new Size(313, 479);
            lstModFolders.TabIndex = 1;
            lstModFolders.SelectedIndexChanged += lstModFolders_SelectedIndexChanged;
            lstModFolders.DoubleClick += lstModFolders_DoubleClick;
            lstModFolders.MouseUp += lstModFolders_MouseUp;
            // 
            // lblModFolders
            // 
            lblModFolders.AutoSize = true;
            lblModFolders.Location = new Point(17, 18);
            lblModFolders.Margin = new Padding(4, 0, 4, 0);
            lblModFolders.Name = "lblModFolders";
            lblModFolders.Size = new Size(113, 25);
            lblModFolders.TabIndex = 0;
            lblModFolders.Text = "Mod Folders";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUpdateMoney);
            panel1.Controls.Add(btnUpdateMoney);
            panel1.Controls.Add(txtMoney);
            panel1.Controls.Add(cmbSavegameDirs);
            panel1.Controls.Add(btnChangeCharacterName);
            panel1.Controls.Add(txtCharacterName);
            panel1.Controls.Add(lblCharacterName);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(lblModOverrideValues);
            panel1.Controls.Add(txtModOverrideValues);
            panel1.Controls.Add(btnLaunchGame);
            panel1.Controls.Add(btnSetModOverride);
            panel1.Controls.Add(btnGameExeFile);
            panel1.Controls.Add(txtGameExeFile);
            panel1.Controls.Add(lblGameExeFile);
            panel1.Controls.Add(btnUserDataPath);
            panel1.Controls.Add(txtUserDataPath);
            panel1.Controls.Add(lblUserDataPath);
            panel1.Controls.Add(btnModFolderPath);
            panel1.Controls.Add(txtModFolderPath);
            panel1.Controls.Add(lblModFolderPath);
            panel1.Location = new Point(0, 630);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 356);
            panel1.TabIndex = 5;
            // 
            // lblUpdateMoney
            // 
            lblUpdateMoney.AutoSize = true;
            lblUpdateMoney.Location = new Point(18, 254);
            lblUpdateMoney.Name = "lblUpdateMoney";
            lblUpdateMoney.Size = new Size(130, 25);
            lblUpdateMoney.TabIndex = 20;
            lblUpdateMoney.Text = "Update Money";
            // 
            // btnUpdateMoney
            // 
            btnUpdateMoney.Location = new Point(617, 251);
            btnUpdateMoney.Name = "btnUpdateMoney";
            btnUpdateMoney.Size = new Size(107, 34);
            btnUpdateMoney.TabIndex = 19;
            btnUpdateMoney.Text = "Update";
            btnUpdateMoney.UseVisualStyleBackColor = true;
            btnUpdateMoney.Click += btnUpdateMoney_Click;
            // 
            // txtMoney
            // 
            txtMoney.Location = new Point(432, 249);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(175, 31);
            txtMoney.TabIndex = 18;
            txtMoney.Text = "Money";
            // 
            // cmbSavegameDirs
            // 
            cmbSavegameDirs.FormattingEnabled = true;
            cmbSavegameDirs.Location = new Point(150, 249);
            cmbSavegameDirs.Name = "cmbSavegameDirs";
            cmbSavegameDirs.Size = new Size(265, 33);
            cmbSavegameDirs.TabIndex = 17;
            cmbSavegameDirs.SelectedIndexChanged += cmbSavegameDirs_SelectedIndexChanged;
            // 
            // btnChangeCharacterName
            // 
            btnChangeCharacterName.Location = new Point(583, 195);
            btnChangeCharacterName.Margin = new Padding(4, 5, 4, 5);
            btnChangeCharacterName.Name = "btnChangeCharacterName";
            btnChangeCharacterName.Size = new Size(141, 38);
            btnChangeCharacterName.TabIndex = 16;
            btnChangeCharacterName.Text = "Change Name";
            btnChangeCharacterName.UseVisualStyleBackColor = true;
            btnChangeCharacterName.Click += btnChangeName_Click;
            // 
            // txtCharacterName
            // 
            txtCharacterName.BackColor = SystemColors.InactiveCaption;
            txtCharacterName.Location = new Point(150, 196);
            txtCharacterName.Name = "txtCharacterName";
            txtCharacterName.ReadOnly = true;
            txtCharacterName.Size = new Size(426, 31);
            txtCharacterName.TabIndex = 15;
            // 
            // lblCharacterName
            // 
            lblCharacterName.AutoSize = true;
            lblCharacterName.Location = new Point(11, 196);
            lblCharacterName.Name = "lblCharacterName";
            lblCharacterName.Size = new Size(138, 25);
            lblCharacterName.TabIndex = 14;
            lblCharacterName.Text = "Character Name";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(615, 315);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 38);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblModOverrideValues
            // 
            lblModOverrideValues.AutoSize = true;
            lblModOverrideValues.Location = new Point(11, 18);
            lblModOverrideValues.Margin = new Padding(4, 0, 4, 0);
            lblModOverrideValues.Name = "lblModOverrideValues";
            lblModOverrideValues.Size = new Size(143, 25);
            lblModOverrideValues.TabIndex = 12;
            lblModOverrideValues.Text = "Current Override";
            // 
            // txtModOverrideValues
            // 
            txtModOverrideValues.BackColor = SystemColors.InactiveCaption;
            txtModOverrideValues.Location = new Point(149, 12);
            txtModOverrideValues.Margin = new Padding(4, 5, 4, 5);
            txtModOverrideValues.Name = "txtModOverrideValues";
            txtModOverrideValues.ReadOnly = true;
            txtModOverrideValues.Size = new Size(574, 31);
            txtModOverrideValues.TabIndex = 11;
            txtModOverrideValues.Text = "Mod Override Values";
            txtModOverrideValues.WordWrap = false;
            txtModOverrideValues.TextChanged += txtModOverrideValues_TextChanged;
            // 
            // btnLaunchGame
            // 
            btnLaunchGame.Location = new Point(205, 315);
            btnLaunchGame.Margin = new Padding(4, 5, 4, 5);
            btnLaunchGame.Name = "btnLaunchGame";
            btnLaunchGame.Size = new Size(176, 38);
            btnLaunchGame.TabIndex = 10;
            btnLaunchGame.Text = "Launch Game";
            btnLaunchGame.UseVisualStyleBackColor = true;
            btnLaunchGame.Click += btnLaunchGame_Click;
            // 
            // btnSetModOverride
            // 
            btnSetModOverride.Location = new Point(12, 315);
            btnSetModOverride.Margin = new Padding(4, 5, 4, 5);
            btnSetModOverride.Name = "btnSetModOverride";
            btnSetModOverride.Size = new Size(176, 38);
            btnSetModOverride.TabIndex = 9;
            btnSetModOverride.Text = "Set Mod Override";
            btnSetModOverride.UseVisualStyleBackColor = true;
            btnSetModOverride.Click += btnSetModOverride_Click;
            // 
            // btnGameExeFile
            // 
            btnGameExeFile.Location = new Point(617, 152);
            btnGameExeFile.Margin = new Padding(4, 5, 4, 5);
            btnGameExeFile.Name = "btnGameExeFile";
            btnGameExeFile.Size = new Size(107, 38);
            btnGameExeFile.TabIndex = 8;
            btnGameExeFile.Text = "Browse";
            btnGameExeFile.UseVisualStyleBackColor = true;
            btnGameExeFile.Click += btnGameExeFile_Click;
            // 
            // txtGameExeFile
            // 
            txtGameExeFile.BackColor = SystemColors.Info;
            txtGameExeFile.Location = new Point(149, 153);
            txtGameExeFile.Margin = new Padding(4, 5, 4, 5);
            txtGameExeFile.Name = "txtGameExeFile";
            txtGameExeFile.ReadOnly = true;
            txtGameExeFile.Size = new Size(458, 31);
            txtGameExeFile.TabIndex = 7;
            txtGameExeFile.Text = "C:\\path\\to\\FarmingSimulator2022.exe";
            txtGameExeFile.WordWrap = false;
            txtGameExeFile.TextChanged += txtGameExeFile_TextChanged;
            // 
            // lblGameExeFile
            // 
            lblGameExeFile.AutoSize = true;
            lblGameExeFile.Location = new Point(21, 160);
            lblGameExeFile.Margin = new Padding(4, 0, 4, 0);
            lblGameExeFile.Name = "lblGameExeFile";
            lblGameExeFile.Size = new Size(132, 25);
            lblGameExeFile.TabIndex = 6;
            lblGameExeFile.Text = "Game .exe Path";
            // 
            // btnUserDataPath
            // 
            btnUserDataPath.Location = new Point(617, 103);
            btnUserDataPath.Margin = new Padding(4, 5, 4, 5);
            btnUserDataPath.Name = "btnUserDataPath";
            btnUserDataPath.Size = new Size(107, 38);
            btnUserDataPath.TabIndex = 5;
            btnUserDataPath.Text = "Browse";
            btnUserDataPath.UseVisualStyleBackColor = true;
            btnUserDataPath.Click += btnUserDataPath_Click;
            // 
            // txtUserDataPath
            // 
            txtUserDataPath.BackColor = SystemColors.Info;
            txtUserDataPath.Location = new Point(150, 105);
            txtUserDataPath.Margin = new Padding(4, 5, 4, 5);
            txtUserDataPath.Name = "txtUserDataPath";
            txtUserDataPath.ReadOnly = true;
            txtUserDataPath.Size = new Size(458, 31);
            txtUserDataPath.TabIndex = 4;
            txtUserDataPath.Text = "C:\\Game\\User\\data\\path";
            txtUserDataPath.WordWrap = false;
            txtUserDataPath.TextChanged += txtUserDataPath_TextChanged;
            // 
            // lblUserDataPath
            // 
            lblUserDataPath.AutoSize = true;
            lblUserDataPath.Location = new Point(17, 110);
            lblUserDataPath.Margin = new Padding(4, 0, 4, 0);
            lblUserDataPath.Name = "lblUserDataPath";
            lblUserDataPath.Size = new Size(140, 25);
            lblUserDataPath.TabIndex = 3;
            lblUserDataPath.Text = "Game User Data";
            // 
            // btnModFolderPath
            // 
            btnModFolderPath.Location = new Point(617, 55);
            btnModFolderPath.Margin = new Padding(4, 5, 4, 5);
            btnModFolderPath.Name = "btnModFolderPath";
            btnModFolderPath.Size = new Size(107, 38);
            btnModFolderPath.TabIndex = 2;
            btnModFolderPath.Text = "Browse";
            btnModFolderPath.UseVisualStyleBackColor = true;
            btnModFolderPath.Click += btnModFolderPath_Click;
            // 
            // txtModFolderPath
            // 
            txtModFolderPath.BackColor = SystemColors.Info;
            txtModFolderPath.Location = new Point(150, 57);
            txtModFolderPath.Margin = new Padding(4, 5, 4, 5);
            txtModFolderPath.Name = "txtModFolderPath";
            txtModFolderPath.ReadOnly = true;
            txtModFolderPath.Size = new Size(458, 31);
            txtModFolderPath.TabIndex = 1;
            txtModFolderPath.Text = "C:\\path\\to\\mods\\folder";
            txtModFolderPath.WordWrap = false;
            txtModFolderPath.TextChanged += txtModFolderPath_TextChanged;
            // 
            // lblModFolderPath
            // 
            lblModFolderPath.AutoSize = true;
            lblModFolderPath.Location = new Point(17, 63);
            lblModFolderPath.Margin = new Padding(4, 0, 4, 0);
            lblModFolderPath.Name = "lblModFolderPath";
            lblModFolderPath.Size = new Size(144, 25);
            lblModFolderPath.TabIndex = 0;
            lblModFolderPath.Text = "Mod Folder Path";
            // 
            // mnuContextFolderList
            // 
            mnuContextFolderList.ImageScalingSize = new Size(24, 24);
            mnuContextFolderList.Items.AddRange(new ToolStripItem[] { mnuContextFolderAdd, mnuContextFolderRemove, mnuContextFolderRename, mnuContextFolderSeparator, mnuContextCopyToSelected, mnuContextFolderCopyAsNew, toolStripMenuItem2, mnuContextOpenGameNotes });
            mnuContextFolderList.Name = "mnuContextFolderList";
            mnuContextFolderList.Size = new Size(336, 208);
            // 
            // mnuContextFolderAdd
            // 
            mnuContextFolderAdd.Name = "mnuContextFolderAdd";
            mnuContextFolderAdd.Size = new Size(335, 32);
            mnuContextFolderAdd.Text = "Add New Folder";
            mnuContextFolderAdd.Click += mnuModFolderAdd_Click;
            // 
            // mnuContextFolderRemove
            // 
            mnuContextFolderRemove.Name = "mnuContextFolderRemove";
            mnuContextFolderRemove.Size = new Size(335, 32);
            mnuContextFolderRemove.Text = "Remove Folder";
            mnuContextFolderRemove.Click += mnuModFolderRemove_Click;
            // 
            // mnuContextFolderRename
            // 
            mnuContextFolderRename.Name = "mnuContextFolderRename";
            mnuContextFolderRename.Size = new Size(335, 32);
            mnuContextFolderRename.Text = "Rename Folder";
            mnuContextFolderRename.Click += mnuContextFolderRename_Click;
            // 
            // mnuContextFolderSeparator
            // 
            mnuContextFolderSeparator.Name = "mnuContextFolderSeparator";
            mnuContextFolderSeparator.Size = new Size(332, 6);
            // 
            // mnuContextCopyToSelected
            // 
            mnuContextCopyToSelected.Name = "mnuContextCopyToSelected";
            mnuContextCopyToSelected.Size = new Size(335, 32);
            mnuContextCopyToSelected.Text = "Copy Mod(s) to Selected Folder";
            mnuContextCopyToSelected.Click += mnuModCopyToSelected_Click;
            // 
            // mnuContextFolderCopyAsNew
            // 
            mnuContextFolderCopyAsNew.Name = "mnuContextFolderCopyAsNew";
            mnuContextFolderCopyAsNew.Size = new Size(335, 32);
            mnuContextFolderCopyAsNew.Text = "Copy Selected as New Folder";
            mnuContextFolderCopyAsNew.Click += mnuModFolderCopyAsNewFolder_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(332, 6);
            // 
            // mnuContextOpenGameNotes
            // 
            mnuContextOpenGameNotes.Name = "mnuContextOpenGameNotes";
            mnuContextOpenGameNotes.Size = new Size(335, 32);
            mnuContextOpenGameNotes.Text = "Open Game Notes";
            mnuContextOpenGameNotes.Click += mnuFileOpenGameNotes_Click;
            // 
            // mnuContextFileList
            // 
            mnuContextFileList.ImageScalingSize = new Size(24, 24);
            mnuContextFileList.Items.AddRange(new ToolStripItem[] { mnuContexstFileRemove, mnuContextFileSeparator, mnuContextModCopyToAll });
            mnuContextFileList.Name = "mnuContextFileList";
            mnuContextFileList.Size = new Size(288, 74);
            // 
            // mnuContexstFileRemove
            // 
            mnuContexstFileRemove.Name = "mnuContexstFileRemove";
            mnuContexstFileRemove.Size = new Size(287, 32);
            mnuContexstFileRemove.Text = "Remove Mod File";
            mnuContexstFileRemove.Click += mnuModFileRemove_Click;
            // 
            // mnuContextFileSeparator
            // 
            mnuContextFileSeparator.Name = "mnuContextFileSeparator";
            mnuContextFileSeparator.Size = new Size(284, 6);
            // 
            // mnuContextModCopyToAll
            // 
            mnuContextModCopyToAll.Name = "mnuContextModCopyToAll";
            mnuContextModCopyToAll.Size = new Size(287, 32);
            mnuContextModCopyToAll.Text = "Copy Mod to ALL Folders";
            mnuContextModCopyToAll.Click += mnuContextModCopyToAll_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 1023);
            Controls.Add(panel1);
            Controls.Add(pnlLists);
            Controls.Add(stsStatusBar);
            Controls.Add(mnuApplicationMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnuApplicationMain;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmMain";
            Text = "Farming Simulator Mod Manager";
            FormClosed += frmMain_FormClosed;
            Load += frmMain_Load;
            mnuApplicationMain.ResumeLayout(false);
            mnuApplicationMain.PerformLayout();
            stsStatusBar.ResumeLayout(false);
            stsStatusBar.PerformLayout();
            pnlLists.ResumeLayout(false);
            pnlLists.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mnuContextFolderList.ResumeLayout(false);
            mnuContextFileList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuApplicationMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileOpenUserDataDir;
        private ToolStripSeparator mnuFileSeparator1;
        private ToolStripMenuItem mnuFileExit;
        private ToolStripMenuItem mnuOptions;
        private ToolStripMenuItem mnuHelp;
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
        private ToolStripMenuItem mnuContextFolderCopyAsNew;
        private ToolStripMenuItem mnuContextFolderRename;
        private ToolStripMenuItem mnuOptionsOpenOptsDirectory;
        private ToolStripMenuItem mnuContextCopyToSelected;
        private ToolStripMenuItem mnuFileRefresh;
        private ToolStripSeparator mnuFileSeparator2;
        private ToolStripMenuItem mnuMods;
        private ToolStripMenuItem mnuModsFolder;
        private ToolStripMenuItem mnuModFolderAdd;
        private ToolStripMenuItem mnuModFolderRemove;
        private ToolStripMenuItem mnuModFolderRename;
        private ToolStripMenuItem mnuCopyAsNewFolder;
        private ToolStripMenuItem MnuModsFile;
        private ToolStripMenuItem mnuModFileRemove;
        private ToolStripMenuItem mnuModFileCopyToSelected;
        private ToolStripMenuItem mnuModFileCopyToAll;
        private ToolStripSeparator mnuModsSeparator;
        private ToolStripMenuItem mnuModsFolderOpen;
        private ToolStripMenuItem mnuModsLaunchModhub;
        private ToolStripMenuItem mnuFileOpenModMangerLog;
        private ToolStripMenuItem mnuFileOpenGameLog;
        private ToolStripMenuItem mnuOptOverwriteOnCopy;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuFileZipGameDataDirectory;
        private ToolStripMenuItem mnuOptdDleteToRecycleBin;
        private ToolStripMenuItem mnuFileOpenGameNotes;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem mnuContextOpenGameNotes;
        private ToolStripMenuItem mnuOptOnlyShowZips;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem mnuModsCreateNewFolder;
        private Label lblCharacterName;
        private TextBox txtCharacterName;
        private Button btnChangeCharacterName;
        private ComboBox cmbSavegameDirs;
        private Label lblUpdateMoney;
        private Button btnUpdateMoney;
        private TextBox txtMoney;
    }
}