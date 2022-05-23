Public Class OrdenesTrabajoEnsamblesForm
    Public Property EnsambleRow As OrdenesTrabajoDS.EnsamblesRow
    Private _IdOrdenTrabajo As Integer

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal idOrdenTrabajo As Integer, ByVal ensamble As OrdenesTrabajoDS.EnsamblesRow) As DialogResult
        EnsambleRow = ensamble
        cboEnsamble.LoadList(App.DefaultCompany.Identity)
        Call loadEnsamble()
        _IdOrdenTrabajo = idOrdenTrabajo
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Try
            If isvalid() Then

                Dim OTFacade As New OrdenTrabajoFacade()

                With (_EnsambleRow)
                    .IdEnsamble = CInt(cboEnsamble.SelectedValue)
                    .NombreEnsamble = cboEnsamble.Text
                    .Orden = CShort(txtOrden.Text)
                    .HorasMaquina = Decimal.Parse(txtHorasMaquina.Text)
                    .CostoMaquina = Decimal.Parse(txtCostoMaquina.Text)
                    .HorasLabor = Decimal.Parse(txtHorasLabor.Text)
                    .CostoLabor = Decimal.Parse(txtCostoLabor.Text)
                End With

                OTFacade.SaveEnsambleOT(App.Session.SessionID, _IdOrdenTrabajo, _EnsambleRow)

                Me.DialogResult = DialogResult.OK
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
        

    End Sub

#Region "Metodos Privados"
    Private Function isvalid() As Boolean
        Dim res As Boolean = True

        If CInt(cboEnsamble.SelectedValue) = 0 Then
            res = False
            MessageBox.Show("Debe seleccionar un ensamble", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If


        If txtOrden.Text = String.Empty Or Not IsNumeric(txtOrden.Text) Then
            res = False
            MessageBox.Show("Introduce el numero de orden(secuencia) del ensamble", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If


        Return res
    End Function

    Private Sub loadEnsamble()
        If _EnsambleRow.IsNull("IdEnsamble") Then Exit Sub
        cboEnsamble.SelectedValue = _EnsambleRow.IdEnsamble
        txtOrden.Text = _EnsambleRow.Orden.ToString()
        txtHorasMaquina.Text = _EnsambleRow.HorasMaquina.ToString()
        txtCostoMaquina.Text = EnsambleRow.CostoMaquina.ToString()
        txtHorasLabor.Text = EnsambleRow.HorasLabor.ToString()
        txtCostoLabor.Text = EnsambleRow.CostoLabor.ToString()

    End Sub

    Private Sub CargarCostosEnsamble()
        Dim EnsambleInfo As New EnsambleInfo(App.Session.SessionID)
        Dim EnsambleFac As New EnsambleFacade()

        Dim IdEnsamble As Integer = CInt(cboEnsamble.SelectedValue)
        EnsambleInfo = EnsambleFac.GetDetail(App.Session.SessionID, IdEnsamble)

        txtHorasMaquina.Text = EnsambleInfo.HorasMaquina.ToString()
        txtCostoMaquina.Text = EnsambleInfo.CostoMaquina.ToString()
        txtHorasLabor.Text = EnsambleInfo.HorasLabor.ToString()
        txtCostoLabor.Text = EnsambleInfo.CostoLabor.ToString()
    End Sub

#End Region

    Private Sub OrdenesTrabajoEnsamblesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            If (cboEnsamble.SelectedValue > 0) Then
                Call CargarCostosEnsamble()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

        
    End Sub



    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cboEnsamble_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEnsamble.SelectedIndexChanged
        Try
            If (cboEnsamble.SelectedValue > 0) Then
                Call CargarCostosEnsamble()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub
End Class