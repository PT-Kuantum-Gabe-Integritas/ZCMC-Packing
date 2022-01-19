<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserManagement
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
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.DataGridViewTable = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_UserManage = New System.Windows.Forms.CheckBox()
        Me.cb_LOG = New System.Windows.Forms.CheckBox()
        Me.cb_Reference = New System.Windows.Forms.CheckBox()
        Me.cb_Manual = New System.Windows.Forms.CheckBox()
        Me.cb_Config = New System.Windows.Forms.CheckBox()
        Me.cb_Run = New System.Windows.Forms.CheckBox()
        Me.cb_Dashboard = New System.Windows.Forms.CheckBox()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.lb_id = New System.Windows.Forms.Label()
        Me.tb_id = New System.Windows.Forms.TextBox()
        Me.tb_confirm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_info = New System.Windows.Forms.Label()
        Me.cb_user = New System.Windows.Forms.ComboBox()
        Me.tb_input = New System.Windows.Forms.TextBox()
        Me.lb_user = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btn_delete.Location = New System.Drawing.Point(332, 272)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(84, 23)
        Me.btn_delete.TabIndex = 38
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btn_refresh.Location = New System.Drawing.Point(115, 272)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(84, 23)
        Me.btn_refresh.TabIndex = 39
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.Red
        Me.btn_close.Location = New System.Drawing.Point(542, 11)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(84, 23)
        Me.btn_close.TabIndex = 30
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'DataGridViewTable
        '
        Me.DataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTable.Location = New System.Drawing.Point(9, 118)
        Me.DataGridViewTable.Name = "DataGridViewTable"
        Me.DataGridViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewTable.Size = New System.Drawing.Size(407, 143)
        Me.DataGridViewTable.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.cb_UserManage)
        Me.GroupBox1.Controls.Add(Me.cb_LOG)
        Me.GroupBox1.Controls.Add(Me.cb_Reference)
        Me.GroupBox1.Controls.Add(Me.cb_Manual)
        Me.GroupBox1.Controls.Add(Me.cb_Config)
        Me.GroupBox1.Controls.Add(Me.cb_Run)
        Me.GroupBox1.Controls.Add(Me.cb_Dashboard)
        Me.GroupBox1.Controls.Add(Me.btn_reset)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.lb_id)
        Me.GroupBox1.Controls.Add(Me.tb_id)
        Me.GroupBox1.Controls.Add(Me.tb_confirm)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lb_info)
        Me.GroupBox1.Controls.Add(Me.cb_user)
        Me.GroupBox1.Controls.Add(Me.tb_input)
        Me.GroupBox1.Controls.Add(Me.lb_user)
        Me.GroupBox1.Controls.Add(Me.DataGridViewTable)
        Me.GroupBox1.Controls.Add(Me.btn_close)
        Me.GroupBox1.Controls.Add(Me.btn_refresh)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(633, 309)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'cb_UserManage
        '
        Me.cb_UserManage.AutoSize = True
        Me.cb_UserManage.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_UserManage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.cb_UserManage.Location = New System.Drawing.Point(18, 84)
        Me.cb_UserManage.Name = "cb_UserManage"
        Me.cb_UserManage.Size = New System.Drawing.Size(96, 19)
        Me.cb_UserManage.TabIndex = 62
        Me.cb_UserManage.Text = "UserManage"
        Me.cb_UserManage.UseVisualStyleBackColor = True
        '
        'cb_LOG
        '
        Me.cb_LOG.AutoSize = True
        Me.cb_LOG.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_LOG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.cb_LOG.Location = New System.Drawing.Point(231, 55)
        Me.cb_LOG.Name = "cb_LOG"
        Me.cb_LOG.Size = New System.Drawing.Size(50, 19)
        Me.cb_LOG.TabIndex = 61
        Me.cb_LOG.Text = "LOG"
        Me.cb_LOG.UseVisualStyleBackColor = True
        '
        'cb_Reference
        '
        Me.cb_Reference.AutoSize = True
        Me.cb_Reference.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Reference.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.cb_Reference.Location = New System.Drawing.Point(125, 55)
        Me.cb_Reference.Name = "cb_Reference"
        Me.cb_Reference.Size = New System.Drawing.Size(85, 19)
        Me.cb_Reference.TabIndex = 60
        Me.cb_Reference.Text = "Reference"
        Me.cb_Reference.UseVisualStyleBackColor = True
        '
        'cb_Manual
        '
        Me.cb_Manual.AutoSize = True
        Me.cb_Manual.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Manual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.cb_Manual.Location = New System.Drawing.Point(18, 55)
        Me.cb_Manual.Name = "cb_Manual"
        Me.cb_Manual.Size = New System.Drawing.Size(66, 19)
        Me.cb_Manual.TabIndex = 59
        Me.cb_Manual.Text = "Manual"
        Me.cb_Manual.UseVisualStyleBackColor = True
        '
        'cb_Config
        '
        Me.cb_Config.AutoSize = True
        Me.cb_Config.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Config.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.cb_Config.Location = New System.Drawing.Point(231, 25)
        Me.cb_Config.Name = "cb_Config"
        Me.cb_Config.Size = New System.Drawing.Size(62, 19)
        Me.cb_Config.TabIndex = 58
        Me.cb_Config.Text = "Config"
        Me.cb_Config.UseVisualStyleBackColor = True
        '
        'cb_Run
        '
        Me.cb_Run.AutoSize = True
        Me.cb_Run.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Run.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.cb_Run.Location = New System.Drawing.Point(125, 25)
        Me.cb_Run.Name = "cb_Run"
        Me.cb_Run.Size = New System.Drawing.Size(48, 19)
        Me.cb_Run.TabIndex = 57
        Me.cb_Run.Text = "Run"
        Me.cb_Run.UseVisualStyleBackColor = True
        '
        'cb_Dashboard
        '
        Me.cb_Dashboard.AutoSize = True
        Me.cb_Dashboard.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Dashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.cb_Dashboard.Location = New System.Drawing.Point(18, 25)
        Me.cb_Dashboard.Name = "cb_Dashboard"
        Me.cb_Dashboard.Size = New System.Drawing.Size(85, 19)
        Me.cb_Dashboard.TabIndex = 56
        Me.cb_Dashboard.Text = "Dashboard"
        Me.cb_Dashboard.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reset.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btn_reset.Location = New System.Drawing.Point(224, 272)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(84, 23)
        Me.btn_reset.TabIndex = 55
        Me.btn_reset.Text = "Clear All"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btn_save.Location = New System.Drawing.Point(9, 272)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(84, 23)
        Me.btn_save.TabIndex = 54
        Me.btn_save.Text = "save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'lb_id
        '
        Me.lb_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_id.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lb_id.Location = New System.Drawing.Point(534, 54)
        Me.lb_id.Name = "lb_id"
        Me.lb_id.Size = New System.Drawing.Size(25, 25)
        Me.lb_id.TabIndex = 53
        Me.lb_id.Text = "ID"
        Me.lb_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_id
        '
        Me.tb_id.Enabled = False
        Me.tb_id.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.tb_id.Location = New System.Drawing.Point(565, 55)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Size = New System.Drawing.Size(53, 25)
        Me.tb_id.TabIndex = 52
        '
        'tb_confirm
        '
        Me.tb_confirm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_confirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_confirm.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_confirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.tb_confirm.Location = New System.Drawing.Point(424, 236)
        Me.tb_confirm.Name = "tb_confirm"
        Me.tb_confirm.Size = New System.Drawing.Size(194, 25)
        Me.tb_confirm.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(424, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 28)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Confirm New Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_info
        '
        Me.lb_info.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lb_info.Location = New System.Drawing.Point(424, 85)
        Me.lb_info.Name = "lb_info"
        Me.lb_info.Size = New System.Drawing.Size(194, 30)
        Me.lb_info.TabIndex = 47
        Me.lb_info.Text = "Select Role"
        Me.lb_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb_user
        '
        Me.cb_user.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_user.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.cb_user.FormattingEnabled = True
        Me.cb_user.Location = New System.Drawing.Point(425, 118)
        Me.cb_user.Name = "cb_user"
        Me.cb_user.Size = New System.Drawing.Size(193, 25)
        Me.cb_user.TabIndex = 46
        '
        'tb_input
        '
        Me.tb_input.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_input.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.tb_input.Location = New System.Drawing.Point(424, 177)
        Me.tb_input.Name = "tb_input"
        Me.tb_input.Size = New System.Drawing.Size(194, 25)
        Me.tb_input.TabIndex = 48
        '
        'lb_user
        '
        Me.lb_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_user.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.lb_user.Location = New System.Drawing.Point(424, 146)
        Me.lb_user.Name = "lb_user"
        Me.lb_user.Size = New System.Drawing.Size(194, 28)
        Me.lb_user.TabIndex = 49
        Me.lb_user.Text = "Insert New Password"
        Me.lb_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ZCMC_Packing.My.Resources.Resources.Schneider_Electric_Logo_wine
        Me.PictureBox1.InitialImage = Global.ZCMC_Packing.My.Resources.Resources.Schneider_Electric_Logo_wine
        Me.PictureBox1.Location = New System.Drawing.Point(321, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'frmUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(649, 319)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmUserManagement"
        Me.Text = "UserManagement"
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents DataGridViewTable As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tb_confirm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_info As Label
    Friend WithEvents cb_user As ComboBox
    Friend WithEvents tb_input As TextBox
    Friend WithEvents lb_user As Label
    Friend WithEvents lb_id As Label
    Friend WithEvents tb_id As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents cb_UserManage As CheckBox
    Friend WithEvents cb_LOG As CheckBox
    Friend WithEvents cb_Reference As CheckBox
    Friend WithEvents cb_Manual As CheckBox
    Friend WithEvents cb_Config As CheckBox
    Friend WithEvents cb_Run As CheckBox
    Friend WithEvents cb_Dashboard As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
