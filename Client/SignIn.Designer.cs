namespace Client
{
    partial class SignIn
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
            this.signInLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.usernameError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // signInLabel
            // 
            this.signInLabel.AutoSize = true;
            this.signInLabel.Font = new System.Drawing.Font("Monospac821 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signInLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.signInLabel.Location = new System.Drawing.Point(137, 32);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(97, 29);
            this.signInLabel.TabIndex = 0;
            this.signInLabel.Text = "Увійти";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(137, 94);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(194, 23);
            this.usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usernameLabel.Location = new System.Drawing.Point(37, 100);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(84, 17);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Юзернейм";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passwordLabel.Location = new System.Drawing.Point(58, 158);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(63, 17);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Пароль";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.passwordLabel.UseMnemonic = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(137, 152);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(194, 23);
            this.passwordTextBox.TabIndex = 4;
            // 
            // logoPicture
            // 
            this.logoPicture.Image = global::Client.Properties.Resources.logo;
            this.logoPicture.Location = new System.Drawing.Point(66, 218);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(37, 36);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicture.TabIndex = 5;
            this.logoPicture.TabStop = false;
            this.logoPicture.Click += new System.EventHandler(this.logoPicture_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.registerBtn.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registerBtn.Location = new System.Drawing.Point(171, 218);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(142, 36);
            this.registerBtn.TabIndex = 6;
            this.registerBtn.Text = "Реєстрація";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // usernameError
            // 
            this.usernameError.AutoSize = true;
            this.usernameError.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameError.ForeColor = System.Drawing.Color.Firebrick;
            this.usernameError.Location = new System.Drawing.Point(186, 120);
            this.usernameError.Name = "usernameError";
            this.usernameError.Size = new System.Drawing.Size(98, 17);
            this.usernameError.TabIndex = 7;
            this.usernameError.Text = "usernameError";
            this.usernameError.Visible = false;
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordError.ForeColor = System.Drawing.Color.Firebrick;
            this.passwordError.Location = new System.Drawing.Point(186, 178);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(96, 17);
            this.passwordError.TabIndex = 8;
            this.passwordError.Text = "passwordError";
            this.passwordError.Visible = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 288);
            this.Controls.Add(this.passwordError);
            this.Controls.Add(this.usernameError);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.signInLabel);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label signInLabel;
        private TextBox usernameTextBox;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private PictureBox logoPicture;
        private Button registerBtn;
        private Label usernameError;
        private Label passwordError;
    }
}