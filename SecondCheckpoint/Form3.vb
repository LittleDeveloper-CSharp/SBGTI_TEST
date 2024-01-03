Public Class Form3
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
        Do
            If x <= -Math.PI / 2 Then
                y = 0
            ElseIf -Math.PI / 2 <= x And x <= 0 Then
                y = Math.Cos(x)
            ElseIf x > 0 Then
                y = 1
            End If

            XResultList.Items.Add(CStr(x))
            YResultList.Items.Add(CStr(y))

            x += h
        Loop While x <= b
    End Sub
End Class