Imports System.IO
Imports System.IO.StreamWriter
Imports System.Text

Public Class clsStentWeighing

    Private oFile As System.IO.File
    Private oWrite As System.IO.StreamWriter
    Private strNewRecord As String
    Private strHeader As String

    Public Function OpenPort(ByVal Baudrate As Integer, ByVal TimeOut As Integer, ByVal PortNo As Integer) As Boolean

        moRS232 = New Rs232()
        OpenPort = False
        Try
            With moRS232
                .BaudRate = Baudrate
                .Timeout = TimeOut
                .Port = PortNo
                .DataBit = DATABIT         '8
                .StopBit = STOPBIT         'Rs232.DataStopBit.StopBit_1
                .Parity = DATAPARITY       'Rs232.DataParity.Parity_None
            End With
            If Not moRS232.IsOpen Then moRS232.Open()
            moRS232.Dtr = True
            moRS232.Rts = True
            OpenPort = True
            moRS232.EnableEvents()
        Catch Ex As Exception
            OpenPort = False
            MessageBox.Show(Ex.Message, "Connection Error.", MessageBoxButtons.OK)
        End Try
        Return (OpenPort)
    End Function

    Public Sub ClosePort()
        Try
            If Not moRS232 Is Nothing Then
                If moRS232.IsOpen Then moRS232.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function GetSerialNo(ByVal BufferBytes As Integer) As String
        Dim nContinueReadLoop As Boolean = False
        Dim nBytesReceived As Integer = 0
        Dim sReceivedChars As String = ""
        Try
            moRS232.DisableEvents()
            moRS232.Write(cINQUIRY_SERIALNO + vbCrLf)

            Do While nContinueReadLoop = False
                moRS232.Read(1)
                sReceivedChars = sReceivedChars & (moRS232.InputStreamString)
                If Len(sReceivedChars) >= BufferBytes Then
                    nContinueReadLoop = True
                End If
                If InStr(sReceivedChars, vbCrLf) > 0 Then
                    nContinueReadLoop = True
                End If
            Loop

            moRS232.EnableEvents()
            Return (sReceivedChars.Substring(InStrRev(sReceivedChars, " ") + 1, 10))

        Catch ex As Exception
            ClosePort()
            moRS232.EnableEvents()
            MessageBox.Show(ex.Message, "GetSerialNo : Failed to Connect with Weighing Machine.", MessageBoxButtons.OK)
            Return ""
        End Try
    End Function

    Public Sub InsertIntoLogFile(ByVal filePath As String, ByVal workOrderNo As String, ByVal stepno As Integer, ByVal sequenceValue As Integer, ByVal stentserialno As String, ByVal weight As Decimal, ByVal remarks As String, ByVal LogDateTime As DateTime)

        Dim strLogScanKey As String
        Dim strLogDateTime As String
        strHeader = "WONo,Operation,StepNo,Sequence,StentNo,Weight,MachineID,Remarks,Operator,LogDateTime"

        If LogDateTime = Nothing Then
            Sql = "select getdate()"
            ds = db.selectQuery(Sql)
            If ds.Tables(0).Rows.Count() > 0 Then
                LogDateTime = ds.Tables(0).Rows(0).Item(0)
            End If
        End If

        strLogScanKey = CoatValue & sequenceValue & String.Concat(LogDateTime.ToString("yy"), LogDateTime.ToString("MM"), LogDateTime.ToString("dd"))
        strLogScanKey = strLogScanKey & LogDateTime.ToString("HH") & LogDateTime.ToString("mm") & LogDateTime.ToString("ss")

        Try
            strLogDateTime = LogDateTime

            Sql = "insert into stentweightlogs (stntscankey, wono, stntserialno, coating, stepno, sequence, stntweight, weightedon, weightedby, machine, remarks) values('" & strLogScanKey & "', '" & workOrderNo & "',  '" & stentserialno & "', " & CoatValue & ", " & stepno & ", " & sequenceValue & ", '" & weight & "', '" & strLogDateTime & "', '" & sLogonUser & "', '" & MachineID & "', '" & remarks & "')"
            db.insertQuery(Sql)


            ' To check if directory and file exist and then create new ones

            If CREATELOGFILE = True Then
                If filePath = "" Then
                    filePath = Directory.GetCurrentDirectory & "\Data\LogLoginLogoff.txt"
                End If

                If Not Directory.Exists(Directory.GetCurrentDirectory & "\\Data") Then
                    Directory.CreateDirectory(Directory.GetCurrentDirectory & "\\Data")
                    If filePath = Directory.GetCurrentDirectory & "\Data\LogLoginLogoff.txt" Then
                        oWrite = New StreamWriter(Directory.GetCurrentDirectory & "\Data\LogLoginLogoff.txt")
                    Else
                        oWrite = New StreamWriter(Directory.GetCurrentDirectory & "\Data\Log" & workOrderNo & ".txt")
                    End If

                    oWrite.WriteLine(strHeader)
                    oWrite.Close()
                Else
                    If Not File.Exists(filePath) Then
                        If filePath = Directory.GetCurrentDirectory & "\Data\LogLoginLogoff.txt" Then
                            oWrite = New StreamWriter(Directory.GetCurrentDirectory & "\Data\LogLoginLogoff.txt")
                        Else
                            oWrite = New StreamWriter(Directory.GetCurrentDirectory & "\Data\Log" & workOrderNo & ".txt")
                        End If
                        oWrite.WriteLine(strHeader)
                        oWrite.Close()
                    End If
                End If


                ' Insert record into file
                If oFile.Exists(filePath) = True Then
                    oWrite = oFile.AppendText(filePath)
                    strNewRecord = workOrderNo & ", " & CoatValue & ", " & stepno & ", " & sequenceValue & ", " & stentserialno & " , " & weight & ", " & MachineID & ", " & remarks & ", " & sLogonUser & ", " & LogDateTime
                    oWrite.WriteLine(strNewRecord)
                    oWrite.Flush()
                    oWrite.Close()
                    oWrite = Nothing
                End If
            End If
            If FrmWeighing.timerAutoLogoff.Enabled = True Then
                FrmWeighing.timerAutoLogoff.Stop()
                FrmWeighing.timerAutoLogoff.Start()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            oWrite.Close()
        End Try
    End Sub

    Function CheckForTolerance(ByVal Value1 As Double, ByVal Value2 As Double, ByVal Value3 As Double) As Boolean
        Dim lo, hi As Double

        If Value3 = 0 Then
            lo = Math.Min(Value1, Value2)
            hi = Math.Max(Value1, Value2)
        Else
            lo = Math.Min(Value1, Value2)
            hi = Math.Max(Value1, Value2)
            lo = Math.Min(lo, Value3)
            hi = Math.Max(hi, Value3)
        End If

        If Math.Round((hi - lo), 3) <= TOLERANCE Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function StuffWithZeros(ByVal sInputStr As String, ByVal nStrLength As Integer) As String
        Dim sTmpStr, sStuff As String
        Dim nI As Integer
        sTmpStr = Trim(sInputStr)
        sStuff = ""
        For nI = 1 To (nStrLength - Len(sInputStr))
            sStuff = sStuff & "0"
        Next
        sTmpStr = sStuff & sTmpStr
        Return sTmpStr
    End Function

    Public Sub SetRs232Parameters()
        BAUDRATE = INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), "RS232Config", "BaudRate")
        TIMEOUT = INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), "RS232Config", "TimeOut")
        PORTNO = INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), "RS232Config", "PortNo")
        DATAPARITY = INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), "RS232Config", "DataParity")
        DATABIT = INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), "RS232Config", "DataBit")
        STOPBIT = INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), "RS232Config", "StopBit")
        XONXOFF = INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), "RS232Config", "XonXoff")

    End Sub

    Public Sub SetSettingsParameter()
        MAX_STDWEIGHTSTEPS = INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), "Settings", "WeighingSteps")
        CREATELOGFILE = INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), "Settings", "WriteLogsInFolder")
    End Sub

    Public Function GetConnectionStringValue() As String
        Dim dbConnectionName As String = "DBConnection"
        Dim sTmpConnString As String = ""
        GetConnectionStringValue = ""

        sTmpConnString = "SERVER="
        sTmpConnString = sTmpConnString & INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), dbConnectionName, "Server")
        sTmpConnString = sTmpConnString & ";Database="
        sTmpConnString = sTmpConnString & INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), dbConnectionName, "Database")
        sTmpConnString = sTmpConnString & ";UID="
        sTmpConnString = sTmpConnString & INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), dbConnectionName, "Uid")
        sTmpConnString = sTmpConnString & ";PWD="
        sTmpConnString = sTmpConnString & INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), dbConnectionName, "Pwd")
        sTmpConnString = sTmpConnString & ";Trusted_Connection="
        sTmpConnString = sTmpConnString & INIRead(Path.Combine(Directory.GetCurrentDirectory, iniFileName), dbConnectionName, "Trusted_Connection")
        GetConnectionStringValue = sTmpConnString
    End Function

    Public Function CheckAdmin(ByVal UserID As String, ByVal MenuID As Integer) As Boolean
        Sql = "select * from biouserrights where userid = '" & UserID & "' and roleid = (select roleid from biorights where menuid = " & MenuID & ")"
        ds = db.selectQuery(Sql)
        If ds.Tables(0).Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
