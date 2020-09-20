<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstfilenames = New System.Windows.Forms.ListBox()
        Me.lstfilepaths = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.Location = New System.Drawing.Point(257, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lstfilenames
        '
        Me.lstfilenames.FormattingEnabled = True
        Me.lstfilenames.Location = New System.Drawing.Point(32, 106)
        Me.lstfilenames.Name = "lstfilenames"
        Me.lstfilenames.Size = New System.Drawing.Size(264, 355)
        Me.lstfilenames.TabIndex = 1
        '
        'lstfilepaths
        '
        Me.lstfilepaths.FormattingEnabled = True
        Me.lstfilepaths.Location = New System.Drawing.Point(352, 106)
        Me.lstfilepaths.Name = "lstfilepaths"
        Me.lstfilepaths.Size = New System.Drawing.Size(473, 355)
        Me.lstfilepaths.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(910, 500)
        Me.Controls.Add(Me.lstfilepaths)
        Me.Controls.Add(Me.lstfilenames)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "File "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lstfilenames As ListBox
    Friend WithEvents lstfilepaths As ListBox
End Class
