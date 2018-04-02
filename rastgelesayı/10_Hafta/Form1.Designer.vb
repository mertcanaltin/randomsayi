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
        Me.TextBoxUretme = New System.Windows.Forms.TextBox()
        Me.ButtonYontem1 = New System.Windows.Forms.Button()
        Me.ButtonYontem2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxUretme
        '
        Me.TextBoxUretme.Location = New System.Drawing.Point(12, 12)
        Me.TextBoxUretme.Name = "TextBoxUretme"
        Me.TextBoxUretme.Size = New System.Drawing.Size(177, 20)
        Me.TextBoxUretme.TabIndex = 1
        '
        'ButtonYontem1
        '
        Me.ButtonYontem1.Location = New System.Drawing.Point(12, 38)
        Me.ButtonYontem1.Name = "ButtonYontem1"
        Me.ButtonYontem1.Size = New System.Drawing.Size(177, 45)
        Me.ButtonYontem1.TabIndex = 0
        Me.ButtonYontem1.Text = "Yöntem 1 Rastgele sayı"
        Me.ButtonYontem1.UseVisualStyleBackColor = True
        '
        'ButtonYontem2
        '
        Me.ButtonYontem2.Location = New System.Drawing.Point(12, 89)
        Me.ButtonYontem2.Name = "ButtonYontem2"
        Me.ButtonYontem2.Size = New System.Drawing.Size(177, 45)
        Me.ButtonYontem2.TabIndex = 2
        Me.ButtonYontem2.Text = "Yöntem 2 Rastgele sayı"
        Me.ButtonYontem2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 281)
        Me.Controls.Add(Me.ButtonYontem2)
        Me.Controls.Add(Me.ButtonYontem1)
        Me.Controls.Add(Me.TextBoxUretme)
        Me.Name = "Form1"
        Me.Text = "Rastgele Sayı Üretme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxUretme As System.Windows.Forms.TextBox
    Friend WithEvents ButtonYontem1 As System.Windows.Forms.Button
    Friend WithEvents ButtonYontem2 As System.Windows.Forms.Button

End Class
