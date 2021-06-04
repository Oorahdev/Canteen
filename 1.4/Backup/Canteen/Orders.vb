Imports System.Windows.Forms.TabControl
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.Mail

Public Class Orders
    Dim intUsrId As Integer = 0
    Dim balance As Decimal = 0D
    Private itmCnt As Integer = 0
    Friend Shared intActID As Integer = 0
    Dim orderId As Integer = 0
    Dim subTotal As Decimal
    Dim total As Decimal
    Dim cashBack As Decimal = 0D
    Dim pmtAmount As Decimal = 0D
    Dim pmtMethod As String = ""
    Dim pmtPrizeAmount As Decimal = 0D
    Dim prizeAmount As Decimal = 0D
    Dim iniPrizeAmount As Decimal = 0D
    Dim usePrizeMoney As Boolean = True
    Dim cashLeftForReturn As Decimal = 0D
    Dim prizeToReturn As Decimal = 0D
    Dim preOrderId As Integer = 0
    Dim frm1 As New FormWait

    Public Class CanteenItm
        Public Sub New(ByVal dr As DataRow)
            Id = dr("ITM_ID")
            Name = dr("ITM_Name")
            Price = dr("ITM_Price")
            Location = ""
            ReturnID = New Nullable(Of Integer)
            '....
        End Sub

        Public Id As Integer = 0
        Public Name As String = ""
        Public Price As Decimal = 0D
        Public Location As String = ""
        Public ReturnID As Integer? = New Nullable(Of Integer)

        Public Overrides Function ToString() As String
            Return String.Format("{0,-16} {1,6:c2}", Name.PadRight(16).Substring(0, 16), Price)
            'Return MyBase.ToString()
        End Function
    End Class

    Private Sub Orders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType() Is GetType(Login) Then
                frm.Close()
                Exit For
            End If
        Next
        Loaditems()
        LoadAccount()
    End Sub

    Private Sub LoadAccount()
        Dim frmChooseACT As New ChooseACT2
        frmChooseACT.ShowDialog()
        Dim actId As Integer = frmChooseACT.SelectAct
        If actId > 0 Then
            ClearOrders()
            Load_Account(actId)
            intActID = actId
            TACTTableAdapter1.FillBy(Me.DsCanteen1.tACT, intActID)
            iniPrizeAmount = DsCanteen1.tACT.Item(0).ACT_PrizeMoney
            LoadPhoto()
            EnableButtons()
            TACTTableAdapter1.FillBy(Me.DsCanteen1.tACT, intActID)
            If Not DsCanteen1.tACT.Item(0).IsACT_SpendingLimitNull Then
                Dim lastUpdate As Date? = New Nullable(Of Date)
                If Not DsCanteen1.tACT.Item(0).IsACT_LastUpdateAmountNull Then
                    lastUpdate = DsCanteen1.tACT.Item(0).ACT_LastUpdateAmount
                End If
                TACTTableAdapter1.ACT_AmountLeftToSpendUpdate(intActID, DsCanteen1.tACT.Item(0).ACT_StartDate, DsCanteen1.tACT.Item(0).ACT_SpendingLimit, lastUpdate)
            End If
            loadPreOrders(actId)
        ElseIf actId = 0 Then
            ClearOrders()
            DisableButtons()
            btnChooseAct.Enabled = True
        End If
    End Sub

    Friend Sub Loaditems()
        'Check if usrid > 0 and if admin...
        TCTGTableAdapter1.FillBySort(Me.DsCanteen1.tCTG)
        TITMTableAdapter1.Fill(Me.DsCanteen1.tITM)
        TINVTableAdapter1.Fill(Me.DsCanteen1.tINV)
        TUSRTableAdapter1.Fill(Me.DsCanteen1.tUSR)
        Dim tabPage As Integer = 1
        If usrAdmin = True Then
            btnAdmin.Enabled = True
        End If
        If preOrderMode Then
            btnAdmin.Visible = False
            btnEditPrice.Visible = False
            btnManageAct.Visible = False
            btnCash.Visible = False
            btnPayment.Visible = False
            chkPrizeMoney.Visible = False
            btnProcess.Text = "Place Order"
            lblBal.Visible = False
            lblPrizeBal.Visible = False
            lblBalance.Visible = False
            lblPrizeBalance.Visible = False
            lblTotal.Visible = False
            lblTot.Visible = False
            lblCashBack.Visible = False
            lblCash.Visible = False
            lblPayment.Visible = False
            lblPay.Visible = False
            Label2.Visible = False
            lblPrizePay.Visible = False
            lblPrizeMoney.Visible = False
            lblPrize.Visible = False
            lblSubTotal.Text = "Total:"
        End If
        tbcItems.TabPages.Clear()
        ClearOrders()
        For Each drCategory As DataRow In Me.DsCanteen1.tCTG.Rows
            Dim tab As New TabPage
            tbcItems.TabPages.Add(tab)
            tab.Name = drCategory.Item("CTG_Name")
            tab.Text = drCategory.Item("CTG_Name")
            tab.BackColor = Color.LemonChiffon

            Dim qty As Integer = drCategory.Item("CTG_Qty")
            Dim tlp As New TableLayoutPanel
            tlp.Name = drCategory.Item("CTG_Name")
            tlp.Text = drCategory.Item("CTG_Name")
            tlp.Dock = DockStyle.Fill
            tab.Controls.Add(tlp)
            tlp.ColumnStyles.Clear()
            tlp.ColumnCount = Math.Floor(Math.Sqrt(qty))
            For x As Integer = 1 To tlp.ColumnCount
                tlp.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100 / tlp.ColumnCount))
            Next x
            tlp.RowStyles.Clear()
            For x As Integer = 1 To Math.Ceiling(qty / tlp.ColumnCount)
                tlp.RowStyles.Add(New RowStyle(SizeType.Percent, 100))
            Next x
            Dim dvItm As New DataView(DsCanteen1.tITM)
            dvItm.RowFilter = "ITM_CTG_ID = " & drCategory.Item("CTG_ID")
            For x As Integer = 1 To qty
                Dim btn As New Button
                btn.Dock = DockStyle.Fill
                AddHandler btn.Click, AddressOf btnItm_Click
                tlp.Controls.Add(btn)
                btn.Enabled = False
            Next x
            For x As Integer = 1 To tlp.Controls.Count
                dvItm.RowFilter = "ITM_Placement = " & x & " and ITM_CTG_ID = " & drCategory.Item("CTG_ID")
                If dvItm.Count > 0 Then
                    Dim drvItem As DataRowView = dvItm(0)
                    tlp.Controls.Item(x - 1).Text = String.Format("{0}{1}-{2}{3}{4}{5}", drCategory.Item("CTG_Section"), drvItem.Item("ITM_Placement"), ControlChars.CrLf, FormatCurrency(drvItem.Item("ITM_Price")), ControlChars.CrLf, drvItem.Item("ITM_Name"))
                    tlp.Controls.Item(x - 1).BackColor = Color.LightSteelBlue
                    tlp.Controls.Item(x - 1).ForeColor = Color.Black
                    tlp.Controls.Item(x - 1).Tag = New CanteenItm(drvItem.Row)

                End If
            Next
        Next
        DisableButtons()
    End Sub

    Private Sub calcPrizeMoney()
        If usePrizeMoney = True Then
            prizeAmount = subTotal - pmtPrizeAmount
            If prizeAmount > iniPrizeAmount Then
                prizeAmount = iniPrizeAmount
            End If
        Else
            prizeAmount = -pmtPrizeAmount
        End If
        lblPrize.Text = FormatCurrency(prizeAmount)
    End Sub

    Private Sub calcTotal()
        total = subTotal + cashBack + -pmtAmount ' + -pmtPrizeAmount
        If usePrizeMoney = True Then
            total -= prizeAmount + pmtPrizeAmount
        End If
        lblTot.Text = FormatCurrency(total)
    End Sub

    Private Sub loadPreOrders(ByVal actId As Integer)
        TITMTableAdapter1.Fill(Me.DsCanteen1.tITM)
        GetPreOrderItmsTableAdapter1.Fill(Me.DsCanteen1.GetPreOrderItms, actId)
        Dim flag As Boolean = False
        For Each drPreOrderItm As DataRow In Me.DsCanteen1.GetPreOrderItms.Rows
            preOrderId = drPreOrderItm.Item("POS_POR_ID")
            flag = True
            Dim drItm As New DataView(DsCanteen1.tITM)
            drItm.RowFilter = "ITM_ID = " & drPreOrderItm.Item("POS_ITM_ID")
            Dim itm As CanteenItm = New CanteenItm(drItm.Item(0).Row)
            lsbItems.Items.Add(itm)
            subTotal += itm.Price
            lblSub.Text = FormatCurrency(subTotal)
        Next
        calcPrizeMoney()
        calcTotal()
        If preOrderMode() = True Then
            If flag = True Then
                btnProcess.Text = "Change Order"
            Else
                btnProcess.Text = "Place Order"
            End If
        End If
    End Sub

    Private Sub btnItm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'COMMENT OUT TO IMPROVE SPEED
        If preOrderMode = True Or boolTrackInventory = False Then
            If intActID > 0 Then
                If sender.GetType Is GetType(Button) Then
                    Dim btn As Button = CType(sender, Button)
                    If Not IsNothing(btn.Tag) AndAlso btn.Tag.GetType Is GetType(CanteenItm) Then
                        Dim itm As CanteenItm = CType(btn.Tag, CanteenItm)
                        'If CheckShelf(itm.Id) = False Then
                        '    If CheckStock(itm.Id) = False Then
                        '        MsgBox("Item out of stock!")
                        '    ElseIf CheckStock(itm.Id) = True Then
                        '        Dim dialogStock As DialogResult
                        '        dialogStock = MsgBox("This item is only in the stockroom. Do you still want to add this item?", MsgBoxStyle.YesNo)
                        '        If dialogStock = Windows.Forms.DialogResult.Yes Then
                        '            itm.Location = "Stock"
                        lsbItems.Items.Add(itm)
                        subTotal += itm.Price
                        lblSub.Text = FormatCurrency(subTotal)
                    End If
                End If
                'Else
                '    itm.Location = "Shelf"
                '    lsbItems.Items.Add(itm)
                '    subTotal += itm.Price
                '    lblSub.Text = FormatCurrency(subTotal)
                '    total = subTotal + cashBack + -pmtAmount
                '    lblTot.Text = FormatCurrency(total)
                'End If
                '    End If
                'End If
            End If
        Else
            If intActID > 0 Then
                If sender.GetType Is GetType(Button) Then
                    Dim btn As Button = CType(sender, Button)
                    If Not IsNothing(btn.Tag) AndAlso btn.Tag.GetType Is GetType(CanteenItm) Then
                        Dim itm As CanteenItm = CType(btn.Tag, CanteenItm)
                        Dim boolStock As Boolean = True
                        If CheckShelf(itm.Id) = False Then
                            boolStock = CheckStock(itm.Id)
                            If boolStock = False Then
                                MsgBox("Item out of stock!")
                            ElseIf boolStock = True Then
                                Dim dialogStock As DialogResult
                                dialogStock = MsgBox("This item is only in the stockroom. Do you still want to add this item?", MsgBoxStyle.YesNo)
                                If dialogStock = Windows.Forms.DialogResult.Yes Then
                                    itm.Location = "Stock"
                                    lsbItems.Items.Add(itm)
                                    subTotal += itm.Price
                                    lblSub.Text = FormatCurrency(subTotal)
                                End If
                            End If
                        Else
                            itm.Location = "Shelf"
                            lsbItems.Items.Add(itm)
                            subTotal += itm.Price
                            lblSub.Text = FormatCurrency(subTotal)
                        End If
                    End If
                End If
            End If
        End If
        calcPrizeMoney()
        calcTotal()
    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        If lsbItems.Items.Count() > 0 Then
            If lsbItems.SelectedIndex > 0 Then
                lsbItems.SelectedIndex -= 1
            Else : lsbItems.SelectedIndex = 0
            End If
        End If
    End Sub
    Public Sub GetItmCnt()
        If lsbItems.Items.Count() <> 0 Then
            itmCnt = lsbItems.Items.Count() - 1
        Else : Exit Sub
        End If
    End Sub

    Private Sub btnDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.Click
        If lsbItems.Items.Count() > 0 Then
            GetItmCnt()
            If lsbItems.SelectedIndex < itmCnt Then
                lsbItems.SelectedIndex += 1
            ElseIf lsbItems.SelectedIndex >= itmCnt Then
                lsbItems.SelectedIndex = itmCnt
            End If
        End If
    End Sub
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If lsbItems.SelectedItems.Count > 0 Then 'SelectedIndex >= 0 And lsbItems.SelectedIndex <= itm Then
            Dim selectedItem As CanteenItm = lsbItems.SelectedItems(0)
            lsbItems.Items.Remove(selectedItem)
            subTotal -= selectedItem.Price
            lblSub.Text = FormatCurrency(subTotal)
        End If
        calcPrizeMoney()
        calcTotal()
    End Sub

    Private Sub btnAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.Click
        Dim frmAdmin As New Admin
        frmAdmin.ShowDialog()
        'tbcItems.TabPages.Item(0)
        If Admin.itemChanges = True Then
            Loaditems()
            Admin.itemChanges = False
        End If
    End Sub

    Private Sub Load_Account(ByVal intActId As Integer)
        Me.ActDisplayTableAdapter.FillACT(Me.DsCanteen1.ActDisplay, intActId)
    End Sub

    Friend Sub btnChooseAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseAct.Click
        If lsbItems.Items.Count > 0 Then
            Dim dialogResult As DialogResult = MsgBox("This will clear all items selected. Are you sure you would like to continue?", MsgBoxStyle.YesNo)
            If dialogResult = Windows.Forms.DialogResult.No Then
                DisableButtons()
                Exit Sub
            ElseIf dialogResult = Windows.Forms.DialogResult.Cancel Then
                btnChooseAct.Enabled = True
            End If
        End If
        LoadAccount()
    End Sub

    Private Function CheckShelf(ByVal itemID As Integer)
        If TINVTableAdapter1.FillBy(Me.DsCanteen1.tINV, itemID) > 0 Then
            If DsCanteen1.tINV.Item(0).INV_QtyShelf > 0 Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function

    Private Function CheckStock(ByVal itemID As Integer)
        If TINVTableAdapter1.FillBy(Me.DsCanteen1.tINV, itemID) > 0 Then
            If DsCanteen1.tINV.Item(0).INV_QtyStockRoom > 0 Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function

    Private Sub UpdateInventory(ByVal itmId As Integer, Optional ByVal shelfAmount As Integer = 0, Optional ByVal stockAmount As Integer = 0)
        'TINVTableAdapter1.UpdateShelfStock(itmId, shelfAmount, stockAmount)
    End Sub

    Private Sub processPreOrder()
        Dim adapter As New dsCanteenTableAdapters.QueriesTableAdapter
        intUsrId = usrId
        orderId = adapter.PlacePreOrder(intActID, Today, intUsrId)
        For Each listItm As CanteenItm In lsbItems.Items
            adapter.PlacePreOrderSub(orderId, listItm.Id, listItm.Price, intUsrId)
        Next
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Me.Cursor = Cursors.WaitCursor
        btnManageAct.Enabled = False
        btnProcess.Enabled = False
        btnCash.Enabled = False
        btnPayment.Enabled = False
        btnChooseAct.Enabled = False
        btnRemove.Enabled = False
        btnEditPrice.Enabled = False
        ' tbcItems.Enabled = False
        For Each Control As Control In tbcItems.Controls
            For Each Control2 As Control In Control.Controls
                ' Control2.Enabled = False
                For Each control3 As Control In Control2.Controls
                    control3.Enabled = False
                Next
            Next
        Next
        If preOrderMode = True Then
            If CheckPreOrderSpending() = False Then
                EnableButtons()
                Me.Cursor = Cursors.Default
                Exit Sub
            Else
                processPreOrder()
                ClearOrders()
                DisableButtons()
                MsgBox("Pre order done successfully")
                LoadAccount()
            End If
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        If CheckSpending() = False Then
            EnableButtons()
            Me.Cursor = Cursors.Default
            Exit Sub
        Else
            If CheckBalance() = False Then
                EnableButtons()
                Me.Cursor = Cursors.Default
                Exit Sub
            Else
                UpdateSpending()
                UpdateBalance()
                Dim processOrder As New dsCanteenTableAdapters.QueriesTableAdapter
                intUsrId = usrId
                If lsbItems.Items.Count > 0 Or cashBack > 0 Or pmtAmount > 0 Or pmtPrizeAmount > 0 Then
                    'total = subTotal + cashBack + -pmtAmount
                    orderId = processOrder.ProcessOrder(intActID, total, prizeAmount, Now, intUsrId)
                    If preOrderId <> 0 Then
                        processOrder.POR_SetPaid(preOrderId)
                    End If
                    'COMMENT OUT TO IMPROVE SPEED
                    For Each listItm As CanteenItm In lsbItems.Items
                        If listItm.Location = "Return" Then
                            processOrder.ProcessOrderSub(orderId, listItm.Id, listItm.Price, listItm.ReturnID, intUsrId)
                            If boolTrackInventory = True Then processOrder.UpdateStockShelf(listItm.Id, 1, 0, "Shelf", "Return", intUsrId)
                        ElseIf listItm.Location = "Reimburse" Then
                            processOrder.ProcessOrderSub(orderId, listItm.Id, listItm.Price, listItm.ReturnID, intUsrId)
                        Else
                            processOrder.ProcessOrderSub(orderId, listItm.Id, listItm.Price, New Nullable(Of Integer), intUsrId)
                            If boolTrackInventory = True Then
                                If listItm.Location = "Shelf" Then
                                    processOrder.UpdateStockShelf(listItm.Id, -1, 0, "Shelf", "Purchase", intUsrId)
                                ElseIf listItm.Location = "Stock" Then
                                    processOrder.UpdateStockShelf(listItm.Id, 0, -1, "Stock", "Purchase", intUsrId)
                                End If
                            End If
                        End If
                    Next
                    If lsbItems.Items.Count > 0 Then
                        Dim flagCash As Boolean = False
                        Dim prizeOrder As Decimal = 0
                        If usePrizeMoney = True Then
                            If iniPrizeAmount + pmtPrizeAmount > subTotal Then
                                prizeOrder = subTotal
                            Else
                                prizeOrder = iniPrizeAmount + pmtPrizeAmount
                                flagCash = True
                            End If
                            processOrder.InsertTransaction(intActID, orderId, "", -prizeOrder - cashLeftForReturn, 0, New Nullable(Of Date), "Order - Prize", intUsrId)
                            If flagCash = True Or cashLeftForReturn > 0 Then
                                processOrder.InsertTransaction(intActID, orderId, "", -subTotal + prizeOrder + cashLeftForReturn, 0, New Nullable(Of Date), "Order - Cash", intUsrId)
                            End If
                        Else
                            processOrder.InsertTransaction(intActID, orderId, "", -subTotal + cashLeftForReturn, 0, New Nullable(Of Date), "Order - Cash", intUsrId)
                        End If
                    End If
                    If cashBack > 0 Then
                        processOrder.InsertTransaction(intActID, orderId, "", -cashBack, 0, New Nullable(Of Date), "CashBack", intUsrId)
                    End If
                    If pmtAmount > 0 Then
                        processOrder.InsertTransaction(intActID, orderId, pmtMethod, pmtAmount, PaymentForm.newPmt.CheckNum, PaymentForm.newPmt.CheckDate, "Payment", intUsrId)
                    End If
                    If pmtPrizeAmount > 0 Then
                        processOrder.InsertTransaction(intActID, orderId, "Prize", pmtPrizeAmount, 0, New Nullable(Of Date), "Add Prize Money", intUsrId)
                    End If
                    Try
                        PrintSingleReceipt()
                    Catch
                    End Try

                    Try
                        PrintDairyReceipt()
                    Catch

                    End Try
                    Try
                        PrintNoshReceipt()
                    Catch
                    End Try
                    Try
                        PrintMeatReceipt()
                    Catch
                    End Try
                    ClearOrders()
                    DisableButtons()
                    'MsgBox("Process Done Successfully")
                    LoadAccount()
                Else
                    MsgBox("No order to process")
                    EnableButtons()
                End If
                EnableButtons()
            End If
            EnableButtons()
        End If
        Me.Cursor = Cursors.Default

        calcPrizeMoney()

    End Sub

    Private Function CheckSpending()
        'Dim dvAct As DataView = GetDV("Select ACT_AmountLeft From ACT Where ACT_ID = " & actId)
        'Dim drvAmountLeft As DataRowView = dvAct(0)
        If Not DsCanteen1.tACT.Item(0).IsACT_SpendingLimitNull Then
            Dim amountleft As Decimal
            If Not DsCanteen1.tACT.Item(0).IsACT_AmountLeftNull Then
                amountleft = DsCanteen1.tACT.Item(0).ACT_AmountLeft
            Else : Return True
            End If
            'If subTotal + cashBack > 0 Then
            'If subTotal + cashBack > amountleft Then
            If total > 0 Then
                If cashBack > 0 And total > amountleft Then
                    Dim msgResult As DialogResult = MsgBox("This purchase exceeds your Spending Limit by " & FormatCurrency(total - amountleft) & "! Cash back is not allowed!", MsgBoxStyle.OkOnly)
                    Return False
                End If
                If total > amountleft Then
                    'Dim msgResult As DialogResult = MsgBox("This purchase exceeds your Spending Limit by " & FormatCurrency((subTotal + cashBack) - amountleft) & "! Would you like to continue?", MsgBoxStyle.YesNo)
                    Dim msgResult As DialogResult = MsgBox("This purchase exceeds your Spending Limit by " & FormatCurrency(total - amountleft) & "! Would you like to continue?", MsgBoxStyle.YesNo)
                    If msgResult = Windows.Forms.DialogResult.Yes Then
                        Return True
                    Else : Return False
                    End If
                End If
            Else : Return True
            End If
        Else : Return True
        End If
        Return True
    End Function

    Private Function CheckPreOrderSpending()
        balance = DsCanteen1.tACT.Item(0).ACT_Balance
        Dim creditLimit As Decimal = DsCanteen1.tACT.Item(0).ACT_CreditLimit
        'If total - balance > creditLimit Then
        If total - balance > 0 Then
            Dim exceedAmount As Decimal = (total - balance) - creditLimit
            Dim dialogResult As DialogResult = MsgBox("This purchase exceeds your balance by: " & FormatCurrency(total - balance), MsgBoxStyle.OkOnly)
            Return False
        End If
        Return True
    End Function

    Private Function CheckBalance()
        balance = DsCanteen1.tACT.Item(0).ACT_Balance
        Dim creditLimit As Decimal = DsCanteen1.tACT.Item(0).ACT_CreditLimit
        If total - balance > creditLimit Then
            Dim exceedAmount As Decimal = (total - balance) - creditLimit
            If cashBack > 0 Then
                Dim msgResult As DialogResult = MsgBox("This purchase exceeds your Spending Limit by " & FormatCurrency(Math.Abs(exceedAmount), 2, TriState.True) & "! Cash back is not allowed!", MsgBoxStyle.OkOnly)
                Return False
            End If
            Dim dialogResult As DialogResult = MsgBox("This purchase exceeds your credit limit by " & FormatCurrency(Math.Abs(exceedAmount), 2, TriState.True) & "! Would you like to continue?", MsgBoxStyle.YesNo)
            If dialogResult = Windows.Forms.DialogResult.Yes Then
                Return True
            Else : Return False
            End If
        End If
        Return True
    End Function

    Private Function UpdateBalance()
        'calcPrizeMoney()
        'calcTotal()
        If TACTTableAdapter1.UpdateBalance(total, prizeAmount, intActID) > 0 Then
            Return True
        End If
        Return False
    End Function

    Private Function UpdateSpending()
        If DsCanteen1.tACT.Item(0).IsACT_SpendingLimitNull Then
            Return True
        Else
            If TACTTableAdapter1.UpdateAmountSpent(subTotal + cashBack, intActID) > 0 Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        intUsrId = 0
        Dim frmLogin As New Login
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub ClearOrders()
        intActID = 0
        balance = FormatCurrency(0)
        itmCnt = 0
        orderId = 0
        'clear labels
        usePrizeMoney = True
        chkPrizeMoney.Checked = True
        lsbItems.Items.Clear()
        subTotal = FormatCurrency(0)
        cashBack = FormatCurrency(0)
        pmtAmount = FormatCurrency(0)
        total = FormatCurrency(0)
        prizeAmount = FormatCurrency(0)
        iniPrizeAmount = FormatCurrency(0)
        prizeAmount = iniPrizeAmount
        pmtPrizeAmount = 0D
        lblActName.Text = ""
        lblBal.Text = ""
        lblPrizeBal.Text = ""
        lblCash.Text = ""
        lblPay.Text = ""
        lblSub.Text = ""
        lblTot.Text = ""
        lblPrize.Text = ""
        lblPrizePay.Text = ""
        pmtMethod = ""
        PaymentForm.newPmt.CheckDate = New Nullable(Of Date)
        PaymentForm.newPmt.CheckNum = 0
        PaymentForm.newPmt.PmtAmount = 0D 'FormatCurrency(0)
        PaymentForm.newPmt.PmtMethod = ""
        Canteen.CashBack.cashBack = 0D ' FormatCurrency(0)
        EditItemPrice.itemPrice = 0D
        PictureBox1.Image = Nothing
        preOrderId = 0
    End Sub

    Private Sub btnCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCash.Click
        If intActID > 0 Then
            Dim frmCashBack As New CashBack
            frmCashBack.ShowDialog()
            cashBack = Canteen.CashBack.cashBack
            lblCash.Text = FormatCurrency(cashBack)
            calcTotal()
        End If
    End Sub

    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click
        If intActID > 0 Then
            Dim frmPayment As New PaymentForm
            frmPayment.ShowDialog()
            If PaymentForm.newPmt.PmtMethod = "Prize" Then
                pmtPrizeAmount = PaymentForm.newPmt.PmtAmount
                lblPrizePay.Text = FormatCurrency(-pmtPrizeAmount)
            Else
                pmtMethod = PaymentForm.newPmt.PmtMethod
                pmtAmount = PaymentForm.newPmt.PmtAmount
                lblPay.Text = FormatCurrency(-pmtAmount)
            End If
            calcPrizeMoney()
            calcTotal()
        End If
    End Sub
    Private Sub DisableButtons()
        If intActID <= 0 Then
            btnManageAct.Enabled = False
            btnProcess.Enabled = False
            btnCash.Enabled = False
            btnPayment.Enabled = False
            For Each Control As Control In tbcItems.Controls
                For Each Control2 As Control In Control.Controls
                    For Each control3 As Control In Control2.Controls
                        control3.Enabled = False
                    Next
                Next
            Next
        End If
    End Sub

    Private Sub EnableButtons()
        If intActID > 0 Then
            btnManageAct.Enabled = True
            btnProcess.Enabled = True
            btnCash.Enabled = True
            btnPayment.Enabled = True
            btnRemove.Enabled = True
            btnEditPrice.Enabled = True
            btnChooseAct.Enabled = True
            For Each Control As Control In tbcItems.Controls
                For Each Control2 As Control In Control.Controls
                    ' Control2.Enabled = True
                    For Each control3 As Control In Control2.Controls
                        If Not control3.Tag Is Nothing Then
                            control3.Enabled = True
                        End If
                    Next
                Next
            Next
            ' tbcItems.Enabled = True
        End If
    End Sub

    Private Sub GetSubTotal()
        '    For Each listitm As CanteenItm In Me.lsbItems.Items
        '        subTotal += listitm.Price
        '    Next
    End Sub

    Private Sub PrintSingleReceipt()
        Me.TPRFTableAdapter1.FillByPrfName(Me.DsCanteen1.tPRF, "Counter Printer")
        If Not DsCanteen1.tPRF.Item(0).IsPRF_ValueNull Then
            SingleReceipt.DataSource.ConnectionString = UpdateShelves.GetOledbConnectionString()
            SingleReceipt.DataSource.RecordSource = ""
            SingleReceipt.DataSource.RecordSource = "SELECT * FROM SingleReceipt"
            SingleReceipt.DataSource.RecordSource += " WHERE TRN_ORD_ID = " & orderId
            SingleReceipt.Document.PrinterSettings.PrinterName = DsCanteen1.tPRF.Item(0).PRF_Value
            SingleReceipt.Document.Print()
        End If
    End Sub

    Private Sub PrintDairyReceipt()
        Me.TPRFTableAdapter1.FillByPrfName(Me.DsCanteen1.tPRF, "Dairy Printer")
        If Not DsCanteen1.tPRF.Item(0).IsPRF_ValueNull Then
            OrderSubReceipt.DataSource.ConnectionString = UpdateShelves.GetOledbConnectionString()
            OrderSubReceipt.DataSource.RecordSource = ""
            OrderSubReceipt.DataSource.RecordSource = "SELECT * FROM OrderSubReceipt"
            OrderSubReceipt.DataSource.RecordSource += " WHERE ORD_ID = " & orderId & " and ITM_printer = 'Dairy Printer' and ORS_ReturnID is null"
            OrderSubReceipt.Document.PrinterSettings.PrinterName = DsCanteen1.tPRF.Item(0).PRF_Value
            OrderSubReceipt.Document.Print()
        End If
    End Sub

    Private Sub PrintMeatReceipt()
        Me.TPRFTableAdapter1.FillByPrfName(Me.DsCanteen1.tPRF, "Meat Printer")
        If Not DsCanteen1.tPRF.Item(0).IsPRF_ValueNull Then
            OrderSubReceipt.DataSource.ConnectionString = UpdateShelves.GetOledbConnectionString()
            OrderSubReceipt.DataSource.RecordSource = ""
            OrderSubReceipt.DataSource.RecordSource = "SELECT * FROM OrderSubReceipt"
            OrderSubReceipt.DataSource.RecordSource += " WHERE ORD_ID = " & orderId & " and ITM_printer = 'Meat Printer' and ORS_ReturnID is null"
            OrderSubReceipt.Document.PrinterSettings.PrinterName = DsCanteen1.tPRF.Item(0).PRF_Value
            OrderSubReceipt.Document.Print()
        End If
    End Sub

    Private Sub PrintNoshReceipt()
        Me.TPRFTableAdapter1.FillByPrfName(Me.DsCanteen1.tPRF, "Nosh Printer")
        If Not DsCanteen1.tPRF.Item(0).IsPRF_ValueNull Then
            OrderSubReceipt.DataSource.ConnectionString = UpdateShelves.GetOledbConnectionString()
            OrderSubReceipt.DataSource.RecordSource = ""
            OrderSubReceipt.DataSource.RecordSource = "SELECT * FROM OrderSubReceipt"
            OrderSubReceipt.DataSource.RecordSource += " WHERE ORD_ID = " & orderId & " and ITM_printer = 'Nosh Printer' and ORS_ReturnID is null"
            OrderSubReceipt.Document.PrinterSettings.PrinterName = DsCanteen1.tPRF.Item(0).PRF_Value
            OrderSubReceipt.Document.Print()
        End If
    End Sub

    'Private Sub GetTotal()
    '    total = FormatCurrency( + 
    'End Sub

    Private Sub OrderSubReceipt_NoData(ByVal sender As Object, ByVal e As System.EventArgs) Handles OrderSubReceipt.NoData
        OrderSubReceipt.Cancel = True
    End Sub

    Private Sub SingleReceipt_NoData(ByVal sender As Object, ByVal e As System.EventArgs) Handles SingleReceipt.NoData
        SingleReceipt.Cancel = True
    End Sub

    Private Sub btnManageAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageAct.Click
        Dim frmAccountHistory As New AccountHistory
        frmAccountHistory.loadbyactid(intActID, Me.Handle)
        frmAccountHistory.ShowDialog()
        If frmAccountHistory.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim returnItmID As Integer = AccountHistory.returnItmID
            TITMTableAdapter1.FillByItmId(Me.DsCanteen1.tITM, AccountHistory.returnItmID)
            Dim itmrow As DataRow = DsCanteen1.tITM.Rows(0)
            'Dim itmRow As DataRow = TITMTableAdapter1.FillByItmId(AccountHistory.returnItmID).Rows(0)
            Dim itm As CanteenItm = New CanteenItm(itmrow)
            itm.Id = AccountHistory.returnItmID
            itm.Name = AccountHistory.returnItmName
            itm.Price = -FormatCurrency(AccountHistory.returnItmPrice, 2, TriState.True, TriState.True)
            If AccountHistory.returnReimburse = "Return" Then
                itm.Location = "Return"
            ElseIf AccountHistory.returnReimburse = "Reimburse" Then
                itm.Location = "Reimburse"
            End If
            itm.ReturnID = AccountHistory.returnOrsID
            lsbItems.Items.Add(itm)
            subTotal += itm.Price
            lblSub.Text = FormatCurrency(subTotal)

            Dim calc As New dsCanteenTableAdapters.QueriesTableAdapter
            cashLeftForReturn = calc.ORD_GetCashLeftForReturn(itm.ReturnID)
            If (cashLeftForReturn >= -itm.Price) Then
                prizeToReturn = 0
            Else
                prizeToReturn = itm.Price + cashLeftForReturn
            End If
            prizeAmount += prizeToReturn
            lblPrize.Text = FormatCurrency(prizeAmount)

            calcTotal()
            btnProcess.PerformClick()
        End If
    End Sub

    Friend Function ItemReturned(ByVal orsID As Integer)
        'Orders.Handle, Me.Handle
        For Each item As CanteenItm In Me.lsbItems.Items
            If orsID = item.ReturnID Then
                Return True
            Else
                Return False
            End If
        Next
        Return False
    End Function

    Private Sub btnEditPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPrice.Click
        If lsbItems.SelectedItems.Count > 0 Then 'SelectedIndex >= 0 And lsbItems.SelectedIndex <= itm Then
            Dim selectedItem As CanteenItm = lsbItems.SelectedItems(0)
            Dim oldPrice As Decimal = selectedItem.Price
            Dim frmEditItemPrice As New EditItemPrice
            frmEditItemPrice.LoadPrice(oldPrice)
            frmEditItemPrice.ShowDialog()
            If frmEditItemPrice.DialogResult = Windows.Forms.DialogResult.OK Then
                selectedItem.Price = EditItemPrice.itemPrice
                lsbItems.Items.Remove(selectedItem)
                lsbItems.Items.Add(selectedItem)
                subTotal += EditItemPrice.itemPrice - oldPrice
                lblSub.Text = FormatCurrency(subTotal)
                calcPrizeMoney()
                calcTotal()
            End If

        End If
    End Sub
    Private Sub LoadPhoto()
        Try
            Dim con As New SqlConnection(My.Settings.CanteenConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("select ACT_Picture from ACT where ACT_ID =" & intActID, con)
            'cmd.Connection = con
            cmd.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)

            If Not IsDBNull(ds.Tables(0).Rows(0).Item(0)) Then
                Dim bits As Byte() = CType(ds.Tables(0).Rows(0).Item(0), Byte())
                Dim memorybits As New MemoryStream(bits)
                Dim bitmap As New Bitmap(memorybits)
                'Dim strHeight As Integer
                'Dim strWidth As Integer
                'strHeight = 100 'Trim(InputBox("Specify the new height of the image (in pixels):", "  Specify Height", PictureBox1.Image.Height.ToString))
                'If strHeight < 0 Then Exit Sub
                'strWidth = 100 'Trim(InputBox("Specify the new width of the image (in pixels):", "  Specify Width", PictureBox1.Image.Width.ToString))
                'If strWidth < 0 Then Exit Sub
                'Dim bitmapThumb As New Bitmap(bitmap, CInt(strHeight), CStr(strWidth)) ', PixelFormat.Format24bppRgb)
                PictureBox1.Image = bitmap
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                'Dim objGraphics As Graphics = Graphics.FromImage(bitmapThumb)
                'objGraphics.DrawImage(PictureBox1.Image, 188, 12, CInt(strHeight), CInt(strWidth))
                'PictureBox1.Image = bitmapThumb
                'PictureBox1.Refresh()
                'PictureBox1.Size = PictureBox1.Image.Size
                'objGraphics.Dispose()
                'objGraphics = Nothing
                'bitmap.sGetThumbnailImage(100, 100, AddressOf System.Drawing.Image.GetThumbnailImageAbort, 0)
            Else : PictureBox1.Image = Nothing
            End If
        Catch

        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If Not PictureBox1.Image Is Nothing Then
            Dim frmEnlargePhoto As New EnlargePhoto
            frmEnlargePhoto.LoadPhoto(PictureBox1.Image)
            frmEnlargePhoto.ShowDialog()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPrizeMoney.CheckedChanged
        usePrizeMoney = chkPrizeMoney.Checked
        calcPrizeMoney()
        calcTotal()
    End Sub
End Class



