Public Class ImpuestosComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList()
        Try
            Dim Impuesto As New ImpuestoFacade
            Dim dtImpuestos As DataTable = Impuesto.LoadList(App.Session.SessionID)
            Me.DisplayMember = "Abrev"
            Me.ValueMember = "IdImpuesto"
            _ItemsTable = dtImpuestos
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
