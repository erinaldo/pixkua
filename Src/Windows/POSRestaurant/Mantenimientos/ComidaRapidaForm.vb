Public Class ComidaRapidaForm

    Private Sub cmdNuevaOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevaOrden.Click
        Try
            Dim VentaTerminada As Boolean = False
            Dim Comanda As New ComandaInfo(App.Session.SessionID)
            Comanda.IdSucursal = App.DefaultSite.Identity

            Do While Not VentaTerminada
                VentaTerminada = ComidaRapida(Comanda)
            Loop
        Catch ex As Exception
            Azteca.Windows.Forms.MsgInfo.Show(ex)
        End Try
    End Sub

    Private Function ComidaRapida(ByVal Comanda As ComandaInfo) As Boolean
        Dim frmComanda As New ComandaForm

        If frmComanda.ShowDialog(Comanda) = DialogResult.OK Then
            If Cobrar(frmComanda.Comanda) Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If

    End Function

    Private Function Cobrar(ByVal Comanda As ComandaInfo) As Boolean
        Try
            Dim frmCobro As New Azteca.Windows.Ventas.CobranzaForm
            Dim idCliente As Integer = Context.UnidadNegocio.IdClienteGenerico
            Dim ComandaFac As New ComandaFacade
            Dim Venta As VentaInfo = ComandaFac.ToVentaInfo(App.Session.SessionID, Comanda, idCliente, Context.UnidadNegocio.PoliticaDescuento)
            Venta.IdCaja = Context.SessionTerminal.IdCaja
            If frmCobro.ShowDialog(1, Venta.Total) = DialogResult.OK Then
                'Aqui se va a pagar
                Comanda = ComandaFac.Pagar(App.Session.SessionID, Comanda, Venta, frmCobro.FormasPagoTable)
                'Se manda imprimir todos los articulos pendientes de envio a su centro de produccion
                Context.PrintTicketPedimento(Comanda.Identity)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
            Return False
        End Try
    End Function

    'Public Sub setPrecio(ByVal idCliente As Integer, ByVal drArticulo As Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow)
    '    Try
    '        'Dim ArtInfo As New Azteca.Business.Ventas.ArticuloInfo(App.Session.SessionID)

    '        'If Context.UnidadNegocio.TipoPrecio = TipoPrecio.ListaPrecio Then
    '        'Dim drLista As Azteca.Inventario.ListasPreciosDS.ListasRow = ServicioInf.ListasPrecio.FindByIdListaPrecio(ClienteInf.IdListaPrecios)
    '        'If drLista IsNot Nothing Then
    '        '    txtPrecio.Text = drLista.Precio.ToString
    '        'Else
    '        '    txtPrecio.Text = "0.0"
    '        'End If
    '        'Else
    '        'Obtener el precio del servicio en la zona
    '        Dim drZona As ZonasVentaDS.ZonasRow = Nothing '= ArtInfo.ZonasVenta.FindByIdZonaVenta(Context.UnidadNegocio.IdZonaVenta)
    '        If drZona IsNot Nothing Then
    '            drArticulo.PrecioUnitario = drZona.Precio.ToString
    '            drArticulo.IdDivisa = drZona.IdDivisa
    '            drArticulo.Divisa = drZona.Divisa
    '        Else
    '            drArticulo.PrecioUnitario = "0.0"
    '        End If
    '        'End If
    '    Catch ex As Exception
    '        Throw New Exception("Problemas al calcular los precios", ex)
    '    End Try
    'End Sub

   

    Private Sub ComidaRapidaForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        StatusBotones()
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub

    Private Sub pnlMenu_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlMenu.Resize
        Dim BotonX As Integer = cmdNuevaOrden.Width
        Dim BotonY As Integer = cmdNuevaOrden.Height

        Dim Separacion As Integer = cmdNuevaOrden.Left - (cmdAbrirCorte.Left + cmdAbrirCorte.Width)
        Dim MargenVertical As Integer = (pnlMenu.Width - (BotonX * 3) + (Separacion * 3)) / 2
        Dim MargenHorizontal As Integer = (pnlMenu.Height - BotonY) / 2

        cmdAbrirCorte.Left = MargenVertical
        cmdNuevaOrden.Left = MargenVertical + BotonX + Separacion
        cmdCorteCaja.Left = MargenVertical + (BotonX * 2) + (Separacion * 2)

        cmdAbrirCorte.Top = MargenHorizontal
        cmdNuevaOrden.Top = MargenHorizontal
        cmdCorteCaja.Top = MargenHorizontal

    End Sub

    Private Sub cmdArqueo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbrirCorte.Click

        ''Cargar información de impresión de la venta
        'Dim dtVenta As Azteca.Business.Ventas.InformesDS.CorteCajaDataTable  ''VentaFac.LoadPrintInfo(App.Session.SessionID, Venta.Identity)
        ''Definir parametros del informe
        ' ''Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
        ' ''Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))

        ''Mostrar vista previa de la venta
        'Dim frmVenta As New ReportForm
        'frmVenta.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Ventas.Orden.rdlc"
        'frmVenta.LocalReport.DataSources.Add(New ReportDataSource("Venta", CType(dtVenta, DataTable)))
        ' ''frmVenta.LocalReport.SetParameters(Parametros)
        'frmVenta.Show("Ventas realizadas") ''& Venta.Identity)

    End Sub

    Private Sub cmdAbrirCorte_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdAbrirCorte.ClickButtonArea
        AbrirCorte()
    End Sub

    Private Sub cmdCerrarCorte_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdCerrarCorte.ClickButtonArea
        CerrarCorte()
    End Sub

    Private Sub cmdCorteCaja_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdCorteCaja.ClickButtonArea
        ImprimirCorte()
    End Sub

#Region "Metodos Privados"
    Private Sub AbrirCorte()
        Try
            Dim cajafac As New CajaFacade
            Dim Caja As CajaInfo = cajafac.GetDetail(App.Session.SessionID, Context.SessionTerminal.IdCaja)

            If Caja.IdCorteActual <> New Guid("00000000000000000000000000000000") Then
                MessageBox.Show("La caja tiene  un corte abierto abierta", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            Dim frm As New Azteca.Windows.Ventas.AbrirCajaForm
            frm.StartPosition = FormStartPosition.CenterParent
            If frm.ShowDialog(Me, Context.SessionTerminal.IdCaja, Context.SessionTerminal.Caja) = System.Windows.Forms.DialogResult.OK Then
                Context.ReiniciarSesion()
                StatusBotones()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub CerrarCorte()
        If MessageBox.Show("Esta seguro de querer hacer el cierre del Corte Caja?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
            Try
                Dim CajaFac As New CajaFacade
                CajaFac.Cerrar(App.Session.SessionID, Context.SessionTerminal.IdCorteActual)
                MessageBox.Show("Se ha realizado el cierre de la caja", "Corte", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Context.ReiniciarSesion()
                StatusBotones()
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub ImprimirCorte()
        Try
            Dim frm As New Azteca.Windows.Ventas.ImpresionCorteForm
            If frm.ShowDialog(Me, Context.SessionTerminal.IdCaja, Context.SessionTerminal.Caja) = System.Windows.Forms.DialogResult.OK Then

            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub StatusBotones()
        cmdCerrarCorte.Visible = Context.SessionTerminal.CorteAbierto
        cmdAbrirCorte.Visible = Not Context.SessionTerminal.CorteAbierto
        cmdNuevaOrden.Enabled = Context.SessionTerminal.CorteAbierto
    End Sub

#End Region

   
   
End Class