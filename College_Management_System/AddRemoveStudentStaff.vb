Imports Transitions
Imports System.IO
Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports MaterialSkin.Controls
Imports MetroFramework.Controls
Imports System.Net.Mail
Imports BunifuAnimatorNS
Imports System.Text.RegularExpressions



Public Class AddRemoveStudentStaff
    Dim userId As Integer
    Dim state As Integer = 1

    'Browse images
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

    'dashboard load method
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordTextBox.Text = GeneratePassword()
        loadUsers("Select * FROM userTbl WHERE state = 1")
        UserDataGridView.Columns(14).Visible = False
        UserDataGridView.Columns(15).Visible = False
        AdminUserDataGridView.Columns(14).Visible = False
        AdminUserDataGridView.Columns(15).Visible = False
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles UserUploadBtn.Click
        imageChooser("UserUploadBtn")
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles StudentUploadButton.Click
        imageChooser("StudentUploadBtn")
    End Sub

    'Connect the database
    Function dbConnect()
        Dim db As New SqlConnection("Data Source=(LocalDB)\v11.0;Integrated Security=true;Database=CMS")
        Return db
    End Function

    'Clear all the textbox
    Sub clearAll()
        Dim textboxArray() As MaterialSingleLineTextField = New MaterialSingleLineTextField() {FirstNameTextBox, LastNameTextBox, MiddleNameTextBox, ContactNoTextBox, EmailTextBox, Address1TextBox, Address2TextBox, UserNameTextBox, PasswordTextBox}
        For Each values As MaterialSingleLineTextField In textboxArray
            values.Text = ""
        Next
        UserIdTextBox.Text = ""
        Dim radiobuttonArray() As MaterialRadioButton = New MaterialRadioButton() {MaleRadioBtn, FemaleRadioBtn}
        For Each values As MaterialRadioButton In radiobuttonArray
            values.Checked = False
        Next
        Dim comboboxArray() As MetroComboBox = New MetroComboBox() {UserTypeComboBox, MaritialStatusComboBox}
        For Each values As MetroComboBox In comboboxArray
            values.SelectedIndex = -1
        Next
        DobDateTimePicker.Value = DateTime.Today.ToString
        UserImage.Image = My.Resources.user_male2_512
        PasswordTextBox.Text = GeneratePassword()
    End Sub

    'Add to database => user
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
        UserImage.Image = My.Resources.user_male2_512
        clearAll()
        PasswordTextBox.Text = GeneratePassword()
        loadUsers("Select * FROM userTbl WHERE state = 1")
    End Sub

    'Insert users to the database
    Public Sub insertUsers(ByVal fn As String, ByVal mn As String, ByVal ln As String, ByVal gender As String, ByVal contactNo As String, ByVal addressOne As String, ByVal addressTwo As String, ByVal userType As String, ByVal dob As String, ByVal email As String, ByVal maritialStatus As String, ByVal username As String, ByVal password As String)
        Dim con As SqlConnection = dbConnect()
        Dim img As Image = Image.FromFile(ImageOpenDialog.FileName)
        Dim ms As New MemoryStream()
        img.Save(ms, img.RawFormat)
        Dim imageBuffer As Byte() = ms.GetBuffer
        Try
            Dim cmd As New SqlCommand("INSERT INTO userTbl values(@firstname,@middlename,@lastname,@gender,@contact,@addressone,@addresstwo,@usertype,@dob,@email,@maritialstatus,@username,@password,@loadimage,@state)", con)
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
            cmd.Parameters.AddWithValue("@state", state)
            con.Open()
            checkEmailFormat()
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
    'If password is not set generate random text and convert to MD5 version
    Function GeneratePassword()
        'Dim Bytes() As Byte
        'Dim s As String = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0!1@2#3$4%5^6&7*89"
        Dim s As String = "ABCDEFGHIJKLMNOPQRSUVWXYZ"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 5
            Dim idx As Integer = r.Next(0, 25)
            sb.Append(s.Substring(idx, 1))
        Next
        'Bytes = Encoding.Default.GetBytes(sb.ToString)
        'Bytes = MD5.Create().ComputeHash(Bytes)
        'For x As Integer = 0 To Bytes.Length - 1
        '    sb.Append(Bytes(x).ToString("x2"))
        'Next
        Return sb.ToString()
    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    'Send email to the set area
    Private Sub sendEmail()
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
            mail.To.Add(EmailTextBox.Text)
            mail.Subject = "Account Created"
            mail.Body = "Your account have been created as a " & UserTypeComboBox.Text & "" & vbNewLine & "Username: " & UserNameTextBox.Text & "" & vbNewLine & "Password: " & PasswordTextBox.Text
            SmtpServer.Send(mail)
            MsgBox("Mail has been successfully send to " & EmailTextBox.Text)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'load users in database
    Public Function loadUsers(ByVal sql As String)
        Dim con As SqlConnection = dbConnect()
        Dim cmd As New SqlCommand(sql, con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        UserDataGridView.DataSource = dt
        AdminUserDataGridView.DataSource = dt
        Return dt
    End Function

    'load users
    Private Sub UserDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles UserDataGridView.RowHeaderMouseClick
        Dim img() As Byte
        img = UserDataGridView.CurrentRow.Cells(14).Value
        Dim ms As New MemoryStream(img)
        OnlyViewUserPictureBox.Image = Image.FromStream(ms)
    End Sub

    'Search for users
    Private Sub searchData()
        Dim con As SqlConnection = dbConnect()
        Dim cmd As New SqlCommand("Select * FROM userTbl WHERE username LIKE @a AND state = 1 ", con)
        cmd.Parameters.AddWithValue("@a", SearchTextBox.Text + "%")
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        AdminUserDataGridView.DataSource = dt
        If (SearchTextBox.Text = "") Then
            UserImage.Image = My.Resources.user_male2_512
            clearAll()
            PasswordTextBox.Text = GeneratePassword()
        End If
    End Sub

    'Searching method and set it to the textbox
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        searchData()
    End Sub

    'show table data to view
    Private Sub AdminUserDataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles AdminUserDataGridView.CellMouseClick
        userId = AdminUserDataGridView.CurrentRow.Cells(0).Value.ToString()
        UserIdTextBox.Text = AdminUserDataGridView.CurrentRow.Cells(0).Value.ToString()
        FirstNameTextBox.Text = AdminUserDataGridView.CurrentRow.Cells(1).Value.ToString()
        MiddleNameTextBox.Text = AdminUserDataGridView.CurrentRow.Cells(2).Value.ToString()
        LastNameTextBox.Text = AdminUserDataGridView.CurrentRow.Cells(3).Value.ToString()
        Dim gender As String = AdminUserDataGridView.CurrentRow.Cells(4).Value.ToString()
        If (gender = "Male") Then
            MaleRadioBtn.Checked = True
        Else
            FemaleRadioBtn.Checked = True
        End If
        ContactNoTextBox.Text = AdminUserDataGridView.CurrentRow.Cells(5).Value.ToString()
        Address1TextBox.Text = AdminUserDataGridView.CurrentRow.Cells(6).Value.ToString()
        Address2TextBox.Text = AdminUserDataGridView.CurrentRow.Cells(7).Value.ToString()
        UserTypeComboBox.Text = AdminUserDataGridView.CurrentRow.Cells(8).Value.ToString()
        DobDateTimePicker.Text = AdminUserDataGridView.CurrentRow.Cells(9).Value.ToString()
        EmailTextBox.Text = AdminUserDataGridView.CurrentRow.Cells(10).Value.ToString()
        MaritialStatusComboBox.Text = AdminUserDataGridView.CurrentRow.Cells(11).Value.ToString()
        UserNameTextBox.Text = AdminUserDataGridView.CurrentRow.Cells(12).Value.ToString()
        PasswordTextBox.Text = AdminUserDataGridView.CurrentRow.Cells(13).Value.ToString()

        Dim img() As Byte
        img = AdminUserDataGridView.CurrentRow.Cells(14).Value
        Dim ms As New MemoryStream(img)
        UserImage.Image = Image.FromStream(ms)
    End Sub

    'update method caller
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Dim gender As String
        If (MaleRadioBtn.Checked) Then
            gender = "Male"
        Else
            gender = "Female"
        End If
        updateUsers(FirstNameTextBox.Text, MiddleNameTextBox.Text, LastNameTextBox.Text, gender, ContactNoTextBox.Text, Address1TextBox.Text, Address2TextBox.Text, UserTypeComboBox.Text, DobDateTimePicker.Text, EmailTextBox.Text, MaritialStatusComboBox.Text, UserNameTextBox.Text, PasswordTextBox.Text)
        If (SendEmailCheckBox.Checked) Then
            sendEmail()
        End If
        UserImage.Image = My.Resources.user_male2_512
        clearAll()
        PasswordTextBox.Text = GeneratePassword()
        loadUsers("Select * FROM userTbl WHERE state = 1")
        searchData()
    End Sub

    'Method to update the existing users
    Public Sub updateUsers(ByVal fn As String, ByVal mn As String, ByVal ln As String, ByVal gender As String, ByVal contactNo As String, ByVal addressOne As String, ByVal addressTwo As String, ByVal userType As String, ByVal dob As String, ByVal email As String, ByVal maritialStatus As String, ByVal username As String, ByVal password As String)
        Dim con As SqlConnection = dbConnect()
        Dim img As Image = Image.FromFile(ImageOpenDialog.FileName)
        Dim ms As New MemoryStream()
        img.Save(ms, img.RawFormat)
        Dim imageBuffer As Byte() = ms.GetBuffer
        Try
            Dim cmd As New SqlCommand("UPDATE userTbl SET firstname = @firstname,middlename = @middlename,lastname = @lastname,gender = @gender,contact_no = @contact,address_1 = @addressone,address_2 = @addresstwo,usertype = @usertype,dob = @dob,email = @email,marital_status = @maritialstatus,username = @username,password = @password,image = @loadimage, state=@state WHERE Id=@userId", con)
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
            cmd.Parameters.AddWithValue("@state", state)
            cmd.Parameters.AddWithValue("@userId", userId)
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

    'Sub method to delete the selected user
    Sub deleteUsers()
        Try
            Dim con As SqlConnection = dbConnect()
            Dim cmd As New SqlCommand("UPDATE userTbl SET state = @state WHERE Id=@userId", con)
            Dim passive As Integer = 0
            cmd.Parameters.AddWithValue("@state", passive)
            cmd.Parameters.AddWithValue("@userId", userId)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Dim r As RecycleBin = New RecycleBin
            r.loadUsers()
        End Try
    End Sub

    'Delete method caller
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        deleteUsers()
        UserImage.Image = My.Resources.user_male2_512
        clearAll()
        PasswordTextBox.Text = GeneratePassword()
        searchData()
        loadUsers("Select * FROM userTbl WHERE state = 1")
    End Sub

    'Çheck contact format
    Sub contactNoChecker()
        Dim chars() As Char = ContactNoTextBox.Text
        If (ContactNoTextBox.TextLength > 10) Then
            PhoneNoValidateLabel.Text = "Only 10 Digit phone number" + vbNewLine + "Eg: 9808546858"
        Else
            PhoneNoValidateLabel.Text = ""
        End If
        For Each c As Char In chars
            If Not IsNumeric(c) Then
                PhoneNoValidateLabel.Text = "Numbers only allowed"
            End If
        Next
    End Sub

    Private Sub ContactNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContactNoTextBox.TextChanged
        contactNoChecker()
    End Sub

    'Check email format
    Sub checkEmailFormat()
        Dim strMessage As String = ""
        Dim regex As Regex = New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Dim IsMatch As Boolean = regex.IsMatch(EmailTextBox.Text)
        If IsMatch Then
            EmailValidateLabel.Text = ""
        Else
            EmailValidateLabel.Text = "Invalid format"
            If (EmailTextBox.Text = "") Then
                EmailValidateLabel.Text = ""
            End If
        End If
    End Sub

    Private Sub EmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged
        checkEmailFormat()
    End Sub

    Private Sub AddUserTab_Click(sender As Object, e As EventArgs) Handles AddUserTab.Click

    End Sub

    Private Sub ClearAllBtn_Click(sender As Object, e As EventArgs) Handles ClearAllBtn.Click
        clearAll()
        PasswordTextBox.Text = GeneratePassword()
        center(OnlyViewUserPictureBox)
    End Sub


    Sub center(ByVal a As PictureBox)
        a.Left = (a.Parent.Width \ 2) - (a.Width \ 2)
    End Sub

End Class