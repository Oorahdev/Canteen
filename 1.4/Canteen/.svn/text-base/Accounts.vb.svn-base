Imports System.IO
Imports System.Data.SqlClient

Public Class Accounts

    Private boolLoading As Boolean = False

    Private Sub Accounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsCanteen.tACT' table. You can move, or remove it, as needed.
        'Me.TACTTableAdapter.Fill(Me.DsCanteen.tACT)
        boolLoading = True
        lsbAccounts.DisplayMember = "ACT_FullName"
        lsbAccounts.ValueMember = "ACT_ID"
        lsbAccounts.DataSource = Me.ActDisplayTableAdapter1.GetDataBy(searchAct.Text)
        cboPsnId.DisplayMember = "PSN_Name"
        cboPsnId.ValueMember = "PSN_ID"
        cboPsnId.DataSource = Me.TPSNTableAdapter1.GetDataBySort()
        cboBnkId.DisplayMember = "BNK_Name"
        cboBnkId.ValueMember = "BNK_ID"
        cboBnkId.DataSource = Me.TBNKTableAdapter1.GetDataBySort()
        LoadActInfo()
        lsbAccounts.SelectedIndex = 0
        Me.btnSave.Enabled = False
        boolLoading = False
    End Sub

    Dim ctlCurrent As TextBox
    Private Sub txbActId_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbFName.GotFocus, txbLName.GotFocus, txbNumber.GotFocus, txbCredit.GotFocus, txbSpending.GotFocus, txbStatus.GotFocus 'txbAmountLeft.GotFocus,
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



    'Private Function CheckTxb()
    '    If Not txbFName.Text = "" Then
    '        If Not txbLName.Text = "" Then
    '            If Not cldStartDate.Value = Now Then
    '                If IsNumeric(txbCredit.Text) And Not txbCredit.Text = "" Then
    '                    If IsNumeric(txbSpending.Text) And Not txbSpending.Text = "" Then
    '                        If IsNumeric(txbBalance.Text) And Not txbBalance.Text = "" Then
    '                            ' If IsNumeric(txbAmountLeft.Text) And Not txbAmountLeft.Text = "" Then
    '                            Return True
    '                            ' Else : lblError.Text = "Please enter an Amount left to spend."
    '                            'Return False
    '                        End If
    '                    Else : lblError.Text = "Please enter a Balance Amount."
    '                        Return False
    '                    End If
    '                Else : lblError.Text = "Please enter a Spending Limit."
    '                    Return False
    '                End If
    '            Else : lblError.Text = "Please enter a Credit Limit."
    '                Return False
    '            End If
    '        Else : lblError.Text = "Please enter a Start Date."
    '            Return False
    '        End If
    '    Else : lblError.Text = "Please enter a Last Name."
    '        Return False
    '    End If
    '    Else : lblError.Text = "Please enter a First Name."
    '    Return False
    '    End If
    '    Return True
    'End Function

    Private Sub LoadActInfo()
        If Not lsbAccounts.SelectedValue Is Nothing Then
            TACTTableAdapter.FillByActId(Me.DsCanteen.tACT, lsbAccounts.SelectedValue)
            actId = DsCanteen.tACT.Item(0).ACT_ID
            txbNumber.ReadOnly = True
            txbNumber.Text = DsCanteen.tACT.Item(0).ACT_Number
            txbFName.Text = DsCanteen.tACT.Item(0).ACT_FirstName
            txbLName.Text = DsCanteen.tACT.Item(0).ACT_LastName
            If Not DsCanteen.tACT.Item(0).IsACT_PSN_IDNull Then
                cboPsnId.SelectedValue = DsCanteen.tACT(0).ACT_PSN_ID
            Else : cboPsnId.SelectedIndex = -1
            End If
            If Not DsCanteen.tACT(0).IsACT_BNK_IDNull Then
                cboBnkId.SelectedValue = DsCanteen.tACT(0).ACT_BNK_ID
            Else : cboBnkId.SelectedIndex = -1
            End If
            If Not DsCanteen.tACT.Item(0).IsACT_PictureNull Then
                txbPhoto.Text = "Account Photo"
            Else : txbPhoto.Text = ""
            End If
            ''cboPlacement.DataSource = AvailableCtgPlacementTableAdapter.GetData()
            '' cboPlacement.Text = DsCanteen.tACT.Item(0).ACT_Placement
            If Not DsCanteen.tACT(0).IsACT_CreditLimitNull Then
                txbCredit.Text = DsCanteen.tACT.Item(0).ACT_CreditLimit
                txbCredit.Text = String.Format("{0:C2}", Val(txbCredit.Text))
            Else
                txbCredit.Text = ""
            End If
            If Not DsCanteen.tACT(0).IsACT_SpendingLimitNull Then
                txbSpending.Text = DsCanteen.tACT.Item(0).ACT_SpendingLimit
                txbSpending.Text = String.Format("{0:C2}", Val(txbSpending.Text))
            Else
                txbSpending.Text = ""
            End If
            'txbBalance.Text = DsCanteen.tACT.Item(0).ACT_Balance
            'txbBalance.Text = String.Format("{0:C2}", Val(txbBalance.Text))
            'If Not DsCanteen.tACT(0).IsACT_AmountLeftNull Then
            '    txbAmountLeft.Text = DsCanteen.tACT.Item(0).ACT_AmountLeft

            'End If
            'txbAmountLeft.Text = String.Format("{0:C2}", Val(txbAmountLeft.Text))
            cldStartDate.Value = DsCanteen.tACT.Item(0).ACT_StartDate
            If Not DsCanteen.tACT(0).IsACT_StatusNull Then
                txbStatus.Text = DsCanteen.tACT.Item(0).ACT_Status
            Else
                txbStatus.Text = ""
            End If
            btnSave.Enabled = False
        End If
    End Sub

    Dim actPhoto As Image

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim browseDialog As New OpenFileDialog
        browseDialog.Title = "Browse"
        'browseDialog.ShowDialog()
        With browseDialog
            .InitialDirectory = "C:\"
            .Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
            .FilterIndex = 4
        End With
        If browseDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txbPhoto.Text = browseDialog.FileName '.ToString()
            If browseDialog.FileName = "" Then
                txbPhoto.Text = ""
            End If
        End If

    End Sub

    'Private Sub btnBrows_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
    '    Try
    '        If Trim(txbPhoto.Text) = "" Then
    '            MsgBox("Please select an image.")
    '            Exit Sub
    '        End If

    '        Dim fs As New FileStream(Trim(txbPhoto.Text), FileMode.Open)
    '        Dim Data() As Byte = New [Byte](fs.Length) {}
    '        fs.Read(Data, 0, fs.Length)

    '        Dim con As New System.Data.SqlClient.SqlConnection(My.Settings.CanteenConnectionString)
    '        con.Open()
    '        Dim cmd As New System.Data.SqlClient.SqlCommand("UploadImage")
    '        cmd.Connection = con
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Parameters.AddWithValue("@Picture", Data)
    '        cmd.Parameters.Add("@ActId", SqlDbType.Int)
    '        cmd.Parameters("@ActId").Value = actId
    '        cmd.ExecuteNonQuery()
    '        con.Close()
    '        fs.Close()
    '    Catch ex As System.Data.SqlClient.SqlException
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Dim lsbSelectedIndex As Integer = 0

    Private Sub lsbAccounts_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsbAccounts.SelectedIndexChanged
        If btnSave.Enabled = True AndAlso boolLoading = False Then
            If lsbAccounts.SelectedIndex <> lsbSelectedIndex Then
                Dim dialogResult As DialogResult = MsgBox("This will clear all your changes! Are you sure you would like to continue?", MsgBoxStyle.YesNo)
                If dialogResult = Windows.Forms.DialogResult.No Then
                    lsbAccounts.SelectedIndex = lsbSelectedIndex
                    Exit Sub
                Else : btnSave.Enabled = False
                End If
            Else
                Exit Sub
            End If
        End If
        lblError.Text = ""
        LoadActInfo()
        lsbSelectedIndex = lsbAccounts.SelectedIndex
    End Sub

    Private Sub txbNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbNumber.TextChanged
        btnSave.Enabled = True
        lblError.Text = ""
    End Sub

    Private Sub ClearTxbs()
        txbNumber.Text = ""
        txbFName.Text = ""
        txbLName.Text = ""
        cboPsnId.SelectedIndex = -1
        cboBnkId.SelectedIndex = -1
        txbPhoto.Text = ""
        cldStartDate.Value = Now()
        txbCredit.Text = ""
        txbSpending.Text = ""
        'txbBalance.Text = ""
        'txbAmountLeft.Text = ""
        txbStatus.Text = ""
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If lsbAccounts.SelectedValue > 0 Then
            TACTTableAdapter.DeleteByActId(lsbAccounts.SelectedValue)
            ClearTxbs()
            lsbAccounts.DataSource = Me.TACTTableAdapter.GetData()
        End If
        btnSave.Enabled = False
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Accounts_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If btnSave.Enabled = True Then
            Dim dialogResult As DialogResult = MsgBox("This will clear all your changes! Are you sure you would like to continue?", MsgBoxStyle.YesNo)
            If dialogResult = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else : btnSave.Enabled = False
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If lsbAccounts.SelectedIndex >= 0 Then
            lsbAccounts.SelectedIndex = -1
        End If
        ClearTxbs()
        actId = 0
        lblError.Text = ""
        btnSave.Enabled = False
    End Sub

    Private Sub txbFName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbFName.TextChanged, txbLName.TextChanged, txbNumber.TextChanged, txbCredit.TextChanged, txbSpending.TextChanged, txbStatus.TextChanged 'txbAmountLeft.TextChanged,
        btnSave.Enabled = True
        lblError.Text = ""
    End Sub
    Dim actId As Integer

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '   If btnSave.Enabled = False Then Exit Sub
        Dim bnkName As String = Nothing
        Dim actNumber As String = Nothing
        Dim actFName As String
        Dim actLName As String
        Dim actPsnId As Integer?
        Dim actBnkId As Integer?
        Dim actStartDate As Date
        Dim actCredit As Decimal
        Dim actSpending As Decimal?
        'Dim actAmountleft As Decimal
        Dim actStatus As String
        If Not lsbAccounts.SelectedValue Is Nothing Then
            actId = lsbAccounts.SelectedValue
        End If
        'If unsavedChanges = True Then
        'If CheckTxb() = True Then 'Not (txbName.Text Is Nothing Or txbNumber.Text Is Nothing Or cboPlacement.Text Is Nothing Or txbPrice.Text Is Nothing Or txbPrinter.Text Is Nothing Or txbQtyShelf.Text Is Nothing Or txbQtyUnit.Text Is Nothing Or txbReorder.Text Is Nothing) Then
        If txbNumber.Text = "" AndAlso cboBnkId.SelectedValue Is Nothing Then
            lblError.Text = "Must choose bunk or manually enter account number!"
            Exit Sub
        End If
        If txbNumber.ReadOnly = True Then
            If Not txbNumber.Text = "" Then
                actNumber = txbNumber.Text
            Else
                actNumber = Nothing
            End If
        ElseIf txbNumber.ReadOnly = False Then
            If txbNumber.Text = "" Then
                actNumber = Nothing
            Else
                If Len(txbNumber.Text) <> 4 Then
                    lblError.Text = "Account Number must be 4 digits"
                Else
                    If actId > 0 Then
                        If TACTTableAdapter.FillByActNumber(Me.DsCanteen.tACT, txbNumber.Text, txbNumber.Text, actId) > 0 Then
                            lblError.Text = "Account Number already in use!"
                            Exit Sub
                        Else
                            actNumber = txbNumber.Text
                        End If
                    Else
                        If TACTTableAdapter.FillByActNumber(Me.DsCanteen.tACT, txbNumber.Text, txbNumber.Text, actId) > 0 Then
                            lblError.Text = "Account Number already in use!"
                            Exit Sub
                        Else
                            actNumber = txbNumber.Text
                        End If
                    End If
                End If
            End If
        End If
        actFName = txbFName.Text
        actLName = txbLName.Text
        If Not cboPsnId.SelectedValue Is Nothing Then
            actPsnId = cboPsnId.SelectedValue
        Else
            actPsnId = New Nullable(Of Integer)
        End If
        If Not cboBnkId.SelectedValue Is Nothing Then
            actBnkId = cboBnkId.SelectedValue
            bnkName = CType(cboBnkId.SelectedItem, DataRowView).Row("BNK_Name").ToString
        Else
            actBnkId = New Nullable(Of Integer)
            bnkName = Nothing
        End If
        actStartDate = FormatDateTime(cldStartDate.Value, DateFormat.ShortDate)
        If Not txbCredit.Text = "" Then
            actCredit = FormatCurrency(txbCredit.Text, 2)
        Else
            actCredit = 0D
        End If
        If Not txbSpending.Text = "" Then
            actSpending = FormatCurrency(txbSpending.Text, 2)
        Else
            actSpending = New Nullable(Of Decimal)
        End If

        'actAmountleft = FormatCurrency(txbAmountLeft.Text, 2)
        If Not txbStatus.Text = "" Then
            actStatus = txbStatus.Text
        Else
            actStatus = Nothing
        End If
        If actId > 0 Then
            TACTTableAdapter.UpdateAct(actNumber, actFName, actLName, actPsnId, actBnkId, actStatus, actCredit, actSpending, actStartDate, actId, usrId)
            If Not txbPhoto.Text = "" AndAlso Not txbPhoto.Text = "Account Photo" Then
                Dim fs As New FileStream(Trim(txbPhoto.Text), FileMode.Open)
                Dim Data() As Byte = New [Byte](fs.Length) {}
                fs.Read(Data, 0, fs.Length)
                QueriesTableAdapter1.UploadImage(Data, actId)
                fs.Close()
            End If
            lblError.Text = "Account updated successfully :)"
            ClearTxbs()
            btnSave.Enabled = False
            lsbAccounts.SelectedIndex = 0
            lsbAccounts.DataSource = Me.ActDisplayTableAdapter1.GetDataBy(searchAct.Text)
            LoadActInfo()
            btnSave.Enabled = False
        Else
            actId = TACTTableAdapter.InsertAct(actNumber, actFName, actLName, actPsnId, actBnkId, bnkName, actStatus, actCredit, actSpending, actStartDate, usrId)
            If Not txbPhoto.Text = "" Then
                Dim fs As New FileStream(Trim(txbPhoto.Text), FileMode.Open)
                Dim Data() As Byte = New [Byte](fs.Length) {}
                fs.Read(Data, 0, fs.Length)
                QueriesTableAdapter1.UploadImage(Data, actId)
                fs.Close()
            End If
            lblError.Text = "Account created successfully :)"
            ClearTxbs()
            btnSave.Enabled = False
            lsbAccounts.DataSource = Me.ActDisplayTableAdapter1.GetDataBy(searchAct.Text)
            lsbAccounts.SelectedIndex = 0
            LoadActInfo()
            btnSave.Enabled = False

            'Load lsbAccounts and selectedvalue = new user
        End If
        'End If
        ' Else : lblError.Text = "No changes were made!"
        ' End If
    End Sub

    Private Sub btnDeletePhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletePhoto.Click
        If Not txbPhoto.Text = "" Then
            QueriesTableAdapter1.DeletePhoto(actId)
            txbPhoto.Text = ""
        End If
    End Sub

    Private Sub cboBnkId_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBnkId.SelectedValueChanged, cboPsnId.SelectedValueChanged
        btnSave.Enabled = True
        lblError.Text = ""
    End Sub

    Private Sub cldStartDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cldStartDate.ValueChanged
        btnSave.Enabled = True
        lblError.Text = ""
    End Sub


    Private Sub btnEditActNum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditActNum.Click
        txbNumber.ReadOnly = False
    End Sub


    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        If lsbAccounts.Items.Count() > 0 Then
            If lsbAccounts.SelectedIndex > 0 Then
                lsbAccounts.SelectedIndex -= 1
            Else : lsbAccounts.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub btnDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.Click
        If lsbAccounts.Items.Count() > 0 Then
            If lsbAccounts.SelectedIndex < lsbAccounts.Items.Count - 1 Then
                lsbAccounts.SelectedIndex += 1
            Else : lsbAccounts.SelectedIndex = lsbAccounts.Items.Count - 1
            End If
        End If
    End Sub

    Private Sub cboPsnId_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPsnId.SelectedValueChanged
        If Not cboPsnId.SelectedValue Is Nothing Then
            TPSNTableAdapter1.FillByPsnId(DsCanteen.tPSN, cboPsnId.SelectedValue)
            txbCredit.Text = FormatCurrency(DsCanteen.tPSN.Item(0).PSN_CreditLimit)
        End If
    End Sub

    Private Sub searchAct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchAct.TextChanged
        lsbAccounts.DataSource = Me.ActDisplayTableAdapter1.GetDataBy(searchAct.Text)
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class