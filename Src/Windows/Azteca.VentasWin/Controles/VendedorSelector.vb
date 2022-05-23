Public Class VendedorSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New VendedorFacade
            Me.EditorAssembly = "Azteca.VentasWin"
            Me.EditorClass = "Azteca.Windows.Ventas.VendedoresForm"
            Me.EditorTitle = "Editar datos de vendedor..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Vendedor As VendedorInfo = CType(Me.PackageInfo, VendedorInfo)
        If Vendedor IsNot Nothing Then
            TextInfo = Vendedor.Empleado.Persona.ApellidoP & " " & Vendedor.Empleado.Persona.ApellidoM & " " & Vendedor.Empleado.Persona.Nombre
            Key = Vendedor.Identity
        End If
    End Sub

End Class
