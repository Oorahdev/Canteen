Public Class PaymentForm

    Public Class CanteenPmt
        Public Sub New()

        End Sub
        Public PmtAmount As Decimal
        Public CheckNum As Integer?
        Public CheckDate As Date? '= 'FormatDateTime(Now, DateFormat.ShortDate)
        Public PmtMethod As String = ""
    End Class

    Public Shared newPmt As New CanteenPmt

    Private Sub PaymentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If newPmt.PmtAmount >= 0 Then
            txbAmount.Text = FormatCurrency(newPmt.PmtAmount)
        End If
        checkDate.Value = newPmt.CheckDate

        If Not IsDBNull(newPmt.CheckNum) Then
            txbCheckNum.Text = newPmt.CheckNum
        End If
        If Not newPmt.PmtMethod = "" Then
            If newPmt.PmtMethod = "Credit Card" Then
                creditCardRB.Checked = True
            ElseIf newPmt.PmtMethod = "Check" Then
                checkRB.Checked = True
            ElseIf newPmt.PmtMethod = "Cash" Then
                cashRB.Checked = True
            ElseIf newPmt.PmtMethod = "Prize" Then
                rbPrizeMoney.Checked = True
            End If
        End If
    End Sub

    Dim ctlCurrent As TextBox
    Private Sub txbActId_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbAmount.GotFocus, txbCheckNum.GotFocus
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

    Public Sub AdmKeypad1_OnKeyPressSpecial_1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AdmKeypad1.OnKeyPressSpecial
        Select Case e.KeyCode
            Case Is = Keys.Enter
                If Not IsNothing(txbAmount.Text) Then
                    'If newPmt.PmtAmount <= 0 Then
                    newPmt.PmtAmount = txbAmount.Text
                End If
                If creditCardRB.Checked = True Then
                    newPmt.PmtMethod = "Credit Card"
                End If
                If cashRB.Checked = True Then
                    newPmt.PmtMethod = "Cash"
                End If
                If checkRB.Checked = True Then
                    newPmt.PmtMethod = "Check"
                End If
                If rbPrizeMoney.Checked = True Then
                    newPmt.PmtMethod = "Prize"
                End If
                If Not txbCheckNum.Text = "" Then
                    newPmt.CheckNum = txbCheckNum.Text
                Else
                    newPmt.CheckNum = New Nullable(Of Integer)
                End If
                Dim a As New Nullable(Of Date)
                If checkDate.ValueIsDbNull = False Then
                    a = New Nullable(Of Date)(checkDate.Value)
                End If
                newPmt.CheckDate = a
                'ElseIf newPmt.PmtAmount > 0 Then
                'newPmt.PmtAmount += txbAmount.Text
                'End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Case Else
                Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyEvent(adm.admUtilities.TextWithSelection.FromTextBox(ctlCurrent), e)
                ctlCurrent.Text = ret.Text
                ctlCurrent.SelectionStart = ret.SelectionStart
                ctlCurrent.SelectionLength = ret.SelectionLength
        End Select
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If Not IsNothing(txbAmount.Text) Then
            txbAmount.Text = ""
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub checkDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles checkDate.KeyDown
        If (e.KeyCode = Windows.Forms.Keys.Delete Or e.KeyCode = Windows.Forms.Keys.Back) Then
            sender.valueisdbnull = True
            e.Handled = True
        End If
    End Sub
End Class