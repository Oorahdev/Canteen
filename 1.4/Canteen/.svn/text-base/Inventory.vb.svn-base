Public Class Inventory

    Dim ctlCurrent As TextBox
    Dim unsavedChanges As Boolean = False
    Private Sub txbName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles stockCaseUpdate.GotFocus, stockItemsUpdate.GotFocus, shelfUpdate.GotFocus
        ctlCurrent = sender
    End Sub


    Private Sub AdmKeyboard1_OnKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AdmKeypad1.OnKeyPress
        If Not ctlCurrent Is Nothing Then
            Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyPress(adm.admUtilities.TextWithSelection.FromTextBox(ctlCurrent), e)
            ctlCurrent.Text = ret.Text
            ctlCurrent.SelectionStart = ret.SelectionStart
            ctlCurrent.SelectionLength = ret.SelectionLength
        End If

    End Sub

    Public Sub AdmKeyboard1_OnKeyPressSpecial(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AdmKeypad1.OnKeyPressSpecial
        If Not ctlCurrent Is Nothing Then
            Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyEvent(adm.admUtilities.TextWithSelection.FromTextBox(ctlCurrent), e)
            ctlCurrent.Text = ret.Text
            ctlCurrent.SelectionStart = ret.SelectionStart
            ctlCurrent.SelectionLength = ret.SelectionLength
        End If
    End Sub

    Private Sub Inventory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If unsavedChanges = True Then
            Dim dialogResult As DialogResult = MsgBox("This will clear all your changes! Are you sure you would like to continue?", MsgBoxStyle.YesNo)
            If dialogResult = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else : unsavedChanges = False
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        End If
    End Sub

    Private Sub Inventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsCanteen.tINV' table. You can move, or remove it, as needed.
        TITMTableAdapter.Fill(Me.DsCanteen.tITM)
        TITMListBox.ValueMember = "ITM_ID"
        TITMListBox.DisplayMember = "ITM_Name"
        TITMListBox.DataSource = TITMTableAdapter.GetDataBySort()
        unsavedChanges = False
        'TODO: This line of code loads data into the 'DsCanteen.tITM' table. You can move, or remove it, as needed.
    End Sub
    Dim lsbSelectedIndex As Integer = 0
    Private Sub TITMListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TITMListBox.SelectedIndexChanged
        If unsavedChanges = True Then
            Dim dialogResult As DialogResult = MsgBox("This will clear all your changes! Are you sure you would like to continue?", MsgBoxStyle.YesNo)
            If dialogResult = Windows.Forms.DialogResult.No Then
                TITMListBox.SelectedIndex = lsbSelectedIndex
                Exit Sub
            Else : unsavedChanges = False
            End If
        End If
        Dim itemId As Integer = TITMListBox.SelectedValue
        TINVTableAdapter.FillBy(Me.DsCanteen.tINV, itemId)
        If Not INV_QtyStockRoom.Text = "" Then
            If Not DsCanteen.tITM.FindByITM_ID(itemId) Is Nothing Then
                INV_QtyStockRoomCase.Text = Math.Round(INV_QtyStockRoom.Text / DsCanteen.tITM.FindByITM_ID(itemId).ITM_QtyPerUnit, 2)
                unsavedChanges = False
            Else
                INV_QtyStockRoomCase.Text = ""
            End If
        Else
            INV_QtyStockRoom.Text = 0
            INV_QtyStockRoomCase.Text = 0
            INV_QtyShelfTextBox.Text = 0
        End If
        unsavedChanges = False
        lsbSelectedIndex = TITMListBox.SelectedIndex
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Dim newShelfAmount As Integer
        'Dim newcaseamount As Decimal
        Dim newItemID As Integer = 0
        If Not shelfUpdate.Text = "" Then
            Select Case Me.ComboBox1.Text
                Case "+"
                    If Not INV_IDTextBox.Text = "" Then
                        'newShelfAmount = INV_QtyShelfTextBox.Text + shelfUpdate.Text
                        newItemID = INV_ITM_IDTextBox.Text
                        QueriesTableAdapter1.UpdateStockShelf(newItemID, shelfUpdate.Text, 0, "Shelf", "Inventory", usrId)
                    Else
                        newItemID = TINVTableAdapter.Insert(TITMListBox.SelectedValue, shelfUpdate.Text, 0, usrId, Now(), New Nullable(Of Integer), New Nullable(Of Date), 0, New Nullable(Of Date))
                        QueriesTableAdapter1.UpdateStockShelf(newItemID, shelfUpdate.Text, 0, "Shelf", "Inventory", usrId)
                    End If
                Case "-"
                    If Not INV_IDTextBox.Text = "" Then
                        ' newShelfAmount = INV_QtyShelfTextBox.Text - shelfUpdate.Text
                        newItemID = INV_ITM_IDTextBox.Text
                        QueriesTableAdapter1.UpdateStockShelf(newItemID, -shelfUpdate.Text, 0, "Shelf", "Inventory", usrId)
                    Else
                        newItemID = TINVTableAdapter.Insert(TITMListBox.SelectedValue, -shelfUpdate.Text, 0, usrId, Now(), New Nullable(Of Integer), New Nullable(Of Date), 0, New Nullable(Of Date))
                        QueriesTableAdapter1.UpdateStockShelf(newItemID, -shelfUpdate.Text, 0, "Shelf", "Inventory", usrId)
                    End If
            End Select
            'Else
            'newShelfAmount = INV_QtyShelfTextBox.Text
        End If
        'Dim newStockAmount As Integer
        If Me.rbCases.Checked = True Then
            Dim qtyPerUnit As Integer = DsCanteen.tITM.FindByITM_ID(TITMListBox.SelectedValue).ITM_QtyPerUnit
            Dim caseAmount As Integer
            If Not stockCaseUpdate.Text = "" Then
                caseAmount = stockCaseUpdate.Text * qtyPerUnit
                Select Case Me.ComboBox2.Text
                    Case "+"
                        If Not newItemID = 0 Then
                            'newcaseamount = Format(INV_QtyStockRoomCase.Text, "D") + stockCaseUpdate.Text
                            'newStockAmount = newcaseamount * qtyPerUnit
                            QueriesTableAdapter1.UpdateStockShelf(newItemID, 0, caseAmount, "Stock", "Inventory", usrId)
                            Exit Select
                        ElseIf Not INV_ITM_IDTextBox.Text = "" Then
                            QueriesTableAdapter1.UpdateStockShelf(INV_ITM_IDTextBox.Text, 0, caseAmount, "Stock", "Inventory", usrId)
                            Exit Select
                        Else
                            newItemID = TINVTableAdapter.Insert(TITMListBox.SelectedValue, 0, caseAmount, usrId, Now(), New Nullable(Of Integer), New Nullable(Of Date), 0, New Nullable(Of Date))
                            QueriesTableAdapter1.UpdateStockShelf(newItemID, 0, caseAmount, "Stock", "Inventory", usrId)
                        End If
                    Case "-"
                        If Not newItemID = 0 Then
                            'newcaseamount = Format(INV_QtyStockRoomCase.Text, "D") + stockCaseUpdate.Text
                            'newStockAmount = newcaseamount * qtyPerUnit
                            QueriesTableAdapter1.UpdateStockShelf(newItemID, 0, -caseAmount, "Stock", "Inventory", usrId)
                            Exit Select
                        ElseIf Not INV_ITM_IDTextBox.Text = "" Then
                            QueriesTableAdapter1.UpdateStockShelf(INV_ITM_IDTextBox.Text, 0, -caseAmount, "Stock", "Inventory", usrId)
                            Exit Select
                        Else
                            newItemID = TINVTableAdapter.Insert(TITMListBox.SelectedValue, 0, -caseAmount, usrId, Now(), New Nullable(Of Integer), New Nullable(Of Date), 0, New Nullable(Of Date))
                            QueriesTableAdapter1.UpdateStockShelf(newItemID, 0, -caseAmount, "Stock", "Inventory", usrId)
                        End If
                End Select
                'Else
                '    newcaseamount = INV_QtyStockRoomCase.Text
                '    newStockAmount = INV_QtyStockRoom.Text
            End If
        ElseIf Me.rbItems.Checked = True Then
            If Not stockItemsUpdate.Text = "" Then
                Select Case Me.ComboBox3.Text
                    Case "+"
                        'newStockAmount = INV_QtyStockRoom.Text + stockItemsUpdate.Text
                        If Not newItemID = 0 Then
                            'newcaseamount = Format(INV_QtyStockRoomCase.Text, "D") + stockCaseUpdate.Text
                            'newStockAmount = newcaseamount * qtyPerUnit
                            QueriesTableAdapter1.UpdateStockShelf(newItemID, 0, stockItemsUpdate.Text, "Stock", "Inventory", usrId)
                            Exit Select
                        ElseIf Not INV_ITM_IDTextBox.Text = "" Then
                            QueriesTableAdapter1.UpdateStockShelf(INV_ITM_IDTextBox.Text, 0, stockItemsUpdate.Text, "Stock", "Inventory", usrId)
                            Exit Select
                        Else
                            newItemID = TINVTableAdapter.Insert(TITMListBox.SelectedValue, 0, stockItemsUpdate.Text, usrId, Now(), New Nullable(Of Integer), New Nullable(Of Date), 0, New Nullable(Of Date))
                            QueriesTableAdapter1.UpdateStockShelf(newItemID, 0, stockItemsUpdate.Text, "Stock", "Inventory", usrId)
                        End If
                    Case "-"
                        'newStockAmount = INV_QtyStockRoom.Text - stockItemsUpdate.Text
                        If Not newItemID = 0 Then
                            'newcaseamount = Format(INV_QtyStockRoomCase.Text, "D") + stockCaseUpdate.Text
                            'newStockAmount = newcaseamount * qtyPerUnit
                            QueriesTableAdapter1.UpdateStockShelf(newItemID, 0, -stockItemsUpdate.Text, "Stock", "Inventory", usrId)
                            Exit Select
                        ElseIf Not INV_ITM_IDTextBox.Text = "" Then
                            QueriesTableAdapter1.UpdateStockShelf(INV_ITM_IDTextBox.Text, 0, -stockItemsUpdate.Text, "Stock", "Inventory", usrId)
                            Exit Select
                        Else
                            newItemID = TINVTableAdapter.Insert(TITMListBox.SelectedValue, 0, -stockItemsUpdate.Text, usrId, Now(), New Nullable(Of Integer), New Nullable(Of Date), 0, New Nullable(Of Date))
                            QueriesTableAdapter1.UpdateStockShelf(newItemID, 0, -stockItemsUpdate.Text, "Stock", "Inventory", usrId)
                        End If
                End Select
                'Else
                '    newStockAmount = INV_QtyStockRoom.Text
            End If
        End If
        'If INV_IDTextBox.Text = "" Then
        '    If TINVTableAdapter.Insert(TITMListBox.SelectedValue, newShelfAmount, newStockAmount, usrid, Now(), New Nullable(Of Integer), New Nullable(Of Date), 0, New Nullable(Of Date)) > 0 Then
        '        TINVTableAdapter.FillBy(Me.DsCanteen.tINV, TITMListBox.SelectedValue)
        '        If Not DsCanteen.tITM.FindByITM_ID(TITMListBox.SelectedValue) Is Nothing Then
        '            INV_QtyStockRoomCase.Text = Math.Round(INV_QtyStockRoom.Text / DsCanteen.tITM.FindByITM_ID(TITMListBox.SelectedValue).ITM_QtyPerUnit, 2)
        '            unsavedChanges = False
        '        Else
        '            INV_QtyStockRoomCase.Text = ""
        '        End If
        '        unsavedChanges = False
        '    End If
        'Else
        '    QueriesTableAdapter1.UpdateStockShelf(TITMListBox.SelectedValue, newshelf
        '    If TINVTableAdapter.Update(TITMListBox.SelectedValue, newShelfAmount, newStockAmount, DsCanteen.tINV.FindByINV_ID(INV_IDTextBox.Text).INV_EnteredBy, DsCanteen.tINV.FindByINV_ID(INV_IDTextBox.Text).INV_DateEntered, usrid, Now, 0, New Nullable(Of Date), INV_IDTextBox.Text) > 0 Then
        '        TINVTableAdapter.FillBy(Me.DsCanteen.tINV, TITMListBox.SelectedValue)
        '        If Not DsCanteen.tITM.FindByITM_ID(TITMListBox.SelectedValue) Is Nothing Then
        '            INV_QtyStockRoomCase.Text = Math.Round(INV_QtyStockRoom.Text / DsCanteen.tITM.FindByITM_ID(TITMListBox.SelectedValue).ITM_QtyPerUnit, 2)
        '            unsavedChanges = False
        '        Else
        '            INV_QtyStockRoomCase.Text = ""
        '        End If
        '        unsavedChanges = False
        '    End If
        'End If
        shelfUpdate.Text = ""
        stockCaseUpdate.Text = ""
        stockItemsUpdate.Text = ""
        Me.ComboBox3.SelectedIndex = -1
        Me.ComboBox2.SelectedIndex = -1
        Me.ComboBox1.SelectedIndex = -1
        Me.ComboBox1.Text = ""
        Me.ComboBox2.Text = ""
        Me.ComboBox3.Text = ""
        TITMListBox.DataSource = TITMTableAdapter.GetDataBySort()
        unsavedChanges = False
        'newShelfAmount = 0
        'newStockAmount = 0
        'newcaseamount = 0
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Not INV_IDTextBox.Text = "" Then
            If MsgBox("Are you sure you would like to delete?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If TINVTableAdapter.Delete(INV_IDTextBox.Text) > 0 Then
                    TINVTableAdapter.FillBy(Me.DsCanteen.tINV, TITMListBox.SelectedValue)
                    INV_QtyStockRoom.Text = 0
                    INV_QtyStockRoomCase.Text = 0
                    INV_QtyShelfTextBox.Text = 0
                    unsavedChanges = False
                End If
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub INV_QtyShelfTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles INV_QtyShelfTextBox.TextChanged, INV_QtyStockRoomCase.TextChanged
        unsavedChanges = True
    End Sub


    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        If TITMListBox.Items.Count() > 0 Then
            If TITMListBox.SelectedIndex > 0 Then
                TITMListBox.SelectedIndex -= 1
            Else : TITMListBox.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub btnDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.Click
        If TITMListBox.Items.Count() > 0 Then
            If TITMListBox.SelectedIndex < TITMListBox.Items.Count - 1 Then
                TITMListBox.SelectedIndex += 1
            Else : TITMListBox.SelectedIndex = TITMListBox.Items.Count - 1
            End If
        End If
    End Sub


End Class