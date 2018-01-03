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
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
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
        Me.picCm1 = New System.Windows.Forms.PictureBox()
        Me.picCm2 = New System.Windows.Forms.PictureBox()
        Me.picCm3 = New System.Windows.Forms.PictureBox()
        Me.picCm4 = New System.Windows.Forms.PictureBox()
        Me.picCm5 = New System.Windows.Forms.PictureBox()
        Me.picCm6 = New System.Windows.Forms.PictureBox()
        Me.picCm7 = New System.Windows.Forms.PictureBox()
        Me.picCm8 = New System.Windows.Forms.PictureBox()
        Me.picCm9 = New System.Windows.Forms.PictureBox()
        Me.picCm10 = New System.Windows.Forms.PictureBox()
        Me.picAir = New System.Windows.Forms.PictureBox()
        Me.tmrCMA = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.picCm1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCm2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCm3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCm4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCm5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCm6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCm7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCm8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCm9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCm10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Green
        Me.PictureBox12.Location = New System.Drawing.Point(1146, 243)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(157, 18)
        Me.PictureBox12.TabIndex = 18
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Tag = "platform"
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Green
        Me.PictureBox11.Location = New System.Drawing.Point(226, 366)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(157, 18)
        Me.PictureBox11.TabIndex = 17
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Tag = "platform"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Green
        Me.PictureBox10.Location = New System.Drawing.Point(152, 90)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(157, 18)
        Me.PictureBox10.TabIndex = 16
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "platform"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Green
        Me.PictureBox9.Location = New System.Drawing.Point(947, 101)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(157, 18)
        Me.PictureBox9.TabIndex = 15
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "platform"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Green
        Me.PictureBox8.Location = New System.Drawing.Point(947, 392)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(157, 18)
        Me.PictureBox8.TabIndex = 14
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "platform"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Green
        Me.PictureBox6.Location = New System.Drawing.Point(586, 69)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(157, 18)
        Me.PictureBox6.TabIndex = 12
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "platform"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Green
        Me.PictureBox4.Location = New System.Drawing.Point(469, 435)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(157, 18)
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "platform"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Green
        Me.PictureBox3.Location = New System.Drawing.Point(372, 181)
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
        Me.PictureBox.Location = New System.Drawing.Point(1410, 1)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(20, 630)
        Me.PictureBox.TabIndex = 8
        Me.PictureBox.TabStop = False
        Me.PictureBox.Tag = "limitedRight"
        '
        'PictureBox5
        '
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
        Me.PictureBox1.Location = New System.Drawing.Point(716, 268)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 18)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "platform"
        '
        'picGround
        '
        Me.picGround.Location = New System.Drawing.Point(-4, 615)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(1434, 16)
        Me.picGround.TabIndex = 1
        Me.picGround.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.Image = Global.ART_of_WAR.My.Resources.Resources.Player
        Me.picPlayer.Location = New System.Drawing.Point(595, 499)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(85, 109)
        Me.picPlayer.TabIndex = 13
        Me.picPlayer.TabStop = False
        '
        'picCm1
        '
        Me.picCm1.Image = CType(resources.GetObject("picCm1.Image"), System.Drawing.Image)
        Me.picCm1.Location = New System.Drawing.Point(595, 499)
        Me.picCm1.Name = "picCm1"
        Me.picCm1.Size = New System.Drawing.Size(85, 109)
        Me.picCm1.TabIndex = 19
        Me.picCm1.TabStop = False
        '
        'picCm2
        '
        Me.picCm2.Image = Global.ART_of_WAR.My.Resources.Resources.CM2
        Me.picCm2.Location = New System.Drawing.Point(595, 499)
        Me.picCm2.Name = "picCm2"
        Me.picCm2.Size = New System.Drawing.Size(85, 109)
        Me.picCm2.TabIndex = 20
        Me.picCm2.TabStop = False
        '
        'picCm3
        '
        Me.picCm3.Image = Global.ART_of_WAR.My.Resources.Resources.CM3
        Me.picCm3.Location = New System.Drawing.Point(595, 499)
        Me.picCm3.Name = "picCm3"
        Me.picCm3.Size = New System.Drawing.Size(85, 109)
        Me.picCm3.TabIndex = 21
        Me.picCm3.TabStop = False
        '
        'picCm4
        '
        Me.picCm4.Image = Global.ART_of_WAR.My.Resources.Resources.CM4
        Me.picCm4.Location = New System.Drawing.Point(595, 499)
        Me.picCm4.Name = "picCm4"
        Me.picCm4.Size = New System.Drawing.Size(85, 109)
        Me.picCm4.TabIndex = 22
        Me.picCm4.TabStop = False
        '
        'picCm5
        '
        Me.picCm5.Image = Global.ART_of_WAR.My.Resources.Resources.CM5
        Me.picCm5.Location = New System.Drawing.Point(595, 499)
        Me.picCm5.Name = "picCm5"
        Me.picCm5.Size = New System.Drawing.Size(85, 109)
        Me.picCm5.TabIndex = 23
        Me.picCm5.TabStop = False
        '
        'picCm6
        '
        Me.picCm6.Image = Global.ART_of_WAR.My.Resources.Resources.CM6
        Me.picCm6.Location = New System.Drawing.Point(595, 499)
        Me.picCm6.Name = "picCm6"
        Me.picCm6.Size = New System.Drawing.Size(85, 109)
        Me.picCm6.TabIndex = 24
        Me.picCm6.TabStop = False
        '
        'picCm7
        '
        Me.picCm7.Image = Global.ART_of_WAR.My.Resources.Resources.CM7
        Me.picCm7.Location = New System.Drawing.Point(595, 499)
        Me.picCm7.Name = "picCm7"
        Me.picCm7.Size = New System.Drawing.Size(85, 109)
        Me.picCm7.TabIndex = 25
        Me.picCm7.TabStop = False
        '
        'picCm8
        '
        Me.picCm8.Image = Global.ART_of_WAR.My.Resources.Resources.CM8
        Me.picCm8.Location = New System.Drawing.Point(595, 499)
        Me.picCm8.Name = "picCm8"
        Me.picCm8.Size = New System.Drawing.Size(85, 109)
        Me.picCm8.TabIndex = 26
        Me.picCm8.TabStop = False
        '
        'picCm9
        '
        Me.picCm9.Image = Global.ART_of_WAR.My.Resources.Resources.CM9
        Me.picCm9.Location = New System.Drawing.Point(595, 499)
        Me.picCm9.Name = "picCm9"
        Me.picCm9.Size = New System.Drawing.Size(85, 109)
        Me.picCm9.TabIndex = 27
        Me.picCm9.TabStop = False
        '
        'picCm10
        '
        Me.picCm10.Image = Global.ART_of_WAR.My.Resources.Resources.CM10
        Me.picCm10.Location = New System.Drawing.Point(595, 499)
        Me.picCm10.Name = "picCm10"
        Me.picCm10.Size = New System.Drawing.Size(85, 109)
        Me.picCm10.TabIndex = 28
        Me.picCm10.TabStop = False
        '
        'picAir
        '
        Me.picAir.BackColor = System.Drawing.Color.Transparent
        Me.picAir.Location = New System.Drawing.Point(-4, 1)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(1434, 492)
        Me.picAir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAir.TabIndex = 2
        Me.picAir.TabStop = False
        '
        'tmrCMA
        '
        '
        'Level_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1431, 633)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
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
        Me.Controls.Add(Me.picCm1)
        Me.Controls.Add(Me.picCm2)
        Me.Controls.Add(Me.picCm3)
        Me.Controls.Add(Me.picCm4)
        Me.Controls.Add(Me.picCm5)
        Me.Controls.Add(Me.picCm6)
        Me.Controls.Add(Me.picCm7)
        Me.Controls.Add(Me.picCm8)
        Me.Controls.Add(Me.picCm9)
        Me.Controls.Add(Me.picCm10)
        Me.Controls.Add(Me.picAir)
        Me.Name = "Level_1"
        Me.Text = "Level_1"
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.picCm1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCm2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCm3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCm4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCm5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCm6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCm7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCm8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCm9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCm10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents picCm1 As System.Windows.Forms.PictureBox
    Friend WithEvents picCm2 As System.Windows.Forms.PictureBox
    Friend WithEvents picCm3 As System.Windows.Forms.PictureBox
    Friend WithEvents picCm4 As System.Windows.Forms.PictureBox
    Friend WithEvents picCm5 As System.Windows.Forms.PictureBox
    Friend WithEvents picCm6 As System.Windows.Forms.PictureBox
    Friend WithEvents picCm7 As System.Windows.Forms.PictureBox
    Friend WithEvents picCm8 As System.Windows.Forms.PictureBox
    Friend WithEvents picCm9 As System.Windows.Forms.PictureBox
    Friend WithEvents picCm10 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrCMA As System.Windows.Forms.Timer
End Class
