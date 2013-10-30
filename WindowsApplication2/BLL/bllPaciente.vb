Public Class bllPaciente
    Dim _rut As String
    Dim _nombres As String
    Dim _apellidos As String
    Dim _sexo As String
    Dim _estadocivil As String
    Dim _edad As Integer
    Dim _direccion As String
    Dim _aseguradora As String
    Dim _nombredepartamento As String
    Dim _idcamilla As Integer
    Dim _fechaingreso As Date
    Dim _fechasalida As Date
    Dim _contraindicacion As String
    Dim _diag As Integer
    Dim Paciente As New dalPaciente

    Public Sub New()
        Paciente = New dalPaciente()

    End Sub

    Public Property rut() As String
        Get
            Return _rut
        End Get
        Set(value As String)

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
    Public Property sexo() As String
        Get
            Return _sexo
        End Get
        Set(value As String)

            _sexo = value

        End Set
    End Property

    Public Property estadocivil() As String
        Get
            Return _estadocivil
        End Get
        Set(value As String)

            _estadocivil = value

        End Set
    End Property

    Public Property edad() As Integer
        Get
            Return _edad
        End Get
        Set(value As Integer)

            _edad = value

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
    Public Property aseguradora() As String
        Get
            Return _aseguradora
        End Get
        Set(value As String)

            _aseguradora = value

        End Set
    End Property
    Public Property nombredepartamento() As String
        Get
            Return _nombredepartamento
        End Get
        Set(value As String)

            _nombredepartamento = value

        End Set
    End Property
    Public Property idcamilla() As Integer
        Get
            Return _idcamilla
        End Get
        Set(value As Integer)

            _idcamilla = value

        End Set
    End Property
    Public Property fechaingreso() As String
        Get
            Return _fechaingreso
        End Get
        Set(value As String)

            _fechaingreso = value

        End Set
    End Property

    Public Property fechasalida() As String
        Get
            Return _fechasalida
        End Get
        Set(value As String)

            _fechasalida = value


        End Set
    End Property

    Public Property contraindicacion() As String
        Get
            Return _contraindicacion
        End Get
        Set(value As String)

            _contraindicacion = value

        End Set
    End Property

    Public Property diag() As Integer
        Get
            Return _diag

        End Get
        Set(value As Integer)
            _diag = value
        End Set
    End Property


    Public Sub New(ByVal rut As String, ByVal nombres As String, ByVal apellidos As String, ByVal estadocivil As String, ByVal sexo As String, ByVal edad As Integer, ByVal direccion As String, ByVal aseguradora As String, ByVal nombredepartamento As String, ByVal idcamilla As Integer, ByVal fechaingreso As Date, ByVal fechasalida As Date, ByVal contraindicaciones As String)
        Me.rut = rut
        Me.nombres = nombres
        Me.apellidos = apellidos
        Me.estadocivil = estadocivil
        Me.sexo = sexo
        Me.edad = edad
        Me.direccion = direccion
        Me.aseguradora = aseguradora
        Me.nombredepartamento = nombredepartamento
        Me.idcamilla = idcamilla
        Me.fechaingreso = fechaingreso
        Me.fechasalida = fechasalida
        Me.contraindicacion = contraindicaciones
        Me.diag = _diag
    End Sub


    Public Function insertar(ByVal rut As String, ByVal nombres As String, ByVal apellidos As String, ByVal estadocivil As String, ByVal sexo As String, ByVal edad As Integer, ByVal direccion As String, ByVal aseguradora As String, ByVal nombredepartamento As String, ByVal idcamilla As Integer, ByVal fechaingreso As Date, ByVal fechasalida As Date, ByVal contraindicaciones As String, ByVal diag As String) As Integer
        Me.rut = rut
        Me.nombres = nombres
        Me.apellidos = apellidos
        Me.estadocivil = estadocivil
        Me.sexo = sexo
        Me.edad = edad
        Me.direccion = direccion
        Me.aseguradora = aseguradora
        Me.nombredepartamento = nombredepartamento
        Me.idcamilla = idcamilla
        Me.fechaingreso = fechaingreso
        Me.fechasalida = fechasalida
        Me.contraindicacion = contraindicaciones
        Me.diag = _diag
        Return Paciente.insertar(rut, nombres, apellidos, estadocivil, sexo, edad, direccion, aseguradora, nombredepartamento, idcamilla, fechaingreso, fechasalida, contraindicaciones, diag)

    End Function















End Class



