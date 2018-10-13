Public Class mbCancelEdit

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Hide()
        mbDontSave.ShowDialog()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.Hide()
        mbDontMakeAnyChanges.ShowDialog()
    End Sub
End Class