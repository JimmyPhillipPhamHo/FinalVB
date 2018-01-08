<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Level_1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level_1))
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCMA = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFlags = New System.Windows.Forms.Timer(Me.components)
        Me.Goal = New System.Windows.Forms.PictureBox()
        Me.Flag2 = New System.Windows.Forms.PictureBox()
        Me.Flag3 = New System.Windows.Forms.PictureBox()
        Me.Flag1 = New System.Windows.Forms.PictureBox()
        Me.Flag0 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picAir = New System.Windows.Forms.PictureBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.Goal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Flag2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Flag3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Flag1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Flag0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 20
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 20
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 20
        '
        'tmrGame
        '
        Me.tmrGame.Interval = 20
        '
        'tmrGravity
        '
        Me.tmrGravity.Interval = 20
        '
        'tmrCMA
        '
        '
        'Goal
        '
        Me.Goal.BackColor = System.Drawing.Color.Transparent
        Me.Goal.Image = Global.ART_of_WAR.My.Resources.Resources.Pelican
        Me.Goal.Location = New System.Drawing.Point(616, 392)
        Me.Goal.Name = "Goal"
        Me.Goal.Size = New System.Drawing.Size(556, 210)
        Me.Goal.TabIndex = 24
        Me.Goal.TabStop = False
        '
        'Flag2
        '
        Me.Flag2.BackColor = System.Drawing.Color.Transparent
        Me.Flag2.Image = Global.ART_of_WAR.My.Resources.Resources.RedFlag1
        Me.Flag2.Location = New System.Drawing.Point(340, 524)
        Me.Flag2.Name = "Flag2"
        Me.Flag2.Size = New System.Drawing.Size(42, 85)
        Me.Flag2.TabIndex = 23
        Me.Flag2.TabStop = False
        '
        'Flag3
        '
        Me.Flag3.BackColor = System.Drawing.Color.Transparent
        Me.Flag3.Image = Global.ART_of_WAR.My.Resources.Resources.RedFlag1
        Me.Flag3.Location = New System.Drawing.Point(776, 165)
        Me.Flag3.Name = "Flag3"
        Me.Flag3.Size = New System.Drawing.Size(42, 85)
        Me.Flag3.TabIndex = 22
        Me.Flag3.TabStop = False
        '
        'Flag1
        '
        Me.Flag1.BackColor = System.Drawing.Color.Transparent
        Me.Flag1.Image = Global.ART_of_WAR.My.Resources.Resources.RedFlag1
        Me.Flag1.Location = New System.Drawing.Point(496, 310)
        Me.Flag1.Name = "Flag1"
        Me.Flag1.Size = New System.Drawing.Size(42, 85)
        Me.Flag1.TabIndex = 21
        Me.Flag1.TabStop = False
        '
        'Flag0
        '
        Me.Flag0.BackColor = System.Drawing.Color.Transparent
        Me.Flag0.Image = Global.ART_of_WAR.My.Resources.Resources.RedFlag1
        Me.Flag0.Location = New System.Drawing.Point(129, 165)
        Me.Flag0.Name = "Flag0"
        Me.Flag0.Size = New System.Drawing.Size(42, 85)
        Me.Flag0.TabIndex = 20
        Me.Flag0.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.BackgroundImage = Global.ART_of_WAR.My.Resources.Resources.platforms
        Me.PictureBox7.Location = New System.Drawing.Point(449, 401)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(131, 32)
        Me.PictureBox7.TabIndex = 19
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "platform"
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Green
        Me.PictureBox12.Location = New System.Drawing.Point(1025, 256)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(157, 18)
        Me.PictureBox12.TabIndex = 18
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Tag = "platform"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Green
        Me.PictureBox10.Location = New System.Drawing.Point(251, 101)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(157, 18)
        Me.PictureBox10.TabIndex = 16
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "platform"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Green
        Me.PictureBox9.Location = New System.Drawing.Point(871, 101)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(157, 18)
        Me.PictureBox9.TabIndex = 15
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "platform"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Green
        Me.PictureBox8.Location = New System.Drawing.Point(861, 354)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(157, 18)
        Me.PictureBox8.TabIndex = 14
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "platform"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Green
        Me.PictureBox6.Location = New System.Drawing.Point(565, 68)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(157, 18)
        Me.PictureBox6.TabIndex = 12
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "platform"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.BackgroundImage = Global.ART_of_WAR.My.Resources.Resources.platforms
        Me.PictureBox4.Location = New System.Drawing.Point(251, 392)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(131, 32)
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "platform"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Green
        Me.PictureBox3.Location = New System.Drawing.Point(423, 256)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(157, 18)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "platform"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Green
        Me.PictureBox2.Location = New System.Drawing.Point(60, 256)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(157, 18)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "platform"
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox.Location = New System.Drawing.Point(1248, 1)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(20, 630)
        Me.PictureBox.TabIndex = 8
        Me.PictureBox.TabStop = False
        Me.PictureBox.Tag = "limitedRight"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Location = New System.Drawing.Point(-4, 1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(23, 630)
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "limitedLeft"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Green
        Me.PictureBox1.Location = New System.Drawing.Point(712, 256)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 18)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "platform"
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.Transparent
        Me.picGround.Location = New System.Drawing.Point(-4, 615)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(1272, 16)
        Me.picGround.TabIndex = 1
        Me.picGround.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer.Image = Global.ART_of_WAR.My.Resources.Resources.Player
        Me.picPlayer.Location = New System.Drawing.Point(86, 499)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(85, 109)
        Me.picPlayer.TabIndex = 13
        Me.picPlayer.TabStop = False
        '
        'picAir
        '
        Me.picAir.BackColor = System.Drawing.Color.Transparent
        Me.picAir.Location = New System.Drawing.Point(-4, 1)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(1272, 492)
        Me.picAir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAir.TabIndex = 2
        Me.picAir.TabStop = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(69, 401)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(133, 54)
        Me.AxWindowsMediaPlayer1.TabIndex = 25
        '
        'Level_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ART_of_WAR.My.Resources.Resources.CityNightbackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1271, 633)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.Goal)
        Me.Controls.Add(Me.Flag2)
        Me.Controls.Add(Me.Flag3)
        Me.Controls.Add(Me.Flag1)
        Me.Controls.Add(Me.Flag0)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picAir)
        Me.Name = "Level_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level_1"
        CType(Me.Goal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Flag2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Flag3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Flag1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Flag0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrRight As System.Windows.Forms.Timer
    Friend WithEvents tmrLeft As System.Windows.Forms.Timer
    Friend WithEvents tmrUp As System.Windows.Forms.Timer
    Friend WithEvents tmrGame As System.Windows.Forms.Timer
    Friend WithEvents tmrGravity As System.Windows.Forms.Timer
    Friend WithEvents picGround As System.Windows.Forms.PictureBox
    Friend WithEvents picAir As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrCMA As System.Windows.Forms.Timer
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Flag0 As System.Windows.Forms.PictureBox
    Friend WithEvents Flag1 As System.Windows.Forms.PictureBox
    Friend WithEvents Flag3 As System.Windows.Forms.PictureBox
    Friend WithEvents Flag2 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrFlags As System.Windows.Forms.Timer
    Friend WithEvents Goal As System.Windows.Forms.PictureBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
End Class
