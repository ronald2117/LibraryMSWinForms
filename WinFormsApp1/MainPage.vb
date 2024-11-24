Public Class MainPage
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim loginForm As New LoginForm
        Me.Hide()
        loginForm.Show()
    End Sub
End Class