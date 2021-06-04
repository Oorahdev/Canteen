Imports System.Data.SqlClient

Public Class Positions

    Private Sub Positions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsCanteen.tPSN' table. You can move, or remove it, as needed.
        'Me.TPSNTableAdapter.Fill(Me.DsCanteen.tPSN)
        lsbPositions.DisplayMember = "PSN_Name"
        lsbPositions.ValueMember = "PSN_ID"
        lsbPositions.DataSource = Me.TPSNTableAdapter.GetData()
        unsavedChanges = False

    End Sub
    Dim deleting As Boolean = False
    Dim ctlCurrent As TextBox
    Private Sub txbName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbName.GotFocus, txbSort.GotFocus, txbCreditLimit.GotFocus
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

        If lsbPositions.SelectedIndex >= 0 Then
            lsbPositions.SelectedIndex = -1
        End If
        ClearTxbs()
        lblError.Text = ""
        unsavedChanges = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim psnId As Integer
        Dim psnName As String
        Dim psnSort As Integer
        Dim psnCreditLimit As Decimal
        If Not lsbPositions.SelectedValue Is Nothing Then
            psnId = lsbPositions.SelectedValue
        End If
        If unsavedChanges = True Then '(txbCatName.Text Is Nothing And txbCatQty.Text Is Nothing And txbCatSection.Text Is Nothing And txbCatSort.Text Is Nothing) Then
            If txbName.Text = "" Then
                lblError.Text = "Name required!"
                Exit Sub
            Else
                psnName = txbName.Text
            End If
            If txbSort.Text = "" Then
                psnSort = 0
            Else
                psnSort = txbSort.Text
            End If
            If Not txbCreditLimit.Text = "" Then
                psnCreditLimit = FormatCurrency(txbCreditLimit.Text)
            End If
            'usrActId = CInt(Me.txbActId.Text)
            If psnId > 0 Then
                TPSNTableAdapter.UpdatePsn(psnName, psnSort, psnCreditLimit, psnId)
                TACTTableAdapter1.UpdateCreditLimit(psnCreditLimit, psnId)
                lblError.Text = "Position updated successfully :)"
                ClearTxbs()
                unsavedChanges = False
                lsbPositions.SelectedIndex = 0
                lsbPositions.DataSource = Me.TPSNTableAdapter.GetData()
                unsavedChanges = False
            Else
                TPSNTableAdapter.InsertPsn(psnName, psnSort, psnCreditLimit)

                lblError.Text = "Position created successfully :)"
                ClearTxbs()
                unsavedChanges = False
                lsbPositions.DataSource = Me.TPSNTableAdapter.GetData()
                lsbPositions.SelectedIndex = 0
                unsavedChanges = False
                'Load lsbPositions and selectedvalue = new user
            End If
        Else : lblError.Text = "You must enter all information."
        End If
        'Try
        '    Me.TPSNBindingSource.EndEdit()
        '    Me.TPSNTableAdapter.Update(DsCanteen.TPSN)
        '    DsCanteen.TPSN.AcceptChanges()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    'Private Sub TPSNBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles TPSNBindingSource.AddingNew
    '    Dim dr As dsCanteen.TPSNRow = DsCanteen.TPSN.NewTPSNRow
    '    dr.BeginEdit()
    '    dr("USR_DateEntered") = Now
    '    dr.EndEdit()
    '    e.NewObject = dr
    'End Sub

    'Private Sub TPSNBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TPSNBindingSource.CurrentChanged
    '    If Me.TPSNBindingSource.Current.GetType Is GetType(DataRowView) Then
    '        Dim dr As DataRowView = Me.TPSNBindingSource.Current
    '        Dim usr As dsCanteen.TPSNRow = dr.Row
    '        Me.txbActId.Text = usr.USR_ACT_ID
    '        Me.txbPassword.Text = usr.USR_Password
    '        Me.txbConfirm.Text = usr.USR_Password
    '        Me.txbUsrName.Text = usr.USR_Login
    '    End If
    'End Sub

    Private Sub ClearTxbs()
        txbName.Text = ""
        txbSort.Text = ""
        txbCreditLimit.Text = ""
    End Sub
    Dim lsbSelectedIndex As Integer = 0
    Private Sub lsbPositions_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsbPositions.SelectedIndexChanged
        If unsavedChanges = True AndAlso deleting = False Then
            Dim dialogResult As DialogResult = MsgBox("This will clear all your changes! Are you sure you would like to continue?", MsgBoxStyle.YesNo)
            If dialogResult = Windows.Forms.DialogResult.No Then
                lsbPositions.SelectedIndex = lsbSelectedIndex
                Exit Sub
            Else : unsavedChanges = False
            End If

        End If
        LoadPsnInfo()
        lblError.Text = ""
        lsbSelectedIndex = lsbPositions.SelectedIndex
    End Sub


    Private Sub LoadPsnInfo()
        If Not lsbPositions.SelectedValue Is Nothing Then
            TPSNTableAdapter.FillByPsnId(Me.DsCanteen.tPSN, lsbPositions.SelectedValue)
            txbName.Text = DsCanteen.tPSN.Item(0).PSN_Name
            txbSort.Text = DsCanteen.tPSN.Item(0).PSN_Sort
            If Not DsCanteen.tPSN.Item(0).IsPSN_CreditLimitNull Then
                txbCreditLimit.Text = FormatCurrency(DsCanteen.tPSN.Item(0).PSN_CreditLimit)
            Else
                txbCreditLimit.Text = ""
            End If
            unsavedChanges = False
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        unsavedChanges = False
        deleting = True
        If lsbPositions.SelectedValue > 0 Then
            If hasActsRelated(lsbPositions.SelectedValue) Then
                MsgBox("There are accounts linked to this position. It cannot be deleted.")
            Else
                TPSNTableAdapter.DeleteByPsnId(lsbPositions.SelectedValue)
                ClearTxbs()
                lsbPositions.DataSource = Me.TPSNTableAdapter.GetData()
            End If
        End If
    End Sub

    Private Function hasActsRelated(psnId As Integer) As Boolean
        Dim connection As New SqlConnection(My.Settings.CanteenConnectionString)
        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("select * from act where ACT_PSN_ID=" + psnId.ToString(), connection)
        Dim result = cmd.ExecuteScalar()
        If (result) Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Dim unsavedChanges As Boolean = False

    Private Sub txbActId_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbName.TextChanged, txbSort.TextChanged, txbCreditLimit.TextChanged
        unsavedChanges = True
    End Sub

    Private Sub Items_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If unsavedChanges = True AndAlso deleting = False Then
            Dim dialogResult As DialogResult = MsgBox("This will clear all your changes! Are you sure you would like to continue?", MsgBoxStyle.YesNo)
            If dialogResult = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else : unsavedChanges = False
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        End If
    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        If lsbPositions.Items.Count() > 0 Then
            If lsbPositions.SelectedIndex > 0 Then
                lsbPositions.SelectedIndex -= 1
            Else : lsbPositions.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub btnDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.Click
        If lsbPositions.Items.Count() > 0 Then
            If lsbPositions.SelectedIndex < lsbPositions.Items.Count - 1 Then
                lsbPositions.SelectedIndex += 1
            Else : lsbPositions.SelectedIndex = lsbPositions.Items.Count - 1
            End If
        End If
    End Sub

End Class