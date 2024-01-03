Public Class Form2
    Dim n As Integer

    Private Sub StartProcessButton_Click(sender As Object, e As EventArgs) Handles StartProcessButton.Click
        Dim p As Integer,
            sum As Integer
        p = CInt(TextBoxPParameter.Text)

        For i = 0 To n Step 1
            If i > p Then
                sum += i
            End If
        Next i

        MsgBox("Сумма " + CStr(sum))
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n = 20
    End Sub
End Class