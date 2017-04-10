<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaskScheule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cbTasks = New System.Windows.Forms.ComboBox()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaintenanceDataSet = New FinalProject.MaintenanceDataSet()
        Me.TasksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TasksTableAdapter = New FinalProject.MaintenanceDataSetTableAdapters.TasksTableAdapter()
        Me.TaskScheduleTableAdapter1 = New FinalProject.MaintenanceDataSetTableAdapters.TaskScheduleTableAdapter()
        CType(Me.MaintenanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbTasks
        '
        Me.cbTasks.DataSource = Me.TasksBindingSource
        Me.cbTasks.DisplayMember = "Name"
        Me.cbTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTasks.FormattingEnabled = True
        Me.cbTasks.Location = New System.Drawing.Point(135, 36)
        Me.cbTasks.Name = "cbTasks"
        Me.cbTasks.Size = New System.Drawing.Size(121, 21)
        Me.cbTasks.TabIndex = 0
        Me.cbTasks.ValueMember = "Id"
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Location = New System.Drawing.Point(72, 73)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDueDate.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(104, 196)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select Task"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Due Date"
        '
        'MaintenanceDataSet
        '
        Me.MaintenanceDataSet.DataSetName = "MaintenanceDataSet"
        Me.MaintenanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TasksBindingSource
        '
        Me.TasksBindingSource.DataMember = "Tasks"
        Me.TasksBindingSource.DataSource = Me.MaintenanceDataSet
        '
        'TasksTableAdapter
        '
        Me.TasksTableAdapter.ClearBeforeFill = True
        '
        'TaskScheduleTableAdapter1
        '
        Me.TaskScheduleTableAdapter1.ClearBeforeFill = True
        '
        'frmTaskScheule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpDueDate)
        Me.Controls.Add(Me.cbTasks)
        Me.Name = "frmTaskScheule"
        Me.Text = "Schedule Task"
        CType(Me.MaintenanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbTasks As ComboBox
    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MaintenanceDataSet As MaintenanceDataSet
    Friend WithEvents TasksBindingSource As BindingSource
    Friend WithEvents TasksTableAdapter As MaintenanceDataSetTableAdapters.TasksTableAdapter
    Friend WithEvents TaskScheduleTableAdapter1 As MaintenanceDataSetTableAdapters.TaskScheduleTableAdapter
End Class
