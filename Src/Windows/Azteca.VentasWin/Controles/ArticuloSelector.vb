Public Class ArticuloSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New ArticuloFacade
            Me.EditorAssembly = "Azteca.VentasWin"
            Me.EditorClass = "Azteca.Windows.Ventas.ArticulosForm"
            Me.EditorTitle = "Editar datos de articulo..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Articulo As ArticuloInfo = CType(Me.PackageInfo, ArticuloInfo)
        If Articulo IsNot Nothing Then
            TextInfo = Articulo.Nombre
            Key = Articulo.Identity
        End If
    End Sub

End Class
