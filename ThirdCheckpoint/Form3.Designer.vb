<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.TextBoxDimensionParameter = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'StartProcessButton
        '
        Me.StartProcessButton.Location = New System.Drawing.Point(151, 247)
        Me.StartProcessButton.Name = "StartProcessButton"
        Me.StartProcessButton.Size = New System.Drawing.Size(342, 38)
        Me.StartProcessButton.TabIndex = 8
        Me.StartProcessButton.Text = "Расчитать"
        Me.StartProcessButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Размерность массива"
        '
        'TextBoxDimensionParameter
        '
        Me.TextBoxDimensionParameter.Location = New System.Drawing.Point(329, 166)
        Me.TextBoxDimensionParameter.Name = "TextBoxDimensionParameter"
        Me.TextBoxDimensionParameter.Size = New System.Drawing.Size(164, 26)
        Me.TextBoxDimensionParameter.TabIndex = 6
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 450)
        Me.Controls.Add(Me.StartProcessButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxDimensionParameter)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartProcessButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxDimensionParameter As TextBox
End Class
