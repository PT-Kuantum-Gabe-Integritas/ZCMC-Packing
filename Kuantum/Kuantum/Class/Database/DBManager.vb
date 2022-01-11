Imports System.Threading

Public Class DBManager
    Implements IDBManager

    Public DBList As List(Of IDatabase) = New List(Of IDatabase)()
    Private dbL
    Public Property DBTYPE As String
    Public Property FILENAME As String

    Public Sub New(ByVal _filename As String,
                   ByVal _dbType As Database.DATATYPE)
        FILENAME = _filename
        DBTYPE = _dbType

    End Sub

    Public Sub New()

    End Sub

    Public Function GetDataBase(filename As String, uid As String, type As Boolean) As IDatabase Implements IDBManager.GetDataBase
        Dim result = (From db In DBList Where db.UID = uid).ToArray()
        If result.Count > 0 Then
            Return result.ElementAt(0)
        Else
            Add(filename, type, uid)
        End If
        Return dbL
    End Function


    Private Sub Add(filename As String, type As Boolean, uid As String) Implements IDBManager.Add
        Dim sq As SQLite = New SQLite()
        Dim oled As Access = New Access()
        Select Case type
            Case False
                sq.Filename = filename
                sq = New SQLite(filename, Database.DATATYPE.USER)
                sq.UID = uid
                sq.Open()
                DBList.Add(sq)
            Case True
                oled.Filename = filename
                oled = New Access(filename, Database.DATATYPE.USER)
                oled.UID = uid
                oled.Open()
                DBList.Add(oled)
            Case Else
                sq = New Database()
                oled = New Database()
        End Select

    End Sub

End Class