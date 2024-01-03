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
        Me.TextBoxA = New System.Windows.Forms.TextBox()
        Me.TextBoxB = New System.Windows.Forms.TextBox()
        Me.StartProcessButton = New System.Windows.Forms.Button()
        Me.LabelAElement = New System.Windows.Forms.Label()
        Me.BLabelElement = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxA
        '
        Me.TextBoxA.Location = New System.Drawing.Point(176, 78)
        Me.TextBoxA.Name = "TextBoxA"
        Me.TextBoxA.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxA.TabIndex = 0
        '
        'TextBoxB
        '
        Me.TextBoxB.Location = New System.Drawing.Point(176, 129)
        Me.TextBoxB.Name = "TextBoxB"
        Me.TextBoxB.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxB.TabIndex = 1
        '
        'StartProcessButton
        '
        Me.StartProcessButton.Location = New System.Drawing.Point(134, 230)
        Me.StartProcessButton.Name = "StartProcessButton"
        Me.StartProcessButton.Size = New System.Drawing.Size(142, 23)
        Me.StartProcessButton.TabIndex = 2
        Me.StartProcessButton.Text = "Ответ"
        Me.StartProcessButton.UseVisualStyleBackColor = True
        '
        'LabelAElement
        '
        Me.LabelAElement.AutoSize = True
        Me.LabelAElement.Location = New System.Drawing.Point(131, 81)
        Me.LabelAElement.Name = "LabelAElement"
        Me.LabelAElement.Size = New System.Drawing.Size(14, 13)
        Me.LabelAElement.TabIndex = 3
        Me.LabelAElement.Text = "A"
        '
        'BLabelElement
        '
        Me.BLabelElement.AutoSize = True
        Me.BLabelElement.Location = New System.Drawing.Point(131, 132)
        Me.BLabelElement.Name = "BLabelElement"
        Me.BLabelElement.Size = New System.Drawing.Size(14, 13)
        Me.BLabelElement.TabIndex = 4
        Me.BLabelElement.Text = "B"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 301)
        Me.Controls.Add(Me.BLabelElement)
        Me.Controls.Add(Me.LabelAElement)
        Me.Controls.Add(Me.StartProcessButton)
        Me.Controls.Add(Me.TextBoxB)
        Me.Controls.Add(Me.TextBoxA)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxA As TextBox
    Friend WithEvents TextBoxB As TextBox
    Friend WithEvents StartProcessButton As Button
    Friend WithEvents LabelAElement As Label
    Friend WithEvents BLabelElement As Label
End Class
