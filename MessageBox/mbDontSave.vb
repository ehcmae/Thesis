Public Class mbDontSave

    Private Sub mbDontSave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
        mbSaveChangesUI.closeMb()
    End Sub
End Class