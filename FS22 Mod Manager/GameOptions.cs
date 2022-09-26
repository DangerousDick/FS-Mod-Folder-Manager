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
    public partial class GameOptions : Form
    {
        public bool returnOK = false;
        public GameOptions(string filename = "filename", bool filename_edit = false)
        {
            InitializeComponent();
        }

        private void GameOptions_Load(object sender, EventArgs e)
        {
            /*
             * load values from Settings
             */
            cmbPerformanceClass.Text = Settings.Default.performanceClass;
            nudLodDistanceCoeff.Text = Settings.Default.lodDistanceCoeff;
            nudTerrainLODDistanceCoeff.Text = Settings.Default.terrainLODDistanceCoeff;
            nudFoliageViewDistanceCoeff.Text = Settings.Default.foliageViewDistanceCoeff;
            nudMaximumMirrors.Text = Settings.Default.maxNumMirrors;
        }

        private void GameOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
             * write values for scalability to game.xml
             */
            if (returnOK)
            {
                Settings.Default.performanceClass = cmbPerformanceClass.Text;
                Settings.Default.lodDistanceCoeff = nudLodDistanceCoeff.Text;
                Settings.Default.terrainLODDistanceCoeff = nudTerrainLODDistanceCoeff.Text;
                Settings.Default.foliageViewDistanceCoeff = nudFoliageViewDistanceCoeff.Text;
                Settings.Default.maxNumMirrors = nudMaximumMirrors.Text;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            returnOK = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            returnOK = false;
            Close();
        }
    }
}
