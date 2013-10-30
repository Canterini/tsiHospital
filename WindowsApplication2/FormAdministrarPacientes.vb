Imports System.Data.SqlClient
Public Class FormAdministrarPacientes
    Dim paciente As New bllPaciente()
    Dim conn As New SqlConnection()


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


        Try
            paciente.insertar(tb_rut.Text, tb_nombres.Text, tb_apellidos.Text, tb_sexo.Text, tb_estadoc.Text, tb_edad.Text, tbb_direccion.Text, tb_aseguradora.Text, cb_departamento.SelectedIndex, cb_idcamilla.SelectedIndex, DateTimePicker4.Text, DateTimePicker3.Text, tb_contraindicaciones.Text, tb_diag.Text)
            MessageBox.Show("Paciente ingresado exitosamente", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.tb_rut.Text = ""
            Me.tb_nombres.Text = ""
            Me.tb_apellidos.Text = ""
            Me.tb_sexo.Text = ""
            Me.tb_estadoc.Text = ""
            Me.tb_edad.ResetText()
            Me.tbb_direccion.Text = ""
            Me.tb_aseguradora.Text = ""
            Me.cb_departamento.Text = ""
            Me.cb_idcamilla.ResetText()
            Me.DateTimePicker4.ResetText()
            Me.DateTimePicker3.ResetText()
            Me.tb_contraindicaciones.Text = ""
            Me.tb_diag.Text = ""
            conn.Close()
        Catch ex As SqlClient.SqlException
            MessageBox.Show("El rut ingresado ya existe", "Error RUT", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.tb_rut.Text = ""
            Me.tb_nombres.Text = ""
            Me.tb_apellidos.Text = ""
            Me.tb_sexo.Text = ""
            Me.tb_estadoc.Text = ""
            Me.tb_edad.ResetText()
            Me.tbb_direccion.Text = ""
            Me.tb_aseguradora.Text = ""
            Me.cb_departamento.Text = ""
            Me.cb_idcamilla.ResetText()
            Me.DateTimePicker4.ResetText()
            Me.DateTimePicker3.ResetText()
            Me.tb_contraindicaciones.Text = ""
            Me.tb_diag.Text = ""
            conn.Close()
        Catch ex As ArgumentException
            MessageBox.Show("Favor revise los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tb_rut.Text = ""
            conn.Close()
        End Try



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

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_idcamilla.SelectedIndexChanged

    End Sub

    Private Sub tb_contraindicaciones_TextChanged(sender As Object, e As EventArgs) Handles tb_contraindicaciones.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class