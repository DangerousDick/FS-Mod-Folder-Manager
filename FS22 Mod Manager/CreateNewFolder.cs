using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;
using System.IO;

namespace FS22_Mod_Manager
{
    public partial class CreateNewFolder : Form
    {
        public string new_folder_name = string.Empty;               // for main form to select new folder in list

        private string favourites_mod_folder_path = string.Empty;   // full path to new mod folder
        private List<string> selected_mods = new List<string>();    // List for selected mods
        private bool NO_SUB_DIRS = false;                           // Flag to indicated selected favourites folder has not subdirectories
        static private Logger logger = new Logger(frmMain.LogFileName, false); // DO NOT CLEAR LOG

        public CreateNewFolder()
        {
            InitializeComponent();
            logger.LogWrite("Initializing create new folder dialog", true);
        }

        private void CreateNewFolder_Load(object sender, EventArgs e)
        {
            /*
             * on form load populate the list boxes using the mod_folder path
             */
            favourites_mod_folder_path = Settings.Default.DefaultFavouritesFolder;
            txtCurrentFavouritesFolder.Text = favourites_mod_folder_path;
            txtDefaultFavouritesFolder.Text = Settings.Default.DefaultFavouritesFolder;
            txtSavedListsPath.Text = Settings.Default.DefaultSavedListsFolder;
            populate_folder_list();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Settings.Default.DefaultFavouritesFolder = txtDefaultFavouritesFolder.Text;
            Settings.Default.DefaultSavedListsFolder = txtSavedListsPath.Text;
            logger.LogWrite("Closing create new folder dialog\n\n", true);
            Close();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            /*
             * create the new folder
             */
            copy_selected_mods();
        }

        private void btnCreateListFromFolder_Click(object sender, EventArgs e)
        {
            /*
             * Creates a new text file list from an existing folder
             * 
             * Looks for the mod zip files in the default favorites folder and use that path by default
             * Any that don't exist in the favourites folders will use the selected folder path
             */
            try
            {

                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    // set initial path
                    string init_dir = Settings.Default.ModFolderPath;
                    if (!Directory.Exists(init_dir))
                    {
                        init_dir = "C:\\";
                    }
                    fbd.InitialDirectory = init_dir;
                    // show folder browser dialog
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        logger.LogWrite("Showing folder dialog");
                        if (Directory.Exists(fbd.SelectedPath))
                        {
                            List<string> mods_list = get_list_from_folder(fbd.SelectedPath);
                            string saved_file_path = Path.Join(txtSavedListsPath.Text, Path.GetFileName(fbd.SelectedPath) + ".txt");
                            save_list_to_file(mods_list, saved_file_path);
                            if (saved_file_path != string.Empty)
                            {
                                // clear current list
                                selected_mods.Clear();
                                lstSelectedModFiles.Items.Clear();
                                // load newly created list
                                read_list_from_file(saved_file_path);
                                populate_selected_files_list();
                            }
                        }
                    }
                    else
                    {
                        logger.LogWrite("No folder selected");
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogWrite($"Error: {ex.Message}");
            }
        }

        private void btnSaveList_Click(object sender, EventArgs e)
        {
            /* 
             * save the list as a text file
             */
            save_list_to_file(lstSelectedModFiles.Items.Cast<string>().ToList());
        }

        private void btnLoadList_Click(object sender, EventArgs e)
        {
            /*
             * load list from saved text file
             */
            read_list_from_file();
            populate_selected_files_list();
        }

        private void btnChangeFolder_Click(object sender, EventArgs e)
        {
            /*
             * select another folder and populate lists
             */
            string path = get_folder_list(favourites_mod_folder_path);
            if (path != "")
            {
                favourites_mod_folder_path = path;
                populate_folder_list();
                txtCurrentFavouritesFolder.Text = favourites_mod_folder_path;
            }
        }

        private void btnDefaultFavourtiesBrowse_Click(object sender, EventArgs e)
        {
            /*
             * Mod folder path browse button clicked so launch 
             * folder dialog to select or create new folder
             */
            using (FolderBrowserDialog ofd = new FolderBrowserDialog())
            {
                try
                {
                    string init_dir = txtDefaultFavouritesFolder.Text;
                    if (!Directory.Exists(init_dir))
                    {
                        init_dir = "C:\\";
                    }
                    ofd.InitialDirectory = init_dir;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //Show in textbox
                        txtDefaultFavouritesFolder.Text = ofd.SelectedPath;
                        populate_folder_list();
                    }
                }
                catch (Exception ex)
                {
                    logger.LogWrite($"Error: {ex.Message}");
                }
            }
        }

