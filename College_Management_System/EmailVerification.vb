Imports System.Net.Mail
Imports System.Data.SqlClient
Imports System.Text

Public Class EmailVerification
    Dim amm As New AddRemoveStudentStaff
    Dim con As SqlConnection = amm.dbConnect()
    Public sqls As String
    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
        check()
    End Sub
    Sub sendEmail()
        Cursor = Cursors.WaitCursor
        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.UseDefaultCredentials = False
            SmtpServer.Credentials = New Net.NetworkCredential("vbcoder977@gmail.com", "iimscollege")
            SmtpServer.Port = 587
            SmtpServer.EnableSsl = True
            SmtpServer.Host = "smtp.gmail.com"
            mail = New MailMessage()
            mail.From = New MailAddress("vbcoder977@gmail.com")
            mail.To.Add(EmailCheckTextBox.Text)
            mail.Subject = "Account Created"
            mail.Body = "Your new password is " & newpass
            SmtpServer.Send(mail)
            MsgBox("Mail has been successfully send to " & EmailCheckTextBox.Text)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Cursor = Cursors.Arrow
    End Sub

    Sub check()
        Cursor = Cursors.WaitCursor
        Dim cmd As New SqlCommand("SELECT * FROM userTbl where email = @a", con)
        cmd.Parameters.AddWithValue("@a", EmailCheckTextBox.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        If (dt.Rows.Count > 0) Then
            sqls = "UPDATE userTbl SET password = @a WHERE email = @b"
            updatePassword(sqls)
        Else
            If (dt.Rows.Count = 0) Then
                Dim cmd2 As New SqlCommand("SELECT * FROM stuTbl where email = @a", con)
                cmd2.Parameters.AddWithValue("@a", EmailCheckTextBox.Text)
                Dim da2 As New SqlDataAdapter(cmd2)
                Dim dt2 As New DataTable()
                da2.Fill(dt2)
                If (dt2.Rows.Count > 0) Then
                    sqls = "UPDATE stuTbl SET password = @a WHERE email = @b"
                    updatePassword(sqls)
                Else
                    MsgBox("Email you entered doesnt exist!!")
                End If
            End If
        End If
        Cursor = Cursors.Arrow
    End Sub
    Public newpass As String
    Sub updatePassword(sql As String)
        newpass = GeneratePassword()
        Dim cmd As New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@a", newpass)
        cmd.Parameters.AddWithValue("@b", EmailCheckTextBox.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Your password has been successfully changed!!")
        sendEmail()
    End Sub
    Function GeneratePassword()
        Dim s As String = "ABCDEFGHIJKLMNOPQRSUVWXYZ"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 25)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

    Private Sub CrossPictureBox_Click(sender As Object, e As EventArgs) Handles CrossPictureBox.Click
        Me.Close()
    End Sub
End Class