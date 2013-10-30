Imports System.Data.SqlClient
Public Class dalDiagnostico


    Dim conn As New SqlConnection()

    Public Sub New()
        conn.ConnectionString = "Server = PHENOMII-PC;"
        conn.ConnectionString = "data source = PHENOMII-PC;"
        conn.ConnectionString += "initial catalog = Hospital_Universitario;"
        conn.ConnectionString += "integrated security=SSPI;"
        conn.ConnectionString += "User ID=Phenom II;"
        conn.ConnectionString += "password='123456'"

    End Sub

    Public Function insertar(ByVal diag As Integer, ByVal rutmedico As String, ByVal rutpaciente As String, ByVal diagnostico As String, ByVal receta As String) As Integer
        Dim comando As New SqlCommand()
        Dim resultado As Integer
        comando.Connection = conn
        comando.CommandText = "insert into pacientePersonal values(@piddiagnostico,@prutmedico, @prutpaciente, @pdiagnostico, @preceta)"
        comando.Parameters.AddWithValue("piddiagnostico", diag)
        comando.Parameters.AddWithValue("prutmedico", rutmedico)
        comando.Parameters.AddWithValue("prutpaciente", rutpaciente)
        comando.Parameters.AddWithValue("pdiagnostico", diagnostico)
        comando.Parameters.AddWithValue("preceta", receta)

        conn.Open()
        resultado = comando.ExecuteNonQuery()
        conn.Close()
        Return resultado
    End Function
End Class
