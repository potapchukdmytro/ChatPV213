namespace Client
{
    partial class NewChatForm
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
            textBoxChatName = new TextBox();
            listBoxUsers = new ListBox();
            buttonOK = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxChatName
            // 
            textBoxChatName.Location = new Point(12, 39);
            textBoxChatName.Name = "textBoxChatName";
            textBoxChatName.Size = new Size(465, 39);
            textBoxChatName.TabIndex = 0;
            // 
            // listBoxUsers
            // 
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 32;
            listBoxUsers.Location = new Point(12, 142);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(465, 228);
            listBoxUsers.TabIndex = 1;
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.DarkSeaGreen;
            buttonOK.Font = new Font("Impact", 9.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOK.ForeColor = Color.Black;
            buttonOK.Location = new Point(12, 376);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(230, 46);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "Ok";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.LightCoral;
            buttonCancel.Font = new Font("Impact", 9.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(246, 376);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(230, 46);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 8.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 27);
            label1.TabIndex = 4;
            label1.Text = "Введіть назву чату";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 8.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(223, 27);
            label2.TabIndex = 5;
            label2.Text = "Додайте користувачів";
            // 
            // NewChatForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 439);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(listBoxUsers);
            Controls.Add(textBoxChatName);
            Name = "NewChatForm";
            Text = "NewChatForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxChatName;
        private ListBox listBoxUsers;
        private Button buttonOK;
        private Button buttonCancel;
        private Label label1;
        private Label label2;
    }
}