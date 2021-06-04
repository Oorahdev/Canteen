<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Positions
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
        Me.components = New System.ComponentModel.Container()
        Dim lblPositionName As System.Windows.Forms.Label
        Dim lblPositionSort As System.Windows.Forms.Label
        Dim lblCreditLimit As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Positions))
        Me.txbName = New System.Windows.Forms.TextBox()
        Me.txbSort = New System.Windows.Forms.TextBox()
        Me.AdmKeyboard1 = New adm.admKeyboard()
        Me.pnlPositions = New System.Windows.Forms.Panel()
        Me.txbCreditLimit = New System.Windows.Forms.TextBox()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.lsbPositions = New System.Windows.Forms.ListBox()
        Me.lblPositions = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TPSNBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCanteen = New Canteen.dsCanteen()
        Me.TPSNTableAdapter = New Canteen.dsCanteenTableAdapters.tPSNTableAdapter()
        Me.TableAdapterManager = New Canteen.dsCanteenTableAdapters.TableAdapterManager()
        Me.TACTTableAdapter1 = New Canteen.dsCanteenTableAdapters.tACTTableAdapter()
        lblPositionName = New System.Windows.Forms.Label()
        lblPositionSort = New System.Windows.Forms.Label()
        lblCreditLimit = New System.Windows.Forms.Label()
        Me.pnlPositions.SuspendLayout()
        CType(Me.TPSNBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPositionName
        '
        lblPositionName.AutoSize = True
        lblPositionName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        lblPositionName.ForeColor = System.Drawing.Color.Black
        lblPositionName.Location = New System.Drawing.Point(342, 65)
        lblPositionName.Name = "lblPositionName"
        lblPositionName.Size = New System.Drawing.Size(69, 22)
        lblPositionName.TabIndex = 9
        lblPositionName.Text = "Name:"
        '
        'lblPositionSort
        '
        lblPositionSort.AutoSize = True
        lblPositionSort.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        lblPositionSort.ForeColor = System.Drawing.Color.Black
        lblPositionSort.Location = New System.Drawing.Point(342, 110)
        lblPositionSort.Name = "lblPositionSort"
        lblPositionSort.Size = New System.Drawing.Size(56, 22)
        lblPositionSort.TabIndex = 11
        lblPositionSort.Text = "Sort:"
        '
        'lblCreditLimit
        '
        lblCreditLimit.AutoSize = True
        lblCreditLimit.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        lblCreditLimit.ForeColor = System.Drawing.Color.Black
        lblCreditLimit.Location = New System.Drawing.Point(342, 147)
        lblCreditLimit.Name = "lblCreditLimit"
        lblCreditLimit.Size = New System.Drawing.Size(123, 22)
        lblCreditLimit.TabIndex = 46
        lblCreditLimit.Text = "Credit Limit:"
        '
        'txbName
        '
        Me.txbName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbName.ForeColor = System.Drawing.Color.Black
        Me.txbName.Location = New System.Drawing.Point(484, 62)
        Me.txbName.Name = "txbName"
        Me.txbName.Size = New System.Drawing.Size(150, 26)
        Me.txbName.TabIndex = 10
        '
        'txbSort
        '
        Me.txbSort.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbSort.ForeColor = System.Drawing.Color.Black
        Me.txbSort.Location = New System.Drawing.Point(484, 103)
        Me.txbSort.Name = "txbSort"
        Me.txbSort.Size = New System.Drawing.Size(150, 26)
        Me.txbSort.TabIndex = 12
        '
        'AdmKeyboard1
        '
        Me.AdmKeyboard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdmKeyboard1.Location = New System.Drawing.Point(0, 251)
        Me.AdmKeyboard1.Margin = New System.Windows.Forms.Padding(0)
        Me.AdmKeyboard1.ModifierKeys = New System.Windows.Forms.Keys(-1) {}
        Me.AdmKeyboard1.Name = "AdmKeyboard1"
        Me.AdmKeyboard1.Size = New System.Drawing.Size(742, 265)
        Me.AdmKeyboard1.TabIndex = 13
        '
        'pnlPositions
        '
        Me.pnlPositions.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlPositions.Controls.Add(Me.txbCreditLimit)
        Me.pnlPositions.Controls.Add(lblCreditLimit)
        Me.pnlPositions.Controls.Add(Me.btnDown)
        Me.pnlPositions.Controls.Add(Me.btnUp)
        Me.pnlPositions.Controls.Add(Me.lsbPositions)
        Me.pnlPositions.Controls.Add(Me.lblPositions)
        Me.pnlPositions.Controls.Add(Me.btnDelete)
        Me.pnlPositions.Controls.Add(Me.lblError)
        Me.pnlPositions.Controls.Add(Me.btnCancel)
        Me.pnlPositions.Controls.Add(Me.btnNew)
        Me.pnlPositions.Controls.Add(Me.btnSave)
        Me.pnlPositions.Controls.Add(Me.txbSort)
        Me.pnlPositions.Controls.Add(lblPositionSort)
        Me.pnlPositions.Controls.Add(Me.txbName)
        Me.pnlPositions.Controls.Add(lblPositionName)
        Me.pnlPositions.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPositions.Location = New System.Drawing.Point(0, 0)
        Me.pnlPositions.Name = "pnlPositions"
        Me.pnlPositions.Size = New System.Drawing.Size(742, 251)
        Me.pnlPositions.TabIndex = 14
        '
        'txbCreditLimit
        '
        Me.txbCreditLimit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCreditLimit.ForeColor = System.Drawing.Color.Black
        Me.txbCreditLimit.Location = New System.Drawing.Point(484, 145)
        Me.txbCreditLimit.Name = "txbCreditLimit"
        Me.txbCreditLimit.Size = New System.Drawing.Size(150, 26)
        Me.txbCreditLimit.TabIndex = 47
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDown.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(248, 88)
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
        Me.btnUp.Location = New System.Drawing.Point(248, 49)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(32, 37)
        Me.btnUp.TabIndex = 44
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'lsbPositions
        '
        Me.lsbPositions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lsbPositions.ForeColor = System.Drawing.Color.Black
        Me.lsbPositions.FormattingEnabled = True
        Me.lsbPositions.ItemHeight = 20
        Me.lsbPositions.Location = New System.Drawing.Point(24, 49)
        Me.lsbPositions.Name = "lsbPositions"
        Me.lsbPositions.Size = New System.Drawing.Size(218, 184)
        Me.lsbPositions.TabIndex = 42
        '
        'lblPositions
        '
        Me.lblPositions.AutoSize = True
        Me.lblPositions.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblPositions.ForeColor = System.Drawing.Color.Black
        Me.lblPositions.Location = New System.Drawing.Point(20, 20)
        Me.lblPositions.Name = "lblPositions"
        Me.lblPositions.Size = New System.Drawing.Size(100, 24)
        Me.lblPositions.TabIndex = 41
        Me.lblPositions.Text = "Positions:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDelete.Location = New System.Drawing.Point(284, 200)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 33)
        Me.btnDelete.TabIndex = 40
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Orange
        Me.lblError.Location = New System.Drawing.Point(293, 18)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 15)
        Me.lblError.TabIndex = 39
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Location = New System.Drawing.Point(637, 200)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 33)
        Me.btnCancel.TabIndex = 38
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Location = New System.Drawing.Point(384, 200)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(116, 32)
        Me.btnNew.TabIndex = 36
        Me.btnNew.Text = "New Position"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(513, 201)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 32)
        Me.btnSave.TabIndex = 37
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'TPSNBindingSource
        '
        Me.TPSNBindingSource.DataMember = "tPSN"
        Me.TPSNBindingSource.DataSource = Me.DsCanteen
        '
        'DsCanteen
        '
        Me.DsCanteen.DataSetName = "dsCanteen"
        Me.DsCanteen.EnforceConstraints = False
        Me.DsCanteen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TPSNTableAdapter
        '
        Me.TPSNTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tACTTableAdapter = Nothing
        Me.TableAdapterManager.tBNKTableAdapter = Nothing
        Me.TableAdapterManager.tCTGTableAdapter = Nothing
        Me.TableAdapterManager.tINTTableAdapter = Nothing
        Me.TableAdapterManager.tINVTableAdapter = Nothing
        Me.TableAdapterManager.tITMTableAdapter = Nothing
        Me.TableAdapterManager.tORDTableAdapter = Nothing
        Me.TableAdapterManager.tORSTableAdapter = Nothing
        Me.TableAdapterManager.tPORTableAdapter = Nothing
        Me.TableAdapterManager.tPOSTableAdapter = Nothing
        Me.TableAdapterManager.tPRFTableAdapter = Nothing
        Me.TableAdapterManager.tPSNTableAdapter = Me.TPSNTableAdapter
        Me.TableAdapterManager.tTRNTableAdapter = Nothing
        Me.TableAdapterManager.tUSRTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Canteen.dsCanteenTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TACTTableAdapter1
        '
        Me.TACTTableAdapter1.ClearBeforeFill = True
        '
        'Positions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(742, 516)
        Me.Controls.Add(Me.AdmKeyboard1)
        Me.Controls.Add(Me.pnlPositions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Positions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Positions"
        Me.pnlPositions.ResumeLayout(False)
        Me.pnlPositions.PerformLayout()
        CType(Me.TPSNBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsCanteen As Canteen.dsCanteen
    Friend WithEvents TPSNBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TPSNTableAdapter As Canteen.dsCanteenTableAdapters.tPSNTableAdapter
    Friend WithEvents TableAdapterManager As Canteen.dsCanteenTableAdapters.TableAdapterManager
    Friend WithEvents txbName As System.Windows.Forms.TextBox
    Friend WithEvents txbSort As System.Windows.Forms.TextBox
    Friend WithEvents AdmKeyboard1 As adm.admKeyboard
    Friend WithEvents pnlPositions As System.Windows.Forms.Panel
    Friend WithEvents lblPositions As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lsbPositions As System.Windows.Forms.ListBox
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents txbCreditLimit As System.Windows.Forms.TextBox
    Friend WithEvents TACTTableAdapter1 As Canteen.dsCanteenTableAdapters.tACTTableAdapter
End Class
