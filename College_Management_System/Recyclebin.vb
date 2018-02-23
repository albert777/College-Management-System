Imports System.Data.SqlClient

Public Class RecycleBin
    Dim Dash As Dashboard = New Dashboard()
    Sub loadUsers()
        Dim dt As New DataTable
        dt = Dash.loadUsers("Select * FROM userTbl WHERE state = 0")
        UserDataGridView.DataSource = dt
        UserDataGridView.Columns(14).Visible = False
        UserDataGridView.Columns(15).Visible = False
    End Sub

    Private Sub RecycleBin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUsers()
    End Sub
End Class