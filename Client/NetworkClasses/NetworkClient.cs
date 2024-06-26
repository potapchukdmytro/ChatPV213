﻿using System;
using System.IO;
﻿using BLL.Models;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using BLL.Network;

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
                MessageBox.Show("Not connected to server.");
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

        public List<UserModel> GetUsers()
        {
            var response = SendRequest(Methods.GetUsers, "");

            if (response.IsSucces)
            {
                return JsonSerializer.Deserialize<List<UserModel>>(response.Message);
            }
            else
            {
                Console.WriteLine("Failed to get users: " + response.Message);
                return new List<UserModel>();
            }
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
