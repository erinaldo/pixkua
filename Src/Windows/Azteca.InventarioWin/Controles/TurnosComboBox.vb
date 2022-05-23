Public Class TurnosComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList()
        Try
            Dim Turno As New TurnoFacade
            Dim dtList As DataTable = Turno.LoadList(App.Session.SessionID)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdTurno"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overloads Sub LoadList(ByVal idArea As Integer)
        Try
            Dim Area As New AreaFacade
            Dim dtList As DataTable = Area.LoadTurnos(App.Session.SessionID, idArea)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdTurno"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
