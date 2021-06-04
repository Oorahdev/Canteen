<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeFrame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TimeFrame))
        Me.pnlAdminBtn = New System.Windows.Forms.Panel
        Me.btnSetTfr = New System.Windows.Forms.Button
        Me.lblEndTime = New System.Windows.Forms.Label
        Me.lblStartTime = New System.Windows.Forms.Label
        Me.TimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.TimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DsCanteen1 = New Canteen.dsCanteen
        Me.TfrTableAdapter1 = New Canteen.dsCanteenTableAdapters.TFRTableAdapter
        Me.pnlAdminBtn.SuspendLayout()
        CType(Me.DsCanteen1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlAdminBtn
        '
        Me.pnlAdminBtn.Controls.Add(Me.btnSetTfr)
        Me.pnlAdminBtn.Controls.Add(Me.lblEndTime)
        Me.pnlAdminBtn.Controls.Add(Me.lblStartTime)
        Me.pnlAdminBtn.Controls.Add(Me.TimePicker2)
        Me.pnlAdminBtn.Controls.Add(Me.TimePicker1)
        Me.pnlAdminBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAdminBtn.Location = New System.Drawing.Point(0, 0)
        Me.pnlAdminBtn.Name = "pnlAdminBtn"
        Me.pnlAdminBtn.Size = New System.Drawing.Size(393, 150)
        Me.pnlAdminBtn.TabIndex = 13
        '
        'btnSetTfr
        '
        Me.btnSetTfr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSetTfr.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnSetTfr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSetTfr.ForeColor = System.Drawing.Color.White
        Me.btnSetTfr.Location = New System.Drawing.Point(303, 101)
        Me.btnSetTfr.Name = "btnSetTfr"
        Me.btnSetTfr.Size = New System.Drawing.Size(78, 37)
        Me.btnSetTfr.TabIndex = 2
        Me.btnSetTfr.Text = "Set"
        Me.btnSetTfr.UseVisualStyleBackColor = False
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblEndTime.Location = New System.Drawing.Point(24, 65)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(75, 18)
        Me.lblEndTime.TabIndex = 1
        Me.lblEndTime.Text = "End Time:"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblStartTime.Location = New System.Drawing.Point(24, 25)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(80, 18)
        Me.lblStartTime.TabIndex = 1
        Me.lblStartTime.Text = "Start Time:"
        '
        'TimePicker2
        '
        Me.TimePicker2.Location = New System.Drawing.Point(157, 65)
        Me.TimePicker2.Name = "TimePicker2"
        Me.TimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.TimePicker2.TabIndex = 0
        '
        'TimePicker1
        '
        Me.TimePicker1.Location = New System.Drawing.Point(157, 25)
        Me.TimePicker1.Name = "TimePicker1"
        Me.TimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.TimePicker1.TabIndex = 0
        '
        'DsCanteen1
        '
        Me.DsCanteen1.DataSetName = "dsCanteen"
        Me.DsCanteen1.EnforceConstraints = False
        Me.DsCanteen1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TfrTableAdapter1
        '
        Me.TfrTableAdapter1.ClearBeforeFill = True
        '
        'TimeFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(393, 150)
        Me.Controls.Add(Me.pnlAdminBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TimeFrame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pre Order Time Frame"
        Me.pnlAdminBtn.ResumeLayout(False)
        Me.pnlAdminBtn.PerformLayout()
        CType(Me.DsCanteen1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAdminBtn As System.Windows.Forms.Panel
    Friend WithEvents TimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStartTime As System.Windows.Forms.Label
    Friend WithEvents lblEndTime As System.Windows.Forms.Label
    Friend WithEvents DsCanteen1 As Canteen.dsCanteen
    Friend WithEvents btnSetTfr As System.Windows.Forms.Button
    Friend WithEvents TfrTableAdapter1 As Canteen.dsCanteenTableAdapters.TFRTableAdapter
End Class
