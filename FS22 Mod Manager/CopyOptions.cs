using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FS22_Mod_Manager
{
    public partial class CopyOptions : Form
    {
        public string fileName = "";
        public bool overwrite = true;
        public bool returnOK = false;
        public CopyOptions(string filename = "filename", bool filename_edit = false)
        {
            InitializeComponent();
            txtFileName.Text = filename;
            if (false == filename_edit)
            {
                txtFileName.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            returnOK = true;
            if (chkOverwriteFile.Checked) { overwrite = true; }
            else { overwrite = false; }
            fileName = txtFileName.Text;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            returnOK = false;
            if (chkOverwriteFile.Checked) { overwrite = true; }
            else { overwrite = false; }
            fileName = txtFileName.Text;
            Close();
        }
    }
}
