Public Class formAdministrarPersonal
    Dim Personal As New bllPersonal()


   

    
    Private Sub btnAgregarPersonal_Click(sender As Object, e As EventArgs) Handles btnAgregarPersonal.Click
        Dim a As Boolean = True
        ErrorGeneral.Clear()


        If (txtRut.Text.Trim = "") Then
            ErrorGeneral.SetError(txtRut, "Ingrese su Rut ")
            a = False
            txtRut.Text = ""
        Else
            a = True
        End If

        If (txtNombres.Text.Trim = "") Then
            ErrorGeneral.SetError(txtNombres, "Ingrese sus nombres ")
            a = False
            txtNombres.Text = ""
        Else
            a = True
        End If
        If (txtApellidos.Text.Trim = "") Then
            ErrorGeneral.SetError(txtApellidos, "Ingrese sus apellidos ")
            a = False
            txtApellidos.Text = ""
        Else
            a = True
        End If

        If (tb_direccion.Text.Trim = "") Then
            ErrorGeneral.SetError(tb_direccion, "Ingrese una direccion ")
            a = False
            tb_direccion.Text = ""

        End If

       


        If (Me.txtCorreo.Text.Trim = "") Then
            ErrorGeneral.SetError(txtCorreo, "Ingrese su mail ")
            a = False
            txtCorreo.Text = ""
        Else
            a = True
        End If


        If (a = False) Then
            MessageBox.Show("Favor revise sus campos", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else



            Try 'intenta insertar personal
                Personal.insertar(txtRut.Text, txtNombres.Text, txtApellidos.Text, CInt(cboEdad.Text), cboSexo.Text, tb_direccion.Text, cboEstado.Text, cboCargo.Text, txtTelefono.Text, txtCorreo.Text, txtContraseña.Text) 'esto hace que inserte en la bd llamando tu funcion de insertar bll y bll lama a dal para cargar los datos de la base de datos
                MessageBox.Show("Personal ingresado exitosamente", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtRut.Text = ""   'esto hace que cambie de texto a vacio osea lo limpia
                Me.txtNombres.Text = ""
                Me.Apellidos.Text = ""

            Catch ex As SqlClient.SqlException ' en caso de erros existe una excepcion paraque no sse  caiga el programa
                MessageBox.Show("El rut ingresado ya existe", "Error RUT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtRut.Text = ""

            Catch ex As ArgumentException
                MessageBox.Show("Ingrese NUEVAMENTE EL RUT", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtRut.Text = ""

            End Try
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim rut_l As String
        rut_l = InputBox("Ingrese el rut a eliminar")

        If (rut_l = "") Then
            MessageBox.Show("El rut ingresado no es válido")

        Else
            ' intenta eliminar personal desde la BD utilizando funcion personal.eliminar
            Personal.eliminar(rut_l)
            Try
                MessageBox.Show("Personal eliminado exitosamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As SqlClient.SqlException ' en caso de error si el rut no existe (excepcion apunta al cliente SQL)
                MessageBox.Show("El rut no existe", "Error RUT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                rut_l = ""
            Catch ex As ArgumentException
                MessageBox.Show("Verifique el rut ingresado e intentelo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception

            End Try
        End If








    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub cboEdad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEdad.SelectedIndexChanged

    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles tb_direccion.TextChanged

    End Sub
End Class