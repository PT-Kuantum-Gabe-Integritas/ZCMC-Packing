Public Interface IProduction
    Enum COL
        IND
        GROUP
        USER
        DATEOUT
        COMPLETE
        PO
    End Enum
    Function ColString(_col As COL) As String
    Function Starts() As Boolean
    Sub Stops()
    Sub Looping()
    Function Update(setCOL As COL, val As String, po As String, reff As String) As Boolean
    Sub SetOrder(po As String, reff As String, qty As String, qty_ind As String, qty_group As String)
    Function CheckTicket(po As String, reff As String) As Boolean
    Function GetPOInfo(po As String, reff As String) As DataTable
    Function Insert(po As String, reff As String, qty_po As String, user As String) As Boolean
    Function Open() As Boolean

    Sub Reset()
End Interface
