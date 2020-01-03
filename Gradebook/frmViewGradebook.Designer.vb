<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewGradebook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewGradebook))
        Me.cboStudents = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboGradeLevel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCourses = New System.Windows.Forms.ComboBox()
        Me.dgvGradebook = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.cboRatingPeriod = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvGradebook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboStudents
        '
        Me.cboStudents.FormattingEnabled = True
        Me.cboStudents.Location = New System.Drawing.Point(17, 39)
        Me.cboStudents.Margin = New System.Windows.Forms.Padding(4)
        Me.cboStudents.Name = "cboStudents"
        Me.cboStudents.Size = New System.Drawing.Size(160, 24)
        Me.cboStudents.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Student"
        '
        'cboGradeLevel
        '
        Me.cboGradeLevel.FormattingEnabled = True
        Me.cboGradeLevel.Location = New System.Drawing.Point(200, 38)
        Me.cboGradeLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.cboGradeLevel.Name = "cboGradeLevel"
        Me.cboGradeLevel.Size = New System.Drawing.Size(119, 24)
        Me.cboGradeLevel.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Grade Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(343, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Select Course"
        '
        'cboCourses
        '
        Me.cboCourses.FormattingEnabled = True
        Me.cboCourses.Location = New System.Drawing.Point(343, 38)
        Me.cboCourses.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCourses.Name = "cboCourses"
        Me.cboCourses.Size = New System.Drawing.Size(303, 24)
        Me.cboCourses.TabIndex = 4
        '
        'dgvGradebook
        '
        Me.dgvGradebook.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGradebook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvGradebook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGradebook.Location = New System.Drawing.Point(21, 103)
        Me.dgvGradebook.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvGradebook.Name = "dgvGradebook"
        Me.dgvGradebook.Size = New System.Drawing.Size(1156, 485)
        Me.dgvGradebook.TabIndex = 6
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(1063, 38)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(115, 28)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(924, 39)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(100, 28)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "Calculator"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'cboRatingPeriod
        '
        Me.cboRatingPeriod.FormattingEnabled = True
        Me.cboRatingPeriod.Items.AddRange(New Object() {"All"})
        Me.cboRatingPeriod.Location = New System.Drawing.Point(671, 39)
        Me.cboRatingPeriod.Margin = New System.Windows.Forms.Padding(4)
        Me.cboRatingPeriod.Name = "cboRatingPeriod"
        Me.cboRatingPeriod.Size = New System.Drawing.Size(137, 24)
        Me.cboRatingPeriod.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(671, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Select Rating Period"
        '
        'frmViewGradebook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 603)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboRatingPeriod)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvGradebook)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboCourses)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboGradeLevel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboStudents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmViewGradebook"
        Me.Text = "Gradebook"
        CType(Me.dgvGradebook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboStudents As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboGradeLevel As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboCourses As ComboBox
    Friend WithEvents dgvGradebook As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents cboRatingPeriod As ComboBox
    Friend WithEvents Label4 As Label
End Class
