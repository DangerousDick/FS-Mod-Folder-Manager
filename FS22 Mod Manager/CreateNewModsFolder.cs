using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FS_Mod_Manager
{
    public partial class frmCreateModsFolder : Form
    {
        public string selected_folder { get; set; }

        private string current_default_mod_folder = string.Empty;               // full path to current default mods folder in the main form
        static private Logger logger = new Logger(frmMain.LogFileName, false);  // DO NOT CLEAR LOG

        // class initialisation
        public frmCreateModsFolder(string current_default_mod_folder)
        {
            InitializeComponent();
            logger.LogWrite("Initializing create new folder dialog", true);
            this.current_default_mod_folder = current_default_mod_folder;
        }

        private void frmCreateModsFolder_Load(object sender, EventArgs e)
        {
            current_default_mod_folder = Settings.Default.ModFolderPath;
            txtCopyFolder.Text = Settings.Default.DefaultFavouritesFolder;
            txtNewFolder.Text = $"{current_default_mod_folder}\\NewFolder";
            if (txtCopyFolder.Text.Length > 0  && Directory.Exists(txtCopyFolder.Text))
            {
                PopulateModsList(txtCopyFolder.Text);
            }
            statusBar.Text = "Create a new mods folder";
        }

        // form close tasks
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.DefaultFavouritesFolder = txtCopyFolder.Text;
                logger.LogWrite("Closing create new folder dialog\n\n", true);
                Close();
            }
            catch (Exception ex)
            {
                // do nothing
            }
        }

        // button click methods
        private void btnCopyBrowse_Click(object sender, EventArgs e)
        {
            /*
             * Folder to copy path browse button clicked so launch 
             * folder dialog to select the folder
             */
            using (FolderBrowserDialog ofd = new FolderBrowserDialog())
            {
                try
                {
                    string init_dir = current_default_mod_folder;
                    if (!Directory.Exists(init_dir))
                    {
                        init_dir = "C:\\";
                    }
                    ofd.InitialDirectory = init_dir;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //Show in textbox
                        txtCopyFolder.Text = ofd.SelectedPath;
                        PopulateModsList(txtCopyFolder.Text);
                    }
                }
                catch (Exception ex)
                {
                    logger.LogWrite($"Error: {ex.Message}");
                }
            }
        }

        private void btnNewBrowse_Click(object sender, EventArgs e)
        {
            /*
             * New folder to create path browse button clicked so launch 
             * folder dialog to select or create the new folder
             */
            using (FolderBrowserDialog ofd = new FolderBrowserDialog())
            {
                try
                {
                    string init_dir = current_default_mod_folder;
                    if (!Directory.Exists(init_dir))
                    {
                        init_dir = "C:\\";
                    }
                    ofd.InitialDirectory = init_dir;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //Show in textbox
                        txtNewFolder.Text = ofd.SelectedPath;
                    }
                }
                catch (Exception ex)
                {
                    logger.LogWrite($"Error: {ex.Message}");
                }
            }
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            /*
            * create the new folder
            */
            statusBar.Text = copy_selected_mods();
        }

        // private methods
        private void PopulateModsList(String folderpath)
        {
            /*
             * Populate the mods listbox with the mods in the selected folder
             */
            try
            {

                logger.LogWrite("Pupulating mods list");
                if (Directory.Exists(folderpath))
                {
                    List<string> mods_list = get_list_from_folder(folderpath);
                    if (mods_list.Count > 0)
                    {
                        // clear current list
                        lstModsList.Items.Clear();
                        foreach (string mod in mods_list)
                        {
                            // add file to list
                            lstModsList.Items.Add(mod);
                        }
                        statusBar.Text = $"List created from {Path.GetFileName(folderpath)}";
                        lblFileCount.Text = $"{mods_list.Count} files found";
                    }
                    else
                    {
                        statusBar.Text = $"Folder {Path.GetFileName(folderpath)} is empty";
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogWrite($"Error: {ex.Message}");
                statusBar.Text = $"Error: {ex.Message}";
            }
        }

        private List<string> get_list_from_folder(string mod_folder)
        {
            /* 
             * get list of files in mods folder
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
                            string mod_file = Path.GetFileName(file_path);
                            logger.LogWrite(file_path);
                            mods_list.Add(file_path);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogWrite($"Error: {ex.Message}");
            }
            return mods_list;
        }

        private String copy_selected_mods()
        {
            /* 
             * use the FolderBrowserDialog to get/create a folder
             * copy the files in selected_mods list to the folder
             */

            string return_msg = "";
            try
            {
                // Check folder exist before proceeding
                if (!Directory.Exists(txtCopyFolder.Text)) { return $"{txtCopyFolder.Text} DOES NOT EXIST"; }
                if (!Directory.Exists(txtNewFolder.Text))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    if (System.Windows.Forms.DialogResult.Yes == MessageBox.Show($"Create folder {txtNewFolder.Text}?", "Create Folder", buttons))
                    {
                        System.IO.Directory.CreateDirectory(txtNewFolder.Text);
                    }
                    else { return $"Folder not created"; }
                }
                // populate folder by copying files
                logger.LogWrite($"creating new folder: {txtNewFolder.Text}");
                foreach (string selected_file in lstModsList.Items)
                {
                    string to_filename = Path.Join(txtNewFolder.Text, Path.GetFileName(selected_file));
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
                    // check new folder was created
                    if (Directory.Exists(txtNewFolder.Text))
                    {
                        statusBar.Text = $"Folder {txtNewFolder.Text} created";
                        return_msg = $"Folder created: {txtNewFolder.Text}";
                    }
                    else
                    { return_msg = $"Failed to create folder {txtNewFolder.Text} see log for details."; }
                }
            }
            catch (Exception ex)
            {
                logger.LogWrite($"Error: {ex.Message}");
                statusBar.Text = $"Unable to create new directory {txtNewFolder.Text}";
                return_msg = ex.Message;
            }
            selected_folder = Path.GetFileName(txtNewFolder.Text);
            return return_msg;
        }
    }
}
