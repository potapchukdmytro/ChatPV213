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
            listBoxGroups = new ListBox();
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
            listBoxMessages = new ListBox();
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
            Primary = new TabControl();
            Primary.SuspendLayout();
            tabPagePrimary.SuspendLayout();
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
            Primary.Location = new Point(28, 60);
            Primary.Margin = new Padding(6, 4, 6, 4);
            Primary.Name = "Primary";
            Primary.SelectedIndex = 0;
            Primary.Size = new Size(435, 770);
            Primary.TabIndex = 1;
            // 
            // tabPagePrimary
            // 
            tabPagePrimary.BackColor = Color.Gray;
            tabPagePrimary.Controls.Add(listBoxGroups);
            tabPagePrimary.Location = new Point(8, 40);
            tabPagePrimary.Margin = new Padding(6, 4, 6, 4);
            tabPagePrimary.Name = "tabPagePrimary";
            tabPagePrimary.Padding = new Padding(6, 4, 6, 4);
            tabPagePrimary.Size = new Size(419, 722);
            tabPagePrimary.TabIndex = 0;
            tabPagePrimary.Text = "Primary";
            // 
            // listBoxGroups
            // 
            listBoxGroups.FormattingEnabled = true;
            listBoxGroups.ItemHeight = 26;
            listBoxGroups.Location = new Point(11, 11);
            listBoxGroups.Margin = new Padding(6, 6, 6, 6);
            listBoxGroups.Name = "listBoxGroups";
            listBoxGroups.Size = new Size(394, 680);
            listBoxGroups.TabIndex = 0;
            // 
            // tabPageGroups
            // 
            tabPageGroups.BackColor = Color.Gray;
            tabPageGroups.Location = new Point(8, 40);
            tabPageGroups.Margin = new Padding(6, 4, 6, 4);
            tabPageGroups.Name = "tabPageGroups";
            tabPageGroups.Padding = new Padding(6, 4, 6, 4);
            tabPageGroups.Size = new Size(419, 722);
            tabPageGroups.TabIndex = 1;
            tabPageGroups.Text = "Groups";
            // 
            // tabPageArchive
            // 
            tabPageArchive.BackColor = Color.Gray;
            tabPageArchive.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageArchive.Location = new Point(8, 40);
            tabPageArchive.Margin = new Padding(6, 4, 6, 4);
            tabPageArchive.Name = "tabPageArchive";
            tabPageArchive.Padding = new Padding(6, 4, 6, 4);
            tabPageArchive.RightToLeft = RightToLeft.No;
            tabPageArchive.Size = new Size(419, 722);
            tabPageArchive.TabIndex = 2;
            tabPageArchive.Text = "Archive";
            // 
            // groupBoxInbox
            // 
            groupBoxInbox.BackColor = Color.Gray;
            groupBoxInbox.Controls.Add(Primary);
            groupBoxInbox.Controls.Add(labelInbox);
            groupBoxInbox.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxInbox.Location = new Point(409, 137);
            groupBoxInbox.Margin = new Padding(6, 4, 6, 4);
            groupBoxInbox.Name = "groupBoxInbox";
            groupBoxInbox.Padding = new Padding(6, 4, 6, 4);
            groupBoxInbox.Size = new Size(488, 849);
            groupBoxInbox.TabIndex = 0;
            groupBoxInbox.TabStop = false;
            // 
            // labelInbox
            // 
            labelInbox.Location = new Point(9, 0);
            labelInbox.Margin = new Padding(6, 0, 6, 0);
            labelInbox.Name = "labelInbox";
            labelInbox.Size = new Size(130, 55);
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
            groupBoxMenu.Location = new Point(19, 19);
            groupBoxMenu.Margin = new Padding(6, 4, 6, 4);
            groupBoxMenu.Name = "groupBoxMenu";
            groupBoxMenu.Padding = new Padding(6, 4, 6, 4);
            groupBoxMenu.Size = new Size(362, 966);
            groupBoxMenu.TabIndex = 1;
            groupBoxMenu.TabStop = false;
            // 
            // labelLogOut
            // 
            labelLogOut.AutoSize = true;
            labelLogOut.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogOut.Location = new Point(85, 898);
            labelLogOut.Margin = new Padding(6, 0, 6, 0);
            labelLogOut.Name = "labelLogOut";
            labelLogOut.Size = new Size(82, 29);
            labelLogOut.TabIndex = 23;
            labelLogOut.Text = "Log out";
            // 
            // buttonLogOut
            // 
            buttonLogOut.ForeColor = SystemColors.ControlLight;
            buttonLogOut.Image = (Image)resources.GetObject("buttonLogOut.Image");
            buttonLogOut.Location = new Point(9, 885);
            buttonLogOut.Margin = new Padding(6, 4, 6, 4);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(65, 60);
            buttonLogOut.TabIndex = 22;
            buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // labelUserUameLeft
            // 
            labelUserUameLeft.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserUameLeft.Location = new Point(85, 13);
            labelUserUameLeft.Margin = new Padding(6, 0, 6, 0);
            labelUserUameLeft.Name = "labelUserUameLeft";
            labelUserUameLeft.Size = new Size(171, 47);
            labelUserUameLeft.TabIndex = 11;
            labelUserUameLeft.Text = "User name";
            labelUserUameLeft.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxAvatarLeft
            // 
            pictureBoxAvatarLeft.Location = new Point(9, 13);
            pictureBoxAvatarLeft.Margin = new Padding(6, 4, 6, 4);
            pictureBoxAvatarLeft.Name = "pictureBoxAvatarLeft";
            pictureBoxAvatarLeft.Size = new Size(56, 47);
            pictureBoxAvatarLeft.TabIndex = 10;
            pictureBoxAvatarLeft.TabStop = false;
            // 
            // labelSetting
            // 
            labelSetting.AutoSize = true;
            labelSetting.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSetting.Location = new Point(85, 427);
            labelSetting.Margin = new Padding(6, 0, 6, 0);
            labelSetting.Name = "labelSetting";
            labelSetting.Size = new Size(82, 29);
            labelSetting.TabIndex = 21;
            labelSetting.Text = "Setting";
            // 
            // labelPrivacy
            // 
            labelPrivacy.AutoSize = true;
            labelPrivacy.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrivacy.Location = new Point(85, 356);
            labelPrivacy.Margin = new Padding(6, 0, 6, 0);
            labelPrivacy.Name = "labelPrivacy";
            labelPrivacy.Size = new Size(86, 29);
            labelPrivacy.TabIndex = 20;
            labelPrivacy.Text = "Privacy";
            // 
            // labelContact
            // 
            labelContact.AutoSize = true;
            labelContact.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelContact.Location = new Point(85, 288);
            labelContact.Margin = new Padding(6, 0, 6, 0);
            labelContact.Name = "labelContact";
            labelContact.Size = new Size(89, 29);
            labelContact.TabIndex = 19;
            labelContact.Text = "Contact";
            // 
            // labelColls
            // 
            labelColls.AutoSize = true;
            labelColls.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelColls.Location = new Point(85, 220);
            labelColls.Margin = new Padding(6, 0, 6, 0);
            labelColls.Name = "labelColls";
            labelColls.Size = new Size(61, 29);
            labelColls.TabIndex = 18;
            labelColls.Text = "Colls";
            // 
            // labelChat
            // 
            labelChat.AutoSize = true;
            labelChat.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelChat.Location = new Point(85, 149);
            labelChat.Margin = new Padding(6, 0, 6, 0);
            labelChat.Name = "labelChat";
            labelChat.Size = new Size(58, 29);
            labelChat.TabIndex = 17;
            labelChat.Text = "Chat";
            // 
            // labelExsplore
            // 
            labelExsplore.AutoSize = true;
            labelExsplore.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelExsplore.Location = new Point(85, 81);
            labelExsplore.Margin = new Padding(6, 0, 6, 0);
            labelExsplore.Name = "labelExsplore";
            labelExsplore.Size = new Size(94, 29);
            labelExsplore.TabIndex = 16;
            labelExsplore.Text = "Exsplore";
            // 
            // buttonContact
            // 
            buttonContact.ForeColor = SystemColors.ControlLight;
            buttonContact.Image = (Image)resources.GetObject("buttonContact.Image");
            buttonContact.Location = new Point(9, 275);
            buttonContact.Margin = new Padding(6, 4, 6, 4);
            buttonContact.Name = "buttonContact";
            buttonContact.Size = new Size(65, 60);
            buttonContact.TabIndex = 15;
            buttonContact.UseVisualStyleBackColor = true;
            // 
            // buttonPrivacy
            // 
            buttonPrivacy.ForeColor = SystemColors.ControlLight;
            buttonPrivacy.Image = (Image)resources.GetObject("buttonPrivacy.Image");
            buttonPrivacy.Location = new Point(9, 343);
            buttonPrivacy.Margin = new Padding(6, 4, 6, 4);
            buttonPrivacy.Name = "buttonPrivacy";
            buttonPrivacy.Size = new Size(65, 60);
            buttonPrivacy.TabIndex = 14;
            buttonPrivacy.UseVisualStyleBackColor = true;
            // 
            // buttonSetting
            // 
            buttonSetting.ForeColor = SystemColors.ControlLight;
            buttonSetting.Image = (Image)resources.GetObject("buttonSetting.Image");
            buttonSetting.Location = new Point(9, 414);
            buttonSetting.Margin = new Padding(6, 4, 6, 4);
            buttonSetting.Name = "buttonSetting";
            buttonSetting.Size = new Size(65, 60);
            buttonSetting.TabIndex = 13;
            buttonSetting.UseVisualStyleBackColor = true;
            // 
            // buttonColls
            // 
            buttonColls.ForeColor = SystemColors.ControlLight;
            buttonColls.Image = (Image)resources.GetObject("buttonColls.Image");
            buttonColls.Location = new Point(9, 207);
            buttonColls.Margin = new Padding(6, 4, 6, 4);
            buttonColls.Name = "buttonColls";
            buttonColls.Size = new Size(65, 60);
            buttonColls.TabIndex = 12;
            buttonColls.UseVisualStyleBackColor = true;
            // 
            // buttonChat
            // 
            buttonChat.BackColor = Color.Gray;
            buttonChat.ForeColor = SystemColors.ControlLightLight;
            buttonChat.Image = (Image)resources.GetObject("buttonChat.Image");
            buttonChat.Location = new Point(9, 137);
            buttonChat.Margin = new Padding(6, 4, 6, 4);
            buttonChat.Name = "buttonChat";
            buttonChat.Size = new Size(65, 60);
            buttonChat.TabIndex = 11;
            buttonChat.UseVisualStyleBackColor = false;
            // 
            // buttonExplore
            // 
            buttonExplore.ForeColor = SystemColors.ControlLight;
            buttonExplore.Image = (Image)resources.GetObject("buttonExplore.Image");
            buttonExplore.Location = new Point(9, 68);
            buttonExplore.Margin = new Padding(6, 4, 6, 4);
            buttonExplore.Name = "buttonExplore";
            buttonExplore.Size = new Size(65, 60);
            buttonExplore.TabIndex = 10;
            buttonExplore.UseVisualStyleBackColor = true;
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
            groupBoxChat.Location = new Point(929, 137);
            groupBoxChat.Margin = new Padding(6, 4, 6, 4);
            groupBoxChat.Name = "groupBoxChat";
            groupBoxChat.Padding = new Padding(6, 4, 6, 4);
            groupBoxChat.Size = new Size(871, 849);
            groupBoxChat.TabIndex = 0;
            groupBoxChat.TabStop = false;
            groupBoxChat.Text = "x";
            // 
            // listBoxMessages
            // 
            listBoxMessages.BackColor = Color.Gray;
            listBoxMessages.FormattingEnabled = true;
            listBoxMessages.ItemHeight = 32;
            listBoxMessages.Location = new Point(26, 87);
            listBoxMessages.Margin = new Padding(6, 4, 6, 4);
            listBoxMessages.Name = "listBoxMessages";
            listBoxMessages.Size = new Size(825, 676);
            listBoxMessages.TabIndex = 28;
            // 
            // textBoxMessage
            // 
            textBoxMessage.BackColor = Color.FromArgb(224, 224, 224);
            textBoxMessage.Location = new Point(26, 783);
            textBoxMessage.Margin = new Padding(6, 4, 6, 4);
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(531, 39);
            textBoxMessage.TabIndex = 27;
            // 
            // buttonSend
            // 
            buttonSend.ForeColor = SystemColors.ControlLight;
            buttonSend.Image = (Image)resources.GetObject("buttonSend.Image");
            buttonSend.Location = new Point(787, 781);
            buttonSend.Margin = new Padding(6, 4, 6, 4);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(65, 60);
            buttonSend.TabIndex = 26;
            buttonSend.UseVisualStyleBackColor = true;
            // 
            // buttonSendVoice
            // 
            buttonSendVoice.ForeColor = SystemColors.ControlLight;
            buttonSendVoice.Image = (Image)resources.GetObject("buttonSendVoice.Image");
            buttonSendVoice.Location = new Point(695, 781);
            buttonSendVoice.Margin = new Padding(6, 4, 6, 4);
            buttonSendVoice.Name = "buttonSendVoice";
            buttonSendVoice.Size = new Size(65, 60);
            buttonSendVoice.TabIndex = 25;
            buttonSendVoice.UseVisualStyleBackColor = true;
            // 
            // buttonSendImage
            // 
            buttonSendImage.ForeColor = SystemColors.ControlLight;
            buttonSendImage.Image = (Image)resources.GetObject("buttonSendImage.Image");
            buttonSendImage.Location = new Point(594, 779);
            buttonSendImage.Margin = new Padding(6, 4, 6, 4);
            buttonSendImage.Name = "buttonSendImage";
            buttonSendImage.Size = new Size(65, 60);
            buttonSendImage.TabIndex = 24;
            buttonSendImage.UseVisualStyleBackColor = true;
            // 
            // buttonChatEnd
            // 
            buttonChatEnd.ForeColor = SystemColors.ControlLight;
            buttonChatEnd.Image = (Image)resources.GetObject("buttonChatEnd.Image");
            buttonChatEnd.Location = new Point(787, 11);
            buttonChatEnd.Margin = new Padding(6, 4, 6, 4);
            buttonChatEnd.Name = "buttonChatEnd";
            buttonChatEnd.Size = new Size(67, 45);
            buttonChatEnd.TabIndex = 9;
            buttonChatEnd.UseVisualStyleBackColor = true;
            // 
            // buttonVoiceChat
            // 
            buttonVoiceChat.ForeColor = SystemColors.ControlLight;
            buttonVoiceChat.Image = (Image)resources.GetObject("buttonVoiceChat.Image");
            buttonVoiceChat.Location = new Point(711, 9);
            buttonVoiceChat.Margin = new Padding(6, 4, 6, 4);
            buttonVoiceChat.Name = "buttonVoiceChat";
            buttonVoiceChat.Size = new Size(67, 47);
            buttonVoiceChat.TabIndex = 8;
            buttonVoiceChat.UseVisualStyleBackColor = true;
            // 
            // buttonVideoChat
            // 
            buttonVideoChat.ForeColor = SystemColors.ControlLight;
            buttonVideoChat.Image = (Image)resources.GetObject("buttonVideoChat.Image");
            buttonVideoChat.Location = new Point(635, 9);
            buttonVideoChat.Margin = new Padding(6, 4, 6, 4);
            buttonVideoChat.Name = "buttonVideoChat";
            buttonVideoChat.Size = new Size(67, 47);
            buttonVideoChat.TabIndex = 7;
            buttonVideoChat.UseVisualStyleBackColor = true;
            // 
            // labelUserNameCenter
            // 
            labelUserNameCenter.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserNameCenter.Location = new Point(91, 9);
            labelUserNameCenter.Margin = new Padding(6, 0, 6, 0);
            labelUserNameCenter.Name = "labelUserNameCenter";
            labelUserNameCenter.Size = new Size(171, 47);
            labelUserNameCenter.TabIndex = 6;
            labelUserNameCenter.Text = "User name";
            labelUserNameCenter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxAvatarCenter
            // 
            pictureBoxAvatarCenter.Location = new Point(26, 9);
            pictureBoxAvatarCenter.Margin = new Padding(6, 4, 6, 4);
            pictureBoxAvatarCenter.Name = "pictureBoxAvatarCenter";
            pictureBoxAvatarCenter.Size = new Size(56, 47);
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
            panel.Location = new Point(409, 19);
            panel.Margin = new Padding(6, 4, 6, 4);
            panel.Name = "panel";
            panel.Size = new Size(1389, 77);
            panel.TabIndex = 2;
            // 
            // labelUserNameRight
            // 
            labelUserNameRight.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserNameRight.Location = new Point(1229, 15);
            labelUserNameRight.Margin = new Padding(6, 0, 6, 0);
            labelUserNameRight.Name = "labelUserNameRight";
            labelUserNameRight.Size = new Size(171, 47);
            labelUserNameRight.TabIndex = 4;
            labelUserNameRight.Text = "User name";
            labelUserNameRight.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxAvatarRight
            // 
            pictureBoxAvatarRight.Location = new Point(1164, 15);
            pictureBoxAvatarRight.Margin = new Padding(6, 4, 6, 4);
            pictureBoxAvatarRight.Name = "pictureBoxAvatarRight";
            pictureBoxAvatarRight.Size = new Size(56, 47);
            pictureBoxAvatarRight.TabIndex = 3;
            pictureBoxAvatarRight.TabStop = false;
            // 
            // buttonAlert
            // 
            buttonAlert.ForeColor = SystemColors.ControlLight;
            buttonAlert.Image = (Image)resources.GetObject("buttonAlert.Image");
            buttonAlert.Location = new Point(1088, 15);
            buttonAlert.Margin = new Padding(6, 4, 6, 4);
            buttonAlert.Name = "buttonAlert";
            buttonAlert.Size = new Size(67, 47);
            buttonAlert.TabIndex = 2;
            buttonAlert.UseVisualStyleBackColor = true;
            // 
            // buttonNewChat
            // 
            buttonNewChat.BackColor = Color.FromArgb(224, 224, 224);
            buttonNewChat.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNewChat.ForeColor = SystemColors.ActiveCaptionText;
            buttonNewChat.Location = new Point(910, 15);
            buttonNewChat.Margin = new Padding(6, 4, 6, 4);
            buttonNewChat.Name = "buttonNewChat";
            buttonNewChat.Size = new Size(169, 47);
            buttonNewChat.TabIndex = 1;
            buttonNewChat.Text = "+ New Chat";
            buttonNewChat.UseVisualStyleBackColor = false;
            buttonNewChat.Click += buttonNewChat_Click;
            // 
            // labelChatTitle
            // 
            labelChatTitle.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelChatTitle.Location = new Point(0, 0);
            labelChatTitle.Margin = new Padding(6, 0, 6, 0);
            labelChatTitle.Name = "labelChatTitle";
            labelChatTitle.Size = new Size(184, 77);
            labelChatTitle.TabIndex = 0;
            labelChatTitle.Text = "Chat";
            labelChatTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1818, 1011);
            Controls.Add(panel);
            Controls.Add(groupBoxChat);
            Controls.Add(groupBoxMenu);
            Controls.Add(groupBoxInbox);
            Margin = new Padding(6, 4, 6, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Primary.ResumeLayout(false);
            tabPagePrimary.ResumeLayout(false);
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
        private ListBox listBoxGroups;
    }
}
