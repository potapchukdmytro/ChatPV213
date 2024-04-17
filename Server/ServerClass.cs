using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class ServerClass
{
    private TcpListener listener;
    private int port;

    public ServerClass(int port)
    {
        this.port = port;
    }

    public void Start()
    {
        try
        {
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            Console.WriteLine("server stopped");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("client connected");

                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string dataReceived = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine("received: " + dataReceived);

                string responseMessage = "message received";
                byte[] responseData = Encoding.UTF8.GetBytes(responseMessage);
                stream.Write(responseData, 0, responseData.Length);
                Console.WriteLine("answer sent");

                stream.Close();
                client.Close();
                Console.WriteLine("connection ended");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("error: " + ex.Message);
        }
    }

    public void Stop()
    {
        if (listener != null)
        {
            listener.Stop();
            Console.WriteLine("server stopped");
        }
    }
}