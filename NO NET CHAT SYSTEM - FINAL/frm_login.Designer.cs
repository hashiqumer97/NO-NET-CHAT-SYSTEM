namespace NO_NET_CHAT_SYSTEM___FINAL
{
    partial class frm_login
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_loginerror = new System.Windows.Forms.Label();
            this.lbl_ipaddress = new System.Windows.Forms.Label();
            this.txt_ipaddress = new System.Windows.Forms.TextBox();
            this.btn_registeruser = new System.Windows.Forms.Button();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_forgetpassword = new System.Windows.Forms.Button();
            this.tbluserdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.no_Net_Chat_System_Dataset = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_Dataset();
            this.tbl_user_detailsTableAdapter1 = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_DatasetTableAdapters.tbl_user_detailsTableAdapter();
            this.lbl_encrypttext = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_Net_Chat_System_Dataset)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to No-Net Chat System";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.White;
            this.lbl_username.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(66, 138);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(76, 17);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.White;
            this.lbl_password.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(66, 202);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(74, 17);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(196, 139);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(317, 25);
            this.txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(196, 200);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(317, 25);
            this.txt_password.TabIndex = 1;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.White;
            this.btn_reset.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Red;
            this.btn_reset.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.clear_icon;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(385, 254);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(130, 37);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "     Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_login.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Green;
            this.btn_login.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.login_icon;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(196, 254);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(126, 37);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "     Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_loginerror
            // 
            this.lbl_loginerror.AutoSize = true;
            this.lbl_loginerror.BackColor = System.Drawing.Color.White;
            this.lbl_loginerror.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginerror.ForeColor = System.Drawing.Color.Red;
            this.lbl_loginerror.Location = new System.Drawing.Point(81, 395);
            this.lbl_loginerror.Name = "lbl_loginerror";
            this.lbl_loginerror.Size = new System.Drawing.Size(416, 24);
            this.lbl_loginerror.TabIndex = 7;
            this.lbl_loginerror.Text = "INCORRECT USERNAME OR PASSWORD";
            this.lbl_loginerror.Visible = false;
            // 
            // lbl_ipaddress
            // 
            this.lbl_ipaddress.AutoSize = true;
            this.lbl_ipaddress.BackColor = System.Drawing.Color.White;
            this.lbl_ipaddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ipaddress.Location = new System.Drawing.Point(68, 257);
            this.lbl_ipaddress.Name = "lbl_ipaddress";
            this.lbl_ipaddress.Size = new System.Drawing.Size(78, 17);
            this.lbl_ipaddress.TabIndex = 8;
            this.lbl_ipaddress.Text = "IP Address";
            this.lbl_ipaddress.Visible = false;
            // 
            // txt_ipaddress
            // 
            this.txt_ipaddress.Enabled = false;
            this.txt_ipaddress.Location = new System.Drawing.Point(198, 254);
            this.txt_ipaddress.Name = "txt_ipaddress";
            this.txt_ipaddress.Size = new System.Drawing.Size(317, 20);
            this.txt_ipaddress.TabIndex = 2;
            this.txt_ipaddress.Visible = false;
            // 
            // btn_registeruser
            // 
            this.btn_registeruser.BackColor = System.Drawing.Color.White;
            this.btn_registeruser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registeruser.ForeColor = System.Drawing.Color.Olive;
            this.btn_registeruser.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.registeruser_icon;
            this.btn_registeruser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registeruser.Location = new System.Drawing.Point(196, 301);
            this.btn_registeruser.Name = "btn_registeruser";
            this.btn_registeruser.Size = new System.Drawing.Size(319, 41);
            this.btn_registeruser.TabIndex = 5;
            this.btn_registeruser.Text = "Register User";
            this.btn_registeruser.UseVisualStyleBackColor = false;
            this.btn_registeruser.Click += new System.EventHandler(this.btn_registeruser_Click);
            // 
            // txtuid
            // 
            this.txtuid.Enabled = false;
            this.txtuid.Location = new System.Drawing.Point(69, 312);
            this.txtuid.Name = "txtuid";
            this.txtuid.Size = new System.Drawing.Size(59, 20);
            this.txtuid.TabIndex = 9;
            this.txtuid.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 26);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btn_forgetpassword
            // 
            this.btn_forgetpassword.BackColor = System.Drawing.Color.White;
            this.btn_forgetpassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_forgetpassword.ForeColor = System.Drawing.Color.Teal;
            this.btn_forgetpassword.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.forgotpassword_icon;
            this.btn_forgetpassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_forgetpassword.Location = new System.Drawing.Point(196, 348);
            this.btn_forgetpassword.Name = "btn_forgetpassword";
            this.btn_forgetpassword.Size = new System.Drawing.Size(317, 44);
            this.btn_forgetpassword.TabIndex = 5;
            this.btn_forgetpassword.Text = "Forgot Password";
            this.btn_forgetpassword.UseVisualStyleBackColor = false;
            this.btn_forgetpassword.Click += new System.EventHandler(this.btn_forgetpassword_Click);
            // 
            // tbluserdetailsBindingSource
            // 
            this.tbluserdetailsBindingSource.DataMember = "tbl_user_details";
            this.tbluserdetailsBindingSource.DataSource = this.no_Net_Chat_System_Dataset;
            // 
            // no_Net_Chat_System_Dataset
            // 
            this.no_Net_Chat_System_Dataset.DataSetName = "No_Net_Chat_System_Dataset";
            this.no_Net_Chat_System_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_user_detailsTableAdapter1
            // 
            this.tbl_user_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // lbl_encrypttext
            // 
            this.lbl_encrypttext.AutoSize = true;
            this.lbl_encrypttext.Location = new System.Drawing.Point(69, 348);
            this.lbl_encrypttext.Name = "lbl_encrypttext";
            this.lbl_encrypttext.Size = new System.Drawing.Size(42, 13);
            this.lbl_encrypttext.TabIndex = 11;
            this.lbl_encrypttext.Text = "encrypt";
            this.lbl_encrypttext.Visible = false;
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Location = new System.Drawing.Point(69, 365);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(60, 13);
            this.lbl_department.TabIndex = 12;
            this.lbl_department.Text = "department";
            this.lbl_department.Visible = false;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.White_Wallpaper_HD_Background_Free;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.lbl_encrypttext);
            this.Controls.Add(this.txtuid);
            this.Controls.Add(this.btn_forgetpassword);
            this.Controls.Add(this.btn_registeruser);
            this.Controls.Add(this.txt_ipaddress);
            this.Controls.Add(this.lbl_ipaddress);
            this.Controls.Add(this.lbl_loginerror);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_Net_Chat_System_Dataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_reset;
        private No_Net_Chat_System_DatasetTableAdapters.tbl_user_detailsTableAdapter tbl_user_detailsTableAdapter1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_loginerror;
        private System.Windows.Forms.Label lbl_ipaddress;
        private System.Windows.Forms.TextBox txt_ipaddress;
        private System.Windows.Forms.Button btn_registeruser;
        private System.Windows.Forms.TextBox txtuid;
        private System.Windows.Forms.BindingSource tbluserdetailsBindingSource;
        private No_Net_Chat_System_Dataset no_Net_Chat_System_Dataset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btn_forgetpassword;
        private System.Windows.Forms.Label lbl_encrypttext;
        private System.Windows.Forms.Label lbl_department;
    }
}

