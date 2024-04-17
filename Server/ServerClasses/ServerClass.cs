using Server.ServerClasses;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class ServerClass
{
    public List<ClientModel> Clients { get; init; }
    public IPAddress IPAddress { get; set; }
    public int Port { get; set; }
    public bool IsRunning { get; set; }

    private TcpListener? listener;

    public ServerClass(string iPAddress, int port)
    {
        Port = port;
        IPAddress = IPAddress.Parse(iPAddress);
        listener = new TcpListener(IPAddress, Port);
        Clients = new List<ClientModel>();
        IsRunning = false;
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

    private void AcceptClientCallback(TcpClient client)
    {
        if(client == null)
        {
            return;
        }
        
        byte[] buffer = new byte[2048];

        NetworkStream stream = client.GetStream();

        int len = stream.Read(buffer);

        string json = Encoding.Default.GetString(buffer, 0, len);

        Console.WriteLine(json);
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