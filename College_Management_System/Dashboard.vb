Imports Transitions
Imports System.IO

Public Class Dashboard


    Private Sub hamburgerPb_Click_1(sender As Object, e As EventArgs) Handles hamburgerPb.Click
        If (hamburgerPnl.Width < 250) Then

            Transition.run(hamburgerPnl, "Width", 250, New TransitionType_EaseInEaseOut(150))
        Else
            Transition.run(hamburgerPnl, "Width", 55, New TransitionType_EaseInEaseOut(150))
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        dashboardTablePnl.Visible = True
        dashboardTablePnl.Enabled = True
        BunifuTransition1.ShowSync(dashboardTablePnl)

    End Sub
    Sub imageChooser(ByVal a As String)
        Dim openDialogImg As OpenFileDialog = New OpenFileDialog
        openDialogImg.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        openDialogImg.FilterIndex = 2
        openDialogImg.RestoreDirectory = True
        If openDialogImg.ShowDialog() = DialogResult.OK Then
            If File.Exists(openDialogImg.FileName) = False Then
                MessageBox.Show("Sorry, The File You Specified Does Not Exist.")
            Else
                If (a = "adminImageSelectUsers") Then
                    PictureBox3.ImageLocation = openDialogImg.FileName
                ElseIf (a = "adminImageSelectStudents") Then
                    PictureBox4.ImageLocation = openDialogImg.FileName
                End If

            End If

        End If
    End Sub





    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        imageChooser("adminImageSelectUsers")
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        imageChooser("adminImageSelectStudents")
    End Sub

    Private Sub addUserTb_Click(sender As Object, e As EventArgs) Handles addUserTb.Click
        Transition.run(hamburgerPnl, "Width", 55, New TransitionType_EaseInEaseOut(150))
    End Sub

  
End Class