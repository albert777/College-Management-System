<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.hamburgerPnl = New System.Windows.Forms.Panel()
        Me.hamburgerPb = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dashboardMainPnl = New System.Windows.Forms.Panel()
        Me.dashboardTablePnl = New System.Windows.Forms.TableLayoutPanel()
        Me.editTablePanelAdmin = New System.Windows.Forms.TableLayoutPanel()
        Me.a = New MaterialSkin.Controls.MaterialTabControl()
        Me.AddUserTab = New System.Windows.Forms.TabPage()
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
        Me.AllUsersTab = New System.Windows.Forms.TabPage()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.UserNameTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.PasswordTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.StudentImage = New System.Windows.Forms.PictureBox()
        Me.StudentUploadBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.AllStudentsTab = New System.Windows.Forms.TabPage()
        Me.SendEmailCheckBox = New MaterialSkin.Controls.MaterialCheckBox()
        Me.hamburgerPnl.SuspendLayout()
        CType(Me.hamburgerPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dashboardMainPnl.SuspendLayout()
        Me.dashboardTablePnl.SuspendLayout()
        Me.editTablePanelAdmin.SuspendLayout()
        Me.a.SuspendLayout()
        Me.AddUserTab.SuspendLayout()
        CType(Me.UserUploadBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddStudentTab.SuspendLayout()
        CType(Me.StudentImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentUploadBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0.0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0.0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0.0!
        Animation2.RotateLimit = 0.0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0.0!
        Animation2.TransparencyCoeff = 0.0!
        Me.BunifuTransition1.DefaultAnimation = Animation2
        Me.BunifuTransition1.Interval = 26
        '
        'hamburgerPnl
        '
        Me.hamburgerPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.hamburgerPnl.Controls.Add(Me.hamburgerPb)
        Me.hamburgerPnl.Controls.Add(Me.PictureBox2)
        Me.hamburgerPnl.Controls.Add(Me.PictureBox1)
        Me.BunifuTransition1.SetDecoration(Me.hamburgerPnl, BunifuAnimatorNS.DecorationType.None)
        Me.hamburgerPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.hamburgerPnl.Location = New System.Drawing.Point(0, 0)
        Me.hamburgerPnl.Margin = New System.Windows.Forms.Padding(0)
        Me.hamburgerPnl.Name = "hamburgerPnl"
        Me.hamburgerPnl.Size = New System.Drawing.Size(55, 749)
        Me.hamburgerPnl.TabIndex = 1
        '
        'hamburgerPb
        '
        Me.hamburgerPb.BackColor = System.Drawing.Color.Transparent
        Me.hamburgerPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.hamburgerPb, BunifuAnimatorNS.DecorationType.None)
        Me.hamburgerPb.Image = Global.College_Management_System.My.Resources.Resources.Menu_32px
        Me.hamburgerPb.Location = New System.Drawing.Point(12, 12)
        Me.hamburgerPb.Name = "hamburgerPb"
        Me.hamburgerPb.Size = New System.Drawing.Size(31, 26)
        Me.hamburgerPb.TabIndex = 1
        Me.hamburgerPb.TabStop = False
        '
        'PictureBox2
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = Global.College_Management_System.My.Resources.Resources.Registration_32px
        Me.PictureBox2.Location = New System.Drawing.Point(12, 68)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 33)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = Global.College_Management_System.My.Resources.Resources.Admin_Settings_Male_32px
        Me.PictureBox1.Location = New System.Drawing.Point(9, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 38)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'dashboardMainPnl
        '
        Me.dashboardMainPnl.Controls.Add(Me.hamburgerPnl)
        Me.dashboardMainPnl.Controls.Add(Me.dashboardTablePnl)
        Me.BunifuTransition1.SetDecoration(Me.dashboardMainPnl, BunifuAnimatorNS.DecorationType.None)
        Me.dashboardMainPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dashboardMainPnl.Location = New System.Drawing.Point(0, 0)
        Me.dashboardMainPnl.Margin = New System.Windows.Forms.Padding(0)
        Me.dashboardMainPnl.Name = "dashboardMainPnl"
        Me.dashboardMainPnl.Size = New System.Drawing.Size(1366, 749)
        Me.dashboardMainPnl.TabIndex = 1
        '
        'dashboardTablePnl
        '
        Me.dashboardTablePnl.ColumnCount = 2
        Me.dashboardTablePnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.dashboardTablePnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.dashboardTablePnl.Controls.Add(Me.editTablePanelAdmin, 1, 0)
        Me.BunifuTransition1.SetDecoration(Me.dashboardTablePnl, BunifuAnimatorNS.DecorationType.None)
        Me.dashboardTablePnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dashboardTablePnl.Enabled = False
        Me.dashboardTablePnl.Location = New System.Drawing.Point(0, 0)
        Me.dashboardTablePnl.Margin = New System.Windows.Forms.Padding(0)
        Me.dashboardTablePnl.Name = "dashboardTablePnl"
        Me.dashboardTablePnl.RowCount = 1
        Me.dashboardTablePnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.dashboardTablePnl.Size = New System.Drawing.Size(1366, 749)
        Me.dashboardTablePnl.TabIndex = 2
        Me.dashboardTablePnl.Visible = False
        '
        'editTablePanelAdmin
        '
        Me.editTablePanelAdmin.ColumnCount = 1
        Me.editTablePanelAdmin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.editTablePanelAdmin.Controls.Add(Me.a, 0, 1)
        Me.editTablePanelAdmin.Controls.Add(Me.MaterialTabSelector1, 0, 0)
        Me.BunifuTransition1.SetDecoration(Me.editTablePanelAdmin, BunifuAnimatorNS.DecorationType.None)
        Me.editTablePanelAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editTablePanelAdmin.Location = New System.Drawing.Point(55, 0)
        Me.editTablePanelAdmin.Margin = New System.Windows.Forms.Padding(0)
        Me.editTablePanelAdmin.Name = "editTablePanelAdmin"
        Me.editTablePanelAdmin.RowCount = 2
        Me.editTablePanelAdmin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.editTablePanelAdmin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.0!))
        Me.editTablePanelAdmin.Size = New System.Drawing.Size(1311, 749)
        Me.editTablePanelAdmin.TabIndex = 0
        '
        'a
        '
        Me.a.Controls.Add(Me.AddUserTab)
        Me.a.Controls.Add(Me.AddStudentTab)
        Me.a.Controls.Add(Me.AllUsersTab)
        Me.a.Controls.Add(Me.AllStudentsTab)
        Me.BunifuTransition1.SetDecoration(Me.a, BunifuAnimatorNS.DecorationType.None)
        Me.a.Depth = 0
        Me.a.Dock = System.Windows.Forms.DockStyle.Fill
        Me.a.Location = New System.Drawing.Point(0, 37)
        Me.a.Margin = New System.Windows.Forms.Padding(0)
        Me.a.MouseState = MaterialSkin.MouseState.HOVER
        Me.a.Name = "a"
        Me.a.SelectedIndex = 0
        Me.a.Size = New System.Drawing.Size(1311, 712)
        Me.a.TabIndex = 0
        '
        'AddUserTab
        '
        Me.AddUserTab.BackColor = System.Drawing.Color.White
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
        Me.BunifuTransition1.SetDecoration(Me.AddUserTab, BunifuAnimatorNS.DecorationType.None)
        Me.AddUserTab.Location = New System.Drawing.Point(4, 24)
        Me.AddUserTab.Margin = New System.Windows.Forms.Padding(0)
        Me.AddUserTab.Name = "AddUserTab"
        Me.AddUserTab.Size = New System.Drawing.Size(1303, 684)
        Me.AddUserTab.TabIndex = 0
        Me.AddUserTab.Text = "Add User"
        '
        'FinsihBtn
        '
        Me.BunifuTransition1.SetDecoration(Me.FinsihBtn, BunifuAnimatorNS.DecorationType.Custom)
        Me.FinsihBtn.Location = New System.Drawing.Point(348, 455)
        Me.FinsihBtn.Name = "FinsihBtn"
        Me.FinsihBtn.Size = New System.Drawing.Size(142, 34)
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
        Me.BunifuTransition1.SetDecoration(Me.UserIdTextBox, BunifuAnimatorNS.DecorationType.None)
        Me.UserIdTextBox.Location = New System.Drawing.Point(414, 67)
        Me.UserIdTextBox.Multiline = True
        Me.UserIdTextBox.Name = "UserIdTextBox"
        Me.UserIdTextBox.ReadOnly = True
        Me.UserIdTextBox.Size = New System.Drawing.Size(85, 29)
        Me.UserIdTextBox.TabIndex = 20
        '
        'MaritialStatusComboBox
        '
        Me.BunifuTransition1.SetDecoration(Me.MaritialStatusComboBox, BunifuAnimatorNS.DecorationType.None)
        Me.MaritialStatusComboBox.FormattingEnabled = True
        Me.MaritialStatusComboBox.ItemHeight = 23
        Me.MaritialStatusComboBox.Items.AddRange(New Object() {"Single", "Married"})
        Me.MaritialStatusComboBox.Location = New System.Drawing.Point(981, 347)
        Me.MaritialStatusComboBox.Name = "MaritialStatusComboBox"
        Me.MaritialStatusComboBox.PromptText = "Current relation"
        Me.MaritialStatusComboBox.Size = New System.Drawing.Size(218, 29)
        Me.MaritialStatusComboBox.TabIndex = 11
        Me.MaritialStatusComboBox.UseSelectable = True
        '
        'EmailTextBox
        '
        Me.BunifuTransition1.SetDecoration(Me.EmailTextBox, BunifuAnimatorNS.DecorationType.None)
        Me.EmailTextBox.Depth = 0
        Me.EmailTextBox.Hint = "Email"
        Me.EmailTextBox.Location = New System.Drawing.Point(349, 353)
        Me.EmailTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailTextBox.SelectedText = ""
        Me.EmailTextBox.SelectionLength = 0
        Me.EmailTextBox.SelectionStart = 0
        Me.EmailTextBox.Size = New System.Drawing.Size(395, 23)
        Me.EmailTextBox.TabIndex = 10
        Me.EmailTextBox.UseSystemPasswordChar = False
        '
        'DobDateTimePicker
        '
        Me.BunifuTransition1.SetDecoration(Me.DobDateTimePicker, BunifuAnimatorNS.DecorationType.None)
        Me.DobDateTimePicker.Location = New System.Drawing.Point(934, 290)
        Me.DobDateTimePicker.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DobDateTimePicker.Name = "DobDateTimePicker"
        Me.DobDateTimePicker.Size = New System.Drawing.Size(265, 29)
        Me.DobDateTimePicker.TabIndex = 9
        '
        'UserUploadBtn
        '
        Me.UserUploadBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.UserUploadBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTransition1.SetDecoration(Me.UserUploadBtn, BunifuAnimatorNS.DecorationType.None)
        Me.UserUploadBtn.Image = Global.College_Management_System.My.Resources.Resources.Upload_32px
        Me.UserUploadBtn.ImageActive = Nothing
        Me.UserUploadBtn.Location = New System.Drawing.Point(59, 303)
        Me.UserUploadBtn.Name = "UserUploadBtn"
        Me.UserUploadBtn.Size = New System.Drawing.Size(198, 23)
        Me.UserUploadBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UserUploadBtn.TabIndex = 16
        Me.UserUploadBtn.TabStop = False
        Me.UserUploadBtn.Zoom = 10
        '
        'UserTypeLabel
        '
        Me.UserTypeLabel.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.UserTypeLabel, BunifuAnimatorNS.DecorationType.None)
        Me.UserTypeLabel.Depth = 0
        Me.UserTypeLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.UserTypeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserTypeLabel.Location = New System.Drawing.Point(344, 296)
        Me.UserTypeLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.UserTypeLabel.Name = "UserTypeLabel"
        Me.UserTypeLabel.Size = New System.Drawing.Size(68, 19)
        Me.UserTypeLabel.TabIndex = 15
        Me.UserTypeLabel.Text = "Usertype"
        '
        'MaritialStatusLabel
        '
        Me.MaritialStatusLabel.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaritialStatusLabel, BunifuAnimatorNS.DecorationType.None)
        Me.MaritialStatusLabel.Depth = 0
        Me.MaritialStatusLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaritialStatusLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaritialStatusLabel.Location = New System.Drawing.Point(857, 353)
        Me.MaritialStatusLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaritialStatusLabel.Name = "MaritialStatusLabel"
        Me.MaritialStatusLabel.Size = New System.Drawing.Size(107, 19)
        Me.MaritialStatusLabel.TabIndex = 15
        Me.MaritialStatusLabel.Text = "Maritial Status"
        '
        'DobLabel
        '
        Me.DobLabel.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.DobLabel, BunifuAnimatorNS.DecorationType.None)
        Me.DobLabel.Depth = 0
        Me.DobLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.DobLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DobLabel.Location = New System.Drawing.Point(858, 296)
        Me.DobLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.DobLabel.Name = "DobLabel"
        Me.DobLabel.Size = New System.Drawing.Size(38, 19)
        Me.DobLabel.TabIndex = 15
        Me.DobLabel.Text = "DOB"
        '
        'GenderLabel
        '
        Me.GenderLabel.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.GenderLabel, BunifuAnimatorNS.DecorationType.None)
        Me.GenderLabel.Depth = 0
        Me.GenderLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.GenderLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GenderLabel.Location = New System.Drawing.Point(346, 180)
        Me.GenderLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.GenderLabel.Name = "GenderLabel"
        Me.GenderLabel.Size = New System.Drawing.Size(56, 19)
        Me.GenderLabel.TabIndex = 15
        Me.GenderLabel.Text = "Gender"
        '
        'UserIdLabel
        '
        Me.UserIdLabel.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.UserIdLabel, BunifuAnimatorNS.DecorationType.None)
        Me.UserIdLabel.Depth = 0
        Me.UserIdLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.UserIdLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserIdLabel.Location = New System.Drawing.Point(346, 72)
        Me.UserIdLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.UserIdLabel.Name = "UserIdLabel"
        Me.UserIdLabel.Size = New System.Drawing.Size(52, 19)
        Me.UserIdLabel.TabIndex = 15
        Me.UserIdLabel.Text = "UserId"
        '
        'FemaleRadioBtn
        '
        Me.FemaleRadioBtn.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.FemaleRadioBtn, BunifuAnimatorNS.DecorationType.None)
        Me.FemaleRadioBtn.Depth = 0
        Me.FemaleRadioBtn.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.FemaleRadioBtn.Location = New System.Drawing.Point(607, 175)
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
        Me.BunifuTransition1.SetDecoration(Me.MaleRadioBtn, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuTransition1.SetDecoration(Me.UserTypeComboBox, BunifuAnimatorNS.DecorationType.None)
        Me.UserTypeComboBox.FormattingEnabled = True
        Me.UserTypeComboBox.ItemHeight = 23
        Me.UserTypeComboBox.Items.AddRange(New Object() {"Receptionist", "Cashier", "Lecturer"})
        Me.UserTypeComboBox.Location = New System.Drawing.Point(477, 290)
        Me.UserTypeComboBox.Name = "UserTypeComboBox"
        Me.UserTypeComboBox.PromptText = "Select Usertype"
        Me.UserTypeComboBox.Size = New System.Drawing.Size(267, 29)
        Me.UserTypeComboBox.TabIndex = 8
        Me.UserTypeComboBox.UseSelectable = True
        '
        'Address2TextBox
        '
        Me.BunifuTransition1.SetDecoration(Me.Address2TextBox, BunifuAnimatorNS.DecorationType.None)
        Me.Address2TextBox.Depth = 0
        Me.Address2TextBox.Hint = "Address 2"
        Me.Address2TextBox.Location = New System.Drawing.Point(861, 242)
        Me.Address2TextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.Address2TextBox.Name = "Address2TextBox"
        Me.Address2TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Address2TextBox.SelectedText = ""
        Me.Address2TextBox.SelectionLength = 0
        Me.Address2TextBox.SelectionStart = 0
        Me.Address2TextBox.Size = New System.Drawing.Size(338, 23)
        Me.Address2TextBox.TabIndex = 7
        Me.Address2TextBox.UseSystemPasswordChar = False
        '
        'Address1TextBox
        '
        Me.BunifuTransition1.SetDecoration(Me.Address1TextBox, BunifuAnimatorNS.DecorationType.None)
        Me.Address1TextBox.Depth = 0
        Me.Address1TextBox.Hint = "Address 1"
        Me.Address1TextBox.Location = New System.Drawing.Point(349, 242)
        Me.Address1TextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.Address1TextBox.Name = "Address1TextBox"
        Me.Address1TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Address1TextBox.SelectedText = ""
        Me.Address1TextBox.SelectionLength = 0
        Me.Address1TextBox.SelectionStart = 0
        Me.Address1TextBox.Size = New System.Drawing.Size(395, 23)
        Me.Address1TextBox.TabIndex = 6
        Me.Address1TextBox.UseSystemPasswordChar = False
        '
        'ContactNoTextBox
        '
        Me.BunifuTransition1.SetDecoration(Me.ContactNoTextBox, BunifuAnimatorNS.DecorationType.None)
        Me.ContactNoTextBox.Depth = 0
        Me.ContactNoTextBox.Hint = "Contact No"
        Me.ContactNoTextBox.Location = New System.Drawing.Point(861, 180)
        Me.ContactNoTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ContactNoTextBox.SelectedText = ""
        Me.ContactNoTextBox.SelectionLength = 0
        Me.ContactNoTextBox.SelectionStart = 0
        Me.ContactNoTextBox.Size = New System.Drawing.Size(265, 23)
        Me.ContactNoTextBox.TabIndex = 5
        Me.ContactNoTextBox.UseSystemPasswordChar = False
        '
        'MiddleNameTextBox
        '
        Me.BunifuTransition1.SetDecoration(Me.MiddleNameTextBox, BunifuAnimatorNS.DecorationType.None)
        Me.MiddleNameTextBox.Depth = 0
        Me.MiddleNameTextBox.Hint = "Middlename"
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(662, 115)
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
        Me.BunifuTransition1.SetDecoration(Me.LastNameTextBox, BunifuAnimatorNS.DecorationType.None)
        Me.LastNameTextBox.Depth = 0
        Me.LastNameTextBox.Hint = "Lastname"
        Me.LastNameTextBox.Location = New System.Drawing.Point(861, 115)
        Me.LastNameTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LastNameTextBox.SelectedText = ""
        Me.LastNameTextBox.SelectionLength = 0
        Me.LastNameTextBox.SelectionStart = 0
        Me.LastNameTextBox.Size = New System.Drawing.Size(265, 23)
        Me.LastNameTextBox.TabIndex = 2
        Me.LastNameTextBox.UseSystemPasswordChar = False
        '
        'FirstNameTextBox
        '
        Me.BunifuTransition1.SetDecoration(Me.FirstNameTextBox, BunifuAnimatorNS.DecorationType.None)
        Me.FirstNameTextBox.Depth = 0
        Me.FirstNameTextBox.Hint = "Firstname"
        Me.FirstNameTextBox.Location = New System.Drawing.Point(348, 115)
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
        Me.UserImage.BackgroundImage = Global.College_Management_System.My.Resources.Resources.Splash_image
        Me.UserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.UserImage, BunifuAnimatorNS.DecorationType.None)
        Me.UserImage.Location = New System.Drawing.Point(59, 65)
        Me.UserImage.Margin = New System.Windows.Forms.Padding(0)
        Me.UserImage.Name = "UserImage"
        Me.UserImage.Size = New System.Drawing.Size(198, 225)
        Me.UserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserImage.TabIndex = 0
        Me.UserImage.TabStop = False
        '
        'AddStudentTab
        '
        Me.AddStudentTab.BackColor = System.Drawing.Color.White
        Me.AddStudentTab.Controls.Add(Me.StudentUploadBtn)
        Me.AddStudentTab.Controls.Add(Me.StudentImage)
        Me.BunifuTransition1.SetDecoration(Me.AddStudentTab, BunifuAnimatorNS.DecorationType.None)
        Me.AddStudentTab.Location = New System.Drawing.Point(4, 24)
        Me.AddStudentTab.Margin = New System.Windows.Forms.Padding(0)
        Me.AddStudentTab.Name = "AddStudentTab"
        Me.AddStudentTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AddStudentTab.Size = New System.Drawing.Size(1303, 684)
        Me.AddStudentTab.TabIndex = 1
        Me.AddStudentTab.Text = "Add Student"
        '
        'AllUsersTab
        '
        Me.BunifuTransition1.SetDecoration(Me.AllUsersTab, BunifuAnimatorNS.DecorationType.None)
        Me.AllUsersTab.Location = New System.Drawing.Point(4, 24)
        Me.AllUsersTab.Name = "AllUsersTab"
        Me.AllUsersTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AllUsersTab.Size = New System.Drawing.Size(1303, 684)
        Me.AllUsersTab.TabIndex = 2
        Me.AllUsersTab.Text = "All Users"
        Me.AllUsersTab.UseVisualStyleBackColor = True
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.a
        Me.BunifuTransition1.SetDecoration(Me.MaterialTabSelector1, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialTabSelector1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(1311, 37)
        Me.MaterialTabSelector1.TabIndex = 1
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'UserNameTextBox
        '
        Me.BunifuTransition1.SetDecoration(Me.UserNameTextBox, BunifuAnimatorNS.DecorationType.None)
        Me.UserNameTextBox.Depth = 0
        Me.UserNameTextBox.Hint = "Username"
        Me.UserNameTextBox.Location = New System.Drawing.Point(59, 415)
        Me.UserNameTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserNameTextBox.SelectedText = ""
        Me.UserNameTextBox.SelectionLength = 0
        Me.UserNameTextBox.SelectionStart = 0
        Me.UserNameTextBox.Size = New System.Drawing.Size(198, 23)
        Me.UserNameTextBox.TabIndex = 23
        Me.UserNameTextBox.UseSystemPasswordChar = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(76, 356)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(150, 20)
        Me.MaterialLabel1.TabIndex = 24
        Me.MaterialLabel1.Text = "Login Information"
        '
        'PasswordTextBox
        '
        Me.BunifuTransition1.SetDecoration(Me.PasswordTextBox, BunifuAnimatorNS.DecorationType.None)
        Me.PasswordTextBox.Depth = 0
        Me.PasswordTextBox.Hint = "Password"
        Me.PasswordTextBox.Location = New System.Drawing.Point(59, 466)
        Me.PasswordTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordTextBox.SelectedText = ""
        Me.PasswordTextBox.SelectionLength = 0
        Me.PasswordTextBox.SelectionStart = 0
        Me.PasswordTextBox.Size = New System.Drawing.Size(198, 23)
        Me.PasswordTextBox.TabIndex = 25
        Me.PasswordTextBox.UseSystemPasswordChar = False
        '
        'StudentImage
        '
        Me.StudentImage.BackgroundImage = Global.College_Management_System.My.Resources.Resources.Splash_image
        Me.StudentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.StudentImage, BunifuAnimatorNS.DecorationType.None)
        Me.StudentImage.Location = New System.Drawing.Point(57, 65)
        Me.StudentImage.Name = "StudentImage"
        Me.StudentImage.Size = New System.Drawing.Size(198, 225)
        Me.StudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StudentImage.TabIndex = 2
        Me.StudentImage.TabStop = False
        '
        'StudentUploadBtn
        '
        Me.StudentUploadBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.StudentUploadBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTransition1.SetDecoration(Me.StudentUploadBtn, BunifuAnimatorNS.DecorationType.None)
        Me.StudentUploadBtn.Image = Global.College_Management_System.My.Resources.Resources.Upload_32px
        Me.StudentUploadBtn.ImageActive = Nothing
        Me.StudentUploadBtn.Location = New System.Drawing.Point(57, 296)
        Me.StudentUploadBtn.Name = "StudentUploadBtn"
        Me.StudentUploadBtn.Size = New System.Drawing.Size(198, 23)
        Me.StudentUploadBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.StudentUploadBtn.TabIndex = 17
        Me.StudentUploadBtn.TabStop = False
        Me.StudentUploadBtn.Zoom = 10
        '
        'AllStudentsTab
        '
        Me.BunifuTransition1.SetDecoration(Me.AllStudentsTab, BunifuAnimatorNS.DecorationType.None)
        Me.AllStudentsTab.Location = New System.Drawing.Point(4, 24)
        Me.AllStudentsTab.Name = "AllStudentsTab"
        Me.AllStudentsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AllStudentsTab.Size = New System.Drawing.Size(1303, 684)
        Me.AllStudentsTab.TabIndex = 3
        Me.AllStudentsTab.Text = "All Students"
        Me.AllStudentsTab.UseVisualStyleBackColor = True
        '
        'SendEmailCheckBox
        '
        Me.SendEmailCheckBox.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.SendEmailCheckBox, BunifuAnimatorNS.DecorationType.None)
        Me.SendEmailCheckBox.Depth = 0
        Me.SendEmailCheckBox.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.SendEmailCheckBox.Location = New System.Drawing.Point(348, 399)
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
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 749)
        Me.Controls.Add(Me.dashboardMainPnl)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.hamburgerPnl.ResumeLayout(False)
        CType(Me.hamburgerPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dashboardMainPnl.ResumeLayout(False)
        Me.dashboardTablePnl.ResumeLayout(False)
        Me.editTablePanelAdmin.ResumeLayout(False)
        Me.a.ResumeLayout(False)
        Me.AddUserTab.ResumeLayout(False)
        Me.AddUserTab.PerformLayout()
        CType(Me.UserUploadBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddStudentTab.ResumeLayout(False)
        CType(Me.StudentImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentUploadBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents dashboardMainPnl As System.Windows.Forms.Panel
    Friend WithEvents hamburgerPnl As System.Windows.Forms.Panel
    Friend WithEvents hamburgerPb As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dashboardTablePnl As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents editTablePanelAdmin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents a As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents AddUserTab As System.Windows.Forms.TabPage
    Friend WithEvents AddStudentTab As System.Windows.Forms.TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents UserImage As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents UserTypeComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Address2TextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Address1TextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents ContactNoTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MiddleNameTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents LastNameTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents FirstNameTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents FemaleRadioBtn As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaleRadioBtn As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents UserIdLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents UserUploadBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents DobLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents UserIdTextBox As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents MaritialStatusComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents EmailTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents DobDateTimePicker As MetroFramework.Controls.MetroDateTime
    Friend WithEvents UserTypeLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaritialStatusLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents GenderLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AllUsersTab As System.Windows.Forms.TabPage
    Friend WithEvents FinsihBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents PasswordTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents UserNameTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents StudentUploadBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents StudentImage As System.Windows.Forms.PictureBox
    Friend WithEvents AllStudentsTab As System.Windows.Forms.TabPage
    Friend WithEvents SendEmailCheckBox As MaterialSkin.Controls.MaterialCheckBox
End Class
