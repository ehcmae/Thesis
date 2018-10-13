Imports System.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class Report

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rvNoise.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        Dim strSql As String

        If Stat.reportStatus = "all" Then
            strSql = "SELECT * FROM stat;"
        Else
            strSql = "SELECT * FROM stat WHERE alarm_timestamp BETWEEN '" & date1 & " 00:00:00' AND '" & date2 & " 23:59:59';"
        End If

        generateReport(strSql)
    End Sub

    Private Sub generateReport(strSql As String)

        connection()

        Dim SDA As New MySqlDataAdapter
        Dim DS As New DataSetNOISE
        SDA.SelectCommand = New MySqlCommand(strSql, Con)

        SDA.Fill(DS.Tables(0))
        Dim params(5) As ReportParameter
        params(0) = New ReportParameter("ReportDate", reportParamDate)
        params(1) = New ReportParameter("monday", Stat.mon)
        params(2) = New ReportParameter("tuesday", Stat.tues)
        params(3) = New ReportParameter("wednesday", Stat.wed)
        params(4) = New ReportParameter("thursday", Stat.thurs)
        params(5) = New ReportParameter("saturday", Stat.sat)

        rvNoise.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        rvNoise.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
        rvNoise.LocalReport.DataSources.Clear()
        rvNoise.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSetNOISE", DS.Tables(0)))
        rvNoise.DocumentMapCollapsed = True
        rvNoise.ShowParameterPrompts = True
        rvNoise.LocalReport.SetParameters(params)
        Me.rvNoise.RefreshReport()
    End Sub
End Class