Imports Microsoft.Reporting.WinForms

Public Class CapturaInventarioFisicoForm
    Private IdArea As Integer
    Private AreaFac As AreaFacade
    Private Area As AreaInfo
    Private AlmacenFac As AlmacenFacade

    Private Almacenes As DataTable
    Private Inventario As AreasDS.InventarioFisicoDataTable

    Private Sub ImprimirInventario()
        'Generar parametros
        Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
        Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
        Parametros.Add(New ReportParameter("Area", Area.Nombre))
        'Configurar reporte
        Dim frmFacturas As New ReportForm
        frmFacturas.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Inventario.InventarioFisicoRPT.rdlc"
        frmFacturas.LocalReport.DataSources.Add(New ReportDataSource("Inventario", CType(Inventario, DataTable)))
        frmFacturas.LocalReport.SetParameters(Parametros)
        frmFacturas.Show("Captura de Inventario Físico")
    End Sub


    Private Sub ActualizarExistencias()
        Dim AlmacenesCaptura = From A In Almacenes
                               Where CBool(A!ReqCapturaFisico) = True

        For Each drAlmacen As DataRow In AlmacenesCaptura
            Dim IdAlmacen As Integer = CInt(drAlmacen("IdAlmacen"))
            Dim Existencias As DataTable = AlmacenFac.GetStock(App.Session.SessionID, IdAlmacen)
            For Each drExistencia As DataRow In Existencias.Rows
                Dim IdArticuloStock As Integer = CInt(drExistencia("IdArticuloStock"))
                Dim drInvFis As AreasDS.InventarioFisicoRow = Inventario.FindByIdArticuloStockIdAlmacen(IdArticuloStock, IdAlmacen)
                If drInvFis IsNot Nothing Then                    
                    If drInvFis.IdUnidadMedidaTipo = 1 Then
                        Dim Teorico As New Empaquetado(CDec(drExistencia("Disponible")) + CDec(drExistencia("Apartado")), drInvFis.Factor)
                        Dim Fisico As New Empaquetado(drInvFis.Fisico, drInvFis.Factor)
                        Dim Diferencia As Empaquetado = Fisico - Teorico
                        '
                        drInvFis.Teorico = Teorico.ToDecimal
                        drInvFis.CantidadTeorico = Teorico.Cajas
                        drInvFis.UnidadesTeorico = Teorico.Unidades
                        '
                        drInvFis.Diferencia = Diferencia.ToDecimal
                        drInvFis.CantidadDiferencia = Diferencia.Cajas
                        drInvFis.UnidadesDiferencia = Diferencia.Unidades
                    Else
                        Dim Teorico As Decimal = CDec(drExistencia("Disponible")) + CDec(drExistencia("Apartado"))
                        Dim Diferencia As Decimal = drInvFis.Fisico - Teorico

                        drInvFis.Teorico = Teorico
                        drInvFis.CantidadTeorico = Teorico
                        '
                        drInvFis.Diferencia = Diferencia
                        drInvFis.CantidadDiferencia = Diferencia
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub CargarInventario()
        Inventario = AreaFac.CargarInventarioFisico(App.Session.SessionID, IdArea)
        bsArticulos.DataSource = Inventario
        grdArticulos.Rebind(True)
    End Sub

    Private Sub CargarAlmacenes()
        Almacenes = AlmacenFac.LoadListByArea(App.Session.SessionID, IdArea)
        bsAlmacenes.DataSource = Almacenes
        bsAlmacenes.Filter = "ReqCapturaFisico=True"
        lstAlmacenes.Rebind(True)
        '
        If bsAlmacenes.Count = 0 Then
            MessageBox.Show("El área seleccionada no contiene almacenes configurados para captura de inventario físico.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            lstAlmacenes.SelectedIndex = 0
        End If
    End Sub

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal idArea As Integer) As DialogResult
        Me.IdArea = idArea
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub CapturaInventarioFisicoForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            AreaFac = New AreaFacade
            AlmacenFac = New AlmacenFacade
            Area = AreaFac.GetDetail(App.Session.SessionID, IdArea, False)
            CargarInventario()
            CargarAlmacenes()
        Catch ex As Exception
            MsgInfo.Show(ex)
            Close()
        End Try
    End Sub

    Private Sub lstAlmacenes_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstAlmacenes.SelectedValueChanged
        If lstAlmacenes.SelectedIndex >= 0 Then
            bsArticulos.Filter = "IdAlmacen=" & lstAlmacenes.SelectedValue.ToString
        End If
    End Sub

    Private Sub grdArticulos_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdArticulos.AfterColUpdate
        If e.Column.Name = "Físico" Or e.Column.Name = "Físico (Unidades)" Then
            Dim dr As AreasDS.InventarioFisicoRow = CType(CType(bsArticulos.Current, DataRowView).Row, AreasDS.InventarioFisicoRow)
            If dr.IdUnidadMedidaTipo = 1 Then
                Dim Teorico As New Empaquetado(CInt(dr.CantidadTeorico), CInt(dr.UnidadesTeorico), dr.Factor)
                Dim Fisico As New Empaquetado(CInt(dr.CantidadFisico), CInt(dr.UnidadesFisico), dr.Factor)
                Dim Diferencia As Empaquetado = Fisico - Teorico

                dr.Diferencia = Diferencia.ToDecimal
                dr.CantidadDiferencia = Diferencia.Cajas
                dr.UnidadesDiferencia = Diferencia.Unidades
            Else
                Dim Diferencia As Decimal = dr.CantidadFisico - dr.CantidadTeorico
                dr.Diferencia = Diferencia
                dr.CantidadDiferencia = Diferencia
            End If
        End If
    End Sub

    Private Sub grdArticulos_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles grdArticulos.BeforeColEdit
        If e.Column.Name = "Físico (Unidades)" Then
            Dim IdUnidadMedida As Integer = CInt(grdArticulos.Columns("IdUnidadMedida").Value)
            Dim IdUnidadMedidaTipo As Integer = CInt(grdArticulos.Columns("IdUnidadMedidaTipo").Value)
            If IdUnidadMedidaTipo > 1 Or IdUnidadMedida = 1 Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub grdArticulos_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdArticulos.FetchCellStyle
        Try
            If e.Column.Name = "Físico (Unidades)" Then
                Dim IdUnidadMedida As Integer = CInt(grdArticulos.Columns("IdUnidadMedida").CellValue(e.Row))
                Dim IdUnidadMedidaTipo As Integer = CInt(grdArticulos.Columns("IdUnidadMedidaTipo").CellValue(e.Row))
                If IdUnidadMedidaTipo > 1 Or IdUnidadMedida = 1 Then
                    e.CellStyle.BackColor = System.Drawing.SystemColors.Control
                End If
            End If

            If e.Column.Name = "Diferencia" Or e.Column.Name = "Diferencia (Unidades)" Then
                Dim Cantidad As Decimal = CDec(grdArticulos.Columns("Diferencia").CellValue(e.Row))
                Dim Unidades As Decimal = CDec(grdArticulos.Columns("Diferencia (Unidades)").CellValue(e.Row))
                Dim Result As Integer = CInt(Cantidad + Unidades)
                If Result = 0 Then
                    e.CellStyle.BackColor = System.Drawing.SystemColors.Control
                ElseIf Result < 0 Then
                    e.CellStyle.BackColor = Drawing.Color.OrangeRed
                ElseIf Result > 0 Then
                    e.CellStyle.BackColor = Drawing.Color.GreenYellow
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdGuardar.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            AreaFac.GuardarInventarioFisico(App.Session.SessionID, Area.IdCorteActual, Inventario)
            Inventario.AcceptChanges()
            MessageBox.Show("La captura de inventario físico se ha guardado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdImprimir.Click
        Try
            ImprimirInventario()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdActualizarExistencias_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdActualizarExistencias.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            ActualizarExistencias()
            MessageBox.Show("El proceso de actualización de existencias ha terminado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

End Class