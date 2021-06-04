<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bunks
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
        Dim lblBnkName As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bunks))
        Me.pnlKeyboard = New System.Windows.Forms.Panel()
        Me.AdmKeyboard1 = New adm.admKeyboard()
        Me.DsCanteen = New Canteen.dsCanteen()
        Me.TBNKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBNKTableAdapter = New Canteen.dsCanteenTableAdapters.tBNKTableAdapter()
        Me.TableAdapterManager = New Canteen.dsCanteenTableAdapters.TableAdapterManager()
        Me.txbBnkname = New System.Windows.Forms.TextBox()
        Me.lsbBunks = New System.Windows.Forms.ListBox()
        Me.lblBunks = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        lblBnkName = New System.Windows.Forms.Label()
        Me.pnlKeyboard.SuspendLayout()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBNKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBnkName
        '
        lblBnkName.AutoSize = True
        lblBnkName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblBnkName.ForeColor = System.Drawing.Color.Black
        lblBnkName.Location = New System.Drawing.Point(358, 120)
        lblBnkName.Name = "lblBnkName"
        lblBnkName.Size = New System.Drawing.Size(59, 19)
        lblBnkName.TabIndex = 13
        lblBnkName.Text = "Name:"
        '
        'pnlKeyboard
        '
        Me.pnlKeyboard.Controls.Add(Me.AdmKeyboard1)
        Me.pnlKeyboard.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlKeyboard.Location = New System.Drawing.Point(0, 331)
        Me.pnlKeyboard.Name = "pnlKeyboard"
        Me.pnlKeyboard.Size = New System.Drawing.Size(769, 241)
        Me.pnlKeyboard.TabIndex = 10
        '
        'AdmKeyboard1
        '
        Me.AdmKeyboard1.BackColor = System.Drawing.Color.PowderBlue
        Me.AdmKeyboard1.DisplayAlt = False
        Me.AdmKeyboard1.DisplayCtrl = False
        Me.AdmKeyboard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdmKeyboard1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AdmKeyboard1.Location = New System.Drawing.Point(0, 0)
        Me.AdmKeyboard1.Margin = New System.Windows.Forms.Padding(0)
        Me.AdmKeyboard1.ModifierKeys = New System.Windows.Forms.Keys(-1) {}
        Me.AdmKeyboard1.Name = "AdmKeyboard1"
        Me.AdmKeyboard1.Size = New System.Drawing.Size(769, 241)
        Me.AdmKeyboard1.TabIndex = 0
        '
        'DsCanteen
        '
        Me.DsCanteen.DataSetName = "dsCanteen"
        Me.DsCanteen.EnforceConstraints = False
        Me.DsCanteen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBNKBindingSource
        '
        Me.TBNKBindingSource.DataMember = "tBNK"
        Me.TBNKBindingSource.DataSource = Me.DsCanteen
        '
        'TBNKTableAdapter
        '
        Me.TBNKTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tACTTableAdapter = Nothing
        Me.TableAdapterManager.tBNKTableAdapter = Me.TBNKTableAdapter
        Me.TableAdapterManager.tCTGTableAdapter = Nothing
        Me.TableAdapterManager.tINTTableAdapter = Nothing
        Me.TableAdapterManager.tINVTableAdapter = Nothing
        Me.TableAdapterManager.tITMTableAdapter = Nothing
        Me.TableAdapterManager.tORDTableAdapter = Nothing
        Me.TableAdapterManager.tORSTableAdapter = Nothing
        Me.TableAdapterManager.tPORTableAdapter = Nothing
        Me.TableAdapterManager.tPOSTableAdapter = Nothing
        Me.TableAdapterManager.tPRFTableAdapter = Nothing
        Me.TableAdapterManager.tPSNTableAdapter = Nothing
        Me.TableAdapterManager.tTRNTableAdapter = Nothing
        Me.TableAdapterManager.tUSRTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Canteen.dsCanteenTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txbBnkname
        '
        Me.txbBnkname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbBnkname.ForeColor = System.Drawing.Color.Black
        Me.txbBnkname.Location = New System.Drawing.Point(447, 117)
        Me.txbBnkname.Name = "txbBnkname"
        Me.txbBnkname.Size = New System.Drawing.Size(200, 26)
        Me.txbBnkname.TabIndex = 0
        '
        'lsbBunks
        '
        Me.lsbBunks.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsbBunks.ForeColor = System.Drawing.Color.Black
        Me.lsbBunks.FormattingEnabled = True
        Me.lsbBunks.ItemHeight = 19
        Me.lsbBunks.Location = New System.Drawing.Point(39, 47)
        Me.lsbBunks.Name = "lsbBunks"
        Me.lsbBunks.Size = New System.Drawing.Size(232, 251)
        Me.lsbBunks.TabIndex = 1
        '
        'lblBunks
        '
        Me.lblBunks.AutoSize = True
        Me.lblBunks.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblBunks.ForeColor = System.Drawing.Color.Black
        Me.lblBunks.Location = New System.Drawing.Point(41, 18)
        Me.lblBunks.Name = "lblBunks"
        Me.lblBunks.Size = New System.Drawing.Size(73, 24)
        Me.lblBunks.TabIndex = 46
        Me.lblBunks.Text = "Bunks:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDelete.Location = New System.Drawing.Point(295, 217)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 33)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Location = New System.Drawing.Point(648, 217)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 33)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Location = New System.Drawing.Point(395, 217)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(116, 32)
        Me.btnNew.TabIndex = 3
        Me.btnNew.Text = "New Bunk"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(524, 218)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 32)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblError.Location = New System.Drawing.Point(365, 24)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 18)
        Me.lblError.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel1.Controls.Add(Me.btnDown)
        Me.Panel1.Controls.Add(Me.btnUp)
        Me.Panel1.Controls.Add(Me.txbBnkname)
        Me.Panel1.Controls.Add(lblBnkName)
        Me.Panel1.Controls.Add(Me.lsbBunks)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.lblBunks)
        Me.Panel1.Controls.Add(Me.lblError)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(769, 328)
        Me.Panel1.TabIndex = 0
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDown.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(277, 86)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(32, 37)
        Me.btnDown.TabIndex = 48
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnUp.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(277, 47)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(32, 37)
        Me.btnUp.TabIndex = 47
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'Bunks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(769, 572)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlKeyboard)
        Me.ForeColor = System.Drawing.Color.DeepPink
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Bunks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bunks"
        Me.pnlKeyboard.ResumeLayout(False)
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBNKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlKeyboard As System.Windows.Forms.Panel
    Friend WithEvents AdmKeyboard1 As adm.admKeyboard
    Friend WithEvents DsCanteen As Canteen.dsCanteen
    Friend WithEvents TBNKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBNKTableAdapter As Canteen.dsCanteenTableAdapters.tBNKTableAdapter
    Friend WithEvents TableAdapterManager As Canteen.dsCanteenTableAdapters.TableAdapterManager
    Friend WithEvents txbBnkname As System.Windows.Forms.TextBox
    Friend WithEvents lsbBunks As System.Windows.Forms.ListBox
    Friend WithEvents lblBunks As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
End Class
