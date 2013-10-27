Imports System.Data.SqlClient
Public Class dalPacientes

    Dim conn As New SqlConnection()

    Public Sub New()
        conn.ConnectionString = "Server = PHENOMII-PC;"
        conn.ConnectionString = "data source = PHENOMII-PC;"
        conn.ConnectionString += "initial catalog = Hospital_Universitario;"
        conn.ConnectionString += "integrated security=SSPI;"
        conn.ConnectionString += "User ID=Phenom II;"
        conn.ConnectionString += "password='123456'"

    End Sub

    Public Function insertar(ByVal rut As String, ByVal nombres As String, ByVal apellidos As String, ByVal estadocivil As String, ByVal sexo As String, ByVal edad As Integer, ByVal direccion As String, ByVal aseguradora As String, ByVal nombredepto As String, ByVal numerocamilla As String, ByVal fechaingreso As Date, ByVal fechasalida As Date, ByVal contraindicaciones As String) As Integer
        Dim comando As New SqlCommand()
        Dim resultado As Integer
        comando.Connection = conn
        comando.CommandText = "insert into Paciente values(@prut,@pnombres,@papellidos,@pestadocivil,@psexo,@pedad,@pdireccion,@paseguradora,@pnombredepto,@pnumerocamilla, @pfechaingreso, @pfechasalida, @pcontraindicaciones)"
        comando.Parameters.AddWithValue("prut", rut)
        comando.Parameters.AddWithValue("pnombres", nombres)
        comando.Parameters.AddWithValue("papellidos", apellidos)
        comando.Parameters.AddWithValue("pestadocivil", estadocivil)
        comando.Parameters.AddWithValue("psexo", sexo)
        comando.Parameters.AddWithValue("pedad", CInt(edad))
        comando.Parameters.AddWithValue("pdireccion", direccion)
        comando.Parameters.AddWithValue("paseguradora", aseguradora)
        comando.Parameters.AddWithValue("pnombredepto", nombredepto)
        comando.Parameters.AddWithValue("pnumerocamilla", numerocamilla)
        comando.Parameters.AddWithValue("pfechaingreso", fechaingreso)
        comando.Parameters.AddWithValue("pfechasalida", fechasalida)
        comando.Parameters.AddWithValue("pcontraindicaciones", contraindicaciones)
        conn.Open()
        resultado = comando.ExecuteNonQuery()
        conn.Close()
        Return resultado
    End Function









End Class
