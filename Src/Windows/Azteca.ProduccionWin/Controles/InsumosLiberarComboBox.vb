Public Class InsumosLiberarComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList(ByVal IdOrdenTrabajo As Integer)
        Try
            Dim InfoFac As New OrdenTrabajoFacade
            Dim dt As OrdenesTrabajoDS.InsumosLiberarCBODataTable = InfoFac.LoadInsumosLiberarCBO(App.Session.SessionID, IdOrdenTrabajo)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdArticuloStock"
            _ItemsTable = dt
            Me.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
