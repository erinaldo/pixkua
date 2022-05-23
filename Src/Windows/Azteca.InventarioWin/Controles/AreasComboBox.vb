Public Class AreasComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList()
        LoadList(App.DefaultSite.Identity)
    End Sub

    Public Overloads Sub LoadList(ByVal idSucursal As Integer)
        LoadList(idSucursal, 1)
    End Sub

    Public Overloads Sub LoadList(ByVal idSucursal As Integer, ByVal idStatus As Integer)
        Try
            Dim Area As New AreaFacade
            Dim dtList As DataTable = Area.LoadList(App.Session.SessionID, idSucursal)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdArea"
            _ItemsTable = dtList
            If idStatus >= 0 Then FilterExpression = "IdStatus=" & idStatus.ToString
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LoadListByUsuario(ByVal idUsuario As Integer, ByVal idSucursal As Integer)
        Try
            Dim Area As New AreaFacade
            Dim dtList As DataTable = Area.LoadListByUsuario(App.Session.SessionID, idUsuario, idSucursal)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdArea"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LoadListByUsuario(ByVal idUsuario As Integer)
        LoadListByUsuario(idUsuario, 0)
    End Sub


End Class
