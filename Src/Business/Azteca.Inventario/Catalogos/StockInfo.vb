<Serializable()> _
Public NotInheritable Class StockInfo

    Friend Sub New()

    End Sub

    Friend _Disponible As Decimal
    Friend _Apartado As Decimal
    Friend _Transito As Decimal
    Friend _CostoPromedio As Decimal
    Friend _UltimoCosto As Decimal
    Friend _Ubicacion As String

    Public ReadOnly Property Disponible As Decimal
        Get
            Return _Disponible
        End Get
    End Property

    Public ReadOnly Property Apartado As Decimal
        Get
            Return _Apartado
        End Get
    End Property

    Public ReadOnly Property Existencia As Decimal
        Get
            Return _Disponible + _Apartado
        End Get
    End Property

    Public ReadOnly Property Transito As Decimal
        Get
            Return _Transito
        End Get
    End Property

    Public ReadOnly Property CostoPromedio As Decimal
        Get
            Return _CostoPromedio
        End Get
    End Property

    Public ReadOnly Property UltimoCosto As Decimal
        Get
            Return _UltimoCosto
        End Get
    End Property

    Public ReadOnly Property Ubicacion As String
        Get
            Return _Ubicacion
        End Get
    End Property
End Class
