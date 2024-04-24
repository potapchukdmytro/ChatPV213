namespace Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabControl Primary;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabPagePrimary = new TabPage();
            tabPageGroups = new TabPage();
            tabPageArchive = new TabPage();
            groupBoxInbox = new GroupBox();
            labelInbox = new Label();
            groupBoxMenu = new GroupBox();
            labelLogOut = new Label();
            buttonLogOut = new Button();
            labelUserUameLeft = new Label();
            pictureBoxAvatarLeft = new PictureBox();
            labelSetting = new Label();
            labelPrivacy = new Label();
            labelContact = new Label();
            labelColls = new Label();
            labelChat = new Label();
            labelExsplore = new Label();
            buttonContact = new Button();
            buttonPrivacy = new Button();
            buttonSetting = new Button();
            buttonColls = new Button();
            buttonChat = new Button();
            buttonExplore = new Button();
            groupBoxChat = new GroupBox();
            textBoxMessage = new TextBox();
            buttonSend = new Button();
            buttonSendVoice = new Button();
            buttonSendImage = new Button();
            buttonChatEnd = new Button();
            buttonVoiceChat = new Button();
            buttonVideoChat = new Button();
            labelUserNameCenter = new Label();
            pictureBoxAvatarCenter = new PictureBox();
            panel = new Panel();
            labelUserNameRight = new Label();
            pictureBoxAvatarRight = new PictureBox();
            buttonAlert = new Button();
            buttonNewChat = new Button();
            labelChatTitle = new Label();
            listBoxMessages = new ListBox();
            Primary = new TabControl();
            Primary.SuspendLayout();
            groupBoxInbox.SuspendLayout();
            groupBoxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatarLeft).BeginInit();
            groupBoxChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatarCenter).BeginInit();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatarRight).BeginInit();
            SuspendLayout();
            // 
            // Primary
            // 
            Primary.Controls.Add(tabPagePrimary);
            Primary.Controls.Add(tabPageGroups);
            Primary.Controls.Add(tabPageArchive);
            Primary.Font = new Font("Impact", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Primary.Location = new Point(17, 38);
            Primary.Name = "Primary";
            Primary.SelectedIndex = 0;
            Primary.Size = new Size(268, 481);
            Primary.TabIndex = 1;
            // 
            // tabPagePrimary
            // 
            tabPagePrimary.BackColor = Color.Gray;
            tabPagePrimary.Location = new Point(4, 26);
            tabPagePrimary.Name = "tabPagePrimary";
            tabPagePrimary.Padding = new Padding(3);
            tabPagePrimary.Size = new Size(260, 451);
            tabPagePrimary.TabIndex = 0;
            tabPagePrimary.Text = "Primary";
            // 
            // tabPageGroups
            // 
            tabPageGroups.BackColor = Color.Gray;
            tabPageGroups.Location = new Point(4, 26);
            tabPageGroups.Name = "tabPageGroups";
            tabPageGroups.Padding = new Padding(3);
            tabPageGroups.Size = new Size(260, 451);
            tabPageGroups.TabIndex = 1;
            tabPageGroups.Text = "Groups";
            // 
            // tabPageArchive
            // 
            tabPageArchive.BackColor = Color.Gray;
            tabPageArchive.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageArchive.Location = new Point(4, 26);
            tabPageArchive.Name = "tabPageArchive";
            tabPageArchive.Padding = new Padding(3);
            tabPageArchive.RightToLeft = RightToLeft.No;
            tabPageArchive.Size = new Size(260, 451);
            tabPageArchive.TabIndex = 2;
            tabPageArchive.Text = "Archive";
            // 
            // groupBoxInbox
            // 
            groupBoxInbox.BackColor = Color.Gray;
            groupBoxInbox.Controls.Add(Primary);
            groupBoxInbox.Controls.Add(labelInbox);
            groupBoxInbox.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxInbox.Location = new Point(252, 86);
            groupBoxInbox.Name = "groupBoxInbox";
            groupBoxInbox.Size = new Size(301, 530);
            groupBoxInbox.TabIndex = 0;
            groupBoxInbox.TabStop = false;
            // 
            // labelInbox
            // 
            labelInbox.Location = new Point(6, 0);
            labelInbox.Name = "labelInbox";
            labelInbox.Size = new Size(80, 35);
            labelInbox.TabIndex = 0;
            labelInbox.Text = "Inbox";
            labelInbox.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBoxMenu
            // 
            groupBoxMenu.BackColor = Color.Gray;
            groupBoxMenu.Controls.Add(labelLogOut);
            groupBoxMenu.Controls.Add(buttonLogOut);
            groupBoxMenu.Controls.Add(labelUserUameLeft);
            groupBoxMenu.Controls.Add(pictureBoxAvatarLeft);
            groupBoxMenu.Controls.Add(labelSetting);
            groupBoxMenu.Controls.Add(labelPrivacy);
            groupBoxMenu.Controls.Add(labelContact);
            groupBoxMenu.Controls.Add(labelColls);
            groupBoxMenu.Controls.Add(labelChat);
            groupBoxMenu.Controls.Add(labelExsplore);
            groupBoxMenu.Controls.Add(buttonContact);
            groupBoxMenu.Controls.Add(buttonPrivacy);
            groupBoxMenu.Controls.Add(buttonSetting);
            groupBoxMenu.Controls.Add(buttonColls);
            groupBoxMenu.Controls.Add(buttonChat);
            groupBoxMenu.Controls.Add(buttonExplore);
            groupBoxMenu.Location = new Point(12, 12);
            groupBoxMenu.Name = "groupBoxMenu";
            groupBoxMenu.Size = new Size(223, 604);
            groupBoxMenu.TabIndex = 1;
            groupBoxMenu.TabStop = false;
            // 
            // labelLogOut
            // 
            labelLogOut.AutoSize = true;
            labelLogOut.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogOut.Location = new Point(52, 561);
            labelLogOut.Name = "labelLogOut";
            labelLogOut.Size = new Size(55, 19);
            labelLogOut.TabIndex = 23;
            labelLogOut.Text = "Log out";
            // 
            // buttonLogOut
            // 
            buttonLogOut.ForeColor = SystemColors.ControlLight;
            buttonLogOut.Image = (Image)resources.GetObject("buttonLogOut.Image");
            buttonLogOut.Location = new Point(6, 553);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(40, 37);
            buttonLogOut.TabIndex = 22;
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // labelUserUameLeft
            // 
            labelUserUameLeft.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserUameLeft.Location = new Point(52, 8);
            labelUserUameLeft.Name = "labelUserUameLeft";
            labelUserUameLeft.Size = new Size(105, 29);
            labelUserUameLeft.TabIndex = 11;
            labelUserUameLeft.Text = "User name";
            labelUserUameLeft.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxAvatarLeft
            // 
            pictureBoxAvatarLeft.Location = new Point(6, 8);
            pictureBoxAvatarLeft.Name = "pictureBoxAvatarLeft";
            pictureBoxAvatarLeft.Size = new Size(34, 29);
            pictureBoxAvatarLeft.TabIndex = 10;
            pictureBoxAvatarLeft.TabStop = false;
            // 
            // labelSetting
            // 
            labelSetting.AutoSize = true;
            labelSetting.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSetting.Location = new Point(52, 266);
            labelSetting.Name = "labelSetting";
            labelSetting.Size = new Size(55, 19);
            labelSetting.TabIndex = 21;
            labelSetting.Text = "Setting";
            // 
            // labelPrivacy
            // 
            labelPrivacy.AutoSize = true;
            labelPrivacy.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrivacy.Location = new Point(52, 223);
            labelPrivacy.Name = "labelPrivacy";
            labelPrivacy.Size = new Size(55, 19);
            labelPrivacy.TabIndex = 20;
            labelPrivacy.Text = "Privacy";
            // 
            // labelContact
            // 
            labelContact.AutoSize = true;
            labelContact.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelContact.Location = new Point(52, 180);
            labelContact.Name = "labelContact";
            labelContact.Size = new Size(58, 19);
            labelContact.TabIndex = 19;
            labelContact.Text = "Contact";
            // 
            // labelColls
            // 
            labelColls.AutoSize = true;
            labelColls.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelColls.Location = new Point(52, 137);
            labelColls.Name = "labelColls";
            labelColls.Size = new Size(40, 19);
            labelColls.TabIndex = 18;
            labelColls.Text = "Colls";
            // 
            // labelChat
            // 
            labelChat.AutoSize = true;
            labelChat.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelChat.Location = new Point(52, 94);
            labelChat.Name = "labelChat";
            labelChat.Size = new Size(38, 19);
            labelChat.TabIndex = 17;
            labelChat.Text = "Chat";
            // 
            // labelExsplore
            // 
            labelExsplore.AutoSize = true;
            labelExsplore.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelExsplore.Location = new Point(52, 51);
            labelExsplore.Name = "labelExsplore";
            labelExsplore.Size = new Size(62, 19);
            labelExsplore.TabIndex = 16;
            labelExsplore.Text = "Exsplore";
            // 
            // buttonContact
            // 
            buttonContact.ForeColor = SystemColors.ControlLight;
            buttonContact.Image = (Image)resources.GetObject("buttonContact.Image");
            buttonContact.Location = new Point(6, 172);
            buttonContact.Name = "buttonContact";
            buttonContact.Size = new Size(40, 37);
            buttonContact.TabIndex = 15;
            buttonContact.UseVisualStyleBackColor = true;
            buttonContact.Click += buttonContact_Click;
            // 
            // buttonPrivacy
            // 
            buttonPrivacy.ForeColor = SystemColors.ControlLight;
            buttonPrivacy.Image = (Image)resources.GetObject("buttonPrivacy.Image");
            buttonPrivacy.Location = new Point(6, 215);
            buttonPrivacy.Name = "buttonPrivacy";
            buttonPrivacy.Size = new Size(40, 37);
            buttonPrivacy.TabIndex = 14;
            buttonPrivacy.UseVisualStyleBackColor = true;
            buttonPrivacy.Click += buttonPrivacy_Click;
            // 
            // buttonSetting
            // 
            buttonSetting.ForeColor = SystemColors.ControlLight;
            buttonSetting.Image = (Image)resources.GetObject("buttonSetting.Image");
            buttonSetting.Location = new Point(6, 258);
            buttonSetting.Name = "buttonSetting";
            buttonSetting.Size = new Size(40, 37);
            buttonSetting.TabIndex = 13;
            buttonSetting.UseVisualStyleBackColor = true;
            buttonSetting.Click += buttonSetting_Click;
            // 
            // buttonColls
            // 
            buttonColls.ForeColor = SystemColors.ControlLight;
            buttonColls.Image = (Image)resources.GetObject("buttonColls.Image");
            buttonColls.Location = new Point(6, 129);
            buttonColls.Name = "buttonColls";
            buttonColls.Size = new Size(40, 37);
            buttonColls.TabIndex = 12;
            buttonColls.UseVisualStyleBackColor = true;
            buttonColls.Click += buttonColls_Click;
            // 
            // buttonChat
            // 
            buttonChat.BackColor = Color.Gray;
            buttonChat.ForeColor = SystemColors.ControlLightLight;
            buttonChat.Image = (Image)resources.GetObject("buttonChat.Image");
            buttonChat.Location = new Point(6, 86);
            buttonChat.Name = "buttonChat";
            buttonChat.Size = new Size(40, 37);
            buttonChat.TabIndex = 11;
            buttonChat.UseVisualStyleBackColor = false;
            buttonChat.Click += buttonChat_Click;
            // 
            // buttonExplore
            // 
            buttonExplore.ForeColor = SystemColors.ControlLight;
            buttonExplore.Image = (Image)resources.GetObject("buttonExplore.Image");
            buttonExplore.Location = new Point(6, 43);
            buttonExplore.Name = "buttonExplore";
            buttonExplore.Size = new Size(40, 37);
            buttonExplore.TabIndex = 10;
            buttonExplore.UseVisualStyleBackColor = true;
            buttonExplore.Click += buttonExplore_Click;
            // 
            // groupBoxChat
            // 
            groupBoxChat.BackColor = Color.Gray;
            groupBoxChat.Controls.Add(listBoxMessages);
            groupBoxChat.Controls.Add(textBoxMessage);
            groupBoxChat.Controls.Add(buttonSend);
            groupBoxChat.Controls.Add(buttonSendVoice);
            groupBoxChat.Controls.Add(buttonSendImage);
            groupBoxChat.Controls.Add(buttonChatEnd);
            groupBoxChat.Controls.Add(buttonVoiceChat);
            groupBoxChat.Controls.Add(buttonVideoChat);
            groupBoxChat.Controls.Add(labelUserNameCenter);
            groupBoxChat.Controls.Add(pictureBoxAvatarCenter);
            groupBoxChat.Location = new Point(571, 86);
            groupBoxChat.Name = "groupBoxChat";
            groupBoxChat.Size = new Size(536, 530);
            groupBoxChat.TabIndex = 0;
            groupBoxChat.TabStop = false;
            groupBoxChat.Text = "x";
            // 
            // textBoxMessage
            // 
            textBoxMessage.BackColor = Color.FromArgb(224, 224, 224);
            textBoxMessage.Location = new Point(16, 489);
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(329, 27);
            textBoxMessage.TabIndex = 27;
            textBoxMessage.TextChanged += textBoxMessage_TextChanged;
            // 
            // buttonSend
            // 
            buttonSend.ForeColor = SystemColors.ControlLight;
            buttonSend.Image = (Image)resources.GetObject("buttonSend.Image");
            buttonSend.Location = new Point(485, 488);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(40, 37);
            buttonSend.TabIndex = 26;
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // buttonSendVoice
            // 
            buttonSendVoice.ForeColor = SystemColors.ControlLight;
            buttonSendVoice.Image = (Image)resources.GetObject("buttonSendVoice.Image");
            buttonSendVoice.Location = new Point(427, 488);
            buttonSendVoice.Name = "buttonSendVoice";
            buttonSendVoice.Size = new Size(40, 37);
            buttonSendVoice.TabIndex = 25;
            buttonSendVoice.UseVisualStyleBackColor = true;
            buttonSendVoice.Click += buttonSendVoice_Click;
            // 
            // buttonSendImage
            // 
            buttonSendImage.ForeColor = SystemColors.ControlLight;
            buttonSendImage.Image = (Image)resources.GetObject("buttonSendImage.Image");
            buttonSendImage.Location = new Point(366, 487);
            buttonSendImage.Name = "buttonSendImage";
            buttonSendImage.Size = new Size(40, 37);
            buttonSendImage.TabIndex = 24;
            buttonSendImage.UseVisualStyleBackColor = true;
            buttonSendImage.Click += buttonSendImage_Click;
            // 
            // buttonChatEnd
            // 
            buttonChatEnd.ForeColor = SystemColors.ControlLight;
            buttonChatEnd.Image = (Image)resources.GetObject("buttonChatEnd.Image");
            buttonChatEnd.Location = new Point(485, 7);
            buttonChatEnd.Name = "buttonChatEnd";
            buttonChatEnd.Size = new Size(41, 28);
            buttonChatEnd.TabIndex = 9;
            buttonChatEnd.UseVisualStyleBackColor = true;
            // 
            // buttonVoiceChat
            // 
            buttonVoiceChat.ForeColor = SystemColors.ControlLight;
            buttonVoiceChat.Image = (Image)resources.GetObject("buttonVoiceChat.Image");
            buttonVoiceChat.Location = new Point(438, 6);
            buttonVoiceChat.Name = "buttonVoiceChat";
            buttonVoiceChat.Size = new Size(41, 29);
            buttonVoiceChat.TabIndex = 8;
            buttonVoiceChat.UseVisualStyleBackColor = true;
            // 
            // buttonVideoChat
            // 
            buttonVideoChat.ForeColor = SystemColors.ControlLight;
            buttonVideoChat.Image = (Image)resources.GetObject("buttonVideoChat.Image");
            buttonVideoChat.Location = new Point(391, 6);
            buttonVideoChat.Name = "buttonVideoChat";
            buttonVideoChat.Size = new Size(41, 29);
            buttonVideoChat.TabIndex = 7;
            buttonVideoChat.UseVisualStyleBackColor = true;
            // 
            // labelUserNameCenter
            // 
            labelUserNameCenter.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserNameCenter.Location = new Point(56, 6);
            labelUserNameCenter.Name = "labelUserNameCenter";
            labelUserNameCenter.Size = new Size(105, 29);
            labelUserNameCenter.TabIndex = 6;
            labelUserNameCenter.Text = "User name";
            labelUserNameCenter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxAvatarCenter
            // 
            pictureBoxAvatarCenter.Location = new Point(16, 6);
            pictureBoxAvatarCenter.Name = "pictureBoxAvatarCenter";
            pictureBoxAvatarCenter.Size = new Size(34, 29);
            pictureBoxAvatarCenter.TabIndex = 5;
            pictureBoxAvatarCenter.TabStop = false;
            // 
            // panel
            // 
            panel.BackColor = Color.Gray;
            panel.Controls.Add(labelUserNameRight);
            panel.Controls.Add(pictureBoxAvatarRight);
            panel.Controls.Add(buttonAlert);
            panel.Controls.Add(buttonNewChat);
            panel.Controls.Add(labelChatTitle);
            panel.Location = new Point(252, 12);
            panel.Name = "panel";
            panel.Size = new Size(855, 48);
            panel.TabIndex = 2;
            // 
            // labelUserNameRight
            // 
            labelUserNameRight.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserNameRight.Location = new Point(757, 9);
            labelUserNameRight.Name = "labelUserNameRight";
            labelUserNameRight.Size = new Size(105, 29);
            labelUserNameRight.TabIndex = 4;
            labelUserNameRight.Text = "User name";
            labelUserNameRight.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxAvatarRight
            // 
            pictureBoxAvatarRight.Location = new Point(717, 9);
            pictureBoxAvatarRight.Name = "pictureBoxAvatarRight";
            pictureBoxAvatarRight.Size = new Size(34, 29);
            pictureBoxAvatarRight.TabIndex = 3;
            pictureBoxAvatarRight.TabStop = false;
            // 
            // buttonAlert
            // 
            buttonAlert.ForeColor = SystemColors.ControlLight;
            buttonAlert.Image = (Image)resources.GetObject("buttonAlert.Image");
            buttonAlert.Location = new Point(670, 9);
            buttonAlert.Name = "buttonAlert";
            buttonAlert.Size = new Size(41, 29);
            buttonAlert.TabIndex = 2;
            buttonAlert.UseVisualStyleBackColor = true;
            buttonAlert.Click += buttonAlert_Click;
            // 
            // buttonNewChat
            // 
            buttonNewChat.BackColor = Color.FromArgb(224, 224, 224);
            buttonNewChat.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNewChat.ForeColor = SystemColors.ActiveCaptionText;
            buttonNewChat.Location = new Point(560, 9);
            buttonNewChat.Name = "buttonNewChat";
            buttonNewChat.Size = new Size(104, 29);
            buttonNewChat.TabIndex = 1;
            buttonNewChat.Text = "+ New Chat";
            buttonNewChat.UseVisualStyleBackColor = false;
            // 
            // labelChatTitle
            // 
            labelChatTitle.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelChatTitle.Location = new Point(0, 0);
            labelChatTitle.Name = "labelChatTitle";
            labelChatTitle.Size = new Size(113, 48);
            labelChatTitle.TabIndex = 0;
            labelChatTitle.Text = "Chat";
            labelChatTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listBoxMessages
            // 
            listBoxMessages.BackColor = Color.Gray;
            listBoxMessages.FormattingEnabled = true;
            listBoxMessages.ItemHeight = 20;
            listBoxMessages.Location = new Point(16, 55);
            listBoxMessages.Name = "listBoxMessages";
            listBoxMessages.Size = new Size(509, 424);
            listBoxMessages.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1119, 632);
            Controls.Add(panel);
            Controls.Add(groupBoxChat);
            Controls.Add(groupBoxMenu);
            Controls.Add(groupBoxInbox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Primary.ResumeLayout(false);
            groupBoxInbox.ResumeLayout(false);
            groupBoxMenu.ResumeLayout(false);
            groupBoxMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatarLeft).EndInit();
            groupBoxChat.ResumeLayout(false);
            groupBoxChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatarCenter).EndInit();
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatarRight).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Primary;
        private GroupBox groupBoxInbox;
        private GroupBox groupBoxMenu;
        private GroupBox groupBoxChat;
        private Panel panel;
        private Label labelChatTitle;
        private Button buttonNewChat;
        private Button buttonAlert;
        private Label labelUserNameRight;
        private PictureBox pictureBoxAvatarRight;
        private Label labelInbox;
        private Button buttonChatEnd;
        private Button buttonVoiceChat;
        private Button buttonVideoChat;
        private Label labelUserNameCenter;
        private PictureBox pictureBoxAvatarCenter;
        private Label labelSetting;
        private Label labelPrivacy;
        private Label labelContact;
        private Label labelColls;
        private Label labelChat;
        private Label labelExsplore;
        private Button buttonContact;
        private Button buttonPrivacy;
        private Button buttonSetting;
        private Button buttonColls;
        private Button buttonChat;
        private Button buttonExplore;
        private Label labelUserUameLeft;
        private PictureBox pictureBoxAvatarLeft;
        private TabPage tabPagePrimary;
        private TabPage tabPageGroups;
        private TabPage tabPageArchive;
        private Label labelLogOut;
        private Button buttonLogOut;
        private Button buttonSend;
        private Button buttonSendVoice;
        private Button buttonSendImage;
        private TextBox textBoxMessage;
        private ListBox listBoxMessages;
    }
}
