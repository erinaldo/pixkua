Public Class EjercicioFiscalCombobox
    Inherits Azteca.Windows.Controls.AZComboBox

    Public Overloads Sub LoadList(ByVal idEmpresa As Integer)
        Try
            Dim EjercicioFac As New EjercicioFiscalFacade
            Dim dtList As DataTable = EjercicioFac.LoadList(App.Session.SessionID, idEmpresa)
            DisplayMember = "Ejercicio"
            ValueMember = "IdEjercicioFiscalTit"
            HoldFields()
            DataSource = dtList
            Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class
