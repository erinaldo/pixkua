Public Class TurnosForm

    Private Sub TurnosForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem

    End Sub

    Private Sub TurnosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpHoraIni.Value = Date.Now
        dtpHoraFin.Value = Date.Now
    End Sub

    Private Sub TurnosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Turno As TurnoInfo = CType(PackageInfo, TurnoInfo)
        With Turno
            txtNombre.Text = .Nombre
            dtpHoraIni.Value = .HoraInicial
            dtpHoraFin.Value = .HoraFinal
        End With
    End Sub

    Private Sub TurnosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Turno As TurnoInfo = CType(PackageInfo, TurnoInfo)
        With Turno
            .Nombre = txtNombre.Text
            .HoraInicial = dtpHoraIni.Value
            .HoraFinal = dtpHoraFin.Value
        End With
    End Sub

End Class