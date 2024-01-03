Public Class Form2
    Private Sub StartProcessButton_Click(sender As Object, e As EventArgs) Handles StartProcessButton.Click
        Dim x As Decimal,
            y As Decimal

        y = 0
        x = CDec(TextBoxXParameter.Text)
        If x <= -1 Then
            y = x * x - 1
        ElseIf Math.Abs(x) <= 1 Then
            y = Math.Cos(Math.PI / (2 * x))
        End If

        MsgBox("Y = " + CStr(y))
    End Sub
End Class