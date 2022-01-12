Public Class Initialization

    Private Shared _instance As Initialization

    Protected Sub New()
    End Sub

    Public Shared Function getInstance() As Initialization
        If _instance Is Nothing Then
            _instance = New Initialization()
        End If
        Return _instance
    End Function



End Class
