Public Class EstructuraComercialSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New EstructuraComercialFacade
            Me.EditorAssembly = "Azteca.VentasWin"
            Me.EditorClass = "Azteca.Windows.Ventas.EstComercialForm"
            Me.EditorTitle = "Editar nodo de estructura comercial..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim EstCom As EstructuraComercialInfo = CType(Me.PackageInfo, EstructuraComercialInfo)
        If EstCom IsNot Nothing Then
            TextInfo = EstCom.NamedPath
            Key = EstCom.Identity
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
