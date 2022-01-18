Imports Database
Public Class Reference
    Implements IReference
    Private Shared _instance As Reference
    Dim _database As DBManager = DBManager.getInstance()
    Dim _dbProduction As SQLite = New SQLite()


    Public Sub New()

    End Sub

    Public Shared Function getInstance() As Reference
        If _instance Is Nothing Then
            _instance = New Reference()
        End If
        Return _instance
    End Function

    Private _Reff As ReferenceData = New ReferenceData()
    Private _dt As DataTable


    Public Function Close() As Boolean Implements IReference.Close
        'Code
        Return True
    End Function

    Public Function Open() As Boolean Implements IReference.Open
        'Code
        '_dbProduction = _database.GetDataBase("Production.db", "PO01", "-SQLite", "Production")
        Return True
    End Function

    Public Function Read() As DataTable Implements IReference.Read
        Dim dt As DataTable = New DataTable()
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
            Dim str_param = "(ArtNumber,Reference,Qty_ind,Qty_Group,Bitmap,InformationPic)"
            Dim str_value = String.Format("('{0}','{1}','{2}','{3}','{4}','{5}')", art_number, reff, qty_ind, qty_group, Bitmap, information)

            'Code Insert to Product Data Reference
        Catch ex As Exception

        End Try
    End Sub

    Private Sub setValue(param As String, val As String, where As String)
        Try
            Dim str_param As String = String.Format("{0}='{1}'", param, val)
            Dim str_where As String = String.Format("Reference='{1}'", where)

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

    Public Function ReadAll(table As String) As DataTable Implements IReference.ReadAll
        Dim dt As DataTable = New DataTable()
        Try
            ' dt = Select File dt = databaseee.DBSelect("*", tableName, "")
        Catch ex As Exception

        End Try
        Return dt
    End Function

    Public Function ReadData(dbSelect As String, table As String, where As String) As DataTable Implements IReference.ReadData
        Dim dt As DataTable = New DataTable()
        Try
            ' dt = Select File
        Catch ex As Exception

        End Try
        Return dt

    End Function



End Class
