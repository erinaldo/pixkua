Public Class MaestroIngEnsamblesForm

    Public Property EnsambleRow As MaestrosIngDS.EnsamblesRow
    Private _IdMaestroIng As Integer

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal idMaestroIng As Integer, ByVal ensamble As MaestrosIngDS.EnsamblesRow) As DialogResult
        EnsambleRow = ensamble
        cboEnsamble.LoadList(App.DefaultCompany.Identity)
        Call loadEnsamble()
        _IdMaestroIng = idMaestroIng
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub CiLabel2_Click(sender As System.Object, e As System.EventArgs) Handles CiLabel2.Click

    End Sub

    Private Sub CiTextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtKgMin.TextChanged

    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If isvalid() Then

            Dim OTFacade As New MaestroIngFacade()

            With (_EnsambleRow)
                .IdEnsamble = CInt(cboEnsamble.SelectedValue)
                .NombreEnsamble = cboEnsamble.Text
                .Orden = CShort(txtOrden.Text)
            End With

            'OTFacade.SaveEnsambleOT(App.Session.SessionID, _IdOrdenTrabajo, _EnsambleRow)

            Me.DialogResult = DialogResult.OK
        End If
    End Sub

#Region "Metodos Privados"
    Private Function isvalid() As Boolean
        If CInt(cboEnsamble.SelectedValue) > 0 Then
            Return True
        Else
            MessageBox.Show("Debe seleccionar un ensamble", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
    End Function

    Private Sub loadEnsamble()
        If _EnsambleRow.IsNull("IdEnsamble") Then Exit Sub
        cboEnsamble.SelectedValue = _EnsambleRow.IdEnsamble
        txtOrden.Text = _EnsambleRow.Orden.ToString()
    End Sub

#End Region

    Private Sub MaestroIngEnsamblesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel

    End Sub
End Class