Imports System.Data.SqlClient

Public Class RecycleBin
    Dim su As AddRemoveStudentStaff = New AddRemoveStudentStaff
    Sub loadUsers()
        Dim dt As New DataTable
        dt = su.loadUsers("Select * FROM userTbl WHERE state = 0")
        UserDataGridView.DataSource = dt
        UserDataGridView.Columns(14).Visible = False
        UserDataGridView.Columns(15).Visible = False
        UserDataGridView.Columns(16).Visible = False
    End Sub

    Private Sub RecycleBin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUsers()
    End Sub


    Private Sub userdatagridview_cellcontentclick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDataGridView.CellContentClick
        Dim userId As Integer = UserDataGridView.CurrentRow.Cells(1).Value
        Try
            Dim con As SqlConnection = su.dbConnect()
            Dim cmd As New SqlCommand("UPDATE userTbl SET state = @state WHERE Id=@userId", con)
            Dim active As Integer = 1
            cmd.Parameters.AddWithValue("@state", active)
            cmd.Parameters.AddWithValue("@userId", userId)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        loadUsers()
    End Sub
End Class