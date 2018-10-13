Imports System.IO
Imports System.Text
Imports System.IO.Ports

Public Class NoiseDetector
    Public status As String = "OFF"

    Private Sub NoiseDetector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewSavedUI()
        'My.Settings.Reset()
        for_insert_command("INSERT INTO activity_log VALUES (now(), 'Security','Successful Login','Visual Studio');", "activity_log")
        'disableAll()

        Dim myPort As Array 'Array to hold the COM detected

        myPort = IO.Ports.SerialPort.GetPortNames() 'Get the portnames for the IO.Ports.SerialPort 

        'Loading COM into combobox
        For Each port In myPort
            cbPort.Items.Add(port)
        Next

        getDeviceLocation()

    End Sub

    '==================================================================================================================
    'SET PROPERTIES OF EACH OBJECT BASED ON SAVED SETTINGS

    Public Sub viewSavedUI()
        table1.Location = My.Settings.table1_loc
        table1.Size = My.Settings.table1_size

        table2.Location = My.Settings.table2_loc
        table2.Size = My.Settings.table2_size

        table3.Location = My.Settings.table3_loc
        table3.Size = My.Settings.table3_size

        table4.Location = My.Settings.table4_loc
        table4.Size = My.Settings.table4_size

        table5.Location = My.Settings.table5_loc
        table5.Size = My.Settings.table5_size

        table6.Location = My.Settings.table6_loc
        table6.Size = My.Settings.table6_size

        table7.Location = My.Settings.table7_loc
        table7.Size = My.Settings.table7_size

        table8.Location = My.Settings.table8_loc
        table8.Size = My.Settings.table8_size

        table9.Location = My.Settings.table9_loc
        table9.Size = My.Settings.table9_size

        table10.Location = My.Settings.table10_loc
        table10.Size = My.Settings.table10_size

        door.Location = My.Settings.door_loc
        door.Size = My.Settings.door_size

        logtable.Location = My.Settings.logtable_loc
        logtable.Size = My.Settings.logtable_size

        baggagecounter.Location = My.Settings.counter_loc
        baggagecounter.Size = My.Settings.counter_size

        librarian1.Location = My.Settings.librarian1_loc
        librarian1.Size = My.Settings.librarian1_size

        librarian2.Location = My.Settings.librarian2_loc
        librarian2.Size = My.Settings.librarian2_size

        librarian3.Location = My.Settings.librarian3_loc
        librarian3.Size = My.Settings.librarian3_size

        bookshelf1.Location = My.Settings.bookshelf1_loc
        bookshelf1.Size = My.Settings.bookshelf1_size

        bookshelf2.Location = My.Settings.bookshelf2_loc
        bookshelf2.Size = My.Settings.bookshelf2_size

        opac.Location = My.Settings.opac_loc
        opac.Size = My.Settings.opac_size

        pcsection.Location = My.Settings.pcsection_loc
        pcsection.Size = My.Settings.pcsection_size

        thesaurus.Location = My.Settings.thesaurus_loc
        thesaurus.Size = My.Settings.thesaurus_size

        bookssection1.Location = My.Settings.bookssection1_loc
        bookssection1.Size = My.Settings.bookssection1_size

        bookssection2.Location = My.Settings.bookssection2_loc
        bookssection2.Size = My.Settings.bookssection2_size

        divider.Location = My.Settings.divider_loc
        divider.Size = My.Settings.divider_size
    End Sub

    '==================================================================================================================
    'SAVE CHANGES MADE BY THE USER DURING RUN TIME - PROJECT > PROPERTIES > SETTINGS

    Public Sub saveChangesToUI()
        My.Settings.table1_loc = table1.Location
        My.Settings.table1_size = table1.Size

        My.Settings.table2_loc = table2.Location
        My.Settings.table2_size = table2.Size

        My.Settings.table3_loc = table3.Location
        My.Settings.table3_size = table3.Size

        My.Settings.table4_loc = table4.Location
        My.Settings.table4_size = table4.Size

        My.Settings.table5_loc = table5.Location
        My.Settings.table5_size = table5.Size

        My.Settings.table6_loc = table6.Location
        My.Settings.table6_size = table6.Size

        My.Settings.table7_loc = table7.Location
        My.Settings.table7_size = table7.Size

        My.Settings.table8_loc = table8.Location
        My.Settings.table8_size = table8.Size

        My.Settings.table9_loc = table9.Location
        My.Settings.table9_size = table9.Size

        My.Settings.table10_loc = table10.Location
        My.Settings.table10_size = table10.Size

        My.Settings.door_loc = door.Location
        My.Settings.door_size = door.Size

        My.Settings.logtable_loc = logtable.Location
        My.Settings.logtable_size = logtable.Size

        My.Settings.counter_loc = baggagecounter.Location
        My.Settings.counter_size = baggagecounter.Size

        My.Settings.librarian1_loc = librarian1.Location
        My.Settings.librarian1_size = librarian1.Size

        My.Settings.librarian2_loc = librarian2.Location
        My.Settings.librarian2_size = librarian2.Size

        My.Settings.librarian3_loc = librarian3.Location
        My.Settings.librarian3_size = librarian3.Size

        My.Settings.bookshelf1_loc = bookshelf1.Location
        My.Settings.bookshelf1_size = bookshelf1.Size

        My.Settings.bookshelf2_loc = bookshelf2.Location
        My.Settings.bookshelf2_size = bookshelf2.Size

        My.Settings.opac_loc = opac.Location
        My.Settings.opac_size = opac.Size

        My.Settings.pcsection_loc = pcsection.Location
        My.Settings.pcsection_size = pcsection.Size

        My.Settings.thesaurus_loc = thesaurus.Location
        My.Settings.thesaurus_size = thesaurus.Size

        My.Settings.bookssection1_loc = bookssection1.Location
        My.Settings.bookssection1_size = bookssection1.Size

        My.Settings.bookssection2_loc = bookssection2.Location
        My.Settings.bookssection2_size = bookssection2.Size

        My.Settings.divider_loc = divider.Location
        My.Settings.divider_size = divider.Size

        My.Settings.Save()
    End Sub

    ''DISABLE SETTINGS WHEN APPLICATION IS NOT CONNECTED TO RECEIVER/DEVICE
    'Public Sub disableAll()
    '    GroupBox1.Enabled = False
    '    GroupBox3.Enabled = False
    'End Sub

    ''ENABLE SETTINGS WHEN CONNECTION IS CONFIRMED
    'Public Sub enableAll()
    '    GroupBox1.Enabled = True
    '    GroupBox3.Enabled = True
    'End Sub

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

    Private Sub SerialPort1_DataReceived(sender As Object, e As Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        'get data from receiver
        'close the port temporarily
        'get first character from string to determine which device sent the data
        'remove first two characters to get the decibel detected by the device
        'determine the level of noise
        'show red border in the location where the device that sent the data is placed
        'announce the location where noise is produced before playing the alarm for the noise level detected
        '3-second delay to prevent the alarm from triggering the device
        'hide red border
        'open the port to resume receiving data
        If status = "ON" Then
            Try
                Dim dataFromArduino As String
                'get data from arduino/receiver
                dataFromArduino = SerialPort1.ReadLine

                Dim deviceNum As Char
                'get first character from string: format - devicenumber_decibels
                deviceNum = dataFromArduino.Chars(0)

                Dim dB As Integer
                'remove first two characters from the string received from arduino
                'example: 1_55; remove '1_' to extract the decibels then convert to int
                Int64.TryParse(dataFromArduino.Remove(0, 2), dB)

                'variable to hold the name of location where the device is triggered
                Dim locationNaIilaw As String = ""

                'there's a previous query where the location of each device is identified and stored in different variables
                If deviceNum = "1" Then
                    'location of device 1
                    locationNaIilaw = deviceLoc1
                ElseIf deviceNum = "2" Then
                    'location of device 2
                    locationNaIilaw = deviceLoc2
                ElseIf deviceNum = "3" Then
                    'location of device 3
                    locationNaIilaw = deviceLoc3
                End If

                Try
                    'identify the level of the noise detected
                    'low, medium and high are variable which hold the threshold for each noise level recorded in the database
                    If dB >= low And dB < medium Then
                        'close port temporarily to stop receiving data
                        SerialPort1.Close()
                        'call
                        'show where the noise came from
                        showLocation(locationNaIilaw)
                        'get alarm for specific noise level
                        Player.URL = pathAlarmFolder & alarm1
                        Player.controls.play()
                        'insert new record to the database
                        for_insert_command("INSERT INTO stat VALUES ('" & locationNaIilaw & "','" & dB & "','LOW', now(), DAYNAME(CURDATE()), WEEKDAY(CURDATE()));", "stat")
                        '3-second delay to prevent the alarm from triggering itself
                        Threading.Thread.Sleep(3000)
                        'call
                        backToNormal(locationNaIilaw)
                        'open the port to resume receiving data
                        SerialPort1.Open()
                    ElseIf dB >= medium And dB < high Then
                        'close port temporarily to stop receiving data
                        SerialPort1.Close()
                        'call
                        'show where the noise came from
                        showLocation(locationNaIilaw)
                        'get alarm for specific noise level
                        Player.URL = pathAlarmFolder & alarm2
                        Player.controls.play()
                        'insert new record to the database
                        for_insert_command("INSERT INTO stat VALUES ('" & locationNaIilaw & "','" & dB & "','MEDIUM', now());", "stat")
                        '3-second delay to prevent the alarm from triggering itself
                        Threading.Thread.Sleep(3000)
                        'call
                        backToNormal(locationNaIilaw)
                        'open the port to resume receiving data
                        SerialPort1.Open()
                    ElseIf dB >= high Then
                        'Close port to stop receiving data
                        SerialPort1.Close()
                        'call
                        'show where the noise came from
                        showLocation(locationNaIilaw)
                        'get alarm for specific noise level
                        Player.URL = pathAlarmFolder & alarm3
                        Player.controls.play()
                        'insert new record to the database
                        for_insert_command("INSERT INTO stat VALUES ('" & locationNaIilaw & "','" & dB & "','HIGH', now());", "stat")
                        '3-second delay to prevent the alarm from triggering itself
                        Threading.Thread.Sleep(3000)
                        'call
                        backToNormal(locationNaIilaw)
                        'open the port to resume receiving data
                        SerialPort1.Open()
                    End If
                Catch ex As Exception
                    mbErrorNotif.ShowDialog()
                End Try
            Catch ex As Exception
                SerialPort1.Close()
                SerialPort1.Dispose()
            End Try
        End If
    End Sub
    '=============================================================================================================
    'CODE FOR SHOWING THE LOCATION WHERE THE DEVICE IS TRIGGERED

    Public Sub showLocation(locationNaIilaw As String)
        'create object for text to speech feature
        Dim SAPI As Object
        SAPI = CreateObject("SAPI.spvoice")

        'show red border to indicate which table produced noise
        'use invoke to prevent threading issues
        'text to speech - mention table number
        If locationNaIilaw = "Table 1" Then
            table1.Invoke(Sub()
                              table1.BackColor = Color.Red
                          End Sub)
            SAPI.speak("Table One")
        ElseIf locationNaIilaw = "Table 2" Then
            table2.Invoke(Sub()
                              table2.BackColor = Color.Red
                          End Sub)
            SAPI.speak("Table Two")
        ElseIf locationNaIilaw = "Table 3" Then
            table3.Invoke(Sub()
                              table3.BackColor = Color.Red
                          End Sub)
            SAPI.speak("Table Three")
        ElseIf locationNaIilaw = "Table 4" Then
            table4.Invoke(Sub()
                              table4.BackColor = Color.Red
                          End Sub)
            SAPI.speak("Table Four")
        ElseIf locationNaIilaw = "Table 5" Then
            table5.Invoke(Sub()
                              table5.BackColor = Color.Red
                          End Sub)
            SAPI.speak("Table Five")
        ElseIf locationNaIilaw = "Table 6" Then
            table6.Invoke(Sub()
                              table6.BackColor = Color.Red
                          End Sub)
            SAPI.speak("Table Six")
        ElseIf locationNaIilaw = "Table 7" Then
            table7.Invoke(Sub()
                              table7.BackColor = Color.Red
                          End Sub)
            SAPI.speak("Table Seven")
        ElseIf locationNaIilaw = "Table 8" Then
            table8.Invoke(Sub()
                              table8.BackColor = Color.Red
                          End Sub)
            SAPI.speak("Table Eight")
        ElseIf locationNaIilaw = "Table 9" Then
            table9.Invoke(Sub()
                              table9.BackColor = Color.Red
                          End Sub)
            SAPI.speak("Table Nine")
        ElseIf locationNaIilaw = "Table 10" Then
            table10.Invoke(Sub()
                               table10.BackColor = Color.Red
                           End Sub)
            SAPI.speak("Table 10")
        End If

    End Sub

    Public Sub backToNormal(locationNaIilaw As String)
        'hide red border after 3 seconds
        'use invoke to prevent threading issues
        If locationNaIilaw = "Table 1" Then
            table1.Invoke(Sub()
                              table1.BackColor = Color.Honeydew
                          End Sub)
        ElseIf locationNaIilaw = "Table 2" Then
            table2.Invoke(Sub()
                              table2.BackColor = Color.Honeydew
                          End Sub)
        ElseIf locationNaIilaw = "Table 3" Then
            table3.Invoke(Sub()
                              table3.BackColor = Color.Honeydew
                          End Sub)
        ElseIf locationNaIilaw = "Table 4" Then
            table4.Invoke(Sub()
                              table4.BackColor = Color.Honeydew
                          End Sub)
        ElseIf locationNaIilaw = "Table 5" Then
            table5.Invoke(Sub()
                              table5.BackColor = Color.Honeydew
                          End Sub)
        ElseIf locationNaIilaw = "Table 6" Then
            table6.Invoke(Sub()
                              table6.BackColor = Color.Honeydew
                          End Sub)
        ElseIf locationNaIilaw = "Table 7" Then
            table7.Invoke(Sub()
                              table7.BackColor = Color.Honeydew
                          End Sub)
        ElseIf locationNaIilaw = "Table 8" Then
            table8.Invoke(Sub()
                              table8.BackColor = Color.Honeydew
                          End Sub)
        ElseIf locationNaIilaw = "Table 9" Then
            table9.Invoke(Sub()
                              table9.BackColor = Color.Honeydew
                          End Sub)
        ElseIf locationNaIilaw = "Table 10" Then
            table10.Invoke(Sub()
                               table10.BackColor = Color.Honeydew
                           End Sub)
        End If
    End Sub

    Private Sub linkGraph_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        SerialPort1.Close()
    End Sub

    'DISPLAY ALL AVAILABLE PORTS IN THE COMBOBOX
    Private Sub cbPort_Click(sender As Object, e As EventArgs) Handles cbPort.Click
        cbPort.Items.Clear()
        Dim myPort As Array 'Array to hold the COM detected

        myPort = IO.Ports.SerialPort.GetPortNames() 'Get the portnames for the IO.Ports.SerialPort 

        'Loading COM into combobox
        For Each port In myPort
            cbPort.Items.Add(port)
        Next

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Stat.refreshForm()
        Stat.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Stat.refreshForm()
        Stat.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Stat.refreshForm()
        Stat.Show()
    End Sub

    'DISPLAY INFORMATION PAGE ABOUT DECIBELS
    Private Sub pbInfo_Click(sender As Object, e As EventArgs)
        InformationAboutDecibels.Show()
    End Sub

    '==================================================================================================================
    'WHEN THE USER WANTS TO CHANGE THE STRUCTURE OF THE LIBRARY
    Private Sub checkMoveObjects_CheckedChanged(sender As Object, e As EventArgs) Handles checkMoveObjects.CheckedChanged
        If checkMoveObjects.CheckState = CheckState.Checked Then
            btnSaveUI.Visible = True
            btnCancelUI.Visible = True
            groupLibStructure.Enabled = True
        Else
            btnSaveUI.Visible = False
            btnCancelUI.Visible = False
            groupLibStructure.Enabled = False
        End If
    End Sub

    Private Sub btnSaveUI_Click(sender As Object, e As EventArgs) Handles btnSaveUI.Click
        Me.Enabled = False
        mbSaveChangesUI.ShowDialog()
    End Sub

    Private Sub btnCancelUI_Click(sender As Object, e As EventArgs) Handles btnCancelUI.Click
        Me.Enabled = False
        mbCancelEdit.ShowDialog()
    End Sub

    '=================================================================================================================
    'CODE FOR RESIZING EACH OBJECT

    Private Sub table1_MouseMove(sender As Object, e As MouseEventArgs) Handles table1.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub table2_MouseMove(sender As Object, e As MouseEventArgs) Handles table2.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub table3_MouseMove(sender As Object, e As MouseEventArgs) Handles table3.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub table4_MouseMove(sender As Object, e As MouseEventArgs) Handles table4.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub table5_MouseMove(sender As Object, e As MouseEventArgs) Handles table5.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub table6_MouseMove(sender As Object, e As MouseEventArgs) Handles table6.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub table7_MouseMove(sender As Object, e As MouseEventArgs) Handles table8.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub table8_MouseMove(sender As Object, e As MouseEventArgs) Handles table7.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub table9_MouseMove(sender As Object, e As MouseEventArgs) Handles table9.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub table10_MouseMove(sender As Object, e As MouseEventArgs) Handles table10.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub door_MouseMove(sender As Object, e As MouseEventArgs) Handles door.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub logtable_MouseMove(sender As Object, e As MouseEventArgs) Handles logtable.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub baggagecounter_MouseMove(sender As Object, e As MouseEventArgs) Handles baggagecounter.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub librarian2_MouseMove(sender As Object, e As MouseEventArgs) Handles librarian2.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub librarian1_MouseMove(sender As Object, e As MouseEventArgs) Handles librarian1.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub bookshelf2_MouseMove(sender As Object, e As MouseEventArgs) Handles bookshelf2.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub bookshelf1_MouseMove(sender As Object, e As MouseEventArgs) Handles bookshelf1.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub opac_MouseMove(sender As Object, e As MouseEventArgs) Handles opac.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub pcsection_MouseMove(sender As Object, e As MouseEventArgs) Handles pcsection.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub librarian3_MouseMove(sender As Object, e As MouseEventArgs) Handles librarian3.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub thesaurus_MouseMove(sender As Object, e As MouseEventArgs) Handles thesaurus.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub bookssection1_MouseMove(sender As Object, e As MouseEventArgs) Handles bookssection1.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub bookssection2_MouseMove(sender As Object, e As MouseEventArgs) Handles bookssection2.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    '=================================================================================================================
    'CODE FOR CHANGING COLORS WHEN THE OBJECT IS CLICKED AND DRAGGED

    Private Sub table1_MouseDown(sender As Object, e As MouseEventArgs) Handles table1.MouseDown
        table1.BackColor = Color.SeaGreen
    End Sub

    Private Sub table2_MouseDown(sender As Object, e As MouseEventArgs) Handles table2.MouseDown
        table2.BackColor = Color.SeaGreen
    End Sub

    Private Sub table3_MouseDown(sender As Object, e As MouseEventArgs) Handles table3.MouseDown
        table3.BackColor = Color.SeaGreen
    End Sub

    Private Sub table4_MouseDown(sender As Object, e As MouseEventArgs) Handles table4.MouseDown
        table4.BackColor = Color.SeaGreen
    End Sub

    Private Sub table5_MouseDown(sender As Object, e As MouseEventArgs) Handles table5.MouseDown
        table5.BackColor = Color.SeaGreen
    End Sub

    Private Sub table6_MouseDown(sender As Object, e As MouseEventArgs) Handles table6.MouseDown
        table6.BackColor = Color.SeaGreen
    End Sub

    Private Sub table7_MouseDown(sender As Object, e As MouseEventArgs) Handles table8.MouseDown
        table8.BackColor = Color.SeaGreen
    End Sub

    Private Sub table8_MouseDown(sender As Object, e As MouseEventArgs) Handles table7.MouseDown
        table7.BackColor = Color.SeaGreen
    End Sub

    Private Sub table9_MouseDown(sender As Object, e As MouseEventArgs) Handles table9.MouseDown
        table9.BackColor = Color.SeaGreen
    End Sub

    Private Sub table10_MouseDown(sender As Object, e As MouseEventArgs) Handles table10.MouseDown
        table10.BackColor = Color.SeaGreen
    End Sub

    Private Sub door_MouseDown(sender As Object, e As MouseEventArgs) Handles door.MouseDown
        door.BackColor = Color.SeaGreen
    End Sub

    Private Sub baggagecounter_MouseDown(sender As Object, e As MouseEventArgs) Handles baggagecounter.MouseDown
        baggagecounter.BackColor = Color.SeaGreen
    End Sub

    Private Sub librarian1_MouseDown(sender As Object, e As MouseEventArgs) Handles librarian1.MouseDown
        librarian1.BackColor = Color.SeaGreen
    End Sub

    Private Sub librarian2_MouseDown(sender As Object, e As MouseEventArgs) Handles librarian2.MouseDown
        librarian2.BackColor = Color.SeaGreen
    End Sub

    Private Sub librarian3_MouseDown(sender As Object, e As MouseEventArgs) Handles librarian3.MouseDown
        librarian3.BackColor = Color.SeaGreen
    End Sub

    Private Sub bookssection1_MouseDown(sender As Object, e As MouseEventArgs) Handles bookssection1.MouseDown
        bookssection1.BackColor = Color.SeaGreen
    End Sub

    Private Sub bookssection2_MouseDown(sender As Object, e As MouseEventArgs) Handles bookssection2.MouseDown
        bookssection2.BackColor = Color.SeaGreen
    End Sub

    '=================================================================================================================
    'CODE FOR RETURNING THE OBJECT BACK TO NORMAL WHEN RELEASED

    Private Sub table1_MouseUp(sender As Object, e As MouseEventArgs) Handles table1.MouseUp
        table1.BackColor = Color.Honeydew
    End Sub

    Private Sub table2_MouseUp(sender As Object, e As MouseEventArgs) Handles table2.MouseUp
        table2.BackColor = Color.Honeydew
    End Sub

    Private Sub table3_MouseUp(sender As Object, e As MouseEventArgs) Handles table3.MouseUp
        table3.BackColor = Color.Honeydew
    End Sub

    Private Sub table4_MouseUp(sender As Object, e As MouseEventArgs) Handles table4.MouseUp
        table4.BackColor = Color.Honeydew
    End Sub

    Private Sub table5_MouseUp(sender As Object, e As MouseEventArgs) Handles table5.MouseUp
        table5.BackColor = Color.Honeydew
    End Sub

    Private Sub table6_MouseUp(sender As Object, e As MouseEventArgs) Handles table6.MouseUp
        table6.BackColor = Color.Honeydew
    End Sub

    Private Sub table7_MouseUp(sender As Object, e As MouseEventArgs) Handles table8.MouseUp
        table8.BackColor = Color.Honeydew
    End Sub

    Private Sub table8_MouseUp(sender As Object, e As MouseEventArgs) Handles table7.MouseUp
        table7.BackColor = Color.Honeydew
    End Sub

    Private Sub table9_MouseUp(sender As Object, e As MouseEventArgs) Handles table9.MouseUp
        table9.BackColor = Color.Honeydew
    End Sub

    Private Sub table10_MouseUp(sender As Object, e As MouseEventArgs) Handles table10.MouseUp
        table10.BackColor = Color.Honeydew
    End Sub

    Private Sub door_MouseUp(sender As Object, e As MouseEventArgs) Handles door.MouseUp
        door.BackColor = Color.Honeydew
    End Sub

    Private Sub baggagecounter_MouseUp(sender As Object, e As MouseEventArgs) Handles baggagecounter.MouseUp
        baggagecounter.BackColor = Color.Honeydew
    End Sub

    Private Sub librarian1_MouseUp(sender As Object, e As MouseEventArgs) Handles librarian1.MouseUp
        librarian1.BackColor = Color.Honeydew
    End Sub

    Private Sub librarian2_MouseUp(sender As Object, e As MouseEventArgs) Handles librarian2.MouseUp
        librarian2.BackColor = Color.Honeydew
    End Sub

    Private Sub librarian3_MouseUp(sender As Object, e As MouseEventArgs) Handles librarian3.MouseUp
        librarian3.BackColor = Color.Honeydew
    End Sub

    Private Sub bookssection1_MouseUp(sender As Object, e As MouseEventArgs) Handles bookssection1.MouseUp
        bookssection1.BackColor = Color.Honeydew
    End Sub

    Private Sub bookssection2_MouseUp(sender As Object, e As MouseEventArgs) Handles bookssection2.MouseUp
        bookssection2.BackColor = Color.Honeydew
    End Sub

    Private Sub divider_MouseMove(sender As Object, e As MouseEventArgs) Handles divider.MouseMove
        OBJ_Resize.ResizeOBJ(sender, e, Me)
    End Sub

    Private Sub divider_MouseDown(sender As Object, e As MouseEventArgs) Handles divider.MouseDown
        divider.BackColor = Color.SeaGreen
    End Sub

    Private Sub divider_MouseUp(sender As Object, e As MouseEventArgs) Handles divider.MouseUp
        divider.BackColor = Color.Honeydew
    End Sub
    '==================================================================================================================
    'CONNECT DEVICE/RECEIVER TO THE APPLICATION
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        SerialPort1.Close()
        Try
            SerialPort1.PortName = cbPort.Text
            serialPortName = cbPort.Text
            SerialPort1.BaudRate = 9600
            SerialPort1.DataBits = 8
            SerialPort1.Open()

            mbConnected.ShowDialog()
            status = "ON"
            btnConnect.Enabled = False
            cbPort.Enabled = False
            btnDisconnect.Visible = True
        Catch ex As Exception
            mbErrorNotif.ShowDialog()
        End Try
    End Sub
    'CLOSE PORT AND DISCONNECT DEVICE/RECEIVER
    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        SerialPort1.Close()
        SerialPort1.Dispose()
        btnDisconnect.Visible = False
        cbPort.Enabled = True
        btnConnect.Enabled = True
        status = "OFF"
    End Sub

    Private Sub menuDashboard_Click(sender As Object, e As EventArgs) Handles menuDashboard.Click
        Me.Hide()
        Stat.refreshForm()
        Stat.Show()
    End Sub

    Private Sub menuSettings_Click(sender As Object, e As EventArgs) Handles menuSettings.Click
        Me.Hide()
        settings.Show()
    End Sub

    Private Sub menuExit_Click(sender As Object, e As EventArgs) Handles menuExit.Click
        mbExit.ShowDialog()
    End Sub

End Class