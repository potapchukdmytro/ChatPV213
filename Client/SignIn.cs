﻿using Client.Models;
using Client.Validation;

namespace Client
{
    public partial class SignIn : Form
    {
        public DialogResult result;
        public SignIn()
        {
            InitializeComponent();
            result = DialogResult.Abort;
            StartPosition = FormStartPosition.CenterParent;
        }

        private void logoPicture_Click(object sender, EventArgs e)
        {
            usernameError.Visible = false;
            passwordError.Visible = false;

            LogInModel model = new LogInModel()
            {
                Login = usernameTextBox.Text,
                Password = passwordTextBox.Text,
            };

            LogInModelValidation validator = new LogInModelValidation();
            var res = validator.Validate(model);

            foreach (var error in res.Errors)
            {
                if (error.PropertyName == "Login")
                {
                    usernameError.Visible = true;
                    usernameError.Text = error.ErrorMessage;
                    return;
                }
                if (error.PropertyName == "Password")
                {
                    passwordError.Visible = true;
                    passwordError.Text = error.ErrorMessage;
                    return;
                }
            }

            result = DialogResult.OK;
            Close();
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
