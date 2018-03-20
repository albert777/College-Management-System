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
        CType(Me.AttendanceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AttendanceDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.AttendanceDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AttendanceDataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.AttendanceDataGridView.Location = New System.Drawing.Point(0, 283)
        Me.AttendanceDataGridView.Name = "AttendanceDataGridView"
        Me.AttendanceDataGridView.Size = New System.Drawing.Size(1221, 505)
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
        Me.AddButton.ForeColor = System.Drawing.Color.Black
        Me.AddButton.Location = New System.Drawing.Point(904, 242)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 29)
        Me.AddButton.TabIndex = 2
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.FontWeight = MetroFramework.MetroDateTimeWeight.Bold
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime1.Location = New System.Drawing.Point(159, 242)
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
        Me.Label1.Location = New System.Drawing.Point(103, 19)
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
        Me.Panel1.Size = New System.Drawing.Size(1221, 86)
        Me.Panel1.TabIndex = 4
        '
        'UpdateButton
        '
        Me.UpdateButton.ForeColor = System.Drawing.Color.Black
        Me.UpdateButton.Location = New System.Drawing.Point(985, 242)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 29)
        Me.UpdateButton.TabIndex = 6
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.BackColor = System.Drawing.Color.MidnightBlue
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(365, 241)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(134, 30)
        Me.MaterialRaisedButton1.TabIndex = 7
        Me.MaterialRaisedButton1.Text = "Present All"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = False
        '
        'PresentDaysLabel
        '
        Me.PresentDaysLabel.AutoSize = True
        Me.PresentDaysLabel.Depth = 0
        Me.PresentDaysLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.PresentDaysLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PresentDaysLabel.Location = New System.Drawing.Point(1024, 102)
        Me.PresentDaysLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.PresentDaysLabel.Name = "PresentDaysLabel"
        Me.PresentDaysLabel.Size = New System.Drawing.Size(0, 19)
        Me.PresentDaysLabel.TabIndex = 9
        '
        'AbsentDaysLabel
        '
        Me.AbsentDaysLabel.AutoSize = True
        Me.AbsentDaysLabel.Depth = 0
        Me.AbsentDaysLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.AbsentDaysLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AbsentDaysLabel.Location = New System.Drawing.Point(1024, 142)
        Me.AbsentDaysLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.AbsentDaysLabel.Name = "AbsentDaysLabel"
        Me.AbsentDaysLabel.Size = New System.Drawing.Size(0, 19)
        Me.AbsentDaysLabel.TabIndex = 11
        '
        'Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 788)
        Me.Controls.Add(Me.AbsentDaysLabel)
        Me.Controls.Add(Me.PresentDaysLabel)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroDateTime1)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.AttendanceDataGridView)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Attendance"
        Me.Text = "Attendance"
        CType(Me.AttendanceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
End Class
