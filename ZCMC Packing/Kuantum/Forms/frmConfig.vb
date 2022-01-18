Public Class frmConfig

    Private _config As Configuration
    Private _conData As ConfigData = New ConfigData

    Public Enum config
        PLC_IP
        PLC_PORT
        IND_PRINT
        IND_NAME
        GROUP_PRINT
        GROUP_NAME
    End Enum


    Public Sub UpdateUI(ctrl As config, str As String)
        If InvokeRequired Then
            Invoke(Sub() UpdateUI(ctrl, str))
            Return
        End If

        Select Case ctrl
            Case config.PLC_IP
                txtPLCIP.Text = str
            Case config.PLC_PORT
                txtPLCPort.Text = str
            Case config.IND_PRINT
                txtIndPrint.Text = str
            Case config.IND_NAME
                txtIndName.Text = str
            Case config.GROUP_NAME
                txtGroupName.Text = str
            Case config.GROUP_PRINT
                txtGroupPrint.Text = str
        End Select
    End Sub

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _config = Configuration.getInstance()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            _conData.PLC_IP = txtPLCIP.Text
            _conData.PLC_PORT = txtPLCPort.Text
            _conData.IND_PRINTER = txtIndPrint.Text
            _conData.INDIVIDUAL_NAME = txtIndName.Text
            _conData.GROUP_NAME = txtGroupName.Text
            _conData.GROUP_PRINTER = txtGroupPrint.Text

            _config.Save(_conData)


        Catch ex As Exception

        End Try
    End Sub

    'Public Sub Load()
    '    UpdateUI()
    'End Sub


End Class