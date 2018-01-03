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
        Me.btnSurvivleMode = New System.Windows.Forms.Button()
        Me.btnMulitplayer = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnSoldier = New System.Windows.Forms.Button()
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
        Me.btnCampaign.Text = "Campaign"
        Me.btnCampaign.UseVisualStyleBackColor = True
        '
        'btnSurvivleMode
        '
        Me.btnSurvivleMode.Location = New System.Drawing.Point(191, 214)
        Me.btnSurvivleMode.Name = "btnSurvivleMode"
        Me.btnSurvivleMode.Size = New System.Drawing.Size(190, 28)
        Me.btnSurvivleMode.TabIndex = 1
        Me.btnSurvivleMode.Text = "Coming Soon"
        Me.btnSurvivleMode.UseVisualStyleBackColor = True
        '
        'btnMulitplayer
        '
        Me.btnMulitplayer.Location = New System.Drawing.Point(191, 160)
        Me.btnMulitplayer.Name = "btnMulitplayer"
        Me.btnMulitplayer.Size = New System.Drawing.Size(190, 28)
        Me.btnMulitplayer.TabIndex = 2
        Me.btnMulitplayer.Text = "Coming Soon"
        Me.btnMulitplayer.UseVisualStyleBackColor = True
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
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(166, 32)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(232, 54)
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
        'btnSoldier
        '
        Me.btnSoldier.Location = New System.Drawing.Point(191, 258)
        Me.btnSoldier.Name = "btnSoldier"
        Me.btnSoldier.Size = New System.Drawing.Size(190, 28)
        Me.btnSoldier.TabIndex = 6
        Me.btnSoldier.Text = "Coming Soon"
        Me.btnSoldier.UseVisualStyleBackColor = True
        '
        'picMBackGround
        '
        Me.picMBackGround.BackColor = System.Drawing.Color.Black
        Me.picMBackGround.Location = New System.Drawing.Point(465, 62)
        Me.picMBackGround.Name = "picMBackGround"
        Me.picMBackGround.Size = New System.Drawing.Size(596, 432)
        Me.picMBackGround.TabIndex = 7
        Me.picMBackGround.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BackgroundImage = CType(resources.GetObject("picLogo.BackgroundImage"), System.Drawing.Image)
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(568, 138)
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
        Me.ClientSize = New System.Drawing.Size(761, 538)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.picMBackGround)
        Me.Controls.Add(Me.btnSoldier)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnMulitplayer)
        Me.Controls.Add(Me.btnSurvivleMode)
        Me.Controls.Add(Me.btnCampaign)
        Me.Name = "ArtofWarMenu"
        Me.Text = " "
        CType(Me.picMBackGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCampaign As System.Windows.Forms.Button
    Friend WithEvents btnSurvivleMode As System.Windows.Forms.Button
    Friend WithEvents btnMulitplayer As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents btnSoldier As System.Windows.Forms.Button
    Friend WithEvents picMBackGround As System.Windows.Forms.PictureBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox

End Class
