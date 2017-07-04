Public Class EditItemPrice
    Public Shared itemPrice As Decimal = 0D

    Private Sub EditItemPrice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txbAmount.Focus() - set tabstop instead.
        txbAmount.Text = FormatCurrency(itemPrice)
    End Sub

    Friend Sub LoadPrice(ByVal oldPrice As Decimal)
        itemPrice = oldPrice
    End Sub

    Private Sub AdmKeypad1_OnKeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AdmKeypad1.OnKeyPress
        Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyPress(adm.admUtilities.TextWithSelection.FromTextBox(txbAmount), e)
        txbAmount.Text = ret.Text
        txbAmount.SelectionStart = ret.SelectionStart
        txbAmount.SelectionLength = ret.SelectionLength
    End Sub
    Public Sub AdmKeypad1_OnKeyPressSpecial_1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AdmKeypad1.OnKeyPressSpecial
        Select Case e.KeyCode
            Case Is = Keys.Enter
                If Not IsNothing(txbAmount.Text) Then
                    'If cashBack <= 0 Then
                    itemPrice = FormatCurrency(txbAmount.Text)
                    'End If
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            Case Else
                Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyEvent(adm.admUtilities.TextWithSelection.FromTextBox(txbAmount), e)
                txbAmount.Text = ret.Text
                txbAmount.SelectionStart = ret.SelectionStart
                txbAmount.SelectionLength = ret.SelectionLength
        End Select
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If Not IsNothing(txbAmount.Text) Then
            txbAmount.Text = ""
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


    Private Sub txbAmount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbAmount.GotFocus
        txbAmount.Focus()
    End Sub

End Class