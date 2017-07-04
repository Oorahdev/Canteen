<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orders))
        Me.pnl1 = New System.Windows.Forms.Panel
        Me.pnlList = New System.Windows.Forms.Panel
        Me.lblPrizeBal = New System.Windows.Forms.Label
        Me.ActDisplayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCanteen1 = New Canteen.dsCanteen
        Me.lblPrizeBalance = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblPrizePay = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblPrize = New System.Windows.Forms.Label
        Me.lblPrizeMoney = New System.Windows.Forms.Label
        Me.lblTot = New System.Windows.Forms.Label
        Me.lblPay = New System.Windows.Forms.Label
        Me.lblCash = New System.Windows.Forms.Label
        Me.lblSub = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblPayment = New System.Windows.Forms.Label
        Me.lblCashBack = New System.Windows.Forms.Label
        Me.lblSubTotal = New System.Windows.Forms.Label
        Me.lblBalance = New System.Windows.Forms.Label
        Me.btnDown = New System.Windows.Forms.Button
        Me.btnUp = New System.Windows.Forms.Button
        Me.lblBal = New System.Windows.Forms.Label
        Me.lblActName = New System.Windows.Forms.Label
        Me.btnLogOut = New System.Windows.Forms.Button
        Me.lsbItems = New System.Windows.Forms.ListBox
        Me.lblCustName = New System.Windows.Forms.Label
        Me.pnlProcess = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnEditPrice = New System.Windows.Forms.Button
        Me.btnManageAct = New System.Windows.Forms.Button
        Me.btnAdmin = New System.Windows.Forms.Button
        Me.btnPayment = New System.Windows.Forms.Button
        Me.btnCash = New System.Windows.Forms.Button
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnProcess = New System.Windows.Forms.Button
        Me.btnChooseAct = New System.Windows.Forms.Button
        Me.chkPrizeMoney = New System.Windows.Forms.CheckBox
        Me.tbcItems = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.SingleReceipt = New C1.Win.C1Report.C1Report
        Me.OrderSubReceipt = New C1.Win.C1Report.C1Report
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TCTGTableAdapter1 = New Canteen.dsCanteenTableAdapters.tCTGTableAdapter
        Me.TITMTableAdapter1 = New Canteen.dsCanteenTableAdapters.tITMTableAdapter
        Me.ActDisplayTableAdapter = New Canteen.dsCanteenTableAdapters.ActDisplayTableAdapter
        Me.TINVTableAdapter1 = New Canteen.dsCanteenTableAdapters.tINVTableAdapter
        Me.TACTTableAdapter1 = New Canteen.dsCanteenTableAdapters.tACTTableAdapter
        Me.TUSRTableAdapter1 = New Canteen.dsCanteenTableAdapters.tUSRTableAdapter
        Me.TPRFTableAdapter1 = New Canteen.dsCanteenTableAdapters.tPRFTableAdapter
        Me.TPORTableAdapter1 = New Canteen.dsCanteenTableAdapters.tPORTableAdapter
        Me.TPOSTableAdapter1 = New Canteen.dsCanteenTableAdapters.tPOSTableAdapter
        Me.GetPreOrderItmsTableAdapter1 = New Canteen.dsCanteenTableAdapters.GetPreOrderItmsTableAdapter
        Me.pnl1.SuspendLayout()
        Me.pnlList.SuspendLayout()
        CType(Me.ActDisplayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCanteen1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlProcess.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcItems.SuspendLayout()
        CType(Me.SingleReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderSubReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnl1.Controls.Add(Me.pnlList)
        Me.pnl1.Controls.Add(Me.pnlProcess)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(305, 516)
        Me.pnl1.TabIndex = 16
        '
        'pnlList
        '
        Me.pnlList.BackColor = System.Drawing.Color.LemonChiffon
        Me.pnlList.Controls.Add(Me.lblPrizeBal)
        Me.pnlList.Controls.Add(Me.lblPrizeBalance)
        Me.pnlList.Controls.Add(Me.Panel1)
        Me.pnlList.Controls.Add(Me.lblBalance)
        Me.pnlList.Controls.Add(Me.btnDown)
        Me.pnlList.Controls.Add(Me.btnUp)
        Me.pnlList.Controls.Add(Me.lblBal)
        Me.pnlList.Controls.Add(Me.lblActName)
        Me.pnlList.Controls.Add(Me.btnLogOut)
        Me.pnlList.Controls.Add(Me.lsbItems)
        Me.pnlList.Controls.Add(Me.lblCustName)
        Me.pnlList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlList.Location = New System.Drawing.Point(0, 0)
        Me.pnlList.Name = "pnlList"
        Me.pnlList.Size = New System.Drawing.Size(305, 283)
        Me.pnlList.TabIndex = 19
        '
        'lblPrizeBal
        '
        Me.lblPrizeBal.AutoSize = True
        Me.lblPrizeBal.BackColor = System.Drawing.SystemColors.Window
        Me.lblPrizeBal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrizeBal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActDisplayBindingSource, "ACT_PrizeMoney", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.lblPrizeBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrizeBal.ForeColor = System.Drawing.Color.Black
        Me.lblPrizeBal.Location = New System.Drawing.Point(221, 51)
        Me.lblPrizeBal.Name = "lblPrizeBal"
        Me.lblPrizeBal.Size = New System.Drawing.Size(2, 22)
        Me.lblPrizeBal.TabIndex = 23
        '
        'ActDisplayBindingSource
        '
        Me.ActDisplayBindingSource.DataMember = "ActDisplay"
        Me.ActDisplayBindingSource.DataSource = Me.DsCanteen1
        '
        'DsCanteen1
        '
        Me.DsCanteen1.DataSetName = "dsCanteen"
        Me.DsCanteen1.EnforceConstraints = False
        Me.DsCanteen1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblPrizeBalance
        '
        Me.lblPrizeBalance.AutoSize = True
        Me.lblPrizeBalance.BackColor = System.Drawing.SystemColors.Window
        Me.lblPrizeBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrizeBalance.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrizeBalance.ForeColor = System.Drawing.Color.Black
        Me.lblPrizeBalance.Location = New System.Drawing.Point(36, 51)
        Me.lblPrizeBalance.Name = "lblPrizeBalance"
        Me.lblPrizeBalance.Size = New System.Drawing.Size(183, 21)
        Me.lblPrizeBalance.TabIndex = 22
        Me.lblPrizeBalance.Text = "Account Prize Balance:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.lblPrizePay)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblPrize)
        Me.Panel1.Controls.Add(Me.lblPrizeMoney)
        Me.Panel1.Controls.Add(Me.lblTot)
        Me.Panel1.Controls.Add(Me.lblPay)
        Me.Panel1.Controls.Add(Me.lblCash)
        Me.Panel1.Controls.Add(Me.lblSub)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.lblPayment)
        Me.Panel1.Controls.Add(Me.lblCashBack)
        Me.Panel1.Controls.Add(Me.lblSubTotal)
        Me.Panel1.Location = New System.Drawing.Point(37, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(253, 108)
        Me.Panel1.TabIndex = 21
        '
        'lblPrizePay
        '
        Me.lblPrizePay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrizePay.BackColor = System.Drawing.Color.White
        Me.lblPrizePay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblPrizePay.ForeColor = System.Drawing.Color.Black
        Me.lblPrizePay.Location = New System.Drawing.Point(123, 17)
        Me.lblPrizePay.Name = "lblPrizePay"
        Me.lblPrizePay.Size = New System.Drawing.Size(123, 15)
        Me.lblPrizePay.TabIndex = 27
        Me.lblPrizePay.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Prize Payment:"
        '
        'lblPrize
        '
        Me.lblPrize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrize.BackColor = System.Drawing.Color.White
        Me.lblPrize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrize.ForeColor = System.Drawing.Color.Black
        Me.lblPrize.Location = New System.Drawing.Point(123, 32)
        Me.lblPrize.Name = "lblPrize"
        Me.lblPrize.Size = New System.Drawing.Size(123, 15)
        Me.lblPrize.TabIndex = 25
        Me.lblPrize.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPrizeMoney
        '
        Me.lblPrizeMoney.AutoSize = True
        Me.lblPrizeMoney.BackColor = System.Drawing.Color.White
        Me.lblPrizeMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrizeMoney.ForeColor = System.Drawing.Color.Black
        Me.lblPrizeMoney.Location = New System.Drawing.Point(1, 32)
        Me.lblPrizeMoney.Name = "lblPrizeMoney"
        Me.lblPrizeMoney.Size = New System.Drawing.Size(80, 15)
        Me.lblPrizeMoney.TabIndex = 24
        Me.lblPrizeMoney.Text = "Prize Total:"
        '
        'lblTot
        '
        Me.lblTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTot.BackColor = System.Drawing.Color.White
        Me.lblTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTot.ForeColor = System.Drawing.Color.Black
        Me.lblTot.Location = New System.Drawing.Point(123, 77)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(123, 15)
        Me.lblTot.TabIndex = 23
        Me.lblTot.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPay
        '
        Me.lblPay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPay.BackColor = System.Drawing.Color.White
        Me.lblPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblPay.ForeColor = System.Drawing.Color.Black
        Me.lblPay.Location = New System.Drawing.Point(123, 62)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(123, 15)
        Me.lblPay.TabIndex = 22
        Me.lblPay.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCash
        '
        Me.lblCash.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCash.BackColor = System.Drawing.Color.White
        Me.lblCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblCash.ForeColor = System.Drawing.Color.Black
        Me.lblCash.Location = New System.Drawing.Point(123, 47)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(123, 15)
        Me.lblCash.TabIndex = 22
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSub
        '
        Me.lblSub.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSub.BackColor = System.Drawing.Color.White
        Me.lblSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblSub.ForeColor = System.Drawing.Color.Black
        Me.lblSub.Location = New System.Drawing.Point(123, 1)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(123, 15)
        Me.lblSub.TabIndex = 21
        Me.lblSub.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(1, 77)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(89, 15)
        Me.lblTotal.TabIndex = 20
        Me.lblTotal.Text = "Money Total:"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.BackColor = System.Drawing.Color.White
        Me.lblPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblPayment.ForeColor = System.Drawing.Color.Black
        Me.lblPayment.Location = New System.Drawing.Point(1, 62)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(98, 15)
        Me.lblPayment.TabIndex = 19
        Me.lblPayment.Text = "Money Payment:"
        '
        'lblCashBack
        '
        Me.lblCashBack.AutoSize = True
        Me.lblCashBack.BackColor = System.Drawing.Color.White
        Me.lblCashBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblCashBack.ForeColor = System.Drawing.Color.Black
        Me.lblCashBack.Location = New System.Drawing.Point(1, 47)
        Me.lblCashBack.Name = "lblCashBack"
        Me.lblCashBack.Size = New System.Drawing.Size(68, 15)
        Me.lblCashBack.TabIndex = 18
        Me.lblCashBack.Text = "Cash Back:"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.BackColor = System.Drawing.Color.White
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblSubTotal.ForeColor = System.Drawing.Color.Black
        Me.lblSubTotal.Location = New System.Drawing.Point(1, 1)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(62, 15)
        Me.lblSubTotal.TabIndex = 17
        Me.lblSubTotal.Text = "Sub Total:"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.BackColor = System.Drawing.SystemColors.Window
        Me.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBalance.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.Black
        Me.lblBalance.Location = New System.Drawing.Point(36, 26)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(140, 21)
        Me.lblBalance.TabIndex = 15
        Me.lblBalance.Text = "Account Balance:"
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDown.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(2, 213)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(32, 37)
        Me.btnDown.TabIndex = 6
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnUp.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(2, 174)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(32, 37)
        Me.btnUp.TabIndex = 5
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'lblBal
        '
        Me.lblBal.AutoSize = True
        Me.lblBal.BackColor = System.Drawing.SystemColors.Window
        Me.lblBal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActDisplayBindingSource, "ACT_Balance", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.lblBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBal.ForeColor = System.Drawing.Color.Black
        Me.lblBal.Location = New System.Drawing.Point(177, 25)
        Me.lblBal.Name = "lblBal"
        Me.lblBal.Size = New System.Drawing.Size(2, 22)
        Me.lblBal.TabIndex = 7
        '
        'lblActName
        '
        Me.lblActName.AutoSize = True
        Me.lblActName.BackColor = System.Drawing.SystemColors.Window
        Me.lblActName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblActName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActDisplayBindingSource, "ACT_FullName", True))
        Me.lblActName.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActName.ForeColor = System.Drawing.Color.Black
        Me.lblActName.Location = New System.Drawing.Point(114, 3)
        Me.lblActName.Name = "lblActName"
        Me.lblActName.Size = New System.Drawing.Size(2, 21)
        Me.lblActName.TabIndex = 8
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnLogOut.Font = New System.Drawing.Font("Arial", 13.25!, System.Drawing.FontStyle.Bold)
        Me.btnLogOut.ForeColor = System.Drawing.Color.Black
        Me.btnLogOut.Location = New System.Drawing.Point(2, 5)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(32, 159)
        Me.btnLogOut.TabIndex = 14
        Me.btnLogOut.Text = "Log  Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'lsbItems
        '
        Me.lsbItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lsbItems.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsbItems.ForeColor = System.Drawing.Color.Black
        Me.lsbItems.FormattingEnabled = True
        Me.lsbItems.IntegralHeight = False
        Me.lsbItems.ItemHeight = 18
        Me.lsbItems.Location = New System.Drawing.Point(37, 75)
        Me.lsbItems.Name = "lsbItems"
        Me.lsbItems.Size = New System.Drawing.Size(253, 97)
        Me.lsbItems.TabIndex = 1
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.BackColor = System.Drawing.SystemColors.Window
        Me.lblCustName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustName.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.ForeColor = System.Drawing.Color.Black
        Me.lblCustName.Location = New System.Drawing.Point(37, 3)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(76, 21)
        Me.lblCustName.TabIndex = 16
        Me.lblCustName.Text = "Account:"
        '
        'pnlProcess
        '
        Me.pnlProcess.BackColor = System.Drawing.Color.LemonChiffon
        Me.pnlProcess.Controls.Add(Me.PictureBox1)
        Me.pnlProcess.Controls.Add(Me.btnEditPrice)
        Me.pnlProcess.Controls.Add(Me.btnManageAct)
        Me.pnlProcess.Controls.Add(Me.btnAdmin)
        Me.pnlProcess.Controls.Add(Me.btnPayment)
        Me.pnlProcess.Controls.Add(Me.btnCash)
        Me.pnlProcess.Controls.Add(Me.btnRemove)
        Me.pnlProcess.Controls.Add(Me.btnProcess)
        Me.pnlProcess.Controls.Add(Me.btnChooseAct)
        Me.pnlProcess.Controls.Add(Me.chkPrizeMoney)
        Me.pnlProcess.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlProcess.Location = New System.Drawing.Point(0, 283)
        Me.pnlProcess.Name = "pnlProcess"
        Me.pnlProcess.Size = New System.Drawing.Size(305, 233)
        Me.pnlProcess.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(4, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 99)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btnEditPrice
        '
        Me.btnEditPrice.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnEditPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditPrice.ForeColor = System.Drawing.Color.Red
        Me.btnEditPrice.Location = New System.Drawing.Point(199, 7)
        Me.btnEditPrice.Name = "btnEditPrice"
        Me.btnEditPrice.Size = New System.Drawing.Size(90, 35)
        Me.btnEditPrice.TabIndex = 16
        Me.btnEditPrice.Text = "Edit Price"
        Me.btnEditPrice.UseVisualStyleBackColor = False
        '
        'btnManageAct
        '
        Me.btnManageAct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnManageAct.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnManageAct.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageAct.ForeColor = System.Drawing.Color.Black
        Me.btnManageAct.Location = New System.Drawing.Point(108, 51)
        Me.btnManageAct.Name = "btnManageAct"
        Me.btnManageAct.Size = New System.Drawing.Size(90, 55)
        Me.btnManageAct.TabIndex = 11
        Me.btnManageAct.Text = "Manage Account"
        Me.btnManageAct.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnAdmin.Enabled = False
        Me.btnAdmin.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnAdmin.ForeColor = System.Drawing.Color.Black
        Me.btnAdmin.Location = New System.Drawing.Point(4, 178)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(97, 43)
        Me.btnAdmin.TabIndex = 15
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnPayment
        '
        Me.btnPayment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPayment.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ForeColor = System.Drawing.Color.Black
        Me.btnPayment.Location = New System.Drawing.Point(199, 110)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(90, 55)
        Me.btnPayment.TabIndex = 12
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'btnCash
        '
        Me.btnCash.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCash.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCash.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.ForeColor = System.Drawing.Color.Black
        Me.btnCash.Location = New System.Drawing.Point(108, 110)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(90, 55)
        Me.btnCash.TabIndex = 9
        Me.btnCash.Text = "Cash back"
        Me.btnCash.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnRemove.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemove.ForeColor = System.Drawing.Color.Red
        Me.btnRemove.Location = New System.Drawing.Point(108, 7)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(90, 35)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnProcess.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnProcess.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnProcess.ForeColor = System.Drawing.Color.White
        Me.btnProcess.Location = New System.Drawing.Point(108, 170)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(181, 56)
        Me.btnProcess.TabIndex = 0
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = False
        '
        'btnChooseAct
        '
        Me.btnChooseAct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnChooseAct.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnChooseAct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnChooseAct.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnChooseAct.ForeColor = System.Drawing.Color.Black
        Me.btnChooseAct.Location = New System.Drawing.Point(199, 51)
        Me.btnChooseAct.Name = "btnChooseAct"
        Me.btnChooseAct.Size = New System.Drawing.Size(90, 55)
        Me.btnChooseAct.TabIndex = 10
        Me.btnChooseAct.Text = "Choose Account"
        Me.btnChooseAct.UseVisualStyleBackColor = False
        '
        'chkPrizeMoney
        '
        Me.chkPrizeMoney.AutoSize = True
        Me.chkPrizeMoney.Checked = True
        Me.chkPrizeMoney.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrizeMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.chkPrizeMoney.Location = New System.Drawing.Point(4, 7)
        Me.chkPrizeMoney.Name = "chkPrizeMoney"
        Me.chkPrizeMoney.Size = New System.Drawing.Size(106, 17)
        Me.chkPrizeMoney.TabIndex = 18
        Me.chkPrizeMoney.Text = "Use Prize Money"
        Me.chkPrizeMoney.UseVisualStyleBackColor = True
        '
        'tbcItems
        '
        Me.tbcItems.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.tbcItems.Controls.Add(Me.TabPage1)
        Me.tbcItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcItems.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcItems.HotTrack = True
        Me.tbcItems.ItemSize = New System.Drawing.Size(200, 90)
        Me.tbcItems.Location = New System.Drawing.Point(305, 0)
        Me.tbcItems.Multiline = True
        Me.tbcItems.Name = "tbcItems"
        Me.tbcItems.Padding = New System.Drawing.Point(16, 16)
        Me.tbcItems.SelectedIndex = 0
        Me.tbcItems.ShowToolTips = True
        Me.tbcItems.Size = New System.Drawing.Size(437, 516)
        Me.tbcItems.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(429, 418)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SingleReceipt
        '
        Me.SingleReceipt.ReportDefinition = resources.GetString("SingleReceipt.ReportDefinition")
        Me.SingleReceipt.ReportName = "SingleReceipt"
        '
        'OrderSubReceipt
        '
        Me.OrderSubReceipt.ReportDefinition = resources.GetString("OrderSubReceipt.ReportDefinition")
        Me.OrderSubReceipt.ReportName = "OrderSubReceipt"
        '
        'TCTGTableAdapter1
        '
        Me.TCTGTableAdapter1.ClearBeforeFill = True
        '
        'TITMTableAdapter1
        '
        Me.TITMTableAdapter1.ClearBeforeFill = True
        '
        'ActDisplayTableAdapter
        '
        Me.ActDisplayTableAdapter.ClearBeforeFill = True
        '
        'TINVTableAdapter1
        '
        Me.TINVTableAdapter1.ClearBeforeFill = True
        '
        'TACTTableAdapter1
        '
        Me.TACTTableAdapter1.ClearBeforeFill = True
        '
        'TUSRTableAdapter1
        '
        Me.TUSRTableAdapter1.ClearBeforeFill = True
        '
        'TPRFTableAdapter1
        '
        Me.TPRFTableAdapter1.ClearBeforeFill = True
        '
        'TPORTableAdapter1
        '
        Me.TPORTableAdapter1.ClearBeforeFill = True
        '
        'TPOSTableAdapter1
        '
        Me.TPOSTableAdapter1.ClearBeforeFill = True
        '
        'GetPreOrderItmsTableAdapter1
        '
        Me.GetPreOrderItmsTableAdapter1.ClearBeforeFill = True
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(742, 516)
        Me.Controls.Add(Me.tbcItems)
        Me.Controls.Add(Me.pnl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Orders"
        Me.Text = "Orders"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl1.ResumeLayout(False)
        Me.pnlList.ResumeLayout(False)
        Me.pnlList.PerformLayout()
        CType(Me.ActDisplayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCanteen1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlProcess.ResumeLayout(False)
        Me.pnlProcess.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcItems.ResumeLayout(False)
        CType(Me.SingleReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderSubReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents tbcItems As System.Windows.Forms.TabControl
    Friend WithEvents pnlList As System.Windows.Forms.Panel
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents lblBal As System.Windows.Forms.Label
    Friend WithEvents lblActName As System.Windows.Forms.Label
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents lsbItems As System.Windows.Forms.ListBox
    Friend WithEvents pnlProcess As System.Windows.Forms.Panel
    Friend WithEvents btnManageAct As System.Windows.Forms.Button
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents btnPayment As System.Windows.Forms.Button
    Friend WithEvents btnCash As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnChooseAct As System.Windows.Forms.Button
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents lblCustName As System.Windows.Forms.Label
    Friend WithEvents TCTGTableAdapter1 As Canteen.dsCanteenTableAdapters.tCTGTableAdapter
    Friend WithEvents TITMTableAdapter1 As Canteen.dsCanteenTableAdapters.tITMTableAdapter
    Friend WithEvents ActDisplayTableAdapter As Canteen.dsCanteenTableAdapters.ActDisplayTableAdapter
    Friend WithEvents TINVTableAdapter1 As Canteen.dsCanteenTableAdapters.tINVTableAdapter
    Friend WithEvents TACTTableAdapter1 As Canteen.dsCanteenTableAdapters.tACTTableAdapter
    Friend WithEvents DsCanteen1 As Canteen.dsCanteen
    Friend WithEvents ActDisplayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TUSRTableAdapter1 As Canteen.dsCanteenTableAdapters.tUSRTableAdapter
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents lblCashBack As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblPay As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents lblSub As System.Windows.Forms.Label
    Friend WithEvents lblTot As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SingleReceipt As C1.Win.C1Report.C1Report
    Friend WithEvents OrderSubReceipt As C1.Win.C1Report.C1Report
    Friend WithEvents TPRFTableAdapter1 As Canteen.dsCanteenTableAdapters.tPRFTableAdapter
    Friend WithEvents btnEditPrice As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblPrizeBalance As System.Windows.Forms.Label
    Friend WithEvents lblPrize As System.Windows.Forms.Label
    Friend WithEvents lblPrizeMoney As System.Windows.Forms.Label
    Friend WithEvents chkPrizeMoney As System.Windows.Forms.CheckBox
    Friend WithEvents lblPrizeBal As System.Windows.Forms.Label
    Friend WithEvents lblPrizePay As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TPORTableAdapter1 As Canteen.dsCanteenTableAdapters.tPORTableAdapter
    Friend WithEvents TPOSTableAdapter1 As Canteen.dsCanteenTableAdapters.tPOSTableAdapter
    Friend WithEvents GetPreOrderItmsTableAdapter1 As Canteen.dsCanteenTableAdapters.GetPreOrderItmsTableAdapter
End Class
