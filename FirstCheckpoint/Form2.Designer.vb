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
        Me.XParameterLabel = New System.Windows.Forms.Label()
        Me.TextBoxXParameter = New System.Windows.Forms.TextBox()
        Me.StartProcessButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'XParameterLabel
        '
        Me.XParameterLabel.AutoSize = True
        Me.XParameterLabel.Location = New System.Drawing.Point(125, 73)
        Me.XParameterLabel.Name = "XParameterLabel"
        Me.XParameterLabel.Size = New System.Drawing.Size(14, 13)
        Me.XParameterLabel.TabIndex = 0
        Me.XParameterLabel.Text = "X"
        '
        'TextBoxXParameter
        '
        Me.TextBoxXParameter.Location = New System.Drawing.Point(175, 70)
        Me.TextBoxXParameter.Name = "TextBoxXParameter"
        Me.TextBoxXParameter.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxXParameter.TabIndex = 1
        '
        'StartProcessButton
        '
        Me.StartProcessButton.Location = New System.Drawing.Point(166, 150)
        Me.StartProcessButton.Name = "StartProcessButton"
        Me.StartProcessButton.Size = New System.Drawing.Size(75, 23)
        Me.StartProcessButton.TabIndex = 2
        Me.StartProcessButton.Text = "Решение"
        Me.StartProcessButton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 231)
        Me.Controls.Add(Me.StartProcessButton)
        Me.Controls.Add(Me.TextBoxXParameter)
        Me.Controls.Add(Me.XParameterLabel)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents XParameterLabel As Label
    Friend WithEvents TextBoxXParameter As TextBox
    Friend WithEvents StartProcessButton As Button
End Class
