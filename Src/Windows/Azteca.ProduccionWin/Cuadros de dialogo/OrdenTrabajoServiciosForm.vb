Imports Azteca.Business.Compras


Public Class OrdenTrabajoServiciosForm

    Public Property _ServicioRow As OrdenesTrabajoDS.ServiciosRow
    Private _IdOrdenTrabajo As Integer

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal idOrdenTrabajo As Integer, ByVal servicio As OrdenesTrabajoDS.ServiciosRow) As DialogResult
        _ServicioRow = servicio
        Call loadServicio()
        _IdOrdenTrabajo = idOrdenTrabajo

        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub selArticuloStock_InfoLoaded(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub OrdenTrabajoServiciosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub


#Region "Metodos Privados"
    Private Function isvalid() As Boolean
        If selServicio.Key = 0 Then
            MessageBox.Show("Debe seleccionar un servicio", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        If (txtCantDeseada.Text = "") Then
            MessageBox.Show("Favor de introducir una cantidad", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        If (txtCosto.Text = "") Then
            MessageBox.Show("Favor de introducir un costo mayor o igual a 0", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        Return True
    End Function

    Private Sub loadServicio()
        If _ServicioRow.IsNull("IdServicio") Then Exit Sub

        selServicio.LoadInfo(_ServicioRow.IdServicio)
        txtCantDeseada.Text = _ServicioRow.Cantidad.ToString()
        txtCosto.Text = _ServicioRow.Costo.ToString()

    End Sub



#End Region

    Private Sub selServicio_InfoLoaded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selServicio.InfoLoaded
        Try
            Dim ServicioFac As New ServicioFacade
            Dim ServicioInfo As New ServicioInfo(App.Session.SessionID)

            ServicioInfo = ServicioFac.GetDetail(App.Session.SessionID, selServicio.Key)
            txtCantDeseada.Text = "1"
            txtCosto.Text = ServicioInfo.CostoUltimo.ToString()

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If isvalid() Then

            Dim OTFacade As New OrdenTrabajoFacade()

            With (_ServicioRow)
                .IdServicio = selServicio.Key
                .Nombre = selServicio.TextInfo
                .Cantidad = CDec(txtCantDeseada.Text)
                .Costo = CDec(txtCosto.Text)
            End With

            OTFacade.SaveServicioOT(App.Session.SessionID, _IdOrdenTrabajo, _ServicioRow)

            Me.DialogResult = DialogResult.OK
        End If
    End Sub
End Class