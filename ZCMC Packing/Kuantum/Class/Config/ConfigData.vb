Public Class ConfigData


    Private _plcIP As String = String.Empty
    Private _plcPort As String = String.Empty
    Private _printerName As String = String.Empty
    Private _indPrint As String = String.Empty
    Private _groupPrint As String = String.Empty
    Private _indName As String = String.Empty
    Private _groupName As String = String.Empty
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

    Public Property IND_PRINTER As String
        Get
            Return _indPrint
        End Get
        Set(value As String)
            _indPrint = value
        End Set
    End Property

    Public Property GROUP_PRINTER As String
        Get
            Return _groupPrint
        End Get
        Set(value As String)
            _groupPrint = value
        End Set
    End Property

    Public Property INDIVIDUAL_NAME As String
        Get
            Return _indName
        End Get
        Set(value As String)
            _indName = value
        End Set
    End Property

    Public Property GROUP_NAME As String
        Get
            Return _groupName
        End Get
        Set(value As String)
            _groupName = value
        End Set
    End Property


End Class
