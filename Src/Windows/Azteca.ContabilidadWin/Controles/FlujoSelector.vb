Public Class FlujoSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New FlujoFacade
            Me.EditorAssembly = "Azteca.ContabilidadWin"
            Me.EditorClass = "Azteca.Windows.Contabilidad.FlujoForm"
            Me.EditorTitle = "Editar nodo de Flujo..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Flujo As FlujoInfo = CType(Me.PackageInfo, FlujoInfo)
        If Flujo IsNot Nothing Then
            TextInfo = Flujo.NamedPath
            Key = Flujo.Identity
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
