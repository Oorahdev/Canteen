Public Class Items

    Private Sub Items_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsCanteen.PRF' table. You can move, or remove it, as needed.
        'Me.PRFTableAdapter.Fill(Me.DsCanteen.PRF)
        'TODO: This line of code loads data into the 'DsCanteen.tITM' table. You can move, or remove it, as needed.
        'Me.TITMTableAdapter.Fill(Me.DsCanteen.tITM)
        lsbItems.DisplayMember = "ITM_Name"
        lsbItems.ValueMember = "ITM_ID"
        lsbItems.DataSource = Me.TITMTableAdapter.GetDataBySort()
        cboPrinter.DisplayMember = "PRF_Name"
        cboPrinter.ValueMember = "PRF_Name"
        cboPrinter.DataSource = Me.PRFTableAdapter.GetData()
        cboCatId.DisplayMember = "CTG_Name"
        cboCatId.ValueMember = "CTG_ID"
        cboCatId.DataSource = Me.TCTGTableAdapter1.GetDataBySort()

        unsavedChanges = False
    End Sub
    Dim ctlCurrent As TextBox
    Private Sub txbActId_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbName.GotFocus, txbPrice.GotFocus, txbQtyShelf.GotFocus, txbQtyUnit.GotFocus, txbReorder.GotFocus
        ctlCurrent = sender
    End Sub

    Private Sub AdmKeyboard1_OnKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AdmKeyboard1.OnKeyPress
        Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyPress(adm.admUtilities.TextWithSelection.FromTextBox(ctlCurrent), e)
        ctlCurrent.Text = ret.Text
        ctlCurrent.SelectionStart = ret.SelectionStart
        ctlCurrent.SelectionLength = ret.SelectionLength
    End Sub

    Public Sub AdmKeyboard1_OnKeyPressSpecial(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AdmKeyboard1.OnKeyPressSpecial
        Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyEvent(adm.admUtilities.TextWithSelection.FromTextBox(ctlCurrent), e)
        ctlCurrent.Text = ret.Text
        ctlCurrent.SelectionStart = ret.SelectionStart
        ctlCurrent.SelectionLength = ret.SelectionLength
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If lsbItems.SelectedIndex >= 0 Then
            lsbItems.SelectedIndex = -1
        End If
        ClearTxbs()
        lblError.Text = ""
        unsavedChanges = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim itmId As Integer
        Dim itmName As String
        Dim itmNumber As Integer = 0
        Dim itmCatId As Integer
        Dim itmPlacement As Integer
        Dim itmPrice As Decimal
        Dim itmPrinter As String
        Dim itmQtyShelf As Integer
        Dim itmQtyUnit As Integer
        Dim itmReorder As Integer
        If Not lsbItems.SelectedValue Is Nothing Then
            itmId = lsbItems.SelectedValue
        End If
        If unsavedChanges = True Then
            If CheckTxb() = True Then 'Not (txbName.Text Is Nothing Or txbNumber.Text Is Nothing Or cboPlacement.Text Is Nothing Or txbPrice.Text Is Nothing Or txbPrinter.Text Is Nothing Or txbQtyShelf.Text Is Nothing Or txbQtyUnit.Text Is Nothing Or txbReorder.Text Is Nothing) Then
                Dim placementID As Integer?
                If IsDBNull(cboPlacement.SelectedValue) Then
                    placementID = New Nullable(Of Integer)
                Else
                    placementID = cboPlacement.SelectedValue
                    If CheckAvailablePlacement(itmId, placementID, cboCatId.SelectedValue) = True Then
                        placementID = cboPlacement.SelectedValue
                    Else : lblError.Text = "The placement is already in use!"
                        Exit Sub
                    End If
                End If
                itmName = txbName.Text
                'itmNumber = txbNumber.Text
                itmCatId = cboCatId.SelectedValue
                itmPrice = FormatCurrency(txbPrice.Text, 2)
                'If Not cboPrinter.SelectedValue = "" Then
                itmPrinter = cboPrinter.SelectedValue
                'End If
                itmQtyShelf = txbQtyShelf.Text
                itmQtyUnit = txbQtyUnit.Text
                itmReorder = txbReorder.Text
                'usrActId = CInt(Me.txbActId.Text)
                If itmId > 0 Then
                    TITMTableAdapter.UpdateItm(itmName, itmNumber, itmCatId, placementID, itmPrice, itmPrinter, itmQtyShelf, itmQtyUnit, itmReorder, itmId)
                    lblError.Text = "Item updated successfully :)"
                    ClearTxbs()
                    unsavedChanges = False
                    lsbItems.SelectedIndex = 0

                    lsbItems.DataSource = Me.TITMTableAdapter.GetDataBySort()
                    GetCtgPlacement()
                    LoadItmInfo()
                    unsavedChanges = False

                Else : TITMTableAdapter.InsertItm(itmName, itmNumber, itmCatId, placementID, itmPrice, itmPrinter, itmQtyShelf, itmQtyUnit, itmReorder)
                    lblError.Text = "Item created successfully :)"
                    ClearTxbs()
                    unsavedChanges = False
                    lsbItems.DataSource = Me.TITMTableAdapter.GetDataBySort()
                    GetCtgPlacement()
                    LoadItmInfo()
                    lsbItems.SelectedIndex = 0
                    unsavedChanges = False

                    'Load lsbItems and selectedvalue = new user
                End If

            End If
        Else : lblError.Text = "No changes were made!"
        End If

        'Try
        '    Me.titmBindingSource.EndEdit()
        '    Me.titmTableAdapter.Update(DsCanteen.titm)
        '    DsCanteen.titm.AcceptChanges()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Function CheckAvailablePlacement(ByVal itemID As Integer, ByVal placementId As Integer, ByVal categoryID As Integer)
        Me.TITMTableAdapter1.FillByCtgID(Me.DsCanteen.tITM, categoryID, itemID)
        For Each row As dsCanteen.tITMRow In Me.DsCanteen.tITM.Rows
            If row.ITM_Placement = placementId Then
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    'Private Sub titmBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles titmBindingSource.AddingNew
    '    Dim dr As dsCanteen.titmRow = DsCanteen.titm.NewtitmRow
    '    dr.BeginEdit()
    '    dr("USR_DateEntered") = Now
    '    dr.EndEdit()
    '    e.NewObject = dr
    'End Sub

    'Private Sub titmBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles titmBindingSource.CurrentChanged
    '    If Me.titmBindingSource.Current.GetType Is GetType(DataRowView) Then
    '        Dim dr As DataRowView = Me.titmBindingSource.Current
    '        Dim usr As dsCanteen.titmRow = dr.Row
    '        Me.txbActId.Text = usr.USR_ACT_ID
    '        Me.txbPassword.Text = usr.USR_Password
    '        Me.txbConfirm.Text = usr.USR_Password
    '        Me.txbUsrName.Text = usr.USR_Login
    '    End If
    'End Sub

    Private Sub ClearTxbs()
        txbName.Text = ""
        'txbNumber.Text = ""
        cboCatId.SelectedIndex = -1
        cboPlacement.SelectedIndex = -1
        txbPrice.Text = ""
        cboPrinter.SelectedIndex = -1
        txbQtyShelf.Text = ""
        txbQtyUnit.Text = ""
        txbReorder.Text = ""
    End Sub
    Dim lsbSelectedIndex As Integer = 0
    Private Sub lsbItems_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsbItems.SelectedIndexChanged
        If unsavedChanges = True And deleting = False Then
            Dim dialogResult As DialogResult = MsgBox("This will clear all your changes! Are you sure you would like to continue?", MsgBoxStyle.YesNo)
            If dialogResult = Windows.Forms.DialogResult.No Then
                lsbItems.SelectedIndex = lsbSelectedIndex
                Exit Sub
            Else : unsavedChanges = False
                lblError.Text = ""
            End If
        End If
        LoadItmInfo()
        lsbSelectedIndex = lsbItems.SelectedIndex
    End Sub


    Private Sub LoadItmInfo()
        If Not lsbItems.SelectedValue Is Nothing Then
            TITMTableAdapter.FillByItmId(Me.DsCanteen.tITM, lsbItems.SelectedValue)
            txbName.Text = DsCanteen.tITM.Item(0).ITM_Name
            'txbNumber.Text = DsCanteen.tITM.Item(0).ITM_Number
            cboCatId.SelectedValue = DsCanteen.tITM(0).ITM_CTG_ID
            If Not cboCatId.SelectedValue Is Nothing Then
                cboPlacement.Enabled = True
            End If
            GetCtgPlacement()
            If Not DsCanteen.tITM(0).IsITM_PlacementNull Then
                cboPlacement.SelectedValue = DsCanteen.tITM.Item(0).ITM_Placement
            End If
            txbPrice.Text = DsCanteen.tITM.Item(0).ITM_Price
            txbPrice.Text = String.Format("{0:C2}", Val(txbPrice.Text))
            cboPrinter.SelectedValue = DsCanteen.tITM.Item(0).ITM_Printer
            txbQtyShelf.Text = DsCanteen.tITM.Item(0).ITM_QtyPerShelf
            txbQtyUnit.Text = DsCanteen.tITM.Item(0).ITM_QtyPerUnit
            txbReorder.Text = DsCanteen.tITM.Item(0).ITM_ReorderLevel
            unsavedChanges = False
        End If
    End Sub
    Dim deleting As Boolean = False

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If lsbItems.SelectedValue > 0 Then
            deleting = True
            TITMTableAdapter.DeleteByItmId(lsbItems.SelectedValue)
            ClearTxbs()
            lsbItems.DataSource = Me.TITMTableAdapter.GetDataBySort()
            deleting = False
        End If
        unsavedChanges = False
    End Sub


    Dim unsavedChanges As Boolean = False

    Private Sub txbActId_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbName.TextChanged, txbPrice.TextChanged, txbQtyShelf.TextChanged, txbQtyUnit.TextChanged, txbReorder.TextChanged ', cboPrinter.SelectedValueChanged ', cboCatId.SelectedValueChanged
        unsavedChanges = True
        lblError.Text = ""
    End Sub
    Private Function CheckTxb()
        If Not txbName.Text = "" Then
            'If Not txbNumber.Text = "" Then
            If Not cboCatId.SelectedValue Is Nothing Then
                If IsNumeric(txbPrice.Text) And Not txbPrice.Text = "" Then
                    If Not cboPrinter.SelectedValue Is Nothing Then
                        If Not txbQtyShelf.Text = "" And IsNumeric(txbQtyShelf.Text) Then
                            If Not txbQtyUnit.Text = "" And IsNumeric(txbQtyUnit.Text) Then
                                If Not txbReorder.Text = "" And IsNumeric(txbReorder.Text) Then
                                    Return True
                                Else : lblError.Text = "Please enter a numeric Reorder Level."
                                    Return False
                                End If
                            Else : lblError.Text = "Please enter a numeric Quantity Per Unit."
                                Return False
                            End If
                        Else : lblError.Text = "Please enter a numeric Quantity Per Shelf"
                            Return False
                        End If
                    Else : lblError.Text = "Please enter a Printer."
                        Return False
                    End If
                Else : lblError.Text = "Please enter a Price."
                    Return False
                End If
            Else : lblError.Text = "Please enter a Category."
                Return False
            End If
            'Else : lblError.Text = "Please enter a Number."
            'Return False
            'End If
            Else : lblError.Text = "Please enter a Name."
        Return False
            End If
        Return True
    End Function

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



    Private Sub cboCatId_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCatId.SelectedValueChanged
        GetCtgPlacement()
        If Not cboCatId.SelectedValue Is Nothing Then
            cboPrinter.SelectedValue = DsCanteen.tCTG.Item(0).CTG_Printer
        End If
    End Sub
    Private Sub GetCtgPlacement()
        If Not cboCatId.SelectedValue Is Nothing Then
            TCTGTableAdapter1.FillByCatID(DsCanteen.tCTG, cboCatId.SelectedValue)
            Dim ctgQty As Integer = DsCanteen.tCTG.Item(0).CTG_Qty
            Dim ctgSection As Char = DsCanteen.tCTG.Item(0).CTG_Section
            cboPlacement.DisplayMember = "placement"
            cboPlacement.ValueMember = "n"
            cboPlacement.DataSource = CtgPlacementTableAdapter.GetData(ctgQty, ctgSection)
        End If
    End Sub

    Private Sub cboPlacement_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCatId.SelectedValueChanged, cboPlacement.SelectedValueChanged, cboPrinter.SelectedValueChanged
        unsavedChanges = True
    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        If lsbItems.Items.Count() > 0 Then
            If lsbItems.SelectedIndex > 0 Then
                lsbItems.SelectedIndex -= 1
            Else : lsbItems.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub btnDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.Click
        If lsbItems.Items.Count() > 0 Then
            If lsbItems.SelectedIndex < lsbItems.Items.Count - 1 Then
                lsbItems.SelectedIndex += 1
            Else : lsbItems.SelectedIndex = lsbItems.Items.Count - 1
            End If
        End If
    End Sub

End Class