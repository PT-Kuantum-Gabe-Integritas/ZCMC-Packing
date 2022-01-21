<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserManagement))
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.DataGridViewTable = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.authorization = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Dashboard = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Run = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Config = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Manual = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Reference = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LOG = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UserManage = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.lb_id = New System.Windows.Forms.Label()
        Me.tb_id = New System.Windows.Forms.TextBox()
        Me.tb_confirm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_info = New System.Windows.Forms.Label()
        Me.cb_user = New System.Windows.Forms.ComboBox()
        Me.tb_input = New System.Windows.Forms.TextBox()
        Me.lb_user = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lb_idSearch = New System.Windows.Forms.Label()
        Me.cbID = New System.Windows.Forms.ComboBox()
        Me.lb_roleSearch = New System.Windows.Forms.Label()
        Me.cbRole = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Red
        Me.btn_delete.Location = New System.Drawing.Point(3, 51)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(167, 42)
        Me.btn_delete.TabIndex = 38
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'DataGridViewTable
        '
        Me.DataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.user, Me.pass, Me.authorization, Me.Dashboard, Me.Run, Me.Config, Me.Manual, Me.Reference, Me.LOG, Me.UserManage})
        Me.DataGridViewTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewTable.Location = New System.Drawing.Point(3, 67)
        Me.DataGridViewTable.Name = "DataGridViewTable"
        Me.DataGridViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewTable.Size = New System.Drawing.Size(1035, 312)
        Me.DataGridViewTable.TabIndex = 45
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'user
        '
        Me.user.HeaderText = "user"
        Me.user.Name = "user"
        '
        'pass
        '
        Me.pass.HeaderText = "pass"
        Me.pass.Name = "pass"
        '
        'authorization
        '
        Me.authorization.HeaderText = "authorization"
        Me.authorization.Name = "authorization"
        '
        'Dashboard
        '
        Me.Dashboard.HeaderText = "Dashboard"
        Me.Dashboard.Name = "Dashboard"
        '
        'Run
        '
        Me.Run.HeaderText = "Run"
        Me.Run.Name = "Run"
        '
        'Config
        '
        Me.Config.HeaderText = "Config"
        Me.Config.Name = "Config"
        '
        'Manual
        '
        Me.Manual.HeaderText = "Manual"
        Me.Manual.Name = "Manual"
        '
        'Reference
        '
        Me.Reference.HeaderText = "Reference"
        Me.Reference.Name = "Reference"
        '
        'LOG
        '
        Me.LOG.HeaderText = "LOG"
        Me.LOG.Name = "LOG"
        '
        'UserManage
        '
        Me.UserManage.HeaderText = "UserManage"
        Me.UserManage.Name = "UserManage"
        '
        'btn_save
        '
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Lime
        Me.btn_save.Location = New System.Drawing.Point(3, 3)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(167, 42)
        Me.btn_save.TabIndex = 54
        Me.btn_save.Text = "save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'lb_id
        '
        Me.lb_id.BackColor = System.Drawing.Color.Green
        Me.lb_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_id.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_id.ForeColor = System.Drawing.Color.White
        Me.lb_id.Location = New System.Drawing.Point(3, 1)
        Me.lb_id.Name = "lb_id"
        Me.lb_id.Size = New System.Drawing.Size(250, 25)
        Me.lb_id.TabIndex = 53
        Me.lb_id.Text = "ID"
        Me.lb_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_id
        '
        Me.tb_id.Enabled = False
        Me.tb_id.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.tb_id.Location = New System.Drawing.Point(3, 28)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Size = New System.Drawing.Size(250, 25)
        Me.tb_id.TabIndex = 50
        '
        'tb_confirm
        '
        Me.tb_confirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_confirm.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_confirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.tb_confirm.Location = New System.Drawing.Point(3, 206)
        Me.tb_confirm.Name = "tb_confirm"
        Me.tb_confirm.Size = New System.Drawing.Size(250, 25)
        Me.tb_confirm.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 28)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Confirm New Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_info
        '
        Me.lb_info.BackColor = System.Drawing.Color.Green
        Me.lb_info.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_info.ForeColor = System.Drawing.Color.White
        Me.lb_info.Location = New System.Drawing.Point(3, 55)
        Me.lb_info.Name = "lb_info"
        Me.lb_info.Size = New System.Drawing.Size(250, 30)
        Me.lb_info.TabIndex = 47
        Me.lb_info.Text = "Select Role"
        Me.lb_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cb_user
        '
        Me.cb_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_user.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.cb_user.FormattingEnabled = True
        Me.cb_user.Items.AddRange(New Object() {"OPERATOR_", "ENGINEER_", "ADMIN_"})
        Me.cb_user.Location = New System.Drawing.Point(4, 88)
        Me.cb_user.Name = "cb_user"
        Me.cb_user.Size = New System.Drawing.Size(249, 25)
        Me.cb_user.TabIndex = 46
        '
        'tb_input
        '
        Me.tb_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_input.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.tb_input.Location = New System.Drawing.Point(3, 147)
        Me.tb_input.Name = "tb_input"
        Me.tb_input.Size = New System.Drawing.Size(250, 25)
        Me.tb_input.TabIndex = 50
        '
        'lb_user
        '
        Me.lb_user.BackColor = System.Drawing.Color.Green
        Me.lb_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_user.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_user.ForeColor = System.Drawing.Color.White
        Me.lb_user.Location = New System.Drawing.Point(3, 116)
        Me.lb_user.Name = "lb_user"
        Me.lb_user.Size = New System.Drawing.Size(250, 28)
        Me.lb_user.TabIndex = 49
        Me.lb_user.Text = "Insert New Password"
        Me.lb_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1325, 409)
        Me.TableLayoutPanel1.TabIndex = 63
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DataGridViewTable, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(281, 24)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1041, 382)
        Me.TableLayoutPanel2.TabIndex = 48
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.lb_idSearch)
        Me.FlowLayoutPanel2.Controls.Add(Me.cbID)
        Me.FlowLayoutPanel2.Controls.Add(Me.lb_roleSearch)
        Me.FlowLayoutPanel2.Controls.Add(Me.cbRole)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnSearch)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnReset)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1035, 58)
        Me.FlowLayoutPanel2.TabIndex = 47
        '
        'lb_idSearch
        '
        Me.lb_idSearch.BackColor = System.Drawing.Color.Green
        Me.lb_idSearch.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lb_idSearch.ForeColor = System.Drawing.Color.White
        Me.lb_idSearch.Location = New System.Drawing.Point(3, 0)
        Me.lb_idSearch.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lb_idSearch.Name = "lb_idSearch"
        Me.lb_idSearch.Size = New System.Drawing.Size(98, 25)
        Me.lb_idSearch.TabIndex = 13
        Me.lb_idSearch.Text = "ID"
        Me.lb_idSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbID
        '
        Me.cbID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbID.FormattingEnabled = True
        Me.cbID.Location = New System.Drawing.Point(107, 3)
        Me.cbID.Name = "cbID"
        Me.cbID.Size = New System.Drawing.Size(195, 21)
        Me.cbID.TabIndex = 14
        '
        'lb_roleSearch
        '
        Me.lb_roleSearch.BackColor = System.Drawing.Color.Green
        Me.lb_roleSearch.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lb_roleSearch.ForeColor = System.Drawing.Color.White
        Me.lb_roleSearch.Location = New System.Drawing.Point(308, 0)
        Me.lb_roleSearch.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lb_roleSearch.Name = "lb_roleSearch"
        Me.lb_roleSearch.Size = New System.Drawing.Size(98, 25)
        Me.lb_roleSearch.TabIndex = 15
        Me.lb_roleSearch.Text = "Role"
        Me.lb_roleSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbRole
        '
        Me.cbRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbRole.FormattingEnabled = True
        Me.cbRole.Location = New System.Drawing.Point(412, 3)
        Me.cbRole.Name = "cbRole"
        Me.cbRole.Size = New System.Drawing.Size(195, 21)
        Me.cbRole.TabIndex = 16
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.Green
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(613, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(35, 35)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.ForeColor = System.Drawing.Color.Green
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(654, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(35, 35)
        Me.btnReset.TabIndex = 18
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 24)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(272, 362)
        Me.TableLayoutPanel3.TabIndex = 49
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lb_id)
        Me.Panel1.Controls.Add(Me.lb_info)
        Me.Panel1.Controls.Add(Me.tb_id)
        Me.Panel1.Controls.Add(Me.tb_confirm)
        Me.Panel1.Controls.Add(Me.lb_user)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tb_input)
        Me.Panel1.Controls.Add(Me.cb_user)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 247)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.FlowLayoutPanel1, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 256)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(266, 103)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_save)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_delete)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(42, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(180, 97)
        Me.FlowLayoutPanel1.TabIndex = 46
        '
        'frmUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1325, 409)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUserManagement"
        Me.Text = "UserManagement"
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_delete As Button
    Friend WithEvents DataGridViewTable As DataGridView
    Friend WithEvents tb_confirm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_info As Label
    Friend WithEvents cb_user As ComboBox
    Friend WithEvents tb_input As TextBox
    Friend WithEvents lb_user As Label
    Friend WithEvents lb_id As Label
    Friend WithEvents tb_id As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lb_idSearch As Label
    Friend WithEvents cbID As ComboBox
    Friend WithEvents lb_roleSearch As Label
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents user As DataGridViewTextBoxColumn
    Friend WithEvents pass As DataGridViewTextBoxColumn
    Friend WithEvents authorization As DataGridViewCheckBoxColumn
    Friend WithEvents Dashboard As DataGridViewCheckBoxColumn
    Friend WithEvents Run As DataGridViewCheckBoxColumn
    Friend WithEvents Config As DataGridViewCheckBoxColumn
    Friend WithEvents Manual As DataGridViewCheckBoxColumn
    Friend WithEvents Reference As DataGridViewCheckBoxColumn
    Friend WithEvents LOG As DataGridViewCheckBoxColumn
    Friend WithEvents UserManage As DataGridViewCheckBoxColumn
End Class
