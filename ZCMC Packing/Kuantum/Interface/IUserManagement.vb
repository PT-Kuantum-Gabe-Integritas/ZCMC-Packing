Public Interface IUserManagement

    Function GetPass(type As String, Optional ByRef pass As String = "") As Boolean
    Function GetPermit(type As String)
    Function GetUserList() As List(Of String)
    Function ValidateUser(user As UserData, pass As String) As Boolean
    Function AddUser(user As String, pass As String) As Boolean
    Function loadTable(param As Boolean)
    Sub ClearUser()
    Sub DeleteUser(param As String)
    Sub UpdateUser(user As String, pass As String, permit As String)
    Function Read(ref As String, artno As String) As DataTable

End Interface
