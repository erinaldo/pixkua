Public Class ConceptoGastosComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList(IdDepartamento As Integer)
        Try
            Dim Fac As New DepartamentoFacade
            Dim dtList As DataTable = Fac.LoadConceptos(App.Session.SessionID, IdDepartamento)
            Me.DisplayMember = "Concepto"
            Me.ValueMember = "IdGastoConcepto"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
