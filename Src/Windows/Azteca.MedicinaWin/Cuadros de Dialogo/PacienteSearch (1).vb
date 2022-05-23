Public Class PacienteSearch
    Private _Cliente As Azteca.Business.Ventas.ClienteInfo = Nothing

    Public ReadOnly Property Cliente As Azteca.Business.Ventas.ClienteInfo
        Get
            Return _Cliente
        End Get
    End Property

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub

    Private Sub Buscar()
        Try
            Dim PacienteFac As New PacienteFacade
            Dim conditions As New Azteca.Kernel.Search.SearchConditionCollection
            Dim order As New Azteca.Kernel.Search.SearchOrderCollection
            Dim Condicion As New Azteca.Kernel.Search.SearchCondition()
            Condicion.Field = "Nombre"
            Condicion.OpCondition = Kernel.Search.Operators.Contenga
            Condicion.Value = txtNombre.Text & "%"
            Condicion.ValueType = GetType(String)
            conditions.Add(Condicion)

            Dim ds As DataSet = PacienteFac.GetSearchResult(App.Session.SessionID, App.DefaultSite.Identity, conditions, order)
            bsPacientes.DataSource = ds.Tables(0)
            grdPacientes.Rebind(True)
        Catch ex As Exception
            Azteca.Windows.Forms.MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyData = Keys.F3 Then
            Buscar()
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombre.TextChanged
        'If txtNombre.Text.Length > 15 Then
        '    Buscar()
        'End If
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Dim item As DataRowView = CType(bsPacientes.Current, DataRowView)

        If IsNothing(item) Then
            MessageBox.Show("No hay un Paciente seleccionado", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Try
            Dim IdPaciente As Integer = CInt(item("IdPaciente"))
            Dim PacienteFac As New PacienteFacade
            Dim Paciente As PacienteInfo = PacienteFac.GetDetail(App.Session.SessionID, IdPaciente)
            _Cliente = Paciente.Cliente
            MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Azteca.Windows.Forms.MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        MyBase.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

   
    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        MyBase.DialogResult = System.Windows.Forms.DialogResult.Retry
    End Sub

    Private Sub grdPacientes_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdPacientes.ButtonClick
        Try
            Dim dr As DataRowView = CType(bsPacientes.Current, DataRowView)
            Dim IdPaciente As Integer = CInt(dr("ID"))
            Dim frmPaciente As New PacientesForm
            If frmPaciente.ShowDialog(IdPaciente, "Editando Paciente") = System.Windows.Forms.DialogResult.OK Then
                Dim PacienteFac As New PacienteFacade
                Dim Paciente As PacienteInfo = PacienteFac.GetDetail(App.Session.SessionID, IdPaciente)
                _Cliente = Paciente.Cliente
                MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            Azteca.Windows.Forms.MsgInfo.Show(ex)
        End Try
    End Sub

End Class