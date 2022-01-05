<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManual
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_group = New System.Windows.Forms.Button()
        Me.btn_ind = New System.Windows.Forms.Button()
        Me.cb_reff = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(274, 600)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(33, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 41)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Reference"
        '
        'btn_group
        '
        Me.btn_group.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_group.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_group.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_group.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_group.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btn_group.Location = New System.Drawing.Point(385, 332)
        Me.btn_group.Name = "btn_group"
        Me.btn_group.Size = New System.Drawing.Size(350, 51)
        Me.btn_group.TabIndex = 14
        Me.btn_group.Text = "Print Group"
        Me.btn_group.UseVisualStyleBackColor = False
        '
        'btn_ind
        '
        Me.btn_ind.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_ind.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ind.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ind.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btn_ind.Location = New System.Drawing.Point(385, 270)
        Me.btn_ind.Name = "btn_ind"
        Me.btn_ind.Size = New System.Drawing.Size(350, 51)
        Me.btn_ind.TabIndex = 13
        Me.btn_ind.Text = "Print Individual"
        Me.btn_ind.UseVisualStyleBackColor = False
        '
        'cb_reff
        '
        Me.cb_reff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cb_reff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_reff.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_reff.FormattingEnabled = True
        Me.cb_reff.Items.AddRange(New Object() {"XVBC07", "XVBC21"})
        Me.cb_reff.Location = New System.Drawing.Point(38, 285)
        Me.cb_reff.Name = "cb_reff"
        Me.cb_reff.Size = New System.Drawing.Size(302, 37)
        Me.cb_reff.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1051, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(274, 600)
        Me.Panel2.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btn_group)
        Me.Panel3.Controls.Add(Me.btn_ind)
        Me.Panel3.Controls.Add(Me.cb_reff)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(274, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(777, 600)
        Me.Panel3.TabIndex = 17
        '
        'frmManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1325, 600)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManual"
        Me.Text = "frmManual"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_group As Button
    Friend WithEvents btn_ind As Button
    Friend WithEvents cb_reff As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
