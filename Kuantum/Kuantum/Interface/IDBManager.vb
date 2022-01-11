Public Interface IDBManager
    Function GetDataBase(filename As String, uid As String, type As Boolean) As IDatabase
    Sub Add(filename As String, type As Boolean, uid As String)

End Interface
