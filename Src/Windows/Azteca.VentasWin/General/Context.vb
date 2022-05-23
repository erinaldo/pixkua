Public NotInheritable Class Context
    Private Sub New()

    End Sub

    Private Shared _UnidadNegocio As UnidadNegocioInfo
    Private Shared _Articulos As New System.Collections.Generic.Dictionary(Of String, Azteca.Business.Inventario.ArticuloStockInfo)
    Private Shared _ArticulosVenta As New System.Collections.Generic.Dictionary(Of Integer, ArticuloInfo)
    Private Shared _Servicios As New System.Collections.Generic.Dictionary(Of String, ServicioInfo)
    Private Shared _UnidadesMedida As New System.Collections.Generic.Dictionary(Of Integer, Azteca.Business.Inventario.UnidadMedidaInfo)

    Public Shared Sub Initialize()
        Dim UnidadFac As New UnidadNegocioFacade
        _UnidadNegocio = UnidadFac.GetDetailByIdSucursal(App.Session.SessionID, App.DefaultSite.Identity)
        _Servicios.Clear()
        _Articulos.Clear()
        _UnidadesMedida.Clear()
    End Sub

    Public Shared ReadOnly Property UnidadNegocio As UnidadNegocioInfo
        Get
            Return _UnidadNegocio
        End Get
    End Property

    Public Shared ReadOnly Property Servicios As System.Collections.Generic.Dictionary(Of String, ServicioInfo)
        Get
            Return _Servicios
        End Get
    End Property

    Public Shared ReadOnly Property Articulos As System.Collections.Generic.Dictionary(Of String, Azteca.Business.Inventario.ArticuloStockInfo)
        Get
            Return _Articulos
        End Get
    End Property

    Public Shared ReadOnly Property UnidadesMedida As System.Collections.Generic.Dictionary(Of Integer, Azteca.Business.Inventario.UnidadMedidaInfo)
        Get
            Return _UnidadesMedida
        End Get
    End Property

    Public Shared ReadOnly Property ArticulosVenta As System.Collections.Generic.Dictionary(Of Integer, ArticuloInfo)
        Get
            Return _ArticulosVenta
        End Get
    End Property

End Class


