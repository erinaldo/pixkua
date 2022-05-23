Public Class MesasSelForm
    Private ModalidadPantalla As ModalidadPantallaEnum = ModalidadPantallaEnum.Seleccion
    Private CentroConsumoPagina As Integer = 1
    Private CentroConsumoPaginas As Integer = 0
    Private CentrosConsumoTable As DataTable, MesasTable As DataTable
    Private IdCentroConsumo As Integer = 0, ImpresoraCentroConsumo As String
    Public IdMesa As Integer = 0, IdComandaTit As String = ""
    Private CentrosConsumoCapacidad As Integer = 0
    Private SizeBtn As Integer = 95
    Dim BotonesX As Integer '= pnlMeseros.Width / 100
    Dim BotonesY As Integer '= pnlMeseros.Height / 100

    Public Overloads Function showdialog(ByVal IdMesero As Integer) As DialogResult
        Dim CentrosConsumoFac As New CentroConsumoFacade
        CentrosConsumoTable = CentrosConsumoFac.LoadDataButtons(App.Session.SessionID, IdMesero)
        Return MyBase.ShowDialog
    End Function

    Private Sub MesasSelForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fillCentrosConsumo()
        ResizeForma()
    End Sub

    Private Sub MesasSelForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ResizeForma()
    End Sub

    Private Sub btnCobrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCobrar.Click
        ModalidadPantalla = ModalidadPantallaEnum.Cuenta
        fillMesas()
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        MyBase.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

#Region "Metodos Privados"

    Private Sub ResizeForma()
        CentrosConsumoCapacidad = (pnlCentrosConsumo.Width \ SizeBtn)
        'Cuantos Botones caben en la pantalla ? = numLugares
        BotonesX = pnlMesas.Width / 100
        BotonesY = pnlMesas.Height / 100

        'Cuantas paginas desplegaria el listado de Categorias
        If Not IsNothing(CentrosConsumoTable) Then
            CentroConsumoPaginas = CInt(Math.Ceiling(CentrosConsumoTable.Rows.Count / CentrosConsumoCapacidad))
        End If
        fillCentrosConsumo()
        fillMesas()
        btnRegresar.Focus()
    End Sub

    Private Sub Cuenta(ByVal IdComandaTit As String)
        'Marcamos la Comanda como cerrada
        Dim ComandaFac As New ComandaFacade
        ComandaFac.ApplyWorkflow(App.Session.SessionID, IdComandaTit, Kernel.BusinessStructure.WorkflowSteps.Close, Date.Today)

        'Mandamos a imprimir la Comanda a la Impresora configurada en la zona de Consumo
        Context.PrintTicketComanda(IdComandaTit, ImpresoraCentroConsumo)

        'Regresamos el valor de completado OK
        Me.DialogResult = System.Windows.Forms.DialogResult.Ignore
    End Sub

    ''Private Function Cobrar(ByVal IdComandaTit As String) As Boolean
    ''    Try
    ''        Dim ComandaFac As New ComandaFacade

    ''        Dim Comanda As ComandaInfo = ComandaFac.GetDetail(App.Session.SessionID, IdComandaTit)
    ''        Dim formaPagoFac As New FormaPagoFacade
    ''        Dim FormasPagoTable As DataTable = formaPagoFac.LoadList(App.Session.SessionID)
    ''        Dim frmCobro As New CobranzaForm
    ''        Dim idCliente As Integer = 2 ''''''ClienteVentaForm(App.Session.SessionID)
    ''        Dim Venta As VentaInfo = CrearPedido(idCliente, Comanda)
    ''        If frmCobro.ShowDialog(Comanda, Venta, FormasPagoTable) = DialogResult.OK Then
    ''            Return True
    ''        Else
    ''            Return False
    ''        End If
    ''    Catch ex As Exception
    ''        MsgInfo.Show(ex)
    ''        Return False
    ''    End Try
    ''End Function

    ''Private Function CrearPedido(ByVal idCliente As Integer, ByVal Comanda As ComandaInfo) As VentaInfo
    ''    Dim Venta As New Azteca.Business.Ventas.VentaInfo(App.Session.SessionID)
    ''    With Venta
    ''        .IdCliente = idCliente
    ''        .FechaEntrega = Date.Today : .Hora = Date.Today
    ''        .IdReferencia = Comanda.Identity
    ''        .IdSucursal = App.DefaultSite.Identity
    ''        .Observaciones = "POS Restaurante"
    ''        .Origen = Azteca.Business.Ventas.OrigenVenta.POS : .IdSucursal = App.DefaultSite.Identity
    ''        For Each drComanda As ComandaDS.ComandaDetRow In Comanda.Details
    ''            .IdDivisa = drComanda.IdDivisa
    ''            Dim drArticulo As Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow = .Articulos.NewArticulosRow
    ''            drArticulo.IdArticuloStock = drComanda.IdArticulo : drArticulo.Cantidad = drComanda.Cantidad : drArticulo.Descripcion = drComanda.Articulo
    ''            drArticulo.PrecioUnitario = drComanda.PrecioUnitario
    ''            .Articulos.AddArticulosRow(drArticulo)
    ''        Next
    ''    End With
    ''    Return Venta
    ''End Function

