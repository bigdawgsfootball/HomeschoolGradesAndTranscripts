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
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.btnGenTranscript = New System.Windows.Forms.Button()
        Me.btnAddAssignment = New System.Windows.Forms.Button()
        Me.btnViewGradebook = New System.Windows.Forms.Button()
        Me.btnCalcGrade = New System.Windows.Forms.Button()
        Me.btnEditJSON = New System.Windows.Forms.Button()
        Me.btnReportCard = New System.Windows.Forms.Button()
        Me.btnBackUp = New System.Windows.Forms.Button()
        Me.btnSetLocations = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCreateNew = New System.Windows.Forms.Button()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetFileLocationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditSchoolInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateTranscriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditJSONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOpenGB
        '
        Me.btnOpenGB.Location = New System.Drawing.Point(7, 29)
        Me.btnOpenGB.Name = "btnOpenGB"
        Me.btnOpenGB.Size = New System.Drawing.Size(119, 23)
        Me.btnOpenGB.TabIndex = 0
        Me.btnOpenGB.Text = "Open Gradebook"
        Me.btnOpenGB.UseVisualStyleBackColor = True
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Enabled = False
        Me.btnAddStudent.Location = New System.Drawing.Point(7, 59)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(119, 23)
        Me.btnAddStudent.TabIndex = 1
        Me.btnAddStudent.Text = "Add Student"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'btnAddCourse
        '
        Me.btnAddCourse.Enabled = False
        Me.btnAddCourse.Location = New System.Drawing.Point(7, 89)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(119, 23)
        Me.btnAddCourse.TabIndex = 2
        Me.btnAddCourse.Text = "Add Course"
        Me.btnAddCourse.UseVisualStyleBackColor = True
        '
        'btnGenTranscript
        '
        Me.btnGenTranscript.Enabled = False
        Me.btnGenTranscript.Location = New System.Drawing.Point(153, 118)
        Me.btnGenTranscript.Name = "btnGenTranscript"
        Me.btnGenTranscript.Size = New System.Drawing.Size(119, 23)
        Me.btnGenTranscript.TabIndex = 3
        Me.btnGenTranscript.Text = "Generate Transcript"
        Me.btnGenTranscript.UseVisualStyleBackColor = True
        '
        'btnAddAssignment
        '
        Me.btnAddAssignment.Enabled = False
        Me.btnAddAssignment.Location = New System.Drawing.Point(7, 118)
        Me.btnAddAssignment.Name = "btnAddAssignment"
        Me.btnAddAssignment.Size = New System.Drawing.Size(119, 23)
        Me.btnAddAssignment.TabIndex = 5
        Me.btnAddAssignment.Text = "Add Assignment"
        Me.btnAddAssignment.UseVisualStyleBackColor = True
        '
        'btnViewGradebook
        '
        Me.btnViewGradebook.Enabled = False
        Me.btnViewGradebook.Location = New System.Drawing.Point(153, 29)
        Me.btnViewGradebook.Name = "btnViewGradebook"
        Me.btnViewGradebook.Size = New System.Drawing.Size(119, 23)
        Me.btnViewGradebook.TabIndex = 6
        Me.btnViewGradebook.Text = "View Gradebook"
        Me.btnViewGradebook.UseVisualStyleBackColor = True
        '
        'btnCalcGrade
        '
        Me.btnCalcGrade.Enabled = False
        Me.btnCalcGrade.Location = New System.Drawing.Point(153, 59)
        Me.btnCalcGrade.Name = "btnCalcGrade"
        Me.btnCalcGrade.Size = New System.Drawing.Size(119, 23)
        Me.btnCalcGrade.TabIndex = 7
        Me.btnCalcGrade.Text = "Calculate Grade"
        Me.btnCalcGrade.UseVisualStyleBackColor = True
        '
        'btnEditJSON
        '
        Me.btnEditJSON.Enabled = False
        Me.btnEditJSON.Location = New System.Drawing.Point(153, 189)
        Me.btnEditJSON.Name = "btnEditJSON"
        Me.btnEditJSON.Size = New System.Drawing.Size(119, 23)
        Me.btnEditJSON.TabIndex = 8
        Me.btnEditJSON.Text = "Edit JSON"
        Me.btnEditJSON.UseVisualStyleBackColor = True
        '
        'btnReportCard
        '
        Me.btnReportCard.Enabled = False
        Me.btnReportCard.Location = New System.Drawing.Point(153, 88)
        Me.btnReportCard.Name = "btnReportCard"
        Me.btnReportCard.Size = New System.Drawing.Size(119, 23)
        Me.btnReportCard.TabIndex = 9
        Me.btnReportCard.Text = "Generate Report Card"
        Me.btnReportCard.UseVisualStyleBackColor = True
        '
        'btnBackUp
        '
        Me.btnBackUp.Enabled = False
        Me.btnBackUp.Location = New System.Drawing.Point(153, 219)
        Me.btnBackUp.Name = "btnBackUp"
        Me.btnBackUp.Size = New System.Drawing.Size(119, 23)
        Me.btnBackUp.TabIndex = 10
        Me.btnBackUp.Text = "Backup"
        Me.btnBackUp.UseVisualStyleBackColor = True
        '
        'btnSetLocations
        '
        Me.btnSetLocations.Location = New System.Drawing.Point(13, 218)
        Me.btnSetLocations.Name = "btnSetLocations"
        Me.btnSetLocations.Size = New System.Drawing.Size(134, 23)
        Me.btnSetLocations.TabIndex = 11
        Me.btnSetLocations.Text = "Set File Locations"
        Me.btnSetLocations.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCreateNew)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 173)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 76)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Admin"
        '
        'btnCreateNew
        '
        Me.btnCreateNew.Location = New System.Drawing.Point(6, 16)
        Me.btnCreateNew.Name = "btnCreateNew"
        Me.btnCreateNew.Size = New System.Drawing.Size(134, 23)
        Me.btnCreateNew.TabIndex = 0
        Me.btnCreateNew.Text = "Create new gradebook"
        Me.btnCreateNew.UseVisualStyleBackColor = True
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(284, 24)
        Me.mnuMain.TabIndex = 13
        Me.mnuMain.Text = "t"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.SetFileLocationsToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator1, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
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
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.NewToolStripMenuItem.Text = "&New Gradebook"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.OpenToolStripMenuItem.Text = "&Open Gradebook"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(204, 6)
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.SaveAsToolStripMenuItem.Text = "&Backup"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(204, 6)
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(204, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditSchoolInfoToolStripMenuItem, Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.toolStripSeparator4})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.UndoToolStripMenuItem.Text = "Add Student"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.RedoToolStripMenuItem.Text = "Add Course"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CutToolStripMenuItem.Text = "Add Assignment"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CopyToolStripMenuItem.Text = "View Gradebook"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(200, 6)
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.GenerateTranscriptToolStripMenuItem, Me.EditJSONToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CustomizeToolStripMenuItem.Text = "Calculate Grade"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.OptionsToolStripMenuItem.Text = "Generate Report Card"
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
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(149, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'SetFileLocationsToolStripMenuItem
        '
        Me.SetFileLocationsToolStripMenuItem.Name = "SetFileLocationsToolStripMenuItem"
        Me.SetFileLocationsToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.SetFileLocationsToolStripMenuItem.Text = "&Set File Locations"
        '
        'EditSchoolInfoToolStripMenuItem
        '
        Me.EditSchoolInfoToolStripMenuItem.Name = "EditSchoolInfoToolStripMenuItem"
        Me.EditSchoolInfoToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.EditSchoolInfoToolStripMenuItem.Text = "Edit School Info"
        '
        'GenerateTranscriptToolStripMenuItem
        '
        Me.GenerateTranscriptToolStripMenuItem.Name = "GenerateTranscriptToolStripMenuItem"
        Me.GenerateTranscriptToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.GenerateTranscriptToolStripMenuItem.Text = "Generate Transcript"
        '
        'EditJSONToolStripMenuItem
        '
        Me.EditJSONToolStripMenuItem.Name = "EditJSONToolStripMenuItem"
        Me.EditJSONToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.EditJSONToolStripMenuItem.Text = "Edit JSON"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnSetLocations)
        Me.Controls.Add(Me.btnBackUp)
        Me.Controls.Add(Me.btnReportCard)
        Me.Controls.Add(Me.btnEditJSON)
        Me.Controls.Add(Me.btnCalcGrade)
        Me.Controls.Add(Me.btnViewGradebook)
        Me.Controls.Add(Me.btnAddAssignment)
        Me.Controls.Add(Me.btnGenTranscript)
        Me.Controls.Add(Me.btnAddCourse)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.btnOpenGB)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMainMenu"
        Me.Text = "Main Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpenGB As Button
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnGenTranscript As Button
    Friend WithEvents btnAddAssignment As Button
    Friend WithEvents btnViewGradebook As Button
    Friend WithEvents btnCalcGrade As Button
    Friend WithEvents btnEditJSON As Button
    Friend WithEvents btnReportCard As Button
    Friend WithEvents btnBackUp As Button
    Friend WithEvents btnSetLocations As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCreateNew As Button
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetFileLocationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditSchoolInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateTranscriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditJSONToolStripMenuItem As ToolStripMenuItem
End Class
