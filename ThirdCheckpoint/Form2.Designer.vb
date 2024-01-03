<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StartProcessButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxPParameter = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'StartProcessButton
        '
        Me.StartProcessButton.Location = New System.Drawing.Point(237, 167)
        Me.StartProcessButton.Name = "StartProcessButton"
        Me.StartProcessButton.Size = New System.Drawing.Size(182, 38)
        Me.StartProcessButton.TabIndex = 5
        Me.StartProcessButton.Text = "Расчитать"
        Me.StartProcessButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "p"
        '
        'TextBoxPParameter
        '
        Me.TextBoxPParameter.Location = New System.Drawing.Point(255, 86)
        Me.TextBoxPParameter.Name = "TextBoxPParameter"
        Me.TextBoxPParameter.Size = New System.Drawing.Size(164, 26)
        Me.TextBoxPParameter.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 291)
        Me.Controls.Add(Me.StartProcessButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxPParameter)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartProcessButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxPParameter As TextBox
End Class
