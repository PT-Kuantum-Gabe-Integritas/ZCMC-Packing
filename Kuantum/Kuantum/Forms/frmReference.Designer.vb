<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReference
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReference))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbReff = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbArt = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtArt = New System.Windows.Forms.TextBox()
        Me.txtReff = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtInd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGroup = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBitmap = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.txtBitmap)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtArt)
        Me.Panel1.Controls.Add(Me.txtGroup)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtReff)
        Me.Panel1.Controls.Add(Me.txtInd)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 600)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.btnReset)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.cbReff)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cbArt)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(250, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1063, 58)
        Me.Panel2.TabIndex = 1
        '
        'cbReff
        '
        Me.cbReff.FormattingEnabled = True
        Me.cbReff.Location = New System.Drawing.Point(412, 34)
        Me.cbReff.Name = "cbReff"
        Me.cbReff.Size = New System.Drawing.Size(195, 21)
        Me.cbReff.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(308, 34)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Reference"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbArt
        '
        Me.cbArt.FormattingEnabled = True
        Me.cbArt.Location = New System.Drawing.Point(107, 34)
        Me.cbArt.Name = "cbArt"
        Me.cbArt.Size = New System.Drawing.Size(195, 21)
        Me.cbArt.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Art No."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(250, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1063, 512)
        Me.DataGridView1.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(238, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Art Number"
        '
        'txtArt
        '
        Me.txtArt.Location = New System.Drawing.Point(3, 66)
        Me.txtArt.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.txtArt.Name = "txtArt"
        Me.txtArt.Size = New System.Drawing.Size(238, 20)
        Me.txtArt.TabIndex = 22
        '
        'txtReff
        '
        Me.txtReff.Location = New System.Drawing.Point(3, 109)
        Me.txtReff.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.txtReff.Name = "txtReff"
        Me.txtReff.Size = New System.Drawing.Size(238, 20)
        Me.txtReff.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(238, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Reference"
        '
        'txtInd
        '
        Me.txtInd.Location = New System.Drawing.Point(3, 152)
        Me.txtInd.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.txtInd.Name = "txtInd"
        Me.txtInd.Size = New System.Drawing.Size(238, 20)
        Me.txtInd.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(238, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Qty Individual"
        '
        'txtGroup
        '
        Me.txtGroup.Location = New System.Drawing.Point(3, 195)
        Me.txtGroup.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Size = New System.Drawing.Size(238, 20)
        Me.txtGroup.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(238, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Qty Group"
        '
        'txtBitmap
        '
        Me.txtBitmap.Location = New System.Drawing.Point(3, 238)
        Me.txtBitmap.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.txtBitmap.Name = "txtBitmap"
        Me.txtBitmap.Size = New System.Drawing.Size(238, 20)
        Me.txtBitmap.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(238, 20)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Bitmap"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(613, 23)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(35, 35)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(37, 291)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(167, 42)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(37, 339)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(167, 42)
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(654, 23)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(35, 35)
        Me.btnReset.TabIndex = 12
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'frmReference
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1325, 600)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReference"
        Me.Text = "frmReference"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cbReff As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbArt As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBitmap As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtArt As TextBox
    Friend WithEvents txtGroup As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtReff As TextBox
    Friend WithEvents txtInd As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReset As Button
End Class
