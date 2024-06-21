<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtEmail = New TextBox()
        btnSearchEmail = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(69, 175)
        Label1.Name = "Label1"
        Label1.Size = New Size(270, 31)
        Label1.TabIndex = 0
        Label1.Text = "Enter the Email to search"
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Location = New Point(362, 179)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(365, 27)
        txtEmail.TabIndex = 1
        ' 
        ' btnSearchEmail
        ' 
        btnSearchEmail.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnSearchEmail.Location = New Point(267, 294)
        btnSearchEmail.Name = "btnSearchEmail"
        btnSearchEmail.Size = New Size(235, 64)
        btnSearchEmail.TabIndex = 2
        btnSearchEmail.Text = "Search For Data"
        btnSearchEmail.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSearchEmail)
        Controls.Add(txtEmail)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnSearchEmail As Button
End Class
