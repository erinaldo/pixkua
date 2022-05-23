Public Class ZonasVentaComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList()
        Try
            Dim Zona As New ZonaVentaFacade
            Dim dtZonas As DataTable = Zona.LoadList(App.Session.SessionID, App.DefaultCompany.Identity)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdZonaVenta"
            _ItemsTable = dtZonas
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overloads Sub LoadList(ByVal idEmpresa As Integer)
        Try
            Dim Zona As New ZonaVentaFacade
            Dim dtZonas As DataTable = Zona.LoadList(App.Session.SessionID, idEmpresa)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdZonaVenta"
            _ItemsTable = dtZonas
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


End Class
