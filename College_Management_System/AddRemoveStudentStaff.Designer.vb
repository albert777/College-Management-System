<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRemoveStudentStaff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.a = New MaterialSkin.Controls.MaterialTabControl()
        Me.AddUserTab = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeleteBtn = New MetroFramework.Controls.MetroButton()
        Me.UpdateBtn = New MetroFramework.Controls.MetroButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.SearchTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SearchDataGridView = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.SendEmailCheckBox = New MaterialSkin.Controls.MaterialCheckBox()
        Me.PasswordTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.UserNameTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.FinsihBtn = New MetroFramework.Controls.MetroButton()
        Me.UserIdTextBox = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.MaritialStatusComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.EmailTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.DobDateTimePicker = New MetroFramework.Controls.MetroDateTime()
        Me.UserUploadBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.UserTypeLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.MaritialStatusLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.DobLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.GenderLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.UserIdLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.FemaleRadioBtn = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaleRadioBtn = New MaterialSkin.Controls.MaterialRadioButton()
        Me.UserTypeComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.Address2TextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Address1TextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.ContactNoTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MiddleNameTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.LastNameTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.FirstNameTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.UserImage = New System.Windows.Forms.PictureBox()
        Me.AddStudentTab = New System.Windows.Forms.TabPage()
        Me.StudentUploadBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.StudentImage = New System.Windows.Forms.PictureBox()
        Me.AllUsersTab = New System.Windows.Forms.TabPage()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.UserDataGridView = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.AllStudentsTab = New System.Windows.Forms.TabPage()
        Me.AddRemoveUserStudentTablePanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ImageOpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.a.SuspendLayout()
        Me.AddUserTab.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserUploadBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddStudentTab.SuspendLayout()
        CType(Me.StudentUploadBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AllUsersTab.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddRemoveUserStudentTablePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.a
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialTabSelector1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(1381, 32)
        Me.MaterialTabSelector1.TabIndex = 1
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'a
        '
        Me.a.Controls.Add(Me.AddUserTab)
        Me.a.Controls.Add(Me.AddStudentTab)
        Me.a.Controls.Add(Me.AllUsersTab)
        Me.a.Controls.Add(Me.AllStudentsTab)
        Me.a.Depth = 0
        Me.a.Dock = System.Windows.Forms.DockStyle.Fill
        Me.a.Location = New System.Drawing.Point(0, 32)
        Me.a.Margin = New System.Windows.Forms.Padding(0)
        Me.a.MouseState = MaterialSkin.MouseState.HOVER
        Me.a.Name = "a"
        Me.a.SelectedIndex = 0
        Me.a.Size = New System.Drawing.Size(1381, 624)
        Me.a.TabIndex = 0
        '
        'AddUserTab
        '
        Me.AddUserTab.BackColor = System.Drawing.Color.White
        Me.AddUserTab.Controls.Add(Me.Label2)
        Me.AddUserTab.Controls.Add(Me.Label1)
        Me.AddUserTab.Controls.Add(Me.DeleteBtn)
        Me.AddUserTab.Controls.Add(Me.UpdateBtn)
        Me.AddUserTab.Controls.Add(Me.PictureBox4)
        Me.AddUserTab.Controls.Add(Me.SearchTextBox)
        Me.AddUserTab.Controls.Add(Me.SearchDataGridView)
        Me.AddUserTab.Controls.Add(Me.SendEmailCheckBox)
        Me.AddUserTab.Controls.Add(Me.PasswordTextBox)
        Me.AddUserTab.Controls.Add(Me.MaterialLabel1)
        Me.AddUserTab.Controls.Add(Me.UserNameTextBox)
        Me.AddUserTab.Controls.Add(Me.FinsihBtn)
        Me.AddUserTab.Controls.Add(Me.UserIdTextBox)
        Me.AddUserTab.Controls.Add(Me.MaritialStatusComboBox)
        Me.AddUserTab.Controls.Add(Me.EmailTextBox)
        Me.AddUserTab.Controls.Add(Me.DobDateTimePicker)
        Me.AddUserTab.Controls.Add(Me.UserUploadBtn)
        Me.AddUserTab.Controls.Add(Me.UserTypeLabel)
        Me.AddUserTab.Controls.Add(Me.MaritialStatusLabel)
        Me.AddUserTab.Controls.Add(Me.DobLabel)
        Me.AddUserTab.Controls.Add(Me.GenderLabel)
        Me.AddUserTab.Controls.Add(Me.UserIdLabel)
        Me.AddUserTab.Controls.Add(Me.FemaleRadioBtn)
        Me.AddUserTab.Controls.Add(Me.MaleRadioBtn)
        Me.AddUserTab.Controls.Add(Me.UserTypeComboBox)
        Me.AddUserTab.Controls.Add(Me.Address2TextBox)
        Me.AddUserTab.Controls.Add(Me.Address1TextBox)
        Me.AddUserTab.Controls.Add(Me.ContactNoTextBox)
        Me.AddUserTab.Controls.Add(Me.MiddleNameTextBox)
        Me.AddUserTab.Controls.Add(Me.LastNameTextBox)
        Me.AddUserTab.Controls.Add(Me.FirstNameTextBox)
        Me.AddUserTab.Controls.Add(Me.UserImage)
        Me.AddUserTab.Location = New System.Drawing.Point(4, 22)
        Me.AddUserTab.Margin = New System.Windows.Forms.Padding(0)
        Me.AddUserTab.Name = "AddUserTab"
        Me.AddUserTab.Size = New System.Drawing.Size(1373, 598)
        Me.AddUserTab.TabIndex = 0
        Me.AddUserTab.Text = "Add User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(859, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 33
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(647, 455)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(143, 34)
        Me.DeleteBtn.TabIndex = 32
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseCustomBackColor = True
        Me.DeleteBtn.UseCustomForeColor = True
        Me.DeleteBtn.UseSelectable = True
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Location = New System.Drawing.Point(497, 455)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(144, 34)
        Me.UpdateBtn.TabIndex = 31
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseCustomBackColor = True
        Me.UpdateBtn.UseCustomForeColor = True
        Me.UpdateBtn.UseSelectable = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.College_Management_System.My.Resources.Resources.Search_25px
        Me.PictureBox4.Location = New System.Drawing.Point(854, 15)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 23)
        Me.PictureBox4.TabIndex = 30
        Me.PictureBox4.TabStop = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Depth = 0
        Me.SearchTextBox.Hint = "Search for user"
        Me.SearchTextBox.Location = New System.Drawing.Point(889, 18)
        Me.SearchTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.SearchTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchTextBox.SelectedText = ""
        Me.SearchTextBox.SelectionLength = 0
        Me.SearchTextBox.SelectionStart = 0
        Me.SearchTextBox.Size = New System.Drawing.Size(311, 23)
        Me.SearchTextBox.TabIndex = 29
        Me.SearchTextBox.UseSystemPasswordChar = False
        '
        'SearchDataGridView
        '
        Me.SearchDataGridView.AllowUserToAddRows = False
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SearchDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.SearchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SearchDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.SearchDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SearchDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SearchDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SearchDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.SearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SearchDataGridView.ColumnHeadersVisible = False
        Me.SearchDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SearchDataGridView.DoubleBuffered = True
        Me.SearchDataGridView.EnableHeadersVisualStyles = False
        Me.SearchDataGridView.HeaderBgColor = System.Drawing.Color.Black
        Me.SearchDataGridView.HeaderForeColor = System.Drawing.Color.White
        Me.SearchDataGridView.Location = New System.Drawing.Point(0, 519)
        Me.SearchDataGridView.Name = "SearchDataGridView"
        Me.SearchDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.SearchDataGridView.Size = New System.Drawing.Size(1373, 79)
        Me.SearchDataGridView.TabIndex = 28
        Me.SearchDataGridView.Visible = False
        '
        'SendEmailCheckBox
        '
        Me.SendEmailCheckBox.AutoSize = True
        Me.SendEmailCheckBox.Depth = 0
        Me.SendEmailCheckBox.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.SendEmailCheckBox.Location = New System.Drawing.Point(347, 399)
        Me.SendEmailCheckBox.Margin = New System.Windows.Forms.Padding(0)
        Me.SendEmailCheckBox.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.SendEmailCheckBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.SendEmailCheckBox.Name = "SendEmailCheckBox"
        Me.SendEmailCheckBox.Ripple = True
        Me.SendEmailCheckBox.Size = New System.Drawing.Size(328, 30)
        Me.SendEmailCheckBox.TabIndex = 26
        Me.SendEmailCheckBox.Text = "Send username and password to the given email"
        Me.SendEmailCheckBox.UseVisualStyleBackColor = True
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Depth = 0
        Me.PasswordTextBox.Hint = "Password"
        Me.PasswordTextBox.Location = New System.Drawing.Point(60, 466)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PasswordTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.SelectedText = ""
        Me.PasswordTextBox.SelectionLength = 0
        Me.PasswordTextBox.SelectionStart = 0
        Me.PasswordTextBox.Size = New System.Drawing.Size(199, 23)
        Me.PasswordTextBox.TabIndex = 25
        Me.PasswordTextBox.UseSystemPasswordChar = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(76, 356)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(128, 19)
        Me.MaterialLabel1.TabIndex = 24
        Me.MaterialLabel1.Text = "Login Information"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Depth = 0
        Me.UserNameTextBox.Hint = "Username"
        Me.UserNameTextBox.Location = New System.Drawing.Point(60, 415)
        Me.UserNameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UserNameTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserNameTextBox.SelectedText = ""
        Me.UserNameTextBox.SelectionLength = 0
        Me.UserNameTextBox.SelectionStart = 0
        Me.UserNameTextBox.Size = New System.Drawing.Size(199, 23)
        Me.UserNameTextBox.TabIndex = 23
        Me.UserNameTextBox.UseSystemPasswordChar = False
        '
        'FinsihBtn
        '
        Me.FinsihBtn.Location = New System.Drawing.Point(347, 455)
        Me.FinsihBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FinsihBtn.Name = "FinsihBtn"
        Me.FinsihBtn.Size = New System.Drawing.Size(143, 34)
        Me.FinsihBtn.TabIndex = 21
        Me.FinsihBtn.Text = "Finish"
        Me.FinsihBtn.Theme = MetroFramework.MetroThemeStyle.Light
        Me.FinsihBtn.UseCustomBackColor = True
        Me.FinsihBtn.UseCustomForeColor = True
        Me.FinsihBtn.UseSelectable = True
        Me.FinsihBtn.UseStyleColors = True
        '
        'UserIdTextBox
        '
        Me.UserIdTextBox.BorderColor = System.Drawing.Color.SeaGreen
        Me.UserIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserIdTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.UserIdTextBox.Location = New System.Drawing.Point(414, 68)
        Me.UserIdTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UserIdTextBox.Multiline = True
        Me.UserIdTextBox.Name = "UserIdTextBox"
        Me.UserIdTextBox.ReadOnly = True
        Me.UserIdTextBox.Size = New System.Drawing.Size(85, 29)
        Me.UserIdTextBox.TabIndex = 20
        '
        'MaritialStatusComboBox
        '
        Me.MaritialStatusComboBox.FormattingEnabled = True
        Me.MaritialStatusComboBox.ItemHeight = 23
        Me.MaritialStatusComboBox.Items.AddRange(New Object() {"Single", "Married"})
        Me.MaritialStatusComboBox.Location = New System.Drawing.Point(981, 348)
        Me.MaritialStatusComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaritialStatusComboBox.Name = "MaritialStatusComboBox"
        Me.MaritialStatusComboBox.PromptText = "Current relation"
        Me.MaritialStatusComboBox.Size = New System.Drawing.Size(218, 29)
        Me.MaritialStatusComboBox.TabIndex = 11
        Me.MaritialStatusComboBox.UseSelectable = True
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Depth = 0
        Me.EmailTextBox.Hint = "Email"
        Me.EmailTextBox.Location = New System.Drawing.Point(349, 352)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EmailTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailTextBox.SelectedText = ""
        Me.EmailTextBox.SelectionLength = 0
        Me.EmailTextBox.SelectionStart = 0
        Me.EmailTextBox.Size = New System.Drawing.Size(396, 23)
        Me.EmailTextBox.TabIndex = 10
        Me.EmailTextBox.UseSystemPasswordChar = False
        '
        'DobDateTimePicker
        '
        Me.DobDateTimePicker.Location = New System.Drawing.Point(935, 290)
        Me.DobDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DobDateTimePicker.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DobDateTimePicker.Name = "DobDateTimePicker"
        Me.DobDateTimePicker.Size = New System.Drawing.Size(265, 29)
        Me.DobDateTimePicker.TabIndex = 9
        '
        'UserUploadBtn
        '
        Me.UserUploadBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.UserUploadBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.UserUploadBtn.Image = Global.College_Management_System.My.Resources.Resources.Upload_32px
        Me.UserUploadBtn.ImageActive = Nothing
        Me.UserUploadBtn.Location = New System.Drawing.Point(60, 303)
        Me.UserUploadBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UserUploadBtn.Name = "UserUploadBtn"
        Me.UserUploadBtn.Size = New System.Drawing.Size(199, 22)
        Me.UserUploadBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UserUploadBtn.TabIndex = 16
        Me.UserUploadBtn.TabStop = False
        Me.UserUploadBtn.Zoom = 10
        '
        'UserTypeLabel
        '
        Me.UserTypeLabel.AutoSize = True
        Me.UserTypeLabel.Depth = 0
        Me.UserTypeLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.UserTypeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserTypeLabel.Location = New System.Drawing.Point(344, 296)
        Me.UserTypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UserTypeLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.UserTypeLabel.Name = "UserTypeLabel"
        Me.UserTypeLabel.Size = New System.Drawing.Size(68, 19)
        Me.UserTypeLabel.TabIndex = 15
        Me.UserTypeLabel.Text = "Usertype"
        '
        'MaritialStatusLabel
        '
        Me.MaritialStatusLabel.AutoSize = True
        Me.MaritialStatusLabel.Depth = 0
        Me.MaritialStatusLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaritialStatusLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaritialStatusLabel.Location = New System.Drawing.Point(858, 352)
        Me.MaritialStatusLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaritialStatusLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaritialStatusLabel.Name = "MaritialStatusLabel"
        Me.MaritialStatusLabel.Size = New System.Drawing.Size(107, 19)
        Me.MaritialStatusLabel.TabIndex = 15
        Me.MaritialStatusLabel.Text = "Maritial Status"
        '
        'DobLabel
        '
        Me.DobLabel.AutoSize = True
        Me.DobLabel.Depth = 0
        Me.DobLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.DobLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DobLabel.Location = New System.Drawing.Point(858, 296)
        Me.DobLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DobLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.DobLabel.Name = "DobLabel"
        Me.DobLabel.Size = New System.Drawing.Size(38, 19)
        Me.DobLabel.TabIndex = 15
        Me.DobLabel.Text = "DOB"
        '
        'GenderLabel
        '
        Me.GenderLabel.AutoSize = True
        Me.GenderLabel.Depth = 0
        Me.GenderLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.GenderLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GenderLabel.Location = New System.Drawing.Point(347, 180)
        Me.GenderLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GenderLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.GenderLabel.Name = "GenderLabel"
        Me.GenderLabel.Size = New System.Drawing.Size(56, 19)
        Me.GenderLabel.TabIndex = 15
        Me.GenderLabel.Text = "Gender"
        '
        'UserIdLabel
        '
        Me.UserIdLabel.AutoSize = True
        Me.UserIdLabel.Depth = 0
        Me.UserIdLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.UserIdLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserIdLabel.Location = New System.Drawing.Point(347, 72)
        Me.UserIdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UserIdLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.UserIdLabel.Name = "UserIdLabel"
        Me.UserIdLabel.Size = New System.Drawing.Size(52, 19)
        Me.UserIdLabel.TabIndex = 15
        Me.UserIdLabel.Text = "UserId"
        '
        'FemaleRadioBtn
        '
        Me.FemaleRadioBtn.AutoSize = True
        Me.FemaleRadioBtn.Depth = 0
        Me.FemaleRadioBtn.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.FemaleRadioBtn.Location = New System.Drawing.Point(606, 175)
        Me.FemaleRadioBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.FemaleRadioBtn.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.FemaleRadioBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.FemaleRadioBtn.Name = "FemaleRadioBtn"
        Me.FemaleRadioBtn.Ripple = True
        Me.FemaleRadioBtn.Size = New System.Drawing.Size(74, 30)
        Me.FemaleRadioBtn.TabIndex = 4
        Me.FemaleRadioBtn.TabStop = True
        Me.FemaleRadioBtn.Text = "Female"
        Me.FemaleRadioBtn.UseVisualStyleBackColor = True
        '
        'MaleRadioBtn
        '
        Me.MaleRadioBtn.AutoSize = True
        Me.MaleRadioBtn.Depth = 0
        Me.MaleRadioBtn.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaleRadioBtn.Location = New System.Drawing.Point(477, 175)
        Me.MaleRadioBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.MaleRadioBtn.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaleRadioBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaleRadioBtn.Name = "MaleRadioBtn"
        Me.MaleRadioBtn.Ripple = True
        Me.MaleRadioBtn.Size = New System.Drawing.Size(59, 30)
        Me.MaleRadioBtn.TabIndex = 3
        Me.MaleRadioBtn.TabStop = True
        Me.MaleRadioBtn.Text = "Male"
        Me.MaleRadioBtn.UseVisualStyleBackColor = True
        '
        'UserTypeComboBox
        '
        Me.UserTypeComboBox.FormattingEnabled = True
        Me.UserTypeComboBox.ItemHeight = 23
        Me.UserTypeComboBox.Items.AddRange(New Object() {"Receptionist", "Cashier", "Lecturer"})
        Me.UserTypeComboBox.Location = New System.Drawing.Point(477, 290)
        Me.UserTypeComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UserTypeComboBox.Name = "UserTypeComboBox"
        Me.UserTypeComboBox.PromptText = "Select Usertype"
        Me.UserTypeComboBox.Size = New System.Drawing.Size(267, 29)
        Me.UserTypeComboBox.TabIndex = 8
        Me.UserTypeComboBox.UseSelectable = True
        '
        'Address2TextBox
        '
        Me.Address2TextBox.Depth = 0
        Me.Address2TextBox.Hint = "Address 2"
        Me.Address2TextBox.Location = New System.Drawing.Point(861, 243)
        Me.Address2TextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Address2TextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.Address2TextBox.Name = "Address2TextBox"
        Me.Address2TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Address2TextBox.SelectedText = ""
        Me.Address2TextBox.SelectionLength = 0
        Me.Address2TextBox.SelectionStart = 0
        Me.Address2TextBox.Size = New System.Drawing.Size(339, 23)
        Me.Address2TextBox.TabIndex = 7
        Me.Address2TextBox.UseSystemPasswordChar = False
        '
        'Address1TextBox
        '
        Me.Address1TextBox.Depth = 0
        Me.Address1TextBox.Hint = "Address 1"
        Me.Address1TextBox.Location = New System.Drawing.Point(349, 243)
        Me.Address1TextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Address1TextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.Address1TextBox.Name = "Address1TextBox"
        Me.Address1TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Address1TextBox.SelectedText = ""
        Me.Address1TextBox.SelectionLength = 0
        Me.Address1TextBox.SelectionStart = 0
        Me.Address1TextBox.Size = New System.Drawing.Size(396, 23)
        Me.Address1TextBox.TabIndex = 6
        Me.Address1TextBox.UseSystemPasswordChar = False
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.Depth = 0
        Me.ContactNoTextBox.Hint = "Contact No"
        Me.ContactNoTextBox.Location = New System.Drawing.Point(861, 180)
        Me.ContactNoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ContactNoTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ContactNoTextBox.SelectedText = ""
        Me.ContactNoTextBox.SelectionLength = 0
        Me.ContactNoTextBox.SelectionStart = 0
        Me.ContactNoTextBox.Size = New System.Drawing.Size(339, 23)
        Me.ContactNoTextBox.TabIndex = 5
        Me.ContactNoTextBox.UseSystemPasswordChar = False
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.Depth = 0
        Me.MiddleNameTextBox.Hint = "Middlename"
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(662, 115)
        Me.MiddleNameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MiddleNameTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MiddleNameTextBox.SelectedText = ""
        Me.MiddleNameTextBox.SelectionLength = 0
        Me.MiddleNameTextBox.SelectionStart = 0
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(151, 23)
        Me.MiddleNameTextBox.TabIndex = 1
        Me.MiddleNameTextBox.UseSystemPasswordChar = False
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Depth = 0
        Me.LastNameTextBox.Hint = "Lastname"
        Me.LastNameTextBox.Location = New System.Drawing.Point(861, 115)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LastNameTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LastNameTextBox.SelectedText = ""
        Me.LastNameTextBox.SelectionLength = 0
        Me.LastNameTextBox.SelectionStart = 0
        Me.LastNameTextBox.Size = New System.Drawing.Size(339, 23)
        Me.LastNameTextBox.TabIndex = 2
        Me.LastNameTextBox.UseSystemPasswordChar = False
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Depth = 0
        Me.FirstNameTextBox.Hint = "Firstname"
        Me.FirstNameTextBox.Location = New System.Drawing.Point(347, 115)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FirstNameTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FirstNameTextBox.SelectedText = ""
        Me.FirstNameTextBox.SelectionLength = 0
        Me.FirstNameTextBox.SelectionStart = 0
        Me.FirstNameTextBox.Size = New System.Drawing.Size(265, 23)
        Me.FirstNameTextBox.TabIndex = 0
        Me.FirstNameTextBox.UseSystemPasswordChar = False
        '
        'UserImage
        '
        Me.UserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UserImage.Image = Global.College_Management_System.My.Resources.Resources.user_male2_512
        Me.UserImage.Location = New System.Drawing.Point(60, 66)
        Me.UserImage.Margin = New System.Windows.Forms.Padding(0)
        Me.UserImage.Name = "UserImage"
        Me.UserImage.Size = New System.Drawing.Size(199, 225)
        Me.UserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserImage.TabIndex = 0
        Me.UserImage.TabStop = False
        '
        'AddStudentTab
        '
        Me.AddStudentTab.BackColor = System.Drawing.Color.White
        Me.AddStudentTab.Controls.Add(Me.MetroComboBox1)
        Me.AddStudentTab.Controls.Add(Me.StudentUploadBtn)
        Me.AddStudentTab.Controls.Add(Me.StudentImage)
        Me.AddStudentTab.Location = New System.Drawing.Point(4, 22)
        Me.AddStudentTab.Margin = New System.Windows.Forms.Padding(0)
        Me.AddStudentTab.Name = "AddStudentTab"
        Me.AddStudentTab.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AddStudentTab.Size = New System.Drawing.Size(1373, 598)
        Me.AddStudentTab.TabIndex = 1
        Me.AddStudentTab.Text = "Add Student"
        '
        'StudentUploadBtn
        '
        Me.StudentUploadBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.StudentUploadBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.StudentUploadBtn.Image = Global.College_Management_System.My.Resources.Resources.Upload_32px
        Me.StudentUploadBtn.ImageActive = Nothing
        Me.StudentUploadBtn.Location = New System.Drawing.Point(57, 296)
        Me.StudentUploadBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StudentUploadBtn.Name = "StudentUploadBtn"
        Me.StudentUploadBtn.Size = New System.Drawing.Size(199, 22)
        Me.StudentUploadBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.StudentUploadBtn.TabIndex = 17
        Me.StudentUploadBtn.TabStop = False
        Me.StudentUploadBtn.Zoom = 10
        '
        'StudentImage
        '
        Me.StudentImage.BackgroundImage = Global.College_Management_System.My.Resources.Resources.Splash_image
        Me.StudentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StudentImage.Location = New System.Drawing.Point(57, 65)
        Me.StudentImage.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StudentImage.Name = "StudentImage"
        Me.StudentImage.Size = New System.Drawing.Size(199, 225)
        Me.StudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StudentImage.TabIndex = 2
        Me.StudentImage.TabStop = False
        '
        'AllUsersTab
        '
        Me.AllUsersTab.Controls.Add(Me.PictureBox3)
        Me.AllUsersTab.Controls.Add(Me.UserDataGridView)
        Me.AllUsersTab.Location = New System.Drawing.Point(4, 22)
        Me.AllUsersTab.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AllUsersTab.Name = "AllUsersTab"
        Me.AllUsersTab.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AllUsersTab.Size = New System.Drawing.Size(1373, 598)
        Me.AllUsersTab.TabIndex = 2
        Me.AllUsersTab.Text = "All Users"
        Me.AllUsersTab.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = Global.College_Management_System.My.Resources.Resources.user_male2_512
        Me.PictureBox3.Location = New System.Drawing.Point(525, 8)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(199, 225)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'UserDataGridView
        '
        Me.UserDataGridView.AllowUserToAddRows = False
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UserDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle23
        Me.UserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UserDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.UserDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.UserDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle25.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UserDataGridView.DefaultCellStyle = DataGridViewCellStyle25
        Me.UserDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UserDataGridView.DoubleBuffered = True
        Me.UserDataGridView.EnableHeadersVisualStyles = False
        Me.UserDataGridView.HeaderBgColor = System.Drawing.Color.Black
        Me.UserDataGridView.HeaderForeColor = System.Drawing.Color.White
        Me.UserDataGridView.Location = New System.Drawing.Point(4, 183)
        Me.UserDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.UserDataGridView.Name = "UserDataGridView"
        Me.UserDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.UserDataGridView.Size = New System.Drawing.Size(1365, 412)
        Me.UserDataGridView.TabIndex = 0
        '
        'AllStudentsTab
        '
        Me.AllStudentsTab.Location = New System.Drawing.Point(4, 22)
        Me.AllStudentsTab.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AllStudentsTab.Name = "AllStudentsTab"
        Me.AllStudentsTab.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AllStudentsTab.Size = New System.Drawing.Size(1373, 598)
        Me.AllStudentsTab.TabIndex = 3
        Me.AllStudentsTab.Text = "All Students"
        Me.AllStudentsTab.UseVisualStyleBackColor = True
        '
        'AddRemoveUserStudentTablePanel
        '
        Me.AddRemoveUserStudentTablePanel.BackColor = System.Drawing.Color.Transparent
        Me.AddRemoveUserStudentTablePanel.ColumnCount = 1
        Me.AddRemoveUserStudentTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.AddRemoveUserStudentTablePanel.Controls.Add(Me.MaterialTabSelector1, 0, 0)
        Me.AddRemoveUserStudentTablePanel.Controls.Add(Me.a, 0, 1)
        Me.AddRemoveUserStudentTablePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddRemoveUserStudentTablePanel.Location = New System.Drawing.Point(0, 0)
        Me.AddRemoveUserStudentTablePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.AddRemoveUserStudentTablePanel.Name = "AddRemoveUserStudentTablePanel"
        Me.AddRemoveUserStudentTablePanel.RowCount = 2
        Me.AddRemoveUserStudentTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.AddRemoveUserStudentTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.0!))
        Me.AddRemoveUserStudentTablePanel.Size = New System.Drawing.Size(1381, 656)
        Me.AddRemoveUserStudentTablePanel.TabIndex = 2
        '
        'ImageOpenDialog
        '
        Me.ImageOpenDialog.FileName = "ImageOpener"
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Location = New System.Drawing.Point(412, 289)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.PromptText = "Select Program"
        Me.MetroComboBox1.Size = New System.Drawing.Size(234, 29)
        Me.MetroComboBox1.TabIndex = 18
        Me.MetroComboBox1.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(351, 383)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 34
        '
        'AddRemoveStudentStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1381, 656)
        Me.Controls.Add(Me.AddRemoveUserStudentTablePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddRemoveStudentStaff"
        Me.Text = "AddRemoveStudentStaff"
        Me.a.ResumeLayout(False)
        Me.AddUserTab.ResumeLayout(False)
        Me.AddUserTab.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserUploadBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddStudentTab.ResumeLayout(False)
        CType(Me.StudentUploadBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AllUsersTab.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddRemoveUserStudentTablePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents a As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents AddUserTab As System.Windows.Forms.TabPage
    Friend WithEvents DeleteBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents UpdateBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents SearchTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents SearchDataGridView As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents SendEmailCheckBox As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents PasswordTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents UserNameTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents FinsihBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents UserIdTextBox As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents MaritialStatusComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents EmailTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents DobDateTimePicker As MetroFramework.Controls.MetroDateTime
    Friend WithEvents UserUploadBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents UserTypeLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaritialStatusLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DobLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents GenderLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents UserIdLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents FemaleRadioBtn As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaleRadioBtn As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents UserTypeComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Address2TextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Address1TextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents ContactNoTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MiddleNameTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents LastNameTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents FirstNameTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents UserImage As System.Windows.Forms.PictureBox
    Friend WithEvents AddStudentTab As System.Windows.Forms.TabPage
    Friend WithEvents StudentUploadBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents StudentImage As System.Windows.Forms.PictureBox
    Friend WithEvents AllUsersTab As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents UserDataGridView As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents AllStudentsTab As System.Windows.Forms.TabPage
    Friend WithEvents AddRemoveUserStudentTablePanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ImageOpenDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
