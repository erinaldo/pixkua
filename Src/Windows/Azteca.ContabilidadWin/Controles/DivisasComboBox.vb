Public Class DivisasComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList()
        Try
            Dim Divisa As New DivisaFacade
            Dim dtDivisas As DataTable = Divisa.LoadList(App.Session.SessionID)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdDivisa"
            _ItemsTable = dtDivisas
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
