namespace NO_NET_CHAT_SYSTEM___FINAL
{
    partial class frm_chatwindow
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
            this.components = new System.ComponentModel.Container();
            this.txt_sendmessage = new System.Windows.Forms.TextBox();
            this.btn_sendmessage = new System.Windows.Forms.Button();
            this.btn_voicecall = new System.Windows.Forms.Button();
            this.btn_videocall = new System.Windows.Forms.Button();
            this.btn_sendattachment = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_server = new System.Windows.Forms.Label();
            this.lbl_client = new System.Windows.Forms.Label();
            this.txt_serverip = new System.Windows.Forms.TextBox();
            this.txt_clientip = new System.Windows.Forms.TextBox();
            this.lbl_serverport = new System.Windows.Forms.Label();
            this.lbl_clientport = new System.Windows.Forms.Label();
            this.txt_serverport = new System.Windows.Forms.TextBox();
            this.txt_clientport = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.txt_chatdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbl_send_messageTableAdapter1 = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_DatasetTableAdapters.tbl_send_messageTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifySecurityQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetUserPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbl_video_callTableAdapter1 = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_DatasetTableAdapters.tbl_video_callTableAdapter();
            this.tbl_voice_callTableAdapter1 = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_DatasetTableAdapters.tbl_voice_callTableAdapter();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txt_receivemessage = new System.Windows.Forms.TextBox();
            this.tbl_send_attachmentTableAdapter1 = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_DatasetTableAdapters.tbl_send_attachmentTableAdapter();
            this.btn_savechat = new System.Windows.Forms.Button();
            this.lbl_department = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_sendmessage
            // 
            this.txt_sendmessage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sendmessage.Location = new System.Drawing.Point(75, 426);
            this.txt_sendmessage.Multiline = true;
            this.txt_sendmessage.Name = "txt_sendmessage";
            this.txt_sendmessage.Size = new System.Drawing.Size(503, 123);
            this.txt_sendmessage.TabIndex = 0;
            // 
            // btn_sendmessage
            // 
            this.btn_sendmessage.BackColor = System.Drawing.Color.White;
            this.btn_sendmessage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendmessage.ForeColor = System.Drawing.Color.Green;
            this.btn_sendmessage.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.imgonline_com_ua_resize_A4iomOV8rn;
            this.btn_sendmessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sendmessage.Location = new System.Drawing.Point(600, 426);
            this.btn_sendmessage.Name = "btn_sendmessage";
            this.btn_sendmessage.Size = new System.Drawing.Size(160, 123);
            this.btn_sendmessage.TabIndex = 1;
            this.btn_sendmessage.Text = "        Send Message";
            this.btn_sendmessage.UseVisualStyleBackColor = false;
            this.btn_sendmessage.Click += new System.EventHandler(this.btn_sendmessage_Click);
            // 
            // btn_voicecall
            // 
            this.btn_voicecall.BackColor = System.Drawing.Color.White;
            this.btn_voicecall.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voicecall.ForeColor = System.Drawing.Color.Olive;
            this.btn_voicecall.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.download__1_;
            this.btn_voicecall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_voicecall.Location = new System.Drawing.Point(14, 382);
            this.btn_voicecall.Name = "btn_voicecall";
            this.btn_voicecall.Size = new System.Drawing.Size(160, 38);
            this.btn_voicecall.TabIndex = 2;
            this.btn_voicecall.Text = "     Voice Call";
            this.btn_voicecall.UseVisualStyleBackColor = false;
            this.btn_voicecall.Click += new System.EventHandler(this.btn_voicecall_Click);
            // 
            // btn_videocall
            // 
            this.btn_videocall.BackColor = System.Drawing.Color.White;
            this.btn_videocall.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_videocall.ForeColor = System.Drawing.Color.Olive;
            this.btn_videocall.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.download;
            this.btn_videocall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_videocall.Location = new System.Drawing.Point(180, 382);
            this.btn_videocall.Name = "btn_videocall";
            this.btn_videocall.Size = new System.Drawing.Size(160, 38);
            this.btn_videocall.TabIndex = 3;
            this.btn_videocall.Text = "      Video Call";
            this.btn_videocall.UseVisualStyleBackColor = false;
            this.btn_videocall.Click += new System.EventHandler(this.btn_videocall_Click);
            // 
            // btn_sendattachment
            // 
            this.btn_sendattachment.BackColor = System.Drawing.Color.White;
            this.btn_sendattachment.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendattachment.ForeColor = System.Drawing.Color.Olive;
            this.btn_sendattachment.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.download__2_;
            this.btn_sendattachment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sendattachment.Location = new System.Drawing.Point(346, 382);
            this.btn_sendattachment.Name = "btn_sendattachment";
            this.btn_sendattachment.Size = new System.Drawing.Size(160, 38);
            this.btn_sendattachment.TabIndex = 4;
            this.btn_sendattachment.Text = "     Attachment";
            this.btn_sendattachment.UseVisualStyleBackColor = false;
            this.btn_sendattachment.Click += new System.EventHandler(this.btn_sendattachment_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(34, 472);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(0, 13);
            this.lbl_username.TabIndex = 5;
            this.lbl_username.Visible = false;
            // 
            // lbl_server
            // 
            this.lbl_server.AutoSize = true;
            this.lbl_server.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_server.Location = new System.Drawing.Point(12, 42);
            this.lbl_server.Name = "lbl_server";
            this.lbl_server.Size = new System.Drawing.Size(95, 14);
            this.lbl_server.TabIndex = 6;
            this.lbl_server.Text = "Server IP Address";
            this.lbl_server.Visible = false;
            // 
            // lbl_client
            // 
            this.lbl_client.AutoSize = true;
            this.lbl_client.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_client.Location = new System.Drawing.Point(12, 93);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(88, 14);
            this.lbl_client.TabIndex = 6;
            this.lbl_client.Text = "Client IP Address";
            this.lbl_client.Visible = false;
            // 
            // txt_serverip
            // 
            this.txt_serverip.Enabled = false;
            this.txt_serverip.Location = new System.Drawing.Point(115, 39);
            this.txt_serverip.Name = "txt_serverip";
            this.txt_serverip.Size = new System.Drawing.Size(260, 20);
            this.txt_serverip.TabIndex = 7;
            this.txt_serverip.Visible = false;
            // 
            // txt_clientip
            // 
            this.txt_clientip.Enabled = false;
            this.txt_clientip.Location = new System.Drawing.Point(115, 93);
            this.txt_clientip.Name = "txt_clientip";
            this.txt_clientip.Size = new System.Drawing.Size(260, 20);
            this.txt_clientip.TabIndex = 7;
            this.txt_clientip.Visible = false;
            // 
            // lbl_serverport
            // 
            this.lbl_serverport.AutoSize = true;
            this.lbl_serverport.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_serverport.Location = new System.Drawing.Point(392, 42);
            this.lbl_serverport.Name = "lbl_serverport";
            this.lbl_serverport.Size = new System.Drawing.Size(62, 14);
            this.lbl_serverport.TabIndex = 8;
            this.lbl_serverport.Text = "Server Port";
            this.lbl_serverport.Visible = false;
            // 
            // lbl_clientport
            // 
            this.lbl_clientport.AutoSize = true;
            this.lbl_clientport.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientport.Location = new System.Drawing.Point(392, 96);
            this.lbl_clientport.Name = "lbl_clientport";
            this.lbl_clientport.Size = new System.Drawing.Size(55, 14);
            this.lbl_clientport.TabIndex = 8;
            this.lbl_clientport.Text = "Client Port";
            this.lbl_clientport.Visible = false;
            // 
            // txt_serverport
            // 
            this.txt_serverport.Enabled = false;
            this.txt_serverport.Location = new System.Drawing.Point(477, 39);
            this.txt_serverport.Name = "txt_serverport";
            this.txt_serverport.Size = new System.Drawing.Size(101, 20);
            this.txt_serverport.TabIndex = 9;
            this.txt_serverport.Text = "1000";
            this.txt_serverport.Visible = false;
            // 
            // txt_clientport
            // 
            this.txt_clientport.Enabled = false;
            this.txt_clientport.Location = new System.Drawing.Point(477, 93);
            this.txt_clientport.Name = "txt_clientport";
            this.txt_clientport.Size = new System.Drawing.Size(101, 20);
            this.txt_clientport.TabIndex = 9;
            this.txt_clientport.Text = "1000";
            this.txt_clientport.Visible = false;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.White;
            this.btn_start.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.Green;
            this.btn_start.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.start_icon;
            this.btn_start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_start.Location = new System.Drawing.Point(285, 65);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(162, 42);
            this.btn_start.TabIndex = 10;
            this.btn_start.Text = "     Start Chat";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // txt_chatdate
            // 
            this.txt_chatdate.Location = new System.Drawing.Point(115, 129);
            this.txt_chatdate.Name = "txt_chatdate";
            this.txt_chatdate.Size = new System.Drawing.Size(200, 20);
            this.txt_chatdate.TabIndex = 11;
            this.txt_chatdate.Visible = false;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.White;
            this.lbl_time.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(565, 105);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(67, 27);
            this.lbl_time.TabIndex = 12;
            this.lbl_time.Text = "TIME";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbl_send_messageTableAdapter1
            // 
            this.tbl_send_messageTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 26);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.modifySecurityQuestionsToolStripMenuItem,
            this.resetUserPasswordToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordToolStripMenuItem.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.resetpassword_icon;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // modifySecurityQuestionsToolStripMenuItem
            // 
            this.modifySecurityQuestionsToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifySecurityQuestionsToolStripMenuItem.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.modify_icon;
            this.modifySecurityQuestionsToolStripMenuItem.Name = "modifySecurityQuestionsToolStripMenuItem";
            this.modifySecurityQuestionsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.modifySecurityQuestionsToolStripMenuItem.Text = "Modify Security Questions";
            this.modifySecurityQuestionsToolStripMenuItem.Click += new System.EventHandler(this.modifySecurityQuestionsToolStripMenuItem_Click);
            // 
            // resetUserPasswordToolStripMenuItem
            // 
            this.resetUserPasswordToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetUserPasswordToolStripMenuItem.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.modifyuser_icon;
            this.resetUserPasswordToolStripMenuItem.Name = "resetUserPasswordToolStripMenuItem";
            this.resetUserPasswordToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.resetUserPasswordToolStripMenuItem.Text = "Modify User Details";
            this.resetUserPasswordToolStripMenuItem.Visible = false;
            this.resetUserPasswordToolStripMenuItem.Click += new System.EventHandler(this.resetUserPasswordToolStripMenuItem_Click);
            // 
            // tbl_video_callTableAdapter1
            // 
            this.tbl_video_callTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_voice_callTableAdapter1
            // 
            this.tbl_voice_callTableAdapter1.ClearBeforeFill = true;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.White;
            this.lbl_date.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(538, 62);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(72, 27);
            this.lbl_date.TabIndex = 14;
            this.lbl_date.Text = "DATE";
            // 
            // txt_receivemessage
            // 
            this.txt_receivemessage.BackColor = System.Drawing.Color.White;
            this.txt_receivemessage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_receivemessage.Location = new System.Drawing.Point(12, 167);
            this.txt_receivemessage.Multiline = true;
            this.txt_receivemessage.Name = "txt_receivemessage";
            this.txt_receivemessage.ReadOnly = true;
            this.txt_receivemessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_receivemessage.Size = new System.Drawing.Size(760, 209);
            this.txt_receivemessage.TabIndex = 16;
            // 
            // tbl_send_attachmentTableAdapter1
            // 
            this.tbl_send_attachmentTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_savechat
            // 
            this.btn_savechat.BackColor = System.Drawing.Color.White;
            this.btn_savechat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savechat.ForeColor = System.Drawing.Color.Teal;
            this.btn_savechat.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.save_icon;
            this.btn_savechat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_savechat.Location = new System.Drawing.Point(12, 121);
            this.btn_savechat.Name = "btn_savechat";
            this.btn_savechat.Size = new System.Drawing.Size(144, 41);
            this.btn_savechat.TabIndex = 19;
            this.btn_savechat.Text = "     Save Chat";
            this.btn_savechat.UseVisualStyleBackColor = false;
            this.btn_savechat.Click += new System.EventHandler(this.btn_savechat_Click);
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Location = new System.Drawing.Point(395, 392);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(0, 13);
            this.lbl_department.TabIndex = 20;
            this.lbl_department.Visible = false;
            // 
            // frm_chatwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.White_Wallpaper_HD_Background_Free;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.btn_savechat);
            this.Controls.Add(this.txt_receivemessage);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.txt_chatdate);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_clientport);
            this.Controls.Add(this.txt_serverport);
            this.Controls.Add(this.lbl_clientport);
            this.Controls.Add(this.lbl_serverport);
            this.Controls.Add(this.txt_clientip);
            this.Controls.Add(this.txt_serverip);
            this.Controls.Add(this.lbl_client);
            this.Controls.Add(this.lbl_server);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_sendattachment);
            this.Controls.Add(this.btn_videocall);
            this.Controls.Add(this.btn_voicecall);
            this.Controls.Add(this.btn_sendmessage);
            this.Controls.Add(this.txt_sendmessage);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_chatwindow";
            this.Text = "Chat Window";
            this.Load += new System.EventHandler(this.frm_chatwindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_sendmessage;
        private System.Windows.Forms.Button btn_sendmessage;
        private System.Windows.Forms.Button btn_voicecall;
        private System.Windows.Forms.Button btn_videocall;
        private System.Windows.Forms.Button btn_sendattachment;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_server;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.TextBox txt_serverip;
        private System.Windows.Forms.TextBox txt_clientip;
        private System.Windows.Forms.Label lbl_serverport;
        private System.Windows.Forms.Label lbl_clientport;
        private System.Windows.Forms.TextBox txt_serverport;
        private System.Windows.Forms.TextBox txt_clientport;
        private System.Windows.Forms.Button btn_start;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DateTimePicker txt_chatdate;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
        private No_Net_Chat_System_DatasetTableAdapters.tbl_send_messageTableAdapter tbl_send_messageTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private No_Net_Chat_System_DatasetTableAdapters.tbl_video_callTableAdapter tbl_video_callTableAdapter1;
        private No_Net_Chat_System_DatasetTableAdapters.tbl_voice_callTableAdapter tbl_voice_callTableAdapter1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox txt_receivemessage;
        private No_Net_Chat_System_DatasetTableAdapters.tbl_send_attachmentTableAdapter tbl_send_attachmentTableAdapter1;
        private System.Windows.Forms.Button btn_savechat;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifySecurityQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetUserPasswordToolStripMenuItem;
        private System.Windows.Forms.Label lbl_department;
    }
}