Imports Transitions
Imports System.IO
Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports MaterialSkin.Controls
Imports MetroFramework.Controls
Imports System.Net.Mail
Imports BunifuAnimatorNS

Public Class Dashboard
    Private Sub hamburgerPb_Click_1(sender As Object, e As EventArgs) Handles hamburgerPb.Click
        If (hamburgerPnl.Width < 250) Then
            Transition.run(hamburgerPnl, "Width", 250, New TransitionType_EaseInEaseOut(150))
        Else
            Transition.run(hamburgerPnl, "Width", 55, New TransitionType_EaseInEaseOut(150))
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        BunifuTransition1.ShowSync(dashboardMainPnl, False, Nothing)
        dashboardTablePnl.Visible = True
        dashboardTablePnl.Enabled = True
    End Sub
    Sub imageChooser(ByVal a As String)
        ImageOpenDialog.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        ImageOpenDialog.FilterIndex = 2
        ImageOpenDialog.RestoreDirectory = True
        If ImageOpenDialog.ShowDialog() = DialogResult.OK Then
            If File.Exists(ImageOpenDialog.FileName) = False Then
                MessageBox.Show("Sorry, The File You Specified Does Not Exist.")
            Else
                If (a = "UserUploadBtn") Then
                    UserImage.ImageLocation = ImageOpenDialog.FileName
                ElseIf (a = "StudentUploadBtn") Then
                    StudentImage.ImageLocation = ImageOpenDialog.FileName
                End If

            End If

        End If
    End Sub

    Private Sub addUserTb_Click(sender As Object, e As EventArgs) Handles AddUserTab.Click
        Transition.run(hamburgerPnl, "Width", 55, New TransitionType_EaseInEaseOut(150))
    End Sub


    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles UserUploadBtn.Click
        imageChooser("UserUploadBtn")
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles StudentUploadBtn.Click
        imageChooser("StudentUploadBtn")
    End Sub

    Function dbConnect()
        Dim db As New SqlConnection("Data Source=(LocalDB)\v11.0;Integrated Security=true;Database=CMS")
        Return db
    End Function
    Sub clearAll()
        Dim textboxArray() As MaterialSingleLineTextField = New MaterialSingleLineTextField() {FirstNameTextBox, LastNameTextBox, MiddleNameTextBox, ContactNoTextBox, EmailTextBox, Address1TextBox, Address2TextBox, UserNameTextBox, PasswordTextBox}
        For Each values As MaterialSingleLineTextField In textboxArray
            values.Text = ""
        Next
        Dim radiobuttonArray() As MaterialRadioButton = New MaterialRadioButton() {MaleRadioBtn, FemaleRadioBtn}
        For Each values As MaterialRadioButton In radiobuttonArray
            values.Checked = False
        Next
        Dim comboboxArray() As MetroComboBox = New MetroComboBox() {UserTypeComboBox, MaritialStatusComboBox}
        For Each values As MetroComboBox In comboboxArray
            values.SelectedIndex = -1
        Next
        DobDateTimePicker.Value = DateTime.Today.ToString
    End Sub
    Private Sub finishBtn_Click(sender As Object, e As EventArgs) Handles FinsihBtn.Click
        Dim gender As String
        If (MaleRadioBtn.Checked) Then
            gender = "Male"
        Else
            gender = "Female"
        End If
        insertUsers(FirstNameTextBox.Text, MiddleNameTextBox.Text, LastNameTextBox.Text, gender, ContactNoTextBox.Text, Address1TextBox.Text, Address2TextBox.Text, UserTypeComboBox.Text, DobDateTimePicker.Text, EmailTextBox.Text, MaritialStatusComboBox.Text, UserNameTextBox.Text, PasswordTextBox.Text)
        If (SendEmailCheckBox.Checked) Then
            sendEmail()
        End If
        clearAll()
        PasswordTextBox.Text = GeneratePassword()
        loadUsers()
    End Sub

    Public Sub insertUsers(ByVal fn As String, ByVal mn As String, ByVal ln As String, ByVal gender As String, ByVal contactNo As String, ByVal addressOne As String, ByVal addressTwo As String, ByVal userType As String, ByVal dob As String, ByVal email As String, ByVal maritialStatus As String, ByVal username As String, ByVal password As String)
        Dim con As SqlConnection = dbConnect()
        Dim img As Image = Image.FromFile(ImageOpenDialog.FileName)
        Dim ms As New MemoryStream()
        img.Save(ms, img.RawFormat)
        Dim imageBuffer As Byte() = ms.GetBuffer
        Try
            Dim cmd As New SqlCommand("INSERT INTO userTbl values(@firstname,@middlename,@lastname,@gender,@contact,@addressone,@addresstwo,@usertype,@dob,@email,@maritialstatus,@username,@password,@loadimage)", con)
            Dim tableName As String = fn & "_user_" & userType & "_" & contactNo

            cmd.Parameters.AddWithValue("@firstname", fn)
            cmd.Parameters.AddWithValue("@middlename", mn)
            cmd.Parameters.AddWithValue("@lastname", ln)
            cmd.Parameters.AddWithValue("@gender", gender)
            cmd.Parameters.AddWithValue("@contact", contactNo)
            cmd.Parameters.AddWithValue("@addressone", addressOne)
            cmd.Parameters.AddWithValue("@addresstwo", addressTwo)
            cmd.Parameters.AddWithValue("@usertype", userType)
            cmd.Parameters.AddWithValue("@dob", dob)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@maritialstatus", maritialStatus)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@loadimage", imageBuffer)
            con.Open()
            cmd.ExecuteNonQuery()
            If (userType = "Cashier") Then
                Dim cmd2 As New SqlCommand("CREATE TABLE " & tableName & "(id INT NOT NULL PRIMARY KEY IDENTITY,date NVARCHAR(50) NULL)", con)
                cmd2.ExecuteNonQuery()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Function GeneratePassword()
        Dim Bytes() As Byte
        Dim s As String = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0!1@2#3$4%5^6&7*89"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 70)
            sb.Append(s.Substring(idx, 1))
        Next
        Bytes = Encoding.Default.GetBytes(sb.ToString)
        Bytes = MD5.Create().ComputeHash(Bytes)
        For x As Integer = 0 To Bytes.Length - 1
            sb.Append(Bytes(x).ToString("x2"))
        Next
        Return sb.ToString()
    End Function
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordTextBox.Text = GeneratePassword()
        loadUsers()
    End Sub
    Private Sub sendEmail()
        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.UseDefaultCredentials = False
            SmtpServer.Credentials = New Net.NetworkCredential("", "")
            SmtpServer.Port = 587
            SmtpServer.EnableSsl = True
            SmtpServer.Host = "smtp.gmail.com"
            mail = New MailMessage()
            mail.From = New MailAddress("")
            mail.To.Add(EmailTextBox.Text)
            mail.Subject = "Account Created"
            mail.Body = "Your account have been created" & UserTypeComboBox.Text & "" & vbNewLine & "Username: " & UserNameTextBox.Text & "" & vbNewLine & "Password: " & PasswordTextBox.Text
            SmtpServer.Send(mail)
            MsgBox("Mail has been successfully send to " & EmailTextBox.Text)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub loadUsers()
        Dim con As SqlConnection = dbConnect()
        Dim cmd As New SqlCommand("Select * FROM userTbl", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.RowTemplate.Height = 100
        DataGridView1.AllowUserToResizeColumns = True
        Dim imgc As DataGridViewColumn
        DataGridView1.DataSource = dt
        imgc = DataGridView1.Columns(14)
    End Sub

End Class