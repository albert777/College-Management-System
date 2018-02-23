Imports System.Data.SqlClient

Public Class Login
    Dim su As AddRemoveStudentStaff = New AddRemoveStudentStaff
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        transparentPanel.BackColor = Color.FromArgb(200, Color.Black)
    End Sub
    Private Sub crossPb_Click(sender As Object, e As EventArgs) Handles CrossPictureBox.Click
        Application.Exit()
    End Sub

    Private Sub signInBtn_Click(sender As Object, e As EventArgs) Handles SignInBtn.Click
        If (UserNameTextBox.Text = "") Then
            loginErrorProvider.SetError(UserNameTextBox, "Please enter your username!!")
        Else
            loginErrorProvider.SetError(UserNameTextBox, String.Empty)
        End If
        If (PasswordTextBox.Text = "") Then
            loginErrorProvider.SetError(PasswordTextBox, "Please enter your password!!")
        Else
            loginErrorProvider.SetError(PasswordTextBox, String.Empty)
        End If
        Dim con As SqlConnection = su.dbConnect()
        Dim cmd As New SqlCommand("SELECT * FROM userTbl where username= @a AND password =@b", con)
        cmd.Parameters.AddWithValue("@a", UserNameTextBox.Text)
        cmd.Parameters.AddWithValue("@b", PasswordTextBox.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        If (dt.Rows.Count > 0) Then
            Dashboard.Show()

        Else
            MsgBox("Incorrect!!")
        End If
    End Sub
    Private Sub loginDateAndTime()
        Dim date_Time As String
        date_Time = DateTime.Now.ToString()
    End Sub
End Class