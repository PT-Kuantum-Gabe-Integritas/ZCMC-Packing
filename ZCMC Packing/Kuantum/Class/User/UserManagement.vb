
Imports System.IO
Imports Database

Public Class UserManagement
    Implements IUserManagement
    Private _path As String = Application.StartupPath
    Private _currUser As UserData = Nothing
    Private getdatabase As DBManager = DBManager.getInstance()
    Private _dbUser As SQLite = New SQLite()

    Public UserType_ As USERTYPE


    Public Enum USERTYPE
        OPERATOR_
        ENGINEER_
        QUALITY_
        ADMIN_
    End Enum

    Public Property CurrentUser As UserData
        Get
            Return _currUser
        End Get
        Set(value As UserData)
            _currUser = value
        End Set
    End Property

    Public Sub Initialize()
        _dbUser = getdatabase.GetDataBase("User.db", "US1", "-SQLite", "User")
    End Sub

    Public Function GetPass(type As String, Optional ByRef pass As String = "") As Boolean Implements IUserManagement.GetPass
        Dim autorized As Boolean = False
        Try
            Dim str_where As String = String.Format("user='{0}'", type)
            Dim dt As DataTable = New DataTable()
            dt = _dbUser.DBSelect("pass, authorization", "tb_user", str_where)
            If dt.Rows.Count > 0 Then
                autorized = Convert.ToBoolean(dt.Rows(0).Item("authorization"))

                pass = String.Format("pass = '{0}'", pass)
                Dim result() As DataRow = dt.Select(pass)
                For Each row As DataRow In result
                    pass = row(0)
                Next

            End If
        Catch ex As Exception

        End Try
        Return autorized
    End Function
    Public Function GetPermit(type As String) Implements IUserManagement.GetPermit

        UserInterface._frmMain.panelUser.Visible = True
        UserInterface._frmMain.lbUsername.Text = String.Format("Hi, {0}", type)


        Dim dt As DataTable = New DataTable()
        Try
            Dim str_where As String = String.Format("user='{0}'", type)
            dt = _dbUser.DBSelect("Dashboard, Run, Config, Manual, Reference, LOG, UserManage", "tb_user", str_where)
            UserInterface._frmMain.btnDash.Visible = Integer.Parse(dt.Rows(0).Item("Dashboard").ToString())
            UserInterface._frmMain.btnLog.Visible = Integer.Parse(dt.Rows(0).Item("LOG").ToString())
            UserInterface._frmMain.btnConfig.Visible = Integer.Parse(dt.Rows(0).Item("Config").ToString())
            UserInterface._frmMain.btnRun.Visible = Integer.Parse(dt.Rows(0).Item("Run").ToString())
            UserInterface._frmMain.btnReff.Visible = Integer.Parse(dt.Rows(0).Item("Reference").ToString())
            UserInterface._frmMain.btnUser.Visible = Integer.Parse(dt.Rows(0).Item("UserManage").ToString())
        Catch ex As Exception
            MsgBox("Failed Get User Permission..")
        End Try
        Return dt
    End Function

    Public Function GetUserList() As List(Of String) Implements IUserManagement.GetUserList
        Dim users As List(Of String) = New List(Of String)()
        Try
            Dim dt As DataTable = New DataTable()
            dt = _dbUser.DBSelect("user", "tb_user", "")

            For i As Integer = 0 To dt.Rows.Count - 1
                users.Add(dt.Rows(i).Item("user"))
            Next
        Catch ex As Exception

        End Try

        Return users
    End Function

    Public Function ValidateUser(user As UserData, pass As String) As Boolean Implements IUserManagement.ValidateUser
        Dim auth As Boolean = False
        With user
            .Logged = False
            auth = GetPass(.Type, pass)
            .Authorized = auth
            If Not auth Then
                .Logged = True
            Else
                If .Pass = pass Then
                    .Logged = True
                End If
            End If

            If .Logged Then
                _currUser = user
            End If
            Return .Logged
        End With
    End Function

    Public Function AddUser(user As String, pass As String) As Boolean Implements IUserManagement.AddUser
        Dim _success As Boolean
        Dim str_where As String = ""
        Dim str_val As String = ""
        If user = "ENGINEER_" Then
            str_where = String.Format("(user,pass,authorization,Dashboard,Run,Config,Manual,Reference,LOG,UserManage)")
            str_val = String.Format("('{0}','{1}','true','true','true','true','true','true','true','false')", user, pass)
        ElseIf user = "ADMIN_" Then
            str_where = String.Format("(user,pass,authorization,Dashboard,Run,Config,Manual,Reference,LOG,UserManage)")
            str_val = String.Format("('{0}','{1}','true','true','true','true','true','true','true','true')", user, pass)
        ElseIf user = "OPERATOR_" Then
            str_where = String.Format("(user,pass,authorization,Dashboard,Run,Config,Manual,Reference,LOG,UserManage)")
            str_val = String.Format("('{0}','{1}','false','true','true','false','true','false','false','false')", user, pass)
        End If

        _dbUser.DBInsert("tb_user", str_where, str_val)
        Return _success
    End Function

    Public Sub DeleteUser(param As String) Implements IUserManagement.DeleteUser
        Dim str_where As String = String.Format("ID='{0}'", param)
        _dbUser.DBDelete("tb_user", str_where)
    End Sub

    Public Sub UpdateUser(user As String, pass As String, permit As String) Implements IUserManagement.UpdateUser
        If pass = String.Empty Then
            Dim str_where As String = String.Format("ID = '{0}'", user)
            Dim str_val As String = String.Format("{0}", permit)
            _dbUser.DBUpdate("tb_user", str_val, str_where)
        Else
            Dim str_where As String = String.Format("ID = '{0}'", user)
            Dim str_val As String = String.Format("pass = '{0}'", pass)
            _dbUser.DBUpdate("tb_user", str_val, str_where)
        End If


    End Sub

    Public Sub ClearUser() Implements IUserManagement.ClearUser
        _currUser = Nothing
    End Sub

    Public Function loadTable(param As Boolean) Implements IUserManagement.loadTable
        Dim TableDB As New DataTable
        Try
            TableDB = _dbUser.DBSelect("*", "tb_user", String.Empty)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return TableDB
    End Function
    Public Function Read(ref As String, artno As String) As DataTable Implements IUserManagement.Read
        Dim dt As DataTable = New DataTable()
        Dim str_where As String = ""
        If artno = "" Then
            str_where = String.Format("id = '{0}'", ref)
        ElseIf ref = "" Then
            str_where = String.Format("user = '{0}'", artno)
        Else
            str_where = String.Format("id = '{0}' and user = '{1}' ", artno, ref)
        End If
        dt = _dbUser.DBSelect("*", "tb_user", str_where)
        Return dt
    End Function
End Class
