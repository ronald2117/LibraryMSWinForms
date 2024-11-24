<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Label2 = New Label()
        lblTitle1 = New Label()
        picLogo = New PictureBox()
        lblTitle2 = New Label()
        LinkLabel1 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        Panel1 = New Panel()
        Label1 = New Label()
        btnLogout = New Button()
        LinkLabel4 = New LinkLabel()
        LinkLabel3 = New LinkLabel()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(89, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 2
        ' 
        ' lblTitle1
        ' 
        lblTitle1.AutoSize = True
        lblTitle1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle1.Location = New Point(121, 39)
        lblTitle1.Name = "lblTitle1"
        lblTitle1.Size = New Size(94, 26)
        lblTitle1.TabIndex = 13
        lblTitle1.Text = "Library"
        ' 
        ' picLogo
        ' 
        picLogo.BackgroundImage = CType(resources.GetObject("picLogo.BackgroundImage"), Image)
        picLogo.BackgroundImageLayout = ImageLayout.Stretch
        picLogo.Location = New Point(22, 19)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(93, 73)
        picLogo.TabIndex = 14
        picLogo.TabStop = False
        ' 
        ' lblTitle2
        ' 
        lblTitle2.AutoSize = True
        lblTitle2.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle2.Location = New Point(121, 65)
        lblTitle2.Name = "lblTitle2"
        lblTitle2.Size = New Size(180, 22)
        lblTitle2.TabIndex = 15
        lblTitle2.Text = "Management System"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.White
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(346, 57)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(40, 15)
        LinkLabel1.TabIndex = 16
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Home"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.ActiveLinkColor = Color.White
        LinkLabel2.AutoSize = True
        LinkLabel2.LinkColor = Color.White
        LinkLabel2.Location = New Point(404, 57)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(57, 15)
        LinkLabel2.TabIndex = 17
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Inventory"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(LinkLabel4)
        Panel1.Controls.Add(lblTitle2)
        Panel1.Controls.Add(lblTitle1)
        Panel1.Controls.Add(LinkLabel3)
        Panel1.Controls.Add(picLogo)
        Panel1.Controls.Add(LinkLabel2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(799, 111)
        Panel1.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(668, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 15)
        Label1.TabIndex = 19
        Label1.Text = "User - Admin"
        ' 
        ' btnLogout
        ' 
        btnLogout.ForeColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        btnLogout.Location = New Point(668, 57)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(58, 25)
        btnLogout.TabIndex = 20
        btnLogout.Text = "Signout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel4
        ' 
        LinkLabel4.ActiveLinkColor = Color.White
        LinkLabel4.AutoSize = True
        LinkLabel4.LinkColor = Color.White
        LinkLabel4.Location = New Point(557, 57)
        LinkLabel4.Name = "LinkLabel4"
        LinkLabel4.RightToLeft = RightToLeft.No
        LinkLabel4.Size = New Size(72, 15)
        LinkLabel4.TabIndex = 19
        LinkLabel4.TabStop = True
        LinkLabel4.Text = "Transactions"
        LinkLabel4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' LinkLabel3
        ' 
        LinkLabel3.ActiveLinkColor = Color.White
        LinkLabel3.AutoSize = True
        LinkLabel3.LinkColor = Color.White
        LinkLabel3.Location = New Point(479, 57)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(60, 15)
        LinkLabel3.TabIndex = 18
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "Borrowers"
        ' 
        ' MainPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        ForeColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        Name = "MainPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTitle1 As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogout As Button
End Class
