Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=test"
        Try
            conn.Open()
            MessageBox.Show("Connection to MySQL test database was successful!!!!", "TESTING CONNECTION TO MySQL DATABASE")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=test"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM Accounts WHERE username = '" & Username.Text & "' AND password = '" & Password.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            Dim count As Integer
            READER = COMMAND.ExecuteReader
            Count = 0
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
