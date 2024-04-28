using BLL.Models;
using BLL.Network;
using Client.NetworkClasses;
using System.Text.Json;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    public partial class Form1 : Form
    {
        private NetworkClient networkClient;
        private UserModel currentUser;

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
            {
                currentUser = signIn.currentUser;
                this.Visible = true;
                labelUserNameRight.Text = currentUser.Name;
                //UpdateMessageList();
                //UpdateGroupList();
            }
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
                SendMessageModel messageModel = new SendMessageModel()
                {
                    Text = message,
                    UserId = currentUser.Id,
                    ChatId = 2
                };

                var json = JsonSerializer.Serialize(messageModel);
                var response = networkClient.SendRequest(Methods.SendMessage, json);

                if (response.IsSucces)
                {
                    textBoxMessage.Text = "";
                }
                else
                {
                    MessageBox.Show(response.Message);
                }
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

        private void UpdateMessageList()
        {
            var response = networkClient.SendRequest(Methods.GetMessages, currentUser.Id.ToString());

            if (response.IsSucces)
            {
                var messages = JsonSerializer.Deserialize<MessageModel[]>(response.Message);

                listBoxMessages.Items.AddRange(messages);
            }
        }

        private void UpdateGroupList()
        {
            var response = networkClient.SendRequest(Methods.GetGroups, currentUser.Id.ToString());

            if (response.IsSucces)
            {
                var groups = JsonSerializer.Deserialize<GroupModel[]>(response.Message);

                listBoxGroups.Items.AddRange(groups);
            }
        }

        private async Task SendUserProfileToServer(UserModel userProfile)
        {
            try
            {
                TcpClient client = new TcpClient();

                string json = JsonSerializer.Serialize(userProfile);

                byte[] data = Encoding.UTF8.GetBytes(json);

                var stream = client.GetStream();

                await stream.WriteAsync(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void buttonNewChat_Click(object sender, EventArgs e)
        {
            using (var newChatForm = new NewChatForm())
            {
                var result = newChatForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string chatName = newChatForm.ChatName;
                    var selectedUsers = newChatForm.SelectedUsers;

                    var newChat = new ChatModel
                    {
                        Title = chatName
                    };

                    foreach (var user in selectedUsers)
                    {
                        newChat.Users.Add(user);
                    }

                    var json = JsonSerializer.Serialize(newChat);

                    var response = networkClient.SendRequest(Methods.CreateChat, json);

                    if (response.IsSucces)
                    {
                        MessageBox.Show("Chat created successfully.");
                        UpdateGroupList();
                    }
                    else
                    {
                        MessageBox.Show(response.Message);
                    }
                }
            }
        }
    }
}
