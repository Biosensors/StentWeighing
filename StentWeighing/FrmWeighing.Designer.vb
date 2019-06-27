<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWeighing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWeighing))
        Me.gboxWODetails = New System.Windows.Forms.GroupBox
        Me.lblInternalAdj = New System.Windows.Forms.Label
        Me.lblCoatName = New System.Windows.Forms.Label
        Me.lblBalanceQty = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblNormalStent = New System.Windows.Forms.Label
        Me.lblStdStent = New System.Windows.Forms.Label
        Me.txtwrkordno = New System.Windows.Forms.TextBox
        Me.lblItem = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblQty = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblBatch = New System.Windows.Forms.Label
        Me.btnNextWO = New System.Windows.Forms.Button
        Me.btnMachineDetails = New System.Windows.Forms.Button
        Me.btn15MinsCheck = New System.Windows.Forms.Button
        Me.gboxMachineDetails = New System.Windows.Forms.GroupBox
        Me.txtColor = New System.Windows.Forms.TextBox
        Me.txtSerialNumber = New System.Windows.Forms.TextBox
        Me.txtMachineName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnAdmin = New System.Windows.Forms.Button
        Me.btnLogOff = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.timerInternalAdjust = New System.Windows.Forms.Timer(Me.components)
        Me.timerStandardWeight = New System.Windows.Forms.Timer(Me.components)
        Me.timerNormalStent = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.gboxStentDetails = New System.Windows.Forms.GroupBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.gboxSerialNos = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.tabStentWeight = New System.Windows.Forms.TabControl
        Me.tabInternalAdjust = New System.Windows.Forms.TabPage
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnContinue = New System.Windows.Forms.Button
        Me.lblMsgWaiting = New System.Windows.Forms.Label
        Me.lblMsgInternalAdjust = New System.Windows.Forms.Label
        Me.txtInternalAdjust = New System.Windows.Forms.TextBox
        Me.tabStandardWeight = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblMsgStandardWeight = New System.Windows.Forms.Label
        Me.txtStandardWeight = New System.Windows.Forms.TextBox
        Me.txtStandardWeightStep3 = New System.Windows.Forms.TextBox
        Me.txtStandardWeightStep2 = New System.Windows.Forms.TextBox
        Me.txtStandardWeightStep1 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtStandardStentSerialNo = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgStandardStentSerials = New System.Windows.Forms.DataGrid
        Me.tabNormalStent = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.lblMsgNormalStent = New System.Windows.Forms.Label
        Me.txtNormalStentWeight = New System.Windows.Forms.TextBox
        Me.txtNormalStentWeightStep3 = New System.Windows.Forms.TextBox
        Me.txtNormalStentWeightStep2 = New System.Windows.Forms.TextBox
        Me.txtNormalStentWeightStep1 = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.txtNormalStentSerialNo = New System.Windows.Forms.TextBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dgNormalStentSerials = New System.Windows.Forms.DataGrid
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.timerAutoLogoff = New System.Windows.Forms.Timer(Me.components)
        Me.pBoxKeyboard = New System.Windows.Forms.PictureBox
        Me.gboxWODetails.SuspendLayout()
        Me.gboxMachineDetails.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gboxStentDetails.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.tabStentWeight.SuspendLayout()
        Me.tabInternalAdjust.SuspendLayout()
        Me.tabStandardWeight.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgStandardStentSerials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNormalStent.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgNormalStentSerials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.pBoxKeyboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gboxWODetails
        '
        Me.gboxWODetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gboxWODetails.Controls.Add(Me.lblInternalAdj)
        Me.gboxWODetails.Controls.Add(Me.lblCoatName)
        Me.gboxWODetails.Controls.Add(Me.lblBalanceQty)
        Me.gboxWODetails.Controls.Add(Me.Label13)
        Me.gboxWODetails.Controls.Add(Me.lblNormalStent)
        Me.gboxWODetails.Controls.Add(Me.lblStdStent)
        Me.gboxWODetails.Controls.Add(Me.txtwrkordno)
        Me.gboxWODetails.Controls.Add(Me.lblItem)
        Me.gboxWODetails.Controls.Add(Me.Label5)
        Me.gboxWODetails.Controls.Add(Me.lblQty)
        Me.gboxWODetails.Controls.Add(Me.Label4)
        Me.gboxWODetails.Controls.Add(Me.Label1)
        Me.gboxWODetails.Controls.Add(Me.Label3)
        Me.gboxWODetails.Controls.Add(Me.lblBatch)
        Me.gboxWODetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxWODetails.ForeColor = System.Drawing.Color.Black
        Me.gboxWODetails.Location = New System.Drawing.Point(12, 78)
        Me.gboxWODetails.Name = "gboxWODetails"
        Me.gboxWODetails.Size = New System.Drawing.Size(621, 158)
        Me.gboxWODetails.TabIndex = 14
        Me.gboxWODetails.TabStop = False
        Me.gboxWODetails.Text = "Work Order Details"
        '
        'lblInternalAdj
        '
        Me.lblInternalAdj.AutoSize = True
        Me.lblInternalAdj.BackColor = System.Drawing.SystemColors.Control
        Me.lblInternalAdj.ForeColor = System.Drawing.Color.Black
        Me.lblInternalAdj.Location = New System.Drawing.Point(445, 25)
        Me.lblInternalAdj.Name = "lblInternalAdj"
        Me.lblInternalAdj.Size = New System.Drawing.Size(155, 16)
        Me.lblInternalAdj.TabIndex = 19
        Me.lblInternalAdj.Text = "1. Internal Adjustment"
        '
        'lblCoatName
        '
        Me.lblCoatName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCoatName.AutoSize = True
        Me.lblCoatName.BackColor = System.Drawing.Color.Transparent
        Me.lblCoatName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoatName.ForeColor = System.Drawing.Color.Indigo
        Me.lblCoatName.Location = New System.Drawing.Point(409, 121)
        Me.lblCoatName.Name = "lblCoatName"
        Me.lblCoatName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCoatName.Size = New System.Drawing.Size(132, 26)
        Me.lblCoatName.TabIndex = 18
        Me.lblCoatName.Text = "Coat Name"
        Me.lblCoatName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBalanceQty
        '
        Me.lblBalanceQty.AutoSize = True
        Me.lblBalanceQty.Enabled = False
        Me.lblBalanceQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalanceQty.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblBalanceQty.Location = New System.Drawing.Point(331, 124)
        Me.lblBalanceQty.Name = "lblBalanceQty"
        Me.lblBalanceQty.Size = New System.Drawing.Size(71, 16)
        Me.lblBalanceQty.TabIndex = 17
        Me.lblBalanceQty.Text = "lblBalQty"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(237, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 16)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Balance Qty"
        '
        'lblNormalStent
        '
        Me.lblNormalStent.AutoSize = True
        Me.lblNormalStent.ForeColor = System.Drawing.Color.Black
        Me.lblNormalStent.Location = New System.Drawing.Point(445, 90)
        Me.lblNormalStent.Name = "lblNormalStent"
        Me.lblNormalStent.Size = New System.Drawing.Size(113, 16)
        Me.lblNormalStent.TabIndex = 15
        Me.lblNormalStent.Text = "3. Normal Stent"
        '
        'lblStdStent
        '
        Me.lblStdStent.AutoSize = True
        Me.lblStdStent.ForeColor = System.Drawing.Color.Black
        Me.lblStdStent.Location = New System.Drawing.Point(445, 59)
        Me.lblStdStent.Name = "lblStdStent"
        Me.lblStdStent.Size = New System.Drawing.Size(139, 16)
        Me.lblStdStent.TabIndex = 14
        Me.lblStdStent.Text = "2. Standard Weight"
        '
        'txtwrkordno
        '
        Me.txtwrkordno.Location = New System.Drawing.Point(127, 36)
        Me.txtwrkordno.MaxLength = 12
        Me.txtwrkordno.Name = "txtwrkordno"
        Me.txtwrkordno.Size = New System.Drawing.Size(156, 22)
        Me.txtwrkordno.TabIndex = 3
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Enabled = False
        Me.lblItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblItem.Location = New System.Drawing.Point(124, 69)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(54, 16)
        Me.lblItem.TabIndex = 8
        Me.lblItem.Text = "lblItem"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Work Order No"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Enabled = False
        Me.lblQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblQty.Location = New System.Drawing.Point(124, 124)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(91, 16)
        Me.lblQty.TabIndex = 11
        Me.lblQty.Text = "lblActualQty"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(45, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Actual Qty"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(86, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(76, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Batch"
        '
        'lblBatch
        '
        Me.lblBatch.AutoSize = True
        Me.lblBatch.Enabled = False
        Me.lblBatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatch.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblBatch.Location = New System.Drawing.Point(124, 97)
        Me.lblBatch.Name = "lblBatch"
        Me.lblBatch.Size = New System.Drawing.Size(64, 16)
        Me.lblBatch.TabIndex = 10
        Me.lblBatch.Text = "lblBatch"
        '
        'btnNextWO
        '
        Me.btnNextWO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNextWO.BackColor = System.Drawing.Color.Azure
        Me.btnNextWO.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextWO.ForeColor = System.Drawing.Color.Red
        Me.btnNextWO.Location = New System.Drawing.Point(4, 51)
        Me.btnNextWO.Name = "btnNextWO"
        Me.btnNextWO.Size = New System.Drawing.Size(110, 35)
        Me.btnNextWO.TabIndex = 10
        Me.btnNextWO.Text = "Next WO (F6)"
        Me.btnNextWO.UseVisualStyleBackColor = False
        '
        'btnMachineDetails
        '
        Me.btnMachineDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMachineDetails.BackColor = System.Drawing.Color.Azure
        Me.btnMachineDetails.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMachineDetails.ForeColor = System.Drawing.Color.Red
        Me.btnMachineDetails.Location = New System.Drawing.Point(4, 10)
        Me.btnMachineDetails.Name = "btnMachineDetails"
        Me.btnMachineDetails.Size = New System.Drawing.Size(110, 35)
        Me.btnMachineDetails.TabIndex = 11
        Me.btnMachineDetails.Text = "Machine (F7)"
        Me.btnMachineDetails.UseVisualStyleBackColor = False
        '
        'btn15MinsCheck
        '
        Me.btn15MinsCheck.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn15MinsCheck.BackColor = System.Drawing.Color.Azure
        Me.btn15MinsCheck.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn15MinsCheck.ForeColor = System.Drawing.Color.Red
        Me.btn15MinsCheck.Location = New System.Drawing.Point(3, 133)
        Me.btn15MinsCheck.Name = "btn15MinsCheck"
        Me.btn15MinsCheck.Size = New System.Drawing.Size(110, 35)
        Me.btn15MinsCheck.TabIndex = 12
        Me.btn15MinsCheck.Text = "15 Mins (F8)"
        Me.btn15MinsCheck.UseVisualStyleBackColor = False
        '
        'gboxMachineDetails
        '
        Me.gboxMachineDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gboxMachineDetails.Controls.Add(Me.txtColor)
        Me.gboxMachineDetails.Controls.Add(Me.txtSerialNumber)
        Me.gboxMachineDetails.Controls.Add(Me.txtMachineName)
        Me.gboxMachineDetails.Controls.Add(Me.Label6)
        Me.gboxMachineDetails.Controls.Add(Me.Label7)
        Me.gboxMachineDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gboxMachineDetails.ForeColor = System.Drawing.Color.Black
        Me.gboxMachineDetails.Location = New System.Drawing.Point(12, 8)
        Me.gboxMachineDetails.Name = "gboxMachineDetails"
        Me.gboxMachineDetails.Size = New System.Drawing.Size(558, 65)
        Me.gboxMachineDetails.TabIndex = 21
        Me.gboxMachineDetails.TabStop = False
        Me.gboxMachineDetails.Text = "Weighing Machine Details"
        '
        'txtColor
        '
        Me.txtColor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtColor.BackColor = System.Drawing.Color.Red
        Me.txtColor.Location = New System.Drawing.Point(263, 34)
        Me.txtColor.Multiline = True
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(18, 18)
        Me.txtColor.TabIndex = 4
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSerialNumber.Location = New System.Drawing.Point(406, 32)
        Me.txtSerialNumber.MaxLength = 50
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.ReadOnly = True
        Me.txtSerialNumber.Size = New System.Drawing.Size(135, 22)
        Me.txtSerialNumber.TabIndex = 2
        '
        'txtMachineName
        '
        Me.txtMachineName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMachineName.Location = New System.Drawing.Point(127, 32)
        Me.txtMachineName.MaxLength = 80
        Me.txtMachineName.Name = "txtMachineName"
        Me.txtMachineName.ReadOnly = True
        Me.txtMachineName.Size = New System.Drawing.Size(135, 22)
        Me.txtMachineName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Machine Name"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(295, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Serial Number"
        '
        'btnAdmin
        '
        Me.btnAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdmin.BackColor = System.Drawing.Color.Azure
        Me.btnAdmin.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.Red
        Me.btnAdmin.Location = New System.Drawing.Point(3, 92)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(110, 35)
        Me.btnAdmin.TabIndex = 9
        Me.btnAdmin.Text = "Admin (F4)"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnLogOff
        '
        Me.btnLogOff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogOff.BackColor = System.Drawing.Color.Azure
        Me.btnLogOff.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOff.ForeColor = System.Drawing.Color.Red
        Me.btnLogOff.Location = New System.Drawing.Point(3, 174)
        Me.btnLogOff.Name = "btnLogOff"
        Me.btnLogOff.Size = New System.Drawing.Size(110, 35)
        Me.btnLogOff.TabIndex = 13
        Me.btnLogOff.Text = "Log Off (F9)"
        Me.btnLogOff.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(29, 239)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(416, 16)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Please take the stent out and place it again."
        Me.Label18.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(371, 73)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 16)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Step 3"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(200, 73)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 16)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "Step 2"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(26, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 16)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "Step 1"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(26, 35)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 16)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "Stent Serial"
        '
        'timerInternalAdjust
        '
        Me.timerInternalAdjust.Interval = 2000
        '
        'timerStandardWeight
        '
        Me.timerStandardWeight.Interval = 2000
        '
        'timerNormalStent
        '
        Me.timerNormalStent.Interval = 2000
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnAdmin)
        Me.Panel1.Controls.Add(Me.btnLogOff)
        Me.Panel1.Controls.Add(Me.btnMachineDetails)
        Me.Panel1.Controls.Add(Me.btn15MinsCheck)
        Me.Panel1.Controls.Add(Me.btnNextWO)
        Me.Panel1.Location = New System.Drawing.Point(639, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(121, 220)
        Me.Panel1.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(142, 16)
        Me.Label17.TabIndex = 23
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(317, 62)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 16)
        Me.Label16.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(317, 103)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 16)
        Me.Label15.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(317, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(20, 16)
        Me.Label14.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(340, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 33
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(23, 8)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(233, 15)
        Me.Label29.TabIndex = 11
        Me.Label29.Text = "Waiting for the response from machine ...."
        Me.Label29.Visible = False
        '
        'gboxStentDetails
        '
        Me.gboxStentDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gboxStentDetails.Controls.Add(Me.Label30)
        Me.gboxStentDetails.Controls.Add(Me.Label31)
        Me.gboxStentDetails.Controls.Add(Me.Label32)
        Me.gboxStentDetails.Controls.Add(Me.Label33)
        Me.gboxStentDetails.Controls.Add(Me.Label34)
        Me.gboxStentDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gboxStentDetails.ForeColor = System.Drawing.Color.Black
        Me.gboxStentDetails.Location = New System.Drawing.Point(263, 10)
        Me.gboxStentDetails.Name = "gboxStentDetails"
        Me.gboxStentDetails.Size = New System.Drawing.Size(533, 239)
        Me.gboxStentDetails.TabIndex = 18
        Me.gboxStentDetails.TabStop = False
        Me.gboxStentDetails.Text = "Standard Weight Details"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(358, 36)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(52, 16)
        Me.Label30.TabIndex = 33
        Me.Label30.Text = "Steps:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(335, 144)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(20, 16)
        Me.Label31.TabIndex = 27
        Me.Label31.Text = "3."
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(335, 103)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(20, 16)
        Me.Label32.TabIndex = 26
        Me.Label32.Text = "2."
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(335, 62)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(20, 16)
        Me.Label33.TabIndex = 25
        Me.Label33.Text = "1."
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(6, 36)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(142, 16)
        Me.Label34.TabIndex = 23
        Me.Label34.Text = "Standard Weight ID"
        '
        'gboxSerialNos
        '
        Me.gboxSerialNos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gboxSerialNos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.gboxSerialNos.ForeColor = System.Drawing.Color.Black
        Me.gboxSerialNos.Location = New System.Drawing.Point(7, 10)
        Me.gboxSerialNos.Name = "gboxSerialNos"
        Me.gboxSerialNos.Size = New System.Drawing.Size(245, 239)
        Me.gboxSerialNos.TabIndex = 17
        Me.gboxSerialNos.TabStop = False
        Me.gboxSerialNos.Text = " Serial Numbers"
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox6.Controls.Add(Me.Label35)
        Me.GroupBox6.Controls.Add(Me.Label36)
        Me.GroupBox6.Controls.Add(Me.Label37)
        Me.GroupBox6.Controls.Add(Me.Label38)
        Me.GroupBox6.Controls.Add(Me.Label39)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(263, 10)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(533, 239)
        Me.GroupBox6.TabIndex = 20
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Normal Stent Details"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(358, 36)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(52, 16)
        Me.Label35.TabIndex = 33
        Me.Label35.Text = "Steps:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(335, 144)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(20, 16)
        Me.Label36.TabIndex = 27
        Me.Label36.Text = "3."
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(335, 103)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(20, 16)
        Me.Label37.TabIndex = 26
        Me.Label37.Text = "2."
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(335, 62)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(20, 16)
        Me.Label38.TabIndex = 25
        Me.Label38.Text = "1."
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(36, 36)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(112, 16)
        Me.Label39.TabIndex = 23
        Me.Label39.Text = "Stent Serial No"
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Black
        Me.GroupBox7.Location = New System.Drawing.Point(7, 10)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(245, 239)
        Me.GroupBox7.TabIndex = 19
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = " Serial Numbers"
        '
        'tabStentWeight
        '
        Me.tabStentWeight.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tabStentWeight.Controls.Add(Me.tabInternalAdjust)
        Me.tabStentWeight.Controls.Add(Me.tabStandardWeight)
        Me.tabStentWeight.Controls.Add(Me.tabNormalStent)
        Me.tabStentWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabStentWeight.Location = New System.Drawing.Point(6, 16)
        Me.tabStentWeight.Name = "tabStentWeight"
        Me.tabStentWeight.SelectedIndex = 0
        Me.tabStentWeight.Size = New System.Drawing.Size(736, 284)
        Me.tabStentWeight.TabIndex = 21
        '
        'tabInternalAdjust
        '
        Me.tabInternalAdjust.BackColor = System.Drawing.Color.Transparent
        Me.tabInternalAdjust.Controls.Add(Me.btnCancel)
        Me.tabInternalAdjust.Controls.Add(Me.btnContinue)
        Me.tabInternalAdjust.Controls.Add(Me.lblMsgWaiting)
        Me.tabInternalAdjust.Controls.Add(Me.lblMsgInternalAdjust)
        Me.tabInternalAdjust.Controls.Add(Me.txtInternalAdjust)
        Me.tabInternalAdjust.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabInternalAdjust.Location = New System.Drawing.Point(4, 25)
        Me.tabInternalAdjust.Name = "tabInternalAdjust"
        Me.tabInternalAdjust.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInternalAdjust.Size = New System.Drawing.Size(728, 255)
        Me.tabInternalAdjust.TabIndex = 0
        Me.tabInternalAdjust.Text = "1. Internal Adjustment"
        Me.tabInternalAdjust.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(155, 226)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Enabled = False
        Me.btnContinue.Location = New System.Drawing.Point(61, 226)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 12
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'lblMsgWaiting
        '
        Me.lblMsgWaiting.AutoSize = True
        Me.lblMsgWaiting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgWaiting.ForeColor = System.Drawing.Color.Red
        Me.lblMsgWaiting.Location = New System.Drawing.Point(23, 8)
        Me.lblMsgWaiting.Name = "lblMsgWaiting"
        Me.lblMsgWaiting.Size = New System.Drawing.Size(233, 15)
        Me.lblMsgWaiting.TabIndex = 11
        Me.lblMsgWaiting.Text = "Waiting for the response from machine ...."
        Me.lblMsgWaiting.Visible = False
        '
        'lblMsgInternalAdjust
        '
        Me.lblMsgInternalAdjust.AutoSize = True
        Me.lblMsgInternalAdjust.BackColor = System.Drawing.Color.Transparent
        Me.lblMsgInternalAdjust.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgInternalAdjust.ForeColor = System.Drawing.Color.Red
        Me.lblMsgInternalAdjust.Location = New System.Drawing.Point(283, 192)
        Me.lblMsgInternalAdjust.Name = "lblMsgInternalAdjust"
        Me.lblMsgInternalAdjust.Size = New System.Drawing.Size(148, 16)
        Me.lblMsgInternalAdjust.TabIndex = 10
        Me.lblMsgInternalAdjust.Text = "lblMsgInternalAdjust"
        Me.lblMsgInternalAdjust.Visible = False
        '
        'txtInternalAdjust
        '
        Me.txtInternalAdjust.BackColor = System.Drawing.Color.White
        Me.txtInternalAdjust.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtInternalAdjust.ForeColor = System.Drawing.Color.Blue
        Me.txtInternalAdjust.Location = New System.Drawing.Point(16, 30)
        Me.txtInternalAdjust.Multiline = True
        Me.txtInternalAdjust.Name = "txtInternalAdjust"
        Me.txtInternalAdjust.ReadOnly = True
        Me.txtInternalAdjust.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInternalAdjust.Size = New System.Drawing.Size(249, 190)
        Me.txtInternalAdjust.TabIndex = 9
        '
        'tabStandardWeight
        '
        Me.tabStandardWeight.BackColor = System.Drawing.Color.Lavender
        Me.tabStandardWeight.Controls.Add(Me.GroupBox1)
        Me.tabStandardWeight.Controls.Add(Me.GroupBox2)
        Me.tabStandardWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabStandardWeight.Location = New System.Drawing.Point(4, 25)
        Me.tabStandardWeight.Name = "tabStandardWeight"
        Me.tabStandardWeight.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStandardWeight.Size = New System.Drawing.Size(728, 255)
        Me.tabStandardWeight.TabIndex = 1
        Me.tabStandardWeight.Text = "2. Standard Weight"
        Me.tabStandardWeight.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblMsgStandardWeight)
        Me.GroupBox1.Controls.Add(Me.txtStandardWeight)
        Me.GroupBox1.Controls.Add(Me.txtStandardWeightStep3)
        Me.GroupBox1.Controls.Add(Me.txtStandardWeightStep2)
        Me.GroupBox1.Controls.Add(Me.txtStandardWeightStep1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtStandardStentSerialNo)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(277, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 239)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Standard Weight Details"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(306, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Steps:"
        '
        'lblMsgStandardWeight
        '
        Me.lblMsgStandardWeight.AutoSize = True
        Me.lblMsgStandardWeight.ForeColor = System.Drawing.Color.Red
        Me.lblMsgStandardWeight.Location = New System.Drawing.Point(6, 187)
        Me.lblMsgStandardWeight.Name = "lblMsgStandardWeight"
        Me.lblMsgStandardWeight.Size = New System.Drawing.Size(165, 16)
        Me.lblMsgStandardWeight.TabIndex = 32
        Me.lblMsgStandardWeight.Text = "lblMsgStandardWeight"
        Me.lblMsgStandardWeight.Visible = False
        '
        'txtStandardWeight
        '
        Me.txtStandardWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold)
        Me.txtStandardWeight.Location = New System.Drawing.Point(48, 75)
        Me.txtStandardWeight.Name = "txtStandardWeight"
        Me.txtStandardWeight.ReadOnly = True
        Me.txtStandardWeight.Size = New System.Drawing.Size(229, 47)
        Me.txtStandardWeight.TabIndex = 8
        Me.txtStandardWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStandardWeightStep3
        '
        Me.txtStandardWeightStep3.Location = New System.Drawing.Point(309, 141)
        Me.txtStandardWeightStep3.Name = "txtStandardWeightStep3"
        Me.txtStandardWeightStep3.ReadOnly = True
        Me.txtStandardWeightStep3.Size = New System.Drawing.Size(131, 22)
        Me.txtStandardWeightStep3.TabIndex = 7
        Me.txtStandardWeightStep3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStandardWeightStep2
        '
        Me.txtStandardWeightStep2.Location = New System.Drawing.Point(309, 100)
        Me.txtStandardWeightStep2.Name = "txtStandardWeightStep2"
        Me.txtStandardWeightStep2.ReadOnly = True
        Me.txtStandardWeightStep2.Size = New System.Drawing.Size(131, 22)
        Me.txtStandardWeightStep2.TabIndex = 6
        Me.txtStandardWeightStep2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStandardWeightStep1
        '
        Me.txtStandardWeightStep1.Location = New System.Drawing.Point(309, 59)
        Me.txtStandardWeightStep1.Name = "txtStandardWeightStep1"
        Me.txtStandardWeightStep1.ReadOnly = True
        Me.txtStandardWeightStep1.Size = New System.Drawing.Size(131, 22)
        Me.txtStandardWeightStep1.TabIndex = 5
        Me.txtStandardWeightStep1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(291, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "3."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(291, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 16)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "2."
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(291, 62)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(20, 16)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "1."
        '
        'txtStandardStentSerialNo
        '
        Me.txtStandardStentSerialNo.Location = New System.Drawing.Point(138, 33)
        Me.txtStandardStentSerialNo.MaxLength = 12
        Me.txtStandardStentSerialNo.Name = "txtStandardStentSerialNo"
        Me.txtStandardStentSerialNo.Size = New System.Drawing.Size(139, 22)
        Me.txtStandardStentSerialNo.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 36)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(129, 16)
        Me.Label24.TabIndex = 23
        Me.Label24.Text = "Standard Stent ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.dgStandardStentSerials)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 239)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Serial Numbers"
        '
        'dgStandardStentSerials
        '
        Me.dgStandardStentSerials.AlternatingBackColor = System.Drawing.Color.Silver
        Me.dgStandardStentSerials.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgStandardStentSerials.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgStandardStentSerials.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgStandardStentSerials.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgStandardStentSerials.CaptionForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgStandardStentSerials.DataMember = ""
        Me.dgStandardStentSerials.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.dgStandardStentSerials.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgStandardStentSerials.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgStandardStentSerials.Location = New System.Drawing.Point(8, 21)
        Me.dgStandardStentSerials.Name = "dgStandardStentSerials"
        Me.dgStandardStentSerials.PreferredColumnWidth = 100
        Me.dgStandardStentSerials.ReadOnly = True
        Me.dgStandardStentSerials.Size = New System.Drawing.Size(253, 212)
        Me.dgStandardStentSerials.TabIndex = 96
        '
        'tabNormalStent
        '
        Me.tabNormalStent.BackColor = System.Drawing.Color.Honeydew
        Me.tabNormalStent.Controls.Add(Me.GroupBox3)
        Me.tabNormalStent.Controls.Add(Me.GroupBox4)
        Me.tabNormalStent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabNormalStent.Location = New System.Drawing.Point(4, 25)
        Me.tabNormalStent.Name = "tabNormalStent"
        Me.tabNormalStent.Size = New System.Drawing.Size(728, 255)
        Me.tabNormalStent.TabIndex = 2
        Me.tabNormalStent.Text = "3. Normal Stent"
        Me.tabNormalStent.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.lblMsgNormalStent)
        Me.GroupBox3.Controls.Add(Me.txtNormalStentWeight)
        Me.GroupBox3.Controls.Add(Me.txtNormalStentWeightStep3)
        Me.GroupBox3.Controls.Add(Me.txtNormalStentWeightStep2)
        Me.GroupBox3.Controls.Add(Me.txtNormalStentWeightStep1)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.txtNormalStentSerialNo)
        Me.GroupBox3.Controls.Add(Me.Label41)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(277, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(449, 239)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Normal Stent Details"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(306, 36)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(52, 16)
        Me.Label25.TabIndex = 33
        Me.Label25.Text = "Steps:"
        '
        'lblMsgNormalStent
        '
        Me.lblMsgNormalStent.AutoSize = True
        Me.lblMsgNormalStent.ForeColor = System.Drawing.Color.Red
        Me.lblMsgNormalStent.Location = New System.Drawing.Point(6, 187)
        Me.lblMsgNormalStent.Name = "lblMsgNormalStent"
        Me.lblMsgNormalStent.Size = New System.Drawing.Size(139, 16)
        Me.lblMsgNormalStent.TabIndex = 32
        Me.lblMsgNormalStent.Text = "lblMsgNormalStent"
        Me.lblMsgNormalStent.Visible = False
        '
        'txtNormalStentWeight
        '
        Me.txtNormalStentWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold)
        Me.txtNormalStentWeight.Location = New System.Drawing.Point(48, 75)
        Me.txtNormalStentWeight.Name = "txtNormalStentWeight"
        Me.txtNormalStentWeight.ReadOnly = True
        Me.txtNormalStentWeight.Size = New System.Drawing.Size(229, 47)
        Me.txtNormalStentWeight.TabIndex = 8
        Me.txtNormalStentWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNormalStentWeightStep3
        '
        Me.txtNormalStentWeightStep3.Location = New System.Drawing.Point(309, 141)
        Me.txtNormalStentWeightStep3.Name = "txtNormalStentWeightStep3"
        Me.txtNormalStentWeightStep3.ReadOnly = True
        Me.txtNormalStentWeightStep3.Size = New System.Drawing.Size(131, 22)
        Me.txtNormalStentWeightStep3.TabIndex = 7
        Me.txtNormalStentWeightStep3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNormalStentWeightStep2
        '
        Me.txtNormalStentWeightStep2.Location = New System.Drawing.Point(309, 100)
        Me.txtNormalStentWeightStep2.Name = "txtNormalStentWeightStep2"
        Me.txtNormalStentWeightStep2.ReadOnly = True
        Me.txtNormalStentWeightStep2.Size = New System.Drawing.Size(131, 22)
        Me.txtNormalStentWeightStep2.TabIndex = 6
        Me.txtNormalStentWeightStep2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNormalStentWeightStep1
        '
        Me.txtNormalStentWeightStep1.Location = New System.Drawing.Point(309, 59)
        Me.txtNormalStentWeightStep1.Name = "txtNormalStentWeightStep1"
        Me.txtNormalStentWeightStep1.ReadOnly = True
        Me.txtNormalStentWeightStep1.Size = New System.Drawing.Size(131, 22)
        Me.txtNormalStentWeightStep1.TabIndex = 5
        Me.txtNormalStentWeightStep1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(291, 144)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(20, 16)
        Me.Label27.TabIndex = 27
        Me.Label27.Text = "3."
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(291, 103)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(20, 16)
        Me.Label28.TabIndex = 26
        Me.Label28.Text = "2."
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(291, 62)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(20, 16)
        Me.Label40.TabIndex = 25
        Me.Label40.Text = "1."
        '
        'txtNormalStentSerialNo
        '
        Me.txtNormalStentSerialNo.Location = New System.Drawing.Point(138, 33)
        Me.txtNormalStentSerialNo.MaxLength = 16
        Me.txtNormalStentSerialNo.Name = "txtNormalStentSerialNo"
        Me.txtNormalStentSerialNo.Size = New System.Drawing.Size(139, 22)
        Me.txtNormalStentSerialNo.TabIndex = 4
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(23, 36)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(112, 16)
        Me.Label41.TabIndex = 23
        Me.Label41.Text = "Stent Serial No"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox4.Controls.Add(Me.dgNormalStentSerials)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(4, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(267, 239)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = " Serial Numbers"
        '
        'dgNormalStentSerials
        '
        Me.dgNormalStentSerials.AlternatingBackColor = System.Drawing.Color.Silver
        Me.dgNormalStentSerials.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgNormalStentSerials.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgNormalStentSerials.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgNormalStentSerials.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgNormalStentSerials.CaptionForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgNormalStentSerials.DataMember = ""
        Me.dgNormalStentSerials.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.dgNormalStentSerials.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgNormalStentSerials.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgNormalStentSerials.Location = New System.Drawing.Point(8, 21)
        Me.dgNormalStentSerials.Name = "dgNormalStentSerials"
        Me.dgNormalStentSerials.PreferredColumnWidth = 100
        Me.dgNormalStentSerials.ReadOnly = True
        Me.dgNormalStentSerials.Size = New System.Drawing.Size(253, 212)
        Me.dgNormalStentSerials.TabIndex = 96
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox5.Controls.Add(Me.tabStentWeight)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 239)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(748, 309)
        Me.GroupBox5.TabIndex = 23
        Me.GroupBox5.TabStop = False
        '
        'timerAutoLogoff
        '
        Me.timerAutoLogoff.Interval = 1000
        '
        'pBoxKeyboard
        '
        Me.pBoxKeyboard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pBoxKeyboard.Image = Global.StentWeighing.My.Resources.Resources.Keyboard
        Me.pBoxKeyboard.Location = New System.Drawing.Point(580, 20)
        Me.pBoxKeyboard.Name = "pBoxKeyboard"
        Me.pBoxKeyboard.Size = New System.Drawing.Size(48, 48)
        Me.pBoxKeyboard.TabIndex = 20
        Me.pBoxKeyboard.TabStop = False
        '
        'FrmWeighing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(772, 556)
        Me.ControlBox = False
        Me.Controls.Add(Me.pBoxKeyboard)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.gboxMachineDetails)
        Me.Controls.Add(Me.gboxWODetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmWeighing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weighing Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gboxWODetails.ResumeLayout(False)
        Me.gboxWODetails.PerformLayout()
        Me.gboxMachineDetails.ResumeLayout(False)
        Me.gboxMachineDetails.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.gboxStentDetails.ResumeLayout(False)
        Me.gboxStentDetails.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.tabStentWeight.ResumeLayout(False)
        Me.tabInternalAdjust.ResumeLayout(False)
        Me.tabInternalAdjust.PerformLayout()
        Me.tabStandardWeight.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgStandardStentSerials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNormalStent.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgNormalStentSerials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.pBoxKeyboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gboxWODetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtwrkordno As System.Windows.Forms.TextBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblBatch As System.Windows.Forms.Label
    Friend WithEvents btnNextWO As System.Windows.Forms.Button
    Friend WithEvents btnMachineDetails As System.Windows.Forms.Button
    Friend WithEvents btn15MinsCheck As System.Windows.Forms.Button
    Friend WithEvents gboxMachineDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtMachineName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    'Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    'Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    'Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    'Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    'Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    'Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents btnLogOff As System.Windows.Forms.Button
    Friend WithEvents lblNormalStent As System.Windows.Forms.Label
    Friend WithEvents lblStdStent As System.Windows.Forms.Label
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents timerInternalAdjust As System.Windows.Forms.Timer
    Friend WithEvents lblBalanceQty As System.Windows.Forms.Label
    Friend WithEvents timerStandardWeight As System.Windows.Forms.Timer
    Friend WithEvents timerNormalStent As System.Windows.Forms.Timer
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblCoatName As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    'Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    'Friend WithEvents Button1 As System.Windows.Forms.Button
    'Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    'Friend WithEvents lblMessage1 As System.Windows.Forms.Label
    'Friend WithEvents txtInputData1 As System.Windows.Forms.TextBox
    'Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gboxStentDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    'Friend WithEvents lblMessage2 As System.Windows.Forms.Label
    'Friend WithEvents txtInputData2 As System.Windows.Forms.TextBox
    'Friend WithEvents txtStep23 As System.Windows.Forms.TextBox
    'Friend WithEvents txtStep22 As System.Windows.Forms.TextBox
    'Friend WithEvents txtStep21 As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    'Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents gboxSerialNos As System.Windows.Forms.GroupBox
    'Friend WithEvents DataGrid3 As System.Windows.Forms.DataGrid
    'Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    'Friend WithEvents lblMessage3 As System.Windows.Forms.Label
    'Friend WithEvents txtInputData3 As System.Windows.Forms.TextBox
    'Friend WithEvents txtStep33 As System.Windows.Forms.TextBox
    'Friend WithEvents txtStep32 As System.Windows.Forms.TextBox
    'Friend WithEvents txtStep31 As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    'Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    'Friend WithEvents DataGrid4 As System.Windows.Forms.DataGrid
    Friend WithEvents tabStentWeight As System.Windows.Forms.TabControl
    Friend WithEvents tabInternalAdjust As System.Windows.Forms.TabPage
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents lblMsgWaiting As System.Windows.Forms.Label
    Friend WithEvents lblMsgInternalAdjust As System.Windows.Forms.Label
    Friend WithEvents txtInternalAdjust As System.Windows.Forms.TextBox
    Friend WithEvents tabStandardWeight As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblMsgStandardWeight As System.Windows.Forms.Label
    Friend WithEvents txtStandardWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtStandardWeightStep3 As System.Windows.Forms.TextBox
    Friend WithEvents txtStandardWeightStep2 As System.Windows.Forms.TextBox
    Friend WithEvents txtStandardWeightStep1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtStandardStentSerialNo As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgStandardStentSerials As System.Windows.Forms.DataGrid
    Friend WithEvents tabNormalStent As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblMsgNormalStent As System.Windows.Forms.Label
    Friend WithEvents txtNormalStentWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtNormalStentWeightStep3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNormalStentWeightStep2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNormalStentWeightStep1 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtNormalStentSerialNo As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgNormalStentSerials As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblInternalAdj As System.Windows.Forms.Label
    Friend WithEvents timerAutoLogoff As System.Windows.Forms.Timer
    Friend WithEvents pBoxKeyboard As System.Windows.Forms.PictureBox
End Class
