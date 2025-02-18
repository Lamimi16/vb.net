Public Class loginform
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String = TxtUsername.Text
        Dim password As String = TxtPassword.Text

        ' Vérification des informations d'identification
        If username = "admin" AndAlso password = "admin123" Then
            ' Accès à l'AdminForm si les informations sont correctes
            Dim adminForm As New AdminForm()
            adminForm.Show()
            Me.Hide() ' Masquer le LoginForm
        Else
            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
