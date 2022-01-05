<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbMenu = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnDash = New System.Windows.Forms.ToolStripButton()
        Me.btnRun = New System.Windows.Forms.ToolStripButton()
        Me.btnConfig = New System.Windows.Forms.ToolStripButton()
        Me.btnManual = New System.Windows.Forms.ToolStripButton()
        Me.btnReff = New System.Windows.Forms.ToolStripButton()
        Me.btnLog = New System.Windows.Forms.ToolStripButton()
        Me.btnAbout = New System.Windows.Forms.ToolStripButton()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.lbMenu)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1325, 99)
        Me.Panel2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(1155, 40)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(167, 53)
        Me.Panel5.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Kuantum.My.Resources.Resources.user__2_
        Me.PictureBox2.Location = New System.Drawing.Point(11, 8)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(50, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hi Username,"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(50, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Welcome!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lbMenu
        '
        Me.lbMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbMenu.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMenu.ForeColor = System.Drawing.Color.White
        Me.lbMenu.Location = New System.Drawing.Point(276, 4)
        Me.lbMenu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbMenu.Name = "lbMenu"
        Me.lbMenu.Size = New System.Drawing.Size(197, 37)
        Me.lbMenu.TabIndex = 2
        Me.lbMenu.Text = "Dashboard"
        Me.lbMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(1258, 4)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 30)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(1292, 4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDash, Me.btnRun, Me.btnConfig, Me.btnManual, Me.btnReff, Me.btnLog, Me.btnAbout})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 508)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1325, 81)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnDash
        '
        Me.btnDash.AutoSize = False
        Me.btnDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDash.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnDash.ForeColor = System.Drawing.Color.White
        Me.btnDash.Image = Global.Kuantum.My.Resources.Resources.layout
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
        Me.btnRun.Image = Global.Kuantum.My.Resources.Resources.testing
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
        Me.btnConfig.Image = Global.Kuantum.My.Resources.Resources.settings__2_
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
        Me.btnManual.Image = Global.Kuantum.My.Resources.Resources.service__1_
        Me.btnManual.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnManual.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnManual.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(160, 60)
        Me.btnManual.Tag = "Manual Test"
        Me.btnManual.Text = "Manual"
        Me.btnManual.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnReff
        '
        Me.btnReff.AutoSize = False
        Me.btnReff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnReff.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnReff.ForeColor = System.Drawing.Color.White
        Me.btnReff.Image = Global.Kuantum.My.Resources.Resources.database
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
        Me.btnLog.Image = Global.Kuantum.My.Resources.Resources.documents
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
        Me.btnAbout.Image = Global.Kuantum.My.Resources.Resources.info
        Me.btnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(160, 60)
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'mainPanel
        '
        Me.mainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(0, 99)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(1325, 409)
        Me.mainPanel.TabIndex = 5
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1325, 589)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbMenu As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnDash As ToolStripButton
    Friend WithEvents btnRun As ToolStripButton
    Friend WithEvents btnConfig As ToolStripButton
    Friend WithEvents btnManual As ToolStripButton
    Friend WithEvents btnLog As ToolStripButton
    Friend WithEvents btnAbout As ToolStripButton
    Friend WithEvents btnReff As ToolStripButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents mainPanel As Panel
End Class
