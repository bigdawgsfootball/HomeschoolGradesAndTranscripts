<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddStudent))
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNewStudent = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStudents
        '
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(17, 85)
        Me.dgvStudents.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.Size = New System.Drawing.Size(579, 220)
        Me.dgvStudents.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Current Students"
        '
        'txtNewStudent
        '
        Me.txtNewStudent.Location = New System.Drawing.Point(17, 32)
        Me.txtNewStudent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNewStudent.Name = "txtNewStudent"
        Me.txtNewStudent.Size = New System.Drawing.Size(496, 22)
        Me.txtNewStudent.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "New Student"
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Location = New System.Drawing.Point(524, 32)
        Me.btnAddStudent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(72, 28)
        Me.btnAddStudent.TabIndex = 4
        Me.btnAddStudent.Text = "Add"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'frmAddStudent
        '
        Me.AcceptButton = Me.btnAddStudent
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 321)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNewStudent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvStudents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAddStudent"
        Me.Text = "Add Student to Gradebook"
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNewStudent As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddStudent As Button
End Class
