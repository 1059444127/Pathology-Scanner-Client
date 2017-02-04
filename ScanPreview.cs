using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
//using PanoramaCreator;

namespace FirstGuiClient
{
    public partial class ScanPreview : Form
    {
        private bool ScanAgainThreadExecuted;

        #region CONTROLLER
        ////////Image image = null;
        //////String imagePath = string.Empty;

        //////int heightFactor = 1;
        //////int widthFactor = 1;

        ////////int nrOfImages = 1;
        #endregion

        public ScanPreview()
        {
            ScanAgainThreadExecuted = false;

            //Controller.InitializeScanPreview();

            InitializeComponent();
            this.pictureBox1.Cursor = Cursors.Hand;

            //Controller.ImageName = Controller.TakePhoto();
            //Controller.GetPhoto(Controller.ImageName); //controller image name
            pictureBox1 = Controller.LoadScanPreview(pictureBox1);
        }

        private void ScanPreview_Load(object sender, EventArgs e)
        {
            //Controller.ImageName = Controller.TakePhoto();
            //Controller.GetPhoto(Controller.ImageName); //controller image name
            //pictureBox1 = Controller.LoadScanPreview(pictureBox1);

            #region CONTROLLER
            //////Image image = null;
            //////Size imageSize;
            //////Bitmap bmp = null;

            ////////if preview image was loaded from server
            //////if (System.IO.File.Exists("F:\\Test\\preview.jpg") == true)
            //////    imagePath = "F:\\Test\\preview.jpg";
            //////else
            //////    imagePath = "F:\\Test\\default.JPG";

            //////try
            //////{
            //////    image = Image.FromFile(imagePath);
            //////    imageSize = new Size(widthFactor * image.Width, heightFactor * image.Height);

            //////    bmp = new Bitmap(image, imageSize);
            //////    image.Dispose();

            //////pictureBox1.Image = bmp;
            //////    pictureBox1.Size = imageSize;
            //////}
            //////catch (Exception ex)
            //////{
            //////    MessageBox.Show(ex.ToString());
            //////    //if (image != null)
            //////    //    image.Dispose();

            //////    //if (bmp != null)
            //////    //    bmp.Dispose();

            //////    //image = null;
            //////    //bmp = null;
            //////}
            #endregion
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void buttonPreviewAgain_Click(object sender, EventArgs e)
        {
            Thread scanAgainThread = new Thread(new ThreadStart(ScanAgain));
            scanAgainThread.Start();

            while (!ScanAgainThreadExecuted)
                Thread.Sleep(500);

            //Controller.ImageName = Controller.TakePhoto();
            //Controller.GetPhoto(Controller.ImageName); //controller image name
            pictureBox1 = Controller.LoadScanPreview(pictureBox1);
            this.Update();

            ScanAgainThreadExecuted = false;
        }

        private void ScanAgain()
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

            ScanAgainThreadExecuted = true;
        }

        private void ScanSingleImage()
        {
            NewScanInitialLoad NewScanInitialLoadObj = new NewScanInitialLoad();
            NewScanInitialLoadObj.Show();

            Controller.ImageName = Controller.TakePhoto();
            Controller.GetPhoto(Controller.ImageName); //controller image name
            pictureBox1 = Controller.LoadScanPreview(pictureBox1);
            //System.Threading.Thread.Sleep(400);
            //this.Hide();
            //NewScanInitialLoadObj.ServerCommunication();
            //this.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        //TODO: is this method needed ????????
        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            
            //if (System.IO.File.Exists("R:\\download.jpg") == true)
            //{
            //    image = Image.FromFile("R:\\download.jpg");
            //}
            //else
            //    image = Image.FromFile("R:\\default.jpg");

            //pictureBox1.Image = image;
            //pictureBox1.Height = image.Height;
            //pictureBox1.Width = image.Width;
        }

        /*private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Cursor = Cursors.Default;
        }*/

        private void buttonFullScreen_Click(object sender, EventArgs e)
        {
            var ScanPreviewFullScreen = new ScanPreviewFullScreenNew(Controller.ConvertImageToByteArray());
            ScanPreviewFullScreen.Show();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            #region controller
            //////byte[] image = null;

            //////using (var ms = new System.IO.MemoryStream())
            //////{
            //////    Image local = Image.FromFile(Controller.ImagePath);
            //////    local.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //////    image = ms.ToArray();
            //////}
            #endregion

            var image = Controller.ConvertImageToByteArray();

            AddMetadata AddMetadata = new AddMetadata(image);
            AddMetadata.Show();


            //System.IO.File.WriteAllBytes("R:\\Test\\test.jpg", imageArray);
            this.Close();
        }

        private void trackBarZoom_Scroll(object sender, EventArgs e)
        {
            Controller.HeightFactor = trackBarZoom.Value;
            Controller.WidthFactor = trackBarZoom.Value;
            //this.pictureBox1.Refresh();
            //ScanPreview_Load(null, null);
            pictureBox1 = Controller.LoadScanPreview(pictureBox1);
        }


        //private void ScanMultipleImages()
        //{
        //    NewScanInitialLoad NewScanInitialLoadObj = new NewScanInitialLoad();
        //    NewScanInitialLoadObj.Show();
        //    //System.Threading.Thread.Sleep(400);
        //    //this.Hide();
        //    NewScanInitialLoadObj.GetMultipleImages();
        //    //this.Show();
        //}

        private void buttonCreatePanorama_Click(object sender, EventArgs e)
        {
            PanoramaSettings panoramaSettingsOjb = new PanoramaSettings();
            panoramaSettingsOjb.Show();
            /*
            
            try
            {
                
                
                
                Panorama panorama = new Panorama();

                //panorama.StitchImage("R:\\test\\left.jpg", "R:\\test\\right.jpg", "R:\\test\\result.jpg");

                MessageBox.Show("Panorama Created!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/

        }
    }
}
