Imports System.IO.Ports
Imports StentWeighing.StentWeighingMain
Imports system.IO

Public Class FrmMachineDetails
    Inherits System.Windows.Forms.Form

    Private miComPort As Integer
    Private WithEvents moRS232 As Rs232
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents ddlPorts As System.Windows.Forms.ComboBox
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents txtMachineID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblSerialNo As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtSerialNo As System.Windows.Forms.TextBox
    Friend WithEvents SrlPorts As System.IO.Ports.SerialPort
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Private mlTicks As Long
    Private Delegate Sub CommEventUpdate(ByVal source As Rs232, ByVal mask As Rs232.EventMasks)
    Dim strMachineName, strMachineSerial, strMachineID, strMachinePort, strSerialNo As String
    Dim sDataParity, sDataBit, sStopBit, sXonXoff As String
    Friend WithEvents txtTimeOut As System.Windows.Forms.TextBox
    Friend WithEvents txtBaudRate As System.Windows.Forms.TextBox
    Friend WithEvents lblTimeOut As System.Windows.Forms.Label
    Friend WithEvents lblBaudRate As System.Windows.Forms.Label
    Dim objClsStentWeighing As New clsStentWeighing

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    ''Form overrides dispose to clean up the component list.
    'Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    '    If disposing Then
    '        If Not (components Is Nothing) Then
    '            components.Dispose()
    '        End If
    '    End If
    '    MyBase.Dispose(disposing)
    'End Sub
    Private components As System.ComponentModel.IContainer


    'Required by the Windows Form Designer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTimeOut = New System.Windows.Forms.TextBox
        Me.txtBaudRate = New System.Windows.Forms.TextBox
        Me.lblTimeOut = New System.Windows.Forms.Label
        Me.lblBaudRate = New System.Windows.Forms.Label
        Me.ddlPorts = New System.Windows.Forms.ComboBox
        Me.lblPort = New System.Windows.Forms.Label
        Me.txtMachineID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblSerialNo = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.txtSerialNo = New System.Windows.Forms.TextBox
        Me.SrlPorts = New System.IO.Ports.SerialPort(Me.components)
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.txtTimeOut)
        Me.GroupBox1.Controls.Add(Me.txtBaudRate)
        Me.GroupBox1.Controls.Add(Me.lblTimeOut)
        Me.GroupBox1.Controls.Add(Me.lblBaudRate)
        Me.GroupBox1.Controls.Add(Me.ddlPorts)
        Me.GroupBox1.Controls.Add(Me.lblPort)
        Me.GroupBox1.Controls.Add(Me.txtMachineID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.lblSerialNo)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.txtSerialNo)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(388, 250)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'txtTimeOut
        '
        Me.txtTimeOut.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTimeOut.Location = New System.Drawing.Point(144, 134)
        Me.txtTimeOut.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTimeOut.MaxLength = 8
        Me.txtTimeOut.Name = "txtTimeOut"
        Me.txtTimeOut.Size = New System.Drawing.Size(180, 21)
        Me.txtTimeOut.TabIndex = 4
        '
        'txtBaudRate
        '
        Me.txtBaudRate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBaudRate.Location = New System.Drawing.Point(144, 97)
        Me.txtBaudRate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBaudRate.MaxLength = 5
        Me.txtBaudRate.Name = "txtBaudRate"
        Me.txtBaudRate.Size = New System.Drawing.Size(180, 21)
        Me.txtBaudRate.TabIndex = 3
        '
        'lblTimeOut
        '
        Me.lblTimeOut.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTimeOut.AutoSize = True
        Me.lblTimeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTimeOut.Location = New System.Drawing.Point(63, 135)
        Me.lblTimeOut.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimeOut.Name = "lblTimeOut"
        Me.lblTimeOut.Size = New System.Drawing.Size(70, 16)
        Me.lblTimeOut.TabIndex = 7
        Me.lblTimeOut.Text = "Time Out"
        Me.lblTimeOut.UseWaitCursor = True
        '
        'lblBaudRate
        '
        Me.lblBaudRate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBaudRate.AutoSize = True
        Me.lblBaudRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblBaudRate.Location = New System.Drawing.Point(55, 98)
        Me.lblBaudRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBaudRate.Name = "lblBaudRate"
        Me.lblBaudRate.Size = New System.Drawing.Size(81, 16)
        Me.lblBaudRate.TabIndex = 6
        Me.lblBaudRate.Text = "Baud Rate"
        Me.lblBaudRate.UseWaitCursor = True
        '
        'ddlPorts
        '
        Me.ddlPorts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ddlPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlPorts.FormattingEnabled = True
        Me.ddlPorts.Location = New System.Drawing.Point(144, 171)
        Me.ddlPorts.Name = "ddlPorts"
        Me.ddlPorts.Size = New System.Drawing.Size(180, 21)
        Me.ddlPorts.TabIndex = 5
        '
        'lblPort
        '
        Me.lblPort.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPort.AutoSize = True
        Me.lblPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblPort.Location = New System.Drawing.Point(76, 172)
        Me.lblPort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(60, 16)
        Me.lblPort.TabIndex = 4
        Me.lblPort.Text = "Port No"
        Me.lblPort.UseWaitCursor = True
        '
        'txtMachineID
        '
        Me.txtMachineID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMachineID.Location = New System.Drawing.Point(144, 23)
        Me.txtMachineID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMachineID.MaxLength = 20
        Me.txtMachineID.Name = "txtMachineID"
        Me.txtMachineID.Size = New System.Drawing.Size(180, 21)
        Me.txtMachineID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(51, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Machine ID"
        Me.Label1.UseWaitCursor = True
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtName.Location = New System.Drawing.Point(144, 60)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.MaxLength = 80
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(180, 21)
        Me.txtName.TabIndex = 2
        '
        'lblSerialNo
        '
        Me.lblSerialNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSerialNo.AutoSize = True
        Me.lblSerialNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblSerialNo.Location = New System.Drawing.Point(63, 209)
        Me.lblSerialNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSerialNo.Name = "lblSerialNo"
        Me.lblSerialNo.Size = New System.Drawing.Size(73, 16)
        Me.lblSerialNo.TabIndex = 0
        Me.lblSerialNo.Text = "Serial No"
        '
        'lblName
        '
        Me.lblName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblName.Location = New System.Drawing.Point(87, 61)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 16)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        Me.lblName.UseWaitCursor = True
        '
        'txtSerialNo
        '
        Me.txtSerialNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSerialNo.Location = New System.Drawing.Point(144, 208)
        Me.txtSerialNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSerialNo.MaxLength = 50
        Me.txtSerialNo.Name = "txtSerialNo"
        Me.txtSerialNo.ReadOnly = True
        Me.txtSerialNo.Size = New System.Drawing.Size(180, 21)
        Me.txtSerialNo.TabIndex = 6
        Me.txtSerialNo.Text = " "
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnClose.Location = New System.Drawing.Point(231, 286)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 25)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSave.Location = New System.Drawing.Point(148, 286)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'FrmMachineDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(438, 328)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmMachineDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Machine Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim sPortList As String() = SrlPorts.GetPortNames()
            Dim i As Integer

            txtMachineID.Focus()
            ddlPorts.Items.Clear()
            For i = 0 To sPortList.Length - 1
                ddlPorts.Items.Add(sPortList(i))
            Next
            ddlPorts.Sorted = True
            SystemName = Environment.MachineName.ToString()
            ClearControls()

            Sql = "select machineid,name,baudrate,timeout,portno,serialno,autologoffmins,dataparity,databit,stopbit,xonxoff from machines where hostname = '" & SystemName & "' and status=1"
            ds = db.selectQuery(Sql)
            If ds.Tables(0).Rows.Count() > 0 Then
                txtMachineID.Text = ds.Tables(0).Rows(0).Item("machineid")
                txtName.Text = ds.Tables(0).Rows(0).Item("name")
                txtBaudRate.Text = ds.Tables(0).Rows(0).Item("baudrate")
                txtTimeOut.Text = ds.Tables(0).Rows(0).Item("timeout")
                ddlPorts.SelectedItem = "COM" & ds.Tables(0).Rows(0).Item("portno")
                txtSerialNo.Text = ds.Tables(0).Rows(0).Item("serialno")
                txtMachineID.ReadOnly = True
            Else
                txtBaudRate.Text = BAUDRATE
                txtTimeOut.Text = TIMEOUT
                ddlPorts.SelectedItem = "COM" & PORTNO
                txtMachineID.ReadOnly = False
                txtMachineID.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            objClsStentWeighing.ClosePort()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            objClsStentWeighing.ClosePort()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim sPortNum As String = "1"

        Try
            If txtMachineID.Text = "" Then
                MsgBox("Enter Machine ID", MsgBoxStyle.Information)
                txtMachineID.Focus()

            ElseIf txtName.Text = "" Then
                MsgBox("Enter Machine Name", MsgBoxStyle.Information)
                txtName.Focus()

            ElseIf txtBaudRate.Text = "" Then
                MsgBox("Enter Baud Rate", MsgBoxStyle.Information)
                txtBaudRate.Focus()

            ElseIf Not IsNumeric(txtBaudRate.Text) Then
                MsgBox("Enter Numeric Values for Baud Rate", MsgBoxStyle.Information)
                txtBaudRate.Text = ""
                txtBaudRate.Focus()

            ElseIf txtTimeOut.Text = "" Then
                MsgBox("Enter Time Out", MsgBoxStyle.Information)
                txtTimeOut.Focus()

            ElseIf Not IsNumeric(txtTimeOut.Text) Then
                MsgBox("Enter Numeric Values for Time Out", MsgBoxStyle.Information)
                txtTimeOut.Text = ""
                txtTimeOut.Focus()

            ElseIf txtMachineID.Text <> "" And txtName.Text <> "" And txtBaudRate.Text <> "" And txtTimeOut.Text <> "" Then

                strMachinePort = ddlPorts.SelectedItem.ToString
                If InStr(strMachinePort, "COM") > 0 Then
                    sPortNum = Mid(strMachinePort, InStr(strMachinePort, "COM") + 3, Len(strMachinePort) - 3)
                End If
                strMachineSerial = txtSerialNo.Text.Trim()
                strMachineName = txtName.Text.Trim()
                strMachineID = txtMachineID.Text.Trim()
                BAUDRATE = CInt(txtBaudRate.Text.Trim())
                TIMEOUT = CInt(txtTimeOut.Text.Trim())
                SystemName = Environment.MachineName.ToString()

                If txtSerialNo.Text.Trim.Length > 0 Then

                    If txtMachineID.ReadOnly = True Then
                        Sql = "update machines set name =  '" & strMachineName & "', baudrate = '" & BAUDRATE & "' , timeout = '" & TIMEOUT & "', portno = '" & sPortNum & "' where hostname = '" & SystemName & "'"
                        db.updateQuery(Sql)
                        WritetoINIFile(BAUDRATE, TIMEOUT, sPortNum, DATAPARITY, DATABIT, STOPBIT, XONXOFF)
                        MsgBox("Machine details updated successfuly.", MsgBoxStyle.Information)
                    End If
                Else
                    objClsStentWeighing.ClosePort()
                    objClsStentWeighing.OpenPort(CInt(txtBaudRate.Text.Trim), CInt(txtTimeOut.Text.Trim), sPortNum)
                    txtSerialNo.Text = objClsStentWeighing.GetSerialNo(SerialNoBytesRead)

                    If Len(Trim(txtSerialNo.Text)) > 0 Then
                        Sql = "select machineid,serialno from machines where hostname = '" & SystemName & "' or serialno = '" & txtSerialNo.Text & "'"
                        ds = db.selectQuery(Sql)
                        If ds.Tables(0).Rows.Count() > 0 Then
                            MsgBox("This computer or weighing machine is already registered. Please try with another.")
                            objClsStentWeighing.ClosePort()
                            DisableControls()
                            Exit Sub
                        Else
                            Sql = "insert into machines (machineid, name, serialno, hostname, baudrate, timeout, portno, status, useby) values('" & strMachineID & "', '" & strMachineName & "', '" & txtSerialNo.Text.Trim & "', '" & SystemName & "', '" & BAUDRATE & "', '" & TIMEOUT & "', '" & sPortNum & "', 1, '')"
                            db.insertQuery(Sql)
                            WritetoINIFile(BAUDRATE, TIMEOUT, sPortNum, DATAPARITY, DATABIT, STOPBIT, XONXOFF)
                            MsgBox("New machine registered successfuly", MsgBoxStyle.Information)
                            txtMachineID.ReadOnly = True
                        End If
                    Else
                        MsgBox("Cannot connect to machine. Please try again.")
                    End If

                    objClsStentWeighing.ClosePort()

                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub WritetoINIFile(ByVal Baudrate As String, ByVal TimeOut As String, ByVal PortNo As String, ByVal DataParity As String, ByVal DataBit As String, ByVal StopBit As String, ByVal XonXoff As String)
        Try
            Dim INIPath = Path.Combine(Directory.GetCurrentDirectory, iniFileName)
            INIWrite(INIPath, "RS232Config", "BaudRate", Baudrate)
            INIWrite(INIPath, "RS232Config", "TimeOut", TimeOut)
            INIWrite(INIPath, "RS232Config", "PortNo", PortNo)
            INIWrite(INIPath, "RS232Config", "DataParity", DataParity)
            INIWrite(INIPath, "RS232Config", "DataBit", DataBit)
            INIWrite(INIPath, "RS232Config", "StopBit", StopBit)
            INIWrite(INIPath, "RS232Config", "XonXoff", XonXoff)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearControls()
        Try
            ddlPorts.SelectedIndex = 0
            txtSerialNo.Clear()
            txtMachineID.Clear()
            txtName.Clear()
            objClsStentWeighing.ClosePort()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EnableControls()
        txtBaudRate.Enabled = True
        txtMachineID.Enabled = True
        txtName.Enabled = True
        txtSerialNo.Enabled = True
        txtTimeOut.Enabled = True
        ddlPorts.Enabled = True
        btnSave.Enabled = True
    End Sub

    Private Sub DisableControls()
        txtBaudRate.Enabled = False
        txtMachineID.Enabled = False
        txtName.Enabled = False
        txtSerialNo.Enabled = False
        txtTimeOut.Enabled = False
        ddlPorts.Enabled = False
        btnSave.Enabled = False
    End Sub

End Class

