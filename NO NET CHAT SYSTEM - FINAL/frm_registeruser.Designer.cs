namespace NO_NET_CHAT_SYSTEM___FINAL
{
    partial class frm_registeruser
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
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.lbl_contactno = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_dob = new System.Windows.Forms.DateTimePicker();
            this.cbox_department = new System.Windows.Forms.ComboBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbl_user_detailsTableAdapter1 = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_DatasetTableAdapters.tbl_user_detailsTableAdapter();
            this.txt_contactno = new System.Windows.Forms.MaskedTextBox();
            this.lbl_securityquestions = new System.Windows.Forms.Label();
            this.lbl_securityanswer = new System.Windows.Forms.Label();
            this.cbox_securityquestions = new System.Windows.Forms.ComboBox();
            this.txt_securityanswer = new System.Windows.Forms.TextBox();
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_encrypttext = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Register User";
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fullname.Location = new System.Drawing.Point(49, 92);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(74, 17);
            this.lbl_fullname.TabIndex = 2;
            this.lbl_fullname.Text = "Full Name";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dob.Location = new System.Drawing.Point(49, 128);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(89, 17);
            this.lbl_dob.TabIndex = 2;
            this.lbl_dob.Text = "Date of Birth";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_department.Location = new System.Drawing.Point(49, 168);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(85, 17);
            this.lbl_department.TabIndex = 2;
            this.lbl_department.Text = "Department";
            // 
            // lbl_contactno
            // 
            this.lbl_contactno.AutoSize = true;
            this.lbl_contactno.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contactno.Location = new System.Drawing.Point(49, 206);
            this.lbl_contactno.Name = "lbl_contactno";
            this.lbl_contactno.Size = new System.Drawing.Size(115, 17);
            this.lbl_contactno.TabIndex = 2;
            this.lbl_contactno.Text = "Contact Number";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(49, 243);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(76, 17);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(49, 278);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(74, 17);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullname.Location = new System.Drawing.Point(194, 93);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(357, 25);
            this.txt_fullname.TabIndex = 4;
            // 
            // txt_dob
            // 
            this.txt_dob.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dob.Location = new System.Drawing.Point(194, 125);
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(200, 25);
            this.txt_dob.TabIndex = 5;
            // 
            // cbox_department
            // 
            this.cbox_department.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_department.FormattingEnabled = true;
            this.cbox_department.Items.AddRange(new object[] {
            "Team Lead",
            "Research & Development",
            "Software Developers",
            "QA"});
            this.cbox_department.Location = new System.Drawing.Point(194, 165);
            this.cbox_department.Name = "cbox_department";
            this.cbox_department.Size = new System.Drawing.Size(200, 25);
            this.cbox_department.TabIndex = 6;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(194, 240);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(200, 25);
            this.txt_username.TabIndex = 8;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(194, 275);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(200, 25);
            this.txt_password.TabIndex = 9;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.White;
            this.btn_register.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.Green;
            this.btn_register.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.tick_icon;
            this.btn_register.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_register.Location = new System.Drawing.Point(194, 396);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(129, 33);
            this.btn_register.TabIndex = 12;
            this.btn_register.Text = "     Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.White;
            this.btn_reset.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Red;
            this.btn_reset.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.clear_icon;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(345, 396);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(130, 33);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "   Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
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
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // tbl_user_detailsTableAdapter1
            // 
            this.tbl_user_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // txt_contactno
            // 
            this.txt_contactno.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contactno.Location = new System.Drawing.Point(194, 206);
            this.txt_contactno.Mask = "000000000";
            this.txt_contactno.Name = "txt_contactno";
            this.txt_contactno.Size = new System.Drawing.Size(200, 25);
            this.txt_contactno.TabIndex = 7;
            this.txt_contactno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contactno_KeyPress);
            // 
            // lbl_securityquestions
            // 
            this.lbl_securityquestions.AutoSize = true;
            this.lbl_securityquestions.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_securityquestions.Location = new System.Drawing.Point(49, 322);
            this.lbl_securityquestions.Name = "lbl_securityquestions";
            this.lbl_securityquestions.Size = new System.Drawing.Size(132, 17);
            this.lbl_securityquestions.TabIndex = 2;
            this.lbl_securityquestions.Text = "Security Questions";
            // 
            // lbl_securityanswer
            // 
            this.lbl_securityanswer.AutoSize = true;
            this.lbl_securityanswer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_securityanswer.Location = new System.Drawing.Point(49, 357);
            this.lbl_securityanswer.Name = "lbl_securityanswer";
            this.lbl_securityanswer.Size = new System.Drawing.Size(113, 17);
            this.lbl_securityanswer.TabIndex = 2;
            this.lbl_securityanswer.Text = "Security Answer";
            // 
            // cbox_securityquestions
            // 
            this.cbox_securityquestions.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_securityquestions.FormattingEnabled = true;
            this.cbox_securityquestions.Items.AddRange(new object[] {
            "What\'s your country of birth?",
            "What is your hobby?",
            "What is your favourite sport?"});
            this.cbox_securityquestions.Location = new System.Drawing.Point(194, 314);
            this.cbox_securityquestions.Name = "cbox_securityquestions";
            this.cbox_securityquestions.Size = new System.Drawing.Size(259, 25);
            this.cbox_securityquestions.TabIndex = 10;
            // 
            // txt_securityanswer
            // 
            this.txt_securityanswer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_securityanswer.Location = new System.Drawing.Point(194, 349);
            this.txt_securityanswer.Name = "txt_securityanswer";
            this.txt_securityanswer.Size = new System.Drawing.Size(200, 25);
            this.txt_securityanswer.TabIndex = 11;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // errorProvider8
            // 
            this.errorProvider8.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 26);
            this.menuStrip1.TabIndex = 14;
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
            // lbl_encrypttext
            // 
            this.lbl_encrypttext.AutoSize = true;
            this.lbl_encrypttext.Location = new System.Drawing.Point(49, 407);
            this.lbl_encrypttext.Name = "lbl_encrypttext";
            this.lbl_encrypttext.Size = new System.Drawing.Size(42, 13);
            this.lbl_encrypttext.TabIndex = 15;
            this.lbl_encrypttext.Text = "encrypt";
            this.lbl_encrypttext.Visible = false;
            // 
            // frm_registeruser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.White_Wallpaper_HD_Background_Free;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lbl_encrypttext);
            this.Controls.Add(this.txt_securityanswer);
            this.Controls.Add(this.cbox_securityquestions);
            this.Controls.Add(this.txt_contactno);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.cbox_department);
            this.Controls.Add(this.txt_dob);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.lbl_securityanswer);
            this.Controls.Add(this.lbl_securityquestions);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_contactno);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.lbl_fullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_registeruser";
            this.Text = "Register User";
            this.Load += new System.EventHandler(this.frm_registeruser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Label lbl_contactno;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.DateTimePicker txt_dob;
        private System.Windows.Forms.ComboBox cbox_department;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private No_Net_Chat_System_DatasetTableAdapters.tbl_user_detailsTableAdapter tbl_user_detailsTableAdapter1;
        private System.Windows.Forms.MaskedTextBox txt_contactno;
        private System.Windows.Forms.TextBox txt_securityanswer;
        private System.Windows.Forms.ComboBox cbox_securityquestions;
        private System.Windows.Forms.Label lbl_securityanswer;
        private System.Windows.Forms.Label lbl_securityquestions;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ErrorProvider errorProvider8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lbl_encrypttext;
    }
}