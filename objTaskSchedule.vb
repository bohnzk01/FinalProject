Option Strict On
Option Explicit On

Public Class objTaskSchedule
    Private adapter As New MaintenanceDataSetTableAdapters.TaskScheduleTableAdapter

    Public Shared Property LastError As String

    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property

    Public ReadOnly Property TaskScheduleList As DataTable
        Get
            Dim listAdapter As New MaintenanceDataSetTableAdapters.TaskScheduleTableAdapter
            Return listAdapter.GetData()
        End Get
    End Property

    Public Function GetByDate(ByVal Type As String) As DataTable
        Dim table As DataTable = adapter.GetData()
        If Type = "PastDue" Then
            table.DefaultView.RowFilter = "DueDate <= #" & DateTime.Now & "#" & " and CompleteDate is null"
        ElseIf Type = "Upcoming" Then
            table.DefaultView.RowFilter = "DueDate > #" & DateTime.Now & "#" & " and CompleteDate is null"
        End If
        Return table
    End Function

    Public Function Insert(ByVal TaskId As Int32, ByVal DueDate As DateTime, ByVal CompleteDate As DateTime) As Boolean
        ' Insert a new row into the Appointments table.  Return True if successful.  If an exception is thrown, LastError will hold an error message.
        Try
            LastError = String.Empty
            adapter.Insert(TaskId, DueDate, CompleteDate)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function

    Public Function Update(ByVal Id As Int32, ByVal TaskID As Int32, ByVal DueDate As DateTime, ByVal CompleteDate As DateTime) As Boolean
        'Update a row into the Appointments tabe.  Return True if successful.  If an exception is thrown, LastError will hold an error message
        LastError = String.Empty
        Try
            adapter.Update(TaskID, DueDate, CompleteDate, Id)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function

    Public Function Delete(ByVal id As Integer) As Boolean
        Dim rowsAffected As Integer = adapter.Delete(id)
        Return rowsAffected > 0
    End Function

End Class