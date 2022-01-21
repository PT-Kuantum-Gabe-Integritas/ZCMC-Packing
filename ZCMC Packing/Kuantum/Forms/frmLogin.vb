Public Class frmLogin

    'Public Enum USERTYPE
    '    OPERATOR_
    '    ENGINEER_
    '    QUALITY_
    '    ADMIN_
    'End Enum


    Private _newUser As UserData = New UserData()
    Public _userManager As UserManagement = New UserManagement()
    Public _ui As UserInterface

    Public Sub Initialize()
        cb_user.Items.Clear()
        Dim tb As DataTable = _userManager.loadTable()
        For Each row As DataRow In tb.Rows
            If cb_user.Items.Contains(row.Item(1)) Then

            Else
                cb_user.Items.Add(row.Item(1))
            End If
        Next
        cb_user.SelectedIndex = 0
        SetDisplay(False)
    End Sub
    Public Sub SetDisplay(_ut As UserManagement.USERTYPE)
        Select Case _ut
            Case UserManagement.USERTYPE.OPERATOR_
                tb_input.Text = ""
                tb_input.Enabled = True
                lb_info1.Text = "Choose your Role."
                lbInfo2.Text = "Please fill your badge number"
                tb_input.Focus()
                tb_input.PasswordChar = ""
            Case UserManagement.USERTYPE.ENGINEER_
                tb_input.Text = ""
                tb_input.Enabled = True
                lb_info1.Text = "Choose your Role."
                lbInfo2.Text = "Please fill your password"
                tb_input.Focus()
                tb_input.PasswordChar = "*"
            Case UserManagement.USERTYPE.QUALITY_
                tb_input.Text = ""
                tb_input.Enabled = True
                lb_info1.Text = "Choose your Role."
                lbInfo2.Text = "Please fill your password"
                tb_input.Focus()
                tb_input.PasswordChar = "*"
            Case UserManagement.USERTYPE.ADMIN_
                tb_input.Text = ""
                tb_input.Enabled = True
                lb_info1.Text = "Choose your Role."
                lbInfo2.Text = "Please fill your password"
                tb_input.Focus()
                tb_input.PasswordChar = "*"
        End Select
    End Sub
    Private Sub DoLogin()
        With _newUser
            .Type = cb_user.SelectedItem
            If _userManager.GetPass(.Type) Then
                .Pass = tb_input.Text
            Else
                .Name = tb_input.Text
            End If

        End With
        If _userManager.ValidateUser(_newUser, tb_input.Text) Then


            _userManager.GetPermit(_newUser.Type)
            _ui.LoadPanel(UserInterface.TAB.RUN)
            UserInterface._frmMain.lbUser.Text = _newUser.Type
            UserInterface._frmMain.pbAccount.Image = My.Resources.account

            Me.Hide()

        Else
            lb_info1.Text = "Wrong Password!"
            lb_info1.ForeColor = Color.Red
            tb_input.Text = ""
            tb_input.Focus()
        End If
    End Sub

    Private Sub cb_user_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_user.SelectedIndexChanged

        _userManager.UserType_ = DirectCast([Enum].Parse(GetType(UserManagement.USERTYPE), cb_user.SelectedItem.ToString()), UserManagement.USERTYPE)
        SetDisplay(_userManager.UserType_)
    End Sub

    Private Sub tb_input_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_input.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Then
            DoLogin()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        _userManager.Initialize()
        Initialize()
        _ui = UserInterface.getInstance()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        DoLogin()
    End Sub
End Class