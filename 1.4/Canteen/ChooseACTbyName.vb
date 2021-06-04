Imports System.Data.SqlClient
Imports System.IO

Public Class ChooseACTbyName

    'Dim ctlCurrent As TextBox = Me.txbActID
    'Public Shared actId As Integer = 0

    Public Function SelectActName() As Integer
        If Me.DialogResult = Windows.Forms.DialogResult.OK Then
            If lsbActID.SelectedItems.Count() > 0 Then
                Return Me.lsbActID.SelectedValue
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function
    Dim actNameId As Integer
    Dim intActID As Integer

    Private Sub ChooseACTbyName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txbActID.Select()
        txbActID.Focus()
        FilterAccounts()
        LoadPhoto()
    End Sub

    Private Sub txbActID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbActID.TextChanged
        ' FilterAccounts("LEFT(ACT_LastName + ',' + ACT_FirstName, " & Len(txbActID.Text) & ") = '" & txbActID.Text & "'")
        FilterAccounts("LEFT(ACT_Number, " & Len(txbActID.Text) & ") = '" & txbActID.Text & "'")
        ' ActDisplayTableAdapter.FillACT(Me.DsCanteen.ActDisplay, txbActID.Text)
    End Sub

    Public Sub FilterAccounts(Optional ByVal _WHERE As String = "")
        Dim con As New SqlConnection(My.Settings.CanteenConnectionString)
        'Dim strCom As String = "Select ACT_ID, convert(nvarchar,ACT_Number) + '-' + ACT_LastName + ',' + ACT_FirstName AS ACT_FullName, ACT_Picture FROM ACT"
        Dim strCom As String = "Select ACT_ID, convert(nvarchar,ACT_Number) + '-' + ACT_FirstName + ' ' + ACT_LastName AS ACT_FullName, ACT_Picture FROM ACT WHERE isnull(ACT_Status,'') <> 'Inactive'"
        If _WHERE <> "" Then
            strCom &= " AND " & _WHERE
        End If
        'strCom &= " ORDER BY ACT_LastName, ACT_FirstName"
        strCom &= " ORDER BY ACT_FullName"
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

    Private Sub txbActID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txbActID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub lsbActID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsbActID.SelectedValueChanged
        actNameId = lsbActID.SelectedValue
        'actPhoto = "ACT_Picture"
        LoadPhoto()
    End Sub

    Private Sub LoadPhoto()

        Try
            Dim con As New SqlConnection(My.Settings.CanteenConnectionString)
            con.Open()
            'Dim cmd As New SqlCommand("select ACT_Picture from ACT where ACT_ID =" & actNameId, con)
            Dim cmd As New SqlCommand("select ACT_Picture from ACT where ACT_ID =" & actNameId, con)
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

    End Sub


    Private Sub AdmKeypad1_OnKeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AdmKeypad1.OnKeyPress
        Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyPress(adm.admUtilities.TextWithSelection.FromTextBox(txbActID), e)
        txbActID.Text = ret.Text
        txbActID.SelectionStart = ret.SelectionStart
        txbActID.SelectionLength = ret.SelectionLength
    End Sub
    Public Sub AdmKeypad1_OnKeyPressSpecial_1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AdmKeypad1.OnKeyPressSpecial
        Select Case e.KeyCode
            Case Is = Keys.Enter
                If lsbActID.SelectedItems.Count() > 0 Then
                    actNameId = lsbActID.SelectedValue

                    If boolPhotoWarning = True Then
                        If PictureBox1.Image Is Nothing Then
                            If MsgBox("This account does not have a photo. Would you like to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                                Exit Sub
                            End If
                        End If
                    End If
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
                'Me.Close()
            Case Else
                Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyEvent(adm.admUtilities.TextWithSelection.FromTextBox(txbActID), e)
                txbActID.Text = ret.Text
                txbActID.SelectionStart = ret.SelectionStart
                txbActID.SelectionLength = ret.SelectionLength
        End Select
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Dim actId As Integer
    Private Sub EnlargePhoto() Handles PictureBox1.Click
        If Not PictureBox1.Image Is Nothing Then
            actId = lsbActID.SelectedValue
            Dim frmEnlargePhoto As New EnlargePhoto
            frmEnlargePhoto.LoadPhoto(PictureBox1.Image)
            frmEnlargePhoto.ShowDialog()
        End If
    End Sub
End Class