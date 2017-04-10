Public Class frmTaskScheule
    Private Sub frmTaskScheule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MaintenanceDataSet.Tasks' table. You can move, or remove it, as needed.
        Me.TasksTableAdapter.Fill(Me.MaintenanceDataSet.Tasks)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.TaskScheduleTableAdapter1.Insert(CInt(cbTasks.SelectedValue), dtpDueDate.Value, Nothing)
    End Sub
End Class