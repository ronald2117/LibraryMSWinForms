Public Class MainPage
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim loginForm As New LoginForm
        Me.Hide()
        loginForm.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkInventory.LinkClicked
        Dim inventory As New Inventory
        Me.Hide()
        inventory.Show()
    End Sub
End Class