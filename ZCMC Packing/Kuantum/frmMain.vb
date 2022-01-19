

Public Class frmMain

    Private initialization As Initialization = Initialization.getInstance()
    Private _production As Production = Production.getInstance()
    Private _ui As UserInterface = UserInterface.getInstance()
    Private last_btn As ToolStripButton

    Private Sub Button(bt As ToolStripButton)
        Try
            last_btn.BackgroundImage = Nothing
        Catch ex As Exception

        End Try
        bt.BackgroundImage = My.Resources.Click1
        last_btn = bt
    End Sub

    Private Sub btnShow(bt As ToolStripButton)
        bt.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        bt.Width = 160
        bt.Height = 60
    End Sub

    Private Sub btnHide(bt As ToolStripButton)
        bt.DisplayStyle = ToolStripItemDisplayStyle.Image
        bt.Width = 65
        bt.Height = 60
    End Sub


    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles btnRun.Click, btnReff.Click, btnManual.Click, btnLog.Click, btnDash.Click, btnConfig.Click, btnAbout.Click
        Button(sender)
        _ui.LoadPanel(sender)
    End Sub

    Private Sub ButtonEnter(sender As Object, e As EventArgs) Handles btnUser.MouseEnter, btnRun.MouseEnter, btnReff.MouseEnter, btnManual.MouseEnter, btnLog.MouseEnter, btnDash.MouseEnter, btnConfig.MouseEnter, btnAbout.MouseEnter
        btnShow(sender)

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        UserInterface._frmMain = Me
        Me.Hide()
        'Start Production 
        _production.Starts()
        HideAll()
        Me.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _production.CloseALL()
        Me.Close()
    End Sub



    Sub HideAll()
        panelUser.Visible = False
        btnDash.Visible = False
        btnLog.Visible = False
        btnRun.Visible = False
        btnReff.Visible = False
        btnConfig.Visible = False
        btnUser.Visible = False

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        HideAll()
        _ui.LoadPanel(UserInterface.TAB.LOGIN)
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Dim _frmUserManagement As frmUserManagement = New frmUserManagement()
        _frmUserManagement.Show()
    End Sub
End Class
