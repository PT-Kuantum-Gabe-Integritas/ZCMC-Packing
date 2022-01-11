<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addUser
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cb_role = New System.Windows.Forms.ComboBox()
        Me.btn_newPass = New System.Windows.Forms.Button()
        Me.tb_confirmPass = New System.Windows.Forms.TextBox()
        Me.lb_confrimPass = New System.Windows.Forms.Label()
        Me.tb_newPass = New System.Windows.Forms.TextBox()
        Me.lb_newPass = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1325, 409)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.cb_role, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_newPass, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.tb_confirmPass, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lb_confrimPass, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tb_newPass, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lb_newPass, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(400, 105)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(524, 198)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'cb_role
        '
        Me.cb_role.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_role.FormattingEnabled = True
        Me.cb_role.Items.AddRange(New Object() {"Operator", "Enginner", "Admin"})
        Me.cb_role.Location = New System.Drawing.Point(6, 6)
        Me.cb_role.Margin = New System.Windows.Forms.Padding(6)
        Me.cb_role.Name = "cb_role"
        Me.cb_role.Size = New System.Drawing.Size(512, 28)
        Me.cb_role.TabIndex = 1
        '
        'btn_newPass
        '
        Me.btn_newPass.BackColor = System.Drawing.Color.Green
        Me.btn_newPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newPass.ForeColor = System.Drawing.Color.White
        Me.btn_newPass.Location = New System.Drawing.Point(3, 158)
        Me.btn_newPass.Name = "btn_newPass"
        Me.btn_newPass.Size = New System.Drawing.Size(518, 37)
        Me.btn_newPass.TabIndex = 8
        Me.btn_newPass.Text = "Add New User"
        Me.btn_newPass.UseVisualStyleBackColor = False
        '
        'tb_confirmPass
        '
        Me.tb_confirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_confirmPass.Location = New System.Drawing.Point(6, 122)
        Me.tb_confirmPass.Margin = New System.Windows.Forms.Padding(6)
        Me.tb_confirmPass.Name = "tb_confirmPass"
        Me.tb_confirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_confirmPass.Size = New System.Drawing.Size(512, 26)
        Me.tb_confirmPass.TabIndex = 5
        Me.tb_confirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_confrimPass
        '
        Me.lb_confrimPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_confrimPass.ForeColor = System.Drawing.Color.Green
        Me.lb_confrimPass.Location = New System.Drawing.Point(3, 97)
        Me.lb_confrimPass.Name = "lb_confrimPass"
        Me.lb_confrimPass.Size = New System.Drawing.Size(518, 19)
        Me.lb_confrimPass.TabIndex = 7
        Me.lb_confrimPass.Text = "Confirm new password"
        Me.lb_confrimPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_newPass
        '
        Me.tb_newPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_newPass.Location = New System.Drawing.Point(6, 64)
        Me.tb_newPass.Margin = New System.Windows.Forms.Padding(6)
        Me.tb_newPass.Name = "tb_newPass"
        Me.tb_newPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_newPass.Size = New System.Drawing.Size(512, 26)
        Me.tb_newPass.TabIndex = 4
        Me.tb_newPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_newPass
        '
        Me.lb_newPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_newPass.ForeColor = System.Drawing.Color.Green
        Me.lb_newPass.Location = New System.Drawing.Point(3, 39)
        Me.lb_newPass.Name = "lb_newPass"
        Me.lb_newPass.Size = New System.Drawing.Size(518, 19)
        Me.lb_newPass.TabIndex = 6
        Me.lb_newPass.Text = "Insert new password here"
        Me.lb_newPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_addUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1325, 409)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_addUser"
        Me.Text = "AddUser"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btn_newPass As Button
    Friend WithEvents tb_confirmPass As TextBox
    Friend WithEvents lb_confrimPass As Label
    Friend WithEvents tb_newPass As TextBox
    Friend WithEvents lb_newPass As Label
    Friend WithEvents cb_role As ComboBox
End Class
