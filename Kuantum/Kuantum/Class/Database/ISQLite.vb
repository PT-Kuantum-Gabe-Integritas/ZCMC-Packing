Public Interface ISQLite
    Function Open(FileName As String, Type As DbType) As Boolean
    Sub Close()
End Interface
