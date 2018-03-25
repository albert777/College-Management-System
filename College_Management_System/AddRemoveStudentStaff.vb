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
Imports System.Drawing.Imaging



Public Class AddRemoveStudentStaff
    Public userId, stuId As Integer
    Dim state As Integer = 1
    Dim userPhoto As String
    Dim studentPhoto As String
    Public studentUserType As String = "Student"
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
                    userPhoto = ImageOpenDialog.FileName
                ElseIf (a = "StudentUploadBtn") Then
                    StudentImage.ImageLocation = ImageOpenDialog.FileName
                    studentPhoto = ImageOpenDialog.FileName
                End If

            End If
        End If
    End Sub

    Private Sub UserImage_Click(sender As Object, e As EventArgs) Handles UserImage.Click
        imageChooser("UserUploadBtn")
    End Sub

    Private Sub StudentImage_Click(sender As Object, e As EventArgs) Handles StudentImage.Click
        imageChooser("StudentUploadBtn")
    End Sub

    Sub loadEverything()
        Dim dt As DataTable = loadUsers("Select * FROM userTbl WHERE state = 1")
        Dim dt2 As DataTable = loadUsers("Select * FROM stuTbl WHERE state = 1")
        'for admin
        AdminUserDataGridView.DataSource = dt
        AdminUserDataGridView.Columns(15).Visible = False
        AdminUserDataGridView.Columns(14).Visible = False
        'For other users who just views 
        UserDataGridView.DataSource = dt
        UserDataGridView.Columns(15).Visible = False
        UserDataGridView.Columns(14).Visible = False
        UserDataGridView.Columns(13).Visible = False
        UserDataGridView.Columns(12).Visible = False
        'for admin
        AdminStudentDataGridView.DataSource = dt2
        AdminStudentDataGridView.Columns(22).Visible = False
        AdminStudentDataGridView.Columns(21).Visible = False
        AdminStudentDataGridView.Columns(20).Visible = False
        'For other users who just views 
        StudentDataGridView.DataSource = dt2
        StudentDataGridView.Columns(22).Visible = False
        StudentDataGridView.Columns(21).Visible = False
        StudentDataGridView.Columns(20).Visible = False
        StudentDataGridView.Columns(19).Visible = False
        StudentDataGridView.Columns(18).Visible = False
        StudentDataGridView.Columns(17).Visible = False

        PasswordTextBox.Text = GeneratePassword()
        StudentPasswordTextBoxs.Text = GeneratePassword()
        loadPrograms()
        SUpdateButton.Enabled = False
        SDeleteButton.Enabled = False
        UUpdateButton.Enabled = False
        UDeleteButton.Enabled = False
    End Sub
    'dashboard load method
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadEverything()
    End Sub

    'Connect the database
    Function dbConnect()
        Dim db As New SqlConnection("Data Source=(LocalDB)\v11.0;Integrated Security=true;Database=CMS")
        Return db
    End Function

    'Clear all the textbox users
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

    Sub clearAllStudent()
        Dim textboxArray() As MaterialSingleLineTextField = New MaterialSingleLineTextField() {FirstNameTextBoxs, LastNameTextBoxes, MiddleNameTextBoxs, CurrentAddressTextBoxs, PermanentAddressTextBoxs, DistrictTextBoxs, PhoneNoTextBoxs, EmailAddressTextBoxs, GuardianNameTextBoxs, GuardianContactTextBoxs, ReligionTextBoxs, LanguageTextBoxs, StudentUsernameTextBoxs, StudentPasswordTextBoxs}
        For Each values As MaterialSingleLineTextField In textboxArray
            values.Text = ""
        Next
        StudentIdTextBoxs.Text = ""
        Dim comboboxArray() As MetroComboBox = New MetroComboBox() {CourseComboBoxs, MaritialStatusComboBoxs, GenderComboBoxs, ScholarshipComboBoxs}
        For Each values As MetroComboBox In comboboxArray
            values.SelectedIndex = -1
        Next
        Dobs.Value = DateTime.Today.ToString
        StudentImage.Image = My.Resources.user_male2_512
        StudentPasswordTextBoxs.Text = GeneratePassword()
        SSubmitButton.Enabled = True
    End Sub
    'load users in database
    Public Function loadUsers(ByVal sql As String)
        Dim con As SqlConnection = dbConnect()
        Dim cmd As New SqlCommand(sql, con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Sub refreshUsers()
        Dim dt As DataTable = loadUsers("SELECT  * FROM userTbl WHERE state = 1")
        AdminUserDataGridView.DataSource = dt
        UserDataGridView.DataSource = dt
    End Sub

    'Add to database => user
    Private Sub finishBtn_Click(sender As Object, e As EventArgs) Handles UFinishButton.Click
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
        refreshUsers()
    End Sub

    'Insert users to the database
    Public Sub insertUsers(ByVal fn As String, ByVal mn As String, ByVal ln As String, ByVal gender As String, ByVal contactNo As String, ByVal addressOne As String, ByVal addressTwo As String, ByVal userType As String, ByVal dob As String, ByVal email As String, ByVal maritialStatus As String, ByVal username As String, ByVal password As String)
        Dim con As SqlConnection = dbConnect()
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
            Dim imgData As Byte()
            imgData = ImgToByteArray(UserImage.Image)
            cmd.Parameters.AddWithValue("@loadimage", imgData)
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
        UFinishButton.Enabled = False
        SUpdateButton.Enabled = True
        SDeleteButton.Enabled = True
    End Sub
    'If password is not set generate random text and convert to MD5 version
    Function GeneratePassword()
        'Dim Bytes() As Byte
        'Dim s As String = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0!1@2#3$4%5^6&7*89"
        Dim s As String = "ABCDEFGHIJKLMNOPQRSUVWXYZ"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8
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

    'load users
    Private Sub UserDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles UserDataGridView.RowHeaderMouseClick
        Dim img() As Byte
        img = UserDataGridView.CurrentRow.Cells(14).Value
        Dim ms As New MemoryStream(img)
        OnlyViewUserPictureBox.Image = Image.FromStream(ms)
    End Sub

    'Search for users
    Private Sub searchData(dtv As DataGridView, sql As String, searchTextBox As MaterialSingleLineTextField, image As PictureBox, pass As MaterialSingleLineTextField, clear As String)
        Dim con As SqlConnection = dbConnect()
        Dim cmd As New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@a", searchTextBox.Text + "%")
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dtv.DataSource = dt
        If (searchTextBox.Text = "") Then
            image.Image = My.Resources.user_male2_512
            If (clear = "searchUser") Then
                clearAll()
            Else
                clearAllStudent()
            End If
            pass.Text = GeneratePassword()
        End If
    End Sub
    'Searching method and set it to the textbox for user
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        searchData(AdminUserDataGridView, "SELECT * FROM userTbl WHERE username LIKE @a AND state = 1", SearchTextBox, UserImage, PasswordTextBox, "searchUser")
    End Sub

    'show table data to view
    Private Sub AdminUserDataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles AdminUserDataGridView.CellMouseClick
        UUpdateButton.Enabled = True
        UDeleteButton.Enabled = True
        UFinishButton.Enabled = False
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
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles UUpdateButton.Click
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
    End Sub
    Public Shared Function ImgToByteArray(img As Image) As Byte()
        Dim ms As New MemoryStream()
        img.Save(ms, img.RawFormat)
        Dim imageBuffer As Byte() = ms.GetBuffer
        Return imageBuffer
    End Function

    'Method to update the existing users
    Public Sub updateUsers(ByVal fn As String, ByVal mn As String, ByVal ln As String, ByVal gender As String, ByVal contactNo As String, ByVal addressOne As String, ByVal addressTwo As String, ByVal userType As String, ByVal dob As String, ByVal email As String, ByVal maritialStatus As String, ByVal username As String, ByVal password As String)
        Dim con As SqlConnection = dbConnect()
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
            Dim imgData As Byte()
            imgData = ImgToByteArray(UserImage.Image)
            cmd.Parameters.AddWithValue("@loadimage", imgData)
            cmd.Parameters.AddWithValue("@state", state)
            cmd.Parameters.AddWithValue("@userId", userId)
            con.Open()
            cmd.ExecuteNonQuery()

            If (userType = "Cashier") Then
                Dim cmd2 As New SqlCommand("CREATE TABLE " & tableName & "(id INT NOT NULL PRIMARY KEY IDENTITY,date NVARCHAR(50) NULL)", con)
                cmd2.ExecuteNonQuery()
            End If
            con.Close()
            refreshUsers()
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
        End Try
    End Sub

    'Delete method caller
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles UDeleteButton.Click
        deleteUsers()
        refreshUsers()
        UserImage.Image = My.Resources.user_male2_512
        clearAll()
        PasswordTextBox.Text = GeneratePassword()
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

    Private Sub ClearAllBtn_Click(sender As Object, e As EventArgs) Handles UClearAllButton.Click
        clearAll()
        PasswordTextBox.Text = GeneratePassword()
        center(OnlyViewUserPictureBox)
    End Sub

    Sub center(ByVal a As PictureBox)
        a.Left = (a.Parent.Width \ 2) - (a.Width \ 2)
    End Sub

    Sub refreshStudents()
        Dim dt As DataTable = loadUsers("SELECT * FROM stuTbl WHERE state = 1")
        AdminStudentDataGridView.DataSource = dt
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SSubmitButton.Click
        insertStudent(FirstNameTextBoxs.Text, MiddleNameTextBoxs.Text, LastNameTextBoxes.Text, CurrentAddressTextBoxs.Text, PermanentAddressTextBoxs.Text, DistrictTextBoxs.Text, PhoneNoTextBoxs.Text, EmailAddressTextBoxs.Text, Dobs.Text, GenderComboBoxs.Text, GuardianNameTextBoxs.Text, GuardianContactTextBoxs.Text, ReligionTextBoxs.Text, MaritialStatusComboBoxs.Text, LanguageTextBoxs.Text, CourseComboBoxs.Text, ScholarshipComboBoxs.Text, StudentUsernameTextBoxs.Text, StudentPasswordTextBoxs.Text)
    End Sub
    Public Sub insertStudent(ByVal fn As String, ByVal mn As String, ByVal ln As String, ByVal cadd As String, ByVal padd As String, ByVal dis As String, ByVal phno As String, ByVal email As String, ByVal dob As String, ByVal gender As String, ByVal gn As String, ByVal gcno As String, ByVal reli As String, ByVal mstatus As String, ByVal lan As String, ByVal cour As String, ByVal scholor As String, ByVal uname As String, ByVal pass As String)
        Dim con As SqlConnection = dbConnect()
        Try
            Dim cmd As New SqlCommand("INSERT INTO stuTbl values(@fname,@mname,@lname,@caddress,@paddress,@district,@phoneno,@email,@dob,@gender,@gname,@gcontactno,@religion,@mstatus,@language,@course,@scholorship,@username,@password,@state,@image,@usertype)", con)
            cmd.Parameters.AddWithValue("@fname", fn)
            cmd.Parameters.AddWithValue("@mname", mn)
            cmd.Parameters.AddWithValue("@lname", ln)
            cmd.Parameters.AddWithValue("@caddress", cadd)
            cmd.Parameters.AddWithValue("@paddress", padd)
            cmd.Parameters.AddWithValue("@district", dis)
            cmd.Parameters.AddWithValue("@phoneno", phno)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@dob", dob)
            cmd.Parameters.AddWithValue("@gender", gender)
            cmd.Parameters.AddWithValue("@gname", gn)
            cmd.Parameters.AddWithValue("@gcontactno", gcno)
            cmd.Parameters.AddWithValue("@religion", reli)
            cmd.Parameters.AddWithValue("@mstatus", mstatus)
            cmd.Parameters.AddWithValue("@language", lan)
            cmd.Parameters.AddWithValue("@course", cour)
            cmd.Parameters.AddWithValue("@scholorship", scholor)
            cmd.Parameters.AddWithValue("@username", uname)
            cmd.Parameters.AddWithValue("@password", pass)
            cmd.Parameters.AddWithValue("@state", state)
            Dim imgData As Byte()
            imgData = ImgToByteArray(StudentImage.Image)
            cmd.Parameters.AddWithValue("@image", imgData)
            cmd.Parameters.AddWithValue("@usertype", studentUserType)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            SSubmitButton.Enabled = False
            SUpdateButton.Enabled = True
            SDeleteButton.Enabled = True
            StudentPasswordTextBoxs.Text = GeneratePassword()
            refreshStudents()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub loadPrograms()
        Dim programData As DataTable = loadUsers("SELECT * FROM tblPrograms")
        CourseComboBoxs.DataSource = programData
        CourseComboBoxs.DataSource = programData
        CourseComboBoxs.DisplayMember = "program_name"
        CourseComboBoxs.ValueMember = "Id"
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles SUpdateButton.Click
        updateStudent(FirstNameTextBoxs.Text, MiddleNameTextBoxs.Text, LastNameTextBoxes.Text, CurrentAddressTextBoxs.Text, PermanentAddressTextBoxs.Text, DistrictTextBoxs.Text, PhoneNoTextBoxs.Text, EmailAddressTextBoxs.Text, Dobs.Text, GenderComboBoxs.Text, GuardianNameTextBoxs.Text, GuardianContactTextBoxs.Text, ReligionTextBoxs.Text, MaritialStatusComboBoxs.Text, LanguageTextBoxs.Text, CourseComboBoxs.Text, ScholarshipComboBoxs.Text, StudentUsernameTextBoxs.Text, StudentPasswordTextBoxs.Text)
    End Sub
    Public Sub updateStudent(ByVal fn As String, ByVal mn As String, ByVal ln As String, ByVal cadd As String, ByVal padd As String, ByVal dis As String, ByVal phno As String, ByVal email As String, ByVal dob As String, ByVal gender As String, ByVal gn As String, ByVal gcno As String, ByVal reli As String, ByVal mstatus As String, ByVal lan As String, ByVal cour As String, ByVal scholor As String, ByVal uname As String, ByVal pass As String)
        Dim con As SqlConnection = dbConnect()

        Try
            Dim cmd As New SqlCommand("UPDATE stuTbl SET fname= @fname,mname= @mname,lname= @lname,caddress= @caddress,paddress= @paddress,district= @district,phoneno= @phoneno,email= @email,dob= @dob,gender= @gender,gname= @gname,gcontactno= @gcontactno,religion= @religion,mstatus= @mstatus,language= @language,course= @course,scholorship= @scholorship,username= @username,password= @password,image=@image WHERE Id = @stuId", con)
            cmd.Parameters.AddWithValue("@fname", fn)
            cmd.Parameters.AddWithValue("@mname", mn)
            cmd.Parameters.AddWithValue("@lname", ln)
            cmd.Parameters.AddWithValue("@caddress", cadd)
            cmd.Parameters.AddWithValue("@paddress", padd)
            cmd.Parameters.AddWithValue("@district", dis)
            cmd.Parameters.AddWithValue("@phoneno", phno)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@dob", dob)
            cmd.Parameters.AddWithValue("@gender", gender)
            cmd.Parameters.AddWithValue("@gname", gn)
            cmd.Parameters.AddWithValue("@gcontactno", gcno)
            cmd.Parameters.AddWithValue("@religion", reli)
            cmd.Parameters.AddWithValue("@mstatus", mstatus)
            cmd.Parameters.AddWithValue("@language", lan)
            cmd.Parameters.AddWithValue("@course", cour)
            cmd.Parameters.AddWithValue("@scholorship", scholor)
            cmd.Parameters.AddWithValue("@username", uname)
            cmd.Parameters.AddWithValue("@password", pass)
            cmd.Parameters.AddWithValue("@stuId", stuId)
            Dim imgData As Byte()
            imgData = ImgToByteArray(StudentImage.Image)
            cmd.Parameters.AddWithValue("@image", imgData)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            StudentPasswordTextBoxs.Text = GeneratePassword()
            refreshStudents()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'search method call to search for students
    Private Sub SearchStudentsTextBox_Click(sender As Object, e As EventArgs) Handles SearchStudentsTextBox.TextChanged
        searchData(AdminStudentDataGridView, "SELECT * FROM stuTbl WHERE username LIKE @a AND state = 1", SearchStudentsTextBox, StudentImage, StudentPasswordTextBoxs, "searchStudent")
    End Sub

    Private Sub AdminStudentDataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles AdminStudentDataGridView.CellMouseClick
        SUpdateButton.Enabled = True
        SDeleteButton.Enabled = True
        SSubmitButton.Enabled = False
        stuId = AdminStudentDataGridView.CurrentRow.Cells(0).Value.ToString()
        StudentIdTextBoxs.Text = AdminStudentDataGridView.CurrentRow.Cells(0).Value.ToString()
        FirstNameTextBoxs.Text = AdminStudentDataGridView.CurrentRow.Cells(1).Value.ToString()
        MiddleNameTextBoxs.Text = AdminStudentDataGridView.CurrentRow.Cells(2).Value.ToString()
        LastNameTextBoxes.Text = AdminStudentDataGridView.CurrentRow.Cells(3).Value.ToString()
        CurrentAddressTextBoxs.Text = AdminStudentDataGridView.CurrentRow.Cells(4).Value.ToString()
        PermanentAddressTextBoxs.Text = AdminStudentDataGridView.CurrentRow.Cells(5).Value.ToString()
        DistrictTextBoxs.Text = AdminStudentDataGridView.CurrentRow.Cells(6).Value.ToString()
        PhoneNoTextBoxs.Text = AdminStudentDataGridView.CurrentRow.Cells(7).Value.ToString()
        EmailAddressTextBoxs.Text = AdminStudentDataGridView.CurrentRow.Cells(8).Value.ToString()
        Dobs.Text = AdminStudentDataGridView.CurrentRow.Cells(9).Value.ToString()
        GenderComboBoxs.Text = AdminStudentDataGridView.CurrentRow.Cells(10).Value.ToString()
        GuardianNameTextBoxs.Text = AdminStudentDataGridView.CurrentRow.Cells(11).Value.ToString()
        GuardianContactTextBoxs.Text = AdminStudentDataGridView.CurrentRow.Cells(12).Value.ToString()
        ReligionTextBoxs.Text = AdminStudentDataGridView.CurrentRow.Cells(13).Value.ToString()
        MaritialStatusComboBoxs.Text = AdminStudentDataGridView.CurrentRow.Cells(14).Value.ToString()
        LanguageTextBoxs.Text = AdminStudentDataGridView.CurrentRow.Cells(15).Value.ToString()
        CourseComboBoxs.Text = AdminStudentDataGridView.CurrentRow.Cells(16).Value.ToString()
        ScholarshipComboBoxs.Text = AdminStudentDataGridView.CurrentRow.Cells(17).Value.ToString()
        StudentUsernameTextBoxs.Text = AdminStudentDataGridView.CurrentRow.Cells(18).Value.ToString()
        StudentPasswordTextBoxs.Text = AdminStudentDataGridView.CurrentRow.Cells(19).Value.ToString()
        Dim img() As Byte
        img = AdminStudentDataGridView.CurrentRow.Cells(21).Value
        Dim ms As New MemoryStream(img)
        StudentImage.Image = Image.FromStream(ms)
    End Sub

    Private Sub CourseComboBoxs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CourseComboBoxs.SelectedIndexChanged

    End Sub

    Private Sub CourseComboBoxs_MouseClick(sender As Object, e As MouseEventArgs) Handles CourseComboBoxs.MouseClick
        loadPrograms()
    End Sub
  
    Private Sub SDeleteButton_Click(sender As Object, e As EventArgs) Handles SDeleteButton.Click
        deleteStudents()
        refreshStudents()
    End Sub
    Sub deleteStudents()
        Try
            Dim con As SqlConnection = dbConnect()
            Dim cmd As New SqlCommand("UPDATE stuTbl SET state = @state WHERE Id=@stuId", con)
            Dim passive As Integer = 0
            cmd.Parameters.AddWithValue("@state", passive)
            cmd.Parameters.AddWithValue("@stuId", stuId)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Dim r As RecycleBin = New RecycleBin
            r.loadUsers()
        End Try
    End Sub

    Private Sub SClearAllButton_Click(sender As Object, e As EventArgs) Handles SClearAllButton.Click
        clearAllStudent()
    End Sub
End Class