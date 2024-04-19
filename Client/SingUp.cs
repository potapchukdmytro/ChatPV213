using Client.Models;
using Client.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Client
{
    public partial class SingUp : Form
    {
        public DialogResult result;
        
        public SingUp()
        {
            InitializeComponent();
            result = DialogResult.Abort;
            StartPosition = FormStartPosition.CenterParent;

        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            Close();
        }

        private void buttonSingUp_Click(object sender, EventArgs e)
        {
            SignUpValidator validations= new SignUpValidator();

            labelNameValidation.Visible = false;
            labelSurnameValidation.Visible = false;
            labelUsernameValidation.Visible = false;
            labelEmailValidation.Visible = false;
            labelPasswordValidation.Visible = false;

            SignUpModel model = new SignUpModel
            {
                Name = textBoxName.Text,
                Lastname = textBoxSurname.Text,
                Username = textBoxUsername.Text,
                Email = textBoxEmail.Text,
                Password = textBoxPassword.Text
            };



            var res = validations.Validate(model);
            foreach (var error in res.Errors) 
            {
                if (error.PropertyName == "Name")
                {
                    labelNameValidation.Visible = true;
                    labelNameValidation.Text = error.ErrorMessage;
                    return;
                }
                if (error.PropertyName == "Lastname")
                {
                    labelSurnameValidation.Visible = true;
                    labelSurnameValidation.Text = error.ErrorMessage;
                    return;
                }
                if (error.PropertyName == "Username")
                {
                    labelUsernameValidation.Visible = true;
                    labelUsernameValidation.Text = error.ErrorMessage;
                    return;
                }
                if (error.PropertyName == "Email")
                {
                    labelEmailValidation.Visible = true;
                    labelEmailValidation.Text = error.ErrorMessage;
                    return;
                }
                if (error.PropertyName == "Password")
                {
                    labelPasswordValidation.Visible = true;
                    labelPasswordValidation.Text = error.ErrorMessage;
                    return;
                }
            }
        }
    }
}
