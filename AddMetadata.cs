using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using ScannerDatabase;

namespace FirstGuiClient
{
    public partial class AddMetadata : Form
    {
        //ScannerDatabase.BasicScanObject basicScanObject;
        byte[] image;
        Metadata Metadata;
        //public static BasicScanObject basicScanObject;
        public AddMetadata(byte[] image)
        {
            this.image = image;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMetadata_Load(object sender, EventArgs e)
        {
            textBoxScanID.Text = DateTime.Now.ToString("yyMMddHHmmss");
            this.Refresh();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (this.Save() == true)
            {
                //MessageBox.Show("Scan saved with success!");
                SaveScanAndMetadata saveScanAndMetadata = new SaveScanAndMetadata(this.Metadata);
                saveScanAndMetadata.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Scan not saved!");
            }
        }

        private bool Save()
        {
            try
            {
                Metadata = new Metadata()
                {
                    ScanId = Convert.ToInt64(textBoxScanID.Text),
                    PatientIdnp = textBoxPatientIDNP.Text,
                    PatientName = textBoxPatientName.Text,
                    PatientSurname = textBoxPatientSurname.Text,
                    TissueType = textBoxTissueType.Text,
                    TissueDescription = textBoxTissueDescription.Text,
                    ClinicalDiagnosis = textBoxClinicalDiagnosis.Text,
                    DoctorName = textBoxDoctorName.Text,
                    DoctorSurname = textBoxDoctorSurname.Text,
                    DoctorDegree = textBoxDoctorDegree.Text,
                    Image = image
                };
                return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false; //testing
            }

            #region controller
            //////byte[] image = null;
            ////try
            ////{
            ////    //basicScanObject = new ScannerDatabase.BasicScanObject(
            ////    //    textBoxScanID.Text,
            ////    //    textBoxPatientIDNP.Text,
            ////    //    textBoxPatientName.Text,
            ////    //    textBoxPatientSurname.Text,
            ////    //    textBoxTissueType.Text,
            ////    //    textBoxTissueDescription.Text,
            ////    //    textBoxClinicalDiagnosis.Text,
            ////    //    textBoxDoctorName.Text,
            ////    //    textBoxDoctorSurname.Text,
            ////    //    textBoxDoctorDegree.Text,
            ////    //    image);

            ////    using (var metadataContext = new MetadataContext())
            ////    {
            ////        Metadata metadata = new Metadata()
            ////        {
            ////            ScanId = Convert.ToInt16(textBoxScanID.Text),
            ////            PatientIdnp = textBoxPatientIDNP.Text,
            ////            PatientName = textBoxPatientName.Text,
            ////            PatientSurname = textBoxPatientSurname.Text,
            ////            TissueType = textBoxTissueType.Text,
            ////            TissueDescription = textBoxTissueDescription.Text,
            ////            ClinicalDiagnosis = textBoxClinicalDiagnosis.Text,
            ////            DoctorName = textBoxDoctorName.Text,
            ////            DoctorSurname = textBoxDoctorSurname.Text,
            ////            DoctorDegree = textBoxDoctorDegree.Text,
            ////            Image = image
            ////        };

            ////        metadataContext.Scans.Add(metadata);
            ////        metadataContext.SaveChanges();
            ////    }


            ////        return true;
            ////}
            ////catch (Exception ex)
            ////{
            ////    Console.WriteLine(ex.Message);
            ////    return false; //testing
            ////}
            #endregion

            //return Controller.SaveMetadataToDatabase(metadata);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelAddMetadata_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxPatientSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTissueDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
