Public Class UserInterface

    Private Shared _instance As UserInterface

    Public Sub New()

    End Sub

    Public Shared Function getInstance() As UserInterface
        If _instance Is Nothing Then
            _instance = New UserInterface()
        End If
        Return _instance
    End Function


    'List of Form
    Public Shared _frmRun As frmRun = New frmRun()
    Public Shared _frmHome As frmHome = New frmHome()
    Public Shared _frmReff As frmReference = New frmReference()
    Public Shared _frmConfig As frmConfig = New frmConfig()
    Public Shared _frmLog As frmLog = New frmLog()
    Public Shared _frmMain As frmMain = New frmMain()
    Public Shared _frmAbout As frmAbout = New frmAbout()


    Public Enum TAB
        DASHBOARD
        RUN
        CONFIG
        MANUAL
        REFERENCE
        LOG
        LOGIN
        USER
        ABOUT
    End Enum


    Public Sub LoadPanel(_tab As ToolStripButton)
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        If _frmMain Is Nothing Then Exit Sub
        If _frmMain.InvokeRequired Then
            _frmMain.Invoke(Sub() DoLoadPanel(_tab))
        Else
            DoLoadPanel(_tab)
        End If
    End Sub

    Public Sub LoadPanel(_tab As TAB)
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        If _frmMain Is Nothing Then Exit Sub
        If _frmMain.InvokeRequired Then
            _frmMain.Invoke(Sub() DoLoadPanel(_tab))
        Else
            DoLoadPanel(_tab)
        End If
    End Sub


    Public Shared Sub DoLoadPanel(_tab As ToolStripButton)
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        '_frmMain = Me

        Select Case _tab.Tag
            Case "Dashboard"

                _frmHome.TopLevel = False
                _frmHome.TopMost = True
                _frmHome.Dock = DockStyle.Fill
                _frmMain.mainPanel.Controls.Clear()
                _frmMain.mainPanel.Controls.Add(_frmHome)
                _frmHome.Show()
                _frmMain.lbMenu.Text = "Dashboard"

            Case "Configuration"
                'Code
                _frmConfig.TopLevel = False
                _frmConfig.TopMost = True
                _frmConfig.Dock = DockStyle.Fill
                _frmMain.mainPanel.Controls.Clear()
                _frmMain.mainPanel.Controls.Add(_frmConfig)
                _frmConfig.Show()
                _frmMain.lbMenu.Text = "Configuration"

            Case "Product Selection"
                'Code
                _frmRun.TopLevel = False
                _frmRun.TopMost = True
                _frmRun.Dock = DockStyle.Fill
                _frmMain.mainPanel.Controls.Clear()
                _frmMain.mainPanel.Controls.Add(_frmRun)
                _frmRun.Show()
                _frmMain.lbMenu.Text = "Product Selection"

            Case "Data Reference"
                'Code
                _frmReff.TopLevel = False
                _frmReff.TopMost = True
                _frmReff.Dock = DockStyle.Fill
                _frmMain.mainPanel.Controls.Clear()
                _frmMain.mainPanel.Controls.Add(_frmReff)
                _frmReff.Show()
                _frmMain.lbMenu.Text = "Product Database"

            Case "Data Log"
                'Code
                _frmLog.TopLevel = False
                _frmLog.TopMost = True
                _frmLog.Dock = DockStyle.Fill
                _frmMain.mainPanel.Controls.Clear()
                _frmMain.mainPanel.Controls.Add(_frmLog)
                _frmLog.Show()
                _frmMain.lbMenu.Text = "Production Log"

            Case "User"
                '_frmLog.TopLevel = False
                '_frmLog.TopMost = True
                '_frmLog.Dock = DockStyle.Fill
                '_frmMain.mainPanel.Controls.Clear()
                '_frmMain.mainPanel.Controls.Add(_frmLog)
                '_frmLog.Show()
                _frmMain.lbMenu.Text = "User Management"

            Case "About"
                'Code
                _frmAbout.TopLevel = False
                _frmAbout.TopMost = True
                _frmAbout.Dock = DockStyle.Fill
                _frmMain.mainPanel.Controls.Clear()
                _frmMain.mainPanel.Controls.Add(_frmAbout)
                _frmAbout.Show()
                _frmMain.lbMenu.Text = "Production Log"




        End Select
    End Sub


    Public Shared Sub DoLoadPanel(_tab As TAB)

        Select Case _tab
            Case TAB.DASHBOARD
                _frmHome.TopLevel = False
                _frmHome.TopMost = True
                _frmHome.Dock = DockStyle.Fill
                _frmMain.mainPanel.Controls.Clear()
                _frmMain.mainPanel.Controls.Add(_frmHome)
                _frmHome.Show()
                _frmMain.lbMenu.Text = "Dashboard"

            Case TAB.CONFIG
                'Code
                _frmConfig.TopLevel = False
                _frmConfig.TopMost = True
                _frmConfig.Dock = DockStyle.Fill
                _frmMain.mainPanel.Controls.Clear()
                _frmMain.mainPanel.Controls.Add(_frmConfig)
                _frmConfig.Show()
                _frmMain.lbMenu.Text = "Configuration"

            Case TAB.RUN
                'Code
                _frmRun.TopLevel = False
                _frmRun.TopMost = True
                _frmRun.Dock = DockStyle.Fill
                _frmMain.mainPanel.Controls.Clear()
                _frmMain.mainPanel.Controls.Add(_frmRun)
                _frmRun.Show()
                _frmMain.lbMenu.Text = "Product Selection"

                '    Case TAB.MANUAL
                '        'Code
                '        _frmManual.TopLevel = False
                '        _frmManual.TopMost = True
                '        _frmManual.Dock = DockStyle.Fill
                '        mainPanel.Controls.Clear()
                '        mainPanel.Controls.Add(_frmManual)
                '        _frmManual.Show()
                '        lbMenu.Text = "Manual Run"

            Case TAB.REFERENCE
                'Code
                _frmReff.TopLevel = False
                _frmReff.TopMost = True
                _frmReff.Dock = DockStyle.Fill
                _frmMain.mainPanel.Controls.Clear()
                _frmMain.mainPanel.Controls.Add(_frmReff)
                _frmReff.Show()

                _frmMain.lbMenu.Text = "Product Database"

            Case TAB.LOG
                'Code
                _frmLog.TopLevel = False
                _frmLog.TopMost = True
                _frmLog.Dock = DockStyle.Fill
                _frmMain.mainPanel.Controls.Clear()
                _frmMain.mainPanel.Controls.Add(_frmLog)
                _frmLog.Show()
                _frmMain.lbMenu.Text = "Production Log"

            Case TAB.LOGIN
                'Code
                '_frmLogin.TopLevel = False
                '_frmLogin.TopMost = True
                '_frmLogin.Dock = DockStyle.Fill
                'mainPanel.Controls.Clear()
                'mainPanel.Controls.Add(_frmLogin)
                '_frmLogin.Show()
                _frmMain.lbMenu.Text = "User Management"

        End Select
    End Sub





End Class
