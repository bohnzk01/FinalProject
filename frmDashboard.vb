Public Class frmDashboard
    'Instructor Requirements
    'x The application will include multiple forms.
    '• Forms will incorporate as many controls as possible: buttons, text boxes, check boxes, labels, radio buttons, drop-down list, etc.
    'x Input validation to ensure that users have entered/selected required information. No processing occurs for invalid input.
    'x Persistent data (SQL Server Or SQLite Or text file)
    'x CRUD operations with data
    'x Object-oriented approach 
    'Student Requirements
    'x Display dashboard of incomplete tasks
    'x Indicate pastdue tasks
    '• Auto schedule reoccuring tasks


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub TaskTypesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskTypesToolStripMenuItem.Click
        frmTaskTypes.ShowDialog()
    End Sub

    Private Sub CreateTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateTaskToolStripMenuItem.Click
        frmTask.ShowDialog()
    End Sub

    Private Sub ScheduleTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScheduleTaskToolStripMenuItem.Click
        frmTaskScheule.ShowDialog()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        frmReports.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TaskScheduleTableAdapter.FillByIncomplete(Me.MaintenanceDataSet.TaskSchedule)
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim DueDate As DateTime = Convert.ToDateTime(row.Cells(2).Value)
            If DueDate < DateTime.Now() And row.Cells(2).Value IsNot Nothing Then
                row.Cells(2).Style.BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.TaskScheduleTableAdapter.FillByIncomplete(Me.MaintenanceDataSet.TaskSchedule)
    End Sub
End Class