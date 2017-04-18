<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TasksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScheduleTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbStatus = New System.Windows.Forms.GroupBox()
        Me.rbAll = New System.Windows.Forms.RadioButton()
        Me.rbUpcoming = New System.Windows.Forms.RadioButton()
        Me.rbPastDue = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TaskScheduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaintenanceDataSet = New FinalProject.MaintenanceDataSet()
        Me.TaskScheduleTableAdapter = New FinalProject.MaintenanceDataSetTableAdapters.TaskScheduleTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        Me.gbStatus.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskScheduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaintenanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(702, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TasksToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.EditToolStripMenuItem.Text = "View"
        '
        'TasksToolStripMenuItem
        '
        Me.TasksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TaskTypesToolStripMenuItem, Me.CreateTaskToolStripMenuItem, Me.ScheduleTaskToolStripMenuItem})
        Me.TasksToolStripMenuItem.Name = "TasksToolStripMenuItem"
        Me.TasksToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.TasksToolStripMenuItem.Text = "Tasks"
        '
        'TaskTypesToolStripMenuItem
        '
        Me.TaskTypesToolStripMenuItem.Name = "TaskTypesToolStripMenuItem"
        Me.TaskTypesToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.TaskTypesToolStripMenuItem.Text = "Task Types"
        '
        'CreateTaskToolStripMenuItem
        '
        Me.CreateTaskToolStripMenuItem.Name = "CreateTaskToolStripMenuItem"
        Me.CreateTaskToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.CreateTaskToolStripMenuItem.Text = "Create Task"
        '
        'ScheduleTaskToolStripMenuItem
        '
        Me.ScheduleTaskToolStripMenuItem.Name = "ScheduleTaskToolStripMenuItem"
        Me.ScheduleTaskToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ScheduleTaskToolStripMenuItem.Text = "Schedule Task"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'gbStatus
        '
        Me.gbStatus.Controls.Add(Me.rbAll)
        Me.gbStatus.Controls.Add(Me.rbUpcoming)
        Me.gbStatus.Controls.Add(Me.rbPastDue)
        Me.gbStatus.Location = New System.Drawing.Point(384, 79)
        Me.gbStatus.Name = "gbStatus"
        Me.gbStatus.Size = New System.Drawing.Size(233, 62)
        Me.gbStatus.TabIndex = 2
        Me.gbStatus.TabStop = False
        Me.gbStatus.Text = "Show"
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.Location = New System.Drawing.Point(173, 32)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(36, 17)
        Me.rbAll.TabIndex = 2
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "All"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'rbUpcoming
        '
        Me.rbUpcoming.AutoSize = True
        Me.rbUpcoming.Location = New System.Drawing.Point(94, 32)
        Me.rbUpcoming.Name = "rbUpcoming"
        Me.rbUpcoming.Size = New System.Drawing.Size(73, 17)
        Me.rbUpcoming.TabIndex = 1
        Me.rbUpcoming.TabStop = True
        Me.rbUpcoming.Text = "Upcoming"
        Me.rbUpcoming.UseVisualStyleBackColor = True
        '
        'rbPastDue
        '
        Me.rbPastDue.AutoSize = True
        Me.rbPastDue.Checked = True
        Me.rbPastDue.Location = New System.Drawing.Point(19, 32)
        Me.rbPastDue.Name = "rbPastDue"
        Me.rbPastDue.Size = New System.Drawing.Size(69, 17)
        Me.rbPastDue.TabIndex = 0
        Me.rbPastDue.TabStop = True
        Me.rbPastDue.Text = "Past Due"
        Me.rbPastDue.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 281)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(665, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'TaskScheduleBindingSource
        '
        Me.TaskScheduleBindingSource.DataMember = "TaskSchedule"
        Me.TaskScheduleBindingSource.DataSource = Me.MaintenanceDataSet
        '
        'MaintenanceDataSet
        '
        Me.MaintenanceDataSet.DataSetName = "MaintenanceDataSet"
        Me.MaintenanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TaskScheduleTableAdapter
        '
        Me.TaskScheduleTableAdapter.ClearBeforeFill = True
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 526)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.gbStatus)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDashboard"
        Me.Text = "Dashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbStatus.ResumeLayout(False)
        Me.gbStatus.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskScheduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaintenanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TasksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateTaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScheduleTaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaskTypesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbStatus As GroupBox
    Friend WithEvents rbAll As RadioButton
    Friend WithEvents rbUpcoming As RadioButton
    Friend WithEvents rbPastDue As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MaintenanceDataSet As MaintenanceDataSet
    Friend WithEvents TaskScheduleBindingSource As BindingSource
    Friend WithEvents TaskScheduleTableAdapter As MaintenanceDataSetTableAdapters.TaskScheduleTableAdapter
End Class
