Public Class TiposArticulosComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList()
        Try
            Dim Tipo As New TipoFacade
            Dim dtList As DataTable = Tipo.LoadList(App.Session.SessionID, App.DefaultCompany.Identity)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdTipo"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
