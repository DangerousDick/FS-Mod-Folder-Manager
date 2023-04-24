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

namespace FS22_Mod_Manager
{
    public partial class CreateNewFolder : Form
    {
        public string new_folder_name = "";                         // for main form to select new folder in list

        private string mod_folder_path = "";                        // full path to new mod folder
        private List<string> selected_mods = new List<string>();    // List for selected mods

        public CreateNewFolder(string mod_folder)
        {
            InitializeComponent();
            mod_folder_path = mod_folder;
        }

        private void CreateNewFolder_Load(object sender, EventArgs e)
        {
            /*
             * on form load populate the list boxes using the mod_folder path
             */
            populate_folder_list();
            populate_file_list();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            /*
             * create the new folder
             */
            copy_selected_mods();
        }

        private void btnChangeFolder_Click(object sender, EventArgs e)
        {
            /*
             * select another folder and populate lists
             */
            mod_folder_path = get_folder_list(mod_folder_path);
            populate_folder_list();
            populate_file_list();
        }

        private void lstModFiles_DoubleClick(object sender, EventArgs e)
        {
            /*
             * when double clicking a mod file add it to the selected mods list and check for duplicates
             */
            string mod_file_name = Path.Join(mod_folder_path, lstFolders.Text, lstModFiles.Text);
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
            for (int i = 0; i < lstModFiles.Items.Count; i++)
            {
                string mod_file_name = Path.Join(mod_folder_path, lstFolders.Text, lstModFiles.Items[i].ToString());
                if (selected_mods.FindIndex(x => x.Equals(mod_file_name)) == -1)
                {
                    selected_mods.Add(mod_file_name);
                }
                populate_selected_files_list();
            }
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
                        else
                        {
                            return "";
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
                if (Directory.Exists(mod_folder_path))
                {
                    string[] dirs = Directory.GetDirectories(mod_folder_path);
                    if (lstFolders.Items.Count > 0)
                    {
                        lstFolders.Items.Clear();
                    }
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
                    lblFoldeerCount.Text = "Folders: " + lstFolders.Items.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("created new folder" + ex.Message);
            }
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
                if (lstFolders.Items.Count > 0)
                {
                    string mfp = Path.Join(mod_folder_path, lstFolders.Text);
                    string[] files = Directory.GetFiles(mfp);
                    foreach (string file in files)
                    {
                        if (Path.GetExtension(file) == ".zip")
                        {
                            lstModFiles.Items.Add(Path.GetFileName(file));
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

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            var result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folder_path = fbd.SelectedPath;
                new_folder_name = Path.GetFileName(folder_path);
                Debug.WriteLine($"new filder name: {new_folder_name}");
                //copy files
                foreach (string selected_file in selected_mods)
                {
                    string to_filename = Path.Join(folder_path, Path.GetFileName(selected_file));
                    try
                    {
                        if (!File.Exists(to_filename))
                        {
                            Debug.WriteLine($"Copying {selected_file} to {to_filename}");
                            File.Copy(selected_file, to_filename);
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Error: {ex.Message}");
                    }
                }
            }
            else
            {
                Debug.WriteLine("No folder selected");
            }

        }
    }
}
