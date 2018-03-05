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
        CType(Me.AttendanceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AttendanceDataGridView
        '
        Me.AttendanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AttendanceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PACheckBoxColumn})
        Me.AttendanceDataGridView.Location = New System.Drawing.Point(12, 244)
        Me.AttendanceDataGridView.Name = "AttendanceDataGridView"
        Me.AttendanceDataGridView.Size = New System.Drawing.Size(677, 252)
        Me.AttendanceDataGridView.TabIndex = 0
        '
        'PACheckBoxColumn
        '
        Me.PACheckBoxColumn.HeaderText = "Present/Absent"
        Me.PACheckBoxColumn.Name = "PACheckBoxColumn"
        Me.PACheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PACheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 508)
        Me.Controls.Add(Me.AttendanceDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Attendance"
        Me.Text = "Attendance"
        CType(Me.AttendanceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AttendanceDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PACheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
