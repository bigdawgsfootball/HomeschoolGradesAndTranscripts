<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.btnOpenGB = New System.Windows.Forms.Button()
        Me.btnViewGradebook = New System.Windows.Forms.Button()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SetFileLocationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreFromBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditSchoolInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAssignmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewGradebookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditJSONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCourseCategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditAssignmentTypesWeightsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcGradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenReportCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateTranscriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBackUp = New System.Windows.Forms.Button()
        Me.lblSchoolName = New System.Windows.Forms.Label()
        Me.lblAddr1 = New System.Windows.Forms.Label()
        Me.lblAddr2 = New System.Windows.Forms.Label()
        Me.GenerateAssignmentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOpenGB
        '
        Me.btnOpenGB.Location = New System.Drawing.Point(53, 126)
        Me.btnOpenGB.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpenGB.Name = "btnOpenGB"
        Me.btnOpenGB.Size = New System.Drawing.Size(159, 28)
        Me.btnOpenGB.TabIndex = 0
        Me.btnOpenGB.Text = "Open Gradebook"
        Me.btnOpenGB.UseVisualStyleBackColor = True
        '
        'btnViewGradebook
        '
        Me.btnViewGradebook.Enabled = False
        Me.btnViewGradebook.Location = New System.Drawing.Point(53, 161)
        Me.btnViewGradebook.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewGradebook.Name = "btnViewGradebook"
        Me.btnViewGradebook.Size = New System.Drawing.Size(159, 28)
        Me.btnViewGradebook.TabIndex = 6
        Me.btnViewGradebook.Text = "View Gradebook"
        Me.btnViewGradebook.UseVisualStyleBackColor = True
        '
        'mnuMain
        '
        Me.mnuMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.mnuMain.Size = New System.Drawing.Size(277, 28)
        Me.mnuMain.TabIndex = 13
        Me.mnuMain.Text = "t"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.toolStripSeparator, Me.SetFileLocationsToolStripMenuItem, Me.BackupToolStripMenuItem, Me.RestoreFromBackupToolStripMenuItem, Me.toolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.NewToolStripMenuItem.Text = "&New Gradebook"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(242, 6)
        '
        'SetFileLocationsToolStripMenuItem
        '
        Me.SetFileLocationsToolStripMenuItem.Name = "SetFileLocationsToolStripMenuItem"
        Me.SetFileLocationsToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.SetFileLocationsToolStripMenuItem.Text = "&Set File Locations"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Enabled = False
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.BackupToolStripMenuItem.Text = "&Backup"
        '
        'RestoreFromBackupToolStripMenuItem
        '
        Me.RestoreFromBackupToolStripMenuItem.Enabled = False
        Me.RestoreFromBackupToolStripMenuItem.Name = "RestoreFromBackupToolStripMenuItem"
        Me.RestoreFromBackupToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.RestoreFromBackupToolStripMenuItem.Text = "Restore from Backup"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(242, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(245, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditSchoolInfoToolStripMenuItem, Me.ToolStripSeparator3, Me.AddStudentToolStripMenuItem, Me.AddCourseToolStripMenuItem, Me.AddAssignmentToolStripMenuItem, Me.ViewGradebookToolStripMenuItem, Me.toolStripSeparator4, Me.EditJSONToolStripMenuItem, Me.EditCourseCategoriesToolStripMenuItem, Me.EditAssignmentTypesWeightsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'EditSchoolInfoToolStripMenuItem
        '
        Me.EditSchoolInfoToolStripMenuItem.Name = "EditSchoolInfoToolStripMenuItem"
        Me.EditSchoolInfoToolStripMenuItem.Size = New System.Drawing.Size(291, 26)
        Me.EditSchoolInfoToolStripMenuItem.Text = "Edit School Info"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(288, 6)
        '
        'AddStudentToolStripMenuItem
        '
        Me.AddStudentToolStripMenuItem.Enabled = False
        Me.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem"
        Me.AddStudentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.AddStudentToolStripMenuItem.Size = New System.Drawing.Size(291, 26)
        Me.AddStudentToolStripMenuItem.Text = "Add Student"
        '
        'AddCourseToolStripMenuItem
        '
        Me.AddCourseToolStripMenuItem.Enabled = False
        Me.AddCourseToolStripMenuItem.Name = "AddCourseToolStripMenuItem"
        Me.AddCourseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.AddCourseToolStripMenuItem.Size = New System.Drawing.Size(291, 26)
        Me.AddCourseToolStripMenuItem.Text = "Add Course"
        '
        'AddAssignmentToolStripMenuItem
        '
        Me.AddAssignmentToolStripMenuItem.Enabled = False
        Me.AddAssignmentToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddAssignmentToolStripMenuItem.Name = "AddAssignmentToolStripMenuItem"
        Me.AddAssignmentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.AddAssignmentToolStripMenuItem.Size = New System.Drawing.Size(291, 26)
        Me.AddAssignmentToolStripMenuItem.Text = "Add Assignment"
        '
        'ViewGradebookToolStripMenuItem
        '
        Me.ViewGradebookToolStripMenuItem.Enabled = False
        Me.ViewGradebookToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewGradebookToolStripMenuItem.Name = "ViewGradebookToolStripMenuItem"
        Me.ViewGradebookToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ViewGradebookToolStripMenuItem.Size = New System.Drawing.Size(291, 26)
        Me.ViewGradebookToolStripMenuItem.Text = "View Gradebook"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(288, 6)
        '
        'EditJSONToolStripMenuItem
        '
        Me.EditJSONToolStripMenuItem.Enabled = False
        Me.EditJSONToolStripMenuItem.Name = "EditJSONToolStripMenuItem"
        Me.EditJSONToolStripMenuItem.Size = New System.Drawing.Size(291, 26)
        Me.EditJSONToolStripMenuItem.Text = "Edit JSON"
        '
        'EditCourseCategoriesToolStripMenuItem
        '
        Me.EditCourseCategoriesToolStripMenuItem.Name = "EditCourseCategoriesToolStripMenuItem"
        Me.EditCourseCategoriesToolStripMenuItem.Size = New System.Drawing.Size(291, 26)
        Me.EditCourseCategoriesToolStripMenuItem.Text = "Edit Course Categories"
        '
        'EditAssignmentTypesWeightsToolStripMenuItem
        '
        Me.EditAssignmentTypesWeightsToolStripMenuItem.Name = "EditAssignmentTypesWeightsToolStripMenuItem"
        Me.EditAssignmentTypesWeightsToolStripMenuItem.Size = New System.Drawing.Size(291, 26)
        Me.EditAssignmentTypesWeightsToolStripMenuItem.Text = "Edit Assignment Types/Weights"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcGradeToolStripMenuItem, Me.GenReportCardToolStripMenuItem, Me.GenerateTranscriptToolStripMenuItem, Me.GenerateAssignmentListToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CalcGradeToolStripMenuItem
        '
        Me.CalcGradeToolStripMenuItem.Enabled = False
        Me.CalcGradeToolStripMenuItem.Name = "CalcGradeToolStripMenuItem"
        Me.CalcGradeToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.CalcGradeToolStripMenuItem.Text = "Calculate Grade"
        '
        'GenReportCardToolStripMenuItem
        '
        Me.GenReportCardToolStripMenuItem.Enabled = False
        Me.GenReportCardToolStripMenuItem.Name = "GenReportCardToolStripMenuItem"
        Me.GenReportCardToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.GenReportCardToolStripMenuItem.Text = "Generate Report Card"
        '
        'GenerateTranscriptToolStripMenuItem
        '
        Me.GenerateTranscriptToolStripMenuItem.Enabled = False
        Me.GenerateTranscriptToolStripMenuItem.Name = "GenerateTranscriptToolStripMenuItem"
        Me.GenerateTranscriptToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.GenerateTranscriptToolStripMenuItem.Text = "Generate Transcript"
        '
        'btnBackUp
        '
        Me.btnBackUp.Enabled = False
        Me.btnBackUp.Location = New System.Drawing.Point(53, 213)
        Me.btnBackUp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBackUp.Name = "btnBackUp"
        Me.btnBackUp.Size = New System.Drawing.Size(159, 28)
        Me.btnBackUp.TabIndex = 10
        Me.btnBackUp.Text = "Backup"
        Me.btnBackUp.UseVisualStyleBackColor = True
        '
        'lblSchoolName
        '
        Me.lblSchoolName.AutoSize = True
        Me.lblSchoolName.Location = New System.Drawing.Point(16, 34)
        Me.lblSchoolName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSchoolName.Name = "lblSchoolName"
        Me.lblSchoolName.Size = New System.Drawing.Size(0, 17)
        Me.lblSchoolName.TabIndex = 14
        '
        'lblAddr1
        '
        Me.lblAddr1.AutoSize = True
        Me.lblAddr1.Location = New System.Drawing.Point(16, 55)
        Me.lblAddr1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddr1.Name = "lblAddr1"
        Me.lblAddr1.Size = New System.Drawing.Size(0, 17)
        Me.lblAddr1.TabIndex = 15
        '
        'lblAddr2
        '
        Me.lblAddr2.AutoSize = True
        Me.lblAddr2.Location = New System.Drawing.Point(16, 76)
        Me.lblAddr2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddr2.Name = "lblAddr2"
        Me.lblAddr2.Size = New System.Drawing.Size(0, 17)
        Me.lblAddr2.TabIndex = 16
        '
        'GenerateAssignmentListToolStripMenuItem
        '
        Me.GenerateAssignmentListToolStripMenuItem.Name = "GenerateAssignmentListToolStripMenuItem"
        Me.GenerateAssignmentListToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.GenerateAssignmentListToolStripMenuItem.Text = "Generate Assignment List"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 256)
        Me.Controls.Add(Me.lblAddr2)
        Me.Controls.Add(Me.lblAddr1)
        Me.Controls.Add(Me.lblSchoolName)
        Me.Controls.Add(Me.btnBackUp)
        Me.Controls.Add(Me.btnViewGradebook)
        Me.Controls.Add(Me.btnOpenGB)
        Me.Controls.Add(Me.mnuMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMain
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMainMenu"
        Me.Text = "Main Menu"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpenGB As Button
    Friend WithEvents btnViewGradebook As Button
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents BackupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAssignmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewGradebookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcGradeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenReportCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetFileLocationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditSchoolInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateTranscriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents EditJSONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnBackUp As Button
    Friend WithEvents lblSchoolName As Label
    Friend WithEvents lblAddr1 As Label
    Friend WithEvents lblAddr2 As Label
    Friend WithEvents EditCourseCategoriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditAssignmentTypesWeightsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreFromBackupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateAssignmentListToolStripMenuItem As ToolStripMenuItem
End Class
