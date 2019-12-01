<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetFileLocations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetFileLocations))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGradeLoc = New System.Windows.Forms.TextBox()
        Me.btnChgGradeLoc = New System.Windows.Forms.Button()
        Me.btnChangeBkUpLoc = New System.Windows.Forms.Button()
        Me.txtBkUpLoc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Default Gradebook Location"
        '
        'txtGradeLoc
        '
        Me.txtGradeLoc.Location = New System.Drawing.Point(16, 30)
        Me.txtGradeLoc.Name = "txtGradeLoc"
        Me.txtGradeLoc.Size = New System.Drawing.Size(293, 20)
        Me.txtGradeLoc.TabIndex = 1
        '
        'btnChgGradeLoc
        '
        Me.btnChgGradeLoc.Image = CType(resources.GetObject("btnChgGradeLoc.Image"), System.Drawing.Image)
        Me.btnChgGradeLoc.Location = New System.Drawing.Point(315, 13)
        Me.btnChgGradeLoc.Name = "btnChgGradeLoc"
        Me.btnChgGradeLoc.Size = New System.Drawing.Size(35, 37)
        Me.btnChgGradeLoc.TabIndex = 2
        Me.btnChgGradeLoc.UseVisualStyleBackColor = True
        '
        'btnChangeBkUpLoc
        '
        Me.btnChangeBkUpLoc.Image = CType(resources.GetObject("btnChangeBkUpLoc.Image"), System.Drawing.Image)
        Me.btnChangeBkUpLoc.Location = New System.Drawing.Point(315, 68)
        Me.btnChangeBkUpLoc.Name = "btnChangeBkUpLoc"
        Me.btnChangeBkUpLoc.Size = New System.Drawing.Size(35, 37)
        Me.btnChangeBkUpLoc.TabIndex = 5
        Me.btnChangeBkUpLoc.UseVisualStyleBackColor = True
        '
        'txtBkUpLoc
        '
        Me.txtBkUpLoc.Location = New System.Drawing.Point(16, 85)
        Me.txtBkUpLoc.Name = "txtBkUpLoc"
        Me.txtBkUpLoc.Size = New System.Drawing.Size(293, 20)
        Me.txtBkUpLoc.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Default Backup Folder Location"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(148, 124)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(57, 23)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmSetFileLocations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 163)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnChangeBkUpLoc)
        Me.Controls.Add(Me.txtBkUpLoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnChgGradeLoc)
        Me.Controls.Add(Me.txtGradeLoc)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSetFileLocations"
        Me.Text = "Set Default File/Folder Locations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtGradeLoc As TextBox
    Friend WithEvents btnChgGradeLoc As Button
    Friend WithEvents btnChangeBkUpLoc As Button
    Friend WithEvents txtBkUpLoc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnOK As Button
End Class
