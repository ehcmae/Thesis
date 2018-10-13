Imports System.IO
Imports System.Drawing.Printing

Public Class Stat
    Public count1 As Integer
    Public count2 As Integer
    Public count3 As Integer
    Public count4 As Integer
    Public count5 As Integer
    Public count6 As Integer
    Public count7 As Integer
    Public count8 As Integer
    Public count9 As Integer
    Public count10 As Integer
    Public name1 As String = "Table 1"
    Public name2 As String = "Table 2"
    Public name3 As String = "Table 3"
    Public name4 As String = "Table 4"
    Public name5 As String = "Table 5"
    Public name6 As String = "Table 6"
    Public name7 As String = "Table 7"
    Public name8 As String = "Table 8"
    Public name9 As String = "Table 9"
    Public name10 As String = "Table 10"
    Public mon As Integer = 0
    Public tues As Integer = 0
    Public wed As Integer = 0
    Public thurs As Integer = 0
    Public sat As Integer = 0
    Public day1 As String = "Monday"
    Public day2 As String = "Tuesday"
    Public day3 As String = "Wednesday"
    Public day4 As String = "Thursday"
    Public day5 As String = "Saturday"
    Public overAllRec As String
    Public reportStatus As String
    Public logSql As String
    Public logMsg As String
    Public weeklyAllCount As Integer

    Private Sub Stat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshForm()
        refreshFormWeekly()
    End Sub

    Public Sub refreshForm()
        Chart1.ChartAreas(0).AxisX.Interval = 1
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        cbReport.Text = ""
        cbReport.SelectedText = "Report"
        'count number of record
        viewData("SELECT COUNT(*) FROM stat;")
        While dreader.Read
            overAllRec = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        'count number of record for first device
        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 1';")
        While dreader.Read
            count1 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        '=======================================================================
        'CODE FOR STORING THE NUMBER OF RECORDS OF OTHER DEVICES

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 2';")
        While dreader.Read
            count2 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 3';")
        While dreader.Read
            count3 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 4';")
        While dreader.Read
            count4 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 5';")
        While dreader.Read
            count5 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 6';")
        While dreader.Read
            count6 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 7';")
        While dreader.Read
            count7 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 8';")
        While dreader.Read
            count8 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 9';")
        While dreader.Read
            count9 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 10';")
        While dreader.Read
            count10 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()
        '==========================================================================
        'CODE FOR GETTING THE SUPPLIED NAME FOR EACH DEVICE

        'viewData("SELECT name FROM devices WHERE ID = 1;")
        'While dreader.Read
        '    name1 = dreader.GetValue(0)
        'End While
        'dreader.Close()
        'Con.Close()
        'Con.Dispose()

        'viewData("SELECT name FROM devices WHERE ID = 2;")
        'While dreader.Read
        '    name2 = dreader.GetValue(0)
        'End While
        'dreader.Close()
        'Con.Close()
        'Con.Dispose()

        'viewData("SELECT name FROM devices WHERE ID = 3;")
        'While dreader.Read
        '    name3 = dreader.GetValue(0)
        'End While
        'dreader.Close()
        'Con.Close()
        'Con.Dispose()
        'lblName1.Text = "Table 1"
        'lblName2.Text = "Table 2"
        'lblName3.Text = "Table 3"

        'Dim percentage As Integer

        'percentage = (100 / overAllRec) * count1
        'lblPer1.Text = percentage
        'lblPer1.RightToLeft = Windows.Forms.RightToLeft.Yes

        'percentage = (100 / overAllRec) * count2
        'lblPer2.Text = percentage
        'lblPer2.RightToLeft = Windows.Forms.RightToLeft.Yes

        'percentage = (100 / overAllRec) * count3
        'lblPer3.Text = percentage
        'lblPer3.RightToLeft = Windows.Forms.RightToLeft.Yes
        If (count1 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name1, count1)
        End If
        If (count2 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name2, count2)
        End If
        If (count3 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name3, count3)
        End If
        If (count4 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name4, count4)
        End If
        If (count5 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name5, count5)
        End If
        If (count6 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name6, count6)
        End If
        If (count7 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name7, count7)
        End If
        If (count8 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name8, count8)
        End If
        If (count9 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name9, count9)
        End If
        If (count10 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name10, count10)
        End If

        viewLogType()
        bindData("SELECT * FROM activity_log;", "activity_log")
        DataGridView1.DataSource = DS.Tables(0)
        Con.Close()

        rdAllAlarm.Checked = True
        rdAll.Checked = True

        reportParamDate = lblMessage.Text
        reportStatus = "all"
    End Sub

    Public Sub refreshFormWeekly()
        Chart2.ChartAreas(0).AxisX.Interval = 1
        mon = 0
        tues = 0
        wed = 0
        thurs = 0
        sat = 0
        Me.Chart2.Series("Day").Points.Clear()
        Me.Chart2.Series("Day").Points.Clear()
        Me.Chart2.Series("Day").Points.Clear()
        Me.Chart2.Series("Day").Points.Clear()
        Me.Chart2.Series("Day").Points.Clear()
        'Day number of record
        viewData("SELECT COUNT(*) FROM stat;")
        While dreader.Read
            weeklyAllCount = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        Dim dates_date(weeklyAllCount) As Date
        Dim i = 0
        Dim format As String = "yyyy-MM-dd"
        'count number of record for first device
        viewData("SELECT alarm_timestamp FROM stat;")
        While dreader.Read
            If i < weeklyAllCount Then
                dates_date(i) = dreader.GetValue(0)
                i = i + 1
            End If
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        Dim dates(weeklyAllCount) As String
        Dim y = 0

        While y < weeklyAllCount
            dates(y) = dates_date(y).ToString(format)
            y = y + 1
        End While

        Dim x = 0

        While x < weeklyAllCount
            viewData("SELECT WEEKDAY('" & dates(x) & "');")
            While dreader.Read
                If dreader.GetValue(0) = 0 Then
                    mon = mon + 1
                ElseIf dreader.GetValue(0) = 1 Then
                    tues = tues + 1
                ElseIf dreader.GetValue(0) = 2 Then
                    wed = wed + 1
                ElseIf dreader.GetValue(0) = 3 Then
                    thurs = thurs + 1
                ElseIf dreader.GetValue(0) = 5 Then
                    sat = sat + 1
                End If
                x = x + 1
            End While
            dreader.Close()
            Con.Close()
            Con.Dispose()
        End While

        Me.Chart2.Series("Day").Points.AddXY(day1, mon)
        Me.Chart2.Series("Day").Points.AddXY(day2, tues)
        Me.Chart2.Series("Day").Points.AddXY(day3, wed)
        Me.Chart2.Series("Day").Points.AddXY(day4, thurs)
        Me.Chart2.Series("Day").Points.AddXY(day5, sat)
    End Sub

    Public Sub viewLogType()
        cbLog.Items.Clear()

        viewData("SELECT * FROM activity_log_type;")
        While dreader.Read
            cbLog.Items.Add(dreader.GetValue(0).ToString)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()
        cbLog.SelectedIndex = 0
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)
        Me.Hide()
        NoiseDetector.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        NoiseDetector.Show()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)
        Me.Hide()
        NoiseDetector.Show()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        If DateTimePicker2.Value < DateTimePicker1.Value Then
            mbInvalidDate.ShowDialog()
            DateTimePicker2.Value = Date.Now
        End If
    End Sub

    Private Sub rdAll_CheckedChanged(sender As Object, e As EventArgs) Handles rdAll.CheckedChanged
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        btnGo.Enabled = False

        DS.Clear()
        bindData("SELECT * FROM activity_log;", "activity_log")
        logSql = "SELECT * FROM activity_log;"
        DataGridView1.DataSource = DS.Tables(0)
        Con.Close()
    End Sub

    Private Sub rdCustom_CheckedChanged(sender As Object, e As EventArgs) Handles rdCustom.CheckedChanged
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
        btnGo.Enabled = True
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim format As String = "yyyy-MM-dd"
        Dim date1 = DateTimePicker1.Value.ToString(format)
        Dim date2 = DateTimePicker2.Value.ToString(format)
        Dim displayFormat As String = "MMMM dd, yyyy"

        If cbLog.Text = "All" Then
            DS.Clear()

            bindData("SELECT * FROM activity_log WHERE act_timestamp BETWEEN '" & date1 & " 00:00:00' AND '" & date2 & " 23:59:59';", "activity_log")
            logSql = "SELECT * FROM activity_log WHERE act_timestamp BETWEEN '" & date1 & " 00:00:00' AND '" & date2 & " 23:59:59';"
            logMsg = "All Records"
            DataGridView1.DataSource = DS.Tables(0)
            Con.Close()

            If DataGridView1.Rows.Count = 1 Then
                mbNoRecordFound.ShowDialog()
            Else
                If date1 = date2 Then
                    logMsg = "Showing all activity log for the day " & DateTimePicker1.Value.ToString(displayFormat)
                Else
                   logMsg = "Showing all activity log from " & DateTimePicker1.Value.ToString(displayFormat) & " up to " & DateTimePicker2.Value.ToString(displayFormat)
                End If

                'for_insert_command("INSERT INTO activity_log VALUES (now(), 'Information','View activity log','MySQL');", "activity_log")
            End If
        Else
            DS.Clear()

            bindData("SELECT * FROM activity_log WHERE type = '" & cbLog.Text & "' AND act_timestamp BETWEEN '" & date1 & " 00:00:00' AND '" & date2 & " 23:59:59';", "activity_log")
            logSql = "SELECT * FROM activity_log WHERE type = '" & cbLog.Text & "' AND act_timestamp BETWEEN '" & date1 & " 00:00:00' AND '" & date2 & " 23:59:59';"
            DataGridView1.DataSource = DS.Tables(0)
            Con.Close()

            If DataGridView1.Rows.Count = 1 Then
                mbNoRecordFound.ShowDialog()
            Else
                If date1 = date2 Then
                    logMsg = "Showing activity log (" & cbLog.Text & ") for the day " & DateTimePicker1.Value.ToString(displayFormat)
                Else
                    logMsg = "Showing activity log (" & cbLog.Text & ") from " & DateTimePicker1.Value.ToString(displayFormat) & " up to " & DateTimePicker2.Value.ToString(displayFormat)
                End If

                'for_insert_command("INSERT INTO activity_log VALUES (now(), 'Information','View activity log','MySQL');", "activity_log")
            End If
        End If
    End Sub

    Private Sub cbLog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLog.SelectedIndexChanged
        If rdAll.Checked = True Then

            If cbLog.Text = "All" Then
                DS.Clear()

                bindData("SELECT * FROM activity_log;", "activity_log")
                logSql = "SELECT * FROM activity_log;"
                DataGridView1.DataSource = DS.Tables(0)
                Con.Close()

                for_insert_command("INSERT INTO activity_log VALUES (now(), 'Information','View activity log','MySQL');", "activity_log")
            Else
                DS.Clear()

                bindData("SELECT * FROM activity_log WHERE type = '" & cbLog.Text & "';", "activity_log")
                logSql = "SELECT * FROM activity_log WHERE type = '" & cbLog.Text & "';"
                DataGridView1.DataSource = DS.Tables(0)
                Con.Close()

                for_insert_command("INSERT INTO activity_log VALUES (now(), 'Information','View activity log','MySQL');", "activity_log")
            End If

            If DataGridView1.Rows.Count = 1 Then
                mbNoRecordFound.ShowDialog()
            End If
        End If
    End Sub

    Private Sub rdAllAlarm_CheckedChanged(sender As Object, e As EventArgs) Handles rdAllAlarm.CheckedChanged
        dateAlarm1.Enabled = False
        dateAlarm2.Enabled = False
        btnViewChart.Enabled = False

        'count number of record
        viewData("SELECT COUNT(*) FROM stat;")
        While dreader.Read
            overAllRec = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        'count number of record per Table then store in a variable
        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 1';")
        While dreader.Read
            count1 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 2';")
        While dreader.Read
            count2 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 3';")
        While dreader.Read
            count3 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 4';")
        While dreader.Read
            count4 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 5';")
        While dreader.Read
            count5 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 6';")
        While dreader.Read
            count6 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 7';")
        While dreader.Read
            count7 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 8';")
        While dreader.Read
            count8 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 9';")
        While dreader.Read
            count9 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 10';")
        While dreader.Read
            count10 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        'display values in the chart
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()

        If (count1 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name1, count1)
        End If
        If (count2 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name2, count2)
        End If
        If (count3 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name3, count3)
        End If
        If (count4 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name4, count4)
        End If
        If (count5 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name5, count5)
        End If
        If (count6 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name6, count6)
        End If
        If (count7 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name7, count7)
        End If
        If (count8 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name8, count8)
        End If
        If (count9 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name9, count9)
        End If
        If (count10 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name10, count10)
        End If

        refreshFormWeekly()
        lblMessage.Text = "ALL RECORDS"
    End Sub

    Private Sub rdCustomAlarm_CheckedChanged(sender As Object, e As EventArgs) Handles rdCustomAlarm.CheckedChanged
        dateAlarm1.Enabled = True
        dateAlarm2.Enabled = True
        btnViewChart.Enabled = True
    End Sub

    Private Sub btnViewChart_Click(sender As Object, e As EventArgs) Handles btnViewChart.Click
        Dim format As String = "yyyy-MM-dd"
        date1 = dateAlarm1.Value.ToString(format)
        date2 = dateAlarm2.Value.ToString(format)
        Dim displayFormat As String = "MMMM dd, yyyy"

        If rdAllAlarm.Checked = True Then
            reportStatus = "all"
        ElseIf rdCustomAlarm.Checked = True Then
            reportStatus = "custom"
        End If

        'count number of record between selected dates
        viewData("SELECT COUNT(*) FROM stat WHERE alarm_timestamp BETWEEN '" & date1 & " 00:00:00' AND '" & date2 & " 23:59:59';")
        While dreader.Read
            overAllRec = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        'count number of record between selected dates for every table
        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 1' AND alarm_timestamp BETWEEN '" & date1 & " 00:00:00' AND '" & date2 & " 23:59:59';")
        While dreader.Read
            count1 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 2' AND alarm_timestamp BETWEEN '" & date1 & " 00:00:00' AND '" & date2 & " 23:59:59';")
        While dreader.Read
            count2 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 3' AND alarm_timestamp BETWEEN '" & date1 & " 00:00:00' AND '" & date2 & " 23:59:59';")
        While dreader.Read
            count3 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 4' AND alarm_timestamp BETWEEN '" & date1 & " 00:00:00' AND '" & date2 & " 23:59:59';")
        While dreader.Read
            count4 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 5' AND alarm_timestamp BETWEEN '" & date1 & " 00:00:00' AND '" & date2 & " 23:59:59';")
        While dreader.Read
            count5 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 6' AND alarm_timestamp BETWEEN '" & date1 & " 00:00:00' AND '" & date2 & " 23:59:59';")
        While dreader.Read
            count6 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 7' AND alarm_timestamp BETWEEN '" & date1 & " 00:00:00' AND '" & date2 & " 23:59:59';")
        While dreader.Read
            count7 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 8' AND alarm_timestamp BETWEEN '" & date1 & " 00:00:00' AND '" & date2 & " 23:59:59';")
        While dreader.Read
            count8 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 9' AND alarm_timestamp BETWEEN '" & date1 & " 00:00:00' AND '" & date2 & " 23:59:59';")
        While dreader.Read
            count9 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT COUNT(*) FROM stat WHERE locname = 'Table 10' AND alarm_timestamp BETWEEN '" & date1 & " 00:00:00' AND '" & date2 & " 23:59:59';")
        While dreader.Read
            count10 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()


        'Dim percentage As Integer

        'percentage = (100 / overAllRec) * count1
        'lblPer1.Text = percentage
        'lblPer1.RightToLeft = Windows.Forms.RightToLeft.Yes

        'percentage = (100 / overAllRec) * count2
        'lblPer2.Text = percentage
        'lblPer2.RightToLeft = Windows.Forms.RightToLeft.Yes

        'percentage = (100 / overAllRec) * count3
        'lblPer3.Text = percentage
        'lblPer3.RightToLeft = Windows.Forms.RightToLeft.Yes

        'display new values to the chart
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()
        Me.Chart1.Series("count").Points.Clear()

        If (count1 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name1, count1)
        End If
        If (count2 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name2, count2)
        End If
        If (count3 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name3, count3)
        End If
        If (count4 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name4, count4)
        End If
        If (count5 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name5, count5)
        End If
        If (count6 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name6, count6)
        End If
        If (count7 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name7, count7)
        End If
        If (count8 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name8, count8)
        End If
        If (count9 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name9, count9)
        End If
        If (count10 <> 0) Then
            Me.Chart1.Series("count").Points.AddXY(name10, count10)
        End If

        If date1 = date2 Then
            lblMessage.Text = "RECORDS FROM " & dateAlarm1.Value.ToString(displayFormat)
            reportParamDate = lblMessage.Text
        Else
            lblMessage.Text = "RECORDS FROM " & dateAlarm1.Value.ToString(displayFormat) & " TO " & dateAlarm2.Value.ToString(displayFormat)
            reportParamDate = lblMessage.Text
        End If

        for_insert_command("INSERT INTO activity_log VALUES (now(), 'Information','Generate chart from database','MySQL');", "activity_log")





        'chart 2!!!

        Chart2.ChartAreas(0).AxisX.Interval = 1
        mon = 0
        tues = 0
        wed = 0
        thurs = 0
        sat = 0
        Me.Chart2.Series("Day").Points.Clear()
        Me.Chart2.Series("Day").Points.Clear()
        Me.Chart2.Series("Day").Points.Clear()
        Me.Chart2.Series("Day").Points.Clear()
        Me.Chart2.Series("Day").Points.Clear()
        'Day number of record
        viewData("SELECT COUNT(*) FROM stat WHERE alarm_timestamp BETWEEN '" & date1 & " 00:00:00' AND '" & date2 & " 23:59:59';")
        While dreader.Read
            weeklyAllCount = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        Dim dates_date(weeklyAllCount) As Date
        Dim i = 0
        Dim format2 As String = "yyyy-MM-dd"
        'count number of record for first device
        viewData("SELECT alarm_timestamp FROM stat WHERE alarm_timestamp BETWEEN '" & date1 & " 00:00:00' AND '" & date2 & " 23:59:59';")
        While dreader.Read
            If i < weeklyAllCount Then
                dates_date(i) = dreader.GetValue(0)
                i = i + 1
            End If
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        Dim dates(weeklyAllCount) As String
        Dim y = 0

        While y < weeklyAllCount
            dates(y) = dates_date(y).ToString(format2)
            y = y + 1
        End While

        Dim x = 0

        While x < weeklyAllCount
            viewData("SELECT WEEKDAY('" & dates(x) & "');")
            While dreader.Read
                If dreader.GetValue(0) = 0 Then
                    mon = mon + 1
                ElseIf dreader.GetValue(0) = 1 Then
                    tues = tues + 1
                ElseIf dreader.GetValue(0) = 2 Then
                    wed = wed + 1
                ElseIf dreader.GetValue(0) = 3 Then
                    thurs = thurs + 1
                ElseIf dreader.GetValue(0) = 5 Then
                    sat = sat + 1
                End If
                x = x + 1
            End While
            dreader.Close()
            Con.Close()
            Con.Dispose()
        End While

        Me.Chart2.Series("Day").Points.AddXY(day1, mon)
        Me.Chart2.Series("Day").Points.AddXY(day2, tues)
        Me.Chart2.Series("Day").Points.AddXY(day3, wed)
        Me.Chart2.Series("Day").Points.AddXY(day4, thurs)
        Me.Chart2.Series("Day").Points.AddXY(day5, sat)

    End Sub

    Private Sub dateAlarm2_ValueChanged(sender As Object, e As EventArgs) Handles dateAlarm2.ValueChanged
        If dateAlarm2.Value < dateAlarm1.Value Then
            mbInvalidDate.ShowDialog()
            dateAlarm2.Value = Date.Now
        End If
    End Sub

    Private Sub pds_PrintPage(sender As Object, ev As PrintPageEventArgs)
        Dim logoPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName & "\images\cvsu_logo.png"
        'Set the top position as the default margin
        Dim ypos As Single = ev.MarginBounds.Top

        'Get the default left margin
        Dim leftMargin As Single = ev.MarginBounds.Left

        'Create a font
        Dim font As New Font("Times New Roman", 16)

        'Get the font's height
        Dim fontheight As Single = font.GetHeight(ev.Graphics)

        'Draw four strings
        ypos = ypos + fontheight
        ypos = ypos + fontheight
        ypos = ypos + fontheight
        ypos = ypos + fontheight

        Static fntHeadingFont As New Font("Times New Roman", 14, FontStyle.Bold)
        Static font1 As New Font("Bookman Old Style", 14, FontStyle.Bold)
        Static font2 As New Font("Century Gothic", 11, FontStyle.Bold)
        Static font3 As New Font("Century Gothic", 9, FontStyle.Bold)
        Static font4 As New Font("Century Gothic", 9)

        Dim i As Image = Image.FromFile(logoPath)

        ev.Graphics.DrawImage(i, ev.MarginBounds.X + 100, 100, 90, 80)

        Dim sngCenterPage As Single
        sngCenterPage = Convert.ToSingle(ev.PageBounds.Width / 2 - ev.Graphics.MeasureString("CAVITE STATE UNIVERSITY", font1).Width / 2)
        ev.Graphics.DrawString("CAVITE STATE UNIVERSITY", font1, Brushes.Black, sngCenterPage, 100)
        sngCenterPage = Convert.ToSingle(ev.PageBounds.Width / 2 - ev.Graphics.MeasureString("Imus, Campus", font2).Width / 2)
        ev.Graphics.DrawString("Imus, Campus", font2, Brushes.Black, sngCenterPage, 125)
        sngCenterPage = Convert.ToSingle(ev.PageBounds.Width / 2 - ev.Graphics.MeasureString("Cavite Civic Center Palico IV, Imus, Cavite", font3).Width / 2)
        ev.Graphics.DrawString("Cavite Civic Center Palico IV, Imus, Cavite", font3, Brushes.Black, sngCenterPage, 145)
        sngCenterPage = Convert.ToSingle(ev.PageBounds.Width / 2 - ev.Graphics.MeasureString("(046) 471-66-07 / (046) 471-67-70 / (046) 686-23-49", font4).Width / 2)
        ev.Graphics.DrawString("(046) 471-66-07 / (046) 471-67-70 / (046) 686-23-49", font4, Brushes.Black, sngCenterPage, 165)
        sngCenterPage = Convert.ToSingle(ev.PageBounds.Width / 2 - ev.Graphics.MeasureString("Library Noise Detector Graphical Report", fntHeadingFont).Width / 2)
        ev.Graphics.DrawString("Library Noise Detector Graphical Report", fntHeadingFont, Brushes.Black, sngCenterPage, 225)

        ' Create and initialize print font 
        Dim printFont As New System.Drawing.Font("Times New Roman", 10)
        ' Create Rectangle structure, used to set the position of the chart 
        Dim myRec As New System.Drawing.Rectangle(ev.MarginBounds.X, ev.MarginBounds.Y + 180, ev.MarginBounds.Width, ev.MarginBounds.Height - 220)
        sngCenterPage = Convert.ToSingle(ev.PageBounds.Width / 2 - ev.Graphics.MeasureString(lblMessage.Text, printFont).Width / 2)
        ' Draw a line of text, followed by the chart
        ev.Graphics.DrawString(lblMessage.Text, printFont, Brushes.Black, sngCenterPage, 250)
        Chart2.Printing.PrintPaint(ev.Graphics, myRec)
        'Draw a rectangle with default margins
        'ev.Graphics.DrawRectangle(New Pen(Color.Black), ev.MarginBounds.X, ev.MarginBounds.Y, ev.MarginBounds.Width, ev.MarginBounds.Height)
        ev.Graphics.DrawString("Total Count: " & overAllRec, font4, Brushes.Black, ev.MarginBounds.X, (ev.MarginBounds.Y + ev.MarginBounds.Height) - ev.Graphics.MeasureString("Total Count: " & overAllRec, font4).Height)
        ev.Graphics.DrawString("Report Timestamp: " & Now(), font4, Brushes.Black, (ev.MarginBounds.X + ev.MarginBounds.Width) - ev.Graphics.MeasureString("Report Timestamp: " & Now(), font4).Width, (ev.MarginBounds.Y + ev.MarginBounds.Height) - ev.Graphics.MeasureString("Report Timestamp: " & Now(), font4).Height)
    End Sub

    Private Sub cbReport_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbReport.SelectedValueChanged
        If cbReport.Text = "Print This Chart" Then
            'Chart1.Printing.Print(True)
            Dim pdS As New PrintDocument()

            AddHandler pdS.PrintPage, AddressOf pds_PrintPage
            pdS.DefaultPageSettings.Landscape = True

            Dim PrintDialog1 As New PrintPreviewDialog
            PrintDialog1.Document = pdS
            PrintDialog1.WindowState = FormWindowState.Maximized

            If (PrintDialog1.ShowDialog = DialogResult.OK) Then
                Chart2.Printing.PrintDocument.DefaultPageSettings.Landscape = True
                pdS.Print()
                for_insert_command("INSERT INTO activity_log VALUES (now(), 'Information','Print Chart','Administrator');", "activity_log")
            End If

        ElseIf cbReport.Text = "Generate Tabular Report" Then
            for_insert_command("INSERT INTO activity_log VALUES (now(), 'Information','Generate Tabular Report','Administrator');", "activity_log")
            Report.Show()
        End If
    End Sub

    Private Sub btnExportLog_Click(sender As Object, e As EventArgs) Handles btnExportLog.Click
        ReportLOG.Show()
    End Sub

    Private Sub menuSettings_Click(sender As Object, e As EventArgs) Handles menuSettings.Click
        Me.Hide()
        settings.Show()
    End Sub

    Private Sub menuExit_Click(sender As Object, e As EventArgs) Handles menuExit.Click
        mbExit.ShowDialog()
    End Sub

    Private Sub menuMonitor_Click(sender As Object, e As EventArgs) Handles menuMonitor.Click
        Me.Hide()
        NoiseDetector.Show()
    End Sub
End Class