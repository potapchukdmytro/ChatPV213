namespace Server
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ServerClass server = new ServerClass("127.0.0.1", 1024);
            await server.StartAsync();

            while(server.IsRunning)
            {
                Thread.Sleep(1000);
            }
        }
    }
}
