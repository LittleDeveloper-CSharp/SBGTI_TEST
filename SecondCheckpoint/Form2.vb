Public Class Form2
    Private Sub StartProcessButton_Click(sender As Object, e As EventArgs) Handles StartProcessButton.Click
        Dim a As Decimal,
            b As Decimal,
            h As Decimal,
            y As Decimal,
            x As Decimal

        a = CDec(TextBoxAParameter.Text)
        b = CDec(TextBoxBParameter.Text)
        h = CDec(TextBoxHParameter.Text)

        XResultList.Items.Clear()
        YResultList.Items.Clear()

        x = a
        Do While x <= b
            If x <= 0 Then
                y = Math.Exp(-x)
            ElseIf 0 <= x And x <= 1 Then
                y = Math.Cos(x * (Math.PI / 2))
            ElseIf x >= 1 Then
                y = 0
            End If

            XResultList.Items.Add(CStr(x))
            YResultList.Items.Add(CStr(y))

            x += h
        Loop
    End Sub
End Class