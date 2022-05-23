Public Class EmpleadoSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New EmpleadoFacade
            Me.EditorAssembly = "Azteca.RHWin"
            Me.EditorClass = "Azteca.Windows.RH.EmpleadosForm"
            Me.EditorTitle = "Editar datos de articulo..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Empleado As EmpleadoInfo = CType(Me.PackageInfo, EmpleadoInfo)
        If Empleado IsNot Nothing Then
            TextInfo = Empleado.Persona.ApellidoP & " " & Empleado.Persona.ApellidoM & " " & Empleado.Persona.Nombre
            Key = Empleado.Identity
        End If
    End Sub

End Class
