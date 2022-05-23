Public Class ListaPreciosSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New ListaPreciosFacade
            Me.EditorAssembly = "Azteca.VentasWin"
            Me.EditorClass = "Azteca.Windows.Ventas.ListaPreciosForm"
            Me.EditorTitle = "Editar datos de Lista de precios..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim ListaPrecios As ListaPreciosInfo = CType(Me.PackageInfo, ListaPreciosInfo)
        If ListaPrecios IsNot Nothing Then
            TextInfo = ListaPrecios.Nombre
            Key = ListaPrecios.Identity
        End If
    End Sub

End Class
