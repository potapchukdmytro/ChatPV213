using BLL.Models;
using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Config config = new Config();
            
            ServerClass server = new ServerClass("127.0.0.1", 1024, config.UserService, config.MessageService);
            await server.StartAsync();

            while(server.IsRunning)
            {
                Thread.Sleep(1000);
            }
        }

        private async Task GetUserProfile()
        {
            try
            {
                TcpListener server = new TcpListener(IPAddress.Any, 1024);
                server.Start();

                while (true)
                {
                    TcpClient client = await server.AcceptTcpClientAsync();

                    var stream = client.GetStream();
                    byte[] buffer = new byte[client.ReceiveBufferSize];

                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    string json = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    UserModel userProfile = JsonConvert.DeserializeObject<UserModel>(json);

                    client.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
