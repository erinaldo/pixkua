Public Class UbicacionesHierarchyForm
    Private _IdAlmacen As Integer
    Public Overloads Function showdialog(idAlmacen As Integer) As DialogResult
        _IdAlmacen = idAlmacen
        Dim UbicacionesFac As New UbicacionFacade
        Return MyBase.ShowDialog(UbicacionesFac, UbicacionesFac)
    End Function

    Protected Overrides Function LoadChilds() As Kernel.BusinessStructure.HierarchyDS.HierarchyDataTable
        Dim UbicacionesFac As New UbicacionFacade

        Return UbicacionesFac.LoadChildsFirst(App.Session.SessionID, App.DefaultCompany.Identity, 0, _IdAlmacen)
    End Function

End Class