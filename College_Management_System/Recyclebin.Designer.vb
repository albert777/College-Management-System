<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecycleBin
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.UserDataGridView = New System.Windows.Forms.DataGridView()
        Me.RestoreDataGridViewButtonColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.StudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SRestoreDataGridViewButtonColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserDataGridView
        '
        Me.UserDataGridView.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.UserDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.UserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UserDataGridView.BackgroundColor = System.Drawing.Color.Silver
        Me.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RestoreDataGridViewButtonColumn})
        Me.UserDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserDataGridView.GridColor = System.Drawing.Color.Black
        Me.UserDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.UserDataGridView.Name = "UserDataGridView"
        Me.UserDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.UserDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.UserDataGridView.Size = New System.Drawing.Size(1194, 378)
        Me.UserDataGridView.TabIndex = 3
        '
        'RestoreDataGridViewButtonColumn
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.RestoreDataGridViewButtonColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.RestoreDataGridViewButtonColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RestoreDataGridViewButtonColumn.HeaderText = "Restore"
        Me.RestoreDataGridViewButtonColumn.Name = "RestoreDataGridViewButtonColumn"
        Me.RestoreDataGridViewButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RestoreDataGridViewButtonColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.RestoreDataGridViewButtonColumn.Text = "Restore"
        Me.RestoreDataGridViewButtonColumn.ToolTipText = "Restore"
        Me.RestoreDataGridViewButtonColumn.UseColumnTextForButtonValue = True
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.StudentDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.StudentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StudentDataGridView.BackgroundColor = System.Drawing.Color.Silver
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SRestoreDataGridViewButtonColumn})
        Me.StudentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StudentDataGridView.GridColor = System.Drawing.Color.Black
        Me.StudentDataGridView.Location = New System.Drawing.Point(3, 387)
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.StudentDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.StudentDataGridView.Size = New System.Drawing.Size(1194, 378)
        Me.StudentDataGridView.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.UserDataGridView, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.StudentDataGridView, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1200, 768)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'SRestoreDataGridViewButtonColumn
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.SRestoreDataGridViewButtonColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.SRestoreDataGridViewButtonColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SRestoreDataGridViewButtonColumn.HeaderText = "Restore"
        Me.SRestoreDataGridViewButtonColumn.Name = "SRestoreDataGridViewButtonColumn"
        Me.SRestoreDataGridViewButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SRestoreDataGridViewButtonColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SRestoreDataGridViewButtonColumn.Text = "Restore"
        Me.SRestoreDataGridViewButtonColumn.ToolTipText = "Restore"
        Me.SRestoreDataGridViewButtonColumn.UseColumnTextForButtonValue = True
        '
        'RecycleBin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 768)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RecycleBin"
        Me.Text = "RecycleBin"
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UserDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RestoreDataGridViewButtonColumn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents StudentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SRestoreDataGridViewButtonColumn As System.Windows.Forms.DataGridViewButtonColumn
End Class
