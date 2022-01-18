Public Class frmSplash
    Public Sub setProgress(Msg As String, value As Integer)
        lb_msg.Text = Msg
        pb_progress.Value = value
        lb_progress.Text = String.Format("{0}%", value)
    End Sub




End Class