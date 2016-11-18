using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace FirstGuiClient
{
    public static class Controller
    {
        public static String ImagePath;
        public static String ImageName;

        public static int HeightFactor = 0;
        public static int WidthFactor = 0;

        private static Image Image;
        private static Size ImageSize;
        private static Bitmap Bmp;

        public static void InitializeScanPreview()
        {
            ImagePath = string.Empty;
            HeightFactor = 1;
            WidthFactor = 1;

            Image = null;
            Image = null;
            Bmp = null;
        }

        public static string TakePhoto()
        {
            var innerContent = ExecuteRequest("takePhoto");

            if (innerContent == null || innerContent.Length < 5)
                Controller.ImageName = null;
            else
                Controller.ImageName = innerContent;

            return innerContent;
        }

        public static Image GetPhoto(string fileName)
        {
            var innerContent = ExecuteRequest("getPhoto/" + fileName);

            if (innerContent == null || innerContent.Length < 4)
                return null;

            var responseByteArray = System.Convert.FromBase64String(innerContent);
            Controller.Image = Image.FromStream(new MemoryStream(responseByteArray));

            return Controller.Image;
        }

        public static Image GetPreview()
        {
            var innerContent = ExecuteRequest("getPreview");

            if (innerContent.Length < 4)
                return null;

            var responseByteArray = System.Convert.FromBase64String(innerContent);
            Controller.Image = Image.FromStream(new MemoryStream(responseByteArray));

            return Controller.Image;
        }

        private static string ExecuteRequest(string resource)
        {
            Configuration Config = new Configuration();

            var client = new RestClient(string.Format("http://{0}:{1}", Config.Ip, Config.Port));
            var request = new RestRequest(resource, Method.GET);
            request.Timeout = 30000; //ms

            IRestResponse response = client.Execute(request);

            if (!response.ResponseStatus.Equals(ResponseStatus.Completed))
            {
                Controller.ImageName = null;
                return null;
            }

            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(response.Content);

            var innerContent = xmlDoc.DocumentElement.InnerText;

            return innerContent;
        }

        public static PictureBox LoadScanPreview(PictureBox pictureBox1)
        {
            if (Controller.ImageName == null || Controller.Image == null)
            {
                ImagePath = "F:\\Test\\default.JPG";
                
                Image = null;
                Image = Image.FromFile(ImagePath);
            }

            //try
            //{
            //Image = Image.FromFile(ImagePath);
            ImageSize = new Size(WidthFactor * Image.Width/4, HeightFactor * Image.Height/4);

            Bmp = new Bitmap(Image, ImageSize);
            //Image.Dispose();
            //Image = null;

            pictureBox1.Image = Bmp;
            pictureBox1.Size = ImageSize;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //    //if (image != null)
            //    //    image.Dispose();

            //    //if (bmp != null)
            //    //    bmp.Dispose();

            //    //image = null;
            //    //bmp = null;
            //}

            return pictureBox1;
        }

        public static byte[] ConvertImageToByteArray()
        {
            byte[] image = null;

            using (var ms = new System.IO.MemoryStream())
            {
                //Image local = Image.FromFile(Controller.ImagePath);
                Image local = Controller.Image;
                local.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                image = ms.ToArray();
            }

            return image;
        }

        public static bool SaveMetadataToDatabase(Metadata metadata)
        {
            //try
            //{
            //var metadataContext = new MetadataContext();
            var metadataContext = new Model1();

            metadataContext.Database.CommandTimeout = 30; //seconds

            metadataContext.Scans.Add(metadata);
            metadataContext.SaveChanges();

            return true;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    return false; //testing
            //}
        }

        public static List<Metadata> GetAllScansFromDatabase()
        {
            try
            {
                var metadataModel = new Model1();

                return metadataModel.Scans.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }

        }

        public static List<Metadata> GetScanFromDatabaseBasedOnQuery(
            string scanId = null,
            string patientIdnp = null,
            string doctorName = null,
            string doctorSurname = null,
            string patientName = null,
            string patientSurname = null)
        {
            var localResults = new List<Metadata>();
            var metadataModel = new Model1();
            var scansList = metadataModel.Scans;

            if (string.IsNullOrEmpty(scanId) == false)
            {
                var scanIdLong = Convert.ToInt64(scanId);
                localResults.AddRange(scansList.Where(s => s.ScanId.Equals(scanIdLong)));
            }

            if (string.IsNullOrEmpty(patientIdnp) == false)
                localResults.AddRange(scansList.Where(s => s.PatientIdnp.Equals(patientIdnp)));

            if (string.IsNullOrEmpty(doctorName) == false)
                localResults.AddRange(scansList.Where(s => s.DoctorName.Equals(doctorName)));

            if (string.IsNullOrEmpty(doctorSurname) == false)
                localResults.AddRange(scansList.Where(s => s.DoctorSurname.Equals(doctorSurname)));

            if (string.IsNullOrEmpty(patientName) == false)
                localResults.AddRange(scansList.Where(s => s.PatientName.Equals(patientName)));

            if (string.IsNullOrEmpty(patientSurname) == false)
                localResults.AddRange(scansList.Where(s => s.PatientSurname.Equals(patientSurname)));

            return localResults;
        }

        private static string GetParam(string body, string left, string right)
        {
            try
            {
                int leftIndex = body.IndexOf(left) + left.Length;
                int length = body.IndexOf(right) - leftIndex;

                return body.Substring(leftIndex, length);
            }
            catch { }

            return "null";
        }

        ////TODO: please rewrite to query info from db, not to store it in memory
        //public static List<Metadata> GetScanFromDatabaseBasedOnQueryOld(
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
        //            //tmp = CopyAndNormalize(localResults[i]);
        //            metadatas.Add(localResults[i]);
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
        //public static bool AddScanToDatabase(Metadata inputScan)
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
    }
}
