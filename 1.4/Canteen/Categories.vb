Imports System.Data.SqlClient

Public Class Categories

    Private Sub Categories_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.TCTGTableAdapter.Fill(Me.DsCanteen.tCTG)
        lsbCategories.DisplayMember = "CTG_Name"
        lsbCategories.ValueMember = "CTG_ID"
        lsbCategories.DataSource = Me.TCTGTableAdapter.GetDataBySort()
        cboCatPrinter.DisplayMember = "PRF_Name"
        cboCatPrinter.ValueMember = "PRF_Name"
        cboCatPrinter.DataSource = Me.TPRFTableAdapter1.GetData()
        LoadCatInfo()
        unsavedChanges = False
    End Sub
    Dim deleting As Boolean = False
    Dim ctlCurrent As TextBox
    Private Sub txbActId_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbCatName.GotFocus, txbCatQty.GotFocus, txbCatSection.GotFocus, txbCatSort.GotFocus
        ctlCurrent = sender
    End Sub

    Private Sub AdmKeyboard1_OnKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AdmKeyboard1.OnKeyPress
        If Not ctlCurrent Is Nothing Then
            Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyPress(adm.admUtilities.TextWithSelection.FromTextBox(ctlCurrent), e)
            ctlCurrent.Text = ret.Text
            ctlCurrent.SelectionStart = ret.SelectionStart
            ctlCurrent.SelectionLength = ret.SelectionLength
        End If
    End Sub

    Public Sub AdmKeyboard1_OnKeyPressSpecial(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AdmKeyboard1.OnKeyPressSpecial
        If Not ctlCurrent Is Nothing Then
            Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyEvent(adm.admUtilities.TextWithSelection.FromTextBox(ctlCurrent), e)
            ctlCurrent.Text = ret.Text
            ctlCurrent.SelectionStart = ret.SelectionStart
            ctlCurrent.SelectionLength = ret.SelectionLength
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        If lsbCategories.SelectedIndex >= 0 Then
            lsbCategories.SelectedIndex = -1
        End If
        ClearTxbs()
        lblError.Text = ""
        unsavedChanges = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim catId As Integer
        Dim catName As String
        Dim catSection As String
        Dim catSort As Integer
        Dim catQty As Integer
        Dim catPrinter As String
        If Not lsbCategories.SelectedValue Is Nothing Then
            catId = lsbCategories.SelectedValue
        End If
        If unsavedChanges = True Then '(txbCatName.Text Is Nothing And txbCatQty.Text Is Nothing And txbCatSection.Text Is Nothing And txbCatSort.Text Is Nothing) Then
            If txbCatName.Text = "" Then
                lblError.Text = "Category Name required!"
                Exit Sub
            Else
                catName = txbCatName.Text
            End If
            If txbCatSection.Text = "" Then
                lblError.Text = "Section Required!"
                Exit Sub
            Else
                catSection = txbCatSection.Text
            End If
            If txbCatQty.Text = "" Then
                lblError.Text = "Qty Required!"
                Exit Sub
            Else
                catQty = txbCatQty.Text
            End If
            If txbCatSort.Text = "" Then
                lblError.Text = "Sort Required!"
                Exit Sub
            Else
                catSort = txbCatSort.Text
            End If
            If cboCatPrinter.SelectedValue = "" Then
                lblError.Text = "Printer Required!"
                Exit Sub
            Else
                catPrinter = cboCatPrinter.SelectedValue
            End If
            'usrActId = CInt(Me.txbActId.Text)
            If catId > 0 Then
                TCTGTableAdapter.UpdateCat(catName, catSection, catQty, catSort, catPrinter, catId)
                lblError.Text = "Category updated successfully :)"
                unsavedChanges = False
                lsbCategories.DataSource = Me.TCTGTableAdapter.GetDataBySort()
                lsbCategories.SelectedIndex = 0
                unsavedChanges = False
            Else : TCTGTableAdapter.InsertCat(catName, catSection, catQty, catSort, catPrinter)
                lblError.Text = "Category created successfully :)"
                ClearTxbs()
                unsavedChanges = False
                lsbCategories.DataSource = Me.TCTGTableAdapter.GetDataBySort()
                lsbCategories.SelectedIndex = 0
                unsavedChanges = False
                'Load lsbCategories and selectedvalue = new user
            End If
        Else : lblError.Text = "No Changes Made."
        End If
        'Try
        '    Me.TCTGBindingSource.EndEdit()
        '    Me.TCTGTableAdapter.Update(DsCanteen.TCTG)
        '    DsCanteen.TCTG.AcceptChanges()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

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

    'Private Sub TCTGBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles TCTGBindingSource.AddingNew
    '    Dim dr As dsCanteen.TCTGRow = DsCanteen.TCTG.NewTCTGRow
    '    dr.BeginEdit()
    '    dr("USR_DateEntered") = Now
    '    dr.EndEdit()
    '    e.NewObject = dr
    'End Sub

    'Private Sub TCTGBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TCTGBindingSource.CurrentChanged
    '    If Me.TCTGBindingSource.Current.GetType Is GetType(DataRowView) Then
    '        Dim dr As DataRowView = Me.TCTGBindingSource.Current
    '        Dim usr As dsCanteen.TCTGRow = dr.Row
    '        Me.txbActId.Text = usr.USR_ACT_ID
    '        Me.txbPassword.Text = usr.USR_Password
    '        Me.txbConfirm.Text = usr.USR_Password
    '        Me.txbUsrName.Text = usr.USR_Login
    '    End If
    'End Sub

    Private Sub ClearTxbs()
        txbCatName.Text = ""
        txbCatQty.Text = ""
        txbCatSection.Text = ""
        txbCatSort.Text = ""
        cboCatPrinter.SelectedIndex = -1
    End Sub

    Dim lsbSelectedIndex As Integer = 0

    Private Sub lsbCategories_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsbCategories.SelectedIndexChanged
        If unsavedChanges = True AndAlso deleting = False Then
            Dim dialogResult As DialogResult = MsgBox("This will clear all your changes! Are you sure you would like to continue?", MsgBoxStyle.YesNo)
            If dialogResult = Windows.Forms.DialogResult.No Then
                ' unsavedChanges = False
                lsbCategories.SelectedIndex = lsbSelectedIndex
                Exit Sub
            Else : unsavedChanges = False
            End If
        End If
        LoadCatInfo()
        lblError.Text = ""
        lsbSelectedIndex = lsbCategories.SelectedIndex
    End Sub


    Private Sub LoadCatInfo()
        If Not lsbCategories.SelectedValue Is Nothing Then
            TCTGTableAdapter.FillByCatID(Me.DsCanteen.tCTG, lsbCategories.SelectedValue)
            txbCatName.Text = DsCanteen.tCTG.Item(0).CTG_Name
            txbCatQty.Text = DsCanteen.tCTG.Item(0).CTG_Qty
            txbCatSection.Text = DsCanteen.tCTG.Item(0).CTG_Section
            txbCatSort.Text = DsCanteen.tCTG.Item(0).CTG_Sort
            If Not DsCanteen.tCTG.Item(0).IsCTG_PrinterNull Then
                cboCatPrinter.SelectedValue = DsCanteen.tCTG.Item(0).CTG_Printer
            Else
                cboCatPrinter.SelectedIndex = -1
            End If
        End If
        unsavedChanges = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        unsavedChanges = False
        If lsbCategories.SelectedValue > 0 Then
            If hasItemsRelated(lsbCategories.SelectedValue) Then
                MsgBox("There are items related to this category. Delete the items if you wish to delete the category.")
            Else
                deleting = True
                TCTGTableAdapter.DeleteByCatId(lsbCategories.SelectedValue)
                ClearTxbs()
                lsbCategories.DataSource = Me.TCTGTableAdapter.GetDataBySort()
                deleting = False
            End If
        End If
    End Sub

    Private Function hasItemsRelated(ctgId As Integer) As Boolean
        Dim connection As New SqlConnection(My.Settings.CanteenConnectionString)
        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("select itm_name from itm where itm_ctg_id=" + ctgId.ToString(), connection)
        Dim result = cmd.ExecuteScalar()
        If (result) Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Dim unsavedChanges As Boolean = False

    Private Sub txbActId_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbCatName.TextChanged, txbCatQty.TextChanged, txbCatSection.TextChanged, txbCatSort.TextChanged, cboCatPrinter.SelectedValueChanged
        unsavedChanges = True
    End Sub


    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        If lsbCategories.Items.Count() > 0 Then
            If lsbCategories.SelectedIndex > 0 Then
                lsbCategories.SelectedIndex -= 1
            Else : lsbCategories.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub btnDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.Click
        If lsbCategories.Items.Count() > 0 Then
            If lsbCategories.SelectedIndex < lsbCategories.Items.Count - 1 Then
                lsbCategories.SelectedIndex += 1
            Else : lsbCategories.SelectedIndex = lsbCategories.Items.Count - 1
            End If
        End If
    End Sub
End Class