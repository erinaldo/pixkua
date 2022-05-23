Public Class GrupoDescuentosSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New GrupoDescuentosFacade
            Me.EditorAssembly = "Azteca.VentasWin"
            Me.EditorClass = "Azteca.Windows.Ventas.GrupoDescuentosForm"
            Me.EditorTitle = "Editar datos de Grupo de Descuentos..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim gpoDescuentos As GrupoDescuentosInfo = CType(Me.PackageInfo, GrupoDescuentosInfo)
        If gpoDescuentos IsNot Nothing Then
            TextInfo = gpoDescuentos.Nombre
            Key = gpoDescuentos.Identity
        End If
    End Sub

End Class
