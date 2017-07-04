<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.lblLogin = New System.Windows.Forms.Label
        Me.txbUserName = New System.Windows.Forms.TextBox
        Me.txbPassword = New System.Windows.Forms.TextBox
        Me.lblUserName = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.lblError = New System.Windows.Forms.Label
        Me.pnlUser = New System.Windows.Forms.Panel
        Me.pnlKeyboard = New System.Windows.Forms.Panel
        Me.AdmKeyboard1 = New adm.admKeyboard
        Me.dsCanteen1 = New Canteen.dsCanteen
        Me.TUSRTableAdapter1 = New Canteen.dsCanteenTableAdapters.tUSRTableAdapter
        Me.pnlUser.SuspendLayout()
        Me.pnlKeyboard.SuspendLayout()
        CType(Me.dsCanteen1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLogin
        '
        Me.lblLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLogin.Location = New System.Drawing.Point(283, 34)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(166, 33)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "User Login"
        '
        'txbUserName
        '
        Me.txbUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbUserName.ForeColor = System.Drawing.Color.SteelBlue
        Me.txbUserName.Location = New System.Drawing.Point(30, 34)
        Me.txbUserName.Name = "txbUserName"
        Me.txbUserName.Size = New System.Drawing.Size(160, 38)
        Me.txbUserName.TabIndex = 0
        '
        'txbPassword
        '
        Me.txbPassword.AcceptsTab = True
        Me.txbPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txbPassword.ForeColor = System.Drawing.Color.SteelBlue
        Me.txbPassword.Location = New System.Drawing.Point(595, 34)
        Me.txbPassword.Name = "txbPassword"
        Me.txbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbPassword.Size = New System.Drawing.Size(160, 38)
        Me.txbPassword.TabIndex = 1
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(56, 11)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(103, 20)
        Me.lblUserName.TabIndex = 3
        Me.lblUserName.Text = "User Name:"
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(633, 11)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(91, 20)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password:"
        '
        'lblError
        '
        Me.lblError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Orange
        Me.lblError.Location = New System.Drawing.Point(195, 119)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 25)
        Me.lblError.TabIndex = 6
        '
        'pnlUser
        '
        Me.pnlUser.Controls.Add(Me.lblError)
        Me.pnlUser.Controls.Add(Me.txbPassword)
        Me.pnlUser.Controls.Add(Me.lblPassword)
        Me.pnlUser.Controls.Add(Me.lblLogin)
        Me.pnlUser.Controls.Add(Me.txbUserName)
        Me.pnlUser.Controls.Add(Me.lblUserName)
        Me.pnlUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlUser.Location = New System.Drawing.Point(0, 0)
        Me.pnlUser.Name = "pnlUser"
        Me.pnlUser.Size = New System.Drawing.Size(793, 154)
        Me.pnlUser.TabIndex = 0
        '
        'pnlKeyboard
        '
        Me.pnlKeyboard.Controls.Add(Me.AdmKeyboard1)
        Me.pnlKeyboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKeyboard.Location = New System.Drawing.Point(0, 154)
        Me.pnlKeyboard.Name = "pnlKeyboard"
        Me.pnlKeyboard.Size = New System.Drawing.Size(793, 371)
        Me.pnlKeyboard.TabIndex = 7
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
        Me.AdmKeyboard1.Size = New System.Drawing.Size(793, 371)
        Me.AdmKeyboard1.TabIndex = 0
        '
        'dsCanteen1
        '
        Me.dsCanteen1.DataSetName = "dsCanteen"
        Me.dsCanteen1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TUSRTableAdapter1
        '
        Me.TUSRTableAdapter1.ClearBeforeFill = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(793, 525)
        Me.Controls.Add(Me.pnlKeyboard)
        Me.Controls.Add(Me.pnlUser)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.pnlUser.ResumeLayout(False)
        Me.pnlUser.PerformLayout()
        Me.pnlKeyboard.ResumeLayout(False)
        CType(Me.dsCanteen1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents txbUserName As System.Windows.Forms.TextBox
    Friend WithEvents txbPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents dsCanteen1 As Canteen.dsCanteen
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents TUSRTableAdapter1 As Canteen.dsCanteenTableAdapters.tUSRTableAdapter
    Friend WithEvents pnlUser As System.Windows.Forms.Panel
    Friend WithEvents AdmKeyboard1 As adm.admKeyboard
    Friend WithEvents pnlKeyboard As System.Windows.Forms.Panel
End Class
