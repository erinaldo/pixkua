Public NotInheritable Class Context

    Private Sub New()

    End Sub

    Public Shared Property Articulos As New System.Collections.Generic.Dictionary(Of String, ArticuloStockInfo)
    Public Shared Property UnidadesMedida As New System.Collections.Generic.Dictionary(Of Integer, UnidadMedidaInfo)

    Public Shared Sub Initialize()
        Articulos.Clear()
        UnidadesMedida.Clear()
    End Sub

End Class
