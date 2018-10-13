Imports MySql.Data.MySqlClient

Public Class ActivityLog

    Private Sub ActivityLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewLogType()
        bindData("SELECT * FROM activity_log;", "activity_log")
        DataGridView1.DataSource = DS.Tables(0)
        Con.Close()
    End Sub

    Public Sub viewLogType()
        viewData("SELECT * FROM activity_log_type;")
        While dreader.Read
            cbLog.Items.Add(dreader.GetValue(0).ToString)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()
        cbLog.SelectedIndex = 0
    End Sub

    Private Sub STATToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STATToolStripMenuItem.Click
        Me.Hide()
        NoiseDetector.Show()
    End Sub
End Class