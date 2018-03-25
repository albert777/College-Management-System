<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AttendanceDataGridView = New System.Windows.Forms.DataGridView()
        Me.PACheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PresentDaysLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.AbsentDaysLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.AttenProgramComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.AttSearchTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        CType(Me.AttendanceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AttendanceDataGridView
        '
        Me.AttendanceDataGridView.AllowUserToAddRows = False
        Me.AttendanceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AttendanceDataGridView.BackgroundColor = System.Drawing.Color.Gray
        Me.AttendanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AttendanceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PACheckBoxColumn})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AttendanceDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.AttendanceDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AttendanceDataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.AttendanceDataGridView.Location = New System.Drawing.Point(0, 149)
        Me.AttendanceDataGridView.Name = "AttendanceDataGridView"
        Me.AttendanceDataGridView.Size = New System.Drawing.Size(1221, 700)
        Me.AttendanceDataGridView.TabIndex = 0
        '
        'PACheckBoxColumn
        '
        Me.PACheckBoxColumn.HeaderText = "Present/Absent"
        Me.PACheckBoxColumn.Name = "PACheckBoxColumn"
        Me.PACheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PACheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.AddButton.FlatAppearance.BorderSize = 0
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.White
        Me.AddButton.Location = New System.Drawing.Point(703, 112)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 31)
        Me.AddButton.TabIndex = 2
        Me.AddButton.Text = "ADD"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.FontWeight = MetroFramework.MetroDateTimeWeight.Bold
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime1.Location = New System.Drawing.Point(357, 110)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(200, 29)
        Me.MetroDateTime1.TabIndex = 3
        Me.MetroDateTime1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(57, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ATTENDANCE MANAGEMENT"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1221, 54)
        Me.Panel1.TabIndex = 4
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.UpdateButton.FlatAppearance.BorderSize = 0
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateButton.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.Color.White
        Me.UpdateButton.Location = New System.Drawing.Point(784, 112)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(106, 31)
        Me.UpdateButton.TabIndex = 6
        Me.UpdateButton.Text = "UPDATE"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.BackColor = System.Drawing.Color.MidnightBlue
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(563, 111)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(134, 32)
        Me.MaterialRaisedButton1.TabIndex = 7
        Me.MaterialRaisedButton1.Text = "Present All"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = False
        '
        'PresentDaysLabel
        '
        Me.PresentDaysLabel.AutoSize = True
        Me.PresentDaysLabel.BackColor = System.Drawing.Color.Transparent
        Me.PresentDaysLabel.Depth = 0
        Me.PresentDaysLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.PresentDaysLabel.ForeColor = System.Drawing.Color.White
        Me.PresentDaysLabel.Location = New System.Drawing.Point(1043, 57)
        Me.PresentDaysLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.PresentDaysLabel.Name = "PresentDaysLabel"
        Me.PresentDaysLabel.Size = New System.Drawing.Size(0, 19)
        Me.PresentDaysLabel.TabIndex = 9
        '
        'AbsentDaysLabel
        '
        Me.AbsentDaysLabel.AutoSize = True
        Me.AbsentDaysLabel.BackColor = System.Drawing.Color.Transparent
        Me.AbsentDaysLabel.Depth = 0
        Me.AbsentDaysLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.AbsentDaysLabel.ForeColor = System.Drawing.Color.White
        Me.AbsentDaysLabel.Location = New System.Drawing.Point(1043, 88)
        Me.AbsentDaysLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.AbsentDaysLabel.Name = "AbsentDaysLabel"
        Me.AbsentDaysLabel.Size = New System.Drawing.Size(0, 19)
        Me.AbsentDaysLabel.TabIndex = 11
        '
        'AttenProgramComboBox
        '
        Me.AttenProgramComboBox.FormattingEnabled = True
        Me.AttenProgramComboBox.ItemHeight = 23
        Me.AttenProgramComboBox.Location = New System.Drawing.Point(155, 110)
        Me.AttenProgramComboBox.Name = "AttenProgramComboBox"
        Me.AttenProgramComboBox.Size = New System.Drawing.Size(196, 29)
        Me.AttenProgramComboBox.TabIndex = 12
        Me.AttenProgramComboBox.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "SELECT PROGRAM"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.College_Management_System.My.Resources.Resources.Search_25px
        Me.PictureBox4.Location = New System.Drawing.Point(894, 113)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(34, 27)
        Me.PictureBox4.TabIndex = 63
        Me.PictureBox4.TabStop = False
        '
        'AttSearchTextBox
        '
        Me.AttSearchTextBox.Depth = 0
        Me.AttSearchTextBox.ForeColor = System.Drawing.Color.White
        Me.AttSearchTextBox.Hint = "Search for userId"
        Me.AttSearchTextBox.Location = New System.Drawing.Point(936, 116)
        Me.AttSearchTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.AttSearchTextBox.Name = "AttSearchTextBox"
        Me.AttSearchTextBox.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.AttSearchTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AttSearchTextBox.SelectedText = ""
        Me.AttSearchTextBox.SelectionLength = 0
        Me.AttSearchTextBox.SelectionStart = 0
        Me.AttSearchTextBox.Size = New System.Drawing.Size(278, 23)
        Me.AttSearchTextBox.TabIndex = 62
        Me.AttSearchTextBox.UseSystemPasswordChar = False
        '
        'Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1221, 849)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.AbsentDaysLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PresentDaysLabel)
        Me.Controls.Add(Me.AttenProgramComboBox)
        Me.Controls.Add(Me.AttSearchTextBox)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroDateTime1)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.AttendanceDataGridView)
        Me.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Attendance"
        Me.Text = "Attendance"
        CType(Me.AttendanceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AttendanceDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PACheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PresentDaysLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AbsentDaysLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AttenProgramComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents AttSearchTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
