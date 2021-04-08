<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerForm
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
        Me.FishButton = New System.Windows.Forms.Button()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FishButton
        '
        Me.FishButton.Location = New System.Drawing.Point(158, 348)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(122, 69)
        Me.FishButton.TabIndex = 0
        Me.FishButton.Text = "Fish"
        Me.FishButton.UseVisualStyleBackColor = True
        '
        'SaladButton
        '
        Me.SaladButton.Location = New System.Drawing.Point(325, 348)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(122, 69)
        Me.SaladButton.TabIndex = 1
        Me.SaladButton.Text = "Salad"
        Me.SaladButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(666, 369)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(122, 69)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SoupButton
        '
        Me.SoupButton.Location = New System.Drawing.Point(487, 348)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(122, 69)
        Me.SoupButton.TabIndex = 3
        Me.SoupButton.Text = "Soup"
        Me.SoupButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Pristina", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(296, 9)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(179, 42)
        Me.NameLabel.TabIndex = 4
        Me.NameLabel.Text = "Spencer's Diner"
        '
        'DisplayLabel
        '
        Me.DisplayLabel.AutoSize = True
        Me.DisplayLabel.Font = New System.Drawing.Font("Informal Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayLabel.Location = New System.Drawing.Point(105, 97)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(0, 34)
        Me.DisplayLabel.TabIndex = 5
        Me.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DinerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.SoupButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.FishButton)
        Me.Name = "DinerForm"
        Me.Text = "Diner Menu "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FishButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents SoupButton As Button
    Friend WithEvents NameLabel As Label
    Friend WithEvents DisplayLabel As Label
End Class
