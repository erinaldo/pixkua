Public Class UbicacionSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New UbicacionFacade
            Me.EditorAssembly = "Azteca.InventarioWin"
            Me.EditorClass = "Azteca.Windows.Inventario.UbicacionForm"
            Me.EditorTitle = "Editar nodo de ubicacion..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Ubic As UbicacionInfo = CType(Me.PackageInfo, UbicacionInfo)
        If Ubic IsNot Nothing Then
            TextInfo = Ubic.NamedPath
            Key = Ubic.Identity
        End If
    End Sub

    Protected Overrides Sub OnSearchingItem(ByVal e As System.EventArgs)
        Dim frmSearch As New Azteca.Windows.Forms.MsgHierarchyForm
        Dim Hierarchy As IHierarchyFacade = CType(Facade, IHierarchyFacade)
        If frmSearch.ShowDialog(Hierarchy, Facade) = DialogResult.OK Then
            Text = frmSearch.SelectedId.ToString
            LoadInfo()
        End If
    End Sub
End Class
