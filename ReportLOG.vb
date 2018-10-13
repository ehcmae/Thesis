Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class ReportLOG

    Private Sub ReportLOG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rvLog.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        generateReport(Stat.logSql)
    End Sub

    Private Sub generateReport(strSql As String)

        connection()

        Dim SDA As New MySqlDataAdapter
        Dim DS As New DataSetNOISE
        SDA.SelectCommand = New MySqlCommand(strSql, Con)

        SDA.Fill(DS.Tables(0))
        Dim params(0) As ReportParameter
        params(0) = New ReportParameter("logMsg", reportParamDate)

        rvLog.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        rvLog.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\ReportLOG.rdlc"
        rvLog.LocalReport.DataSources.Clear()
        rvLog.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSetLOG", DS.Tables(0)))
        rvLog.DocumentMapCollapsed = True
        rvLog.ShowParameterPrompts = True
        rvLog.LocalReport.SetParameters(params)
        Me.rvLog.RefreshReport()
    End Sub
End Class