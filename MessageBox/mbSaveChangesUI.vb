Public Class mbSaveChangesUI

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        NoiseDetector.saveChangesToUI()
        for_insert_command("INSERT INTO activity_log VALUES (now(), 'Information','Changing of Library Structure','User');", "activity_log")
        'MsgBox("Changes have been successfully saved!", MsgBoxStyle.Information)
        Me.Hide()
        mbSaveChanges.ShowDialog()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Hide()
        mbDontSave.ShowDialog()
    End Sub

    Public Sub closeMb()
        Me.Close()
        NoiseDetector.Enabled = True
    End Sub
End Class