Public Class bllDiagnostico
    Dim _diag As Integer
    Dim _rutmedico As String
    Dim _rutpaciente As String
    Dim _diagnostico As String
    Dim _receta As String

    Dim ddco As New dalDiagnostico

    Public Sub New()
        ddco = New dalDiagnostico

    End Sub


    Public Property diag() As Integer
        Get
            Return _diag
        End Get
        Set(value As Integer)
            value = _diag
        End Set
    End Property


    Public Property rutmedico() As String
        Get
            Return _rutmedico
        End Get
        Set(value As String)
            value = _rutmedico
        End Set
    End Property

    Public Property rutpaciente() As String
        Get
            Return _rutpaciente

        End Get
        Set(value As String)
            value = _rutpaciente
        End Set
    End Property


    Public Property diagnosticof() As String
        Get
            Return _diagnostico

        End Get
        Set(value As String)
            value = _diagnostico
        End Set
    End Property


    Public Property receta() As String
        Get
            Return _receta

        End Get
        Set(value As String)
            value = _receta
        End Set
    End Property


    Public Sub New(ByVal diag As Integer, ByVal rutmedico As String, ByVal rutpaciente As String, ByVal diagnostico As String, ByVal receta As String)
        Me.diag = diag
        Me.rutmedico = rutmedico
        Me.rutpaciente = rutpaciente
        Me.diagnosticof = diagnostico
        Me.receta = receta
    End Sub

    Public Function insertar(ByVal diag As String, ByVal rutmedico As String, ByVal rutpaciente As String, ByVal diagnostico As String, ByVal receta As String) As Integer
        Me.diag = diag
        Me.rutmedico = rutmedico
        Me.rutpaciente = rutpaciente
        Me.diagnosticof = diagnostico
        Me.receta = receta
        Return ddco.insertar(diag, rutmedico, rutpaciente, diagnostico, receta)
    End Function

End Class
