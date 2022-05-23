Public Class ChequerasComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList(idCaja As Integer)
        Try
            Dim CajaFac As New CajaFacade
            Dim dt As DataTable = CajaFac.ChequerasList(App.Session.SessionID, idCaja)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdChequera"
            _ItemsTable = dt
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
