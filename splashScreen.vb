Public Class splashScreen

    Private Sub splashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)

        If ProgressBar1.Value = 25 Then
            Label3.Text = "Ito na wait lang . . ."
        ElseIf ProgressBar1.Value = 50 Then
            Label3.Text = "Ohmyghaaaawd wait . . ."
        ElseIf ProgressBar1.Value = 75 Then
            Label3.Text = "Kaunti na laaaang . . ."
        ElseIf ProgressBar1.Value = 100 Then
            Me.Hide()
            Timer1.Enabled = False
            NoiseDetector.Show()
        End If
    End Sub
End Class