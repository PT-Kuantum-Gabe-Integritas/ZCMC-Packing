Imports MB
Imports MB.Variable
Imports CS
Imports CS.Variable
Imports System.Threading
Imports Database
Public Class Production
    Implements IProduction

    Public Structure STATION
        Public Print As Boolean
        Public PrintFlag As Boolean
        Public Out As Boolean
        Public OutFlag As Boolean
        Public Qty As Integer
        Public Img As Image
        Public Run As Boolean
        Public Complete As Boolean
        Public Enable As Short
        Public Total As Integer
        Public Stp As Integer
        Public Sub Reset()
            Print = False
            PrintFlag = False
            Out = False
            OutFlag = False
            Run = False
            Complete = False
            Qty = 0
            Total = 0
            Stp = 0
            Img = Nothing
            Enable = 0
        End Sub
    End Structure

    Public Structure ORDER
        Public RefTicket As String
        Public PO As String
        Public Qty As Integer
        Public Run As Boolean
        Public Bitmap As String

        Public Sub Reset()
            RefTicket = ""
            PO = ""
            Qty = 0
            Run = False
        End Sub
    End Structure


    Private Shared _instance As Production
    Private _Initialization As Initialization = Initialization.getInstance()
    Private _modbus As Modbus
    Private _label As Codesoft
    Private _ui As UserInterface = UserInterface.getInstance()
    Public database As DBManager = DBManager.getInstance()
    Private _config As Configuration
    Public dbProduction As SQLite = New SQLite()
    Public Shared th As Thread
    Public Shared ts As ThreadStart
    Public Shared wo As ORDER
    Public Shared ind As STATION = New STATION()
    Public Shared group As STATION = New STATION()
    Public Shared _exit As Boolean = False
    'Public Shared pack As STATION = New STATION()

    Public fn_ind As String
    Public fn_group As String
    Public printer_ind As String
    Public printer_group As String




    Public Sub New()

    End Sub

    Public Shared Function getInstance() As Production
        If _instance Is Nothing Then
            _instance = New Production()
        End If
        Return _instance
    End Function

    Public Enum COL
        IND
        GROUP
        USER
        DATEOUT
        COMPLETE
        PO
    End Enum

    Private Function ColString(_col As IProduction.COL) As String Implements IProduction.ColString
        Select Case _col
            Case COL.IND
                Return "qty_ind"
            Case COL.GROUP
                Return "qty_group"
            Case COL.COMPLETE
                Return "status"
            Case COL.DATEOUT
                Return "date_out"
            Case COL.PO
                Return "po_number"
            Case Else
                Return "status"
        End Select
    End Function

    Public Function Starts() As Boolean Implements IProduction.Starts
        Dim result As Boolean

        'Starting Initialization
        _Initialization.Start()

        Open()
        _ui.LoadPanel(UserInterface.TAB.LOGIN)
        If _modbus.Stats = Status.Connected Then
            ts = New ThreadStart(AddressOf Looping)
            th = New Thread(ts)
            th.IsBackground = False
            th.Start()

            'OPENING LABEL
            '_label = New Codesoft()
            '_label.BasePath = Application.StartupPath
            '_label.Open(fn_ind, TYPE.IND)
            '_label.Open(fn_group, TYPE.GROUP)



            ind.Enable = 0
            group.Enable = 0

            _modbus.Write(Name.Q_Ind_Trig, ind.Enable)
            _modbus.Write(Name.Q_Group, group.Enable)


            result = True
        Else
            result = False
        End If
        Return result
    End Function

    Public Sub Stops() Implements IProduction.Stops
        _exit = True
        Try
            th.Abort()
        Catch ex As Exception

        End Try



    End Sub

    Public Sub Looping() Implements IProduction.Looping
        While Not _exit


            'INDIVIDUAL RUNNING
            If ind.Run Then
                ind.Print = _modbus.ReadBit(Name.I_ind_print)
                'ind.Out = _modbus.ReadBit(Name.I_ind_out)

                If ind.Print And Not ind.PrintFlag Then
                    'Label.print("fn_ind",1,printer_np)
                    ind.Qty += 1
                    ind.PrintFlag = True
                    Update(COL.IND, ind.Qty, wo.PO, wo.RefTicket)
                    UserInterface._frmHome.UpdateUI(frmHome.CONTROL.IND_QTY, ind.Qty.ToString())
                End If
                If Not ind.Print And ind.PrintFlag Then
                    ind.PrintFlag = False
                End If



                If ind.Qty < wo.Qty Then
                    ind.Enable = 1
                Else
                    ind.Enable = 0
                    ind.Complete = True
                End If



            End If

            'GROUP RUNNING
            group.Total = 10
            If group.Run Then
                If ind.Qty Mod group.Total <> 0 And ind.Qty >= wo.Qty Then
                    Dim result As DialogResult = MessageBox.Show("Order Finish", "Order was Finish ", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        'label.print(fn_group,1,printer_group)
                        group.Complete = True
                        group.Qty += 1
                        Update(COL.GROUP, group.Qty, wo.PO, wo.RefTicket)
                        Update(COL.DATEOUT, String.Format("{0:0000}-{1:00}-{2:00} {3:00}:{4:00}:{5:00}",
                                                                        Date.Now.Year, Date.Now.Month, Date.Now.Day, Date.Now.Hour, Date.Now.Minute, Date.Now.Second), wo.PO, wo.RefTicket)
                        Update(COL.COMPLETE, "2", wo.PO, wo.RefTicket)
                        'RESET ALL
                        _exit = True
                        Stops()
                        Reset()
                    End If
                End If

                If ind.Qty Mod group.Total = 0 And group.PrintFlag = False And ind.Qty > 0 Then
                    'label.print(fn_group,1,printer_group)
                    group.Qty += 1
                    Update(COL.GROUP, group.Qty, wo.PO, wo.RefTicket)
                    UserInterface._frmHome.UpdateUI(frmHome.CONTROL.GROUP_QTY, group.Qty.ToString())
                    group.PrintFlag = True
                End If

                If ind.Qty Mod group.Total <> 0 And group.PrintFlag = True Then
                    group.PrintFlag = False
                End If
            End If

            'CHECK QTY
            If ind.Qty >= wo.Qty Then
                ind.Complete = True
            End If



            'IF ALL COMPLETE
            If ind.Complete And group.Complete Then
                Update(COL.DATEOUT, String.Format("{0:0000}-{1:00}-{2:00} {3:00}:{4:00}:{5:00}",
                                                                    Date.Now.Year, Date.Now.Month, Date.Now.Day, Date.Now.Hour, Date.Now.Minute, Date.Now.Second), wo.PO, wo.RefTicket)
                Update(COL.COMPLETE, "1", wo.PO, wo.RefTicket)
                _exit = True
                Stops()
                Reset()

            End If
            Thread.Sleep(100)

        End While

    End Sub

    Public Function Update(setCOL As IProduction.COL, val As String, po As String, reff As String) As Boolean Implements IProduction.Update
        Try
            Dim str_col As String = ColString(setCOL)
            Dim str_update As String = String.Format("{0}='{1}'", str_col, val)
            Dim str_where As String = String.Format("po_number='{0}' AND reference='{1}'", po, reff)
            dbProduction.DBUpdate("PRODUCT", str_update, str_where)
            Return True
        Catch ex As Exception
            MsgBox(String.Format("Update po:{0} with value:{1} is Failed", po, val) & vbNewLine & ex.Message)
            Return False
        End Try

    End Function

    Public Sub SetOrder(po As String, reff As String, qty As String, qty_ind As String, qty_group As String) Implements IProduction.SetOrder

        If po = String.Empty Or reff = String.Empty Or qty = String.Empty Then
            MsgBox("Please Fill All Data")
            Return
        End If

        wo.PO = po
        wo.RefTicket = reff
        wo.Qty = Integer.Parse(qty)
        ind.Qty = Integer.Parse(qty_ind)
        group.Qty = Integer.Parse(qty_group)

        UserInterface._frmHome.UpdateUI(frmHome.CONTROL.REFF, wo.RefTicket)
        UserInterface._frmHome.UpdateUI(frmHome.CONTROL.PO, wo.PO)
        UserInterface._frmHome.UpdateUI(frmHome.CONTROL.TOTAL_QTY, wo.Qty)

        'LOAD LABEL IMAGE
        'ind.Img = _label.LoadLabel(fn_ind, "Bitmap", wo.Bitmap, False)
        'group.Img = _label.LoadLabel(fn_group, "Bitmap", wo.Bitmap, False)
        'pack.Img = Image.FromFile(IO.Path.Combine(fn_pack, wo.RefTicket & ".PNG"))
        'LOAD LABEL IMAGE


        UserInterface._frmHome.UpdateUI(frmHome.CONTROL.IND_QTY, ind.Qty)
        UserInterface._frmHome.UpdateUI(frmHome.CONTROL.GROUP_QTY, group.Qty)
        UserInterface._frmHome.UpdateUI(frmHome.CONTROL.IND_IMG, ind.Img)
        UserInterface._frmHome.UpdateUI(frmHome.CONTROL.GROUP_IMG, group.Img)
        'UserInterface._frmHome.UpdateUI(frmHome.CONTROL.PRODUCT_IMG, pack.Img)



        If ind.Qty < wo.Qty Then
            ind.Enable = 1

            ind.Run = True
            group.Run = True
            _ui.LoadPanel(UserInterface.TAB.DASHBOARD)
        Else
            ind.Enable = 0
            ind.Complete = True
        End If



    End Sub


    Public Function CheckTicket(po As String, reff As String) As Boolean Implements IProduction.CheckTicket
        Dim status As Boolean
        Dim dt As DataTable = New DataTable
        Dim str As String = String.Format("po_number='{0}' AND reference='{1}'", po, reff)
        Try
            dt = dbProduction.DBSelect("*", "PRODUCT", str)

            If dt.Rows.Count > 0 Then
                status = True
            Else
                status = False
            End If

        Catch ex As Exception
            MsgBox(String.Format("Check Reference PO:{0} and Ref:{1} is Fail", po, reff))
            status = False
            Return status
        End Try
        Return status

    End Function

    Public Function GetPOInfo(po As String, reff As String) As DataTable Implements IProduction.GetPOInfo
        Dim dt As DataTable = New DataTable()
        Dim str_param As String = "qty_po,qty_ind,qty_group,status"
        Dim str_where As String = String.Format("po_number='{0}' AND reference='{1}'", po, reff)
        Try
            dt = dbProduction.DBSelect(str_param, "PRODUCT", str_where)
            Return dt
        Catch ex As Exception
            MsgBox(String.Format("Get Data Failed") & vbNewLine & ex.Message)
            Return dt
        End Try
        Return dt
    End Function

    Public Function Insert(po As String, reff As String, qty_po As String, user As String) As Boolean Implements IProduction.Insert
        Try
            Dim str_param As String = String.Format("(po_number, reference, qty_po, qty_ind, qty_group, status, user, date_in)")
            Dim str_val As String = String.Format("('{0}','{1}','{2}','0','0','0','{3}', datetime('now','localtime'))", po, reff, qty_po, user)
            dbProduction.DBInsert("PRODUCT", str_param, str_val)
            Return True
        Catch ex As Exception
            MsgBox(String.Format("Insert PO:{0} with Ref:{1} is Failed", po, reff) & vbNewLine & ex.Message)
            Return False
        End Try
    End Function


    Public Function Open() As Boolean Implements IProduction.Open
        Dim prodStat As Boolean

        If Not dbProduction.isConnected Then
            dbProduction = database.GetDataBase("Production.db", "P01", "-SQLite", "Order")
            _config = Configuration.getInstance()
            _modbus = Modbus.getInstance()
            prodStat = True
        End If


        Return prodStat
    End Function


    Public Sub Reset() Implements IProduction.Reset
        Dim emptyImage As Image = Nothing
        ind.Reset()
        group.Reset()
        wo.Reset()

        UserInterface._frmHome.UpdateUI(frmHome.CONTROL.IND_QTY, ind.Qty)
        UserInterface._frmHome.UpdateUI(frmHome.CONTROL.IND_IMG, ind.Img)
        UserInterface._frmHome.UpdateUI(frmHome.CONTROL.GROUP_QTY, group.Qty)
        UserInterface._frmHome.UpdateUI(frmHome.CONTROL.GROUP_IMG, group.Img)
        UserInterface._frmHome.UpdateUI(frmHome.CONTROL.REFF, wo.RefTicket)
        UserInterface._frmHome.UpdateUI(frmHome.CONTROL.PO, wo.PO)
        UserInterface._frmHome.UpdateUI(frmHome.CONTROL.TOTAL_QTY, wo.Qty.ToString())
        UserInterface._frmHome.UpdateUI(frmHome.CONTROL.PO, wo.PO)
        UserInterface._frmHome.UpdateUI(frmHome.CONTROL.REFF, wo.RefTicket)
        UserInterface._frmRun.Initial()
        '_ui.LoadPanel(UserInterface.TAB.RUN)

        _modbus.Write(Name.Q_Ind_Trig, ind.Enable)
        _modbus.Write(Name.Q_Group, group.Enable)

    End Sub


    Public Sub CloseALL()
        _modbus.Dispose()
        _config.Close()
        Stops()

    End Sub


End Class
