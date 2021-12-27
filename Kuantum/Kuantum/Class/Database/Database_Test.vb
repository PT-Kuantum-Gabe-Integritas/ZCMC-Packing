Public Class Database_Test

    Private _db_Access As Access
    Private _db_sqlite As SQLite
    Private dataType As Integer = 0

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Dim index As Integer = CheckedListBox1.SelectedIndex
        Dim count = CheckedListBox1.Items.Count

        For x As Integer = 0 To count - 1
            If index <> x Then
                CheckedListBox1.SetItemChecked(x, False)
            End If

            If index = 0 Then

                dataType = 0
            Else
                dataType = 1

            End If


        Next


    End Sub

    Public Function Open()
        Try
            If dataType = 0 Then
                _db_sqlite = New SQLite(Application.StartupPath)
                Return _db_sqlite.Open("Product", SQLite.DBTYPE.CONFIG)
            Else
                _db_Access = New Access(Application.StartupPath)
                Return _db_Access.Open("dbProduct", Access.DBTYPE.DATABASE)
            End If


        Catch ex As Exception
            Return False
        End Try


    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        btnOpen.Enabled = True
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Open()
        btnOpen.Enabled = False
    End Sub
End Class