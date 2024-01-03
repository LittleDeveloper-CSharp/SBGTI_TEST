Public Class Form1
    Private Sub StartProcessButton_Click(sender As Object, e As EventArgs) Handles StartProcessButton.Click
        Dim a As Decimal,
            b As Decimal,
            h As Decimal,
            y As Decimal

        a = CDec(TextBoxAParameter.Text)
        b = CDec(TextBoxBParameter.Text)
        h = CDec(TextBoxHParameter.Text)

        XResultList.Items.Clear()
        YResultList.Items.Clear()

        For x = a To b Step h
            If x <= -1 Then
                y = 0
            ElseIf -1 < x And x < 0 Then
                y = 1 + Math.PI
            ElseIf x >= 1 Then
                y = Math.Cos(Math.PI * (x / 2))
            End If

            XResultList.Items.Add(CStr(x))
            YResultList.Items.Add(CStr(y))
        Next x

    End Sub
End Class
