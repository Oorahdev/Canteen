Public Class Bunks

    Private Sub Bunks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsCanteen.tBNK' table. You can move, or remove it, as needed.
        'Me.TBNKTableAdapter.Fill(Me.DsCanteen.tBNK)
        lsbBunks.DisplayMember = "BNK_Name"
        lsbBunks.ValueMember = "BNK_ID"
        lsbBunks.DataSource = TBNKTableAdapter.GetDataBySort()
    End Sub

    Dim ctlCurrent As TextBox
    Private Sub txbActId_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbBnkname.GotFocus
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
        If lsbBunks.SelectedIndex >= 0 Then
            lsbBunks.SelectedIndex = -1
        End If
        ClearTxbs()
        lblError.Text = ""
        unsavedChanges = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim bnkId As Integer
        Dim bnkName As String
        If Not lsbBunks.SelectedValue Is Nothing Then
            bnkId = lsbBunks.SelectedValue
        End If
        If unsavedChanges = True Then
            If CheckTxb() = True Then 'Not (txbName.Text Is Nothing Or txbNumber.Text Is Nothing Or cboPlacement.Text Is Nothing Or txbPrice.Text Is Nothing Or txbPrinter.Text Is Nothing Or txbQtyShelf.Text Is Nothing Or txbQtyUnit.Text Is Nothing Or txbReorder.Text Is Nothing) Then
                bnkName = txbBnkname.Text
                If bnkId > 0 Then
                    TBNKTableAdapter.UpdateBnk(bnkName, bnkId)
                    lblError.Text = "Item updated successfully!"
                    ClearTxbs()
                    unsavedChanges = False
                    lsbBunks.SelectedIndex = 0
                    lsbBunks.DataSource = Me.TBNKTableAdapter.GetDataBySort()
                    unsavedChanges = False
                Else : TBNKTableAdapter.InsertBnk(bnkName)
                    lblError.Text = "Item created successfully!"
                    ClearTxbs()
                    unsavedChanges = False
                    lsbBunks.DataSource = Me.TBNKTableAdapter.GetDataBySort()
                    lsbBunks.SelectedIndex = 0
                    unsavedChanges = False

                End If
            End If
        Else : lblError.Text = "No changes were made!"
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub ClearTxbs()
        txbBnkname.Text = ""
    End Sub

    Private Sub lsbBunks_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsbBunks.SelectedValueChanged
        If unsavedChanges = True Then
            Dim dialogResult As DialogResult = MsgBox("This will clear all your changes! Are you sure you would like to continue?", MsgBoxStyle.YesNo)
            If dialogResult = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else : unsavedChanges = False
            End If
        End If
        LoadCatInfo()
        lblError.Text = ""
    End Sub


    Private Sub LoadCatInfo()
        If Not lsbBunks.SelectedValue Is Nothing Then
            TBNKTableAdapter.FillByBnkId(Me.DsCanteen.tBNK, lsbBunks.SelectedValue)
            txbBnkname.Text = DsCanteen.tBNK.Item(0).BNK_Name
            unsavedChanges = False
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If lsbBunks.SelectedValue > 0 Then
            TBNKTableAdapter.DeleteByBnkId(lsbBunks.SelectedValue)
            ClearTxbs()
            lsbBunks.DataSource = Me.TBNKTableAdapter.GetDataBySort()
        End If
        unsavedChanges = False
    End Sub

    Dim unsavedChanges As Boolean = False

    Private Sub txbActId_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbBnkname.TextChanged
        unsavedChanges = True
    End Sub
    Private Function CheckTxb()
        If Not txbBnkname.Text = "" Then
            If Len(txbBnkname.Text) <> 2 Then
                lblError.Text = "Bunk Number must be 2 digits"
                Return False
            Else
                Return True
            End If
        Else
            lblError.Text = "Please enter a Name."
            Return False
        End If
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


    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        If lsbBunks.Items.Count() > 0 Then
            If lsbBunks.SelectedIndex > 0 Then
                lsbBunks.SelectedIndex -= 1
            Else : lsbBunks.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub btnDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.Click
        If lsbBunks.Items.Count() > 0 Then
            If lsbBunks.SelectedIndex < lsbBunks.Items.Count - 1 Then
                lsbBunks.SelectedIndex += 1
            Else : lsbBunks.SelectedIndex = lsbBunks.Items.Count - 1
            End If
        End If
    End Sub

End Class