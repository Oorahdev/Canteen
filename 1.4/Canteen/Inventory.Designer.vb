<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Me.components = New System.ComponentModel.Container
        Dim INV_QtyShelfLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
        Me.TITMListBox = New System.Windows.Forms.ListBox
        Me.INV_IDTextBox = New System.Windows.Forms.TextBox
        Me.TINVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCanteen = New Canteen.dsCanteen
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.INV_QtyShelfTextBox = New System.Windows.Forms.TextBox
        Me.INV_QtyStockRoomCase = New System.Windows.Forms.TextBox
        Me.INV_ITM_IDTextBox = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.stockCaseUpdate = New System.Windows.Forms.TextBox
        Me.shelfUpdate = New System.Windows.Forms.TextBox
        Me.rbCases = New System.Windows.Forms.RadioButton
        Me.stockItemsUpdate = New System.Windows.Forms.TextBox
        Me.INV_QtyStockRoom = New System.Windows.Forms.TextBox
        Me.rbItems = New System.Windows.Forms.RadioButton
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.TITMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TITMTableAdapter = New Canteen.dsCanteenTableAdapters.tITMTableAdapter
        Me.TableAdapterManager = New Canteen.dsCanteenTableAdapters.TableAdapterManager
        Me.TINVTableAdapter = New Canteen.dsCanteenTableAdapters.tINVTableAdapter
        Me.btnDown = New System.Windows.Forms.Button
        Me.btnUp = New System.Windows.Forms.Button
        Me.AdmKeypad1 = New adm.admKeypad
        Me.QueriesTableAdapter1 = New Canteen.dsCanteenTableAdapters.QueriesTableAdapter
        INV_QtyShelfLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        CType(Me.TINVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TITMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'INV_QtyShelfLabel
        '
        INV_QtyShelfLabel.AutoSize = True
        INV_QtyShelfLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        INV_QtyShelfLabel.Location = New System.Drawing.Point(336, 84)
        INV_QtyShelfLabel.Name = "INV_QtyShelfLabel"
        INV_QtyShelfLabel.Size = New System.Drawing.Size(112, 24)
        INV_QtyShelfLabel.TabIndex = 4
        INV_QtyShelfLabel.Text = "Qty on Shelf"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(336, 119)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(153, 24)
        Label1.TabIndex = 52
        Label1.Text = "Qty in Stockroom"
        '
        'TITMListBox
        '
        Me.TITMListBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.TITMListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TITMListBox.FormattingEnabled = True
        Me.TITMListBox.ItemHeight = 18
        Me.TITMListBox.Location = New System.Drawing.Point(0, 0)
        Me.TITMListBox.Name = "TITMListBox"
        Me.TITMListBox.Size = New System.Drawing.Size(334, 526)
        Me.TITMListBox.TabIndex = 2
        '
        'INV_IDTextBox
        '
        Me.INV_IDTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.INV_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TINVBindingSource, "INV_ID", True))
        Me.INV_IDTextBox.Location = New System.Drawing.Point(563, 7)
        Me.INV_IDTextBox.Name = "INV_IDTextBox"
        Me.INV_IDTextBox.ReadOnly = True
        Me.INV_IDTextBox.Size = New System.Drawing.Size(47, 20)
        Me.INV_IDTextBox.TabIndex = 7
        '
        'TINVBindingSource
        '
        Me.TINVBindingSource.DataMember = "tINV"
        Me.TINVBindingSource.DataSource = Me.DsCanteen
        '
        'DsCanteen
        '
        Me.DsCanteen.DataSetName = "dsCanteen"
        Me.DsCanteen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDelete.Location = New System.Drawing.Point(343, 252)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 33)
        Me.btnDelete.TabIndex = 44
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Location = New System.Drawing.Point(583, 252)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 33)
        Me.btnCancel.TabIndex = 43
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(454, 253)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 32)
        Me.btnSave.TabIndex = 42
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'INV_QtyShelfTextBox
        '
        Me.INV_QtyShelfTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TINVBindingSource, "INV_QtyShelf", True))
        Me.INV_QtyShelfTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INV_QtyShelfTextBox.Location = New System.Drawing.Point(496, 82)
        Me.INV_QtyShelfTextBox.Name = "INV_QtyShelfTextBox"
        Me.INV_QtyShelfTextBox.ReadOnly = True
        Me.INV_QtyShelfTextBox.Size = New System.Drawing.Size(48, 29)
        Me.INV_QtyShelfTextBox.TabIndex = 46
        '
        'INV_QtyStockRoomCase
        '
        Me.INV_QtyStockRoomCase.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INV_QtyStockRoomCase.Location = New System.Drawing.Point(496, 155)
        Me.INV_QtyStockRoomCase.Name = "INV_QtyStockRoomCase"
        Me.INV_QtyStockRoomCase.ReadOnly = True
        Me.INV_QtyStockRoomCase.Size = New System.Drawing.Size(48, 29)
        Me.INV_QtyStockRoomCase.TabIndex = 47
        '
        'INV_ITM_IDTextBox
        '
        Me.INV_ITM_IDTextBox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.INV_ITM_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TINVBindingSource, "INV_ITM_ID", True))
        Me.INV_ITM_IDTextBox.Location = New System.Drawing.Point(620, 7)
        Me.INV_ITM_IDTextBox.Name = "INV_ITM_IDTextBox"
        Me.INV_ITM_IDTextBox.ReadOnly = True
        Me.INV_ITM_IDTextBox.Size = New System.Drawing.Size(47, 20)
        Me.INV_ITM_IDTextBox.TabIndex = 48
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"+", "-"})
        Me.ComboBox1.Location = New System.Drawing.Point(552, 80)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(58, 32)
        Me.ComboBox1.TabIndex = 53
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"+", "-"})
        Me.ComboBox2.Location = New System.Drawing.Point(552, 153)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(58, 32)
        Me.ComboBox2.TabIndex = 54
        '
        'stockCaseUpdate
        '
        Me.stockCaseUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockCaseUpdate.Location = New System.Drawing.Point(622, 155)
        Me.stockCaseUpdate.Name = "stockCaseUpdate"
        Me.stockCaseUpdate.Size = New System.Drawing.Size(48, 29)
        Me.stockCaseUpdate.TabIndex = 56
        '
        'shelfUpdate
        '
        Me.shelfUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shelfUpdate.Location = New System.Drawing.Point(622, 82)
        Me.shelfUpdate.Name = "shelfUpdate"
        Me.shelfUpdate.Size = New System.Drawing.Size(48, 29)
        Me.shelfUpdate.TabIndex = 55
        '
        'rbCases
        '
        Me.rbCases.AutoSize = True
        Me.rbCases.Checked = True
        Me.rbCases.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCases.Location = New System.Drawing.Point(338, 155)
        Me.rbCases.Name = "rbCases"
        Me.rbCases.Size = New System.Drawing.Size(80, 28)
        Me.rbCases.TabIndex = 57
        Me.rbCases.TabStop = True
        Me.rbCases.Text = "Cases"
        Me.rbCases.UseVisualStyleBackColor = True
        '
        'stockItemsUpdate
        '
        Me.stockItemsUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockItemsUpdate.Location = New System.Drawing.Point(622, 200)
        Me.stockItemsUpdate.Name = "stockItemsUpdate"
        Me.stockItemsUpdate.Size = New System.Drawing.Size(48, 29)
        Me.stockItemsUpdate.TabIndex = 58
        '
        'INV_QtyStockRoom
        '
        Me.INV_QtyStockRoom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TINVBindingSource, "INV_QtyStockRoom", True))
        Me.INV_QtyStockRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INV_QtyStockRoom.Location = New System.Drawing.Point(495, 200)
        Me.INV_QtyStockRoom.Name = "INV_QtyStockRoom"
        Me.INV_QtyStockRoom.ReadOnly = True
        Me.INV_QtyStockRoom.Size = New System.Drawing.Size(48, 29)
        Me.INV_QtyStockRoom.TabIndex = 60
        '
        'rbItems
        '
        Me.rbItems.AutoSize = True
        Me.rbItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbItems.Location = New System.Drawing.Point(338, 200)
        Me.rbItems.Name = "rbItems"
        Me.rbItems.Size = New System.Drawing.Size(156, 28)
        Me.rbItems.TabIndex = 61
        Me.rbItems.TabStop = True
        Me.rbItems.Text = "Individual Items"
        Me.rbItems.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"+", "-"})
        Me.ComboBox3.Location = New System.Drawing.Point(552, 198)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(58, 32)
        Me.ComboBox3.TabIndex = 62
        '
        'TITMBindingSource
        '
        Me.TITMBindingSource.DataMember = "tITM"
        Me.TITMBindingSource.DataSource = Me.DsCanteen
        '
        'TITMTableAdapter
        '
        Me.TITMTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tACTTableAdapter = Nothing
        Me.TableAdapterManager.tBNKTableAdapter = Nothing
        Me.TableAdapterManager.tCTGTableAdapter = Nothing
        Me.TableAdapterManager.tINTTableAdapter = Nothing
        Me.TableAdapterManager.tINVTableAdapter = Me.TINVTableAdapter
        Me.TableAdapterManager.tITMTableAdapter = Me.TITMTableAdapter
        Me.TableAdapterManager.tORDTableAdapter = Nothing
        Me.TableAdapterManager.tORSTableAdapter = Nothing
        Me.TableAdapterManager.tPRFTableAdapter = Nothing
        Me.TableAdapterManager.tPSNTableAdapter = Nothing
        Me.TableAdapterManager.tTRNTableAdapter = Nothing
        Me.TableAdapterManager.tUSRTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Canteen.dsCanteenTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TINVTableAdapter
        '
        Me.TINVTableAdapter.ClearBeforeFill = True
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDown.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(340, 40)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(32, 37)
        Me.btnDown.TabIndex = 64
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnUp.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(340, 1)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(32, 37)
        Me.btnUp.TabIndex = 63
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'AdmKeypad1
        '
        Me.AdmKeypad1.DisplayOperators = False
        Me.AdmKeypad1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AdmKeypad1.Location = New System.Drawing.Point(334, 305)
        Me.AdmKeypad1.Margin = New System.Windows.Forms.Padding(0)
        Me.AdmKeypad1.ModifierKeys = New System.Windows.Forms.Keys(-1) {}
        Me.AdmKeypad1.Name = "AdmKeypad1"
        Me.AdmKeypad1.Size = New System.Drawing.Size(344, 231)
        Me.AdmKeypad1.TabIndex = 65
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(678, 536)
        Me.Controls.Add(Me.INV_QtyStockRoom)
        Me.Controls.Add(Me.AdmKeypad1)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.rbItems)
        Me.Controls.Add(Me.stockItemsUpdate)
        Me.Controls.Add(Me.rbCases)
        Me.Controls.Add(Me.stockCaseUpdate)
        Me.Controls.Add(Me.shelfUpdate)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.INV_ITM_IDTextBox)
        Me.Controls.Add(Me.INV_QtyStockRoomCase)
        Me.Controls.Add(Me.INV_QtyShelfTextBox)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.INV_IDTextBox)
        Me.Controls.Add(INV_QtyShelfLabel)
        Me.Controls.Add(Me.TITMListBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inventory"
        CType(Me.TINVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TITMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsCanteen As Canteen.dsCanteen
    Friend WithEvents TITMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TITMTableAdapter As Canteen.dsCanteenTableAdapters.tITMTableAdapter
    Friend WithEvents TableAdapterManager As Canteen.dsCanteenTableAdapters.TableAdapterManager
    Friend WithEvents TINVTableAdapter As Canteen.dsCanteenTableAdapters.tINVTableAdapter
    Friend WithEvents TITMListBox As System.Windows.Forms.ListBox
    Friend WithEvents TINVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INV_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents INV_QtyShelfTextBox As System.Windows.Forms.TextBox
    Friend WithEvents INV_QtyStockRoomCase As System.Windows.Forms.TextBox
    Friend WithEvents INV_ITM_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents stockCaseUpdate As System.Windows.Forms.TextBox
    Friend WithEvents shelfUpdate As System.Windows.Forms.TextBox
    Friend WithEvents rbCases As System.Windows.Forms.RadioButton
    Friend WithEvents stockItemsUpdate As System.Windows.Forms.TextBox
    Friend WithEvents INV_QtyStockRoom As System.Windows.Forms.TextBox
    Friend WithEvents rbItems As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents AdmKeypad1 As adm.admKeypad
    Friend WithEvents QueriesTableAdapter1 As Canteen.dsCanteenTableAdapters.QueriesTableAdapter
End Class
