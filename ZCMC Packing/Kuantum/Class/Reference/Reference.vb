Imports Database
Public Class Reference
    Implements IReference
    Private Shared _instance As Reference
    Dim _database As DBManager = DBManager.getInstance()
    Dim _dbProduct As Access = New Access()

    Private _Reff As ReferenceData = New ReferenceData()
    Private _dt As DataTable

    Public Sub New()

    End Sub

    Public Shared Function getInstance() As Reference
        If _instance Is Nothing Then
            _instance = New Reference()
        End If
        Return _instance
    End Function

    Public Function Close() As Boolean Implements IReference.Close
        'Code
        Return True
    End Function

    Public Function Open() As Boolean Implements IReference.Open
        'Code
        Dim status As Boolean = False
        If Not _dbProduct.isConnected Then
            _dbProduct = _database.GetDataBase("dbProduct.mdb", "PD01", "-Access", "Reference")
            status = _dbProduct._isConnected
            status = True
        End If
        Return status
    End Function

    Public Function ReadData(dbSelect As String, table As String, where As String) As DataTable Implements IReference.ReadData
        Dim dt As DataTable = New DataTable()
        Try
            Dim str_select As String = String.Format("{0}", dbSelect)
            Dim str_where As String = String.Format("Reference = '{0}'", where)


            dt = _dbProduct.DBSelect(str_select, table, str_where)

        Catch ex As Exception

        End Try
        Return dt

    End Function

    Public Function Read(ref As String, artno As String) As DataTable Implements IReference.Read
        Dim dt As DataTable = New DataTable()
        Dim str_where As String = ""

        If artno <> String.Empty And ref <> String.Empty Then
            str_where = String.Format("Art_Number = '{0}' and Reference = '{1}' ", artno, ref)
        ElseIf artno <> String.Empty And ref = String.Empty Then
            str_where = String.Format("Art_Number = '{0}'", artno, ref)
        ElseIf artno = String.Empty And ref <> String.Empty Then
            str_where = String.Format("Reference = '{0}", artno, ref)
        Else
            str_where = String.Empty

        End If
        dt = _dbProduct.DBSelect("*", "ProductData", str_where)
        Return dt
    End Function

    Public Sub Insert(newProduct As ReferenceData) Implements IReference.Insert
        With newProduct
            InsertProd(.Art_Number, .Reference, .Qty_Individual, .Qty_Group, .Bitmap, .Information)
        End With
    End Sub
    Public Sub Update(product As ReferenceData) Implements IReference.Update
        With product
            setValue("Art_Number", .Art_Number, .Reference)
            setValue("Qty_ind", .Qty_Individual, .Reference)
            setValue("Qty_Group", .Qty_Group, .Reference)
            setValue("Bitmap", .Bitmap, .Reference)
            setValue("InformationPic", .Information, .Reference)

        End With
    End Sub

    Private Sub InsertProd(art_number As String, reff As String, qty_ind As String, qty_group As String, Bitmap As String, information As String)
        Try
            Dim str_param = "(Art_Number,Reference,Qty_ind,Qty_Group,Bitmap,InformationPic)"
            Dim str_value = String.Format("('{0}','{1}','{2}','{3}','{4}','{5}')", art_number, reff, qty_ind, qty_group, Bitmap, information)
            _dbProduct.DBInsert("ProductData", str_param, str_value)
            'Code Insert to Product Data Reference
        Catch ex As Exception

        End Try
    End Sub

    Private Sub setValue(param As String, val As String, where As String)
        Try
            Dim str_param As String = String.Format("{0} = '{1}'", param, val)
            Dim str_where As String = String.Format("Reference='{0}'", where)
            _dbProduct.DBUpdate("ProductData", str_param, str_where)
            'Code Update to Product Data
        Catch ex As Exception

        End Try

    End Sub

    Private Function getValue(Item As String) As String
        Dim val As String = ""
        Try
            Dim str_where As String = String.Format("Item='{0}'", Item)
            Dim dt As DataTable = New DataTable()
            'Eksekusi Database Config (Select)

            If dt.Rows.Count > 0 Then
                val = dt.Rows(0).Item(0)
            End If
        Catch ex As Exception

        End Try
        Return val
    End Function

    Public Function loadTable()
        Dim dt As New DataTable
        Try
            dt = _dbProduct.DBSelect("*", "ProductData", String.Empty)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dt
    End Function
End Class
