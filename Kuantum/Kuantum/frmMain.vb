Public Class frmMain
    Private last_btn As ToolStripButton


    Public Enum TAB
        DASHBOARD
        RUN
        CONFIG
        MANUAL
        REFERENCE
        LOG
        LOGIN
        ABOUT
    End Enum


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


    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles btnDash.Click, btnRun.Click, btnManual.Click, btnLog.Click, btnConfig.Click, btnAbout.Click, btnReff.Click
        Button(sender)
        LoadPanel(sender)
    End Sub

    Private Sub ButtonEnter(sender As Object, e As EventArgs) Handles btnDash.MouseEnter, btnRun.MouseEnter, btnManual.MouseEnter, btnLog.MouseEnter, btnConfig.MouseEnter, btnAbout.MouseEnter, btnReff.MouseEnter
        btnShow(sender)

    End Sub

    Private Sub ButtonLeave(sender As Object, e As EventArgs) Handles btnDash.MouseLeave, btnRun.MouseLeave, btnManual.MouseLeave, btnLog.MouseLeave, btnConfig.MouseLeave, btnAbout.MouseLeave, btnReff.MouseLeave
        'btnHide(sender)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Public Sub LoadPanel(_tab As ToolStripButton)
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        If Me.InvokeRequired Then
            Me.Invoke(Sub() LoadPanel(_tab.Tag))
        End If

        Select Case _tab.Tag
            Case "Dashboard"
                _frmHome.TopLevel = False
                _frmHome.TopMost = True
                _frmHome.Dock = DockStyle.Fill
                mainPanel.Controls.Clear()
                mainPanel.Controls.Add(_frmHome)
                _frmHome.Show()
                lbMenu.Text = "Dashboard"

            Case "Configuration"
                'Code
                _frmConfig.TopLevel = False
                _frmConfig.TopMost = True
                _frmConfig.Dock = DockStyle.Fill
                mainPanel.Controls.Clear()
                mainPanel.Controls.Add(_frmConfig)
                _frmConfig.Show()
                lbMenu.Text = "Configuration"

            Case "Product Selection"
                'Code
                _frmRun.TopLevel = False
                _frmRun.TopMost = True
                _frmRun.Dock = DockStyle.Fill
                mainPanel.Controls.Clear()
                mainPanel.Controls.Add(_frmRun)
                _frmRun.Show()
                lbMenu.Text = "Product Selection"

            Case "Manual Test"
                'Code
                _frmManual.TopLevel = False
                _frmManual.TopMost = True
                _frmManual.Dock = DockStyle.Fill
                mainPanel.Controls.Clear()
                mainPanel.Controls.Add(_frmManual)
                _frmManual.Show()
                lbMenu.Text = "Manual Run"

            Case "Data Reference"
                'Code
                _frmReference.TopLevel = False
                _frmReference.TopMost = True
                _frmReference.Dock = DockStyle.Fill
                mainPanel.Controls.Clear()
                mainPanel.Controls.Add(_frmReference)
                _frmReference.Show()
                lbMenu.Text = "Product Database"

            Case "Data Log"
                'Code
                _frmLog.TopLevel = False
                _frmLog.TopMost = True
                _frmLog.Dock = DockStyle.Fill
                mainPanel.Controls.Clear()
                mainPanel.Controls.Add(_frmLog)
                _frmLog.Show()
                lbMenu.Text = "Production Log"


        End Select
    End Sub

    Public Sub LoadPanel(_tab As TAB)
        ' System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        If Me.InvokeRequired Then
            Me.Invoke(Sub() LoadPanel(_tab))
        End If

        Select Case _tab
            Case TAB.DASHBOARD
                _frmHome.TopLevel = False
                _frmHome.TopMost = True
                _frmHome.Dock = DockStyle.Fill
                mainPanel.Controls.Clear()
                mainPanel.Controls.Add(_frmHome)
                _frmHome.Show()
                lbMenu.Text = "Dashboard"

            Case TAB.CONFIG
                'Code
                _frmConfig.TopLevel = False
                _frmConfig.TopMost = True
                _frmConfig.Dock = DockStyle.Fill
                mainPanel.Controls.Clear()
                mainPanel.Controls.Add(_frmConfig)
                _frmConfig.Show()
                lbMenu.Text = "Configuration"

            Case TAB.RUN
                'Code
                _frmRun.TopLevel = False
                _frmRun.TopMost = True
                _frmRun.Dock = DockStyle.Fill
                mainPanel.Controls.Clear()
                mainPanel.Controls.Add(_frmRun)
                _frmRun.Show()
                lbMenu.Text = "Product Selection"

            Case TAB.MANUAL
                'Code
                _frmManual.TopLevel = False
                _frmManual.TopMost = True
                _frmManual.Dock = DockStyle.Fill
                mainPanel.Controls.Clear()
                mainPanel.Controls.Add(_frmManual)
                _frmManual.Show()
                lbMenu.Text = "Manual Run"

            Case TAB.REFERENCE
                'Code
                _frmReference.TopLevel = False
                _frmReference.TopMost = True
                _frmReference.Dock = DockStyle.Fill
                mainPanel.Controls.Clear()
                mainPanel.Controls.Add(_frmReference)
                _frmReference.Show()
                lbMenu.Text = "Product Database"

            Case TAB.LOG
                'Code
                _frmLog.TopLevel = False
                _frmLog.TopMost = True
                _frmLog.Dock = DockStyle.Fill
                mainPanel.Controls.Clear()
                mainPanel.Controls.Add(_frmLog)
                _frmLog.Show()
                lbMenu.Text = "Production Log"

            Case TAB.LOGIN


        End Select
    End Sub

    Private Sub ToolStrip1_Leave(sender As Object, e As EventArgs) Handles ToolStrip1.Leave

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        LoadPanel(TAB.REFERENCE)
    End Sub
End Class
