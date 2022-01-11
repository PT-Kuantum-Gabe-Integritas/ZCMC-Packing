Public Interface IDBManager
    Function GetDataBase(filename As String, uid As String, type As Boolean, Folder As Database.DATATYPE) As IDatabase
    Sub Add(filename As String, type As Boolean, uid As String, Folder As Database.DATATYPE)

End Interface
