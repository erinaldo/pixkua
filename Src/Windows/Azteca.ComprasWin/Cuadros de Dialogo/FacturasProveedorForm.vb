Public Class FacturasProveedorForm
    Private IdProveedor As Integer

    Private _Serie As String
    Private _Folio As Integer
    Private _UUID As String

#Region "Propiedades"

    Public ReadOnly Property Serie As String
        Get
            Return _Serie
        End Get
    End Property

    Public ReadOnly Property Folio As Integer
        Get
            Return _Folio
        End Get
    End Property

    Public ReadOnly Property UUID As String
        Get
            Return _UUID
        End Get
    End Property

#End Region

#Region "Metodos Privados"

    Private Sub CargarFacturas()
        Dim FacturaFac As New ComprobanteFiscalFacade
        Dim dtFacturas As DataTable = FacturaFac.ListaProveedor(App.Session.SessionID, IdProveedor, Date.Today.AddYears(-1), Date.Today)
        bsFacturas.DataSource = dtFacturas
        grdFacturas.Rebind(True)
    End Sub

    Private Sub VerFactura()

    End Sub

    Private Sub SelectFactura()
        _Serie = grdFacturas.Columns("Serie").Text
        _Folio = CInt(grdFacturas.Columns("Folio").Value)
        _UUID = grdFacturas.Columns("UUID").Text
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

#End Region

#Region "Implementacion"

    Public Overloads Function ShowDialog(owner As Form, idProveedor As Integer) As DialogResult
        Me.IdProveedor = idProveedor
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub FacturasProveedorForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            CargarFacturas()
        Catch ex As Exception
            MsgInfo.Show(ex)
            DialogResult = System.Windows.Forms.DialogResult.Cancel
        End Try
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAceptar.Click
        If bsFacturas.Current IsNot Nothing Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                cmdAceptar.Enabled = False
                SelectFactura()
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
                cmdAceptar.Enabled = True
            End Try
        Else
            MessageBox.Show("Debe elegir un comprobante fiscal", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmdVerFactura_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdVerFactura.Click
        If bsFacturas.Current IsNot Nothing Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                VerFactura()
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub grdFacturas_DoubleClick(sender As Object, e As System.EventArgs) Handles grdFacturas.DoubleClick
        If bsFacturas.Current IsNot Nothing Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                cmdAceptar.Enabled = False
                SelectFactura()
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
                cmdAceptar.Enabled = True
            End Try
        End If
    End Sub

#End Region

End Class