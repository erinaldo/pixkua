Public Class BancosComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList()
        Try
            Dim BancoFac As New BancoFacade
            Dim dt As DataTable = BancoFac.List(App.Session.SessionID, App.DefaultCompany.Identity)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdBanco"
            _ItemsTable = dt
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
