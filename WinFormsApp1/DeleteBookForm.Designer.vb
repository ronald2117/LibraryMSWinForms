<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteBookForm
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
        btnCancel = New Button()
        Panel1 = New Panel()
        Label5 = New Label()
        btnSubmit = New Button()
        txtBoxId = New TextBox()
        Label3 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCancel
        ' 
        btnCancel.ForeColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        btnCancel.Location = New Point(372, 30)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(86, 26)
        btnCancel.TabIndex = 30
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(btnSubmit)
        Panel1.Controls.Add(txtBoxId)
        Panel1.Location = New Point(108, 80)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(261, 156)
        Panel1.TabIndex = 28
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        Label5.Location = New Point(34, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 22)
        Label5.TabIndex = 29
        Label5.Text = "ID"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(81, 94)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(92, 37)
        btnSubmit.TabIndex = 4
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' txtBoxId
        ' 
        txtBoxId.Location = New Point(81, 46)
        txtBoxId.Name = "txtBoxId"
        txtBoxId.Size = New Size(149, 23)
        txtBoxId.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(31, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(162, 26)
        Label3.TabIndex = 29
        Label3.Text = "Enter Book ID"
        ' 
        ' DeleteBookForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        ClientSize = New Size(484, 273)
        Controls.Add(btnCancel)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Name = "DeleteBookForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Delete a book"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtBoxId As TextBox
    Friend WithEvents Label3 As Label
End Class
