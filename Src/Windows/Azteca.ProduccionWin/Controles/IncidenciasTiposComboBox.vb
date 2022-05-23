Public Class IncidenciasTiposComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList(ByVal IdEmpresa As Integer)
        Try
            Dim InfoFac As New IncidenciaTipoFacade
            Dim dt As IncidenciasDS.TiposDataTable = InfoFac.List(App.Session.SessionID, IdEmpresa)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdIncidenciaTipo"
            _ItemsTable = dt
            Me.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
