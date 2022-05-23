Public Class CentralComprasComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList(ByVal IdEmpresa As Integer)
        Try
            Dim Fac As New CentralFacade
            Dim dtList As DataTable = Fac.List(App.Session.SessionID, IdEmpresa)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdCentral"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
