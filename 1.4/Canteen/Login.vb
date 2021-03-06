﻿Public Class Login

    Private Sub LoadPrefs()
        Dim prefsTableAdapter As New dsCanteenTableAdapters.PRFTableAdapter
        Dim dsCanteen1 As New dsCanteen
        Dim prefsTable As dsCanteen.PRFDataTable = prefsTableAdapter.GetDataBy("WarnPhoto")
        boolPhotoWarning = prefsTable.Item(0).PRF_Value
        prefsTable = prefsTableAdapter.GetDataBy("TrackInventory")
        boolTrackInventory = prefsTable.Item(0).PRF_Value
    End Sub

    Private Sub Login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Is = Keys.Enter
                Login()
        End Select
    End Sub

    Private Sub Login()
        For Each drUser As DataRow In Me.dsCanteen1.tUSR.Rows
            If drUser.Item("USR_Login").ToString.ToLower = txbUserName.Text.ToLower And drUser.Item("USR_Password") = txbPassword.Text Then
                usrId = drUser.Item("USR_ID")
                usrAdmin = drUser.Item("USR_Admin")
                LoadPrefs()
                Dim frmOrders As New Orders
                frmOrders.Show()
                Me.Close()
            Else : lblError.Text = "Error logging in! Please try again."
            End If
        Next
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim verTableAdapter As New dsCanteenTableAdapters.VERTableAdapter
        verTableAdapter.Fill(Me.dsCanteen1.VER)
        'My.Settings.Item("CompcareDataConnectionString") = ""
        'My.Settings.Save()
        Dim applicationVersion As String = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        '  For Each DataRow As DataRow In Me.dsCanteen1.VER.Rows
        ' If Not DataRow.Item("VER_Name") = applicationVersion Then
        If Not dsCanteen1.VER.Item(0).VER_Value = applicationVersion Then
            MessageBox.Show("You do not have the latest version installed on this computer. Please install!", "Canteen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End If
        'Next
        txbUserName.Focus()
        TUSRTableAdapter1.Fill(Me.dsCanteen1.tUSR)

        If preOrderMode = True Then
            Me.Visible = False
            LoadPrefs()
            Dim frmOrders As New Orders
            frmOrders.Show()
        End If

    End Sub

    Dim ctlCurrent As TextBox = Me.txbUserName

    Private Sub AdmKeyboard1_OnKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AdmKeyboard1.OnKeyPress
        If Not ctlCurrent Is Nothing Then
            Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyPress(adm.admUtilities.TextWithSelection.FromTextBox(ctlCurrent), e)
            ctlCurrent.Text = ret.Text
            ctlCurrent.SelectionStart = ret.SelectionStart
            ctlCurrent.SelectionLength = ret.SelectionLength
        End If
    End Sub

    Public Sub AdmKeyboard1_OnKeyPressSpecial(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AdmKeyboard1.OnKeyPressSpecial
        Select Case e.KeyCode
            Case Is = Keys.Tab
                ' SelectNextControl(Me, True, True, True, True)
                If ctlCurrent Is txbUserName Then
                    ctlCurrent = txbPassword
                ElseIf ctlCurrent Is txbPassword Then
                    ctlCurrent = txbUserName
                End If
            Case Is = Keys.Enter
                Login()
            Case Else
                If Not ctlCurrent Is Nothing Then
                    Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyEvent(adm.admUtilities.TextWithSelection.FromTextBox(ctlCurrent), e)
                    ctlCurrent.Text = ret.Text
                    ctlCurrent.SelectionStart = ret.SelectionStart
                    ctlCurrent.SelectionLength = ret.SelectionLength
                End If
        End Select

    End Sub

    Private Sub txbUserName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbUserName.GotFocus
        ctlCurrent = Me.txbUserName
    End Sub

    Private Sub txbPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbPassword.GotFocus
        ctlCurrent = Me.txbPassword
    End Sub

    Private Sub txbPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txbPassword.KeyDown, txbUserName.KeyDown
        Select Case e.KeyCode
            Case Is = Keys.Enter
                Login()
        End Select
    End Sub

End Class