        private void btnSavedListsBrowse_Click(object sender, EventArgs e)
        {
            /*
             * Saved lists path browse button clicked so launch 
             * folder dialog to select or create new folder
             */
            using (FolderBrowserDialog ofd = new FolderBrowserDialog())
            {
                try
                {
                    string init_dir = txtSavedListsPath.Text;
                    if (!Directory.Exists(init_dir))
                    {
                        init_dir = "C:\\"; // default is root of C drive
                    }
                    ofd.InitialDirectory = init_dir;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //Show in textbox
                        txtSavedListsPath.Text = ofd.SelectedPath;
                    }
                }
                catch (Exception ex)
                {
                    logger.LogWrite($"Error: {ex.Message}");
                }
            }
        }

        private void lstModFiles_DoubleClick(object sender, EventArgs e)
        {
            /*
             * when double clicking a mod file add it to the selected mods list, no duplicates, and repopulate listbox
             */
            string mod_file_name = "";
            if (NO_SUB_DIRS)
            {
                mod_file_name = Path.Join(favourites_mod_folder_path, lstModFiles.Text);
            }
            else
            {
                mod_file_name = Path.Join(favourites_mod_folder_path, lstFolders.Text, lstModFiles.Text);
            }
            if (selected_mods.FindIndex(x => x.Equals(mod_file_name)) == -1)
            {
                selected_mods.Add(mod_file_name);
            }

            populate_selected_files_list();
        }

        private void lstSelectedModFiles_DoubleClick(object sender, EventArgs e)
        {
            /*
             * remove item from list when double clicked
             */
            string mod_file_name = lstSelectedModFiles.Text;
            selected_mods.RemoveAll(x => x.Equals(mod_file_name));
            populate_selected_files_list();
        }

        private void lstFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate_file_list();
        }

        private void mnuSelectAllMods_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstModFiles.Items.Count > 0)
                {
                    for (int i = 0; i < lstModFiles.Items.Count; i++)
                    {
                        string mod_file_name = Path.Join(favourites_mod_folder_path, lstFolders.Text, lstModFiles.Items[i].ToString());
                        if (selected_mods.FindIndex(x => x.Equals(mod_file_name)) == -1)
                        {
                            selected_mods.Add(mod_file_name);
                        }
                    }
                    populate_selected_files_list();
                }
            }
            catch (Exception ex)
            {
                logger.LogWrite($"Exception: {ex.Message}");
            }
        }

        private void mnuRemoveAll_Click(object sender, EventArgs e)
        {
            lstSelectedModFiles.Items.Clear();
            selected_mods.Clear();
        }

        private void chkIncludeParentDir_CheckedChanged(object sender, EventArgs e)
        {
            populate_file_list();
        }

        private void chkOnlyShowZips_CheckedChanged(object sender, EventArgs e)
        {
            populate_file_list();
        }

        // private methods
        private string get_folder_list(string default_path)
        {
            /*
             * Use the open file dialog class to get a list of folders
             * containing mod files
             * */
            if (default_path != null && default_path.Length > 0)
            {
                // create file
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    try
                    {
                        fbd.InitialDirectory = default_path;
                        fbd.SelectedPath = default_path;
                        if (fbd.ShowDialog() == DialogResult.OK)
                        {
                            return fbd.SelectedPath;
                        }
                    }
                    catch (Exception ex)
                    {
                        logger.LogWrite($"Exception: {ex.Message}");
                    }
                }
            }
            return "";
        }

        private void populate_folder_list()
        {
            /*
             * Get the folders from the mod folder path and populate the list box
             */
            try
            {
                NO_SUB_DIRS = false;
                if (Directory.Exists(favourites_mod_folder_path))
                {
                    string[] dirs = Directory.GetDirectories(favourites_mod_folder_path);
                    if (lstFolders.Items.Count > 0)
                    {
                        lstFolders.Items.Clear();
                    }
                    // handle no subdirectories
                    if (dirs.Length == 0)
                    {
                        NO_SUB_DIRS = true;
                        lstFolders.Items.Clear();
                        lblFoldeerCount.Text = "Folders: " + lstFolders.Items.Count.ToString();
                    }
                    else
                    {
                        foreach (string dir in dirs)
                        {
                            if (Directory.Exists(dir))
                            {
                                lstFolders.Items.Add(Path.GetFileName(dir));
                            }
                        }
                        if (lstFolders.Items.Count > 0)
                        {
                            lstFolders.SelectedIndex = 0;
                        }
                    }
                    lblFoldeerCount.Text = "Folders: " + lstFolders.Items.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                logger.LogWrite($"Exception: {ex.Message}");
            }
            // now populate the mod files list
            populate_file_list();
        }

        private void populate_file_list()
        {
            /*
             * Populate the mod files list from the mod folder list selected item
             */
            try
            {
                if (lstModFiles.Items.Count > 0)
                {
                    lstModFiles.Items.Clear();
                }
                // handle no subdirectories
                if (NO_SUB_DIRS)
                {
                    lstModFiles.Items.Clear();
                    string[] files = Directory.GetFiles(favourites_mod_folder_path);
                    foreach (string file in files)
                    {
                        if (chkOnlyShowZips.Checked && Path.GetExtension(file) == ".zip")
                        {
                            lstModFiles.Items.Add(Path.GetFileName(file));
                        }
                        else if (!chkOnlyShowZips.Checked)
                        {
                            lstModFiles.Items.Add(Path.GetFileName(file));
                        }
                    }
                }
                else
                {
                    string mfp = Path.Join(favourites_mod_folder_path, lstFolders.Text);
                    string[] files = Directory.GetFiles(mfp);
                    foreach (string file in files)
                    {
                        if (chkOnlyShowZips.Checked && Path.GetExtension(file) == ".zip")
                        {
                            lstModFiles.Items.Add(Path.GetFileName(file));
                        }
                        else if (!chkOnlyShowZips.Checked)
                        {
                            lstModFiles.Items.Add(Path.GetFileName(file));
                        }
                    }
                    if (chkIncludeParentDir.Checked)
                    {
                        files = Directory.GetFiles(favourites_mod_folder_path);
                        foreach (string file in files)
                        {
                            if (chkOnlyShowZips.Checked && Path.GetExtension(file) == ".zip")
                            {
                                lstModFiles.Items.Add(Path.GetFileName(file));
                            }
                            else if (!chkOnlyShowZips.Checked)
                            {
                                lstModFiles.Items.Add(Path.GetFileName(file));
                            }
                        }
                    }
                }
                lblModFileCount.Text = "Mod Files: " + lstModFiles.Items.Count.ToString();
            }
            catch (Exception ex)
            {
                logger.LogWrite($"Exception: {ex.Message}");
            }
        }

        private void populate_selected_files_list()
        {
            /*
             * iterate over the selected files list and add to listbox
             */
            if (lstSelectedModFiles.Items.Count > 0)
            {
                lstSelectedModFiles.Items.Clear();
            }
            foreach (string mod_file in selected_mods)
            {
                lstSelectedModFiles.Items.Add(mod_file);
            }
            lblSelectedFileCount.Text = "Selected Files: " + lstSelectedModFiles.Items.Count.ToString();
            lstSelectedModFiles.SelectedIndex = lstSelectedModFiles.Items.Count - 1;
        }

        private void copy_selected_mods()
        {
            /* 
             * use the FolderBrowserDialog to get/create a folder
             * copy the files in selected_mods list to the folder
             */

            try
            {

                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    string init_dir = txtCurrentFavouritesFolder.Text;
                    if (!Directory.Exists(init_dir))
                    {
                        init_dir = "C:\\";
                    }
                    fbd.InitialDirectory = init_dir;

                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        string folder_path = fbd.SelectedPath;
                        new_folder_name = Path.GetFileName(folder_path);
                        logger.LogWrite($"new folder name: {new_folder_name}");
                        //copy files
                        foreach (string selected_file in selected_mods)
                        {
                            string to_filename = Path.Join(folder_path, Path.GetFileName(selected_file));
                            try
                            {
                                if (!File.Exists(to_filename))
                                {
                                    logger.LogWrite($"Copying {selected_file} to {to_filename}");
                                    File.Copy(selected_file, to_filename);
                                }
                            }
                            catch (Exception ex)
                            {
                                logger.LogWrite($"Error: {ex.Message}");
                            }
                        }
                    }
                    else
                    {
                        logger.LogWrite("No folder selected");
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogWrite($"Error: {ex.Message}");
            }
        }

        private void save_list_to_file(List<string> mods_list, string save_file_name = "")
        {
            /*
             * use the StreamWrite to save the list of selected mods to a text file
             */
            if (save_file_name == "")
            {
                // use SaveFileDialog to get or create a text file to write to.
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.InitialDirectory = txtSavedListsPath.Text;
                    sfd.Filter = "Text File|*.txt";
                    sfd.Title = "Save list to text file";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        // get the file name
                        if (sfd.FileName != "")
                        {
                            save_file_name = sfd.FileName;
                        }
                    }
                }
            }
            if (File.Exists(save_file_name))
            {
                // delete file if it already exists so a new clean file is created.
                File.Delete(save_file_name);
            }
            if (save_file_name != "")
            {
                using (StreamWriter sw = File.CreateText(save_file_name))
                {
                    try
                    {
                        // write each item from the list box to the text file
                        foreach (string selected_file in mods_list)
                        {
                            logger.LogWrite($"Adding {selected_file} to {save_file_name}");
                            sw.WriteLine($"{selected_file}");
                        }
                    }
                    catch (Exception ex)
                    {
                        logger.LogWrite($"Error: {ex.Message}");
                    }
                    sw.Close();
                }
            }
        }

        private void read_list_from_file(string read_file_path = "")
        {
            /*
             * Use File.ReadAllLines to load the list from a text file
             */

            logger.LogWrite("load list from text file");
            if (read_file_path == "")
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Text File|*.txt";
                    ofd.Title = "Open saved list";
                    ofd.InitialDirectory = txtSavedListsPath.Text;
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        if (ofd.FileName != "")
                        {
                            read_file_path = ofd.FileName;
                        }
                    }
                }
            }


            if (File.Exists(read_file_path))
            {
                if (lstSelectedModFiles.SelectedItems.Count > 0)
                {
                    // does the user want to clear current list?
                    string message = "Would you like to clear the current list?";
                    string caption = "Load Mod Files From Saved List?";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    // Displays the MessageBox.
                    if (System.Windows.Forms.DialogResult.Yes == MessageBox.Show(message, caption, buttons))
                    {
                        selected_mods.Clear();
                        lstSelectedModFiles.Items.Clear();
                    }
                }

                logger.LogWrite($"Opening file {read_file_path}");
                try
                {
                    string[] lines = File.ReadAllLines(read_file_path);
                    if (lines.Length > 0)
                    {
                        foreach (string l in lines)
                        {
                            add_file_to_selected_mods_list(l);
                        }
                        populate_selected_files_list();
                    }
                }
                catch (Exception ex)
                {
                    logger.LogWrite($"Error: {ex.Message}");
                }
            }
        }

        private void add_file_to_selected_mods_list(string mod_file_name)
        {
            /*
             * adds a file to the list only if it does not already exist
             */
            if (selected_mods.FindIndex(x => x.Equals(mod_file_name)) == -1)
            {
                selected_mods.Add(mod_file_name);
            }
        }

        private List<string> get_list_from_folder(string mod_folder)
        {
            /* 
             * get list of file in mod folder
             */
            List<string> mods_list = new List<string>();
            try
            {
                foreach (string file_path in Directory.GetFiles(mod_folder))
                {
                    if (File.Exists(file_path))
                    {
                        // This path is a file add it to the list if it is a .zip file
                        if (Path.GetExtension(file_path) == ".zip")
                        {
                            //mods_list.Add(Path.GetFileName(file_path));
                            string mod_file = Path.GetFileName(file_path);
                            // is the mod in our favourites folder?
                            var search_result = Directory.EnumerateFiles(favourites_mod_folder_path, mod_file, SearchOption.AllDirectories);
                            if (search_result.Any())
                            {
                                logger.LogWrite($"{search_result.First()}");
                                mods_list.Add(search_result.First());
                            }
                            else
                            {
                                logger.LogWrite(file_path);
                                mods_list.Add(file_path);
                            }
                        }
                    }
                    else if (Directory.Exists(file_path))
                    {
                        // This path is a directory do you want this to be recursive?
                        logger.LogWrite($"Recursive path: {file_path}");
                    }
                    else
                    {
                        // file or path not found so ignore it
                        logger.LogWrite($"Error: {file_path} is not a valid file or directory path.");
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogWrite($"Error: {ex.Message}");
            }
            return mods_list;
        }
    }
}
