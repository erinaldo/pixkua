Public Class UbicacionTipoCombobox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overrides Sub LoadList()
        Try
            Dim Fac As New UbicacionTipoFacade
            Dim dtList As DataTable = Fac.LoadList(App.Session.SessionID, App.DefaultSite.Identity)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdUbicacionTipo"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
