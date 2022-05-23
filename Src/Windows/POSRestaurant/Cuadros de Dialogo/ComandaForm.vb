Public Class ComandaForm
    Private _Comanda As ComandaInfo

    Public ReadOnly Property Comanda As ComandaInfo
        Get
            Return _Comanda
        End Get
    End Property

#Region "Variables de botones automaticos"
    Private SizeBtn As Integer = 0
    Private artCapacidad As Integer = 0, artPagina As Integer, artPaginas As Integer = 0
    Private centroProdCapacidad As Integer = 0, centroProdPagina As Integer, CentroProdPaginas As Integer = 0
    Private categoriaCapacidad As Integer, categoriaPagina As Integer, categoriaPaginas As Integer = 0

    Private artButtonsX As Integer = 0, artButtonsY As Integer = 0
    Private IdCentroProduccion As Integer, IdCategoria As Integer

#End Region

#Region "Implementacion de eventos de la forma"

    Public Overloads Function showdialog(ByVal IdComandaTit As String) As DialogResult
        If IdComandaTit = "" Then
            _Comanda = New ComandaInfo(App.Session.SessionID)
        Else
            Dim ComandaFac As New ComandaFacade
            _Comanda = ComandaFac.GetDetail(App.Session.SessionID, IdComandaTit)
            fillComanda()
        End If

        Return MyBase.ShowDialog
    End Function

    Public Overloads Function showdialog(ByVal Comanda As ComandaInfo) As DialogResult
        Dim ComandaFac As New ComandaFacade
        _Comanda = Comanda
        fillComanda()
        Return MyBase.ShowDialog
    End Function


    Private Sub ComandaForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        SizeBtn = pnlCentrosProduccion.Width
        artButtonsX = (pnlArticulos.Width \ SizeBtn)
        artButtonsY = (pnlArticulos.Height \ SizeBtn)
        artCapacidad = (artButtonsX * artButtonsY) - 2

        centroProdCapacidad = (pnlCentrosProduccion.Height \ SizeBtn) - 2
        categoriaCapacidad = (pnlCategorias.Width \ SizeBtn) - 2

        'Cuantas paginas desplegaria el listado de articulos
        If Not IsNothing(Context.ArticulosTable) Then
            artPaginas = CInt(Math.Ceiling(Context.ArticulosTable.Rows.Count / artCapacidad))
        End If

        'Cuantas paginas desplegaria el listado de Centros produccion
        If Not IsNothing(Context.CentrosProduccionTable) Then
            CentroProdPaginas = CInt(Math.Ceiling(Context.CentrosProduccionTable.Rows.Count / centroProdCapacidad))
        End If
        'Cuantas paginas desplegaria el listado de Categorias
        If Not IsNothing(Context.CentrosProduccionTable) Then
            categoriaPaginas = CInt(Math.Ceiling(Context.CategoriasTable.Rows.Count / categoriaCapacidad))
        End If

        ResetArticulos() : ResetCentrosProduccion() : ResetCategorias()
        fillArticulos() : fillCentrosProduccion() : fillCategorias()
    End Sub


    Private Sub cmdAumentar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAumentar.Click
        If lvwComanda.SelectedItems.Count = 0 Then Exit Sub
        Dim dr As ComandaDS.ComandaDetRow = CType(lvwComanda.SelectedItems(0).Tag, ComandaDS.ComandaDetRow)
        dr.Cantidad = dr.Cantidad + 1 : lvwComanda.SelectedItems(0).SubItems(1).Text = dr.Cantidad
    End Sub

    Private Sub cmdDisminuir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisminuir.Click
        If lvwComanda.SelectedItems.Count = 0 Then Exit Sub
        Dim dr As ComandaDS.ComandaDetRow = CType(lvwComanda.SelectedItems(0).Tag, ComandaDS.ComandaDetRow)
        dr.Cantidad = dr.Cantidad - 1 : lvwComanda.SelectedItems(0).SubItems(1).Text = dr.Cantidad
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            If _Comanda.Details.Rows.Count = 0 Then
                MessageBox.Show("Debe seleccionar al menos un articulo", "restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitar.Click
        If lvwComanda.SelectedItems.Count = 0 Then Exit Sub
        Dim dr As ComandaDS.ComandaDetRow = CType(lvwComanda.SelectedItems(0).Tag, ComandaDS.ComandaDetRow)
        dr.Delete() : fillComanda()
    End Sub

    Private Sub txtSubir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubir.Click
        If lvwComanda.SelectedItems.Count = 0 Then Exit Sub
        Dim dr As ComandaDS.ComandaDetRow = CType(lvwComanda.SelectedItems(0).Tag, ComandaDS.ComandaDetRow)
    End Sub

#End Region

#Region "Manejo de botones de Centros de produccion"

    Private Sub ResetCentrosProduccion()
        centroProdPagina = 1
    End Sub


    Private Sub fillCentrosProduccion()

        Dim CentroProdFac As New CentroProduccionFacade

        If IsNothing(Context.CentrosProduccionTable) Then Exit Sub

        pnlCentrosProduccion.Controls.Clear()

        Dim countY As Integer = 1

        'Ponemos el boton de anterior para los centros de produccion previos cuando se está paginando la lista
        addPreviusButtonCentroProd(SizeBtn * (countY - 1), 0) : countY = countY + 1

        Dim dv As New DataView(Context.CentrosProduccionTable, "", "CentroProduccion", System.Data.DataViewRowState.CurrentRows)

        Dim inicio As Integer = (centroProdPagina - 1) * centroProdCapacidad
        Dim Fin As Integer = inicio + centroProdCapacidad
        For i As Integer = inicio To Fin - 1
            If i > Context.CentrosProduccionTable.Rows.Count - 1 Then Exit For

            'cada vez q se llene una linea de botones en Y, se resetea Y 
            'If countY > CentrosProduccionTable.Rows.Count Then countY = 1

            Dim Imagen As Byte()
            If IsDBNull(dv(i)("Imagen")) Then
                Imagen = Nothing
            Else
                Imagen = dv(i)("Imagen")
            End If

            'Agrega el boton del centro de produccion
            addButtonCentroProduccion(dv(i)("Id"), dv(i)("CentroProduccion"), Imagen, SizeBtn * (countY - 1), 0)

            countY = countY + 1
        Next
        'Ponemos el boton de siguiente para los Centros de produccion previos cuando se está paginando la lista 
        addNextButtonCentroProd(SizeBtn * (countY - 1), 0)

    End Sub

    Private Sub addButtonCentroProduccion(ByVal Id As Integer, ByVal Descripcion As String, ByVal imagen As Byte(), ByVal Top As Integer, ByVal Left As Integer)
        Dim cmd As New Azteca.Windows.Controls.ButtonPlus
        FormatoButton(cmd, "")
        cmd.Text = Descripcion : cmd.Width = SizeBtn : cmd.Height = SizeBtn 'Me.CButtonRound2.Size = New System.Drawing.Size(90, 90)
        cmd.Left = (pnlEsquina.Width - cmd.Width) / 2 : cmd.Top = Top  '': cmd.ForeColor = Color.
        cmd.Margin = New System.Windows.Forms.Padding(5)
        If Not imagen Is Nothing Then
            Dim ms As New System.IO.MemoryStream(imagen)
            cmd.Image = System.Drawing.Image.FromStream(ms)
            cmd.ImageSize = New System.Drawing.Size(64, 64)
            ms.Close()
            cmd.Text = ""
        End If

        cmd.Tag = Id
        AddHandler cmd.Click, AddressOf clickCentroProduccion
        pnlCentrosProduccion.Controls.Add(cmd)
    End Sub

    Private Sub addNextButtonCentroProd(ByVal Top As Integer, ByVal Left As Integer)
        Dim cmd As New Azteca.Windows.Controls.CIButton
        cmd.Image = My.Resources.down_64 : cmd.FlatStyle = FlatStyle.Flat : cmd.FlatAppearance.BorderSize = 0 : cmd.BackColor = Color.Transparent
        cmd.Width = SizeBtn : cmd.Height = SizeBtn
        cmd.Left = Left : cmd.Top = Top : cmd.Enabled = IIf(centroProdPagina = CentroProdPaginas, False, True)
        AddHandler cmd.Click, AddressOf clickPageNextCentroProd
        pnlCentrosProduccion.Controls.Add(cmd)
    End Sub

    Private Sub addPreviusButtonCentroProd(ByVal Top As Integer, ByVal Left As Integer)
        Dim cmd As New Azteca.Windows.Controls.CIButton
        ''FormatoButton(cmd)
        cmd.Text = "" : cmd.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        cmd.Image = My.Resources.up_64 : cmd.FlatStyle = FlatStyle.Flat : cmd.FlatAppearance.BorderSize = 0 : cmd.BackColor = Color.Transparent
        cmd.Width = SizeBtn : cmd.Height = SizeBtn
        cmd.Left = Left : cmd.Top = Top : cmd.Enabled = IIf(centroProdPagina = 1, False, True)
        AddHandler cmd.Click, AddressOf clickPagePreviusCentroProd
        pnlCentrosProduccion.Controls.Add(cmd)
    End Sub

    Private Sub clickPageNextCentroProd(ByVal sender As System.Object, ByVal e As System.EventArgs)
        centroProdPagina = centroProdPagina + 1
        fillCentrosProduccion()
    End Sub

    Private Sub clickPagePreviusCentroProd(ByVal sender As System.Object, ByVal e As System.EventArgs)
        centroProdPagina = centroProdPagina - 1
        fillCentrosProduccion()
    End Sub

    Private Sub clickCentroProduccion(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cmd As Azteca.Windows.Controls.ButtonPlus = CType(sender, Azteca.Windows.Controls.ButtonPlus)
        'cmd.BorderColor = Color.White
        'resetFlatCentroProduccion()
        IdCentroProduccion = CInt(cmd.Tag)
        ''cmd.FlatStyle = FlatStyle.Standard
        fillArticulos()
    End Sub

    Private Sub resetFlatCentroProduccion()
        For Each Control As Control In pnlCentrosProduccion.Controls
            Dim cmd As Azteca.Windows.Controls.ButtonPlus = CType(Control, Azteca.Windows.Controls.ButtonPlus)
            'If cmd.BorderColor = System.Drawing.Color.White Then
            cmd.BorderColor = System.Drawing.Color.AliceBlue : Exit For
            'End If
        Next
    End Sub

#End Region

#Region "Manejo de botones de articulos"

    Private Sub ResetArticulos()
        artPagina = 1
    End Sub

    Private Sub fillArticulos()
        If IsNothing(Context.ArticulosTable) Then Exit Sub

        pnlArticulos.Controls.Clear()

        Dim countX As Integer = 1, countY As Integer = 1

        If IdCentroProduccion = 0 Then Exit Sub

        Dim query = From ArtCtoProd In Context.ArticulosCentrosTable _
              Join Art In Context.ArticulosTable On Art.IdArticulo Equals ArtCtoProd.IdArticulo
              Where ArtCtoProd.IdCentroProduccion = IdCentroProduccion And Art.IdCategoria = IdCategoria
              Order By Art.Articulo Select Art.Articulo, Art.IdArticulo, Art.PrecioNeto, Art.Color

        artPaginas = CInt(Math.Ceiling(query.Count / artCapacidad))

        'Ponemos el boton de anterior para los articulos previos cuando se está paginando la lista de articulos
        addPreviusButtonArt(SizeBtn * (countY - 1), SizeBtn * (countX - 1)) : countX = countX + 1

        Dim inicio As Integer = (artPagina - 1) * artCapacidad
        Dim Fin As Integer = inicio + artCapacidad
        For i As Integer = inicio To Fin - 1

            'cada vez q se llene una linea de botones en X, se resetea X y se incrementa Y para mostrar en el siguiente renglon
            If countX > artButtonsX Then countX = 1 : countY = countY + 1

            If i > query.Count - 1 Then Exit For

            Dim Imagen As Byte() = Nothing
            Dim Art As ArticulosConfigDS.ArticuloRow = Context.ArticulosTable.FindByIdArticulo(query(i).IdArticulo)
            If Not Art.IsImagenNull Then Imagen = Art.Imagen
            'Agrega el boton del articulo
            addButtonArticulo(query(i).IdArticulo, query(i).Articulo, query(i).PrecioNeto, Imagen, SizeBtn * (countY - 1), SizeBtn * (countX - 1), query(i).Color)

            countX = countX + 1
        Next
        'Ponemos el boton de siguiente para los articulos previos cuando se está paginando la lista de articulos
        addNextButtonArt(SizeBtn * (countY - 1), SizeBtn * (countX - 1)) : countX = countX + 1

    End Sub

    Private Sub addButtonArticulo(ByVal Id As Integer, ByVal Descripcion As String, ByVal Precio As Decimal, ByVal Imagen As Byte(), ByVal Top As Integer, ByVal Left As Integer, ByVal Color As String)
        Dim cmd As New Azteca.Windows.Controls.ButtonPlus
        cmd.Text = Descripcion & ControlChars.CrLf & Precio.ToString("#.00") : cmd.Width = SizeBtn : cmd.Height = SizeBtn
        cmd.Left = Left : cmd.Top = Top : cmd.Tag = Id
        If Not Imagen Is Nothing Then
            Dim ms As New System.IO.MemoryStream(Imagen)
            cmd.Image = System.Drawing.Image.FromStream(ms)
            cmd.ImageSize = New System.Drawing.Size(64, 64)
            ms.Close()
            ' cmd.ImageAlign = ContentAlignment.TopCenter
            cmd.Text = ""
        End If
        FormatoButton(cmd, Color)
        AddHandler cmd.Click, AddressOf clickArticulo
        pnlArticulos.Controls.Add(cmd)
    End Sub

    Private Sub addNextButtonArt(ByVal Top As Integer, ByVal Left As Integer)
        Dim cmd As New Azteca.Windows.Controls.CIButton
        cmd.Image = My.Resources.down_64 : cmd.FlatStyle = FlatStyle.Flat : cmd.FlatAppearance.BorderSize = 0 : cmd.BackColor = Color.Transparent
        cmd.Width = SizeBtn : cmd.Height = SizeBtn
        cmd.Left = Left : cmd.Top = Top : cmd.Enabled = IIf(artPagina = artPaginas, False, True)
        AddHandler cmd.Click, AddressOf clickPageNextArt
        pnlArticulos.Controls.Add(cmd)
    End Sub

    Private Sub addPreviusButtonArt(ByVal Top As Integer, ByVal Left As Integer)
        Dim cmd As New Azteca.Windows.Controls.CIButton
        cmd.Image = My.Resources.up_64 : cmd.FlatStyle = FlatStyle.Flat : cmd.FlatAppearance.BorderSize = 0 : cmd.BackColor = Color.Transparent
        cmd.Width = SizeBtn : cmd.Height = SizeBtn
        cmd.Left = Left : cmd.Top = Top : cmd.Enabled = IIf(artPagina = 1, False, True)
        AddHandler cmd.Click, AddressOf clickPagePreviusArt
        pnlArticulos.Controls.Add(cmd)
    End Sub

    Private Sub clickPageNextArt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        artPagina = artPagina + 1
        fillArticulos()
    End Sub

    Private Sub clickPagePreviusArt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        artPagina = artPagina - 1
        fillArticulos()
    End Sub

    Private Sub clickArticulo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cmd As Azteca.Windows.Controls.ButtonPlus = CType(sender, Azteca.Windows.Controls.ButtonPlus)
        addArticuloComanda(CInt(cmd.Tag))
    End Sub

    Private Sub addArticuloComanda(ByVal IdArticulo As Integer)
        Dim Partida As Integer = 1, IngredientesExtra As Boolean = False
        Dim InsumosOpcionalesTable As ProductosDS.InsumosOpcionalesDataTable = Nothing

        Dim item As ComandaDS.ComandaDetRow = _Comanda.Details.FindByIdArticuloIdCentroProduccion(IdArticulo, IdCentroProduccion)
        Dim drArticulo As ArticulosConfigDS.ArticuloRow = Context.ArticulosTable.FindByIdArticulo(IdArticulo)
        'Verificamos si este articulo se va a producir. De ser asi, mostramos listado de insumos opcionales en caso de tenerlos
        If drArticulo.IdProducto Then
            Dim ProdFac As New ProductoFacade
            InsumosOpcionalesTable = ProdFac.InsumosOpcionales(App.Session.SessionID, drArticulo.IdProducto)
            If InsumosOpcionalesTable.Rows.Count > 0 Then
                Dim frmOpcionales As New InsumosOpcionalesForm
                If frmOpcionales.ShowDialog(Me, InsumosOpcionalesTable) = DialogResult.OK Then
                    InsumosOpcionalesTable = frmOpcionales.returnInsumosTable
                    IngredientesExtra = True
                End If
            End If
        End If

        'Validamos la divisa
        If _Comanda.IdDivisa = 0 Then _Comanda.IdDivisa = drArticulo.IdDivisa

        If _Comanda.IdDivisa <> drArticulo.IdDivisa Then
            MessageBox.Show("No se permite incluir en una comanda articulos con diferente divisa", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        'agregamos el articulo a la comanda
        If IsNothing(item) Then
            item = _Comanda.Details.NewComandaDetRow()
            With item
                .IdCentroProduccion = IdCentroProduccion
                .IdArticulo = IdArticulo : .IdArticuloStock = drArticulo.IdArticuloStock : .Articulo = drArticulo.Articulo
                .PrecioUnitario = drArticulo.Precio : .Cantidad = 1 : .Entregado = 0
                .IdImpuesto1 = drArticulo.IdImpuesto1 : .IdImpuesto2 = drArticulo.IdImpuesto2 : .IdImpuesto3 = drArticulo.IdImpuesto3
                .PorImpto1 = drArticulo.PorImpto1 : .PorImpto2 = drArticulo.PorImpto2 : .PorImpto3 = drArticulo.PorImpto3
                .PrecioNeto = drArticulo.PrecioNeto
                .Observaciones = ""
            End With
            _Comanda.Details.AddComandaDetRow(item)
        Else
            If IngredientesExtra Then
                Dim UltimaPartida As Integer = _Comanda.IngredientesExtra.Compute("MAX(Partida)", "IdArticulo=" & IdArticulo)
                Partida = UltimaPartida + 1
            End If
            item.Cantidad = item.Cantidad + 1
        End If

        'Agrega el detalle de los ingredientes Extra
        If IngredientesExtra Then AgregarIngredientesExtra(IdArticulo, Partida, InsumosOpcionalesTable)

        fillComanda()
    End Sub

    Private Sub AgregarIngredientesExtra(ByVal IdArticulo As Integer, ByVal Partida As Integer, ByVal InsumosOpcionalesTable As ProductosDS.InsumosOpcionalesDataTable)
        For Each drIng As ProductosDS.InsumosOpcionalesRow In InsumosOpcionalesTable
            Dim drNew As ComandaDS.IngredientesExtraRow = _Comanda.IngredientesExtra.NewIngredientesExtraRow
            With drNew
                .IdArticulo = IdArticulo
                .IdInsumo = drIng.IdInsumo
                .Insumo = drIng.Insumo
                .Partida = Partida
            End With
            _Comanda.IngredientesExtra.AddIngredientesExtraRow(drNew)
        Next
    End Sub

#End Region

#Region "Manejo de botones de Categorias"

    Private Sub ResetCategorias()
        categoriaPagina = 1
    End Sub

    Private Sub fillCategorias()

        Dim categoriaFac As New CentroProduccionFacade

        If IsNothing(Context.CategoriasTable) Then Exit Sub

        pnlCategorias.Controls.Clear()

        Dim countX As Integer = 1

        'Ponemos el boton de anterior para los categorias previas cuando se está paginando la lista
        addPreviusButtonCategoria(0, SizeBtn * (countX - 1)) : countX = countX + 1

        Dim dv As New DataView(Context.CategoriasTable, "", "Nombre", System.Data.DataViewRowState.CurrentRows)

        Dim inicio As Integer = (categoriaPagina - 1) * categoriaCapacidad
        Dim Fin As Integer = inicio + categoriaCapacidad
        For i As Integer = inicio To Fin - 1
            If i > Context.CategoriasTable.Rows.Count - 1 Then Exit For

            'cada vez q se llene una linea de botones en Y, se resetea Y 
            'If countX > CentrosProduccionTable.Rows.Count Then countX = 1

            'Agrega el boton del centro de produccion
            Dim Imagen As Byte()
            If IsDBNull(dv(i)("Imagen")) Then
                Imagen = Nothing
            Else
                Imagen = dv(i)("Imagen")
            End If
            addButtonCategoria(dv(i)("IdCategoria"), dv(i)("Nombre"), Imagen, 0, SizeBtn * (countX - 1), dv(i)("Color"))

            countX = countX + 1
        Next
        'Ponemos el boton de siguiente para los Centros de produccion previos cuando se está paginando la lista 
        addNextButtonCategoria(0, SizeBtn * (countX - 1))

    End Sub

    Private Sub addButtonCategoria(ByVal Id As Integer, ByVal Descripcion As String, ByVal image As Byte(), ByVal Top As Integer, ByVal Left As Integer, ByVal color As String)
        Dim cmd As New Azteca.Windows.Controls.ButtonPlus
        cmd.Text = Descripcion : cmd.Width = SizeBtn : cmd.Height = SizeBtn - 5
        If Not image Is Nothing Then
            Dim ms As New System.IO.MemoryStream(image)
            cmd.Image = System.Drawing.Image.FromStream(ms)
            cmd.ImageSize = New System.Drawing.Size(64, 64)
            ms.Close()
            cmd.Text = ""
        End If

        FormatoButton(cmd, color)

        cmd.Left = Left : cmd.Top = (pnlEsquina.Height - cmd.Height) / 2
        cmd.Tag = Id
        AddHandler cmd.Click, AddressOf clickCategoria
        pnlCategorias.Controls.Add(cmd)
    End Sub

    Private Sub addNextButtonCategoria(ByVal Top As Integer, ByVal Left As Integer)
        Dim cmd As New Azteca.Windows.Controls.CIButton
        cmd.Image = My.Resources.next_64 : cmd.FlatStyle = FlatStyle.Flat : cmd.FlatAppearance.BorderSize = 0 : cmd.BackColor = Color.Transparent
        cmd.Width = SizeBtn : cmd.Height = SizeBtn - 10
        cmd.Left = Left : cmd.Top = (pnlEsquina.Height - cmd.Height) / 2 : cmd.Enabled = IIf(categoriaPagina = categoriaPaginas, False, True)
        AddHandler cmd.Click, AddressOf clickPageNextCategoria
        pnlCategorias.Controls.Add(cmd)
    End Sub

    Private Sub addPreviusButtonCategoria(ByVal Top As Integer, ByVal Left As Integer)
        Dim cmd As New Azteca.Windows.Controls.CIButton
        cmd.Image = My.Resources.back_64 : cmd.FlatStyle = FlatStyle.Flat : cmd.FlatAppearance.BorderSize = 0 : cmd.BackColor = Color.Transparent
        cmd.Width = SizeBtn : cmd.Height = SizeBtn - 10
        cmd.Left = Left : cmd.Top = (pnlEsquina.Height - cmd.Height) / 2 : cmd.Enabled = IIf(categoriaPagina = 1, False, True)
        AddHandler cmd.Click, AddressOf clickPagePreviusCategoria
        pnlCategorias.Controls.Add(cmd)
    End Sub

    Private Sub clickPageNextCategoria(ByVal sender As System.Object, ByVal e As System.EventArgs)
        categoriaPagina = categoriaPagina + 1
        fillCategorias()
    End Sub

    Private Sub clickPagePreviusCategoria(ByVal sender As System.Object, ByVal e As System.EventArgs)
        categoriaPagina = categoriaPagina - 1
        fillCategorias()
    End Sub

    Private Sub clickCategoria(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cmd As Azteca.Windows.Controls.ButtonPlus = CType(sender, Azteca.Windows.Controls.ButtonPlus)
        ''resetFlatCategorias()
        ''cmd.FlatStyle = FlatStyle.Standard
        IdCategoria = CInt(cmd.Tag)
        fillArticulos()
    End Sub

    Private Sub resetFlatCategorias()
        For Each Control As Control In pnlCategorias.Controls
            Dim cmd As Azteca.Windows.Controls.CIButton = CType(Control, Azteca.Windows.Controls.CIButton)

            If cmd.FlatStyle = FlatStyle.Standard Then
                cmd.FlatStyle = FlatStyle.Flat
                Exit For
            End If
        Next
    End Sub

#End Region

#Region "Metodos Privados"

    Private Sub FormatoButton(ByVal cmd As Azteca.Windows.Controls.ButtonPlus, ByVal color As String)
        Dim CBlendItems1 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()

        cmd.BackColor = System.Drawing.Color.Transparent
        'Dim DesignerRectTracker1 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        'DesignerRectTracker1.IsActive = False
        'DesignerRectTracker1.TrackerRectangle = CType(Resources.GetObject("DesignerRectTracker31.TrackerRectangle"), System.Drawing.RectangleF)
        'Me.CButtonRound2.CenterPtTracker = DesignerRectTracker31

        If color.Trim.Length = 0 Then
            cmd.BorderColor = System.Drawing.Color.Goldenrod
            CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.White,
                                                              System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)),
                                                              System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))}
        Else
            Dim myColor As System.Drawing.Color = System.Drawing.ColorTranslator.FromHtml(CInt(color))
            CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.White,
                                                  System.Drawing.Color.FromArgb(CType(CType(myColor.A, Byte), Integer), CType(CType(myColor.R, Byte), Integer), CType(CType(myColor.G, Byte), Integer), CType(CType(myColor.B, Byte), Integer)),
                                                  System.Drawing.Color.FromArgb(CType(CType(myColor.A, Byte), Integer), CType(CType(myColor.R, Byte), Integer), CType(CType(myColor.G, Byte), Integer), CType(CType(myColor.B, Byte), Integer))}
            cmd.BorderColor = myColor
        End If

        CBlendItems1.iPoint = New Single() {0.0!, 0.00308642!, 1.0!}
        cmd.ColorFillBlend = CBlendItems1
        cmd.ColorFillSolid = System.Drawing.Color.OrangeRed
        cmd.Corners.All = CType(20, Short)
        cmd.Corners.LowerLeft = CType(15, Short)
        cmd.Corners.LowerRight = CType(15, Short)
        cmd.Corners.UpperLeft = CType(15, Short)
        cmd.Corners.UpperRight = CType(15, Short)
        cmd.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientLinear
        cmd.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        cmd.FocalPoints.CenterPtX = 0.4823529!
        cmd.FocalPoints.CenterPtY = 0.6!
        cmd.FocalPoints.FocusPtX = 0.6!
        cmd.FocalPoints.FocusPtY = 0.6!
        cmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        cmd.ForeColor = System.Drawing.Color.Olive
        cmd.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        cmd.SideImage = Nothing
        cmd.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        cmd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        cmd.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        cmd.TextMargin = New System.Windows.Forms.Padding(0)
        cmd.TextShadow = System.Drawing.Color.DodgerBlue
        cmd.TextShadowShow = False
        cmd.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        cmd.UseMnemonic = True
    End Sub

    Private Sub fillComanda()
        Dim Partida As Integer = 0
        Dim Total As Decimal = 0
        Dim CantidadItems As Integer = 0

        lvwComanda.BeginUpdate()
        lvwComanda.Items.Clear()
        ''Dim vwOrdenes As New DataView(dtOrdenes, "", "Fecha DESC, SUCURSAL", DataViewRowState.CurrentRows)
        For Each dr As ComandaDS.ComandaDetRow In _Comanda.Details
            If Not dr.RowState = DataRowState.Deleted Then
                Dim Item As New ListViewItem(dr.Articulo, 2)
                Item.SubItems.Add(dr.Cantidad.ToString("#0"))
                Item.SubItems.Add(dr.PrecioNeto.ToString("#0.00"))
                Dim Importe As Decimal = dr.PrecioNeto * dr.Cantidad
                Item.SubItems.Add(Importe.ToString("#0.00"))

                Item.Tag = CType(dr, ComandaDS.ComandaDetRow)
                lvwComanda.Items.Add(Item)

                'Mostramos los ingredientes Extra
                Dim dvExtras As New DataView(_Comanda.IngredientesExtra, "IdArticulo=" & dr.IdArticulo, "Partida", DataViewRowState.CurrentRows)
                For Each drExtra As DataRowView In dvExtras
                    If Partida <> drExtra("Partida") Then
                        Dim ItemPartida As New ListViewItem(CStr("     Partida:" & drExtra("Partida")), 2)
                        lvwComanda.Items.Add(ItemPartida.Clone)
                    End If
                    Dim ItemExtra As New ListViewItem()
                    ItemExtra.BackColor = Color.Beige
                    ItemExtra.Text = "     " + "*" + CStr(drExtra("Insumo"))
                    lvwComanda.Items.Add(ItemExtra)
                    Partida = drExtra("Partida")
                Next
                Total = Total + Importe
                CantidadItems = CantidadItems + dr.Cantidad
            End If
        Next
        lvwComanda.EndUpdate()
        lblTotTotalTXT.Text = Total.ToString("#0.00")
        lblTotCantidadTXT.Text = CantidadItems.ToString("#0")
    End Sub

#End Region

End Class