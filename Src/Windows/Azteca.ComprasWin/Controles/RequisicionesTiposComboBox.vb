Public Class RequisicionesTiposComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList(ByVal IdEmpresa As Integer)
        Try
            Dim Fac As New RequisicionFacade
            Dim dtList As DataTable = Fac.TiposList(App.Session.SessionID, App.Session.User.Identity)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdRequisicionTipo"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
