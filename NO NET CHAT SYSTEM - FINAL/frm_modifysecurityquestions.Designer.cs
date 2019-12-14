namespace NO_NET_CHAT_SYSTEM___FINAL
{
    partial class frm_modifysecurityquestions
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
            this.lbl_securityquestion = new System.Windows.Forms.Label();
            this.lbl_securityanswer = new System.Windows.Forms.Label();
            this.cbox_securityquestion = new System.Windows.Forms.ComboBox();
            this.txt_securityanswer = new System.Windows.Forms.TextBox();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_userid = new System.Windows.Forms.Label();
            this.tbl_user_detailsTableAdapter1 = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_DatasetTableAdapters.tbl_user_detailsTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_encrypttext = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modify Security Questions";
            // 
            // lbl_securityquestion
            // 
            this.lbl_securityquestion.AutoSize = true;
            this.lbl_securityquestion.BackColor = System.Drawing.Color.White;
            this.lbl_securityquestion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_securityquestion.Location = new System.Drawing.Point(60, 181);
            this.lbl_securityquestion.Name = "lbl_securityquestion";
            this.lbl_securityquestion.Size = new System.Drawing.Size(124, 17);
            this.lbl_securityquestion.TabIndex = 4;
            this.lbl_securityquestion.Text = "Security Question";
            // 
            // lbl_securityanswer
            // 
            this.lbl_securityanswer.AutoSize = true;
            this.lbl_securityanswer.BackColor = System.Drawing.Color.White;
            this.lbl_securityanswer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_securityanswer.Location = new System.Drawing.Point(60, 245);
            this.lbl_securityanswer.Name = "lbl_securityanswer";
            this.lbl_securityanswer.Size = new System.Drawing.Size(113, 17);
            this.lbl_securityanswer.TabIndex = 4;
            this.lbl_securityanswer.Text = "Security Answer";
            // 
            // cbox_securityquestion
            // 
            this.cbox_securityquestion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_securityquestion.FormattingEnabled = true;
            this.cbox_securityquestion.Items.AddRange(new object[] {
            "What\'s your country of birth?",
            "What is your hobby?",
            "What is your favourite sport?"});
            this.cbox_securityquestion.Location = new System.Drawing.Point(237, 177);
            this.cbox_securityquestion.Name = "cbox_securityquestion";
            this.cbox_securityquestion.Size = new System.Drawing.Size(291, 25);
            this.cbox_securityquestion.TabIndex = 5;
            // 
            // txt_securityanswer
            // 
            this.txt_securityanswer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_securityanswer.Location = new System.Drawing.Point(237, 245);
            this.txt_securityanswer.Name = "txt_securityanswer";
            this.txt_securityanswer.Size = new System.Drawing.Size(291, 25);
            this.txt_securityanswer.TabIndex = 6;
            // 
            // btn_modify
            // 
            this.btn_modify.BackColor = System.Drawing.Color.White;
            this.btn_modify.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modify.ForeColor = System.Drawing.Color.Green;
            this.btn_modify.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.tick_icon;
            this.btn_modify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modify.Location = new System.Drawing.Point(237, 333);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(124, 36);
            this.btn_modify.TabIndex = 7;
            this.btn_modify.Text = "      Modify";
            this.btn_modify.UseVisualStyleBackColor = false;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.White;
            this.btn_reset.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Red;
            this.btn_reset.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.clear_icon;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(401, 333);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(127, 36);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "      Reset";
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
            // lbl_userid
            // 
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.Location = new System.Drawing.Point(60, 312);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(35, 13);
            this.lbl_userid.TabIndex = 9;
            this.lbl_userid.Text = "label2";
            this.lbl_userid.Visible = false;
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
            this.menuStrip1.TabIndex = 10;
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
            this.lbl_encrypttext.Location = new System.Drawing.Point(63, 355);
            this.lbl_encrypttext.Name = "lbl_encrypttext";
            this.lbl_encrypttext.Size = new System.Drawing.Size(42, 13);
            this.lbl_encrypttext.TabIndex = 11;
            this.lbl_encrypttext.Text = "encrypt";
            this.lbl_encrypttext.Visible = false;
            // 
            // frm_modifysecurityquestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.White_Wallpaper_HD_Background_Free;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lbl_encrypttext);
            this.Controls.Add(this.lbl_userid);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.txt_securityanswer);
            this.Controls.Add(this.cbox_securityquestion);
            this.Controls.Add(this.lbl_securityanswer);
            this.Controls.Add(this.lbl_securityquestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_modifysecurityquestions";
            this.Text = "Modify Security Questions";
            this.Load += new System.EventHandler(this.frm_modifysecurityquestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_securityquestion;
        private System.Windows.Forms.Label lbl_securityanswer;
        private System.Windows.Forms.ComboBox cbox_securityquestion;
        private System.Windows.Forms.TextBox txt_securityanswer;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label lbl_userid;
        private No_Net_Chat_System_DatasetTableAdapters.tbl_user_detailsTableAdapter tbl_user_detailsTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lbl_encrypttext;
    }
}