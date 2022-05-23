Public Class EditPrecioForm

    Public ReadOnly Property Precio As Decimal
        Get
            Return CDec(Val(txtPrecio.Text))
        End Get
    End Property

    Public ReadOnly Property IdDivisa As Integer
        Get
            Return CInt(cboDivisa.SelectedValue)
        End Get
    End Property

    Public ReadOnly Property RangoAplicacion As String
        Get
            If rdbFiltro.Checked Then
                Return "F"
            Else
                Return "S"
            End If
        End Get
    End Property

    Private Function IsValid() As Boolean
        If Val(txtPrecio.Text) <= 0 Then
            MessageBox.Show("Debe introducir un precio mayor a cero", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        ElseIf cboDivisa.SelectedIndex = -1 Then
            MessageBox.Show("Debe elegir una divisa.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub EditPrecioForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            cboDivisa.LoadList()
            cboDivisa.SelectedValue = Context.UnidadNegocio.IdDivisaBase
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAceptar.Click
        Try
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
End Class