using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
//using ScannerDatabase;

namespace FirstGuiClient
{
    public partial class SaveScanAndMetadata : Form
    {
        //ScannerDatabase.BasicScanObject basicScanObject;
        Metadata Metadata;
        public SaveScanAndMetadata(Metadata metadata)
        {
            //this.basicScanObject = basicScanObject;
            this.Metadata = metadata;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                //save data to zip file
            }
            if (checkBoxDatabase.Checked == true)
            {
                var infoPage = new WritingToDbInfo();
                infoPage.Show();
                infoPage.Update();

                if (Controller.SaveMetadataToDatabase(this.Metadata))
                    infoPage.label1.Text += " SUCCESS!";
                else
                    infoPage.label1.Text += " FAIL";

                infoPage.Update();
                Thread.Sleep(2000);

                infoPage.Close();
                //ScannerDatabase.ScannerDatabase database = new ScannerDatabase.ScannerDatabase();
                //database.AddScan(basicScanObject);
            }

            this.Close();
        }

        private void SaveScanAndMetadata_Load(object sender, EventArgs e)
        {
        }
    }
}
