<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbUser = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbMenu = New System.Windows.Forms.Label()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pbAccount = New System.Windows.Forms.PictureBox()
        Me.lbConLog = New System.Windows.Forms.Label()
        Me.lbConConf = New System.Windows.Forms.Label()
        Me.lbConRef = New System.Windows.Forms.Label()
        Me.lbConCod = New System.Windows.Forms.Label()
        Me.lbConMod = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDash = New System.Windows.Forms.ToolStripButton()
        Me.btnRun = New System.Windows.Forms.ToolStripButton()
        Me.btnConfig = New System.Windows.Forms.ToolStripButton()
        Me.btnManual = New System.Windows.Forms.ToolStripButton()
        Me.btnReff = New System.Windows.Forms.ToolStripButton()
        Me.btnLog = New System.Windows.Forms.ToolStripButton()
        Me.btnAbout = New System.Windows.Forms.ToolStripButton()
        Me.btnUser = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pbAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Green
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDash, Me.btnRun, Me.btnConfig, Me.btnManual, Me.btnReff, Me.btnLog, Me.btnAbout, Me.btnUser})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 509)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1325, 81)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lbMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1325, 152)
        Me.Panel1.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.btnMinimize)
        Me.Panel4.Controls.Add(Me.btnClose)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(817, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(508, 115)
        Me.Panel4.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.Controls.Add(Me.btnLogout)
        Me.Panel5.Controls.Add(Me.lbUser)
        Me.Panel5.Controls.Add(Me.pbAccount)
        Me.Panel5.Location = New System.Drawing.Point(293, 52)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(212, 57)
        Me.Panel5.TabIndex = 6
        '
        'lbUser
        '
        Me.lbUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbUser.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUser.ForeColor = System.Drawing.Color.White
        Me.lbUser.Location = New System.Drawing.Point(2, 32)
        Me.lbUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(127, 22)
        Me.lbUser.TabIndex = 5
        Me.lbUser.Text = "User"
        Me.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnMinimize.Location = New System.Drawing.Point(442, 2)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimize.TabIndex = 3
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnClose.Location = New System.Drawing.Point(476, 2)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lbConLog)
        Me.Panel3.Controls.Add(Me.lbConConf)
        Me.Panel3.Controls.Add(Me.lbConRef)
        Me.Panel3.Controls.Add(Me.lbConCod)
        Me.Panel3.Controls.Add(Me.lbConMod)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(336, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(481, 115)
        Me.Panel3.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(336, 115)
        Me.Panel2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(170, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ZCMC Pack"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbMenu
        '
        Me.lbMenu.BackColor = System.Drawing.Color.Gray
        Me.lbMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbMenu.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMenu.ForeColor = System.Drawing.Color.White
        Me.lbMenu.Location = New System.Drawing.Point(0, 115)
        Me.lbMenu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbMenu.Name = "lbMenu"
        Me.lbMenu.Size = New System.Drawing.Size(1325, 37)
        Me.lbMenu.TabIndex = 3
        Me.lbMenu.Text = "Dashboard"
        Me.lbMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'mainPanel
        '
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(0, 152)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(1325, 357)
        Me.mainPanel.TabIndex = 10
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Green
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Image = Global.ZCMC_Packing.My.Resources.Resources._exit
        Me.btnLogout.Location = New System.Drawing.Point(173, 21)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(36, 33)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pbAccount
        '
        Me.pbAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbAccount.Image = Global.ZCMC_Packing.My.Resources.Resources.account
        Me.pbAccount.Location = New System.Drawing.Point(137, 24)
        Me.pbAccount.Name = "pbAccount"
        Me.pbAccount.Size = New System.Drawing.Size(30, 30)
        Me.pbAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAccount.TabIndex = 4
        Me.pbAccount.TabStop = False
        '
        'lbConLog
        '
        Me.lbConLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbConLog.BackColor = System.Drawing.Color.Silver
        Me.lbConLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbConLog.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConLog.ForeColor = System.Drawing.Color.Black
        Me.lbConLog.Image = Global.ZCMC_Packing.My.Resources.Resources.Loggg_Con
        Me.lbConLog.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbConLog.Location = New System.Drawing.Point(387, 83)
        Me.lbConLog.Margin = New System.Windows.Forms.Padding(5)
        Me.lbConLog.Name = "lbConLog"
        Me.lbConLog.Size = New System.Drawing.Size(85, 25)
        Me.lbConLog.TabIndex = 7
        Me.lbConLog.Text = "DataLog"
        Me.lbConLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbConConf
        '
        Me.lbConConf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbConConf.BackColor = System.Drawing.Color.Silver
        Me.lbConConf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbConConf.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConConf.ForeColor = System.Drawing.Color.Black
        Me.lbConConf.Image = Global.ZCMC_Packing.My.Resources.Resources.Config_Disc
        Me.lbConConf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbConConf.Location = New System.Drawing.Point(7, 83)
        Me.lbConConf.Margin = New System.Windows.Forms.Padding(5)
        Me.lbConConf.Name = "lbConConf"
        Me.lbConConf.Size = New System.Drawing.Size(85, 25)
        Me.lbConConf.TabIndex = 6
        Me.lbConConf.Text = "Config"
        Me.lbConConf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbConRef
        '
        Me.lbConRef.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbConRef.BackColor = System.Drawing.Color.Silver
        Me.lbConRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbConRef.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConRef.ForeColor = System.Drawing.Color.Black
        Me.lbConRef.Image = Global.ZCMC_Packing.My.Resources.Resources.Database_Disc
        Me.lbConRef.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbConRef.Location = New System.Drawing.Point(292, 83)
        Me.lbConRef.Margin = New System.Windows.Forms.Padding(5)
        Me.lbConRef.Name = "lbConRef"
        Me.lbConRef.Size = New System.Drawing.Size(85, 25)
        Me.lbConRef.TabIndex = 5
        Me.lbConRef.Text = "Reference"
        Me.lbConRef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbConCod
        '
        Me.lbConCod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbConCod.BackColor = System.Drawing.Color.Silver
        Me.lbConCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbConCod.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConCod.ForeColor = System.Drawing.Color.Black
        Me.lbConCod.Image = Global.ZCMC_Packing.My.Resources.Resources.Codesoft_con
        Me.lbConCod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbConCod.Location = New System.Drawing.Point(197, 83)
        Me.lbConCod.Margin = New System.Windows.Forms.Padding(5)
        Me.lbConCod.Name = "lbConCod"
        Me.lbConCod.Size = New System.Drawing.Size(85, 25)
        Me.lbConCod.TabIndex = 4
        Me.lbConCod.Text = "Codesoft"
        Me.lbConCod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbConMod
        '
        Me.lbConMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbConMod.BackColor = System.Drawing.Color.Silver
        Me.lbConMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbConMod.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConMod.ForeColor = System.Drawing.Color.Black
        Me.lbConMod.Image = Global.ZCMC_Packing.My.Resources.Resources.EthernetDisc
        Me.lbConMod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbConMod.Location = New System.Drawing.Point(102, 83)
        Me.lbConMod.Margin = New System.Windows.Forms.Padding(5)
        Me.lbConMod.Name = "lbConMod"
        Me.lbConMod.Size = New System.Drawing.Size(85, 25)
        Me.lbConMod.TabIndex = 3
        Me.lbConMod.Text = "Modbus"
        Me.lbConMod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ZCMC_Packing.My.Resources.Resources.Schneider_Electric_Logo_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnDash
        '
        Me.btnDash.AutoSize = False
        Me.btnDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDash.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnDash.ForeColor = System.Drawing.Color.White
        Me.btnDash.Image = Global.ZCMC_Packing.My.Resources.Resources.monitor
        Me.btnDash.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnDash.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDash.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnDash.Name = "btnDash"
        Me.btnDash.Size = New System.Drawing.Size(160, 60)
        Me.btnDash.Tag = "Dashboard"
        Me.btnDash.Text = "Dashboard"
        Me.btnDash.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnRun
        '
        Me.btnRun.AutoSize = False
        Me.btnRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRun.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnRun.ForeColor = System.Drawing.Color.White
        Me.btnRun.Image = Global.ZCMC_Packing.My.Resources.Resources._Select
        Me.btnRun.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRun.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(160, 60)
        Me.btnRun.Tag = "Product Selection"
        Me.btnRun.Text = "Run"
        Me.btnRun.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnConfig
        '
        Me.btnConfig.AutoSize = False
        Me.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnConfig.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnConfig.ForeColor = System.Drawing.Color.White
        Me.btnConfig.Image = Global.ZCMC_Packing.My.Resources.Resources.Config2
        Me.btnConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnConfig.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConfig.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(160, 60)
        Me.btnConfig.Tag = "Configuration"
        Me.btnConfig.Text = "Config"
        Me.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnManual
        '
        Me.btnManual.AutoSize = False
        Me.btnManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnManual.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnManual.ForeColor = System.Drawing.Color.White
        Me.btnManual.Image = Global.ZCMC_Packing.My.Resources.Resources.manuals__1_
        Me.btnManual.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnManual.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnManual.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(160, 60)
        Me.btnManual.Tag = "Manual Test"
        Me.btnManual.Text = "Manual"
        Me.btnManual.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnManual.Visible = False
        '
        'btnReff
        '
        Me.btnReff.AutoSize = False
        Me.btnReff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnReff.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnReff.ForeColor = System.Drawing.Color.White
        Me.btnReff.Image = Global.ZCMC_Packing.My.Resources.Resources.server
        Me.btnReff.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnReff.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReff.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnReff.Name = "btnReff"
        Me.btnReff.Size = New System.Drawing.Size(160, 60)
        Me.btnReff.Tag = "Data Reference"
        Me.btnReff.Text = "Reference"
        Me.btnReff.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnLog
        '
        Me.btnLog.AutoSize = False
        Me.btnLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLog.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnLog.ForeColor = System.Drawing.Color.White
        Me.btnLog.Image = Global.ZCMC_Packing.My.Resources.Resources.file1
        Me.btnLog.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnLog.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLog.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(160, 60)
        Me.btnLog.Tag = "Data Log"
        Me.btnLog.Text = "Log"
        Me.btnLog.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnAbout
        '
        Me.btnAbout.AutoSize = False
        Me.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAbout.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.Image = Global.ZCMC_Packing.My.Resources.Resources.info__1_
        Me.btnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(160, 60)
        Me.btnAbout.Tag = "About"
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnUser
        '
        Me.btnUser.AutoSize = False
        Me.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUser.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnUser.ForeColor = System.Drawing.Color.White
        Me.btnUser.Image = Global.ZCMC_Packing.My.Resources.Resources.admin
        Me.btnUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUser.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(160, 60)
        Me.btnUser.Tag = "User"
        Me.btnUser.Text = "User "
        Me.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1325, 590)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formMain"
        Me.Text = "ZCMC Packing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.pbAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnDash As ToolStripButton
    Friend WithEvents btnRun As ToolStripButton
    Friend WithEvents btnConfig As ToolStripButton
    Friend WithEvents btnManual As ToolStripButton
    Friend WithEvents btnReff As ToolStripButton
    Friend WithEvents btnLog As ToolStripButton
    Friend WithEvents btnAbout As ToolStripButton
    Friend WithEvents btnUser As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbMenu As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbConConf As Label
    Friend WithEvents lbConRef As Label
    Friend WithEvents lbConCod As Label
    Friend WithEvents lbConMod As Label
    Friend WithEvents lbConLog As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents pbAccount As PictureBox
    Friend WithEvents lbUser As Label
    Friend WithEvents mainPanel As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnLogout As Button
End Class
