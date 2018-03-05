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
        Me.AttendanceDataGridView = New System.Windows.Forms.DataGridView()
        Me.PACheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PresentCheckBox = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        CType(Me.AttendanceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AttendanceDataGridView
        '
        Me.AttendanceDataGridView.AllowUserToAddRows = False
        Me.AttendanceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AttendanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AttendanceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PACheckBoxColumn})
        Me.AttendanceDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AttendanceDataGridView.Location = New System.Drawing.Point(0, 48)
        Me.AttendanceDataGridView.Name = "AttendanceDataGridView"
        Me.AttendanceDataGridView.Size = New System.Drawing.Size(1221, 776)
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
        Me.PresentCheckBox.Location = New System.Drawing.Point(928, 10)
        Me.PresentCheckBox.Name = "PresentCheckBox"
        Me.PresentCheckBox.Size = New System.Drawing.Size(75, 30)
        Me.PresentCheckBox.TabIndex = 1
        Me.PresentCheckBox.Text = "Present All"
        Me.PresentCheckBox.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(12, 10)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 30)
        Me.AddButton.TabIndex = 2
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.FontWeight = MetroFramework.MetroDateTimeWeight.Bold
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime1.Location = New System.Drawing.Point(1009, 11)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(200, 29)
        Me.MetroDateTime1.TabIndex = 3
        Me.MetroDateTime1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 824)
        Me.Controls.Add(Me.MetroDateTime1)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.PresentCheckBox)
        Me.Controls.Add(Me.AttendanceDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Attendance"
        Me.Text = "Attendance"
        CType(Me.AttendanceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AttendanceDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PACheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PresentCheckBox As System.Windows.Forms.Button
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
End Class
