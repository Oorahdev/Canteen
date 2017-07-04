Public Class Form2

    Private Sub TITMBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TITMBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TITMBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsCanteen)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsCanteen.tITM' table. You can move, or remove it, as needed.
        Me.TITMTableAdapter.Fill(Me.DsCanteen.tITM)

    End Sub
End Class