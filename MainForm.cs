using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FirstGuiClient
{
    public partial class MainForm : Form
    {
        private bool LoadingPageThreadExecuted;

        public MainForm()
        {
            LoadingPageThreadExecuted = false;
            InitializeComponent();
        }

        private void wizzardModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NewScanWizzardMode NewScanWizzardMode = new NewScanWizzardMode();
            //NewScanWizzardMode.Show();
            //this.Hide();
            Controller.SetStatus("Opening ScanPreview");
            //var ScanPreview = new ScanPreview();
            //ScanPreview.Show();

            //var LoadingPage = new NewScanInitialLoad();
            //LoadingPage.Show();
            Thread LoadingPageThread = new Thread(new ThreadStart(LoadingPageProcess));
            LoadingPageThread.Start();

            while (!LoadingPageThreadExecuted)
                Thread.Sleep(500);

            if (Controller.Image != null)
            {
                LoadingPageThreadExecuted = false;
                var ScanPreview = new ScanPreview();
                ScanPreview.Show();
            }

        }

        private void LoadingPageProcess()
        {
            var LoadingPage = new NewScanInitialLoad();
            LoadingPage.Show();
            
            Controller.InitializeScanPreview();
            LoadingPage.labelInitialLoad.Text = Controller.GetStatus();
            LoadingPage.Update();

            Controller.ImageName = Controller.TakePhoto();
            LoadingPage.labelInitialLoad.Text = Controller.GetStatus();
            LoadingPage.Update();

            Controller.GetPhoto(Controller.ImageName);
            LoadingPage.labelInitialLoad.Text = Controller.GetStatus();
            LoadingPage.Update();

            if (Controller.Image != null)
                LoadingPage.labelInitialLoad.Text = "Photo Successfully Received!";
            else
                LoadingPage.labelInitialLoad.Text = "Some error occured!";
            
            LoadingPage.Update();
            Thread.Sleep(2000);
             
            LoadingPageThreadExecuted = true;
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
