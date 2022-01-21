Public Class formMain
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

    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles btnRun.Click, btnReff.Click, btnManual.Click, btnLog.Click, btnDash.Click, btnConfig.Click, btnAbout.Click, btnUser.Click
        Button(sender)
        _ui.LoadPanel(sender)
    End Sub

    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        UserInterface._frmMain = Me
        Me.Hide()
        'Start Production 
        _production.Starts()
        HideAll()
        Me.Show()

    End Sub

    Sub HideAll()
        'panelUser.Visible = False
        'btnLogout.Visible = False
        btnLogout.Visible = False
        btnDash.Visible = False
        btnLog.Visible = False
        btnRun.Visible = False
        btnReff.Visible = False
        btnConfig.Visible = False
        btnUser.Visible = False

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        _ui.LoadPanel(UserInterface.TAB.LOGIN)
        btnLogout.Visible = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        _production.Stops()
        Me.Close()
    End Sub

End Class