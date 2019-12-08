<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalcGrade
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboGradeLevel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStudents = New System.Windows.Forms.ComboBox()
        Me.dgvGrades = New System.Windows.Forms.DataGridView()
        CType(Me.dgvGrades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Select Grade Level"
        '
        'cboGradeLevel
        '
        Me.cboGradeLevel.FormattingEnabled = True
        Me.cboGradeLevel.Location = New System.Drawing.Point(149, 25)
        Me.cboGradeLevel.Name = "cboGradeLevel"
        Me.cboGradeLevel.Size = New System.Drawing.Size(90, 21)
        Me.cboGradeLevel.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select Student"
        '
        'cboStudents
        '
        Me.cboStudents.FormattingEnabled = True
        Me.cboStudents.Location = New System.Drawing.Point(12, 26)
        Me.cboStudents.Name = "cboStudents"
        Me.cboStudents.Size = New System.Drawing.Size(121, 21)
        Me.cboStudents.TabIndex = 6
        '
        'dgvGrades
        '
        Me.dgvGrades.AllowUserToAddRows = False
        Me.dgvGrades.AllowUserToDeleteRows = False
        Me.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrades.Location = New System.Drawing.Point(12, 75)
        Me.dgvGrades.Name = "dgvGrades"
        Me.dgvGrades.ReadOnly = True
        Me.dgvGrades.Size = New System.Drawing.Size(576, 295)
        Me.dgvGrades.TabIndex = 10
        '
        'frmCalcGrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 382)
        Me.Controls.Add(Me.dgvGrades)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboGradeLevel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboStudents)
        Me.Name = "frmCalcGrade"
        Me.Text = "Calculate Grades"
        CType(Me.dgvGrades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents cboGradeLevel As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboStudents As ComboBox
    Friend WithEvents dgvGrades As DataGridView
End Class
