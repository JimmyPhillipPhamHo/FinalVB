Public Class ArtofWarMenu
    Dim second As Integer

    Private Sub ArtofWarMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 5000
        Timer1.Start() 'Timer starts functioning
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        picLogo.Visible = False
        picMBackGround.Visible = False

        second = second + 1
        If second >= 10 Then
            Timer1.Stop() 'Timer stops functioning
        End If
    End Sub

    Private Sub btnCampaign_Click(sender As Object, e As EventArgs) Handles btnCampaign.Click
        Me.Hide()
        CampaignMenu.Show()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class
