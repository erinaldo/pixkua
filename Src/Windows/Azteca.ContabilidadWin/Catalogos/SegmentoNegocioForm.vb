Public Class SegmentoNegocioForm

    Private Sub SegmentoNegocioForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As SegmentoNegocioInfo = CType(Me.PackageInfo, SegmentoNegocioInfo)
        With info
            txtNombre.Text = .Descripcion
           
        End With

    End Sub

    Private Sub SegmentoNegocioForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As SegmentoNegocioInfo = CType(Me.PackageInfo, SegmentoNegocioInfo)
        With info
            .Descripcion = txtNombre.Text
           
        End With
    End Sub

End Class