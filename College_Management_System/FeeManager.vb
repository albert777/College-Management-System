Imports System.Data.SqlClient
Public Class frmFeeManager
    'Public con As New SqlConnection("Data Source=(localdb)\v11.0;Integrated Security=True; Database=CMS")

    'Public Sub refreshTable()
    '    txtSearch.Text = "Search..."
    '    'Dim con As New SqlConnection("Data Source=(localdb)\v11.0;Integrated Security=True; Database=StudentRecords")
    '    Dim cmd As New SqlCommand("SELECT * FROM stuTbl", con)
    '    Dim da As New SqlDataAdapter(cmd)
    '    Dim dt As New DataTable()
    '    da.Fill(dt)
    '    DataGridView1.DataSource = dt

    '    DataGridView1.Columns(4).Visible = False
    '    DataGridView1.Columns(5).Visible = False
    '    DataGridView1.Columns(6).Visible = False
    '    DataGridView1.Columns(7).Visible = False
    '    DataGridView1.Columns(8).Visible = False
    '    DataGridView1.Columns(9).Visible = False
    '    DataGridView1.Columns(10).Visible = False
    '    DataGridView1.Columns(11).Visible = False
    '    DataGridView1.Columns(12).Visible = False
    '    DataGridView1.Columns(13).Visible = False
    '    DataGridView1.Columns(14).Visible = False
    '    DataGridView1.Columns(15).Visible = False
    '    DataGridView1.Columns(18).Visible = False
    '    DataGridView1.Columns(19).Visible = False
    '    DataGridView1.Columns(20).Visible = False
    '    DataGridView1.Columns(21).Visible = False

    'End Sub

    'Public Sub searchStudent()
    '    Dim cmd As New SqlCommand("SELECT * FROM stuTbl WHERE Id LIKE @a", con)    'SQL Query
    '    cmd.Parameters.AddWithValue("@a", txtSearch.Text + "%")   'Parameterized Command
    '    Dim da As New SqlDataAdapter(cmd)   'Adapter Object - Mediator betn Data and Table
    '    Dim dt As New DataTable()   'Table Object'
    '    da.Fill(dt) 'Loads data in Table
    '    DataGridView1.DataSource = dt   'Shows up Data in Table

    'End Sub

    'Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
    '    txtSearch.Text = ""
    'End Sub

    'Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
    '    searchStudent()
    'End Sub

    'Private Sub btnRefresh_Click_1(sender As Object, e As EventArgs) Handles btnRefresh.Click
    '    refreshTable()
    'End Sub

    'Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click, btnSearch.Click
    '    searchStudent()
    'End Sub

    'Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click, btnClear.Click
    '    refreshTable()
    'End Sub
    'Public Shared id, fn, ln, mn, scholar, course As String
    'Public Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    id = DataGridView1.CurrentRow.Cells(0).Value.ToString()
    '    fn = DataGridView1.CurrentRow.Cells(1).Value.ToString()
    '    mn = DataGridView1.CurrentRow.Cells(2).Value.ToString()
    '    ln = DataGridView1.CurrentRow.Cells(3).Value.ToString()
    '    course = DataGridView1.CurrentRow.Cells(4).Value.ToString()
    '    scholar = DataGridView1.CurrentRow.Cells(5).Value.ToString()
    '    Dim FeePaymentBox As New frmFeePaymentBox()
    '    FeePaymentBox.ShowDialog()
    'End Sub

    'Private Sub frmFeeManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    refreshTable()
    'End Sub



End Class
