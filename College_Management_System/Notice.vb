Imports System.Data.SqlClient

Public Class Notice
    Dim su As New AddRemoveStudentStaff
    Dim con As SqlConnection = su.dbConnect
    Dim date_time As String = Now.ToLongTimeString + " " + Now.ToLongDateString
    Sub publishNotice()
        Dim cmd As New SqlCommand("INSERT INTO noticeTbl VALUES(@a,@b)", con)
        cmd.Parameters.AddWithValue("@a", NoticeHeadingTextBox.Text + date_time)
        cmd.Parameters.AddWithValue("@b", NoticeRichTextBox.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Sub loadNotices()
        Dim dt As New DataTable
        dt = su.loadUsers("SELECT * FROM noticeTbl")
        AllNoticeListView.DataSource = dt
        AllNoticeListView.DisplayMember = "heading"
        AllNoticeListView.ValueMember = "Id"
    End Sub
    Private Sub PublishButton_Click(sender As Object, e As EventArgs) Handles PublishButton.Click
        publishNotice()
        loadNotices()
    End Sub

    Private Sub Notice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadNotices()
    End Sub
End Class