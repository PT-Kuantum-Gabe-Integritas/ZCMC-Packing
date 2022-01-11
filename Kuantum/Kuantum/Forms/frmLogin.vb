Public Class frm_Login

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint
        cb_role.Text = "- Select Role -"
    End Sub

    Private Sub tb_user_TextChanged(sender As Object, e As EventArgs) Handles tb_user.TextChanged

    End Sub

    Private Sub cb_role_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_role.SelectedIndexChanged
        If cb_role.Text = "Engineer" Then
            UIMode(1)
        ElseIf cb_role.Text = "Admin" Then
            UIMode(2)
        Else
            UIMode(3)
        End If

    End Sub



    Private Sub UIMode(ByVal permit As Integer)
        Select Case permit
            Case 1
                lb_info.Text = "Please Fill The Password"
            Case 2
                lb_info.Text = "Please Fill The Password"
            Case 3
                lb_info.Text = "Please Fill Your Employee Number.."

        End Select
    End Sub
End Class