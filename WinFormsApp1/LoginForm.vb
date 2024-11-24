Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient

Public Class LoginForm

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim mainPage As New MainPage()

        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=library_management_system"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM librarian WHERE username = '" & Username.Text & "' AND password = '" & Password.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            Dim count As Integer
            READER = COMMAND.ExecuteReader
            count = 0
            While READER.Read
                count = count + 1
            End While
            If count = 1 Then
                Me.Hide()
                mainPage.Show()
            ElseIf count > 1 Then
                MessageBox.Show("Username and password are duplicate!")
            Else
                MessageBox.Show("Username and password are incorrect!")
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim registrationPage As New RegistrationPage()
        Me.Hide()
        registrationPage.Show()
    End Sub
End Class
