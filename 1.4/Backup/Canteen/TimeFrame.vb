Public Class TimeFrame

    Private Sub TimeFrame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TimePicker1.Format = DateTimePickerFormat.Time
        TimePicker2.Format = DateTimePickerFormat.Time

        TimePicker1.ShowUpDown = True
        TimePicker2.ShowUpDown = True

        Dim adapter As New dsCanteenTableAdapters.TFRTableAdapter
        adapter.Fill(Me.DsCanteen1.TFR)
        Dim drTfr As DataRow = Me.DsCanteen1.TFR.Rows.Item(0)
        Dim tsStart As DateTime = drTfr(0)
        Dim tsEnd As DateTime = drTfr(1)

        TimePicker1.Value = New DateTime(Now.Year, Now.Month, Now.Day, tsStart.Hour, tsStart.Minute, tsStart.Second)
        TimePicker2.Value = New DateTime(Now.Year, Now.Month, Now.Day, tsEnd.Hour, tsEnd.Minute, tsEnd.Second)
    End Sub

    Private Sub btnSetTfr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetTfr.Click
        Dim adapter As New dsCanteenTableAdapters.TFRTableAdapter
        Dim dtStartTime As DateTime = TimePicker1.Value
        'Dim tsStartTime As TimeSpan = New TimeSpan(dtStartTime.Hour, dtStartTime.Minute, dtStartTime.Second)
        Dim dtEndTime As DateTime = TimePicker2.Value
        'Dim tsEndTime As TimeSpan = New TimeSpan(dtEndTime.Hour, dtEndTime.Minute, dtEndTime.Second)
        adapter.UpdateTfr(dtStartTime, dtEndTime)
        Me.Close()
    End Sub
End Class
