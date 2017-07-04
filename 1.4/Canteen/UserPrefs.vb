Public Class UserPrefs

    Private Sub UserPrefs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsbPrefs.DisplayMember = "PRF_Name"
        lsbPrefs.ValueMember = "PRF_Name"
        lsbPrefs.DataSource = Me.TPRFTableAdapter.GetData()
        cboUsrId.DisplayMember = "USR_Login"
        cboUsrId.ValueMember = "USR_ID"
        cboUsrId.DataSource = Me.TUSRTableAdapter1.GetData()
        LoadPrfInfo()
        lsbPrefs.SelectedIndex = 0
    End Sub

    Dim ctlCurrent As TextBox
    Private Sub txbActId_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbName.GotFocus, txbValue.GotFocus
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
        If lsbPrefs.SelectedIndex >= 0 Then
            lsbPrefs.SelectedIndex = -1
        End If
        ClearTxbs()
        lblError.Text = ""
        unsavedChanges = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim prfName As String
        Dim prfValue As String
        Dim prfUsrId As Integer
        If Not lsbPrefs.SelectedValue Is Nothing Then
            prfName = lsbPrefs.SelectedValue
        End If
        If CheckTxb() = True Then 'Not (txbName.Text Is Nothing Or txbNumber.Text Is Nothing Or cboPlacement.Text Is Nothing Or txbPrice.Text Is Nothing Or txbPrinter.Text Is Nothing Or txbQtyShelf.Text Is Nothing Or txbQtyUnit.Text Is Nothing Or txbReorder.Text Is Nothing) Then
            prfName = txbName.Text
            prfValue = txbValue.Text
            If Not cboUsrId.SelectedValue Is Nothing Then
                prfUsrId = cboUsrId.SelectedValue
            End If
            If Not prfName Is Nothing Then
                TPRFTableAdapter.UpdatePrf(prfName, prfValue, prfUsrId)
                lblError.Text = "Pref updated successfully!"
                ClearTxbs()
                unsavedChanges = False
                lsbPrefs.SelectedIndex = 0
                lsbPrefs.DataSource = Me.TPRFTableAdapter.GetData()
                cboUsrId.DataSource = Me.TUSRTableAdapter1.GetData()
                LoadPrfInfo()
                unsavedChanges = False
            Else : TPRFTableAdapter.InsertPrf(prfName, prfValue, prfUsrId)
                lblError.Text = "Pref created successfully!"
                ClearTxbs()
                unsavedChanges = False
                lsbPrefs.DataSource = Me.TPRFTableAdapter.GetData()
                cboUsrId.DataSource = Me.TUSRTableAdapter1.GetData()
                lsbPrefs.SelectedIndex = 0
                unsavedChanges = False
                'Load lsbPrefs and selectedvalue = new user
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub ClearTxbs()
        txbName.Text = ""
        txbValue.Text = ""
        cboUsrId.SelectedIndex = -1
    End Sub




    Private Sub LoadPrfInfo()
        If Not lsbPrefs.SelectedValue Is Nothing Then
            TPRFTableAdapter.FillByPrfName(Me.DsCanteen.tPRF, lsbPrefs.SelectedValue)
            txbName.Text = DsCanteen.tPRF.Item(0).PRF_Name
            If Not DsCanteen.tPRF.Item(0).IsPRF_ValueNull Then
                txbValue.Text = DsCanteen.tPRF.Item(0).PRF_Value
            Else : txbValue.Text = ""
            End If
            If Not DsCanteen.tPRF.Item(0).IsPRF_USR_IDNull Then
                cboUsrId.SelectedValue = DsCanteen.tPRF.Item(0).PRF_USR_ID
            Else
                cboUsrId.SelectedIndex = -1
            End If
            'cbouser()
            'If Not cboUsrId.SelectedValue Is Nothing Then
            '    cboUsrId.SelectedValue = DsCanteen.tUSR.Item(0).USR_ID
            'End If
            unsavedChanges = False
        End If
    End Sub



    Dim unsavedChanges As Boolean = False

    Private Sub txbActId_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbName.TextChanged, txbValue.TextChanged
        unsavedChanges = True
    End Sub
    Private Function CheckTxb()
        If Not txbName.Text = "" Then
            'If Not txbValue.Text = "" Then
            '    'If Not cboUsrId.SelectedValue Is Nothing Then
            '    '    Return True
            '    'Else : lblError.Text = "Please select a User Id."
            'Else : lblError.Text = "Please enter a Value."
            '    Return False
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

    Private Sub lsbPrefs_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsbPrefs.SelectedValueChanged
        LoadPrfInfo()
        lblError.Text = ""
    End Sub
End Class