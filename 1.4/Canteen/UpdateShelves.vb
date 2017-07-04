Public Class UpdateShelves
    Dim editor As New TextBox
    Private Sub UpdateShelves_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsCanteen.CheckShelfInv' table. You can move, or remove it, as needed.
      
        LoadGrid()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        CheckShelfInv.DataSource.ConnectionString = GetOledbConnectionString()
        CheckShelfInv.Document.PrinterSettings.PrinterName = DsCanteen.tPRF.Item(0).PRF_Value
        CheckShelfInv.Document.DocumentName = "RestockShelves" & Now
        Try
            CheckShelfInv.Document.Print()
        Catch
        End Try
    End Sub

    Private Sub LoadGrid()
        gridCheckShelfInv.DataSource = Me.CheckShelfInvTableAdapter.GetData()
        Dim items As C1.Win.C1TrueDBGrid.ValueItems = Me.gridCheckShelfInv.Columns("updateShelf").ValueItems
        ' We're going to translate values - the DataSource needs to hold at least 3 states.              
        items.Translate = True
        ' Each click will cycle thru the various checkbox states.               
        items.CycleOnClick = True
        ' Display the cell as a checkbox.               
        items.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
        ' Now associate the underlying db values with the checked state.               
        items.Values.Clear()
        ' Unchecked.               
        items.Values.Add(New C1.Win.C1TrueDBGrid.ValueItem("0", False))
        ' Checked.               
        items.Values.Add(New C1.Win.C1TrueDBGrid.ValueItem("1", True))
        gridCheckShelfInv.Splits(0).DisplayColumns.Item("updateshelf").Width = 70
        gridCheckShelfInv.Splits(0).DisplayColumns.Item("updateshelf").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
        gridCheckShelfInv.Splits(0).DisplayColumns.Item("item").Width = 100
        gridCheckShelfInv.Splits(0).DisplayColumns.Item("ctg_name").Width = 80
        gridCheckShelfInv.Splits(0).DisplayColumns.Item("ctg_name").Locked = True
        gridCheckShelfInv.Splits(0).DisplayColumns.Item("shelfrestockamount").Width = 115
        gridCheckShelfInv.Splits(0).DisplayColumns.Item("inv_id").Visible = False
        gridCheckShelfInv.Splits(0).DisplayColumns.Item("inv_itm_id").Visible = False
        gridCheckShelfInv.Splits(0).DisplayColumns.Item("itm_qtypershelf").Visible = False
        gridCheckShelfInv.Splits(0).DisplayColumns.Item("inv_qtyshelf").Visible = False
        gridCheckShelfInv.Splits(0).DisplayColumns.Item("inv_qtystockroom").Visible = False
        Me.gridCheckShelfInv.ExtendRightColumn = True
        Me.TPRFTableAdapter1.FillByPrfName(Me.DsCanteen.tPRF, "Regular Printer")
    End Sub

    Public Shared Function GetOledbConnectionString() As String
        Dim oleconn As New OleDb.OleDbConnectionStringBuilder
        Dim sqlconn As New SqlClient.SqlConnectionStringBuilder(My.Settings.CanteenConnectionString)
        oleconn.DataSource = sqlconn.DataSource
        oleconn.Provider = "SQLOLEDB.1"
        oleconn.Add("Initial Catalog", sqlconn.InitialCatalog)
        If sqlconn.IntegratedSecurity = True Then
            oleconn.Add("Integrated Security", "SSPI")
        Else
            oleconn.Add("User ID", sqlconn.UserID)
            oleconn.Add("Password", sqlconn.Password)
        End If
        Return oleconn.ConnectionString
    End Function


    Private Sub btnUpdateShelves_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateShelves.Click
        For x As Integer = 0 To gridCheckShelfInv.RowCount - 1
            If gridCheckShelfInv.Item(x, "updateShelf") = 1 Then
                QueriesTableAdapter1.UpdateStockShelf(gridCheckShelfInv.Item(x, "inv_itm_id"), gridCheckShelfInv.Item(x, "shelfrestockamount"), 0, "Shelf", "Reshelf", usrid)
                QueriesTableAdapter1.UpdateStockShelf(gridCheckShelfInv.Item(x, "inv_itm_id"), 0, -gridCheckShelfInv.Item(x, "shelfrestockamount"), "Stock", "Reshelf", usrid)
            End If
        Next
        gridCheckShelfInv.DataSource = Me.CheckShelfInvTableAdapter.GetData()
        LoadGrid()
    End Sub

    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinish.Click
        Me.Close()
    End Sub

    Dim ctlCurrent As Object
    Private Sub txbName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridCheckShelfInv.GotFocus
        ctlCurrent = sender
    End Sub

    Private Sub AdmKeypad1_OnKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AdmKeypad1.OnKeyPress
        'Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyPress(adm.admUtilities.TextWi(ctlCurrent), e)
        'Dim txt As New adm.admUtilities.TextWithSelection
        'txt.Text = ""
        'txt.SelectionStart = 0
        'txt.SelectionLength = 3
        'Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyPress(txt, e)
        If gridCheckShelfInv.Col = 6 Then
            Dim txt As New adm.admUtilities.TextWithSelection
            txt.Text = gridCheckShelfInv.Item(gridCheckShelfInv.Row, gridCheckShelfInv.Col) 'gridCheckShelfInv.SelectedText
            Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyPress(txt, e)
            gridCheckShelfInv.Item(gridCheckShelfInv.Row, gridCheckShelfInv.Col) = ret.Text
        End If
        ' gridCheckShelfInv.Item(gridCheckShelfInv.Row, gridCheckShelfInv.Col) = e.KeyChar
        'e.KeyChar 
        'ctlCurrent.Text = ret.Text
        'ctlCurrent.SelectionStart = ret.SelectionStart
        'ctlCurrent.SelectionLength = ret.SelectionLength
    End Sub

    Private Sub AdmKeypad1_OnKeyPressSpecial(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AdmKeypad1.OnKeyPressSpecial
        If gridCheckShelfInv.Col = 6 Then
            Select Case e.KeyCode
                Case Is = Keys.Back
                    Dim txt As New adm.admUtilities.TextWithSelection
                    txt.Text = gridCheckShelfInv.Item(gridCheckShelfInv.Row, gridCheckShelfInv.Col)
                    Dim ret As adm.admUtilities.TextWithSelection = adm.admUtilities.ProcessKeyEvent(txt, e)
                    If ret.Text.Length > 0 Then
                        gridCheckShelfInv.Item(gridCheckShelfInv.Row, gridCheckShelfInv.Col) = ret.Text
                    Else
                        gridCheckShelfInv.Item(gridCheckShelfInv.Row, gridCheckShelfInv.Col) = 0
                    End If
                Case Else
            End Select
        End If
    End Sub
End Class