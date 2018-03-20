Imports System.Data.SqlClient
Imports System.IO

Public Class Login
    Public usertype, username, fname, lname, phone, email As String

    Dim countError As Integer = 1
    Public img() As Byte
    Dim su As New AddRemoveStudentStaff
    Dim d As New Dashboard
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
        Dim cmd As New SqlCommand("SELECT * FROM userTbl WHERE username= @a AND password =@b AND state = 1", con)
        cmd.Parameters.AddWithValue("@a", UserNameTextBox.Text)
        cmd.Parameters.AddWithValue("@b", PasswordTextBox.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
       
        If (dt.Rows.Count > 0) Then
            usertype = dt.Rows(0).Item("usertype")
            img = dt.Rows(0).Item("image")
            username = dt.Rows(0).Item("username")
            fname = dt.Rows(0).Item("firstname")
            lname = dt.Rows(0).Item("lastname")
            phone = dt.Rows(0).Item("contact_no")
            email = dt.Rows(0).Item("email")
            d.Show()
            Me.Hide()
        Else
            ErrorTimer.Start()
            ErrorMessagePanel.Visible = True
        End If
    End Sub
    Private Sub loginDateAndTime()
        Dim date_Time As String
        date_Time = DateTime.Now.ToString()
    End Sub

    Private Sub ErrorTimer_Tick(sender As Object, e As EventArgs) Handles ErrorTimer.Tick
        countError = countError + 1
        If (countError > 50) Then
            ErrorMessagePanel.Visible = False
            ErrorTimer.Dispose()
            countError = 1
        End If
    End Sub
End Class