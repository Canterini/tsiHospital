Public Class FormContactoAdmin

    Dim contacto As New bllContactoAdmin

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Nombre.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        rtb_comentario.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Boolean
        ErrorGeneral.Clear()

        If rtb_comentario.Text = "" Then
            ErrorGeneral.SetError(rtb_comentario, "Favor ingrese comentario")
            a = False

        Else

        End If

        If (a = False) Then
            MessageBox.Show("Favor revise sus campos", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else



            Try 'intenta insertar personal
                contacto.enviar(tb_nombre.Text, dtp_fecha.Text, rtb_comentario.Text) 'esto hace que inserte en la bd llamando tu funcion de insertar bll y bll lama a dal para cargar los datos de la base de datos
                MessageBox.Show("Personal ingresado exitosamente", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tb_nombre.Text = ""   'esto hace que cambie de texto a vacio osea lo limpia
                Me.dtp_fecha.Text = ""
                Me.rtb_comentario.Text = ""

          
            Catch ex As ArgumentException
                MessageBox.Show("favor rellene los campos", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tb_nombre.Text = ""
                Me.dtp_fecha.Text = ""
                Me.rtb_comentario.Text = ""

            End Try
        End If


    End Sub
End Class