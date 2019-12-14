<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_videocall
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_videocall))
        Me.AxVideoChatSender1 = New AxVideoChatSenderLib.AxVideoChatSender()
        Me.AxVideoChatReceiver1 = New AxVideoChatReceiverLib.AxVideoChatReceiver()
        Me.btn_listen = New System.Windows.Forms.Button()
        Me.btn_endcall = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_connect = New System.Windows.Forms.Button()
        CType(Me.AxVideoChatSender1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxVideoChatReceiver1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxVideoChatSender1
        '
        Me.AxVideoChatSender1.Enabled = True
        Me.AxVideoChatSender1.Location = New System.Drawing.Point(21, 89)
        Me.AxVideoChatSender1.Name = "AxVideoChatSender1"
        Me.AxVideoChatSender1.OcxState = CType(resources.GetObject("AxVideoChatSender1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoChatSender1.Size = New System.Drawing.Size(275, 211)
        Me.AxVideoChatSender1.TabIndex = 0
        '
        'AxVideoChatReceiver1
        '
        Me.AxVideoChatReceiver1.Enabled = True
        Me.AxVideoChatReceiver1.Location = New System.Drawing.Point(337, 89)
        Me.AxVideoChatReceiver1.Name = "AxVideoChatReceiver1"
        Me.AxVideoChatReceiver1.OcxState = CType(resources.GetObject("AxVideoChatReceiver1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoChatReceiver1.Size = New System.Drawing.Size(275, 211)
        Me.AxVideoChatReceiver1.TabIndex = 2
        '
        'btn_listen
        '
        Me.btn_listen.BackColor = System.Drawing.Color.White
        Me.btn_listen.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_listen.ForeColor = System.Drawing.Color.Green
        Me.btn_listen.Image = Global.NO_NET_CHAT_SYSTEM___VIDEO_CALL.My.Resources.Resources.start_icon
        Me.btn_listen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_listen.Location = New System.Drawing.Point(172, 306)
        Me.btn_listen.Name = "btn_listen"
        Me.btn_listen.Size = New System.Drawing.Size(286, 42)
        Me.btn_listen.TabIndex = 3
        Me.btn_listen.Text = "Start Video Call"
        Me.btn_listen.UseVisualStyleBackColor = False
        '
        'btn_endcall
        '
        Me.btn_endcall.BackColor = System.Drawing.Color.White
        Me.btn_endcall.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_endcall.ForeColor = System.Drawing.Color.Red
        Me.btn_endcall.Image = Global.NO_NET_CHAT_SYSTEM___VIDEO_CALL.My.Resources.Resources.end_icon
        Me.btn_endcall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_endcall.Location = New System.Drawing.Point(172, 397)
        Me.btn_endcall.Name = "btn_endcall"
        Me.btn_endcall.Size = New System.Drawing.Size(286, 41)
        Me.btn_endcall.TabIndex = 4
        Me.btn_endcall.Text = "End Video Call"
        Me.btn_endcall.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.BackColor = System.Drawing.Color.White
        Me.lbl_time.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(419, 34)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(63, 27)
        Me.lbl_time.TabIndex = 13
        Me.lbl_time.Text = "Time"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.White
        Me.lbl_date.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(82, 34)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(62, 27)
        Me.lbl_date.TabIndex = 14
        Me.lbl_date.Text = "Date"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(624, 26)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(61, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'btn_connect
        '
        Me.btn_connect.BackColor = System.Drawing.Color.White
        Me.btn_connect.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_connect.ForeColor = System.Drawing.Color.Olive
        Me.btn_connect.Image = Global.NO_NET_CHAT_SYSTEM___VIDEO_CALL.My.Resources.Resources.connect_icon
        Me.btn_connect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_connect.Location = New System.Drawing.Point(172, 354)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(286, 40)
        Me.btn_connect.TabIndex = 3
        Me.btn_connect.Text = "Connect Video Call"
        Me.btn_connect.UseVisualStyleBackColor = False
        Me.btn_connect.Visible = False
        '
        'frm_videocall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NO_NET_CHAT_SYSTEM___VIDEO_CALL.My.Resources.Resources.White_Wallpaper_HD_Background_Free
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.btn_endcall)
        Me.Controls.Add(Me.btn_connect)
        Me.Controls.Add(Me.btn_listen)
        Me.Controls.Add(Me.AxVideoChatReceiver1)
        Me.Controls.Add(Me.AxVideoChatSender1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_videocall"
        Me.Text = "Video Call"
        CType(Me.AxVideoChatSender1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxVideoChatReceiver1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxVideoChatSender1 As AxVideoChatSenderLib.AxVideoChatSender
    Friend WithEvents AxVideoChatReceiver1 As AxVideoChatReceiverLib.AxVideoChatReceiver
    Friend WithEvents btn_listen As Button
    Friend WithEvents btn_endcall As Button
    Friend WithEvents Timer1 As Timer
    Private WithEvents lbl_time As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_connect As Button
End Class
