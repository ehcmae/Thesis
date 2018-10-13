Imports WMPLib
Imports MySql.Data.MySqlClient
Imports System.IO

Module Module1
    Public pathAlarmFolder As String = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName & "\alarm\"
    Public low As Integer
    Public medium As Integer
    Public high As Integer
    Public alarm1 As String
    Public alarm2 As String
    Public alarm3 As String
    Public Player As WindowsMediaPlayer = New WindowsMediaPlayer
    Public serialPortName As String
    Public serialBaudRate As Integer = 9600
    Public strSql As String
    Public Con As New MySqlConnection With {.ConnectionString = "Server=localhost;User Id=root;Password=naj;Database=noisedetect;"}
    Public Cmd As New MySqlCommand
    Public DA As New MySqlDataAdapter
    Public DS As New DataSet
    Public dreader As MySqlDataReader
    Public i As Integer
    Public MyDataTbl As New DataTable
    Public deviceName1 As String
    Public deviceName2 As String
    Public deviceName3 As String
    Public deviceLoc1 As String
    Public deviceLoc2 As String
    Public deviceLoc3 As String
    Public natflag As Integer = 0
    Public date1 As String
    Public date2 As String
    Public reportParamDate As String

    Public Sub connection()
        If Con.State = ConnectionState.Closed Then
            Con.ConnectionString = "Server=localhost;User Id=root;Password=naj;Database=noisedetect"
            Con.Open()
        End If
    End Sub

    Public Sub viewData(strSql As String)
        connection()
        Cmd = New MySqlCommand(strSql, Con)
        dreader = Cmd.ExecuteReader
    End Sub

    Public Sub RunQuery(strSql As String)
        Try
            Call connection()
            Cmd = New MySqlCommand(strSql, Con)
            DA = New MySqlDataAdapter(Cmd)
            DS = New DataSet
            DA.Fill(DS)
            DA.Fill(MyDataTbl)
            Con.Close()
        Catch ex As Exception
            natflag = natflag + 1
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
    End Sub

    Public Function for_insert_command(strSql As String, table_name As String) As Boolean

        Try
            Call connection()

            Cmd.Connection = Con
            Cmd.CommandText = strSql
            DA.InsertCommand = Cmd
            DA.SelectCommand = Cmd
            DA.Fill(DS, table_name)

            Con.Close()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
    End Function

    Public Function bindData(strSql As String, table_name As String) As Boolean
        Call connection()
        Dim com As String = strSql
        Dim Adpt As New MySqlDataAdapter(com, Con)
        Adpt.Fill(DS, table_name)
        Return True
    End Function
End Module
