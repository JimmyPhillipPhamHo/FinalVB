Public Class Level_1

    Dim Velocity As Integer = 15
    Dim Gravity As Integer = 10



    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        picPlayer.Top -= 20
    End Sub





    Dim moveSpeed As Integer = 15
    Dim jumpSpeed As Integer = 60

    Dim isJumping As Boolean

    Private Sub Level_1_Load(sender As Object, e As EventArgs) Handles Me.Load
        tmrGame.Start()
    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick
        If picPlayer.Bounds.IntersectsWith(picAir.Bounds) Then
            tmrGravity.Start()
            'If isJumping = False Then
            'tmrGravity.Start()
            'End If
        ElseIf picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGravity.Stop()
        End If


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

        For Each limit As Control In Me.Controls
            If TypeOf limit Is PictureBox Then
                If limit.Tag = "limitedLeft" Then
                    If picPlayer.Bounds.IntersectsWith(limit.Bounds) Then
                        tmrRight.Stop()
                    End If
                End If
            End If
        Next
    End Sub


    Private Sub Level_1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
                tmrCMA.Start()
            Case Keys.Left
                tmrLeft.Start()
                tmrCMA.Start()
            Case Keys.Up
                tmrUp.Start()
                tmrCMA.Start()
                isJumping = True
        End Select
    End Sub

    Private Sub Level_1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
                tmrCMA.Stop()
            Case Keys.Left
                tmrLeft.Stop()
                tmrCMA.Stop()
            Case Keys.Up
                tmrUp.Stop()
                tmrCMA.Stop()
                isJumping = False
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        picPlayer.Left += Velocity
        picCm1.Left += Velocity
        picCm2.Left += Velocity
        picCm3.Left += Velocity
        picCm4.Left += Velocity
        picCm5.Left += Velocity
        picCm6.Left += Velocity
        picCm7.Left += Velocity
        picCm8.Left += Velocity
        picCm9.Left += Velocity
        picCm10.Left += Velocity
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        picPlayer.Left -= Velocity
        picCm1.Left -= Velocity
        picCm2.Left -= Velocity
        picCm3.Left -= Velocity
        picCm4.Left -= Velocity
        picCm5.Left -= Velocity
        picCm6.Left -= Velocity
        picCm7.Left -= Velocity
        picCm8.Left -= Velocity
        picCm9.Left -= Velocity
        picCm10.Left -= Velocity

    End Sub

    'Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
    'picTest.Top -= jumpSpeed
    'End Sub

    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
        picPlayer.Top += Gravity
    End Sub

    Private Sub tmrCMA_Tick(sender As Object, e As EventArgs) Handles tmrCMA.Tick

        If picPlayer.Visible = True Then
            picPlayer.Visible = False
            picCm1.Visible = True
        ElseIf picCm1.Visible = True Then
            picCm1.Visible = False
            picCm2.Visible = True
        ElseIf picCm2.Visible = True Then
            picCm2.Visible = False
            picCm3.Visible = True
        ElseIf picCm3.Visible = True Then
            picCm3.Visible = False
            picCm4.Visible = True
        ElseIf picCm4.Visible = True Then
            picCm4.Visible = False
            picCm5.Visible = True
        ElseIf picCm5.Visible = True Then
            picCm5.Visible = False
            picCm6.Visible = True
        ElseIf picCm6.Visible = True Then
            picCm6.Visible = False
            picCm7.Visible = True
        ElseIf picCm7.Visible = True Then
            picCm7.Visible = False
            picCm8.Visible = True
        ElseIf picCm8.Visible = True Then
            picCm8.Visible = False
            picCm9.Visible = True
        ElseIf picCm9.Visible = True Then
            picCm9.Visible = False
            picCm10.Visible = True
        ElseIf picCm10.Visible = True Then
            picCm10.Visible = False
            picPlayer.Visible = True
        End If
    End Sub
End Class