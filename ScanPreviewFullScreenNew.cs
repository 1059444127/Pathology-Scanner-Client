using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstGuiClient
{
    public partial class ScanPreviewFullScreenNew : Form
    {
        private bool Dragging;
        private int xPos;
        private int yPos;
        private byte[] image;

        public ScanPreviewFullScreenNew()
        {
            InitializeComponent();
        }

        public ScanPreviewFullScreenNew(byte[] _image = null)
        {
            if (_image != null)
                this.image = _image;

            InitializeComponent();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ScanPreviewFullScreenNew_Load_1(object sender, EventArgs e)
        {
            Image localImage = null;

            if (image == null)
                localImage = Image.FromFile("F:\\Test\\default.jpg");
            
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

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        //private void ScanPreviewFullScreenNew_MouseMove(object sender, MouseEventArgs e)
        //{

        //}

        //private void ScanPreviewFullScreenNew_MouseDown(object sender, MouseEventArgs e)
        //{

        //}

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Dragging = true;
                xPos = e.X;
                yPos = e.Y;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (Dragging && c != null)
            {
                c.Top = e.Y + c.Top - yPos;
                c.Left = e.X + c.Left - xPos;
            }
        }
    }
}
