Imports MB.Variable

Public Class Variable
    Public Enum Name
        I_poka1
        I_poka2
        I_poka3
        I_poka4
        I_np_print
        I_np_out
        I_ind_print
        I_ind_out
        Q_Ind_Trig
        Q_poka
        Q_np
    End Enum

    Public Enum Status
        Connected
        Disconnected
    End Enum
    Public Structure ReadingResult
        Public Address As Integer
        Public Value As Short
    End Structure

    Public Structure Memories
        Public AddrName As Name
        Public Address As Integer
        Public Bit As Integer
        Public IsBinary As Boolean
        Public Sub New(AddressName As Name, Addr As Integer, BitId As Integer, Binary As Boolean)
            AddrName = AddressName
            Address = Addr
            Bit = BitId
            IsBinary = Binary
        End Sub

    End Structure
End Class

Class VariableData
    Private _name As String
    Private _addr As Integer

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
    Public Property Address As Integer
        Get
            Return _addr
        End Get
        Set(value As Integer)
            _addr = value
        End Set
    End Property


    Public Sub New()

    End Sub

    Overridable Sub SetValue(new_value As Short)

    End Sub
End Class

Class BinaryType
    Inherits VariableData
    Private _data As Boolean
    Private _bit As Integer
    Public Property Data As Boolean
        Get
            Return _data
        End Get
        Set(value As Boolean)
            _data = value
        End Set
    End Property

    Public Property Bit As Integer
        Get
            Return _bit
        End Get
        Set(value As Integer)
            _bit = value
        End Set
    End Property

    Public Sub New(new_name As String, new_addr As Integer, new_bit As Integer)
        MyBase.New()
        MyBase.Name = new_name
        MyBase.Address = new_addr
        _bit = new_bit
    End Sub
    Public Overrides Sub SetValue(new_value As Short)
        _data = Conversion.GetBitValue(new_value, _bit)
        '_data = GetBit(new_value, _bit)
    End Sub

End Class

Class WordType
    Inherits VariableData
    Private _data As Short
    Public Sub New(new_name As String, new_addr As Integer)
        MyBase.New()
        MyBase.Name = new_name
        MyBase.Address = new_addr
    End Sub

    Public Overrides Sub SetValue(new_value As Short)
        _data = new_value
    End Sub
End Class

'Class WriteData
'    Public Address As Integer
'    Public Bit As Integer
'    Public Val As Short
'    Public vd As VariableData
'    Public Sub SetAddress(AddressName As Name, VarList As List(Of VariableData))
'        Dim name = AddressName.ToString()
'        '_write_val = Value
'        vd = (From var In VarList Where var.Name = name).ToArray().ElementAt(0)
'        Address = DirectCast(vd, BinaryType).Address
'        Bit = DirectCast(vd, BinaryType).Bit
'        _write_records = (From reads In _read_result Where reads.Address = Address).ToArray()
'        _write_last_word = _write_records(0).Value
'        _write_new_word = Conversion.SetBitValue(_write_last_word, _write_index, Value)
'        _write_word = _write_new_word

'    End Sub
'End Class
