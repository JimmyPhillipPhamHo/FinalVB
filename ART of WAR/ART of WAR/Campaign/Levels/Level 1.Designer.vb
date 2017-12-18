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
        Me.picTest = New System.Windows.Forms.PictureBox()
        Me.picAir = New System.Windows.Forms.PictureBox()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picTest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTest
        '
        Me.picTest.Image = Global.ART_of_WAR.My.Resources.Resources.piq_57250_400x400
        Me.picTest.Location = New System.Drawing.Point(-4, 333)
        Me.picTest.Name = "picTest"
        Me.picTest.Size = New System.Drawing.Size(110, 90)
        Me.picTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTest.TabIndex = 0
        Me.picTest.TabStop = False
        '
        'picAir
        '
        Me.picAir.Location = New System.Drawing.Point(-4, -1)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(862, 328)
        Me.picAir.TabIndex = 1
        Me.picAir.TabStop = False
        '
        'tmrRight
        '
        '
        'Level_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 434)
        Me.Controls.Add(Me.picTest)
        Me.Controls.Add(Me.picAir)
        Me.Name = "Level_1"
        Me.Text = "Level_1"
        CType(Me.picTest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picTest As System.Windows.Forms.PictureBox
    Friend WithEvents picAir As System.Windows.Forms.PictureBox
    Friend WithEvents tmrRight As System.Windows.Forms.Timer
End Class
