Public Class FormAdministrarDepartamentos
    Dim Departamento As New bllDespartamento()
    Private Sub btnAgregarDpto_Click(sender As Object, e As EventArgs)
        Try
            Departamento.insertar(txtNombreDepto.Text, cboTipo.Text) 'esto hace que onserte en la bd llamando tu funcion de insertar bll y bll lama a dal para cargar los datos de la base de datos
            MessageBox.Show("Personal ingresado exitosamente", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As SqlClient.SqlException ' en caso de erros existe una excepcion paraque no sse  caiga el programa
            MessageBox.Show("El rut ingresado ya existe", "Error RUT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtNombreDepto.Text = ""
        Catch ex As ArgumentException
            MessageBox.Show("Ingrese NUEVAMENTE EL RUT", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtNombreDepto.Text = ""
        End Try
    End Sub

    Private Sub FormAdministrarDepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_salir(sender As Object, e As EventArgs) Handles b_salir.Click
        Me.Close()

    End Sub

    Private Sub b_modificar(sender As Object, e As EventArgs) Handles bt_modificar.Click

    End Sub
End Class