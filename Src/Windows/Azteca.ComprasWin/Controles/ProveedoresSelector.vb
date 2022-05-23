Public Class ProveedoresSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New ProveedorFacade
            Me.EditorAssembly = "Azteca.ComprasWin"
            Me.EditorClass = "Azteca.Windows.Compras.ProveedoresForm"
            Me.EditorTitle = "Editar proveedores..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Proveedor As ProveedorInfo = CType(Me.PackageInfo, ProveedorInfo)
        If Proveedor IsNot Nothing Then
            TextInfo = Proveedor.Nombre
            Key = Proveedor.Identity
        End If
    End Sub

End Class
