Public Class Mains
    Private tesSQ As IDBManager = New DBManager()
    Private a As SQLite = New SQLite()


    Sub blabla()
        a = tesSQ.GetDataBase("Product", "P01", 0, Database.DATATYPE.PRODUCT)
    End Sub
End Class
