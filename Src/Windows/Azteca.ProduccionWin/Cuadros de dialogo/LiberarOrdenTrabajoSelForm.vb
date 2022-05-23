Public Class LiberarOrdenTrabajoSelForm



    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal OTInfo As OrdenTrabajoInfo) As DialogResult
        Dim OTFacade As New OrdenTrabajoFacade()
        Dim InsumosLiberarDT As OrdenesTrabajoDS.InsumosLiberarDataTable = OTFacade.LoadInsumosLiberar(App.Session.SessionID, OTInfo.Identity)
        bsInsumos.DataSource = InsumosLiberarDT
        grdInsumosLiberar.Rebind(True)

        Dim EnsambleFac As New EnsambleFacade()
        Dim EnsambleInfo As New EnsambleInfo(App.Session.SessionID)

        EnsambleInfo = EnsambleFac.GetDetail(App.Session.SessionID, OTInfo.EnsambleSiguiente.Identity)
        lblEnsamble.Text = EnsambleInfo.Nombre()
        lblOrdenTrabajo.Text = OTInfo.UserCode

        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub LiberarOrdenTrabajoSelForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If (isValid()) Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Function isValid() As Boolean
        If (lblEnsamble.Text = "") Then
            MessageBox.Show("El ensamble no se cargo correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (lblOrdenTrabajo.Text = "") Then
            MessageBox.Show("La orden de trabajo no se cargo correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (bsInsumos.Count <= 0) Then
            MessageBox.Show("La orden de trabajo no cuenta con ensambles existentes", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
End Class