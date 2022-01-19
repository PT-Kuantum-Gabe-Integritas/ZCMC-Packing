Imports Database
Public Class DataLog
    Private Shared _instance As DataLog
    Private database As DBManager
    Private dbProduction As SQLite = New SQLite()

    Public Sub New()

    End Sub

    Public Shared Function getInstance() As DataLog
        If _instance Is Nothing Then
            _instance = New DataLog()
        End If
        Return _instance
    End Function

    Public Structure VIEWPARAMETER
        Public po As String
        Public reff As String
        Public datein_from As Date
        Public datein_to As Date
        Public by_po As Boolean
        Public by_reff As Boolean
        Public by_datein As Boolean
        Public by_dateout As Boolean
        Public offset As String
    End Structure

    Public Function GetDateString(_date As Date) As String
        Return String.Format("{0:0000}-{1:00}-{2:00}", _date.Year, _date.Month, _date.Day)
    End Function

    Public Enum COL
        NP
        PACK
        IND
        GROUP
        USER
        DATEOUT
        COMPLETE
        PO
    End Enum

    Private Function ColString(_col As COL) As String
        Select Case _col
            Case COL.NP
                Return "qty_np"
            Case COL.PACK
                Return "qty_pack"
            Case COL.IND
                Return "qty_ind"
            Case COL.GROUP
                Return "qty_group"
            Case COL.COMPLETE
                Return "status"
            Case COL.DATEOUT
                Return "date_out"
            Case COL.PO
                Return "po_number"
            Case Else
                Return "status"
        End Select
    End Function

    Public Function View(_col As COL) As List(Of String)
        Dim result As List(Of String) = New List(Of String)()
        Dim dt As DataTable = New DataTable
        Try

            Dim str_select As String = ColString(_col)

            dt = dbProduction.DBSelect(str_select, "PRODUCT", String.Empty)
            For cnt As Integer = 0 To dt.Rows.Count - 1
                result.Add(dt.Rows(cnt).Item(str_select.ToString()))
            Next
            Return result
        Catch ex As Exception
            MsgBox(String.Format("View Command Failed") & vbNewLine & ex.Message)
            dt.Clear()
            Return result
        End Try
    End Function

    Public Function View(_params As VIEWPARAMETER) As DataTable
        Dim query_po As String
        Dim query_reff As String
        Dim query_datein As String
        Dim dt As DataTable = New DataTable()
        Dim str_where As String = String.Empty

        Try
            Dim str_select As String = "*"



            'Search by Product Order
            If _params.by_po Then
                query_po = "po_number='" & _params.po & "'"
            Else
                query_po = ""
            End If
            'Search By Refference Product or by Reff&PO
            If _params.by_reff Then
                If _params.by_po Then
                    query_reff = " AND reference='" & _params.reff & "'"
                Else
                    query_reff = "reference='" & _params.reff & "'"
                End If
            Else
                query_reff = ""
            End If


            'Search by date in
            If _params.by_datein Then
                If _params.by_po Or _params.by_reff Then
                    query_datein = "AND date_in BETWEEN date('" & GetDateString(_params.datein_from) & "') AND date('" & GetDateString(_params.datein_to) & "') "
                Else
                    query_datein = "date_in BETWEEN date('" & GetDateString(_params.datein_from) & "') AND date('" & GetDateString(_params.datein_to) & "') "
                End If
            Else
                query_datein = ""
            End If

            If _params.by_po Or _params.by_reff Or _params.by_datein Then
                str_where = query_po & query_reff & query_datein
                dt = dbProduction.DBSelect("*", "PRODUCT", str_where)
            Else
                dt = dbProduction.DBSelect("*", "PRODUCT", String.Empty)
            End If




        Catch ex As Exception
            MsgBox(String.Format("View Command Failed") & vbNewLine & ex.Message)
            dt.Clear()
            Return dt
        End Try


        Return dt
    End Function



    Public Function Open() As Boolean
        Dim status As Boolean
        If Not dbProduction.isConnected Then
            database = DBManager.getInstance()
            dbProduction = database.GetDataBase("Production.db", "P01", "-SQLite", "Order")
            status = True
        End If

        Return status
    End Function
End Class
