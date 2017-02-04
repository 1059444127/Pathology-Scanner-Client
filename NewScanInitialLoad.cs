using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace FirstGuiClient
{
    public partial class NewScanInitialLoad : Form
    {
        //PiNetworkSocketsForm net = new PiNetworkSocketsForm();
        public NewScanInitialLoad()
        {
            InitializeComponent();
            labelInitialLoad.Text = Controller.GetStatus();

            //Controller.InitializeScanPreview();
            //labelInitialLoad.Text = Controller.GetStatus();

            //Controller.ImageName = Controller.TakePhoto();
            //labelInitialLoad.Text = Controller.GetStatus();

            //Controller.GetPhoto(Controller.ImageName);
            //labelInitialLoad.Text = Controller.GetStatus();
        }

        private void NewScanInitialLoad_Load(object sender, EventArgs e)
        {
            //Controller.InitializeScanPreview();
            //labelInitialLoad.Text = Controller.GetStatus();

            //Controller.ImageName = Controller.TakePhoto();
            //labelInitialLoad.Text = Controller.GetStatus();

            //Controller.GetPhoto(Controller.ImageName);
            //labelInitialLoad.Text = Controller.GetStatus();
        }

        private void textBoxInitialLoad_TextChanged(object sender, EventArgs e)
        {
            //this.Refresh();
            //this.labelInitialLoad.ResetText();
            //this.labelInitialLoad.ResumeLayout();
            //this.labelInitialLoad.Show();
            this.labelInitialLoad.Update();
        }

        //public void FalseServerCommunication()
        //{
        //    ScanPreview ScanPreviewObj = new ScanPreview();
        //    ScanPreviewObj.Show();

        //    this.Close();
        //}

        private void labelInitialLoad_Click(object sender, EventArgs e)
        {

        }

        private void labelInitialLoad_TextChanged(object sender, EventArgs e)
        {

        }


        /*public void Process()
        {
            Thread.Sleep(200);
            //ScanPreview ScanPreview = new ScanPreview();
            //ScanPreview.Show();
            //this.Close();
            //this.Show();
            string command = string.Empty;
            string response = string.Empty;

            textBoxInitialLoad.Text = "Connecting to scanner...";

            if (net.StartClient("192.168.1.104", 3610) == false)
            {
                textBoxInitialLoad.Text = "Failed to connect!";
                Thread.Sleep(200);

                //int attempts = 2;
                //while (net.StartClient("192.168.1.104", 3610) == false)
                //{
                    //textBoxInitialLoad.Text = "Connecting to scanner (attempt " + attempts + ")...";
                    //attempts++;
                //}
                return;
            }

            textBoxInitialLoad.Text = "Connecting to scanner... Connected!!!";

            if (net.SendMessage("TakePhoto") == true)
            {
                textBoxInitialLoad.Text = "Scanning image...";

                int imageSize = Convert.ToInt32(net.GetMessage()); // Get the image size from the sserver

                textBoxInitialLoad.Text = "Scanning image... Completed!";

                byte[] image = new byte[imageSize];

                int bufferSize = 8192;
                byte[] buffer;
                int remainImage = imageSize;

                net.SendMessage("Ready");
                System.Threading.Thread.Sleep(40);

                textBoxInitialLoad.Text = "Downloading image...";

                int percentage = 0;

                while (remainImage > 0)
                {
                    net.SendMessage("Ready");

                    percentage = 100 - ((remainImage * 100) / imageSize);

                    textBoxInitialLoad.Text = "Downloading image... " + percentage + "%";

                    System.Threading.Thread.Sleep(100); // The row must be positioned before the SendMessage() statement.
                    buffer = net.GetData();
                    for (int i = 0; i < bufferSize; i++)
                    {
                        image[imageSize - remainImage + i] = buffer[i];
                    }
                    remainImage -= bufferSize;
                    if (remainImage < bufferSize)
                        bufferSize = remainImage;
                }

                textBoxInitialLoad.Text = "Downloading image... Completed!!!";

                System.IO.File.WriteAllBytes("R:\\img.jpg", image);
                Console.WriteLine("Photo size after copying : {0}", image.Length);

                net.StopClient();
            }

        }*/
        //public void GetMultipleImages()
        //{
        //    string command = string.Empty;
        //    string response = string.Empty;

        //    labelInitialLoad.Text = "Connecting to scanner...";

        //    labelInitialLoad.Update();
        //    //MessageBox.Show("conn to scann...");

        //    if (net.StartClient("192.168.1.113", 3610) == false)
        //    {
        //        labelInitialLoad.Text = "Failed to connect!";
        //        labelInitialLoad.Update();
        //        Thread.Sleep(200);

        //        int attempts = 2;
        //        while ((net.StartClient("192.168.1.104", 3610) == false) && attempts < 10)
        //        {
        //            labelInitialLoad.Text = "Connecting to scanner (attempt " + attempts + ")...";
        //            labelInitialLoad.Update();
        //            attempts++;
        //        }


        //        MessageBox.Show("Could not connect to server !");
        //        this.Close();
        //        return;
        //    }

        //    labelInitialLoad.Text = "Connecting to scanner... Connected!!!";
        //    labelInitialLoad.Update();

        //    if (net.SendMessage("TakePhoto") == true)
        //    {
        //        labelInitialLoad.Text = "Scanning image...";
        //        labelInitialLoad.Update();

        //        int imageSize = Convert.ToInt32(net.GetMessage()); // Get the image size from the server

        //        labelInitialLoad.Text = "Scanning image... Completed!";
        //        labelInitialLoad.Update();

        //        byte[] image = new byte[imageSize];

        //        int bufferSize = 30000;

        //        net.clientSocket.ReceiveBufferSize = bufferSize;
        //        byte[] buffer;
        //        int remainImage = imageSize;

        //        net.SendMessage("Ready");
        //        System.Threading.Thread.Sleep(40);

        //        labelInitialLoad.Text = "Downloading image...";
        //        labelInitialLoad.Update();

        //        int percentage = 0;

        //        while (remainImage > 0)
        //        {
        //            net.SendMessage("Ready");

        //            percentage = 100 - ((remainImage * 100) / imageSize);

        //            labelInitialLoad.Text = "Downloading image... " + percentage + "%";
        //            labelInitialLoad.Update();

        //            //System.Threading.Thread.Sleep(100); // The row must be positioned before the SendMessage() statement.
        //            buffer = net.GetData();
        //            for (int i = 0; i < bufferSize; i++)
        //            {
        //                image[imageSize - remainImage + i] = buffer[i];
        //            }
        //            remainImage -= bufferSize;
        //            if (remainImage < bufferSize)
        //            {
        //                bufferSize = remainImage;
        //                buffer = new byte[bufferSize];
        //                net.clientSocket.ReceiveBufferSize = bufferSize;
        //            }
        //        }

        //        labelInitialLoad.Text = "Downloading image... Completed!!!";
        //        labelInitialLoad.Update();

        //        try
        //        {
        //            System.IO.File.WriteAllBytes("R:\\download.jpg", image);
        //            Console.WriteLine("Photo size after copying : {0}", image.Length);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }

        //        finally
        //        {
        //            net.StopClient();

        //            ScanPreview ScanPreviewObj = new ScanPreview();
        //            ScanPreviewObj.Show();

        //            this.Close();
        //        }

        //    }

        //}

        //public void ServerCommunication()
        //{

        //    //Thread.Sleep(200);
        //    //ScanPreview ScanPreview = new ScanPreview();
        //    //ScanPreview.Show();
        //    //this.Close();
        //    //this.Show();
        //    string command = string.Empty;
        //    string response = string.Empty;

        //    labelInitialLoad.Text = "Connecting to scanner...";
        //    labelInitialLoad.Update();
        //    //MessageBox.Show("conn to scann...");

        //    if (net.StartClient("192.168.1.113", 3610) == false)
        //    {
        //        labelInitialLoad.Text = "Failed to connect!";
        //        labelInitialLoad.Update();
        //        Thread.Sleep(200);

        //        int attempts = 2;
        //        while ((net.StartClient("192.168.1.104", 3610) == false) && attempts < 10)
        //        {
        //        labelInitialLoad.Text = "Connecting to scanner (attempt " + attempts + ")...";
        //        labelInitialLoad.Update();
        //        attempts++;
        //        }


        //        MessageBox.Show("Could not connect to server !");
        //        this.Close();
        //        return;
        //    }

        //    labelInitialLoad.Text = "Connecting to scanner... Connected!!!";
        //    labelInitialLoad.Update();

        //    if (net.SendMessage("TakePhoto") == true)
        //    {
        //        labelInitialLoad.Text = "Scanning image...";
        //        labelInitialLoad.Update();

        //        int imageSize = Convert.ToInt32(net.GetMessage()); // Get the image size from the server

        //        labelInitialLoad.Text = "Scanning image... Completed!";
        //        labelInitialLoad.Update();

        //        byte[] image = new byte[imageSize];

        //        int bufferSize = 30000;

        //        net.clientSocket.ReceiveBufferSize = bufferSize;
        //        byte[] buffer;
        //        int remainImage = imageSize;

        //        net.SendMessage("Ready");
        //        System.Threading.Thread.Sleep(40);

        //        labelInitialLoad.Text = "Downloading image...";
        //        labelInitialLoad.Update();

        //        int percentage = 0;

        //        while (remainImage > 0)
        //        {
        //            net.SendMessage("Ready");

        //            percentage = 100 - ((remainImage * 100) / imageSize);

        //            labelInitialLoad.Text = "Downloading image... " + percentage + "%";
        //            labelInitialLoad.Update();

        //            //System.Threading.Thread.Sleep(100); // The row must be positioned before the SendMessage() statement.
        //            buffer = net.GetData();
        //            for (int i = 0; i < bufferSize; i++)
        //            {
        //                image[imageSize - remainImage + i] = buffer[i];
        //            }
        //            remainImage -= bufferSize;
        //            if (remainImage < bufferSize)
        //            {
        //                bufferSize = remainImage;
        //                buffer = new byte[bufferSize];
        //                net.clientSocket.ReceiveBufferSize = bufferSize;
        //            }
        //        }

        //        labelInitialLoad.Text = "Downloading image... Completed!!!";
        //        labelInitialLoad.Update();

        //        try
        //        {
        //            System.IO.File.WriteAllBytes("R:\\download.jpg", image);
        //            Console.WriteLine("Photo size after copying : {0}", image.Length);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }

        //        finally
        //        {
        //            net.StopClient();

        //            ScanPreview ScanPreviewObj = new ScanPreview();
        //            ScanPreviewObj.Show();

        //            this.Close();
        //        }

        //    }
        //}

    }
}
