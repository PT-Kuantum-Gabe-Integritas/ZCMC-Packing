Public Class frmMain
    Private tet As Integer = 5
    Private teuut As Integer = 5



    Private Sub btn(bt As ToolStripButton)
        If Not bt.Checked Then
            bt.Checked = True
        Else
            bt.Checked = False
        End If
        MsgBox(ToolStrip1.Controls.Count.ToString())

        lbMenu.Text = bt.Tag
    End Sub


    Private Sub btnTDash_Click(sender As Object, e As EventArgs) Handles btnTDash.Click
        btn(sender)

    End Sub











End Class
