Imports System.Data.SqlClient
Public Class FormAdministrarDepartamentos
    Dim Departamento As New bllDespartamento()
    Dim conn As New SqlConnection
    

    Private Sub FormAdministrarDepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_salir(sender As Object, e As EventArgs) Handles b_salir.Click
        Me.Close()

    End Sub

    Private Sub b_modificar(sender As Object, e As EventArgs) Handles bt_modificar.Click

    End Sub

    Private Sub b_agregar_Click(sender As Object, e As EventArgs) Handles btnAgregardepto.Click
        Try
         


            Departamento.insertar(txtNombreDepto.Text) 'esto hace que onserte en la bd llamando tu funcion de insertar bll y bll lama a dal para cargar los datos de la base de datos
            MessageBox.Show("Departamento ingresado exitosamente", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()

        Catch ex As SqlClient.SqlException ' en caso de erros existe una excepcion paraque no sse  caiga el programa
            MessageBox.Show("El departamento ingresado ya existe", "Error Nombre", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtNombreDepto.Text = ""
            conn.Close()
        Catch ex As ArgumentException
            MessageBox.Show("Favor ingrese un departamento", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtNombreDepto.Text = ""
            conn.Close()
        End Try
    End Sub

    Private Sub txtNombreDepto_TextChanged(sender As Object, e As EventArgs) Handles txtNombreDepto.TextChanged

    End Sub
End Class