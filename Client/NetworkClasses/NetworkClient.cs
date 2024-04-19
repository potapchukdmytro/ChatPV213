using BLL.Models;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

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

        public ResponseModel SendRequest(string method, string data)
        {
            if (!isConnected)
            {
                return new ResponseModel
                {
                    IsSucces = false,
                    Message = "Disconnected"
                };
            }

            RequestModel model = new RequestModel
            {
                Data = data,
                Method = method,
            };

            var json = JsonSerializer.Serialize(model);

            var stream = tcpClient.GetStream();

            stream.Write(Encoding.Default.GetBytes(json));

            byte[] buffer = new byte[8192];

            int len = stream.Read(buffer);

            string response = Encoding.Default.GetString(buffer, 0, len);

            var responseModel = JsonSerializer.Deserialize<ResponseModel>(response);

            return responseModel;
        }
    }
}
