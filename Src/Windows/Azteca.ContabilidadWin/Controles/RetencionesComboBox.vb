Public Class RetencionesComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList()
        Try
            Dim Retencion As New RetencionFacade
            Dim dtRetenciones As DataTable = Retencion.LoadList(App.Session.SessionID, App.DefaultCompany.Identity)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdRetencion"
            _ItemsTable = dtRetenciones
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
