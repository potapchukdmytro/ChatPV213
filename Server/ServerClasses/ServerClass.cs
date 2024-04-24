using BLL.Models;
using BLL.Network;
using Server.ServerClasses;
using Server.Services;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

public class ServerClass
{
    public List<ClientModel> Clients { get; init; }
    public IPAddress IPAddress { get; set; }
    public int Port { get; set; }
    public bool IsRunning { get; set; }

    private TcpListener? listener;
    private readonly UserService userService;
    private readonly MessageService messageService;

    public ServerClass(string iPAddress, int port, UserService userService, MessageService messageService)
    {
        Port = port;
        IPAddress = IPAddress.Parse(iPAddress);
        listener = new TcpListener(IPAddress, Port);
        Clients = new List<ClientModel>();
        IsRunning = false;
        this.userService = userService;
        this.messageService = messageService;
    }

    public Task StartAsync()
    {
        IsRunning = true;

        return Task.Run(() =>
        {
            try
            {
                listener?.Start();
                Console.WriteLine("Server started");
                while (IsRunning)
                {
                    Console.WriteLine("wait");
                    var client = listener?.AcceptTcpClient();

                    Task.Run(() =>
                    {
                        AcceptClientCallback(client);
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        });
    }

    private async void AcceptClientCallback(TcpClient client)
    {
        try
        {
            if (client == null)
            {
                return;
            }

            Console.WriteLine($"Connected {client.Client.RemoteEndPoint}");

            byte[] buffer = new byte[8192];

            NetworkStream stream = client.GetStream();

            while (client.Connected)
            {
                int len = stream.Read(buffer);

                string json = Encoding.Default.GetString(buffer, 0, len);

                var request = JsonSerializer.Deserialize<RequestModel>(json);

                if(request.Method == Methods.SignIn)
                {
                    var model = JsonSerializer.Deserialize<LogInModel>(request.Data);

                    var userModel = userService.SignInAsync(model).Result;

                    if(userModel == null)
                    {
                        SendResponse(client, false, "incorrect login or password");
                    }
                    else
                    {
                        SendResponse(client, true, JsonSerializer.Serialize(userModel));
                    }
                }
                else if(request.Method == Methods.SendMessage)
                {
                    var model = JsonSerializer.Deserialize<SendMessageModel>(request.Data);

                    var response = await messageService.CreateMessageAsync(model);

                    SendResponse(client, response.IsSuccess, response.Message);

                }
                else if(request.Method == Methods.GetMessages)
                {
                    int userId = int.Parse(request.Data);
                    var res = await messageService.GetMessagesByUserAsync(userId);

                    string data = JsonSerializer.Serialize(res.ToArray());
                    SendResponse(client, true, data);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private void SendResponse(TcpClient client, bool isSuccess, string message)
    {
        ResponseModel response = new ResponseModel
        {
            IsSucces = isSuccess,
            Message = message
        };

        var json = JsonSerializer.Serialize(response);

        byte[] bytes = Encoding.Default.GetBytes(json);

        var stream = client.GetStream();
        stream.Write(bytes);
    }

    public void Stop()
    {
        if (listener != null)
        {
            IsRunning = false;
            listener.Stop();
            Console.WriteLine("Server stopped");
        }
    }
}