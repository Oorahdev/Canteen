<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUser
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
        Dim lblActId As System.Windows.Forms.Label
        Dim lblAdmin As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewUser))
        Me.lblName = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.btnNew = New System.Windows.Forms.Button
        Me.TUSRBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.TUSRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCanteen = New Canteen.dsCanteen
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TUSRBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.txbActId = New System.Windows.Forms.TextBox
        Me.txbPassword = New System.Windows.Forms.TextBox
        Me.txbUsrName = New System.Windows.Forms.TextBox
        Me.ckbAdmin = New System.Windows.Forms.CheckBox
        Me.btnChooseAct = New System.Windows.Forms.Button
        Me.lsbUsers = New System.Windows.Forms.ListBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblUsers = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.lblError = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txbConfirm = New System.Windows.Forms.TextBox
        Me.lblConfirmPwd = New System.Windows.Forms.Label
        Me.AdmKeyboard1 = New adm.admKeyboard
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TUSRTableAdapter = New Canteen.dsCanteenTableAdapters.tUSRTableAdapter
        Me.TableAdapterManager = New Canteen.dsCanteenTableAdapters.TableAdapterManager
        lblActId = New System.Windows.Forms.Label
        lblAdmin = New System.Windows.Forms.Label
        CType(Me.TUSRBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TUSRBindingNavigator.SuspendLayout()
        CType(Me.TUSRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblActId
        '
        lblActId.AutoSize = True
        lblActId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        lblActId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        lblActId.Location = New System.Drawing.Point(288, 39)
        lblActId.Name = "lblActId"
        lblActId.Size = New System.Drawing.Size(118, 24)
        lblActId.TabIndex = 17
        lblActId.Text = "Account ID:"
        '
        'lblAdmin
        '
        lblAdmin.AutoSize = True
        lblAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        lblAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        lblAdmin.Location = New System.Drawing.Point(288, 156)
        lblAdmin.Name = "lblAdmin"
        lblAdmin.Size = New System.Drawing.Size(76, 24)
        lblAdmin.TabIndex = 23
        lblAdmin.Text = "Admin:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblName.Location = New System.Drawing.Point(288, 69)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(120, 24)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "User Name:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPassword.Location = New System.Drawing.Point(288, 100)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(106, 24)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password:"
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnNew.Location = New System.Drawing.Point(392, 197)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(116, 32)
        Me.btnNew.TabIndex = 2
        Me.btnNew.Text = "New User"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'TUSRBindingNavigator
        '
        Me.TUSRBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TUSRBindingNavigator.BindingSource = Me.TUSRBindingSource
        Me.TUSRBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TUSRBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TUSRBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TUSRBindingNavigatorSaveItem})
        Me.TUSRBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TUSRBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TUSRBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TUSRBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TUSRBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TUSRBindingNavigator.Name = "TUSRBindingNavigator"
        Me.TUSRBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TUSRBindingNavigator.Size = New System.Drawing.Size(742, 25)
        Me.TUSRBindingNavigator.TabIndex = 15
        Me.TUSRBindingNavigator.Text = "BindingNavigator1"
        Me.TUSRBindingNavigator.Visible = False
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
        'TUSRBindingSource
        '
        Me.TUSRBindingSource.DataMember = "tUSR"
        Me.TUSRBindingSource.DataSource = Me.DsCanteen
        '
        'DsCanteen
        '
        Me.DsCanteen.DataSetName = "dsCanteen"
        Me.DsCanteen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TUSRBindingNavigatorSaveItem
        '
        Me.TUSRBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TUSRBindingNavigatorSaveItem.Image = CType(resources.GetObject("TUSRBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TUSRBindingNavigatorSaveItem.Name = "TUSRBindingNavigatorSaveItem"
        Me.TUSRBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TUSRBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txbActId
        '
        Me.txbActId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txbActId.ForeColor = System.Drawing.Color.SteelBlue
        Me.txbActId.Location = New System.Drawing.Point(439, 39)
        Me.txbActId.Name = "txbActId"
        Me.txbActId.ReadOnly = True
        Me.txbActId.Size = New System.Drawing.Size(200, 26)
        Me.txbActId.TabIndex = 4
        '
        'txbPassword
        '
        Me.txbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txbPassword.ForeColor = System.Drawing.Color.SteelBlue
        Me.txbPassword.Location = New System.Drawing.Point(439, 100)
        Me.txbPassword.Name = "txbPassword"
        Me.txbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbPassword.Size = New System.Drawing.Size(200, 26)
        Me.txbPassword.TabIndex = 1
        '
        'txbUsrName
        '
        Me.txbUsrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txbUsrName.ForeColor = System.Drawing.Color.SteelBlue
        Me.txbUsrName.Location = New System.Drawing.Point(439, 69)
        Me.txbUsrName.Name = "txbUsrName"
        Me.txbUsrName.Size = New System.Drawing.Size(200, 26)
        Me.txbUsrName.TabIndex = 0
        '
        'ckbAdmin
        '
        Me.ckbAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ckbAdmin.ForeColor = System.Drawing.Color.SteelBlue
        Me.ckbAdmin.Location = New System.Drawing.Point(439, 158)
        Me.ckbAdmin.Name = "ckbAdmin"
        Me.ckbAdmin.Size = New System.Drawing.Size(200, 26)
        Me.ckbAdmin.TabIndex = 3
        Me.ckbAdmin.UseVisualStyleBackColor = True
        '
        'btnChooseAct
        '
        Me.btnChooseAct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnChooseAct.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnChooseAct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnChooseAct.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseAct.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnChooseAct.Location = New System.Drawing.Point(645, 40)
        Me.btnChooseAct.Name = "btnChooseAct"
        Me.btnChooseAct.Size = New System.Drawing.Size(84, 25)
        Me.btnChooseAct.TabIndex = 4
        Me.btnChooseAct.Text = "Accounts"
        Me.btnChooseAct.UseVisualStyleBackColor = False
        '
        'lsbUsers
        '
        Me.lsbUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lsbUsers.ForeColor = System.Drawing.Color.SteelBlue
        Me.lsbUsers.FormattingEnabled = True
        Me.lsbUsers.ItemHeight = 20
        Me.lsbUsers.Location = New System.Drawing.Point(22, 46)
        Me.lsbUsers.Name = "lsbUsers"
        Me.lsbUsers.Size = New System.Drawing.Size(218, 184)
        Me.lsbUsers.TabIndex = 25
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnSave.Location = New System.Drawing.Point(521, 198)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 32)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.lblUsers)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.lblError)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.txbConfirm)
        Me.Panel1.Controls.Add(Me.lblConfirmPwd)
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.ckbAdmin)
        Me.Panel1.Controls.Add(Me.txbUsrName)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.lsbUsers)
        Me.Panel1.Controls.Add(lblAdmin)
        Me.Panel1.Controls.Add(Me.btnChooseAct)
        Me.Panel1.Controls.Add(Me.txbPassword)
        Me.Panel1.Controls.Add(lblActId)
        Me.Panel1.Controls.Add(Me.txbActId)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(742, 247)
        Me.Panel1.TabIndex = 0
        '
        'lblUsers
        '
        Me.lblUsers.AutoSize = True
        Me.lblUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblUsers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblUsers.Location = New System.Drawing.Point(28, 17)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(69, 24)
        Me.lblUsers.TabIndex = 35
        Me.lblUsers.Text = "Users:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDelete.Location = New System.Drawing.Point(292, 197)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 33)
        Me.btnDelete.TabIndex = 34
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.NavajoWhite
        Me.lblError.Location = New System.Drawing.Point(301, 15)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 15)
        Me.lblError.TabIndex = 33
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Location = New System.Drawing.Point(645, 197)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 33)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txbConfirm
        '
        Me.txbConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txbConfirm.ForeColor = System.Drawing.Color.SteelBlue
        Me.txbConfirm.Location = New System.Drawing.Point(439, 131)
        Me.txbConfirm.Name = "txbConfirm"
        Me.txbConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbConfirm.Size = New System.Drawing.Size(200, 26)
        Me.txbConfirm.TabIndex = 2
        '
        'lblConfirmPwd
        '
        Me.lblConfirmPwd.AutoSize = True
        Me.lblConfirmPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPwd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblConfirmPwd.Location = New System.Drawing.Point(288, 131)
        Me.lblConfirmPwd.Name = "lblConfirmPwd"
        Me.lblConfirmPwd.Size = New System.Drawing.Size(134, 24)
        Me.lblConfirmPwd.TabIndex = 30
        Me.lblConfirmPwd.Text = "Confirm Pwd:"
        '
        'AdmKeyboard1
        '
        Me.AdmKeyboard1.DisplayAlt = False
        Me.AdmKeyboard1.DisplayCtrl = False
        Me.AdmKeyboard1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AdmKeyboard1.Location = New System.Drawing.Point(0, 0)
        Me.AdmKeyboard1.Margin = New System.Windows.Forms.Padding(0)
        Me.AdmKeyboard1.ModifierKeys = New System.Windows.Forms.Keys(-1) {}
        Me.AdmKeyboard1.Name = "AdmKeyboard1"
        Me.AdmKeyboard1.Size = New System.Drawing.Size(742, 266)
        Me.AdmKeyboard1.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AdmKeyboard1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 250)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(742, 266)
        Me.Panel2.TabIndex = 29
        '
        'TUSRTableAdapter
        '
        Me.TUSRTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tPRFTableAdapter = Nothing
        Me.TableAdapterManager.tPSNTableAdapter = Nothing
        Me.TableAdapterManager.tTRNTableAdapter = Nothing
        Me.TableAdapterManager.tUSRTableAdapter = Me.TUSRTableAdapter
        Me.TableAdapterManager.UpdateOrder = Canteen.dsCanteenTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(742, 516)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TUSRBindingNavigator)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "NewUser"
        CType(Me.TUSRBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TUSRBindingNavigator.ResumeLayout(False)
        Me.TUSRBindingNavigator.PerformLayout()
        CType(Me.TUSRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents DsCanteen As Canteen.dsCanteen
    Friend WithEvents TUSRBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TUSRTableAdapter As Canteen.dsCanteenTableAdapters.tUSRTableAdapter
    Friend WithEvents TableAdapterManager As Canteen.dsCanteenTableAdapters.TableAdapterManager
    Friend WithEvents TUSRBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TUSRBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents txbActId As System.Windows.Forms.TextBox
    Friend WithEvents txbPassword As System.Windows.Forms.TextBox
    Friend WithEvents txbUsrName As System.Windows.Forms.TextBox
    Friend WithEvents ckbAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents btnChooseAct As System.Windows.Forms.Button
    Friend WithEvents lsbUsers As System.Windows.Forms.ListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AdmKeyboard1 As adm.admKeyboard
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txbConfirm As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPwd As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblUsers As System.Windows.Forms.Label
End Class
