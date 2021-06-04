<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categories
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
        Dim lblCategoryName As System.Windows.Forms.Label
        Dim lblCategorySection As System.Windows.Forms.Label
        Dim lblCategoryQty As System.Windows.Forms.Label
        Dim lblCategorySort As System.Windows.Forms.Label
        Dim lblCategoryPrinter As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Categories))
        Me.btnCancel = New System.Windows.Forms.Button
        Me.pnlKeyboard = New System.Windows.Forms.Panel
        Me.AdmKeyboard1 = New adm.admKeyboard
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cboCatPrinter = New System.Windows.Forms.ComboBox
        Me.btnDown = New System.Windows.Forms.Button
        Me.btnUp = New System.Windows.Forms.Button
        Me.lblError = New System.Windows.Forms.Label
        Me.lblCategories = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.txbCatName = New System.Windows.Forms.TextBox
        Me.txbCatSection = New System.Windows.Forms.TextBox
        Me.txbCatQty = New System.Windows.Forms.TextBox
        Me.txbCatSort = New System.Windows.Forms.TextBox
        Me.lsbCategories = New System.Windows.Forms.ListBox
        Me.TCTGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCanteen = New Canteen.dsCanteen
        Me.TCTGTableAdapter = New Canteen.dsCanteenTableAdapters.tCTGTableAdapter
        Me.TableAdapterManager = New Canteen.dsCanteenTableAdapters.TableAdapterManager
        Me.TPRFTableAdapter1 = New Canteen.dsCanteenTableAdapters.tPRFTableAdapter
        lblCategoryName = New System.Windows.Forms.Label
        lblCategorySection = New System.Windows.Forms.Label
        lblCategoryQty = New System.Windows.Forms.Label
        lblCategorySort = New System.Windows.Forms.Label
        lblCategoryPrinter = New System.Windows.Forms.Label
        Me.pnlKeyboard.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TCTGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCategoryName
        '
        lblCategoryName.AutoSize = True
        lblCategoryName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCategoryName.ForeColor = System.Drawing.Color.Black
        lblCategoryName.Location = New System.Drawing.Point(271, 29)
        lblCategoryName.Name = "lblCategoryName"
        lblCategoryName.Size = New System.Drawing.Size(59, 19)
        lblCategoryName.TabIndex = 10
        lblCategoryName.Text = "Name:"
        '
        'lblCategorySection
        '
        lblCategorySection.AutoSize = True
        lblCategorySection.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCategorySection.ForeColor = System.Drawing.Color.Black
        lblCategorySection.Location = New System.Drawing.Point(271, 59)
        lblCategorySection.Name = "lblCategorySection"
        lblCategorySection.Size = New System.Drawing.Size(73, 19)
        lblCategorySection.TabIndex = 12
        lblCategorySection.Text = "Section:"
        '
        'lblCategoryQty
        '
        lblCategoryQty.AutoSize = True
        lblCategoryQty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCategoryQty.ForeColor = System.Drawing.Color.Black
        lblCategoryQty.Location = New System.Drawing.Point(271, 89)
        lblCategoryQty.Name = "lblCategoryQty"
        lblCategoryQty.Size = New System.Drawing.Size(79, 19)
        lblCategoryQty.TabIndex = 14
        lblCategoryQty.Text = "Quantity:"
        '
        'lblCategorySort
        '
        lblCategorySort.AutoSize = True
        lblCategorySort.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCategorySort.ForeColor = System.Drawing.Color.Black
        lblCategorySort.Location = New System.Drawing.Point(271, 119)
        lblCategorySort.Name = "lblCategorySort"
        lblCategorySort.Size = New System.Drawing.Size(47, 19)
        lblCategorySort.TabIndex = 16
        lblCategorySort.Text = "Sort:"
        '
        'lblCategoryPrinter
        '
        lblCategoryPrinter.AutoSize = True
        lblCategoryPrinter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCategoryPrinter.ForeColor = System.Drawing.Color.Black
        lblCategoryPrinter.Location = New System.Drawing.Point(271, 148)
        lblCategoryPrinter.Name = "lblCategoryPrinter"
        lblCategoryPrinter.Size = New System.Drawing.Size(66, 19)
        lblCategoryPrinter.TabIndex = 46
        lblCategoryPrinter.Text = "Printer:"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Location = New System.Drawing.Point(627, 181)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 31)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'pnlKeyboard
        '
        Me.pnlKeyboard.Controls.Add(Me.AdmKeyboard1)
        Me.pnlKeyboard.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlKeyboard.Location = New System.Drawing.Point(0, 231)
        Me.pnlKeyboard.Name = "pnlKeyboard"
        Me.pnlKeyboard.Size = New System.Drawing.Size(742, 285)
        Me.pnlKeyboard.TabIndex = 8
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
        Me.AdmKeyboard1.Size = New System.Drawing.Size(742, 285)
        Me.AdmKeyboard1.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel1.Controls.Add(Me.cboCatPrinter)
        Me.Panel1.Controls.Add(lblCategoryPrinter)
        Me.Panel1.Controls.Add(Me.btnDown)
        Me.Panel1.Controls.Add(Me.btnUp)
        Me.Panel1.Controls.Add(Me.lblError)
        Me.Panel1.Controls.Add(Me.lblCategories)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(lblCategoryName)
        Me.Panel1.Controls.Add(Me.txbCatName)
        Me.Panel1.Controls.Add(lblCategorySection)
        Me.Panel1.Controls.Add(Me.txbCatSection)
        Me.Panel1.Controls.Add(lblCategoryQty)
        Me.Panel1.Controls.Add(Me.txbCatQty)
        Me.Panel1.Controls.Add(lblCategorySort)
        Me.Panel1.Controls.Add(Me.txbCatSort)
        Me.Panel1.Controls.Add(Me.lsbCategories)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.ForeColor = System.Drawing.Color.Firebrick
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(742, 228)
        Me.Panel1.TabIndex = 9
        '
        'cboCatPrinter
        '
        Me.cboCatPrinter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cboCatPrinter.ForeColor = System.Drawing.Color.Black
        Me.cboCatPrinter.FormattingEnabled = True
        Me.cboCatPrinter.Location = New System.Drawing.Point(402, 146)
        Me.cboCatPrinter.Name = "cboCatPrinter"
        Me.cboCatPrinter.Size = New System.Drawing.Size(200, 27)
        Me.cboCatPrinter.TabIndex = 47
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDown.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(233, 69)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(32, 37)
        Me.btnDown.TabIndex = 45
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnUp.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(233, 30)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(32, 37)
        Me.btnUp.TabIndex = 44
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Location = New System.Drawing.Point(273, 12)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 15)
        Me.lblError.TabIndex = 40
        '
        'lblCategories
        '
        Me.lblCategories.AutoSize = True
        Me.lblCategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategories.ForeColor = System.Drawing.Color.Black
        Me.lblCategories.Location = New System.Drawing.Point(19, 5)
        Me.lblCategories.Name = "lblCategories"
        Me.lblCategories.Size = New System.Drawing.Size(101, 20)
        Me.lblCategories.TabIndex = 39
        Me.lblCategories.Text = "Categories:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDelete.Location = New System.Drawing.Point(268, 180)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 33)
        Me.btnDelete.TabIndex = 38
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Location = New System.Drawing.Point(359, 180)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(132, 32)
        Me.btnNew.TabIndex = 36
        Me.btnNew.Text = "New Category"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(497, 181)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 32)
        Me.btnSave.TabIndex = 37
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txbCatName
        '
        Me.txbCatName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txbCatName.ForeColor = System.Drawing.Color.Black
        Me.txbCatName.Location = New System.Drawing.Point(402, 26)
        Me.txbCatName.Name = "txbCatName"
        Me.txbCatName.Size = New System.Drawing.Size(200, 26)
        Me.txbCatName.TabIndex = 11
        '
        'txbCatSection
        '
        Me.txbCatSection.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txbCatSection.ForeColor = System.Drawing.Color.Black
        Me.txbCatSection.Location = New System.Drawing.Point(402, 56)
        Me.txbCatSection.Name = "txbCatSection"
        Me.txbCatSection.Size = New System.Drawing.Size(200, 26)
        Me.txbCatSection.TabIndex = 13
        '
        'txbCatQty
        '
        Me.txbCatQty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txbCatQty.ForeColor = System.Drawing.Color.Black
        Me.txbCatQty.Location = New System.Drawing.Point(402, 86)
        Me.txbCatQty.Name = "txbCatQty"
        Me.txbCatQty.Size = New System.Drawing.Size(200, 26)
        Me.txbCatQty.TabIndex = 15
        '
        'txbCatSort
        '
        Me.txbCatSort.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txbCatSort.ForeColor = System.Drawing.Color.Black
        Me.txbCatSort.Location = New System.Drawing.Point(402, 116)
        Me.txbCatSort.Name = "txbCatSort"
        Me.txbCatSort.Size = New System.Drawing.Size(200, 26)
        Me.txbCatSort.TabIndex = 17
        '
        'lsbCategories
        '
        Me.lsbCategories.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lsbCategories.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lsbCategories.ForeColor = System.Drawing.Color.Black
        Me.lsbCategories.FormattingEnabled = True
        Me.lsbCategories.ItemHeight = 19
        Me.lsbCategories.Location = New System.Drawing.Point(20, 30)
        Me.lsbCategories.Name = "lsbCategories"
        Me.lsbCategories.Size = New System.Drawing.Size(207, 175)
        Me.lsbCategories.TabIndex = 8
        '
        'TCTGBindingSource
        '
        Me.TCTGBindingSource.DataMember = "tCTG"
        Me.TCTGBindingSource.DataSource = Me.DsCanteen
        '
        'DsCanteen
        '
        Me.DsCanteen.DataSetName = "dsCanteen"
        Me.DsCanteen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TCTGTableAdapter
        '
        Me.TCTGTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tACTTableAdapter = Nothing
        Me.TableAdapterManager.tBNKTableAdapter = Nothing
        Me.TableAdapterManager.tCTGTableAdapter = Me.TCTGTableAdapter
        Me.TableAdapterManager.tINTTableAdapter = Nothing
        Me.TableAdapterManager.tINVTableAdapter = Nothing
        Me.TableAdapterManager.tITMTableAdapter = Nothing
        Me.TableAdapterManager.tORDTableAdapter = Nothing
        Me.TableAdapterManager.tORSTableAdapter = Nothing
        Me.TableAdapterManager.tPRFTableAdapter = Nothing
        Me.TableAdapterManager.tPSNTableAdapter = Nothing
        Me.TableAdapterManager.tTRNTableAdapter = Nothing
        Me.TableAdapterManager.tUSRTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Canteen.dsCanteenTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TPRFTableAdapter1
        '
        Me.TPRFTableAdapter1.ClearBeforeFill = True
        '
        'Categories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(742, 516)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlKeyboard)
        Me.ForeColor = System.Drawing.Color.Firebrick
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Categories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Categories"
        Me.pnlKeyboard.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TCTGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents pnlKeyboard As System.Windows.Forms.Panel
    Friend WithEvents AdmKeyboard1 As adm.admKeyboard
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lsbCategories As System.Windows.Forms.ListBox
    Friend WithEvents DsCanteen As Canteen.dsCanteen
    Friend WithEvents TCTGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TCTGTableAdapter As Canteen.dsCanteenTableAdapters.tCTGTableAdapter
    Friend WithEvents TableAdapterManager As Canteen.dsCanteenTableAdapters.TableAdapterManager
    Friend WithEvents txbCatName As System.Windows.Forms.TextBox
    Friend WithEvents txbCatSection As System.Windows.Forms.TextBox
    Friend WithEvents txbCatQty As System.Windows.Forms.TextBox
    Friend WithEvents txbCatSort As System.Windows.Forms.TextBox
    Friend WithEvents lblCategories As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents cboCatPrinter As System.Windows.Forms.ComboBox
    Friend WithEvents TPRFTableAdapter1 As Canteen.dsCanteenTableAdapters.tPRFTableAdapter
End Class
