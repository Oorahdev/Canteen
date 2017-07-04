Public Class AccountHistory
    Dim intInstanceId As Integer
    Dim intActID As Integer
    Friend Shared returnOrsID As Integer = 0
    Friend Shared returnItmID As Integer = 0
    Friend Shared returnItmPrice As Decimal = 0D
    Friend Shared returnItmName As String = ""
    Friend Shared returnReimburse As String = ""

    Friend Sub loadbyactid(ByVal actid As Integer, ByVal instanceID As Integer)
        intActID = actid
        intInstanceID = instanceID
    End Sub


    Private Sub AccountHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsCanteen.tTRN' table. You can move, or remove it, as needed.
        Me.TTRNTableAdapter.Fill(Me.DsCanteen.tTRN)
        If intActID > 0 Then
            'ClearOrders()
            Load_Account(intActID)
            'lblActName.Text = Me.DsCanteen.tACT.Item("ACT_Name").ToString()
            'lblBal.Text = FormatCurrency(Me.DsCanteen.tACT.Item("ACT_Balance"))
            'intActID = intActID
            'TACTTableAdapter1.FillBy(Me.DsCanteen.tACT, intActID)
            'If Not DsCanteen.tACT.Item(0).IsACT_SpendingLimitNull And DsCanteen.tACT.Item(0).IsACT_StartDateNull Then
            '    ' If Not IsNothing(DsCanteen1.tACT.Item(0).ACT_SpendingLimit) And IsNothing(DsCanteen1.tACT.Item(0).ACT_StartDate) Then
            '    TACTTableAdapter1.ACT_AmountLeftToSpendUpdate(intActID, DsCanteen.tACT.Item(0).ACT_StartDate, DsCanteen.tACT.Item(0).ACT_SpendingLimit, DsCanteen.tACT.Item(0).ACT_LastUpdateAmount)
            'End If
        End If
    End Sub

    Private Sub Load_Account(ByVal intActId As Integer)
        Me.ActDisplayTableAdapter1.FillACT(Me.DsCanteen.ActDisplay, intActId)
    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Select Case lsbActHistory.SelectedItem.GetType.ToString
            'Case Is = GetType(OrderHeader).ToString
            Case Is = GetType(OrderItem).ToString
                If (CType(Me.lsbActHistory.SelectedItem, OrderItem).OrsReturnID) Is Nothing And (CType(Me.lsbActHistory.SelectedItem, OrderItem).ItemReturned) Is Nothing Then
                    Dim orders As Orders = orders.FromHandle(intInstanceId)
                    If orders.ItemReturned(CType(Me.lsbActHistory.SelectedItem, OrderItem).OrsID) = False Then
                        returnOrsID = CType(Me.lsbActHistory.SelectedItem, OrderItem).OrsID
                        returnItmID = CType(Me.lsbActHistory.SelectedItem, OrderItem).ItemID
                        returnItmPrice = CType(Me.lsbActHistory.SelectedItem, OrderItem).ItemPrice
                        returnItmName = CType(Me.lsbActHistory.SelectedItem, OrderItem).ItemName
                        returnReimburse = "Return"
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        'Case Is = GetType(OrderHeader).ToString
                        'Case Is = GetType(OrderHeader).ToString
                    End If
                End If
        End Select
    End Sub

    Private Sub btnReimburse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReimburse.Click
        If lsbActHistory.SelectedIndex >= 0 Then
            Select Case lsbActHistory.SelectedItem.GetType.ToString
                'Case Is = GetType(OrderHeader).ToString
                Case Is = GetType(OrderItem).ToString
                    If (CType(Me.lsbActHistory.SelectedItem, OrderItem).OrsReturnID) Is Nothing And (CType(Me.lsbActHistory.SelectedItem, OrderItem).ItemReturned) Is Nothing Then
                        If Orders.ItemReturned(CType(Me.lsbActHistory.SelectedItem, OrderItem).OrsID) = False Then
                            returnOrsID = CType(Me.lsbActHistory.SelectedItem, OrderItem).OrsID
                            returnItmID = CType(Me.lsbActHistory.SelectedItem, OrderItem).ItemID
                            returnItmPrice = CType(Me.lsbActHistory.SelectedItem, OrderItem).ItemPrice
                            returnItmName = CType(Me.lsbActHistory.SelectedItem, OrderItem).ItemName
                            returnReimburse = "Reimburse"
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                            'Case Is = GetType(OrderHeader).ToString
                            'Case Is = GetType(OrderHeader).ToString
                        End If
                    End If
            End Select
        End If
    End Sub

    'Private Sub EnableButtons()
    '    btnReimburse.Enabled = True
    '    btnReturn.Enabled = True
    '    btnAllTrn.Enabled = True
    '    btnLastTrn.Enabled = True

    'End Sub

    Private Sub btnAllTrn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllTrn.Click
        If MsgBox("This will print ALL orders for this account. Are you sure you would like to proceed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            PrintrptAccountHistory()
        End If

    End Sub
    'Dim allOrdersId As Integer = Me.TORDTableAdapter1.FillByAllOrd(DsCanteen.tORD, actId)
    Private Sub PrintrptAccountHistory()
        Me.TPRFTableAdapter1.FillByPrfName(Me.DsCanteen.tPRF, "Reprint Printer")
        If Not DsCanteen.tPRF.Item(0).IsPRF_ValueNull Then
            rptAccountHistory.DataSource.ConnectionString = UpdateShelves.GetOledbConnectionString()
            rptAccountHistory.DataSource.RecordSource = ""
            rptAccountHistory.DataSource.RecordSource = "SELECT * FROM SingleReceipt"
            rptAccountHistory.DataSource.RecordSource += " WHERE ACT_ID = " & intActID
            rptAccountHistory.Document.PrinterSettings.PrinterName = DsCanteen.tPRF.Item(0).PRF_Value
            rptAccountHistory.Document.Print()
        End If
    End Sub

    Private Sub btnLastTrn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLastTrn.Click
        PrintrptLastTrans()
    End Sub
    Dim lastOrderId As Integer

    Private Sub PrintrptLastTrans()
        Me.TPRFTableAdapter1.FillByPrfName(Me.DsCanteen.tPRF, "Reprint Printer")
        If Not DsCanteen.tPRF.Item(0).IsPRF_ValueNull Then
            Me.TORDTableAdapter1.FillByLastOrd(Me.DsCanteen.tORD, intActID)
            lastOrderId = Me.DsCanteen.tORD.Item(0).Item("MaxOrder")
            rptLastTrans.DataSource.ConnectionString = UpdateShelves.GetOledbConnectionString()
            rptLastTrans.DataSource.RecordSource = ""
            rptLastTrans.DataSource.RecordSource = "SELECT * FROM SingleReceipt"
            rptLastTrans.DataSource.RecordSource += " WHERE TRN_ORD_ID = " & lastOrderId
            rptLastTrans.Document.PrinterSettings.PrinterName = DsCanteen.tPRF.Item(0).PRF_Value
            rptLastTrans.Document.Print()
        End If
    End Sub

    Private Sub PrintrptSelectTrans()
        Me.TPRFTableAdapter1.FillByPrfName(Me.DsCanteen.tPRF, "Reprint Printer")
        If Not DsCanteen.tPRF.Item(0).IsPRF_ValueNull Then
            If lsbActHistory.SelectedItem.GetType() Is GetType(BlankLine) Then
                Exit Sub
            Else
                Me.TORDTableAdapter1.FillByOrdID(Me.DsCanteen.tORD, lsbActHistory.SelectedItem.Order.OrderId)
                Dim selectedOrderId As Integer
                selectedOrderId = Me.DsCanteen.tORD.Item(0).ORD_ID
                rptLastTrans.DataSource.ConnectionString = UpdateShelves.GetOledbConnectionString()
                rptLastTrans.DataSource.RecordSource = ""
                rptLastTrans.DataSource.RecordSource = "SELECT * FROM SingleReceipt"
                rptLastTrans.DataSource.RecordSource += " WHERE TRN_ORD_ID = " & selectedOrderId
                rptLastTrans.Document.PrinterSettings.PrinterName = DsCanteen.tPRF.Item(0).PRF_Value
                rptLastTrans.Document.Print()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Dim unsavedChanges As Boolean = False

    Private Sub Items_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If unsavedChanges = True Then
            Dim dialogResult As DialogResult = MsgBox("This will clear all your changes! Are you sure you would like to continue?", MsgBoxStyle.YesNo)
            If dialogResult = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else : unsavedChanges = False
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        End If
    End Sub

    'Private Sub btnChooseAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Dim frmChooseACT As New ChooseACT2
    'intActID = frmChooseACT.SelectAct
    '    If intActID > 0 Then
    '        ClearOrders()
    '        Load_Account(intActID)
    '        intActID = intActID
    '        EnableButtons()
    '        TACTTableAdapter1.FillBy(Me.DsCanteen.tACT, intActID)
    '        If Not DsCanteen.tACT.Item(0).IsACT_SpendingLimitNull And DsCanteen.tACT.Item(0).IsACT_StartDateNull Then
    '' If Not IsNothing(DsCanteen1.tACT.Item(0).ACT_SpendingLimit) And IsNothing(DsCanteen1.tACT.Item(0).ACT_StartDate) Then
    '            TACTTableAdapter1.ACT_AmountLeftToSpendUpdate(intActID, DsCanteen.tACT.Item(0).ACT_StartDate, DsCanteen.tACT.Item(0).ACT_SpendingLimit, DsCanteen.tACT.Item(0).ACT_LastUpdateAmount)
    '        End If
    '    End If
    'End Sub

    'Private Sub ClearOrders()
    '    lsbActHistory.Items.Clear()
    'End Sub



    Private Class Order
        Public OrderId As Integer = 0
        Public OrderDate As Date = Now
        Public OrderTotal As Decimal = 0D
        Public OrderPrizeTotal As Decimal = 0D
        Public OrderUser As Int16 = 0
    End Class

    Private Class OrderHeader
        Public Order As New Order
        Public Overrides Function ToString() As String
            Return String.Format("Order:{0,-10}{1,10:M/d/yyyy}", Me.Order.OrderId, Me.Order.OrderDate)
        End Function
    End Class

    Private Class OrderHeader2
        Public Order As New Order
        Public Overrides Function ToString() As String
            Return String.Format("User:{0},{1}", Me.Order.OrderId)
        End Function
    End Class

    Private Class OrderFooter
        Public Order As New Order
        Public Overrides Function ToString() As String
            Return String.Format("Total:{0,20:c2}", Me.Order.OrderTotal)
        End Function
    End Class

    Private Class OrderPrizeFooter
        Public Order As New Order
        Public Overrides Function ToString() As String
            Return String.Format("Prize Money:{0,14:c2}", Me.Order.OrderPrizeTotal)
        End Function
    End Class

    Private Class BlankLine
        Public Separator As Char = " "
        Public Overrides Function ToString() As String
            Dim ret As String = ""
            For x As Integer = 1 To 26
                ret &= Separator
            Next
            Return ret
        End Function
    End Class

    Private Class OrderItem
        Public Order As New Order
        Public OrsID As Integer = 0
        Public ItemID As Integer = 0
        Public ItemName As String = ""
        Public ItemPrice As Decimal = 0D
        Public OrsReturnID As Integer? = New Nullable(Of Integer)
        Public ItemReturned As Integer? = New Nullable(Of Integer)

        Public Overrides Function ToString() As String
            Return String.Format("{0:*:""}{1,-14}{2,10:c2}", CDbl(Me.ItemReturned.HasValue).ToString("*;*;-"), Me.ItemName.PadRight(14).Substring(0, 14), Me.ItemPrice)
        End Function
    End Class

    Private Class OrderTransaction
        Public Order As New Order
        Public TransactionID As Integer = 0
        Public TransactionType As TransactionType = TransactionType.OrderTotal
        Public TransactionAmount As Decimal = 0D

        Public Overrides Function ToString() As String
            Return String.Format("{0,-16}{1,10:c2}", [Enum].GetName(GetType(TransactionType), Me.TransactionType), Me.TransactionAmount)
        End Function
    End Class

    Private Enum TransactionType As Integer
        OrderTotal
        Payment
        CashBack
    End Enum

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AccountHistoryTableAdapter.FillbyAct(Me.DsCanteen.AccountHistory, intActID)
        Dim line As New BlankLine
        line.Separator = "`"
        For Each row As dsCanteen.AccountHistoryRow In DsCanteen.AccountHistory.Rows
            Dim ord As New Order
            ord.OrderId = row.ORD_ID
            ord.OrderTotal = row.ORD_Amount
            ord.OrderPrizeTotal = row.ORD_UsedPrizeMoney
            ord.OrderDate = row.ORD_Date
            Dim oheader As New OrderHeader
            oheader.Order = ord
            Me.lsbActHistory.Items.Add(oheader)
            ' Dim tot As New OrderTransaction
            AccountHistorySubTableAdapter.FillByOrderId(Me.DsCanteen.AccountHistorySub, ord.OrderId)
            For Each row1 As dsCanteen.AccountHistorySubRow In DsCanteen.AccountHistorySub.Rows
                Dim itm As New OrderItem
                itm.OrsID = row1.ORS_ID
                itm.Order = ord
                itm.ItemID = row1.ORS_ITM_ID
                itm.ItemName = row1.itm_name
                itm.ItemPrice = row1.ORS_Charge
                If row1.IsORS_ReturnIDNull Then
                    itm.OrsReturnID = New Nullable(Of Integer)
                Else
                    itm.OrsReturnID = row1.ORS_ReturnID
                End If
                If row1.IsItemReturnedNull Then
                    itm.ItemReturned = New Nullable(Of Integer)
                Else
                    itm.ItemReturned = row1.ItemReturned
                End If
                ' tot.TransactionAmount += itm.ItemPrice
                Me.lsbActHistory.Items.Add(itm)
            Next
            Me.lsbActHistory.Items.Add(line)
            Me.TTRNTableAdapter.FillByOrdID(Me.DsCanteen.tTRN, ord.OrderId)
            For Each row2 As dsCanteen.tTRNRow In DsCanteen.tTRN.Rows
                If row2.TRN_Type = "Order" Then
                    Dim orderTran As New OrderTransaction
                    orderTran.Order = ord
                    orderTran.TransactionID = row2.TRN_ID
                    orderTran.TransactionAmount = -row2.TRN_Amount
                    orderTran.TransactionType = TransactionType.OrderTotal
                    Me.lsbActHistory.Items.Add(orderTran)
                ElseIf row2.TRN_Type = "CashBack" Then
                    Dim cashTran As New OrderTransaction
                    cashTran.Order = ord
                    cashTran.TransactionID = row2.TRN_ID
                    cashTran.TransactionAmount = -row2.TRN_Amount
                    cashTran.TransactionType = TransactionType.CashBack
                    Me.lsbActHistory.Items.Add(cashTran)
                ElseIf row2.TRN_Type = "Payment" Then
                    Dim paymentTran As New OrderTransaction
                    paymentTran.Order = ord
                    paymentTran.TransactionID = row2.TRN_ID
                    paymentTran.TransactionAmount = -row2.TRN_Amount
                    paymentTran.TransactionType = TransactionType.Payment
                    Me.lsbActHistory.Items.Add(paymentTran)
                End If
            Next
            'If x Mod 3 = 0 Then
            '    Dim pmt As New OrderTransaction
            '    pmt.Order = ord
            '    pmt.TransactionAmount = Rnd() * 25
            '    pmt.TransactionID = x * 4
            '    pmt.TransactionType = TransactionType.Payment
            '    Me.lsbActHistory.Items.Add(pmt)
            'End If
            'If x Mod 2 = 0 Then
            '    Dim cash As New OrderTransaction
            '    cash.Order = ord
            '    cash.TransactionAmount = Rnd() * 10
            '    cash.TransactionID = x * 2
            '    cash.TransactionType = TransactionType.CashBack
            '    Me.lsbActHistory.Items.Add(cash)
            'End If
            Dim ofooter As New OrderFooter
            ofooter.Order = ord
            Dim ofooter2 As New OrderPrizeFooter
            ofooter2.Order = ord
            Dim lineOrd As New BlankLine
            lineOrd.Separator = "_"
            Dim lineOrd2 As New BlankLine
            lineOrd2.Separator = ""
            Me.lsbActHistory.Items.Add(ofooter)
            Me.lsbActHistory.Items.Add(ofooter2)
            Me.lsbActHistory.Items.Add(lineOrd)
            Me.lsbActHistory.Items.Add(lineOrd2)
        Next

    End Sub

    Private Sub lsbActHistory_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsbActHistory.SelectedIndexChanged
        Select Case lsbActHistory.SelectedItem.GetType.ToString
            Case Is = GetType(OrderHeader).ToString
            Case Is = GetType(OrderItem).ToString
                ' CType(Me.lsbActHistory.SelectedItem, OrderItem).ItemID
            Case Is = GetType(OrderHeader).ToString
            Case Is = GetType(OrderHeader).ToString

        End Select
    End Sub

    Private Sub btnSelectTrn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectTrn.Click
        PrintrptSelectTrans()
    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        If lsbActHistory.Items.Count() > 0 Then
            If lsbActHistory.SelectedIndex > 0 Then
                lsbActHistory.SelectedIndex -= 1
            Else : lsbActHistory.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub btnDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.Click
        If lsbActHistory.Items.Count() > 0 Then
            If lsbActHistory.SelectedIndex < lsbActHistory.Items.Count - 1 Then
                lsbActHistory.SelectedIndex += 1
            Else : lsbActHistory.SelectedIndex = lsbActHistory.Items.Count - 1
            End If
        End If
    End Sub

    Private Sub btnTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTop.Click
        If lsbActHistory.Items.Count() > 0 Then
            lsbActHistory.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnBottom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBottom.Click
        If lsbActHistory.Items.Count() > 0 Then
            lsbActHistory.SelectedIndex = lsbActHistory.Items.Count - 1
        End If
    End Sub
End Class

