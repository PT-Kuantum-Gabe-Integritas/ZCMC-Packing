Imports TKX.Lppa
'Imports LabelManager
Imports System.Drawing
Imports CS.Variable

Public Class Codesoft
    Private _app As TKX.Lppa.Application = Nothing
    Private _preview As Image = Nothing
    Private var_doc As Variable
    Private _base_path As String
    Private Shared _instance As Codesoft


    Public ReadOnly Property Preview As Image
        Get
            Return _preview
        End Get
    End Property
    Public Property BasePath As String
        Get
            Return _base_path
        End Get
        Set(value As String)
            _base_path = value
        End Set
    End Property
    Public Sub New()
        _app = New TKX.Lppa.Application()
    End Sub


    Public Shared Function getInstance() As Codesoft
        If _instance Is Nothing Then
            _instance = New Codesoft()
        End If
        Return _instance
    End Function

    Public Structure DOCS
        Public _doc As Document
        Public _id As String
    End Structure

    Public Sub Open(_filename As String, _type As TYPE)
        _filename += ".lab"
        Try
            If _app IsNot Nothing Then
                '"C:\Pokapick Maximo\Pokapick Maximo\Pokapick Maximo\bin\Debug\Label\Individual\Individual (OK).lab"
                Dim type_str As String
                Select Case _type
                    Case TYPE.NP
                        type_str = "Label\Nameplate"
                    Case TYPE.IND
                        type_str = "Label\Individual"
                    Case TYPE.GROUP
                        type_str = "Label\Group"
                    Case Else
                        type_str = "Label\Individual"
                End Select
                Dim str As String = System.IO.Path.Combine("@:", _base_path, type_str, _filename)
                _app.Documents.Open(str, False)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function LoadLabel(name As String, var As String, value As String, rotate As Boolean) As Image
        Dim img As Image = Nothing
        Try
            If _app IsNot Nothing Then
                _app.Documents.Item(name).Activate()
                _app.ActiveDocument.Variables(var).Value = value
                img = _app.ActiveDocument.GetPreview(True, True, 500)
                If rotate Then
                    img.RotateFlip(RotateFlipType.Rotate180FlipNone)
                End If
                Return img
            Else
                Return img
            End If
        Catch ex As Exception
            Return img
        End Try
    End Function

    Public Sub Clear()

    End Sub

    Public Sub PrinterSelect()
        'If _doc IsNot Nothing Then
        '    Try
        '        _app.Dialogs(DialogType.PrinterSelect).Show()
        '        _doc.Save()
        '        _app.Documents.SaveAll()
        '    Catch ex As Exception
        '    End Try
        'End If
    End Sub

    Public Sub PrintDialog()
        'If _doc IsNot Nothing Then
        '    Try
        '        _app.Dialogs(DialogType.Print).Show()
        '        _doc.Save()
        '        _app.Documents.SaveAll()
        '    Catch ex As Exception
        '    End Try
        'End If
    End Sub

    Public Sub Printer(printer As String)
        'If _doc IsNot Nothing Then
        '    Try
        '        _doc.Printer.SwitchTo(printer)
        '    Catch ex As Exception
        '    End Try
        'End If
    End Sub

    'Public Sub Print(printer As String)
    '    '_doc.PrintDocument(1)
    'End Sub

    Public Sub Print(name As String, qty As Integer, printer As String)
        _app.Documents.Item(name).Activate()
        _app.ActiveDocument.Printer.SwitchTo(printer)
        _app.ActiveDocument.PrintDocument(qty)
    End Sub

    Public Sub SetMargin(horz As Double, vert As Double)
        'If _doc IsNot Nothing Then
        '    Try
        '        _doc.HorzPrintOffset = horz
        '        _doc.VertPrintOffset = vert

        '    Catch ex As Exception
        '    End Try
        'End If
    End Sub

    Public Sub Close()
        Try
            _app.Documents.CloseAll()
            _app.Quit()
            _app.Dispose()
        Catch ex As Exception

        End Try
    End Sub
End Class
