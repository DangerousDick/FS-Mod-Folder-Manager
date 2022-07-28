namespace FS22_Mod_Manager
{
    using System.Diagnostics;       // for Process class
    using Microsoft.VisualBasic;    // for input box
    using System.IO.Compression;

    public partial class frmMain : Form
    {
        // constant values
        const string version = "V1.4.7";
        // private variables to be set on form load
        private string AppTempDirectory = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            "AppData\\Local\\FS22_Mod_Manager");
        private string gameSettingsXmlFile = "";
        private string gameXmlFile = "";
        // static member variable for initialising log file class
        static private string LogFileName = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            "AppData\\Local\\FS22_Mod_Manager\\FsModManager.log");
        static private Logger logger = new Logger(LogFileName, true);
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            /*
             * actions to carry out at application start
             */
            // Window location
            this.Location = Settings.Default.MainWindowLocation;
            logger.LogWrite("Application started", true);
            // get user settings and set xml paths
            read_user_settings();
            gameSettingsXmlFile = Path.Join(Settings.Default.UserDataPath, "gameSettings.xml");
            gameXmlFile = Path.Join(Settings.Default.UserDataPath, "game.xml");

            // populate lists
            try
            {
                if (Directory.Exists(txtModFolderPath.Text))
                {
                    populate_folder_list();
                    populate_file_list();
                }
                else
                {
                    stsStatusLabel.Text = "ERROR: Mod folder path not found";
                    logger.LogWrite(stsStatusLabel.Text, true);
                }
            }
            catch (IOException ex)
            {
                logger.LogWrite(ex.Message, true);
            }
            // get mod folder override settings from gameSettings.xml
            read_mod_override_from_xml();
            game_xml_controls_element();
            update_mod_override_values();
            read_scalability_options();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            /* 
             * actions to carry out at application exit
             */
            logger.LogWrite("Application closing", true);
            write_user_settings();
        }

        /*
         * MENU EVENT HANDLERS
         */

        private void mnuFileOpenUserDataDir_Click(object sender, EventArgs e)
        {
            /*
             * Opens the user data directory in Windows default file manager
             */
            open_with_default_app(txtUserDataPath.Text);
        }

        private void mnuFileOpenGameSettingsXml_Click(object sender, EventArgs e)
        {
            /*
             * Opens the Farming Sinlator gameSetting.xml file
             */
            open_with_default_app(txtUserDataPath.Text + "\\gameSettings.xml");

        }

        private void mnuFileOpenGameXml_Click(object sender, EventArgs e)
        {
            /*
             * Opens the Farming Sinlator game.xml file
             */
            open_with_default_app(txtUserDataPath.Text + "\\game.xml");
        }

        private void mnuFileZipGameDataDirectory_Click(object sender, EventArgs e)
        {
            /*
             *  Create a zip file from the game data directory
            */
            string folderName = txtUserDataPath.Text;
            string zipName = txtUserDataPath.Text + ".zip";
            stsStatusLabel.Text = "Creating zip please wait...";
            if (File.Exists(zipName))
            {
                string message = "Do you want to overwrite existing zip file?";
                string caption = "Zip file already exists";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                if (System.Windows.Forms.DialogResult.Yes == MessageBox.Show(message, caption, buttons))
                {
                    // delete the folder
                    logger.LogWrite("deleting file " + zipName);
                    File.Delete(zipName);
                }
                else
                {
                    stsStatusLabel.Text = "Zip creation caneled";
                    return;
                }
            }
            try
            {
                ZipFile.CreateFromDirectory(folderName, zipName, CompressionLevel.Fastest, true);
            }
            catch(Exception ex)
            {
                stsStatusLabel.Text = "Zip creation failed!";
                logger.LogWrite("ERROR: Zip creation failed!\n" + ex.Message);
            }
            stsStatusLabel.Text = "Zip created";
        }

        private void mnuFileRefresh_Click(object sender, EventArgs e)
        {
            /*
             *  Refresh folder lists and game file data
             */
            populate_folder_list();
            populate_file_list();
            read_mod_override_from_xml();
            game_xml_controls_element();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            /*
             * Closes the application
             */
            this.Close();
        }

        private void mnuModFolderAdd_Click(object sender, EventArgs e)
        {
            /*
             * Creates a new mod folder and adds it to the list
             */
            string new_folder = create_new_mod_folder();
            if ("" != new_folder)
            {
                logger.LogWrite(new_folder + " created");
                if (Directory.Exists(new_folder))
                {
                    populate_folder_list();
                    lstModFolders.SelectedIndex = lstModFolders.FindString(Path.GetFileName(new_folder));
                    populate_file_list();
                }
            }
        }

        private void mnuModFolderRemove_Click(object sender, EventArgs e)
        {
            /*
             * Deletes a mod folder from the directory and removes it from the list
             */
            string remove_folder = Path.Join(txtModFolderPath.Text, lstModFolders.Text);
            if (lstModFolders.Items.Count > 0)
            {
                // remove folder
                string message = "Are you sure you want to remove folder " + lstModFolders.Text + "?";
                string caption = "Deleteing folder from disk";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                
                // Displays the MessageBox.
                if (System.Windows.Forms.DialogResult.Yes == MessageBox.Show(message, caption, buttons))
                {
                    // delete the folder
                    logger.LogWrite("Removing folder: " + remove_folder);
                    Directory.Delete(remove_folder, true);
                    populate_folder_list();
                    populate_file_list();
                }
            }
        }

        private void mnuModFolderCopyAsNewFolder_Click(object sender, EventArgs e)
        {
            /*
            *  Create a new folder and copy contents of an existing folder.
            *  e.g. Create new map folder and copy your favourite mods.
            */
            string new_folder = create_new_mod_folder();
            string existing_folder = Path.Join(txtModFolderPath.Text, lstModFolders.Text);
            logger.LogWrite("Creating " + new_folder + " From " + existing_folder);
            try
            {
                if (Directory.Exists(new_folder) && Directory.Exists(existing_folder))
                {
                    // Get the files in the source directory and copy to the destination directory
                    var copy_from = new DirectoryInfo(existing_folder);
                    foreach (FileInfo file in copy_from.GetFiles())
                    {
                        string targetFilePath = Path.Combine(new_folder, file.Name);
                        file.CopyTo(targetFilePath);
                        logger.LogWrite(file.FullName + " --> " + targetFilePath);
                    }
                    lstModFolders.Items.Add(Path.GetFileName(new_folder));
                    logger.LogWrite(new_folder + " created");
                }
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.ToString());
            }
        }

        private void mnuModFolderOpen_Click(object sender, EventArgs e)
        {
            /*
             * Opens the mods folder in Windows default file manager
             */
            open_with_default_app(txtModFolderPath.Text);
        }

        private void mnuModFileRemove_Click(object sender, EventArgs e)
        {
            /*
             * Deletes the mod file from the directory and removes it from the list
             */
            string del_file = Path.Join(txtModFolderPath.Text, lstModFolders.Text, lstModFiles.Text);
            logger.LogWrite("DELETING file " + del_file);
            try
            {
                File.Delete(del_file);
                populate_file_list();
            }
            catch (Exception ex) 
            {
                logger.LogWrite(ex.Message);
            }
        }

        private void mnuModCopyToSelected_Click(object sender, EventArgs e)
        {
            /* 
             * Opens the file dialog box to select mod file(s) to copy to the selected mod folder
             */
            string init_dir = "C:\\";
            if (Directory.Exists(Path.Join(txtModFolderPath.Text, lstModFolders.Text)))
            {
                init_dir = Path.Join(txtModFolderPath.Text, lstModFolders.Text);
            }
            try
            {
                string[] file_list = get_file_list(init_dir, "Zip files (*.zip)|*.zip|All files (*.*)|*.*");
                if (null != file_list && file_list.Length > 0)
                {
                    for (int i = 0; i < file_list.Length; i++)
                    {
                        string dest_file = Path.Join(txtModFolderPath.Text, lstModFolders.Text, Path.GetFileName(file_list[i]));
                        logger.LogWrite("\t" + file_list[i] + " -> " + dest_file);
                        try
                        {
                            if (mnuOptOverwriteOnCopy.Checked) { File.Copy(file_list[i], dest_file, true); } // overwrite set to true
                            else { File.Copy(file_list[i], dest_file, false); }
                        }
                        catch (Exception ex)
                        {
                            logger.LogWrite(ex.Message);
                        }
                    }
                    populate_file_list();
                }
            }
            catch (Exception ex)
            { 
                logger.LogWrite(ex.Message);
            }
        }

        private void mnuModFileCopyToAll_Click(object sender, EventArgs e)
        {
            /*
             * Open file dialog box to select mod file(s) to copy to ALL folders in the mod folder list
             * */
            string init_dir = "C:\\";
            if (Directory.Exists(Path.Join(txtModFolderPath.Text, lstModFolders.Text)))
            {
                init_dir = Path.Join(txtModFolderPath.Text, lstModFolders.Text);
            }
            try
            {
                string[] file_list = get_file_list(init_dir, "Zip files (*.zip)|*.zip|All files (*.*)|*.*");
                if (null != file_list && file_list.Length > 0)
                {
                    for (int i = 0; i < file_list.Length; i++)
                    {
                        foreach (string folder in lstModFolders.Items)
                        {
                            string dest_file = Path.Join(txtModFolderPath.Text, folder, Path.GetFileName(file_list[i]));
                            logger.LogWrite("\t" + file_list[i] + " -> " + dest_file);
                            try
                            {
                                if (file_list[i] != dest_file)
                                {
                                    if (mnuOptOverwriteOnCopy.Checked) { File.Copy(file_list[i], dest_file, true); } // overwrite set to true
                                    else { File.Copy(file_list[i], dest_file, false); }
                                }
                            }
                            catch (Exception ex)
                            {
                                logger.LogWrite(ex.Message);
                            }
                        }
                    }
                    populate_file_list();
                }
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message);
            }
        }

        private void mnuModsLaunchModhub_Click(object sender, EventArgs e)
        {
            /*
             * Launches the mod hub web page
             */
            try
            {
                open_with_default_app("https://www.farming-simulator.com/mods.php");
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message);
            }

        }

        private void mnuOptionsOpenOptsDirectory_Click(object sender, EventArgs e)
        {
            /*
             * Opens the settings temporary directory in Windows default file manager
             */
            open_with_default_app(AppTempDirectory);
        }

        private void mnuOptLaunchConsole_Click(object sender, EventArgs e)
        {
            /*
             * Checks/Unchecks the launch with console option and writes value to xml
             */
            Settings.Default.LaunchWithConsole = mnuOptLaunchConsole.Checked;
            game_xml_controls_element(true);
            if (mnuOptLaunchLaunchCheats.Checked)
            {
                // uncheck this option and update settings file as it requires the console to use
                mnuOptLaunchLaunchCheats.Checked = false;
                Settings.Default.LaunchWithCheats = false;
            }
        }

        private void mnuOptLaunchLaunchCheats_Click(object sender, EventArgs e)
        {
            /*
             * Checks/Unchecks the launch with cheats option
             */
            Settings.Default.LaunchWithCheats = true;
            // console needs to be set to use cheats
            if (false == Settings.Default.LaunchWithConsole)
            {
                mnuOptLaunchConsole.Checked = true;
                Settings.Default.LaunchWithConsole = true;
                game_xml_controls_element(true);
            }
        }

        private void mnuOptLaunchRestart_Click(object sender, EventArgs e)
        {
            /*
             * Checks/Unchecks the launch as restart option
             */
            Settings.Default.LaunchAsRestart = mnuOptLaunchRestart.Checked;
        }

        private void mnuHelpOpen_Click(object sender, EventArgs e)
        {
            /*
             * Launches the help files
             */
            try
            {
                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                open_with_default_app(projectDirectory + "\\help\\help.html");
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message);
            }
        }

        private void mnuOptScalabilityOptions_Click(object sender, EventArgs e)
        {
            /*
            * show scalability options dialog box
            */
            ScalabilityOptions so = new ScalabilityOptions();
            so.ShowDialog();
            if (true == so.returnOK)
            {
                write_scalability_options();
            }
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            /*
             * launches a message with information about the application
             */
            try
            {
                string[] about_info = new string[]
                {
                    "Copyright Richard Sayer 2022",
                    "Farming Simulator 22 Mods Folder Manager " + version,
                    "Application to manage farming simulator mod folders"
                };
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(String.Join("\n", about_info), "About Mod Manager", buttons);
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message);
            }
        }

        /*
         * Context menu events
         */

        private void lstModFolders_MouseUp(object sender, MouseEventArgs e)
        {
            /*
             * Right click mod folder list event handler
             * Shows context menu
             */
            int location = lstModFolders.IndexFromPoint(e.Location);
            if (e.Button == MouseButtons.Right)
            {
                lstModFolders.SelectedIndex = location;                //Index selected
                mnuContextFolderList.Show(PointToScreen(e.Location));   //Show Menu
            }
        }

        private void lstModFiles_MouseUp(object sender, MouseEventArgs e)
        {
            /*
             * Right click mod files list event handler
             * Shows context menu
             */
            int location = lstModFiles.IndexFromPoint(e.Location);
            if (e.Button == MouseButtons.Right)
            {
                lstModFiles.SelectedIndex = location;                //Index selected
                mnuContextFileList.Show(PointToScreen(e.Location));   //Show Menu
            }
        }

        private void mnuContextFolderRefresh_Click(object sender, EventArgs e)
        {
            /*
             *  Refresh folder lists and game file data
             */
            logger.LogWrite("Refreshing application data fields", true);
            string selected_folder = lstModFolders.Text;
            string selected_file = lstModFiles.Text;
            // refresh lists
            populate_folder_list();
            lstModFolders.SelectedIndex = lstModFolders.FindString(Path.GetFileName(selected_folder));
            populate_file_list();
            lstModFiles.SelectedIndex = lstModFiles.FindString(Path.GetFileName(selected_file));
            // refresh game file data
            read_mod_override_from_xml();
            game_xml_controls_element();
        }

        private void mnuContextFolderRename_Click(object sender, EventArgs e)
        {
            /*
             * Renames the currently selected folder
             * Gets the new folder name from the InputBox
             */
            try
            {
                // get source folder 
                string src_dir = Path.Join(txtModFolderPath.Text, lstModFolders.Text);
                // get destination folder
                string fld_name = Interaction.InputBox("Enter folder name?", "Rename Folder", lstModFolders.Text);
                if (fld_name != "")
                {
                    string dest_dir = Path.Join(txtModFolderPath.Text, fld_name);
                    // rename folder
                    if (Directory.Exists(src_dir))
                    {
                        try
                        {
                            logger.LogWrite("Renaming folder " + src_dir + " to " + dest_dir, true);
                            Directory.Move(src_dir, dest_dir);
                            populate_folder_list();
                            lstModFolders.SelectedIndex = lstModFolders.FindString(Path.GetFileName(fld_name));
                            populate_file_list();
                        }
                        catch (IOException ex)
                        { logger.LogWrite("Failed to rename folder\n" + ex.Message); }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message);
            }
        }

        /*
         * TEXTBOX EVENTS
         */

        private void txtModOverrideValues_TextChanged(object sender, EventArgs e)
        {
            /*
             *  add scroll to end funtionality so the end of the path is visible 
             */
            logger.LogWrite("Mod override values changed: " + txtModOverrideValues.Text);
            try
            {
                txtModOverrideValues.Select(txtModOverrideValues.TextLength, 0);
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message);
            }
        }

        private void txtModFolderPath_TextChanged(object sender, EventArgs e)
        {
            /*
             *  add scroll to end funtionality so the end of the path is visible 
             */
            logger.LogWrite("Mod folder path changed: " + txtModFolderPath.Text);
            try
            { 
                txtModFolderPath.Select(txtModFolderPath.TextLength, 0);
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message);
            }
        }

        private void txtUserDataPath_TextChanged(object sender, EventArgs e)
        {
            /*
             *  add scroll to end funtionality so the end of the path is visible 
             */
            logger.LogWrite("User data path changed: " + txtUserDataPath.Text);
            try
            {
                txtUserDataPath.Select(txtUserDataPath.TextLength, 0);
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message);
            }
        }

        private void txtGameExeFile_TextChanged(object sender, EventArgs e)
        {
            /*
             *  add scroll to end funtionality so the end of the path is visible 
             */
            logger.LogWrite("Game EXE changed: " + txtGameExeFile.Text);
            try
            {
                txtGameExeFile.Select(txtGameExeFile.TextLength, 0);
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message);
            }
        }

        /*
         * BUTTON EVENT HANDLERS
         */

        private void btnModFolderPath_Click(object sender, EventArgs e)
        {
            /*
             * Mod folder path browse button clicked to so launch 
             * file dialog to select or create new folder
             */
            using (FolderBrowserDialog ofd = new FolderBrowserDialog())
            {
                try
                { 
                    string init_dir = txtModFolderPath.Text;
                    if (!Directory.Exists(init_dir))
                    {
                        init_dir = "C:\\";
                    }
                    ofd.InitialDirectory = init_dir;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //Show in textbox
                        txtModFolderPath.Text = ofd.SelectedPath;
                        populate_folder_list();
                        populate_file_list();
                    }
                }
                catch (Exception ex)
                {
                    logger.LogWrite(ex.Message);
                }
            }
        }

        private void btnUserDataPath_Click(object sender, EventArgs e)
        {
            /*
             * User data path browse button clicked so launch file dialog to select folder
             */
            using (FolderBrowserDialog ofd = new FolderBrowserDialog())
            {
                try
                { 
                    ofd.InitialDirectory = txtUserDataPath.Text;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //Show in textbox
                        txtUserDataPath.Text = ofd.SelectedPath;
                    }
                }
                catch (Exception ex)
                {
                    logger.LogWrite(ex.Message);
                }
            }
        }


        private void btnGameExeFile_Click(object sender, EventArgs e)
        {
            /*
             * Game exe file path browse button clicked to so launch 
             * file dialog to select a different game exe file
             */
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                try
                { 
                    string ini_dir = "C:\\";
                    if (Directory.Exists(Path.GetDirectoryName(txtGameExeFile.Text)))
                    {
                        ini_dir = Path.GetDirectoryName(txtGameExeFile.Text);
                    }
                    ofd.InitialDirectory = ini_dir;
                    ofd.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
                    ofd.FilterIndex = 1;
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //Show in textbox
                        txtGameExeFile.Text = ofd.FileName;
                    }
                    else
                    {
                        stsStatusLabel.Text = "ERROR: Failed to select file";
                        logger.LogWrite(stsStatusLabel.Text, true);
                    }
                }
                catch (Exception ex)
                {
                    logger.LogWrite(ex.Message);
                }
            }
        }

        private void btnSetModOverride_Click(object sender, EventArgs e)
        {
            /*
             * Udate the application settings and gameSettings.xml file
             */
            write_mod_override_to_xml();
            update_mod_override_values();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            /*
             * Call the menu exit event handler to exit the game
             */
            mnuFileExit_Click(sender, e);
        }


        private void btnLaunchGame_Click(object sender, EventArgs e)
        {
            /*
             * Launch FarmingSimulator2022.exe
             */
            List<string> args = new List<string>();
            
            if (mnuOptLaunchRestart.Checked)
            {
                args.Add(" -restart");
            }
            if (mnuOptLaunchLaunchCheats.Checked)
            {
                args.Add(" -cheats");
            }
            run_exe_proces(txtGameExeFile.Text, args.ToArray());
        }

        /*
         * LISTBOX EVENT HANDLERS
         */

        private void lstModFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * Refresh the mod files list box
             */
            populate_file_list();
        }

        private void lstModFolders_DoubleClick(object sender, EventArgs e)
        {
            /*
             * If the launch on double click option is checked update the xml and launch the game
             */
            if (true == mnuOptModDoubleClick.Checked)
            {
                btnSetModOverride_Click(sender, e);
                btnLaunchGame_Click(sender, e);
            }
        }

       private void lstModFiles_DoubleClick(object sender, EventArgs e)
        {
            /*
             * Show mod file in Windows default application
             */
            string mod_file_name = Path.Join(txtModFolderPath.Text, lstModFolders.Text, lstModFiles.Text);
            open_with_default_app(mod_file_name);
        }

        /*
         * PRIVATE MEMBER METHODS
         */

        private void update_mod_override_values()
        {
            /*
             * Update the textbox showing the mod override vales
             */
            try
            {
                txtModOverrideValues.Text = "Override folder=" + mnuOptModOverride.Checked.ToString() +
                                            " : Dierctory=" + Path.Join(txtModFolderPath.Text, lstModFolders.Text);
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message);
            }
        }

        private string[] get_file_list(string init_dir, string file_filter)
        {
            /*
             * Use the open file dialog class to get a list of mod files
             * */
            logger.LogWrite("Getting file list");
            List<string> file_list = new List<string>();
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                try
                { 
                    ofd.InitialDirectory = init_dir;
                    ofd.Multiselect = true;
                    ofd.Filter = "Zip files (*.zip)|*.zip|All files (*.*)|*.*";
                    ofd.FilterIndex = 1;
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //Show in textbox
                        string[] selected_files = ofd.FileNames;
                        for (int i = 0; i < selected_files.Length; i++)
                        {
                            file_list.Add(selected_files[i]);
                            logger.LogWrite("Add file " + selected_files[i] + " to list");
                        }
                        return file_list.ToArray();
                    }
                    else
                    {
                        stsStatusLabel.Text = "No file selected";
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    logger.LogWrite(ex.Message);
                }
            }
            return file_list.ToArray();
        }

        public string create_new_mod_folder()
        {
            /*
             * Creates a new folder under the mods folder path
             * Get new folder name from the InputBox
             */
            // get new folder name
            string new_folder = Interaction.InputBox("New folder name?", "New Folder");
            if (new_folder.Length > 0)
            {
                new_folder = Path.Join(txtModFolderPath.Text, new_folder);
                // create new folder and update lists
                logger.LogWrite("Creating new folder");
                try
                {
                    Directory.CreateDirectory(new_folder);
                }
                catch (IOException ex)
                {
                    logger.LogWrite("Folder creation error: " + ex.Message, true);
                    return "";
                }
                return new_folder;
            }
            return "";
        }

        private void read_user_settings()
        {
            /*
             * Read the user settings file and set the application values
             */
            logger.LogWrite("Getting default user settings");
            try
            { 
                // get textbox values
                txtModFolderPath.Text = Settings.Default.ModFolderPath;
                if (false == Directory.Exists(Settings.Default.UserDataPath))
                {
                    // on initial start you may need to add the user home directiry to the user data path
                    string user_data_path = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                        Settings.Default.UserDataPath);
                    if (Directory.Exists(user_data_path))
                    {
                        Settings.Default.UserDataPath = user_data_path;
                    }
                }
                txtUserDataPath.Text = Settings.Default.UserDataPath;
                if (false == File.Exists(Settings.Default.GameExePath))
                {
                    /*
                     * On initial run the game exe may be in a different location so Try steamapps
                     * look into how to check other prividers like Origin and Epic
                     */
                    string game_exe_path =
                        "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Farming Simulator 2022\\FarmingSimulator2022.exe";
                    if (File.Exists(game_exe_path))
                    {
                        Settings.Default.GameExePath = game_exe_path;
                    }
                }
                txtGameExeFile.Text = Settings.Default.GameExePath;
                // get options menu settings
                mnuOptModDoubleClick.Checked = Settings.Default.AllowDoubleClick;
                mnuOptModOverride.Checked = Settings.Default.ModFodlerOverride;
                mnuOptOverwriteOnCopy.Checked = Settings.Default.OverwriteOnCopy;
                mnuOptLaunchConsole.Checked = Settings.Default.LaunchWithConsole;
                mnuOptLaunchLaunchCheats.Checked = Settings.Default.LaunchWithCheats;
                mnuOptLaunchRestart.Checked = Settings.Default.LaunchAsRestart;

                log_user_settings();
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message);
            }
        }

        private void write_user_settings()
        {
            /*
             * Write the application user settings to file
             */
            logger.LogWrite("Saving default user settings");
            // textbox values
            Settings.Default.ModFolderPath = txtModFolderPath.Text;
            Settings.Default.UserDataPath = txtUserDataPath.Text;
            Settings.Default.GameExePath = txtGameExeFile.Text;
            // options menu settings
            Settings.Default.AllowDoubleClick = mnuOptModDoubleClick.Checked;
            Settings.Default.ModFodlerOverride = mnuOptModOverride.Checked;
            Settings.Default.OverwriteOnCopy = mnuOptOverwriteOnCopy.Checked;
            Settings.Default.LaunchWithConsole = mnuOptLaunchConsole.Checked;
            Settings.Default.LaunchWithCheats = mnuOptLaunchLaunchCheats.Checked;
            Settings.Default.LaunchAsRestart = mnuOptLaunchRestart.Checked;
            // Window location
            Settings.Default.MainWindowLocation = this.Location;
            Settings.Default.Save();
            log_user_settings();
        }

        private void log_user_settings()
        {
            /*
             * Write the application user settings to the log file
             */
            logger.LogWrite("User settings", true);
            // textbox values
            logger.LogWrite("Folder path = " + Settings.Default.ModFolderPath.ToString());
            logger.LogWrite("User data path = " + Settings.Default.UserDataPath.ToString());
            logger.LogWrite("Game EXE path = " + Settings.Default.GameExePath.ToString());
            // options menu settings
            logger.LogWrite("Option AllowDoubleClick = " + Settings.Default.AllowDoubleClick.ToString());
            logger.LogWrite("Option ModFodlerOverride = " + Settings.Default.ModFodlerOverride.ToString());
            logger.LogWrite("Option OverwriteOnCopy = " + Settings.Default.OverwriteOnCopy.ToString());
            logger.LogWrite("Option LaunchWithConsole = " + Settings.Default.LaunchWithConsole.ToString());
            logger.LogWrite("Option LaunchWithCheats= " + Settings.Default.LaunchWithCheats.ToString());
            logger.LogWrite("Option LaunchAsRestart = " + Settings.Default.LaunchAsRestart.ToString());
            // Window location
            logger.LogWrite("Window Position = " + Settings.Default.MainWindowLocation.ToString());
        }

        private void read_mod_override_from_xml()
        {
            /*
             * Read the gameSettings.xml file and get the attribute values
             * element name is modsDirectoryOverride
             * attributes are active="true/false" and directory="c:\path\string"
             */
            logger.LogWrite("Getting mod override values from gameSettings.xml");
            try
            { 
                System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
                xmlDoc.Load(gameSettingsXmlFile);
                System.Xml.XmlNodeList elemList = xmlDoc.GetElementsByTagName("modsDirectoryOverride");
                if (elemList.Count > 0)
                {
                    for (int i = 0; i < elemList.Count; i++)
                    {
                        string attrActive = elemList[i].Attributes["active"].Value;
                        string attrDir = elemList[i].Attributes["directory"].Value;
                        // there is only one override element in the file
                        if ("true" == attrActive)
                        {
                            mnuOptModOverride.Checked = true;
                            string dirname = Path.GetFileName(attrDir);
                            if (Directory.Exists(Path.Join(txtModFolderPath.Text, dirname)))
                            {
                                lstModFolders.SetSelected(lstModFolders.FindString(dirname), true);
                            }
                        }
                        else
                        {
                            mnuOptModOverride.Checked = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message);
            }
        }

        private void write_mod_override_to_xml()
        {
            /*
             * Read the gameSettings.xml file and get the attribute values
             * element name is modsDirectoryOverride
             * attributes are active="true/false" and directory="c:\path\string"
             */
            logger.LogWrite("Saving mod override values to gameSettings.xml", true);
            System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
            xmlDoc.Load(gameSettingsXmlFile);
            System.Xml.XmlNodeList elemList = xmlDoc.GetElementsByTagName("modsDirectoryOverride");
            if (elemList.Count > 0)
            {
                for (int i = 0; i < elemList.Count; i++)
                {
                    // set attributes
                    elemList[i].Attributes["active"].Value = mnuOptModOverride.Checked.ToString().ToLower();
                    elemList[i].Attributes["directory"].Value = Path.Join(txtModFolderPath.Text, lstModFolders.Text);
                }
                xmlDoc.Save(gameSettingsXmlFile);
            }
        }

        private void read_scalability_options()
        {
            /*
             * Read the game.xml file and get the scalability element value
             * <scalability>
             *      <performanceClass>Medium</performanceClass>
             *      <lodDistanceCoeff>1.000000</lodDistanceCoeff>
             *      <terrainLODDistanceCoeff>1.000000</terrainLODDistanceCoeff>
             *      <foliageViewDistanceCoeff>1.000000</foliageViewDistanceCoeff>
             * </scalability>
             * 
             * The Coeff values are a percentage 1.000000 is 100%
            */
            string val;
            val = read_xml_file_element(gameXmlFile, "performanceClass");
            if (val.Length > 0) { Settings.Default.performanceClass = val; }
            val = read_xml_file_element(gameXmlFile, "lodDistanceCoeff");
            if (val.Length > 0) { Settings.Default.lodDistanceCoeff = val; }
            val = read_xml_file_element(gameXmlFile, "terrainLODDistanceCoeff");
            if (val.Length > 0) { Settings.Default.terrainLODDistanceCoeff = val; }
            val = read_xml_file_element(gameXmlFile, "foliageViewDistanceCoeff");
            if (val.Length > 0) { Settings.Default.foliageViewDistanceCoeff = val; }
        }

        private void write_scalability_options()
        {
            /*
             * Write the scalability element values to the game.xml file
             * <scalability>
             *      <performanceClass>Medium</performanceClass>
             *      <lodDistanceCoeff>1.000000</lodDistanceCoeff>
             *      <terrainLODDistanceCoeff>1.000000</terrainLODDistanceCoeff>
             *      <foliageViewDistanceCoeff>1.000000</foliageViewDistanceCoeff>
             * </scalability>
             * 
             * The Coeff values are a percentage 1.000000 is 100%
            */
            write_xml_file_element_value(gameXmlFile, "performanceClass", Settings.Default.performanceClass);
            write_xml_file_element_value(gameXmlFile, "lodDistanceCoeff", Settings.Default.lodDistanceCoeff);
            write_xml_file_element_value(gameXmlFile, "terrainLODDistanceCoeff", Settings.Default.terrainLODDistanceCoeff);
            write_xml_file_element_value(gameXmlFile, "foliageViewDistanceCoeff", Settings.Default.foliageViewDistanceCoeff);
        }

        private string read_xml_file_element(string xmlFileName, string elementName)
        {
            /*
             * Read the XML file xmlFileName and get the elementName value
            */
            logger.LogWrite("getting " + elementName + " From " + xmlFileName) ;
            try
            {
                System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
                xmlDoc.Load(xmlFileName);
                System.Xml.XmlNodeList elemList = xmlDoc.GetElementsByTagName(elementName);
                if (elemList.Count > 0)
                {
                    // set scalability settings to value in xml file
                    string elementValue = elemList[0].InnerXml;
                    logger.LogWrite(elementName + " = " + elementValue);
                    if (elementValue != null && elementValue.Length > 0) { return elementValue; }
                    else { return ""; }
                }
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message);
            }
            return null;
        }

        private string write_xml_file_element_value(string xmlFileName, string elementName, string elementValue)
        {
            /*
             * Write the value of elementName to the XML file xmlFileName
            */
            logger.LogWrite("writting " + elementName + " to " + xmlFileName);
            try
            {
                System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
                xmlDoc.Load(xmlFileName);
                System.Xml.XmlNodeList elemList = xmlDoc.GetElementsByTagName(elementName);
                if (elemList.Count > 0)
                {
                    // write the element value and save document
                    elemList[0].InnerXml = elementValue;
                    xmlDoc.Save(gameXmlFile);
                    //<lodDistanceCoeff>1.000000</lodDistanceCoeff>
                    logger.LogWrite("\t<" + elementName + ">" + elementValue + "</" + elementName + ">");
                }
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message);
            }
            return null;
        }

        private void game_xml_controls_element(bool write_value=false)
        {
            /*
             * Read the game.xml file and get the controls element value
             * <development>
             *      <controls>"false"</controls>   <-- this is the console enable element "true" is enabled
             *      <openDevConsole onWarnings="false" onErrors="false"/>
             * </development>
             */
            logger.LogWrite("Getting console settings from game.xml");
            try
            { 
                System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
                xmlDoc.Load(gameXmlFile);
                System.Xml.XmlNodeList elemList = xmlDoc.GetElementsByTagName("controls");
                if (elemList.Count > 0)
                {
                    if (true == write_value)
                    {
                        // set element to mnuOptLaunchConsole.Checked and save file
                        elemList[0].InnerXml = mnuOptLaunchConsole.Checked.ToString().ToLower();
                        xmlDoc.Save(gameXmlFile);
                    }
                    else
                    {
                        // set mnuOptLaunchConsole.Checked to value in xml file
                        if ("true" == elemList[0].InnerXml)
                        {
                            mnuOptLaunchConsole.Checked = true;
                            Settings.Default.LaunchWithConsole = true;
                        }
                        else
                        {
                            mnuOptLaunchConsole.Checked = false;
                            Settings.Default.LaunchWithConsole = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message);
            }
        }

        private void populate_file_list()
        {
            /*
             * Populate the mod files list from the mod folder list selected item
             */
            logger.LogWrite("Populating mod files list box from " + lstModFolders.Text);
            try
            { 
                if (lstModFiles.Items.Count > 0)
                {
                    lstModFiles.Items.Clear();
                }
                if (lstModFolders.Items.Count > 0)
                {
                    string mfp = Path.Join(txtModFolderPath.Text, lstModFolders.Text);
                    string[] files = Directory.GetFiles(mfp);
                    foreach (string file in files)
                    {
                        lstModFiles.Items.Add(Path.GetFileName(file));
                    }
                    lblModFileCount.Text = string.Format("{0} Files", lstModFiles.Items.Count.ToString());
                }
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message);
            }
        }

        private void populate_folder_list()
        {
            /*
             * Get the folders from the mod folder path and populate the list box
             */
            logger.LogWrite("Populating mod folders list box from " + txtModFolderPath.Text);
            try
            { 
                if (Directory.Exists(txtModFolderPath.Text))
                {
                    string[] dirs = Directory.GetDirectories(txtModFolderPath.Text);
                    if (lstModFolders.Items.Count > 0)
                    {
                        lstModFolders.Items.Clear();
                    }
                    foreach (string dir in dirs)
                    {
                        if (Directory.Exists(dir))
                        {
                            lstModFolders.Items.Add(Path.GetFileName(dir));
                        }
                    }
                    if (lstModFolders.Items.Count > 0)
                    {
                        lstModFolders.SelectedIndex = 0;
                    }
                    lblModFolderCount.Text = string.Format("{0} Folders", lstModFolders.Items.Count.ToString());
                }
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message);
            }
        }

        static void run_exe_proces(string exe_name, string[] args)
        {
            /*
             * Launch a process such as the FarmingSimulator2022.exe file
             */
            // join arguments
            string arguments = String.Join(" ", args.Where(s => !String.IsNullOrEmpty(s)));
            logger.LogWrite("Starting process: " + exe_name + " " + arguments, true);

            // Use ProcessStartInfo class
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = true;
            startInfo.FileName = exe_name;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = arguments;

            try
            {
                Process exeProcess = Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                logger.LogWrite(ex.Message, true);
            }
        }

        public static void open_with_default_app(string file_name)
        {
            /*
             * Open a file in the default application
             */
            logger.LogWrite("Opening : " + file_name, true);
            try
            {
                Process fileopener = new Process();
                fileopener.StartInfo.FileName = "explorer";
                fileopener.StartInfo.Arguments = "\"" + file_name + "\"";
                fileopener.Start();
            }
            catch (IOException ex)
            {
                logger.LogWrite(ex.Message, true);
            }
        }

        private void mnuFileOpenModMangerLog_Click(object sender, EventArgs e)
        {
            open_with_default_app(AppTempDirectory + "\\FsModManager.log");
        }

        private void mnuFileOpenGameLog_Click(object sender, EventArgs e)
        {
            open_with_default_app(txtUserDataPath.Text + "\\log.txt");
        }
    }
}