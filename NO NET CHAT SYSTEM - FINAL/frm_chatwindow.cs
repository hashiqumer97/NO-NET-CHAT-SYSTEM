using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace NO_NET_CHAT_SYSTEM___FINAL
{
    /*Author - Hashiq Umer (UOB 1821715)*/
    public partial class frm_chatwindow : Form
    {

        public static string passinguserid;
        
        private TcpClient client;
        public StreamReader STR;
        
        public StreamWriter STW;
        
        public string receive;
        public string TextToSend;
      

        public frm_chatwindow()
        {
            InitializeComponent();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    txt_serverip.Text = address.ToString();
                    txt_clientip.Text = address.ToString();

                }

            }
        }

        private void frm_chatwindow_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            txt_sendmessage.Text = frm_createchat.passingusername;
            txt_sendmessage.AppendText(" - ");
            lbl_username.Text = frm_createchat.passinguserid;
            timer1.Start();
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            lbl_date.Text = DateTime.Now.ToLongDateString();
            txt_serverport.Text = frm_createchat.passingportnumber;
            txt_clientport.Text = frm_createchat.passingportnumber;
            lbl_department.Text = frm_login.passingdepartment;


            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(txt_clientip.Text), int.Parse(txt_clientport.Text));
            try
            {
                client.Connect(IpEnd);

                if (client.Connected)
                {
                    btn_start.Enabled = false;
                    txt_receivemessage.AppendText("Successfully Connected to the Chat Server!" + "\n" + Environment.NewLine);
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

        private void btn_start_Click(object sender, EventArgs e)
        {

            txt_receivemessage.AppendText("Wait for a user to get connected!" + "\n" + Environment.NewLine);
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(txt_serverport.Text));

            listener.Start();
            client = listener.AcceptTcpClient();
            txt_receivemessage.AppendText("A user has been connected to the chat system" + "\n" + Environment.NewLine);
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            
            STW.AutoFlush = true;
            
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;



        }

        private void btn_connect_Click(object sender, EventArgs e)
        {


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {

                    receive = STR.ReadLine();
                   
                    
                    this.txt_receivemessage.Invoke(new MethodInvoker(delegate ()
                    {

                        txt_sendmessage.Text = frm_createchat.passingusername;
                        txt_sendmessage.AppendText(" - ");
                        txt_receivemessage.AppendText(receive + "\n" + Environment.NewLine);
                       

                    }));
                    receive = "";

                    


                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.Message.ToString());

                }


            }
        }



        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(TextToSend);
               
                
                this.txt_receivemessage.Invoke(new MethodInvoker(delegate ()
                {
                    txt_sendmessage.Text = frm_createchat.passingusername;
                    txt_sendmessage.AppendText(" - ");
                    txt_receivemessage.AppendText(TextToSend + "\n" + Environment.NewLine);
                   

                }));

               
            }
            else
            {

                MessageBox.Show("Sending Failed!");

            }

            backgroundWorker2.CancelAsync();
        }

        private void btn_sendmessage_Click(object sender, EventArgs e)
        {
            if (txt_sendmessage.Text != "")
            {

                TextToSend = txt_sendmessage.Text;
               
                backgroundWorker2.RunWorkerAsync();

                int uuid;
                int.TryParse(lbl_username.Text, out uuid);

                tbl_send_messageTableAdapter1.InsertQueryForSendMessage(txt_sendmessage.Text, txt_chatdate.Value.Date, lbl_time.Text, uuid);

            }

            txt_sendmessage.Text = "";
            



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btn_videocall_Click(object sender, EventArgs e)
        {

            int uuid;
            int.TryParse(lbl_username.Text, out uuid);

            tbl_video_callTableAdapter1.InsertQueryForVideoCall(txt_chatdate.Value.Date, lbl_time.Text, uuid);
            NO_NET_CHAT_SYSTEM___VIDEO_CALL.frm_videocall frm = new NO_NET_CHAT_SYSTEM___VIDEO_CALL.frm_videocall();
            frm.Show();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_receivemessage.AppendText("A user has left the chat system" + "\n" + Environment.NewLine);
            for (int i = Application.OpenForms.Count - 1; i != -1;)
            {
                Application.OpenForms[i].Dispose();
                break;
                
            }

            frm_login frm = new frm_login();
            frm.Show();
            this.Hide();



        }

        private void btn_voicecall_Click(object sender, EventArgs e)
        {
            int uuid;
            int.TryParse(lbl_username.Text, out uuid);

            tbl_voice_callTableAdapter1.InsertQueryForVoiceCall(txt_chatdate.Value.Date, lbl_time.Text, uuid);

            NO_NET_CHAT_SYSTEM___VIDEO_CALL.frm_voicecall frm = new NO_NET_CHAT_SYSTEM___VIDEO_CALL.frm_voicecall();
            frm.Show();
        }

        private void btn_sendattachment_Click(object sender, EventArgs e)
        {
            frm_attachment frm1 = new frm_attachment();
            frm1.Show();
            passinguserid = lbl_username.Text;
           
            
        }


        private void btn_savechat_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                System.IO.File.WriteAllText(sfd.FileName, txt_receivemessage.Text);

            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_changepassword frm = new frm_changepassword();
            frm.Show();
        }

        private void modifySecurityQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_modifysecurityquestions frm = new frm_modifysecurityquestions();
            frm.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbl_department.Text == "Team Lead")
            {
                resetUserPasswordToolStripMenuItem.Visible = true;
            }
        }

        private void resetUserPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_modifyuser frm = new frm_modifyuser();
            frm.Show();
        }
    }
}
