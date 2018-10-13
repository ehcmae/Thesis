Public Class mbSaveChanges

    Private Sub mbSaveChanges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
        NoiseDetector.viewSavedUI()
        NoiseDetector.checkMoveObjects.CheckState = CheckState.Unchecked
        NoiseDetector.btnSaveUI.Visible = False
        NoiseDetector.btnCancelUI.Visible = False
        mbSaveChangesUI.closeMb()
    End Sub
End Class