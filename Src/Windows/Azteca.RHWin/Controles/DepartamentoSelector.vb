Public Class DepartamentoSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New DepartamentoFacade
            Me.EditorAssembly = "Azteca.RHWin"
            Me.EditorClass = "Azteca.Windows.RH.DepartamentosForm"
            Me.EditorTitle = "Editar nodo de estructura comercial..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Depto As DepartamentoInfo = CType(Me.PackageInfo, DepartamentoInfo)
        If Depto IsNot Nothing Then
            TextInfo = Depto.NamedPath
            Key = Depto.Identity
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
