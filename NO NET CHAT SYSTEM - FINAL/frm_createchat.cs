using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NO_NET_CHAT_SYSTEM___FINAL
{
    /*Author - Hashiq Umer (UOB 1821715)*/
    public partial class frm_createchat : Form
    {
        public static string passingusername;
        public static string passinguserid;
        public static string passingportnumber;
        public static string passingipaddress;
        public static string passingattachport;
        public frm_createchat()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    txt_ipaddress.Text = address.ToString();
                    

                }

            }
        }

        private void frm_createchat_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            txt_userid.Text = frm_login.passinguserid;

            int uuid;
            int.TryParse(txt_userid.Text, out uuid);
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
                    string name = myreader.GetString("full_name");
                    lbl_name.Text = name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            this.cbox_purposeofchat.DropDownStyle = ComboBoxStyle.DropDownList;
            this.txt_portnumber.DropDownStyle = ComboBoxStyle.DropDownList;
            this.txt_attachport.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cbox_purposeofchat.SelectedItem = null;
        }

        private void btn_createchat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbox_purposeofchat.Text))
            {

                cbox_purposeofchat.Focus();
                errorProvider1.SetError(cbox_purposeofchat, "Please indicate the purpose of the chat.");
            }
            else if (string.IsNullOrEmpty(txt_portnumber.Text))
            {

                txt_portnumber.Focus();
                errorProvider2.SetError(txt_portnumber, "Please enter the designated port number.");

            }
            else if (string.IsNullOrEmpty(txt_attachport.Text))
            {

                txt_attachport.Focus();
                errorProvider3.SetError(txt_attachport, "Please enter the designated port number.");

            }

            else if (txt_portnumber.Text == txt_attachport.Text)
            {

                txt_attachport.Focus();
                txt_portnumber.Focus();
                errorProvider4.SetError(txt_attachport, "Please enter the designated port number for the attachment port number.");
                errorProvider5.SetError(txt_portnumber, "Please enter the designated port number for the send message port number.");

            }
            else
            {
                int uuuid;
                int.TryParse(txt_userid.Text, out uuuid);
                string constring = "datasource=localhost;port=3306;username=root;password=";
                string query = "select * from nonet_chat_system.tbl_user_details where user_id ='" + uuuid + "' ;";
                MySqlConnection condatabase = new MySqlConnection(constring);
                MySqlCommand cmdDatabase = new MySqlCommand(query, condatabase);
                MySqlDataReader myreader;
                try
                {
                    condatabase.Open();
                    myreader = cmdDatabase.ExecuteReader();

                    while (myreader.Read())
                    {
                        string username = myreader.GetString("username");
                        txtusername.Text = username;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }


                int uuid;
                int.TryParse(txt_userid.Text, out uuid);

                tbl_create_chatTableAdapter1.InsertQueryForCreateChat(cbox_purposeofchat.SelectedItem.ToString(), txt_dateofchat.Value.Date, uuid);

                passingusername = txtusername.Text;
                passinguserid = txt_userid.Text;
                passingportnumber = txt_portnumber.Text;
                passingipaddress = txt_ipaddress.Text;
                passingattachport = txt_attachport.Text;
                frm_chatwindow frm = new frm_chatwindow();
                frm.Show();
                this.Hide();
                

            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login frm = new frm_login();
            frm.Show();
            this.Hide();
        }

        private void txt_portnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {

                e.Handled = true;

            }
        }
    }
}
