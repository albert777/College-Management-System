<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBill))
        Me.lblCollegeName = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCollegeAddr = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCollegeContact = New MaterialSkin.Controls.MaterialLabel()
        Me.panel = New System.Windows.Forms.Panel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.outTotal = New MaterialSkin.Controls.MaterialLabel()
        Me.lblTotal = New MaterialSkin.Controls.MaterialLabel()
        Me.outMis3 = New MaterialSkin.Controls.MaterialLabel()
        Me.outMis2 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblMis3 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblMis2 = New MaterialSkin.Controls.MaterialLabel()
        Me.outMis1 = New MaterialSkin.Controls.MaterialLabel()
        Me.outEduDue = New MaterialSkin.Controls.MaterialLabel()
        Me.outPreDue = New MaterialSkin.Controls.MaterialLabel()
        Me.outSchol = New MaterialSkin.Controls.MaterialLabel()
        Me.outSemDue = New MaterialSkin.Controls.MaterialLabel()
        Me.lblMis1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblTitle = New MaterialSkin.Controls.MaterialLabel()
        Me.btnConfirm = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.outSem = New MaterialSkin.Controls.MaterialLabel()
        Me.outName = New MaterialSkin.Controls.MaterialLabel()
        Me.outStudentId = New MaterialSkin.Controls.MaterialLabel()
        Me.outCourse = New MaterialSkin.Controls.MaterialLabel()
        Me.gboPrintable = New System.Windows.Forms.GroupBox()
        Me.logoBox = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.panel.SuspendLayout()
        Me.gboPrintable.SuspendLayout()
        CType(Me.logoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCollegeName
        '
        Me.lblCollegeName.AutoSize = True
        Me.lblCollegeName.Depth = 0
        Me.lblCollegeName.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblCollegeName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCollegeName.Location = New System.Drawing.Point(79, 11)
        Me.lblCollegeName.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCollegeName.Name = "lblCollegeName"
        Me.lblCollegeName.Size = New System.Drawing.Size(123, 19)
        Me.lblCollegeName.TabIndex = 1
        Me.lblCollegeName.Text = "COLLEGE_NAME"
        '
        'lblCollegeAddr
        '
        Me.lblCollegeAddr.AutoSize = True
        Me.lblCollegeAddr.Depth = 0
        Me.lblCollegeAddr.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblCollegeAddr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCollegeAddr.Location = New System.Drawing.Point(79, 34)
        Me.lblCollegeAddr.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCollegeAddr.Name = "lblCollegeAddr"
        Me.lblCollegeAddr.Size = New System.Drawing.Size(119, 19)
        Me.lblCollegeAddr.TabIndex = 2
        Me.lblCollegeAddr.Text = "COLLEGE_ADDR"
        '
        'lblCollegeContact
        '
        Me.lblCollegeContact.AutoSize = True
        Me.lblCollegeContact.Depth = 0
        Me.lblCollegeContact.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblCollegeContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCollegeContact.Location = New System.Drawing.Point(79, 60)
        Me.lblCollegeContact.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCollegeContact.Name = "lblCollegeContact"
        Me.lblCollegeContact.Size = New System.Drawing.Size(149, 19)
        Me.lblCollegeContact.TabIndex = 3
        Me.lblCollegeContact.Text = "COLLEGE_CONTACT"
        '
        'panel
        '
        Me.panel.Controls.Add(Me.outTotal)
        Me.panel.Controls.Add(Me.MaterialLabel1)
        Me.panel.Controls.Add(Me.lblTotal)
        Me.panel.Controls.Add(Me.outMis3)
        Me.panel.Controls.Add(Me.outMis2)
        Me.panel.Controls.Add(Me.lblMis3)
        Me.panel.Controls.Add(Me.lblMis2)
        Me.panel.Controls.Add(Me.outMis1)
        Me.panel.Controls.Add(Me.outEduDue)
        Me.panel.Controls.Add(Me.outPreDue)
        Me.panel.Controls.Add(Me.outSchol)
        Me.panel.Controls.Add(Me.outSemDue)
        Me.panel.Controls.Add(Me.lblMis1)
        Me.panel.Controls.Add(Me.MaterialLabel2)
        Me.panel.Controls.Add(Me.MaterialLabel4)
        Me.panel.Controls.Add(Me.MaterialLabel3)
        Me.panel.Controls.Add(Me.ShapeContainer1)
        Me.panel.Location = New System.Drawing.Point(6, 192)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(572, 268)
        Me.panel.TabIndex = 5
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(13, 44)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(111, 19)
        Me.MaterialLabel1.TabIndex = 2
        Me.MaterialLabel1.Text = "Semester Dues"
        '
        'outTotal
        '
        Me.outTotal.AutoSize = True
        Me.outTotal.Depth = 0
        Me.outTotal.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outTotal.Location = New System.Drawing.Point(431, 233)
        Me.outTotal.MouseState = MaterialSkin.MouseState.HOVER
        Me.outTotal.Name = "outTotal"
        Me.outTotal.Size = New System.Drawing.Size(91, 19)
        Me.outTotal.TabIndex = 4
        Me.outTotal.Text = "TOTAL_DUE"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Depth = 0
        Me.lblTotal.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(14, 233)
        Me.lblTotal.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(55, 19)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "TOTAL"
        '
        'outMis3
        '
        Me.outMis3.AutoSize = True
        Me.outMis3.Depth = 0
        Me.outMis3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outMis3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outMis3.Location = New System.Drawing.Point(430, 166)
        Me.outMis3.MouseState = MaterialSkin.MouseState.HOVER
        Me.outMis3.Name = "outMis3"
        Me.outMis3.Size = New System.Drawing.Size(50, 19)
        Me.outMis3.TabIndex = 4
        Me.outMis3.Text = "MIS_3"
        '
        'outMis2
        '
        Me.outMis2.AutoSize = True
        Me.outMis2.Depth = 0
        Me.outMis2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outMis2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outMis2.Location = New System.Drawing.Point(431, 143)
        Me.outMis2.MouseState = MaterialSkin.MouseState.HOVER
        Me.outMis2.Name = "outMis2"
        Me.outMis2.Size = New System.Drawing.Size(50, 19)
        Me.outMis2.TabIndex = 4
        Me.outMis2.Text = "MIS_2"
        '
        'lblMis3
        '
        Me.lblMis3.AutoSize = True
        Me.lblMis3.Depth = 0
        Me.lblMis3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblMis3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMis3.Location = New System.Drawing.Point(13, 166)
        Me.lblMis3.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblMis3.Name = "lblMis3"
        Me.lblMis3.Size = New System.Drawing.Size(119, 19)
        Me.lblMis3.TabIndex = 4
        Me.lblMis3.Text = "Miscellaneous 3"
        '
        'lblMis2
        '
        Me.lblMis2.AutoSize = True
        Me.lblMis2.Depth = 0
        Me.lblMis2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblMis2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMis2.Location = New System.Drawing.Point(14, 143)
        Me.lblMis2.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblMis2.Name = "lblMis2"
        Me.lblMis2.Size = New System.Drawing.Size(119, 19)
        Me.lblMis2.TabIndex = 4
        Me.lblMis2.Text = "Miscellaneous 2"
        '
        'outMis1
        '
        Me.outMis1.AutoSize = True
        Me.outMis1.Depth = 0
        Me.outMis1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outMis1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outMis1.Location = New System.Drawing.Point(430, 120)
        Me.outMis1.MouseState = MaterialSkin.MouseState.HOVER
        Me.outMis1.Name = "outMis1"
        Me.outMis1.Size = New System.Drawing.Size(50, 19)
        Me.outMis1.TabIndex = 4
        Me.outMis1.Text = "MIS_1"
        '
        'outEduDue
        '
        Me.outEduDue.AutoSize = True
        Me.outEduDue.Depth = 0
        Me.outEduDue.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outEduDue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outEduDue.Location = New System.Drawing.Point(430, 70)
        Me.outEduDue.MouseState = MaterialSkin.MouseState.HOVER
        Me.outEduDue.Name = "outEduDue"
        Me.outEduDue.Size = New System.Drawing.Size(74, 19)
        Me.outEduDue.TabIndex = 3
        Me.outEduDue.Text = "EDU_DUE"
        '
        'outPreDue
        '
        Me.outPreDue.AutoSize = True
        Me.outPreDue.Depth = 0
        Me.outPreDue.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outPreDue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outPreDue.Location = New System.Drawing.Point(429, 18)
        Me.outPreDue.MouseState = MaterialSkin.MouseState.HOVER
        Me.outPreDue.Name = "outPreDue"
        Me.outPreDue.Size = New System.Drawing.Size(72, 19)
        Me.outPreDue.TabIndex = 1
        Me.outPreDue.Text = "PRE_DUE"
        '
        'outSchol
        '
        Me.outSchol.AutoSize = True
        Me.outSchol.Depth = 0
        Me.outSchol.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outSchol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outSchol.Location = New System.Drawing.Point(430, 95)
        Me.outSchol.MouseState = MaterialSkin.MouseState.HOVER
        Me.outSchol.Name = "outSchol"
        Me.outSchol.Size = New System.Drawing.Size(93, 19)
        Me.outSchol.TabIndex = 4
        Me.outSchol.Text = "SCHOL_DUE"
        '
        'outSemDue
        '
        Me.outSemDue.AutoSize = True
        Me.outSemDue.Depth = 0
        Me.outSemDue.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outSemDue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outSemDue.Location = New System.Drawing.Point(429, 44)
        Me.outSemDue.MouseState = MaterialSkin.MouseState.HOVER
        Me.outSemDue.Name = "outSemDue"
        Me.outSemDue.Size = New System.Drawing.Size(76, 19)
        Me.outSemDue.TabIndex = 2
        Me.outSemDue.Text = "SEM_DUE"
        '
        'lblMis1
        '
        Me.lblMis1.AutoSize = True
        Me.lblMis1.Depth = 0
        Me.lblMis1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblMis1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMis1.Location = New System.Drawing.Point(14, 120)
        Me.lblMis1.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblMis1.Name = "lblMis1"
        Me.lblMis1.Size = New System.Drawing.Size(119, 19)
        Me.lblMis1.TabIndex = 4
        Me.lblMis1.Text = "Miscellaneous 1"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(14, 70)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(116, 19)
        Me.MaterialLabel2.TabIndex = 3
        Me.MaterialLabel2.Text = "Educational Tax"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(14, 95)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(88, 19)
        Me.MaterialLabel4.TabIndex = 4
        Me.MaterialLabel4.Text = "Scholarship"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(13, 18)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(105, 19)
        Me.MaterialLabel3.TabIndex = 1
        Me.MaterialLabel3.Text = "Previous Dues"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(572, 268)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 420
        Me.LineShape2.X2 = 420
        Me.LineShape2.Y1 = 15
        Me.LineShape2.Y2 = 251
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(6, 10)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(557, 248)
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 1
        Me.LineShape1.X2 = 569
        Me.LineShape1.Y1 = 71
        Me.LineShape1.Y2 = 68
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Depth = 0
        Me.lblTitle.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(193, 9)
        Me.lblTitle.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(195, 19)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "CONFIRM BILLING DETAILS"
        '
        'btnConfirm
        '
        Me.btnConfirm.Depth = 0
        Me.btnConfirm.Location = New System.Drawing.Point(248, 517)
        Me.btnConfirm.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Primary = True
        Me.btnConfirm.Size = New System.Drawing.Size(122, 46)
        Me.btnConfirm.TabIndex = 7
        Me.btnConfirm.Text = "Confirm Print"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(10, 115)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(53, 19)
        Me.MaterialLabel5.TabIndex = 1
        Me.MaterialLabel5.Text = "Name:"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(10, 139)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(77, 19)
        Me.MaterialLabel6.TabIndex = 2
        Me.MaterialLabel6.Text = "Semester:"
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(10, 163)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(61, 19)
        Me.MaterialLabel7.TabIndex = 3
        Me.MaterialLabel7.Text = "Course:"
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(10, 93)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(82, 19)
        Me.MaterialLabel8.TabIndex = 6
        Me.MaterialLabel8.Text = "Student ID:"
        '
        'outSem
        '
        Me.outSem.AutoSize = True
        Me.outSem.Depth = 0
        Me.outSem.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outSem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outSem.Location = New System.Drawing.Point(88, 139)
        Me.outSem.MouseState = MaterialSkin.MouseState.HOVER
        Me.outSem.Name = "outSem"
        Me.outSem.Size = New System.Drawing.Size(85, 19)
        Me.outSem.TabIndex = 2
        Me.outSem.Text = "SEMESTER"
        '
        'outName
        '
        Me.outName.AutoSize = True
        Me.outName.Depth = 0
        Me.outName.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outName.Location = New System.Drawing.Point(88, 115)
        Me.outName.MouseState = MaterialSkin.MouseState.HOVER
        Me.outName.Name = "outName"
        Me.outName.Size = New System.Drawing.Size(87, 19)
        Me.outName.TabIndex = 1
        Me.outName.Text = "STD_NAME"
        '
        'outStudentId
        '
        Me.outStudentId.AutoSize = True
        Me.outStudentId.Depth = 0
        Me.outStudentId.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outStudentId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outStudentId.Location = New System.Drawing.Point(88, 93)
        Me.outStudentId.MouseState = MaterialSkin.MouseState.HOVER
        Me.outStudentId.Name = "outStudentId"
        Me.outStudentId.Size = New System.Drawing.Size(81, 19)
        Me.outStudentId.TabIndex = 6
        Me.outStudentId.Text = "Student_ID"
        '
        'outCourse
        '
        Me.outCourse.AutoSize = True
        Me.outCourse.Depth = 0
        Me.outCourse.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.outCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.outCourse.Location = New System.Drawing.Point(88, 163)
        Me.outCourse.MouseState = MaterialSkin.MouseState.HOVER
        Me.outCourse.Name = "outCourse"
        Me.outCourse.Size = New System.Drawing.Size(66, 19)
        Me.outCourse.TabIndex = 3
        Me.outCourse.Text = "COURSE"
        '
        'gboPrintable
        '
        Me.gboPrintable.Controls.Add(Me.outSem)
        Me.gboPrintable.Controls.Add(Me.outCourse)
        Me.gboPrintable.Controls.Add(Me.MaterialLabel6)
        Me.gboPrintable.Controls.Add(Me.outStudentId)
        Me.gboPrintable.Controls.Add(Me.MaterialLabel5)
        Me.gboPrintable.Controls.Add(Me.MaterialLabel8)
        Me.gboPrintable.Controls.Add(Me.outName)
        Me.gboPrintable.Controls.Add(Me.MaterialLabel7)
        Me.gboPrintable.Controls.Add(Me.panel)
        Me.gboPrintable.Controls.Add(Me.lblCollegeContact)
        Me.gboPrintable.Controls.Add(Me.logoBox)
        Me.gboPrintable.Controls.Add(Me.lblCollegeName)
        Me.gboPrintable.Controls.Add(Me.lblCollegeAddr)
        Me.gboPrintable.Controls.Add(Me.ShapeContainer3)
        Me.gboPrintable.Location = New System.Drawing.Point(12, 31)
        Me.gboPrintable.Name = "gboPrintable"
        Me.gboPrintable.Size = New System.Drawing.Size(584, 480)
        Me.gboPrintable.TabIndex = 9
        Me.gboPrintable.TabStop = False
        '
        'logoBox
        '
        Me.logoBox.Location = New System.Drawing.Point(4, 11)
        Me.logoBox.Name = "logoBox"
        Me.logoBox.Size = New System.Drawing.Size(69, 68)
        Me.logoBox.TabIndex = 0
        Me.logoBox.TabStop = False
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer3.Size = New System.Drawing.Size(578, 461)
        Me.ShapeContainer3.TabIndex = 7
        Me.ShapeContainer3.TabStop = False
        '
        'frmBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(604, 598)
        Me.Controls.Add(Me.gboPrintable)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblTitle)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bill Print Preview"
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        Me.gboPrintable.ResumeLayout(False)
        Me.gboPrintable.PerformLayout()
        CType(Me.logoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logoBox As System.Windows.Forms.PictureBox
    Friend WithEvents lblCollegeName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCollegeAddr As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCollegeContact As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents panel As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblMis1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents outMis1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents outEduDue As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents outPreDue As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents outSchol As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents outSemDue As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblMis3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblMis2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents outTotal As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTotal As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents outMis3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents outMis2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnConfirm As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents gboPrintable As System.Windows.Forms.GroupBox
    Friend WithEvents outCourse As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents outStudentId As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents outSem As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents outName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
End Class
