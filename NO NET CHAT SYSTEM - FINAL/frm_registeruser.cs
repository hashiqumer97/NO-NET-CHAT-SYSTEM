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
    /*Author - Hashiq Umer (UOB 1821715)*/
    public partial class frm_registeruser : Form
    {
        public frm_registeruser()
        {
            InitializeComponent();
        }

        string hash = "p@ssW0rD";

        private void btn_register_Click(object sender, EventArgs e)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txt_password.Text);
            using (MD5CryptoServiceProvider mdS = new MD5CryptoServiceProvider())
            {
                byte[] keys = mdS.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    lbl_encrypttext.Text = Convert.ToBase64String(results, 0, results.Length);

                }
            }

            if (string.IsNullOrEmpty(txt_fullname.Text))
                {
                   
                    txt_fullname.Focus();
                    errorProvider1.SetError(txt_fullname, "Please enter your full name.");
                }
               

            else if (string.IsNullOrEmpty(txt_dob.Text))
            {

                txt_dob.Focus();
                errorProvider2.SetError(txt_dob, "Please enter your date of birth.");
            }
           
             else  if (string.IsNullOrEmpty(cbox_department.Text))
            {

                cbox_department.Focus();
                errorProvider3.SetError(cbox_department, "Please enter your department.");
            }
           
           
            else if (txt_contactno.Text == string.Empty)
            {

                txt_contactno.Focus();
                errorProvider4.SetError(txt_contactno, "Please enter your contact number.");
            }
            
            else if (string.IsNullOrEmpty(txt_username.Text))
            {

                txt_username.Focus();
                errorProvider5.SetError(txt_username, "Please enter the username.");
            }
           

            else if (string.IsNullOrEmpty(txt_password.Text))
            {

                txt_password.Focus();
                errorProvider6.SetError(txt_password, "Please enter the password.");
            }
            else if (string.IsNullOrEmpty(cbox_securityquestions.Text))
            {

                cbox_securityquestions.Focus();
                errorProvider7.SetError(cbox_securityquestions, "Please enter the security question.");
            }
            else if (string.IsNullOrEmpty(txt_securityanswer.Text))
            {

                txt_securityanswer.Focus();
                errorProvider8.SetError(txt_securityanswer, "Please enter the security answer.");
            }
            else
            {

            int contact;
            int.TryParse(txt_contactno.Text, out contact);
            tbl_user_detailsTableAdapter1.InsertQueryForUserDetails(txt_fullname.Text, txt_dob.Value.Date, cbox_department.SelectedItem.ToString(), contact, txt_username.Text, lbl_encrypttext.Text, cbox_securityquestions.SelectedItem.ToString(), txt_securityanswer.Text);

            
            MessageBox.Show("You have successfully registered!");
                this.Close();

            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_fullname.Clear();
            cbox_department.SelectedItem = null;
            txt_dob.ResetText();
            txt_contactno.Clear();
            txt_username.Clear();
            txt_password.Clear();
            cbox_securityquestions.SelectedItem = null;
            txt_securityanswer.Clear();

        }

        private void txt_contactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && txt_contactno.Text.Length > 10)
            {

                e.Handled = true;

            }
            

        }

        private void frm_registeruser_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            this.cbox_department.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbox_securityquestions.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
