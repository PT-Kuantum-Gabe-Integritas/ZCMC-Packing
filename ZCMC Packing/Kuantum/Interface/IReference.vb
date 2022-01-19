Public Interface IReference
    Function Open() As Boolean
    Function Close() As Boolean
    Function Read(reff As String, artno As String) As DataTable
    Sub Insert(newProduct As ReferenceData)
    Sub Update(product As ReferenceData)
End Interface
