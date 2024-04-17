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
            IPEndPoint iPEnd = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1024);
            tcpClient.Connect(iPEnd);

            isConnected = tcpClient.Connected;
            return isConnected;
        }

        public void SendMessage(string message)
        {
            if (!isConnected)
            {
                return;
            }

            var stream = tcpClient.GetStream();

            stream.Write(Encoding.Default.GetBytes(message));
        }

        public void SendUser(string model)
        {

        }
    }
}
