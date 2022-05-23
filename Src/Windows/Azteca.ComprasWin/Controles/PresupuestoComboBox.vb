Public Class PresupuestoComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList(ByVal IdEmpresa As Integer)
        Try
            Dim Fac As New PresupuestoFacade
            Dim dtList As DataTable = Fac.LoadList(App.Session.SessionID, IdEmpresa)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdPresupuesto"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
