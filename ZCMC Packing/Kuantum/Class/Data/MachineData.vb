Public Class MachineData
    Private Shared _instance As MachineData
    Public Enum StepType
        IDLE
        INITIALIZATION
        START

    End Enum

    Public CurrentStep As StepType

    Protected Sub New()
    End Sub

    Public Shared Function getInstance() As MachineData
        If _instance Is Nothing Then
            _instance = New MachineData()
        End If
        Return _instance
    End Function



End Class
