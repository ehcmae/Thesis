Imports System.IO
Imports System.Text

Public Class RecordNaming

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If txtName.Text <> "" Then
            Dim sourcepath As String = "d:\temporary.mp3"

            Dim DestPath As String = pathAlarmFolder & txtName.Text & ".mp3"

            Dim path As String = "d:\temporary.mp3"

            Using reader As StreamReader = New StreamReader(New FileStream(path, FileMode.Open), New UTF8Encoding())
                System.IO.File.Copy(path, pathAlarmFolder & txtName.Text & ".mp3")
            End Using

            System.IO.File.Delete("d:\temporary.mp3")

            mbNewAlarmAdded.ShowDialog()

            settings.displayAvailableAlarms()

            settings.listAudio.Items.Add(txtName.Text & ".mp3")

            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class