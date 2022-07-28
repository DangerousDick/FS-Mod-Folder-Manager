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
    public partial class ScalabilityOptions : Form
    {
        public bool returnOK = false;
        public ScalabilityOptions(string filename = "filename", bool filename_edit = false)
        {
            InitializeComponent();
        }

        private void ScalabilityOptions_Load(object sender, EventArgs e)
        {
            /*
             * load values from Settings
             */
            cmbPerformanceClass.Text = Settings.Default.performanceClass;
            nudLodDistanceCoeff.Text = Settings.Default.lodDistanceCoeff;
            nudTerrainLODDistanceCoeff.Text = Settings.Default.terrainLODDistanceCoeff;
            nudFoliageViewDistanceCoeff.Text = Settings.Default.foliageViewDistanceCoeff;
        }

        private void ScalabilityOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
             * write values for scalability to game.xml
             */
            Settings.Default.performanceClass = cmbPerformanceClass.Text;
            Settings.Default.lodDistanceCoeff = nudLodDistanceCoeff.Text;
            Settings.Default.terrainLODDistanceCoeff = nudTerrainLODDistanceCoeff.Text;
            Settings.Default.foliageViewDistanceCoeff = nudFoliageViewDistanceCoeff.Text;
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
