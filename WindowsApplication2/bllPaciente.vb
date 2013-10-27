Public Class bllPaciente
    Dim _rut As String
    Dim _nombres As String
    Dim _apellidos As String
    Dim _sexo As String
    Dim _estadocivil As String
    Dim _edad As Integer
    Dim _direccion As String
    Dim _aseguradora As String
    Dim _nombredepto As String
    Dim _numerocamilla As Integer
    Dim _fechaingreso As Date
    Dim _fechasalida As Date
    Dim _contraindicacion As String
    Dim Paciente As New dalPacientes

    Public Sub New()
        Paciente = New dalPacientes()

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
    Public Property nombredepto() As String
        Get
            Return _nombredepto
        End Get
        Set(value As String)

            _nombredepto = value

        End Set
    End Property
    Public Property numerocamilla() As String
        Get
            Return _numerocamilla
        End Get
        Set(value As String)

            _numerocamilla = value

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


    Public Sub New(ByVal rut As String, ByVal nombres As String, ByVal apellidos As String, ByVal estadocivil As String, ByVal sexo As String, ByVal edad As Integer, ByVal direccion As String, ByVal aseguradora As String, ByVal nombredepto As String, ByVal numerocamilla As String, ByVal fechaingreso As Date, ByVal fechasalida As Date, ByVal contraindicaciones As String)
        Me.rut = rut
        Me.nombres = nombres
        Me.apellidos = apellidos
        Me.estadocivil = estadocivil
        Me.sexo = sexo
        Me.edad = edad
        Me.direccion = direccion
        Me.aseguradora = aseguradora
        Me.nombredepto = nombredepto
        Me.numerocamilla = numerocamilla
        Me.fechaingreso = fechaingreso
        Me.fechasalida = fechasalida
        Me.contraindicacion = contraindicaciones
    End Sub


    Public Function insertar(ByVal rut As String, ByVal nombres As String, ByVal apellidos As String, ByVal estadocivil As String, ByVal sexo As String, ByVal edad As Integer, ByVal direccion As String, ByVal aseguradora As String, ByVal nombredepto As String, ByVal numerocamilla As String, ByVal fechaingreso As Date, ByVal fechasalida As Date, ByVal contraindicaciones As String)
        Me.rut = rut
        Me.nombres = nombres
        Me.apellidos = apellidos
        Me.estadocivil = estadocivil
        Me.sexo = sexo
        Me.edad = edad
        Me.direccion = direccion
        Me.aseguradora = aseguradora
        Me.nombredepto = nombredepto
        Me.numerocamilla = numerocamilla
        Me.fechaingreso = fechaingreso
        Me.fechasalida = fechasalida
        Me.contraindicacion = contraindicaciones
        Return Paciente.insertar(rut, nombres, apellidos, estadocivil, sexo, edad, direccion, aseguradora, nombredepto, numerocamilla, fechaingreso, fechasalida, contraindicaciones)

    End Function















End Class



