Imports System.Threading
Imports MB
Imports CS
Imports CS.Variable

Public Class Initialization
    Implements IInitialization
    Private Shared _instance As Initialization
    Private Shared _wait As System.Threading.ManualResetEvent

    'Get Object Instance
    Dim _config As IConfiguration = Configuration.getInstance()
    Dim _Reference As IReference = Reference.getInstance()
    Dim _modbus As Modbus = Modbus.getInstance()
    Private _label As Codesoft
    Private _production As Production
    'Dim _database As DBManager = New DBManager
    'Dim _dbProduction As SQLite = New SQLite()
    Private Shared _frmSplash As frmSplash


    Public Sub New()
    End Sub

    Public Shared Function getInstance() As Initialization
        If _instance Is Nothing Then
            _instance = New Initialization()
        End If
        Return _instance
    End Function


    Public Sub UpdateStatus(msg As String, value As Integer) Implements IInitialization.UpdateStatus
        If _frmSplash Is Nothing Then Exit Sub
        If _frmSplash.InvokeRequired Then
            _frmSplash.Invoke(Sub() DoUpdateStatus(msg, value))
        Else
            DoUpdateStatus(msg, value)
        End If

    End Sub

    Private Shared Sub DoUpdateStatus(Msg As String, Value As Integer)
        _frmSplash.setProgress(Msg, Value)
    End Sub

    Public Sub Show() Implements IInitialization.Show
        If _wait IsNot Nothing Then Exit Sub
        _wait = New System.Threading.ManualResetEvent(False)
        System.Threading.Tasks.Task.Factory.StartNew(AddressOf DoShowSplash)
        _wait.WaitOne()
    End Sub

    Public Sub Close() Implements IInitialization.Close
        If _frmSplash Is Nothing Then Exit Sub
        _frmSplash.Invoke(New Action(AddressOf DoCloseSplash))
    End Sub

    Private Shared Sub DoShowSplash()
        _frmSplash = New frmSplash
        _wait.Set()
        _frmSplash.ShowDialog()
    End Sub

    Private Shared Sub DoCloseSplash()
        _frmSplash.Close()
        _frmSplash = Nothing
        _wait.Dispose()
        _wait = Nothing
    End Sub

    Public Sub Start() Implements IInitialization.Start
        Dim str_status = String.Empty
        Dim delay As Integer = 500
        Dim progress As Integer = 0

        Show()
        'STEP 1
        str_status = "Initialization"
        UpdateStatus(String.Format("{0}...", str_status), progress)
        progress += 5
        Thread.Sleep(delay)

        'STEP 2 OPEN Configuration
        str_status = "Open DB Configuration"
        progress += 10
        UpdateStatus(String.Format("{0}...", str_status), progress)
        Thread.Sleep(delay)
        If Not _config.Open Then
            UserInterface._frmMain.lbConConf.Image = My.Resources.Config_Disc
            UpdateStatus(String.Format("{0} - Failed", str_status), progress)
            Thread.Sleep(delay)
        Else
            UserInterface._frmMain.lbConConf.Image = My.Resources.Config_Con
            _config.Read()
            UpdateStatus(String.Format("{0} - Success", str_status), progress)
            progress += 5
            Thread.Sleep(delay)
        End If


        'STEP 3 OPEN PRODUCT REFERENCE
        str_status = "Open DB Reference"
        progress += 10
        UpdateStatus(String.Format("{0}...", str_status), progress)
        Thread.Sleep(delay)
        If Not _Reference.Open Then
            UserInterface._frmMain.lbConRef.Image = My.Resources.Database_Disc
            UpdateStatus(String.Format("{0} - Failed", str_status), progress)
            Thread.Sleep(delay)
        Else
            UserInterface._frmMain.lbConRef.Image = My.Resources.Database_Con
            UpdateStatus(String.Format("{0} - Success", str_status), progress)
            progress += 5
            Thread.Sleep(delay)
        End If

        'STEP 4 OPEN MODBUS
        str_status = "Connecting to Modbus"
        progress += 10
        UpdateStatus(String.Format("{0}...", str_status), progress)
        Thread.Sleep(delay)
        If Not _modbus.Start("127.0.0.1") Then
            UserInterface._frmMain.lbConMod.Image = My.Resources.EthernetDisc
            UpdateStatus(String.Format("{0} - Failed", str_status), progress)
            Thread.Sleep(delay)
        Else
            UserInterface._frmMain.lbConMod.Image = My.Resources.ethernet_on
            UpdateStatus(String.Format("{0} - Success", str_status), progress)
            progress += 5
            Thread.Sleep(delay)
        End If

        'STEP 5 OPEN PRODUCTION
        str_status = "Opening Production"
        progress += 10
        UpdateStatus(String.Format("{0}...", str_status), progress)
        Thread.Sleep(delay)
        Try
            _production = Production.getInstance()
            If Not _production.Open() Then
                UserInterface._frmMain.lbConLog.Image = My.Resources.Loggg_Disc
                UpdateStatus(String.Format("{0} - Failed", str_status), progress)
                Thread.Sleep(delay)
            Else
                UserInterface._frmMain.lbConLog.Image = My.Resources.Loggg_Con
                UpdateStatus(String.Format("{0} - Success", str_status), progress)
                progress += 5
                Thread.Sleep(delay)
            End If
        Catch ex As Exception

        End Try




        ''STEP 6 OPEN LABEL
        str_status = "Opening Label"
        progress += 10
        UpdateStatus(String.Format("{0}...", str_status), progress)
        Thread.Sleep(delay)
        Try
            _label = Codesoft.getInstance()
            _label.BasePath = Application.StartupPath
            _label.Open("Individual", TYPE.IND)
            _label.Open("Group", TYPE.GROUP)
            UserInterface._frmMain.lbConCod.Image = My.Resources.Codesoft_con
            UpdateStatus(String.Format("{0} - Success", str_status), progress)
            progress += 5
        Catch ex As Exception
            UserInterface._frmMain.lbConCod.Image = My.Resources.Codesoft_DIsc
            UpdateStatus(String.Format("{0} - Failed", str_status), progress)
        Thread.Sleep(delay)
        'GoTo Finish
        End Try





        'FINISH INItIALIZATION
        progress = 100
        UpdateStatus("Initialization Done...", progress)
        Thread.Sleep(delay)
        Close()



    End Sub



End Class
