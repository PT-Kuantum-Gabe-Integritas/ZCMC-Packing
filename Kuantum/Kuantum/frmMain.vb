Public Class frmMain
    Private tet As Integer = 5
    Private teuut As Integer = 5

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        pnlBlue.Width = btnDashboard.Width
        pnlBlue.Top = btnDashboard.Top + btnDashboard.Height
        pnlBlue.Left = btnDashboard.Left
        btnDashboard.BackColor = Color.FromArgb(20, 124, 81)
        lbMenu.Text = "Dashboard"
        'Write Code


    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        pnlBlue.Width = btnConfig.Width
        pnlBlue.Top = btnConfig.Top + btnConfig.Height
        pnlBlue.Left = btnConfig.Left
        btnConfig.BackColor = Color.FromArgb(20, 124, 81)
        lbMenu.Text = "Config"
        'Write Code

    End Sub

    Private Sub btnReference_Click(sender As Object, e As EventArgs) Handles btnReference.Click
        pnlBlue.Width = btnReference.Width
        pnlBlue.Top = btnReference.Top + btnReference.Height
        pnlBlue.Left = btnReference.Left
        btnReference.BackColor = Color.FromArgb(20, 124, 81)
        lbMenu.Text = "Reference"
        'Write Code


    End Sub

    Private Sub btnManual_Click(sender As Object, e As EventArgs) Handles btnManual.Click
        pnlBlue.Width = btnManual.Width
        pnlBlue.Top = btnManual.Top + btnManual.Height
        pnlBlue.Left = btnManual.Left
        btnManual.BackColor = Color.FromArgb(20, 124, 81)
        lbMenu.Text = "Manual"
        'Write Code


    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        pnlBlue.Width = btnLog.Width
        pnlBlue.Top = btnLog.Top + btnLog.Height
        pnlBlue.Left = btnLog.Left
        btnLog.BackColor = Color.FromArgb(20, 124, 81)
        lbMenu.Text = "Log"
        'Write Code


    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        pnlBlue.Width = btnAbout.Width
        pnlBlue.Top = btnAbout.Top + btnAbout.Height
        pnlBlue.Left = btnAbout.Left
        btnAbout.BackColor = Color.FromArgb(20, 124, 81)
        lbMenu.Text = "Software About"
        'Write Code

    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        pnlBlue.Width = btnRun.Width
        pnlBlue.Top = btnRun.Top + btnRun.Height
        pnlBlue.Left = btnRun.Left
        btnRun.BackColor = Color.FromArgb(20, 124, 81)
        lbMenu.Text = "Software About"
        'Write Code
    End Sub



#Region "LEAVE BUTTON"
    Private Sub btnDashboard_Leave(sender As Object, e As EventArgs) Handles btnDashboard.Leave
        btnDashboard.BackColor = Color.FromArgb(40, 172, 108)
    End Sub

    Private Sub btnConfig_Leave(sender As Object, e As EventArgs) Handles btnConfig.Leave
        btnConfig.BackColor = Color.FromArgb(40, 172, 108)
    End Sub

    Private Sub btnReference_Leave(sender As Object, e As EventArgs) Handles btnReference.Leave
        btnReference.BackColor = Color.FromArgb(40, 172, 108)
    End Sub

    Private Sub btnManual_Leave(sender As Object, e As EventArgs) Handles btnManual.Leave
        btnManual.BackColor = Color.FromArgb(40, 172, 108)
    End Sub

    Private Sub btnLog_Leave(sender As Object, e As EventArgs) Handles btnLog.Leave
        btnLog.BackColor = Color.FromArgb(40, 172, 108)
    End Sub

    Private Sub btnAbout_Leave(sender As Object, e As EventArgs) Handles btnAbout.Leave
        btnAbout.BackColor = Color.FromArgb(40, 172, 108)
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.FromArgb(40, 172, 108)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnRun_Leave(sender As Object, e As EventArgs) Handles btnRun.Leave
        btnRun.BackColor = Color.FromArgb(40, 172, 108)
    End Sub

#End Region



End Class
