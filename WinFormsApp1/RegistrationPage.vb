Imports MySql.Data.MySqlClient

Public Class RegistrationPage
    Dim loginForm As New LoginForm()
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim connectionString As String = "server=127.0.0.1;userid=root;password='';database=library_management_system"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()
            Dim query As String = "INSERT INTO users (first_name, middle_name, last_name, username, password, account_type) VALUES (@fName, @mName, @lName, @username, @password, @account_type)"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@fName", txtBoxFirstName.Text)
            cmd.Parameters.AddWithValue("@mName", txtBoxMiddleName.Text)
            cmd.Parameters.AddWithValue("@lName", txtBoxLastName.Text)
            cmd.Parameters.AddWithValue("@username", txtBoxUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtBoxPassword.Text)
            cmd.Parameters.AddWithValue("@account_type", "librarian")
            cmd.ExecuteNonQuery()
            MessageBox.Show("Registered successfully!")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        Finally
            connection.Close()
            Close()
            loginForm.Show()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
        loginForm.Show()
    End Sub
End Class