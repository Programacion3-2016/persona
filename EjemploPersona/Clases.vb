Public Class Persona

    Private vNombreyApellido As String
    Private vDNI As Integer
    Private vFechaDeNacimiento As Date
    Private vSexo As String

    'Dim Altura As Double
    'Dim Peso As Double
    Public Property NombreyApellido() As String
        Get
            Return vNombreyApellido
        End Get
        Set(ByVal value As String)
            vNombreyApellido = value
        End Set
    End Property

    Public Property DNI() As String
        Get
            Return vDNI
        End Get
        Set(ByVal pDNI As String)
            vDNI = pDNI
        End Set
    End Property

    Public Property Sexo() As String
        Get
            Return IIf(vSexo = "M", "Masculino", "Femenino")
        End Get
        Set(ByVal pSexo As String)
            vSexo = UCase(Mid(pSexo, 1, 1))
        End Set
    End Property

    Public Property FechaDeNacimiento() As Date
        Get
            Return vFechaDeNacimiento
        End Get
        Set(ByVal pFecha As Date)
            vFechaDeNacimiento = pFecha
        End Set
    End Property

    '''<summary>Es una función que me permite...</summary> 
    Public Function DecirNombre() As String

        Return NombreyApellido
    End Function

    Public Function DecirNombreCortesia() As String

        If vSexo = "M" Then
            Return "Sr. " + NombreyApellido
        Else
            Return "Sra. " + NombreyApellido
        End If

    End Function

    '''<summary>Es una función que me permite calcular la edad en base a la fecha de nacimiento</summary> 
    '''<returns>Esta funcion retorna un valor entero.</returns>
    Public Function Edad() As Integer

        Return DateAndTime.DateDiff(DateInterval.Year, vFechaDeNacimiento, Now)

    End Function

    Public Sub New(Nombre As String, Apellido As String, pSexo As String)
        NombreyApellido = Nombre + " " + Apellido
        vSexo = pSexo
        MsgBox("Este es el constructor de Persona " + NombreyApellido)
    End Sub

    Public Sub New()
        MsgBox("Constructor Sobrecargdo")

    End Sub


End Class

Public Class Empleado
    Public Overridable Function Sumar(a As Integer, b As Integer) As Integer
        Return a + b
    End Function

    Public Sub New()

    End Sub

End Class