Imports System.Data.SqlClient
Public Class FormDiagnostico
    Dim diagnos As New bllDiagnostico
    Dim conn As New sqlconnection



    Private Sub FormDiagnostico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub tb_diag_TextChanged(sender As Object, e As EventArgs) Handles tb_diag.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            diagnos.insertar(tb_ndiag.Text, tb_rutdoc.Text, tb_rutpac.Text, tb_diag.Text, tb_receta.Text) 'esto hace que onserte en la bd llamando tu funcion de insertar bll y bll lama a dal para cargar los datos de la base de datos
            MessageBox.Show("Diagnostico registrado exitosamente", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.tb_ndiag.Text = ""
            Me.tb_rutdoc.Text = ""
            Me.tb_rutpac.Text = ""
            Me.tb_diag.Text = ""
            Me.tb_receta.Text = ""
            conn.Close()

        Catch ex As SqlClient.SqlException ' en caso de erros existe una excepcion paraque no sse  caiga el programa
            MessageBox.Show("El nombre ingresado ya existe", "Error Nombre", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tb_ndiag.Text = ""
            Me.tb_rutdoc.Text = ""
            Me.tb_rutpac.Text = ""
            Me.tb_diag.Text = ""
            Me.tb_receta.Text = ""
            conn.Close()
        Catch ex As ArgumentException
            MessageBox.Show("Favor revise los campos", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tb_ndiag.Text = ""
            Me.tb_rutdoc.Text = ""
            Me.tb_rutpac.Text = ""
            Me.tb_diag.Text = ""
            Me.tb_receta.Text = ""
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class