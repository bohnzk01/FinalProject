Public Class frmTaskTypes
    Private Sub frmTaskTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MaintenanceDataSet.TaskTypes' table. You can move, or remove it, as needed.
        Me.TaskTypesTableAdapter.Fill(Me.MaintenanceDataSet.TaskTypes)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (Not String.IsNullOrEmpty(txtName.Text)) Then
            TaskTypesTableAdapter.Insert(txtName.Text)
            ToolStripStatusLabel1.Text = String.Format("{0} successfully added as a task type", txtName.Text)
            txtName.Text = Nothing
            Me.TaskTypesTableAdapter.Fill(Me.MaintenanceDataSet.TaskTypes)
        Else
            ToolStripStatusLabel1.Text = "Name must be provided"
        End If

    End Sub
End Class