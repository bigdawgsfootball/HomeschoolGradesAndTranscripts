<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAssignment
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
        Me.cboStudents = New System.Windows.Forms.ComboBox()
        Me.cboCourses = New System.Windows.Forms.ComboBox()
        Me.cboGradeLevel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboWeight = New System.Windows.Forms.ComboBox()
        Me.btnAddAssignment = New System.Windows.Forms.Button()
        Me.txtRatingPeriod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rtbDescription = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvAssignments = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvAssignments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboStudents
        '
        Me.cboStudents.FormattingEnabled = True
        Me.cboStudents.Location = New System.Drawing.Point(3, 32)
        Me.cboStudents.Name = "cboStudents"
        Me.cboStudents.Size = New System.Drawing.Size(324, 21)
        Me.cboStudents.TabIndex = 0
        '
        'cboCourses
        '
        Me.cboCourses.FormattingEnabled = True
        Me.cboCourses.Location = New System.Drawing.Point(3, 75)
        Me.cboCourses.Name = "cboCourses"
        Me.cboCourses.Size = New System.Drawing.Size(324, 21)
        Me.cboCourses.TabIndex = 2
        '
        'cboGradeLevel
        '
        Me.cboGradeLevel.FormattingEnabled = True
        Me.cboGradeLevel.Location = New System.Drawing.Point(393, 32)
        Me.cboGradeLevel.Name = "cboGradeLevel"
        Me.cboGradeLevel.Size = New System.Drawing.Size(121, 21)
        Me.cboGradeLevel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Student"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(395, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Grade Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Course"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboWeight)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnAddAssignment)
        Me.GroupBox1.Controls.Add(Me.txtRatingPeriod)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.rtbDescription)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(522, 173)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Assignment"
        '
        'cboWeight
        '
        Me.cboWeight.FormattingEnabled = True
        Me.cboWeight.Location = New System.Drawing.Point(60, 144)
        Me.cboWeight.Name = "cboWeight"
        Me.cboWeight.Size = New System.Drawing.Size(121, 21)
        Me.cboWeight.TabIndex = 6
        '
        'btnAddAssignment
        '
        Me.btnAddAssignment.Location = New System.Drawing.Point(469, 141)
        Me.btnAddAssignment.Name = "btnAddAssignment"
        Me.btnAddAssignment.Size = New System.Drawing.Size(42, 23)
        Me.btnAddAssignment.TabIndex = 7
        Me.btnAddAssignment.Text = "Add"
        Me.btnAddAssignment.UseVisualStyleBackColor = True
        '
        'txtRatingPeriod
        '
        Me.txtRatingPeriod.Location = New System.Drawing.Point(469, 35)
        Me.txtRatingPeriod.Name = "txtRatingPeriod"
        Me.txtRatingPeriod.Size = New System.Drawing.Size(42, 20)
        Me.txtRatingPeriod.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Weight"
        '
        'rtbDescription
        '
        Me.rtbDescription.Location = New System.Drawing.Point(13, 74)
        Me.rtbDescription.Name = "rtbDescription"
        Me.rtbDescription.Size = New System.Drawing.Size(498, 60)
        Me.rtbDescription.TabIndex = 5
        Me.rtbDescription.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Description"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(13, 35)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(450, 20)
        Me.txtTitle.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Assignment Title"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(472, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 28)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Rating Period"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvAssignments
        '
        Me.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssignments.Location = New System.Drawing.Point(6, 293)
        Me.dgvAssignments.Name = "dgvAssignments"
        Me.dgvAssignments.Size = New System.Drawing.Size(519, 256)
        Me.dgvAssignments.TabIndex = 9
        '
        'frmAddAssignment
        '
        Me.AcceptButton = Me.btnAddAssignment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 561)
        Me.Controls.Add(Me.dgvAssignments)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboGradeLevel)
        Me.Controls.Add(Me.cboCourses)
        Me.Controls.Add(Me.cboStudents)
        Me.Name = "frmAddAssignment"
        Me.Text = "Add Assignment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvAssignments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboStudents As ComboBox
    Friend WithEvents cboCourses As ComboBox
    Friend WithEvents cboGradeLevel As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAddAssignment As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents rtbDescription As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboWeight As ComboBox
    Friend WithEvents txtRatingPeriod As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvAssignments As DataGridView
End Class
