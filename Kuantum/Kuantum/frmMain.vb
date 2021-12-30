Public Class frmMain
    Dim last_btn As ToolStripButton


    Private Sub Button(bt As ToolStripButton)

        Try
            last_btn.BackgroundImage = Nothing
        Catch ex As Exception

        End Try
        bt.BackgroundImage = My.Resources.Click1
        last_btn = bt
    End Sub

    Private Sub btnShow(bt As ToolStripButton)
        bt.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        bt.Width = 160
        bt.Height = 60
    End Sub

    Private Sub btnHide(bt As ToolStripButton)
        bt.DisplayStyle = ToolStripItemDisplayStyle.Image
        bt.Width = 65
        bt.Height = 60
    End Sub


    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles btnTDash.Click, btnTRun.Click, btnTReff.Click, btnTManual.Click, btnTLog.Click, btnTConfig.Click, btnTAbout.Click
        Button(sender)

    End Sub

    Private Sub ButtonEnter(sender As Object, e As EventArgs) Handles btnTDash.MouseEnter, btnTRun.MouseEnter, btnTReff.MouseEnter, btnTManual.MouseEnter, btnTLog.MouseEnter, btnTConfig.MouseEnter, btnTAbout.MouseEnter
        btnShow(sender)

    End Sub

    Private Sub ButtonLeave(sender As Object, e As EventArgs) Handles btnTDash.MouseLeave, btnTRun.MouseLeave, btnTReff.MouseLeave, btnTManual.MouseLeave, btnTLog.MouseLeave, btnTConfig.MouseLeave, btnTAbout.MouseLeave
        btnHide(sender)
    End Sub


End Class
