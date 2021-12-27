
Imports System.Data.OleDb
Imports Kuantum
Imports System.IO
Public Class Access
    Implements IDatabase
    Private _con As OleDbConnection
    Private _cmd As OleDbCommand
    Private _dr As OleDbDataReader

    Private _connectionString As String
    Private _path As String
    Private _isConnected As Boolean

    Public Enum DBTYPE
        CONFIG
        LOG
        RESULT

    End Enum

    Public Function GetFolderBase(type As DbType) As String
        Select Case type
            Case DbType.CONFIG
                Return "Config"
            Case DbType.LOG
                Return "Log"
            Case DbType.RESULT
                Return "Result"
            Case Else
                Return "Log"
        End Select
    End Function

    Public Property BasePath As String Implements IDatabase.BasePath
        Get
            Return _path
        End Get
        Set(value As String)
            _path = value
        End Set
    End Property

    Public ReadOnly Property isConnected As String Implements IDatabase.isConnected
        Get
            Return _isConnected
        End Get
    End Property

    Public Sub Close() Implements IDatabase.Close
        Try
            If _isConnected Then
                _cmd.Dispose()
                _dr.Close()
                _con.Close()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub DBInsert(param As String, table As String, values As String) Implements IDatabase.DBInsert
        If _isConnected Then
            Dim query As String = ""
            query = String.Format("INSERT INTO {0} {1} VALUES {2}", table, param, values)
            ExecNonQuery(query)
        End If
    End Sub

    Public Sub DBUpdate(param As String, table As String, where As String) Implements IDatabase.DBUpdate
        If _isConnected Then
            Dim query As String = ""
            query = String.Format("UPDATE {0} SET {1} WHERE {2}", table, param, where)
            ExecNonQuery(query)
        End If
    End Sub

    Public Sub ExecNonQuery(cmd As String) Implements IDatabase.ExecNonQuery
        If _isConnected Then
            _cmd = _con.CreateCommand()
            _cmd.CommandText = cmd
            _cmd.ExecuteNonQuery()

        End If
    End Sub

    Public Sub FolderExist(path As String) Implements IDatabase.FolderExist
        If Not Directory.Exists(path) Then
            Directory.CreateDirectory(path)
        End If
    End Sub

    Public Function DBSelect(param As String, table As String, where As String) As DataTable Implements IDatabase.DBSelect
        Dim dt As DataTable = New DataTable()
        If _isConnected Then
            Dim query As String = ""
            If where = String.Empty Then
                query = String.Format("SELECT {0} FROM {1}",
                                            param, table)
            Else
                query = String.Format("SELECT {0} FROM {1} WHERE {2}",
                                            param, table, where)

            End If
            dt = ExecQuery(query)
        End If
        Return dt
    End Function

    Public Function ExecQuery(cmd As String) As DataTable Implements IDatabase.ExecQuery
        Dim dt As DataTable = New DataTable()
        If _isConnected Then
            _cmd = _con.CreateCommand()
            _cmd.CommandText = cmd
            _dr = _cmd.ExecuteReader()
            dt.Load(_dr)

        End If
        Return dt
    End Function

    Public Function GetDate(_date As Date) As String Implements IDatabase.GetDate
        Return String.Format("{0:0000}-{1:00}-{2:00}", _date.Year, _date.Month, _date.Day)
    End Function

    Public Function Open(FileName As String, Type As Data.DbType) As Boolean Implements IDatabase.Open
        _isConnected = False
        Try
            Dim folderPath As String = Path.Combine(_path, GetFolderBase(Type))
            FolderExist(folderPath)
            _connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & IO.Path.Combine(folderPath, FileName + ".mdb") & ";Jet OLEDB:Database;"
            _con = New OleDbConnection(_connectionString)
            _cmd = New OleDbCommand()
            _con.Open()
            _isConnected = True
        Catch ex As Exception
            _isConnected = False
        End Try
        Return _isConnected
    End Function


End Class
