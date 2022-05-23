Public Class CobranzaForm
    Private _Venta As VentaInfo
    Private _Comanda As ComandaInfo
    Private _FormasPagoTable As Business.Ventas.DetalleVentaDS.FormasPagoDataTable
    Private _DetallePago As New DetalleVentaDS.FormasPagoDataTable
    Private SizeBtn As Integer = 95
    Private FormasPagoPagina As Integer = 1
    Private FormasPagoPaginas As Integer = 0
    Private FormasPagoCapacidad As Integer = 0

    Public ReadOnly Property FormaPagoTable As Business.Ventas.DetalleVentaDS.FormasPagoDataTable
        Get
            Return _FormasPagoTable
        End Get
    End Property



    Public Overloads Function showdialog(ByVal IdVentaTipo As Integer, ByVal Total As Decimal) As DialogResult
        lblTotalTXT.Text = "$" & Total.ToString("0.00")
        lblTotTotalPagar.Text = "$" & Total.ToString("0.00")
        lblCambioTXT.Text = "$ 0.00"
        txtPropina.TextInfo = "$ 0.00"
        txtCantidad.TextInfo = Total.ToString("0.00")
        _FormasPagoTable = New Business.Ventas.DetalleVentaDS.FormasPagoDataTable
        grdFormaPago.DataSource = _FormasPagoTable
        ResizeForma()
        Return MyBase.ShowDialog()
    End Function

    Private Sub btnCobrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCobrar.Click
        Aceptar()
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtPropina_NumberChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPropina.NumberChanged
        lblTotTotalPagar.Text = "" & Format(CDec(lblTotTotalPagar.Text) + CDec(txtPropina.TextInfo), "0.00")
        txtCantidad.TextInfo = lblTotTotalPagar.Text
        _FormasPagoTable = New Business.Ventas.DetalleVentaDS.FormasPagoDataTable
        grdFormaPago.Refresh()
    End Sub

    Private Sub grdFormaPago_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles grdFormaPago.RowsRemoved
        ActualizaEncabezado()
    End Sub

    Private Sub ResizeForma()
        FormasPagoCapacidad = (pnlFormasPago.Width \ SizeBtn)

        'Cuantas paginas desplegaria el listado de Categorias
        If Not IsNothing(Context.FormasPagoTable) Then
            FormasPagoPaginas = CInt(Math.Ceiling(Context.FormasPagoTable.Rows.Count / FormasPagoCapacidad))
        End If
        fillFormasPago()
        btnRegresar.Focus()
    End Sub

    Private Sub addFormaPago(ByVal IdFormaPago As Integer, ByVal Descripcion As String)
        If CDec(Val(txtCantidad.TextInfo)) <= 0 Then
            MessageBox.Show("Debe capturar un monto mayor a cero", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtCantidad.Focus()
            Exit Sub
        End If

        Dim Suma As Object = _FormasPagoTable.Compute("SUM(MONTO)", "")
        If IsDBNull(Suma) Then Suma = 0

        If IdFormaPago <> Context.IdFormaPagoEfectivo Then
            If CDec(Suma) + CDec(Val(txtCantidad.TextInfo)) > CDec((lblTotTotalPagar.Text)) Then
                MessageBox.Show("Esta forma de pago no permite exceder el monto de la venta ya que no se permite devolucion de cambio", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
        Else
            Dim Efectivo As Object = _FormasPagoTable.Compute("SUM(MONTO)", "IdFormaPago=" & IdFormaPago)
            If IsDBNull(Efectivo) Then Efectivo = 0
            If Suma + CDec(Val(txtCantidad.TextInfo)) > CDec((lblTotTotalPagar.Text)) Then
                lblCambioTXT.Text = (Suma + CDec(Val(txtCantidad.TextInfo))) - CDec((lblTotTotalPagar.Text))
                txtCantidad.TextInfo = CDec(txtCantidad.TextInfo) - CDec(lblCambioTXT.Text)
            End If
        End If

        Dim dv As New DataView(_FormasPagoTable, "IdFormaPago=" & IdFormaPago, "", DataViewRowState.CurrentRows)
        If dv.Count = 0 Then
            Dim drPago As Business.Ventas.DetalleVentaDS.FormasPagoRow = _FormasPagoTable.NewFormasPagoRow
            With drPago
                .IdFormaPago = IdFormaPago : .FormaPago = Descripcion : .Monto = CDec(Val(txtCantidad.TextInfo))
                _FormasPagoTable.AddFormasPagoRow(drPago)
            End With
        Else
            dv(0)("Monto") = dv(0)("Monto") + CDec(txtCantidad.TextInfo)
        End If

        Suma = _FormasPagoTable.Compute("SUM(MONTO)", "")
        If IsDBNull(Suma) Then Suma = 0

        txtCantidad.TextInfo = CDec(lblTotTotalPagar.Text) - Suma

        ActualizaEncabezado()
    End Sub

    Private Sub ActualizaEncabezado()
        Dim Suma As Object = _FormasPagoTable.Compute("SUM(MONTO)", "")
        If IsDBNull(Suma) Then Suma = 0
        lblPagoTXT.Text = CDec(Suma).ToString("0.00") + CDec(lblCambioTXT.Text)
    End Sub

    Private Sub Aceptar()
        Dim Suma As Object = _FormasPagoTable.Compute("SUM(MONTO)", "")
        If IsDBNull(Suma) Then Suma = 0

        If CDec(lblTotalTXT.Text) > Suma Then
            MessageBox.Show("No ha completado el monto total de la venta.", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

#Region "Manejo de botones de Formas de pago"

    Private Sub ResetFormasPago()
        FormasPagoPagina = 1
    End Sub

    Private Sub fillFormasPago()

        If IsNothing(Context.FormasPagoTable) Then Exit Sub

        Dim top As Integer = 0
        top = (pnlFormasPago.Height - 80) / 2

        pnlFormasPago.Controls.Clear()

        Dim countX As Integer = 1

        'Ponemos el boton de anterior para los categorias previas cuando se está paginando la lista
        addPreviusButtonFormaPago(0, SizeBtn * (countX - 1)) : countX = countX + 1

        Dim dv As New DataView(Context.FormasPagoTable, "", "", System.Data.DataViewRowState.CurrentRows)

        Dim inicio As Integer = (FormasPagoPagina - 1) * FormasPagoCapacidad
        Dim Fin As Integer = inicio + FormasPagoCapacidad
        For i As Integer = inicio To Fin - 1
            If i > Context.FormasPagoTable.Rows.Count - 1 Then Exit For

            'cada vez q se llene una linea de botones en Y, se resetea Y 
            'If countX > CentrosProduccionTable.Rows.Count Then countX = 1

            'Agrega el boton del centro de produccion
            Dim Imagen As Byte()
            If IsDBNull(dv(i)("Imagen")) Then
                Imagen = Nothing
            Else
                Imagen = dv(i)("Imagen")
            End If
            addButtonFormaPago(dv(i)("IdFormaPago"), dv(i)("Nombre"), Imagen, top, SizeBtn * (countX - 1), "")

            countX = countX + 1
        Next
        'Ponemos el boton de siguiente para los Centros de produccion previos cuando se está paginando la lista 
        addNextButtonFormaPago(0, SizeBtn * (countX - 1))

    End Sub

    Private Sub addNextButtonFormaPago(ByVal Top As Integer, ByVal Left As Integer)
        Dim cmd As New Azteca.Windows.Controls.CIButton
        cmd.Image = My.Resources.next_64 : cmd.FlatStyle = FlatStyle.Flat : cmd.FlatAppearance.BorderSize = 0 : cmd.BackColor = Color.Transparent
        cmd.Width = SizeBtn : cmd.Height = SizeBtn - 10
        cmd.Left = Left : cmd.Top = (pnlFormasPago.Height - cmd.Height) / 2 : cmd.Enabled = IIf(FormasPagoPagina = FormasPagoPaginas, False, True)
        AddHandler cmd.Click, AddressOf clickPageNextFormaPago
        pnlFormasPago.Controls.Add(cmd)
    End Sub

    Private Sub addPreviusButtonFormaPago(ByVal Top As Integer, ByVal Left As Integer)
        Dim cmd As New Azteca.Windows.Controls.CIButton
        cmd.Image = My.Resources.back_64 : cmd.FlatStyle = FlatStyle.Flat : cmd.FlatAppearance.BorderSize = 0 : cmd.BackColor = Color.Transparent
        cmd.Width = SizeBtn : cmd.Height = SizeBtn - 10
        cmd.Left = Left : cmd.Top = (pnlFormasPago.Height - cmd.Height) / 2 : cmd.Enabled = IIf(FormasPagoPagina = 1, False, True)
        AddHandler cmd.Click, AddressOf clickPagePreviusFormaPago
        pnlFormasPago.Controls.Add(cmd)
    End Sub

    Private Sub clickPageNextFormaPago(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormasPagoPagina = FormasPagoPagina + 1
    End Sub

    Private Sub clickPagePreviusFormaPago(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormasPagoPagina = FormasPagoPagina - 1
    End Sub

    Private Sub addButtonFormaPago(ByVal Id As Integer, ByVal Descripcion As String, ByVal imagen As Byte(), ByVal Top As Integer, ByVal Left As Integer, ByVal color As String)
        Dim btnAdd As New Azteca.Windows.Controls.ButtonPlus
        Dim DesignerRectTracker1 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MeserosSelForm))
        Dim CBlendItems1 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker2 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()

        btnAdd.AutoLock = False
        btnAdd.BackColor = System.Drawing.Color.Transparent
        btnAdd.BorderColor = Drawing.Color.Olive '' System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        btnAdd.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.White}
        CBlendItems1.iPoint = New Single() {0.0!, 0.9969136!, 1.0!}
        btnAdd.ColorFillBlend = CBlendItems1
        btnAdd.ColorFillSolid = System.Drawing.SystemColors.Control
        btnAdd.Corners.All = CType(10, Short)
        btnAdd.Corners.LowerLeft = CType(10, Short)
        btnAdd.Corners.LowerRight = CType(10, Short)
        btnAdd.Corners.UpperLeft = CType(10, Short)
        btnAdd.Corners.UpperRight = CType(10, Short)
        btnAdd.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientLinear
        btnAdd.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        btnAdd.FocalPoints.CenterPtX = 0.5!
        btnAdd.FocalPoints.CenterPtY = 0.5!
        btnAdd.FocalPoints.FocusPtX = 0.0!
        btnAdd.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        btnAdd.FocusPtTracker = DesignerRectTracker2
        btnAdd.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        btnAdd.ForeColor = System.Drawing.Color.Green

        If imagen Is Nothing Then
            btnAdd.Image = Global.Azteca.Windows.My.Resources.Resources.Zonas_64
        Else
            Dim ms As New System.IO.MemoryStream(imagen)
            btnAdd.Image = System.Drawing.Image.FromStream(ms)
            btnAdd.ImageSize = New System.Drawing.Size(64, 64)
            ms.Close()
        End If

        btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        btnAdd.ImageIndex = 0
        btnAdd.ImageSize = New System.Drawing.Size(64, 64)
        btnAdd.Location = New System.Drawing.Point(Left, Top)
        btnAdd.Name = "btnAdd"
        btnAdd.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        btnAdd.SideImage = Nothing
        btnAdd.SideImageAlign = System.Drawing.ContentAlignment.TopCenter
        btnAdd.SideImageSize = New System.Drawing.Size(48, 48)
        btnAdd.Size = New System.Drawing.Size(90, 80)
        btnAdd.TabIndex = 0
        btnAdd.Text = Descripcion
        btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        btnAdd.TextMargin = New System.Windows.Forms.Padding(2)
        btnAdd.TextShadowShow = False
        btnAdd.TextShadow = Drawing.Color.White '' System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        btnAdd.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
        btnAdd.UseMnemonic = True

        btnAdd.Tag = Id
        AddHandler btnAdd.Click, AddressOf clickFormaPago

        pnlFormasPago.Controls.Add(btnAdd)

    End Sub

    Private Sub clickFormaPago(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cmd As Azteca.Windows.Controls.ButtonPlus = CType(sender, Azteca.Windows.Controls.ButtonPlus)
        Dim IdFormaPago As Integer = CInt(cmd.Tag)
        addFormaPago(IdFormaPago, cmd.Text)
    End Sub

#End Region

End Class


''Public Overloads Function showdialog(ByVal Comanda As ComandaInfo, ByVal Venta As VentaInfo, ByVal FormasPago As DataTable) As DialogResult
''    _Venta = Venta
''    _Comanda = Comanda
''    FormasPagoTable = FormasPago
''    fillVenta()
''    Return MyBase.ShowDialog
''End Function

'#Region "Metodos Privados"

'Private Sub fillVenta()
'    lvwComanda.BeginUpdate()
'    lvwComanda.Items.Clear()
'    ''Dim vwOrdenes As New DataView(dtOrdenes, "", "Fecha DESC, SUCURSAL", DataViewRowState.CurrentRows)
'    For Each dr As DetalleVentaDS.ArticulosRow In _Venta.Articulos
'        Dim Item As New ListViewItem(dr.Descripcion, 2)
'        Item.SubItems.Add((dr.Cantidad.ToString("#0")))
'        Item.SubItems.Add((dr.PrecioUnitario.ToString("#0.00")))
'        Item.Tag = CType(dr, DetalleVentaDS.ArticulosRow)
'        lvwComanda.Items.Add(Item)
'    Next
'    lvwComanda.EndUpdate()
'    lblTotalCuenta.Text = _Venta.Total
'End Sub

'#End Region

'Private Sub cmdCobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    Try
'        If Not validaMontos() Then Exit Sub
'        'Guardar Comanda, Venta, y detalle de pago
'        detallePago()
'        Dim ComandaFac As New ComandaFacade
'        ComandaFac.Pagar(App.Session.SessionID, _Comanda, _Venta, _DetallePago)
'        Me.DialogResult = DialogResult.OK
'    Catch ex As Exception
'        MsgInfo.Show(ex)
'    End Try
'End Sub

'Private Function detallePago() As Boolean
'    _DetallePago.Rows.Clear()
'    Dim Total As Decimal = 0
'    For Each item As MultiSeleccionButtonsControl In pnlFormasPago.Controls
'        If item.Valor > 0 Then
'            Dim drNew As DetalleVentaDS.FormasPagoRow = _DetallePago.NewFormasPagoRow
'            drNew.FormaPago = item.Descripcion
'            drNew.IdFormaPago = item.Key
'            drNew.Monto = item.Valor
'            _DetallePago.AddFormasPagoRow(drNew)
'        End If
'        Total = Total + item.Valor
'    Next
'    Return Total
'End Function


