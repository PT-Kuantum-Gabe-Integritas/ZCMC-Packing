Imports Database
Public Class SelectPO

    Private _ui As UserInterface = UserInterface.getInstance()

    'Private _database As DBManager = DBManager.getInstance()
    Private _production As Production = Production.getInstance()
    'Private _dbProduction As SQLite = New SQLite()

    Public Enum SEQ
        PO
        REFF
        QTY
    End Enum
     
    Public Property Sequence As SEQ
        Get
            Return _seq
        End Get
        Set(value As SEQ)
            _seq = value
        End Set
    End Property

    Public Property ProductOrder As String
        Get
            Return _po
        End Get
        Set(value As String)
            _po = value
        End Set
    End Property


    Public Property Refference As String
        Get
            Return _reff
        End Get
        Set(value As String)
            _reff = value
        End Set
    End Property
    Public Property Quantity As String
        Get
            Return _qty
        End Get
        Set(value As String)
            _qty = value
        End Set
    End Property
    Public Property Done As Boolean
        Get
            Return _done
        End Get
        Set(value As Boolean)
            _done = value
        End Set
    End Property


    Private _po As String
    Private _reff As String
    Private _qty As String
    Private _seq As SEQ
    Private Shared _instance As SelectPO
    Private _done As Boolean


    Public Sub New()

    End Sub

    Public Shared Function getInstance() As SelectPO
        If _instance Is Nothing Then
            _instance = New SelectPO()
        End If
        Return _instance
    End Function
    Public Function Scan(input As String) As String

        Dim instruction As String = String.Empty

        Select Case _seq
            Case SEQ.PO

                'Connect the Production Database
                If Not _production.dbProduction.isConnected Then
                    _production.Open()
                End If

                Dim length = input.Length
                If length < 10 Then
                    instruction = "PO Text Length is too short" + vbNewLine + "Please Scan PO.No."
                    Return instruction
                End If
                Dim num = IsNumeric(input)
                If Not num Then
                    instruction = "PO Text is not Number" + vbNewLine + "Please Scan PO.No."
                    Return instruction
                End If
                _po = input
                _seq = SEQ.REFF
                instruction = "Please Scan Refference No."

            Case SEQ.REFF
                Dim num = IsNumeric(input)
                If num Then
                    instruction = "Reference Text cannot be Number" + vbNewLine + "Please Scan Reference."
                    Return instruction
                End If
                If input.IndexOf("ZC") = -1 Then
                    instruction = "Reference Format Wrong, Miss 'ZCMC'" + vbNewLine + "Please Scan New reference"
                    Return instruction
                End If
                _reff = input

                'CHECKING WORK ORDER PRODUCTION IN DATABASE
                Dim res = _production.CheckTicket(_po, _reff)
                If res Then
                    Dim dt = _production.GetPOInfo(_po, _reff)
                    Dim cnt = dt.Rows.Count
                    If cnt > 0 Then
                        cnt -= 1
                    Else

                    End If
                    _qty = dt.Rows(cnt).Item("qty_po").ToString()
                    Dim stats = dt.Rows(cnt).Item("status").ToString()
                    Dim qtyInd = dt.Rows(cnt).Item("qty_ind").ToString()
                    Dim qtyGroup = dt.Rows(cnt).Item("qty_group").ToString()

                    If stats = "1" Then
                        instruction = "PO Already Completed." & vbNewLine & "please scan another PO!"
                        Return instruction
                    Else
                        _seq = SEQ.PO
                        _production.SetOrder(_po, _reff, _qty, qtyInd, qtyGroup)
                    End If
                Else
                    _seq = SEQ.QTY
                    instruction = "Please Scan Quantity."
                End If
                'SETELAH CHECK LANJUT KE
            Case SEQ.QTY
                Dim num = IsNumeric(input)
                If Not num Then
                    instruction = "Qty must be Number" + vbNewLine + "Please Scan Qty."
                    Return instruction
                End If
                _qty = input
                instruction = "Order Will be processed..."
                _seq = SEQ.PO
                _production.Insert(_po, _reff, _qty, "User")
                _production.SetOrder(_po, _reff, _qty, "0", "0")


        End Select
        Return instruction
    End Function

End Class
