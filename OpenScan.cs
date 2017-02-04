using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using ScannerDatabase;

namespace FirstGuiClient
{
    public partial class OpenScan : Form
    {
        //byte[] image;
        Metadata metadata;
        public OpenScan(Metadata metadata)
        {
            this.metadata = metadata;
            InitializeComponent();
        }

        private void OpenScan_Load(object sender, EventArgs e)
        {
            textBoxScanID.Text = metadata.ScanId.ToString();
            textBoxPatientName.Text = metadata.PatientName;
            textBoxPatientSurname.Text = metadata.PatientSurname;
            textBoxPatientIDNP.Text = metadata.PatientIdnp;
            textBoxDoctorName.Text = metadata.DoctorName;
            textBoxDoctorSurname.Text = metadata.DoctorSurname;
            textBoxTissueType.Text = metadata.TissueType;
            textBoxTissueDescription.Text = metadata.TissueDescription;
            textBoxClinicalDiagnosis.Text = metadata.ClinicalDiagnosis;
            //image = metadata.Image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ScanPreviewFullScreen = new ScanPreviewFullScreenNew(metadata.Image);
            ScanPreviewFullScreen.Show();
        }

        private void buttonSaveToFolder_Click(object sender, EventArgs e)
        {
            Controller.SaveMetadataToFolder(this.metadata);
        }
    }
}
