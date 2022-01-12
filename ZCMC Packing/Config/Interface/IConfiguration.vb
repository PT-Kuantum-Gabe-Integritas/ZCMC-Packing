Public Interface IConfiguration
    'Function Open() As Boolean
    Function Close() As Boolean
    Sub Save(newConfig As ConfigData)
End Interface
