Imports Database
Public Class frmUserManagement
    Private _path As String = Application.StartupPath
    Public _userManager As UserManagement = New UserManagement()

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        lb_info.Text = "Select cell you want to Delete"
        For Each row As DataGridViewRow In DataGridViewTable.SelectedRows
            If row.Selected = True Then
                _userManager.DeleteUser(DataGridViewTable.CurrentRow.Cells(0).Value.ToString)
            End If
        Next
        updateData(DataGridViewTable)
        loadtb()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        _userManager.Initialize()
        tb_confirm.Enabled = False
        tb_input.Enabled = False
        loadtb()
    End Sub

    Private Sub loadtb()
        Dim tb As DataTable = _userManager.loadTable(0)

        DataGridViewTable.DataSource = Nothing
        loadData(DataGridViewTable, tb)
        DataGridViewTable.ClearSelection()
        For Each row As DataRow In tb.Rows
            If cb_user.Items.Contains(row.Item(1)) Then

            Else
                cb_user.Items.Add(row.Item(1))
                cbRole.Items.Add(row.Item(1))
            End If
            If cbID.Items.Contains(row.Item(0)) Then
            Else
                cbID.Items.Add(row.Item(0))
            End If
        Next
    End Sub

    Private Sub cb_user_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_user.SelectedValueChanged
        If cb_user.SelectedValue = 0 Or cb_user.Text = "" Then
            tb_confirm.Enabled = False
            tb_input.Enabled = False
        End If

        tb_confirm.Enabled = True
        tb_input.Enabled = True
    End Sub

    Private Sub DataGridViewTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTable.CellClick
        cb_user.Enabled = False
        For Each row As DataGridViewRow In DataGridViewTable.SelectedRows
            If row.Selected = True Then
                tb_id.Text = (DataGridViewTable.CurrentRow.Cells(0).Value.ToString)
                cb_user.Text = (DataGridViewTable.CurrentRow.Cells(1).Value.ToString)
            End If
        Next
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If cb_user.Text Is "" Or cb_user.SelectedIndex = -1 And tb_id.Text = "" Then
            lb_info.Text = "Select User"
        ElseIf cb_user.Enabled = True Then
            If tb_input.Text = tb_confirm.Text Then
                _userManager.AddUser(cb_user.Text, tb_input.Text)
            Else
                lb_info.Text = "Password is not the same"
            End If
        ElseIf tb_input.Text = tb_confirm.Text And tb_input.Text <> "" Then
            _userManager.UpdateUser(tb_id.Text, tb_input.Text, String.Empty)
        Else

            updateData(DataGridViewTable)
        End If

        loadtb()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        loadtb()
        tb_id.Clear()
        tb_confirm.Clear()
        tb_input.Clear()
        DataGridViewTable.ClearSelection()
        cb_user.Enabled = True
        cb_user.SelectedIndex = -1
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim tb As DataTable = _userManager.Read(cbID.Text, cbRole.Text)
        loadData(DataGridViewTable, tb)
        DataGridViewTable.ClearSelection()
    End Sub
    Private Sub loadData(dgv As DataGridView, dt As DataTable)
        With dgv
            .Rows.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1
                Try
                    .Rows.Add(dt.Rows(i).Item("id"), dt.Rows(i).Item("user"), dt.Rows(i).Item("pass"), Convert.ToBoolean(dt.Rows(i).Item("authorization")), Convert.ToBoolean(dt.Rows(i).Item("Dashboard")), Convert.ToBoolean(dt.Rows(i).Item("Run")), Convert.ToBoolean(dt.Rows(i).Item("Config")),
                Convert.ToBoolean(dt.Rows(i).Item("Manual")), Convert.ToBoolean(dt.Rows(i).Item("Reference")), Convert.ToBoolean(dt.Rows(i).Item("Log")),
                 Convert.ToBoolean(dt.Rows(i).Item("UserManage")))
                Catch ex As Exception

                End Try

            Next
        End With
    End Sub

    Private Sub updateData(dgv As DataGridView)
        Dim cb_pass As String = ""
        With dgv
            For i As Integer = 0 To dgv.RowCount - 2
                Dim cb_id As String = (DataGridViewTable.Rows(i).Cells(0).Value.ToString)
                Try
                    cb_pass = (DataGridViewTable.Rows(i).Cells(2).Value.ToString)
                Catch ex As Exception

                End Try
                Dim cb_auth As String = (DataGridViewTable.Rows(i).Cells(3).Value.ToString)
                Dim cb_dsb As String = (DataGridViewTable.Rows(i).Cells(4).Value.ToString)
                Dim cb_rn As String = (DataGridViewTable.Rows(i).Cells(5).Value.ToString)
                Dim cb_cf As String = (DataGridViewTable.Rows(i).Cells(6).Value.ToString)
                Dim cb_mn As String = (DataGridViewTable.Rows(i).Cells(7).Value.ToString)
                Dim cb_rf As String = (DataGridViewTable.Rows(i).Cells(8).Value.ToString)
                Dim cb_lg As String = (DataGridViewTable.Rows(i).Cells(9).Value.ToString)
                Dim cb_um As String = (DataGridViewTable.Rows(i).Cells(10).Value.ToString)

                Dim str_permit As String = String.Format("Dashboard = '{0}', Run = '{1}', Config = '{2}', Manual = '{3}', Reference = '{4}', LOG = '{5}', UserManage = '{6}', authorization = '{7}', ID = '{8}', pass = '{9}'", cb_dsb, cb_rn, cb_cf, cb_mn, cb_rf, cb_lg, cb_um, cb_auth, i + 1, cb_pass)
                _userManager.UpdateUser(cb_id, tb_input.Text, str_permit)

            Next
        End With
    End Sub
End Class