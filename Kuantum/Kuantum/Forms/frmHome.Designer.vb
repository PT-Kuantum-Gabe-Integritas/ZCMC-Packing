<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPO = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblReff = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.pbInd = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblQtyInd = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pbGroup = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblQtyGroup = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pbPI = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.pbInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.pbPI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblPO)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblReff)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1325, 37)
        Me.Panel1.TabIndex = 0
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotal.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.Green
        Me.lblTotal.Location = New System.Drawing.Point(1005, 0)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(320, 37)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "1234567890"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(902, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 37)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total Qty"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPO
        '
        Me.lblPO.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPO.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblPO.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lblPO.ForeColor = System.Drawing.Color.Green
        Me.lblPO.Location = New System.Drawing.Point(554, 0)
        Me.lblPO.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblPO.Name = "lblPO"
        Me.lblPO.Size = New System.Drawing.Size(348, 37)
        Me.lblPO.TabIndex = 3
        Me.lblPO.Text = "1234567890"
        Me.lblPO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(451, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PO No."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReff
        '
        Me.lblReff.BackColor = System.Drawing.Color.Gainsboro
        Me.lblReff.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblReff.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lblReff.ForeColor = System.Drawing.Color.Green
        Me.lblReff.Location = New System.Drawing.Point(103, 0)
        Me.lblReff.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblReff.Name = "lblReff"
        Me.lblReff.Size = New System.Drawing.Size(348, 37)
        Me.lblReff.TabIndex = 1
        Me.lblReff.Text = "Reference"
        Me.lblReff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reference"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.SplitContainer1)
        Me.Panel2.Location = New System.Drawing.Point(4, 45)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(661, 541)
        Me.Panel2.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.pbInd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblQtyInd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label15)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pbGroup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblQtyGroup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Size = New System.Drawing.Size(661, 550)
        Me.SplitContainer1.SplitterDistance = 319
        Me.SplitContainer1.TabIndex = 0
        '
        'pbInd
        '
        Me.pbInd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbInd.BackColor = System.Drawing.Color.Gainsboro
        Me.pbInd.Location = New System.Drawing.Point(0, 123)
        Me.pbInd.Margin = New System.Windows.Forms.Padding(0)
        Me.pbInd.Name = "pbInd"
        Me.pbInd.Size = New System.Drawing.Size(319, 418)
        Me.pbInd.TabIndex = 20
        Me.pbInd.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Gray
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(319, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Preview"
        '
        'lblQtyInd
        '
        Me.lblQtyInd.BackColor = System.Drawing.Color.Black
        Me.lblQtyInd.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblQtyInd.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtyInd.ForeColor = System.Drawing.Color.Lime
        Me.lblQtyInd.Location = New System.Drawing.Point(0, 57)
        Me.lblQtyInd.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblQtyInd.Name = "lblQtyInd"
        Me.lblQtyInd.Size = New System.Drawing.Size(319, 46)
        Me.lblQtyInd.TabIndex = 18
        Me.lblQtyInd.Text = "0000"
        Me.lblQtyInd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Lime
        Me.Label14.Location = New System.Drawing.Point(0, 37)
        Me.Label14.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(319, 20)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Qty"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label15.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(319, 37)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Individual"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbGroup
        '
        Me.pbGroup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbGroup.BackColor = System.Drawing.Color.Gainsboro
        Me.pbGroup.Location = New System.Drawing.Point(0, 123)
        Me.pbGroup.Margin = New System.Windows.Forms.Padding(0)
        Me.pbGroup.Name = "pbGroup"
        Me.pbGroup.Size = New System.Drawing.Size(340, 418)
        Me.pbGroup.TabIndex = 20
        Me.pbGroup.TabStop = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Gray
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(338, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Preview"
        '
        'lblQtyGroup
        '
        Me.lblQtyGroup.BackColor = System.Drawing.Color.Black
        Me.lblQtyGroup.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblQtyGroup.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtyGroup.ForeColor = System.Drawing.Color.Lime
        Me.lblQtyGroup.Location = New System.Drawing.Point(0, 57)
        Me.lblQtyGroup.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblQtyGroup.Name = "lblQtyGroup"
        Me.lblQtyGroup.Size = New System.Drawing.Size(338, 46)
        Me.lblQtyGroup.TabIndex = 18
        Me.lblQtyGroup.Text = "0000"
        Me.lblQtyGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(0, 37)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(338, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Qty"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(338, 37)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Group"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.pbPI)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Location = New System.Drawing.Point(670, 42)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(655, 553)
        Me.Panel4.TabIndex = 2
        '
        'pbPI
        '
        Me.pbPI.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbPI.BackColor = System.Drawing.Color.Gainsboro
        Me.pbPI.Location = New System.Drawing.Point(0, 60)
        Me.pbPI.Margin = New System.Windows.Forms.Padding(0)
        Me.pbPI.Name = "pbPI"
        Me.pbPI.Size = New System.Drawing.Size(655, 484)
        Me.pbPI.TabIndex = 11
        Me.pbPI.TabStop = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Gray
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(0, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(650, 20)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Preview"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(0, 3)
        Me.Label12.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(650, 37)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Product Information"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1325, 600)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.pbInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.pbPI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblReff As Label
    Friend WithEvents lblPO As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pbPI As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents pbInd As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblQtyInd As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents pbGroup As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblQtyGroup As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
