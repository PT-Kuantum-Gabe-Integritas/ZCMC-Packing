Public Class Conversion
    Public Shared Function GetBitValue(word As Short, index As Integer) As Boolean
        Dim my_array = WordToBitArray(word)
        Return my_array(index)
    End Function

    Public Shared Function SetBitValue(word As Short, index As Integer, value As Boolean) As Integer
        Dim result As Integer
        Dim my_array = WordToBitArray(word)
        my_array.Set(index, value)
        result = BitArrayToWord(my_array)
        Return result
    End Function

    Public Shared Function BitArrayToWord(array As BitArray) As Short
        Dim result(1) As Integer
        array.CopyTo(result, 0)
        Return result(0)
    End Function

    Public Shared Function WordToBitArray(word As Short) As BitArray
        Dim array As BitArray = New BitArray(16)
        Dim str = Convert.ToString(word, 2).PadLeft(16, "0")
        Dim bool As Boolean
        For i As Integer = str.Length To 1 Step -1
            If Val(Mid(str, i, 1)) = 1 Then
                bool = True
            Else
                bool = False
            End If
            array.Item(16 - i) = bool
        Next
        Return array
    End Function
End Class
