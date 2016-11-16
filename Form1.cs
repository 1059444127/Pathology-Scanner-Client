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
    public partial class Form1 : Form
    {
        PiNetworkSocketsForm pi = new PiNetworkSocketsForm();

        public string command = string.Empty;

        public string response = string.Empty;

        public Stream image = null;

        public bool isConnected = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void startClient_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image image = null;
            if (System.IO.File.Exists("R:\\img.jpg") == true)
            {
                image = Image.FromFile("R:\\img.jpg");
            }
            else
                image = Image.FromFile("R:\\default.jpg");

            pictureBox1.Image = image;
            pictureBox1.Height = 300;
            pictureBox1.Width = 300;
        }

        private void btnStartClient_Click(object sender, EventArgs e)
        {
            tbMain.Text = "Connecting to server. Please wait...";
            isConnected = pi.StartClient("192.168.1.108", 3610);
            
            if (isConnected == true)
                tbMain.Text = "Client connected to server";
            else
                tbMain.Text = "Could not connect to\r server\n";
        }


        private void tbMain_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTakePhoto_Click(object sender, EventArgs e)
        {
            if (isConnected == false)
            {
                tbMain.Text = "Connection with server not established!";
                return;
            }
         
            tbMain.Text = "\nCommand: \"Take Photo\"";
            //System.Threading.Thread.Sleep(1000);

            if (pi.SendMessage("TakePhoto$") == false)
            {
                tbMain.Text = "Could not send \"TakePhoto\" command!";
                return;
            }

            string imgSize = string.Empty;
            imgSize = pi.GetMessage();

            tbMain.Text = "Receiving image size...";
            
            int imageSize = Convert.ToInt32(imgSize);
            tbMain.Text += Convert.ToString(imageSize) + " bytes";

            byte[] image = new byte[imageSize];

            int bufferSize = 8192;
            byte[] buffer;
            int remainImage = imageSize;

            if (pi.SendMessage("Ready$") == false)
            {
                tbMain.Text = "Error during transfer negotiation...";
                return;
            }
            tbMain.Text = "Receiving image ...";
            System.Threading.Thread.Sleep(40);
            int parts = imageSize / bufferSize;
            int partNumber = 0;
            int percentage = 0;
            while (remainImage > 0)
            {
                System.Threading.Thread.Sleep(70);
                pi.SendMessage("Ready$");
                buffer = pi.GetData();
                for (int i = 0; i < bufferSize; i++)
                {
                    image[imageSize - remainImage + i] = buffer[i];
                }

                percentage = (partNumber * 100) / parts;
                tbMain.Text = "Image " + Convert.ToString(percentage) + "% received...";

                remainImage -= bufferSize;
                if (remainImage < bufferSize)
                    bufferSize = remainImage;
            }

            System.IO.File.WriteAllBytes("R:\\img.jpg", image);
        }
    }
}