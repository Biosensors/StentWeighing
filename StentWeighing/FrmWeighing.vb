Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports StentWeighing.StentWeighingMain
Imports System.IO

Public Class FrmWeighing

    Dim StandardStentInputValue, NormalStentInputValue As Double
    Dim strSerialNo As String
    Dim stdweight, Maxtolerance, Mintolerance As Double
    Private miComPort As Integer
    Private WithEvents moRS232 As Rs232
    Private mlTicks As Long
    Private Delegate Sub CommEventUpdate(ByVal source As Rs232, ByVal mask As Rs232.EventMasks)
    Dim objClsStentWeighing As New clsStentWeighing
    Public nTotBytes As Integer
    Dim frmMachDetails As New FrmMachineDetails
    Dim finalWeight As Double
    Dim WeightArray(2) As Double
    Public dgSerialCount As Integer
    Private strGetValue As String
    Private sequenceNo As Integer
    Private sLogFilePath As String
    Public sStentGridWO As String
    Dim p As New System.Diagnostics.Process

    Private Sub FrmWeighing_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        SystemName = Environment.MachineName.ToString()
        btn15MinsCheck.Tag = 1
        btnAdmin.Tag = 1
        FrmLogin.Close()

        'Display Coat Name
        SetLabelCoatValue(CoatValue)

        btnAdmin.Text = "Admin (F4)"
        tabStentWeight.Enabled = False
        gboxMachineDetails.Enabled = False
        gboxWODetails.Enabled = False
        btnNextWO.Enabled = False
        btnMachineDetails.Enabled = True
        txtMachineName.Text = ""
        txtSerialNumber.Text = ""
        txtColor.BackColor = Color.Red
        ClearControls()

        ConnectToMachine()

    End Sub

    Private Sub ConnectToMachine()
        Try
            objClsStentWeighing.SetRs232Parameters()
            objClsStentWeighing.SetSettingsParameter()

            If MAX_STDWEIGHTSTEPS = 2 Or MAX_STDWEIGHTSTEPS = 3 Then
            Else
                MAX_STDWEIGHTSTEPS = 3
            End If

            Sql = " select machineid,status from machines where hostname = '" & SystemName & "' and status=1"
            ds = db.selectQuery(Sql)
            If ds.Tables(0).Rows.Count() > 0 Then

                If ds.Tables(0).Rows(0).Item("status") = 2 Then
                    MsgBox("This weighing machine is blocked for scanning or doesn't exist. Please contact the administrator.", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    objClsStentWeighing.ClosePort()
                    objClsStentWeighing.OpenPort(BAUDRATE, TIMEOUT, PORTNO)
                    strSerialNo = objClsStentWeighing.GetSerialNo(SerialNoBytesRead)

                    If Len(Trim(strSerialNo)) <> 0 And strSerialNo <> "" Then

                        Sql = "select machineid,name,serialno,autologoffmins from machines where hostname = '" & SystemName & "' and serialno = '" & strSerialNo & "'"
                        ds = db.selectQuery(Sql)
                        If ds.Tables(0).Rows.Count() > 0 Then
                            MachineID = ds.Tables(0).Rows(0).Item("machineid")
                            txtMachineName.Text = ds.Tables(0).Rows(0).Item("name")
                            txtColor.BackColor = Color.Lime
                            txtSerialNumber.Text = strSerialNo

                            tabStentWeight.Enabled = True
                            gboxMachineDetails.Enabled = True
                            gboxWODetails.Enabled = True
                            btnNextWO.Enabled = True
                            btnMachineDetails.Enabled = False
                            txtwrkordno.Focus()

                            'change machine status to 'In Use' by operator
                            Sql = "update machines set useby ='" & sLogonUser & "' where machineid ='" & MachineID & "'"
                            db.updateQuery(Sql)

                        Else
                            Sql = "select machineid,serialno from machines where hostname = '" & SystemName & "' or serialno = '" & strSerialNo & "'"
                            ds = db.selectQuery(Sql)
                            If ds.Tables(0).Rows.Count() > 0 Then
                                MsgBox("This computer or weighing machine is already registered. Please try with another.", MsgBoxStyle.Critical)
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            Else
                MsgBox("Please register this computer with the weighing machine first and then proceed.", MsgBoxStyle.Information)
                frmMachDetails.ShowDialog()
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CompleteWorkOrderProcess()
        Try
            If txtwrkordno.ReadOnly = False Then
                If Not txtwrkordno.Text = "" Then
                    If ValidateWorkOrder() Then
                        sLogFilePath = Directory.GetCurrentDirectory & "\Data\Log" & Trim(txtwrkordno.Text) & ".txt"
                        dgSerialCount = GetSerialNumbersGridCount()
                        FillWODetails()
                        tabStentWeight.Enabled = True
                        tabStentWeight.Controls.Remove(tabStandardWeight)
                        tabStentWeight.Controls.Remove(tabNormalStent)
                        nTotBytes = 24
                        txtwrkordno.ReadOnly = True
                        sIntAdjustmentStatus = ""

                        Sql = "select getdate()"
                        ds = db.selectQuery(Sql)
                        If ds.Tables(0).Rows.Count() > 0 Then
                            StartInternalAdjustDateTime = ds.Tables(0).Rows(0).Item(0)
                        Else
                            StartInternalAdjustDateTime = System.DateTime.Now
                        End If

                        DisableTimers()
                        timerInternalAdjust.Enabled = True
                        timerInternalAdjust.Interval = timeIntervalValue
                        lblMsgWaiting.Visible = True
                        btnCancel.Enabled = True
                        nCurrentTAB = 1
                        sequenceNo = 0
                        txtInternalAdjust.Focus()
                    Else
                        MsgBox("Invalid Work Order No", MsgBoxStyle.Critical)
                        lblBatch.Text = ""
                        lblItem.Text = ""
                        lblQty.Text = ""
                        lblBalanceQty.Text = ""
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DoInternalAdjustmentProcess()
        Try
            If InStr(UCase(Trim(txtInternalAdjust.Text)), "ADJUSTMENT DONE") Then
                lblMsgInternalAdjust.Visible = True
                lblMsgInternalAdjust.Text = "Internal Adjustment successful."
                lblMsgInternalAdjust.Visible = False
                txtStandardStentSerialNo.ReadOnly = False
                txtInternalAdjust.Text = ""
                RemoveTabs()
                tabStentWeight.Controls.Add(tabStandardWeight)
                ResetWeightTextBoxes()
                txtStandardStentSerialNo.Focus()
                lblInternalAdj.ForeColor = Color.Blue
                FillSerialNumbersGrid()
            ElseIf InStr(UCase(Trim(txtInternalAdjust.Text)), "ABORT") Then
                lblMsgInternalAdjust.Visible = True
                lblMsgInternalAdjust.Text = "Internal Adjustment not successful. Please try again."
                txtInternalAdjust.Text = ""
                txtInternalAdjust.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ResetWeightTextBoxes()

        WeighingSteps = 0
        txtStandardWeightStep1.Visible = True
        txtStandardWeightStep2.Visible = True
        txtNormalStentWeightStep1.Visible = True
        txtNormalStentWeightStep2.Visible = False
        txtNormalStentWeightStep3.Visible = False

        If MAX_STDWEIGHTSTEPS = 3 Then
            txtStandardWeightStep3.Visible = True
            Label11.Visible = True
            Label27.Visible = True
        Else
            txtStandardWeightStep3.Visible = False
            Label11.Visible = False
            Label27.Visible = False
        End If
        If MAX_NORMALWEIGHTSTEPS = 3 Then
            txtNormalStentWeightStep1.Visible = True
            txtNormalStentWeightStep2.Visible = True
            txtNormalStentWeightStep3.Visible = True
        ElseIf MAX_NORMALWEIGHTSTEPS = 2 Then
            txtNormalStentWeightStep1.Visible = True
            txtNormalStentWeightStep2.Visible = True
        Else
            txtNormalStentWeightStep1.Visible = True
        End If

    End Function

    Private Sub DoStandardWeightProcess(ByVal sRecvdData As String)

        Dim nCurrentWeight As String
        Try

            nCurrentWeight = sReturnActualWeight(sRecvdData)

            If Len(Trim(txtStandardWeight.Text.Trim)) > 0 Then
                txtNormalStentSerialNo.ReadOnly = False

                If bDataReadStatus = True Then
                    If Val(nCurrentWeight) = 0 Then
                        bDataReadStatus = False
                        Exit Sub
                    Else
                        Exit Sub
                    End If
                Else
                    If Val(nCurrentWeight) = 0 Then
                        Exit Sub
                    End If
                End If

                If Val(nCurrentWeight) = 0 Then
                    sReceivedWeightData = ""
                    Exit Sub
                End If

                StandardStentInputValue = CDbl(nCurrentWeight.Trim)
                bDataReadStatus = True
                txtStandardWeight.Text = ""
                If StandardStentInputValue >= Mintolerance And StandardStentInputValue <= Maxtolerance Then

                    If txtStandardWeightStep1.Text.Trim() <> "" Then          ' equal to 0 : Step 1 Continue
                        If txtStandardWeightStep2.Text.Trim() <> "" Then      ' Equal to 0 Then Step 2 else continue 

                            If objClsStentWeighing.CheckForTolerance(txtStandardWeightStep1.Text, txtStandardWeightStep2.Text, StandardStentInputValue) Then    ' STEP 3
                                sequenceNo = sequenceNo + 1
                                objClsStentWeighing.InsertIntoLogFile(sLogFilePath, Trim(txtwrkordno.Text), 2, sequenceNo, UCase(Trim(txtStandardStentSerialNo.Text)), StandardStentInputValue, "", Nothing)
                                txtStandardWeightStep3.Text = Format(StandardStentInputValue, "##0.000")
                                WeighingSteps = 3

                                'lblMsgNormalStent.Text = ""
                                'lblMsgNormalStent.Visible = False
                                'RemoveTabs()
                                'tabStentWeight.Controls.Add(tabNormalStent)
                                'btnAdmin.Enabled = True
                                'btn15MinsCheck.Enabled = True
                                'txtNormalStentSerialNo.Focus()
                                'lblStdStent.ForeColor = Color.Blue
                                'FillSerialNumbersGrid()
                            Else
                                ClearStandardWeightControls()
                                txtStandardWeight.Focus()
                            End If
                        Else    ' Step 2
                            If objClsStentWeighing.CheckForTolerance(txtStandardWeightStep1.Text, StandardStentInputValue, 0) Then
                                txtStandardWeightStep2.Text = Format(StandardStentInputValue, "##0.000")
                                WeighingSteps = 2
                                sequenceNo = sequenceNo + 1
                                txtStandardWeightStep2.BackColor = Color.Empty
                                txtStandardWeightStep3.BackColor = Color.Yellow
                                objClsStentWeighing.InsertIntoLogFile(sLogFilePath, Trim(txtwrkordno.Text), 2, sequenceNo, UCase(Trim(txtStandardStentSerialNo.Text)), StandardStentInputValue, "", Nothing)
                                txtStandardWeight.Focus()
                            Else
                                ClearStandardWeightControls()
                                'txtStandardWeight.Focus()
                            End If
                        End If
                    Else         ' Step 1
                        txtStandardWeightStep1.Text = Format(StandardStentInputValue, "##0.000")
                        sequenceNo = sequenceNo + 1
                        WeighingSteps = 1
                        txtStandardWeightStep1.BackColor = Color.Empty
                        txtStandardWeightStep2.BackColor = Color.Yellow
                        objClsStentWeighing.InsertIntoLogFile(sLogFilePath, Trim(txtwrkordno.Text), 2, sequenceNo, UCase(Trim(txtStandardStentSerialNo.Text)), StandardStentInputValue, "", Nothing)
                    End If

                    If WeighingSteps = MAX_STDWEIGHTSTEPS Then
                        lblMsgNormalStent.Text = ""
                        lblMsgNormalStent.Visible = False
                        RemoveTabs()
                        tabStentWeight.Controls.Add(tabNormalStent)
                        ResetWeightTextBoxes()
                        btnAdmin.Enabled = True
                        btn15MinsCheck.Enabled = True
                        txtNormalStentSerialNo.Focus()
                        lblStdStent.ForeColor = Color.Blue
                        FillSerialNumbersGrid()
                    Else
                        'ClearStandardWeightControls()
                        txtStandardWeight.Focus()

                    End If

                    'txtStandardWeight.Clear()
                    'txtStandardWeight.Focus()
                Else
                    ClearStandardWeightControls()
                    txtStandardWeight.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearStandardWeightControls()
        lblMsgStandardWeight.Visible = True
        lblMsgStandardWeight.Text = "Invalid Standard Weight."
        MsgBox("Invalid Standard Weight. Please Weigh again.")
        txtStandardWeightStep1.Clear()
        txtStandardWeightStep2.Clear()
        txtStandardWeightStep3.Clear()
        txtStandardWeightStep1.BackColor = Color.Yellow
        txtStandardWeightStep2.BackColor = Color.Empty
        txtStandardWeightStep3.BackColor = Color.Empty
        sequenceNo = sequenceNo + 1
        bDataReadStatus = True
        objClsStentWeighing.InsertIntoLogFile(sLogFilePath, Trim(txtwrkordno.Text), 2, sequenceNo, Trim(txtStandardStentSerialNo.Text), StandardStentInputValue, "", Nothing)
        txtStandardWeight.Clear()
    End Sub

    Private Sub DoNormalStentProcess(ByVal sRecvdData As String)

        txtStandardWeight.Text = ""
        Dim ncurrentweight As String

        Try
            ncurrentweight = sReturnActualWeight(sRecvdData)

            If Trim(txtNormalStentWeight.Text).Length > 0 Then
                Try
                    If bDataReadStatus = True Then
                        If Val(ncurrentweight) = 0 Then
                            bDataReadStatus = False
                            Exit Sub
                        Else
                            Exit Sub
                        End If
                    Else
                        If Val(ncurrentweight) = 0 Then
                            Exit Sub
                        End If
                    End If
                Catch ex As Exception
                    txtNormalStentWeight.Text = txtNormalStentWeight.Text & vbCrLf & vbCrLf & ex.Message
                End Try

            End If
            lblMsgNormalStent.Text = ""

            If txtNormalStentWeight.Text.Trim() <> "" Then

                NormalStentInputValue = CDbl(ncurrentweight.Trim)              'txtNormalStentWeight.Text.Trim()
                txtNormalStentWeight.Focus()

                If txtNormalStentWeightStep1.Text.Trim = "" Then         ' STEP 1
                    If txtNormalStentWeightStep2.Text.Trim = "" Then
                        If txtNormalStentWeightStep3.Text.Trim = "" Then
                            sequenceNo = sequenceNo + 1
                            txtNormalStentWeightStep1.Text = Format(NormalStentInputValue, "##0.000")       'txtNormalStentWeight.Text.Trim()
                            bDataReadStatus = True
                            WeighingSteps = 1
                            txtNormalStentWeightStep1.BackColor = Color.Empty
                            txtNormalStentWeightStep2.BackColor = Color.Yellow
                            objClsStentWeighing.InsertIntoLogFile(sLogFilePath, Trim(txtwrkordno.Text), 3, sequenceNo, Trim(txtNormalStentSerialNo.Text), NormalStentInputValue, "", Nothing)
                            txtNormalStentWeight.Focus()
                        End If
                    End If
                Else
                    If txtNormalStentWeightStep2.Text.Trim = "" Then         ' STEP 2

                        'Check for tolerance for first and second weights
                        If objClsStentWeighing.CheckForTolerance(txtNormalStentWeightStep1.Text, NormalStentInputValue, 0) Then
                            sequenceNo = sequenceNo + 1
                            txtNormalStentWeightStep2.Text = Format(NormalStentInputValue, "##0.000")
                            bDataReadStatus = True
                            WeighingSteps = 2
                            txtNormalStentWeightStep2.BackColor = Color.Empty
                            txtNormalStentWeightStep3.BackColor = Color.Yellow
                            objClsStentWeighing.InsertIntoLogFile(sLogFilePath, Trim(txtwrkordno.Text), 3, sequenceNo, Trim(txtNormalStentSerialNo.Text), NormalStentInputValue, "", Nothing)
                            txtNormalStentWeight.Focus()
                        Else
                            ClearNormalStentControls()
                            txtNormalStentSerialNo.Text = ""
                            txtNormalStentSerialNo.Focus()
                        End If

                    ElseIf txtNormalStentWeightStep3.Text.Trim = "" Then   ' STEP 3
                        'Check for telerance for first, second and third weights
                        If objClsStentWeighing.CheckForTolerance(txtNormalStentWeightStep1.Text, txtNormalStentWeightStep2.Text, NormalStentInputValue) Then
                            txtNormalStentWeightStep3.Text = Format(NormalStentInputValue, "##0.000")
                            bDataReadStatus = True

                            sequenceNo = sequenceNo + 1
                            objClsStentWeighing.InsertIntoLogFile(sLogFilePath, Trim(txtwrkordno.Text), 3, sequenceNo, Trim(txtNormalStentSerialNo.Text), NormalStentInputValue, "", Nothing)
                            WeighingSteps = 3

                            ''Insert final weight into database
                            'If Trim(txtNormalStentWeightStep1.Text).Length > 0 Then
                            '    WeightArray(0) = CDbl(Trim(txtNormalStentWeightStep1.Text))
                            'End If
                            'If Trim(txtNormalStentWeightStep2.Text).Length > 0 Then
                            '    WeightArray(1) = CDbl(Trim(txtNormalStentWeightStep2.Text))
                            'End If
                            'If Trim(txtNormalStentWeightStep3.Text).Length > 0 Then
                            '    WeightArray(2) = CDbl(Trim(txtNormalStentWeightStep3.Text))
                            'End If

                            'Array.Sort(WeightArray)
                            'finalWeight = WeightArray(1)

                            'If Trim(txtNormalStentSerialNo.Text).Length > 0 Then
                            '    If AdminCoatValue = 9 Then 'For Admin Check
                            '        Sql = "insert into StentWeightsChecks (stntserial,coating,weightedby,weightedon,step1wt,step2wt,step3wt,finalwt,machine,overwritten) values('" & Trim(txtNormalStentSerialNo.Text) & "', " & CoatValue & ", '" & sLogonAdmin & "', getdate(), " & Trim(txtNormalStentWeightStep1.Text) & ", " & Trim(txtNormalStentWeightStep2.Text) & ", " & Trim(txtNormalStentWeightStep3.Text) & ", " & finalWeight & ", '" & MachineID & "',0)"
                            '        db.insertQuery(Sql)
                            '    Else 'For Precoat, 15 Mins check and Postcoat
                            '        Sql = "insert into stentfinalweights (stntserial,coating,weightedby,weightedon,step1wt,step2wt,step3wt,finalwt,machine,datamode,modifiedby,modifiedon) values('" & Trim(txtNormalStentSerialNo.Text) & "', " & CoatValue & ", '" & sLogonUser & "', getdate(), " & Trim(txtNormalStentWeightStep1.Text) & ", " & Trim(txtNormalStentWeightStep2.Text) & ", " & Trim(txtNormalStentWeightStep3.Text) & ", " & finalWeight & ", '" & MachineID & "', 0, '" & sLogonUser & "', getdate())"
                            '        db.insertQuery(Sql)
                            '    End If
                            'End If

                            'dgSerialCount = GetSerialNumbersGridCount()
                            'FillSerialNumbersGrid()

                            'txtNormalStentSerialNo.Enabled = True
                            'txtNormalStentSerialNo.Text = ""
                            'txtNormalStentSerialNo.Focus()
                        Else
                            ClearNormalStentControls()
                            txtNormalStentSerialNo.Text = ""
                            txtNormalStentSerialNo.Focus()
                        End If
                        lblNormalStent.ForeColor = Color.Blue
                    End If
                End If
                If WeighingSteps = MAX_NORMALWEIGHTSTEPS Then
                    'Insert final weight into database
                    If Trim(txtNormalStentWeightStep1.Text).Length > 0 Then
                        WeightArray(0) = CDbl(Trim(txtNormalStentWeightStep1.Text))
                    End If
                    If Trim(txtNormalStentWeightStep2.Text).Length > 0 Then
                        WeightArray(1) = CDbl(Trim(txtNormalStentWeightStep2.Text))
                    End If
                    If Trim(txtNormalStentWeightStep3.Text).Length > 0 Then
                        WeightArray(2) = CDbl(Trim(txtNormalStentWeightStep3.Text))
                    End If

                    Select Case MAX_NORMALWEIGHTSTEPS
                        Case 1
                            txtNormalStentWeightStep2.Text = 0
                            txtNormalStentWeightStep3.Text = 0
                            finalWeight = WeightArray(0)
                        Case 2
                            txtNormalStentWeightStep3.Text = 0
                            finalWeight = (WeightArray(0) + WeightArray(1)) / 2
                        Case 3
                            Array.Sort(WeightArray)
                            finalWeight = WeightArray(1)
                    End Select
                    ' Commented by Ali, 29-July-2016
                    'If MAX_STDWEIGHTSTEPS = 3 Then
                    '    Array.Sort(WeightArray)
                    '    finalWeight = WeightArray(1)
                    'Else
                    '    txtNormalStentWeightStep3.Text = 0
                    '    finalWeight = (WeightArray(0) + WeightArray(1)) / 2
                    'End If


                    If Trim(txtNormalStentSerialNo.Text).Length > 0 Then
                        finalWeight = Math.Round(finalWeight, 3)
                        If AdminCoatValue = 9 Then 'For Admin Check
                            Sql = "insert into StentWeightsChecks (stntserial,coating,weightedby,weightedon,step1wt,step2wt,step3wt,finalwt,machine,overwritten) values('" & Trim(txtNormalStentSerialNo.Text) & "', " & CoatValue & ", '" & sLogonAdmin & "', getdate(), " & Trim(txtNormalStentWeightStep1.Text) & ", " & Trim(txtNormalStentWeightStep2.Text) & ", " & Trim(txtNormalStentWeightStep3.Text) & ", " & finalWeight & ", '" & MachineID & "',0)"
                            db.insertQuery(Sql)
                        Else 'For Precoat, 15 Mins check and Postcoat
                            Sql = "insert into stentfinalweights (stntserial,coating,weightedby,weightedon,step1wt,step2wt,step3wt,finalwt,machine,datamode,modifiedby,modifiedon) values('" & Trim(txtNormalStentSerialNo.Text) & "', " & CoatValue & ", '" & sLogonUser & "', getdate(), " & Trim(txtNormalStentWeightStep1.Text) & ", " & Trim(txtNormalStentWeightStep2.Text) & ", " & Trim(txtNormalStentWeightStep3.Text) & ", " & finalWeight & ", '" & MachineID & "', 0, '" & sLogonUser & "', getdate())"
                            db.insertQuery(Sql)
                        End If
                    End If

                    dgSerialCount = GetSerialNumbersGridCount()
                    FillSerialNumbersGrid()

                    txtNormalStentSerialNo.Enabled = True
                    txtNormalStentSerialNo.Text = ""
                    txtNormalStentSerialNo.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearNormalStentControls()
        lblMsgNormalStent.Visible = True
        lblMsgNormalStent.Text = "Stent weight is not within allowed range. Please weigh again."
        MsgBox("Stent weight is not within allowed range. Please weigh again.")
        bDataReadStatus = False
        txtNormalStentWeightStep1.Clear()
        txtNormalStentWeightStep2.Clear()
        txtNormalStentWeightStep3.Clear()
        txtNormalStentWeightStep1.BackColor = Color.Yellow
        txtNormalStentWeightStep2.BackColor = Color.Empty
        txtNormalStentWeightStep3.BackColor = Color.Empty
        sequenceNo = sequenceNo + 1
        bDataReadStatus = True
        objClsStentWeighing.InsertIntoLogFile(sLogFilePath, Trim(txtwrkordno.Text), 3, sequenceNo, Trim(txtNormalStentSerialNo.Text), NormalStentInputValue, "", Nothing)
        txtNormalStentWeight.Clear()
    End Sub

    Private Sub CheckStandardStentSerial()
        Try
            If txtStandardStentSerialNo.Text.Trim() <> "" Then
                Sql = "Select stentid from stdweight where stentid='" & txtStandardStentSerialNo.Text.Trim() & "'"
                ds = db.selectQuery(Sql)
                If ds.Tables(0).Rows.Count = 0 Then
                    lblMsgStandardWeight.Visible = True
                    lblMsgStandardWeight.Text = "Invalid standard serial number."
                    txtStandardStentSerialNo.Clear()
                    txtStandardStentSerialNo.Focus()
                Else
                    Sql = "select stdweight, mintolerance, maxtolerance from stdweight where stentid = '" & txtStandardStentSerialNo.Text.Trim() & "'"
                    ds = db.selectQuery(Sql)

                    If ds.Tables(0).Rows.Count() > 0 Then
                        stdweight = ds.Tables(0).Rows(0).Item("stdweight")
                        Mintolerance = ds.Tables(0).Rows(0).Item("mintolerance")
                        Maxtolerance = ds.Tables(0).Rows(0).Item("maxtolerance")
                        sequenceNo = 0
                        timerStandardWeight.Enabled = True
                        txtStandardWeight.Focus()
                        SetTextBackground()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckNormalStentSerial()
        Try
            Dim sStentWorkOrder As String

            If txtNormalStentSerialNo.Text.Trim() <> "" Then
                ' Sql = "select stntserial,status from stentserials where stntserial='" & txtNormalStentSerialNo.Text.Trim() & "' and stwono='" & txtwrkordno.Text.Trim() & "'"
                ' Check  for work order Number matching outside the SQL statement in order to allow 15 Mins weight check of another work order
                Sql = "select stwono, stntserial,status from stentserials where stntserial='" & txtNormalStentSerialNo.Text.Trim() & "'"
                ds = db.selectQuery(Sql)
                If ds.Tables(0).Rows.Count = 0 Then
                    lblMsgNormalStent.Visible = True
                    lblMsgNormalStent.Text = "Invalid stent serial number."
                    txtNormalStentSerialNo.Clear()
                    txtNormalStentSerialNo.Focus()
                Else
                    sStentWorkOrder = ds.Tables(0).Rows(0).Item("stwono")
                    sStentGridWO = ds.Tables(0).Rows(0).Item("stwono")
                    If ds.Tables(0).Rows(0).Item("status") = 0 Then
                        lblMsgNormalStent.Visible = True
                        lblMsgNormalStent.Text = "This stent serial number is rejected."
                        txtNormalStentSerialNo.Clear()
                        txtNormalStentSerialNo.Focus()
                    Else
                        If ((CoatValue = 1 Or CoatValue = 3) And txtwrkordno.Text.Trim() <> ds.Tables(0).Rows(0).Item("stwono")) Then
                            lblMsgNormalStent.Visible = True
                            lblMsgNormalStent.Text = "Serial No. does not belong to this Work Order"
                            txtNormalStentSerialNo.Clear()
                            txtNormalStentSerialNo.Focus()

                        Else

                            '' Need to Initialize Weighing Cycle Steps for 15Mins Weighing
                            '' Ali , 02 - Aug - 2016

                            '' Read Weighing Cycle Parameter and set MAX Steps - Ali @ 29-July-2016  
                            Sql = "EXECUTE [dbo].[GetWeighingCycleParameter] '" & sStentWorkOrder & "', " & CoatValue
                            ds = db.selectQuery(Sql)
                            If ds.Tables(0).Rows.Count() > 0 Then
                                MAX_NORMALWEIGHTSTEPS = ds.Tables(0).Rows(0).Item(0)
                            Else
                                MAX_NORMALWEIGHTSTEPS = 2
                            End If
                            ResetWeightTextBoxes()

                            'For Admin Check, allow already scanned serial numbers
                            If AdminCoatValue = 9 Then

                                ' Check for Pre Coating already done
                                If CoatValue = 1 Then
                                    Sql = "Select stntserial,coating from stentfinalweights where stntserial='" & txtNormalStentSerialNo.Text.Trim() & "' and coating =1"
                                    ds = db.selectQuery(Sql)
                                    If ds.Tables(0).Rows.Count > 0 Then
                                        AllowStentWeighing()
                                    Else
                                        lblMsgNormalStent.Visible = True
                                        lblMsgNormalStent.Text = "Admin Check can be done only after Pre Coat weighing."
                                    End If

                                    ' Check for Post Coating already done
                                ElseIf CoatValue = 3 Then
                                    Sql = "select stntserial,coating from stentfinalweights where stntserial='" & txtNormalStentSerialNo.Text.Trim() & "' and coating =3"
                                    ds = db.selectQuery(Sql)
                                    If ds.Tables(0).Rows.Count > 0 Then
                                        AllowStentWeighing()
                                    Else
                                        lblMsgNormalStent.Visible = True
                                        lblMsgNormalStent.Text = "Admin Check can be done only after Post Coat weighing."
                                    End If
                                End If

                            Else
                                'For 15 Mins Check 
                                If CoatValue = 2 Then
                                    Sql = "Select stntserial,coating from stentfinalweights where stntserial='" & txtNormalStentSerialNo.Text.Trim() & "' and coating =1"
                                    ds = db.selectQuery(Sql)
                                    If ds.Tables(0).Rows.Count > 0 Then
                                        Sql = "select stntserial,coating from stentfinalweights where stntserial='" & txtNormalStentSerialNo.Text.Trim() & "' and coating =2"
                                        ds = db.selectQuery(Sql)
                                        If ds.Tables(0).Rows.Count = 0 Then
                                            AllowStentWeighing()
                                        Else
                                            lblMsgNormalStent.Visible = True
                                            lblMsgNormalStent.Text = "This stent serial number is already scanned for 15 Mins Check."
                                        End If
                                    Else
                                        lblMsgNormalStent.Visible = True
                                        lblMsgNormalStent.Text = "15 Mins Check can be done only after Pre Coat weighing."
                                    End If

                                Else
                                    'For Pre Coating and Post Coating
                                    Sql = "select stntserial,coating from stentfinalweights where stntserial='" & txtNormalStentSerialNo.Text.Trim() & "' and coating =" & CoatValue & ""
                                    ds = db.selectQuery(Sql)
                                    If ds.Tables(0).Rows.Count = 0 Then
                                        If CoatValue = 1 Then
                                            AllowStentWeighing()
                                        ElseIf CoatValue = 3 Then
                                            Sql = "select stntserial,coating from stentfinalweights where stntserial='" & txtNormalStentSerialNo.Text.Trim() & "' and coating =1"
                                            ds = db.selectQuery(Sql)
                                            If ds.Tables(0).Rows.Count = 0 Then
                                                lblMsgNormalStent.Visible = True
                                                lblMsgNormalStent.Text = "Post Coat weighing can be done only after Pre Coat weighing."
                                                txtNormalStentSerialNo.Focus()
                                            Else
                                                AllowStentWeighing()
                                            End If
                                        End If
                                    Else
                                        lblMsgNormalStent.Visible = True
                                        lblMsgNormalStent.Text = "This stent serial number is already scanned for this coating."
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                txtNormalStentSerialNo.Clear()
                txtNormalStentSerialNo.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AllowStentWeighing()
        timerNormalStent.Enabled = True
        sequenceNo = 0
        txtNormalStentWeight.Focus()
        SetTextBackground()
    End Sub

    Private Sub RemoveTabs()
        tabStentWeight.Controls.Remove(tabInternalAdjust)
        tabStentWeight.Controls.Remove(tabStandardWeight)
        tabStentWeight.Controls.Remove(tabNormalStent)
    End Sub

    Private Sub FillWODetails()

        lblBatch.Text = ""
        lblItem.Text = ""
        lblQty.Text = ""
        lblBalanceQty.Text = ""

        Try
            Sql = "SELECT project as WorkOrderNo, ItemCode as ItemCode, ItemDesc as ItemDescription, QtyActual as Quantity, facode as BatchNo FROM ZWOList WHERE project = '" & txtwrkordno.Text.Trim.ToString() & "'"
            ds = db.selectQuery(Sql)

            If (ds.Tables(0).Rows.Count > 0) Then
                lblItem.Text = ds.Tables(0).Rows(0).Item("ItemCode")
                lblQty.Text = ds.Tables(0).Rows(0).Item("Quantity")
                lblBatch.Text = ds.Tables(0).Rows(0).Item("BatchNo")
                lblBalanceQty.Text = CInt(lblQty.Text) - dgSerialCount
            Else
                lblItem.Text = ""
                lblQty.Text = ""
                lblBatch.Text = ""
                lblBalanceQty.Text = ""
            End If
            ' Read Weighing Cycle Parameter and set MAX Steps - Ali @ 29-July-2016  
            Sql = "EXECUTE [dbo].[GetWeighingCycleParameter] '" & txtwrkordno.Text.Trim.ToString() & "', " & CoatValue
            ds = db.selectQuery(Sql)
            If ds.Tables(0).Rows.Count() > 0 Then
                MAX_NORMALWEIGHTSTEPS = ds.Tables(0).Rows(0).Item(0)
            Else
                MAX_NORMALWEIGHTSTEPS = 2
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FillSerialNumbersGrid()
        Try
            ds.Clear()
            Sql = "select s.stntserial as 'Stent Serial', s.finalwt as Weight from stentfinalweights s , stentserials w where s.stntserial = w.stntserial and w.stwono = '" & sStentGridWO & "' and coating =" & CoatValue & " order by s.weightedon desc"
            ds = db.selectQuery(Sql)
            dgStandardStentSerials.DataSource = ds.Tables(0).DefaultView
            dgNormalStentSerials.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function GetSerialNumbersGridCount()
        Try
            Sql = "select s.stntserial as 'Stent Serial', s.finalwt as Weight from stentfinalweights s , stentserials w where s.stntserial = w.stntserial and w.stwono = '" & sStentGridWO & "' and coating =" & CoatValue & " order by s.weightedon desc"
            ds = db.selectQuery(Sql)
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0).Rows.Count
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function

    Private Function ValidateWorkOrder() As Boolean
        Dim sql As String
        Dim code As String
        Dim ds As New DataSet
        ValidateWorkOrder = False
        If Not txtwrkordno.Text = "" Then
            Try
                sql = "select * from WorkOrders where project = '" & txtwrkordno.Text.Trim & "'"
                ds = db.selectQuery(sql)
                If ds.Tables(0).Rows.Count() > 0 Then
                    code = ds.Tables(0).Rows(0).Item("ItemCode")
                    ValidateWorkOrder = True
                Else
                    txtwrkordno.Text = ""
                    ValidateWorkOrder = False
                    txtwrkordno.Focus()
                End If
            Catch ex As System.Exception
                txtwrkordno.Text = ""
                ValidateWorkOrder = False
                txtwrkordno.Focus()
            End Try
        Else
            ValidateWorkOrder = False
        End If
    End Function

    Private Sub ClearControls()
        txtwrkordno.Text = ""
        txtInternalAdjust.Text = ""
        txtStandardWeight.Text = ""
        txtNormalStentWeight.Text = ""
        txtStandardStentSerialNo.Text = ""
        txtNormalStentSerialNo.Text = ""
        txtStandardWeightStep1.Text = ""
        txtStandardWeightStep2.Text = ""
        txtStandardWeightStep3.Text = ""
        txtNormalStentWeightStep1.Text = ""
        txtNormalStentWeightStep2.Text = ""
        txtNormalStentWeightStep3.Text = ""
        txtInternalAdjust.BackColor = Color.Empty
        txtStandardWeight.BackColor = Color.Empty
        txtNormalStentWeight.BackColor = Color.Empty
        txtStandardWeightStep1.BackColor = Color.Empty
        txtStandardWeightStep2.BackColor = Color.Empty
        txtStandardWeightStep3.BackColor = Color.Empty
        txtNormalStentWeightStep1.BackColor = Color.Empty
        txtNormalStentWeightStep2.BackColor = Color.Empty
        txtNormalStentWeightStep3.BackColor = Color.Empty
        txtwrkordno.ReadOnly = False

        lblItem.Text = ""
        lblBatch.Text = ""
        lblQty.Text = ""
        lblBalanceQty.Text = ""
        lblInternalAdj.ForeColor = Color.Empty
        lblStdStent.ForeColor = Color.Empty
        lblNormalStent.ForeColor = Color.Empty
        lblMsgWaiting.Visible = False
        lblMsgInternalAdjust.Text = ""
        lblMsgStandardWeight.Text = ""
        lblMsgNormalStent.Text = ""
        lblMsgInternalAdjust.Visible = False
        lblMsgStandardWeight.Visible = False
        lblMsgNormalStent.Visible = False

        RemoveTabs()
        tabStentWeight.Controls.Add(tabInternalAdjust)
        tabStentWeight.Enabled = False

        btn15MinsCheck.Enabled = False
        btnAdmin.Enabled = False
        'btnAdmin.Enabled = True
        btnAdmin.Text = "Admin (F4)"
        btn15MinsCheck.Text = "15 Mins (F8)"
        btnLogOff.Enabled = True
        btnNextWO.Enabled = False
        btnAdmin.Tag = 1
        btnContinue.Enabled = False

        AdminCoatValue = 0
        SetLabelCoatValue(LoginCoatValue)
        ClearSerialDataGrids()
        DisableTimers()
        timerAutoLogoff.Enabled = False
        txtwrkordno.Focus()

    End Sub

    Private Sub ClearSerialDataGrids()
        Sql = "select s.stntserial as SerialNo, s.finalwt as Weight from stentfinalweights s , stentserials w where s.stntserial = w.stntserial and w.stwono = '' and coating =" & CoatValue & " order by s.weightedon desc"
        ds = db.selectQuery(Sql)
        dgStandardStentSerials.DataSource = ds.Tables(0).DefaultView
        dgNormalStentSerials.DataSource = ds.Tables(0).DefaultView
    End Sub

    Private Sub DisableTimers()
        timerInternalAdjust.Enabled = False
        timerStandardWeight.Enabled = False
        timerNormalStent.Enabled = False
    End Sub

    Private Sub txtwrkordno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtwrkordno.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            nCurrentTAB = 0
            Try
                sStentGridWO = Trim(txtwrkordno.Text)
                If Trim(txtwrkordno.Text).Length = 0 Then
                    lblMsgInternalAdjust.Visible = True
                    MsgBox("Enter Work Order Number")
                    txtwrkordno.Focus()
                Else
                    lblMsgWaiting.Text = "Waiting for the response from machine ...."
                    timerAutoLogoff.Enabled = False

                    Sql = "select autologoffmins from machines where hostname = '" & SystemName & "' and status =1"
                    ds = db.selectQuery(Sql)
                    If ds.Tables(0).Rows.Count() > 0 Then
                        If CInt(ds.Tables(0).Rows(0).Item(0)) > 0 Then
                            timerAutoLogoff.Interval = CInt(ds.Tables(0).Rows(0).Item(0)) * 60000
                            timerAutoLogoff.Enabled = True
                        End If
                    End If
                    CompleteWorkOrderProcess()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtStandardStentSerialNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStandardStentSerialNo.GotFocus
        nCurrentTAB = 2
        bDataReadStatus = True
        DisableTimers()
        txtStandardWeight.Text = ""
        txtStandardWeightStep1.Text = ""
        txtStandardWeightStep2.Text = ""
        txtStandardWeightStep3.Text = ""
        txtStandardWeightStep1.BackColor = Color.Empty
        txtStandardWeightStep2.BackColor = Color.Empty
        txtStandardWeightStep3.BackColor = Color.Empty
    End Sub

    Private Sub txtStandardStentSerialNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStandardStentSerialNo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            nCurrentTAB = 2
            txtStandardWeightStep1.Text = ""
            txtStandardWeightStep2.Text = ""
            txtStandardWeightStep3.Text = ""
            DisableTimers()
            bDataReadStatus = True
            sIntAdjustmentStatus = ""
            If Trim(txtStandardStentSerialNo.Text).Length = 0 Then
                lblMsgStandardWeight.Visible = True
                lblMsgStandardWeight.Text = "Enter Stent Serial Number."
                txtStandardStentSerialNo.Focus()
            Else
                CheckStandardStentSerial()
            End If
        End If
    End Sub

    Private Sub txtNormalStentSerialNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNormalStentSerialNo.GotFocus
        nCurrentTAB = 3
        bDataReadStatus = True
        DisableTimers()
        txtNormalStentWeight.Text = ""
        txtNormalStentWeightStep1.Text = ""
        txtNormalStentWeightStep2.Text = ""
        txtNormalStentWeightStep3.Text = ""
        txtNormalStentWeightStep1.BackColor = Color.Empty
        txtNormalStentWeightStep2.BackColor = Color.Empty
        txtNormalStentWeightStep3.BackColor = Color.Empty
    End Sub

    Private Sub txtNormalStentSerialNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNormalStentSerialNo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            nCurrentTAB = 3
            txtNormalStentWeightStep1.Text = ""
            txtNormalStentWeightStep2.Text = ""
            txtNormalStentWeightStep3.Text = ""
            DisableTimers()
            bDataReadStatus = True
            sIntAdjustmentStatus = ""
            If Trim(txtNormalStentSerialNo.Text).Length = 0 Then
                lblMsgNormalStent.Visible = True
                lblMsgNormalStent.Text = "Enter Stent Serial Number."
                txtNormalStentSerialNo.Focus()
            Else
                lblMsgNormalStent.Text = ""
                CheckNormalStentSerial()
            End If
        End If
    End Sub

    Private Sub txtStandardWeight_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStandardWeight.GotFocus
        timerStandardWeight.Interval = timeIntervalValue
        timerStandardWeight.Enabled = True

        If txtStandardWeightStep1.Text = "" Then
            txtStandardWeightStep1.BackColor = Color.Yellow
        End If
        If txtNormalStentWeightStep1.Text = "" Then
            txtNormalStentWeightStep1.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub txtNormalStentWeight_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNormalStentWeight.GotFocus
        timerNormalStent.Interval = timeIntervalValue
        timerNormalStent.Enabled = True

        If txtStandardWeightStep1.Text = "" Then
            txtStandardWeightStep1.BackColor = Color.Yellow
        End If
        If txtNormalStentWeightStep1.Text = "" Then
            txtNormalStentWeightStep1.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub btnMachineDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMachineDetails.Click
        objClsStentWeighing.ClosePort()
        ClearControls()
        frmMachDetails.ShowDialog()
    End Sub

    Private Sub btnNextWO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextWO.Click
        objClsStentWeighing.ClosePort()
        ClearControls()
        ConnectToMachine()
    End Sub

    Private Sub btnAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.Click

        If btnAdmin.Tag = 1 Then
            btn15MinsCheck.Enabled = False
            FrmLogin.lblAdmin.Text = "AdminLogin"
            FrmLogin.lblChangePassword.Visible = False
            FrmLogin.txtUserID.Focus()
            FrmLogin.ShowDialog()
            FillSerialNumbersGrid()

        ElseIf btnAdmin.Tag = 2 Then
            btnAdmin.Tag = 1
            btn15MinsCheck.Enabled = True
            btnAdmin.Text = "Admin (F4)"
            FrmLogin.lblAdmin.Text = "UserLogin"
            lblMsgNormalStent.Visible = False
            txtNormalStentSerialNo.Text = ""
            txtNormalStentWeight.Text = ""
            txtNormalStentWeightStep1.Text = ""
            txtNormalStentWeightStep2.Text = ""
            txtNormalStentWeightStep3.Text = ""
            txtNormalStentSerialNo.Focus()

            'Enter log for Admin LogOff
            objClsStentWeighing.InsertIntoLogFile("", "", 0, 1, 0, 0, "Admin LogOff", Nothing)
            sLogonUser = sTempLogonUser
            CoatValue = LoginCoatValue
            AdminCoatValue = 0

            SetLabelCoatValue(CoatValue)
            FillSerialNumbersGrid()

        End If

    End Sub

    Private Sub btn15MinsCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn15MinsCheck.Click
        Dim sTmpCurrentWo As String = ""
        If btn15MinsCheck.Tag = 1 Then
            CoatValue = 2
            '' Need to Initialize Weighing Cycle Steps for 15Mins Weighing
            '' Ali , 02 - Aug - 2016

            '' Read Weighing Cycle Parameter and set MAX Steps - Ali @ 29-July-2016  
            'Sql = "EXECUTE [dbo].[GetWeighingCycleParameter] '" & txtwrkordno.Text.Trim.ToString() & "', " & CoatValue
            'ds = db.selectQuery(Sql)
            'If ds.Tables(0).Rows.Count() > 0 Then
            '    MAX_NORMALWEIGHTSTEPS = ds.Tables(0).Rows(0).Item(0)
            'Else
            '    MAX_NORMALWEIGHTSTEPS = 2
            'End If
            'ResetWeightTextBoxes()
            sTmpCurrentWo = txtwrkordno.Text.Trim
            lblMsgNormalStent.Visible = False
            txtNormalStentSerialNo.Text = ""
            txtNormalStentWeight.Text = ""
            txtNormalStentWeightStep1.Text = ""
            txtNormalStentWeightStep2.Text = ""
            txtNormalStentWeightStep3.Text = ""
            txtNormalStentSerialNo.Focus()
            btnAdmin.Enabled = False
            btn15MinsCheck.Text = "Exit 15 Mins (F8)"
            btn15MinsCheck.Tag = 2
            SetLabelCoatValue(CoatValue)
            FillSerialNumbersGrid()

        ElseIf btn15MinsCheck.Tag = 2 Then

            CoatValue = LoginCoatValue
            '' Need to Initialize Weighing Cycle Steps for original Process, after exit from 15Min Weighing
            '' Ali , 02 - Aug - 2016

            '' Read Weighing Cycle Parameter and set MAX Steps - Ali @ 29-July-2016  
            'Sql = "EXECUTE [dbo].[GetWeighingCycleParameter] '" & txtwrkordno.Text.Trim.ToString() & "', " & CoatValue
            'ds = db.selectQuery(Sql)
            'If ds.Tables(0).Rows.Count() > 0 Then
            '    MAX_NORMALWEIGHTSTEPS = ds.Tables(0).Rows(0).Item(0)
            'Else
            '    MAX_NORMALWEIGHTSTEPS = 2
            'End If
            'ResetWeightTextBoxes()
            btn15MinsCheck.Tag = 1
            sStentGridWO = sTmpCurrentWo
            lblMsgNormalStent.Visible = False
            txtNormalStentSerialNo.Text = ""
            txtNormalStentWeight.Text = ""
            txtNormalStentWeightStep1.Text = ""
            txtNormalStentWeightStep2.Text = ""
            txtNormalStentWeightStep3.Text = ""
            txtNormalStentSerialNo.Focus()
            btnAdmin.Enabled = True
            btn15MinsCheck.Text = "15 Mins (F8)"
            SetLabelCoatValue(CoatValue)
            FillSerialNumbersGrid()

        End If
    End Sub

    Private Sub btnLogOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOff.Click
        If (MsgBox("Are you sure you want to log off", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            Me.Close()
            LogOff(1, "User LogOff")
        End If
    End Sub

    Private Sub SetLabelCoatValue(ByVal CoatValue As Integer)
        If CoatValue = 1 Then
            lblCoatName.Text = "Pre Coat ( " & MAX_NORMALWEIGHTSTEPS & "x )"
        ElseIf CoatValue = 2 Then
            lblCoatName.Text = "15 Mins Check ( " & MAX_NORMALWEIGHTSTEPS & "x )"
        ElseIf CoatValue = 3 Then
            lblCoatName.Text = "Post Coat ( " & MAX_NORMALWEIGHTSTEPS & "x )"
        ElseIf CoatValue = 9 Then
            lblCoatName.Text = "Admin Check"
        End If
    End Sub

    Sub LogOff(ByVal value As Integer, ByVal remarks As String)
        Try
            'Enter log for User LogOff
            objClsStentWeighing.InsertIntoLogFile("", "", 0, value, 0, 0, remarks, Nothing)

            objClsStentWeighing.ClosePort()
            ClearControls()

            'change machine status to 'Not in Use'
            Sql = "update machines set useby ='' where machineid ='" & MachineID & "'"
            db.updateQuery(Sql)

            Application.Exit()
            'Me.Close()
            'FrmLogin.Close()

            'FrmLogin.txtUserID.Text = ""
            'FrmLogin.txtPassword.Text = ""
            'FrmLogin.chkPreCoat.Checked = True
            'FrmLogin.chkPostCoat.Checked = False
            'FrmLogin.txtUserID.Focus()
            'FrmLogin.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function sReturnActualWeight(ByVal sRecvdData As String) As String
        Dim nMgPosition As Integer
        nMgPosition = 0
        sReturnActualWeight = ""
        If Len(Trim(sRecvdData.Trim)) > 0 Then
            nMgPosition = InStr(Trim(UCase(sRecvdData)), " MG")
            If nMgPosition > 0 Then
                ' Ali, 22nd Sep 2011
                'sReturnActualWeight = Trim(Mid((Trim(sRecvdData)), 1, (nMgPosition - 1)))
                sReturnActualWeight = Trim(Mid((Trim(sRecvdData.Trim)), 1, (nMgPosition - 1)))
            Else
                ' sReturnActualWeight = ""    Ali, 20-Sep-2011
                sReturnActualWeight = ""    'Trim(sRecvdData)
            End If
        End If
    End Function

    Private Sub SetTextBackground()
        If bDataReadStatus = False Then
            If nCurrentTAB = 2 Then
                txtStandardWeight.BackColor = Color.LightGreen
                lblMsgStandardWeight.Visible = True
                lblMsgStandardWeight.Text = "Place the stent and press PRINT."
            ElseIf nCurrentTAB = 3 Then
                txtNormalStentWeight.BackColor = Color.LightGreen
                lblMsgNormalStent.Visible = True
                lblMsgNormalStent.Text = "Place the stent and press PRINT."
            End If
        Else
            If nCurrentTAB = 2 Then
                txtStandardWeight.BackColor = Color.Orange
                lblMsgStandardWeight.Visible = True
                lblMsgStandardWeight.Text = "Press PRINT on ZERO weight."
            ElseIf nCurrentTAB = 3 Then
                txtNormalStentWeight.BackColor = Color.Orange
                lblMsgNormalStent.Visible = True
                lblMsgNormalStent.Text = "Press PRINT on ZERO weight."
            End If
        End If

        lblMsgStandardWeight.Refresh()
        lblMsgNormalStent.Refresh()
        txtStandardWeight.Refresh()
        txtNormalStentWeight.Refresh()
    End Sub

    Private Sub btnAdmin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnAdmin.KeyDown
        If e.KeyCode = 115 Then
            Call btnAdmin_Click(btnAdmin, e)
        End If
    End Sub

    Private Sub btnNextWO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnNextWO.KeyDown
        If e.KeyCode = 117 Then
            Call btnNextWO_Click(btnNextWO, e)
        End If
    End Sub

    Private Sub btnMachineDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnMachineDetails.KeyDown
        If e.KeyCode = 118 Then
            Call btnMachineDetails_Click(btnMachineDetails, e)
        End If
    End Sub

    Private Sub btn15MinsCheck_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btn15MinsCheck.KeyDown
        If e.KeyCode = 119 Then
            Call btn15MinsCheck_Click(btn15MinsCheck, e)
        End If
    End Sub

    Private Sub btnLogOff_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnLogOff.KeyDown
        If e.KeyCode = 120 Then
            Call btnLogOff_Click(btnLogOff, e)
        End If
    End Sub

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        DisableTimers()
        DoInternalAdjustmentProcess()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ClearControls()
    End Sub

    Private Sub timerInternalAdjust_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timerInternalAdjust.Tick
        ' This code is for Internal Adjustment
        btnNextWO.Enabled = False
        btnMachineDetails.Enabled = False
        btnLogOff.Enabled = False

        Try
            txtInternalAdjust.ForeColor = Color.Blue
            txtInternalAdjust.Text = sIntAdjustmentStatus
            nTotBytes = 40
        Catch ex As Exception
            txtInternalAdjust.Text = txtInternalAdjust.Text & vbCrLf & vbCrLf & ex.Message
        End Try

        If Len(Trim(txtInternalAdjust.Text)) = 0 Then
            lblMsgWaiting.Text = "Waiting for the response from machine...."
        Else
            lblMsgWaiting.Text = "Reading data from the machine....."
        End If
        txtInternalAdjust.Refresh()

        Try
            If InStr(Trim(UCase(txtInternalAdjust.Text)), "DONE") Then
                lblMsgWaiting.Text = "Data Retrieval Completed."
                btnContinue.Enabled = True
                btnNextWO.Enabled = True
                btnLogOff.Enabled = True
                DisableTimers()
                sequenceNo = sequenceNo + 1
                objClsStentWeighing.InsertIntoLogFile(sLogFilePath, Trim(txtwrkordno.Text), 1, 1, 0, 0, "Adjustment Done", StartInternalAdjustDateTime)
                objClsStentWeighing.InsertIntoLogFile(sLogFilePath, Trim(txtwrkordno.Text), 1, 2, 0, 0, "Adjustment Done", Nothing)

            ElseIf InStr(Trim(UCase(txtInternalAdjust.Text)), "ABORT") Then
                lblMsgWaiting.Text = "Data Retrieval Completed."
                btnContinue.Enabled = False
                sequenceNo = sequenceNo + 1
                objClsStentWeighing.InsertIntoLogFile(sLogFilePath, Trim(txtwrkordno.Text), 1, 1, 0, 0, "Adjustment Abort", StartInternalAdjustDateTime)
                objClsStentWeighing.InsertIntoLogFile(sLogFilePath, Trim(txtwrkordno.Text), 1, 2, 0, 0, "Adjustment Abort", Nothing)
                btnNextWO.Enabled = True
                btnLogOff.Enabled = True
                DisableTimers()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtInternalAdjust.ForeColor = Color.Blue
    End Sub

    Private Sub timerStandardWeight_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timerStandardWeight.Tick
        ' This code is for Standard Weight
        Try
            'timerStandardWeight.Enabled = False
            SetTextBackground()

            txtStandardWeight.Text = sReceivedWeightData.Trim
            txtStandardWeight.Refresh()

            Try
                If InStr(Trim(UCase(txtStandardWeight.Text)), " MG") Then
                    timerStandardWeight.Enabled = False
                    DoStandardWeightProcess(sReceivedWeightData)
                    timerStandardWeight.Enabled = True
                    sReceivedWeightData = ""
                End If
            Catch
            End Try
            'txtStandardWeight.Text = sReturnActualWeight(sReceivedWeightData)
            ' sReceivedWeightData = ""

            'If Len((txtStandardWeight.Text.Trim)) > 0 Then
            '    'timerStandardWeight.Enabled = False
            '    DoStandardWeightProcess()
            '    'timerStandardWeight.Enabled = True
            'End If

        Catch ex As Exception
            txtStandardWeight.Text = txtStandardWeight.Text & vbCrLf & vbCrLf & ex.Message
        End Try
    End Sub

    Private Sub timerNormalStent_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timerNormalStent.Tick
        ' This code is for Normal Stent Weight
        Try
            SetTextBackground()
            txtNormalStentWeight.Text = sReceivedWeightData.Trim      ' sReturnActualWeight(sReceivedWeightData)
            txtNormalStentWeight.Refresh()

            Try
                If InStr(Trim(UCase(txtNormalStentWeight.Text)), " MG") Then
                    timerNormalStent.Enabled = False
                    DoNormalStentProcess(sReceivedWeightData)
                    timerNormalStent.Enabled = True
                    sReceivedWeightData = ""
                End If
            Catch ex As Exception

            End Try

            'If Len(Trim(txtNormalStentWeight.Text)) > 0 Then
            '    timerNormalStent.Enabled = False
            '    DoNormalStentProcess()
            '    timerNormalStent.Enabled = True
            'End If
        Catch ex As Exception
            txtNormalStentWeight.Text = txtNormalStentWeight.Text & vbCrLf & vbCrLf & ex.Message
        End Try
    End Sub

    Private Sub timerAutoLogoff_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerAutoLogoff.Tick
        LogOff(2, "Auto LogOff")
        MsgBox("Logged off automatically, Since the system was idle")
    End Sub

    Private Sub pBoxKeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pBoxKeyboard.Click
        p.StartInfo.FileName = "osk"
        p.Start()
    End Sub

    Private Sub txtInternalAdjust_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInternalAdjust.TextChanged

    End Sub

    Private Sub moRS232_CommEvent(ByVal source As Rs232, ByVal Mask As Rs232.EventMasks) Handles moRS232.CommEvent

        Debug.Assert(Me.InvokeRequired = False)

        'Dim iPnt As Int32, sBuf As String, Buffer() As Byte
        Debug.Assert(Me.InvokeRequired = False)
        If nCurrentTAB = 2 Then
            txtStandardWeight.Text = source.InputStreamString
        ElseIf nCurrentTAB = 3 Then
            txtNormalStentWeight.Text = source.InputStreamString
        End If
    End Sub
End Class