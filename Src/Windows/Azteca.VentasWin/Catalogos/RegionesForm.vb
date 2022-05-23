Public Class RegionesForm

    Private Sub RegionesForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        chkActivo.Checked = True
    End Sub

    Private Sub RegionesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RegionesForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim RegionInf As RegionInfo = CType(PackageInfo, RegionInfo)
        With RegionInf
            txtNombre.Text = .Nombre
            chkActivo.Checked = (.Status = Kernel.BusinessStructure.CatalogState.Active)
        End With
    End Sub

    Private Sub RegionesForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim RegionInf As RegionInfo = CType(PackageInfo, RegionInfo)
        With RegionInf
            .Nombre = txtNombre.Text
            If chkActivo.Checked Then
                .Status = Kernel.BusinessStructure.CatalogState.Active
            Else
                .Status = Kernel.BusinessStructure.CatalogState.Inactive
            End If
        End With
    End Sub
End Class