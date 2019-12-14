namespace NO_NET_CHAT_SYSTEM___FINAL
{
    partial class frm_modifyuser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_userdetails = new System.Windows.Forms.DataGridView();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.securityquestionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.securityanswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbluserdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.no_Net_Chat_System_Dataset = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_Dataset();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.lbl_dateofbirth = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.lbl_contactnumber = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.cbox_department = new System.Windows.Forms.ComboBox();
            this.txt_contactnumber = new System.Windows.Forms.MaskedTextBox();
            this.btn_modifydetails = new System.Windows.Forms.Button();
            this.btn_deleteuser = new System.Windows.Forms.Button();
            this.btn_resetpassword = new System.Windows.Forms.Button();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.txt_resetpassword = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.tbl_create_chatTableAdapter1 = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_DatasetTableAdapters.tbl_create_chatTableAdapter();
            this.tbl_send_attachmentTableAdapter1 = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_DatasetTableAdapters.tbl_send_attachmentTableAdapter();
            this.tbl_send_messageTableAdapter1 = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_DatasetTableAdapters.tbl_send_messageTableAdapter();
            this.tbl_user_detailsTableAdapter1 = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_DatasetTableAdapters.tbl_user_detailsTableAdapter();
            this.tbl_video_callTableAdapter1 = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_DatasetTableAdapters.tbl_video_callTableAdapter();
            this.tbl_voice_callTableAdapter1 = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_DatasetTableAdapters.tbl_voice_callTableAdapter();
            this.tbl_user_detailsTableAdapter2 = new NO_NET_CHAT_SYSTEM___FINAL.No_Net_Chat_System_DatasetTableAdapters.tbl_user_detailsTableAdapter();
            this.btn_reset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_userdetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_Net_Chat_System_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modify User Details";
            // 
            // tbl_userdetails
            // 
            this.tbl_userdetails.AutoGenerateColumns = false;
            this.tbl_userdetails.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_userdetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tbl_userdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_userdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.contactnoDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.securityquestionsDataGridViewTextBoxColumn,
            this.securityanswerDataGridViewTextBoxColumn});
            this.tbl_userdetails.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tbluserdetailsBindingSource, "user_id", true));
            this.tbl_userdetails.DataSource = this.tbluserdetailsBindingSource;
            this.tbl_userdetails.Location = new System.Drawing.Point(-2, 347);
            this.tbl_userdetails.Name = "tbl_userdetails";
            this.tbl_userdetails.Size = new System.Drawing.Size(786, 213);
            this.tbl_userdetails.TabIndex = 4;
            this.tbl_userdetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tbl_userdetails_RowHeaderMouseClick);
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "User ID";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "full_name";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // contactnoDataGridViewTextBoxColumn
            // 
            this.contactnoDataGridViewTextBoxColumn.DataPropertyName = "contact_no";
            this.contactnoDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            this.contactnoDataGridViewTextBoxColumn.Name = "contactnoDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // securityquestionsDataGridViewTextBoxColumn
            // 
            this.securityquestionsDataGridViewTextBoxColumn.DataPropertyName = "security_questions";
            this.securityquestionsDataGridViewTextBoxColumn.HeaderText = "Security Question";
            this.securityquestionsDataGridViewTextBoxColumn.Name = "securityquestionsDataGridViewTextBoxColumn";
            // 
            // securityanswerDataGridViewTextBoxColumn
            // 
            this.securityanswerDataGridViewTextBoxColumn.DataPropertyName = "security_answer";
            this.securityanswerDataGridViewTextBoxColumn.HeaderText = "Security Answer";
            this.securityanswerDataGridViewTextBoxColumn.Name = "securityanswerDataGridViewTextBoxColumn";
            this.securityanswerDataGridViewTextBoxColumn.Visible = false;
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
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.BackColor = System.Drawing.Color.White;
            this.lbl_fullname.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fullname.Location = new System.Drawing.Point(15, 123);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(74, 17);
            this.lbl_fullname.TabIndex = 5;
            this.lbl_fullname.Text = "Full Name";
            // 
            // lbl_dateofbirth
            // 
            this.lbl_dateofbirth.AutoSize = true;
            this.lbl_dateofbirth.BackColor = System.Drawing.Color.White;
            this.lbl_dateofbirth.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateofbirth.Location = new System.Drawing.Point(15, 215);
            this.lbl_dateofbirth.Name = "lbl_dateofbirth";
            this.lbl_dateofbirth.Size = new System.Drawing.Size(89, 17);
            this.lbl_dateofbirth.TabIndex = 5;
            this.lbl_dateofbirth.Text = "Date of Birth";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.BackColor = System.Drawing.Color.White;
            this.lbl_department.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_department.Location = new System.Drawing.Point(367, 123);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(85, 17);
            this.lbl_department.TabIndex = 5;
            this.lbl_department.Text = "Department";
            // 
            // lbl_contactnumber
            // 
            this.lbl_contactnumber.AutoSize = true;
            this.lbl_contactnumber.BackColor = System.Drawing.Color.White;
            this.lbl_contactnumber.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contactnumber.Location = new System.Drawing.Point(367, 215);
            this.lbl_contactnumber.Name = "lbl_contactnumber";
            this.lbl_contactnumber.Size = new System.Drawing.Size(115, 17);
            this.lbl_contactnumber.TabIndex = 5;
            this.lbl_contactnumber.Text = "Contact Number";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullname.Location = new System.Drawing.Point(114, 120);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(232, 25);
            this.txt_fullname.TabIndex = 0;
            // 
            // txt_dateofbirth
            // 
            this.txt_dateofbirth.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dateofbirth.Location = new System.Drawing.Point(117, 212);
            this.txt_dateofbirth.Name = "txt_dateofbirth";
            this.txt_dateofbirth.Size = new System.Drawing.Size(229, 25);
            this.txt_dateofbirth.TabIndex = 2;
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
            this.cbox_department.Location = new System.Drawing.Point(504, 120);
            this.cbox_department.Name = "cbox_department";
            this.cbox_department.Size = new System.Drawing.Size(244, 25);
            this.cbox_department.TabIndex = 1;
            // 
            // txt_contactnumber
            // 
            this.txt_contactnumber.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contactnumber.Location = new System.Drawing.Point(504, 212);
            this.txt_contactnumber.Mask = "000000000";
            this.txt_contactnumber.Name = "txt_contactnumber";
            this.txt_contactnumber.Size = new System.Drawing.Size(244, 25);
            this.txt_contactnumber.TabIndex = 3;
            this.txt_contactnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contactnumber_KeyPress);
            // 
            // btn_modifydetails
            // 
            this.btn_modifydetails.BackColor = System.Drawing.Color.White;
            this.btn_modifydetails.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifydetails.ForeColor = System.Drawing.Color.Green;
            this.btn_modifydetails.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.tick_icon;
            this.btn_modifydetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modifydetails.Location = new System.Drawing.Point(140, 252);
            this.btn_modifydetails.Name = "btn_modifydetails";
            this.btn_modifydetails.Size = new System.Drawing.Size(159, 41);
            this.btn_modifydetails.TabIndex = 4;
            this.btn_modifydetails.Text = "     Modify Details";
            this.btn_modifydetails.UseVisualStyleBackColor = false;
            this.btn_modifydetails.Click += new System.EventHandler(this.btn_modifydetails_Click);
            // 
            // btn_deleteuser
            // 
            this.btn_deleteuser.BackColor = System.Drawing.Color.White;
            this.btn_deleteuser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteuser.ForeColor = System.Drawing.Color.Red;
            this.btn_deleteuser.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.deleteuser_icon;
            this.btn_deleteuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteuser.Location = new System.Drawing.Point(305, 252);
            this.btn_deleteuser.Name = "btn_deleteuser";
            this.btn_deleteuser.Size = new System.Drawing.Size(159, 41);
            this.btn_deleteuser.TabIndex = 5;
            this.btn_deleteuser.Text = "     Delete User";
            this.btn_deleteuser.UseVisualStyleBackColor = false;
            this.btn_deleteuser.Click += new System.EventHandler(this.btn_deleteuser_Click);
            // 
            // btn_resetpassword
            // 
            this.btn_resetpassword.BackColor = System.Drawing.Color.White;
            this.btn_resetpassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetpassword.ForeColor = System.Drawing.Color.Olive;
            this.btn_resetpassword.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.resetpassword_icon;
            this.btn_resetpassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_resetpassword.Location = new System.Drawing.Point(470, 252);
            this.btn_resetpassword.Name = "btn_resetpassword";
            this.btn_resetpassword.Size = new System.Drawing.Size(172, 41);
            this.btn_resetpassword.TabIndex = 6;
            this.btn_resetpassword.Text = "         Reset Password";
            this.btn_resetpassword.UseVisualStyleBackColor = false;
            this.btn_resetpassword.Click += new System.EventHandler(this.btn_resetpassword_Click);
            // 
            // txt_userid
            // 
            this.txt_userid.Location = new System.Drawing.Point(138, 110);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(100, 20);
            this.txt_userid.TabIndex = 11;
            this.txt_userid.Visible = false;
            // 
            // txt_resetpassword
            // 
            this.txt_resetpassword.Location = new System.Drawing.Point(260, 110);
            this.txt_resetpassword.Name = "txt_resetpassword";
            this.txt_resetpassword.Size = new System.Drawing.Size(110, 20);
            this.txt_resetpassword.TabIndex = 12;
            this.txt_resetpassword.Visible = false;
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
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.BackColor = System.Drawing.Color.White;
            this.lbl_search.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.Location = new System.Drawing.Point(15, 313);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(55, 17);
            this.lbl_search.TabIndex = 5;
            this.lbl_search.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(79, 310);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(188, 25);
            this.txt_search.TabIndex = 7;
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // tbl_create_chatTableAdapter1
            // 
            this.tbl_create_chatTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_send_attachmentTableAdapter1
            // 
            this.tbl_send_attachmentTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_send_messageTableAdapter1
            // 
            this.tbl_send_messageTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_user_detailsTableAdapter1
            // 
            this.tbl_user_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_video_callTableAdapter1
            // 
            this.tbl_video_callTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_voice_callTableAdapter1
            // 
            this.tbl_voice_callTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_user_detailsTableAdapter2
            // 
            this.tbl_user_detailsTableAdapter2.ClearBeforeFill = true;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.White;
            this.btn_reset.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Teal;
            this.btn_reset.Image = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.clear_icon;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(273, 306);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(113, 32);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "       Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 26);
            this.menuStrip1.TabIndex = 15;
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
            // frm_modifyuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NO_NET_CHAT_SYSTEM___FINAL.Properties.Resources.White_Wallpaper_HD_Background_Free;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_resetpassword);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.btn_resetpassword);
            this.Controls.Add(this.btn_deleteuser);
            this.Controls.Add(this.btn_modifydetails);
            this.Controls.Add(this.txt_contactnumber);
            this.Controls.Add(this.cbox_department);
            this.Controls.Add(this.txt_dateofbirth);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.lbl_contactnumber);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.lbl_dateofbirth);
            this.Controls.Add(this.lbl_fullname);
            this.Controls.Add(this.tbl_userdetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_modifyuser";
            this.Text = "Modify User Details";
            this.Load += new System.EventHandler(this.frm_modifyuser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_userdetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_Net_Chat_System_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tbl_userdetails;
        private No_Net_Chat_System_Dataset no_Net_Chat_System_Dataset;
        private System.Windows.Forms.BindingSource tbluserdetailsBindingSource;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.Label lbl_dateofbirth;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Label lbl_contactnumber;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.DateTimePicker txt_dateofbirth;
        private System.Windows.Forms.ComboBox cbox_department;
        private System.Windows.Forms.MaskedTextBox txt_contactnumber;
        private System.Windows.Forms.Button btn_modifydetails;
        private System.Windows.Forms.Button btn_deleteuser;
        private System.Windows.Forms.Button btn_resetpassword;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.TextBox txt_resetpassword;
        private No_Net_Chat_System_DatasetTableAdapters.tbl_create_chatTableAdapter tbl_create_chatTableAdapter1;
        private No_Net_Chat_System_DatasetTableAdapters.tbl_send_attachmentTableAdapter tbl_send_attachmentTableAdapter1;
        private No_Net_Chat_System_DatasetTableAdapters.tbl_send_messageTableAdapter tbl_send_messageTableAdapter1;
        private No_Net_Chat_System_DatasetTableAdapters.tbl_user_detailsTableAdapter tbl_user_detailsTableAdapter1;
        private No_Net_Chat_System_DatasetTableAdapters.tbl_video_callTableAdapter tbl_video_callTableAdapter1;
        private No_Net_Chat_System_DatasetTableAdapters.tbl_voice_callTableAdapter tbl_voice_callTableAdapter1;
        private No_Net_Chat_System_DatasetTableAdapters.tbl_user_detailsTableAdapter tbl_user_detailsTableAdapter2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn securityquestionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn securityanswerDataGridViewTextBoxColumn;
    }
}