<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountHistory))
        Me.lblBalance = New System.Windows.Forms.Label
        Me.lblCustName = New System.Windows.Forms.Label
        Me.lblBal = New System.Windows.Forms.Label
        Me.ActDisplayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCanteen = New Canteen.dsCanteen
        Me.lblActName = New System.Windows.Forms.Label
        Me.lsbActHistory = New System.Windows.Forms.ListBox
        Me.btnReturn = New System.Windows.Forms.Button
        Me.btnLastTrn = New System.Windows.Forms.Button
        Me.btnAllTrn = New System.Windows.Forms.Button
        Me.btnReimburse = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.rptAccountHistory = New C1.Win.C1Report.C1Report
        Me.rptLastTrans = New C1.Win.C1Report.C1Report
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.lnsCancel = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.pnlHistory = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlButtons = New System.Windows.Forms.Panel
        Me.btnSelectTrn = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnTop = New System.Windows.Forms.Button
        Me.btnBottom = New System.Windows.Forms.Button
        Me.btnDown = New System.Windows.Forms.Button
        Me.btnUp = New System.Windows.Forms.Button
        Me.ActDisplayTableAdapter1 = New Canteen.dsCanteenTableAdapters.ActDisplayTableAdapter
        Me.TableAdapterManager = New Canteen.dsCanteenTableAdapters.TableAdapterManager
        Me.TACTTableAdapter1 = New Canteen.dsCanteenTableAdapters.tACTTableAdapter
        Me.TPRFTableAdapter1 = New Canteen.dsCanteenTableAdapters.tPRFTableAdapter
        Me.TORDTableAdapter1 = New Canteen.dsCanteenTableAdapters.tORDTableAdapter
        Me.TORSTableAdapter1 = New Canteen.dsCanteenTableAdapters.tORSTableAdapter
        Me.AccountHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountHistoryTableAdapter = New Canteen.dsCanteenTableAdapters.AccountHistoryTableAdapter
        Me.AccountHistorySubBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountHistorySubTableAdapter = New Canteen.dsCanteenTableAdapters.AccountHistorySubTableAdapter
        Me.TTRNBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TTRNTableAdapter = New Canteen.dsCanteenTableAdapters.tTRNTableAdapter
        CType(Me.ActDisplayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptAccountHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptLastTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHistory.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        CType(Me.AccountHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountHistorySubBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TTRNBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.BackColor = System.Drawing.SystemColors.Window
        Me.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBalance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.Black
        Me.lblBalance.Location = New System.Drawing.Point(12, 38)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(132, 20)
        Me.lblBalance.TabIndex = 20
        Me.lblBalance.Text = "Account Balance:"
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.BackColor = System.Drawing.SystemColors.Window
        Me.lblCustName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustName.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.ForeColor = System.Drawing.Color.Black
        Me.lblCustName.Location = New System.Drawing.Point(12, 17)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(115, 20)
        Me.lblCustName.TabIndex = 21
        Me.lblCustName.Text = "Account Name:"
        '
        'lblBal
        '
        Me.lblBal.AutoSize = True
        Me.lblBal.BackColor = System.Drawing.SystemColors.Window
        Me.lblBal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActDisplayBindingSource, "ACT_Balance", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.lblBal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBal.ForeColor = System.Drawing.Color.Black
        Me.lblBal.Location = New System.Drawing.Point(151, 38)
        Me.lblBal.Name = "lblBal"
        Me.lblBal.Size = New System.Drawing.Size(2, 20)
        Me.lblBal.TabIndex = 18
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
        'lblActName
        '
        Me.lblActName.AutoSize = True
        Me.lblActName.BackColor = System.Drawing.SystemColors.Window
        Me.lblActName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblActName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActDisplayBindingSource, "ACT_FullName", True))
        Me.lblActName.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActName.ForeColor = System.Drawing.Color.Black
        Me.lblActName.Location = New System.Drawing.Point(151, 16)
        Me.lblActName.Name = "lblActName"
        Me.lblActName.Size = New System.Drawing.Size(2, 20)
        Me.lblActName.TabIndex = 19
        '
        'lsbActHistory
        '
        Me.lsbActHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lsbActHistory.DisplayMember = "TRN_ID"
        Me.lsbActHistory.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsbActHistory.ForeColor = System.Drawing.Color.Black
        Me.lsbActHistory.FormattingEnabled = True
        Me.lsbActHistory.IntegralHeight = False
        Me.lsbActHistory.ItemHeight = 22
        Me.lsbActHistory.Location = New System.Drawing.Point(12, 86)
        Me.lsbActHistory.Name = "lsbActHistory"
        Me.lsbActHistory.Size = New System.Drawing.Size(313, 406)
        Me.lsbActHistory.TabIndex = 17
        Me.lsbActHistory.ValueMember = "TRN_ID"
        '
        'btnReturn
        '
        Me.btnReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnReturn.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReturn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnReturn.ForeColor = System.Drawing.Color.Black
        Me.btnReturn.Location = New System.Drawing.Point(42, 165)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(124, 55)
        Me.btnReturn.TabIndex = 24
        Me.btnReturn.Text = "Return and Process"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnLastTrn
        '
        Me.btnLastTrn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLastTrn.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnLastTrn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLastTrn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnLastTrn.ForeColor = System.Drawing.Color.Black
        Me.btnLastTrn.Location = New System.Drawing.Point(7, 293)
        Me.btnLastTrn.Name = "btnLastTrn"
        Me.btnLastTrn.Size = New System.Drawing.Size(117, 61)
        Me.btnLastTrn.TabIndex = 25
        Me.btnLastTrn.Text = "Print Last Transaction"
        Me.btnLastTrn.UseVisualStyleBackColor = False
        '
        'btnAllTrn
        '
        Me.btnAllTrn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAllTrn.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAllTrn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAllTrn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnAllTrn.ForeColor = System.Drawing.Color.Black
        Me.btnAllTrn.Location = New System.Drawing.Point(253, 293)
        Me.btnAllTrn.Name = "btnAllTrn"
        Me.btnAllTrn.Size = New System.Drawing.Size(117, 61)
        Me.btnAllTrn.TabIndex = 26
        Me.btnAllTrn.Text = "Print All Transactions"
        Me.btnAllTrn.UseVisualStyleBackColor = False
        '
        'btnReimburse
        '
        Me.btnReimburse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnReimburse.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnReimburse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReimburse.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnReimburse.ForeColor = System.Drawing.Color.Black
        Me.btnReimburse.Location = New System.Drawing.Point(219, 165)
        Me.btnReimburse.Name = "btnReimburse"
        Me.btnReimburse.Size = New System.Drawing.Size(124, 55)
        Me.btnReimburse.TabIndex = 27
        Me.btnReimburse.Text = "Reimburse and Process"
        Me.btnReimburse.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.Location = New System.Drawing.Point(260, 434)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 58)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'rptAccountHistory
        '
        Me.rptAccountHistory.ReportDefinition = resources.GetString("rptAccountHistory.ReportDefinition")
        Me.rptAccountHistory.ReportName = "AccountHistory"
        '
        'rptLastTrans
        '
        Me.rptLastTrans.ReportDefinition = resources.GetString("rptLastTrans.ReportDefinition")
        Me.rptLastTrans.ReportName = "SingleReceipt"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1, Me.lnsCancel})
        Me.ShapeContainer1.Size = New System.Drawing.Size(374, 516)
        Me.ShapeContainer1.TabIndex = 29
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LineShape2.BorderWidth = 3
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.SelectionColor = System.Drawing.Color.NavajoWhite
        Me.LineShape2.X1 = 11
        Me.LineShape2.X2 = 365
        Me.LineShape2.Y1 = 127
        Me.LineShape2.Y2 = 127
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.SelectionColor = System.Drawing.Color.NavajoWhite
        Me.LineShape1.X1 = 7
        Me.LineShape1.X2 = 361
        Me.LineShape1.Y1 = 255
        Me.LineShape1.Y2 = 256
        '
        'lnsCancel
        '
        Me.lnsCancel.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.lnsCancel.BorderWidth = 3
        Me.lnsCancel.Name = "lnsCancel"
        Me.lnsCancel.SelectionColor = System.Drawing.Color.NavajoWhite
        Me.lnsCancel.X1 = 6
        Me.lnsCancel.X2 = 360
        Me.lnsCancel.Y1 = 387
        Me.lnsCancel.Y2 = 388
        '
        'pnlHistory
        '
        Me.pnlHistory.BackColor = System.Drawing.Color.LemonChiffon
        Me.pnlHistory.Controls.Add(Me.Label3)
        Me.pnlHistory.Controls.Add(Me.Label2)
        Me.pnlHistory.Controls.Add(Me.lsbActHistory)
        Me.pnlHistory.Controls.Add(Me.lblActName)
        Me.pnlHistory.Controls.Add(Me.lblBal)
        Me.pnlHistory.Controls.Add(Me.lblBalance)
        Me.pnlHistory.Controls.Add(Me.lblCustName)
        Me.pnlHistory.Location = New System.Drawing.Point(0, 0)
        Me.pnlHistory.Name = "pnlHistory"
        Me.pnlHistory.Size = New System.Drawing.Size(328, 516)
        Me.pnlHistory.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActDisplayBindingSource, "ACT_PrizeMoney", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(191, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(2, 20)
        Me.Label3.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Account Prize Balance:"
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.LemonChiffon
        Me.pnlButtons.Controls.Add(Me.btnSelectTrn)
        Me.pnlButtons.Controls.Add(Me.Label1)
        Me.pnlButtons.Controls.Add(Me.btnCancel)
        Me.pnlButtons.Controls.Add(Me.btnReimburse)
        Me.pnlButtons.Controls.Add(Me.btnAllTrn)
        Me.pnlButtons.Controls.Add(Me.btnLastTrn)
        Me.pnlButtons.Controls.Add(Me.btnReturn)
        Me.pnlButtons.Controls.Add(Me.ShapeContainer1)
        Me.pnlButtons.Location = New System.Drawing.Point(368, 0)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(374, 516)
        Me.pnlButtons.TabIndex = 31
        '
        'btnSelectTrn
        '
        Me.btnSelectTrn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSelectTrn.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSelectTrn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSelectTrn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnSelectTrn.ForeColor = System.Drawing.Color.Black
        Me.btnSelectTrn.Location = New System.Drawing.Point(130, 293)
        Me.btnSelectTrn.Name = "btnSelectTrn"
        Me.btnSelectTrn.Size = New System.Drawing.Size(117, 61)
        Me.btnSelectTrn.TabIndex = 30
        Me.btnSelectTrn.Text = "Print Selected Transaction"
        Me.btnSelectTrn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(107, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 22)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Account History"
        '
        'btnTop
        '
        Me.btnTop.BackColor = System.Drawing.Color.White
        Me.btnTop.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnTop.Image = Global.Canteen.My.Resources.Resources.Collapse_large
        Me.btnTop.Location = New System.Drawing.Point(331, 59)
        Me.btnTop.Name = "btnTop"
        Me.btnTop.Size = New System.Drawing.Size(32, 37)
        Me.btnTop.TabIndex = 47
        Me.btnTop.UseVisualStyleBackColor = False
        '
        'btnBottom
        '
        Me.btnBottom.BackColor = System.Drawing.Color.White
        Me.btnBottom.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnBottom.Image = Global.Canteen.My.Resources.Resources.Expand_large
        Me.btnBottom.Location = New System.Drawing.Point(331, 188)
        Me.btnBottom.Name = "btnBottom"
        Me.btnBottom.Size = New System.Drawing.Size(32, 37)
        Me.btnBottom.TabIndex = 46
        Me.btnBottom.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDown.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(331, 143)
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
        Me.btnUp.Location = New System.Drawing.Point(331, 104)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(32, 37)
        Me.btnUp.TabIndex = 44
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'ActDisplayTableAdapter1
        '
        Me.ActDisplayTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tACTTableAdapter = Me.TACTTableAdapter1
        Me.TableAdapterManager.tBNKTableAdapter = Nothing
        Me.TableAdapterManager.tCTGTableAdapter = Nothing
        Me.TableAdapterManager.tINTTableAdapter = Nothing
        Me.TableAdapterManager.tINVTableAdapter = Nothing
        Me.TableAdapterManager.tITMTableAdapter = Nothing
        Me.TableAdapterManager.tORDTableAdapter = Nothing
        Me.TableAdapterManager.tORSTableAdapter = Nothing
        Me.TableAdapterManager.tPRFTableAdapter = Me.TPRFTableAdapter1
        Me.TableAdapterManager.tPSNTableAdapter = Nothing
        Me.TableAdapterManager.tTRNTableAdapter = Nothing
        Me.TableAdapterManager.tUSRTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Canteen.dsCanteenTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TACTTableAdapter1
        '
        Me.TACTTableAdapter1.ClearBeforeFill = True
        '
        'TPRFTableAdapter1
        '
        Me.TPRFTableAdapter1.ClearBeforeFill = True
        '
        'TORDTableAdapter1
        '
        Me.TORDTableAdapter1.ClearBeforeFill = True
        '
        'TORSTableAdapter1
        '
        Me.TORSTableAdapter1.ClearBeforeFill = True
        '
        'AccountHistoryBindingSource
        '
        Me.AccountHistoryBindingSource.DataMember = "AccountHistory"
        Me.AccountHistoryBindingSource.DataSource = Me.DsCanteen
        '
        'AccountHistoryTableAdapter
        '
        Me.AccountHistoryTableAdapter.ClearBeforeFill = True
        '
        'AccountHistorySubBindingSource
        '
        Me.AccountHistorySubBindingSource.DataMember = "AccountHistorySub"
        Me.AccountHistorySubBindingSource.DataSource = Me.DsCanteen
        '
        'AccountHistorySubTableAdapter
        '
        Me.AccountHistorySubTableAdapter.ClearBeforeFill = True
        '
        'TTRNBindingSource
        '
        Me.TTRNBindingSource.DataMember = "tTRN"
        Me.TTRNBindingSource.DataSource = Me.DsCanteen
        '
        'TTRNTableAdapter
        '
        Me.TTRNTableAdapter.ClearBeforeFill = True
        '
        'AccountHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(742, 516)
        Me.Controls.Add(Me.btnTop)
        Me.Controls.Add(Me.btnBottom)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.pnlHistory)
        Me.Controls.Add(Me.pnlButtons)
        Me.ForeColor = System.Drawing.Color.DarkOrange
        Me.Name = "AccountHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AccountHistory"
        CType(Me.ActDisplayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCanteen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptAccountHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptLastTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHistory.ResumeLayout(False)
        Me.pnlHistory.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlButtons.PerformLayout()
        CType(Me.AccountHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountHistorySubBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TTRNBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents lblCustName As System.Windows.Forms.Label
    Friend WithEvents lblBal As System.Windows.Forms.Label
    Friend WithEvents lblActName As System.Windows.Forms.Label
    Friend WithEvents lsbActHistory As System.Windows.Forms.ListBox
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnLastTrn As System.Windows.Forms.Button
    Friend WithEvents btnAllTrn As System.Windows.Forms.Button
    Friend WithEvents btnReimburse As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ActDisplayTableAdapter1 As Canteen.dsCanteenTableAdapters.ActDisplayTableAdapter
    Friend WithEvents DsCanteen As Canteen.dsCanteen
    Friend WithEvents ActDisplayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As Canteen.dsCanteenTableAdapters.TableAdapterManager
    Friend WithEvents TACTTableAdapter1 As Canteen.dsCanteenTableAdapters.tACTTableAdapter
    Friend WithEvents rptAccountHistory As C1.Win.C1Report.C1Report
    Friend WithEvents rptLastTrans As C1.Win.C1Report.C1Report
    Friend WithEvents TPRFTableAdapter1 As Canteen.dsCanteenTableAdapters.tPRFTableAdapter
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lnsCancel As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents pnlHistory As System.Windows.Forms.Panel
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TORDTableAdapter1 As Canteen.dsCanteenTableAdapters.tORDTableAdapter
    Friend WithEvents TORSTableAdapter1 As Canteen.dsCanteenTableAdapters.tORSTableAdapter
    Friend WithEvents AccountHistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccountHistoryTableAdapter As Canteen.dsCanteenTableAdapters.AccountHistoryTableAdapter
    Friend WithEvents AccountHistorySubBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccountHistorySubTableAdapter As Canteen.dsCanteenTableAdapters.AccountHistorySubTableAdapter
    Friend WithEvents TTRNBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TTRNTableAdapter As Canteen.dsCanteenTableAdapters.tTRNTableAdapter
    Friend WithEvents btnSelectTrn As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnBottom As System.Windows.Forms.Button
    Friend WithEvents btnTop As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
