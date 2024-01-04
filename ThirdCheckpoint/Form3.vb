Public Class Form3
    Private Sub PrintArray(array As Integer(,), arrayDimension As Integer)
        Dim msg As String = ""

        For i = 0 To arrayDimension Step 1
            For j = 0 To arrayDimension Step 1
                msg += " " + CStr(array(i, j))
            Next j

            msg += Environment.NewLine
        Next i

        MsgBox(msg)
    End Sub

    Private Function GetSwapArray(sourceArray As Integer(,), arrayDimension As Integer) As Integer(,)
        Dim swapArray(arrayDimension, arrayDimension) As Integer

        For i = 0 To arrayDimension Step 1
            For j = 0 To arrayDimension Step 1
                swapArray(i, j) = sourceArray(j, i)
            Next j
        Next i

        Return swapArray
    End Function

    Private Function GetSourceArray(arrayDimension) As Integer(,)
        Dim sourceArray(arrayDimension, arrayDimension) As Integer

        For i = 0 To arrayDimension Step 1
            For j = 0 To arrayDimension Step 1
                sourceArray(i, j) = Int((6 * Rnd()) + 1)
            Next j
        Next i

        Return sourceArray
    End Function

    Private Sub StartProcessButton_Click(sender As Object, e As EventArgs) Handles StartProcessButton.Click
        Dim arrayDimension As Integer
        arrayDimension = CInt(TextBoxDimensionParameter.Text) - 1

        Dim sourceArray As Integer(,) = GetSourceArray(arrayDimension)
        MsgBox("Исходная матрица")
        PrintArray(sourceArray, arrayDimension)

        Dim swapArray As Integer(,) = GetSwapArray(sourceArray, arrayDimension)
        MsgBox("Измененная матрица")
        PrintArray(swapArray, arrayDimension)
    End Sub
End Class