Imports EasyModbus
Imports System.Threading
Imports System.Collections
Imports MB.Variable

Public Class Modbus
    Public Structure WRITE_DATA
        Public Name As String
        Public Address As Integer
        Public Bit As Integer
        Public Val As Short
        Public LastVal As Short

        Public Sub Reset()
            Address = 0
            Bit = 0
            Val = 0
            LastVal = 0
        End Sub
    End Structure

    'Public vd As VariableData
    'Public Sub SetAddress(AddressName As Name, VarList As List(Of VariableData))
    '    Dim name = AddressName.ToString()
    '    '_write_val = Value
    '    vd = (From var In VarList Where var.Name = name).ToArray().ElementAt(0)
    '    Address = DirectCast(vd, BinaryType).Address
    '    Bit = DirectCast(vd, BinaryType).Bit
    '    _write_records = (From reads In _read_result Where reads.Address = Address).ToArray()
    '    _write_last_word = _write_records(0).Value
    '    _write_new_word = Conversion.SetBitValue(_write_last_word, _write_index, Value)
    '    _write_word = _write_new_word

    'End Sub

    Public Property IPAddress As String
        Get
            IPAddress = _ipaddress
        End Get
        Set(value As String)
            _ipaddress = IPAddress
        End Set
    End Property

    Public ReadOnly Property Stats As Status
        Get
            Return _status
        End Get
    End Property

    'Public WriteOnly Property WriteData As WRITE_DATA
    '    Set(value As WRITE_DATA)
    '        _wd = value
    '    End Set
    'End Property


    Private _th_read As Thread
    Private _ts_read As ThreadStart
    Private _th_write As Thread
    Private _ts_write As ThreadStart
    Public Counter As Integer

    Dim device As ModbusClient

    Private _ipaddress As String
    Private Const _port As Integer = 502

    Private _write_mem As Boolean
    Private _write_name As String
    Private _write_val As Boolean
    Private _write_addr As Integer
    Private _write_index As Integer

    Private _write_id As String
    Private _write_word As Short
    Private _write_exe As Boolean

    Private _write_records(1) As ReadingResult
    Private _write_last_word As Short
    Private _write_new_word As Short
    Private _write_var(1) As VariableData

    Private _read_result As List(Of ReadingResult) = New List(Of ReadingResult)()
    Private _read_val As Short
    Private _read_addr As Integer

    Private _var_list As List(Of VariableData) = New List(Of VariableData)()

    Private _status As Variable.Status = Status.Disconnected

    Private _exit As Boolean = False

    Private _que As Queue(Of WRITE_DATA) = New Queue(Of WRITE_DATA)()

    Private wd As WRITE_DATA = New WRITE_DATA()
    Private name As String
    Private vd As VariableData = New VariableData()

    Private _mem_array() As Memories = {
        New Memories(Variable.Name.I_poka1, 100, 0, True),
        New Memories(Variable.Name.I_poka2, 100, 1, True),
        New Memories(Variable.Name.I_poka3, 100, 2, True),
        New Memories(Variable.Name.I_poka4, 100, 3, True),
        New Memories(Variable.Name.I_np_print, 101, 0, True),
        New Memories(Variable.Name.I_np_out, 101, 1, True),
        New Memories(Variable.Name.I_ind_print, 102, 0, True),
        New Memories(Variable.Name.I_ind_out, 102, 1, True),
        New Memories(Variable.Name.Q_Ind_Trig, 120, 0, False),
        New Memories(Variable.Name.Q_np, 130, 0, False),
        New Memories(Variable.Name.Q_poka, 110, 0, False)
    }


    Public Sub New()
        _ts_read = New ThreadStart(AddressOf ReadLoop)
        _th_read = New Thread(_ts_read)
        _th_read.IsBackground = False

        _ts_write = New ThreadStart(AddressOf WriteLoop)
        _th_write = New Thread(_ts_write)
        _th_write.IsBackground = False
        device = New ModbusClient("127.0.0.1", _port)
    End Sub

    Public Sub New(IPAddress As String)
        _ipaddress = IPAddress
        _ts_read = New ThreadStart(AddressOf ReadLoop)
        _th_read = New Thread(_ts_read)
        _th_read.IsBackground = False

        _ts_write = New ThreadStart(AddressOf WriteLoop)
        _th_write = New Thread(_ts_write)
        _th_write.IsBackground = False
        device = New ModbusClient(_ipaddress, _port)
    End Sub

    Public Function Start() As Boolean
        If Connect() Then
            If _th_read.ThreadState <> ThreadState.Running Then
                _th_read.Start()
                _th_write.Start()
            Else
                _th_read.Abort()
                _th_write.Abort()
                Thread.Sleep(10)
                _th_read.Start()
                _th_write.Start()
            End If
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub Dispose()
        _exit = True

        Disconnect()

        If _th_read.ThreadState = ThreadState.Running Then
            _th_read.Abort()
        End If

        If _th_write.ThreadState = ThreadState.Running Then
            _th_write.Abort()
        End If

        _status = Status.Disconnected
    End Sub
    Public Function ReadBit(AddressName As Name) As Boolean
        Dim result = From var In _var_list Where var.Name = AddressName.ToString()
        Dim value = DirectCast(result(0), BinaryType).Data
        Return value
    End Function

    Public Sub Write(AddressName As Name, Value As Short)
        wd.Reset()
        wd.Name = AddressName.ToString()
        Dim all = (From var In _var_list Where var.Name = wd.Name Select var.Address).ToArray()

        If all.Length > 0 Then
            'wd.Address = (From var In _var_list Where var.Name = wd.Name).ToArray().ElementAt(0).Address
            'wd.Address = DirectCast(vd, WordType).Address
            wd.Address = all(0)
            wd.Val = Value
            _que.Enqueue(wd)

        End If
    End Sub

    Public Sub Write(AddressName As Name, Value As Boolean)
        name = AddressName.ToString()
        vd = (From var In _var_list Where var.Name = name).ToArray().ElementAt(0)
        wd.Address = DirectCast(vd, BinaryType).Address
        wd.Bit = DirectCast(vd, BinaryType).Bit
        wd.LastVal = (From reads In _read_result Where reads.Address = wd.Address).ToArray().ElementAt(0).Value
        wd.Val = Conversion.SetBitValue(wd.LastVal, wd.Bit, Value)
        _que.Enqueue(wd)
    End Sub
    Private Sub ReadLoop()
        Dim err As Boolean
        Dim err_msg As String = String.Empty
        Dim item As WRITE_DATA

        For i As Integer = 0 To _mem_array.Length - 1
            Dim temp_name = _mem_array(i).AddrName.ToString()
            If _mem_array(i).IsBinary Then
                'Add variable from bank to list
                _var_list.Add(New BinaryType(temp_name, _mem_array(i).Address, _mem_array(i).Bit))
            ElseIf Not _mem_array(i).IsBinary Then
                'Add variable from bank to list
                _var_list.Add(New WordType(temp_name, _mem_array(i).Address))
            End If
            '_read_result.Add(New ReadingResult With {.Address = 0, .Value = 0})
        Next

        'Get All Address To Read From Modbus
        Dim _addr_list = GetAddressList()
        'Dim cnt As Integer
        While Not _exit
            Try
                If _status = Status.Connected Then

                    'If cnt > _addr_list.Count Then
                    '    cnt = 0
                    '    _read_result.Clear()
                    'End If

                    If _que.Count > 0 Then
                        item = _que.Dequeue()
                        WriteMemoryWord(item.Address, item.Val, err, err_msg)
                    Else
                        _read_result.Clear()
                        For i As Integer = 0 To _addr_list.Count - 1
                            _read_addr = _addr_list(i)
                            _read_val = ReadMemoryWord(_read_addr, err, err_msg)
                            _read_result.Add(New ReadingResult With {.Address = _read_addr, .Value = _read_val})
                            'cnt += 1
                        Next
                        UpdateValue(_read_result)

                    End If

                    '_read_result()
                    '_read_result.Clear()
                    'Reading Section
                    'For i As Integer = 0 To _addr_list.Count - 1
                    'Set address to the list
                    '_read_addr = _addr_list(i)
                    'Read Value of the current address
                    '_read_val = ReadMemoryWord(_read_addr, err, err_msg)

                    'Set Value to the list
                    '_read_result.Add(New ReadingResult With {.Address = _read_addr, .Value = _read_val})
                    'Next
                    'UpdateValue(_read_result)

                    'Write Section
                    'If _que.Count > 0 Then
                    '    item = _que.Dequeue()
                    '    WriteMemoryWord(item.Address, item.Val, err, err_msg)
                    'End If
                    Thread.Sleep(10)

                End If

            Catch ex As Exception

            End Try
        End While
    End Sub

    Private Sub WriteLoop()
        'Dim err As Boolean
        Dim err_msg As String = String.Empty
        'Dim item As WRITE_DATA

        While Not _exit
            Try
                'If _status = Status.Connected Then
                '    'Write Section
                '    If _que.Count > 0 Then
                '        item = _que.Dequeue()
                '        WriteMemoryWord(item.Address, item.Val, err, err_msg)
                '    End If

                '    'If _write_exe Then
                '    '    _write_var = (From var In _var_list Where var.Name = _write_id).ToArray()
                '    '    _write_addr = DirectCast(_write_var(0), WordType).Address
                '    '    WriteMemoryWord(_write_addr, _write_word, err, err_msg)
                '    '    _write_exe = False
                '    'End If
                '    Thread.Sleep(1)

                'End If

            Catch ex As Exception

            End Try
        End While
    End Sub
    Private Function GetAddressList() As List(Of Integer)
        Dim addr_list As List(Of Integer) = New List(Of Integer)()
        For i As Integer = 0 To _var_list.Count - 1
            addr_list.Add(_var_list(i).Address)
        Next
        Dim result As List(Of Integer) = addr_list.Distinct().ToList
        Return result
    End Function
    Private Sub UpdateValue(reading_result As List(Of ReadingResult))
        For i As Integer = 0 To _var_list.Count - 1
            Dim curr_addr As Integer = _var_list(i).Address
            Dim result = (From reads In reading_result Where reads.Address = curr_addr).ToArray()
            _var_list(i).SetValue(result(0).Value)
        Next
    End Sub
    Private Function Connect() As Boolean
        Dim msg As String

        If device IsNot Nothing Then
            If device.Connected Then device.Disconnect()
        End If

        Try
            device.Connect()
            msg = String.Format("Modbus Connected to {0} port= {1}", device.IPAddress, device.Port)
            _status = Status.Connected
            Return True
        Catch ex As Exception
            msg = String.Format("Error! Can't connect to {0} port= {1}." & vbCrLf & "{2}", device.IPAddress, device.Port, ex.Message)
            _status = Status.Disconnected
            Return False
        End Try
    End Function
    Private Sub Disconnect()
        If device.Connected Then
            device.Disconnect()
        End If
    End Sub

    Private Function ReadMemoryWord(addr As Integer, ByRef err As Boolean, ByRef err_msg As String) As Int16
        Dim result(1) As Integer
        If device.Connected Then
            Try
                result = device.ReadHoldingRegisters(addr, 1)
            Catch ex As Exception
                err = True
                err_msg = String.Format("error read register from {0}" & vbCrLf & ex.Message, addr)
            End Try
        End If
        Return result(0)
    End Function

    Private Sub WriteMemoryWord(addr As Integer, val As Short, ByRef err As Boolean, ByRef err_msg As String)
        Dim result(1) As Integer
        If device.Connected Then
            Try
                device.WriteSingleRegister(addr, val)
            Catch ex As Exception
                err = True
                err_msg = String.Format("error write value={0} to register={1}" & vbCrLf & ex.Message, val, addr)
            End Try
        End If
    End Sub



    Public Sub TrialSub()
        Dim test = Conversion.WordToBitArray(10)
    End Sub

    'Public Sub Write(AddressName As Name, Value As Boolean)
    '_write_name = AddressName.ToString()
    ''_write_val = Value
    '_write_var = (From var In _var_list Where var.Name = _write_name).ToArray()
    '_write_addr = DirectCast(_write_var(0), BinaryType).Address
    '_write_index = DirectCast(_write_var(0), BinaryType).Bit
    '_write_records = (From reads In _read_result Where reads.Address = _write_addr).ToArray()
    '_write_last_word = _write_records(0).Value
    '_write_new_word = Conversion.SetBitValue(_write_last_word, _write_index, Value)
    '_write_word = _write_new_word
    '_write_mem = True
    'Dim name = AddressName.ToString()
    'Dim vd = (From var In _var_list Where var.Name = name).ToArray().ElementAt(0)
    '_wd.Address = DirectCast(vd, BinaryType).Address
    '_wd.Bit = DirectCast(vd, BinaryType).Bit
    'Dim last_val = (From reads In _read_result Where reads.Address = _wd.Address).ToArray().ElementAt(0).Value
    '_wd.Val = Conversion.SetBitValue(last_val, _wd.Bit, Value)
    '_wd.Exec = True
    'End Sub

    'Public Sub Write(AddressName As Name, value As Short)
    '    '_write_id = AddressName.ToString()
    '    '_write_word = value

    '    '_write_exe = True
    '    Dim name = AddressName.ToString()
    '    Dim vd = (From var In _var_list Where var.Name = name).ToArray().ElementAt(0)
    '    _wd.Address = DirectCast(vd, WordType).Address
    '    _wd.Val = value
    '    '_wd.Exec = True
    'End Sub
End Class
