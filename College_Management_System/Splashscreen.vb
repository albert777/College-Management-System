Imports Transitions

Public Class Splashscreen
    Dim login As New Login
    'Progressbar timer For the splashscreen load Event
    Private Sub LoadingTimer_Tick(sender As Object, e As EventArgs) Handles LoadingTimer.Tick
        splashProgressBar.Increment(10)
        If splashProgressBar.Value = 101 Then
            LoadingTimer.Stop()
            Threading.Thread.Sleep(3000)
            login.Show()
            Me.Hide()
            LoadingTimer.Dispose()



        End If
    End Sub
End Class