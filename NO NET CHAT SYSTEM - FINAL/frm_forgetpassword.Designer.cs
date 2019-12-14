namespace NO_NET_CHAT_SYSTEM___FINAL
{
    partial class frm_forgetpassword
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.lbl_securityquestion = new System.Windows.Forms.Label();
            this.txt_securityquestion = new System.Windows.Forms.TextBox();
            this.lbl_securityanswer = new System.Windows.Forms.Label();
            this.txt_securityanswer = new System.Windows.Forms.TextBox();
            this.btn_confirmanswer = new System.Windows.Forms.Button();
            this.lbl_newpassword = new System.Windows.Forms.Label();
            this.txt_newpassword = new System.Windows.Forms.TextBox();
            this.lbl_confirmnewpassword = new System.Windows.Forms.Label();
            this.txt_confirmnewpassword = new System.Windows.Forms.TextBox();
            this.btn_confirmpassword = new System.Windows.Forms.Button();
            this.tbl_user_detailsTableAdapter1 = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_DatasetTableAdapters.tbl_user_detailsTableAdapter();
            this.lbl_userid = new System.Windows.Forms.Label();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_encrypttext = new System.Windows.Forms.Label();
            this.lbl_encryptanswer = new System.Windows.Forms.Label();
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Forgot Password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.White;
            this.lbl_username.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(17, 218);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(76, 17);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "Username";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(195, 215);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(333, 25);
            this.txt_username.TabIndex = 4;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.White;
            this.btn_confirm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.Green;
            this.btn_confirm.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.tick_icon;
            this.btn_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_confirm.Location = new System.Drawing.Point(261, 244);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(194, 29);
            this.btn_confirm.TabIndex = 5;
            this.btn_confirm.Text = "          Confirm Username";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // lbl_securityquestion
            // 
            this.lbl_securityquestion.AutoSize = true;
            this.lbl_securityquestion.BackColor = System.Drawing.Color.White;
            this.lbl_securityquestion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_securityquestion.Location = new System.Drawing.Point(17, 199);
            this.lbl_securityquestion.Name = "lbl_securityquestion";
            this.lbl_securityquestion.Size = new System.Drawing.Size(124, 17);
            this.lbl_securityquestion.TabIndex = 3;
            this.lbl_securityquestion.Text = "Security Question";
            this.lbl_securityquestion.Visible = false;
            // 
            // txt_securityquestion
            // 
            this.txt_securityquestion.BackColor = System.Drawing.Color.White;
            this.txt_securityquestion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_securityquestion.Location = new System.Drawing.Point(195, 196);
            this.txt_securityquestion.Name = "txt_securityquestion";
            this.txt_securityquestion.ReadOnly = true;
            this.txt_securityquestion.Size = new System.Drawing.Size(333, 25);
            this.txt_securityquestion.TabIndex = 4;
            this.txt_securityquestion.Visible = false;
            // 
            // lbl_securityanswer
            // 
            this.lbl_securityanswer.AutoSize = true;
            this.lbl_securityanswer.BackColor = System.Drawing.Color.White;
            this.lbl_securityanswer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_securityanswer.Location = new System.Drawing.Point(17, 236);
            this.lbl_securityanswer.Name = "lbl_securityanswer";
            this.lbl_securityanswer.Size = new System.Drawing.Size(113, 17);
            this.lbl_securityanswer.TabIndex = 3;
            this.lbl_securityanswer.Text = "Security Answer";
            this.lbl_securityanswer.Visible = false;
            // 
            // txt_securityanswer
            // 
            this.txt_securityanswer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_securityanswer.Location = new System.Drawing.Point(195, 228);
            this.txt_securityanswer.Name = "txt_securityanswer";
            this.txt_securityanswer.Size = new System.Drawing.Size(333, 25);
            this.txt_securityanswer.TabIndex = 4;
            this.txt_securityanswer.Visible = false;
            this.txt_securityanswer.WordWrap = false;
            // 
            // btn_confirmanswer
            // 
            this.btn_confirmanswer.BackColor = System.Drawing.Color.White;
            this.btn_confirmanswer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmanswer.ForeColor = System.Drawing.Color.Green;
            this.btn_confirmanswer.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.tick_icon;
            this.btn_confirmanswer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_confirmanswer.Location = new System.Drawing.Point(261, 259);
            this.btn_confirmanswer.Name = "btn_confirmanswer";
            this.btn_confirmanswer.Size = new System.Drawing.Size(194, 29);
            this.btn_confirmanswer.TabIndex = 5;
            this.btn_confirmanswer.Text = "     Confirm Answer";
            this.btn_confirmanswer.UseVisualStyleBackColor = false;
            this.btn_confirmanswer.Visible = false;
            this.btn_confirmanswer.Click += new System.EventHandler(this.btn_confirmanswer_Click);
            // 
            // lbl_newpassword
            // 
            this.lbl_newpassword.AutoSize = true;
            this.lbl_newpassword.BackColor = System.Drawing.Color.White;
            this.lbl_newpassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newpassword.Location = new System.Drawing.Point(17, 181);
            this.lbl_newpassword.Name = "lbl_newpassword";
            this.lbl_newpassword.Size = new System.Drawing.Size(107, 17);
            this.lbl_newpassword.TabIndex = 3;
            this.lbl_newpassword.Text = "New Password";
            this.lbl_newpassword.Visible = false;
            // 
            // txt_newpassword
            // 
            this.txt_newpassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newpassword.Location = new System.Drawing.Point(195, 181);
            this.txt_newpassword.Name = "txt_newpassword";
            this.txt_newpassword.PasswordChar = '*';
            this.txt_newpassword.Size = new System.Drawing.Size(333, 25);
            this.txt_newpassword.TabIndex = 4;
            this.txt_newpassword.Visible = false;
            // 
            // lbl_confirmnewpassword
            // 
            this.lbl_confirmnewpassword.AutoSize = true;
            this.lbl_confirmnewpassword.BackColor = System.Drawing.Color.White;
            this.lbl_confirmnewpassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmnewpassword.Location = new System.Drawing.Point(17, 215);
            this.lbl_confirmnewpassword.Name = "lbl_confirmnewpassword";
            this.lbl_confirmnewpassword.Size = new System.Drawing.Size(163, 17);
            this.lbl_confirmnewpassword.TabIndex = 3;
            this.lbl_confirmnewpassword.Text = "Confirm New Password";
            this.lbl_confirmnewpassword.Visible = false;
            // 
            // txt_confirmnewpassword
            // 
            this.txt_confirmnewpassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmnewpassword.Location = new System.Drawing.Point(195, 213);
            this.txt_confirmnewpassword.Name = "txt_confirmnewpassword";
            this.txt_confirmnewpassword.PasswordChar = '*';
            this.txt_confirmnewpassword.Size = new System.Drawing.Size(333, 25);
            this.txt_confirmnewpassword.TabIndex = 4;
            this.txt_confirmnewpassword.Visible = false;
            this.txt_confirmnewpassword.WordWrap = false;
            // 
            // btn_confirmpassword
            // 
            this.btn_confirmpassword.BackColor = System.Drawing.Color.White;
            this.btn_confirmpassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmpassword.ForeColor = System.Drawing.Color.Green;
            this.btn_confirmpassword.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.tick_icon;
            this.btn_confirmpassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_confirmpassword.Location = new System.Drawing.Point(261, 246);
            this.btn_confirmpassword.Name = "btn_confirmpassword";
            this.btn_confirmpassword.Size = new System.Drawing.Size(194, 29);
            this.btn_confirmpassword.TabIndex = 5;
            this.btn_confirmpassword.Text = "         Confirm Password";
            this.btn_confirmpassword.UseVisualStyleBackColor = false;
            this.btn_confirmpassword.Visible = false;
            this.btn_confirmpassword.Click += new System.EventHandler(this.btn_confirmpassword_Click);
            // 
            // tbl_user_detailsTableAdapter1
            // 
            this.tbl_user_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // lbl_userid
            // 
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.Location = new System.Drawing.Point(46, 385);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(35, 13);
            this.lbl_userid.TabIndex = 6;
            this.lbl_userid.Text = "label2";
            this.lbl_userid.Visible = false;
            // 
            // lbl_answer
            // 
            this.lbl_answer.AutoSize = true;
            this.lbl_answer.Location = new System.Drawing.Point(112, 398);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Size = new System.Drawing.Size(35, 13);
            this.lbl_answer.TabIndex = 7;
            this.lbl_answer.Text = "label2";
            this.lbl_answer.Visible = false;
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
            this.lbl_encrypttext.Location = new System.Drawing.Point(46, 343);
            this.lbl_encrypttext.Name = "lbl_encrypttext";
            this.lbl_encrypttext.Size = new System.Drawing.Size(42, 13);
            this.lbl_encrypttext.TabIndex = 9;
            this.lbl_encrypttext.Text = "encrypt";
            this.lbl_encrypttext.Visible = false;
            // 
            // lbl_encryptanswer
            // 
            this.lbl_encryptanswer.AutoSize = true;
            this.lbl_encryptanswer.Location = new System.Drawing.Point(115, 343);
            this.lbl_encryptanswer.Name = "lbl_encryptanswer";
            this.lbl_encryptanswer.Size = new System.Drawing.Size(76, 13);
            this.lbl_encryptanswer.TabIndex = 10;
            this.lbl_encryptanswer.Text = "encryptanswer";
            this.lbl_encryptanswer.Visible = false;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // frm_forgetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.White_Wallpaper_HD_Background_Free;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lbl_encryptanswer);
            this.Controls.Add(this.lbl_encrypttext);
            this.Controls.Add(this.lbl_answer);
            this.Controls.Add(this.lbl_userid);
            this.Controls.Add(this.btn_confirmpassword);
            this.Controls.Add(this.btn_confirmanswer);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.txt_confirmnewpassword);
            this.Controls.Add(this.txt_newpassword);
            this.Controls.Add(this.txt_securityanswer);
            this.Controls.Add(this.txt_securityquestion);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_confirmnewpassword);
            this.Controls.Add(this.lbl_newpassword);
            this.Controls.Add(this.lbl_securityanswer);
            this.Controls.Add(this.lbl_securityquestion);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_forgetpassword";
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.frm_forgetpassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label lbl_securityquestion;
        private System.Windows.Forms.TextBox txt_securityquestion;
        private System.Windows.Forms.Label lbl_securityanswer;
        private System.Windows.Forms.TextBox txt_securityanswer;
        private System.Windows.Forms.Button btn_confirmanswer;
        private System.Windows.Forms.Label lbl_newpassword;
        private System.Windows.Forms.TextBox txt_newpassword;
        private System.Windows.Forms.Label lbl_confirmnewpassword;
        private System.Windows.Forms.TextBox txt_confirmnewpassword;
        private System.Windows.Forms.Button btn_confirmpassword;
        private No_Net_Chat_System_DatasetTableAdapters.tbl_user_detailsTableAdapter tbl_user_detailsTableAdapter1;
        private System.Windows.Forms.Label lbl_userid;
        private System.Windows.Forms.Label lbl_answer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lbl_encrypttext;
        private System.Windows.Forms.Label lbl_encryptanswer;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}