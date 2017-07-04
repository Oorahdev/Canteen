<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentForm))
        Me.txbAmount = New System.Windows.Forms.TextBox
        Me.lblPaymentAmount = New System.Windows.Forms.Label
        Me.txbCheckNum = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.checkDate = New C1.Win.C1Input.C1DateEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cashRB = New System.Windows.Forms.RadioButton
        Me.checkRB = New System.Windows.Forms.RadioButton
        Me.creditCardRB = New System.Windows.Forms.RadioButton
        Me.AdmKeypad1 = New adm.admKeypad
        Me.btnCancel = New System.Windows.Forms.Button
        Me.panel2 = New System.Windows.Forms.Panel
        Me.rbPrizeMoney = New System.Windows.Forms.RadioButton
        CType(Me.checkDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txbAmount
        '
        Me.txbAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txbAmount.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbAmount.ForeColor = System.Drawing.Color.Black
        Me.txbAmount.Location = New System.Drawing.Point(229, 131)
        Me.txbAmount.Name = "txbAmount"
        Me.txbAmount.Size = New System.Drawing.Size(196, 29)
        Me.txbAmount.TabIndex = 0
        '
        'lblPaymentAmount
        '
        Me.lblPaymentAmount.AutoSize = True
        Me.lblPaymentAmount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentAmount.ForeColor = System.Drawing.Color.Black
        Me.lblPaymentAmount.Location = New System.Drawing.Point(225, 84)
        Me.lblPaymentAmount.Name = "lblPaymentAmount"
        Me.lblPaymentAmount.Size = New System.Drawing.Size(145, 19)
        Me.lblPaymentAmount.TabIndex = 2
        Me.lblPaymentAmount.Text = "Payment Amount:"
        '
        'txbCheckNum
        '
        Me.txbCheckNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txbCheckNum.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCheckNum.ForeColor = System.Drawing.Color.Black
        Me.txbCheckNum.Location = New System.Drawing.Point(121, 23)
        Me.txbCheckNum.Name = "txbCheckNum"
        Me.txbCheckNum.Size = New System.Drawing.Size(121, 29)
        Me.txbCheckNum.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Check #"
        '
        'checkDate
        '
        Me.checkDate.ButtonWidth = 35
        '
        '
        '
        Me.checkDate.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.checkDate.Calendar.BoldedDates = New Date(-1) {}
        Me.checkDate.Calendar.ClearText = "&Clear"
        Me.checkDate.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkDate.Calendar.Margin = New System.Windows.Forms.Padding(0)
        Me.checkDate.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.checkDate.Calendar.SelectedDate = New Date(2010, 6, 23, 0, 0, 0, 0)
        Me.checkDate.Calendar.TodayText = "&Today"
        Me.checkDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.checkDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.checkDate.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.checkDate.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.checkDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkDate.ForeColor = System.Drawing.Color.Black
        Me.checkDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.checkDate.Location = New System.Drawing.Point(57, 76)
        Me.checkDate.Name = "checkDate"
        Me.checkDate.Size = New System.Drawing.Size(185, 32)
        Me.checkDate.TabIndex = 7
        Me.checkDate.Tag = Nothing
        Me.checkDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txbCheckNum)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.checkDate)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(465, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 136)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Check Info"
        '
        'cashRB
        '
        Me.cashRB.AutoSize = True
        Me.cashRB.Checked = True
        Me.cashRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cashRB.ForeColor = System.Drawing.Color.Black
        Me.cashRB.Location = New System.Drawing.Point(30, 24)
        Me.cashRB.Name = "cashRB"
        Me.cashRB.Size = New System.Drawing.Size(71, 28)
        Me.cashRB.TabIndex = 12
        Me.cashRB.Text = "Cash"
        Me.cashRB.UseVisualStyleBackColor = True
        '
        'checkRB
        '
        Me.checkRB.AutoSize = True
        Me.checkRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkRB.ForeColor = System.Drawing.Color.Black
        Me.checkRB.Location = New System.Drawing.Point(30, 78)
        Me.checkRB.Name = "checkRB"
        Me.checkRB.Size = New System.Drawing.Size(82, 28)
        Me.checkRB.TabIndex = 13
        Me.checkRB.Text = "Check"
        Me.checkRB.UseVisualStyleBackColor = True
        '
        'creditCardRB
        '
        Me.creditCardRB.AutoSize = True
        Me.creditCardRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creditCardRB.ForeColor = System.Drawing.Color.Black
        Me.creditCardRB.Location = New System.Drawing.Point(30, 132)
        Me.creditCardRB.Name = "creditCardRB"
        Me.creditCardRB.Size = New System.Drawing.Size(122, 28)
        Me.creditCardRB.TabIndex = 14
        Me.creditCardRB.Text = "Credit Card"
        Me.creditCardRB.UseVisualStyleBackColor = True
        '
        'AdmKeypad1
        '
        Me.AdmKeypad1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AdmKeypad1.DisplayOperators = False
        Me.AdmKeypad1.Location = New System.Drawing.Point(191, 25)
        Me.AdmKeypad1.Margin = New System.Windows.Forms.Padding(0)
        Me.AdmKeypad1.ModifierKeys = New System.Windows.Forms.Keys(-1) {}
        Me.AdmKeypad1.Name = "AdmKeypad1"
        Me.AdmKeypad1.Size = New System.Drawing.Size(287, 292)
        Me.AdmKeypad1.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Location = New System.Drawing.Point(640, 240)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 62)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.LemonChiffon
        Me.panel2.Controls.Add(Me.btnCancel)
        Me.panel2.Controls.Add(Me.AdmKeypad1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 219)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(742, 349)
        Me.panel2.TabIndex = 1
        '
        'rbPrizeMoney
        '
        Me.rbPrizeMoney.AutoSize = True
        Me.rbPrizeMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPrizeMoney.ForeColor = System.Drawing.Color.Black
        Me.rbPrizeMoney.Location = New System.Drawing.Point(30, 185)
        Me.rbPrizeMoney.Name = "rbPrizeMoney"
        Me.rbPrizeMoney.Size = New System.Drawing.Size(133, 28)
        Me.rbPrizeMoney.TabIndex = 15
        Me.rbPrizeMoney.Text = "Prize Money"
        Me.rbPrizeMoney.UseVisualStyleBackColor = True
        '
        'PaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(742, 568)
        Me.Controls.Add(Me.rbPrizeMoney)
        Me.Controls.Add(Me.creditCardRB)
        Me.Controls.Add(Me.checkRB)
        Me.Controls.Add(Me.cashRB)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblPaymentAmount)
        Me.Controls.Add(Me.txbAmount)
        Me.Controls.Add(Me.panel2)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PaymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payment"
        CType(Me.checkDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txbAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblPaymentAmount As System.Windows.Forms.Label
    Friend WithEvents txbCheckNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents checkDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cashRB As System.Windows.Forms.RadioButton
    Friend WithEvents checkRB As System.Windows.Forms.RadioButton
    Friend WithEvents creditCardRB As System.Windows.Forms.RadioButton
    Friend WithEvents AdmKeypad1 As adm.admKeypad
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbPrizeMoney As System.Windows.Forms.RadioButton
End Class
