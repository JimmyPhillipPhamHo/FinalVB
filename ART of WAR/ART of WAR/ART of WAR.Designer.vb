<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArtofWarMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArtofWarMenu))
        Me.btnCampaign = New System.Windows.Forms.Button()
        Me.btnSM = New System.Windows.Forms.Button()
        Me.btnMultiplayer = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnSolder = New System.Windows.Forms.Button()
        Me.picMBackGround = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picMBackGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCampaign
        '
        Me.btnCampaign.Location = New System.Drawing.Point(191, 110)
        Me.btnCampaign.Name = "btnCampaign"
        Me.btnCampaign.Size = New System.Drawing.Size(190, 24)
        Me.btnCampaign.TabIndex = 0
        Me.btnCampaign.Text = "CAMPAIGN"
        Me.btnCampaign.UseVisualStyleBackColor = True
        '
        'btnSM
        '
        Me.btnSM.Location = New System.Drawing.Point(191, 214)
        Me.btnSM.Name = "btnSM"
        Me.btnSM.Size = New System.Drawing.Size(190, 28)
        Me.btnSM.TabIndex = 1
        Me.btnSM.Text = "Survival Mode"
        Me.btnSM.UseVisualStyleBackColor = True
        '
        'btnMultiplayer
        '
        Me.btnMultiplayer.Location = New System.Drawing.Point(191, 160)
        Me.btnMultiplayer.Name = "btnMultiplayer"
        Me.btnMultiplayer.Size = New System.Drawing.Size(190, 28)
        Me.btnMultiplayer.TabIndex = 2
        Me.btnMultiplayer.Text = "Multiplayer"
        Me.btnMultiplayer.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(191, 356)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(190, 28)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("High Tower Text", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(166, 32)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(250, 55)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Art of War"
        '
        'Timer1
        '
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(191, 312)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(190, 28)
        Me.btnSettings.TabIndex = 5
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnSolder
        '
        Me.btnSolder.Location = New System.Drawing.Point(191, 258)
        Me.btnSolder.Name = "btnSolder"
        Me.btnSolder.Size = New System.Drawing.Size(190, 28)
        Me.btnSolder.TabIndex = 6
        Me.btnSolder.Text = "Solder"
        Me.btnSolder.UseVisualStyleBackColor = True
        '
        'picMBackGround
        '
        Me.picMBackGround.BackColor = System.Drawing.Color.Black
        Me.picMBackGround.Location = New System.Drawing.Point(1, -1)
        Me.picMBackGround.Name = "picMBackGround"
        Me.picMBackGround.Size = New System.Drawing.Size(597, 468)
        Me.picMBackGround.TabIndex = 7
        Me.picMBackGround.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BackgroundImage = CType(resources.GetObject("picLogo.BackgroundImage"), System.Drawing.Image)
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(142, 90)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(369, 274)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 8
        Me.picLogo.TabStop = False
        '
        'ArtofWarMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(595, 466)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.picMBackGround)
        Me.Controls.Add(Me.btnSolder)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnMultiplayer)
        Me.Controls.Add(Me.btnSM)
        Me.Controls.Add(Me.btnCampaign)
        Me.Name = "ArtofWarMenu"
        Me.Text = " "
        CType(Me.picMBackGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCampaign As System.Windows.Forms.Button
    Friend WithEvents btnSM As System.Windows.Forms.Button
    Friend WithEvents btnMultiplayer As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnSolder As System.Windows.Forms.Button
    Friend WithEvents picMBackGround As System.Windows.Forms.PictureBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox

End Class
