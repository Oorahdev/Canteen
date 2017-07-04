Imports System.Data.SqlClient
Imports System.IO

Public Class EnlargePhoto

    Dim intActID As Integer

    Private Sub EnlargePhoto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'intActID = ChooseACT2.actId
        'LoadPhoto(intActID)
    End Sub

    Friend Sub LoadPhoto(ByVal img As Image)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.Image = img
    End Sub

    Friend Sub LoadPhoto(ByVal intAct As Integer)
        'If actPhoto > 0 Then
        Try
            Dim con As New SqlConnection(My.Settings.CanteenConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("select ACT_Picture from ACT where ACT_ID =" & intAct, con)
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
                'strHeight = 400 'Trim(InputBox("Specify the new height of the image (in pixels):", "  Specify Height", PictureBox1.Image.Height.ToString))
                'If strHeight < 0 Then Exit Sub
                'strWidth = 400 'Trim(InputBox("Specify the new width of the image (in pixels):", "  Specify Width", PictureBox1.Image.Width.ToString))
                'If strWidth < 0 Then Exit Sub
                'Dim bitmapThumb As New Bitmap(bitmap, CInt(strHeight), CStr(strWidth)) ', PixelFormat.Format24bppRgb)
                PictureBox1.Image = bitmap
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                'Dim objGraphics As Graphics = Graphics.FromImage(bitmapThumb)
                'objGraphics.DrawImage(PictureBox1.Image, 0, 0, CInt(strHeight), CInt(strWidth))
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

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class