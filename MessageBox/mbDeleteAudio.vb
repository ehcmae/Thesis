Public Class mbDeleteAudio

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        For Each item In settings.listAudio.CheckedItems
            System.IO.File.Delete(pathAlarmFolder & item)
        Next

        With settings.listAudio

            If .CheckedItems.Count > 0 Then

                For checked As Integer = .CheckedItems.Count - 1 To 0 Step -1

                    .Items.Remove(.CheckedItems(checked))

                Next

            End If

        End With
        settings.displayAvailableAlarms()

        Me.Close()
        mbDelAudioYes.ShowDialog()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Close()
    End Sub
End Class