#End Region

#Region "Manejo de botones de Centros de consumo"

    Private Sub ResetCentroConsumo()
        CentroConsumoPagina = 1
    End Sub

    Private Sub fillCentrosConsumo()

        If IsNothing(CentrosConsumoTable) Then Exit Sub

        pnlCentrosConsumo.Controls.Clear()

        Dim countX As Integer = 1

        'Ponemos el boton de anterior para los categorias previas cuando se está paginando la lista
        addPreviusButtonCentroConsumo(0, SizeBtn * (countX - 1)) : countX = countX + 1

        Dim dv As New DataView(CentrosConsumoTable, "", "Nombre", System.Data.DataViewRowState.CurrentRows)

        Dim inicio As Integer = (CentroConsumoPagina - 1) * CentrosConsumoCapacidad
        Dim Fin As Integer = inicio + CentrosConsumoCapacidad
        For i As Integer = inicio To Fin - 1
            If i > CentrosConsumoTable.Rows.Count - 1 Then Exit For

            'cada vez q se llene una linea de botones en Y, se resetea Y 
            'If countX > CentrosProduccionTable.Rows.Count Then countX = 1

            'Agrega el boton del centro de produccion
            Dim Imagen As Byte()
            If IsDBNull(dv(i)("Imagen")) Then
                Imagen = Nothing
            Else
                Imagen = dv(i)("Imagen")
            End If
            addButtonCentroConsumo(dv(i)("IdCentroConsumo"), dv(i)("Nombre"), Imagen, 0, SizeBtn * (countX - 1), "")

            countX = countX + 1
        Next
        'Ponemos el boton de siguiente para los Centros de produccion previos cuando se está paginando la lista 
        addNextButtonCentroConsumo(0, SizeBtn * (countX - 1))

    End Sub

    Private Sub addButtonCentroConsumo(ByVal Id As Integer, ByVal Descripcion As String, ByVal imagen As Byte(), ByVal Top As Integer, ByVal Left As Integer, ByVal color As String)
        Dim btnAdd As New Azteca.Windows.Controls.ButtonPlus
        Dim DesignerRectTracker1 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MeserosSelForm))
        Dim CBlendItems1 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker2 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()

        btnAdd.AutoLock = False
        btnAdd.BackColor = System.Drawing.Color.Transparent
        btnAdd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
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
        btnAdd.ForeColor = System.Drawing.Color.Firebrick

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
        AddHandler btnAdd.Click, AddressOf clickCentroConsumo

        pnlCentrosConsumo.Controls.Add(btnAdd)

    End Sub

    Private Sub clickCentroConsumo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cmd As Azteca.Windows.Controls.ButtonPlus = CType(sender, Azteca.Windows.Controls.ButtonPlus)
        IdCentroConsumo = CInt(cmd.Tag)
        Dim dv As New DataView(CentrosConsumoTable, "IdCentroConsumo=" & IdCentroConsumo, "", DataViewRowState.CurrentRows)
        ImpresoraCentroConsumo = dv(0)("Impresora")
        Dim MesaFac As New MesaFacade
        MesasTable = MesaFac.LoadDataButtons(App.Session.SessionID, IdCentroConsumo)
        fillMesas()
    End Sub

    Private Sub addNextButtonCentroConsumo(ByVal Top As Integer, ByVal Left As Integer)
        Dim cmd As New Azteca.Windows.Controls.CIButton
        cmd.Image = My.Resources.next_64 : cmd.FlatStyle = FlatStyle.Flat : cmd.FlatAppearance.BorderSize = 0 : cmd.BackColor = Color.Transparent
        cmd.Width = SizeBtn : cmd.Height = SizeBtn - 10
        cmd.Left = Left : cmd.Top = (pnlCentrosConsumo.Height - cmd.Height) / 2 : cmd.Enabled = IIf(CentroConsumoPagina = CentroConsumoPaginas, False, True)
        AddHandler cmd.Click, AddressOf clickPageNextCentroConsumo
        pnlCentrosConsumo.Controls.Add(cmd)
    End Sub

    Private Sub addPreviusButtonCentroConsumo(ByVal Top As Integer, ByVal Left As Integer)
        Dim cmd As New Azteca.Windows.Controls.CIButton
        cmd.Image = My.Resources.back_64 : cmd.FlatStyle = FlatStyle.Flat : cmd.FlatAppearance.BorderSize = 0 : cmd.BackColor = Color.Transparent
        cmd.Width = SizeBtn : cmd.Height = SizeBtn - 10
        cmd.Left = Left : cmd.Top = (pnlCentrosConsumo.Height - cmd.Height) / 2 : cmd.Enabled = IIf(CentroConsumoPagina = 1, False, True)
        AddHandler cmd.Click, AddressOf clickPagePreviusCentroConsumo
        pnlCentrosConsumo.Controls.Add(cmd)
    End Sub

    Private Sub clickPageNextCentroConsumo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CentroConsumoPagina = CentroConsumoPagina + 1
    End Sub

    Private Sub clickPagePreviusCentroConsumo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CentroConsumoPagina = CentroConsumoPagina - 1
    End Sub

