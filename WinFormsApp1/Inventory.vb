Imports MySql.Data.MySqlClient

Public Class Inventory
    Dim connectionString As String = "server=127.0.0.1;userid=root;password='';database=library_management_system"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM books"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable
            adapter.Fill(table)
            dataGridInventory.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        Close()
        AddBookForm.Show()
    End Sub
    Private Sub btnUpdateBook_Click(sender As Object, e As EventArgs) Handles btnUpdateBook.Click
        Close()
        UpdateBookForm.Show()
    End Sub
    Private Sub btnDeleteBook_Click(sender As Object, e As EventArgs) Handles btnDeleteBook.Click
        Close()
        DeleteBookForm.Show()
    End Sub
End Class