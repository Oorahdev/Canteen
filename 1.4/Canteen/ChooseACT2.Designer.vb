<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseACT2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChooseACT2))
        Me.btnCancel = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblActID = New System.Windows.Forms.Label
        Me.lsbActID = New System.Windows.Forms.ListBox
        Me.ActDisplayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCanteen = New Canteen.dsCanteen
        Me.DsCanteen1 = New Canteen.dsCanteen
        Me.TACTTableAdapter1 = New Canteen.dsCanteenTableAdapters.tACTTableAdapter
        Me.TACTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActDisplayTableAdapter = New Canteen.dsCanteenTableAdapters.ActDisplayTableAdapter
        Me.txbActID = New System.Windows.Forms.TextBox
        Me.btnByName = New System.Windows.Forms.Button
        Me.btnClearAct = New System.Windows.Forms.Button
        Me.AdmKeyboard1 = New adm.admKeyboard
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActDisplayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCanteen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TACTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Location = New System.Drawing.Point(544, 43)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(114, 101)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.TableLayoutPanel1.SetRowSpan(Me.PictureBox1, 2)
        Me.PictureBox1.Size = New System.Drawing.Size(194, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lblActID
        '
        Me.lblActID.AutoSize = True
        Me.lblActID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblActID.Location = New System.Drawing.Point(3, 9)
        Me.lblActID.Name = "lblActID"
        Me.lblActID.Size = New System.Drawing.Size(59, 19)
        Me.lblActID.TabIndex = 6
        Me.lblActID.Text = "Name:"
        '
        'lsbActID
        '
        Me.lsbActID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsbActID.BackColor = System.Drawing.Color.LavenderBlush
        Me.lsbActID.DataSource = Me.ActDisplayBindingSource
        Me.lsbActID.DisplayMember = "ACT_FullName"
        Me.lsbActID.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsbActID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lsbActID.FormattingEnabled = True
        Me.lsbActID.IntegralHeight = False
        Me.lsbActID.ItemHeight = 24
        Me.lsbActID.Location = New System.Drawing.Point(3, 70)
        Me.lsbActID.Name = "lsbActID"
        Me.lsbActID.Size = New System.Drawing.Size(258, 460)
        Me.lsbActID.TabIndex = 1
        Me.lsbActID.ValueMember = "ACT_ID"
        '
        'ActDisplayBindingSource
        '
        Me.ActDisplayBindingSource.DataMember = "ActDisplay"
        Me.ActDisplayBindingSource.DataSource = Me.DsCanteen
        '
        'DsCanteen
        '
        Me.DsCanteen.DataSetName = "dsCanteen"
        Me.DsCanteen.EnforceConstraints = False
        Me.DsCanteen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsCanteen1
        '
        Me.DsCanteen1.DataSetName = "dsCanteen"
        Me.DsCanteen1.EnforceConstraints = False
        Me.DsCanteen1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TACTTableAdapter1
        '
        Me.TACTTableAdapter1.ClearBeforeFill = True
        '
        'TACTBindingSource
        '
        Me.TACTBindingSource.DataMember = "tACT"
        Me.TACTBindingSource.DataSource = Me.DsCanteen1
        '
        'ActDisplayTableAdapter
        '
        Me.ActDisplayTableAdapter.ClearBeforeFill = True
        '
        'txbActID
        '
        Me.txbActID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txbActID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txbActID.BackColor = System.Drawing.Color.LavenderBlush
        Me.txbActID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbActID.Location = New System.Drawing.Point(3, 31)
        Me.txbActID.Name = "txbActID"
        Me.txbActID.Size = New System.Drawing.Size(258, 35)
        Me.txbActID.TabIndex = 0
        '
        'btnByName
        '
        Me.btnByName.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnByName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnByName.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnByName.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnByName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnByName.Location = New System.Drawing.Point(424, 43)
        Me.btnByName.Name = "btnByName"
        Me.btnByName.Size = New System.Drawing.Size(114, 101)
        Me.btnByName.TabIndex = 1
        Me.btnByName.Text = "Choose Account by ID"
        Me.btnByName.UseVisualStyleBackColor = False
        '
        'btnClearAct
        '
        Me.btnClearAct.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnClearAct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClearAct.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnClearAct.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClearAct.Location = New System.Drawing.Point(304, 43)
        Me.btnClearAct.Name = "btnClearAct"
        Me.btnClearAct.Size = New System.Drawing.Size(114, 101)
        Me.btnClearAct.TabIndex = 0
        Me.btnClearAct.Text = "Clear Account"
        Me.btnClearAct.UseVisualStyleBackColor = False
        '
        'AdmKeyboard1
        '
        Me.AdmKeyboard1.BackColor = System.Drawing.Color.SteelBlue
        Me.AdmKeyboard1.DisplayAlt = False
        Me.AdmKeyboard1.DisplayCtrl = False
        Me.AdmKeyboard1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AdmKeyboard1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AdmKeyboard1.Location = New System.Drawing.Point(267, 178)
        Me.AdmKeyboard1.Margin = New System.Windows.Forms.Padding(0)
        Me.AdmKeyboard1.ModifierKeys = New System.Windows.Forms.Keys(-1) {}
        Me.AdmKeyboard1.Name = "AdmKeyboard1"
        Me.AdmKeyboard1.Size = New System.Drawing.Size(661, 355)
        Me.AdmKeyboard1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lsbActID)
        Me.Panel2.Controls.Add(Me.txbActID)
        Me.Panel2.Controls.Add(Me.lblActID)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(267, 533)
        Me.Panel2.TabIndex = 0
        Me.Panel2.TabStop = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(267, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(661, 178)
        Me.Panel3.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnByName, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClearAct, 2, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.22222!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(661, 147)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'ChooseACT2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(928, 533)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.AdmKeyboard1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "ChooseACT2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Choose Account"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActDisplayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCanteen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TACTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblActID As System.Windows.Forms.Label
    Friend WithEvents lsbActID As System.Windows.Forms.ListBox
    Friend WithEvents DsCanteen1 As Canteen.dsCanteen
    Friend WithEvents TACTTableAdapter1 As Canteen.dsCanteenTableAdapters.tACTTableAdapter
    Friend WithEvents TACTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCanteen As Canteen.dsCanteen
    Friend WithEvents ActDisplayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActDisplayTableAdapter As Canteen.dsCanteenTableAdapters.ActDisplayTableAdapter
    Friend WithEvents txbActID As System.Windows.Forms.TextBox
    Friend WithEvents btnByName As System.Windows.Forms.Button
    Friend WithEvents btnClearAct As System.Windows.Forms.Button
    Friend WithEvents AdmKeyboard1 As adm.admKeyboard
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
