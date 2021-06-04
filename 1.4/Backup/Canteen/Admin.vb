﻿Public Class Admin

    Private Sub btnNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsers.Click
        Dim frmNewUser As New NewUser
        frmNewUser.ShowDialog()
    End Sub

    Private Sub btnPositions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPositions.Click
        Dim frmPositions As New Positions
        frmPositions.ShowDialog()
    End Sub

    Private Sub btnAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccounts.Click
        Dim frmAccounts As New Accounts
        frmAccounts.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnCats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCats.Click
        Dim frmCategories As New Categories
        frmCategories.ShowDialog()
        itemChanges = True
    End Sub

    Private Sub btnItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItems.Click
        Dim frmItems As New Items
        frmItems.ShowDialog()
        itemChanges = True
    End Sub

    Private Sub btnUserPrefs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserPrefs.Click
        Dim frmPrefs As New UserPrefs
        frmPrefs.ShowDialog()
    End Sub

    Private Sub btnBunks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBunks.Click
        Dim frmBunks As New Bunks
        frmBunks.ShowDialog()
    End Sub

    Friend Shared itemChanges As Boolean = False

    Dim unsavedChanges As Boolean = False
    Private Sub Admin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If unsavedChanges = True Then
            Dim dialogResult As DialogResult = MsgBox("This will clear all your changes! Are you sure you would like to continue?", MsgBoxStyle.YesNo)
            If dialogResult = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else : unsavedChanges = False
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdateShelves.Click
        Dim frmUpdateShelves As New UpdateShelves
        frmUpdateShelves.ShowDialog()
    End Sub

    Private Sub btnInventory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        Dim frmInventory As New Inventory
        frmInventory.ShowDialog()
    End Sub

    Private Sub printReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printReports.Click
        Dim frmReports As New Reports
        frmReports.ShowDialog()
    End Sub

    Private Sub btnTimeFrame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeFrame.Click
        Dim frmTimeFrame As New TimeFrame
        frmTimeFrame.ShowDialog()
    End Sub
End Class
