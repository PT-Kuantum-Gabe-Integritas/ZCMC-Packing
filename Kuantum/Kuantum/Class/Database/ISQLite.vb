Public Interface ISQLite
    Function Open(FileName As String, Type As DbType) As Boolean
    Sub Close()
    Sub ExecNonQuery(cmd As String)
    Function ExecQuery(cmd As String) As DataTable
    Function DBSelect(param As String, table As String, where As String) As DataTable
    Sub DBUpdate(param As String, table As String, where As String)
    Sub DBInsert(param As String, table As String, values As String)
End Interface
