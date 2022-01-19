Public Class ReferenceData
    Private _artNumber As String = String.Empty
    Private _reference As String = String.Empty
    Private _qtyInd As String = String.Empty
    Private _qtyGroup As String = String.Empty
    Private _bitmap As String = String.Empty
    Private _logOffer As String = String.Empty
    Private _Information As String = String.Empty
    Public NewProduct As ReferenceData

    Public Property Art_Number As String
        Get
            Return _artNumber
        End Get
        Set(value As String)
            _artNumber = value
        End Set
    End Property

    Public Property Reference As String
        Get
            Return _reference
        End Get
        Set(value As String)
            _reference = value
        End Set
    End Property

    Public Property Qty_Individual As String
        Get
            Return _qtyInd
        End Get
        Set(value As String)
            _qtyInd = value
        End Set
    End Property

    Public Property Qty_Group As String
        Get
            Return _qtyGroup
        End Get
        Set(value As String)
            _qtyGroup = value
        End Set
    End Property

    Public Property Bitmap As String
        Get
            Return _bitmap
        End Get
        Set(value As String)
            _bitmap = value
        End Set
    End Property

    Public Property Log_Offer As String
        Get
            Return _logOffer
        End Get
        Set(value As String)
            _logOffer = value
        End Set
    End Property

    Public Property Information As String
        Get
            Return _Information
        End Get
        Set(value As String)
            _Information = value
        End Set
    End Property



End Class
