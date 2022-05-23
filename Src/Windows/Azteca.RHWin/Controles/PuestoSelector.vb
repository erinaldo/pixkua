Public Class PuestoSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New PuestoFacade
            Me.EditorAssembly = "Azteca.RHWin"
            Me.EditorClass = "Azteca.Windows.RH.PuestosForm"
            Me.EditorTitle = "Editar nodo de estructura comercial..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Puesto As PuestoInfo = CType(Me.PackageInfo, PuestoInfo)
        If Puesto IsNot Nothing Then
            TextInfo = Puesto.NamedPath
            Key = Puesto.Identity
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
