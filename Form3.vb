Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text
Public Class Form3




    Private stopwatch As New Stopwatch()
    Private isRunning As Boolean = False
    Private lastElapsedTime As TimeSpan = TimeSpan.Zero
    Private WithEvents Timer1 As New Timer()


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim currentTime As TimeSpan
        If isRunning Then
            currentTime = stopwatch.Elapsed
        Else
            currentTime = lastElapsedTime
        End If
        lblTime.Text = currentTime.ToString("hh\:mm\:ss")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        If Not isRunning Then
            ' Start the Stopwatch
            stopwatch.Start()
            Timer1.Start() ' Start updating the time display
            btnToggle.Text = "Pause"
            isRunning = True
        Else
            ' Pause the Stopwatch
            stopwatch.Stop()
            Timer1.Stop() ' Stop updating the time display
            lastElapsedTime = stopwatch.Elapsed
            btnToggle.Text = "Resume"
            isRunning = False
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblTime.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Async Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        ' Create an instance of HttpClient
        Dim client As New HttpClient()

        ' URL of your Express server endpoint to submit data
        Dim uri As String = "http://localhost:3000/api/submit"

        Try
            ' Prepare data to be sent as JSON
            Dim submissionData As New With {
                .name = Textname.Text,
                .email = Textmail.Text,
                .number = Textno.Text,
                .link = Textlink.Text,
                .Time = lblTime.Text
            }

            Dim json As String = JsonConvert.SerializeObject(submissionData)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            ' Make POST request to submit data
            Dim response As HttpResponseMessage = Await client.PostAsync(uri, content)

            ' Check if request was successful
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful")
            Else
                MessageBox.Show("Error submitting data: " & response.StatusCode)
            End If
        Catch ex As Exception
            MessageBox.Show("Error submitting data: " & ex.Message)
        Finally
            ' Dispose of HttpClient to release resources
            client.Dispose()
        End Try
    End Sub

    Private Sub Textname_TextChanged(sender As Object, e As EventArgs) Handles Textname.TextChanged

    End Sub

    Private Sub Textname_KeyDown(sender As Object, e As KeyEventArgs) Handles Textname.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Execute button1's click event
            submit.PerformClick()
        End If
    End Sub

    Private Sub Textmail_TextChanged(sender As Object, e As EventArgs) Handles Textmail.TextChanged

    End Sub


    Private Sub Textno_TextChanged(sender As Object, e As EventArgs) Handles Textno.TextChanged

    End Sub

    Private Sub Textno_KeyDown(sender As Object, e As KeyEventArgs) Handles Textno.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Execute button1's click event
            submit.PerformClick()
        End If
    End Sub

    Private Sub Textmail_KeyDown(sender As Object, e As KeyEventArgs) Handles Textmail.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Execute button1's click event
            submit.PerformClick()
        End If
    End Sub

    Private Sub Textlink_TextChanged(sender As Object, e As EventArgs) Handles Textlink.TextChanged

    End Sub


    Private Sub btnToggle_KeyDown(sender As Object, e As KeyEventArgs) Handles btnToggle.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Execute button1's click event
            submit.PerformClick()
        End If
    End Sub

    Private Sub submit_KeyDown(sender As Object, e As KeyEventArgs) Handles submit.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Execute button1's click event
            submit.PerformClick()
        End If
    End Sub

    Private Sub Textlink_KeyDown(sender As Object, e As KeyEventArgs) Handles Textlink.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Execute button1's click event
            submit.PerformClick()
        End If
    End Sub
End Class