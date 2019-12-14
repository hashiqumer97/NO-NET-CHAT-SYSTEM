namespace NO_NET_CHAT_SYSTEM___FINAL
{
    partial class frm_createchat
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_purposeofchat = new System.Windows.Forms.Label();
            this.lbl_dateofchat = new System.Windows.Forms.Label();
            this.lbl_userid = new System.Windows.Forms.Label();
            this.txt_dateofchat = new System.Windows.Forms.DateTimePicker();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.btn_createchat = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lbl_hello = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.cbox_purposeofchat = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_portnumber = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_ipaddress = new System.Windows.Forms.TextBox();
            this.lbl_sendmessage = new System.Windows.Forms.Label();
            this.lbl_attachport = new System.Windows.Forms.Label();
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbl_create_chatTableAdapter1 = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_DatasetTableAdapters.tbl_create_chatTableAdapter();
            this.txt_portnumber = new System.Windows.Forms.ComboBox();
            this.txt_attachport = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Chat";
            // 
            // lbl_purposeofchat
            // 
            this.lbl_purposeofchat.AutoSize = true;
            this.lbl_purposeofchat.BackColor = System.Drawing.Color.White;
            this.lbl_purposeofchat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purposeofchat.Location = new System.Drawing.Point(55, 182);
            this.lbl_purposeofchat.Name = "lbl_purposeofchat";
            this.lbl_purposeofchat.Size = new System.Drawing.Size(114, 17);
            this.lbl_purposeofchat.TabIndex = 2;
            this.lbl_purposeofchat.Text = "Purpose of Chat";
            // 
            // lbl_dateofchat
            // 
            this.lbl_dateofchat.AutoSize = true;
            this.lbl_dateofchat.BackColor = System.Drawing.Color.White;
            this.lbl_dateofchat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateofchat.Location = new System.Drawing.Point(56, 231);
            this.lbl_dateofchat.Name = "lbl_dateofchat";
            this.lbl_dateofchat.Size = new System.Drawing.Size(90, 17);
            this.lbl_dateofchat.TabIndex = 2;
            this.lbl_dateofchat.Text = "Date of Chat";
            // 
            // lbl_userid
            // 
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.BackColor = System.Drawing.Color.White;
            this.lbl_userid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userid.Location = new System.Drawing.Point(55, 319);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(57, 17);
            this.lbl_userid.TabIndex = 2;
            this.lbl_userid.Text = "User ID";
            this.lbl_userid.Visible = false;
            // 
            // txt_dateofchat
            // 
            this.txt_dateofchat.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dateofchat.Enabled = false;
            this.txt_dateofchat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dateofchat.Location = new System.Drawing.Point(198, 223);
            this.txt_dateofchat.Name = "txt_dateofchat";
            this.txt_dateofchat.Size = new System.Drawing.Size(200, 25);
            this.txt_dateofchat.TabIndex = 4;
            // 
            // txt_userid
            // 
            this.txt_userid.Enabled = false;
            this.txt_userid.Location = new System.Drawing.Point(198, 316);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(200, 20);
            this.txt_userid.TabIndex = 5;
            this.txt_userid.Visible = false;
            // 
            // btn_createchat
            // 
            this.btn_createchat.BackColor = System.Drawing.Color.White;
            this.btn_createchat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createchat.ForeColor = System.Drawing.Color.Green;
            this.btn_createchat.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.create_icon;
            this.btn_createchat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_createchat.Location = new System.Drawing.Point(198, 332);
            this.btn_createchat.Name = "btn_createchat";
            this.btn_createchat.Size = new System.Drawing.Size(162, 47);
            this.btn_createchat.TabIndex = 3;
            this.btn_createchat.Text = "     Create Chat";
            this.btn_createchat.UseVisualStyleBackColor = false;
            this.btn_createchat.Click += new System.EventHandler(this.btn_createchat_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.White;
            this.btn_reset.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Red;
            this.btn_reset.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.clear_icon;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(392, 332);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(162, 47);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "   Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(37, 373);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 8;
            this.txtusername.Visible = false;
            // 
            // lbl_hello
            // 
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.BackColor = System.Drawing.Color.White;
            this.lbl_hello.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hello.Location = new System.Drawing.Point(164, 125);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(112, 27);
            this.lbl_hello.TabIndex = 9;
            this.lbl_hello.Text = "Welcome";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.White;
            this.lbl_name.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Green;
            this.lbl_name.Location = new System.Drawing.Point(295, 123);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(93, 29);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "(Name)";
            // 
            // cbox_purposeofchat
            // 
            this.cbox_purposeofchat.BackColor = System.Drawing.Color.White;
            this.cbox_purposeofchat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_purposeofchat.FormattingEnabled = true;
            this.cbox_purposeofchat.Items.AddRange(new object[] {
            "Status Update Meetings.",
            "Information Sharing Meetings.",
            "Decision Making Meetings.",
            "Problem Solving Meetings.",
            "Innovation Meetings.",
            "Team Building Meetings."});
            this.cbox_purposeofchat.Location = new System.Drawing.Point(198, 178);
            this.cbox_purposeofchat.Name = "cbox_purposeofchat";
            this.cbox_purposeofchat.Size = new System.Drawing.Size(249, 25);
            this.cbox_purposeofchat.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 26);
            this.menuStrip1.TabIndex = 12;
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
            // lbl_portnumber
            // 
            this.lbl_portnumber.AutoSize = true;
            this.lbl_portnumber.BackColor = System.Drawing.Color.White;
            this.lbl_portnumber.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_portnumber.Location = new System.Drawing.Point(55, 277);
            this.lbl_portnumber.Name = "lbl_portnumber";
            this.lbl_portnumber.Size = new System.Drawing.Size(91, 17);
            this.lbl_portnumber.TabIndex = 13;
            this.lbl_portnumber.Text = "Port Number";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // txt_ipaddress
            // 
            this.txt_ipaddress.Location = new System.Drawing.Point(198, 385);
            this.txt_ipaddress.Name = "txt_ipaddress";
            this.txt_ipaddress.Size = new System.Drawing.Size(208, 20);
            this.txt_ipaddress.TabIndex = 15;
            this.txt_ipaddress.Visible = false;
            // 
            // lbl_sendmessage
            // 
            this.lbl_sendmessage.AutoSize = true;
            this.lbl_sendmessage.BackColor = System.Drawing.Color.White;
            this.lbl_sendmessage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sendmessage.Location = new System.Drawing.Point(184, 265);
            this.lbl_sendmessage.Name = "lbl_sendmessage";
            this.lbl_sendmessage.Size = new System.Drawing.Size(72, 36);
            this.lbl_sendmessage.TabIndex = 13;
            this.lbl_sendmessage.Text = "Send\r\nMessage\r\n";
            // 
            // lbl_attachport
            // 
            this.lbl_attachport.AutoSize = true;
            this.lbl_attachport.BackColor = System.Drawing.Color.White;
            this.lbl_attachport.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_attachport.Location = new System.Drawing.Point(389, 265);
            this.lbl_attachport.Name = "lbl_attachport";
            this.lbl_attachport.Size = new System.Drawing.Size(87, 54);
            this.lbl_attachport.TabIndex = 13;
            this.lbl_attachport.Text = "Send\r\nAttachment\r\n\r\n";
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // tbl_create_chatTableAdapter1
            // 
            this.tbl_create_chatTableAdapter1.ClearBeforeFill = true;
            // 
            // txt_portnumber
            // 
            this.txt_portnumber.BackColor = System.Drawing.Color.White;
            this.txt_portnumber.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_portnumber.FormattingEnabled = true;
            this.txt_portnumber.Items.AddRange(new object[] {
            "1000",
            "1001",
            "1002",
            "1003",
            "1004"});
            this.txt_portnumber.Location = new System.Drawing.Point(267, 274);
            this.txt_portnumber.Name = "txt_portnumber";
            this.txt_portnumber.Size = new System.Drawing.Size(93, 25);
            this.txt_portnumber.TabIndex = 16;
            // 
            // txt_attachport
            // 
            this.txt_attachport.BackColor = System.Drawing.Color.White;
            this.txt_attachport.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_attachport.FormattingEnabled = true;
            this.txt_attachport.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004"});
            this.txt_attachport.Location = new System.Drawing.Point(494, 274);
            this.txt_attachport.Name = "txt_attachport";
            this.txt_attachport.Size = new System.Drawing.Size(93, 25);
            this.txt_attachport.TabIndex = 17;
            // 
            // frm_createchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.White_Wallpaper_HD_Background_Free;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.txt_attachport);
            this.Controls.Add(this.txt_portnumber);
            this.Controls.Add(this.txt_ipaddress);
            this.Controls.Add(this.lbl_attachport);
            this.Controls.Add(this.lbl_sendmessage);
            this.Controls.Add(this.lbl_portnumber);
            this.Controls.Add(this.cbox_purposeofchat);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_hello);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_createchat);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.txt_dateofchat);
            this.Controls.Add(this.lbl_userid);
            this.Controls.Add(this.lbl_dateofchat);
            this.Controls.Add(this.lbl_purposeofchat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_createchat";
            this.Text = "Create Chat";
            this.Load += new System.EventHandler(this.frm_createchat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_purposeofchat;
        private System.Windows.Forms.Label lbl_dateofchat;
        private System.Windows.Forms.Label lbl_userid;
        private System.Windows.Forms.DateTimePicker txt_dateofchat;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.Button btn_createchat;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private No_Net_Chat_System_DatasetTableAdapters.tbl_create_chatTableAdapter tbl_create_chatTableAdapter1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_hello;
        private System.Windows.Forms.ComboBox cbox_purposeofchat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label lbl_portnumber;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox txt_ipaddress;
        private System.Windows.Forms.Label lbl_attachport;
        private System.Windows.Forms.Label lbl_sendmessage;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ComboBox txt_attachport;
        private System.Windows.Forms.ComboBox txt_portnumber;
    }
}