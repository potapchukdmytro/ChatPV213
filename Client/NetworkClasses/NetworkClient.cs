using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client.NetworkClasses
{
    public class NetworkClient
    {
        private TcpClient tcpClient;
        private bool isConnected;

        public NetworkClient()
        {
            tcpClient = new TcpClient();
        }

        public bool Connect()
        {
            try
            {
                IPEndPoint iPEnd = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1024);
                tcpClient.Connect(iPEnd);
                isConnected = tcpClient.Connected;
                return isConnected;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to server: " + ex.Message);
                return false;
            }
        }

        public void SendMessage(string message)
        {
            if (!isConnected)
            {
                Console.WriteLine("Not connected to server.");
                return;
            }

            try
            {
                var stream = tcpClient.GetStream();
                byte[] data = Encoding.Default.GetBytes(message);
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Message sent: " + message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending message: " + ex.Message);
            }
        }

        public void SendVoiceMessage(string audioFilePath)
        {
            if (!isConnected)
            {
                Console.WriteLine("Not connected to server.");
                return;
            }

            try
            {
               
                byte[] audioData = File.ReadAllBytes(audioFilePath);

               
                var stream = tcpClient.GetStream();

                
                stream.Write(audioData, 0, audioData.Length);

                Console.WriteLine("Voice message sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending voice message: " + ex.Message);
            }
        }
    }
}
