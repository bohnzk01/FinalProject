Public Class frmDashboard
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
End Class