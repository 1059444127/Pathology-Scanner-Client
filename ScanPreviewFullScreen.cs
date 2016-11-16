using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FirstGuiClient
{
    public partial class ScanPreviewFullScreen : Form
    {
        byte[] image;
        public ScanPreviewFullScreen(byte[] _image = null)
        {
            if (_image != null)
                this.image = _image;

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ScanPreviewFullScreen_Load(object sender, EventArgs e)
        {
            Image localImage = null;

            if (image == null)
            {
                //if (System.IO.File.Exists("R:\\download.jpg") == true)
                //{
                //image = Image.FromFile("R:\\download.jpg");
                //}
                //else
                localImage = Image.FromFile("F:\\Test\\default.jpg");
            }
            else
            {
                MemoryStream stream = new MemoryStream();
                stream.Write(image, 0, image.Length);
                localImage = Image.FromStream(stream);
            }

            pictureBox1.Image = localImage;
            pictureBox1.Height = localImage.Height;
            pictureBox1.Width = localImage.Width;
        }
    }
}
