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
        txtBoxFirstName = New TextBox()
        Panel1 = New Panel()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Button2 = New Button()
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
        Label1.ForeColor = Color.DarkOrange
        Label1.Location = New Point(54, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 22)
        Label1.TabIndex = 24
        Label1.Text = "Name"
        ' 
        ' txtBoxFirstName
        ' 
        txtBoxFirstName.Location = New Point(141, 40)
        txtBoxFirstName.Name = "txtBoxFirstName"
        txtBoxFirstName.Size = New Size(219, 23)
        txtBoxFirstName.TabIndex = 23
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtBoxFirstName)
        Panel1.Location = New Point(78, 82)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(418, 211)
        Panel1.TabIndex = 25
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkOrange
        Label2.Location = New Point(54, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 22)
        Label2.TabIndex = 26
        Label2.Text = "Author"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(141, 79)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(219, 23)
        TextBox1.TabIndex = 25
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkOrange
        Label4.Location = New Point(54, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 22)
        Label4.TabIndex = 28
        Label4.Text = "Quantity"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(141, 118)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(219, 23)
        TextBox2.TabIndex = 27
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkOrange
        Button2.ForeColor = Color.White
        Button2.Location = New Point(186, 159)
        Button2.Name = "Button2"
        Button2.Size = New Size(92, 37)
        Button2.TabIndex = 31
        Button2.Text = "Submit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' AddBookForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOrange
        ClientSize = New Size(581, 329)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Name = "AddBookForm"
        Text = "Add Book to Inventory"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxFirstName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
End Class
