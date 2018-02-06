Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        transparentPanel.BackColor = Color.FromArgb(200, Color.Black)
    End Sub
    Private Sub crossPb_Click(sender As Object, e As EventArgs) Handles crossPb.Click
        Application.Exit()
    End Sub

    Private Sub signInBtn_Click(sender As Object, e As EventArgs) Handles signInBtn.Click
        If (usernameTb.Text = "") Then
            loginErrorProvider.SetError(usernameTb, "Please enter your username!!")
        Else
            loginErrorProvider.SetError(usernameTb, String.Empty)
        End If
        If (passwordTb.Text = "") Then
            loginErrorProvider.SetError(passwordTb, "Please enter your password!!")
        Else
            loginErrorProvider.SetError(passwordTb, String.Empty)
        End If
    End Sub
    Private Sub loginDateAndTime()
        Dim date_Time As String
        date_Time = DateTime.Now.ToString()
    End Sub
End Class