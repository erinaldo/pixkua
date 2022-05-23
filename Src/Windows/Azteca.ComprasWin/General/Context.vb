Public NotInheritable Class Context
    Private Shared _UnidadesMedida As New System.Collections.Generic.Dictionary(Of Integer, Azteca.Business.Inventario.UnidadMedidaInfo)
    Private Shared _IdZonaCompra As Integer

    Public Shared Sub Initialize()
        _UnidadesMedida.Clear()
    End Sub

    Public Shared ReadOnly Property UnidadesMedida As System.Collections.Generic.Dictionary(Of Integer, Azteca.Business.Inventario.UnidadMedidaInfo)
        Get
            Return _UnidadesMedida
        End Get
    End Property

End Class
