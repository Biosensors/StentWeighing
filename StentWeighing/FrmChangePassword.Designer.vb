<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChangePassword))
        Me.btnsave = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.lblUserID = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtConfirmNewPassword = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNewPassword = New System.Windows.Forms.TextBox
        Me.txtOldPassword = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnsave
        '
        resources.ApplyResources(Me.btnsave, "btnsave")
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Tag = "I"
        '
        'btncancel
        '
        resources.ApplyResources(Me.btncancel, "btncancel")
        Me.btncancel.Name = "btncancel"
        '
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Controls.Add(Me.txtUserID)
        Me.GroupBox2.Controls.Add(Me.lblUserID)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtConfirmNewPassword)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtNewPassword)
        Me.GroupBox2.Controls.Add(Me.txtOldPassword)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'txtUserID
        '
        Me.txtUserID.AllowDrop = True
        resources.ApplyResources(Me.txtUserID, "txtUserID")
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        '
        'lblUserID
        '
        resources.ApplyResources(Me.lblUserID, "lblUserID")
        Me.lblUserID.Name = "lblUserID"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txtConfirmNewPassword
        '
        resources.ApplyResources(Me.txtConfirmNewPassword, "txtConfirmNewPassword")
        Me.txtConfirmNewPassword.Name = "txtConfirmNewPassword"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'txtNewPassword
        '
        resources.ApplyResources(Me.txtNewPassword, "txtNewPassword")
        Me.txtNewPassword.Name = "txtNewPassword"
        '
        'txtOldPassword
        '
        resources.ApplyResources(Me.txtOldPassword, "txtOldPassword")
        Me.txtOldPassword.Name = "txtOldPassword"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'FrmChangePassword
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btncancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmChangePassword"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents lblUserID As System.Windows.Forms.Label
End Class
