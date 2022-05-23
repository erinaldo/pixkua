Public Class PeriodoComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList(ByVal IdEmpresa As Integer)
        Try
            Dim Fac As New PeriodoFacade
            Dim dtList As DataTable = Fac.LoadList(App.Session.SessionID, IdEmpresa)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdPeriodo"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
