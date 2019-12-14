using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NO_NET_CHAT_SYSTEM___FINAL
{
    public partial class frm_modifyuser : Form
    {
        public frm_modifyuser()
        {
            InitializeComponent();
        }

        string hash = "p@ssW0rD";

        private void frm_modifyuser_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            foreach (DataGridViewColumn c in tbl_userdetails.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 11.25F, GraphicsUnit.Pixel);
            }
            // TODO: This line of code loads data into the 'no_Net_Chat_System_Dataset.tbl_user_details' table. You can move, or remove it, as needed.
            this.cbox_department.DropDownStyle = ComboBoxStyle.DropDownList;
            this.tbl_user_detailsTableAdapter2.Fill(this.no_Net_Chat_System_Dataset.tbl_user_details);

        }

        private void tbl_userdetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.tbl_userdetails.SelectionMode =
            DataGridViewSelectionMode.RowHeaderSelect;
            this.tbl_userdetails.Rows[e.RowIndex].Selected = true;

            txt_userid.Text = tbl_userdetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_fullname.Text = tbl_userdetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_dateofbirth.Text = tbl_userdetails.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbox_department.Text = tbl_userdetails.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_contactnumber.Text = tbl_userdetails.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_resetpassword.Text = tbl_userdetails.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void txt_contactnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && txt_contactnumber.Text.Length >= 10)
            {

                e.Handled = true;

            }
        }

        private void btn_resetpassword_Click(object sender, EventArgs e)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txt_resetpassword.Text);
            using (MD5CryptoServiceProvider mdS = new MD5CryptoServiceProvider())
            {
                byte[] keys = mdS.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    txt_resetpassword.Text = Convert.ToBase64String(results, 0, results.Length);

                }
            }

            int uuid;
            int.TryParse(txt_userid.Text, out uuid);

            tbl_user_detailsTableAdapter2.UpdateQueryForChangePassword(txt_resetpassword.Text, uuid);

            MessageBox.Show("Password has been successfully reset!");

            this.tbl_user_detailsTableAdapter2.Fill(this.no_Net_Chat_System_Dataset.tbl_user_details);
            
        }

        private void btn_modifydetails_Click(object sender, EventArgs e)
        {
            if (txt_fullname.Text == "")
            {
                txt_fullname.Focus();
                errorProvider1.SetError(txt_fullname, "Please enter the full name of the user");
            }
            else if (cbox_department.Text == "")
            {
                cbox_department.Focus();
                errorProvider2.SetError(cbox_department, "Please select the department");
            }
            else if (txt_contactnumber.Text == "")
            {
                txt_contactnumber.Focus();
                errorProvider3.SetError(txt_contactnumber, "Please enter the user's contact number");
            }
            else
            {
                int uuid;
                int.TryParse(txt_userid.Text, out uuid);
                int contact;
                int.TryParse(txt_contactnumber.Text, out contact);

                tbl_user_detailsTableAdapter2.UpdateQueryForUserDetails(txt_fullname.Text, txt_dateofbirth.Value.Date, cbox_department.SelectedItem.ToString(), contact, uuid);

                MessageBox.Show("User Details has been successfully modified!");

                this.tbl_user_detailsTableAdapter2.Fill(this.no_Net_Chat_System_Dataset.tbl_user_details);

                txt_search.Text = null;
                txt_fullname.Text = null;
                txt_dateofbirth.ResetText();
                cbox_department.SelectedItem = null;
                txt_contactnumber.Text = null;
                tbl_userdetails.DataSource = tbl_user_detailsTableAdapter2.GetDataBySearchUser(txt_search.Text + "%");
            }
        }

        private void btn_deleteuser_Click(object sender, EventArgs e)
        {
            if (txt_fullname.Text == "")
            {
                txt_fullname.Focus();
                errorProvider1.SetError(txt_fullname, "Please enter the full name of the user");
            }
            else if (cbox_department.Text == "")
            {
                cbox_department.Focus();
                errorProvider2.SetError(cbox_department, "Please select the department");
            }
            else if (txt_contactnumber.Text == "")
            {
                txt_contactnumber.Focus();
                errorProvider3.SetError(txt_contactnumber, "Please enter the user's contact number");
            }
            else
            {

                int uuid;
                int.TryParse(txt_userid.Text, out uuid);
                tbl_user_detailsTableAdapter2.DeleteQueryForUser(uuid);
                tbl_create_chatTableAdapter1.DeleteQueryForUser(uuid);
                tbl_send_messageTableAdapter1.DeleteQueryForUser(uuid);
                tbl_video_callTableAdapter1.DeleteQueryForUser(uuid);
                tbl_voice_callTableAdapter1.DeleteQueryForUser(uuid);
                tbl_send_attachmentTableAdapter1.DeleteQueryForUser(uuid);

                MessageBox.Show("User Details has been successfully deleted!");

                this.tbl_user_detailsTableAdapter2.Fill(this.no_Net_Chat_System_Dataset.tbl_user_details);

                txt_search.Text = null;
                txt_fullname.Text = null;
                txt_dateofbirth.ResetText();
                cbox_department.SelectedItem = null;
                txt_contactnumber.Text = null;
                tbl_userdetails.DataSource = tbl_user_detailsTableAdapter2.GetDataBySearchUser(txt_search.Text + "%");
            }
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_search.TextLength > 0)
            {
                
                tbl_userdetails.DataSource = tbl_user_detailsTableAdapter2.GetDataBySearchUser(txt_search.Text + "%");
            }
           
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_search.Text = null;
            txt_fullname.Text = null;
            txt_dateofbirth.ResetText();
            cbox_department.SelectedItem = null;
            txt_contactnumber.Text = null;
            tbl_userdetails.DataSource = tbl_user_detailsTableAdapter2.GetDataBySearchUser(txt_search.Text + "%");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
