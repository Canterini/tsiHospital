Public Class tb_direccion
    Dim paciente As New bllPaciente()

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)


    End Sub

    Private Sub FormAdministrarPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnAgregarPaciente.Click
        Dim a As Boolean = True
        ErrorGeneral.Clear()

        If (tb_rut.Text.Trim = "") Then
            ErrorGeneral.SetError(tb_rut, "Ingrese el rut solicitado")
            a = False
            tb_rut.Text = ""
        Else

        End If

        If (tb_nombres.Text.Trim = "") Then
            ErrorGeneral.SetError(tb_nombres, "Ingrese nombre")
            a = False
            tb_nombres.Text = ""
        Else

        End If
        If (tb_apellidos.Text.Trim = "") Then
            ErrorGeneral.SetError(tb_apellidos, "Ingrese el apellido solicitado")
            a = False
            tb_apellidos.Text = ""
        Else

        End If

        If (tb_sexo.Text.Trim = "") Then
            ErrorGeneral.SetError(tb_sexo, "Ingrese el rut solicitado")
            a = False
            tb_sexo.Text = ""
        Else

        End If
        If (tb_estadoc.Text.Trim = "") Then
            ErrorGeneral.SetError(tb_estadoc, "Ingrese el rut solicitado")
            a = False
            tb_estadoc.Text = ""
        Else

        End If
        If (tb_edad.Text.Trim = "") Then
            ErrorGeneral.SetError(tb_edad, "Ingrese el rut solicitado")
            a = False
            tb_edad.Text = ""
        Else

        End If
        If (tbb_direccion.Text.Trim = "") Then
            ErrorGeneral.SetError(tbb_direccion, "Ingrese la direccion solicitada")
            a = False
            tbb_direccion.Text = ""
        Else

        End If

        If (tb_aseguradora.Text.Trim = "") Then
            ErrorGeneral.SetError(tb_aseguradora, "Ingrese el rut solicitado")
            a = False
            tb_aseguradora.Text = ""
        Else

        End If


        If (tb_aseguradora.Text.Trim = "") Then
            ErrorGeneral.SetError(tb_aseguradora, "Ingrese el rut solicitado")
            a = False
            tb_aseguradora.Text = ""
        Else

        End If

        If (tb_contraindicaciones.Text.Trim = "") Then
            ErrorGeneral.SetError(tb_contraindicaciones, "Si el paciente no tiene una contrandicacion indique ninguna")
            a = False
            tb_aseguradora.Text = ""
        Else

        End If






    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub tb_rut_TextChanged(sender As Object, e As EventArgs) Handles tb_rut.TextChanged

    End Sub

    Private Sub tb_sexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tb_sexo.SelectedIndexChanged

    End Sub

    Private Sub tb_aseguradora_TextChanged(sender As Object, e As EventArgs) Handles tb_aseguradora.TextChanged

    End Sub

    Private Sub tbb_direccion_TextChanged(sender As Object, e As EventArgs) Handles tbb_direccion.TextChanged

    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_departamento.SelectedIndexChanged

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub tb_contraindicaciones_TextChanged(sender As Object, e As EventArgs) Handles tb_contraindicaciones.TextChanged

    End Sub
End Class