<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items
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
        Dim lblItmName As System.Windows.Forms.Label
        Dim lblItmCatId As System.Windows.Forms.Label
        Dim lblItmPlcmnt As System.Windows.Forms.Label
        Dim lblItmPrice As System.Windows.Forms.Label
        Dim lblItmPrinter As System.Windows.Forms.Label
        Dim lblItmQtyShelf As System.Windows.Forms.Label
        Dim lblItmQtyUnit As System.Windows.Forms.Label
        Dim lblItmReorder As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Items))
        Me.pnlKeyboard = New System.Windows.Forms.Panel
        Me.AdmKeyboard1 = New adm.admKeyboard
        Me.txbName = New System.Windows.Forms.TextBox
        Me.cboCatId = New System.Windows.Forms.ComboBox
        Me.txbPrice = New System.Windows.Forms.TextBox
        Me.txbQtyShelf = New System.Windows.Forms.TextBox
        Me.txbQtyUnit = New System.Windows.Forms.TextBox
        Me.txbReorder = New System.Windows.Forms.TextBox
        Me.lsbItems = New System.Windows.Forms.ListBox
        Me.pnlItems = New System.Windows.Forms.Panel
        Me.btnDown = New System.Windows.Forms.Button
        Me.btnUp = New System.Windows.Forms.Button
        Me.cboPrinter = New System.Windows.Forms.ComboBox
        Me.cboPlacement = New System.Windows.Forms.ComboBox
        Me.lblError = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblItems = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.DsCanteen = New Canteen.dsCanteen
        Me.TITMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TITMTableAdapter = New Canteen.dsCanteenTableAdapters.tITMTableAdapter
        Me.TableAdapterManager = New Canteen.dsCanteenTableAdapters.TableAdapterManager
        Me.TCTGTableAdapter1 = New Canteen.dsCanteenTableAdapters.tCTGTableAdapter
        Me.AvailableCtgPlacementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AvailableCtgPlacementTableAdapter = New Canteen.dsCanteenTableAdapters.AvailableCtgPlacementTableAdapter
        Me.PRFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRFTableAdapter = New Canteen.dsCanteenTableAdapters.PRFTableAdapter
        Me.CtgPlacementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CtgPlacementTableAdapter = New Canteen.dsCanteenTableAdapters.CtgPlacementTableAdapter
        Me.TITMTableAdapter1 = New Canteen.dsCanteenTableAdapters.tITMTableAdapter
        lblItmName = New System.Windows.Forms.Label
        lblItmCatId = New System.Windows.Forms.Label
        lblItmPlcmnt = New System.Windows.Forms.Label
        lblItmPrice = New System.Windows.Forms.Label
        lblItmPrinter = New System.Windows.Forms.Label
        lblItmQtyShelf = New System.Windows.Forms.Label
        lblItmQtyUnit = New System.Windows.Forms.Label
        lblItmReorder = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Me.pnlKeyboard.SuspendLayout()
        Me.pnlItems.SuspendLayout()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TITMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvailableCtgPlacementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtgPlacementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblItmName
        '
        lblItmName.AutoSize = True
        lblItmName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblItmName.Location = New System.Drawing.Point(274, 53)
        lblItmName.Name = "lblItmName"
        lblItmName.Size = New System.Drawing.Size(49, 16)
        lblItmName.TabIndex = 14
        lblItmName.Text = "Name:"
        '
        'lblItmCatId
        '
        lblItmCatId.AutoSize = True
        lblItmCatId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblItmCatId.Location = New System.Drawing.Point(274, 79)
        lblItmCatId.Name = "lblItmCatId"
        lblItmCatId.Size = New System.Drawing.Size(86, 16)
        lblItmCatId.TabIndex = 16
        lblItmCatId.Text = "Category ID:"
        '
        'lblItmPlcmnt
        '
        lblItmPlcmnt.AutoSize = True
        lblItmPlcmnt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblItmPlcmnt.Location = New System.Drawing.Point(274, 108)
        lblItmPlcmnt.Name = "lblItmPlcmnt"
        lblItmPlcmnt.Size = New System.Drawing.Size(80, 16)
        lblItmPlcmnt.TabIndex = 18
        lblItmPlcmnt.Text = "Placement:"
        '
        'lblItmPrice
        '
        lblItmPrice.AutoSize = True
        lblItmPrice.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblItmPrice.Location = New System.Drawing.Point(274, 132)
        lblItmPrice.Name = "lblItmPrice"
        lblItmPrice.Size = New System.Drawing.Size(45, 16)
        lblItmPrice.TabIndex = 20
        lblItmPrice.Text = "Price:"
        '
        'lblItmPrinter
        '
        lblItmPrinter.AutoSize = True
        lblItmPrinter.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblItmPrinter.Location = New System.Drawing.Point(274, 159)
        lblItmPrinter.Name = "lblItmPrinter"
        lblItmPrinter.Size = New System.Drawing.Size(55, 16)
        lblItmPrinter.TabIndex = 22
        lblItmPrinter.Text = "Printer:"
        '
        'lblItmQtyShelf
        '
        lblItmQtyShelf.AutoSize = True
        lblItmQtyShelf.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblItmQtyShelf.Location = New System.Drawing.Point(274, 185)
        lblItmQtyShelf.Name = "lblItmQtyShelf"
        lblItmQtyShelf.Size = New System.Drawing.Size(124, 16)
        lblItmQtyShelf.TabIndex = 24
        lblItmQtyShelf.Text = "Quantity On Shelf:"
        '
        'lblItmQtyUnit
        '
        lblItmQtyUnit.AutoSize = True
        lblItmQtyUnit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblItmQtyUnit.Location = New System.Drawing.Point(274, 211)
        lblItmQtyUnit.Name = "lblItmQtyUnit"
        lblItmQtyUnit.Size = New System.Drawing.Size(120, 16)
        lblItmQtyUnit.TabIndex = 26
        lblItmQtyUnit.Text = "Quantity Per Unit:"
        '
        'lblItmReorder
        '
        lblItmReorder.AutoSize = True
        lblItmReorder.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblItmReorder.Location = New System.Drawing.Point(274, 237)
        lblItmReorder.Name = "lblItmReorder"
        lblItmReorder.Size = New System.Drawing.Size(102, 16)
        lblItmReorder.TabIndex = 28
        lblItmReorder.Text = "Reorder Level:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(487, 242)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(94, 14)
        Label1.TabIndex = 44
        Label1.Text = "Individual Items"
        '
        'pnlKeyboard
        '
        Me.pnlKeyboard.Controls.Add(Me.AdmKeyboard1)
        Me.pnlKeyboard.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlKeyboard.Location = New System.Drawing.Point(0, 288)
        Me.pnlKeyboard.Name = "pnlKeyboard"
        Me.pnlKeyboard.Size = New System.Drawing.Size(742, 241)
        Me.pnlKeyboard.TabIndex = 9
        '
        'AdmKeyboard1
        '
        Me.AdmKeyboard1.BackColor = System.Drawing.Color.SteelBlue
        Me.AdmKeyboard1.DisplayAlt = False
        Me.AdmKeyboard1.DisplayCtrl = False
        Me.AdmKeyboard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdmKeyboard1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AdmKeyboard1.Location = New System.Drawing.Point(0, 0)
        Me.AdmKeyboard1.Margin = New System.Windows.Forms.Padding(0)
        Me.AdmKeyboard1.ModifierKeys = New System.Windows.Forms.Keys(-1) {}
        Me.AdmKeyboard1.Name = "AdmKeyboard1"
        Me.AdmKeyboard1.Size = New System.Drawing.Size(742, 241)
        Me.AdmKeyboard1.TabIndex = 5
        '
        'txbName
        '
        Me.txbName.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbName.ForeColor = System.Drawing.Color.Black
        Me.txbName.Location = New System.Drawing.Point(410, 50)
        Me.txbName.Name = "txbName"
        Me.txbName.Size = New System.Drawing.Size(170, 25)
        Me.txbName.TabIndex = 1
        '
        'cboCatId
        '
        Me.cboCatId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCatId.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCatId.ForeColor = System.Drawing.Color.Black
        Me.cboCatId.FormattingEnabled = True
        Me.cboCatId.Location = New System.Drawing.Point(410, 76)
        Me.cboCatId.Name = "cboCatId"
        Me.cboCatId.Size = New System.Drawing.Size(170, 26)
        Me.cboCatId.TabIndex = 2
        '
        'txbPrice
        '
        Me.txbPrice.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPrice.ForeColor = System.Drawing.Color.Black
        Me.txbPrice.Location = New System.Drawing.Point(410, 130)
        Me.txbPrice.Name = "txbPrice"
        Me.txbPrice.Size = New System.Drawing.Size(170, 25)
        Me.txbPrice.TabIndex = 4
        '
        'txbQtyShelf
        '
        Me.txbQtyShelf.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbQtyShelf.ForeColor = System.Drawing.Color.Black
        Me.txbQtyShelf.Location = New System.Drawing.Point(410, 183)
        Me.txbQtyShelf.Name = "txbQtyShelf"
        Me.txbQtyShelf.Size = New System.Drawing.Size(170, 25)
        Me.txbQtyShelf.TabIndex = 6
        '
        'txbQtyUnit
        '
        Me.txbQtyUnit.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbQtyUnit.ForeColor = System.Drawing.Color.Black
        Me.txbQtyUnit.Location = New System.Drawing.Point(410, 209)
        Me.txbQtyUnit.Name = "txbQtyUnit"
        Me.txbQtyUnit.Size = New System.Drawing.Size(170, 25)
        Me.txbQtyUnit.TabIndex = 7
        '
        'txbReorder
        '
        Me.txbReorder.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbReorder.ForeColor = System.Drawing.Color.Black
        Me.txbReorder.Location = New System.Drawing.Point(410, 235)
        Me.txbReorder.Name = "txbReorder"
        Me.txbReorder.Size = New System.Drawing.Size(73, 25)
        Me.txbReorder.TabIndex = 8
        '
        'lsbItems
        '
        Me.lsbItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lsbItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsbItems.ForeColor = System.Drawing.Color.Black
        Me.lsbItems.FormattingEnabled = True
        Me.lsbItems.ItemHeight = 20
        Me.lsbItems.Location = New System.Drawing.Point(10, 35)
        Me.lsbItems.Name = "lsbItems"
        Me.lsbItems.Size = New System.Drawing.Size(219, 244)
        Me.lsbItems.TabIndex = 30
        '
        'pnlItems
        '
        Me.pnlItems.Controls.Add(Label1)
        Me.pnlItems.Controls.Add(Me.btnDown)
        Me.pnlItems.Controls.Add(Me.btnUp)
        Me.pnlItems.Controls.Add(Me.cboPrinter)
        Me.pnlItems.Controls.Add(Me.cboPlacement)
        Me.pnlItems.Controls.Add(Me.lblError)
        Me.pnlItems.Controls.Add(Me.btnCancel)
        Me.pnlItems.Controls.Add(Me.lblItems)
        Me.pnlItems.Controls.Add(Me.btnDelete)
        Me.pnlItems.Controls.Add(Me.btnNew)
        Me.pnlItems.Controls.Add(Me.btnSave)
        Me.pnlItems.Controls.Add(Me.txbReorder)
        Me.pnlItems.Controls.Add(lblItmReorder)
        Me.pnlItems.Controls.Add(Me.txbQtyUnit)
        Me.pnlItems.Controls.Add(lblItmQtyUnit)
        Me.pnlItems.Controls.Add(Me.txbQtyShelf)
        Me.pnlItems.Controls.Add(lblItmQtyShelf)
        Me.pnlItems.Controls.Add(lblItmPrinter)
        Me.pnlItems.Controls.Add(Me.txbPrice)
        Me.pnlItems.Controls.Add(lblItmPrice)
        Me.pnlItems.Controls.Add(lblItmPlcmnt)
        Me.pnlItems.Controls.Add(Me.cboCatId)
        Me.pnlItems.Controls.Add(lblItmCatId)
        Me.pnlItems.Controls.Add(Me.txbName)
        Me.pnlItems.Controls.Add(lblItmName)
        Me.pnlItems.Controls.Add(Me.lsbItems)
        Me.pnlItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlItems.Location = New System.Drawing.Point(0, 0)
        Me.pnlItems.Name = "pnlItems"
        Me.pnlItems.Size = New System.Drawing.Size(742, 288)
        Me.pnlItems.TabIndex = 0
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDown.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(232, 74)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(32, 37)
        Me.btnDown.TabIndex = 43
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnUp.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(232, 35)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(32, 37)
        Me.btnUp.TabIndex = 42
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'cboPrinter
        '
        Me.cboPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrinter.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPrinter.ForeColor = System.Drawing.Color.Black
        Me.cboPrinter.FormattingEnabled = True
        Me.cboPrinter.Location = New System.Drawing.Point(410, 156)
        Me.cboPrinter.Name = "cboPrinter"
        Me.cboPrinter.Size = New System.Drawing.Size(170, 26)
        Me.cboPrinter.TabIndex = 5
        '
        'cboPlacement
        '
        Me.cboPlacement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlacement.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPlacement.ForeColor = System.Drawing.Color.Black
        Me.cboPlacement.FormattingEnabled = True
        Me.cboPlacement.Location = New System.Drawing.Point(410, 103)
        Me.cboPlacement.Name = "cboPlacement"
        Me.cboPlacement.Size = New System.Drawing.Size(170, 26)
        Me.cboPlacement.TabIndex = 3
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblError.Location = New System.Drawing.Point(229, 9)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 16)
        Me.lblError.TabIndex = 41
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Location = New System.Drawing.Point(614, 203)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 33)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblItems.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblItems.Location = New System.Drawing.Point(8, 9)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(65, 24)
        Me.lblItems.TabIndex = 39
        Me.lblItems.Text = "Items:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDelete.Location = New System.Drawing.Point(614, 71)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 33)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Location = New System.Drawing.Point(599, 116)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(116, 32)
        Me.btnNew.TabIndex = 10
        Me.btnNew.Text = "New Item"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(599, 160)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 32)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
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
        'TCTGTableAdapter1
        '
        Me.TCTGTableAdapter1.ClearBeforeFill = True
        '
        'AvailableCtgPlacementBindingSource
        '
        Me.AvailableCtgPlacementBindingSource.DataMember = "AvailableCtgPlacement"
        Me.AvailableCtgPlacementBindingSource.DataSource = Me.DsCanteen
        '
        'AvailableCtgPlacementTableAdapter
        '
        Me.AvailableCtgPlacementTableAdapter.ClearBeforeFill = True
        '
        'PRFBindingSource
        '
        Me.PRFBindingSource.DataMember = "PRF"
        Me.PRFBindingSource.DataSource = Me.DsCanteen
        '
        'PRFTableAdapter
        '
        Me.PRFTableAdapter.ClearBeforeFill = True
        '
        'CtgPlacementBindingSource
        '
        Me.CtgPlacementBindingSource.DataMember = "CtgPlacement"
        Me.CtgPlacementBindingSource.DataSource = Me.DsCanteen
        '
        'CtgPlacementTableAdapter
        '
        Me.CtgPlacementTableAdapter.ClearBeforeFill = True
        '
        'TITMTableAdapter1
        '
        Me.TITMTableAdapter1.ClearBeforeFill = True
        '
        'Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(742, 529)
        Me.Controls.Add(Me.pnlItems)
        Me.Controls.Add(Me.pnlKeyboard)
        Me.ForeColor = System.Drawing.Color.SteelBlue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Items"
        Me.pnlKeyboard.ResumeLayout(False)
        Me.pnlItems.ResumeLayout(False)
        Me.pnlItems.PerformLayout()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TITMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvailableCtgPlacementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtgPlacementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlKeyboard As System.Windows.Forms.Panel
    Friend WithEvents AdmKeyboard1 As adm.admKeyboard
    Friend WithEvents DsCanteen As Canteen.dsCanteen
    Friend WithEvents TITMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TITMTableAdapter As Canteen.dsCanteenTableAdapters.tITMTableAdapter
    Friend WithEvents TableAdapterManager As Canteen.dsCanteenTableAdapters.TableAdapterManager
    Friend WithEvents txbName As System.Windows.Forms.TextBox
    Friend WithEvents txbPrice As System.Windows.Forms.TextBox
    Friend WithEvents txbQtyShelf As System.Windows.Forms.TextBox
    Friend WithEvents txbQtyUnit As System.Windows.Forms.TextBox
    Friend WithEvents txbReorder As System.Windows.Forms.TextBox
    Friend WithEvents lsbItems As System.Windows.Forms.ListBox
    Friend WithEvents pnlItems As System.Windows.Forms.Panel
    Friend WithEvents lblItems As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents TCTGTableAdapter1 As Canteen.dsCanteenTableAdapters.tCTGTableAdapter
    Friend WithEvents cboCatId As System.Windows.Forms.ComboBox
    Friend WithEvents cboPlacement As System.Windows.Forms.ComboBox
    Friend WithEvents AvailableCtgPlacementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AvailableCtgPlacementTableAdapter As Canteen.dsCanteenTableAdapters.AvailableCtgPlacementTableAdapter
    Friend WithEvents cboPrinter As System.Windows.Forms.ComboBox
    Friend WithEvents PRFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PRFTableAdapter As Canteen.dsCanteenTableAdapters.PRFTableAdapter
    Friend WithEvents CtgPlacementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CtgPlacementTableAdapter As Canteen.dsCanteenTableAdapters.CtgPlacementTableAdapter
    Friend WithEvents TITMTableAdapter1 As Canteen.dsCanteenTableAdapters.tITMTableAdapter
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
End Class
