Imports System.Data.SqlClient
Public Class ChooseACT

    Dim current As TextBox = Me.txbActID
    Private Sub ChooseACT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txbActID.Focus()
        LoadAccounts()
    End Sub

    Private Sub txbActID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbActID.GotFocus
        current = Me.txbActID
    End Sub

    Private Sub AdmKeypad1_OnKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AdmKeypad1.OnKeyPress
        Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyPress(adm.admUtilities.TextWithSelection.FromTextBox(current), e)
        current.Text = ret.Text
        current.SelectionStart = ret.SelectionStart
        current.SelectionLength = ret.SelectionLength
    End Sub
    Public Sub AdmKeypad1_OnKeyPressSpecial(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AdmKeypad1.OnKeyPressSpecial
        'Select Case 
        Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyEvent(adm.admUtilities.TextWithSelection.FromTextBox(current), e)
        current.Text = ret.Text
        current.SelectionStart = ret.SelectionStart
        current.SelectionLength = ret.SelectionLength
    End Sub
    'Private Sub AdmKeyBack1_OnKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AdmKeyBack1.OnKeyPress
    '    Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyPress(adm.admUtilities.TextWithSelection.FromTextBox(current), e)
    '    current.Text = ret.Text
    '    current.SelectionStart = ret.SelectionStart
    '    current.SelectionLength = ret.SelectionLength
    'End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub lsbActID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsbActID.SelectedIndexChanged
        txbActID.Text = lsbActID.Text
    End Sub

    Private Sub txbActID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbActID.TextChanged
        ActDisplayTableAdapter.FillACT(Me.DsCanteen.ActDisplay, txbActID.Text)
    End Sub
    'Private Sub AdmKeyBack1_OnKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AdmKeyBack1.OnKeyPress
    '    Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyPress(adm.admUtilities.TextWithSelection.FromTextBox(current), e)
    '    current.Text = ret.Text
    '    current.SelectionStart = ret.SelectionStart
    '    current.SelectionLength = ret.SelectionLength
    'End Sub

    Public Sub LoadAccounts()
        ActDisplayTableAdapter.FillACT(Me.DsCanteen.ActDisplay, txbActID.Text)
        lsbActID.DisplayMember = (DsCanteen.ActDisplay.ACT_FullNameColumn).ToString()
        'Dim strCon As String = ("Data Source=VMSER2\ADMIREDEV;Initial Catalog=Canteen;User ID=CanteenUser; Password=1234")
        'Dim con As New SqlConnection(strCon)
        'Dim rdrAccounts As SqlDataReader
        'Dim strCom As String = ("Select ACT_ID, ACT_Number + '-' + ACT_FirstName + ' ' + ACT_LastName AS 'ACT_FullName' FROM ACT")
        'Dim com As New SqlCommand(strCom, con)
        'Try
        '    con.Open()
        '    rdrAccounts = com.ExecuteReader()
        '    lsbActID.Items.Clear()
        '    Do While rdrAccounts.Read()
        '        lsbActID.Items.Add(rdrAccounts.Item("ACT_FullName"))
        '    Loop


        '    rdrAccounts.Close()
        'Finally
        '    con.Close()
        'End Try


        'lsbactid.displaymember = tacttableadapter1.getdatabyfullname().tostring()
        'lsbactid.displaymember = string.format("{0}-{1}{2}", .item("act_number"), draccount.item("act_firstname"), draccount.item("act_lastname")
        'lsbActID.Items.Add(String.Format("{0}-{1}{2}", draccount.item("act_number"), draccount.item("act_firstname"), draccount.item("act_lastname")))

        ' Next
    End Sub

End Class