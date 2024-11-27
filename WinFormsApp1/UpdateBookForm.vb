Imports MySql.Data.MySqlClient
Public Class UpdateBookForm
    Dim inventory As New Inventory
    Dim connectionString As String = "server=127.0.0.1;userid=root;password='';database=library_management_system"
    Dim connection As New MySqlConnection(connectionString)
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            connection.Open()
            Dim query As String = "UPDATE books SET title = @title, author = @author, quantity = @quantity  WHERE book_id = @id"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id", txtBoxId.Text)
            cmd.Parameters.AddWithValue("@title", txtBoxTitle.Text)
            cmd.Parameters.AddWithValue("@author", txtBoxAuthor.Text)
            cmd.Parameters.AddWithValue("@quantity", txtBoxQuantity.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Book updated successfully")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
            Me.Close()
            inventory.Show()
        End Try
    End Sub
End Class