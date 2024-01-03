Public Class Form1
    Dim n As Integer

    Private Sub StartProcessButton_Click(sender As Object, e As EventArgs) Handles StartProcessButton.Click
        Dim s As Decimal,
            x As Decimal,
            k As Integer,
            factorialValue As Integer

        x = CDec(TextBoxXParameter.Text)
        For k = 1 To n Step 1
            factorialValue = Factorial(k)
            s += Math.Sin(x) / factorialValue
        Next k

        MsgBox("S = " + CStr(s))
    End Sub

    Private Function Factorial(maxValue As Integer) As Integer
        If maxValue = 1 Then
            Return maxValue
        End If

        Return Factorial(maxValue - 1) * maxValue
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n = 10
        TextBoxXParameter.Text = Math.PI / 4
    End Sub
End Class
