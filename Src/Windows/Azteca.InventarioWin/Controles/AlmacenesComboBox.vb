Public Class AlmacenesComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overrides Sub LoadList()
        Try
            Dim Almacen As New AlmacenFacade
            Dim dtList As DataTable = Almacen.LoadList(App.Session.SessionID, App.DefaultSite.Identity)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdAlmacen"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overloads Sub LoadList(ByVal idSucursal As Integer)
        Try
            Dim Almacen As New AlmacenFacade
            Dim dtList As DataTable = Almacen.LoadList(App.Session.SessionID, idSucursal)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdAlmacen"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overloads Sub LoadList(ByVal idSucursal As Integer, ByVal idUsuario As Integer, ByVal acceso As TipoAccesoAlmacen)
        Try
            Dim Almacen As New AlmacenFacade
            Dim dtList As DataTable = Almacen.LoadList(App.Session.SessionID, idSucursal, idUsuario, acceso)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdAlmacen"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LoadListByArea(ByVal idArea As Integer)
        Try
            Dim Almacen As New AlmacenFacade
            Dim dtList As DataTable = Almacen.LoadListByArea(App.Session.SessionID, idArea)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdAlmacen"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LoadListByArea(ByVal idArea As Integer, ByVal idUsuario As Integer, ByVal acceso As TipoAccesoAlmacen)
        Try
            Dim Almacen As New AlmacenFacade
            Dim dtList As DataTable = Almacen.LoadListByArea(App.Session.SessionID, idArea, idUsuario, acceso)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdAlmacen"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
