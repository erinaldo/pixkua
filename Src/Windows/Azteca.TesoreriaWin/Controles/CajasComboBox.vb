Public Class CajasComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList()
        Try
            Dim CajaFac As New CajaFacade
            Dim dt As DataTable = CajaFac.List(App.Session.SessionID, App.DefaultCompany.Identity)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdCaja"
            _ItemsTable = dt
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overloads Sub LoadList(IdUsuario As Integer)
        Try
            Dim CajaFac As New CajaFacade
            Dim dt As DataTable = CajaFac.LoadList(App.Session.SessionID, IdUsuario)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdCaja"
            _ItemsTable = dt
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


End Class
