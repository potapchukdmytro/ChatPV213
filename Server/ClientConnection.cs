using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientConnection
    {
        private string serverIP;
        private int serverPort;

        public ClientConnection(string serverIP, int serverPort)
        {
            this.serverIP = serverIP;
            this.serverPort = serverPort;
        }
        public void ConnectAndSendMessage(string message)
        {
            try
            {
                TcpClient client = new TcpClient(serverIP, serverPort);

                Console.WriteLine("connected to server");

                NetworkStream stream = client.GetStream();

                byte[] dataToSend = Encoding.UTF8.GetBytes(message);
                stream.Write(dataToSend, 0, dataToSend.Length);

                Console.WriteLine("message sent to server: " + message);

                byte[] responseData = new byte[1024];
                int bytesRead = stream.Read(responseData, 0, responseData.Length);

                string responceMessage = Encoding.UTF8.GetString(responseData);
                Console.WriteLine("response from server: " + responceMessage);

                stream.Close();
                client.Close();

                Console.WriteLine("connection ended");
            } catch (Exception ex)
            {
                Console.WriteLine("error: " + ex);
            }
        }
    }
}
