<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBoxXParameter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartProcessButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxXParameter
        '
        Me.TextBoxXParameter.Location = New System.Drawing.Point(61, 45)
        Me.TextBoxXParameter.Name = "TextBoxXParameter"
        Me.TextBoxXParameter.Size = New System.Drawing.Size(164, 26)
        Me.TextBoxXParameter.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "x"
        '
        'StartProcessButton
        '
        Me.StartProcessButton.Location = New System.Drawing.Point(43, 126)
        Me.StartProcessButton.Name = "StartProcessButton"
        Me.StartProcessButton.Size = New System.Drawing.Size(182, 38)
        Me.StartProcessButton.TabIndex = 2
        Me.StartProcessButton.Text = "Расчитать"
        Me.StartProcessButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 194)
        Me.Controls.Add(Me.StartProcessButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxXParameter)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxXParameter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents StartProcessButton As Button
End Class
