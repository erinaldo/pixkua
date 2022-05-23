Public Class ZonasComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList(ByVal IdEmpresa As Integer)
        Try
            Dim Fac As New ZonaCompraFacade
            Dim dtList As DataTable = Fac.LoadList(App.Session.SessionID, IdEmpresa)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdZonaCompra"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
