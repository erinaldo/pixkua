Public Class ProductoSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New ProductoFacade
            Me.EditorAssembly = "Azteca.ProduccionWin"
            Me.EditorClass = "Azteca.Windows.Produccion.ProductosForm"
            Me.EditorTitle = "Editar Productos..."
        End If
    End Sub
    'Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
    '    MyBase.OnLoad(e)
    'End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim info As ProductoInfo = CType(Me.PackageInfo, ProductoInfo)
        If info IsNot Nothing Then
            TextInfo = info.Nombre
            Key = info.Identity
        End If
    End Sub
End Class
