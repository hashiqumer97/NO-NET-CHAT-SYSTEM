using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NO_NET_CHAT_SYSTEM___FINAL;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace NO_NET_CHAT_SYSTEM___FINAL
{
    public partial class frm_attachment : Form
    {
        private TcpClient client;
        public StreamReader STR;

        public StreamWriter STW;

        public string receive;
        public string TextToSend;

        public frm_attachment()
        {
            InitializeComponent();
            timer2.Start();
            btn_encryptsend.Enabled = false;
            btn_decryptsend.Enabled = false;
            btn_sendattachment.Enabled = false;
            btn_encrypt.Enabled = false;
            btn_decrypt.Enabled = false;
            btn_saveattachment.Enabled = false;
            
        }

        string hash = "p@ssW0rD";

        private void frm_attachment_Load(object sender, EventArgs e)
        {

            MaximizeBox = false;
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            lbl_username.Text = frm_chatwindow.passinguserid;
            txt_serverip.Text = frm_createchat.passingipaddress;
            txt_serverport.Text = frm_createchat.passingattachport;
            txt_clientip.Text = frm_createchat.passingipaddress;
            txt_clientport.Text = frm_createchat.passingattachport;
            lbl_username.Text = frm_createchat.passinguserid;


            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(txt_clientip.Text), int.Parse(txt_clientport.Text));
            try
            {
                client.Connect(IpEnd);

                if (client.Connected)
                {
                    btn_start.Enabled = false;
                    lbl_receiveattachment.AppendText("Successfully Connected to the Attachment Feature!" + "\n" + Environment.NewLine);
                    STR = new StreamReader(client.GetStream());
                    STW = new StreamWriter(client.GetStream());

                    STW.AutoFlush = true;

                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;

                }




            }
            catch (Exception)
            {

            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer2.Start();
        }

        private void btn_oppenattachment_Click(object sender, EventArgs e)
        {
            
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text|*.txt|All|*.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               

                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    btn_encryptsend.Enabled = true;
                    btn_decryptsend.Enabled = true;
                    btn_sendattachment.Enabled = true;
                    btn_decrypt.Enabled = false;
                    btn_encrypt.Enabled = false;
                    btn_saveattachment.Enabled = false;
                    lbl_attachment.Text = filetext;

                    byte[] data = UTF8Encoding.UTF8.GetBytes(lbl_attachment.Text);
                    using (MD5CryptoServiceProvider mdS = new MD5CryptoServiceProvider())
                    {
                        byte[] keys = mdS.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                        using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                        {
                            ICryptoTransform transform = tripDes.CreateEncryptor();
                            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                            lbl_attachment.Text = Convert.ToBase64String(results, 0, results.Length);
                            
                        }
                    }

                }

            }
        }

        private void btn_sendattachment_Click(object sender, EventArgs e)
        {
           
           

            if (lbl_attachment.Text != "")
            {
                lbl_receiveattachment.Text = null;
                btn_decrypt.Visible = true;
                btn_encrypt.Visible = false;
                btn_decrypt.Enabled = true;
                btn_encrypt.Enabled = true;
                btn_saveattachment.Enabled = true;
                TextToSend = lbl_attachment.Text;

                backgroundWorker2.RunWorkerAsync();

                int uuid;
                int.TryParse(lbl_username.Text, out uuid);

                tbl_send_attachmentTableAdapter1.InsertQueryForSendAttachment(txt_chatdate.Value.Date, lbl_time.Text, uuid);
                
            }

            lbl_attachment.Text = "";

            
        }

        private void btn_saveattachment_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                System.IO.File.WriteAllText(sfd.FileName, lbl_receiveattachment.Text);

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {

                    receive = STR.ReadLine();


                    this.lbl_receiveattachment.Invoke(new MethodInvoker(delegate ()
                    {
                        btn_decrypt.Visible = true;
                        btn_encrypt.Visible = false;
                        btn_decrypt.Enabled = true;
                        btn_encrypt.Enabled = true;
                        btn_saveattachment.Enabled = true;
                        lbl_receiveattachment.Text = null;
                        lbl_receiveattachment.AppendText(receive + "\n");
                        
                       


                    }));
                    receive = "";




                }
                catch (Exception)
                {
                   // MessageBox.Show(ex.Message.ToString());

                }


            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(TextToSend);


                this.lbl_receiveattachment.Invoke(new MethodInvoker(delegate ()
                {
                    btn_decrypt.Visible = true;
                    btn_encrypt.Visible = false;
                    btn_decrypt.Enabled = true;
                    btn_encrypt.Enabled = true;
                    btn_saveattachment.Enabled = true;
                    lbl_receiveattachment.Text = null;
                    lbl_receiveattachment.AppendText(TextToSend + "\n");


                }));


            }
            else
            {

                MessageBox.Show("Sending Failed!");

            }

            backgroundWorker2.CancelAsync();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            lbl_receiveattachment.AppendText("Wait for a user to get connected!" + "\n" + Environment.NewLine);
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(txt_serverport.Text));

            listener.Start();
            client = listener.AcceptTcpClient();
            lbl_receiveattachment.AppendText("A user has been connected to the attachment feature" + "\n" + Environment.NewLine);
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());

            STW.AutoFlush = true;

            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            btn_encrypt.Visible = true;
            btn_decrypt.Visible = false;
            
            byte[] data = Convert.FromBase64String(lbl_receiveattachment.Text);
            using (MD5CryptoServiceProvider mdS = new MD5CryptoServiceProvider())
            {
                byte[] keys = mdS.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    lbl_receiveattachment.Text = UTF8Encoding.UTF8.GetString(results);
                    

                }
            }
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            btn_decrypt.Visible = true;
            btn_encrypt.Visible = false;
           
            byte[] data = UTF8Encoding.UTF8.GetBytes(lbl_receiveattachment.Text);
            using (MD5CryptoServiceProvider mdS = new MD5CryptoServiceProvider())
            {
                byte[] keys = mdS.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    lbl_receiveattachment.Text = Convert.ToBase64String(results, 0, results.Length);
                    

                }
            }
        }

        private void btn_encryptsend_Click(object sender, EventArgs e)
        {
            btn_decryptsend.Visible = true;
            btn_encryptsend.Visible = false;
            btn_sendattachment.Enabled = true;
            byte[] data = UTF8Encoding.UTF8.GetBytes(lbl_attachment.Text);
            using (MD5CryptoServiceProvider mdS = new MD5CryptoServiceProvider())
            {
                byte[] keys = mdS.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    lbl_attachment.Text = Convert.ToBase64String(results, 0, results.Length);
                    
                }
            }
        }

        private void btn_decryptsend_Click(object sender, EventArgs e)
        {
            btn_encryptsend.Visible = true;
            btn_decryptsend.Visible = false;
            btn_sendattachment.Enabled = false;
            byte[] data = Convert.FromBase64String(lbl_attachment.Text);
            using (MD5CryptoServiceProvider mdS = new MD5CryptoServiceProvider())
            {
                byte[] keys = mdS.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    lbl_attachment.Text = UTF8Encoding.UTF8.GetString(results);


                }
            }
        }
    }
}
