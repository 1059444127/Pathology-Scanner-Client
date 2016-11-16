using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace FirstGuiClient
{
    /// <summary>
    /// Raspberry Pi Scan Client Network Controller using Sockets
    /// </summary>
    public class PiNetworkSocketsForm
    {

        /// <summary>
        /// TCP connection with the server
        /// </summary>
        public System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();

        /// <summary>
        /// The server stream
        /// </summary>
        public  NetworkStream serverStream;

        /// <summary>
        /// Starts client at specified ip and port
        /// </summary>
        /// <param name="ip">IP address</param>
        /// <param name="port">Port number</param>
        /// <returns>true - succes; false - fail</returns>
        public bool StartClient(string ip, int port)
        {
            try
            {
                clientSocket.Connect(ip, port);
                Console.WriteLine("Client connected to {0}:{1}!", ip, port);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// Send a string message and receives the response
        /// </summary>
        /// <param name="message">Message to be send</param>
        /// <returns>True - message sent; False - otherwise</returns>
        public bool SendMessage(string message)
        {
            bool returnValue = false;
            try
            {
                //send data
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(message + "$");
                SendData(outStream);
                returnValue = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                returnValue = false;
            }
            return returnValue;
        }

        /// <summary>
        /// Get the message from the server
        /// </summary>
        /// <returns>Message from the server</returns>
        public string GetMessage()
        {
            string returnData = System.Text.Encoding.ASCII.GetString(GetData());
            returnData = returnData.Substring(0, returnData.IndexOf("$"));

            return returnData;
        }

        /// <summary>
        /// Sends data and receives response
        /// </summary>
        /// <param name="data">Actual data to be send</param>
        /// <returns>True - data sent; False - otherwise</returns>
        public bool SendData(byte[] data)
        {
            bool returnValue = false;
            try
            {
                //send data
                serverStream = clientSocket.GetStream();
                serverStream.Write(data, 0, data.Length);
                serverStream.Flush();
                
                // Testing !!!!
                //serverStream.Close();
                // end Testing !!!

                returnValue = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                returnValue = false;
            }

            return returnValue;
        }

        /// <summary>
        /// Get data(image) from the server.
        /// </summary>
        /// <returns>Data(image).</returns>
        public byte[] GetData()
        {
            try
            {
                int streamLength = clientSocket.ReceiveBufferSize;
                byte[] inStream = new byte[streamLength];
                serverStream.Read(inStream, 0, streamLength);

                // Testing
                serverStream.Flush();
                // end Testing

                return inStream;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        /// <summary>
        /// Stop the client
        /// </summary>
        public void StopClient()
        {
            if (clientSocket != null)
                clientSocket.Close();

            Console.WriteLine("Client stopped!");
        }

        /*public void func(string[] args)
        {

            if (StartClient("192.168.1.106", 3610) == true)
            {
                string command = string.Empty;
                string response = string.Empty;
                
                while (true)
                {
                    Console.Write("Command : ");
                    command = Console.ReadLine();

                    if (command.Equals("TakePhoto") == true)
                    {
                        Console.WriteLine("Receiving a image...");
                        if (SendMessage(command + "$") == true)
                        {
                            int imageSize = Convert.ToInt32(GetMessage()); // Get the image size from the sserver
                            byte[] image = new byte[imageSize];

                            int bufferSize = 8192;
                            byte[] buffer;
                            int remainImage = imageSize;
                            
                            SendMessage("Ready$");
                            System.Threading.Thread.Sleep(40);
                            while (remainImage > 0)
                            {
                                
                                SendMessage("Ready$");
                                System.Threading.Thread.Sleep(100); // The row must be positioned before the SendMessage() statement.
                                buffer = GetData();
                                for (int i = 0; i < bufferSize; i++)
                                {
                                    image[imageSize - remainImage + i] = buffer[i];
                                }
                                remainImage -= bufferSize;
                                if (remainImage < bufferSize)
                                    bufferSize = remainImage;
                            }

                            System.IO.File.WriteAllBytes("R:\\file.jpg", image);
                            Console.WriteLine("Photo size after copying : {0}", image.Length);
                        }
                    }
                }
            }
            else
                Console.WriteLine("Could not connect to server!");

            StopClient();

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadLine();
        }*/
    }
}
