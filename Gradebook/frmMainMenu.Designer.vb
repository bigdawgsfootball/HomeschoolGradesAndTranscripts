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
        Me.btnOpenGB = New System.Windows.Forms.Button()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.btnAddExtra = New System.Windows.Forms.Button()
        Me.btnAddAssignment = New System.Windows.Forms.Button()
        Me.btnViewGradebook = New System.Windows.Forms.Button()
        Me.btnCalcGrade = New System.Windows.Forms.Button()
        Me.btnEditJSON = New System.Windows.Forms.Button()
        Me.btnReportCard = New System.Windows.Forms.Button()
        Me.btnBackUp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOpenGB
        '
        Me.btnOpenGB.Location = New System.Drawing.Point(7, 7)
        Me.btnOpenGB.Name = "btnOpenGB"
        Me.btnOpenGB.Size = New System.Drawing.Size(119, 23)
        Me.btnOpenGB.TabIndex = 0
        Me.btnOpenGB.Text = "Open Gradebook"
        Me.btnOpenGB.UseVisualStyleBackColor = True
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Enabled = False
        Me.btnAddStudent.Location = New System.Drawing.Point(7, 37)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(119, 23)
        Me.btnAddStudent.TabIndex = 1
        Me.btnAddStudent.Text = "Add Student"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'btnAddCourse
        '
        Me.btnAddCourse.Enabled = False
        Me.btnAddCourse.Location = New System.Drawing.Point(7, 67)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(119, 23)
        Me.btnAddCourse.TabIndex = 2
        Me.btnAddCourse.Text = "Add Course"
        Me.btnAddCourse.UseVisualStyleBackColor = True
        '
        'btnAddExtra
        '
        Me.btnAddExtra.Enabled = False
        Me.btnAddExtra.Location = New System.Drawing.Point(7, 226)
        Me.btnAddExtra.Name = "btnAddExtra"
        Me.btnAddExtra.Size = New System.Drawing.Size(119, 23)
        Me.btnAddExtra.TabIndex = 3
        Me.btnAddExtra.Text = "Add Extracurricular"
        Me.btnAddExtra.UseVisualStyleBackColor = True
        '
        'btnAddAssignment
        '
        Me.btnAddAssignment.Enabled = False
        Me.btnAddAssignment.Location = New System.Drawing.Point(7, 96)
        Me.btnAddAssignment.Name = "btnAddAssignment"
        Me.btnAddAssignment.Size = New System.Drawing.Size(119, 23)
        Me.btnAddAssignment.TabIndex = 5
        Me.btnAddAssignment.Text = "Add Assignment"
        Me.btnAddAssignment.UseVisualStyleBackColor = True
        '
        'btnViewGradebook
        '
        Me.btnViewGradebook.Enabled = False
        Me.btnViewGradebook.Location = New System.Drawing.Point(153, 7)
        Me.btnViewGradebook.Name = "btnViewGradebook"
        Me.btnViewGradebook.Size = New System.Drawing.Size(119, 23)
        Me.btnViewGradebook.TabIndex = 6
        Me.btnViewGradebook.Text = "View Gradebook"
        Me.btnViewGradebook.UseVisualStyleBackColor = True
        '
        'btnCalcGrade
        '
        Me.btnCalcGrade.Enabled = False
        Me.btnCalcGrade.Location = New System.Drawing.Point(153, 37)
        Me.btnCalcGrade.Name = "btnCalcGrade"
        Me.btnCalcGrade.Size = New System.Drawing.Size(119, 23)
        Me.btnCalcGrade.TabIndex = 7
        Me.btnCalcGrade.Text = "Calculate Grade"
        Me.btnCalcGrade.UseVisualStyleBackColor = True
        '
        'btnEditJSON
        '
        Me.btnEditJSON.Enabled = False
        Me.btnEditJSON.Location = New System.Drawing.Point(153, 127)
        Me.btnEditJSON.Name = "btnEditJSON"
        Me.btnEditJSON.Size = New System.Drawing.Size(119, 23)
        Me.btnEditJSON.TabIndex = 8
        Me.btnEditJSON.Text = "Edit JSON"
        Me.btnEditJSON.UseVisualStyleBackColor = True
        '
        'btnReportCard
        '
        Me.btnReportCard.Enabled = False
        Me.btnReportCard.Location = New System.Drawing.Point(153, 66)
        Me.btnReportCard.Name = "btnReportCard"
        Me.btnReportCard.Size = New System.Drawing.Size(119, 23)
        Me.btnReportCard.TabIndex = 9
        Me.btnReportCard.Text = "Generate Report Card"
        Me.btnReportCard.UseVisualStyleBackColor = True
        '
        'btnBackUp
        '
        Me.btnBackUp.Enabled = False
        Me.btnBackUp.Location = New System.Drawing.Point(153, 157)
        Me.btnBackUp.Name = "btnBackUp"
        Me.btnBackUp.Size = New System.Drawing.Size(119, 23)
        Me.btnBackUp.TabIndex = 10
        Me.btnBackUp.Text = "Backup to GDrive"
        Me.btnBackUp.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnBackUp)
        Me.Controls.Add(Me.btnReportCard)
        Me.Controls.Add(Me.btnEditJSON)
        Me.Controls.Add(Me.btnCalcGrade)
        Me.Controls.Add(Me.btnViewGradebook)
        Me.Controls.Add(Me.btnAddAssignment)
        Me.Controls.Add(Me.btnAddExtra)
        Me.Controls.Add(Me.btnAddCourse)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.btnOpenGB)
        Me.Name = "frmMainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOpenGB As Button
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnAddExtra As Button
    Friend WithEvents btnAddAssignment As Button
    Friend WithEvents btnViewGradebook As Button
    Friend WithEvents btnCalcGrade As Button
    Friend WithEvents btnEditJSON As Button
    Friend WithEvents btnReportCard As Button
    Friend WithEvents btnBackUp As Button
End Class
