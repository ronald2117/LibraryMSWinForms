<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        LoginBtn = New Button()
        Password = New TextBox()
        Label2 = New Label()
        Username = New TextBox()
        Label1 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        panelLogin = New Panel()
        PictureBox1 = New PictureBox()
        title2 = New Label()
        panelBkShelves = New Panel()
        panelLibRoom = New Panel()
        LinkLabel2 = New LinkLabel()
        panelLogin.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelLibRoom.SuspendLayout()
        SuspendLayout()
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        LoginBtn.ForeColor = Color.White
        LoginBtn.Location = New Point(143, 286)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(84, 28)
        LoginBtn.TabIndex = 10
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' Password
        ' 
        Password.BackColor = SystemColors.Control
        Password.Location = New Point(134, 259)
        Password.Name = "Password"
        Password.PasswordChar = "*"c
        Password.Size = New Size(118, 21)
        Password.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Window
        Label2.Location = New Point(57, 267)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 8
        Label2.Text = "Password"
        ' 
        ' Username
        ' 
        Username.BackColor = SystemColors.Control
        Username.Location = New Point(134, 220)
        Username.Name = "Username"
        Username.Size = New Size(118, 21)
        Username.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Window
        Label1.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(57, 228)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 14)
        Label1.TabIndex = 6
        Label1.Text = "Username"
        ' 
        ' panelLogin
        ' 
        panelLogin.BackColor = SystemColors.Window
        panelLogin.BorderStyle = BorderStyle.FixedSingle
        panelLogin.Controls.Add(LinkLabel2)
        panelLogin.Controls.Add(PictureBox1)
        panelLogin.Controls.Add(title2)
        panelLogin.Controls.Add(Username)
        panelLogin.Controls.Add(LoginBtn)
        panelLogin.Controls.Add(Label1)
        panelLogin.Controls.Add(Password)
        panelLogin.Controls.Add(Label2)
        panelLogin.Location = New Point(377, 50)
        panelLogin.Name = "panelLogin"
        panelLogin.Size = New Size(311, 350)
        panelLogin.TabIndex = 11
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(103, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(124, 97)
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' title2
        ' 
        title2.AutoSize = True
        title2.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        title2.Location = New Point(45, 157)
        title2.Name = "title2"
        title2.Size = New Size(247, 22)
        title2.TabIndex = 12
        title2.Text = "Library Management System"
        ' 
        ' panelBkShelves
        ' 
        panelBkShelves.BackgroundImage = My.Resources.Resources.shelves
        panelBkShelves.BackgroundImageLayout = ImageLayout.Stretch
        panelBkShelves.Location = New Point(325, 0)
        panelBkShelves.Name = "panelBkShelves"
        panelBkShelves.Size = New Size(365, 242)
        panelBkShelves.TabIndex = 12
        ' 
        ' panelLibRoom
        ' 
        panelLibRoom.BackgroundImage = My.Resources.Resources.library_room
        panelLibRoom.BackgroundImageLayout = ImageLayout.Stretch
        panelLibRoom.Controls.Add(panelBkShelves)
        panelLibRoom.Location = New Point(112, 50)
        panelLibRoom.Name = "panelLibRoom"
        panelLibRoom.Size = New Size(268, 350)
        panelLibRoom.TabIndex = 13
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.LinkColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        LinkLabel2.Location = New Point(162, 317)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(48, 15)
        LinkLabel2.TabIndex = 14
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Sign up"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(panelLibRoom)
        Controls.Add(panelLogin)
        Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login - Library Management System"
        panelLogin.ResumeLayout(False)
        panelLogin.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelLibRoom.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents LoginBtn As Button
    Friend WithEvents Password As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents panelLogin As Panel
    Friend WithEvents title2 As Label
    Friend WithEvents panelBkShelves As Panel
    Friend WithEvents panelLibRoom As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel

End Class
