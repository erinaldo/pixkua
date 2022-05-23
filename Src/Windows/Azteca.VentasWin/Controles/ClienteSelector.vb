Public Class ClienteSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New ClienteFacade
            Me.EditorAssembly = "Azteca.VentasWin"
            Me.EditorClass = "Azteca.Windows.Ventas.ClientesForm"
            Me.EditorTitle = "Editar datos de cliente..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Cliente As ClienteInfo = CType(Me.PackageInfo, ClienteInfo)
        If Cliente IsNot Nothing Then
            TextInfo = Cliente.Nombre
            Key = Cliente.Identity
        End If
    End Sub

End Class
