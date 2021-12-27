Public Interface IDatabase
    Sub ExecNonQuery(cmd As String)
    Function ExecQuery(cmd As String) As DataTable
    Function DBSelect(param As String, table As String, where As String) As DataTable
    Sub DBUpdate(param As String, table As String, where As String)
    Sub DBInsert(param As String, table As String, values As String)
    Function Open(FileName As String, Type As Data.DbType) As Boolean
    Sub Close()
    Function GetDate(_date As Date) As String
    Sub FolderExist(path As String)
    ReadOnly Property isConnected As String
    Property BasePath As String


End Interface
