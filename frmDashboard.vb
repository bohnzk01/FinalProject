Public Class frmDashboard
    'Instructor Requirements
    'x The application will include multiple forms.
    'x Forms will incorporate as many controls as possible: xbuttons, xtext boxes, check boxes, xlabels, xradio buttons, xdrop-down list, etc.
    'x Input validation to ensure that users have entered/selected required information. No processing occurs for invalid input.
    'x Persistent data (SQL Server Or SQLite Or text file)
    'x CRUD operations with data
    'x Object-oriented approach 
    'Student Requirements
    'x Display dashboard of incomplete tasks
    'x Indicate pastdue tasks
    'x Auto schedule reoccuring tasks
    Private mTasks As New objTaskSchedule

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
        'Me.TaskScheduleTableAdapter.FillByIncomplete(Me.MaintenanceDataSet.TaskSchedule)
        DataGridView1.DataSource = mTasks.GetByDate("PastDue")
        SetGridColor()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.TaskScheduleTableAdapter.FillByIncomplete(Me.MaintenanceDataSet.TaskSchedule)
    End Sub

    Private Sub rbPastDue_CheckedChanged(sender As Object, e As EventArgs) Handles rbPastDue.CheckedChanged
        DataGridView1.DataSource = mTasks.GetByDate("PastDue")
        SetGridColor()
    End Sub

    Private Sub rbUpcoming_CheckedChanged(sender As Object, e As EventArgs) Handles rbUpcoming.CheckedChanged
        DataGridView1.DataSource = mTasks.GetByDate("Upcoming")
        SetGridColor()
    End Sub

    Private Sub rbAll_CheckedChanged(sender As Object, e As EventArgs) Handles rbAll.CheckedChanged
        DataGridView1.DataSource = mTasks.GetByDate("All")
        SetGridColor()
    End Sub

    Private Sub SetGridColor()
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim DueDate As DateTime = Convert.ToDateTime(row.Cells(2).Value)
            If DueDate < DateTime.Now() And row.Cells(2).Value IsNot Nothing Then
                row.Cells(2).Style.BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        If IsNothing(DataGridView1.CurrentRow) Then
            MessageBox.Show("no task selected")
        Else
            Dim completedtask As objTaskSchedule = New objTaskSchedule()
            completedtask.Update(CInt(DataGridView1.CurrentRow.Cells("ID").Value), CInt(DataGridView1.CurrentRow.Cells("TaskID").Value), CDate(DataGridView1.CurrentRow.Cells("DueDate").Value), DateTime.Now)

            Dim Task As DataTable = Me.TasksTableAdapter1.GetDataByID(CInt(DataGridView1.CurrentRow.Cells("TaskID").Value))
            Dim ID As Integer = CInt(Task.Rows(0)("ID"))
            Dim Name As String = CStr(Task.Rows(0)("Name"))
            Dim TypeID As Integer = CInt(Task.Rows(0)("TypeID"))
            Dim Recurrance As Integer = CInt(Task.Rows(0)("Recurrence"))
            Dim RecurranceUnit As String = CStr(Task.Rows(0)("RecurrenceUnit"))

            If Not String.IsNullOrEmpty(Recurrance.ToString()) Then
                Dim newTaskSchedule As objTaskSchedule = New objTaskSchedule()

                If RecurranceUnit.Trim = "Day" Then
                    newTaskSchedule.Insert(ID, DateTime.Now.AddDays(Recurrance))
                ElseIf RecurranceUnit.Trim = "Week" Then
                    newTaskSchedule.Insert(ID, DateTime.Now.AddDays(Recurrance * 7))
                ElseIf RecurranceUnit.Trim = "Month" Then
                    newTaskSchedule.Insert(ID, DateTime.Now.AddMonths(Recurrance))
                ElseIf RecurranceUnit.Trim = "Year" Then
                    newTaskSchedule.Insert(ID, DateTime.Now.AddYears(Recurrance))
                End If

            End If
            DataGridView1.DataSource = mTasks.GetByDate("All")
            SetGridColor()
        End If
    End Sub
End Class