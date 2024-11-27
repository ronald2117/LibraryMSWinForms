Imports MySql.Data.MySqlClient
Public Class AddBookForm
    Dim inventory As New Inventory
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim connectionString As String = "server=127.0.0.1;userid=root;password='';database=library_management_system"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()
            Dim query As String = "INSERT INTO books (title, author, quantity) VALUES (@title, @author, @quantity)"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@title", txtBoxTitle.Text)
            cmd.Parameters.AddWithValue("@author", txtBoxAuthor.Text)
            cmd.Parameters.AddWithValue("@quantity", txtBoxQuantity.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Book added successfully!")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        Finally
            connection.Close()
            inventory.Show()
            Close()
        End Try
    End Sub
End Class