Imports Transitions

Public Class Splashscreen
    'Progressbar timer For the splashscreen load Event
    Dim login As New Login
    Private Sub LoadingTimer_Tick(sender As Object, e As EventArgs) Handles LoadingTimer.Tick
        splashProgressBar.Increment(5)
        If splashProgressBar.Value = 101 Then
            LoadingTimer.Stop()
            Threading.Thread.Sleep(3000)
            LoadingTimer.Dispose()
            login.Show()
            Me.Hide()
        End If
    End Sub
End Class