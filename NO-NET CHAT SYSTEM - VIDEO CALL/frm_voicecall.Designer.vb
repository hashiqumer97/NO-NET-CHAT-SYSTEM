<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_voicecall
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_voicecall))
        Me.AxVideoChatSender1 = New AxVideoChatSenderLib.AxVideoChatSender()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.btn_endcall = New System.Windows.Forms.Button()
        Me.btn_volumeup = New System.Windows.Forms.Button()
        Me.btn_mute = New System.Windows.Forms.Button()
        Me.btn_volumedown = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AxVideoChatReceiver1 = New AxVideoChatReceiverLib.AxVideoChatReceiver()
        CType(Me.AxVideoChatSender1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.AxVideoChatReceiver1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxVideoChatSender1
        '
        Me.AxVideoChatSender1.Enabled = True
        Me.AxVideoChatSender1.Location = New System.Drawing.Point(12, 118)
        Me.AxVideoChatSender1.Name = "AxVideoChatSender1"
        Me.AxVideoChatSender1.OcxState = CType(resources.GetObject("AxVideoChatSender1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoChatSender1.Size = New System.Drawing.Size(253, 193)
        Me.AxVideoChatSender1.TabIndex = 0
        Me.AxVideoChatSender1.Visible = False
        '
        'btn_connect
        '
        Me.btn_connect.BackColor = System.Drawing.Color.White
        Me.btn_connect.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_connect.ForeColor = System.Drawing.Color.Green
        Me.btn_connect.Image = Global.NO_NET_CHAT_SYSTEM___VIDEO_CALL.My.Resources.Resources.start_icon
        Me.btn_connect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_connect.Location = New System.Drawing.Point(158, 327)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(286, 42)
        Me.btn_connect.TabIndex = 5
        Me.btn_connect.Text = "Start Voice Call"
        Me.btn_connect.UseVisualStyleBackColor = False
        '
        'btn_endcall
        '
        Me.btn_endcall.BackColor = System.Drawing.Color.White
        Me.btn_endcall.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_endcall.ForeColor = System.Drawing.Color.Red
        Me.btn_endcall.Image = Global.NO_NET_CHAT_SYSTEM___VIDEO_CALL.My.Resources.Resources.end_icon
        Me.btn_endcall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_endcall.Location = New System.Drawing.Point(158, 387)
        Me.btn_endcall.Name = "btn_endcall"
        Me.btn_endcall.Size = New System.Drawing.Size(286, 42)
        Me.btn_endcall.TabIndex = 6
        Me.btn_endcall.Text = "End Voice Call"
        Me.btn_endcall.UseVisualStyleBackColor = False
        '
        'btn_volumeup
        '
        Me.btn_volumeup.BackColor = System.Drawing.Color.Lime
        Me.btn_volumeup.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volumeup.Location = New System.Drawing.Point(30, 162)
        Me.btn_volumeup.Name = "btn_volumeup"
        Me.btn_volumeup.Size = New System.Drawing.Size(135, 84)
        Me.btn_volumeup.TabIndex = 7
        Me.btn_volumeup.Text = "Volume +"
        Me.btn_volumeup.UseVisualStyleBackColor = False
        '
        'btn_mute
        '
        Me.btn_mute.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_mute.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mute.Location = New System.Drawing.Point(231, 162)
        Me.btn_mute.Name = "btn_mute"
        Me.btn_mute.Size = New System.Drawing.Size(135, 84)
        Me.btn_mute.TabIndex = 8
        Me.btn_mute.Text = "Mute"
        Me.btn_mute.UseVisualStyleBackColor = False
        '
        'btn_volumedown
        '
        Me.btn_volumedown.BackColor = System.Drawing.Color.Red
        Me.btn_volumedown.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volumedown.Location = New System.Drawing.Point(442, 162)
        Me.btn_volumedown.Name = "btn_volumedown"
        Me.btn_volumedown.Size = New System.Drawing.Size(135, 84)
        Me.btn_volumedown.TabIndex = 9
        Me.btn_volumedown.Text = "Volume -"
        Me.btn_volumedown.UseVisualStyleBackColor = False
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.White
        Me.lbl_date.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(68, 53)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(62, 27)
        Me.lbl_date.TabIndex = 15
        Me.lbl_date.Text = "Date"
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.BackColor = System.Drawing.Color.White
        Me.lbl_time.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(440, 53)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(63, 27)
        Me.lbl_time.TabIndex = 16
        Me.lbl_time.Text = "Time"
        '
        'Timer1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(624, 26)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(61, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'AxVideoChatReceiver1
        '
        Me.AxVideoChatReceiver1.Enabled = True
        Me.AxVideoChatReceiver1.Location = New System.Drawing.Point(315, 118)
        Me.AxVideoChatReceiver1.Name = "AxVideoChatReceiver1"
        Me.AxVideoChatReceiver1.OcxState = CType(resources.GetObject("AxVideoChatReceiver1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoChatReceiver1.Size = New System.Drawing.Size(129, 92)
        Me.AxVideoChatReceiver1.TabIndex = 1
        Me.AxVideoChatReceiver1.Visible = False
        '
        'frm_voicecall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NO_NET_CHAT_SYSTEM___VIDEO_CALL.My.Resources.Resources.White_Wallpaper_HD_Background_Free
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_volumedown)
        Me.Controls.Add(Me.btn_mute)
        Me.Controls.Add(Me.btn_volumeup)
        Me.Controls.Add(Me.btn_endcall)
        Me.Controls.Add(Me.btn_connect)
        Me.Controls.Add(Me.AxVideoChatReceiver1)
        Me.Controls.Add(Me.AxVideoChatSender1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_voicecall"
        Me.Text = "Voice Call"
        CType(Me.AxVideoChatSender1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.AxVideoChatReceiver1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxVideoChatSender1 As AxVideoChatSenderLib.AxVideoChatSender
    Friend WithEvents btn_connect As Button
    Friend WithEvents btn_endcall As Button
    Friend WithEvents btn_volumeup As Button
    Friend WithEvents btn_mute As Button
    Friend WithEvents btn_volumedown As Button
    Friend WithEvents lbl_date As Label
    Private WithEvents lbl_time As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AxVideoChatReceiver1 As AxVideoChatReceiverLib.AxVideoChatReceiver
End Class
