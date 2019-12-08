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
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcGradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenReportCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateTranscriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBackUp = New System.Windows.Forms.Button()
        Me.lblSchoolName = New System.Windows.Forms.Label()
        Me.lblAddr1 = New System.Windows.Forms.Label()
        Me.lblAddr2 = New System.Windows.Forms.Label()
        Me.EditAssignmentTypesWeightsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOpenGB
        '
        Me.btnOpenGB.Location = New System.Drawing.Point(40, 102)
        Me.btnOpenGB.Name = "btnOpenGB"
        Me.btnOpenGB.Size = New System.Drawing.Size(119, 23)
        Me.btnOpenGB.TabIndex = 0
        Me.btnOpenGB.Text = "Open Gradebook"
        Me.btnOpenGB.UseVisualStyleBackColor = True
        '
        'btnViewGradebook
        '
        Me.btnViewGradebook.Enabled = False
        Me.btnViewGradebook.Location = New System.Drawing.Point(40, 131)
        Me.btnViewGradebook.Name = "btnViewGradebook"
        Me.btnViewGradebook.Size = New System.Drawing.Size(119, 23)
        Me.btnViewGradebook.TabIndex = 6
        Me.btnViewGradebook.Text = "View Gradebook"
        Me.btnViewGradebook.UseVisualStyleBackColor = True
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(208, 24)
        Me.mnuMain.TabIndex = 13
        Me.mnuMain.Text = "t"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.toolStripSeparator, Me.SetFileLocationsToolStripMenuItem, Me.BackupToolStripMenuItem, Me.toolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.NewToolStripMenuItem.Text = "&New Gradebook"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(199, 6)
        '
        'SetFileLocationsToolStripMenuItem
        '
        Me.SetFileLocationsToolStripMenuItem.Name = "SetFileLocationsToolStripMenuItem"
        Me.SetFileLocationsToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.SetFileLocationsToolStripMenuItem.Text = "&Set File Locations"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Enabled = False
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.BackupToolStripMenuItem.Text = "&Backup"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(199, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditSchoolInfoToolStripMenuItem, Me.ToolStripSeparator3, Me.AddStudentToolStripMenuItem, Me.AddCourseToolStripMenuItem, Me.AddAssignmentToolStripMenuItem, Me.ViewGradebookToolStripMenuItem, Me.toolStripSeparator4, Me.EditJSONToolStripMenuItem, Me.EditCourseCategoriesToolStripMenuItem, Me.EditAssignmentTypesWeightsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'EditSchoolInfoToolStripMenuItem
        '
        Me.EditSchoolInfoToolStripMenuItem.Name = "EditSchoolInfoToolStripMenuItem"
        Me.EditSchoolInfoToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.EditSchoolInfoToolStripMenuItem.Text = "Edit School Info"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(238, 6)
        '
        'AddStudentToolStripMenuItem
        '
        Me.AddStudentToolStripMenuItem.Enabled = False
        Me.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem"
        Me.AddStudentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.AddStudentToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.AddStudentToolStripMenuItem.Text = "Add Student"
        '
        'AddCourseToolStripMenuItem
        '
        Me.AddCourseToolStripMenuItem.Enabled = False
        Me.AddCourseToolStripMenuItem.Name = "AddCourseToolStripMenuItem"
        Me.AddCourseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.AddCourseToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.AddCourseToolStripMenuItem.Text = "Add Course"
        '
        'AddAssignmentToolStripMenuItem
        '
        Me.AddAssignmentToolStripMenuItem.Enabled = False
        Me.AddAssignmentToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddAssignmentToolStripMenuItem.Name = "AddAssignmentToolStripMenuItem"
        Me.AddAssignmentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.AddAssignmentToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.AddAssignmentToolStripMenuItem.Text = "Add Assignment"
        '
        'ViewGradebookToolStripMenuItem
        '
        Me.ViewGradebookToolStripMenuItem.Enabled = False
        Me.ViewGradebookToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewGradebookToolStripMenuItem.Name = "ViewGradebookToolStripMenuItem"
        Me.ViewGradebookToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ViewGradebookToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.ViewGradebookToolStripMenuItem.Text = "View Gradebook"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(238, 6)
        '
        'EditJSONToolStripMenuItem
        '
        Me.EditJSONToolStripMenuItem.Enabled = False
        Me.EditJSONToolStripMenuItem.Name = "EditJSONToolStripMenuItem"
        Me.EditJSONToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.EditJSONToolStripMenuItem.Text = "Edit JSON"
        '
        'EditCourseCategoriesToolStripMenuItem
        '
        Me.EditCourseCategoriesToolStripMenuItem.Name = "EditCourseCategoriesToolStripMenuItem"
        Me.EditCourseCategoriesToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.EditCourseCategoriesToolStripMenuItem.Text = "Edit Course Categories"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcGradeToolStripMenuItem, Me.GenReportCardToolStripMenuItem, Me.GenerateTranscriptToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CalcGradeToolStripMenuItem
        '
        Me.CalcGradeToolStripMenuItem.Enabled = False
        Me.CalcGradeToolStripMenuItem.Name = "CalcGradeToolStripMenuItem"
        Me.CalcGradeToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CalcGradeToolStripMenuItem.Text = "Calculate Grade"
        '
        'GenReportCardToolStripMenuItem
        '
        Me.GenReportCardToolStripMenuItem.Enabled = False
        Me.GenReportCardToolStripMenuItem.Name = "GenReportCardToolStripMenuItem"
        Me.GenReportCardToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.GenReportCardToolStripMenuItem.Text = "Generate Report Card"
        '
        'GenerateTranscriptToolStripMenuItem
        '
        Me.GenerateTranscriptToolStripMenuItem.Enabled = False
        Me.GenerateTranscriptToolStripMenuItem.Name = "GenerateTranscriptToolStripMenuItem"
        Me.GenerateTranscriptToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.GenerateTranscriptToolStripMenuItem.Text = "Generate Transcript"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(119, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'btnBackUp
        '
        Me.btnBackUp.Enabled = False
        Me.btnBackUp.Location = New System.Drawing.Point(40, 173)
        Me.btnBackUp.Name = "btnBackUp"
        Me.btnBackUp.Size = New System.Drawing.Size(119, 23)
        Me.btnBackUp.TabIndex = 10
        Me.btnBackUp.Text = "Backup"
        Me.btnBackUp.UseVisualStyleBackColor = True
        '
        'lblSchoolName
        '
        Me.lblSchoolName.AutoSize = True
        Me.lblSchoolName.Location = New System.Drawing.Point(12, 28)
        Me.lblSchoolName.Name = "lblSchoolName"
        Me.lblSchoolName.Size = New System.Drawing.Size(0, 13)
        Me.lblSchoolName.TabIndex = 14
        '
        'lblAddr1
        '
        Me.lblAddr1.AutoSize = True
        Me.lblAddr1.Location = New System.Drawing.Point(12, 45)
        Me.lblAddr1.Name = "lblAddr1"
        Me.lblAddr1.Size = New System.Drawing.Size(0, 13)
        Me.lblAddr1.TabIndex = 15
        '
        'lblAddr2
        '
        Me.lblAddr2.AutoSize = True
        Me.lblAddr2.Location = New System.Drawing.Point(12, 62)
        Me.lblAddr2.Name = "lblAddr2"
        Me.lblAddr2.Size = New System.Drawing.Size(0, 13)
        Me.lblAddr2.TabIndex = 16
        '
        'EditAssignmentTypesWeightsToolStripMenuItem
        '
        Me.EditAssignmentTypesWeightsToolStripMenuItem.Name = "EditAssignmentTypesWeightsToolStripMenuItem"
        Me.EditAssignmentTypesWeightsToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.EditAssignmentTypesWeightsToolStripMenuItem.Text = "Edit Assignment Types/Weights"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(208, 208)
        Me.Controls.Add(Me.lblAddr2)
        Me.Controls.Add(Me.lblAddr1)
        Me.Controls.Add(Me.lblSchoolName)
        Me.Controls.Add(Me.btnBackUp)
        Me.Controls.Add(Me.btnViewGradebook)
        Me.Controls.Add(Me.btnOpenGB)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
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
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
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
End Class
