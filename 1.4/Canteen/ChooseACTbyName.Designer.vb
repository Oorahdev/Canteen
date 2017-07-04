<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseACTbyName
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChooseACTbyName))
        Me.lsbActID = New System.Windows.Forms.ListBox
        Me.lblActID = New System.Windows.Forms.Label
        Me.txbActID = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.AdmKeypad1 = New adm.admKeypad
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsbActID
        '
        Me.lsbActID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsbActID.BackColor = System.Drawing.Color.LavenderBlush
        Me.lsbActID.DisplayMember = "ACT_FullName"
        Me.lsbActID.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsbActID.ForeColor = System.Drawing.Color.Black
        Me.lsbActID.FormattingEnabled = True
        Me.lsbActID.IntegralHeight = False
        Me.lsbActID.ItemHeight = 24
        Me.lsbActID.Location = New System.Drawing.Point(0, 68)
        Me.lsbActID.Name = "lsbActID"
        Me.lsbActID.Size = New System.Drawing.Size(271, 491)
        Me.lsbActID.TabIndex = 1
        Me.lsbActID.ValueMember = "ACT_ID"
        '
        'lblActID
        '
        Me.lblActID.AutoSize = True
        Me.lblActID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActID.ForeColor = System.Drawing.Color.Black
        Me.lblActID.Location = New System.Drawing.Point(13, 11)
        Me.lblActID.Name = "lblActID"
        Me.lblActID.Size = New System.Drawing.Size(31, 19)
        Me.lblActID.TabIndex = 14
        Me.lblActID.Text = "ID:"
        '
        'txbActID
        '
        Me.txbActID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txbActID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txbActID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txbActID.BackColor = System.Drawing.Color.LavenderBlush
        Me.txbActID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbActID.ForeColor = System.Drawing.Color.Black
        Me.txbActID.Location = New System.Drawing.Point(0, 33)
        Me.txbActID.Name = "txbActID"
        Me.txbActID.Size = New System.Drawing.Size(268, 29)
        Me.txbActID.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(297, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 129)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Location = New System.Drawing.Point(557, 33)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 86)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lsbActID)
        Me.Panel1.Controls.Add(Me.lblActID)
        Me.Panel1.Controls.Add(Me.txbActID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 559)
        Me.Panel1.TabIndex = 15
        '
        'AdmKeypad1
        '
        Me.AdmKeypad1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdmKeypad1.DisplayOperators = False
        Me.AdmKeypad1.Location = New System.Drawing.Point(297, 187)
        Me.AdmKeypad1.Margin = New System.Windows.Forms.Padding(7)
        Me.AdmKeypad1.ModifierKeys = New System.Windows.Forms.Keys(-1) {}
        Me.AdmKeypad1.Name = "AdmKeypad1"
        Me.AdmKeypad1.Size = New System.Drawing.Size(379, 356)
        Me.AdmKeypad1.TabIndex = 17
        '
        'ChooseACTbyName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(699, 559)
        Me.Controls.Add(Me.AdmKeypad1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChooseACTbyName"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ChooseACTbyName"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsbActID As System.Windows.Forms.ListBox
    Friend WithEvents lblActID As System.Windows.Forms.Label
    Friend WithEvents txbActID As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AdmKeypad1 As adm.admKeypad
End Class
