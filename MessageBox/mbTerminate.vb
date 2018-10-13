Public Class mbTerminate

    Private Sub mbTerminate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        for_insert_command("INSERT INTO activity_log VALUES (now(), 'Information','Terminate Program','Visual Studio');", "activity_log")
        End
    End Sub
End Class