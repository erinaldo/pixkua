Public Class CausaDevolucionComboBox

    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList()
        Try
            Dim CausaDevolucion As New CausaDevolucionFacade
            Dim dtList As DataTable = CausaDevolucion.LoadList(App.Session.SessionID, App.DefaultCompany.Identity)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdCausaDevolucion"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
