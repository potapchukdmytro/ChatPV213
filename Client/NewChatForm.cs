using BLL.Models;
using BLL.Network;
using Client.NetworkClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;


namespace Client
{
    public partial class NewChatForm : Form
    {
        private List<UserModel> _userModels;
        public NewChatForm()
        {
            InitializeComponent();
            PopulateUsersList();

        }

        public string ChatName
        {
            get { return textBoxChatName.Text; }
        }

        public List<UserModel> SelectedUsers
        {
            get
            {
                var selectedItems = listBoxUsers.SelectedItems;
                return selectedItems.Cast<UserModel>().ToList();
            }
        }

        private void PopulateUsersList()
        {
            NetworkClient networkClient = new NetworkClient();
            listBoxUsers.Items.Clear();

            var users = networkClient.GetUsers();

            foreach (var user in users)
            {
                listBoxUsers.Items.Add(user); 
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ChatName))
            {
                MessageBox.Show("Please enter a chat name.");
                return;
            }

            if (SelectedUsers.Count == 0)
            {
                MessageBox.Show("Please select at least one user.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
