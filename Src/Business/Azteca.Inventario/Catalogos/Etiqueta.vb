Public Class Etiqueta
    Public Property OrdenCompra As String
    Public Property CodigoArticulo As String
    Public Property DescArticulo As String
    Public Property CodigoProveedor As String
    Public Property NombreProveedor As String
    Public Property Cantidad As Decimal
    Public Property UnidMedida As String
    Public Property LineaArticulo As String
    Public Property LoteArticulo As String
    Public Property Etiqueta As Integer
    Public Property Reimpresion As Boolean
    Public Property LabelEtiqueta As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal oCompra As String,
                   ByVal cArticulo As String,
                   ByVal dArticulo As String,
                   ByVal cProveedor As String,
                   ByVal nProveedor As String,
                   ByVal cant As Decimal,
                   ByVal uMedida As String,
                   ByVal linArticulo As String,
                   ByVal lotArticulo As String,
                   ByVal iEtiqueta As Integer,
                   ByVal reimEtiqueta As Boolean,
                   ByVal lblEtiqueta As String)
        OrdenCompra = oCompra
        CodigoArticulo = cArticulo
        DescArticulo = dArticulo
        CodigoProveedor = cProveedor
        NombreProveedor = nProveedor
        Cantidad = cant
        UnidMedida = uMedida
        LineaArticulo = linArticulo
        LoteArticulo = lotArticulo
        Etiqueta = iEtiqueta
        Reimpresion = reimEtiqueta
        LabelEtiqueta = lblEtiqueta
    End Sub
End Class

