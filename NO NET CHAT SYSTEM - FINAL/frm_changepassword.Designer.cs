namespace NO_NET_CHAT_SYSTEM___FINAL
{
    partial class frm_changepassword
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
            this.lbl_newpassword = new System.Windows.Forms.Label();
            this.lbl_confirmnewpassword = new System.Windows.Forms.Label();
            this.txt_newpassword = new System.Windows.Forms.TextBox();
            this.txt_confirmnewpassword = new System.Windows.Forms.TextBox();
            this.btn_changepassword = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_userid = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbl_user_detailsTableAdapter1 = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_DatasetTableAdapters.tbl_user_detailsTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_encrypttext = new System.Windows.Forms.Label();
            this.txt_oldpassword = new System.Windows.Forms.TextBox();
            this.lbl_oldpass = new System.Windows.Forms.Label();
            this.btn_checkpassword = new System.Windows.Forms.Button();
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_oldpassword = new System.Windows.Forms.Label();
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Change Password";
            // 
            // lbl_newpassword
            // 
            this.lbl_newpassword.AutoSize = true;
            this.lbl_newpassword.BackColor = System.Drawing.Color.White;
            this.lbl_newpassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newpassword.Location = new System.Drawing.Point(61, 170);
            this.lbl_newpassword.Name = "lbl_newpassword";
            this.lbl_newpassword.Size = new System.Drawing.Size(113, 18);
            this.lbl_newpassword.TabIndex = 3;
            this.lbl_newpassword.Text = "New Password";
            this.lbl_newpassword.Visible = false;
            // 
            // lbl_confirmnewpassword
            // 
            this.lbl_confirmnewpassword.AutoSize = true;
            this.lbl_confirmnewpassword.BackColor = System.Drawing.Color.White;
            this.lbl_confirmnewpassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmnewpassword.Location = new System.Drawing.Point(61, 244);
            this.lbl_confirmnewpassword.Name = "lbl_confirmnewpassword";
            this.lbl_confirmnewpassword.Size = new System.Drawing.Size(172, 18);
            this.lbl_confirmnewpassword.TabIndex = 3;
            this.lbl_confirmnewpassword.Text = "Confirm New Password";
            this.lbl_confirmnewpassword.Visible = false;
            // 
            // txt_newpassword
            // 
            this.txt_newpassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newpassword.Location = new System.Drawing.Point(262, 170);
            this.txt_newpassword.Name = "txt_newpassword";
            this.txt_newpassword.PasswordChar = '*';
            this.txt_newpassword.Size = new System.Drawing.Size(269, 25);
            this.txt_newpassword.TabIndex = 0;
            this.txt_newpassword.Visible = false;
            // 
            // txt_confirmnewpassword
            // 
            this.txt_confirmnewpassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmnewpassword.Location = new System.Drawing.Point(262, 242);
            this.txt_confirmnewpassword.Name = "txt_confirmnewpassword";
            this.txt_confirmnewpassword.PasswordChar = '*';
            this.txt_confirmnewpassword.Size = new System.Drawing.Size(269, 25);
            this.txt_confirmnewpassword.TabIndex = 1;
            this.txt_confirmnewpassword.Visible = false;
            // 
            // btn_changepassword
            // 
            this.btn_changepassword.BackColor = System.Drawing.Color.White;
            this.btn_changepassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changepassword.ForeColor = System.Drawing.Color.Green;
            this.btn_changepassword.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.tick_icon;
            this.btn_changepassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_changepassword.Location = new System.Drawing.Point(191, 329);
            this.btn_changepassword.Name = "btn_changepassword";
            this.btn_changepassword.Size = new System.Drawing.Size(179, 36);
            this.btn_changepassword.TabIndex = 2;
            this.btn_changepassword.Text = "        Change Password";
            this.btn_changepassword.UseVisualStyleBackColor = false;
            this.btn_changepassword.Visible = false;
            this.btn_changepassword.Click += new System.EventHandler(this.btn_changepassword_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.White;
            this.btn_reset.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Red;
            this.btn_reset.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.clear_icon;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(390, 329);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(141, 36);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "     Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lbl_userid
            // 
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.Location = new System.Drawing.Point(29, 308);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(35, 13);
            this.lbl_userid.TabIndex = 7;
            this.lbl_userid.Text = "label4";
            this.lbl_userid.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // tbl_user_detailsTableAdapter1
            // 
            this.tbl_user_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 26);
            this.menuStrip1.TabIndex = 8;
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
            this.lbl_encrypttext.Location = new System.Drawing.Point(42, 342);
            this.lbl_encrypttext.Name = "lbl_encrypttext";
            this.lbl_encrypttext.Size = new System.Drawing.Size(42, 13);
            this.lbl_encrypttext.TabIndex = 9;
            this.lbl_encrypttext.Text = "encrypt";
            this.lbl_encrypttext.Visible = false;
            // 
            // txt_oldpassword
            // 
            this.txt_oldpassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_oldpassword.Location = new System.Drawing.Point(262, 202);
            this.txt_oldpassword.Name = "txt_oldpassword";
            this.txt_oldpassword.PasswordChar = '*';
            this.txt_oldpassword.Size = new System.Drawing.Size(269, 25);
            this.txt_oldpassword.TabIndex = 0;
            // 
            // lbl_oldpass
            // 
            this.lbl_oldpass.AutoSize = true;
            this.lbl_oldpass.BackColor = System.Drawing.Color.White;
            this.lbl_oldpass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_oldpass.Location = new System.Drawing.Point(61, 205);
            this.lbl_oldpass.Name = "lbl_oldpass";
            this.lbl_oldpass.Size = new System.Drawing.Size(106, 18);
            this.lbl_oldpass.TabIndex = 3;
            this.lbl_oldpass.Text = "Old Password";
            // 
            // btn_checkpassword
            // 
            this.btn_checkpassword.BackColor = System.Drawing.Color.White;
            this.btn_checkpassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkpassword.ForeColor = System.Drawing.Color.Green;
            this.btn_checkpassword.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.tick_icon;
            this.btn_checkpassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_checkpassword.Location = new System.Drawing.Point(198, 329);
            this.btn_checkpassword.Name = "btn_checkpassword";
            this.btn_checkpassword.Size = new System.Drawing.Size(172, 36);
            this.btn_checkpassword.TabIndex = 2;
            this.btn_checkpassword.Text = "       Check Password";
            this.btn_checkpassword.UseVisualStyleBackColor = false;
            this.btn_checkpassword.Click += new System.EventHandler(this.btn_checkpassword_Click);
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // lbl_oldpassword
            // 
            this.lbl_oldpassword.AutoSize = true;
            this.lbl_oldpassword.Location = new System.Drawing.Point(28, 373);
            this.lbl_oldpassword.Name = "lbl_oldpassword";
            this.lbl_oldpassword.Size = new System.Drawing.Size(35, 13);
            this.lbl_oldpassword.TabIndex = 10;
            this.lbl_oldpassword.Text = "label2";
            this.lbl_oldpassword.Visible = false;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // frm_changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.White_Wallpaper_HD_Background_Free;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lbl_oldpassword);
            this.Controls.Add(this.lbl_encrypttext);
            this.Controls.Add(this.lbl_userid);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_checkpassword);
            this.Controls.Add(this.btn_changepassword);
            this.Controls.Add(this.txt_confirmnewpassword);
            this.Controls.Add(this.txt_oldpassword);
            this.Controls.Add(this.txt_newpassword);
            this.Controls.Add(this.lbl_confirmnewpassword);
            this.Controls.Add(this.lbl_oldpass);
            this.Controls.Add(this.lbl_newpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_changepassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frm_changepassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_newpassword;
        private System.Windows.Forms.Label lbl_confirmnewpassword;
        private System.Windows.Forms.TextBox txt_newpassword;
        private System.Windows.Forms.TextBox txt_confirmnewpassword;
        private System.Windows.Forms.Button btn_changepassword;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_userid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private No_Net_Chat_System_DatasetTableAdapters.tbl_user_detailsTableAdapter tbl_user_detailsTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lbl_encrypttext;
        private System.Windows.Forms.TextBox txt_oldpassword;
        private System.Windows.Forms.Label lbl_oldpass;
        private System.Windows.Forms.Button btn_checkpassword;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Label lbl_oldpassword;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}