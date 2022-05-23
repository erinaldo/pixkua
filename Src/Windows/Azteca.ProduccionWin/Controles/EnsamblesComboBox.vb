Public Class EnsamblesComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList(ByVal IdEmpresa As Integer)
        Try
            Dim InfoFac As New EnsambleFacade
            Dim dt As OrdenesTrabajoDS.EnsamblesCBODataTable = InfoFac.List(App.Session.SessionID, IdEmpresa)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdEnsamble"
            _ItemsTable = dt
            Me.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overloads Sub LoadListByOT(ByVal IdOrdenTrabajo As Integer)
        Try
            Dim InfoFac As New EnsambleFacade
            Dim dt As OrdenesTrabajoDS.EnsamblesCBODataTable = InfoFac.LoadListByOT(App.Session.SessionID, IdOrdenTrabajo)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdEnsamble"
            _ItemsTable = dt
            Me.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
