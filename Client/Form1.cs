using BLL.Models;
using Client.NetworkClasses;
using Newtonsoft.Json;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    public partial class Form1 : Form
    {
        private NetworkClient networkClient;

        public Form1()
        {
            InitializeComponent();

            networkClient = new NetworkClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectToServer();

            SignIn signIn = new SignIn(networkClient);
            this.Hide();
            signIn.ShowDialog();

            if (signIn.result == DialogResult.Abort)
                this.Close();
            else
                this.Visible = true;

        }

        private void ConnectToServer()
        {
            if (networkClient.Connect())
            {

            }
        }

        private async Task SendUserProfileToServer(UserModel userProfile)
        {
            try
            {
                TcpClient client = new TcpClient();

                string json = JsonConvert.SerializeObject(userProfile);

                byte[] data = Encoding.UTF8.GetBytes(json);

                var stream = client.GetStream();

                await stream.WriteAsync(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
