Public Class CategoriasComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList()
        LoadList(App.DefaultSite.Identity)
    End Sub

    Public Overloads Sub LoadList(ByVal idSucursal As Integer)
        LoadList(idSucursal, 1)
    End Sub

    Public Overloads Sub LoadList(ByVal idSucursal As Integer, ByVal idStatus As Integer)
        Try
            Dim Categoria As New CategoriaFacade
            Dim dtList As DataTable = Categoria.LoadList(App.Session.SessionID, idSucursal)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdCategoria"
            _ItemsTable = dtList
            ''If idStatus >= 0 Then FilterExpression = "IdStatus=" & idStatus.ToString
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
