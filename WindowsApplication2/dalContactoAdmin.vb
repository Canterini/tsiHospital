﻿Imports System.Data.SqlClient


Public Class dalContactoAdmin

    Dim conn As New SqlConnection()

    Public Sub New()
        conn.ConnectionString = "Server = PHENOMII-PC;"
        conn.ConnectionString = "data source = PHENOMII-PC;"
        conn.ConnectionString += "initial catalog = Hospital_Universitario;"
        conn.ConnectionString += "integrated security=SSPI;"
        conn.ConnectionString += "User ID=Phenom II;"
        conn.ConnectionString += "password='123456'"

    End Sub

    Public Function enviar(ByVal nombre As String, ByVal fecha As Date, ByVal comentario As String) As Integer
        Dim comando As New SqlCommand()
        Dim resultado As Integer
        comando.Connection = conn
        comando.CommandText = "insert into Departamentos values(@pnombre,@ptipo)"
        comando.Parameters.AddWithValue("pnombre", nombre)
        comando.Parameters.AddWithValue("pfecha", fecha)
        comando.Parameters.AddWithValue("pcomentario", comentario)

        conn.Open()
        resultado = comando.ExecuteNonQuery()
        conn.Close()
        Return resultado
    End Function
End Class


