Imports System.Threading
Public Class frmRun

    Dim order As SelectPO = SelectPO.getInstance()


    Private Sub frmRun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initial()
        txtScan.Focus()

        'dbSelect = DatabaseList.GetDataBase("Production", "PN01", 0, Database.DATATYPE.PRODUCT)
    End Sub

    Private Sub txtScan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtScan.KeyDown

        If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter Then
            Dim masukan As String = txtScan.Text.ToUpper().Trim(vbCrLf, vbLf, vbCr)
            lbl_Instruction.Text = order.Scan(masukan)
            lbPO.Text = order.ProductOrder
            lbReff.Text = order.Refference
            lbQty.Text = order.Quantity
            'Done = order.Done
            ResetInput()
        End If
    End Sub



    Private Sub ResetInput()
        txtScan.Text = String.Empty
        txtScan.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Initial()
    End Sub

    Public Sub Initial()
        lbPO.Text = String.Empty
        lbReff.Text = String.Empty
        lbQty.Text = String.Empty
        order.Sequence = SelectPO.SEQ.PO
        lbl_Instruction.Text = "Please Scan PO"
    End Sub


End Class