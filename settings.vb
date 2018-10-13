Imports System.IO
Imports System.Text

Public Class settings
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayAvailableAlarms()
        viewThreshold()
    End Sub

    Private Sub menuMonitor_Click(sender As Object, e As EventArgs) Handles menuMonitor.Click
        Me.Hide()
        NoiseDetector.Show()
    End Sub

    Private Sub menuDashboard_Click(sender As Object, e As EventArgs) Handles menuDashboard.Click
        Me.Hide()
        Stat.refreshForm()
        Stat.Show()
    End Sub

    Private Sub menuExit_Click(sender As Object, e As EventArgs) Handles menuExit.Click
        mbExit.ShowDialog()
    End Sub

    'DISPLAY ALARMS STORED IN THE ALARM FOLDER
    Public Sub displayAvailableAlarms()
        cb1.Items.Clear()
        cb2.Items.Clear()
        cb3.Items.Clear()
        cb1.ResetText()
        cb2.ResetText()
        cb3.ResetText()

        Dim filenames = From fullFilename In Directory.EnumerateFiles(pathAlarmFolder) Select Path.GetFileName(fullFilename)

        For Each filename As String In filenames
            cb1.Items.Add(filename)
            cb2.Items.Add(filename)
            cb3.Items.Add(filename)
        Next

        viewData("SELECT alarm FROM noise WHERE level = 'low';")
        While dreader.Read
            cb1.SelectedText = dreader.GetValue(0).ToString
            alarm1 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT alarm FROM noise WHERE level = 'medium';")
        While dreader.Read
            cb2.SelectedText = dreader.GetValue(0).ToString
            alarm2 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT alarm FROM noise WHERE level = 'high';")
        While dreader.Read
            cb3.SelectedText = dreader.GetValue(0).ToString
            alarm3 = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()
    End Sub

    'GET THRESHOLD SETTING FOR EACH LEVEL IN THE DATABASE
    Public Sub viewThreshold()
        txt1.Clear()
        txt2.Clear()
        txt3.Clear()

        viewData("SELECT threshold FROM noise WHERE level = 'low';")
        While dreader.Read
            txt1.Text = dreader.GetValue(0).ToString
            low = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT threshold FROM noise WHERE level = 'medium';")
        While dreader.Read
            txt2.Text = dreader.GetValue(0).ToString
            medium = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        viewData("SELECT threshold FROM noise WHERE level = 'high';")
        While dreader.Read
            txt3.Text = dreader.GetValue(0).ToString
            high = dreader.GetValue(0)
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()
    End Sub

    'GET THE ASSIGNED LOCATION FOR EACH DEVICE IN THE DATABASE
    Public Sub getDeviceLocation()
        Dim i(3) As String
        Dim index As Integer = 0

        viewData("SELECT * FROM devices;")
        While dreader.Read
            i(index) = dreader.GetValue(1)
            index = index + 1
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        deviceLoc1 = i(0)
        deviceLoc2 = i(1)
        deviceLoc3 = i(2)
    End Sub

    'GET ALL TABLE NUMBERS STORED IN THE DATABASE
    Public Sub viewAllLibraryLocation()
        cbloc1.Items.Clear()
        cbloc2.Items.Clear()
        cbloc3.Items.Clear()
        cbloc1.ResetText()
        cbloc2.ResetText()
        cbloc3.ResetText()

        viewData("SELECT * FROM location;")
        While dreader.Read
            cbloc1.Items.Add(dreader.GetValue(0))
            cbloc2.Items.Add(dreader.GetValue(0))
            cbloc3.Items.Add(dreader.GetValue(0))
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        'GET AND DISPLAY LOCATION OF DEVICE 1
        viewData("SELECT * FROM devices WHERE ID = 1;")
        While dreader.Read
            cbloc1.SelectedText = dreader.GetValue(1).ToString
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        'GET AND DISPLAY LOCATION OF DEVICE 2
        viewData("SELECT * FROM devices WHERE ID = 2;")
        While dreader.Read
            cbloc2.SelectedText = dreader.GetValue(1).ToString
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()

        'GET AND DISPLAY LOCATION OF DEVICE 3
        viewData("SELECT * FROM devices WHERE ID = 3;")
        While dreader.Read
            cbloc3.SelectedText = dreader.GetValue(1).ToString
        End While
        dreader.Close()
        Con.Close()
        Con.Dispose()
    End Sub

    Public Sub viewAudioList()
        listAudio.Items.Clear()
        Dim filenames = From fullFilename In Directory.EnumerateFiles(pathAlarmFolder) Select Path.GetFileName(fullFilename)

        For Each filename As String In filenames
            listAudio.Items.Add(filename)
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            RunQuery("UPDATE noise SET threshold = '" & txt1.Text & "', alarm = '" & cb1.Text & "' WHERE level = 'low';")
            RunQuery("UPDATE noise SET threshold = '" & txt2.Text & "', alarm = '" & cb2.Text & "' WHERE level = 'medium';")
            RunQuery("UPDATE noise SET threshold = '" & txt3.Text & "', alarm = '" & cb3.Text & "' WHERE level = 'high';")

            If natflag = 0 Then
                mbSaveChanges.ShowDialog()
                displayAvailableAlarms()
                viewThreshold()
                for_insert_command("INSERT INTO activity_log VALUES (now(), 'Information','Changing of alarm and threshold settings','Administrator');", "activity_log")
            Else
                mbErrorNotif.ShowDialog()
                natflag = 0
            End If
        Catch ex As Exception
            mbErrorNotif.ShowDialog()
        End Try
    End Sub
    'DISPLAY INFORMATION PAGE ABOUT DECIBELS
    Private Sub pbInfo_Click(sender As Object, e As EventArgs) Handles pbInfo.Click
        InformationAboutDecibels.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer
        sum = Integer.Parse(txt1.Text) + 1
        If sum > 130 Then
            mbMaximumThreshold.ShowDialog()
        Else
            txt1.Text = sum
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim difference As Integer
        difference = Integer.Parse(txt1.Text) - 1
        If difference < 30 Then
            mbMinimumThreshold.ShowDialog()
        Else
            txt1.Text = difference
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sum As Integer
        sum = Integer.Parse(txt2.Text) + 1
        If sum > 130 Then
            mbMaximumThreshold.ShowDialog()
        Else
            txt2.Text = sum
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim difference As Integer
        difference = Integer.Parse(txt2.Text) - 1
        If difference < 30 Then
            mbMinimumThreshold.ShowDialog()
        Else
            txt2.Text = difference
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim sum As Integer
        sum = Integer.Parse(txt3.Text) + 1
        If sum > 130 Then
            mbMaximumThreshold.ShowDialog()
        Else
            txt3.Text = sum
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim difference As Integer
        difference = Integer.Parse(txt3.Text) - 1
        If difference < 30 Then
            mbMinimumThreshold.ShowDialog()
        Else
            txt3.Text = difference
        End If
    End Sub

    Private Sub txt1_LostFocus(sender As Object, e As EventArgs) Handles txt1.LostFocus
        Try
            Dim temp As Integer = Integer.Parse(txt1.Text)
            If temp < 30 Then
                mbMinimumThreshold.ShowDialog()
                txt1.Clear()
            End If
        Catch ex As Exception
            txt1.Clear()
        End Try
    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged
        Dim allowed As String = ("0123456789")
        For Each c As Char In txt1.Text
            If allowed.Contains(c) = False Then
                mbOnlyNumbers.ShowDialog()
                txt1.Clear()
            Else
                Try
                    If txt1.Text <> "" Then
                        Dim temp As Integer = Integer.Parse(txt1.Text)

                        If temp > 130 Then
                            mbMaximumThreshold.ShowDialog()
                            txt1.Clear()
                        End If
                    End If
                Catch ex As Exception
                    txt1.Clear()
                End Try
            End If
        Next

    End Sub

    Private Sub txt2_LostFocus(sender As Object, e As EventArgs) Handles txt2.LostFocus
        Try
            Dim temp As Integer = Integer.Parse(txt2.Text)
            If temp < 30 Then
                mbMinimumThreshold.ShowDialog()
                txt2.Clear()
            End If
        Catch ex As Exception
            txt2.Clear()
        End Try
    End Sub

    Private Sub txt2_TextChanged(sender As Object, e As EventArgs) Handles txt2.TextChanged
        Dim allowed As String = ("0123456789")
        For Each c As Char In txt2.Text
            If allowed.Contains(c) = False Then
                mbOnlyNumbers.ShowDialog()
                txt2.Clear()
            Else
                Try
                    If txt2.Text <> "" Then
                        Dim temp As Integer = Integer.Parse(txt2.Text)

                        If temp > 130 Then
                            mbMaximumThreshold.ShowDialog()
                            txt2.Clear()
                        End If
                    End If
                Catch ex As Exception
                    txt2.Clear()
                End Try
            End If
        Next
    End Sub

    Private Sub txt3_LostFocus(sender As Object, e As EventArgs) Handles txt3.LostFocus
        Try
            Dim temp As Integer = Integer.Parse(txt3.Text)
            If temp < 30 Then
                mbMinimumThreshold.ShowDialog()
                txt3.Clear()
            End If
        Catch ex As Exception
            txt3.Clear()
        End Try
    End Sub

    Private Sub txt3_TextChanged(sender As Object, e As EventArgs) Handles txt3.TextChanged
        Dim allowed As String = ("0123456789")
        For Each c As Char In txt3.Text
            If allowed.Contains(c) = False Then
                mbOnlyNumbers.ShowDialog()
                txt3.Clear()
            Else
                Try
                    If txt3.Text <> "" Then
                        Dim temp As Integer = Integer.Parse(txt3.Text)

                        If temp > 130 Then
                            mbMaximumThreshold.ShowDialog()
                            txt3.Clear()
                        End If
                    End If
                Catch ex As Exception
                    txt3.Clear()
                End Try
            End If
        Next
    End Sub

    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click

        btnRecord.Enabled = False
        btnPlay.Enabled = False
        btnStop.Enabled = True

        mciSendString("open new Type waveaudio Alias hrsSound", "", 9, 9)

        mciSendString("record hrsSound", "", 9, 9)

        Label4.Text = "Recording..."

        Label4.Visible = True

    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click

        btnRecord.Enabled = True

        btnStop.Enabled = False

        btnPlay.Enabled = True

        mciSendString("save hrsSound d:\temporary.mp3", "", 9, 9)

        mciSendString("close hrsSound", "", 0, 0)

        mbListenToRecord.ShowDialog()

        Label4.Text = "Stopped..."

        Label4.Visible = False

    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Try
            Label4.Text = "Playing..."

            Label4.Visible = True

            My.Computer.Audio.Play("d:\temporary.mp3", AudioPlayMode.Background)

            mbWouldYouUpload.ShowDialog()

        Catch ex As Exception
            mbRecordSomething.ShowDialog()
        End Try
        
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Try
            Dim dialog As OpenFileDialog = New OpenFileDialog()
            dialog.Filter = "Music files | *.mp3"
            dialog.Multiselect = False

            If dialog.ShowDialog() = DialogResult.OK Then
                Dim path As String = dialog.FileName

                Using reader As StreamReader = New StreamReader(New FileStream(path, FileMode.Open), New UTF8Encoding())
                    System.IO.File.Copy(path, pathAlarmFolder & dialog.SafeFileName)
                End Using

                mbNewAlarmAdded.ShowDialog()
                displayAvailableAlarms()
                viewAudioList()
                for_insert_command("INSERT INTO activity_log VALUES (now(), 'Information','Upload New Alarm','Visual Studio');", "activity_log")
            End If
        Catch ex As Exception
            mbErrorNotif.ShowDialog()
        End Try

    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If listAudio.CheckedItems.Count = 0 Then
            mbNoneSelected.ShowDialog()
        Else
            mbDeleteAudio.ShowDialog()
        End If
    End Sub

    Private Sub btnSaveName_Click(sender As Object, e As EventArgs) Handles btnSaveName.Click
        Try
            RunQuery("UPDATE devices SET locname = '" & cbloc1.Text & "' WHERE ID = 1;")
            RunQuery("UPDATE devices SET locname = '" & cbloc2.Text & "' WHERE ID = 2;")
            RunQuery("UPDATE devices SET locname = '" & cbloc3.Text & "' WHERE ID = 3;")
            If natflag = 0 Then
                mbSaveChanges.ShowDialog()
                getDeviceLocation()
                for_insert_command("INSERT INTO activity_log VALUES (now(), 'Information','Changing of device location','Visual Studio');", "activity_log")
            Else
                mbDeviceLocation.ShowDialog()
                natflag = 0
            End If
        Catch ex As Exception
            mbErrorNotif.ShowDialog()
        End Try
    End Sub

    Private Sub pbNoiseLevel_Click(sender As Object, e As EventArgs) Handles pbNoiseLevel.Click
        gbNoiseLevel.Enabled = True
        gbNoiseLevel.Visible = True
        gbDevices.Enabled = False
        gbDevices.Visible = False
        gbNewAlarm.Enabled = False
        gbNewAlarm.Visible = False
        gbDelete.Enabled = False
        gbDelete.Visible = False
        lblNoiseLevel.Visible = True
        lblDevices.Visible = False
        lblNewAlarm.Visible = False
        lblAudioFiles.Visible = False
    End Sub

    Private Sub pbDevices_Click(sender As Object, e As EventArgs) Handles pbDevices.Click
        gbNoiseLevel.Enabled = False
        gbNoiseLevel.Visible = False
        gbDevices.Enabled = True
        gbDevices.Visible = True
        gbNewAlarm.Enabled = False
        gbNewAlarm.Visible = False
        gbDelete.Enabled = False
        gbDelete.Visible = False
        lblNoiseLevel.Visible = False
        lblDevices.Visible = True
        lblNewAlarm.Visible = False
        lblAudioFiles.Visible = False
        getDeviceLocation()
        viewAllLibraryLocation()
    End Sub

    Private Sub pbNewAlarm_Click(sender As Object, e As EventArgs) Handles pbNewAlarm.Click
        gbNoiseLevel.Enabled = False
        gbNoiseLevel.Visible = False
        gbDevices.Enabled = False
        gbDevices.Visible = False
        gbNewAlarm.Enabled = True
        gbNewAlarm.Visible = True
        gbDelete.Enabled = False
        gbDelete.Visible = False
        lblNoiseLevel.Visible = False
        lblDevices.Visible = False
        lblNewAlarm.Visible = True
        lblAudioFiles.Visible = False
    End Sub

    Private Sub pbAudioFiles_Click(sender As Object, e As EventArgs) Handles pbAudioFiles.Click
        gbNoiseLevel.Enabled = False
        gbNoiseLevel.Visible = False
        gbDevices.Enabled = False
        gbDevices.Visible = False
        gbNewAlarm.Enabled = False
        gbNewAlarm.Visible = False
        gbDelete.Enabled = True
        gbDelete.Visible = True
        lblNoiseLevel.Visible = False
        lblDevices.Visible = False
        lblNewAlarm.Visible = False
        lblAudioFiles.Visible = True
        viewAudioList()
    End Sub
End Class