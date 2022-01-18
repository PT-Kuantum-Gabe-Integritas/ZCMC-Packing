Public Class frmHome

    Public Enum CONTROL
        REFF
        PO
        TOTAL_QTY
        IND_QTY
        GROUP_QTY
        IND_IMG
        GROUP_IMG
        PRODUCT_IMG
    End Enum

    Public Sub UIMessage(msg As String)
        If InvokeRequired Then
            Invoke(Sub() UIMessage(msg))
            Return
        End If
        lb_msg.Text = msg
    End Sub

    Public Sub UpdateUI(ctrl As CONTROL, img As Image)
        If InvokeRequired Then
            Invoke(Sub() UpdateUI(ctrl, img))
            Return
        End If

        Select Case ctrl
            Case CONTROL.IND_IMG
                pbInd.Image = img
            Case CONTROL.GROUP_IMG
                pbGroup.Image = img
            Case CONTROL.PRODUCT_IMG
                pbPI.Image = img
        End Select
    End Sub

    Public Sub UpdateUI(ctrl As CONTROL, str As String)
        If InvokeRequired Then
            Invoke(Sub() UpdateUI(ctrl, str))
            Return
        End If

        Select Case ctrl
            Case CONTROL.REFF
                lb_PO.Text = str
            Case CONTROL.PO
                lb_Reff.Text = str
            Case CONTROL.TOTAL_QTY
                lb_Total.Text = Integer.Parse(str)
            Case CONTROL.IND_QTY
                lb_qtyInd.Text = Integer.Parse(str)
            Case CONTROL.GROUP_QTY
                lb_qtyGroup.Text = Integer.Parse(str)
        End Select
    End Sub



End Class