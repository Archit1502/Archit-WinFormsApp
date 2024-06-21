Imports System.Net.Http
Imports Newtonsoft.Json
Public Class Form4

    Private Async Sub btnSearchEmail_Click(sender As Object, e As EventArgs) Handles btnSearchEmail.Click
        Dim client As New HttpClient()
        Dim baseUrl As String = "http://localhost:3000" ' Replace with your server URL
        Dim email As String = txtEmail.Text.Trim()

        Try
            Dim response = Await client.GetAsync($"{baseUrl}/api/search?email={Uri.EscapeDataString(email)}")

            If response.IsSuccessStatusCode Then
                Dim jsonResult As String = Await response.Content.ReadAsStringAsync()
                Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(jsonResult)

                If submission IsNot Nothing Then
                    MessageBox.Show($"Email found! Data: {Environment.NewLine}Name: {submission.Name}{Environment.NewLine}MAIL: {submission.Email}{Environment.NewLine}Number: {submission.Number}{Environment.NewLine}Link: {submission.Link}{Environment.NewLine}Time: {submission.Time}{Environment.NewLine}", "Email Found")
                Else
                    MessageBox.Show("Email not found.", "Email Not Found")
                End If
            Else
                Dim errorMessage As String = $"Error: {response.StatusCode} - {response.ReasonPhrase}"
                MessageBox.Show(errorMessage, "Server Error")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error")
        Finally
            client.Dispose()
        End Try
    End Sub


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class