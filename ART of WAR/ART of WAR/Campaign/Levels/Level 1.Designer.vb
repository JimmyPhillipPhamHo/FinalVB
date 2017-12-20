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
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.picTest = New System.Windows.Forms.PictureBox()
        Me.picAir = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        CType(Me.picTest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'tmrGameLogic
        '
        Me.tmrGameLogic.Interval = 20
        '
        'tmrGravity
        '
        Me.tmrGravity.Interval = 20
        '
        'picTest
        '
        Me.picTest.Image = Global.ART_of_WAR.My.Resources.Resources.piq_57250_400x400
        Me.picTest.Location = New System.Drawing.Point(-4, 324)
        Me.picTest.Name = "picTest"
        Me.picTest.Size = New System.Drawing.Size(110, 90)
        Me.picTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTest.TabIndex = 0
        Me.picTest.TabStop = False
        '
        'picAir
        '
        Me.picAir.Image = Global.ART_of_WAR.My.Resources.Resources.Level1TestBackGround
        Me.picAir.Location = New System.Drawing.Point(-4, 1)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(856, 317)
        Me.picAir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAir.TabIndex = 2
        Me.picAir.TabStop = False
        '
        'picGround
        '
        Me.picGround.Location = New System.Drawing.Point(-4, 420)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(856, 13)
        Me.picGround.TabIndex = 1
        Me.picGround.TabStop = False
        '
        'Level_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 434)
        Me.Controls.Add(Me.picTest)
        Me.Controls.Add(Me.picAir)
        Me.Controls.Add(Me.picGround)
        Me.Name = "Level_1"
        Me.Text = "Level_1"
        CType(Me.picTest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picTest As System.Windows.Forms.PictureBox
    Friend WithEvents tmrRight As System.Windows.Forms.Timer
    Friend WithEvents tmrLeft As System.Windows.Forms.Timer
    Friend WithEvents tmrUp As System.Windows.Forms.Timer
    Friend WithEvents tmrGameLogic As System.Windows.Forms.Timer
    Friend WithEvents tmrGravity As System.Windows.Forms.Timer
    Friend WithEvents picGround As System.Windows.Forms.PictureBox
    Friend WithEvents picAir As System.Windows.Forms.PictureBox
End Class
