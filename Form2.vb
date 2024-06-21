Public Class Form2


    Private submissions As List(Of Submission)
    Private currentIndex As Integer

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub
    ' Method to set submissions
    Public Sub SetSubmissions(subs As List(Of Submission))
        submissions = subs
        currentIndex = 0
        DisplayCurrentSubmission()
    End Sub
    ' Method to display current submission
    Private Sub DisplayCurrentSubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 AndAlso currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim currentSubmission As Submission = submissions(currentIndex)
            Label7.Text = currentSubmission.Name
            Label8.Text = currentSubmission.Email
            Label9.Text = currentSubmission.Number
            Label10.Text = currentSubmission.Link
            Label11.Text = currentSubmission.Time
        End If
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplayCurrentSubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplayCurrentSubmission()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If submissions IsNot Nothing AndAlso currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            ' Remove the current submission from the list
            submissions.RemoveAt(currentIndex)

            ' Adjust currentIndex if it goes out of bounds
            If currentIndex >= submissions.Count Then
                currentIndex = submissions.Count - 1
            End If

            ' Display the updated current submission or clear if no submissions left
            DisplayCurrentSubmission()
        End If
    End Sub

    Private Sub btnPrevious_KeyDown(sender As Object, e As KeyEventArgs) Handles btnPrevious.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ' Execute button1's click event
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Execute button2's click event
            btnNext.PerformClick()
        End If
    End Sub

    Private Sub btnNext_KeyDown(sender As Object, e As KeyEventArgs) Handles btnNext.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ' Execute button1's click event
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Execute button2's click event
            btnNext.PerformClick()
        End If
    End Sub

    Private Sub Label7_TextChanged(sender As Object, e As EventArgs) Handles Label7.TextChanged

    End Sub

    Private Sub Label7_KeyDown(sender As Object, e As KeyEventArgs) Handles Label7.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ' Execute button1's click event
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Execute button2's click event
            btnNext.PerformClick()
        End If
    End Sub

    Private Sub Label8_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ' Execute button1's click event
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Execute button2's click event
            btnNext.PerformClick()
        End If
    End Sub

    Private Sub Label9_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ' Execute button1's click event
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Execute button2's click event
            btnNext.PerformClick()
        End If
    End Sub

    Private Sub Label10_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ' Execute button1's click event
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Execute button2's click event
            btnNext.PerformClick()
        End If
    End Sub

    Private Sub Label11_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ' Execute button1's click event
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Execute button2's click event
            btnNext.PerformClick()
        End If
    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ' Execute button1's click event
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Execute button2's click event
            btnNext.PerformClick()
        End If
    End Sub
End Class