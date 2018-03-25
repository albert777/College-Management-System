Imports System.Data.SqlClient

Public Class frmFeePaymentBox
    Public pre_amt, sem_amt, edu_amt, schol_amt, paid_amt, total_amt, due_amt, ma1, ma2, ma3 As Integer
    Public misName1, misName2, misName3, misAmt1, misAmt2, misAmt3 As String
    Dim count As Integer = 0
    Dim mOnesArray(8) As String
    Dim mOneTensArray(9) As String
    Dim mTensArray(7) As String
    Dim mPlaceValues(4) As String
    Dim Place() As String
    Dim Left, Right As String

    Public Sub frmPaymentBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeComponent()
        'Keeping labels to default
        outTotalAmt.Text = "0"
        outPaidAmt.Text = "0"
        outDueAmt.Text = "0"
        Dim a As String = frmFeeManager.id
        outStdId.Text = a
        outStdName.Text = frmFeeManager.fn & " " & frmFeeManager.mn & " " & frmFeeManager.ln
        outStdCourse.Text = frmFeeManager.course
        txtScholar.Text = frmFeeManager.scholar
        checkText()

        'calculations
        total_amt = pre_amt + sem_amt + edu_amt
        total_amt = total_amt - schol_amt
        outTotalAmt.Text = total_amt.ToString()
    End Sub



    Private Sub txtPaidAmount_TextChanged(sender As Object, e As EventArgs) Handles txtPaidAmount.TextChanged
        'calculations

        'paid_amt = CInt(txtPaidAmount.Text)
        'outPaidAmt.Text = paid_amt.ToString()
        'due_amt = total_amt - paid_amt
        'outDueAmt.Text = due_amt.ToString()

        'changing IN WORDS label
        outWords.Text = ConvertNumberToWords(txtPaidAmount.Text)

    End Sub



    'Dim posX As Integer = 30
    'Dim posY As Integer = 140
    Private Sub btnAddElement_Click(sender As Object, e As EventArgs) Handles btnAddElement.Click
        'Try
        '    Dim misTxtCODE As String = "misTxtCODE" & count
        '    Dim elementAdd As New TextBox()
        '    gboPayment.Controls.Add(elementAdd)
        '    posY = posY + 30
        '    elementAdd.Left = posX
        '    elementAdd.Top = posY
        '    misTxtCODE = elementAdd.Name = "newTxtElement" & count
        '    elementAdd.Text = "Miscellaneous " & count
        '    elementAdd.BringToFront()
        '    elementAdd.Visible = True
        '    elementAdd.AutoSize = True
        '    count = count + 1

        '    total_amt = pre_amt + sem_amt + edu_amt + CInt(add0)
        '    outTotalAmt.Text = total_amt.ToString()

        '    If count.Equals(3) Then
        '        btnAddElement.Dispose()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex)
        'End Try

            DataGridView1.Rows.Add()
            count = count + 1
            If count.Equals(3) Then
                btnAddElement.Dispose()
            End If
    End Sub

    Public Sub calcElements()
        'calculations
        If IsNumeric(txtPaidAmount.Text) = False Then
            MsgBox("Only Numbers.")
            txtPaidAmount.Text = ""
        Else
            'calculations
            total_amt = pre_amt + sem_amt + edu_amt
            outTotalAmt.Text = total_amt.ToString()

            paid_amt = CInt(txtPaidAmount.Text)
            outPaidAmt.Text = paid_amt.ToString()
            due_amt = total_amt - paid_amt
            outDueAmt.Text = due_amt.ToString()

            'changing IN WORDS label
            outWords.Text = ConvertNumberToWords(txtPaidAmount.Text)
        End If
    End Sub
    Sub checkText()


        'setting Default value
        If txtPrevious.Text = "" Then
            txtPrevious.Text = "0"
        End If
        If txtSemester.Text = "" Then
            txtSemester.Text = "0"
        End If
        If txtScholar.Text = "" Then
            txtScholar.Text = "0"
        End If
        If txtEducation.Text = "" Then
            txtEducation.Text = "1000"
        End If
        If txtRemarks.Text = "" Then
            txtRemarks.Text = " "
        End If
        If misName1 = "" Or misAmt1 = "" Then
            misName1 = " "
            misAmt1 = "0"
        End If
        If misName2 = "" Or misAmt2 = "" Then
            misName2 = " "
            misAmt2 = "0"
        End If
        If misName3 = "" Or misAmt3 = "" Then
            misName3 = " "
            misAmt3 = "0"
        End If

        'Converting strings to intergers
        'pre_amt = CInt(txtPrevious.Text)
        'sem_amt = CInt(txtSemester.Text)
        'edu_amt = CInt(txtEducation.Text)
        'schol_amt = CInt(txtScholar.Text)
        'ma1 = CInt(misAmt1)
        'ma2 = CInt(misAmt2)     ''''''''''''''''''''''''''''
        'ma3 = CInt(misAmt3)

    End Sub

    Sub updateFire()
        'current date and time stamp
        Dim dateNow As Date = Now
        'dateNow = DateString + " " + TimeString

        'UPDATE Query
        checkText()
        Try
            Dim con As New SqlConnection("Data Source=(localdb)\v11.0;Integrated Security=True; Database=StudentRecords")   'DB Connection
            Dim cmd As New SqlCommand("UPDATE StudentRecords SET Semester_Fee=@sem,Educational_Fee=@edu,Scholarship_Amt=@schol,misName1=@misname1,misName2=@misname2,misName3=@misname3,misAmount1=@misamt1,misAmount2=@misamt2,misAmount3=@misamt3,Previous_Dues=@due,Last_Paid_Amt=@lastPay,Last_Payment_Date=@date,remarks=@remark WHERE StudentID=@a", con)
            cmd.Parameters.AddWithValue("@a", frmFeeManager.id)   'Parameterized Command
            cmd.Parameters.AddWithValue("@sem", Trim(sem_amt.ToString()))
            cmd.Parameters.AddWithValue("@edu", Trim(edu_amt.ToString()))
            cmd.Parameters.AddWithValue("@schol", Trim(schol_amt.ToString()))
            cmd.Parameters.AddWithValue("@due", Trim(due_amt.ToString()))
            cmd.Parameters.AddWithValue("@misname1", misName1.ToString())
            cmd.Parameters.AddWithValue("@misname2", misName2.ToString())
            cmd.Parameters.AddWithValue("@misname3", misName3.ToString())
            cmd.Parameters.AddWithValue("@misamt1", misAmt1.ToString())
            cmd.Parameters.AddWithValue("@misamt2", misAmt2.ToString())
            cmd.Parameters.AddWithValue("@misamt3", misAmt3.ToString())
            cmd.Parameters.AddWithValue("@lastPay", Trim(paid_amt.ToString()))
            cmd.Parameters.AddWithValue("@date", dateNow)
            cmd.Parameters.AddWithValue("@remark", Trim(txtRemarks.Text))
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Information Updated Successfully.")
            txtPaidAmount.Text = "0"
            frmFeeManager.refreshTable()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub New()

        mOnesArray(0) = "One"
        mOnesArray(1) = "Two"
        mOnesArray(2) = "Three"
        mOnesArray(3) = "Four"
        mOnesArray(4) = "Five"
        mOnesArray(5) = "Six"
        mOnesArray(6) = "Seven"
        mOnesArray(7) = "Eight"
        mOnesArray(8) = "Nine"

        mOneTensArray(0) = "Ten"
        mOneTensArray(1) = "Eleven"
        mOneTensArray(2) = "Twelve"
        mOneTensArray(3) = "Thirteen"
        mOneTensArray(4) = "Fourteen"
        mOneTensArray(5) = "Fifteen"
        mOneTensArray(6) = "Sixteen"
        mOneTensArray(7) = "Seventeen"
        mOneTensArray(8) = "Eightteen"
        mOneTensArray(9) = "Nineteen"

        mTensArray(0) = "Twenty"
        mTensArray(1) = "Thirty"
        mTensArray(2) = "Forty"
        mTensArray(3) = "Fifty"
        mTensArray(4) = "Sixty"
        mTensArray(5) = "Seventy"
        mTensArray(6) = "Eighty"
        mTensArray(7) = "Ninety"

        mPlaceValues(0) = "Hundred"
        mPlaceValues(1) = "Thousand"
        mPlaceValues(2) = "Million"
        mPlaceValues(3) = "Billion"
        mPlaceValues(4) = "Trillion"
    End Sub

    Protected Function GetOnes(ByVal OneDigit As Integer) As String

        GetOnes = ""

        If OneDigit = 0 Then
            Exit Function
        End If

        GetOnes = mOnesArray(OneDigit - 1)

    End Function

    Protected Function GetTens(ByVal TensDigit As Integer) As String

        GetTens = ""

        If TensDigit = 0 Or TensDigit = 1 Then
            Exit Function
        End If

        GetTens = mTensArray(TensDigit - 2)

    End Function

    Public Function ConvertNumberToWords(ByVal NumberValue As String) As String

        Dim Delimiter As String = " "
        Dim TensDelimiter As String = "-"
        Dim mNumberValue As String = ""
        Dim mNumbers As String = ""
        Dim mNumWord As String = ""
        Dim mFraction As String = ""
        Dim mNumberStack() As String
        Dim j As Integer = 0
        Dim i As Integer = 0
        Dim mOneTens As Boolean = False

        ConvertNumberToWords = ""

        ' validate input
        Try
            j = CDbl(NumberValue)
        Catch ex As Exception
            ConvertNumberToWords = "Invalid input."
            Exit Function
        End Try

        ' get fractional part {if any}
        If InStr(NumberValue, ".") = 0 Then
            ' no fraction
            mNumberValue = NumberValue
        Else
            mNumberValue = Microsoft.VisualBasic.Left(NumberValue, InStr(NumberValue, ".") - 1)
            mFraction = Mid(NumberValue, InStr(NumberValue, ".")) ' + 1)
            mFraction = Math.Round(CSng(mFraction), 2) * 100

            If CInt(mFraction) = 0 Then
                mFraction = ""
            Else
                mFraction = "&& " & mFraction & "/100"
            End If
        End If
        mNumbers = mNumberValue.ToCharArray

        ' move numbers to stack/array backwards
        For j = mNumbers.Length - 1 To 0 Step -1
            ReDim Preserve mNumberStack(i)

            mNumberStack(i) = mNumbers(j)
            i += 1
        Next

        For j = mNumbers.Length - 1 To 0 Step -1
            Select Case j
                Case 0, 3, 6, 9, 12
                    ' ones  value
                    If Not mOneTens Then
                        mNumWord &= GetOnes(Val(mNumberStack(j))) & Delimiter
                    End If

                    Select Case j
                        Case 3
                            ' thousands
                            mNumWord &= mPlaceValues(1) & Delimiter

                        Case 5
                            ' millions
                            mNumWord &= mPlaceValues(2) & Delimiter

                        Case 7
                            ' billions
                            mNumWord &= mPlaceValues(3) & Delimiter

                        Case 9
                            ' trillions
                            mNumWord &= mPlaceValues(4) & Delimiter
                    End Select


                Case Is = 1, 4, 7, 10, 13
                    ' tens value
                    If Val(mNumberStack(j)) = 0 Then
                        mNumWord &= GetOnes(Val(mNumberStack(j - 1))) & Delimiter
                        mOneTens = True
                        Exit Select
                    End If

                    If Val(mNumberStack(j)) = 1 Then
                        mNumWord &= mOneTensArray(Val(mNumberStack(j - 1))) & Delimiter
                        mOneTens = True
                        Exit Select
                    End If

                    mNumWord &= GetTens(Val(mNumberStack(j)))

                    ' this places the tensdelimiter; check for succeeding 0
                    If Val(mNumberStack(j - 1)) <> 0 Then
                        mNumWord &= TensDelimiter
                    End If
                    mOneTens = False

                Case Else
                    ' hundreds value 
                    mNumWord &= GetOnes(Val(mNumberStack(j))) & Delimiter

                    If Val(mNumberStack(j)) <> 0 Then
                        mNumWord &= mPlaceValues(0) & Delimiter
                    End If
            End Select
        Next

        Return mNumWord & mFraction

    End Function

    'Public Sub allMiscel()
    '    Dim n As Integer = 0
    '    DataGridView1.Rows.Add()
    '    DataGridView1.Rows.Item(n).Cells(0).Value = frmFeeManager.misName1
    '    DataGridView1.Rows.Item(n).Cells(1).Value = frmFeeManager.misAmt1
    '    misName1 = DataGridView1.Rows.Item(n).Cells(0).Value
    '    misAmt1 = DataGridView1.Rows.Item(n).Cells(1).Value
    '    n = n + 1
    '    DataGridView1.Rows.Add()
    '    DataGridView1.Rows.Item(n).Cells(0).Value = frmFeeManager.misName2
    '    DataGridView1.Rows.Item(n).Cells(1).Value = frmFeeManager.misAmt2
    '    misName2 = DataGridView1.Rows.Item(n).Cells(0).Value
    '    misAmt2 = DataGridView1.Rows.Item(n).Cells(1).Value
    '    n = n + 1
    '    DataGridView1.Rows.Add()
    '    DataGridView1.Rows.Item(n).Cells(0).Value = frmFeeManager.misName3
    '    DataGridView1.Rows.Item(n).Cells(1).Value = frmFeeManager.misAmt3
    '    misName3 = DataGridView1.Rows.Item(n).Cells(0).Value
    '    misAmt3 = DataGridView1.Rows.Item(n).Cells(1).Value

    '    btnAddElement.Dispose()

    'End Sub
    Public totals As String
    Private Sub btnPrintBill_Click(sender As Object, e As EventArgs) Handles btnPrintBill.Click
        'printpreview.showdialog()
        'printbill.print()

        'me.printform1.printaction = printing.printaction.printtopreview
        'me.printform1.print()

        Dim frmbill As New frmBill()
        totals = outTotalAmt.Text
        frmbill.ShowDialog()
    End Sub

    Private Sub printbill_printpage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintBill.PrintPage
        'dim font as new font("arial", 16, fontstyle.regular)
        'e.graphics.drawstring(outstdname.text, font, brushes.black, 0, 0)

        'dim bm as bitmap = new bitmap(me.gbopayment.width, me.gbopayment.height)
        'gbodetails.drawtobitmap(bm, new rectangle(0, 0, me.gbopayment.width, me.gbopayment.height))
        'e.graphics.drawimage(bm, 0, 0)
    End Sub




    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs) Handles btnSavePrint.Click
        updateFire()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim resultYN As Integer = MessageBox.Show("Sure to close?", "Cancel", MessageBoxButtons.YesNo)
        If resultYN = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


End Class