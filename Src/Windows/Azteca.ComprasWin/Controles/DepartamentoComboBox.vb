Public Class DepartamentoComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList()
        Try
            Dim Fac As New DepartamentoFacade
            Dim dtList As DataTable = Fac.LoadList(App.Session.SessionID, App.DefaultCompany.Identity, App.Session.User.Identity)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdDepartamento"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
