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
        public string new_folder_name = "";                         // for main form to select new folder in list

        private string mod_folder_path = "";                        // full path to new mod folder
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
            mod_folder_path = Settings.Default.DefaultFavouritesFolder;
            txtCurrentFavouritesFolder.Text = mod_folder_path;
            txtDefaultFavouritesFolder.Text = Settings.Default.DefaultFavouritesFolder;
            populate_folder_list();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Settings.Default.DefaultFavouritesFolder = txtDefaultFavouritesFolder.Text;
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

        private void btnSaveList_Click(object sender, EventArgs e)
        {
            /* 
             * save the list as a text file
             */
            save_list_to_file();
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
            string path = get_folder_list(mod_folder_path);
            if (path != "")
            {
                mod_folder_path = path;
                populate_folder_list();
                txtCurrentFavouritesFolder.Text = mod_folder_path;
            }
        }

        private void btnDefaultFavourtiesBrowse_Click(object sender, EventArgs e)
        {
            /*
             * Mod folder path browse button clicked to so launch 
             * file dialog to select or create new folder
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

        private void lstModFiles_DoubleClick(object sender, EventArgs e)
        {
            /*
             * when double clicking a mod file add it to the selected mods list, no duplicates, and repopulate listbox
             */
            string mod_file_name = "";
            if (NO_SUB_DIRS)
            {
                mod_file_name = Path.Join(mod_folder_path, lstModFiles.Text);
            }
            else
            {
                mod_file_name = Path.Join(mod_folder_path, lstFolders.Text, lstModFiles.Text);
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
                        string mod_file_name = Path.Join(mod_folder_path, lstFolders.Text, lstModFiles.Items[i].ToString());
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
                MessageBox.Show("Exception: " + ex.Message);
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
                        MessageBox.Show("Exception: " + ex.Message);
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
                if (Directory.Exists(mod_folder_path))
                {
                    string[] dirs = Directory.GetDirectories(mod_folder_path);
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
                MessageBox.Show("Exception: " + ex.Message);
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
                    string[] files = Directory.GetFiles(mod_folder_path);
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
                    string mfp = Path.Join(mod_folder_path, lstFolders.Text);
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
                        files = Directory.GetFiles(mod_folder_path);
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
                MessageBox.Show("Exception: " + ex.Message);
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

        private void save_list_to_file()
        {
            /*
             * use the StreamWrite to save the list of selected mods to a text file
             */

            // use SaveFileDialog to get or create a text file to write to.
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = txtDefaultFavouritesFolder.Text;
                sfd.Filter = "Text File|*.txt";
                sfd.Title = "Save list to text file";
                sfd.ShowDialog();
                // If the file name is not an empty string open it for saving.
                if (sfd.FileName != "")
                {
                    if (File.Exists(sfd.FileName))
                    {
                        // delete file if it already exists so a new clean file is created.
                        File.Delete(sfd.FileName);
                    }
                    using (StreamWriter sw = File.CreateText(sfd.FileName))
                    {
                        try
                        {
                            // write each item from the list box to the text file
                            foreach (string selected_file in lstSelectedModFiles.Items)
                            {
                                logger.LogWrite($"Adding {selected_file} to {sfd.FileName}");
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
        }

        private void read_list_from_file()
        {
            /*
             * Use File.ReadAllLines to load the list from a text file
             */

            logger.LogWrite("load list from text file");
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text File|*.txt";
                ofd.Title = "Open saved list";
                ofd.ShowDialog();
                if (ofd.FileName != "" && File.Exists(ofd.FileName))
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

                    logger.LogWrite($"Opening file {ofd.FileName}");
                    try
                    {
                        string[] lines = File.ReadAllLines(ofd.FileName);
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
        }

        private void add_file_to_selected_mods_list(string mod_file_name)
        {
            if (selected_mods.FindIndex(x => x.Equals(mod_file_name)) == -1)
            {
                selected_mods.Add(mod_file_name);
            }
        }
    }
}
