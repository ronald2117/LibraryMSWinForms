<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBookForm
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
        Label3 = New Label()
        Label1 = New Label()
        txtBoxTitle = New TextBox()
        Panel1 = New Panel()
        btnSubmit = New Button()
        Label4 = New Label()
        txtBoxQuantity = New TextBox()
        Label2 = New Label()
        txtBoxAuthor = New TextBox()
        btnCancel = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(27, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(207, 26)
        Label3.TabIndex = 22
        Label3.Text = "Enter Book Details"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        Label1.Location = New Point(54, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 22)
        Label1.TabIndex = 24
        Label1.Text = "Title"
        ' 
        ' txtBoxTitle
        ' 
        txtBoxTitle.Location = New Point(141, 40)
        txtBoxTitle.Name = "txtBoxTitle"
        txtBoxTitle.Size = New Size(219, 23)
        txtBoxTitle.TabIndex = 23
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(btnSubmit)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtBoxQuantity)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtBoxAuthor)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtBoxTitle)
        Panel1.Location = New Point(78, 78)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(423, 215)
        Panel1.TabIndex = 25
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(177, 159)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(92, 37)
        btnSubmit.TabIndex = 31
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        Label4.Location = New Point(54, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 22)
        Label4.TabIndex = 28
        Label4.Text = "Quantity"
        ' 
        ' txtBoxQuantity
        ' 
        txtBoxQuantity.Location = New Point(141, 118)
        txtBoxQuantity.Name = "txtBoxQuantity"
        txtBoxQuantity.Size = New Size(219, 23)
        txtBoxQuantity.TabIndex = 27
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        Label2.Location = New Point(54, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 22)
        Label2.TabIndex = 26
        Label2.Text = "Author"
        ' 
        ' txtBoxAuthor
        ' 
        txtBoxAuthor.Location = New Point(141, 79)
        txtBoxAuthor.Name = "txtBoxAuthor"
        txtBoxAuthor.Size = New Size(219, 23)
        txtBoxAuthor.TabIndex = 25
        ' 
        ' btnCancel
        ' 
        btnCancel.ForeColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        btnCancel.Location = New Point(460, 32)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(86, 26)
        btnCancel.TabIndex = 26
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' AddBookForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        ClientSize = New Size(581, 329)
        Controls.Add(btnCancel)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Name = "AddBookForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Book to Inventory"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxTitle As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBoxQuantity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBoxAuthor As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
End Class
