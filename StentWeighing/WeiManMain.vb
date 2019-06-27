
Imports System.IO

Module WeiManMain
    Public WithEvents moRS232 As Rs232
    Public BAUDRATE As Integer = 9600
    Public TIMEOUT As Integer = 1500
    Public PORTNO As Integer = 4
    Public DATAPARITY As Integer = 2
    Public DATABIT As Integer = 8
    Public STOPBIT As Integer = 0
    Public XONXOFF As Boolean = 1    'True
    Public TOLERANCE As Double = 0.002
    Public Const cINQUIRY_SERIALNO As String = "I4"
    Public Const cRESET_MACHINE As String = "@"
    Public SerialNoBytesRead As Integer = 25
    Public iniFileName As String = "Weiman.ini"
    Public timeIntervalValue = 300
    Public SystemName As String

    Public MAX_STDWEIGHTSTEPS As Integer = 2
    Public MAX_NORMALWEIGHTSTEPS As Integer = 2

    Public CREATELOGFILE As Boolean = False
    Public WeighingSteps As Integer = 0

    Public CoatValue, LoginCoatValue, AdminCoatValue As Integer
    Public MachineID As String
    Public bDataReadStatus As Boolean
    Public sIntAdjustmentStatus As String
    Public sReceivedWeightData As String = ""
    Public nCurrentTAB As Integer
    Public StartInternalAdjustDateTime As DateTime
    Public LogDateTime As DateTime
    Public Mintolerance, Maxtolerance As Double

End Module
