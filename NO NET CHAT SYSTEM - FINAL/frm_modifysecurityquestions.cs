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
    public partial class frm_modifysecurityquestions : Form
    {
        public frm_modifysecurityquestions()
        {
            InitializeComponent();
        }

        string hash = "p@ssW0rD";
        private void frm_modifysecurityquestions_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            this.cbox_securityquestion.DropDownStyle = ComboBoxStyle.DropDownList;
            lbl_userid.Text = frm_createchat.passinguserid;
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txt_securityanswer.Text);
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
            if (cbox_securityquestion.Text == "")
            {
                cbox_securityquestion.Focus();
                errorProvider1.SetError(cbox_securityquestion, "Please select the security question");
            }
            else if (txt_securityanswer.Text == "")
            {
                txt_securityanswer.Focus();
                errorProvider2.SetError(txt_securityanswer, "Please enter the security answer");
            }
            else
            {
                int uuid;
                int.TryParse(lbl_userid.Text, out uuid);

                tbl_user_detailsTableAdapter1.UpdateQueryForModifySecurityQuestions(cbox_securityquestion.SelectedItem.ToString(), lbl_encrypttext.Text, uuid);

                MessageBox.Show("The answer for your security question has been successfully modified!");

                frm_modifysecurityquestions frm = new frm_modifysecurityquestions();
                frm.Show();
                this.Hide();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cbox_securityquestion.SelectedItem = null;
            txt_securityanswer.Clear();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
