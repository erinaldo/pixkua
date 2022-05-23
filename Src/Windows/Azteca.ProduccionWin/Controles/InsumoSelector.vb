Public Class InsumoSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New InsumoFacade
            Me.EditorAssembly = "Azteca.ProduccionWin"
            Me.EditorClass = "Azteca.Windows.Produccion.InsumosForm"
            Me.EditorTitle = "Editar insumos..."
        End If
    End Sub
    'Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
    '    MyBase.OnLoad(e)
    'End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim info As InsumoInfo = CType(Me.PackageInfo, InsumoInfo)
        If info IsNot Nothing Then
            TextInfo = info.Nombre
            Key = info.Identity
        End If
    End Sub


End Class
