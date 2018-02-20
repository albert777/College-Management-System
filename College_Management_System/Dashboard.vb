Imports Transitions
Imports System.IO
Imports System.Data.SqlClient
Imports System.Text

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
                    UserImage.ImageLocation = openDialogImg.FileName
                ElseIf (a = "adminImageSelectStudents") Then
                    PictureBox4.ImageLocation = openDialogImg.FileName
                End If

            End If

        End If
    End Sub

    Private Sub addUserTb_Click(sender As Object, e As EventArgs) Handles addUserTb.Click
        Transition.run(hamburgerPnl, "Width", 55, New TransitionType_EaseInEaseOut(150))
    End Sub


    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles UserUploadBtn.Click
        imageChooser("adminImageSelectUsers")
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        imageChooser("adminImageSelectStudents")
    End Sub

    Function dbConnect()
        Dim db As New SqlConnection("Data Source=(LocalDB)\v11.0;Integrated Security=true;Database=CMS")
        Return db
    End Function

    Private Sub finishBtn_Click(sender As Object, e As EventArgs) Handles FinsihBtn.Click
        Dim gender As String
        If (MaleRadioBtn.Checked) Then
            gender = "Male"
        Else
            gender = "Female"
        End If
        Dim pass As String = GeneratePassword()
        insertUsers(FirstNameTextBox.Text, MiddleNameTextBox.Text, LastNameTextBox.Text, gender, ContactNoTextBox.Text, Address1TextBox.Text, Address2TextBox.Text, UserTypeComboBox.Text, DobDateTimePicker.Text, EmailTextBox.Text, MaritialStatusComboBox.Text, pass)
    End Sub

    Public Sub insertUsers(ByVal fn As String, ByVal mn As String, ByVal ln As String, ByVal gender As String, ByVal contactNo As String, ByVal addressOne As String, ByVal addressTwo As String, ByVal userType As String, ByVal dob As String, ByVal email As String, ByVal maritialStatus As String, ByVal password As String)
        Dim con As SqlConnection = dbConnect()
        Try
            Dim cmd As New SqlCommand("INSERT INTO userTbl values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l)", con)
            Dim tableName As String = fn & "_user_" & userType & "_" & addressOne
            Dim cmd2 As New SqlCommand("CREATE TABLE " & tableName & "(id INT NOT NULL PRIMARY KEY IDENTITY,date NVARCHAR(50) NULL)", con)
            cmd.Parameters.AddWithValue("@a", fn)
            cmd.Parameters.AddWithValue("@b", mn)
            cmd.Parameters.AddWithValue("@c", ln)
            cmd.Parameters.AddWithValue("@d", gender)
            cmd.Parameters.AddWithValue("@e", contactNo)
            cmd.Parameters.AddWithValue("@f", addressOne)
            cmd.Parameters.AddWithValue("@g", addressTwo)
            cmd.Parameters.AddWithValue("@h", userType)
            cmd.Parameters.AddWithValue("@i", dob)
            cmd.Parameters.AddWithValue("@j", email)
            cmd.Parameters.AddWithValue("@k", maritialStatus)
            cmd.Parameters.AddWithValue("@l", password)
            con.Open()
            cmd.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Function GeneratePassword()
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class