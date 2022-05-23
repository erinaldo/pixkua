Public Class IncidenciasComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList(ByVal IdEmpresa As Integer)
        Try
            Dim InfoFac As New IncidenciaFacade
            Dim dt As OrdenesTrabajoDS.IncidenciasCBODataTable = InfoFac.LoadList(App.Session.SessionID)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdIncidencia"
            _ItemsTable = dt
            Me.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    

End Class
