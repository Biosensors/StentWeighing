Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Reflection
Imports System.Text
Imports System.Text.StringBuilder

Public Class MDIForm

    Dim datRow As DataRow

    Private Sub form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call OpenLogonForm()
        FrmLogin.txtUserID.Focus()
    End Sub

    Private Sub OpenLogonForm()
        sLogonUser = ""
        FrmLogin.MdiParent = Me
        FrmLogin.lblAdmin.Text = "UserLogin"
        FrmLogin.Show()
        If Not sLogonUser = "" Then
            Me.Activate()
            Me.TSSlblLogin.Text = UserFullName & " (" & sLogonUser & ")"
            'Me.TSSlbldbName.Text = FrmLogin.ddlServer.SelectedItem
        End If
    End Sub

End Class