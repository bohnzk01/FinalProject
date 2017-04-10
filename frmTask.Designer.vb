<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTask
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
        Me.gvTasks = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudOccurance = New System.Windows.Forms.NumericUpDown()
        Me.cbUnit = New System.Windows.Forms.ComboBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaintenanceDataSet = New FinalProject.MaintenanceDataSet()
        Me.TasksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TasksTableAdapter = New FinalProject.MaintenanceDataSetTableAdapters.TasksTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecurrenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecurrenceUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TaskTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaskTypesTableAdapter = New FinalProject.MaintenanceDataSetTableAdapters.TaskTypesTableAdapter()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.gvTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudOccurance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaintenanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.TaskTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvTasks
        '
        Me.gvTasks.AutoGenerateColumns = False
        Me.gvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvTasks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.TypeIDDataGridViewTextBoxColumn, Me.RecurrenceDataGridViewTextBoxColumn, Me.RecurrenceUnitDataGridViewTextBoxColumn})
        Me.gvTasks.DataSource = Me.TasksBindingSource
        Me.gvTasks.Location = New System.Drawing.Point(14, 188)
        Me.gvTasks.Name = "gvTasks"
        Me.gvTasks.Size = New System.Drawing.Size(240, 150)
        Me.gvTasks.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(154, 14)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(84, 147)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Occurs Every"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Time Unit"
        '
        'nudOccurance
        '
        Me.nudOccurance.Location = New System.Drawing.Point(151, 79)
        Me.nudOccurance.Name = "nudOccurance"
        Me.nudOccurance.Size = New System.Drawing.Size(120, 20)
        Me.nudOccurance.TabIndex = 6
        '
        'cbUnit
        '
        Me.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnit.FormattingEnabled = True
        Me.cbUnit.Items.AddRange(New Object() {"Days", "Weeks", "Months", "Years"})
        Me.cbUnit.Location = New System.Drawing.Point(151, 107)
        Me.cbUnit.Name = "cbUnit"
        Me.cbUnit.Size = New System.Drawing.Size(121, 21)
        Me.cbUnit.TabIndex = 7
        '
        'cbType
        '
        Me.cbType.DataSource = Me.TaskTypesBindingSource
        Me.cbType.DisplayMember = "Name"
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.FormattingEnabled = True
        Me.cbType.Location = New System.Drawing.Point(151, 47)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(121, 21)
        Me.cbType.TabIndex = 9
        Me.cbType.ValueMember = "Id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Task Type"
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
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'TypeIDDataGridViewTextBoxColumn
        '
        Me.TypeIDDataGridViewTextBoxColumn.DataPropertyName = "TypeID"
        Me.TypeIDDataGridViewTextBoxColumn.HeaderText = "TypeID"
        Me.TypeIDDataGridViewTextBoxColumn.Name = "TypeIDDataGridViewTextBoxColumn"
        '
        'RecurrenceDataGridViewTextBoxColumn
        '
        Me.RecurrenceDataGridViewTextBoxColumn.DataPropertyName = "Recurrence"
        Me.RecurrenceDataGridViewTextBoxColumn.HeaderText = "Recurrence"
        Me.RecurrenceDataGridViewTextBoxColumn.Name = "RecurrenceDataGridViewTextBoxColumn"
        '
        'RecurrenceUnitDataGridViewTextBoxColumn
        '
        Me.RecurrenceUnitDataGridViewTextBoxColumn.DataPropertyName = "RecurrenceUnit"
        Me.RecurrenceUnitDataGridViewTextBoxColumn.HeaderText = "RecurrenceUnit"
        Me.RecurrenceUnitDataGridViewTextBoxColumn.Name = "RecurrenceUnitDataGridViewTextBoxColumn"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 359)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(284, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TaskTypesBindingSource
        '
        Me.TaskTypesBindingSource.DataMember = "TaskTypes"
        Me.TaskTypesBindingSource.DataSource = Me.MaintenanceDataSet
        '
        'TaskTypesTableAdapter
        '
        Me.TaskTypesTableAdapter.ClearBeforeFill = True
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'frmTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 381)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbUnit)
        Me.Controls.Add(Me.nudOccurance)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gvTasks)
        Me.Name = "frmTask"
        Me.Text = "Tasks"
        CType(Me.gvTasks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudOccurance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaintenanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.TaskTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gvTasks As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nudOccurance As NumericUpDown
    Friend WithEvents cbUnit As ComboBox
    Friend WithEvents cbType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MaintenanceDataSet As MaintenanceDataSet
    Friend WithEvents TasksBindingSource As BindingSource
    Friend WithEvents TasksTableAdapter As MaintenanceDataSetTableAdapters.TasksTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecurrenceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecurrenceUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TaskTypesBindingSource As BindingSource
    Friend WithEvents TaskTypesTableAdapter As MaintenanceDataSetTableAdapters.TaskTypesTableAdapter
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
