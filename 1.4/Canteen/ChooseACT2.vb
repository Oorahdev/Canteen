Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class ChooseACT2
    Dim promptNoPicture As Boolean = True
    Friend Shared actId As Integer

    Dim current As TextBox = Me.txbActID
    'Public Shared actId As Integer = 0

    Public Function SelectAct() As Integer
        If Me.DialogResult = Windows.Forms.DialogResult.OK Then
            If lsbActID.SelectedItems.Count() > 0 Then
                EnlargePhoto()
                Return Me.lsbActID.SelectedValue
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    Private Sub ChooseACT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Width = My.Computer.Screen.WorkingArea.Width
        'Me.Height = Me.Width * 0.6
        'Me.Top = (My.Computer.Screen.WorkingArea.Height - Me.Height) / 2 + My.Computer.Screen.WorkingArea.Top
        'Me.ResumeLayout(True)
        txbActID.Select()
        txbActID.Focus()
        FilterAccounts()
        promptNoPicture = True
        'LoadPhoto()
        'Private Sub btnDownload_Click(ByVal sender As System.Object, 
        '   ByVal e As System.EventArgs)  Handles btnDownload.Click
    End Sub
    Dim actPhoto As Byte
    Private Sub LoadPhoto()
        'If actPhoto > 0 Then
        Try
            Dim con As New SqlConnection(My.Settings.CanteenConnectionString)
            con.Open()
            'Dim cmd As New SqlCommand("select ACT_Picture from ACT where ACT_ID =" & actId, con)
            Dim cmd As New SqlCommand("select ACT_Picture from ACT where ACT_ID =" & actId, con)
            'cmd.Connection = con
            cmd.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)
            If Not IsDBNull(ds.Tables(0).Rows(0).Item(0)) Then
                Dim bits As Byte() = CType(ds.Tables(0).Rows(0).Item(0), Byte())
                Dim memorybits As New MemoryStream(bits)
                Dim bitmap As New Bitmap(memorybits)
                'Dim strHeight As Integer
                'Dim strWidth As Integer
                'strHeight = 100 'Trim(InputBox("Specify the new height of the image (in pixels):", "  Specify Height", PictureBox1.Image.Height.ToString))
                'If strHeight < 0 Then Exit Sub
                'strWidth = 100 'Trim(InputBox("Specify the new width of the image (in pixels):", "  Specify Width", PictureBox1.Image.Width.ToString))
                'If strWidth < 0 Then Exit Sub
                'Dim bitmapThumb As New Bitmap(bitmap, CInt(strHeight), CStr(strWidth)) ', PixelFormat.Format24bppRgb)
                PictureBox1.Image = bitmap
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                'Dim objGraphics As Graphics = Graphics.FromImage(bitmapThumb)
                'objGraphics.DrawImage(PictureBox1.Image, 188, 12, CInt(strHeight), CInt(strWidth))
                'PictureBox1.Image = bitmapThumb
                'PictureBox1.Refresh()
                'PictureBox1.Size = PictureBox1.Image.Size
                'objGraphics.Dispose()
                'objGraphics = Nothing
                'bitmap.sGetThumbnailImage(100, 100, AddressOf System.Drawing.Image.GetThumbnailImageAbort, 0)
            Else : PictureBox1.Image = Nothing
            End If
        Catch

        End Try
        'End If
    End Sub

    'Private Function ImageAbort()
    '    If PictureBox1.Image.PropertyItems > 0 Then
    '        Return True
    '    End If
    '    Return True
    'End Function
    'End Sub

    Private Sub txbActID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txbActID.GotFocus
        current = Me.txbActID
    End Sub

    Private Sub AdmKeypad1_OnKeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AdmKeyboard1.OnKeyPress
        Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyPress(adm.admUtilities.TextWithSelection.FromTextBox(current), e)
        current.Text = ret.Text
        current.SelectionStart = ret.SelectionStart
        current.SelectionLength = ret.SelectionLength
    End Sub
    Public Sub AdmKeypad1_OnKeyPressSpecial_1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AdmKeyboard1.OnKeyPressSpecial

        Select Case e.KeyCode
            Case Is = Keys.Enter
                EnlargePhoto()
                If preOrderMode() = True And CheckTimeRange() = False Then
                    Exit Sub
                End If

                'If lsbActID.SelectedItems.Count() > 0 Then
                '    actId = lsbActID.SelectedValue
                'End If
                If lsbActID.SelectedItems.Count > 0 Then
                    If boolPhotoWarning = True Then
                        If promptNoPicture = True Then
                            If PictureBox1.Image Is Nothing And preOrderMode() = False Then
                                If MsgBox("This account does not have a photo. Would you like to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                                    Exit Sub
                                End If
                                'Me.Close()
                            End If
                        End If
                    End If
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Case Else
                Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyEvent(adm.admUtilities.TextWithSelection.FromTextBox(current), e)
                current.Text = ret.Text
                current.SelectionStart = ret.SelectionStart
                current.SelectionLength = ret.SelectionLength
        End Select
    End Sub
    'Private Sub AdmKeyBack1_OnKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AdmKeyBack1.OnKeyPress
    '    Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyPress(adm.admUtilities.TextWithSelection.FromTextBox(current), e)
    '    current.Text = ret.Text
    '    current.SelectionStart = ret.SelectionStart
    '    current.SelectionLength = ret.SelectionLength
    'End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        'Me.Close()
    End Sub

    Private Sub txbActID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbActID.TextChanged
        'FilterAccounts("LEFT(ACT_Number, " & Len(txbActID.Text) & ") = '" & txbActID.Text & "'")
        FilterAccounts("LEFT(ACT_LastName + ',' + ACT_FirstName, " & Len(txbActID.Text) & ") = '" & txbActID.Text & "'")
        ' ActDisplayTableAdapter.FillACT(Me.DsCanteen.ActDisplay, txbActID.Text)
    End Sub

    Public Sub FilterAccounts(Optional ByVal _WHERE As String = "")
        Dim con As New SqlConnection(My.Settings.CanteenConnectionString)
        'Dim strCom As String = "Select ACT_ID, convert(nvarchar,ACT_Number) + '-' + ACT_FirstName + ' ' + ACT_LastName AS ACT_FullName, ACT_Picture FROM ACT"
        Dim strCom As String = "Select ACT_ID, convert(nvarchar,ACT_Number) + '-' + ACT_LastName + ',' + ACT_FirstName AS ACT_FullName FROM ACT WHERE isnull(act_status,'') <> 'Inactive'"
        If _WHERE <> "" Then
            strCom &= " AND " & _WHERE
        End If
        'strCom &= " ORDER BY ACT_FullName"
        strCom &= " ORDER BY ACT_LastName, ACT_FirstName"
        Dim cmd As New SqlCommand(strCom, con)
        Dim dt As New DataTable
        Try
            con.Open()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
        Finally
            con.Close()
        End Try

        If dt Is Nothing Then MsgBox("Error loading accounts.") : Exit Sub

        Dim dv1 As New DataView(dt)

        lsbActID.ValueMember = "ACT_ID"
        lsbActID.DisplayMember = "ACT_FullName"
        'actPhoto = "ACT_Picture"
        lsbActID.DataSource = dv1
        'cboActId.ValueMember = "ACT_ID"
        'cboActId.DisplayMember = "ACT_FullName"
        'cboActId.DataSource = dv1
        'actId = lsbActID.ValueMember

    End Sub

    'Private Sub AdmKeyBack1_OnKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AdmKeyBack1.OnKeyPress
    '    Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyPress(adm.admUtilities.TextWithSelection.FromTextBox(current), e)
    '    current.Text = ret.Text
    '    current.SelectionStart = ret.SelectionStart
    '    current.SelectionLength = ret.SelectionLength
    'End Sub

    'Public Sub LoadAccounts()
    'FilterAccounts()

    ''ActDisplayTableAdapter.FillACT(Me.DsCanteen.ActDisplay, txbActID.Text)
    ''lsbActID.DisplayMember = (DsCanteen.ActDisplay.ACT_FullNameColumn).ToString()
    'Dim strCon As String = ("Data Source=VMSER2\ADMIREDEV;Initial Catalog=Canteen;User ID=CanteenUser; Password=1234")
    'Dim con As New SqlConnection(strCon)
    'Dim rdrAccounts As SqlDataReader
    'Dim strCom As String = ("Select ACT_ID, ACT_Number + '-' + ACT_FirstName + ' ' + ACT_LastName AS 'ACT_FullName' FROM ACT")
    'Dim com As New SqlCommand(strCom, con)
    'Try
    '    con.Open()
    '    rdrAccounts = com.ExecuteReader()
    '    lsbActID.Items.Clear()
    '    Do While rdrAccounts.Read()
    '        lsbActID.Items.Add(rdrAccounts.Item("ACT_FullName"))
    '    Loop


    '    rdrAccounts.Close()
    'Finally
    '    con.Close()
    'End Try


    'lsbactid.displaymember = tacttableadapter1.getdatabyfullname().tostring()
    'lsbactid.displaymember = string.format("{0}-{1}{2}", .item("act_number"), draccount.item("act_firstname"), draccount.item("act_lastname")
    'lsbActID.Items.Add(String.Format("{0}-{1}{2}", draccount.item("act_number"), draccount.item("act_firstname"), draccount.item("act_lastname")))

    ' Next
    'End Sub


    Private Sub txbActID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txbActID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If preOrderMode() = True And CheckTimeRange() = False Then
                Exit Sub
            End If
            If boolPhotoWarning = True Then
                If promptNoPicture = True Then
                    If PictureBox1.Image Is Nothing Then
                        If promptNoPicture = True And preOrderMode() = False Then
                            If MsgBox("This account does not have a photo. Would you like to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub lsbActID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsbActID.SelectedValueChanged
        If actId <> lsbActID.SelectedValue Then
            promptNoPicture = True
        End If
        actId = lsbActID.SelectedValue
        If actId > 0 Then
            LoadPhoto()
        End If
    End Sub

    Private Sub btnByName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnByName.Click
        Dim frmChooseActByName As New ChooseACTbyName
        If frmChooseActByName.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.promptNoPicture = False
        End If
        Dim intActNameId As Integer = frmChooseActByName.SelectActName
        If intActNameId > 0 Then
            lsbActID.Text = ""
            FilterAccounts("")
            lsbActID.SelectedValue = intActNameId
            promptNoPicture = False
            LoadPhoto()
        End If
    End Sub

    Private Sub btnClearAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAct.Click
        Me.lsbActID.SelectedIndex = -1
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub EnlargePhoto() Handles PictureBox1.Click
        If Not PictureBox1.Image Is Nothing Then
            actId = lsbActID.SelectedValue
            Dim frmEnlargePhoto As New EnlargePhoto
            frmEnlargePhoto.LoadPhoto(PictureBox1.Image)
            frmEnlargePhoto.ShowDialog()
        End If
    End Sub

    Private Sub AdmKeyboard1_Layout(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles AdmKeyboard1.Layout
        If Not IsNothing(Me.AdmKeyboard1.Parent) Then
            Me.AdmKeyboard1.Height = Me.AdmKeyboard1.Width * 0.35
            Me.AdmKeyboard1.Parent.ResumeLayout(False)
        End If
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        'Me.ResumeLayout(True)
        InitializeComponent()
        Dim sz As New Size
        sz.Width = My.Computer.Screen.WorkingArea.Width
        sz.Height = sz.Width * 0.44
        Me.Top = (My.Computer.Screen.WorkingArea.Height - sz.Height) / 2 + My.Computer.Screen.WorkingArea.Top
        Me.Size = sz
        'Me.PerformLayout()
        'Me.Panel2.ResumeLayout(False)
        'Me.Panel2.PerformLayout()
        'Me.Panel3.ResumeLayout(False)
        'Me.TableLayoutPanel1.ResumeLayout(False)
        'Me.ResumeLayout(False)

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Function CheckTimeRange() As Boolean
        Dim adapter As New dsCanteenTableAdapters.TFRTableAdapter
        adapter.Fill(Me.DsCanteen1.TFR)
        Dim drTfr As DataRow = Me.DsCanteen1.TFR.Rows.Item(0)
        Dim tsStart As DateTime = drTfr(0)
        Dim tsEnd As DateTime = drTfr(1)
        Dim dtStart As DateTime = New DateTime(Now.Year, Now.Month, Now.Day, tsStart.Hour, tsStart.Minute, tsStart.Second)
        Dim dtEnd As DateTime = New DateTime(Now.Year, Now.Month, Now.Day, tsEnd.Hour, tsEnd.Minute, tsEnd.Second)
        If DateTime.Now >= dtStart And DateTime.Now <= dtEnd Then
            Return True
        Else
            MsgBox("Canteen preordering is currently closed." & Environment.NewLine & "Preordering is open from " & dtStart.ToString("hh:mm tt") & " to " & dtEnd.ToString("hh:mm tt"))
        End If
    End Function

End Class