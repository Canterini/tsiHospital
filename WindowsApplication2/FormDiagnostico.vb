Public Class FormDiagnostico

   
    Private Sub cboRequiere_SelectedIndexChanged(sender As Object, e As EventArgs)
        If (cboRequiere.SelectedIndex = 0) Then
            btnGenerarReceta.Enabled = True
        Else
            btnGenerarReceta.Enabled = False

        End If
    End Sub

    Private Sub FormDiagnostico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnGenerarReceta.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub
End Class