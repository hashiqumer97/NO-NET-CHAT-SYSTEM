namespace NO_NET_CHAT_SYSTEM___FINAL
{
    partial class frm_attachment
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
            this.lbl_attachment = new System.Windows.Forms.TextBox();
            this.lbl_receiveattachment = new System.Windows.Forms.TextBox();
            this.btn_openattachment = new System.Windows.Forms.Button();
            this.btn_sendattachment = new System.Windows.Forms.Button();
            this.btn_saveattachment = new System.Windows.Forms.Button();
            this.txt_chatdate = new System.Windows.Forms.DateTimePicker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.txt_serverip = new System.Windows.Forms.TextBox();
            this.txt_serverport = new System.Windows.Forms.TextBox();
            this.txt_clientip = new System.Windows.Forms.TextBox();
            this.txt_clientport = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tbl_send_attachmentTableAdapter1 = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_DatasetTableAdapters.tbl_send_attachmentTableAdapter();
            this.btn_start = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_encryptsend = new System.Windows.Forms.Button();
            this.btn_decryptsend = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_attachment
            // 
            this.lbl_attachment.BackColor = System.Drawing.Color.White;
            this.lbl_attachment.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_attachment.Location = new System.Drawing.Point(12, 49);
            this.lbl_attachment.Multiline = true;
            this.lbl_attachment.Name = "lbl_attachment";
            this.lbl_attachment.ReadOnly = true;
            this.lbl_attachment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lbl_attachment.Size = new System.Drawing.Size(290, 258);
            this.lbl_attachment.TabIndex = 0;
            // 
            // lbl_receiveattachment
            // 
            this.lbl_receiveattachment.BackColor = System.Drawing.Color.White;
            this.lbl_receiveattachment.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receiveattachment.Location = new System.Drawing.Point(322, 49);
            this.lbl_receiveattachment.Multiline = true;
            this.lbl_receiveattachment.Name = "lbl_receiveattachment";
            this.lbl_receiveattachment.ReadOnly = true;
            this.lbl_receiveattachment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lbl_receiveattachment.Size = new System.Drawing.Size(290, 258);
            this.lbl_receiveattachment.TabIndex = 0;
            // 
            // btn_openattachment
            // 
            this.btn_openattachment.BackColor = System.Drawing.Color.White;
            this.btn_openattachment.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openattachment.ForeColor = System.Drawing.Color.Olive;
            this.btn_openattachment.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.open_icon;
            this.btn_openattachment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_openattachment.Location = new System.Drawing.Point(12, 313);
            this.btn_openattachment.Name = "btn_openattachment";
            this.btn_openattachment.Size = new System.Drawing.Size(130, 55);
            this.btn_openattachment.TabIndex = 1;
            this.btn_openattachment.Text = "        Open \r\n        Attachment";
            this.btn_openattachment.UseVisualStyleBackColor = false;
            this.btn_openattachment.Click += new System.EventHandler(this.btn_oppenattachment_Click);
            // 
            // btn_sendattachment
            // 
            this.btn_sendattachment.BackColor = System.Drawing.Color.White;
            this.btn_sendattachment.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendattachment.ForeColor = System.Drawing.Color.Green;
            this.btn_sendattachment.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.send_icon1;
            this.btn_sendattachment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sendattachment.Location = new System.Drawing.Point(159, 313);
            this.btn_sendattachment.Name = "btn_sendattachment";
            this.btn_sendattachment.Size = new System.Drawing.Size(139, 55);
            this.btn_sendattachment.TabIndex = 1;
            this.btn_sendattachment.Text = "           Send \r\n           Attachment ";
            this.btn_sendattachment.UseVisualStyleBackColor = false;
            this.btn_sendattachment.Click += new System.EventHandler(this.btn_sendattachment_Click);
            // 
            // btn_saveattachment
            // 
            this.btn_saveattachment.BackColor = System.Drawing.Color.White;
            this.btn_saveattachment.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveattachment.ForeColor = System.Drawing.Color.Teal;
            this.btn_saveattachment.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.save_icon;
            this.btn_saveattachment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saveattachment.Location = new System.Drawing.Point(486, 313);
            this.btn_saveattachment.Name = "btn_saveattachment";
            this.btn_saveattachment.Size = new System.Drawing.Size(126, 55);
            this.btn_saveattachment.TabIndex = 1;
            this.btn_saveattachment.Text = "        Save \r\n        Attachment";
            this.btn_saveattachment.UseVisualStyleBackColor = false;
            this.btn_saveattachment.Click += new System.EventHandler(this.btn_saveattachment_Click);
            // 
            // txt_chatdate
            // 
            this.txt_chatdate.Location = new System.Drawing.Point(50, 313);
            this.txt_chatdate.Name = "txt_chatdate";
            this.txt_chatdate.Size = new System.Drawing.Size(200, 20);
            this.txt_chatdate.TabIndex = 2;
            this.txt_chatdate.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(43, 415);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(35, 13);
            this.lbl_username.TabIndex = 14;
            this.lbl_username.Text = "label1";
            this.lbl_username.Visible = false;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.White;
            this.lbl_time.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(260, 405);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(67, 27);
            this.lbl_time.TabIndex = 15;
            this.lbl_time.Text = "TIME";
            // 
            // txt_serverip
            // 
            this.txt_serverip.Location = new System.Drawing.Point(70, 12);
            this.txt_serverip.Name = "txt_serverip";
            this.txt_serverip.Size = new System.Drawing.Size(180, 20);
            this.txt_serverip.TabIndex = 16;
            this.txt_serverip.Visible = false;
            // 
            // txt_serverport
            // 
            this.txt_serverport.Location = new System.Drawing.Point(312, 12);
            this.txt_serverport.Name = "txt_serverport";
            this.txt_serverport.Size = new System.Drawing.Size(100, 20);
            this.txt_serverport.TabIndex = 17;
            this.txt_serverport.Visible = false;
            // 
            // txt_clientip
            // 
            this.txt_clientip.Location = new System.Drawing.Point(70, 40);
            this.txt_clientip.Name = "txt_clientip";
            this.txt_clientip.Size = new System.Drawing.Size(180, 20);
            this.txt_clientip.TabIndex = 16;
            this.txt_clientip.Visible = false;
            // 
            // txt_clientport
            // 
            this.txt_clientport.Location = new System.Drawing.Point(312, 40);
            this.txt_clientport.Name = "txt_clientport";
            this.txt_clientport.Size = new System.Drawing.Size(100, 20);
            this.txt_clientport.TabIndex = 17;
            this.txt_clientport.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // tbl_send_attachmentTableAdapter1
            // 
            this.tbl_send_attachmentTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.White;
            this.btn_start.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.Green;
            this.btn_start.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.start_icon;
            this.btn_start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_start.Location = new System.Drawing.Point(446, 0);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(166, 43);
            this.btn_start.TabIndex = 18;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 26);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.BackColor = System.Drawing.Color.White;
            this.btn_decrypt.Enabled = false;
            this.btn_decrypt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decrypt.ForeColor = System.Drawing.Color.Green;
            this.btn_decrypt.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.decrypt_icon;
            this.btn_decrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_decrypt.Location = new System.Drawing.Point(322, 313);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(148, 55);
            this.btn_decrypt.TabIndex = 1;
            this.btn_decrypt.Text = "       Decrypt \r\n       Received Text";
            this.btn_decrypt.UseVisualStyleBackColor = false;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.BackColor = System.Drawing.Color.White;
            this.btn_encrypt.Enabled = false;
            this.btn_encrypt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encrypt.ForeColor = System.Drawing.Color.Red;
            this.btn_encrypt.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.encrypt_icon;
            this.btn_encrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_encrypt.Location = new System.Drawing.Point(322, 313);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(148, 55);
            this.btn_encrypt.TabIndex = 1;
            this.btn_encrypt.Text = "      Encrypt \r\n      Received Text";
            this.btn_encrypt.UseVisualStyleBackColor = false;
            this.btn_encrypt.Visible = false;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // btn_encryptsend
            // 
            this.btn_encryptsend.BackColor = System.Drawing.Color.White;
            this.btn_encryptsend.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encryptsend.ForeColor = System.Drawing.Color.Red;
            this.btn_encryptsend.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.encrypt_icon;
            this.btn_encryptsend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_encryptsend.Location = new System.Drawing.Point(98, 373);
            this.btn_encryptsend.Name = "btn_encryptsend";
            this.btn_encryptsend.Size = new System.Drawing.Size(156, 55);
            this.btn_encryptsend.TabIndex = 1;
            this.btn_encryptsend.Text = "        Encrypt\r\n        Sending Text";
            this.btn_encryptsend.UseVisualStyleBackColor = false;
            this.btn_encryptsend.Visible = false;
            this.btn_encryptsend.Click += new System.EventHandler(this.btn_encryptsend_Click);
            // 
            // btn_decryptsend
            // 
            this.btn_decryptsend.BackColor = System.Drawing.Color.White;
            this.btn_decryptsend.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decryptsend.ForeColor = System.Drawing.Color.Green;
            this.btn_decryptsend.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.decrypt_icon;
            this.btn_decryptsend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_decryptsend.Location = new System.Drawing.Point(97, 373);
            this.btn_decryptsend.Name = "btn_decryptsend";
            this.btn_decryptsend.Size = new System.Drawing.Size(157, 55);
            this.btn_decryptsend.TabIndex = 1;
            this.btn_decryptsend.Text = "        Decrypt \r\n        Sending Text";
            this.btn_decryptsend.UseVisualStyleBackColor = false;
            this.btn_decryptsend.Click += new System.EventHandler(this.btn_decryptsend_Click);
            // 
            // frm_attachment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.White_Wallpaper_HD_Background_Free;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_clientport);
            this.Controls.Add(this.txt_serverport);
            this.Controls.Add(this.txt_clientip);
            this.Controls.Add(this.txt_serverip);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_chatdate);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.btn_saveattachment);
            this.Controls.Add(this.btn_sendattachment);
            this.Controls.Add(this.btn_decryptsend);
            this.Controls.Add(this.btn_encryptsend);
            this.Controls.Add(this.btn_openattachment);
            this.Controls.Add(this.lbl_receiveattachment);
            this.Controls.Add(this.lbl_attachment);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_attachment";
            this.Text = "Send Attachment";
            this.Load += new System.EventHandler(this.frm_attachment_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lbl_attachment;
        private System.Windows.Forms.TextBox lbl_receiveattachment;
        private System.Windows.Forms.Button btn_openattachment;
        private System.Windows.Forms.Button btn_sendattachment;
        private System.Windows.Forms.Button btn_saveattachment;
        private System.Windows.Forms.DateTimePicker txt_chatdate;
        private No_Net_Chat_System_DatasetTableAdapters.tbl_send_attachmentTableAdapter tbl_send_attachmentTableAdapter1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.TextBox txt_serverip;
        private System.Windows.Forms.TextBox txt_serverport;
        private System.Windows.Forms.TextBox txt_clientip;
        private System.Windows.Forms.TextBox txt_clientport;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_encryptsend;
        private System.Windows.Forms.Button btn_decryptsend;
    }
}