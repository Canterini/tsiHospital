Imports System.Data.SqlClient

Public Class dalPersonal
    Dim conn As New SqlConnection()


    Public Sub New()

        conn.ConnectionString = "Server = PHENOMII-PC;"
        conn.ConnectionString = "data source = PHENOMII-PC;"
        conn.ConnectionString += "initial catalog = Hospital_Universitario;"
        conn.ConnectionString += "integrated security=SSPI;"
        conn.ConnectionString += "User ID=Phenom II;"
        conn.ConnectionString += "password='123456'"

    End Sub
    Public Function insertar(ByVal rut As String, ByVal nombres As String, ByVal apellidos As String, ByVal edad As Integer, ByVal sexo As String, ByVal direccion As String, ByVal estado As String, ByVal cargo As String, ByVal telefono As String, ByVal correo As String, ByVal contraseña As String) As Integer
        Dim comando As New SqlCommand()
        Dim resultado As Integer
        comando.Connection = conn
        comando.CommandText = "insert into Personal values(@prut,@pnombres,@papellidos,@pedad,@psexo,@pdireccion,@pestado,@pcargo,@ptelefono,@pcorreo,@pcontraseña)"
        comando.Parameters.AddWithValue("prut", rut)
        comando.Parameters.AddWithValue("pnombres", nombres)
        comando.Parameters.AddWithValue("papellidos", apellidos)
        comando.Parameters.AddWithValue("pedad", CInt(edad))
         comando.Parameters.AddWithValue("psexo", sexo)
        comando.Parameters.AddWithValue("pdireccion", direccion)
        comando.Parameters.AddWithValue("pestado", estado)
        comando.Parameters.AddWithValue("pcargo", cargo)
        comando.Parameters.AddWithValue("ptelefono", telefono)
        comando.Parameters.AddWithValue("pcorreo", correo)
        comando.Parameters.AddWithValue("pcontraseña", contraseña)
        conn.Open()
        resultado = comando.ExecuteNonQuery()
        conn.Close()
        Return resultado
    End Function

    Function eliminar(rut As String) As Integer
        Dim comando As New SqlCommand()
        Dim resultado As Integer
        comando.Connection = conn
        comando.CommandText = "delete from Personal where Rut = (@prut)"
        comando.Parameters.AddWithValue("prut", rut)
        conn.Open()
        resultado = comando.ExecuteNonQuery()
        conn.Close()
        Return resultado

    End Function
End Class
