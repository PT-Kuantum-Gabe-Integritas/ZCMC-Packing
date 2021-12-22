Imports System.Data.SQLite
Imports System.IO
Imports Kuantum

Public Class SQLite

    Implements ISQLite

    Public Enum DBTYPE
        CONFIG
        LOG
        RESULT
    End Enum

    Private _con As SQLiteConnection
    Private _cmd As SQLiteCommand
    Private _dr As SQLiteDataReader

    Private _connectionString As String
    Private _path As String
    Private _isConnected As Boolean

    Public ReadOnly Property isConnected As String
        Get
            Return _isConnected
        End Get
    End Property


    Public Property BasePath As String
        Get
            Return _path
        End Get
        Set(value As String)
            _path = value
        End Set
    End Property


    Public Sub New(Path As String)
        _path = Path
    End Sub

    Public Function GetFolderBase(type As DBTYPE) As String
        Select Case type
            Case DBTYPE.CONFIG
                Return "Config"
            Case DBTYPE.LOG
                Return "Log"
            Case DBTYPE.RESULT
                Return "Result"
            Case Else
                Return "Log"
        End Select
    End Function

    Public Sub FolderExist(path As String)
        If Not Directory.Exists(path) Then
            Directory.CreateDirectory(path)
        End If
    End Sub

    Public Function Open(FileName As String, Type As DBTYPE) As Boolean
        _isConnected = False
        Try
            Dim folderPath As String = Path.Combine(_path, GetFolderBase(Type))
            FolderExist(folderPath)
            _connectionString = "Data Source =" & IO.Path.Combine(folderPath, FileName + ".db") & ";Version=3;"
            _con = New SQLiteConnection(_connectionString)
            _cmd = New SQLiteCommand()
            _con.ParseViaFramework = True
            _con.Open()
            _isConnected = True
        Catch ex As Exception
            _isConnected = False
        End Try
        Return _isConnected
    End Function

    Public Sub Close()
        Try
            If _isConnected Then
                _cmd.Dispose()
                _dr.Close()
                _con.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ExecNonQuery(cmd As String)
        If _isConnected Then
            _cmd = _con.CreateCommand()
            _cmd.CommandText = cmd
            _cmd.ExecuteNonQuery()

        End If
    End Sub

    Public Function ExecQuery(cmd As String) As DataTable
        Dim dt As DataTable = New DataTable()
        If _isConnected Then
            _cmd = _con.CreateCommand()
            _cmd.CommandText = cmd
            _dr = _cmd.ExecuteReader()
            dt.Load(_dr)

        End If
        Return dt
    End Function

    Public Function DBSelect(param As String, table As String, where As String) As DataTable
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

    Public Sub DBUpdate(param As String, table As String, where As String)
        If _isConnected Then
            Dim query As String = ""
            query = String.Format("UPDATE {0} SET {1} WHERE {2}", table, param, where)
            ExecNonQuery(query)
        End If
    End Sub

    Public Sub DBInsert(param As String, table As String, values As String)
        If _isConnected Then
            Dim query As String = ""
            query = String.Format("INSERT INTO {0} (1) VALUES (2)", table, param, values)
            ExecNonQuery(query)
        End If
    End Sub

    Public Function GetDate(_date As Date) As String
        Return String.Format("{0:0000}-{1:00}-{2:00}", _date.Year, _date.Month, _date.Day)
    End Function
End Class
