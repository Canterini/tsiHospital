Public Class bllDespartamento
    Dim _nombre As String
    Dim _tipo As String
    Dim Departamento As dalDepartamento

    Public Sub New()
        Departamento = New dalDepartamento()
    End Sub

    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)

            _nombre = value


        End Set
    End Property
    Public Property tipo() As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value

        End Set
    End Property

    Public Sub New(ByVal nombre As String, ByVal tipo As String)
        Me.nombre = nombre
        Me.tipo = tipo

    End Sub

    Public Function insertar(ByVal nombre As String, ByVal tipo As String) As Integer
        Me.nombre = nombre
        Me.tipo = tipo
        Return Departamento.insertar(nombre, tipo)
    End Function


End Class
