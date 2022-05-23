Public Class CategoriasPresupuestalesComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadListByArticulo()
        LoadListByArticulo(0)
    End Sub


    Public Overloads Sub LoadListByArticulo(idArticuloStock As Integer)
        Try
            Dim Fac As New CategoriaPresupuestalFacade
            Dim dtList As DataTable = Fac.LoadListByArticulo(App.Session.SessionID, idArticuloStock, App.Session.User.Identity)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdCategoriaPresupuestal"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overloads Sub LoadListByServicio(idServicio As Integer)
        Try
            Dim Fac As New CategoriaPresupuestalFacade
            Dim dtList As DataTable = Fac.LoadListByServicio(App.Session.SessionID, idServicio, App.Session.User.Identity)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdCategoriaPresupuestal"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overloads Sub LoadListByServicio()
        LoadListByServicio(0)
    End Sub

End Class
