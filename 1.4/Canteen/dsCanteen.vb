Partial Class dsCanteen
    Partial Class TFRDataTable

        Private Sub TFRDataTable_TFRRowChanging(ByVal sender As System.Object, ByVal e As TFRRowChangeEvent) Handles Me.TFRRowChanging

        End Sub

    End Class

    Partial Class tPORDataTable

        Private Sub tPORDataTable_tPORRowChanging(ByVal sender As System.Object, ByVal e As tPORRowChangeEvent) Handles Me.tPORRowChanging

        End Sub

    End Class

    Partial Class ActDisplayDataTable

    End Class

    Partial Class tORDDataTable

    End Class

    Partial Class AccountHistoryDataTable

        Private Sub AccountHistoryDataTable_AccountHistoryRowChanging(ByVal sender As System.Object, ByVal e As AccountHistoryRowChangeEvent) Handles Me.AccountHistoryRowChanging

        End Sub

    End Class

    Partial Class tACTDataTable

    End Class

    Partial Class tITMDataTable

    End Class

End Class

Namespace dsCanteenTableAdapters
    
    Partial Public Class tCTGTableAdapter
    End Class
End Namespace

Namespace dsCanteenTableAdapters
    
    Partial Public Class AccountHistorySubTableAdapter
    End Class
End Namespace

Namespace dsCanteenTableAdapters
    
    Partial Public Class tACTTableAdapter
    End Class
End Namespace

Namespace dsCanteenTableAdapters
    
    Partial Public Class GetPreOrderItmsTableAdapter
    End Class
End Namespace

Namespace dsCanteenTableAdapters
    
    Partial Public Class ActDisplayTableAdapter
    End Class
End Namespace
