Imports System
Imports System.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.IO
Imports System.StringSplitOptions
Imports StentWeighing

Public Class Class1
  
    Public conn As New SqlConnection(sConnectionServer)
    Private Shared DEBUG As Boolean = True
    Public w As Integer
    Private Declare Auto Function PlaySound Lib "winmm.dll" (ByVal lpszSoundName As String, ByVal hModule As Integer, ByVal dwFlags As Integer) As Integer
    Private Const SND_FILENAME As Integer = &H20000

    Public Function PlayWav(ByVal sType As String) As Boolean

        'return true if successful, false if otherwise
        Dim bAns As Boolean, iRet As Integer = 0
        Dim sFileFullPath As String

        sFileFullPath = "blip.wav"

        Try
            iRet = PlaySound(sFileFullPath, 0, SND_FILENAME)
        Catch

        End Try
        Return iRet

    End Function

    Public Function selectQuery(ByVal sql As String) As DataSet
        Dim response As MsgBoxResult
        Dim conn As New SqlConnection(sConnectionServer)
        Dim ds As New DataSet

        Try
            Dim da As New SqlDataAdapter(sql, conn)
            da.SelectCommand.CommandTimeout = 400
            da.Fill(ds)
        Catch ex As System.Exception
            response = MsgBoxResult.Cancel
            response = MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2)
            Return Nothing
        End Try
        Return ds
    End Function

    Public Function updateQuery(ByVal sql As String) As Boolean
        Dim response As MsgBoxResult
        Dim conn As New SqlConnection(sConnectionServer)

        Try
            Dim cmd As New SqlCommand(sql, conn)
            conn.Open()
            cmd.CommandTimeout = 400
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)

            response = MsgBoxResult.Cancel
            Do While response <> MsgBoxResult.Ok
                response = MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2)
            Loop
            Return False
        End Try
        Return True
    End Function

    Public Function insertQuery(ByVal sql As String) As Boolean
        Dim response As MsgBoxResult
        Dim conn As New SqlConnection(sConnectionServer)
        Try
            Dim cmd As New SqlCommand(sql, conn)
            conn.Open()
            cmd.CommandTimeout = 400
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As System.Exception
            response = MsgBoxResult.Cancel
            If InStr(ex.Message, "Cannot insert duplicate", CompareMethod.Binary) > 0 Then
                w = 1
            Else
                Do While response <> MsgBoxResult.Ok
                    response = MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2)
                Loop
            End If
            Return False
        End Try
        Return True
    End Function

    Public Function deleteQuery(ByVal sql As String) As Boolean
        Dim response As MsgBoxResult
        Dim conn As New SqlConnection(sConnectionServer)
        Try
            Dim cmd As New SqlCommand(sql, conn)
            conn.Open()
            cmd.CommandTimeout = 400
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As System.Exception
            response = MsgBoxResult.Cancel
            Do While response <> MsgBoxResult.Ok
                response = MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2)
            Loop
            Return False
        End Try
        Return True
    End Function

    Public Sub close()
        Dim conn As New SqlConnection(sConnectionServer)
        Try
            conn.Close()
        Catch

        End Try
    End Sub

End Class

