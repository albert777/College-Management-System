<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFeePaymentBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFeePaymentBox))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gboPayment = New System.Windows.Forms.GroupBox()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.misHeaderName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.misAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddElement = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnCancel = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnSavePrint = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSummary = New MaterialSkin.Controls.MaterialLabel()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.outTotalAmt = New MaterialSkin.Controls.MaterialLabel()
        Me.lblTotalAmt = New MaterialSkin.Controls.MaterialLabel()
        Me.outPaidAmt = New MaterialSkin.Controls.MaterialLabel()
        Me.lblPaidAmt = New MaterialSkin.Controls.MaterialLabel()
        Me.outDueAmt = New MaterialSkin.Controls.MaterialLabel()
        Me.lblRemarks = New MaterialSkin.Controls.MaterialLabel()
        Me.lblDueAmt = New MaterialSkin.Controls.MaterialLabel()
        Me.txtPaidAmount = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtScholar = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtEducation = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtSemester = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtPrevious = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.outWords = New MaterialSkin.Controls.MaterialLabel()
        Me.lblWords = New MaterialSkin.Controls.MaterialLabel()
        Me.lblScholar = New MaterialSkin.Controls.MaterialLabel()
        Me.lblPaidFee = New MaterialSkin.Controls.MaterialLabel()
        Me.lblEducationFee = New MaterialSkin.Controls.MaterialLabel()
        Me.lblSemesterFee = New MaterialSkin.Controls.MaterialLabel()
        Me.lblPreviousFee = New MaterialSkin.Controls.MaterialLabel()
        Me.gboDetails = New System.Windows.Forms.GroupBox()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnPrintBill = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.outStdIntake = New MaterialSkin.Controls.MaterialLabel()
        Me.outStdCourse = New MaterialSkin.Controls.MaterialLabel()
        Me.outStdSem = New MaterialSkin.Controls.MaterialLabel()
        Me.outStdId = New MaterialSkin.Controls.MaterialLabel()
        Me.outStdName = New MaterialSkin.Controls.MaterialLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PrintPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintBill = New System.Drawing.Printing.PrintDocument()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Panel1.SuspendLayout()
        Me.gboPayment.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddElement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.gboDetails.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gboPayment)
        Me.Panel1.Controls.Add(Me.gboDetails)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(975, 534)
        Me.Panel1.TabIndex = 0
        '
        'gboPayment
        '
        Me.gboPayment.Controls.Add(Me.MaterialLabel6)
        Me.gboPayment.Controls.Add(Me.DataGridView1)
        Me.gboPayment.Controls.Add(Me.btnAddElement)
        Me.gboPayment.Controls.Add(Me.btnCancel)
        Me.gboPayment.Controls.Add(Me.btnSavePrint)
        Me.gboPayment.Controls.Add(Me.Panel2)
        Me.gboPayment.Controls.Add(Me.txtPaidAmount)
        Me.gboPayment.Controls.Add(Me.txtScholar)
        Me.gboPayment.Controls.Add(Me.txtEducation)
        Me.gboPayment.Controls.Add(Me.txtSemester)
        Me.gboPayment.Controls.Add(Me.txtPrevious)
        Me.gboPayment.Controls.Add(Me.outWords)
        Me.gboPayment.Controls.Add(Me.lblWords)
        Me.gboPayment.Controls.Add(Me.lblScholar)
        Me.gboPayment.Controls.Add(Me.lblPaidFee)
        Me.gboPayment.Controls.Add(Me.lblEducationFee)
        Me.gboPayment.Controls.Add(Me.lblSemesterFee)
        Me.gboPayment.Controls.Add(Me.lblPreviousFee)
        Me.gboPayment.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboPayment.Location = New System.Drawing.Point(320, 5)
        Me.gboPayment.Name = "gboPayment"
        Me.gboPayment.Size = New System.Drawing.Size(650, 494)
        Me.gboPayment.TabIndex = 1
        Me.gboPayment.TabStop = False
        Me.gboPayment.Text = "Payment Details (In Rs.)"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(17, 166)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(111, 19)
        Me.MaterialLabel6.TabIndex = 8
        Me.MaterialLabel6.Text = "Miscellaneous:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.misHeaderName, Me.misAmount})
        Me.DataGridView1.Location = New System.Drawing.Point(22, 200)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(369, 150)
        Me.DataGridView1.TabIndex = 7
        '
        'misHeaderName
        '
        Me.misHeaderName.HeaderText = "Header Name"
        Me.misHeaderName.Name = "misHeaderName"
        '
        'misAmount
        '
        Me.misAmount.HeaderText = "Amount"
        Me.misAmount.Name = "misAmount"
        '
        'btnAddElement
        '
        Me.btnAddElement.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAddElement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAddElement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnAddElement.Image = Global.College_Management_System.My.Resources.Resources.Plus_24px
        Me.btnAddElement.ImageActive = Nothing
        Me.btnAddElement.Location = New System.Drawing.Point(133, 162)
        Me.btnAddElement.Name = "btnAddElement"
        Me.btnAddElement.Size = New System.Drawing.Size(36, 32)
        Me.btnAddElement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAddElement.TabIndex = 6
        Me.btnAddElement.TabStop = False
        Me.btnAddElement.Zoom = 10
        '
        'btnCancel
        '
        Me.btnCancel.Depth = 0
        Me.btnCancel.Location = New System.Drawing.Point(191, 425)
        Me.btnCancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Primary = True
        Me.btnCancel.Size = New System.Drawing.Size(150, 41)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSavePrint
        '
        Me.btnSavePrint.Depth = 0
        Me.btnSavePrint.Location = New System.Drawing.Point(22, 425)
        Me.btnSavePrint.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSavePrint.Name = "btnSavePrint"
        Me.btnSavePrint.Primary = True
        Me.btnSavePrint.Size = New System.Drawing.Size(150, 41)
        Me.btnSavePrint.TabIndex = 2
        Me.btnSavePrint.Text = "Save and Print"
        Me.btnSavePrint.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblSummary)
        Me.Panel2.Controls.Add(Me.txtRemarks)
        Me.Panel2.Controls.Add(Me.outTotalAmt)
        Me.Panel2.Controls.Add(Me.lblTotalAmt)
        Me.Panel2.Controls.Add(Me.outPaidAmt)
        Me.Panel2.Controls.Add(Me.lblPaidAmt)
        Me.Panel2.Controls.Add(Me.outDueAmt)
        Me.Panel2.Controls.Add(Me.lblRemarks)
        Me.Panel2.Controls.Add(Me.lblDueAmt)
        Me.Panel2.Location = New System.Drawing.Point(397, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(247, 263)
        Me.Panel2.TabIndex = 3
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Depth = 0
        Me.lblSummary.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblSummary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSummary.Location = New System.Drawing.Point(72, 10)
        Me.lblSummary.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(100, 19)
        Me.lblSummary.TabIndex = 6
        Me.lblSummary.Text = "Fee Summary"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(14, 163)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(217, 88)
        Me.txtRemarks.TabIndex = 2
        '
        'outTotalAmt
        '
        Me.outTotalAmt.AutoSize = True
        Me.outTotalAmt.Depth = 0
        Me.outTotalAmt.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outTotalAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outTotalAmt.Location = New System.Drawing.Point(134, 51)
        Me.outTotalAmt.MouseState = MaterialSkin.MouseState.HOVER
        Me.outTotalAmt.Name = "outTotalAmt"
        Me.outTotalAmt.Size = New System.Drawing.Size(94, 19)
        Me.outTotalAmt.TabIndex = 1
        Me.outTotalAmt.Text = "TOTAL_AMT"
        '
        'lblTotalAmt
        '
        Me.lblTotalAmt.AutoSize = True
        Me.lblTotalAmt.Depth = 0
        Me.lblTotalAmt.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblTotalAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalAmt.Location = New System.Drawing.Point(10, 51)
        Me.lblTotalAmt.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTotalAmt.Name = "lblTotalAmt"
        Me.lblTotalAmt.Size = New System.Drawing.Size(134, 19)
        Me.lblTotalAmt.TabIndex = 1
        Me.lblTotalAmt.Text = "Total Amount: Rs. "
        '
        'outPaidAmt
        '
        Me.outPaidAmt.AutoSize = True
        Me.outPaidAmt.Depth = 0
        Me.outPaidAmt.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outPaidAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outPaidAmt.Location = New System.Drawing.Point(134, 83)
        Me.outPaidAmt.MouseState = MaterialSkin.MouseState.HOVER
        Me.outPaidAmt.Name = "outPaidAmt"
        Me.outPaidAmt.Size = New System.Drawing.Size(81, 19)
        Me.outPaidAmt.TabIndex = 1
        Me.outPaidAmt.Text = "PAID_AMT"
        '
        'lblPaidAmt
        '
        Me.lblPaidAmt.AutoSize = True
        Me.lblPaidAmt.Depth = 0
        Me.lblPaidAmt.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblPaidAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPaidAmt.Location = New System.Drawing.Point(10, 83)
        Me.lblPaidAmt.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPaidAmt.Name = "lblPaidAmt"
        Me.lblPaidAmt.Size = New System.Drawing.Size(132, 19)
        Me.lblPaidAmt.TabIndex = 1
        Me.lblPaidAmt.Text = "Paid Amount:  Rs. "
        '
        'outDueAmt
        '
        Me.outDueAmt.AutoSize = True
        Me.outDueAmt.Depth = 0
        Me.outDueAmt.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outDueAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outDueAmt.Location = New System.Drawing.Point(134, 115)
        Me.outDueAmt.MouseState = MaterialSkin.MouseState.HOVER
        Me.outDueAmt.Name = "outDueAmt"
        Me.outDueAmt.Size = New System.Drawing.Size(77, 19)
        Me.outDueAmt.TabIndex = 1
        Me.outDueAmt.Text = "DUE_AMT"
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Depth = 0
        Me.lblRemarks.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblRemarks.Location = New System.Drawing.Point(10, 140)
        Me.lblRemarks.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(72, 19)
        Me.lblRemarks.TabIndex = 1
        Me.lblRemarks.Text = "Remarks:"
        '
        'lblDueAmt
        '
        Me.lblDueAmt.AutoSize = True
        Me.lblDueAmt.Depth = 0
        Me.lblDueAmt.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblDueAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDueAmt.Location = New System.Drawing.Point(10, 115)
        Me.lblDueAmt.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblDueAmt.Name = "lblDueAmt"
        Me.lblDueAmt.Size = New System.Drawing.Size(129, 19)
        Me.lblDueAmt.TabIndex = 1
        Me.lblDueAmt.Text = "Due Amount:   Rs."
        '
        'txtPaidAmount
        '
        Me.txtPaidAmount.Depth = 0
        Me.txtPaidAmount.Hint = ""
        Me.txtPaidAmount.Location = New System.Drawing.Point(133, 363)
        Me.txtPaidAmount.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPaidAmount.Name = "txtPaidAmount"
        Me.txtPaidAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPaidAmount.SelectedText = ""
        Me.txtPaidAmount.SelectionLength = 0
        Me.txtPaidAmount.SelectionStart = 0
        Me.txtPaidAmount.Size = New System.Drawing.Size(155, 23)
        Me.txtPaidAmount.TabIndex = 2
        Me.txtPaidAmount.Text = "PAID_AMOUNT"
        Me.txtPaidAmount.UseSystemPasswordChar = False
        '
        'txtScholar
        '
        Me.txtScholar.Depth = 0
        Me.txtScholar.Hint = ""
        Me.txtScholar.Location = New System.Drawing.Point(133, 132)
        Me.txtScholar.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtScholar.Name = "txtScholar"
        Me.txtScholar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtScholar.SelectedText = ""
        Me.txtScholar.SelectionLength = 0
        Me.txtScholar.SelectionStart = 0
        Me.txtScholar.Size = New System.Drawing.Size(184, 23)
        Me.txtScholar.TabIndex = 2
        Me.txtScholar.Text = "SCHOLAR_AMT"
        Me.txtScholar.UseSystemPasswordChar = False
        '
        'txtEducation
        '
        Me.txtEducation.Depth = 0
        Me.txtEducation.Hint = ""
        Me.txtEducation.Location = New System.Drawing.Point(133, 101)
        Me.txtEducation.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtEducation.Name = "txtEducation"
        Me.txtEducation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEducation.SelectedText = ""
        Me.txtEducation.SelectionLength = 0
        Me.txtEducation.SelectionStart = 0
        Me.txtEducation.Size = New System.Drawing.Size(184, 23)
        Me.txtEducation.TabIndex = 2
        Me.txtEducation.Text = "EDUCATION_FEE"
        Me.txtEducation.UseSystemPasswordChar = False
        '
        'txtSemester
        '
        Me.txtSemester.Depth = 0
        Me.txtSemester.Hint = ""
        Me.txtSemester.Location = New System.Drawing.Point(133, 67)
        Me.txtSemester.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtSemester.Name = "txtSemester"
        Me.txtSemester.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSemester.SelectedText = ""
        Me.txtSemester.SelectionLength = 0
        Me.txtSemester.SelectionStart = 0
        Me.txtSemester.Size = New System.Drawing.Size(184, 23)
        Me.txtSemester.TabIndex = 2
        Me.txtSemester.Text = "SEMESTER_FEE"
        Me.txtSemester.UseSystemPasswordChar = False
        '
        'txtPrevious
        '
        Me.txtPrevious.Depth = 0
        Me.txtPrevious.Hint = ""
        Me.txtPrevious.Location = New System.Drawing.Point(133, 36)
        Me.txtPrevious.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPrevious.Name = "txtPrevious"
        Me.txtPrevious.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrevious.SelectedText = ""
        Me.txtPrevious.SelectionLength = 0
        Me.txtPrevious.SelectionStart = 0
        Me.txtPrevious.Size = New System.Drawing.Size(184, 23)
        Me.txtPrevious.TabIndex = 2
        Me.txtPrevious.Text = "PREVIOUS_DUES"
        Me.txtPrevious.UseSystemPasswordChar = False
        '
        'outWords
        '
        Me.outWords.AutoSize = True
        Me.outWords.Depth = 0
        Me.outWords.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outWords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outWords.Location = New System.Drawing.Point(96, 394)
        Me.outWords.MouseState = MaterialSkin.MouseState.HOVER
        Me.outWords.Name = "outWords"
        Me.outWords.Size = New System.Drawing.Size(82, 19)
        Me.outWords.TabIndex = 1
        Me.outWords.Text = "IN_WORDS"
        '
        'lblWords
        '
        Me.lblWords.AutoSize = True
        Me.lblWords.Depth = 0
        Me.lblWords.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblWords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblWords.Location = New System.Drawing.Point(18, 394)
        Me.lblWords.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblWords.Name = "lblWords"
        Me.lblWords.Size = New System.Drawing.Size(72, 19)
        Me.lblWords.TabIndex = 1
        Me.lblWords.Text = "In Words:"
        '
        'lblScholar
        '
        Me.lblScholar.AutoSize = True
        Me.lblScholar.Depth = 0
        Me.lblScholar.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblScholar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblScholar.Location = New System.Drawing.Point(18, 132)
        Me.lblScholar.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblScholar.Name = "lblScholar"
        Me.lblScholar.Size = New System.Drawing.Size(92, 19)
        Me.lblScholar.TabIndex = 1
        Me.lblScholar.Text = "Scholarship:"
        '
        'lblPaidFee
        '
        Me.lblPaidFee.AutoSize = True
        Me.lblPaidFee.Depth = 0
        Me.lblPaidFee.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblPaidFee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPaidFee.Location = New System.Drawing.Point(18, 366)
        Me.lblPaidFee.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPaidFee.Name = "lblPaidFee"
        Me.lblPaidFee.Size = New System.Drawing.Size(99, 19)
        Me.lblPaidFee.TabIndex = 1
        Me.lblPaidFee.Text = "Paid Amount:"
        '
        'lblEducationFee
        '
        Me.lblEducationFee.AutoSize = True
        Me.lblEducationFee.Depth = 0
        Me.lblEducationFee.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblEducationFee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblEducationFee.Location = New System.Drawing.Point(18, 101)
        Me.lblEducationFee.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblEducationFee.Name = "lblEducationFee"
        Me.lblEducationFee.Size = New System.Drawing.Size(108, 19)
        Me.lblEducationFee.TabIndex = 1
        Me.lblEducationFee.Text = "Education Tax:"
        '
        'lblSemesterFee
        '
        Me.lblSemesterFee.AutoSize = True
        Me.lblSemesterFee.Depth = 0
        Me.lblSemesterFee.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblSemesterFee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSemesterFee.Location = New System.Drawing.Point(18, 66)
        Me.lblSemesterFee.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSemesterFee.Name = "lblSemesterFee"
        Me.lblSemesterFee.Size = New System.Drawing.Size(105, 19)
        Me.lblSemesterFee.TabIndex = 1
        Me.lblSemesterFee.Text = "Semester Fee:"
        '
        'lblPreviousFee
        '
        Me.lblPreviousFee.AutoSize = True
        Me.lblPreviousFee.Depth = 0
        Me.lblPreviousFee.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblPreviousFee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPreviousFee.Location = New System.Drawing.Point(18, 34)
        Me.lblPreviousFee.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPreviousFee.Name = "lblPreviousFee"
        Me.lblPreviousFee.Size = New System.Drawing.Size(109, 19)
        Me.lblPreviousFee.TabIndex = 1
        Me.lblPreviousFee.Text = "Previous Dues:"
        '
        'gboDetails
        '
        Me.gboDetails.Controls.Add(Me.MaterialLabel5)
        Me.gboDetails.Controls.Add(Me.MaterialLabel4)
        Me.gboDetails.Controls.Add(Me.MaterialLabel3)
        Me.gboDetails.Controls.Add(Me.MaterialLabel2)
        Me.gboDetails.Controls.Add(Me.MaterialLabel1)
        Me.gboDetails.Controls.Add(Me.btnPrintBill)
        Me.gboDetails.Controls.Add(Me.outStdIntake)
        Me.gboDetails.Controls.Add(Me.outStdCourse)
        Me.gboDetails.Controls.Add(Me.outStdSem)
        Me.gboDetails.Controls.Add(Me.outStdId)
        Me.gboDetails.Controls.Add(Me.outStdName)
        Me.gboDetails.Controls.Add(Me.PictureBox1)
        Me.gboDetails.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboDetails.Location = New System.Drawing.Point(3, 3)
        Me.gboDetails.Name = "gboDetails"
        Me.gboDetails.Size = New System.Drawing.Size(309, 496)
        Me.gboDetails.TabIndex = 0
        Me.gboDetails.TabStop = False
        Me.gboDetails.Text = "Student Details"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(42, 390)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(88, 19)
        Me.MaterialLabel5.TabIndex = 3
        Me.MaterialLabel5.Text = "Intake Year:"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(42, 358)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(61, 19)
        Me.MaterialLabel4.TabIndex = 3
        Me.MaterialLabel4.Text = "Course:"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(42, 327)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(73, 19)
        Me.MaterialLabel3.TabIndex = 3
        Me.MaterialLabel3.Text = "Semester"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(42, 295)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(82, 19)
        Me.MaterialLabel2.TabIndex = 3
        Me.MaterialLabel2.Text = "Student ID:"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(42, 258)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(53, 19)
        Me.MaterialLabel1.TabIndex = 3
        Me.MaterialLabel1.Text = "Name:"
        '
        'btnPrintBill
        '
        Me.btnPrintBill.Depth = 0
        Me.btnPrintBill.Location = New System.Drawing.Point(75, 425)
        Me.btnPrintBill.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrintBill.Name = "btnPrintBill"
        Me.btnPrintBill.Primary = True
        Me.btnPrintBill.Size = New System.Drawing.Size(150, 41)
        Me.btnPrintBill.TabIndex = 2
        Me.btnPrintBill.Text = "Print Bill"
        Me.btnPrintBill.UseVisualStyleBackColor = True
        '
        'outStdIntake
        '
        Me.outStdIntake.AutoSize = True
        Me.outStdIntake.Depth = 0
        Me.outStdIntake.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outStdIntake.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outStdIntake.Location = New System.Drawing.Point(127, 390)
        Me.outStdIntake.MouseState = MaterialSkin.MouseState.HOVER
        Me.outStdIntake.Name = "outStdIntake"
        Me.outStdIntake.Size = New System.Drawing.Size(135, 19)
        Me.outStdIntake.TabIndex = 1
        Me.outStdIntake.Text = "STUDENT_INTAKE"
        '
        'outStdCourse
        '
        Me.outStdCourse.AutoSize = True
        Me.outStdCourse.Depth = 0
        Me.outStdCourse.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outStdCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outStdCourse.Location = New System.Drawing.Point(127, 358)
        Me.outStdCourse.MouseState = MaterialSkin.MouseState.HOVER
        Me.outStdCourse.Name = "outStdCourse"
        Me.outStdCourse.Size = New System.Drawing.Size(140, 19)
        Me.outStdCourse.TabIndex = 1
        Me.outStdCourse.Text = "STUDENT_COURSE"
        '
        'outStdSem
        '
        Me.outStdSem.AutoSize = True
        Me.outStdSem.Depth = 0
        Me.outStdSem.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outStdSem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outStdSem.Location = New System.Drawing.Point(127, 327)
        Me.outStdSem.MouseState = MaterialSkin.MouseState.HOVER
        Me.outStdSem.Name = "outStdSem"
        Me.outStdSem.Size = New System.Drawing.Size(114, 19)
        Me.outStdSem.TabIndex = 1
        Me.outStdSem.Text = "STUDENT_SEM"
        '
        'outStdId
        '
        Me.outStdId.AutoSize = True
        Me.outStdId.Depth = 0
        Me.outStdId.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outStdId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outStdId.Location = New System.Drawing.Point(127, 295)
        Me.outStdId.MouseState = MaterialSkin.MouseState.HOVER
        Me.outStdId.Name = "outStdId"
        Me.outStdId.Size = New System.Drawing.Size(97, 19)
        Me.outStdId.TabIndex = 1
        Me.outStdId.Text = "STUDENT_ID"
        '
        'outStdName
        '
        Me.outStdName.AutoSize = True
        Me.outStdName.Depth = 0
        Me.outStdName.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outStdName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outStdName.Location = New System.Drawing.Point(127, 258)
        Me.outStdName.MouseState = MaterialSkin.MouseState.HOVER
        Me.outStdName.Name = "outStdName"
        Me.outStdName.Size = New System.Drawing.Size(126, 19)
        Me.outStdName.TabIndex = 1
        Me.outStdName.Text = "STUDENT_NAME"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.College_Management_System.My.Resources.Resources.user_male2_512
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Global.College_Management_System.My.Resources.Resources.user_male2_512
        Me.PictureBox1.Location = New System.Drawing.Point(58, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 204)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 540.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(981, 540)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'PrintPreview
        '
        Me.PrintPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreview.Document = Me.PrintBill
        Me.PrintPreview.Enabled = True
        Me.PrintPreview.Icon = CType(resources.GetObject("PrintPreview.Icon"), System.Drawing.Icon)
        Me.PrintPreview.Name = "PrintPreviewDialog1"
        Me.PrintPreview.Visible = False
        '
        'PrintBill
        '
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = False
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.btnCancel
        Me.BunifuDragControl1.Vertical = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'frmFeePaymentBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1002, 562)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFeePaymentBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fee Payment Box"
        Me.Panel1.ResumeLayout(False)
        Me.gboPayment.ResumeLayout(False)
        Me.gboPayment.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddElement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.gboDetails.ResumeLayout(False)
        Me.gboDetails.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gboDetails As System.Windows.Forms.GroupBox
    Friend WithEvents gboPayment As System.Windows.Forms.GroupBox
    Friend WithEvents outStdName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents outStdId As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents outStdIntake As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents outStdCourse As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents outStdSem As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnPrintBill As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblPreviousFee As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblPaidFee As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblEducationFee As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblSemesterFee As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtEducation As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtSemester As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtPrevious As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtPaidAmount As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents outTotalAmt As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTotalAmt As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents outPaidAmt As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblPaidAmt As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents outDueAmt As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblDueAmt As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblRemarks As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents outWords As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblWords As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnCancel As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnSavePrint As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PrintPreview As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintBill As System.Drawing.Printing.PrintDocument
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents lblSummary As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnAddElement As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents txtScholar As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblScholar As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents misHeaderName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents misAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
End Class
