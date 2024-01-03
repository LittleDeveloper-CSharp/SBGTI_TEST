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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.YResultList = New System.Windows.Forms.ListBox()
        Me.XResultList = New System.Windows.Forms.ListBox()
        Me.TextBoxHParameter = New System.Windows.Forms.TextBox()
        Me.TextBoxBParameter = New System.Windows.Forms.TextBox()
        Me.TextBoxAParameter = New System.Windows.Forms.TextBox()
        Me.StartProcessButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(482, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "y"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "x"
        '
        'YResultList
        '
        Me.YResultList.FormattingEnabled = True
        Me.YResultList.Location = New System.Drawing.Point(500, 15)
        Me.YResultList.Name = "YResultList"
        Me.YResultList.Size = New System.Drawing.Size(120, 290)
        Me.YResultList.TabIndex = 19
        '
        'XResultList
        '
        Me.XResultList.FormattingEnabled = True
        Me.XResultList.Location = New System.Drawing.Point(267, 12)
        Me.XResultList.Name = "XResultList"
        Me.XResultList.Size = New System.Drawing.Size(120, 290)
        Me.XResultList.TabIndex = 18
        '
        'TextBoxHParameter
        '
        Me.TextBoxHParameter.Location = New System.Drawing.Point(61, 78)
        Me.TextBoxHParameter.Name = "TextBoxHParameter"
        Me.TextBoxHParameter.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHParameter.TabIndex = 17
        '
        'TextBoxBParameter
        '
        Me.TextBoxBParameter.Location = New System.Drawing.Point(61, 44)
        Me.TextBoxBParameter.Name = "TextBoxBParameter"
        Me.TextBoxBParameter.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBParameter.TabIndex = 16
        '
        'TextBoxAParameter
        '
        Me.TextBoxAParameter.Location = New System.Drawing.Point(61, 12)
        Me.TextBoxAParameter.Name = "TextBoxAParameter"
        Me.TextBoxAParameter.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAParameter.TabIndex = 15
        '
        'StartProcessButton
        '
        Me.StartProcessButton.Location = New System.Drawing.Point(19, 137)
        Me.StartProcessButton.Name = "StartProcessButton"
        Me.StartProcessButton.Size = New System.Drawing.Size(142, 23)
        Me.StartProcessButton.TabIndex = 14
        Me.StartProcessButton.Text = "Решение"
        Me.StartProcessButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "h"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "b"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "a"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 354)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.YResultList)
        Me.Controls.Add(Me.XResultList)
        Me.Controls.Add(Me.TextBoxHParameter)
        Me.Controls.Add(Me.TextBoxBParameter)
        Me.Controls.Add(Me.TextBoxAParameter)
        Me.Controls.Add(Me.StartProcessButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents YResultList As ListBox
    Friend WithEvents XResultList As ListBox
    Friend WithEvents TextBoxHParameter As TextBox
    Friend WithEvents TextBoxBParameter As TextBox
    Friend WithEvents TextBoxAParameter As TextBox
    Friend WithEvents StartProcessButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
