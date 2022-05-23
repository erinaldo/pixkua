Public NotInheritable Class ArticuloCostoInfo

    Public Sub New()
        _CostoMaterial = 0
        _CostoCarga = 0
        _CostoLabor = 0
        _CostoServicio = 0
        _BaseCalculo = String.Empty
        _CostoMaterialBase = 0
        _CostoCargaBase = 0
        _CostoLaborBase = 0
        _CostoServicioBase = 0
    End Sub

#Region "Campos Privados"
    Friend _IdArticuloStock As Integer
    Friend _CostoMaterial As Decimal
    Friend _CostoCarga As Decimal
    Friend _CostoLabor As Decimal
    Friend _CostoServicio As Decimal
    Friend _BaseCalculo As String
    Friend _CostoMaterialBase As Decimal
    Friend _CostoCargaBase As Decimal
    Friend _CostoLaborBase As Decimal
    Friend _CostoServicioBase As Decimal
#End Region

#Region "Propiedades"

    


    Public ReadOnly Property BaseCalculo As String
        Get
            Return _BaseCalculo
        End Get
    End Property

    Public ReadOnly Property IdArticuloStock As Integer
        Get
            Return _IdArticuloStock
        End Get
    End Property

    Public ReadOnly Property CostoMaterial As Decimal
        Get
            Return _CostoMaterial
        End Get
    End Property

    Public ReadOnly Property CostoLabor As Decimal
        Get
            Return _CostoLabor
        End Get
    End Property

    Public ReadOnly Property CostoCarga As Decimal
        Get
            Return _CostoCarga
        End Get
    End Property

    Public ReadOnly Property CostoServicio As Decimal
        Get
            Return _CostoServicio
        End Get
    End Property

    Public ReadOnly Property CostoTotal As Decimal
        Get
            Return _CostoMaterial + _CostoCarga + _CostoLabor + _CostoServicio
        End Get
    End Property

    Public ReadOnly Property CostoMaterialBase As Decimal
        Get
            Return _CostoMaterialBase
        End Get
    End Property

    Public ReadOnly Property CostoLaborBase As Decimal
        Get
            Return _CostoLaborBase
        End Get
    End Property

    Public ReadOnly Property CostoCargaBase As Decimal
        Get
            Return _CostoCargaBase
        End Get
    End Property

    Public ReadOnly Property CostoServicioBase As Decimal
        Get
            Return _CostoServicioBase
        End Get
    End Property
#End Region




End Class
