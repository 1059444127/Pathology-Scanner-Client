using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstGuiClient
{
    public partial class NewScanWizzardMode : Form
    {
        PiNetworkSocketsForm net = new PiNetworkSocketsForm();

        public NewScanWizzardMode()
        {
            InitializeComponent();
        }

        private void NewScanWizzardMode_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            /*System.Threading.Thread thread = new System.Threading.Thread(this.ScanSingleImage);
            thread.Start();
            this.Hide(); // or close.*/

            NewScanInitialLoad NewScanInitialLoadObj = new NewScanInitialLoad();
            NewScanInitialLoadObj.Show();
            NewScanInitialLoadObj.FalseServerCommunication(); //TODO: replace it with real server communication
            
            this.Hide();

        }

        private void ScanSingleImage()
        {
            NewScanInitialLoad NewScanInitialLoadObj = new NewScanInitialLoad();
            NewScanInitialLoadObj.Show();
            //System.Threading.Thread.Sleep(400);
            //this.Hide();
            NewScanInitialLoadObj.ServerCommunication();
            //this.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /*public void ServerCommunication(NewScanInitialLoad obj)
        {

            //Thread.Sleep(200);
            //ScanPreview ScanPreview = new ScanPreview();
            //ScanPreview.Show();
            //this.Close();
            //this.Show();
            string command = string.Empty;
            string response = string.Empty;

            obj.labelInitialLoad.Text = "Connecting to scanner...";
            System.Threading.Thread.Sleep(100);
            //MessageBox.Show("conn to scann...");

            if (net.StartClient("192.168.1.113", 3610) == false)
            {
                obj.labelInitialLoad.Text = "Failed to connect!";
                Console.WriteLine("failed to connect");
                System.Threading.Thread.Sleep(200);

                int attempts = 2;
                while ((net.StartClient("192.168.1.104", 3610) == false) && attempts < 99)
                {
                    obj.labelInitialLoad.Text = "Connecting to scanner (attempt " + attempts + ")...";
                    //Console.WriteLine("conn to scanner attempt n");
                    attempts++;
                }


                MessageBox.Show("Could not connect to server !");
                this.Close();
                return;
            }

            obj.labelInitialLoad.Text = "Connecting to scanner... Connected!!!";

            if (net.SendMessage("TakePhoto") == true)
            {
                obj.labelInitialLoad.Text = "Scanning image...";
                Console.WriteLine("scanning image");

                int imageSize = Convert.ToInt32(net.GetMessage()); // Get the image size from the server

                //labelInitialLoad.Text = "Scanning image... Completed!";
                Console.WriteLine("scanning image completed");

                byte[] image = new byte[imageSize];

                int bufferSize = 30000;

                net.clientSocket.ReceiveBufferSize = bufferSize;
                byte[] buffer;
                int remainImage = imageSize;

                net.SendMessage("Ready");
                System.Threading.Thread.Sleep(40);

                //labelInitialLoad.Text = "Downloading image...";
                Console.WriteLine("downloading image...");

                int percentage = 0;

                while (remainImage > 0)
                {
                    net.SendMessage("Ready");

                    percentage = 100 - ((remainImage * 100) / imageSize);

                    //labelInitialLoad.Text = "Downloading image... " + percentage + "%";
                    Console.WriteLine("downl image procentage n");

                    //System.Threading.Thread.Sleep(100); // The row must be positioned before the SendMessage() statement.
                    buffer = net.GetData();
                    for (int i = 0; i < bufferSize; i++)
                    {
                        image[imageSize - remainImage + i] = buffer[i];
                    }
                    remainImage -= bufferSize;
                    if (remainImage < bufferSize)
                    {
                        bufferSize = remainImage;
                        buffer = new byte[bufferSize];
                        net.clientSocket.ReceiveBufferSize = bufferSize;
                    }
                }

                //labelInitialLoad.Text = "Downloading image... Completed!!!";
                Console.WriteLine("downl img.. completed");

                try
                {
                    System.IO.File.WriteAllBytes("R:\\download.jpg", image);
                    Console.WriteLine("Photo size after copying : {0}", image.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    net.StopClient();

                    ScanPreview ScanPreviewObj = new ScanPreview();
                    ScanPreviewObj.Show();

                    this.Close();
                }

            }
        }*/

    }
}
