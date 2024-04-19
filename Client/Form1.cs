using Client.Models;
using Client.NetworkClasses;
using Newtonsoft.Json;
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
            SignIn signIn = new SignIn();
            this.Hide();
            signIn.ShowDialog();

            if (signIn.result == DialogResult.Abort)
                this.Close();
            else
                this.Visible = true;

            //ConnectToServer();
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
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(userProfile);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
