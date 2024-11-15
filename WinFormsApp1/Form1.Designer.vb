<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnTest = New Button()
        LoginBtn = New Button()
        Password = New TextBox()
        Label2 = New Label()
        Username = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnTest
        ' 
        btnTest.Location = New Point(111, 71)
        btnTest.Name = "btnTest"
        btnTest.Size = New Size(125, 38)
        btnTest.TabIndex = 0
        btnTest.Text = "Connection Test"
        btnTest.UseVisualStyleBackColor = True
        ' 
        ' LoginBtn
        ' 
        LoginBtn.Location = New Point(315, 237)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(75, 23)
        LoginBtn.TabIndex = 10
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = True
        ' 
        ' Password
        ' 
        Password.Location = New Point(302, 176)
        Password.Name = "Password"
        Password.Size = New Size(100, 23)
        Password.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(236, 184)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 8
        Label2.Text = "Password"
        ' 
        ' Username
        ' 
        Username.Location = New Point(302, 138)
        Username.Name = "Username"
        Username.Size = New Size(100, 23)
        Username.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(236, 141)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 6
        Label1.Text = "Username"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LoginBtn)
        Controls.Add(Password)
        Controls.Add(Label2)
        Controls.Add(Username)
        Controls.Add(Label1)
        Controls.Add(btnTest)
        Name = "Form1"
        Text = "MYSQL DATABASE CONNECTION"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTest As Button
    Friend WithEvents LoginBtn As Button
    Friend WithEvents Password As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Label1 As Label

End Class
