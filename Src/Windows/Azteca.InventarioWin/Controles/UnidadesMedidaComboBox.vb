Public Class UnidadesMedidaComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList()
        Try
            Dim UnidadMedida As New UnidadMedidaFacade
            Dim dtList As DataTable = UnidadMedida.LoadList(App.Session.SessionID)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdUnidadMedida"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
