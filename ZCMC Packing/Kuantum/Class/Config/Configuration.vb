Imports Database

Public Class Configuration
    Implements IConfiguration
    Private Shared _instance As Configuration
    Private _database As DBManager = DBManager.getInstance()
    Private _dbConfig As SQLite = New SQLite()
    'Private _ui As UserInterface = UserInterface.getInstance()
    Public _currConfig As ConfigData = New ConfigData()

    Public Sub New()
    End Sub

    Public Shared Function getInstance() As Configuration
        If _instance Is Nothing Then
            _instance = New Configuration()
        End If
        Return _instance
    End Function

    Public Function Open() As Boolean Implements IConfiguration.Open

        Dim status As Boolean
        If Not _dbConfig.isConnected Then
            _dbConfig = _database.GetDataBase("Config.db", "C01", "-SQLite", "Configuration")
            status = True
        End If
        Return status
    End Function

    Public Function Close() As Boolean Implements IConfiguration.Close

        Return True
    End Function

    Private Sub SetValue(param As String, val As String) Implements IConfiguration.SetValue
        Try
            Dim str_where As String = String.Format("Item='{0}'", param)
            Dim str_val As String = String.Format("Value='{0}'", val)
            'Masukkan ke Database DB (Update)
            _dbConfig.DBUpdate("config", str_val, str_where)

        Catch ex As Exception

        End Try
    End Sub

    Private Function GetValue(Item As String) As String Implements IConfiguration.GetValue
        Dim val As String = ""
        Try
            Dim str_where As String = String.Format("Item='{0}'", Item)
            Dim dt As DataTable = New DataTable()
            'Eksekusi Database Config (Select)
            dt = _dbConfig.DBSelect("Value", "config", str_where)
            If dt.Rows.Count > 0 Then
                val = dt.Rows(0).Item(0)
            End If

        Catch ex As Exception

        End Try
        Return val

    End Function


    Public Sub Save(newConfig As ConfigData) Implements IConfiguration.Save
        With newConfig
            SetValue("PLCIPAddress", .PLC_IP)
            SetValue("PLCPort", .PLC_PORT)
            SetValue("IndividualPrinter", .IND_PRINTER)
            SetValue("IndividualFileName", .INDIVIDUAL_NAME)
            SetValue("GroupPrinter", .GROUP_PRINTER)
            SetValue("GroupFileName", .GROUP_NAME)


        End With
    End Sub


    Public Function Read() As ConfigData Implements IConfiguration.Read
        Try
            With _currConfig
                .PLC_IP = GetValue("PLCIPAddress")
                .PLC_PORT = GetValue("PLCPort")
                .IND_PRINTER = GetValue("IndividualPrinter")
                .GROUP_PRINTER = GetValue("GroupPrinter")
                .INDIVIDUAL_NAME = GetValue("IndividualFileName")
                .GROUP_NAME = GetValue("GroupFileName")

            End With

        Catch ex As Exception

        End Try

        UserInterface._frmConfig.UpdateUI(frmConfig.config.PLC_IP, _currConfig.PLC_IP)
        UserInterface._frmConfig.UpdateUI(frmConfig.config.PLC_PORT, _currConfig.PLC_PORT)
        UserInterface._frmConfig.UpdateUI(frmConfig.config.IND_PRINT, _currConfig.IND_PRINTER)
        UserInterface._frmConfig.UpdateUI(frmConfig.config.IND_NAME, _currConfig.INDIVIDUAL_NAME)
        UserInterface._frmConfig.UpdateUI(frmConfig.config.GROUP_NAME, _currConfig.GROUP_NAME)
        UserInterface._frmConfig.UpdateUI(frmConfig.config.GROUP_PRINT, _currConfig.GROUP_PRINTER)


        Return _currConfig
    End Function






End Class
