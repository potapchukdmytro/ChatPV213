using BLL.Models;
using BLL.Network;
using Client.NetworkClasses;
using Client.Validation;
using System.Text.Json;

namespace Client
{
    public partial class SignIn : Form
    {
        private NetworkClient networkClient;

        public DialogResult result;
        public UserModel? currentUser;
        public SignIn(NetworkClient networkClient)
        {
            InitializeComponent();
            result = DialogResult.Abort;
            StartPosition = FormStartPosition.CenterParent;
            this.networkClient = networkClient;
            currentUser = null;
        }

        private bool Validation(LogInModel model)
        {
            usernameError.Visible = false;
            passwordError.Visible = false;

            LogInModelValidation validator = new LogInModelValidation();
            var res = validator.Validate(model);

            foreach (var error in res.Errors)
            {
                if (error.PropertyName == "Login")
                {
                    usernameError.Visible = true;
                    usernameError.Text = error.ErrorMessage;
                    return false;
                }
                if (error.PropertyName == "Password")
                {
                    passwordError.Visible = true;
                    passwordError.Text = error.ErrorMessage;
                    return false;
                }
            }

            return true;
        }

        private void logoPicture_Click(object sender, EventArgs e)
        {
            LogInModel model = new LogInModel()
            {
                Login = usernameTextBox.Text,
                Password = passwordTextBox.Text,
            };

            if (!Validation(model))
            {
                return;
            }

            var data = JsonSerializer.Serialize(model);

            var response = networkClient.SendRequest(Methods.SignIn, data);

            if(response.IsSucces)
            {
                var userModel = JsonSerializer.Deserialize<UserModel>(response.Message);
                result = DialogResult.OK;
                currentUser = userModel;
                Close();
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            SingUp signUp = new SingUp();
            this.Hide();
            signUp.ShowDialog();

            if (signUp.result == DialogResult.Abort)
                this.Close();
            else
                this.Visible = true;
        }
    }
}
