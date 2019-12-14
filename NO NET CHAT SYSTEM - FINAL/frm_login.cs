using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using SimpleTCP;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace NO_NET_CHAT_SYSTEM___FINAL
    /*Author - Hashiq Umer (UOB 1821715)*/
{
    public partial class frm_login : Form
    {
        public static string passinguserid;
        public static string passingpassword;
        public static string passingdepartment;
        
        public frm_login()
        {
            InitializeComponent();
        }

        string hash = "p@ssW0rD";


        public void login(string username, string password)
        {
            if (txt_ipaddress.Text == "127.0.0.1")
            {
                try
                {
                    
                    if (tbl_user_detailsTableAdapter1.GetDataByLogin(username, password).Rows.Count == 1)
                    {
                        string role = tbl_user_detailsTableAdapter1.GetDataByLogin(username, password).Rows[0]["department"].ToString();

                        switch (role)
                        {
                            case "Research & Development":

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
                                            txtuid.Text = uid;
                                            string dept = myreader.GetString("department");
                                            lbl_department.Text = dept;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                        throw;
                                    }

                                    passingdepartment = lbl_department.Text;
                                    passinguserid = txtuid.Text;
                                    passingpassword = lbl_encrypttext.Text;
                                    frm_createchat frm = new frm_createchat();
                                     frm.Show();
                                     this.Hide();

                                    break;
                                    

                                }

                            case "Software Developers":

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
                                            txtuid.Text = uid;
                                            string dept = myreader.GetString("department");
                                            lbl_department.Text = dept;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                        throw;
                                    }
                                    passingdepartment = lbl_department.Text;
                                    passinguserid = txtuid.Text;
                                    frm_createchat frm = new frm_createchat();
                                    frm.Show();
                                    this.Hide();

                                    break;


                                }

                            case "QA":

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
                                            txtuid.Text = uid;
                                            string dept = myreader.GetString("department");
                                            lbl_department.Text = dept;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                        throw;
                                    }
                                    passingdepartment = lbl_department.Text;
                                    passinguserid = txtuid.Text;
                                    frm_createchat frm = new frm_createchat();
                                    frm.Show();
                                    this.Hide();

                                    break;


                                }

                            case "Team Lead":

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
                                            txtuid.Text = uid;
                                            string dept = myreader.GetString("department");
                                            lbl_department.Text = dept;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                        throw;
                                    }
                                    passingdepartment = lbl_department.Text;
                                    passinguserid = txtuid.Text;
                                    frm_createchat frm = new frm_createchat();
                                    frm.Show();
                                    this.Hide();

                                    break;


                                }


                            default:
                                MessageBox.Show("Invalid Role. Please contact the administrator");
                                break;
                        }
                    }

                    else
                    {
                        this.lbl_loginerror.Show();
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
                MessageBox.Show("You are not connected to the designated network!");
            }
            
        }

        private void btn_login_Click(object sender, EventArgs e)
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
            login(txt_username.Text, lbl_encrypttext.Text);
            
           
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    txt_ipaddress.Text = address.ToString();
                }

            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txtuid.Clear();
        }

        private void btn_ipaddress_Click(object sender, EventArgs e)
        {
            
           
            
        }

        private void btn_registeruser_Click(object sender, EventArgs e)
        {
            frm_registeruser frm = new frm_registeruser();
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_forgetpassword_Click(object sender, EventArgs e)
        {
            frm_forgetpassword frm = new frm_forgetpassword();
            frm.Show();
        }
    }

        
    }

