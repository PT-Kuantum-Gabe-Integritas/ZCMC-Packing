<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lb_info = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.cb_user = New System.Windows.Forms.ComboBox()
        Me.tb_input = New System.Windows.Forms.TextBox()
        Me.lb_user = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1325, 600)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lb_info)
        Me.Panel1.Controls.Add(Me.btn_login)
        Me.Panel1.Controls.Add(Me.cb_user)
        Me.Panel1.Controls.Add(Me.tb_input)
        Me.Panel1.Controls.Add(Me.lb_user)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(444, 183)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 234)
        Me.Panel1.TabIndex = 0
        '
        'lb_info
        '
        Me.lb_info.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lb_info.Location = New System.Drawing.Point(3, 67)
        Me.lb_info.Name = "lb_info"
        Me.lb_info.Size = New System.Drawing.Size(429, 32)
        Me.lb_info.TabIndex = 6
        Me.lb_info.Text = "Please Fill ID or Username"
        Me.lb_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_login
        '
        Me.btn_login.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btn_login.Location = New System.Drawing.Point(3, 158)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(429, 35)
        Me.btn_login.TabIndex = 8
        Me.btn_login.Text = "Login"
        Me.btn_login.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'cb_user
        '
        Me.cb_user.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_user.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.cb_user.FormattingEnabled = True
        Me.cb_user.Items.AddRange(New Object() {"Operator", "Engineer", "Administrator"})
        Me.cb_user.Location = New System.Drawing.Point(3, 42)
        Me.cb_user.Name = "cb_user"
        Me.cb_user.Size = New System.Drawing.Size(429, 25)
        Me.cb_user.TabIndex = 5
        '
        'tb_input
        '
        Me.tb_input.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_input.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.tb_input.Location = New System.Drawing.Point(3, 130)
        Me.tb_input.Name = "tb_input"
        Me.tb_input.Size = New System.Drawing.Size(429, 25)
        Me.tb_input.TabIndex = 7
        '
        'lb_user
        '
        Me.lb_user.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_user.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lb_user.Location = New System.Drawing.Point(3, 99)
        Me.lb_user.Name = "lb_user"
        Me.lb_user.Size = New System.Drawing.Size(429, 28)
        Me.lb_user.TabIndex = 9
        Me.lb_user.Text = "User"
        Me.lb_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1325, 600)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.Text = "frmLogin"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lb_info As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents cb_user As ComboBox
    Friend WithEvents tb_input As TextBox
    Friend WithEvents lb_user As Label
End Class
