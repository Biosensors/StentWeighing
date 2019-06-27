Imports System.Data
Imports System.Data.SqlClient
Imports system.IO
Imports StentWeighing.ClsUtil

Module StentWeighingMain
    Public db As New Class1
    Public sMainWorkOrderNO As String
    Public sMainOperation As Integer
    Public sLogonUser As String
    Public sLogonAdmin As String
    Public sTempLogonUser As String
    Public sUpdateMode As String
    Public sStentDS As DataSet
    Public sMainStatus As String
    Public sMainReasonCodes As String
    Public domainUser As String
    Public Username As String
    Public nUserPos As Integer
    Public UserFullName As String
    Public sDBServer As String
    Public sDBName As String
    Public sConnectionServer As String
    Public sFldColumnsName As String
    Public INIFilePath As String
    Public version As String
    Public Sql As String
    Public ds As DataSet
    Public sUserID As String
    Public sRoleid As String
    Public dsDimension As DataSet
    Public sDimSerialNo As String
    Public sNodeFormType As String
    Public conn As New SqlConnection(sConnectionServer)
    Public strQuery As String
    Public strMenuText As String
    Public sLoginCancel As Boolean = False
    Public sShipmentWorkOrderNO As String

    Public Function getUserAuthentication() As Boolean

        Dim Success As Boolean = False
        Try
            Sql = "Select * from Users where userid = '" & sLogonUser & "'"
            ds = db.selectQuery(Sql)

            If (ds.Tables(0).Rows.Count > 0) Then
                If (ds.Tables(0).Rows(0).Item("stat") = 1) Then
                    Success = True
                    UserFullName = ds.Tables(0).Rows(0).Item("uname")
                Else
                    Success = False
                    MsgBox("User does not exist", MsgBoxStyle.Critical)
                End If
            Else
                UserFullName = ""
                Success = False
            End If
        Catch ex As System.Exception

        End Try
        Return (Success)

    End Function

End Module
