Imports Transitions
Imports System.IO

Public Class Dashboard


    Private Sub hamburgerPb_Click_1(sender As Object, e As EventArgs) Handles hamburgerPb.Click
        If (hamburgerPnl.Width < 250) Then

            Transition.run(hamburgerPnl, "Width", 250, New TransitionType_EaseInEaseOut(150))
        Else
            Transition.run(hamburgerPnl, "Width", 55, New TransitionType_EaseInEaseOut(150))
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        dashboardTablePnl.Visible = True
        dashboardTablePnl.Enabled = True
        BunifuTransition1.ShowSync(dashboardTablePnl)

    End Sub
    Sub imageChooser(ByVal a As String)
        Dim openDialogImg As OpenFileDialog = New OpenFileDialog
        openDialogImg.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        openDialogImg.FilterIndex = 2
        openDialogImg.RestoreDirectory = True
        If openDialogImg.ShowDialog() = DialogResult.OK Then
            If File.Exists(openDialogImg.FileName) = False Then
                MessageBox.Show("Sorry, The File You Specified Does Not Exist.")
            Else
                If (a = "adminImageSelectUsers") Then
                    PictureBox3.ImageLocation = openDialogImg.FileName
                ElseIf (a = "adminImageSelectStudents") Then
                    PictureBox4.ImageLocation = openDialogImg.FileName
                End If

            End If

        End If
    End Sub
    Private Sub addUserTb_Click(sender As Object, e As EventArgs) Handles addUserTb.Click
        Transition.run(hamburgerPnl, "Width", 55, New TransitionType_EaseInEaseOut(150))
    End Sub

  
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        imageChooser("adminImageSelectUsers")
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        imageChooser("adminImageSelectStudents")
    End Sub

    Private Sub allUsersTb_Click(sender As Object, e As EventArgs) Handles allUsersTb.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub MaterialLabel5_Click(sender As Object, e As EventArgs) Handles MaterialLabel5.Click

    End Sub

    Private Sub BunifuCustomTextbox1_TextChanged(sender As Object, e As EventArgs) Handles BunifuCustomTextbox1.TextChanged

    End Sub

    Private Sub MaterialLabel4_Click(sender As Object, e As EventArgs) Handles MaterialLabel4.Click

    End Sub

    Private Sub MaterialLabel3_Click(sender As Object, e As EventArgs) Handles MaterialLabel3.Click

    End Sub

    Private Sub MetroComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox2.SelectedIndexChanged

    End Sub

    Private Sub MaterialSingleLineTextField4_Click(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField4.Click

    End Sub

    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime1.ValueChanged

    End Sub

    Private Sub MaterialLabel2_Click(sender As Object, e As EventArgs) Handles MaterialLabel2.Click

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub MaterialTabSelector1_Click(sender As Object, e As EventArgs) Handles MaterialTabSelector1.Click

    End Sub

    Private Sub addStudentTb_Click(sender As Object, e As EventArgs) Handles addStudentTb.Click

    End Sub

    Private Sub MaterialSingleLineTextField1_Click(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField1.Click

    End Sub

    Private Sub MaterialSingleLineTextField2_Click(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField2.Click

    End Sub

    Private Sub MaterialSingleLineTextField7_Click(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField7.Click

    End Sub

    Private Sub MaterialSingleLineTextField3_Click(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField3.Click

    End Sub

    Private Sub MaterialSingleLineTextField5_Click(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField5.Click

    End Sub

    Private Sub MaterialSingleLineTextField6_Click(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField6.Click

    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged

    End Sub

    Private Sub MaterialRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton1.CheckedChanged

    End Sub

    Private Sub MaterialRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton2.CheckedChanged

    End Sub

    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs) Handles MaterialLabel1.Click

    End Sub

    Private Sub a_SelectedIndexChanged(sender As Object, e As EventArgs) Handles a.SelectedIndexChanged

    End Sub

    Private Sub editTablePanelAdmin_Paint(sender As Object, e As PaintEventArgs) Handles editTablePanelAdmin.Paint

    End Sub

    Private Sub dashboardTablePnl_Paint(sender As Object, e As PaintEventArgs) Handles dashboardTablePnl.Paint

    End Sub

    Private Sub dashboardMainPnl_Paint(sender As Object, e As PaintEventArgs) Handles dashboardMainPnl.Paint

    End Sub

    Private Sub hamburgerPnl_Paint(sender As Object, e As PaintEventArgs) Handles hamburgerPnl.Paint

    End Sub
End Class