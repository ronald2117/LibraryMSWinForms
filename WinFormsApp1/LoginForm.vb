Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient

Public Class LoginForm

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=library_management_system"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM users WHERE Username = '" & Username.Text & "' AND Password = '" & Password.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            Dim count As Integer
            READER = COMMAND.ExecuteReader
            count = 0
            While READER.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("Login successful!")
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

End Class
