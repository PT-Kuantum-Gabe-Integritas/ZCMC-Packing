Imports System.Threading
Public Class frmRun

    Public Enum SEQ
        PO
        REFF
        QTY
    End Enum

    Private _seq As SEQ

    Public Property Sequence As SEQ
        Get
            Return _seq
        End Get
        Set(value As SEQ)
            _seq = value
        End Set
    End Property

    Private Sub frmRun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtScan.Focus()
    End Sub

    Private Sub txtScan_KeyDown(sender As Object, e As KeyEventArgs) Handles txtScan.KeyDown

        If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter Then
            Dim masukan As String = txtScan.Text.ToUpper().Trim(vbCrLf, vbLf, vbCr)
            Thread.Sleep(200)
            Select Case _seq
                Case SEQ.PO
                    Dim length = masukan.Length
                    If length < 10 Then
                        lbl_Instruction.Text = "PO Text Length is too short" + vbNewLine + "Please Scan PO.No."
                        ResetInput()
                        Return
                    End If
                    Dim num = IsNumeric(masukan)
                    If Not num Then
                        lbl_Instruction.Text = "PO Text is not Number" + vbNewLine + "Please Scan PO.No."
                        ResetInput()
                        Return
                    End If
                    lbPO.Text = masukan
                    ResetInput()
                    _seq = SEQ.REFF
                    lbl_Instruction.Text = "Please Scan Refference No."

                Case SEQ.REFF
                    Dim num = IsNumeric(masukan)
                    If num Then
                        lbl_Instruction.Text = "Reference Text cannot be Number" + vbNewLine + "Please Scan Reference."
                        ResetInput()
                        Return
                    End If

                    If masukan.IndexOf("ZC") = -1 Then
                        lbl_Instruction.Text = "Reference Format Wrong, Miss 'ZCMC'" + vbNewLine + "Please Scan New reference"
                        ResetInput()
                        Return
                    End If

                    lbReff.Text = masukan

                    'UPDATE DATA TO SQLITE'

                    'BLABLALBA'


                    'UPDATE DATA TO SQLITE'

                    ResetInput()
                    _seq = SEQ.QTY
                    lbl_Instruction.Text = "Please Scan Qty"
                    masukan = String.Empty


                Case SEQ.QTY
                    Dim num = IsNumeric(masukan)
                    If Not num Then
                        lbl_Instruction.Text = "Qty must be Number" + vbNewLine + "Please Scan Qty."
                        ResetInput()
                        Return
                    End If

                    lbQty.Text = masukan
                    ResetInput()
                    _seq = SEQ.PO
                    masukan = String.Empty

            End Select

        End If
    End Sub



    Private Sub ResetInput()
        txtScan.Text = String.Empty
        txtScan.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'frmMain.LoadPanel(_frmMain.TAB.REFERENCE)
        _seq = SEQ.PO
        Initial()
    End Sub

    Private Sub Initial()
        lbPO.Text = String.Empty
        lbReff.Text = String.Empty
        lbQty.Text = String.Empty
        _seq = SEQ.PO
    End Sub
End Class