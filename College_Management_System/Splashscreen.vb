Imports Transitions

Public Class Splashscreen
    'Progressbar timer For the splashscreen load Event
    Private Sub LoadingTimer_Tick(sender As Object, e As EventArgs) Handles LoadingTimer.Tick
        splashProgressBar.Increment(1)
        If splashProgressBar.Value = 101 Then
            LoadingTimer.Stop()
            Threading.Thread.Sleep(3000)
            Login.Show()
            Me.Hide()
        End If
    End Sub
End Class