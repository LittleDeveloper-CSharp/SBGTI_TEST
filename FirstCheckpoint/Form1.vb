Public Class Form1
    Dim a As Decimal,
        b As Decimal,
        x As Decimal,
        y As Decimal,
        p As Decimal

    Private Sub StartProcessButton_Click(sender As Object, e As EventArgs) Handles StartProcessButton.Click
        Dim k As Decimal,
            z As Decimal,
            i As Decimal,
            u As Decimal,
            f As Decimal

        a = CDec(TextBoxA.Text)
        b = CDec(TextBoxB.Text)

        k = Math.Cos(x - p / a) ^ 2
        z = y ^ 2 + x * y + x ^ 2
        i = a ^ 2 + b ^ 2
        u = z / i * k
        f = Math.Sin(x - p / a) ^ 2 + u

        MsgBox("F = " + CStr(f))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        x = CDec(InputBox("Введите X"))
        y = CDec(InputBox("Введите Y"))
        p = CDec(InputBox("Введите P"))
    End Sub
End Class
