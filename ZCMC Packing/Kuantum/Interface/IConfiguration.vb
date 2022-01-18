Public Interface IConfiguration
    Function Open() As Boolean
    Function Close() As Boolean
    Sub Save(newConfig As ConfigData)
    Function Read() As ConfigData
    Sub SetValue(param As String, val As String)
    Function GetValue(Item As String) As String
End Interface
