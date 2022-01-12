Public Class ConfigData


    Private _plcIP As String = String.Empty
    Private _plcPort As String = String.Empty
    Private _printerName As String = String.Empty


    Public DefaultConfig As ConfigData
    Public Property PLC_IP As String
        Get
            Return _plcIP
        End Get
        Set(value As String)
            _plcIP = value
        End Set
    End Property

    Public Property PLC_PORT As String
        Get
            Return _plcPort
        End Get
        Set(value As String)
            _plcPort = value
        End Set
    End Property

    Public Property PRINTER_NAME As String
        Get
            Return _printerName
        End Get
        Set(value As String)
            _printerName = value
        End Set
    End Property
End Class
