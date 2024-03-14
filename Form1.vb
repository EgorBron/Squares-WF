Public Class Form1
    Private Sub SolveButton_Click(sender As Object, e As EventArgs) Handles SolveButton.Click
        Dim a = Val(TextBoxA.Text)
        Dim b = Val(TextBoxB.Text)
        Dim c = Val(TextBoxC.Text)
        Dim d = b * b - 4 * a * c
        Dim txt = $"Дискриминант = {d}"
        If d > 0 Then
            Dim x1 = (b + Math.Sqrt(d)) / (2 * a)
            Dim x2 = (b - Math.Sqrt(d)) / (2 * a)
            txt &= vbCrLf & vbCrLf & $"x1={x1}" & vbCrLf & vbCrLf & $"x2={x2}"
        ElseIf d = 0 Then
            txt &= vbCrLf & vbCrLf & $"x={b / (2 * a)}"
        Else
            txt &= vbCrLf & vbCrLf & "Корней нет"
        End If
        ResultLabel.Text = txt
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub
End Class
