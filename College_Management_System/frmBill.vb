Public Class frmBill
    'Dim a As String = frmFeeManager.id
    'Public Sub callBill()
    '    outStudentId.Text = a
    '    outName.Text = frmFeeManager.fn & " " & frmFeeManager.mn & " " & frmFeeManager.ln
    '    outCourse.Text = frmFeeManager.course
    '    'outPreDue.Text = frmFeeManager.pre_amt
    '    'outSemDue.Text = frmFeeManager.sem_amt
    '    'outEduDue.Text = frmFeeManager.edu_amt
    '    'outSchol.Text = frmFeeManager.schol_amt
    '    'lblMis1.Text = frmFeePaymentBox.misName1
    '    'lblMis2.Text = frmFeePaymentBox.misName2
    '    'lblMis3.Text = frmFeePaymentBox.misName3
    '    'outMis1.Text = frmFeePaymentBox.misAmt1
    '    'outMis2.Text = frmFeePaymentBox.misAmt2
    '    'outMis3.Text = frmFeePaymentBox.misAmt3
    '    'outTotal.Text = frmFeePaymentBox.totals
    '    'If outMis1.Equals("") Then
    '    '    lblMis1.Visible = False And outMis1.Visible = False
    '    'End If
    '    'If outMis2.Equals("") Then
    '    '    lblMis2.Visible = False And outMis2.Visible = False
    '    'End If
    '    'If outMis3.Equals("") Then
    '    '    lblMis3.Visible = False And outMis3.Visible = False
    '    'End If
    'End Sub

    'Private Sub frmBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    callBill()
    '    'outStudentId.Text = frmFeeManager.stdId
    '    'outName.Text = frmFeeManager.stdName
    '    'outSem.Text = frmFeeManager.stdSemester
    '    'outCourse.Text = frmFeeManager.stdCourse
    '    'outPreDue.Text = frmFeeManager.pre_amt
    '    'outSemDue.Text = frmFeeManager.sem_amt
    '    'outEduDue.Text = frmFeeManager.edu_amt
    '    'outSchol.Text = frmFeeManager.schol_amt
    '    'lblMis1.Text = frmFeePaymentBox.misName1
    '    'lblMis2.Text = frmFeePaymentBox.misName2
    '    'lblMis3.Text = frmFeePaymentBox.misName3
    '    'outMis1.Text = frmFeePaymentBox.misAmt1
    '    'outMis2.Text = frmFeePaymentBox.misAmt2
    '    'outMis3.Text = frmFeePaymentBox.misAmt3
    '    'outTotal.Text = frmFeePaymentBox.totals
    '    'outTotal.BringToFront()

    '    'If outMis1.Equals("") Then
    '    '    lblMis1.Visible = False And outMis1.Visible = False
    '    'End If
    '    'If outMis2.Equals("") Then
    '    '    lblMis2.Visible = False And outMis2.Visible = False
    '    'End If
    '    'If outMis3.Equals("") Then
    '    '    lblMis3.Visible = False And outMis3.Visible = False
    '    'End If

    '    'RectangleShape1.SendToBack()
    'End Sub

    'Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
    '    'PrintPreviewDialog1.ShowDialog()       //not taking panel to print
    '    'PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
    '    lblTitle.Visible = False
    '    btnConfirm.Visible = False
    '    PrintForm1.Print()
    '    Me.Close()
    'End Sub

    'Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '    Dim bm As Bitmap = New Bitmap(Me.gboPrintable.Width, Me.gboPrintable.Height)
    '    gboPrintable.DrawToBitmap(bm, New Rectangle(0, 0, Me.gboPrintable.Width, Me.gboPrintable.Height))
    '    e.Graphics.DrawImage(bm, 0, 0)
    'End Sub

End Class