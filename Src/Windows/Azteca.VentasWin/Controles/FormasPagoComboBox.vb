Public Class FormasPagoComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList()
        Try
            Dim FormaPago As New FormaPagoFacade
            Dim dtFormasPago As DataTable = FormaPago.LoadList(App.Session.SessionID)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdFormaPago"
            _ItemsTable = dtFormasPago
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
