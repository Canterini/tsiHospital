Public Class bllContactoAdmin
    Dim _nombre As String
    Dim _fecha As Date
    Dim _comentario As String
    Dim contacto As New dalContactoAdmin

    Public Sub New()
        contacto = New dalContactoAdmin
    End Sub



    Public Property nombre() As String
        Get
            Return _nombre

        End Get
        Set(value As String)
            _nombre = value


        End Set
    End Property

    Public Property fecha() As Date
        Get
            Return _fecha

        End Get
        Set(value As Date)
            _fecha = value


        End Set
    End Property

    Public Property comentario() As String
        Get
            Return _comentario

        End Get
        Set(value As String)
            _comentario = value


        End Set
    End Property



    Public Sub New(ByVal nombre As String, ByVal fecha As Date, ByVal comentario As String)
        Me.nombre = nombre
        Me.fecha = fecha
        Me.comentario = comentario

    End Sub


    Public Function enviar(ByVal nombre As String, ByVal fecha As Date, ByVal comentario As Date) As Integer
        Me.nombre = nombre
        Me.fecha = fecha
        Me.comentario = comentario

        Return contacto.enviar(nombre, fecha, comentario)
    End Function



End Class