#End Region

#Region "Manejo de botones de Mesas"

    Private Sub fillMesas()
        Dim Count As Integer = 0, MargenX As Integer = 0, X As Integer = 0

        If IsNothing(MesasTable) Then Exit Sub

        pnlMesas.Controls.Clear()
        Dim numMesas As Integer = MesasTable.Rows.Count
        'Ver donde va a comenzar a poner los botones en coord Y
        Dim Y As Integer = Math.Ceiling(numMesas / BotonesX)
        Y = (BotonesY - 1) / 2
        Dim dv As New DataView(MesasTable, "", "Descripcion", DataViewRowState.CurrentRows)

        For Each dr As DataRowView In dv
            ''reiniciar cuando llego al extremo de la coordenada X
            If X >= BotonesX Then
                Y = Y + 1
                X = 0
            End If
            'Margen centrado de X
            If X = 0 Then
                If numMesas - Count < BotonesX Then
                    MargenX = pnlMesas.Width - ((numMesas - Count) * 100)
                    MargenX = MargenX / 2
                Else
                    MargenX = pnlMesas.Width - (BotonesX * 100)
                    MargenX = MargenX / 2
                End If
            End If

            Dim top As Integer = Y * 100, Left As Integer = (X * 100) + MargenX

            addButtonMesa(dr("IdMesa"), dr("Descripcion"), dr("IdComandaTit"), dr("IdStatus"), top, Left)

            X = X + 1
            Count = Count + 1
        Next
    End Sub

    Private Sub addButtonMesa(ByVal Id As Integer, ByVal NombreCorto As String, ByVal IdComandaTit As String, ByVal IdStatus As Integer, ByVal Top As Integer, ByVal Left As Integer)
        Dim Enabled As Boolean = True

        'Se deshabilita la mesa cuando se solicita la cuenta y no tiene comanda. En caso de tener comanda, q no este la cuenta ya solicitada
        If ModalidadPantalla = ModalidadPantallaEnum.Cuenta And (IdComandaTit.Trim.Length = 0 Or (IdComandaTit.Trim.Length > 0 And IdStatus = Kernel.BusinessStructure.WorkflowSteps.Close)) Then Enabled = False

        If IdComandaTit.Trim.Length > 0 Then
            MesaOcupadaButton(Id, NombreCorto, Top, Left, Enabled, IdStatus)
        Else
            MesaDisponibleBotton(Id, NombreCorto, Top, Left, Enabled)
        End If

    End Sub

    Private Sub MesaDisponibleBotton(ByVal Id As Integer, ByVal NombreCorto As String, ByVal Top As Integer, ByVal Left As Integer, ByVal Enabled As Boolean)
        Dim btnAdd As New Azteca.Windows.Controls.ButtonPlus
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MesasSelForm))
        Dim DesignerRectTracker5 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems3 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker6 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()

        btnAdd.AutoLock = False
        btnAdd.BorderColor = System.Drawing.Color.Olive
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        btnAdd.CenterPtTracker = DesignerRectTracker5
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))}
        CBlendItems3.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        btnAdd.ColorFillBlend = CBlendItems3
        btnAdd.ColorFillSolid = System.Drawing.SystemColors.Control
        btnAdd.Corners.All = CType(6, Short)
        btnAdd.Corners.LowerLeft = CType(6, Short)
        btnAdd.Corners.LowerRight = CType(6, Short)
        btnAdd.Corners.UpperLeft = CType(6, Short)
        btnAdd.Corners.UpperRight = CType(6, Short)
        btnAdd.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientLinear
        btnAdd.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        btnAdd.FocalPoints.CenterPtX = 0.5333334!
        btnAdd.FocalPoints.CenterPtY = 0.452381!
        btnAdd.FocalPoints.FocusPtX = 0.0!
        btnAdd.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        btnAdd.FocusPtTracker = DesignerRectTracker6
        btnAdd.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        btnAdd.ForeColor = System.Drawing.Color.Olive
        btnAdd.Image = Global.Azteca.Windows.My.Resources.Resources.Mesa_64
        btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        btnAdd.ImageIndex = 0
        btnAdd.ImageSize = New System.Drawing.Size(64, 64)
        btnAdd.Location = New System.Drawing.Point(Left, Top)
        btnAdd.Name = "btnAdd"
        btnAdd.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        btnAdd.SideImage = Nothing
        btnAdd.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        btnAdd.SideImageSize = New System.Drawing.Size(48, 48)
        btnAdd.Size = New System.Drawing.Size(90, 90)
        btnAdd.TabIndex = 0
        btnAdd.Text = NombreCorto
        btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        btnAdd.TextMargin = New System.Windows.Forms.Padding(2)
        btnAdd.TextShadowShow = False
        btnAdd.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        btnAdd.UseMnemonic = True
        btnAdd.Tag = Id
        btnAdd.Enabled = Enabled
        AddHandler btnAdd.Click, AddressOf clickMesa

        pnlMesas.Controls.Add(btnAdd)
    End Sub

    Private Sub MesaOcupadaButton(ByVal Id As Integer, ByVal NombreCorto As String, ByVal Top As Integer, ByVal Left As Integer, ByVal Enabled As Boolean, ByVal IdStatus As Integer)
        Dim btnAdd As New Azteca.Windows.Controls.ButtonPlus
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MesasSelForm))
        Dim DesignerRectTracker3 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems2 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker4 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()

        btnAdd.AutoLock = False
        btnAdd.BorderColor = System.Drawing.Color.Olive
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        btnAdd.CenterPtTracker = DesignerRectTracker3
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(114, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))}
        CBlendItems2.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        btnAdd.ColorFillBlend = CBlendItems2
        btnAdd.ColorFillSolid = System.Drawing.SystemColors.Control
        btnAdd.Corners.All = CType(6, Short)
        btnAdd.Corners.LowerLeft = CType(6, Short)
        btnAdd.Corners.LowerRight = CType(6, Short)
        btnAdd.Corners.UpperLeft = CType(6, Short)
        btnAdd.Corners.UpperRight = CType(6, Short)
        btnAdd.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientLinear
        btnAdd.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        btnAdd.FocalPoints.CenterPtX = 0.5!
        btnAdd.FocalPoints.CenterPtY = 0.5!
        btnAdd.FocalPoints.FocusPtX = 0.0!
        btnAdd.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        btnAdd.FocusPtTracker = DesignerRectTracker4
        btnAdd.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        btnAdd.ForeColor = System.Drawing.Color.Black
        If IdStatus = Kernel.BusinessStructure.WorkflowSteps.Close Then
            btnAdd.Image = Global.Azteca.Windows.My.Resources.Resources.loan_64
        Else
            btnAdd.Image = Global.Azteca.Windows.My.Resources.Resources.Mesa_64
        End If
        btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        btnAdd.ImageIndex = 0
        btnAdd.ImageSize = New System.Drawing.Size(64, 64)
        btnAdd.Location = New System.Drawing.Point(Left, Top)
        btnAdd.Name = "btnMesaInactiva"
        btnAdd.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        btnAdd.SideImage = Nothing
        btnAdd.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        btnAdd.SideImageSize = New System.Drawing.Size(48, 48)
        btnAdd.Size = New System.Drawing.Size(90, 90)
        btnAdd.TabIndex = 1
        btnAdd.Text = NombreCorto
        btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        btnAdd.TextMargin = New System.Windows.Forms.Padding(2)
        btnAdd.TextShadowShow = False
        btnAdd.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        btnAdd.UseMnemonic = True

        btnAdd.Tag = Id
        btnAdd.Enabled = Enabled
        AddHandler btnAdd.Click, AddressOf clickMesa

        pnlMesas.Controls.Add(btnAdd)
    End Sub

    Private Sub clickMesa(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim IdStatus As Integer = 0
        Dim cmd As Azteca.Windows.Controls.ButtonPlus = CType(sender, Azteca.Windows.Controls.ButtonPlus)
        IdMesa = CInt(cmd.Tag)
        Dim dv As New DataView(MesasTable, "IdMesa=" & IdMesa, "", DataViewRowState.CurrentRows)
        IdComandaTit = dv(0)("IdComandaTit") : IdStatus = dv(0)("IdStatus")

        If ModalidadPantalla = ModalidadPantallaEnum.Seleccion Then
            If IdStatus = Kernel.BusinessStructure.WorkflowSteps.Close Then
                MessageBox.Show("La comanda esta cerrada y no puede modificarse", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop) : Exit Sub
            End If
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        ElseIf ModalidadPantalla = ModalidadPantallaEnum.Cuenta Then
            Cuenta(IdComandaTit)
        End If

    End Sub

#End Region

End Class

Public Enum ModalidadPantallaEnum
    Seleccion
    Cuenta
    Combinar
    Separar
End Enum
