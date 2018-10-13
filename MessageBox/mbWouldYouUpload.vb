Public Class mbWouldYouUpload

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.Close()
        RecordNaming.ShowDialog()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        System.IO.File.Delete("d:\temporary.mp3")
        Me.Close()
        mbDontUpload.ShowDialog()
    End Sub
End Class