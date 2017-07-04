Public Class NewUser

    Private Sub NewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsCanteen.tUSR' table. You can move, or remove it, as needed.
        'Me.TUSRTableAdapter.Fill(Me.DsCanteen.tUSR)
        lsbUsers.ValueMember = "usr_id"
        lsbUsers.DisplayMember = "usr_login"
        lsbUsers.DataSource = Me.TUSRTableAdapter.GetData()
        'For Each drUsers As dsCanteen.tUSRRow In DsCanteen.tUSR.Rows
        '    lsbUsers.Items.Add(drUsers)
        'Next


        lsbUsers.SelectedIndex = 0
        LoadUserInfo()
        unsavedChanges = False
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        If lsbUsers.SelectedIndex >= 0 Then
            lsbUsers.SelectedIndex = -1
        End If
        ClearTxbs()
        lblError.Text = ""
    End Sub
    'Dim usrActId As Integer = 0
    'Dim usrName As String = ""
    'Dim usrPassword As String = ""
    'Dim usrAdmin As Boolean = False
    'Dim usrId As Integer = usrid


    Private Sub btnChooseAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseAct.Click
        Dim frmChooseAct As New ChooseACT2
        frmChooseAct.ShowDialog()
        Dim usrActId As Integer = frmChooseAct.SelectAct
        If usrActId > 0 Then
            txbActId.Text = usrActId
            For Each drUsr As DataRow In Me.DsCanteen.tUSR.Rows
                drUsr.Item("USR_ACT_ID") = usrActId
            Next
        End If
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim usrId As Integer
        Dim usrName As String
        Dim usrPassword As String
        Dim usrAdmin As Boolean
        Dim usrActId As Integer
        If Not lsbUsers.SelectedValue Is Nothing Then
            usrId = lsbUsers.SelectedValue
        End If
        If CheckTxb() = True Then
            'If Not (txbActId.Text Is Nothing And txbConfirm.Text Is Nothing And txbPassword.Text Is Nothing And txbUsrName.Text Is Nothing) Then
            usrName = txbUsrName.Text
            usrPassword = txbPassword.Text
            usrAdmin = ckbAdmin.Checked
            If txbPassword.Text = txbConfirm.Text Then
                If IsNumeric(Me.txbActId.Text) Then
                    usrActId = CInt(Me.txbActId.Text)
                    If usrId > 0 Then
                        TUSRTableAdapter.UpdateUser(usrActId, usrName, usrPassword, usrAdmin, usrId)
                        lblError.Text = "User updated successfully :)"
                        ClearTxbs()
                        unsavedChanges = False
                        lsbUsers.DataSource = Me.TUSRTableAdapter.GetData()
                        lsbUsers.SelectedIndex = 0
                        unsavedChanges = False
                    Else : TUSRTableAdapter.InsertUser(usrActId, usrName, usrPassword, usrAdmin)
                        lblError.Text = "User created successfully :)"
                        ClearTxbs()
                        unsavedChanges = False
                        lsbUsers.DataSource = Me.TUSRTableAdapter.GetData()
                        lsbUsers.SelectedIndex = 0
                        unsavedChanges = False
                        'Load lsbUsers and selectedvalue = new user
                    End If
                Else : lblError.Text = "Please enter a valid Account ID."
                End If
            Else : lblError.Text = "Your passwords do not match! Please try again."
            End If
        Else : lblError.Text = "You must enter all information."
        End If
        'End If

        'Try
        '    Me.TUSRBindingSource.EndEdit()
        '    Me.TUSRTableAdapter.Update(DsCanteen.tUSR)
        '    DsCanteen.tUSR.AcceptChanges()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    'Private Sub TUSRBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles TUSRBindingSource.AddingNew
    '    Dim dr As dsCanteen.tUSRRow = DsCanteen.tUSR.NewtUSRRow
    '    dr.BeginEdit()
    '    dr("USR_DateEntered") = Now
    '    dr.EndEdit()
    '    e.NewObject = dr
    'End Sub

    'Private Sub TUSRBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TUSRBindingSource.CurrentChanged
    '    If Me.TUSRBindingSource.Current.GetType Is GetType(DataRowView) Then
    '        Dim dr As DataRowView = Me.TUSRBindingSource.Current
    '        Dim usr As dsCanteen.tUSRRow = dr.Row
    '        Me.txbActId.Text = usr.USR_ACT_ID
    '        Me.txbPassword.Text = usr.USR_Password
    '        Me.txbConfirm.Text = usr.USR_Password
    '        Me.txbUsrName.Text = usr.USR_Login
    '    End If
    'End Sub

    Private Sub ClearTxbs()
        txbActId.Text = ""
        txbConfirm.Text = ""
        txbPassword.Text = ""
        txbUsrName.Text = ""
        ckbAdmin.Checked = False
    End Sub
    Dim lsbSelectedIndex As Integer = 0
    Private Sub lsbUsers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsbUsers.SelectedValueChanged
        If unsavedChanges = True Then
            Dim dialogResult As DialogResult = MsgBox("This will clear all your changes! Are you sure you would like to continue?", MsgBoxStyle.YesNo)
            If dialogResult = Windows.Forms.DialogResult.No Then
                lsbUsers.SelectedIndex = lsbSelectedIndex
                Exit Sub
            Else : unsavedChanges = False
            End If

        End If
        LoadUserInfo()
        lblError.Text = ""
        lsbSelectedIndex = lsbUsers.SelectedIndex
    End Sub


    Private Sub LoadUserInfo()
        If Not lsbUsers.SelectedValue Is Nothing Then
            TUSRTableAdapter.FillByUsrId(Me.DsCanteen.tUSR, lsbUsers.SelectedValue)
            txbUsrName.Text = DsCanteen.tUSR.Item(0).USR_Login
            txbConfirm.Text = DsCanteen.tUSR.Item(0).USR_Password
            txbPassword.Text = DsCanteen.tUSR.Item(0).USR_Password
            txbActId.Text = DsCanteen.tUSR.Item(0).USR_ACT_ID
            ckbAdmin.Checked = DsCanteen.tUSR.Item(0).USR_Admin
            unsavedChanges = False
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If lsbUsers.SelectedValue > 0 Then
            TUSRTableAdapter.DeleteByUsrId(lsbUsers.SelectedValue)
            ClearTxbs()
            unsavedChanges = False
            lsbUsers.DataSource = Me.TUSRTableAdapter.GetData()
            unsavedChanges = False
        End If
        unsavedChanges = False
    End Sub

    Dim unsavedChanges As Boolean = False

    Private Sub txbActId_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbActId.TextChanged, txbConfirm.TextChanged, txbPassword.TextChanged, txbUsrName.TextChanged, ckbAdmin.CheckedChanged
        unsavedChanges = True
    End Sub
    Dim ctlCurrent As TextBox
    Private Sub txbActId_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbActId.GotFocus, txbConfirm.GotFocus, txbPassword.GotFocus, txbUsrName.GotFocus
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

    Private Function CheckTxb()
        If Not txbUsrName.Text = "" Then
            If Not txbPassword.Text = "" Then
                If Not txbConfirm.Text = "" Then
                    Return True
                Else : lblError.Text = "Please confirm your password."
                    Return False
                End If
            Else : lblError.Text = "Please enter a password."
                Return False
            End If
        Else : lblError.Text = "Please enter a user name."
            Return False
        End If
        Return True
    End Function
End Class