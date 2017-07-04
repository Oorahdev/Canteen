Public Class TestActHistory
    Private Class Order
        Public OrderId As Integer = 0
        Public OrderDate As Date = Now
        Public OrderTotal As Decimal = 0D
    End Class

    Private Class OrderHeader
        Public Order As New Order
        Public Overrides Function ToString() As String
            Return String.Format("Order:{0,-10}{1,10:M/d/yyyy}", Me.Order.OrderId, Me.Order.OrderDate)
        End Function
    End Class

    Private Class OrderFooter
        Public Order As New Order
        Public Overrides Function ToString() As String
            Return String.Format("Total:{0,20:c2}", Me.Order.OrderTotal)
        End Function
    End Class

    Private Class BlankLine
        Public Separator As Char = " "
        Public Overrides Function ToString() As String
            Dim ret As String = ""
            For x As Integer = 1 To 26
                ret &= Separator
            Next
            Return ret
        End Function
    End Class

    Private Class OrderItem
        Public Order As New Order
        Public ItemID As Integer = 0
        Public ItemName As String = ""
        Public ItemPrice As Decimal = 0D

        Public Overrides Function ToString() As String
            Return String.Format("{0,-16}{1,10:c2}", Me.ItemName, Me.ItemPrice)
        End Function
    End Class

    Private Class OrderTransaction
        Public Order As New Order
        Public TransactionID As Integer = 0
        Public TransactionType As TransactionType = TransactionType.OrderTotal
        Public TransactionAmount As Decimal = 0D

        Public Overrides Function ToString() As String
            Return String.Format("{0,-16}{1,10:c2}", [Enum].GetName(GetType(TransactionType), Me.TransactionType), Me.TransactionAmount)
        End Function
    End Class

    Private Enum TransactionType As Integer
        OrderTotal
        Payment
        CashBack
    End Enum

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim items() As String = {"Candy", "Soda", "Popcorn"}
        Dim line As New BlankLine
        line.Separator = "-"
        For x As Integer = 1 To 20
            Dim ord As New Order
            ord.OrderId = x
            ord.OrderTotal = Rnd() * 25
            Dim oheader As New OrderHeader
            oheader.Order = ord
            Me.ListBox1.Items.Add(oheader)
            Dim tot As New OrderTransaction
            For y As Integer = 1 To 10
                Dim itm As New OrderItem
                itm.Order = ord
                itm.ItemID = (x + y) Mod 3
                itm.ItemName = items((x + y) Mod 3)
                itm.ItemPrice = Rnd() * 2
                tot.TransactionAmount += itm.ItemPrice
                Me.ListBox1.Items.Add(itm)
            Next
            Me.ListBox1.Items.Add(line)
            tot.TransactionID = x * 3
            tot.TransactionType = TransactionType.OrderTotal
            Me.ListBox1.Items.Add(tot)
            If x Mod 3 = 0 Then
                Dim pmt As New OrderTransaction
                pmt.Order = ord
                pmt.TransactionAmount = Rnd() * 25
                pmt.TransactionID = x * 4
                pmt.TransactionType = TransactionType.Payment
                Me.ListBox1.Items.Add(pmt)
            End If
            If x Mod 2 = 0 Then
                Dim cash As New OrderTransaction
                cash.Order = ord
                cash.TransactionAmount = Rnd() * 10
                cash.TransactionID = x * 2
                cash.TransactionType = TransactionType.CashBack
                Me.ListBox1.Items.Add(cash)
            End If
            Dim ofooter As New OrderFooter
            ofooter.Order = ord
            Me.ListBox1.Items.Add(ofooter)
            Me.ListBox1.Items.Add(line)
            Me.ListBox1.Items.Add(line)
        Next

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case Me.ListBox1.SelectedItem.GetType.ToString
            Case Is = GetType(OrderHeader).ToString
            Case Is = GetType(OrderItem).ToString
                'CType(Me.ListBox1.SelectedItem, OrderItem).ItemID()
            Case Is = GetType(OrderHeader).ToString
            Case Is = GetType(OrderHeader).ToString

        End Select
    End Sub
End Class