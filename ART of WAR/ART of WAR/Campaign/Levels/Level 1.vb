Public Class Level_1

    Dim Velocity As Integer = 15
    Dim Gravity As Integer = 10
    Dim Jumping As Boolean
    Dim PlayerMAR As Integer = 1
    Dim PlayerMAJ As Integer = 1
    Dim Score As Integer
    Dim FlagWaving As Integer = 1




    Private Sub Level_1_Load(sender As Object, e As EventArgs) Handles Me.Load
        tmrGame.Start()
        tmrFlags.Start()

        AxWindowsMediaPlayer1.Hide()
        AxWindowsMediaPlayer1.URL = "D:\FinalVB\ART of WAR\ART of WAR\Resources\04_MKAlieZ.wav"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    ' Timer For The Game Logic.
    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick
        If picPlayer.Bounds.IntersectsWith(picAir.Bounds) Then
            tmrGravity.Start()
        ElseIf picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGravity.Stop()
        End If

        ' Platform
        For Each plat As Control In Me.Controls
            If TypeOf plat Is PictureBox Then
                If plat.Tag = "platform" Then
                    If picPlayer.Bounds.IntersectsWith(plat.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
            End If
        Next

        ' Map Boundary
        ' Right
        For Each limit As Control In Me.Controls
            If TypeOf limit Is PictureBox Then
                If limit.Tag = "limitedRight" Then
                    If picPlayer.Bounds.IntersectsWith(limit.Bounds) Then
                        tmrRight.Stop()
                    End If
                End If
            End If
        Next

        'Left
        For Each limit As Control In Me.Controls
            If TypeOf limit Is PictureBox Then
                If limit.Tag = "limitedLeft" Then
                    If picPlayer.Bounds.IntersectsWith(limit.Bounds) Then
                        tmrRight.Stop()
                    End If
                End If
            End If
        Next

        Dim flags() = {Flag0, Flag1, Flag2, Flag3}
        Dim x As Integer

        For x = 0 To 3
            If picPlayer.Bounds.IntersectsWith(flags(x).Bounds) Then
                If flags(x).Enabled = True Then
                    Score += 1
                    My.Computer.Audio.Play(My.Resources.Flagcaptured, AudioPlayMode.Background)
                End If
                flags(x).Hide()
                flags(x).Enabled = False
            End If
        Next

        Goal.Hide()
        If Score = 4 Then
            Goal.Show()
        End If

        If picPlayer.Bounds.IntersectsWith(Goal.Bounds) Then
            If Score = 4 And Goal.Enabled = True Then
                tmrRight.Stop()
                tmrLeft.Stop()

            End If
        End If

    End Sub

    ' When any key is down perform funtions below.
    Private Sub Level_1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
                'tmrCMA.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Up
                tmrUp.Start()
                
                Jumping = True
                
        End Select
    End Sub

    ' When any key is up perform funtions below.
    Private Sub Level_1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
                'tmrCMA.Stop()
                picPlayer.Image = My.Resources.Player
            Case Keys.Left
                tmrLeft.Stop()
                picPlayer.Image = My.Resources.PlayerRV
            Case Keys.Up
                tmrUp.Stop()
                picPlayer.Image = My.Resources.Player
                Jumping = False
        End Select
    End Sub

    ' Timers
    ' A timer that moves picPlayer to the Right.
    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        picPlayer.Left += Velocity          ' Moves picPlayer to right of set variable of Velocity.

        Select Case PlayerMAR
            Case 1
                picPlayer.Image = My.Resources.CM1
                PlayerMAR += 1
            Case 2
                picPlayer.Image = My.Resources.CM2
                PlayerMAR += 1
            Case 3
                picPlayer.Image = My.Resources.CM3
                PlayerMAR += 1
            Case 4
                picPlayer.Image = My.Resources.CM4
                PlayerMAR += 1
            Case 5
                picPlayer.Image = My.Resources.CM5
                PlayerMAR += 1
            Case 6
                picPlayer.Image = My.Resources.CM6
                PlayerMAR += 1
            Case 7
                picPlayer.Image = My.Resources.CM7
                PlayerMAR += 1
            Case 8
                picPlayer.Image = My.Resources.CM8
                PlayerMAR += 1
            Case 9
                picPlayer.Image = My.Resources.CM9
                PlayerMAR += 1
            Case 10
                picPlayer.Image = My.Resources.CM10
                PlayerMAR = 1
        End Select



    End Sub

    ' A timer that moves picPlayer to the Left.
    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        picPlayer.Left -= Velocity           ' Moves picPlayer to left of set variable of Velocity.

        Select Case PlayerMAR
            Case 1
                picPlayer.Image = My.Resources.CMRV1
                PlayerMAR += 1
            Case 2
                picPlayer.Image = My.Resources.CMRV2
                PlayerMAR += 1
            Case 3
                picPlayer.Image = My.Resources.CMRV3
                PlayerMAR += 1
            Case 4
                picPlayer.Image = My.Resources.CMRV4
                PlayerMAR += 1
            Case 5
                picPlayer.Image = My.Resources.CMRV5
                PlayerMAR += 1
            Case 6
                picPlayer.Image = My.Resources.CMRV6
                PlayerMAR += 1
            Case 7
                picPlayer.Image = My.Resources.CMRV7
                PlayerMAR += 1
            Case 8
                picPlayer.Image = My.Resources.CMRV8
                PlayerMAR += 1
            Case 9
                picPlayer.Image = My.Resources.CMRV9
                PlayerMAR += 1
            Case 10
                picPlayer.Image = My.Resources.CMRV10
                PlayerMAR = 1
        End Select
    End Sub
    ' A timer that moves picPlayer to the up.
    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        picPlayer.Top -= 20         ' Moves picPlayer to Up of set 20.

        Select Case PlayerMAJ
            Case 1
                picPlayer.Image = My.Resources.CMJ1
                PlayerMAJ += 1
            Case 1
                picPlayer.Image = My.Resources.CMJ2
                PlayerMAJ = 1
        End Select

        

    End Sub

    ' A timer that move picPlayer down
    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
        picPlayer.Top += Gravity          ' Moves picPlayer to down of set variable of Gravity.


    End Sub

    Private Sub tmrCMA_Tick(sender As Object, e As EventArgs) Handles tmrCMA.Tick
       
    End Sub

    Private Sub tmrFlags_Tick(sender As Object, e As EventArgs)
        Dim flags() = {Flag0, Flag1, Flag2, Flag3}
        Dim y As Integer

        For y = 0 To 3
            Select Case FlagWaving
                Case 1
                    flags(y).Image = My.Resources.RedFlag1
                    FlagWaving += 1
                Case 2
                    flags(y).Image = My.Resources.RedFlag2
                    FlagWaving += 1
                Case 2
                    flags(y).Image = My.Resources.RedFlag3
                    FlagWaving = 1
            End Select
        Next
    End Sub

End Class