Public Class ArticuloStockSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New ArticuloStockFacade
            Me.EditorAssembly = "Azteca.InventarioWin"
            Me.EditorClass = "Azteca.Windows.Inventario.ArticulosStockForm"
            Me.EditorTitle = "Editar Articulos de inventario..."
        End If
    End Sub
    'Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
    '    MyBase.OnLoad(e)
    'End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim ArtStock As ArticuloStockInfo = CType(Me.PackageInfo, ArticuloStockInfo)
        If ArtStock IsNot Nothing Then
            TextInfo = ArtStock.Nombre
            Key = ArtStock.Identity
        End If
    End Sub

End Class
