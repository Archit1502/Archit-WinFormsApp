Imports System.Net.Http
Imports Newtonsoft.Json

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        viewbutton = New Button()
        Label1 = New Label()
        createbutton = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' viewbutton
        ' 
        viewbutton.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        viewbutton.Font = New Font("Segoe UI", 11F)
        viewbutton.ForeColor = Color.Black
        viewbutton.Location = New Point(225, 171)
        viewbutton.Name = "viewbutton"
        viewbutton.Size = New Size(323, 54)
        viewbutton.TabIndex = 0
        viewbutton.Text = "View Submissions (Ctrl+V)"
        viewbutton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Copperplate Gothic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(95, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(650, 31)
        Label1.TabIndex = 1
        Label1.Text = "Archit Agrawal, Slidely Task - Form App"
        ' 
        ' createbutton
        ' 
        createbutton.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        createbutton.Font = New Font("Segoe UI", 11F)
        createbutton.Location = New Point(225, 256)
        createbutton.Name = "createbutton"
        createbutton.Size = New Size(323, 54)
        createbutton.TabIndex = 2
        createbutton.Text = "Create New Submission (Ctrl+N)"
        createbutton.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button1.Font = New Font("Segoe UI", 11F)
        Button1.Location = New Point(225, 337)
        Button1.Name = "Button1"
        Button1.Size = New Size(323, 52)
        Button1.TabIndex = 3
        Button1.Text = "Search Data"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(820, 428)
        Controls.Add(Button1)
        Controls.Add(createbutton)
        Controls.Add(Label1)
        Controls.Add(viewbutton)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents viewbutton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents createbutton As Button

    Private Sub createbutton_Click(sender As Object, e As EventArgs) Handles createbutton.Click
        Form3.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub viewbutton_Click(sender As Object, e As EventArgs) Handles viewbutton.Click
        Dim form2 As New Form2()
        form2.Show()

        ' Retrieve submissions from server and pass them to Form2
        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = client.GetAsync("http://localhost:3000/api/submissions").Result
                response.EnsureSuccessStatusCode() ' Ensure success status code

                Dim submissions As List(Of Submission) = JsonConvert.DeserializeObject(Of List(Of Submission))(response.Content.ReadAsStringAsync().Result)
                form2.SetSubmissions(submissions) ' Pass submissions to Form2
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving submissions: " & ex.Message)
        End Try
    End Sub

    Private Sub viewbutton_KeyDown(sender As Object, e As KeyEventArgs) Handles viewbutton.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Execute button1's click event
            viewbutton.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Execute button2's click event
            createbutton.PerformClick()
        End If
    End Sub

    Private Sub createbutton_KeyDown(sender As Object, e As KeyEventArgs) Handles createbutton.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            ' Execute button1's click event
            createbutton.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.V Then
            ' Execute button2's click event
            viewbutton.PerformClick()
        End If
    End Sub

    Friend WithEvents Button1 As Button
End Class

' Private Sub viewbutton_KeyDown(sender As Object, e As KeyEventArgs) Handles viewbutton.KeyDown
'    If e.Control AndAlso e.KeyCode = Keys.V Then
'       ' Execute button1's click event programmatically
'        Form2.Show()
'    End If
'End Sub

'Private Sub createbutton_KeyDown(sender As Object, e As KeyEventArgs) Handles createbutton.KeyDown
'If e.Control AndAlso e.KeyCode = Keys.N Then
' Execute button1's click event programmatically
'createbutton.PerformClick()
'End If
'End Sub
'End Class
