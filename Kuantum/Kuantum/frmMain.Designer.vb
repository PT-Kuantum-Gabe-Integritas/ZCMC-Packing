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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbMenu = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.miniToolStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnTDash = New System.Windows.Forms.ToolStripButton()
        Me.btnTRun = New System.Windows.Forms.ToolStripButton()
        Me.btnTConfig = New System.Windows.Forms.ToolStripButton()
        Me.btnTManual = New System.Windows.Forms.ToolStripButton()
        Me.btnTReff = New System.Windows.Forms.ToolStripButton()
        Me.btnTLog = New System.Windows.Forms.ToolStripButton()
        Me.btnTAbout = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Size = New System.Drawing.Size(1262, 99)
        Me.Panel2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(1092, 39)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(167, 53)
        Me.Panel5.TabIndex = 0
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
        'lbMenu
        '
        Me.lbMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbMenu.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMenu.ForeColor = System.Drawing.Color.White
        Me.lbMenu.Location = New System.Drawing.Point(287, 11)
        Me.lbMenu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbMenu.Name = "lbMenu"
        Me.lbMenu.Size = New System.Drawing.Size(779, 37)
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
        Me.Button2.Location = New System.Drawing.Point(1195, 4)
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
        Me.Button1.Location = New System.Drawing.Point(1229, 4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pnlForm
        '
        Me.pnlForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlForm.Location = New System.Drawing.Point(0, 99)
        Me.pnlForm.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(1262, 449)
        Me.pnlForm.TabIndex = 3
        '
        'miniToolStrip
        '
        Me.miniToolStrip.AutoSize = False
        Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.miniToolStrip.Location = New System.Drawing.Point(1, 1)
        Me.miniToolStrip.Name = "miniToolStrip"
        Me.miniToolStrip.Size = New System.Drawing.Size(1262, 22)
        Me.miniToolStrip.TabIndex = 8
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnTDash, Me.btnTRun, Me.btnTConfig, Me.btnTManual, Me.btnTReff, Me.btnTLog, Me.btnTAbout})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 478)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1262, 70)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnTDash
        '
        Me.btnTDash.AutoSize = False
        Me.btnTDash.BackgroundImage = Global.Kuantum.My.Resources.Resources.Line1
        Me.btnTDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTDash.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnTDash.ForeColor = System.Drawing.Color.White
        Me.btnTDash.Image = Global.Kuantum.My.Resources.Resources.layout
        Me.btnTDash.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnTDash.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTDash.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnTDash.Name = "btnTDash"
        Me.btnTDash.Size = New System.Drawing.Size(160, 65)
        Me.btnTDash.Tag = "Dashboard"
        Me.btnTDash.Text = "Dashboard"
        Me.btnTDash.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnTRun
        '
        Me.btnTRun.AutoSize = False
        Me.btnTRun.BackgroundImage = CType(resources.GetObject("btnTRun.BackgroundImage"), System.Drawing.Image)
        Me.btnTRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTRun.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnTRun.ForeColor = System.Drawing.Color.White
        Me.btnTRun.Image = Global.Kuantum.My.Resources.Resources.testing
        Me.btnTRun.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnTRun.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTRun.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnTRun.Name = "btnTRun"
        Me.btnTRun.Size = New System.Drawing.Size(160, 65)
        Me.btnTRun.Tag = "Product Selection"
        Me.btnTRun.Text = "Run"
        Me.btnTRun.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnTConfig
        '
        Me.btnTConfig.AutoSize = False
        Me.btnTConfig.BackgroundImage = CType(resources.GetObject("btnTConfig.BackgroundImage"), System.Drawing.Image)
        Me.btnTConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTConfig.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnTConfig.ForeColor = System.Drawing.Color.White
        Me.btnTConfig.Image = Global.Kuantum.My.Resources.Resources.settings__2_
        Me.btnTConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnTConfig.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTConfig.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnTConfig.Name = "btnTConfig"
        Me.btnTConfig.Size = New System.Drawing.Size(160, 65)
        Me.btnTConfig.Text = "Config"
        Me.btnTConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnTManual
        '
        Me.btnTManual.AutoSize = False
        Me.btnTManual.BackgroundImage = CType(resources.GetObject("btnTManual.BackgroundImage"), System.Drawing.Image)
        Me.btnTManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTManual.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnTManual.ForeColor = System.Drawing.Color.White
        Me.btnTManual.Image = Global.Kuantum.My.Resources.Resources.service__1_
        Me.btnTManual.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnTManual.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTManual.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnTManual.Name = "btnTManual"
        Me.btnTManual.Size = New System.Drawing.Size(160, 65)
        Me.btnTManual.Text = "Manual"
        Me.btnTManual.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnTReff
        '
        Me.btnTReff.AutoSize = False
        Me.btnTReff.BackgroundImage = CType(resources.GetObject("btnTReff.BackgroundImage"), System.Drawing.Image)
        Me.btnTReff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTReff.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnTReff.ForeColor = System.Drawing.Color.White
        Me.btnTReff.Image = Global.Kuantum.My.Resources.Resources.database
        Me.btnTReff.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnTReff.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTReff.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnTReff.Name = "btnTReff"
        Me.btnTReff.Size = New System.Drawing.Size(160, 65)
        Me.btnTReff.Text = "Reference"
        Me.btnTReff.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnTLog
        '
        Me.btnTLog.AutoSize = False
        Me.btnTLog.BackgroundImage = CType(resources.GetObject("btnTLog.BackgroundImage"), System.Drawing.Image)
        Me.btnTLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTLog.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnTLog.ForeColor = System.Drawing.Color.White
        Me.btnTLog.Image = Global.Kuantum.My.Resources.Resources.documents
        Me.btnTLog.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnTLog.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTLog.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnTLog.Name = "btnTLog"
        Me.btnTLog.Size = New System.Drawing.Size(160, 65)
        Me.btnTLog.Text = "Log"
        Me.btnTLog.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnTAbout
        '
        Me.btnTAbout.AutoSize = False
        Me.btnTAbout.BackgroundImage = CType(resources.GetObject("btnTAbout.BackgroundImage"), System.Drawing.Image)
        Me.btnTAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTAbout.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnTAbout.ForeColor = System.Drawing.Color.White
        Me.btnTAbout.Image = Global.Kuantum.My.Resources.Resources.info
        Me.btnTAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnTAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTAbout.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.btnTAbout.Name = "btnTAbout"
        Me.btnTAbout.Size = New System.Drawing.Size(160, 65)
        Me.btnTAbout.Text = "About"
        Me.btnTAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1262, 548)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pnlForm)
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
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents pnlForm As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbMenu As Label
    Friend WithEvents miniToolStrip As StatusStrip
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnTDash As ToolStripButton
    Friend WithEvents btnTRun As ToolStripButton
    Friend WithEvents btnTConfig As ToolStripButton
    Friend WithEvents btnTManual As ToolStripButton
    Friend WithEvents btnTReff As ToolStripButton
    Friend WithEvents btnTLog As ToolStripButton
    Friend WithEvents btnTAbout As ToolStripButton
End Class
