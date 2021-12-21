<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.pnlBlue = New System.Windows.Forms.Panel()
        Me.miniToolStrip = New System.Windows.Forms.StatusStrip()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnManual = New System.Windows.Forms.Button()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.btnReference = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnAbout)
        Me.Panel4.Controls.Add(Me.btnRun)
        Me.Panel4.Controls.Add(Me.pnlBlue)
        Me.Panel4.Controls.Add(Me.btnLog)
        Me.Panel4.Controls.Add(Me.btnDashboard)
        Me.Panel4.Controls.Add(Me.btnManual)
        Me.Panel4.Controls.Add(Me.btnConfig)
        Me.Panel4.Controls.Add(Me.btnReference)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 478)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1262, 70)
        Me.Panel4.TabIndex = 2
        '
        'btnAbout
        '
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.Image = Global.Kuantum.My.Resources.Resources.info
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAbout.Location = New System.Drawing.Point(998, 0)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(160, 65)
        Me.btnAbout.TabIndex = 7
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'pnlBlue
        '
        Me.pnlBlue.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.pnlBlue.Location = New System.Drawing.Point(11, 63)
        Me.pnlBlue.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlBlue.Name = "pnlBlue"
        Me.pnlBlue.Size = New System.Drawing.Size(161, 5)
        Me.pnlBlue.TabIndex = 2
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
        'btnRun
        '
        Me.btnRun.FlatAppearance.BorderSize = 0
        Me.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRun.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.ForeColor = System.Drawing.Color.White
        Me.btnRun.Image = Global.Kuantum.My.Resources.Resources.testing
        Me.btnRun.Location = New System.Drawing.Point(176, 0)
        Me.btnRun.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(160, 65)
        Me.btnRun.TabIndex = 8
        Me.btnRun.Text = "Run"
        Me.btnRun.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'btnLog
        '
        Me.btnLog.FlatAppearance.BorderSize = 0
        Me.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLog.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.ForeColor = System.Drawing.Color.White
        Me.btnLog.Image = Global.Kuantum.My.Resources.Resources.documents
        Me.btnLog.Location = New System.Drawing.Point(834, 0)
        Me.btnLog.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(160, 65)
        Me.btnLog.TabIndex = 6
        Me.btnLog.Text = "Log"
        Me.btnLog.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = Global.Kuantum.My.Resources.Resources.layout
        Me.btnDashboard.Location = New System.Drawing.Point(12, 0)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(160, 65)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'btnManual
        '
        Me.btnManual.FlatAppearance.BorderSize = 0
        Me.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManual.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManual.ForeColor = System.Drawing.Color.White
        Me.btnManual.Image = Global.Kuantum.My.Resources.Resources.service__1_
        Me.btnManual.Location = New System.Drawing.Point(506, 0)
        Me.btnManual.Margin = New System.Windows.Forms.Padding(2)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(160, 65)
        Me.btnManual.TabIndex = 5
        Me.btnManual.Text = "Manual"
        Me.btnManual.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnManual.UseVisualStyleBackColor = True
        '
        'btnConfig
        '
        Me.btnConfig.FlatAppearance.BorderSize = 0
        Me.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfig.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfig.ForeColor = System.Drawing.Color.White
        Me.btnConfig.Image = Global.Kuantum.My.Resources.Resources.settings__2_
        Me.btnConfig.Location = New System.Drawing.Point(342, 0)
        Me.btnConfig.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(160, 65)
        Me.btnConfig.TabIndex = 3
        Me.btnConfig.Text = "Config"
        Me.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnConfig.UseVisualStyleBackColor = True
        '
        'btnReference
        '
        Me.btnReference.FlatAppearance.BorderSize = 0
        Me.btnReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReference.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReference.ForeColor = System.Drawing.Color.White
        Me.btnReference.Image = Global.Kuantum.My.Resources.Resources.database
        Me.btnReference.Location = New System.Drawing.Point(670, 0)
        Me.btnReference.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReference.Name = "btnReference"
        Me.btnReference.Size = New System.Drawing.Size(160, 65)
        Me.btnReference.TabIndex = 4
        Me.btnReference.Text = "Reference"
        Me.btnReference.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnReference.UseVisualStyleBackColor = True
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
        Me.Controls.Add(Me.Panel4)
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
        Me.Panel4.ResumeLayout(False)
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
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pnlBlue As Panel
    Friend WithEvents btnLog As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnManual As Button
    Friend WithEvents btnConfig As Button
    Friend WithEvents btnReference As Button
    Friend WithEvents miniToolStrip As StatusStrip
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnRun As Button
End Class
