<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblChangePassword = New System.Windows.Forms.LinkLabel
        Me.chkPostCoat = New System.Windows.Forms.CheckBox
        Me.chkPreCoat = New System.Windows.Forms.CheckBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblUserID = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnLogIn = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lboxOperators = New System.Windows.Forms.ListBox
        Me.gboxKeyPad = New System.Windows.Forms.GroupBox
        Me.btnBack = New System.Windows.Forms.Button
        Me.btn0 = New System.Windows.Forms.Button
        Me.btn9 = New System.Windows.Forms.Button
        Me.btn8 = New System.Windows.Forms.Button
        Me.btn7 = New System.Windows.Forms.Button
        Me.btn6 = New System.Windows.Forms.Button
        Me.btn5 = New System.Windows.Forms.Button
        Me.btn4 = New System.Windows.Forms.Button
        Me.btn3 = New System.Windows.Forms.Button
        Me.btn2 = New System.Windows.Forms.Button
        Me.btn1 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lblAdmin = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gboxKeyPad.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.lblChangePassword)
        Me.GroupBox1.Controls.Add(Me.chkPostCoat)
        Me.GroupBox1.Controls.Add(Me.chkPreCoat)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblUserID)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.txtUserID)
        Me.GroupBox1.Location = New System.Drawing.Point(289, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(296, 132)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'lblChangePassword
        '
        Me.lblChangePassword.AutoSize = True
        Me.lblChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangePassword.Location = New System.Drawing.Point(149, 76)
        Me.lblChangePassword.Name = "lblChangePassword"
        Me.lblChangePassword.Size = New System.Drawing.Size(133, 16)
        Me.lblChangePassword.TabIndex = 13
        Me.lblChangePassword.TabStop = True
        Me.lblChangePassword.Text = "Change Password"
        '
        'chkPostCoat
        '
        Me.chkPostCoat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkPostCoat.AutoSize = True
        Me.chkPostCoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPostCoat.Location = New System.Drawing.Point(191, 104)
        Me.chkPostCoat.Name = "chkPostCoat"
        Me.chkPostCoat.Size = New System.Drawing.Size(94, 20)
        Me.chkPostCoat.TabIndex = 12
        Me.chkPostCoat.Text = "Post Coat"
        Me.chkPostCoat.UseVisualStyleBackColor = True
        '
        'chkPreCoat
        '
        Me.chkPreCoat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkPreCoat.AutoSize = True
        Me.chkPreCoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPreCoat.Location = New System.Drawing.Point(101, 103)
        Me.chkPreCoat.Name = "chkPreCoat"
        Me.chkPreCoat.Size = New System.Drawing.Size(87, 20)
        Me.chkPreCoat.TabIndex = 11
        Me.chkPreCoat.Text = "Pre Coat"
        Me.chkPreCoat.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(101, 46)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(176, 22)
        Me.txtPassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(10, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Operations"
        '
        'lblUserID
        '
        Me.lblUserID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblUserID.Location = New System.Drawing.Point(36, 20)
        Me.lblUserID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(60, 16)
        Me.lblUserID.TabIndex = 0
        Me.lblUserID.Text = "User ID"
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.Location = New System.Drawing.Point(18, 49)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(76, 16)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        '
        'txtUserID
        '
        Me.txtUserID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(101, 18)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserID.MaxLength = 20
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(176, 22)
        Me.txtUserID.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.Location = New System.Drawing.Point(156, 15)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 32)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnLogIn
        '
        Me.btnLogIn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnLogIn.Location = New System.Drawing.Point(41, 15)
        Me.btnLogIn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(100, 32)
        Me.btnLogIn.TabIndex = 15
        Me.btnLogIn.Text = "Login"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.lboxOperators)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(18, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 464)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operators"
        '
        'lboxOperators
        '
        Me.lboxOperators.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lboxOperators.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxOperators.FormattingEnabled = True
        Me.lboxOperators.ItemHeight = 20
        Me.lboxOperators.Location = New System.Drawing.Point(17, 24)
        Me.lboxOperators.Name = "lboxOperators"
        Me.lboxOperators.Size = New System.Drawing.Size(222, 424)
        Me.lboxOperators.TabIndex = 1
        '
        'gboxKeyPad
        '
        Me.gboxKeyPad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gboxKeyPad.Controls.Add(Me.btnBack)
        Me.gboxKeyPad.Controls.Add(Me.btn0)
        Me.gboxKeyPad.Controls.Add(Me.btn9)
        Me.gboxKeyPad.Controls.Add(Me.btn8)
        Me.gboxKeyPad.Controls.Add(Me.btn7)
        Me.gboxKeyPad.Controls.Add(Me.btn6)
        Me.gboxKeyPad.Controls.Add(Me.btn5)
        Me.gboxKeyPad.Controls.Add(Me.btn4)
        Me.gboxKeyPad.Controls.Add(Me.btn3)
        Me.gboxKeyPad.Controls.Add(Me.btn2)
        Me.gboxKeyPad.Controls.Add(Me.btn1)
        Me.gboxKeyPad.Location = New System.Drawing.Point(288, 142)
        Me.gboxKeyPad.Name = "gboxKeyPad"
        Me.gboxKeyPad.Size = New System.Drawing.Size(297, 273)
        Me.gboxKeyPad.TabIndex = 15
        Me.gboxKeyPad.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(199, 213)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(60, 46)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "BS"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(37, 213)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(141, 46)
        Me.btn0.TabIndex = 5
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(199, 21)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(60, 46)
        Me.btn9.TabIndex = 14
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(118, 21)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(60, 46)
        Me.btn8.TabIndex = 13
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(37, 21)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(60, 46)
        Me.btn7.TabIndex = 12
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(199, 85)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(60, 46)
        Me.btn6.TabIndex = 11
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(118, 85)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(60, 46)
        Me.btn5.TabIndex = 10
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(37, 85)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(60, 46)
        Me.btn4.TabIndex = 9
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(199, 149)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(60, 46)
        Me.btn3.TabIndex = 8
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(118, 149)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(60, 46)
        Me.btn2.TabIndex = 7
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(37, 149)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(60, 46)
        Me.btn1.TabIndex = 6
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox4.Controls.Add(Me.btnCancel)
        Me.GroupBox4.Controls.Add(Me.btnLogIn)
        Me.GroupBox4.Location = New System.Drawing.Point(289, 415)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(296, 55)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        '
        'lblAdmin
        '
        Me.lblAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Location = New System.Drawing.Point(524, 474)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(55, 13)
        Me.lblAdmin.TabIndex = 17
        Me.lblAdmin.Text = "UserLogin"
        Me.lblAdmin.Visible = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 495)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gboxKeyPad)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.gboxKeyPad.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lboxOperators As System.Windows.Forms.ListBox
    Friend WithEvents gboxKeyPad As System.Windows.Forms.GroupBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPostCoat As System.Windows.Forms.CheckBox
    Friend WithEvents chkPreCoat As System.Windows.Forms.CheckBox
    Friend WithEvents lblChangePassword As System.Windows.Forms.LinkLabel
    Friend WithEvents lblAdmin As System.Windows.Forms.Label

End Class
