using MySql.Data.MySqlClient;
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
    public partial class frm_changepassword : Form
    {
        public frm_changepassword()
        {
            InitializeComponent();
            
        }
        string hash = "p@ssW0rD";

        private void frm_changepassword_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            lbl_userid.Text = frm_createchat.passinguserid;
            int uuid;
            int.TryParse(lbl_userid.Text, out uuid);
            string constring = "datasource=localhost;port=3306;username=root;password=";
            string query = "select * from nonet_chat_system.tbl_user_details where user_id='" + uuid + "' ;";
            MySqlConnection condatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(query, condatabase);
            MySqlDataReader myreader;
            try
            {
                condatabase.Open();
                myreader = cmdDatabase.ExecuteReader();

                while (myreader.Read())
                {
                    string name = myreader.GetString("password");
                    lbl_oldpassword.Text = name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btn_changepassword_Click(object sender, EventArgs e)
        {
            if (txt_newpassword.Text == "")
            {
                txt_newpassword.Focus();
                errorProvider1.SetError(txt_newpassword, "Please enter the new Password");
            }
            else if (txt_confirmnewpassword.Text == "")
            {
                txt_confirmnewpassword.Focus();
                errorProvider2.SetError(txt_confirmnewpassword, "Please confirm the new Password");
            }
            else if (txt_newpassword.Text == txt_confirmnewpassword.Text)
            {
                byte[] data = UTF8Encoding.UTF8.GetBytes(txt_confirmnewpassword.Text);
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

                    int uuid;
                int.TryParse(lbl_userid.Text, out uuid);

                tbl_user_detailsTableAdapter1.UpdateQueryForChangePassword(lbl_encrypttext.Text, uuid);

                MessageBox.Show("Password has been successfully changed!");

                frm_changepassword frm = new frm_changepassword();
                frm.Show();
                this.Hide();

            }
            else
            {

                MessageBox.Show("Password has not been changed successfully!");

            }
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_oldpassword.Text = null;
            txt_newpassword.Text = null;
            txt_confirmnewpassword.Text = null;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_checkpassword_Click(object sender, EventArgs e)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txt_oldpassword.Text);
            using (MD5CryptoServiceProvider mdS = new MD5CryptoServiceProvider())
            {
                byte[] keys = mdS.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                   
                    txt_oldpassword.Text = Convert.ToBase64String(results, 0, results.Length);
                }

                if (txt_oldpassword.Text == "")
                {
                   
                    txt_oldpassword.Focus();
                    errorProvider3.SetError(txt_oldpassword, "Please provide your current password.");
                }
                else if (txt_oldpassword.Text == lbl_oldpassword.Text)
                {

                    lbl_oldpass.Visible = false;
                    txt_oldpassword.Visible = false;
                    btn_checkpassword.Visible = false;
                    lbl_newpassword.Visible = true;
                    txt_newpassword.Visible = true;
                    lbl_confirmnewpassword.Visible = true;
                    txt_confirmnewpassword.Visible = true;
                    btn_changepassword.Visible = true;


                }
                else if(txt_oldpassword.Text != lbl_oldpassword.Text)
                {
                    txt_oldpassword.Text = null;
                    txt_oldpassword.Focus();
                    errorProvider4.SetError(txt_oldpassword, "Please provide the correct password.");
                }
                
            }
        }
    }
}
