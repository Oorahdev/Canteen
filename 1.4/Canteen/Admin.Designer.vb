﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.pnlAdminBtn = New System.Windows.Forms.Panel
        Me.tlpAdminBtn = New System.Windows.Forms.TableLayoutPanel
        Me.btnBunks = New System.Windows.Forms.Button
        Me.btnInventory = New System.Windows.Forms.Button
        Me.btnUpdateShelves = New System.Windows.Forms.Button
        Me.btnUserPrefs = New System.Windows.Forms.Button
        Me.btnPositions = New System.Windows.Forms.Button
        Me.btnAccounts = New System.Windows.Forms.Button
        Me.btnUsers = New System.Windows.Forms.Button
        Me.btnCats = New System.Windows.Forms.Button
        Me.btnItems = New System.Windows.Forms.Button
        Me.pnlCancel = New System.Windows.Forms.Panel
        Me.btnTimeFrame = New System.Windows.Forms.Button
        Me.printReports = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.pnlAdminBtn.SuspendLayout()
        Me.tlpAdminBtn.SuspendLayout()
        Me.pnlCancel.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAdminBtn
        '
        Me.pnlAdminBtn.Controls.Add(Me.tlpAdminBtn)
        Me.pnlAdminBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAdminBtn.Location = New System.Drawing.Point(0, 0)
        Me.pnlAdminBtn.Name = "pnlAdminBtn"
        Me.pnlAdminBtn.Size = New System.Drawing.Size(742, 516)
        Me.pnlAdminBtn.TabIndex = 13
        '
        'tlpAdminBtn
        '
        Me.tlpAdminBtn.ColumnCount = 3
        Me.tlpAdminBtn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpAdminBtn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpAdminBtn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpAdminBtn.Controls.Add(Me.btnBunks, 0, 2)
        Me.tlpAdminBtn.Controls.Add(Me.btnInventory, 0, 2)
        Me.tlpAdminBtn.Controls.Add(Me.btnUpdateShelves, 0, 2)
        Me.tlpAdminBtn.Controls.Add(Me.btnUserPrefs, 0, 1)
        Me.tlpAdminBtn.Controls.Add(Me.btnPositions, 0, 1)
        Me.tlpAdminBtn.Controls.Add(Me.btnAccounts, 0, 0)
        Me.tlpAdminBtn.Controls.Add(Me.btnUsers, 1, 0)
        Me.tlpAdminBtn.Controls.Add(Me.btnCats, 2, 1)
        Me.tlpAdminBtn.Controls.Add(Me.btnItems, 2, 0)
        Me.tlpAdminBtn.Location = New System.Drawing.Point(160, 75)
        Me.tlpAdminBtn.Name = "tlpAdminBtn"
        Me.tlpAdminBtn.Padding = New System.Windows.Forms.Padding(10)
        Me.tlpAdminBtn.RowCount = 3
        Me.tlpAdminBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpAdminBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpAdminBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpAdminBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.tlpAdminBtn.Size = New System.Drawing.Size(395, 220)
        Me.tlpAdminBtn.TabIndex = 0
        '
        'btnBunks
        '
        Me.btnBunks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBunks.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnBunks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBunks.ForeColor = System.Drawing.Color.Black
        Me.btnBunks.Location = New System.Drawing.Point(13, 145)
        Me.btnBunks.Name = "btnBunks"
        Me.btnBunks.Size = New System.Drawing.Size(119, 62)
        Me.btnBunks.TabIndex = 14
        Me.btnBunks.Text = "Bunks"
        Me.btnBunks.UseVisualStyleBackColor = False
        '
        'btnInventory
        '
        Me.btnInventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInventory.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.Black
        Me.btnInventory.Location = New System.Drawing.Point(263, 145)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(119, 62)
        Me.btnInventory.TabIndex = 13
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = False
        '
        'btnUpdateShelves
        '
        Me.btnUpdateShelves.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateShelves.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnUpdateShelves.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateShelves.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateShelves.Location = New System.Drawing.Point(138, 145)
        Me.btnUpdateShelves.Name = "btnUpdateShelves"
        Me.btnUpdateShelves.Size = New System.Drawing.Size(119, 62)
        Me.btnUpdateShelves.TabIndex = 12
        Me.btnUpdateShelves.Text = "Update Shelves"
        Me.btnUpdateShelves.UseVisualStyleBackColor = False
        '
        'btnUserPrefs
        '
        Me.btnUserPrefs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUserPrefs.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnUserPrefs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserPrefs.ForeColor = System.Drawing.Color.Black
        Me.btnUserPrefs.Location = New System.Drawing.Point(138, 79)
        Me.btnUserPrefs.Name = "btnUserPrefs"
        Me.btnUserPrefs.Size = New System.Drawing.Size(119, 60)
        Me.btnUserPrefs.TabIndex = 11
        Me.btnUserPrefs.Text = "User Prefs"
        Me.btnUserPrefs.UseVisualStyleBackColor = False
        '
        'btnPositions
        '
        Me.btnPositions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPositions.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPositions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPositions.ForeColor = System.Drawing.Color.Black
        Me.btnPositions.Location = New System.Drawing.Point(13, 79)
        Me.btnPositions.Name = "btnPositions"
        Me.btnPositions.Size = New System.Drawing.Size(119, 60)
        Me.btnPositions.TabIndex = 9
        Me.btnPositions.Text = "Positions"
        Me.btnPositions.UseVisualStyleBackColor = False
        '
        'btnAccounts
        '
        Me.btnAccounts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccounts.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccounts.ForeColor = System.Drawing.Color.Black
        Me.btnAccounts.Location = New System.Drawing.Point(13, 13)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Padding = New System.Windows.Forms.Padding(10)
        Me.btnAccounts.Size = New System.Drawing.Size(119, 60)
        Me.btnAccounts.TabIndex = 8
        Me.btnAccounts.Text = "Accounts"
        Me.btnAccounts.UseVisualStyleBackColor = False
        '
        'btnUsers
        '
        Me.btnUsers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUsers.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.Black
        Me.btnUsers.Location = New System.Drawing.Point(138, 13)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Padding = New System.Windows.Forms.Padding(10)
        Me.btnUsers.Size = New System.Drawing.Size(119, 60)
        Me.btnUsers.TabIndex = 6
        Me.btnUsers.Text = "Users"
        Me.btnUsers.UseVisualStyleBackColor = False
        '
        'btnCats
        '
        Me.btnCats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCats.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCats.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCats.ForeColor = System.Drawing.Color.Black
        Me.btnCats.Location = New System.Drawing.Point(263, 79)
        Me.btnCats.Name = "btnCats"
        Me.btnCats.Size = New System.Drawing.Size(119, 60)
        Me.btnCats.TabIndex = 10
        Me.btnCats.Text = "Categories"
        Me.btnCats.UseVisualStyleBackColor = False
        '
        'btnItems
        '
        Me.btnItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnItems.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItems.ForeColor = System.Drawing.Color.Black
        Me.btnItems.Location = New System.Drawing.Point(263, 13)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Padding = New System.Windows.Forms.Padding(10)
        Me.btnItems.Size = New System.Drawing.Size(119, 60)
        Me.btnItems.TabIndex = 7
        Me.btnItems.Text = "Items"
        Me.btnItems.UseVisualStyleBackColor = False
        '
        'pnlCancel
        '
        Me.pnlCancel.Controls.Add(Me.btnTimeFrame)
        Me.pnlCancel.Controls.Add(Me.printReports)
        Me.pnlCancel.Controls.Add(Me.btnCancel)
        Me.pnlCancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlCancel.Location = New System.Drawing.Point(0, 416)
        Me.pnlCancel.Name = "pnlCancel"
        Me.pnlCancel.Size = New System.Drawing.Size(742, 100)
        Me.pnlCancel.TabIndex = 14
        '
        'btnTimeFrame
        '
        Me.btnTimeFrame.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTimeFrame.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnTimeFrame.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnTimeFrame.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeFrame.ForeColor = System.Drawing.Color.Black
        Me.btnTimeFrame.Location = New System.Drawing.Point(160, 17)
        Me.btnTimeFrame.Name = "btnTimeFrame"
        Me.btnTimeFrame.Size = New System.Drawing.Size(162, 62)
        Me.btnTimeFrame.TabIndex = 7
        Me.btnTimeFrame.Text = "Set Pre Order Time Frame"
        Me.btnTimeFrame.UseVisualStyleBackColor = False
        '
        'printReports
        '
        Me.printReports.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.printReports.BackColor = System.Drawing.Color.LightSteelBlue
        Me.printReports.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.printReports.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printReports.ForeColor = System.Drawing.Color.Black
        Me.printReports.Location = New System.Drawing.Point(12, 17)
        Me.printReports.Name = "printReports"
        Me.printReports.Size = New System.Drawing.Size(121, 62)
        Me.printReports.TabIndex = 7
        Me.printReports.Text = "Reports"
        Me.printReports.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Location = New System.Drawing.Point(627, 17)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 62)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(742, 516)
        Me.Controls.Add(Me.pnlCancel)
        Me.Controls.Add(Me.pnlAdminBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Admin"
        Me.pnlAdminBtn.ResumeLayout(False)
        Me.tlpAdminBtn.ResumeLayout(False)
        Me.pnlCancel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAdminBtn As System.Windows.Forms.Panel
    Friend WithEvents pnlCancel As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents tlpAdminBtn As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnBunks As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents btnUpdateShelves As System.Windows.Forms.Button
    Friend WithEvents btnUserPrefs As System.Windows.Forms.Button
    Friend WithEvents btnPositions As System.Windows.Forms.Button
    Friend WithEvents btnAccounts As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents btnCats As System.Windows.Forms.Button
    Friend WithEvents btnItems As System.Windows.Forms.Button
    Friend WithEvents printReports As System.Windows.Forms.Button
    Friend WithEvents btnTimeFrame As System.Windows.Forms.Button
End Class
