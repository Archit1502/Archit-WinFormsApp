Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Execute button1's click event
            viewbutton.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Execute button2's click event
            createbutton.PerformClick()
        End If
    End Sub
End Class
