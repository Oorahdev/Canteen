﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.btnShelfRestock = New System.Windows.Forms.Button
        Me.btnStockReorder = New System.Windows.Forms.Button
        Me.btnActBalances = New System.Windows.Forms.Button
        Me.btnTotals = New System.Windows.Forms.Button
        Me.btnItemsTotSold = New System.Windows.Forms.Button
        Me.btnItem = New System.Windows.Forms.Button
        Me.btnPreOrders = New System.Windows.Forms.Button
        Me.pnlCancel = New System.Windows.Forms.Panel
        Me.printReports = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.AccountBalances = New C1.Win.C1Report.C1Report
        Me.Totals = New C1.Win.C1Report.C1Report
        Me.ItemTotals = New C1.Win.C1Report.C1Report
        Me.ItemCards = New C1.Win.C1Report.C1Report
        Me.CheckShelfInv = New C1.Win.C1Report.C1Report
        Me.ReorderInventory = New C1.Win.C1Report.C1Report
        Me.PreOrders = New C1.Win.C1Report.C1Report
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlCancel.SuspendLayout()
        CType(Me.AccountBalances, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Totals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemTotals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemCards, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckShelfInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReorderInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LemonChiffon
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnShelfRestock, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnStockReorder, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnActBalances, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnTotals, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnItemsTotSold, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnItem, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPreOrders, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(78, 40)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(427, 278)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnShelfRestock
        '
        Me.btnShelfRestock.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnShelfRestock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnShelfRestock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShelfRestock.Location = New System.Drawing.Point(15, 199)
        Me.btnShelfRestock.Margin = New System.Windows.Forms.Padding(15)
        Me.btnShelfRestock.Name = "btnShelfRestock"
        Me.btnShelfRestock.Size = New System.Drawing.Size(110, 64)
        Me.btnShelfRestock.TabIndex = 5
        Me.btnShelfRestock.Text = "Shelf Restock"
        Me.btnShelfRestock.UseVisualStyleBackColor = False
        '
        'btnStockReorder
        '
        Me.btnStockReorder.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnStockReorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStockReorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockReorder.Location = New System.Drawing.Point(155, 199)
        Me.btnStockReorder.Margin = New System.Windows.Forms.Padding(15)
        Me.btnStockReorder.Name = "btnStockReorder"
        Me.btnStockReorder.Size = New System.Drawing.Size(110, 64)
        Me.btnStockReorder.TabIndex = 4
        Me.btnStockReorder.Text = "Reorder Inventory"
        Me.btnStockReorder.UseVisualStyleBackColor = False
        '
        'btnActBalances
        '
        Me.btnActBalances.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnActBalances.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnActBalances.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActBalances.Location = New System.Drawing.Point(15, 15)
        Me.btnActBalances.Margin = New System.Windows.Forms.Padding(15)
        Me.btnActBalances.Name = "btnActBalances"
        Me.btnActBalances.Size = New System.Drawing.Size(110, 62)
        Me.btnActBalances.TabIndex = 0
        Me.btnActBalances.Text = "Account Balances"
        Me.btnActBalances.UseVisualStyleBackColor = False
        '
        'btnTotals
        '
        Me.btnTotals.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnTotals.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTotals.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotals.Location = New System.Drawing.Point(155, 15)
        Me.btnTotals.Margin = New System.Windows.Forms.Padding(15)
        Me.btnTotals.Name = "btnTotals"
        Me.btnTotals.Size = New System.Drawing.Size(110, 62)
        Me.btnTotals.TabIndex = 1
        Me.btnTotals.Text = "Totals"
        Me.btnTotals.UseVisualStyleBackColor = False
        '
        'btnItemsTotSold
        '
        Me.btnItemsTotSold.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnItemsTotSold.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnItemsTotSold.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemsTotSold.Location = New System.Drawing.Point(15, 107)
        Me.btnItemsTotSold.Margin = New System.Windows.Forms.Padding(15)
        Me.btnItemsTotSold.Name = "btnItemsTotSold"
        Me.btnItemsTotSold.Size = New System.Drawing.Size(110, 62)
        Me.btnItemsTotSold.TabIndex = 2
        Me.btnItemsTotSold.Text = "Items - Total Sold"
        Me.btnItemsTotSold.UseVisualStyleBackColor = False
        '
        'btnItem
        '
        Me.btnItem.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItem.Location = New System.Drawing.Point(155, 107)
        Me.btnItem.Margin = New System.Windows.Forms.Padding(15)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Size = New System.Drawing.Size(110, 62)
        Me.btnItem.TabIndex = 3
        Me.btnItem.Text = "Item Cards"
        Me.btnItem.UseVisualStyleBackColor = False
        '
        'btnPreOrders
        '
        Me.btnPreOrders.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPreOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnPreOrders.Location = New System.Drawing.Point(295, 15)
        Me.btnPreOrders.Margin = New System.Windows.Forms.Padding(15)
        Me.btnPreOrders.Name = "btnPreOrders"
        Me.btnPreOrders.Size = New System.Drawing.Size(109, 62)
        Me.btnPreOrders.TabIndex = 6
        Me.btnPreOrders.Text = "Today's Pre Orders"
        Me.btnPreOrders.UseVisualStyleBackColor = False
        '
        'pnlCancel
        '
        Me.pnlCancel.Controls.Add(Me.printReports)
        Me.pnlCancel.Controls.Add(Me.btnCancel)
        Me.pnlCancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlCancel.Location = New System.Drawing.Point(0, 355)
        Me.pnlCancel.Name = "pnlCancel"
        Me.pnlCancel.Size = New System.Drawing.Size(582, 73)
        Me.pnlCancel.TabIndex = 15
        '
        'printReports
        '
        Me.printReports.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.printReports.BackColor = System.Drawing.Color.Lime
        Me.printReports.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.printReports.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printReports.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.printReports.Location = New System.Drawing.Point(-148, 17)
        Me.printReports.Name = "printReports"
        Me.printReports.Size = New System.Drawing.Size(121, 62)
        Me.printReports.TabIndex = 7
        Me.printReports.Text = "Cancel"
        Me.printReports.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Location = New System.Drawing.Point(465, 19)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 40)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'AccountBalances
        '
        Me.AccountBalances.ReportDefinition = resources.GetString("AccountBalances.ReportDefinition")
        Me.AccountBalances.ReportName = "AccountBalances"
        '
        'Totals
        '
        Me.Totals.ReportDefinition = resources.GetString("Totals.ReportDefinition")
        Me.Totals.ReportName = "Totals"
        '
        'ItemTotals
        '
        Me.ItemTotals.ReportDefinition = resources.GetString("ItemTotals.ReportDefinition")
        Me.ItemTotals.ReportName = "ItemTotals"
        '
        'ItemCards
        '
        Me.ItemCards.ReportDefinition = resources.GetString("ItemCards.ReportDefinition")
        Me.ItemCards.ReportName = "ItemCards"
        '
        'CheckShelfInv
        '
        Me.CheckShelfInv.ReportDefinition = resources.GetString("CheckShelfInv.ReportDefinition")
        Me.CheckShelfInv.ReportName = "CheckShelfInv"
        '
        'ReorderInventory
        '
        Me.ReorderInventory.ReportDefinition = resources.GetString("ReorderInventory.ReportDefinition")
        Me.ReorderInventory.ReportName = "ReorderInventory"
        '
        'PreOrders
        '
        Me.PreOrders.ReportDefinition = resources.GetString("PreOrders.ReportDefinition")
        Me.PreOrders.ReportName = "PreOrders"
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(582, 428)
        Me.Controls.Add(Me.pnlCancel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reports"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlCancel.ResumeLayout(False)
        CType(Me.AccountBalances, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Totals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemTotals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemCards, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckShelfInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReorderInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnActBalances As System.Windows.Forms.Button
    Friend WithEvents btnTotals As System.Windows.Forms.Button
    Friend WithEvents btnItemsTotSold As System.Windows.Forms.Button
    Friend WithEvents btnItem As System.Windows.Forms.Button
    Friend WithEvents pnlCancel As System.Windows.Forms.Panel
    Friend WithEvents printReports As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents AccountBalances As C1.Win.C1Report.C1Report
    Friend WithEvents Totals As C1.Win.C1Report.C1Report
    Friend WithEvents ItemTotals As C1.Win.C1Report.C1Report
    Friend WithEvents ItemCards As C1.Win.C1Report.C1Report
    Friend WithEvents btnShelfRestock As System.Windows.Forms.Button
    Friend WithEvents btnStockReorder As System.Windows.Forms.Button
    Friend WithEvents CheckShelfInv As C1.Win.C1Report.C1Report
    Friend WithEvents ReorderInventory As C1.Win.C1Report.C1Report
    Friend WithEvents btnPreOrders As System.Windows.Forms.Button
    Friend WithEvents PreOrders As C1.Win.C1Report.C1Report
End Class
