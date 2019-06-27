
Public Class FrmLogin

    Dim objClsStentWeighing As New clsStentWeighing
    Dim p As New System.Diagnostics.Process
    Dim ds As New DataSet

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sConnectionServer = objClsStentWeighing.GetConnectionStringValue
        SystemName = Environment.MachineName.ToString()

        FillOperatorsList()
        'FrmWeighing.Close()

        txtUserID.Text = ""
        txtPassword.Text = ""
        chkPreCoat.Checked = True
        chkPostCoat.Checked = False
        lboxOperators.SelectedIndex = -1
        gboxKeyPad.Visible = False
    End Sub

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        If txtUserID.Text = "" Then
            MsgBox("Select Username")
            txtUserID.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("Enter Password")
            txtPassword.Focus()
        ElseIf chkPreCoat.Checked = False And chkPostCoat.Checked = False Then
            MsgBox("Select Operations")
        Else
            ValidateLogin()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If lblAdmin.Text = "AdminLogin" Then
            Me.Close()
        Else
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub lboxOperators_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lboxOperators.SelectedIndexChanged
        If lboxOperators.SelectedIndex >= 0 Then
            txtUserID.Text = lboxOperators.SelectedValue.ToString()
            txtPassword.Text = ""
            txtPassword.Focus()
            gboxKeyPad.Visible = True
        End If
    End Sub

    Private Sub FillOperatorsList()
        'Sql = "select userid, uname from users where stat = 1 order by uname"
        Sql = "select distinct u.userid,u.uname from biouserrights ur left join users u on ur.userid = u.userid where ur.roleid='AMPC' order by u.uname"
        ds = db.selectQuery(Sql)

        lboxOperators.DataSource = ds.Tables(0)
        lboxOperators.DisplayMember = "uname"
        lboxOperators.ValueMember = "userid"
    End Sub

    Private Sub ValidateLogin()
        Try
            If lblAdmin.Text = "AdminLogin" Then
                sLogonAdmin = LCase(txtUserID.Text.Trim())
            Else
                sLogonUser = LCase(txtUserID.Text.Trim())
            End If

            Sql = "select userid from Users where userid = '" & txtUserID.Text.Trim() & "' and passwd = '" & txtPassword.Text.Trim() & "' COLLATE Latin1_General_CS_AS"
            ds = db.selectQuery(Sql)

            If (ds.Tables(0).Rows.Count > 0) And (getUserAuthentication() = True) Then
                SuccessLogin()
            Else
                MsgBox("Password is incorrect.", MsgBoxStyle.Critical)
                txtPassword.Text = ""
                txtPassword.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SuccessLogin()

        Me.txtPassword.Text = ""
        Me.Hide()
        sLoginCancel = True

        If chkPreCoat.Checked = True Then
            CoatValue = 1
        ElseIf chkPostCoat.Checked = True Then
            CoatValue = 3
        End If

        If lblAdmin.Text = "AdminLogin" Then

            If objClsStentWeighing.CheckAdmin(txtUserID.Text.Trim(), 107) Then

                sTempLogonUser = sLogonUser
                sLogonAdmin = txtUserID.Text.Trim()
                sLogonUser = sLogonAdmin
                AdminCoatValue = 9

                FrmWeighing.lblMsgNormalStent.Visible = False
                FrmWeighing.txtNormalStentSerialNo.Text = ""
                FrmWeighing.txtNormalStentWeight.Text = ""
                FrmWeighing.txtNormalStentWeightStep1.Text = ""
                FrmWeighing.txtNormalStentWeightStep2.Text = ""
                FrmWeighing.txtNormalStentWeightStep3.Text = ""
                FrmWeighing.txtNormalStentSerialNo.Focus()

                If CoatValue = 1 Then
                    FrmWeighing.lblCoatName.Text = "Admin - Pre Coat"
                ElseIf CoatValue = 3 Then
                    FrmWeighing.lblCoatName.Text = "Admin - Post Coat"
                End If

                'Enter log for Admin Login
                objClsStentWeighing.InsertIntoLogFile("", "", 0, 0, 0, 0, "Admin Login", Nothing)

                FrmWeighing.btnAdmin.Enabled = True
                FrmWeighing.btnAdmin.Tag = 2
                FrmWeighing.btnAdmin.Text = "Exit Admin (F4)"
                Me.Close()

            Else
                MsgBox("Invalid Admin User", MsgBoxStyle.Critical)
            End If

        Else

            LoginCoatValue = CoatValue

            Sql = "select machineid,name,serialno,autologoffmins from machines where hostname = '" & SystemName & "'"
            ds = db.selectQuery(Sql)
            If ds.Tables(0).Rows.Count() > 0 Then
                MachineID = ds.Tables(0).Rows(0).Item("machineid")
            End If

            'Enter log for User Login
            objClsStentWeighing.InsertIntoLogFile("", "", 0, 0, 0, 0, "User Login", Nothing)

            Me.Close()
            MDIForm.TSSlblLogin.Text = UserFullName & " (" & sLogonUser & ")"
            MDIForm.Activate()

            FrmWeighing.ShowDialog()

        End If

    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            ValidateLogin()
        End If
    End Sub

    Private Sub chkPreCoat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPreCoat.CheckedChanged
        If chkPreCoat.Checked = True Then
            chkPostCoat.Checked = False
        End If
    End Sub

    Private Sub chkPostCoat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPostCoat.CheckedChanged
        If chkPostCoat.Checked = True Then
            chkPreCoat.Checked = False
        End If
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        txtPassword.Text = txtPassword.Text & 1
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        txtPassword.Text = txtPassword.Text & 2
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        txtPassword.Text = txtPassword.Text & 3
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        txtPassword.Text = txtPassword.Text & 4
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        txtPassword.Text = txtPassword.Text & 5
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        txtPassword.Text = txtPassword.Text & 6
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        txtPassword.Text = txtPassword.Text & 7
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        txtPassword.Text = txtPassword.Text & 8
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        txtPassword.Text = txtPassword.Text & 9
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        txtPassword.Text = txtPassword.Text & 0
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If Trim(txtPassword.Text) <> "" Then
            txtPassword.Text = Trim(txtPassword.Text).Substring(0, Len(txtPassword.Text) - 1)
        End If
    End Sub

    Private Sub lblChangePassword_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblChangePassword.LinkClicked
        If txtUserID.Text = "" Then
            MsgBox("Select Operator and Proceed")
        Else
            FrmChangePassword.txtUserID.Text = txtUserID.Text
            FrmChangePassword.ShowDialog()
        End If
    End Sub

End Class
