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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.hamburgerPnl = New System.Windows.Forms.Panel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.UserDetailPanel = New System.Windows.Forms.Panel()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.UserTypeLabel = New System.Windows.Forms.Label()
        Me.dashboardTablePnl = New System.Windows.Forms.TableLayoutPanel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.AttendanceButton = New System.Windows.Forms.Button()
        Me.RecycleBinButton = New System.Windows.Forms.Button()
        Me.AdminSettingButton = New System.Windows.Forms.Button()
        Me.AddRemoveButton = New System.Windows.Forms.Button()
        Me.HamburgerButton = New System.Windows.Forms.Button()
        Me.ProfilePictureBox = New System.Windows.Forms.PictureBox()
        Me.SlideDownButton = New System.Windows.Forms.Button()
        Me.hamburgerPnl.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.UserDetailPanel.SuspendLayout()
        Me.dashboardTablePnl.SuspendLayout()
        CType(Me.ProfilePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hamburgerPnl
        '
        Me.hamburgerPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.hamburgerPnl.Controls.Add(Me.HomeButton)
        Me.hamburgerPnl.Controls.Add(Me.LogOutButton)
        Me.hamburgerPnl.Controls.Add(Me.CloseButton)
        Me.hamburgerPnl.Controls.Add(Me.AttendanceButton)
        Me.hamburgerPnl.Controls.Add(Me.RecycleBinButton)
        Me.hamburgerPnl.Controls.Add(Me.AdminSettingButton)
        Me.hamburgerPnl.Controls.Add(Me.AddRemoveButton)
        Me.hamburgerPnl.Controls.Add(Me.HamburgerButton)
        Me.hamburgerPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.hamburgerPnl.Location = New System.Drawing.Point(0, 0)
        Me.hamburgerPnl.Margin = New System.Windows.Forms.Padding(0)
        Me.hamburgerPnl.Name = "hamburgerPnl"
        Me.hamburgerPnl.Size = New System.Drawing.Size(45, 729)
        Me.hamburgerPnl.TabIndex = 3
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.UserDetailPanel)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(48, 0)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1302, 729)
        Me.MainPanel.TabIndex = 0
        '
        'UserDetailPanel
        '
        Me.UserDetailPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserDetailPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.UserDetailPanel.Controls.Add(Me.UsernameLabel)
        Me.UserDetailPanel.Controls.Add(Me.UserTypeLabel)
        Me.UserDetailPanel.Controls.Add(Me.ProfilePictureBox)
        Me.UserDetailPanel.Controls.Add(Me.SlideDownButton)
        Me.UserDetailPanel.Location = New System.Drawing.Point(903, 0)
        Me.UserDetailPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.UserDetailPanel.Name = "UserDetailPanel"
        Me.UserDetailPanel.Size = New System.Drawing.Size(399, 18)
        Me.UserDetailPanel.TabIndex = 2
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Italic)
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.Location = New System.Drawing.Point(120, 332)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(0, 19)
        Me.UsernameLabel.TabIndex = 4
        '
        'UserTypeLabel
        '
        Me.UserTypeLabel.AutoSize = True
        Me.UserTypeLabel.BackColor = System.Drawing.Color.Transparent
        Me.UserTypeLabel.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserTypeLabel.ForeColor = System.Drawing.Color.White
        Me.UserTypeLabel.Location = New System.Drawing.Point(128, 292)
        Me.UserTypeLabel.Name = "UserTypeLabel"
        Me.UserTypeLabel.Size = New System.Drawing.Size(0, 19)
        Me.UserTypeLabel.TabIndex = 3
        Me.UserTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dashboardTablePnl
        '
        Me.dashboardTablePnl.BackColor = System.Drawing.Color.LightSalmon
        Me.dashboardTablePnl.ColumnCount = 2
        Me.dashboardTablePnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.dashboardTablePnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.dashboardTablePnl.Controls.Add(Me.MainPanel, 1, 0)
        Me.dashboardTablePnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dashboardTablePnl.Location = New System.Drawing.Point(0, 0)
        Me.dashboardTablePnl.Margin = New System.Windows.Forms.Padding(0)
        Me.dashboardTablePnl.Name = "dashboardTablePnl"
        Me.dashboardTablePnl.RowCount = 1
        Me.dashboardTablePnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.dashboardTablePnl.Size = New System.Drawing.Size(1350, 729)
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
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.HomeButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HomeButton.FlatAppearance.BorderSize = 0
        Me.HomeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.HomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeButton.ForeColor = System.Drawing.Color.White
        Me.HomeButton.Image = Global.College_Management_System.My.Resources.Resources.Home_32px
        Me.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HomeButton.Location = New System.Drawing.Point(0, 579)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(0)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(45, 50)
        Me.HomeButton.TabIndex = 13
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'LogOutButton
        '
        Me.LogOutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.LogOutButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogOutButton.FlatAppearance.BorderSize = 0
        Me.LogOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.LogOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOutButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutButton.ForeColor = System.Drawing.Color.White
        Me.LogOutButton.Image = Global.College_Management_System.My.Resources.Resources.Logout_Rounded_Left_32px
        Me.LogOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogOutButton.Location = New System.Drawing.Point(0, 629)
        Me.LogOutButton.Margin = New System.Windows.Forms.Padding(0)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(45, 50)
        Me.LogOutButton.TabIndex = 12
        Me.LogOutButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.Image = Global.College_Management_System.My.Resources.Resources.Exit_32px
        Me.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseButton.Location = New System.Drawing.Point(0, 679)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(45, 50)
        Me.CloseButton.TabIndex = 11
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'AttendanceButton
        '
        Me.AttendanceButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.AttendanceButton.FlatAppearance.BorderSize = 0
        Me.AttendanceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.AttendanceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.AttendanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AttendanceButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttendanceButton.ForeColor = System.Drawing.Color.White
        Me.AttendanceButton.Image = Global.College_Management_System.My.Resources.Resources.List_32px1
        Me.AttendanceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AttendanceButton.Location = New System.Drawing.Point(0, 200)
        Me.AttendanceButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AttendanceButton.Name = "AttendanceButton"
        Me.AttendanceButton.Size = New System.Drawing.Size(45, 50)
        Me.AttendanceButton.TabIndex = 10
        Me.AttendanceButton.UseVisualStyleBackColor = False
        '
        'RecycleBinButton
        '
        Me.RecycleBinButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.RecycleBinButton.FlatAppearance.BorderSize = 0
        Me.RecycleBinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.RecycleBinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.RecycleBinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RecycleBinButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecycleBinButton.ForeColor = System.Drawing.Color.White
        Me.RecycleBinButton.Image = Global.College_Management_System.My.Resources.Resources.Trash_32px
        Me.RecycleBinButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RecycleBinButton.Location = New System.Drawing.Point(0, 150)
        Me.RecycleBinButton.Margin = New System.Windows.Forms.Padding(0)
        Me.RecycleBinButton.Name = "RecycleBinButton"
        Me.RecycleBinButton.Size = New System.Drawing.Size(45, 50)
        Me.RecycleBinButton.TabIndex = 9
        Me.RecycleBinButton.UseVisualStyleBackColor = False
        '
        'AdminSettingButton
        '
        Me.AdminSettingButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.AdminSettingButton.FlatAppearance.BorderSize = 0
        Me.AdminSettingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.AdminSettingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.AdminSettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminSettingButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminSettingButton.ForeColor = System.Drawing.Color.White
        Me.AdminSettingButton.Image = Global.College_Management_System.My.Resources.Resources.Admin_Settings_Male_32px
        Me.AdminSettingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AdminSettingButton.Location = New System.Drawing.Point(0, 100)
        Me.AdminSettingButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AdminSettingButton.Name = "AdminSettingButton"
        Me.AdminSettingButton.Size = New System.Drawing.Size(45, 50)
        Me.AdminSettingButton.TabIndex = 8
        Me.AdminSettingButton.UseVisualStyleBackColor = False
        '
        'AddRemoveButton
        '
        Me.AddRemoveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.AddRemoveButton.FlatAppearance.BorderSize = 0
        Me.AddRemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.AddRemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.AddRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddRemoveButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddRemoveButton.ForeColor = System.Drawing.Color.White
        Me.AddRemoveButton.Image = Global.College_Management_System.My.Resources.Resources.Registration_32px
        Me.AddRemoveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddRemoveButton.Location = New System.Drawing.Point(0, 50)
        Me.AddRemoveButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AddRemoveButton.Name = "AddRemoveButton"
        Me.AddRemoveButton.Size = New System.Drawing.Size(45, 50)
        Me.AddRemoveButton.TabIndex = 7
        Me.AddRemoveButton.UseVisualStyleBackColor = False
        '
        'HamburgerButton
        '
        Me.HamburgerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.HamburgerButton.FlatAppearance.BorderSize = 0
        Me.HamburgerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.HamburgerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.HamburgerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HamburgerButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HamburgerButton.ForeColor = System.Drawing.Color.White
        Me.HamburgerButton.Image = Global.College_Management_System.My.Resources.Resources.Menu_32px
        Me.HamburgerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HamburgerButton.Location = New System.Drawing.Point(0, 0)
        Me.HamburgerButton.Margin = New System.Windows.Forms.Padding(0)
        Me.HamburgerButton.Name = "HamburgerButton"
        Me.HamburgerButton.Size = New System.Drawing.Size(45, 50)
        Me.HamburgerButton.TabIndex = 7
        Me.HamburgerButton.UseVisualStyleBackColor = False
        '
        'ProfilePictureBox
        '
        Me.ProfilePictureBox.Image = Global.College_Management_System.My.Resources.Resources._75205
        Me.ProfilePictureBox.Location = New System.Drawing.Point(96, 59)
        Me.ProfilePictureBox.Name = "ProfilePictureBox"
        Me.ProfilePictureBox.Size = New System.Drawing.Size(198, 191)
        Me.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfilePictureBox.TabIndex = 2
        Me.ProfilePictureBox.TabStop = False
        '
        'SlideDownButton
        '
        Me.SlideDownButton.BackColor = System.Drawing.Color.Black
        Me.SlideDownButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SlideDownButton.FlatAppearance.BorderSize = 0
        Me.SlideDownButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.SlideDownButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.SlideDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SlideDownButton.Image = Global.College_Management_System.My.Resources.Resources.Expand_Arrow_24px
        Me.SlideDownButton.Location = New System.Drawing.Point(0, -12)
        Me.SlideDownButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SlideDownButton.Name = "SlideDownButton"
        Me.SlideDownButton.Size = New System.Drawing.Size(399, 30)
        Me.SlideDownButton.TabIndex = 1
        Me.SlideDownButton.UseVisualStyleBackColor = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.hamburgerPnl)
        Me.Controls.Add(Me.dashboardTablePnl)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.dashboardTablePnl.ResumeLayout(False)
        CType(Me.ProfilePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents hamburgerPnl As System.Windows.Forms.Panel
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents dashboardTablePnl As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents HamburgerButton As System.Windows.Forms.Button
    Friend WithEvents AddRemoveButton As System.Windows.Forms.Button
    Friend WithEvents AdminSettingButton As System.Windows.Forms.Button
    Friend WithEvents RecycleBinButton As System.Windows.Forms.Button
    Friend WithEvents AttendanceButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents SlideDownButton As System.Windows.Forms.Button
    Friend WithEvents UserDetailPanel As System.Windows.Forms.Panel
    Friend WithEvents ProfilePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UserTypeLabel As System.Windows.Forms.Label
    Friend WithEvents LogOutButton As System.Windows.Forms.Button
    Friend WithEvents HomeButton As System.Windows.Forms.Button
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
End Class
