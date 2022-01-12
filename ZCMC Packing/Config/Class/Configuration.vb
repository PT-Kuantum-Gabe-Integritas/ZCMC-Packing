Public Class Configuration
    Implements IConfiguration
    Private Shared _instance As Configuration

    Private _currConfig As ConfigData = New ConfigData()

    Public Sub New()
    End Sub

    Public Shared Function getInstance() As Configuration
        If _instance Is Nothing Then
            _instance = New Configuration()
        End If
        Return _instance
    End Function

    Public Function Open() As Boolean

        Return True
    End Function

    Public Function Close() As Boolean Implements IConfiguration.Close

        Return True
    End Function

    Private Sub SetValue(param As String, val As String)
        Try
            Dim str_param As String = String.Format("Item='{0}'", param)
            Dim str_val As String = String.Format("Value='{0}'", val)
            'Masukkan ke Database DB (Update)

        Catch ex As Exception

        End Try
    End Sub

    Private Function GetValue(Item As String) As String
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


    Public Sub Save(newConfig As ConfigData) Implements IConfiguration.Save
        With newConfig
            With .DefaultConfig
                SetValue("PLC_IP", .PLC_IP)
                SetValue("PLC_Port", .PLC_PORT)
                SetValue("PrinterName", .PRINTER_NAME)
            End With
        End With
    End Sub


    Public Function Read() As ConfigData
        Try
            With _currConfig
                With .DefaultConfig
                    .PLC_IP = GetValue("PLC_IP")
                    .PLC_PORT = GetValue("PLC_PORT")
                    .PRINTER_NAME = GetValue("PrinterName")
                End With
            End With

        Catch ex As Exception

        End Try

        Return _currConfig
    End Function




End Class
