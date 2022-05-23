Public Class RegionesComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList()
        Try
            Dim Region As New RegionFacade
            Dim dtRegiones As DataTable = Region.LoadList(App.Session.SessionID, App.DefaultCompany.Identity)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdRegion"
            _ItemsTable = dtRegiones
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overloads Sub LoadList(ByVal idEmpresa As Integer)
        Try
            Dim Region As New RegionFacade
            Dim dtRegiones As DataTable = Region.LoadList(App.Session.SessionID, idEmpresa)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdRegion"
            _ItemsTable = dtRegiones
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
