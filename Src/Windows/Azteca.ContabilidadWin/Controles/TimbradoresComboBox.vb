Public Class TimbradoresComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList()
        Try
            Dim Timbrador As New TimbradorFacade
            Dim dtList As DataTable = Timbrador.LoadList(App.Session.SessionID)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdTimbrador"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
