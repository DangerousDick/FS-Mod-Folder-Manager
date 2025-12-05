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
        private ContextMenuStrip mnulistboxContext;                             // context menu for listbox

        /*
         * class initialisation
         **********************************************************************************************
         */
        public frmCreateModsFolder(string current_default_mod_folder)
        {
            /*
             *  construction tasks
             */
            InitializeComponent();
            logger.LogWrite("Initializing create new folder dialog", true);
            this.current_default_mod_folder = current_default_mod_folder;
        }

        private void frmCreateModsFolder_Load(object sender, EventArgs e)
        {
            /*
             * tasks to do on form load
             */
            current_default_mod_folder = Settings.Default.ModFolderPath;
            txtCopyFolder.Text = Settings.Default.DefaultFavouritesFolder;
            txtNewFolder.Text = $"{current_default_mod_folder}\\NewFolder";
            if (txtCopyFolder.Text.Length > 0 && Directory.Exists(txtCopyFolder.Text))
            {
                PopulateModsList(txtCopyFolder.Text);
            }
            statusBar.Text = "Create a new mods folder";
        }

        /*
         * button events
         **********************************************************************************************
         */

        private void btnExit_Click(object sender, EventArgs e)
        {
            /*
             * task to do before closing
             */
            try
            {
                lstModsList.ContextMenuStrip = mnulistboxContext;
                Settings.Default.DefaultFavouritesFolder = txtCopyFolder.Text;
                logger.LogWrite("Closing create new folder dialog\n\n", true);
                Close();
            }
            catch (Exception ex)
            {
                // do nothing
            }
        }

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
                    string init_dir = Directory.GetParent(txtCopyFolder.Text).ToString();
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

        private void btnClearList_Click(object sender, EventArgs e)
        {
            clear_listbox_items();
        }

        private void btnReloadList_Click(object sender, EventArgs e)
        {
            reload_list_box();
        }

        /*
         * listbox events
         **********************************************************************************************
         */
        private void lstModsList_MouseUp(object sender, MouseEventArgs e)
        {
            /*
             * right click event for listbox
             */
            if (e.Button == MouseButtons.Right)
            {
                int location = lstModsList.IndexFromPoint(e.Location);
                if (lstModsList.SelectedItems.Count > 0)
                {
                    lstModsList.SelectedIndex = lstModsList.IndexFromPoint(e.Location);
                    lstModsList.ContextMenuStrip = mnuListBoxContext;
                    lstModsList.ContextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        /*
         * menu events
         **********************************************************************************************
         */
        private void mnuAddItem_Click(object sender, EventArgs e)
        {
            /*
             * Add an item to the listbox
             */
            logger.LogWrite("Getting file list", true);
            List<string> file_list = new List<string>();
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                try
                {
                    ofd.InitialDirectory = txtCopyFolder.Text;
                    ofd.Multiselect = true;
                    ofd.Filter = "Zip files (*.zip)|*.zip|All files (*.*)|*.*";
                    ofd.FilterIndex = 1;
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //Show in textbox
                        string[] selected_files = ofd.FileNames;
                        int current_count = lstModsList.Items.Count;
                        for (int i = 0; i < selected_files.Length; i++)
                        {
                            // if file exists don't add it again
                            if (!lstModsList.Items.Contains(selected_files[i]))
                            {
                                // add file to listbox
                                lstModsList.Items.Add(selected_files[i]);
                                logger.LogWrite("Adding file " + selected_files[i] + " to list");
                            }
                        }
                        if (current_count < lstModsList.Items.Count)
                        {
                            statusBar.Text = $"Added items to the list";
                            lblFileCount.Text = $"{lstModsList.Items.Count} files found";
                            lstModsList.SelectedIndex = lstModsList.Items.Count - 1;
                        }

                    }
                    else
                    {
                        statusBar.Text = "No files selected";
                    }
                }
                catch (Exception ex)
                {
                    logger.LogWrite(ex.Message, true);
                }
            }
        }

        private void mnuReloadList_Click(object sender, EventArgs e)
        {
            /*
             * reload data from  folder in txtCopyFolder textbox
             */
            reload_list_box();
        }

        private void mnuClearList_Click(object sender, EventArgs e)
        {
            clear_listbox_items();
        }

        private void mnuRemoveItem_Click(object sender, EventArgs e)
        {
            /*
             * Deletes the mod file from the directory and removes it from the list
             */
            logger.LogWrite("DELETING listbox item", true);
            if (lstModsList.SelectedIndex >= 0)
            {
                int Index = lstModsList.SelectedIndex;
                string ItemText = lstModsList.Text;
                lstModsList.Items.RemoveAt(lstModsList.SelectedIndex);
                lstModsList.SelectedIndex = Index;
                statusBar.Text = $"Removed:{ItemText}";
                lblFileCount.Text = $"{lstModsList.Items.Count} files found";
            }
        }

        /*
         * private methods
         **********************************************************************************************
         */
        private void reload_list_box()
        {
            /*
             * reload data from  folder in txtCopyFolder textbox
             */
            if (System.Windows.Forms.DialogResult.Yes == MessageBox.Show($"Clear list and reload from {txtCopyFolder.Text}?", "Reload List",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification))
            {
                PopulateModsList(txtCopyFolder.Text);
            }
        }

        private void PopulateModsList(String folderpath)
        {
            /*
             * populate the mods listbox with the mods in the selected folder
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
                        if (lstModsList.Items.Count > 0)
                        {
                            lstModsList.SelectedIndex = 0;
                        }
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
                    if (System.Windows.Forms.DialogResult.Yes == MessageBox.Show($"Create folder {txtNewFolder.Text}?", "Create Folder",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification))
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

        private void clear_listbox_items()
        {
            /*
             * clear all items from the listbox
             */
            if (System.Windows.Forms.DialogResult.Yes == MessageBox.Show("Are you sure you want to clear the list", "Clear the list",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification))
            {
                lstModsList.Items.Clear();
            }
        }
    }
}
