﻿namespace Client
{
    partial class SingUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonSingUp = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelNameValidation = new System.Windows.Forms.Label();
            this.labelSurnameValidation = new System.Windows.Forms.Label();
            this.labelUsernameValidation = new System.Windows.Forms.Label();
            this.labelEmailValidation = new System.Windows.Forms.Label();
            this.labelPasswordValidation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(101, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Реєстрація";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(113, 89);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSurname.Location = new System.Drawing.Point(113, 132);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(200, 22);
            this.textBoxSurname.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.Location = new System.Drawing.Point(113, 175);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 22);
            this.textBoxUsername.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.Location = new System.Drawing.Point(113, 218);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 22);
            this.textBoxEmail.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(113, 261);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(200, 22);
            this.textBoxPassword.TabIndex = 5;
            // 
            // buttonSingUp
            // 
            this.buttonSingUp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSingUp.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSingUp.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSingUp.Location = new System.Drawing.Point(101, 325);
            this.buttonSingUp.Name = "buttonSingUp";
            this.buttonSingUp.Size = new System.Drawing.Size(152, 28);
            this.buttonSingUp.TabIndex = 6;
            this.buttonSingUp.Text = "Реєстрація";
            this.buttonSingUp.UseVisualStyleBackColor = false;
            this.buttonSingUp.Click += new System.EventHandler(this.buttonSingUp_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonLogin.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLogin.Location = new System.Drawing.Point(119, 422);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(117, 29);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Увійти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelName.Location = new System.Drawing.Point(69, 94);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(34, 17);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Ім\'я";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSurname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSurname.Location = new System.Drawing.Point(27, 137);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(78, 17);
            this.labelSurname.TabIndex = 9;
            this.labelSurname.Text = "Прізвище";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUsername.Location = new System.Drawing.Point(23, 180);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(84, 17);
            this.labelUsername.TabIndex = 10;
            this.labelUsername.Text = "Юзернейм";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelEmail.Location = new System.Drawing.Point(50, 223);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(55, 17);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "Пошта";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPassword.Location = new System.Drawing.Point(40, 266);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 17);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Пароль";
            // 
            // labelNameValidation
            // 
            this.labelNameValidation.AutoSize = true;
            this.labelNameValidation.ForeColor = System.Drawing.Color.Red;
            this.labelNameValidation.Location = new System.Drawing.Point(119, 114);
            this.labelNameValidation.Name = "labelNameValidation";
            this.labelNameValidation.Size = new System.Drawing.Size(62, 15);
            this.labelNameValidation.TabIndex = 13;
            this.labelNameValidation.Text = "nameError";
            this.labelNameValidation.Visible = false;
            // 
            // labelSurnameValidation
            // 
            this.labelSurnameValidation.AutoSize = true;
            this.labelSurnameValidation.ForeColor = System.Drawing.Color.Red;
            this.labelSurnameValidation.Location = new System.Drawing.Point(119, 157);
            this.labelSurnameValidation.Name = "labelSurnameValidation";
            this.labelSurnameValidation.Size = new System.Drawing.Size(78, 15);
            this.labelSurnameValidation.TabIndex = 14;
            this.labelSurnameValidation.Text = "surnameError";
            this.labelSurnameValidation.Visible = false;
            // 
            // labelUsernameValidation
            // 
            this.labelUsernameValidation.AutoSize = true;
            this.labelUsernameValidation.ForeColor = System.Drawing.Color.Red;
            this.labelUsernameValidation.Location = new System.Drawing.Point(119, 200);
            this.labelUsernameValidation.Name = "labelUsernameValidation";
            this.labelUsernameValidation.Size = new System.Drawing.Size(84, 15);
            this.labelUsernameValidation.TabIndex = 15;
            this.labelUsernameValidation.Text = "usernameError";
            this.labelUsernameValidation.Visible = false;
            // 
            // labelEmailValidation
            // 
            this.labelEmailValidation.AutoSize = true;
            this.labelEmailValidation.ForeColor = System.Drawing.Color.Red;
            this.labelEmailValidation.Location = new System.Drawing.Point(119, 243);
            this.labelEmailValidation.Name = "labelEmailValidation";
            this.labelEmailValidation.Size = new System.Drawing.Size(61, 15);
            this.labelEmailValidation.TabIndex = 16;
            this.labelEmailValidation.Text = "emailError";
            this.labelEmailValidation.Visible = false;
            // 
            // labelPasswordValidation
            // 
            this.labelPasswordValidation.AutoSize = true;
            this.labelPasswordValidation.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordValidation.Location = new System.Drawing.Point(119, 286);
            this.labelPasswordValidation.Name = "labelPasswordValidation";
            this.labelPasswordValidation.Size = new System.Drawing.Size(82, 15);
            this.labelPasswordValidation.TabIndex = 17;
            this.labelPasswordValidation.Text = "passwordError";
            this.labelPasswordValidation.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(128, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Маєте акаунт?";
            // 
            // SingUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPasswordValidation);
            this.Controls.Add(this.labelEmailValidation);
            this.Controls.Add(this.labelUsernameValidation);
            this.Controls.Add(this.labelSurnameValidation);
            this.Controls.Add(this.labelNameValidation);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonSingUp);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "SingUp";
            this.Text = "SingUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxUsername;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Button buttonSingUp;
        private Button buttonLogin;
        private Label labelName;
        private Label labelSurname;
        private Label labelUsername;
        private Label labelEmail;
        private Label labelPassword;
        private Label labelNameValidation;
        private Label labelSurnameValidation;
        private Label labelUsernameValidation;
        private Label labelEmailValidation;
        private Label labelPasswordValidation;
        private Label label2;
    }
}