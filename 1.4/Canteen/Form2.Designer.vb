<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim ITM_IDLabel As System.Windows.Forms.Label
        Dim ITM_NumberLabel As System.Windows.Forms.Label
        Dim ITM_NameLabel As System.Windows.Forms.Label
        Dim ITM_CTG_IDLabel As System.Windows.Forms.Label
        Dim ITM_PlacementLabel As System.Windows.Forms.Label
        Dim ITM_PriceLabel As System.Windows.Forms.Label
        Dim ITM_PrinterLabel As System.Windows.Forms.Label
        Dim ITM_QtyPerShelfLabel As System.Windows.Forms.Label
        Dim ITM_QtyPerUnitLabel As System.Windows.Forms.Label
        Dim ITM_ReorderLevelLabel As System.Windows.Forms.Label
        Me.DsCanteen = New Canteen.dsCanteen
        Me.TITMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TITMTableAdapter = New Canteen.dsCanteenTableAdapters.tITMTableAdapter
        Me.TableAdapterManager = New Canteen.dsCanteenTableAdapters.TableAdapterManager
        Me.TITMBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.TITMBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ITM_IDTextBox = New System.Windows.Forms.TextBox
        Me.ITM_NumberTextBox = New System.Windows.Forms.TextBox
        Me.ITM_NameTextBox = New System.Windows.Forms.TextBox
        Me.ITM_CTG_IDTextBox = New System.Windows.Forms.TextBox
        Me.ITM_PlacementTextBox = New System.Windows.Forms.TextBox
        Me.ITM_PriceTextBox = New System.Windows.Forms.TextBox
        Me.ITM_PrinterTextBox = New System.Windows.Forms.TextBox
        Me.ITM_QtyPerShelfTextBox = New System.Windows.Forms.TextBox
        Me.ITM_QtyPerUnitTextBox = New System.Windows.Forms.TextBox
        Me.ITM_ReorderLevelTextBox = New System.Windows.Forms.TextBox
        ITM_IDLabel = New System.Windows.Forms.Label
        ITM_NumberLabel = New System.Windows.Forms.Label
        ITM_NameLabel = New System.Windows.Forms.Label
        ITM_CTG_IDLabel = New System.Windows.Forms.Label
        ITM_PlacementLabel = New System.Windows.Forms.Label
        ITM_PriceLabel = New System.Windows.Forms.Label
        ITM_PrinterLabel = New System.Windows.Forms.Label
        ITM_QtyPerShelfLabel = New System.Windows.Forms.Label
        ITM_QtyPerUnitLabel = New System.Windows.Forms.Label
        ITM_ReorderLevelLabel = New System.Windows.Forms.Label
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TITMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TITMBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TITMBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DsCanteen
        '
        Me.DsCanteen.DataSetName = "dsCanteen"
        Me.DsCanteen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Me.TableAdapterManager.ActDisplayTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tACTTableAdapter = Nothing
        Me.TableAdapterManager.tBNKTableAdapter = Nothing
        Me.TableAdapterManager.tCTGTableAdapter = Nothing
        Me.TableAdapterManager.tINTTableAdapter = Nothing
        Me.TableAdapterManager.tINVTableAdapter = Nothing
        Me.TableAdapterManager.tITMTableAdapter = Me.TITMTableAdapter
        Me.TableAdapterManager.tORDTableAdapter = Nothing
        Me.TableAdapterManager.tORSTableAdapter = Nothing
        Me.TableAdapterManager.tPRFTableAdapter = Nothing
        Me.TableAdapterManager.tPSNTableAdapter = Nothing
        Me.TableAdapterManager.tTRNTableAdapter = Nothing
        Me.TableAdapterManager.tUSRTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Canteen.dsCanteenTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TITMBindingNavigator
        '
        Me.TITMBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TITMBindingNavigator.BindingSource = Me.TITMBindingSource
        Me.TITMBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TITMBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TITMBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TITMBindingNavigatorSaveItem})
        Me.TITMBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TITMBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TITMBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TITMBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TITMBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TITMBindingNavigator.Name = "TITMBindingNavigator"
        Me.TITMBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TITMBindingNavigator.Size = New System.Drawing.Size(557, 25)
        Me.TITMBindingNavigator.TabIndex = 0
        Me.TITMBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 13)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TITMBindingNavigatorSaveItem
        '
        Me.TITMBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TITMBindingNavigatorSaveItem.Image = CType(resources.GetObject("TITMBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TITMBindingNavigatorSaveItem.Name = "TITMBindingNavigatorSaveItem"
        Me.TITMBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TITMBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ITM_IDLabel
        '
        ITM_IDLabel.AutoSize = True
        ITM_IDLabel.Location = New System.Drawing.Point(42, 50)
        ITM_IDLabel.Name = "ITM_IDLabel"
        ITM_IDLabel.Size = New System.Drawing.Size(43, 13)
        ITM_IDLabel.TabIndex = 1
        ITM_IDLabel.Text = "ITM ID:"
        '
        'ITM_IDTextBox
        '
        Me.ITM_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TITMBindingSource, "ITM_ID", True))
        Me.ITM_IDTextBox.Location = New System.Drawing.Point(147, 47)
        Me.ITM_IDTextBox.Name = "ITM_IDTextBox"
        Me.ITM_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ITM_IDTextBox.TabIndex = 2
        '
        'ITM_NumberLabel
        '
        ITM_NumberLabel.AutoSize = True
        ITM_NumberLabel.Location = New System.Drawing.Point(42, 76)
        ITM_NumberLabel.Name = "ITM_NumberLabel"
        ITM_NumberLabel.Size = New System.Drawing.Size(69, 13)
        ITM_NumberLabel.TabIndex = 3
        ITM_NumberLabel.Text = "ITM Number:"
        '
        'ITM_NumberTextBox
        '
        Me.ITM_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TITMBindingSource, "ITM_Number", True))
        Me.ITM_NumberTextBox.Location = New System.Drawing.Point(147, 73)
        Me.ITM_NumberTextBox.Name = "ITM_NumberTextBox"
        Me.ITM_NumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ITM_NumberTextBox.TabIndex = 4
        '
        'ITM_NameLabel
        '
        ITM_NameLabel.AutoSize = True
        ITM_NameLabel.Location = New System.Drawing.Point(42, 102)
        ITM_NameLabel.Name = "ITM_NameLabel"
        ITM_NameLabel.Size = New System.Drawing.Size(60, 13)
        ITM_NameLabel.TabIndex = 5
        ITM_NameLabel.Text = "ITM Name:"
        '
        'ITM_NameTextBox
        '
        Me.ITM_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TITMBindingSource, "ITM_Name", True))
        Me.ITM_NameTextBox.Location = New System.Drawing.Point(147, 99)
        Me.ITM_NameTextBox.Name = "ITM_NameTextBox"
        Me.ITM_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ITM_NameTextBox.TabIndex = 6
        '
        'ITM_CTG_IDLabel
        '
        ITM_CTG_IDLabel.AutoSize = True
        ITM_CTG_IDLabel.Location = New System.Drawing.Point(42, 128)
        ITM_CTG_IDLabel.Name = "ITM_CTG_IDLabel"
        ITM_CTG_IDLabel.Size = New System.Drawing.Size(68, 13)
        ITM_CTG_IDLabel.TabIndex = 7
        ITM_CTG_IDLabel.Text = "ITM CTG ID:"
        '
        'ITM_CTG_IDTextBox
        '
        Me.ITM_CTG_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TITMBindingSource, "ITM_CTG_ID", True))
        Me.ITM_CTG_IDTextBox.Location = New System.Drawing.Point(147, 125)
        Me.ITM_CTG_IDTextBox.Name = "ITM_CTG_IDTextBox"
        Me.ITM_CTG_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ITM_CTG_IDTextBox.TabIndex = 8
        '
        'ITM_PlacementLabel
        '
        ITM_PlacementLabel.AutoSize = True
        ITM_PlacementLabel.Location = New System.Drawing.Point(42, 154)
        ITM_PlacementLabel.Name = "ITM_PlacementLabel"
        ITM_PlacementLabel.Size = New System.Drawing.Size(82, 13)
        ITM_PlacementLabel.TabIndex = 9
        ITM_PlacementLabel.Text = "ITM Placement:"
        '
        'ITM_PlacementTextBox
        '
        Me.ITM_PlacementTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TITMBindingSource, "ITM_Placement", True))
        Me.ITM_PlacementTextBox.Location = New System.Drawing.Point(147, 151)
        Me.ITM_PlacementTextBox.Name = "ITM_PlacementTextBox"
        Me.ITM_PlacementTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ITM_PlacementTextBox.TabIndex = 10
        '
        'ITM_PriceLabel
        '
        ITM_PriceLabel.AutoSize = True
        ITM_PriceLabel.Location = New System.Drawing.Point(42, 180)
        ITM_PriceLabel.Name = "ITM_PriceLabel"
        ITM_PriceLabel.Size = New System.Drawing.Size(56, 13)
        ITM_PriceLabel.TabIndex = 11
        ITM_PriceLabel.Text = "ITM Price:"
        '
        'ITM_PriceTextBox
        '
        Me.ITM_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TITMBindingSource, "ITM_Price", True))
        Me.ITM_PriceTextBox.Location = New System.Drawing.Point(147, 177)
        Me.ITM_PriceTextBox.Name = "ITM_PriceTextBox"
        Me.ITM_PriceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ITM_PriceTextBox.TabIndex = 12
        '
        'ITM_PrinterLabel
        '
        ITM_PrinterLabel.AutoSize = True
        ITM_PrinterLabel.Location = New System.Drawing.Point(42, 206)
        ITM_PrinterLabel.Name = "ITM_PrinterLabel"
        ITM_PrinterLabel.Size = New System.Drawing.Size(62, 13)
        ITM_PrinterLabel.TabIndex = 13
        ITM_PrinterLabel.Text = "ITM Printer:"
        '
        'ITM_PrinterTextBox
        '
        Me.ITM_PrinterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TITMBindingSource, "ITM_Printer", True))
        Me.ITM_PrinterTextBox.Location = New System.Drawing.Point(147, 203)
        Me.ITM_PrinterTextBox.Name = "ITM_PrinterTextBox"
        Me.ITM_PrinterTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ITM_PrinterTextBox.TabIndex = 14
        '
        'ITM_QtyPerShelfLabel
        '
        ITM_QtyPerShelfLabel.AutoSize = True
        ITM_QtyPerShelfLabel.Location = New System.Drawing.Point(42, 232)
        ITM_QtyPerShelfLabel.Name = "ITM_QtyPerShelfLabel"
        ITM_QtyPerShelfLabel.Size = New System.Drawing.Size(94, 13)
        ITM_QtyPerShelfLabel.TabIndex = 15
        ITM_QtyPerShelfLabel.Text = "ITM Qty Per Shelf:"
        '
        'ITM_QtyPerShelfTextBox
        '
        Me.ITM_QtyPerShelfTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TITMBindingSource, "ITM_QtyPerShelf", True))
        Me.ITM_QtyPerShelfTextBox.Location = New System.Drawing.Point(147, 229)
        Me.ITM_QtyPerShelfTextBox.Name = "ITM_QtyPerShelfTextBox"
        Me.ITM_QtyPerShelfTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ITM_QtyPerShelfTextBox.TabIndex = 16
        '
        'ITM_QtyPerUnitLabel
        '
        ITM_QtyPerUnitLabel.AutoSize = True
        ITM_QtyPerUnitLabel.Location = New System.Drawing.Point(42, 258)
        ITM_QtyPerUnitLabel.Name = "ITM_QtyPerUnitLabel"
        ITM_QtyPerUnitLabel.Size = New System.Drawing.Size(89, 13)
        ITM_QtyPerUnitLabel.TabIndex = 17
        ITM_QtyPerUnitLabel.Text = "ITM Qty Per Unit:"
        '
        'ITM_QtyPerUnitTextBox
        '
        Me.ITM_QtyPerUnitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TITMBindingSource, "ITM_QtyPerUnit", True))
        Me.ITM_QtyPerUnitTextBox.Location = New System.Drawing.Point(147, 255)
        Me.ITM_QtyPerUnitTextBox.Name = "ITM_QtyPerUnitTextBox"
        Me.ITM_QtyPerUnitTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ITM_QtyPerUnitTextBox.TabIndex = 18
        '
        'ITM_ReorderLevelLabel
        '
        ITM_ReorderLevelLabel.AutoSize = True
        ITM_ReorderLevelLabel.Location = New System.Drawing.Point(42, 284)
        ITM_ReorderLevelLabel.Name = "ITM_ReorderLevelLabel"
        ITM_ReorderLevelLabel.Size = New System.Drawing.Size(99, 13)
        ITM_ReorderLevelLabel.TabIndex = 19
        ITM_ReorderLevelLabel.Text = "ITM Reorder Level:"
        '
        'ITM_ReorderLevelTextBox
        '
        Me.ITM_ReorderLevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TITMBindingSource, "ITM_ReorderLevel", True))
        Me.ITM_ReorderLevelTextBox.Location = New System.Drawing.Point(147, 281)
        Me.ITM_ReorderLevelTextBox.Name = "ITM_ReorderLevelTextBox"
        Me.ITM_ReorderLevelTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ITM_ReorderLevelTextBox.TabIndex = 20
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 514)
        Me.Controls.Add(ITM_IDLabel)
        Me.Controls.Add(Me.ITM_IDTextBox)
        Me.Controls.Add(ITM_NumberLabel)
        Me.Controls.Add(Me.ITM_NumberTextBox)
        Me.Controls.Add(ITM_NameLabel)
        Me.Controls.Add(Me.ITM_NameTextBox)
        Me.Controls.Add(ITM_CTG_IDLabel)
        Me.Controls.Add(Me.ITM_CTG_IDTextBox)
        Me.Controls.Add(ITM_PlacementLabel)
        Me.Controls.Add(Me.ITM_PlacementTextBox)
        Me.Controls.Add(ITM_PriceLabel)
        Me.Controls.Add(Me.ITM_PriceTextBox)
        Me.Controls.Add(ITM_PrinterLabel)
        Me.Controls.Add(Me.ITM_PrinterTextBox)
        Me.Controls.Add(ITM_QtyPerShelfLabel)
        Me.Controls.Add(Me.ITM_QtyPerShelfTextBox)
        Me.Controls.Add(ITM_QtyPerUnitLabel)
        Me.Controls.Add(Me.ITM_QtyPerUnitTextBox)
        Me.Controls.Add(ITM_ReorderLevelLabel)
        Me.Controls.Add(Me.ITM_ReorderLevelTextBox)
        Me.Controls.Add(Me.TITMBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TITMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TITMBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TITMBindingNavigator.ResumeLayout(False)
        Me.TITMBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsCanteen As Canteen.dsCanteen
    Friend WithEvents TITMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TITMTableAdapter As Canteen.dsCanteenTableAdapters.tITMTableAdapter
    Friend WithEvents TableAdapterManager As Canteen.dsCanteenTableAdapters.TableAdapterManager
    Friend WithEvents TITMBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TITMBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ITM_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITM_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITM_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITM_CTG_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITM_PlacementTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITM_PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITM_PrinterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITM_QtyPerShelfTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITM_QtyPerUnitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ITM_ReorderLevelTextBox As System.Windows.Forms.TextBox
End Class
