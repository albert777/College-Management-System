Imports MetroFramework.Animation
Imports Transitions

Public Class Dashboard
    'Hamburger slide transition
    Private Sub hamburgerPb_Click_1(sender As Object, e As EventArgs) Handles hamburgerPb.Click
        If (hamburgerBarPnl.Width < 206) Then
            Transition.run(hamburgerBarPnl, "Width", 206, New TransitionType_EaseInEaseOut(200))
        Else
            Transition.run(hamburgerBarPnl, "Width", 42, New TransitionType_EaseInEaseOut(200))
        End If
    End Sub

    Private Sub settingPb_Click(sender As Object, e As EventArgs) Handles settingPb.Click
        settingTableLayout.Visible = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        settingTableLayout.Visible = False
    End Sub

    Private Sub crossPb_Click(sender As Object, e As EventArgs) Handles crossPb.Click
        Application.Exit()
    End Sub
End Class