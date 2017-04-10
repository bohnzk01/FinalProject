Public Class frmTask
    Private Sub frmTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MaintenanceDataSet.TaskTypes' table. You can move, or remove it, as needed.
        Me.TaskTypesTableAdapter.Fill(Me.MaintenanceDataSet.TaskTypes)
        'TODO: This line of code loads data into the 'MaintenanceDataSet.Tasks' table. You can move, or remove it, as needed.
        Me.TasksTableAdapter.Fill(Me.MaintenanceDataSet.Tasks)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (Not String.IsNullOrEmpty(txtName.Text)) Then
            If nudOccurance.Value = 0 Then
                TasksTableAdapter.Insert(txtName.Text, CInt(cbType.SelectedValue), Nothing, Nothing)
            Else
                TasksTableAdapter.Insert(txtName.Text, CInt(cbType.SelectedValue), CInt(nudOccurance.Value), cbUnit.SelectedItem.ToString())
            End If
            ToolStripStatusLabel1.Text = String.Format("{0} successfully added as a task", txtName.Text)
            txtName.Text = Nothing
            nudOccurance.Value = 0
            Me.TasksTableAdapter.Fill(Me.MaintenanceDataSet.Tasks)
        Else
            ToolStripStatusLabel1.Text = "Name is required"
        End If
    End Sub
End Class