using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstGuiClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void wizzardModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NewScanWizzardMode NewScanWizzardMode = new NewScanWizzardMode();
            //NewScanWizzardMode.Show();
            //this.Hide();
            var ScanPreview = new ScanPreview();
            ScanPreview.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Nothing here, pjjjjj.....");
            SearchScan searchScanObj = new SearchScan();
            searchScanObj.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
    }
}
