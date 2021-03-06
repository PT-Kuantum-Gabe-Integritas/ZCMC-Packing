Public Interface IDatabase
    Function DBSelect(param As String, table As String, where As String) As DataTable
    Sub DBInsert(table As String, param As String, values As String)
    Sub DBUpdate(table As String, param As String, where As String)
    Sub DBDelete(table As String, where As String)
    Function GetDate(_date As Date) As String
    Sub FolderExist(path As String)
    ReadOnly Property isConnected As Boolean
    Property BasePath As String
    Property Filename As String
    Sub Open()
    Sub Close()
    Property UID As String
End Interface
