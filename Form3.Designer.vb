<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Textlink = New TextBox()
        Textno = New TextBox()
        labellink = New Label()
        labelno = New Label()
        labelmail = New Label()
        labelname = New Label()
        Label1 = New Label()
        lblTime = New Label()
        btnToggle = New Button()
        submit = New Button()
        Textmail = New TextBox()
        Textname = New TextBox()
        SuspendLayout()
        ' 
        ' Textlink
        ' 
        Textlink.Location = New Point(391, 307)
        Textlink.Name = "Textlink"
        Textlink.Size = New Size(298, 27)
        Textlink.TabIndex = 16
        ' 
        ' Textno
        ' 
        Textno.Location = New Point(391, 250)
        Textno.Name = "Textno"
        Textno.Size = New Size(298, 27)
        Textno.TabIndex = 15
        ' 
        ' labellink
        ' 
        labellink.AutoSize = True
        labellink.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        labellink.Location = New Point(159, 309)
        labellink.Name = "labellink"
        labellink.Size = New Size(179, 25)
        labellink.TabIndex = 13
        labellink.Text = "Github Link For Task"
        ' 
        ' labelno
        ' 
        labelno.AutoSize = True
        labelno.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        labelno.Location = New Point(201, 252)
        labelno.Name = "labelno"
        labelno.Size = New Size(95, 25)
        labelno.TabIndex = 12
        labelno.Text = "Phone No"
        ' 
        ' labelmail
        ' 
        labelmail.AutoSize = True
        labelmail.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        labelmail.Location = New Point(214, 195)
        labelmail.Name = "labelmail"
        labelmail.Size = New Size(69, 25)
        labelmail.TabIndex = 11
        labelmail.Text = "E MAIL"
        ' 
        ' labelname
        ' 
        labelname.AutoSize = True
        labelname.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        labelname.Location = New Point(216, 138)
        labelname.Name = "labelname"
        labelname.Size = New Size(64, 25)
        labelname.TabIndex = 10
        labelname.Text = "NAME"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.Location = New Point(159, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(508, 32)
        Label1.TabIndex = 9
        Label1.Text = "Archit Agrawal, Slidely - Create Submission"
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.BorderStyle = BorderStyle.FixedSingle
        lblTime.Location = New Point(467, 396)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(65, 22)
        lblTime.TabIndex = 18
        lblTime.Text = "00:00:00"
        ' 
        ' btnToggle
        ' 
        btnToggle.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnToggle.Location = New Point(190, 389)
        btnToggle.Name = "btnToggle"
        btnToggle.Size = New Size(215, 36)
        btnToggle.TabIndex = 19
        btnToggle.Text = "Toggle Stopwatch (Ctrl+T)"
        btnToggle.UseVisualStyleBackColor = False
        ' 
        ' submit
        ' 
        submit.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        submit.Font = New Font("Segoe UI", 13F)
        submit.Location = New Point(217, 473)
        submit.Name = "submit"
        submit.Size = New Size(332, 46)
        submit.TabIndex = 20
        submit.Text = "SUBMIT (Ctrl+S)"
        submit.UseVisualStyleBackColor = False
        ' 
        ' Textmail
        ' 
        Textmail.Location = New Point(391, 193)
        Textmail.Name = "Textmail"
        Textmail.Size = New Size(298, 27)
        Textmail.TabIndex = 17
        ' 
        ' Textname
        ' 
        Textname.Location = New Point(391, 136)
        Textname.Name = "Textname"
        Textname.Size = New Size(298, 27)
        Textname.TabIndex = 14
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 564)
        Controls.Add(submit)
        Controls.Add(btnToggle)
        Controls.Add(lblTime)
        Controls.Add(Textmail)
        Controls.Add(Textlink)
        Controls.Add(Textno)
        Controls.Add(Textname)
        Controls.Add(labellink)
        Controls.Add(labelno)
        Controls.Add(labelmail)
        Controls.Add(labelname)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Textlink As TextBox
    Friend WithEvents Textno As TextBox
    Friend WithEvents labellink As Label
    Friend WithEvents labelno As Label
    Friend WithEvents labelmail As Label
    Friend WithEvents labelname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents btnToggle As Button
    Friend WithEvents submit As Button
    Friend WithEvents Textmail As TextBox
    Friend WithEvents Textname As TextBox
End Class
