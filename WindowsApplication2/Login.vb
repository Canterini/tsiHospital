Public Class Login

    
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If (txtUsuario.Text.Length >= 4 And txtPass.Text.Length >= 4) Then

            FormAdministracion.Show()
        Else
            MessageBox.Show("Por favor verifique sus Datos")



        End If
        Me.Hide()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        MessageBox.Show("cerrando sesion")
        Me.Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
