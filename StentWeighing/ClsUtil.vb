Public Class ClsUtil

    Public Shared Function MNI(ByVal i As Object) As Integer
        If IsDBNull(i) Then
            Return 0
        ElseIf i Is Nothing Then
            Return 0
        Else
            Return Convert.ToInt32(i)
        End If
    End Function

    Public Shared Function MNDbl(ByVal i As Object) As Double
        If IsDBNull(i) Then
            Return 0
        ElseIf i Is Nothing Then
            Return 0
        Else
            Return Convert.ToDouble(i)
        End If
    End Function

    Public Shared Function MNS(ByVal i As Object) As String
        If IsDBNull(i) Then
            Return ""
        ElseIf i Is Nothing Then
            Return ""
        Else
            Return Convert.ToString(i)
        End If
    End Function

    Public Shared Function MND(ByVal i As Object) As String
        Try
            If IsDBNull(i) Then
                Return ""
            ElseIf i Is Nothing Then
                Return ""
            Else
                Dim dt As DateTime
                dt = Convert.ToDateTime(i).AddHours(8)
                If dt.Year <= 1971 Then Return ""
                Return dt.ToString
            End If
        Catch ex As System.Exception
            Return ""
        End Try

    End Function

    Public Shared Function MNDiff(ByVal dto1 As Object, ByVal dto2 As Object) As String
        Try
            If IsDBNull(dto1) Or dto1 Is Nothing Or IsDBNull(dto2) Or dto2 Is Nothing Then
                Return ""
            Else
                Dim dt1 As DateTime
                dt1 = Convert.ToDateTime(dto1)
                Dim dt2 As DateTime
                dt2 = Convert.ToDateTime(dto2)
                If dt1.Year <= 1971 Or dt2.Year <= 1971 Then Return ""
                Dim ts As TimeSpan
                ts = dt1.Subtract(dt2)
                Return ts.Hours & ":" & ts.Minutes & ":" & ts.Seconds
            End If
        Catch ex As System.Exception
            Return ""
        End Try

    End Function

    Public Shared Function updateDate(ByVal dt As DateTime) As String
        Dim dt2 As DateTime
        dt2 = dt.AddHours(-8)

        Return "TO_Date( '" & dt2.ToString() & "', 'MM/DD/YYYY HH:MI:SS AM')"

    End Function

    Public Shared Function GetServerDateTime() As Date
        Try
            Dim db As New Class1
            Dim sql As String
            Dim ds As DataSet
            Dim dr As DataRow

            sql = "select to_char(sysdate, ' MM-DD-YYYY HH:MI:SS PM') from dual"
            ds = db.selectQuery(sql)

            dr = ds.Tables(0).Rows(0)
            GetServerDateTime = Convert.ToDateTime(dr(0))

        Catch
            MsgBox("Error in GetServerDateTime: " & Err.Description)
        End Try

    End Function

    Public Function StuffWithZeros(ByVal sInputStr As String, ByVal nStrLength As Integer) As String
        Dim sTmpStr, sStuff As String
        Dim nI As Integer
        sTmpStr = Trim(sInputStr)
        sStuff = ""
        For nI = 1 To (nStrLength - Len(sInputStr))
            sStuff = sStuff & "0"
        Next
        sTmpStr = sStuff & sTmpStr
        Return sTmpStr
    End Function

End Class


