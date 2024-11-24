<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationPage))
        Panel1 = New Panel()
        Button1 = New Button()
        Label1 = New Label()
        picLogo = New PictureBox()
        Label2 = New Label()
        lblTitle2 = New Label()
        lblTitle1 = New Label()
        Panel1.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        Panel1.Controls.Add(lblTitle2)
        Panel1.Controls.Add(lblTitle1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(picLogo)
        Panel1.Controls.Add(Label2)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(1, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(913, 124)
        Panel1.TabIndex = 19
        ' 
        ' Button1
        ' 
        Button1.ForeColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        Button1.Location = New Point(794, 48)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 31)
        Button1.TabIndex = 17
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(418, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(258, 26)
        Label1.TabIndex = 16
        Label1.Text = "Register As A Librarian"
        ' 
        ' picLogo
        ' 
        picLogo.BackgroundImage = CType(resources.GetObject("picLogo.BackgroundImage"), Image)
        picLogo.BackgroundImageLayout = ImageLayout.Stretch
        picLogo.Location = New Point(25, 14)
        picLogo.Margin = New Padding(3, 4, 3, 4)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(106, 97)
        picLogo.TabIndex = 14
        picLogo.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(102, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 2
        ' 
        ' lblTitle2
        ' 
        lblTitle2.AutoSize = True
        lblTitle2.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle2.Location = New Point(142, 65)
        lblTitle2.Name = "lblTitle2"
        lblTitle2.Size = New Size(180, 22)
        lblTitle2.TabIndex = 19
        lblTitle2.Text = "Management System"
        ' 
        ' lblTitle1
        ' 
        lblTitle1.AutoSize = True
        lblTitle1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle1.Location = New Point(142, 30)
        lblTitle1.Name = "lblTitle1"
        lblTitle1.Size = New Size(94, 26)
        lblTitle1.TabIndex = 18
        lblTitle1.Text = "Library"
        ' 
        ' RegistrationPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 11F)
        Margin = New Padding(3, 4, 3, 4)
        Name = "RegistrationPage"
        Text = "Registration - Library Management System"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents lblTitle1 As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
