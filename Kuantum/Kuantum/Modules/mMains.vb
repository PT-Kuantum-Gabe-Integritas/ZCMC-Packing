Imports System.Threading



Module mMains
    Private Databasee As DBManager = New DBManager()
    Public Sub Main_Setup()
        Dim str_status = String.Empty
        Dim delay As Integer = 200
        Dim progress As Integer = 0

        _frmSplash.Show()
        str_status = "Initialization..."
        progress += 5
        _frmSplash.setProgress(str_status, progress)
        Thread.Sleep(delay)
        Databasee.Connection()




    End Sub

End Module
