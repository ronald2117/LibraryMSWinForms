Imports MySql.Data.MySqlClient
Public Class DeleteBookForm
    Dim connectionString As String = "server=127.0.0.1;userid=root;password='';database=library_management_system"
    Dim connection As New MySqlConnection(connectionString)
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            connection.Open()
            Dim query As String = "DELETE FROM books WHERE book_id = @id"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id", txtBoxId.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Book deleted successfully!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
            Close()
            Inventory.Show()
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
        Inventory.Show()
    End Sub
End Class