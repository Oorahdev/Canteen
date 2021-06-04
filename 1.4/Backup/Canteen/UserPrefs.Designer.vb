<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserPrefs
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
        Dim lblUsrId As System.Windows.Forms.Label
        Dim lblName As System.Windows.Forms.Label
        Dim lblValue As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserPrefs))
        Me.pnlKeyboard = New System.Windows.Forms.Panel
        Me.AdmKeyboard1 = New adm.admKeyboard
        Me.pnlItems = New System.Windows.Forms.Panel
        Me.lblError = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblItems = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.txbValue = New System.Windows.Forms.TextBox
        Me.cboUsrId = New System.Windows.Forms.ComboBox
        Me.txbName = New System.Windows.Forms.TextBox
        Me.lsbPrefs = New System.Windows.Forms.ListBox
        Me.DsCanteen = New Canteen.dsCanteen
        Me.TPRFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TPRFTableAdapter = New Canteen.dsCanteenTableAdapters.tPRFTableAdapter
        Me.TableAdapterManager = New Canteen.dsCanteenTableAdapters.TableAdapterManager
        Me.TUSRTableAdapter1 = New Canteen.dsCanteenTableAdapters.tUSRTableAdapter
        lblUsrId = New System.Windows.Forms.Label
        lblName = New System.Windows.Forms.Label
        lblValue = New System.Windows.Forms.Label
        Me.pnlKeyboard.SuspendLayout()
        Me.pnlItems.SuspendLayout()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPRFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsrId
        '
        lblUsrId.AutoSize = True
        lblUsrId.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblUsrId.ForeColor = System.Drawing.Color.Black
        lblUsrId.Location = New System.Drawing.Point(291, 144)
        lblUsrId.Name = "lblUsrId"
        lblUsrId.Size = New System.Drawing.Size(75, 19)
        lblUsrId.TabIndex = 16
        lblUsrId.Text = "User  ID:"
        '
        'lblName
        '
        lblName.AutoSize = True
        lblName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblName.ForeColor = System.Drawing.Color.Black
        lblName.Location = New System.Drawing.Point(291, 67)
        lblName.Name = "lblName"
        lblName.Size = New System.Drawing.Size(94, 19)
        lblName.TabIndex = 14
        lblName.Text = "Pref Name:"
        '
        'lblValue
        '
        lblValue.AutoSize = True
        lblValue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblValue.ForeColor = System.Drawing.Color.Black
        lblValue.Location = New System.Drawing.Point(291, 104)
        lblValue.Name = "lblValue"
        lblValue.Size = New System.Drawing.Size(58, 19)
        lblValue.TabIndex = 42
        lblValue.Text = "Value:"
        '
        'pnlKeyboard
        '
        Me.pnlKeyboard.Controls.Add(Me.AdmKeyboard1)
        Me.pnlKeyboard.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlKeyboard.Location = New System.Drawing.Point(0, 275)
        Me.pnlKeyboard.Name = "pnlKeyboard"
        Me.pnlKeyboard.Size = New System.Drawing.Size(742, 241)
        Me.pnlKeyboard.TabIndex = 10
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
        Me.AdmKeyboard1.TabIndex = 0
        '
        'pnlItems
        '
        Me.pnlItems.BackColor = System.Drawing.Color.LemonChiffon
        Me.pnlItems.Controls.Add(lblValue)
        Me.pnlItems.Controls.Add(Me.lblError)
        Me.pnlItems.Controls.Add(Me.btnCancel)
        Me.pnlItems.Controls.Add(Me.lblItems)
        Me.pnlItems.Controls.Add(Me.btnDelete)
        Me.pnlItems.Controls.Add(Me.btnNew)
        Me.pnlItems.Controls.Add(Me.btnSave)
        Me.pnlItems.Controls.Add(Me.txbValue)
        Me.pnlItems.Controls.Add(Me.cboUsrId)
        Me.pnlItems.Controls.Add(lblUsrId)
        Me.pnlItems.Controls.Add(Me.txbName)
        Me.pnlItems.Controls.Add(lblName)
        Me.pnlItems.Controls.Add(Me.lsbPrefs)
        Me.pnlItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlItems.Location = New System.Drawing.Point(0, 0)
        Me.pnlItems.Name = "pnlItems"
        Me.pnlItems.Size = New System.Drawing.Size(742, 275)
        Me.pnlItems.TabIndex = 0
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblError.Location = New System.Drawing.Point(271, 9)
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
        Me.btnCancel.Location = New System.Drawing.Point(634, 207)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 33)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblItems.ForeColor = System.Drawing.Color.Black
        Me.lblItems.Location = New System.Drawing.Point(27, 9)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(112, 24)
        Me.lblItems.TabIndex = 39
        Me.lblItems.Text = "User Prefs:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDelete.Location = New System.Drawing.Point(265, 207)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 33)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnNew.Enabled = False
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Location = New System.Drawing.Point(360, 207)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(116, 32)
        Me.btnNew.TabIndex = 5
        Me.btnNew.Text = "New Pref"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(488, 207)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 32)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txbValue
        '
        Me.txbValue.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbValue.ForeColor = System.Drawing.Color.Black
        Me.txbValue.Location = New System.Drawing.Point(411, 105)
        Me.txbValue.Name = "txbValue"
        Me.txbValue.Size = New System.Drawing.Size(170, 25)
        Me.txbValue.TabIndex = 2
        '
        'cboUsrId
        '
        Me.cboUsrId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsrId.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUsrId.ForeColor = System.Drawing.Color.Black
        Me.cboUsrId.FormattingEnabled = True
        Me.cboUsrId.Location = New System.Drawing.Point(411, 143)
        Me.cboUsrId.Name = "cboUsrId"
        Me.cboUsrId.Size = New System.Drawing.Size(170, 26)
        Me.cboUsrId.TabIndex = 3
        '
        'txbName
        '
        Me.txbName.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbName.ForeColor = System.Drawing.Color.Black
        Me.txbName.Location = New System.Drawing.Point(411, 66)
        Me.txbName.Name = "txbName"
        Me.txbName.Size = New System.Drawing.Size(170, 25)
        Me.txbName.TabIndex = 1
        '
        'lsbPrefs
        '
        Me.lsbPrefs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lsbPrefs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsbPrefs.ForeColor = System.Drawing.Color.Black
        Me.lsbPrefs.FormattingEnabled = True
        Me.lsbPrefs.ItemHeight = 20
        Me.lsbPrefs.Location = New System.Drawing.Point(27, 38)
        Me.lsbPrefs.Name = "lsbPrefs"
        Me.lsbPrefs.Size = New System.Drawing.Size(219, 224)
        Me.lsbPrefs.TabIndex = 0
        '
        'DsCanteen
        '
        Me.DsCanteen.DataSetName = "dsCanteen"
        Me.DsCanteen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TPRFBindingSource
        '
        Me.TPRFBindingSource.DataMember = "tPRF"
        Me.TPRFBindingSource.DataSource = Me.DsCanteen
        '
        'TPRFTableAdapter
        '
        Me.TPRFTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tPRFTableAdapter = Me.TPRFTableAdapter
        Me.TableAdapterManager.tPSNTableAdapter = Nothing
        Me.TableAdapterManager.tTRNTableAdapter = Nothing
        Me.TableAdapterManager.tUSRTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Canteen.dsCanteenTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TUSRTableAdapter1
        '
        Me.TUSRTableAdapter1.ClearBeforeFill = True
        '
        'UserPrefs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(742, 516)
        Me.Controls.Add(Me.pnlItems)
        Me.Controls.Add(Me.pnlKeyboard)
        Me.ForeColor = System.Drawing.Color.DarkCyan
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserPrefs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "UserPrefs"
        Me.pnlKeyboard.ResumeLayout(False)
        Me.pnlItems.ResumeLayout(False)
        Me.pnlItems.PerformLayout()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPRFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsCanteen As Canteen.dsCanteen
    Friend WithEvents TPRFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TPRFTableAdapter As Canteen.dsCanteenTableAdapters.tPRFTableAdapter
    Friend WithEvents TableAdapterManager As Canteen.dsCanteenTableAdapters.TableAdapterManager
    Friend WithEvents pnlKeyboard As System.Windows.Forms.Panel
    Friend WithEvents AdmKeyboard1 As adm.admKeyboard
    Friend WithEvents pnlItems As System.Windows.Forms.Panel
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblItems As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cboUsrId As System.Windows.Forms.ComboBox
    Friend WithEvents txbName As System.Windows.Forms.TextBox
    Friend WithEvents lsbPrefs As System.Windows.Forms.ListBox
    Friend WithEvents txbValue As System.Windows.Forms.TextBox
    Friend WithEvents TUSRTableAdapter1 As Canteen.dsCanteenTableAdapters.tUSRTableAdapter
End Class
