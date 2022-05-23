Imports System.IO

Public Class RecibirFacturaForm
    Private Comprobantes As ComprobantesDS.ComprobantesDataTable

    Private Sub MoveFile(ByVal fileName As String, ByVal valido As Boolean)
        Dim TargetFolder As String = String.Empty
        If valido Then
            TargetFolder = txtFolder.Text & "\Validos"
        Else
            TargetFolder = txtFolder.Text & "\NoValidos"
        End If
        If Not Directory.Exists(TargetFolder) Then Directory.CreateDirectory(TargetFolder)
        If File.Exists(TargetFolder & "\" & fileName) Then File.Delete(TargetFolder & "\" & fileName)
        File.Move(txtFolder.Text & "\" & fileName, TargetFolder & "\" & fileName)
    End Sub

    Private Sub CargarInfoComprobante(ByVal fileName As String, ByVal comprobante As ComprobanteFiscalInfo, ByVal drComprobante As ComprobantesDS.ComprobantesRow)
        drComprobante.Archivo = Path.GetFileName(fileName)
        If comprobante IsNot Nothing Then
            With drComprobante
                .Fecha = comprobante.Fecha
                .Serie = comprobante.Serie
                .Folio = comprobante.Folio
                .UUID = comprobante.UUID
                .RFC = comprobante.Emisor.RFC
                .RazonSocial = comprobante.Emisor.Nombre
                .SubTotal = comprobante.SubTotal
                .ImpuestosRet = comprobante.Impuestos.TotalRetenciones
                .ImpuestosTras = comprobante.Impuestos.TotalTraslados
                .Total = comprobante.Total
                .Estatus = comprobante.Estatus
                .TipoCambio = comprobante.TipoCambio
                .Valido = comprobante.Valido
                If .Valido Then .Estatus = "Comprobante Válido"
            End With
        Else
            drComprobante.Estatus = "El archivo no es un CFD"
            drComprobante.Valido = False
        End If
    End Sub

    Private Function GetErrorStack(ByVal ex As Exception) As String
        Dim ErrorText As String = ex.Message
        If ex.InnerException IsNot Nothing Then ErrorText &= ControlChars.NewLine & GetErrorStack(ex.InnerException)
        Return ErrorText
    End Function

    Private Sub RecibirFacturaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtFolder.Text = Registry.GetValue("Compras", "CFD Folder", String.Empty)
            'Cargar la lista de divisas
            Dim DivisaFac As New Azteca.Business.Contabilidad.DivisaFacade
            Dim dtDivisas As DataTable = DivisaFac.LoadList(App.Session.SessionID)
            bsDivisas.DataSource = dtDivisas
            cboDivisas.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            grdComprobantes.UpdateData()
            cmdGuardar.Enabled = False
            Dim ComprobanteFac As New ComprobanteFiscalFacade
            For Each drComprobante As ComprobantesDS.ComprobantesRow In Comprobantes
                If drComprobante.Valido Then
                    Dim Reader As TextReader = File.OpenText(txtFolder.Text & "\" & drComprobante.Archivo)
                    Dim strFactura As String = Reader.ReadToEnd
                    Reader.Close()
                    ComprobanteFac.Save(App.Session.SessionID, App.DefaultCompany.Identity, App.DefaultSite.Identity, strFactura, drComprobante.IdDivisa, 1)
                End If
                MoveFile(drComprobante.Archivo, drComprobante.Valido)
            Next
            bsComprobantes.DataSource = Nothing
            grdComprobantes.Rebind(True)
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(GetErrorStack(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmdGuardar.Enabled = True
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub


    Private Sub btnSelFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelFolder.Click
        If dlgFolder.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                txtFolder.Text = dlgFolder.SelectedPath
                Registry.SetValue("Compras", "CFD Folder", txtFolder.Text)
                bsComprobantes.DataSource = Nothing
                cmdGuardar.Enabled = False
                grdComprobantes.Rebind(True)
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If txtFolder.Text.Trim <> String.Empty Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                Comprobantes = New ComprobantesDS.ComprobantesDataTable
                Dim Files As String() = Directory.GetFiles(txtFolder.Text, "*.xml")
                For Each fileName As String In Files
                    Dim reader As TextReader = File.OpenText(fileName)
                    Dim drComprobante As ComprobantesDS.ComprobantesRow = Comprobantes.NewComprobantesRow
                    Dim Comprobante As ComprobanteFiscalInfo = Nothing
                    Dim ComprobanteFac As New ComprobanteFiscalFacade
                    Try
                        Dim ComprobanteXML As String = reader.ReadToEnd
                        Comprobante = ComprobanteFac.Validar(App.Session.SessionID, App.DefaultCompany.Identity, ComprobanteXML)
                        CargarInfoComprobante(fileName, Comprobante, drComprobante)
                    Catch ex As Exception
                        drComprobante.Estatus = GetErrorStack(ex)
                        drComprobante.Valido = False
                        CargarInfoComprobante(fileName, Comprobante, drComprobante)
                    Finally
                        reader.Close()
                    End Try
                    Comprobantes.AddComprobantesRow(drComprobante)
                Next
                bsComprobantes.DataSource = Comprobantes
                grdComprobantes.Rebind(True)
                cmdGuardar.Enabled = True
                grdComprobantes.Focus()
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        Else
            MessageBox.Show("Debe seleccionar la carpeta para buscar CFD's", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdComprobantes_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdComprobantes.ButtonClick
        If e.Column.Name = "Estatus" Then
            Clipboard.SetText(grdComprobantes.Columns("Estatus").Text)
            MessageBox.Show("El estatus ha sido copiado al portapapeles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdComprobantes_FetchCellTips(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellTipsEventArgs) Handles grdComprobantes.FetchCellTips
        e.CellTip = grdComprobantes.Columns("Estatus").CellText(e.Row)
    End Sub

    Private Sub grdComprobantes_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles grdComprobantes.FetchRowStyle
        If CBool(grdComprobantes.Columns("Valido").CellValue(e.Row)) Then
            e.CellStyle.BackColor = Drawing.Color.LightGreen
        Else
            e.CellStyle.BackColor = Drawing.Color.Orange
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
End Class