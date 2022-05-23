Public Class SacerdotesComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList(ByVal idSucursal As Integer)
        Try
            Dim Sacerdote As New SacerdoteFacade
            Dim dtSacerdotes As DataTable = Sacerdote.LoadList(App.Session.SessionID, idSucursal)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdSacerdote"
            _ItemsTable = dtSacerdotes
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
