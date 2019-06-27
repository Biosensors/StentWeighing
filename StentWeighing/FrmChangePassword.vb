Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Reflection

Public Class FrmChangePassword
    Public pstatus As String
    Dim p As New System.Diagnostics.Process

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearControls()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        CloseOnScreenKeyboard()
        Me.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim sql As String
        Dim ds As DataSet

        If Trim(txtOldPassword.Text) = "" Then
            MsgBox("Enter Old Password")
            txtOldPassword.Focus()

        ElseIf Trim(txtNewPassword.Text) = "" Then
            MsgBox("Enter New Password")
            txtNewPassword.Focus()

        ElseIf Trim(txtConfirmNewPassword.Text) = "" Then
            MsgBox("Re-enter New Password")
            txtConfirmNewPassword.Focus()

        ElseIf Trim(txtNewPassword.Text) <> Trim(txtConfirmNewPassword.Text) Then
            MsgBox("Passwords do not match")
            ClearControls()

        Else
            sql = "select passwd from Users where userid = '" & Trim(txtUserID.Text) & "'"
            ds = db.selectQuery(sql)

            If ds.Tables(0).Rows.Count > 0 Then
                If ds.Tables(0).Rows(0).Item(0) = Trim(txtOldPassword.Text) Then
                    sql = "update Users set passwd='" & Trim(txtNewPassword.Text) & "' where userid='" & Trim(txtUserID.Text) & "'"
                    db.updateQuery(sql)
                    MsgBox("Password changed successfully", MsgBoxStyle.Information)
                    CloseOnScreenKeyboard()
                    Me.Close()
                Else
                    MsgBox("Incorrect old password")
                    ClearControls()
                End If
            End If
        End If
    End Sub

    Private Sub ClearControls()
        txtOldPassword.Clear()
        txtNewPassword.Clear()
        txtConfirmNewPassword.Clear()
        txtOldPassword.Focus()
    End Sub

    Private Sub CloseOnScreenKeyboard()
        Dim myProcesses() As Process
        myProcesses = Process.GetProcessesByName("osk")
        For Each p In myProcesses
            p.CloseMainWindow()
            p.Close()
        Next
    End Sub

    Private Sub txtOldPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOldPassword.GotFocus
        p.StartInfo.FileName = "osk"
        p.Start()
    End Sub

    Private Sub txtNewPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNewPassword.GotFocus
        p.StartInfo.FileName = "osk"
        p.Start()
    End Sub

    Private Sub txtConfirmNewPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConfirmNewPassword.GotFocus
        p.StartInfo.FileName = "osk"
        p.Start()
    End Sub
End Class