Public Class frm_videocall

    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click

        btn_endcall.Enabled = True

        AxVideoChatReceiver1.ReceiveAudioStream = True
        AxVideoChatReceiver1.ReceiveVideoStream = True
        If (AxVideoChatReceiver1.Listen("127.0.0.1", 1500)) Then
            AxVideoChatReceiver1.Listen("127.0.0.1", 1500)
        Else
            MessageBox.Show("You are not connected to the designated network!")
        End If
    End Sub

    Private Sub btn_listen_Click(sender As Object, e As EventArgs) Handles btn_listen.Click

        AxVideoChatSender1.VideoDevice = 0
        AxVideoChatSender1.AudioDevice = 0
        AxVideoChatSender1.VideoFormat = 0
        AxVideoChatSender1.FrameRate = 15
        AxVideoChatSender1.VideoBitrate = 128000
        AxVideoChatSender1.AudioComplexity = 0
        AxVideoChatSender1.AudioQuality = 50
        AxVideoChatSender1.SendAudioStream = True
        AxVideoChatSender1.SendVideoStream = True

        AxVideoChatSender1.ConferenceNumber = 5000
        AxVideoChatSender1.ConferenceUserID = 10000

        AxVideoChatSender1.Connect("127.0.0.1", 1500)
        btn_listen.Visible = False
        btn_connect.Visible = True



    End Sub

    Private Sub btn_endcall_Click(sender As Object, e As EventArgs) Handles btn_endcall.Click

        Me.Close()
    End Sub

    Private Sub frm_videocall_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MaximizeBox = False
        Timer1.Start()
        lbl_time.Text = DateTime.Now.ToLongTimeString()

        lbl_date.Text = DateTime.Now.ToLongDateString()




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lbl_time.Text = DateTime.Now.ToLongTimeString()
        Timer1.Start()

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class
