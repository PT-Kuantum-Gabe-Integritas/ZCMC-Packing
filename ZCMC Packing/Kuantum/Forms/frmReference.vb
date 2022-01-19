Public Class frmReference
    Public _dbProd As Reference = Reference.getInstance()
    Public _reffData As ReferenceData = New ReferenceData()


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            If row.Selected = True Then
                txtArt.Text = row.DataBoundItem(6).ToString
                txtBitmap.Text = row.DataBoundItem(4).ToString
                txtGroup.Text = row.DataBoundItem(3).ToString
                txtInd.Text = row.DataBoundItem(2).ToString
                txtReff.Text = row.DataBoundItem(0).ToString
            End If
        Next
    End Sub

    Private Sub frmReference_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim tb As DataTable = New DataTable()
        _dbProd.Open()
        'loadtb()

    End Sub

    Private Sub loadtb()
        Dim tb As DataTable = _dbProd.loadTable()
        DataGridView1.ReadOnly = True
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = tb
        DataGridView1.ClearSelection()
        For Each row As DataRow In tb.Rows
            If cbArt.Items.Contains(row.Item(6)) Then

            Else
                cbArt.Items.Add(row.Item(6))
            End If
            If cbReff.Items.Contains(row.Item(0)) Then

            Else
                cbReff.Items.Add(row.Item(0))
            End If
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With _reffData
            .Art_Number = txtArt.Text
            .Reference = txtReff.Text
            .Qty_Group = txtGroup.Text
            .Qty_Individual = txtInd.Text
            .Bitmap = txtBitmap.Text
        End With
        _dbProd.Update(_reffData)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With _reffData
            .Art_Number = txtArt.Text
            .Reference = txtReff.Text
            .Qty_Group = txtGroup.Text
            .Qty_Individual = txtInd.Text
            .Bitmap = txtBitmap.Text
        End With
        _dbProd.Insert(_reffData)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        loadtb()
        txtArt.Text = String.Empty
        txtBitmap.Text = String.Empty
        txtGroup.Text = String.Empty
        txtInd.Text = String.Empty
        txtReff.Text = String.Empty
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim tb As DataTable = _dbProd.Read(cbReff.Text, cbArt.Text)
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = tb
        DataGridView1.ClearSelection()
    End Sub
End Class