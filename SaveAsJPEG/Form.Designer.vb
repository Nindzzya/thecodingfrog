<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Me.Install = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.AutoArchive = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LabelCS5 = New System.Windows.Forms.Label
        Me.LabelCS4 = New System.Windows.Forms.Label
        Me.LabelCS3 = New System.Windows.Forms.Label
        Me.CS5 = New System.Windows.Forms.Label
        Me.CS4 = New System.Windows.Forms.Label
        Me.CS3 = New System.Windows.Forms.Label
        Me.ArchiveDirectory = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Install
        '
        Me.Install.Location = New System.Drawing.Point(6, 94)
        Me.Install.Name = "Install"
        Me.Install.Size = New System.Drawing.Size(247, 23)
        Me.Install.TabIndex = 0
        Me.Install.Text = "Button1"
        Me.Install.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ArchiveDirectory)
        Me.GroupBox1.Controls.Add(Me.AutoArchive)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 77)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Archive"
        '
        'AutoArchive
        '
        Me.AutoArchive.AutoSize = True
        Me.AutoArchive.Location = New System.Drawing.Point(10, 45)
        Me.AutoArchive.Name = "AutoArchive"
        Me.AutoArchive.Size = New System.Drawing.Size(166, 17)
        Me.AutoArchive.TabIndex = 0
        Me.AutoArchive.Text = "Auto archive previous version"
        Me.AutoArchive.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelCS5)
        Me.GroupBox2.Controls.Add(Me.LabelCS4)
        Me.GroupBox2.Controls.Add(Me.LabelCS3)
        Me.GroupBox2.Controls.Add(Me.CS5)
        Me.GroupBox2.Controls.Add(Me.CS4)
        Me.GroupBox2.Controls.Add(Me.CS3)
        Me.GroupBox2.Controls.Add(Me.Install)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 123)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Install"
        '
        'LabelCS5
        '
        Me.LabelCS5.AutoSize = True
        Me.LabelCS5.Location = New System.Drawing.Point(93, 68)
        Me.LabelCS5.Name = "LabelCS5"
        Me.LabelCS5.Size = New System.Drawing.Size(54, 13)
        Me.LabelCS5.TabIndex = 6
        Me.LabelCS5.Text = "Not found"
        '
        'LabelCS4
        '
        Me.LabelCS4.AutoSize = True
        Me.LabelCS4.Location = New System.Drawing.Point(93, 44)
        Me.LabelCS4.Name = "LabelCS4"
        Me.LabelCS4.Size = New System.Drawing.Size(54, 13)
        Me.LabelCS4.TabIndex = 5
        Me.LabelCS4.Text = "Not found"
        '
        'LabelCS3
        '
        Me.LabelCS3.AutoSize = True
        Me.LabelCS3.Location = New System.Drawing.Point(93, 20)
        Me.LabelCS3.Name = "LabelCS3"
        Me.LabelCS3.Size = New System.Drawing.Size(54, 13)
        Me.LabelCS3.TabIndex = 4
        Me.LabelCS3.Text = "Not found"
        '
        'CS5
        '
        Me.CS5.AutoSize = True
        Me.CS5.Location = New System.Drawing.Point(7, 68)
        Me.CS5.Name = "CS5"
        Me.CS5.Size = New System.Drawing.Size(90, 13)
        Me.CS5.TabIndex = 3
        Me.CS5.Text = "Photoshop CS5 : "
        '
        'CS4
        '
        Me.CS4.AutoSize = True
        Me.CS4.Location = New System.Drawing.Point(7, 44)
        Me.CS4.Name = "CS4"
        Me.CS4.Size = New System.Drawing.Size(90, 13)
        Me.CS4.TabIndex = 2
        Me.CS4.Text = "Photoshop CS4 : "
        '
        'CS3
        '
        Me.CS3.AutoSize = True
        Me.CS3.Location = New System.Drawing.Point(7, 20)
        Me.CS3.Name = "CS3"
        Me.CS3.Size = New System.Drawing.Size(90, 13)
        Me.CS3.TabIndex = 1
        Me.CS3.Text = "Photoshop CS3 : "
        '
        'ArchiveDirectory
        '
        Me.ArchiveDirectory.Location = New System.Drawing.Point(75, 19)
        Me.ArchiveDirectory.Name = "ArchiveDirectory"
        Me.ArchiveDirectory.Size = New System.Drawing.Size(178, 20)
        Me.ArchiveDirectory.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Directory"
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 232)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form"
        Me.Text = "SaveAsJPEG"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Install As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AutoArchive As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CS3 As System.Windows.Forms.Label
    Friend WithEvents CS5 As System.Windows.Forms.Label
    Friend WithEvents CS4 As System.Windows.Forms.Label
    Friend WithEvents LabelCS5 As System.Windows.Forms.Label
    Friend WithEvents LabelCS4 As System.Windows.Forms.Label
    Friend WithEvents LabelCS3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ArchiveDirectory As System.Windows.Forms.TextBox
End Class