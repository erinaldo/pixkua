Public Class OrdenTrabajoSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New OrdenTrabajoFacade
            Me.EditorAssembly = "Azteca.ProduccionWin"
            Me.EditorClass = "Azteca.Windows.Produccion.OrdenesTrabajoForm"
            Me.EditorTitle = "Editar Orden de Trabajo..."
        End If
    End Sub
    'Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
    '    MyBase.OnLoad(e)
    'End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim info As OrdenTrabajoInfo = CType(Me.PackageInfo, OrdenTrabajoInfo)
        If info IsNot Nothing Then
            TextInfo = info.Nombre
            Key = info.Identity
        End If
    End Sub

End Class
