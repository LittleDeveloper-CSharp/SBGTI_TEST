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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StartProcessButton = New System.Windows.Forms.Button()
        Me.TextBoxAParameter = New System.Windows.Forms.TextBox()
        Me.TextBoxBParameter = New System.Windows.Forms.TextBox()
        Me.TextBoxHParameter = New System.Windows.Forms.TextBox()
        Me.XResultList = New System.Windows.Forms.ListBox()
        Me.YResultList = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "a"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "b"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "h"
        '
        'StartProcessButton
        '
        Me.StartProcessButton.Location = New System.Drawing.Point(31, 152)
        Me.StartProcessButton.Name = "StartProcessButton"
        Me.StartProcessButton.Size = New System.Drawing.Size(142, 23)
        Me.StartProcessButton.TabIndex = 3
        Me.StartProcessButton.Text = "Решение"
        Me.StartProcessButton.UseVisualStyleBackColor = True
        '
        'TextBoxAParameter
        '
        Me.TextBoxAParameter.Location = New System.Drawing.Point(73, 27)
        Me.TextBoxAParameter.Name = "TextBoxAParameter"
        Me.TextBoxAParameter.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAParameter.TabIndex = 4
        '
        'TextBoxBParameter
        '
        Me.TextBoxBParameter.Location = New System.Drawing.Point(73, 59)
        Me.TextBoxBParameter.Name = "TextBoxBParameter"
        Me.TextBoxBParameter.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBParameter.TabIndex = 5
        '
        'TextBoxHParameter
        '
        Me.TextBoxHParameter.Location = New System.Drawing.Point(73, 93)
        Me.TextBoxHParameter.Name = "TextBoxHParameter"
        Me.TextBoxHParameter.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHParameter.TabIndex = 6
        '
        'XResultList
        '
        Me.XResultList.FormattingEnabled = True
        Me.XResultList.Location = New System.Drawing.Point(279, 27)
        Me.XResultList.Name = "XResultList"
        Me.XResultList.Size = New System.Drawing.Size(120, 290)
        Me.XResultList.TabIndex = 7
        '
        'YResultList
        '
        Me.YResultList.FormattingEnabled = True
        Me.YResultList.Location = New System.Drawing.Point(512, 30)
        Me.YResultList.Name = "YResultList"
        Me.YResultList.Size = New System.Drawing.Size(120, 290)
        Me.YResultList.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "x"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(494, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "y"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 450)
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
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents StartProcessButton As Button
    Friend WithEvents TextBoxAParameter As TextBox
    Friend WithEvents TextBoxBParameter As TextBox
    Friend WithEvents TextBoxHParameter As TextBox
    Friend WithEvents XResultList As ListBox
    Friend WithEvents YResultList As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
