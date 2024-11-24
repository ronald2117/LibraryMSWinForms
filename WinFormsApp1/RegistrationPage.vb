Public Class RegistrationPage
    Dim loginForm As New LoginForm()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        loginForm.Show()
    End Sub

End Class