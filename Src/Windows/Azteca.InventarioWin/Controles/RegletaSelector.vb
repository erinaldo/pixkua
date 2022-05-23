Public Class RegletaSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New RegletaFacade
            Me.EditorAssembly = "Azteca.InventarioWin"
            Me.EditorClass = "Azteca.Windows.Inventario.RegletasForm"
            Me.EditorTitle = "Editar Regleta..."
        End If
    End Sub
    'Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
    '    MyBase.OnLoad(e)
    'End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim info As RegletaInfo = CType(Me.PackageInfo, RegletaInfo)
        If info IsNot Nothing Then
            TextInfo = info.Nombre
            Key = info.Identity
        End If
    End Sub
End Class
