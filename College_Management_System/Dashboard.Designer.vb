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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.hamburgerPnl = New System.Windows.Forms.Panel()
        Me.NoticeButton = New System.Windows.Forms.Button()
        Me.BillButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.ResultButton = New System.Windows.Forms.Button()
        Me.SettingButton = New System.Windows.Forms.Button()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.AttendanceButton = New System.Windows.Forms.Button()
        Me.RecycleBinButton = New System.Windows.Forms.Button()
        Me.PcMgmtButton = New System.Windows.Forms.Button()
        Me.AddRemoveButton = New System.Windows.Forms.Button()
        Me.HamburgerButton = New System.Windows.Forms.Button()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.UserDetailPanel = New System.Windows.Forms.Panel()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.PhoneNoLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.ProfilePictureBox = New System.Windows.Forms.PictureBox()
        Me.SlideDownButton = New System.Windows.Forms.Button()
        Me.dashboardTablePnl = New System.Windows.Forms.TableLayoutPanel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.hamburgerPnl.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.UserDetailPanel.SuspendLayout()
        CType(Me.ProfilePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dashboardTablePnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'hamburgerPnl
        '
        Me.hamburgerPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.hamburgerPnl.Controls.Add(Me.NoticeButton)
        Me.hamburgerPnl.Controls.Add(Me.BillButton)
        Me.hamburgerPnl.Controls.Add(Me.HomeButton)
        Me.hamburgerPnl.Controls.Add(Me.ResultButton)
        Me.hamburgerPnl.Controls.Add(Me.SettingButton)
        Me.hamburgerPnl.Controls.Add(Me.LogOutButton)
        Me.hamburgerPnl.Controls.Add(Me.CloseButton)
        Me.hamburgerPnl.Controls.Add(Me.AttendanceButton)
        Me.hamburgerPnl.Controls.Add(Me.RecycleBinButton)
        Me.hamburgerPnl.Controls.Add(Me.PcMgmtButton)
        Me.hamburgerPnl.Controls.Add(Me.AddRemoveButton)
        Me.hamburgerPnl.Controls.Add(Me.HamburgerButton)
        Me.BunifuTransition1.SetDecoration(Me.hamburgerPnl, BunifuAnimatorNS.DecorationType.None)
        Me.hamburgerPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.hamburgerPnl.Location = New System.Drawing.Point(0, 0)
        Me.hamburgerPnl.Margin = New System.Windows.Forms.Padding(0)
        Me.hamburgerPnl.Name = "hamburgerPnl"
        Me.hamburgerPnl.Size = New System.Drawing.Size(45, 826)
        Me.hamburgerPnl.TabIndex = 3
        '
        'NoticeButton
        '
        Me.NoticeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.NoticeButton, BunifuAnimatorNS.DecorationType.None)
        Me.NoticeButton.FlatAppearance.BorderSize = 0
        Me.NoticeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.NoticeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.NoticeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NoticeButton.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoticeButton.ForeColor = System.Drawing.Color.White
        Me.NoticeButton.Image = Global.College_Management_System.My.Resources.Resources.Megaphone_32px
        Me.NoticeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NoticeButton.Location = New System.Drawing.Point(0, 397)
        Me.NoticeButton.Margin = New System.Windows.Forms.Padding(0)
        Me.NoticeButton.Name = "NoticeButton"
        Me.NoticeButton.Size = New System.Drawing.Size(45, 57)
        Me.NoticeButton.TabIndex = 17
        Me.NoticeButton.UseVisualStyleBackColor = False
        '
        'BillButton
        '
        Me.BillButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.BillButton, BunifuAnimatorNS.DecorationType.None)
        Me.BillButton.FlatAppearance.BorderSize = 0
        Me.BillButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BillButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BillButton.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillButton.ForeColor = System.Drawing.Color.White
        Me.BillButton.Image = Global.College_Management_System.My.Resources.Resources.Bill_32px
        Me.BillButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BillButton.Location = New System.Drawing.Point(0, 340)
        Me.BillButton.Margin = New System.Windows.Forms.Padding(0)
        Me.BillButton.Name = "BillButton"
        Me.BillButton.Size = New System.Drawing.Size(45, 57)
        Me.BillButton.TabIndex = 16
        Me.BillButton.UseVisualStyleBackColor = False
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.HomeButton, BunifuAnimatorNS.DecorationType.None)
        Me.HomeButton.FlatAppearance.BorderSize = 0
        Me.HomeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.HomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeButton.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeButton.ForeColor = System.Drawing.Color.White
        Me.HomeButton.Image = Global.College_Management_System.My.Resources.Resources.Home_32px
        Me.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HomeButton.Location = New System.Drawing.Point(0, 57)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(0)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(45, 57)
        Me.HomeButton.TabIndex = 13
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'ResultButton
        '
        Me.ResultButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.ResultButton, BunifuAnimatorNS.DecorationType.None)
        Me.ResultButton.FlatAppearance.BorderSize = 0
        Me.ResultButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.ResultButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResultButton.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultButton.ForeColor = System.Drawing.Color.White
        Me.ResultButton.Image = Global.College_Management_System.My.Resources.Resources.Report_Card_32px
        Me.ResultButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ResultButton.Location = New System.Drawing.Point(0, 283)
        Me.ResultButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ResultButton.Name = "ResultButton"
        Me.ResultButton.Size = New System.Drawing.Size(45, 57)
        Me.ResultButton.TabIndex = 15
        Me.ResultButton.UseVisualStyleBackColor = False
        '
        'SettingButton
        '
        Me.SettingButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.SettingButton, BunifuAnimatorNS.DecorationType.None)
        Me.SettingButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SettingButton.FlatAppearance.BorderSize = 0
        Me.SettingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.SettingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingButton.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingButton.ForeColor = System.Drawing.Color.White
        Me.SettingButton.Image = Global.College_Management_System.My.Resources.Resources.Settings_32px1
        Me.SettingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SettingButton.Location = New System.Drawing.Point(0, 655)
        Me.SettingButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SettingButton.Name = "SettingButton"
        Me.SettingButton.Size = New System.Drawing.Size(45, 57)
        Me.SettingButton.TabIndex = 14
        Me.SettingButton.UseVisualStyleBackColor = False
        '
        'LogOutButton
        '
        Me.LogOutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.LogOutButton, BunifuAnimatorNS.DecorationType.None)
        Me.LogOutButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogOutButton.FlatAppearance.BorderSize = 0
        Me.LogOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.LogOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOutButton.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutButton.ForeColor = System.Drawing.Color.White
        Me.LogOutButton.Image = Global.College_Management_System.My.Resources.Resources.Logout_Rounded_Left_32px
        Me.LogOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogOutButton.Location = New System.Drawing.Point(0, 712)
        Me.LogOutButton.Margin = New System.Windows.Forms.Padding(0)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(45, 57)
        Me.LogOutButton.TabIndex = 12
        Me.LogOutButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.CloseButton, BunifuAnimatorNS.DecorationType.None)
        Me.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.Image = Global.College_Management_System.My.Resources.Resources.Exit_32px
        Me.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseButton.Location = New System.Drawing.Point(0, 769)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(45, 57)
        Me.CloseButton.TabIndex = 11
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'AttendanceButton
        '
        Me.AttendanceButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.AttendanceButton, BunifuAnimatorNS.DecorationType.None)
        Me.AttendanceButton.FlatAppearance.BorderSize = 0
        Me.AttendanceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.AttendanceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.AttendanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AttendanceButton.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttendanceButton.ForeColor = System.Drawing.Color.White
        Me.AttendanceButton.Image = Global.College_Management_System.My.Resources.Resources.List_32px1
        Me.AttendanceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AttendanceButton.Location = New System.Drawing.Point(0, 227)
        Me.AttendanceButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AttendanceButton.Name = "AttendanceButton"
        Me.AttendanceButton.Size = New System.Drawing.Size(45, 57)
        Me.AttendanceButton.TabIndex = 10
        Me.AttendanceButton.UseVisualStyleBackColor = False
        '
        'RecycleBinButton
        '
        Me.RecycleBinButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.RecycleBinButton, BunifuAnimatorNS.DecorationType.None)
        Me.RecycleBinButton.FlatAppearance.BorderSize = 0
        Me.RecycleBinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.RecycleBinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.RecycleBinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RecycleBinButton.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecycleBinButton.ForeColor = System.Drawing.Color.White
        Me.RecycleBinButton.Image = Global.College_Management_System.My.Resources.Resources.Trash_32px
        Me.RecycleBinButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RecycleBinButton.Location = New System.Drawing.Point(0, 453)
        Me.RecycleBinButton.Margin = New System.Windows.Forms.Padding(0)
        Me.RecycleBinButton.Name = "RecycleBinButton"
        Me.RecycleBinButton.Size = New System.Drawing.Size(45, 57)
        Me.RecycleBinButton.TabIndex = 9
        Me.RecycleBinButton.UseVisualStyleBackColor = False
        '
        'PcMgmtButton
        '
        Me.PcMgmtButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.PcMgmtButton, BunifuAnimatorNS.DecorationType.None)
        Me.PcMgmtButton.FlatAppearance.BorderSize = 0
        Me.PcMgmtButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.PcMgmtButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.PcMgmtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PcMgmtButton.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PcMgmtButton.ForeColor = System.Drawing.Color.White
        Me.PcMgmtButton.Image = Global.College_Management_System.My.Resources.Resources.Admin_Settings_Male_32px
        Me.PcMgmtButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PcMgmtButton.Location = New System.Drawing.Point(0, 170)
        Me.PcMgmtButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PcMgmtButton.Name = "PcMgmtButton"
        Me.PcMgmtButton.Size = New System.Drawing.Size(45, 57)
        Me.PcMgmtButton.TabIndex = 8
        Me.PcMgmtButton.UseVisualStyleBackColor = False
        '
        'AddRemoveButton
        '
        Me.AddRemoveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.AddRemoveButton, BunifuAnimatorNS.DecorationType.None)
        Me.AddRemoveButton.FlatAppearance.BorderSize = 0
        Me.AddRemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.AddRemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.AddRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddRemoveButton.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddRemoveButton.ForeColor = System.Drawing.Color.White
        Me.AddRemoveButton.Image = Global.College_Management_System.My.Resources.Resources.Registration_32px
        Me.AddRemoveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddRemoveButton.Location = New System.Drawing.Point(0, 113)
        Me.AddRemoveButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AddRemoveButton.Name = "AddRemoveButton"
        Me.AddRemoveButton.Size = New System.Drawing.Size(45, 57)
        Me.AddRemoveButton.TabIndex = 7
        Me.AddRemoveButton.UseVisualStyleBackColor = False
        '
        'HamburgerButton
        '
        Me.HamburgerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.HamburgerButton, BunifuAnimatorNS.DecorationType.None)
        Me.HamburgerButton.FlatAppearance.BorderSize = 0
        Me.HamburgerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.HamburgerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.HamburgerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HamburgerButton.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HamburgerButton.ForeColor = System.Drawing.Color.White
        Me.HamburgerButton.Image = Global.College_Management_System.My.Resources.Resources.Menu_32px
        Me.HamburgerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HamburgerButton.Location = New System.Drawing.Point(0, 0)
        Me.HamburgerButton.Margin = New System.Windows.Forms.Padding(0)
        Me.HamburgerButton.Name = "HamburgerButton"
        Me.HamburgerButton.Size = New System.Drawing.Size(45, 57)
        Me.HamburgerButton.TabIndex = 7
        Me.HamburgerButton.UseVisualStyleBackColor = False
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.UserDetailPanel)
        Me.BunifuTransition1.SetDecoration(Me.MainPanel, BunifuAnimatorNS.DecorationType.None)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(48, 0)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1302, 826)
        Me.MainPanel.TabIndex = 0
        '
        'UserDetailPanel
        '
        Me.UserDetailPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserDetailPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.UserDetailPanel.Controls.Add(Me.EmailLabel)
        Me.UserDetailPanel.Controls.Add(Me.PhoneNoLabel)
        Me.UserDetailPanel.Controls.Add(Me.NameLabel)
        Me.UserDetailPanel.Controls.Add(Me.ProfilePictureBox)
        Me.UserDetailPanel.Controls.Add(Me.SlideDownButton)
        Me.BunifuTransition1.SetDecoration(Me.UserDetailPanel, BunifuAnimatorNS.DecorationType.None)
        Me.UserDetailPanel.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserDetailPanel.ForeColor = System.Drawing.Color.White
        Me.UserDetailPanel.Location = New System.Drawing.Point(903, 0)
        Me.UserDetailPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.UserDetailPanel.Name = "UserDetailPanel"
        Me.UserDetailPanel.Size = New System.Drawing.Size(399, 27)
        Me.UserDetailPanel.TabIndex = 2
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.EmailLabel, BunifuAnimatorNS.DecorationType.None)
        Me.EmailLabel.Location = New System.Drawing.Point(176, 457)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(64, 24)
        Me.EmailLabel.TabIndex = 8
        Me.EmailLabel.Text = "Email"
        '
        'PhoneNoLabel
        '
        Me.PhoneNoLabel.AutoSize = True
        Me.PhoneNoLabel.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.PhoneNoLabel, BunifuAnimatorNS.DecorationType.None)
        Me.PhoneNoLabel.Location = New System.Drawing.Point(151, 393)
        Me.PhoneNoLabel.Name = "PhoneNoLabel"
        Me.PhoneNoLabel.Size = New System.Drawing.Size(109, 24)
        Me.PhoneNoLabel.TabIndex = 7
        Me.PhoneNoLabel.Text = "Phone no"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.NameLabel, BunifuAnimatorNS.DecorationType.None)
        Me.NameLabel.Location = New System.Drawing.Point(165, 335)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(75, 24)
        Me.NameLabel.TabIndex = 6
        Me.NameLabel.Text = "Name"
        '
        'ProfilePictureBox
        '
        Me.BunifuTransition1.SetDecoration(Me.ProfilePictureBox, BunifuAnimatorNS.DecorationType.None)
        Me.ProfilePictureBox.Image = Global.College_Management_System.My.Resources.Resources._75205
        Me.ProfilePictureBox.Location = New System.Drawing.Point(96, 67)
        Me.ProfilePictureBox.Name = "ProfilePictureBox"
        Me.ProfilePictureBox.Size = New System.Drawing.Size(198, 216)
        Me.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfilePictureBox.TabIndex = 2
        Me.ProfilePictureBox.TabStop = False
        '
        'SlideDownButton
        '
        Me.SlideDownButton.BackColor = System.Drawing.Color.Black
        Me.BunifuTransition1.SetDecoration(Me.SlideDownButton, BunifuAnimatorNS.DecorationType.None)
        Me.SlideDownButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SlideDownButton.FlatAppearance.BorderSize = 0
        Me.SlideDownButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.SlideDownButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.SlideDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SlideDownButton.Image = Global.College_Management_System.My.Resources.Resources.Expand_Arrow_24px
        Me.SlideDownButton.Location = New System.Drawing.Point(0, -7)
        Me.SlideDownButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SlideDownButton.Name = "SlideDownButton"
        Me.SlideDownButton.Size = New System.Drawing.Size(399, 34)
        Me.SlideDownButton.TabIndex = 1
        Me.SlideDownButton.UseVisualStyleBackColor = False
        '
        'dashboardTablePnl
        '
        Me.dashboardTablePnl.BackColor = System.Drawing.Color.LightSalmon
        Me.dashboardTablePnl.ColumnCount = 2
        Me.dashboardTablePnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.dashboardTablePnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.dashboardTablePnl.Controls.Add(Me.MainPanel, 1, 0)
        Me.BunifuTransition1.SetDecoration(Me.dashboardTablePnl, BunifuAnimatorNS.DecorationType.None)
        Me.dashboardTablePnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dashboardTablePnl.Location = New System.Drawing.Point(0, 0)
        Me.dashboardTablePnl.Margin = New System.Windows.Forms.Padding(0)
        Me.dashboardTablePnl.Name = "dashboardTablePnl"
        Me.dashboardTablePnl.RowCount = 1
        Me.dashboardTablePnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.dashboardTablePnl.Size = New System.Drawing.Size(1350, 826)
        Me.dashboardTablePnl.TabIndex = 4
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.MainPanel
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.hamburgerPnl
        Me.BunifuDragControl2.Vertical = True
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 826)
        Me.Controls.Add(Me.hamburgerPnl)
        Me.Controls.Add(Me.dashboardTablePnl)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.hamburgerPnl.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.UserDetailPanel.ResumeLayout(False)
        Me.UserDetailPanel.PerformLayout()
        CType(Me.ProfilePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dashboardTablePnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents hamburgerPnl As System.Windows.Forms.Panel
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents dashboardTablePnl As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents HamburgerButton As System.Windows.Forms.Button
    Friend WithEvents AddRemoveButton As System.Windows.Forms.Button
    Friend WithEvents PcMgmtButton As System.Windows.Forms.Button
    Friend WithEvents RecycleBinButton As System.Windows.Forms.Button
    Friend WithEvents AttendanceButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents SlideDownButton As System.Windows.Forms.Button
    Friend WithEvents UserDetailPanel As System.Windows.Forms.Panel
    Friend WithEvents ProfilePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LogOutButton As System.Windows.Forms.Button
    Friend WithEvents HomeButton As System.Windows.Forms.Button
    Friend WithEvents EmailLabel As System.Windows.Forms.Label
    Friend WithEvents PhoneNoLabel As System.Windows.Forms.Label
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents BillButton As System.Windows.Forms.Button
    Friend WithEvents ResultButton As System.Windows.Forms.Button
    Friend WithEvents SettingButton As System.Windows.Forms.Button
    Friend WithEvents NoticeButton As System.Windows.Forms.Button
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
End Class
