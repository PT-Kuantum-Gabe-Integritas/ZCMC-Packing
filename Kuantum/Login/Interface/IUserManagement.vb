﻿Public Interface IUserManagement

    Function GetPass(type As String, Optional ByRef pass As String = "") As Boolean
    Function GetUserList() As List(Of String)
    Function ValidateUser(user As UserData) As Boolean
    Function AddUser()
    Sub ClearUser()
    Function Open() As Boolean
    Sub Close()
End Interface
