﻿Imports Database
Imports System.Threading
Imports System.IO
Imports System.Data.SQLite
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class Databasemain
    Implements IDatabase

    Public _isConnected As Boolean
    Public _path = Application.StartupPath
    Public _connectionString As String
    Public _con
    Public _cmd
    Public Data
    Public _fn

    Public Property Filename As String Implements IDatabase.Filename
        Get
            Return _fn
        End Get
        Set(value As String)
            value = _fn
        End Set
    End Property
    Public Property UID As String Implements IDatabase.UID


    Enum DATATYPE
        CONFIG
        USER
    End Enum

    Public Property BasePath As String Implements IDatabase.BasePath
        Get
            Return _path
        End Get
        Set(value As String)
            _path = value
        End Set
    End Property

    'Public Sub New(Path As String)
    '    _path = Path
    'End Sub

    Public Function GetFolderBase(type As String) As String
        Dim str As String = String.Empty
        str = String.Format("Database\{0}", type)
        Return str
    End Function


    Public ReadOnly Property isConnected As Boolean Implements IDatabase.isConnected
        Get
            Return _isConnected

        End Get
    End Property

    Public Sub DBInsert(table As String, param As String, values As String) Implements IDatabase.DBInsert
        Dim query As String = ""
        If _isConnected Then
            query = String.Format("INSERT INTO {0} {1} VALUES {2}", table, param, values)
        End If
        ExecNonQuery(query)
    End Sub

    Public Sub DBUpdate(table As String, param As String, where As String) Implements IDatabase.DBUpdate
        Dim query As String = ""
        If _isConnected Then
            query = String.Format("UPDATE {0} SET {1} WHERE {2}", table, param, where)
        End If
        ExecNonQuery(query)
    End Sub

    Public Sub DBDelete(table As String, where As String) Implements IDatabase.DBDelete
        Dim query As String = ""
        If _isConnected Then
            query = String.Format("DELETE FROM {0} WHERE {1}", table, where)
        End If
        ExecNonQuery(query)
    End Sub

    Public Sub FolderExist(path As String) Implements IDatabase.FolderExist
        If Not Directory.Exists(path) Then
            Directory.CreateDirectory(path)
        End If
    End Sub

    Public Function DBSelect(param As String, table As String, where As String) As DataTable Implements IDatabase.DBSelect
        Dim query As String = ""
        Dim dt As DataTable
        If _isConnected Then
            If where = String.Empty Then
                query = String.Format("SELECT {0} FROM {1}",
                                            param, table)
            Else
                query = String.Format("SELECT {0} FROM {1} WHERE {2}",
                                            param, table, where)

            End If
        End If
        dt = ExecQuery(query)
        Return dt
    End Function
    'Public Function DBLoad(table As String, ByVal tbl As DataTable, ByVal cn As SQLiteConnection)
    '    Dim query As String = ""
    '    query = String.Format("SELECT * FROM {0}", table)
    '    Dim SQLiteDA As New SQLiteDataAdapter(query, cn)
    '    SQLiteDA.Fill(tbl)
    '    SQLiteDA.Dispose()
    '    SQLiteDA = Nothing
    'End Function
    Public Function GetDate(_date As Date) As String Implements IDatabase.GetDate
        Return String.Format("{0:0000}-{1:00}-{2:00}", _date.Year, _date.Month, _date.Day)
    End Function


    Public Overridable Sub Open() Implements IDatabase.Open

    End Sub

    Public Overridable Sub Close() Implements IDatabase.Close

    End Sub

    Public Overridable Sub ExecNonQuery(cmd As String)

    End Sub
    Public Overridable Function ExecQuery(cmd As String) As DataTable
        Dim dt As DataTable = New DataTable()

        Return dt
    End Function
End Class
