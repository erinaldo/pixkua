Public Class MetaAlmacenesForm

    Private Sub MetaAlmacenes_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem

    End Sub

    Private Sub MetaAlmacenes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetaAlmacenes_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim MetaAlmacen As MetaAlmacenInfo = CType(PackageInfo, MetaAlmacenInfo)
        With MetaAlmacen
            txtNombre.Text = .Nombre
        End With
    End Sub

    Private Sub MetaAlmacenes_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim MetaAlmacen As MetaAlmacenInfo = CType(PackageInfo, MetaAlmacenInfo)
        With MetaAlmacen
            .Nombre = txtNombre.Text
        End With
    End Sub

End Class