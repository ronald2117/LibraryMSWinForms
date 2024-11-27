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
        linkHome = New LinkLabel()
        linkInventory = New LinkLabel()
        Panel1 = New Panel()
        Label1 = New Label()
        btnLogout = New Button()
        linkTransactions = New LinkLabel()
        linkBorrowers = New LinkLabel()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
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
        lblTitle1.Location = New Point(121, 31)
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
        lblTitle2.Location = New Point(121, 57)
        lblTitle2.Name = "lblTitle2"
        lblTitle2.Size = New Size(180, 22)
        lblTitle2.TabIndex = 15
        lblTitle2.Text = "Management System"
        ' 
        ' linkHome
        ' 
        linkHome.ActiveLinkColor = Color.White
        linkHome.AutoSize = True
        linkHome.Font = New Font("Times New Roman", 12F)
        linkHome.LinkColor = Color.White
        linkHome.Location = New Point(325, 46)
        linkHome.Name = "linkHome"
        linkHome.Size = New Size(46, 19)
        linkHome.TabIndex = 16
        linkHome.TabStop = True
        linkHome.Text = "Home"
        ' 
        ' linkInventory
        ' 
        linkInventory.ActiveLinkColor = Color.White
        linkInventory.AutoSize = True
        linkInventory.Font = New Font("Times New Roman", 12F)
        linkInventory.LinkColor = Color.White
        linkInventory.Location = New Point(383, 46)
        linkInventory.Name = "linkInventory"
        linkInventory.Size = New Size(66, 19)
        linkInventory.TabIndex = 17
        linkInventory.TabStop = True
        linkInventory.Text = "Inventory"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(linkTransactions)
        Panel1.Controls.Add(lblTitle2)
        Panel1.Controls.Add(lblTitle1)
        Panel1.Controls.Add(linkBorrowers)
        Panel1.Controls.Add(picLogo)
        Panel1.Controls.Add(linkInventory)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(linkHome)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(799, 111)
        Panel1.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F)
        Label1.Location = New Point(651, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 19)
        Label1.TabIndex = 19
        Label1.Text = "User - Admin"
        ' 
        ' btnLogout
        ' 
        btnLogout.Font = New Font("Times New Roman", 12F)
        btnLogout.ForeColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        btnLogout.Location = New Point(670, 60)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(72, 27)
        btnLogout.TabIndex = 20
        btnLogout.Text = "Signout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' linkTransactions
        ' 
        linkTransactions.ActiveLinkColor = Color.White
        linkTransactions.AutoSize = True
        linkTransactions.Font = New Font("Times New Roman", 12F)
        linkTransactions.LinkColor = Color.White
        linkTransactions.Location = New Point(536, 46)
        linkTransactions.Name = "linkTransactions"
        linkTransactions.RightToLeft = RightToLeft.No
        linkTransactions.Size = New Size(84, 19)
        linkTransactions.TabIndex = 19
        linkTransactions.TabStop = True
        linkTransactions.Text = "Transactions"
        linkTransactions.TextAlign = ContentAlignment.TopCenter
        ' 
        ' linkBorrowers
        ' 
        linkBorrowers.ActiveLinkColor = Color.White
        linkBorrowers.AutoSize = True
        linkBorrowers.Font = New Font("Times New Roman", 12F)
        linkBorrowers.LinkColor = Color.White
        linkBorrowers.Location = New Point(458, 46)
        linkBorrowers.Name = "linkBorrowers"
        linkBorrowers.Size = New Size(74, 19)
        linkBorrowers.TabIndex = 18
        linkBorrowers.TabStop = True
        linkBorrowers.Text = "Borrowers"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F)
        Label3.Location = New Point(68, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(172, 19)
        Label3.TabIndex = 19
        Label3.Text = "Welcome - Ronald A Sope"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F)
        Label4.Location = New Point(68, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 19)
        Label4.TabIndex = 20
        Label4.Text = "Total books: 200"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 12F)
        Label5.Location = New Point(68, 202)
        Label5.Name = "Label5"
        Label5.Size = New Size(136, 19)
        Label5.TabIndex = 21
        Label5.Text = "Borrowed books: 50"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 12F)
        Label6.Location = New Point(68, 226)
        Label6.Name = "Label6"
        Label6.Size = New Size(145, 19)
        Label6.TabIndex = 22
        Label6.Text = "Overdue books: None"
        ' 
        ' MainPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 449)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        Name = "MainPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home - Library Management System"
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTitle1 As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents linkHome As LinkLabel
    Friend WithEvents linkInventory As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents linkTransactions As LinkLabel
    Friend WithEvents linkBorrowers As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
