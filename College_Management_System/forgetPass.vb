Imports System.Data.SqlClient
Imports Transitions
Imports System.Text

Public Class forgetPass
    Dim amm As New AddRemoveStudentStaff
    Dim con As SqlConnection = amm.dbConnect()
    Public sqls As String
    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
        Dim cmd As New SqlCommand("SELECT * FROM userTbl where email = @a", con)
        cmd.Parameters.AddWithValue("@a", EmailCheckTextBox.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        If (dt.Rows.Count > 0) Then
            Transition.run(Me, "Height", 246, New TransitionType_EaseInEaseOut(100))
            forgetPassPanel.Visible = True
            forgetPassPanel.Enabled = True
            sqls = "UPDATE userTbl SET password = @a WHERE email = @b"
        Else
            If (dt.Rows.Count = 0) Then
                Dim cmd2 As New SqlCommand("SELECT * FROM stuTbl where email = @a", con)
                cmd2.Parameters.AddWithValue("@a", EmailCheckTextBox.Text)
                Dim da2 As New SqlDataAdapter(cmd2)
                Dim dt2 As New DataTable()
                da2.Fill(dt2)
                If (dt2.Rows.Count > 0) Then
                    Transition.run(Me, "Height", 246, New TransitionType_EaseInEaseOut(100))
                    forgetPassPanel.Visible = True
                    forgetPassPanel.Enabled = True
                    sqls = "UPDATE stuTbl SET password = @a WHERE email = @b"
                Else
                    Transition.run(Me, "Height", 108, New TransitionType_EaseInEaseOut(100))
                    forgetPassPanel.Visible = False
                    forgetPassPanel.Enabled = False
                    MsgBox("Email you entered doesnt exist!!")
                End If
            End If
        End If
    End Sub


    Private Sub CancelButton_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Sub updatePassword(sql As String)
        Dim cmd As New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@a", ReEnterPasswordTextBox.Text)
        cmd.Parameters.AddWithValue("@b", EmailCheckTextBox.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Your password has been successfully changed!!")
    End Sub

    Private Sub ChangeButton_Click(sender As Object, e As EventArgs) Handles ChangeButton.Click
        updatePassword(sqls)
    End Sub

    Private Sub CrossPictureBox_Click(sender As Object, e As EventArgs) Handles CrossPictureBox.Click
        Me.Close()
    End Sub

    Private Sub forgetPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Transition.run(Me, "Height", 108, New TransitionType_EaseInEaseOut(100))
        Bun.ShowAsyc(Me)
    End Sub
End Class