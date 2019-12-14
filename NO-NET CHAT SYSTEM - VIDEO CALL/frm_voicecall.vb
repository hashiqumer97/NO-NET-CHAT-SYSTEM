Imports System.Runtime.InteropServices


Public Class frm_voicecall
    Private Const APPCOMMAND_VOLUME_MUTE = &H80000
    Private Const APPCOMNAND_VOLUME_UP = &HA0000
    Private Const APPCOMMAND_VOLUME_DOWN = &H90000
    Private Const WM_APPCOMAND = &H319
    <DllImport("user32.dll")> Public Shared Function SendMessageW(ByVal hwnd As IntPtr, ByVal mag As Integer, ByVal y As IntPtr, ByVal x As Integer) As Long
    End Function
    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click

        btn_endcall.Enabled = True
        btn_connect.Enabled = False

        AxVideoChatReceiver1.ReceiveAudioStream = True
        AxVideoChatReceiver1.ReceiveVideoStream = False

        If (AxVideoChatReceiver1.Listen("127.0.0.1", 2000)) Then
            AxVideoChatReceiver1.Listen("127.0.0.1", 2000)
        Else
            MessageBox.Show("You are not connected to the designated network!")
        End If



    End Sub

    Private Sub frm_voicecall_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MaximizeBox = False
        btn_endcall.Enabled = False

        Timer1.Start()
        lbl_time.Text = DateTime.Now.ToLongTimeString()

        lbl_date.Text = DateTime.Now.ToLongDateString()

        AxVideoChatSender1.VideoDevice = 0
        AxVideoChatSender1.AudioDevice = 0
        AxVideoChatSender1.VideoFormat = 0
        AxVideoChatSender1.FrameRate = 15
        AxVideoChatSender1.VideoBitrate = 128000
        AxVideoChatSender1.AudioComplexity = 0
        AxVideoChatSender1.AudioQuality = 50
        AxVideoChatSender1.SendAudioStream = True
        AxVideoChatSender1.SendVideoStream = False


        AxVideoChatSender1.ConferenceNumber = 5000
        AxVideoChatSender1.ConferenceUserID = 10000

        AxVideoChatSender1.Connect("127.0.0.1", 2000)

    End Sub

    Private Sub btn_endcall_Click(sender As Object, e As EventArgs) Handles btn_endcall.Click

        AxVideoChatSender1.SendAudioStream = False
        AxVideoChatReceiver1.ReceiveAudioStream = False

        Me.Close()

    End Sub

    Private Sub btn_volumeup_Click(sender As Object, e As EventArgs) Handles btn_volumeup.Click

        SendMessageW(Me.Handle, WM_APPCOMAND, Me.Handle, New IntPtr(APPCOMNAND_VOLUME_UP))

    End Sub

    Private Sub btn_mute_Click(sender As Object, e As EventArgs) Handles btn_mute.Click

        SendMessageW(Me.Handle, WM_APPCOMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_MUTE))

    End Sub

    Private Sub btn_volumedown_Click(sender As Object, e As EventArgs) Handles btn_volumedown.Click

        SendMessageW(Me.Handle, WM_APPCOMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_DOWN))

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lbl_time.Text = DateTime.Now.ToLongTimeString()
        Timer1.Start()

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btn_connectcall_Click(sender As Object, e As EventArgs)

    End Sub
End Class