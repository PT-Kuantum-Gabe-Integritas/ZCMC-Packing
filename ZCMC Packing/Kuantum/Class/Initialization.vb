Imports System.Threading
Imports Splash
Imports Config

Public Class Initialization
    Implements IInitialization
    Private Shared _instance As Initialization



    'Object Instance
    Dim _machine As MachineData = MachineData.getInstance()
    Dim _config As Configuration = Configuration.getInstance()
    Private _frmSplash As frmSplash = New frmSplash()


    Protected Sub New()
    End Sub

    Public Shared Function getInstance() As Initialization
        If _instance Is Nothing Then
            _instance = New Initialization()
        End If
        Return _instance
    End Function

    Public Sub Start() Implements IInitialization.Start
        Dim str_status = String.Empty
        Dim delay As Integer = 200
        Dim progress As Integer = 0
        _machine.CurrentStep = MachineData.StepType.INITIALIZATION
        _frmSplash.Show()
        'STEP 1
        str_status = "Initialization..."
        progress += 10
        _frmSplash.setProgress(str_status, progress)
        Thread.Sleep(delay)

        'STEP 2 OPEN Configuration
        str_status = "Open DB Configuration..."
        progress += 10
        _frmSplash.setProgress(str_status, progress)
        If Not _config.Open Then
            str_status = "Failed to Open DB Configuration...."
            _frmSplash.setProgress(str_status, progress)
            Thread.Sleep(delay)
            GoTo Finish
        End If
        str_status = "Success Open DB Configuration..."
        progress += 5
        _frmSplash.setProgress(str_status, progress)
        Thread.Sleep(delay)


        'STEP 3 OPEN PRODUCT REFERENCE
        str_status = "Open DB Reference.."




Finish:
        _frmSplash.Close()




    End Sub





End Class
