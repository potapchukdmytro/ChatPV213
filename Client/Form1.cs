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
            //ConnectToServer();

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
           
            if (networkClient != null && networkClient.Connect())
            {
                MessageBox.Show("Connected to server successfully.");
               
            }
            else
            {
                MessageBox.Show("Failed to connect to server.");
                
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string message = textBoxMessage.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                // send message
            }
            else
            {
                MessageBox.Show("Please enter a message to send.");
            }
        }

        private void buttonSendVoice_Click(object sender, EventArgs e)
        {

            if (networkClient != null)
            {
                // send voice message
            }
            else
            {
                MessageBox.Show("Network client not initialized.");
            }
        }

        private void buttonSendImage_Click(object sender, EventArgs e)
        {
            if (networkClient != null)
            {
                // send image
            }
            else
            {
                MessageBox.Show("Network client not initialized.");
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out successfully.");
        }

        private void buttonExplore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exploring...");
        }

        private void buttonChat_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Opening chat...");
            
        }

        private void buttonColls_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accessing collections...");
        }

        private void buttonContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Managing contacts...");
        }

        private void buttonPrivacy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Managing privacy settings...");
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accessing settings...");
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {
            buttonSend.Enabled = !string.IsNullOrEmpty(textBoxMessage.Text.Trim());
        }

        private void buttonAlert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alert triggered.");
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
