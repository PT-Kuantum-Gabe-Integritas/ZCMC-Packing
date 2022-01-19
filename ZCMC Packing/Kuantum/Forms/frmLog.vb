Public Class frmLog

    Private _datalog As DataLog
    Private _offset As Integer = 0

    Public Sub Initialize()
        comboFilter.Checked = False
        dtFrom.Enabled = False
        dtTo.Enabled = False
        cbPO.Items.Clear()
        txtReff.Text = ""
        cbPO.Items.AddRange(_datalog.View(DataLog.COL.PO).ToArray())

        txtReff.Focus()
    End Sub

    Public Sub LoadTable()

        Dim vp As DataLog.VIEWPARAMETER
        vp.po = cbPO.Text
        vp.reff = txtReff.Text
        vp.datein_from = dtFrom.Value
        vp.datein_to = dtTo.Value
        vp.offset = _offset.ToString()

        If cbPO.Text IsNot String.Empty Then
            vp.by_po = True
        Else
            vp.by_po = False
        End If

        If txtReff.Text IsNot String.Empty Then
            vp.by_reff = True
        Else
            vp.by_reff = False
        End If

        vp.by_datein = comboFilter.Checked

        Dim dt = _datalog.View(vp)
        For cnt As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(cnt).Item("status") = "1" Then
                dt.Rows(cnt).Item("status") = "Finish Lot"
            ElseIf dt.Rows(cnt).Item("status") = "2" Then
                dt.Rows(cnt).Item("status") = "InComplete Lot"
            Else
                dt.Rows(cnt).Item("status") = "On Hold"
            End If
        Next
        dgvOrder.DataSource = Nothing
        dgvOrder.Rows.Clear()
        dgvOrder.DataSource = dt
        dgvOrder.AllowUserToAddRows = False
        dgvOrder.AllowUserToResizeRows = False
        dgvOrder.EditMode = DataGridViewEditMode.EditProgrammatically
        'lbOffset.Text = String.Format("Show {0} Record(s)", dgvOrder.Rows.Count)
        dgvOrder.Columns("po_number").HeaderText = "PO No."
        dgvOrder.Columns("reference").HeaderText = "Reference"
        dgvOrder.Columns("qty_po").HeaderText = "PO Qty"
        dgvOrder.Columns("qty_ind").HeaderText = "Qty Individual"
        dgvOrder.Columns("qty_group").HeaderText = "Qty Group"
        dgvOrder.Columns("status").HeaderText = "Status"
        dgvOrder.Columns("user").HeaderText = "User in"
        dgvOrder.Columns("date_in").HeaderText = "Date In"
        dgvOrder.Columns("date_out").HeaderText = "Date Out"


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadTable()
    End Sub

    Private Sub frmLog_Load(sender As Object, e As EventArgs) Handles Me.Load
        _datalog = DataLog.getInstance()
        _datalog.Open()
        Initialize()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Initialize()
    End Sub

    Private Sub comboFilter_CheckedChanged(sender As Object, e As EventArgs) Handles comboFilter.CheckedChanged
        If comboFilter.Checked Then
            dtFrom.Enabled = True
            dtTo.Enabled = True
        Else
            dtFrom.Enabled = False
            dtTo.Enabled = False
        End If
    End Sub
End Class