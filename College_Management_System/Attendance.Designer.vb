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
        Me.PresentCheckBox = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AttendanceDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.AttendanceDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AttendanceDataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.AttendanceDataGridView.Location = New System.Drawing.Point(0, 181)
        Me.AttendanceDataGridView.Name = "AttendanceDataGridView"
        Me.AttendanceDataGridView.Size = New System.Drawing.Size(1221, 607)
        Me.AttendanceDataGridView.TabIndex = 0
        '
        'PACheckBoxColumn
        '
        Me.PACheckBoxColumn.HeaderText = "Present/Absent"
        Me.PACheckBoxColumn.Name = "PACheckBoxColumn"
        Me.PACheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PACheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'PresentCheckBox
        '
        Me.PresentCheckBox.ForeColor = System.Drawing.Color.Black
        Me.PresentCheckBox.Location = New System.Drawing.Point(461, 116)
        Me.PresentCheckBox.Name = "PresentCheckBox"
        Me.PresentCheckBox.Size = New System.Drawing.Size(69, 59)
        Me.PresentCheckBox.TabIndex = 1
        Me.PresentCheckBox.Text = "Present All"
        Me.PresentCheckBox.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.ForeColor = System.Drawing.Color.Black
        Me.AddButton.Location = New System.Drawing.Point(370, 116)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 59)
        Me.AddButton.TabIndex = 2
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.FontWeight = MetroFramework.MetroDateTimeWeight.Bold
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime1.Location = New System.Drawing.Point(110, 129)
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
        'Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 788)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroDateTime1)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.PresentCheckBox)
        Me.Controls.Add(Me.AttendanceDataGridView)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Attendance"
        Me.Text = "Attendance"
        CType(Me.AttendanceDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents AttendanceDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PACheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PresentCheckBox As System.Windows.Forms.Button
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
