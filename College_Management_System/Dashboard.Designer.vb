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
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.hamburgerPnl = New System.Windows.Forms.Panel()
        Me.dashboardMainPnl = New System.Windows.Forms.Panel()
        Me.dashboardTablePnl = New System.Windows.Forms.TableLayoutPanel()
        Me.editTablePanelAdmin = New System.Windows.Forms.TableLayoutPanel()
        Me.a = New MaterialSkin.Controls.MaterialTabControl()
        Me.addUserTb = New System.Windows.Forms.TabPage()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRadioButton2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MaterialSingleLineTextField6 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField5 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField3 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField7 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.addStudentTb = New System.Windows.Forms.TabPage()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.MaterialSingleLineTextField4 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MetroComboBox2 = New MetroFramework.Controls.MetroComboBox()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.BunifuCustomTextbox1 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.hamburgerPb = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.allUsersTb = New System.Windows.Forms.TabPage()
        Me.hamburgerPnl.SuspendLayout()
        Me.dashboardMainPnl.SuspendLayout()
        Me.dashboardTablePnl.SuspendLayout()
        Me.editTablePanelAdmin.SuspendLayout()
        Me.a.SuspendLayout()
        Me.addUserTb.SuspendLayout()
        Me.addStudentTb.SuspendLayout()
        CType(Me.hamburgerPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0.0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0.0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0.0!
        Animation3.RotateLimit = 0.0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0.0!
        Animation3.TransparencyCoeff = 0.0!
        Me.BunifuTransition1.DefaultAnimation = Animation3
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
        Me.a.Controls.Add(Me.addUserTb)
        Me.a.Controls.Add(Me.addStudentTb)
        Me.a.Controls.Add(Me.allUsersTb)
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
        'addUserTb
        '
        Me.addUserTb.BackColor = System.Drawing.Color.White
        Me.addUserTb.Controls.Add(Me.BunifuFlatButton2)
        Me.addUserTb.Controls.Add(Me.BunifuFlatButton1)
        Me.addUserTb.Controls.Add(Me.BunifuCustomTextbox1)
        Me.addUserTb.Controls.Add(Me.MetroComboBox2)
        Me.addUserTb.Controls.Add(Me.MaterialSingleLineTextField4)
        Me.addUserTb.Controls.Add(Me.MetroDateTime1)
        Me.addUserTb.Controls.Add(Me.BunifuImageButton1)
        Me.addUserTb.Controls.Add(Me.MaterialLabel4)
        Me.addUserTb.Controls.Add(Me.MaterialLabel3)
        Me.addUserTb.Controls.Add(Me.MaterialLabel2)
        Me.addUserTb.Controls.Add(Me.MaterialLabel5)
        Me.addUserTb.Controls.Add(Me.MaterialLabel1)
        Me.addUserTb.Controls.Add(Me.MaterialRadioButton2)
        Me.addUserTb.Controls.Add(Me.MaterialRadioButton1)
        Me.addUserTb.Controls.Add(Me.MetroComboBox1)
        Me.addUserTb.Controls.Add(Me.MaterialSingleLineTextField6)
        Me.addUserTb.Controls.Add(Me.MaterialSingleLineTextField5)
        Me.addUserTb.Controls.Add(Me.MaterialSingleLineTextField3)
        Me.addUserTb.Controls.Add(Me.MaterialSingleLineTextField7)
        Me.addUserTb.Controls.Add(Me.MaterialSingleLineTextField2)
        Me.addUserTb.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.addUserTb.Controls.Add(Me.PictureBox3)
        Me.BunifuTransition1.SetDecoration(Me.addUserTb, BunifuAnimatorNS.DecorationType.None)
        Me.addUserTb.Location = New System.Drawing.Point(4, 24)
        Me.addUserTb.Margin = New System.Windows.Forms.Padding(0)
        Me.addUserTb.Name = "addUserTb"
        Me.addUserTb.Size = New System.Drawing.Size(1303, 684)
        Me.addUserTb.TabIndex = 0
        Me.addUserTb.Text = "Add User"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(346, 72)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(51, 18)
        Me.MaterialLabel1.TabIndex = 15
        Me.MaterialLabel1.Text = "UserId"
        '
        'MaterialRadioButton2
        '
        Me.MaterialRadioButton2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialRadioButton2, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialRadioButton2.Depth = 0
        Me.MaterialRadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MaterialRadioButton2.Location = New System.Drawing.Point(607, 175)
        Me.MaterialRadioButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton2.Name = "MaterialRadioButton2"
        Me.MaterialRadioButton2.Ripple = True
        Me.MaterialRadioButton2.Size = New System.Drawing.Size(74, 30)
        Me.MaterialRadioButton2.TabIndex = 4
        Me.MaterialRadioButton2.TabStop = True
        Me.MaterialRadioButton2.Text = "Female"
        Me.MaterialRadioButton2.UseVisualStyleBackColor = True
        '
        'MaterialRadioButton1
        '
        Me.MaterialRadioButton1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialRadioButton1, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialRadioButton1.Depth = 0
        Me.MaterialRadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MaterialRadioButton1.Location = New System.Drawing.Point(477, 175)
        Me.MaterialRadioButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton1.Name = "MaterialRadioButton1"
        Me.MaterialRadioButton1.Ripple = True
        Me.MaterialRadioButton1.Size = New System.Drawing.Size(59, 30)
        Me.MaterialRadioButton1.TabIndex = 3
        Me.MaterialRadioButton1.TabStop = True
        Me.MaterialRadioButton1.Text = "Male"
        Me.MaterialRadioButton1.UseVisualStyleBackColor = True
        '
        'MetroComboBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.MetroComboBox1, BunifuAnimatorNS.DecorationType.None)
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Items.AddRange(New Object() {"Receptionist", "Cashier", "Lecturer"})
        Me.MetroComboBox1.Location = New System.Drawing.Point(427, 290)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.PromptText = "Select Usertype"
        Me.MetroComboBox1.Size = New System.Drawing.Size(267, 29)
        Me.MetroComboBox1.TabIndex = 8
        Me.MetroComboBox1.UseSelectable = True
        '
        'MaterialSingleLineTextField6
        '
        Me.BunifuTransition1.SetDecoration(Me.MaterialSingleLineTextField6, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialSingleLineTextField6.Depth = 0
        Me.MaterialSingleLineTextField6.Hint = "Address 2"
        Me.MaterialSingleLineTextField6.Location = New System.Drawing.Point(788, 242)
        Me.MaterialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField6.Name = "MaterialSingleLineTextField6"
        Me.MaterialSingleLineTextField6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField6.SelectedText = ""
        Me.MaterialSingleLineTextField6.SelectionLength = 0
        Me.MaterialSingleLineTextField6.SelectionStart = 0
        Me.MaterialSingleLineTextField6.Size = New System.Drawing.Size(338, 23)
        Me.MaterialSingleLineTextField6.TabIndex = 7
        Me.MaterialSingleLineTextField6.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField5
        '
        Me.BunifuTransition1.SetDecoration(Me.MaterialSingleLineTextField5, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialSingleLineTextField5.Depth = 0
        Me.MaterialSingleLineTextField5.Hint = "Address 1"
        Me.MaterialSingleLineTextField5.Location = New System.Drawing.Point(349, 242)
        Me.MaterialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField5.Name = "MaterialSingleLineTextField5"
        Me.MaterialSingleLineTextField5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField5.SelectedText = ""
        Me.MaterialSingleLineTextField5.SelectionLength = 0
        Me.MaterialSingleLineTextField5.SelectionStart = 0
        Me.MaterialSingleLineTextField5.Size = New System.Drawing.Size(345, 23)
        Me.MaterialSingleLineTextField5.TabIndex = 6
        Me.MaterialSingleLineTextField5.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField3
        '
        Me.BunifuTransition1.SetDecoration(Me.MaterialSingleLineTextField3, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialSingleLineTextField3.Depth = 0
        Me.MaterialSingleLineTextField3.Hint = "Contact No"
        Me.MaterialSingleLineTextField3.Location = New System.Drawing.Point(861, 180)
        Me.MaterialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField3.Name = "MaterialSingleLineTextField3"
        Me.MaterialSingleLineTextField3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField3.SelectedText = ""
        Me.MaterialSingleLineTextField3.SelectionLength = 0
        Me.MaterialSingleLineTextField3.SelectionStart = 0
        Me.MaterialSingleLineTextField3.Size = New System.Drawing.Size(265, 23)
        Me.MaterialSingleLineTextField3.TabIndex = 5
        Me.MaterialSingleLineTextField3.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField7
        '
        Me.BunifuTransition1.SetDecoration(Me.MaterialSingleLineTextField7, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialSingleLineTextField7.Depth = 0
        Me.MaterialSingleLineTextField7.Hint = "Middlename"
        Me.MaterialSingleLineTextField7.Location = New System.Drawing.Point(662, 115)
        Me.MaterialSingleLineTextField7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField7.Name = "MaterialSingleLineTextField7"
        Me.MaterialSingleLineTextField7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField7.SelectedText = ""
        Me.MaterialSingleLineTextField7.SelectionLength = 0
        Me.MaterialSingleLineTextField7.SelectionStart = 0
        Me.MaterialSingleLineTextField7.Size = New System.Drawing.Size(151, 23)
        Me.MaterialSingleLineTextField7.TabIndex = 1
        Me.MaterialSingleLineTextField7.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField2
        '
        Me.BunifuTransition1.SetDecoration(Me.MaterialSingleLineTextField2, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialSingleLineTextField2.Depth = 0
        Me.MaterialSingleLineTextField2.Hint = "Lastname"
        Me.MaterialSingleLineTextField2.Location = New System.Drawing.Point(861, 115)
        Me.MaterialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField2.Name = "MaterialSingleLineTextField2"
        Me.MaterialSingleLineTextField2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField2.SelectedText = ""
        Me.MaterialSingleLineTextField2.SelectionLength = 0
        Me.MaterialSingleLineTextField2.SelectionStart = 0
        Me.MaterialSingleLineTextField2.Size = New System.Drawing.Size(265, 23)
        Me.MaterialSingleLineTextField2.TabIndex = 2
        Me.MaterialSingleLineTextField2.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField1
        '
        Me.BunifuTransition1.SetDecoration(Me.MaterialSingleLineTextField1, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Hint = "Firstname"
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(349, 115)
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(265, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 0
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'addStudentTb
        '
        Me.addStudentTb.BackColor = System.Drawing.Color.White
        Me.addStudentTb.Controls.Add(Me.BunifuImageButton2)
        Me.addStudentTb.Controls.Add(Me.PictureBox4)
        Me.BunifuTransition1.SetDecoration(Me.addStudentTb, BunifuAnimatorNS.DecorationType.None)
        Me.addStudentTb.Location = New System.Drawing.Point(4, 24)
        Me.addStudentTb.Margin = New System.Windows.Forms.Padding(0)
        Me.addStudentTb.Name = "addStudentTb"
        Me.addStudentTb.Padding = New System.Windows.Forms.Padding(3)
        Me.addStudentTb.Size = New System.Drawing.Size(1303, 684)
        Me.addStudentTb.TabIndex = 1
        Me.addStudentTb.Text = "Add Student"
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
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(785, 296)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(41, 18)
        Me.MaterialLabel2.TabIndex = 15
        Me.MaterialLabel2.Text = "DOB"
        '
        'MetroDateTime1
        '
        Me.BunifuTransition1.SetDecoration(Me.MetroDateTime1, BunifuAnimatorNS.DecorationType.None)
        Me.MetroDateTime1.Location = New System.Drawing.Point(861, 290)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(265, 29)
        Me.MetroDateTime1.TabIndex = 9
        '
        'MaterialSingleLineTextField4
        '
        Me.BunifuTransition1.SetDecoration(Me.MaterialSingleLineTextField4, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialSingleLineTextField4.Depth = 0
        Me.MaterialSingleLineTextField4.Hint = "Email"
        Me.MaterialSingleLineTextField4.Location = New System.Drawing.Point(349, 353)
        Me.MaterialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField4.Name = "MaterialSingleLineTextField4"
        Me.MaterialSingleLineTextField4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField4.SelectedText = ""
        Me.MaterialSingleLineTextField4.SelectionLength = 0
        Me.MaterialSingleLineTextField4.SelectionStart = 0
        Me.MaterialSingleLineTextField4.Size = New System.Drawing.Size(346, 23)
        Me.MaterialSingleLineTextField4.TabIndex = 10
        Me.MaterialSingleLineTextField4.UseSystemPasswordChar = False
        '
        'MetroComboBox2
        '
        Me.BunifuTransition1.SetDecoration(Me.MetroComboBox2, BunifuAnimatorNS.DecorationType.None)
        Me.MetroComboBox2.FormattingEnabled = True
        Me.MetroComboBox2.ItemHeight = 23
        Me.MetroComboBox2.Items.AddRange(New Object() {"Single", "Married"})
        Me.MetroComboBox2.Location = New System.Drawing.Point(908, 347)
        Me.MetroComboBox2.Name = "MetroComboBox2"
        Me.MetroComboBox2.PromptText = "Current relation"
        Me.MetroComboBox2.Size = New System.Drawing.Size(218, 29)
        Me.MetroComboBox2.TabIndex = 11
        Me.MetroComboBox2.UseSelectable = True
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(784, 353)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(101, 18)
        Me.MaterialLabel3.TabIndex = 15
        Me.MaterialLabel3.Text = "Maritial Status"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(344, 296)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(67, 18)
        Me.MaterialLabel4.TabIndex = 15
        Me.MaterialLabel4.Text = "Usertype"
        '
        'BunifuCustomTextbox1
        '
        Me.BunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomTextbox1.Cursor = System.Windows.Forms.Cursors.No
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomTextbox1.Location = New System.Drawing.Point(414, 67)
        Me.BunifuCustomTextbox1.Multiline = True
        Me.BunifuCustomTextbox1.Name = "BunifuCustomTextbox1"
        Me.BunifuCustomTextbox1.ReadOnly = True
        Me.BunifuCustomTextbox1.Size = New System.Drawing.Size(85, 29)
        Me.BunifuCustomTextbox1.TabIndex = 20
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(346, 180)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(57, 18)
        Me.MaterialLabel5.TabIndex = 15
        Me.MaterialLabel5.Text = "Gender"
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
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Show UserList"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Global.College_Management_System.My.Resources.Resources.List_20px
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0.0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 50.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(492, 432)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(164, 48)
        Me.BunifuFlatButton2.TabIndex = 21
        Me.BunifuFlatButton2.Text = "Show UserList"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Finish"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0.0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(350, 432)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(122, 48)
        Me.BunifuFlatButton1.TabIndex = 21
        Me.BunifuFlatButton1.Text = "Finish"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = Global.College_Management_System.My.Resources.Resources.Upload_32px
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(59, 303)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(198, 23)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 16
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.College_Management_System.My.Resources.Resources.Splash_image
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox3.Location = New System.Drawing.Point(59, 65)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(198, 225)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = Global.College_Management_System.My.Resources.Resources.Upload_32px
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(57, 296)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(198, 23)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 17
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.College_Management_System.My.Resources.Resources.Splash_image
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.PictureBox4, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox4.Location = New System.Drawing.Point(57, 65)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(198, 225)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'allUsersTb
        '
        Me.BunifuTransition1.SetDecoration(Me.allUsersTb, BunifuAnimatorNS.DecorationType.None)
        Me.allUsersTb.Location = New System.Drawing.Point(4, 24)
        Me.allUsersTb.Name = "allUsersTb"
        Me.allUsersTb.Padding = New System.Windows.Forms.Padding(3)
        Me.allUsersTb.Size = New System.Drawing.Size(1303, 684)
        Me.allUsersTb.TabIndex = 2
        Me.allUsersTb.Text = "All Users"
        Me.allUsersTb.UseVisualStyleBackColor = True
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
        Me.dashboardMainPnl.ResumeLayout(False)
        Me.dashboardTablePnl.ResumeLayout(False)
        Me.editTablePanelAdmin.ResumeLayout(False)
        Me.a.ResumeLayout(False)
        Me.addUserTb.ResumeLayout(False)
        Me.addUserTb.PerformLayout()
        Me.addStudentTb.ResumeLayout(False)
        CType(Me.hamburgerPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents addUserTb As System.Windows.Forms.TabPage
    Friend WithEvents addStudentTb As System.Windows.Forms.TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MaterialSingleLineTextField6 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField5 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField3 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField7 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialRadioButton2 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BunifuCustomTextbox1 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents MetroComboBox2 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MaterialSingleLineTextField4 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents allUsersTb As System.Windows.Forms.TabPage
End Class
