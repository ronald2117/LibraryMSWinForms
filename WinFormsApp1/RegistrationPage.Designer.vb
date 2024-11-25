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
        lblTitle2 = New Label()
        lblTitle1 = New Label()
        Button1 = New Button()
        Label1 = New Label()
        picLogo = New PictureBox()
        Label2 = New Label()
        txtBoxFirstName = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txtBoxMiddleName = New TextBox()
        Label5 = New Label()
        txtBoxLastName = New TextBox()
        Label6 = New Label()
        txtBoxUserName = New TextBox()
        Label7 = New Label()
        txtBoxPassword = New TextBox()
        Label8 = New Label()
        txtBoxConfPass = New TextBox()
        Label9 = New Label()
        btnSubmit = New Button()
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
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(913, 105)
        Panel1.TabIndex = 19
        ' 
        ' lblTitle2
        ' 
        lblTitle2.AutoSize = True
        lblTitle2.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle2.Location = New Point(142, 55)
        lblTitle2.Name = "lblTitle2"
        lblTitle2.Size = New Size(180, 22)
        lblTitle2.TabIndex = 19
        lblTitle2.Text = "Management System"
        ' 
        ' lblTitle1
        ' 
        lblTitle1.AutoSize = True
        lblTitle1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle1.Location = New Point(142, 26)
        lblTitle1.Name = "lblTitle1"
        lblTitle1.Size = New Size(94, 26)
        lblTitle1.TabIndex = 18
        lblTitle1.Text = "Library"
        ' 
        ' Button1
        ' 
        Button1.ForeColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        Button1.Location = New Point(794, 41)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 26)
        Button1.TabIndex = 17
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(418, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(258, 26)
        Label1.TabIndex = 16
        Label1.Text = "Register As A Librarian"
        ' 
        ' picLogo
        ' 
        picLogo.BackgroundImage = CType(resources.GetObject("picLogo.BackgroundImage"), Image)
        picLogo.BackgroundImageLayout = ImageLayout.Stretch
        picLogo.Location = New Point(25, 12)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(106, 82)
        picLogo.TabIndex = 14
        picLogo.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(102, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 17)
        Label2.TabIndex = 2
        ' 
        ' txtBoxFirstName
        ' 
        txtBoxFirstName.Location = New Point(411, 187)
        txtBoxFirstName.Name = "txtBoxFirstName"
        txtBoxFirstName.Size = New Size(260, 25)
        txtBoxFirstName.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 14.25F)
        Label3.Location = New Point(302, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 21)
        Label3.TabIndex = 21
        Label3.Text = "First Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 14.25F)
        Label4.Location = New Point(284, 226)
        Label4.Name = "Label4"
        Label4.RightToLeft = RightToLeft.No
        Label4.Size = New Size(114, 21)
        Label4.TabIndex = 23
        Label4.Text = "Middle Name:"
        ' 
        ' txtBoxMiddleName
        ' 
        txtBoxMiddleName.Location = New Point(411, 223)
        txtBoxMiddleName.Name = "txtBoxMiddleName"
        txtBoxMiddleName.Size = New Size(260, 25)
        txtBoxMiddleName.TabIndex = 22
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 14.25F)
        Label5.Location = New Point(304, 262)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 21)
        Label5.TabIndex = 25
        Label5.Text = "Last Name:"
        ' 
        ' txtBoxLastName
        ' 
        txtBoxLastName.Location = New Point(411, 258)
        txtBoxLastName.Name = "txtBoxLastName"
        txtBoxLastName.Size = New Size(260, 25)
        txtBoxLastName.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 14.25F)
        Label6.Location = New Point(301, 299)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 21)
        Label6.TabIndex = 27
        Label6.Text = "User Name:"
        ' 
        ' txtBoxUserName
        ' 
        txtBoxUserName.Location = New Point(411, 295)
        txtBoxUserName.Name = "txtBoxUserName"
        txtBoxUserName.Size = New Size(260, 25)
        txtBoxUserName.TabIndex = 26
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 14.25F)
        Label7.Location = New Point(310, 334)
        Label7.Name = "Label7"
        Label7.Size = New Size(88, 21)
        Label7.TabIndex = 29
        Label7.Text = "Password:"
        ' 
        ' txtBoxPassword
        ' 
        txtBoxPassword.Location = New Point(411, 331)
        txtBoxPassword.Name = "txtBoxPassword"
        txtBoxPassword.Size = New Size(260, 25)
        txtBoxPassword.TabIndex = 28
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 14.25F)
        Label8.ImageAlign = ContentAlignment.MiddleRight
        Label8.Location = New Point(243, 370)
        Label8.Name = "Label8"
        Label8.RightToLeft = RightToLeft.Yes
        Label8.Size = New Size(155, 21)
        Label8.TabIndex = 31
        Label8.Text = "Confirm Password:"
        ' 
        ' txtBoxConfPass
        ' 
        txtBoxConfPass.Location = New Point(411, 366)
        txtBoxConfPass.Name = "txtBoxConfPass"
        txtBoxConfPass.Size = New Size(260, 25)
        txtBoxConfPass.TabIndex = 30
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(356, 142)
        Label9.Name = "Label9"
        Label9.Size = New Size(202, 23)
        Label9.TabIndex = 32
        Label9.Text = "Enter your information"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(411, 410)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(104, 37)
        btnSubmit.TabIndex = 20
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' RegistrationPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 510)
        Controls.Add(btnSubmit)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(txtBoxConfPass)
        Controls.Add(Label7)
        Controls.Add(txtBoxPassword)
        Controls.Add(Label6)
        Controls.Add(txtBoxUserName)
        Controls.Add(Label5)
        Controls.Add(txtBoxLastName)
        Controls.Add(Label4)
        Controls.Add(txtBoxMiddleName)
        Controls.Add(Label3)
        Controls.Add(txtBoxFirstName)
        Controls.Add(Panel1)
        Font = New Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        Name = "RegistrationPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registration - Library Management System"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents lblTitle1 As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtBoxFirstName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBoxMiddleName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBoxLastName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBoxUserName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBoxPassword As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBoxConfPass As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSubmit As Button
End Class
