Public Class bllPersonal
    Dim _rut As String
    Dim _nombres As String
    Dim _apellidos As String
    Dim _edad As Integer
    Dim _sexo As String
    Dim _direccion As String
    Dim _estado As String
    Dim _cargo As String
    Dim _telefono As String
    Dim _correo As String
    Dim _contraseña As String
    Dim Personal As dalPersonal

    Public Sub New()
        Personal = New dalPersonal()
    End Sub

    Public Property rut() As String
        Get
            Return _rut
        End Get
        Set(ByVal value As String)

            _rut = value


        End Set
    End Property
    Public Property nombres() As String
        Get
            Return _nombres

        End Get
        Set(value As String)
            _nombres = value

        End Set
    End Property

    Public Property apellidos() As String
        Get
            Return _apellidos

        End Get
        Set(value As String)
            _apellidos = value

        End Set
    End Property

    Public Property edad() As Integer

        Get
            Return _edad
        End Get
        Set(ByVal value As Integer)
            If (CDbl(value.ToString) > 0) Then
                _edad = value
            End If
        End Set
    End Property
    Public Property sexo() As String
        Get
            Return _sexo

        End Get
        Set(value As String)
            _sexo = value

        End Set
    End Property

    Public Property direccion() As String
        Get
            Return _direccion

        End Get
        Set(value As String)
            _direccion = value

        End Set
    End Property
    Public Property estado() As String
        Get
            Return _estado

        End Get
        Set(value As String)
            _estado = value

        End Set
    End Property

    Public Property cargo() As String
        Get
            Return _cargo

        End Get
        Set(value As String)
            _cargo = value

        End Set
    End Property
    Public Property telefono() As String
        Get
            Return _telefono

        End Get
        Set(value As String)
            _telefono = value

        End Set
    End Property

    Public Property correo() As String
        Get
            Return _correo


        End Get
        Set(value As String)
            _correo = value

        End Set
    End Property

    Public Property contraseña() As String
        Get
            Return _contraseña


        End Get
        Set(value As String)
            _contraseña = value

        End Set
    End Property
    Public Sub New(ByVal rut As String, ByVal nombres As String, ByVal apellidos As String, ByVal edad As Integer, ByVal sexo As String, ByVal direccion As String, ByVal estado As String, ByVal cargo As String, ByVal telefono As String, ByVal correo As String, ByVal contraseña As String)
        Me.rut = rut
        Me.nombres = nombres
        Me.apellidos = apellidos
        Me.edad = edad
        Me.sexo = sexo
        Me.direccion = direccion
        Me.estado = estado
        Me.cargo = cargo
        Me.telefono = telefono
        Me.correo = correo
        Me.contraseña = contraseña
    End Sub
    Public Function insertar(ByVal rut As String, ByVal nombres As String, ByVal apellidos As String, ByVal edad As Integer, ByVal sexo As String, ByVal direccion As String, ByVal estado As String, ByVal cargo As String, ByVal telefono As String, ByVal correo As String, ByVal contraseña As String) As Integer
        Me.rut = rut
        Me.nombres = nombres
        Me.apellidos = apellidos
        Me.edad = edad
        Me.sexo = sexo
        Me.direccion = direccion
        Me.estado = estado
        Me.cargo = cargo
        Me.telefono = telefono
        Me.correo = correo
        Me.contraseña = contraseña
        Return Personal.insertar(rut, nombres, apellidos, edad, sexo, direccion, estado, cargo, telefono, correo, contraseña)
    End Function
    Public Function eliminar(ByVal rut As String) As Integer
        Me.rut = rut
        Return Personal.eliminar(rut)
    End Function

   


End Class

