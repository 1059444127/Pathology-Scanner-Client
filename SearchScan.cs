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
    public partial class SearchScan : Form
    {
        List<Metadata> results;

        public SearchScan()
        {
            InitializeComponent();
        }

        //[Search] button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //listView1.ResetText();

                var metadata = new Metadata();

                results = new List<Metadata>();

                if (checkBoxScanID.Checked == true)
                    results = Controller.GetScanFromDatabaseBasedOnQuery(textBoxScanID.Text);

                if (checkBoxPatientIDNP.Checked == true)
                    results = Controller.GetScanFromDatabaseBasedOnQuery(null, textBoxPatientIDNP.Text);

                if (checkBoxDoctorName.Checked == true)
                    results = Controller.GetScanFromDatabaseBasedOnQuery(null, null, textBoxDoctorName.Text);

                if (checkBoxDoctorSurname.Checked == true)
                    results = Controller.GetScanFromDatabaseBasedOnQuery(null, null, null, textBoxDoctorSurname.Text);

                if (checkBoxPatientName.Checked == true)
                    results = Controller.GetScanFromDatabaseBasedOnQuery(null, null, null, null, textBoxPatientName.Text);

                if (checkBoxPatientSurname.Checked == true)
                    results = Controller.GetScanFromDatabaseBasedOnQuery(null, null, null, null, null, textBoxPatientSurname.Text);

                //var metadataContext = new Model1();
                //results = new List<Metadata>();

                ////results.Add(metadataContext.Scans.First(s => s.TissueType.Contains("test tissue")));

                //foreach (var scan in metadataContext.Scans)
                //    if (scan.TissueType.Contains("test tissue"))
                //        results.Add(scan);

                UpdateListView();
                this.Refresh();

                //OpenScan openScanObj = new OpenScan(basicScanObject);
                //openScanObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }

            #region controller
            //try
            //{
            //    //listView1.ResetText();

            //    BasicScanObject basicScanObject = new BasicScanObject();

            //    ScannerDatabase.ScannerDatabase database = new ScannerDatabase.ScannerDatabase();

            //    results = new List<BasicScanObject>();

            //    if (checkBoxScanID.Checked == true)
            //        results = database.GetScan(textBoxScanID.Text);

            //    if (checkBoxPatientIDNP.Checked == true)
            //        results = database.GetScan(null, textBoxPatientIDNP.Text);

            //    if (checkBoxDoctorName.Checked == true)
            //        results = database.GetScan(null, null, textBoxDoctorName.Text);

            //    if (checkBoxDoctorSurname.Checked == true)
            //        results = database.GetScan(null, null, null, textBoxDoctorSurname.Text);

            //    if (checkBoxPatientName.Checked == true)
            //        results = database.GetScan(null, null, null, null, textBoxPatientName.Text);

            //    if (checkBoxPatientSurname.Checked == true)
            //        results = database.GetScan(null, null, null, null, null, textBoxPatientSurname.Text);

            //    UpdateListView();
            //    this.Refresh();

            //    //OpenScan openScanObj = new OpenScan(basicScanObject);
            //    //openScanObj.Show();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Application.ExitThread();
            //}
            #endregion
        }

        public void UpdateListView()
        {
            try
            {
                //listView1.ResetText();
                //listView1.Refresh();
                //listView1.Invalidate();
                listView1.Items.Clear();
                //listView1.Update();
                for (int i = 0; i < results.Count; i++)
                {
                    //ListViewItem item = new ListViewItem(results[i].ScanId.ToString());
                    ListViewItem item = new ListViewItem();
                    //item.SubItems.Ad
                    item.SubItems.Add(results[i].ScanId.ToString());
                    item.SubItems.Add(results[i].PatientIdnp);
                    item.SubItems.Add(results[i].PatientName + " " + results[i].PatientSurname);
                    item.SubItems.Add(results[i].DoctorName + " " + results[i].DoctorSurname);

                    listView1.Items.Add(item);

                    //this.Refresh();
                    //UpdateListView();
                }
                //UpdateListView();
                //this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }

        }

        //[Show All] button
        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                //listView1.Clear();
                //UpdateListView();
                //listView1.Refresh();
                //listView1.Invalidate();
                //listView1.Update();
                //listView1.ResetText();
                //listView1.Items.Clear();

                Metadata metadata = new Metadata();

                results = new List<Metadata>();

                var metadatas = Controller.GetAllScansFromDatabase();

                //{
                Metadata tmp = new Metadata();
                for (int i = 0; i < metadatas.Count; i++)
                {
                    //tmp = CopyAndNormalize(metadatas[i]);
                    results.Add(metadatas[i]);
                }

                UpdateListView();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        //Open one result
        private void ItemDoubleClick(object sender, EventArgs e)
        {
            //var checks = listView1.CheckedIndices;
            string scanId = string.Empty;
            //ListViewItem item = listView1.CheckedItems[0];
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected == true)
                    scanId = listView1.Items[i].SubItems[1].Text; //ScanId
            }
            //var item = listView1.CheckedItems;

            Metadata metadata = new Metadata();
            //string ScanID = item.SubItems[0].ToString(); //ScanID
            metadata = Controller.GetScanFromDatabaseBasedOnQuery(scanId).First();
            OpenScan openScanObj = new OpenScan(metadata);
            openScanObj.Show();
        }

        private void SearchScan_Load(object sender, EventArgs e)
        {

        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var checks = listView1.CheckedIndices;
            ListViewItem item = listView1.CheckedItems[0];
            //var item = listView1.CheckedItems;
            string scanId = item.SubItems[1].Text; //ScanId
            Metadata metadata = new Metadata();
            //string ScanID = item.SubItems[0].ToString(); //ScanID
            metadata = Controller.GetScanFromDatabaseBasedOnQuery(scanId).First();

            OpenScan openScanObj = new OpenScan(metadata);
        }

        //public List<Metadata> GetMetadataList()
        //{
        //    try
        //    {
        //        var metadataModel = new Model1();

        //        return metadataModel.Scans.ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);

        //        return null;
        //    }

        //}

        /// <summary>
        /// Get the BasicScanObject that satisfies condition.
        /// </summary>
        /// <param name="scanId"></param>
        /// <param name="patientIdnp"></param>
        /// <param name="doctorName"></param>
        /// <param name="doctorSurname"></param>
        /// <param name="patientName"></param>
        /// <param name="patientSurname"></param>
        /// <returns>List of BasicScanObject</returns>
        //public List<Metadata> GetMetadata(
        //    string scanId = null,
        //    string patientIdnp = null,
        //    string doctorName = null,
        //    string doctorSurname = null,
        //    string patientName = null,
        //    string patientSurname = null)
        //{
        //    List<Metadata> localResults = new List<Metadata>();
        //    try
        //    {
        //        var metadataList = Controller.GetAllScansFromDatabase();

        //        if (string.IsNullOrEmpty(scanId) == false)
        //            for (int i = 0; i < metadataList.Count; i++)
        //                if (metadataList[i].ScanId.Equals(scanId))
        //                    localResults.Add(metadataList[i]);

        //        if (string.IsNullOrEmpty(patientName) == false)
        //            for (int i = 0; i < metadataList.Count; i++)
        //                if (metadataList[i].PatientName.Equals(patientName))
        //                    localResults.Add(metadataList[i]);

        //        if (string.IsNullOrEmpty(patientIdnp) == false)
        //            for (int i = 0; i < metadataList.Count; i++)
        //                if (metadataList[i].PatientIdnp.Equals(patientIdnp))
        //                    localResults.Add(metadataList[i]);

        //        if (string.IsNullOrEmpty(patientSurname) == false)
        //            for (int i = 0; i < metadataList.Count; i++)
        //                if (metadataList[i].PatientSurname.Equals(patientSurname))
        //                    localResults.Add(metadataList[i]);

        //        if (string.IsNullOrEmpty(doctorName) == false)
        //            for (int i = 0; i < metadataList.Count; i++)
        //                if (metadataList[i].DoctorName.Equals(doctorName))
        //                    localResults.Add(metadataList[i]);

        //        if (string.IsNullOrEmpty(doctorSurname) == false)
        //            for (int i = 0; i < metadataList.Count; i++)
        //                if (metadataList[i].DoctorSurname.Equals(doctorSurname))
        //                    localResults.Add(metadataList[i]);

        //        Metadata tmp = new Metadata();
        //        List<Metadata> metadatas = new List<Metadata>();
        //        for (int i = 0; i < localResults.Count; i++)
        //        {
        //            tmp = CopyAndNormalize(localResults[i]);
        //            metadatas.Add(tmp);
        //        }

        //        return metadatas;

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        localResults = null;
        //    }
        //    return null;
        //}

        ///// <summary>
        ///// Add Scan to database.
        ///// </summary>
        ///// <param name="inputScan"></param>
        ///// <returns>True - ok, False - otherwise.</returns>
        //public bool AddScan(Metadata inputScan)
        //{
        //    bool flag = false;
        //    try
        //    {
        //        //Metadata scan = new Metadata();

        //        //scan = CopyAndNormalize(inputScan);

        //        Model1 entities = new Model1();
        //        entities.Scans.Add(inputScan);
        //        entities.SaveChanges();

        //        flag = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        flag = false;
        //    }
        //    return flag;
        //}

        //public Metadata CopyAndNormalize(Metadata from)
        //{
        //    var to = new Metadata();

        //    //try
        //    //{
        //    to.PatientIdnp = from.PatientIdnp;
        //    to.PatientName = from.PatientName;
        //    to.PatientSurname = from.PatientSurname;
        //    to.TissueType = from.TissueType;
        //    to.TissueDescription = from.TissueDescription;
        //    to.ClinicalDiagnosis = from.ClinicalDiagnosis;
        //    //left.DateCreated = right.DateCreated; // may appear errors
        //    to.DoctorName = from.DoctorName;
        //    to.DoctorSurname = from.DoctorSurname;

        //    if (from.Image != null)
        //        to.Image = from.Image;

        //    //if (string.IsNullOrEmpty(from.ScanId))
        //    //if (from.ScanId > 0)
        //    //    to.ScanId = Convert.ToInt64(DateTime.Now.ToString("yyMMddHHmmss"));
        //    //else
        //        to.ScanId = from.ScanId;
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    Console.WriteLine(ex.Message);
        //    //}

        //    return to;
        //}

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
