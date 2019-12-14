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
    public partial class frm_forgetpassword : Form
    {
        public frm_forgetpassword()
        {
            InitializeComponent();
        }

        string hash = "p@ssW0rD";
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            usernameview(txt_username.Text);
        }

        public void usernameview(string username)
        {

            if (tbl_user_detailsTableAdapter1.GetDataByUsername(username).Rows.Count == 1)
            {

                string constring = "datasource=localhost;port=3306;username=root;password=";
                string query = "select * from nonet_chat_system.tbl_user_details where username='" + txt_username.Text + "' ;";
                MySqlConnection condatabase = new MySqlConnection(constring);
                MySqlCommand cmdDatabase = new MySqlCommand(query, condatabase);
                MySqlDataReader myreader;
                try
                {
                    condatabase.Open();
                    myreader = cmdDatabase.ExecuteReader();

                    while (myreader.Read())
                    {
                        string uid = myreader.GetInt32("user_id").ToString();
                        lbl_userid.Text = uid;
                        string name = myreader.GetString("security_answer");
                        lbl_encryptanswer.Text = name;
                        lbl_username.Visible = false;
                        txt_username.Visible = false;
                        btn_confirm.Visible = false;
                        lbl_securityquestion.Visible = true;
                        txt_securityquestion.Visible = true;
                        lbl_securityanswer.Visible = true;
                        txt_securityanswer.Visible = true;
                        btn_confirmanswer.Visible = true;
                        string question = myreader.GetString("security_questions");
                        txt_securityquestion.Text = question;
                        string answer = myreader.GetString("security_answer");
                        lbl_answer.Text = answer;

                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }

            }
            else
            {
                txt_username.Focus();
                errorProvider1.SetError(txt_username, "Username is incorrect, Please check again!");
                
            }


        }

        private void btn_confirmanswer_Click(object sender, EventArgs e)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txt_securityanswer.Text);
            using (MD5CryptoServiceProvider mdS = new MD5CryptoServiceProvider())
            {
                byte[] keys = mdS.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    
                    txt_securityanswer.Text = Convert.ToBase64String(results, 0, results.Length);
                }
            }
            if(txt_securityanswer.Text == "")
            {
                txt_securityanswer.Text = null;
                txt_securityanswer.Focus();
                errorProvider2.SetError(txt_securityanswer, "Please provide the answer.");
            }
           else if (txt_securityanswer.Text == lbl_encryptanswer.Text)
            {

                lbl_securityquestion.Visible = false;
                txt_securityquestion.Visible = false;
                lbl_securityanswer.Visible = false;
                txt_securityanswer.Visible = false;
                btn_confirmanswer.Visible = false;
                lbl_newpassword.Visible = true;
                txt_newpassword.Visible = true;
                lbl_confirmnewpassword.Visible = true;
                txt_confirmnewpassword.Visible = true;
                btn_confirmpassword.Visible = true;



            }
            else if(txt_securityanswer.Text != lbl_encryptanswer.Text)
            {
                txt_securityanswer.Text = null;
                txt_securityanswer.Focus();
                errorProvider6.SetError(txt_securityanswer, "Your answer is incorrect, please check again!");
            }
            {
                
                
            }
        }

        private void btn_confirmpassword_Click(object sender, EventArgs e)
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
            if (txt_newpassword.Text == "")
            {
                txt_newpassword.Focus();
                errorProvider3.SetError(txt_newpassword, "Please enter the new Password");
            }
            else if (txt_confirmnewpassword.Text == "")
            {
                txt_confirmnewpassword.Focus();
                errorProvider4.SetError(txt_confirmnewpassword, "Please confirm the new Password");
            }
            else if (txt_newpassword.Text == txt_confirmnewpassword.Text)
            {

                int uuid;
                int.TryParse(lbl_userid.Text, out uuid);

                tbl_user_detailsTableAdapter1.UpdateQueryForChangePassword(lbl_encrypttext.Text, uuid);

                MessageBox.Show("Password has been successfully changed!");
                this.Close();
            }
            else if(txt_newpassword.Text != txt_confirmnewpassword.Text)
            {
                txt_confirmnewpassword.Focus();
                errorProvider5.SetError(txt_confirmnewpassword, "Your new password is not matching, Please check again!");    
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_forgetpassword_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
