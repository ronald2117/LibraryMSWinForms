<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
        LinkLabel2 = New LinkLabel()
        Panel1 = New Panel()
        Label1 = New Label()
        btnLogout = New Button()
        LinkLabel4 = New LinkLabel()
        lblTitle2 = New Label()
        lblTitle1 = New Label()
        LinkLabel3 = New LinkLabel()
        picLogo = New PictureBox()
        LinkLabel1 = New LinkLabel()
        Label2 = New Label()
        LinkLabel5 = New LinkLabel()
        Label3 = New Label()
        btnAddBook = New Button()
        btnUpdateBook = New Button()
        btnDeleteBook = New Button()
        dataGridInventory = New DataGridView()
        Panel1.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataGridInventory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.ActiveLinkColor = Color.White
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Times New Roman", 12F)
        LinkLabel2.LinkColor = Color.White
        LinkLabel2.Location = New Point(367, 216)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(66, 19)
        LinkLabel2.TabIndex = 18
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
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(LinkLabel5)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(799, 111)
        Panel1.TabIndex = 19
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
        ' LinkLabel4
        ' 
        LinkLabel4.ActiveLinkColor = Color.White
        LinkLabel4.AutoSize = True
        LinkLabel4.Font = New Font("Times New Roman", 12F)
        LinkLabel4.LinkColor = Color.White
        LinkLabel4.Location = New Point(536, 46)
        LinkLabel4.Name = "LinkLabel4"
        LinkLabel4.RightToLeft = RightToLeft.No
        LinkLabel4.Size = New Size(84, 19)
        LinkLabel4.TabIndex = 19
        LinkLabel4.TabStop = True
        LinkLabel4.Text = "Transactions"
        LinkLabel4.TextAlign = ContentAlignment.TopCenter
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
        ' LinkLabel3
        ' 
        LinkLabel3.ActiveLinkColor = Color.White
        LinkLabel3.AutoSize = True
        LinkLabel3.Font = New Font("Times New Roman", 12F)
        LinkLabel3.LinkColor = Color.White
        LinkLabel3.Location = New Point(458, 46)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(74, 19)
        LinkLabel3.TabIndex = 18
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "Borrowers"
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
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.White
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Times New Roman", 12F)
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(383, 46)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(66, 19)
        LinkLabel1.TabIndex = 17
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Inventory"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(89, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 2
        ' 
        ' LinkLabel5
        ' 
        LinkLabel5.ActiveLinkColor = Color.White
        LinkLabel5.AutoSize = True
        LinkLabel5.Font = New Font("Times New Roman", 12F)
        LinkLabel5.LinkColor = Color.White
        LinkLabel5.Location = New Point(325, 46)
        LinkLabel5.Name = "LinkLabel5"
        LinkLabel5.Size = New Size(46, 19)
        LinkLabel5.TabIndex = 16
        LinkLabel5.TabStop = True
        LinkLabel5.Text = "Home"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(255), CByte(98), CByte(0))
        Label3.Location = New Point(42, 138)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 26)
        Label3.TabIndex = 21
        Label3.Text = "Books"
        ' 
        ' btnAddBook
        ' 
        btnAddBook.Location = New Point(490, 141)
        btnAddBook.Name = "btnAddBook"
        btnAddBook.Size = New Size(75, 23)
        btnAddBook.TabIndex = 22
        btnAddBook.Text = "Add"
        btnAddBook.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateBook
        ' 
        btnUpdateBook.Location = New Point(586, 141)
        btnUpdateBook.Name = "btnUpdateBook"
        btnUpdateBook.Size = New Size(75, 23)
        btnUpdateBook.TabIndex = 23
        btnUpdateBook.Text = "Update"
        btnUpdateBook.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteBook
        ' 
        btnDeleteBook.Location = New Point(682, 143)
        btnDeleteBook.Name = "btnDeleteBook"
        btnDeleteBook.Size = New Size(75, 23)
        btnDeleteBook.TabIndex = 24
        btnDeleteBook.Text = "Delete"
        btnDeleteBook.UseVisualStyleBackColor = True
        ' 
        ' dataGridInventory
        ' 
        dataGridInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataGridInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridInventory.Location = New Point(90, 198)
        dataGridInventory.Name = "dataGridInventory"
        dataGridInventory.Size = New Size(591, 211)
        dataGridInventory.TabIndex = 25
        ' 
        ' Inventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dataGridInventory)
        Controls.Add(btnDeleteBook)
        Controls.Add(btnUpdateBook)
        Controls.Add(btnAddBook)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Controls.Add(LinkLabel2)
        Name = "Inventory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory - Library Management System"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(dataGridInventory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents lblTitle1 As Label
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddBook As Button
    Friend WithEvents btnUpdateBook As Button
    Friend WithEvents btnDeleteBook As Button
    Friend WithEvents dataGridInventory As DataGridView
End Class
