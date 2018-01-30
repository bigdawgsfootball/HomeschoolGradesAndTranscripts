<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCourse
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStudents = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCredits = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumRatings = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGradeLevel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.dgvCourses = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboCategories = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Student to add Course to"
        '
        'cboStudents
        '
        Me.cboStudents.FormattingEnabled = True
        Me.cboStudents.Location = New System.Drawing.Point(12, 22)
        Me.cboStudents.Name = "cboStudents"
        Me.cboStudents.Size = New System.Drawing.Size(256, 21)
        Me.cboStudents.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboCategories)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCredits)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNumRatings)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPublisher)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtGradeLevel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(533, 150)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Course Info"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(148, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Credits"
        '
        'txtCredits
        '
        Me.txtCredits.Location = New System.Drawing.Point(193, 20)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.Size = New System.Drawing.Size(42, 20)
        Me.txtCredits.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(246, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Number of Rating Periods"
        '
        'txtNumRatings
        '
        Me.txtNumRatings.Location = New System.Drawing.Point(376, 21)
        Me.txtNumRatings.Name = "txtNumRatings"
        Me.txtNumRatings.Size = New System.Drawing.Size(35, 20)
        Me.txtNumRatings.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Course Publisher"
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(5, 93)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(523, 20)
        Me.txtPublisher.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(417, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Grade Level"
        '
        'txtGradeLevel
        '
        Me.txtGradeLevel.Location = New System.Drawing.Point(484, 20)
        Me.txtGradeLevel.Name = "txtGradeLevel"
        Me.txtGradeLevel.Size = New System.Drawing.Size(42, 20)
        Me.txtGradeLevel.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course Title"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(4, 46)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(523, 20)
        Me.txtTitle.TabIndex = 3
        '
        'btnAddCourse
        '
        Me.btnAddCourse.Location = New System.Drawing.Point(462, 22)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCourse.TabIndex = 5
        Me.btnAddCourse.Text = "Add Course"
        Me.btnAddCourse.UseVisualStyleBackColor = True
        '
        'dgvCourses
        '
        Me.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCourses.Location = New System.Drawing.Point(12, 223)
        Me.dgvCourses.Name = "dgvCourses"
        Me.dgvCourses.Size = New System.Drawing.Size(527, 279)
        Me.dgvCourses.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Existing Courses"
        '
        'cboCategories
        '
        Me.cboCategories.FormattingEnabled = True
        Me.cboCategories.Location = New System.Drawing.Point(99, 121)
        Me.cboCategories.Name = "cboCategories"
        Me.cboCategories.Size = New System.Drawing.Size(426, 21)
        Me.cboCategories.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Course Category"
        '
        'frmAddCourse
        '
        Me.AcceptButton = Me.btnAddCourse
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 514)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvCourses)
        Me.Controls.Add(Me.btnAddCourse)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboStudents)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAddCourse"
        Me.Text = "Add Course for Student"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvCourses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents cboStudents As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGradeLevel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents dgvCourses As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNumRatings As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCredits As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboCategories As ComboBox
End Class
