Public Class ClasificacionesConceptosComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overrides Sub LoadList()
        Try
            Dim Clasificacion As New ClasificacionConceptoFacade
            Dim dtList As DataTable = Clasificacion.LoadList(App.Session.SessionID, App.DefaultCompany.Identity)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdConceptoClasificacion"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
