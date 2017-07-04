<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseACT
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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.btnCancel = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txbActID = New System.Windows.Forms.TextBox
        Me.lblActID = New System.Windows.Forms.Label
        Me.lsbActID = New System.Windows.Forms.ListBox
        Me.ActDisplayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCanteen = New Canteen.dsCanteen
        Me.DsCanteen1 = New Canteen.dsCanteen
        Me.TACTTableAdapter1 = New Canteen.dsCanteenTableAdapters.tACTTableAdapter
        Me.AdmKeypad1 = New adm.admKeypad
        Me.AdmKeyBack1 = New adm.admKey
        Me.TACTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActDisplayTableAdapter = New Canteen.dsCanteenTableAdapters.ActDisplayTableAdapter
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActDisplayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCanteen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TACTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(742, 516)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.BorderColor = System.Drawing.Color.Black
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 619
        Me.LineShape1.X2 = 620
        Me.LineShape1.Y1 = 3
        Me.LineShape1.Y2 = 518
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Location = New System.Drawing.Point(640, 419)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 62)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(188, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 92)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'txbActID
        '
        Me.txbActID.BackColor = System.Drawing.Color.LavenderBlush
        Me.txbActID.ForeColor = System.Drawing.Color.Black
        Me.txbActID.Location = New System.Drawing.Point(14, 70)
        Me.txbActID.Name = "txbActID"
        Me.txbActID.Size = New System.Drawing.Size(168, 35)
        Me.txbActID.TabIndex = 0
        '
        'lblActID
        '
        Me.lblActID.AutoSize = True
        Me.lblActID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActID.ForeColor = System.Drawing.Color.Black
        Me.lblActID.Location = New System.Drawing.Point(24, 48)
        Me.lblActID.Name = "lblActID"
        Me.lblActID.Size = New System.Drawing.Size(110, 19)
        Me.lblActID.TabIndex = 6
        Me.lblActID.Text = "Customer ID:"
        '
        'lsbActID
        '
        Me.lsbActID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lsbActID.BackColor = System.Drawing.Color.LavenderBlush
        Me.lsbActID.DataSource = Me.ActDisplayBindingSource
        Me.lsbActID.DisplayMember = "ACT_FullName"
        Me.lsbActID.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsbActID.ForeColor = System.Drawing.Color.Black
        Me.lsbActID.FormattingEnabled = True
        Me.lsbActID.ItemHeight = 24
        Me.lsbActID.Location = New System.Drawing.Point(14, 118)
        Me.lsbActID.Name = "lsbActID"
        Me.lsbActID.Size = New System.Drawing.Size(262, 340)
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
        'AdmKeypad1
        '
        Me.AdmKeypad1.Location = New System.Drawing.Point(317, 118)
        Me.AdmKeypad1.Margin = New System.Windows.Forms.Padding(7)
        Me.AdmKeypad1.ModifierKeys = New System.Windows.Forms.Keys(-1) {}
        Me.AdmKeypad1.Name = "AdmKeypad1"
        Me.AdmKeypad1.Size = New System.Drawing.Size(271, 339)
        Me.AdmKeypad1.TabIndex = 7
        '
        'AdmKeyBack1
        '
        Me.AdmKeyBack1.BackColor = System.Drawing.Color.Black
        Me.AdmKeyBack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AdmKeyBack1.KeyValue = "Backspace"
        Me.AdmKeyBack1.KeyValueShift = ""
        Me.AdmKeyBack1.Location = New System.Drawing.Point(317, 65)
        Me.AdmKeyBack1.Margin = New System.Windows.Forms.Padding(0)
        Me.AdmKeyBack1.Name = "AdmKeyBack1"
        Me.AdmKeyBack1.Size = New System.Drawing.Size(189, 56)
        Me.AdmKeyBack1.Style = adm.admKey.KeyStyle.Two
        Me.AdmKeyBack1.TabIndex = 8
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
        'ChooseACT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(742, 516)
        Me.Controls.Add(Me.AdmKeyBack1)
        Me.Controls.Add(Me.AdmKeypad1)
        Me.Controls.Add(Me.lsbActID)
        Me.Controls.Add(Me.lblActID)
        Me.Controls.Add(Me.txbActID)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "ChooseACT"
        Me.Text = "Choose Account"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActDisplayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCanteen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TACTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txbActID As System.Windows.Forms.TextBox
    Friend WithEvents lblActID As System.Windows.Forms.Label
    Friend WithEvents lsbActID As System.Windows.Forms.ListBox
    Friend WithEvents DsCanteen1 As Canteen.dsCanteen
    Friend WithEvents TACTTableAdapter1 As Canteen.dsCanteenTableAdapters.tACTTableAdapter
    Friend WithEvents AdmKeypad1 As adm.admKeypad
    Friend WithEvents AdmKeyBack1 As adm.admKey
    Friend WithEvents TACTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCanteen As Canteen.dsCanteen
    Friend WithEvents ActDisplayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActDisplayTableAdapter As Canteen.dsCanteenTableAdapters.ActDisplayTableAdapter
End Class
