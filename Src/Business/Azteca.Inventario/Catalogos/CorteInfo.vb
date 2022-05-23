<Serializable()> _
Public Class CorteInfo

#Region "Campos Privados"
    Friend _IdArea As Integer
    Friend _IdTurno As Integer
    Friend _FechaApertura As Date
    Friend _FechaCierre As Date
    Friend _IdUsuarioApertura As Integer
    Friend _IdUsuarioCierre As Integer
    Friend _Cerrado As Boolean
    Friend _Area As String
    Friend _Turno As String
#End Region

#Region "Propiedades"
    Public ReadOnly Property IdArea As Integer
        Get
            Return _IdArea
        End Get
    End Property

    Public ReadOnly Property IdTurno As Integer
        Get
            Return _IdTurno
        End Get
    End Property

    Public ReadOnly Property FechaApertura As Date
        Get
            Return _FechaApertura
        End Get
    End Property

    Public ReadOnly Property FechaCierre As Date
        Get
            Return _FechaCierre
        End Get
    End Property

    Public ReadOnly Property IdUsuarioApertura As Integer
        Get
            Return _IdUsuarioApertura
        End Get
    End Property

    Public ReadOnly Property IdUsuarioCierre As Integer
        Get
            Return _IdUsuarioCierre
        End Get
    End Property

    Public ReadOnly Property Cerrado As Boolean
        Get
            Return _Cerrado
        End Get
    End Property

    Public ReadOnly Property Area As String
        Get
            Return _Area
        End Get
    End Property

    Public ReadOnly Property Turno As String
        Get
            Return _Turno
        End Get
    End Property
#End Region

End Class
