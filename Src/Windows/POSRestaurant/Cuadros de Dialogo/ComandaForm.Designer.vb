<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComandaForm
    Inherits Azteca.Windows.Forms.BaseForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComandaForm))
        Me.pnlTituloComanda = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha14 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha15 = New Azteca.Windows.ColorWithAlpha()
        Me.lblComanda = New Azteca.Windows.Controls.CILabel()
        Me.pnlTitulo = New Azteca.Windows.Controls.CIPanel()
        Me.SplitHorImagenTitulos = New System.Windows.Forms.SplitContainer()
        Me.splitVerImagen = New System.Windows.Forms.SplitContainer()
        Me.pnlLogp = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha16 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha17 = New Azteca.Windows.ColorWithAlpha()
        Me.lblTotCantidadTXT = New Azteca.Windows.Controls.CILabel()
        Me.lblTotTotalTXT = New Azteca.Windows.Controls.CILabel()
        Me.lblTotCantidad = New Azteca.Windows.Controls.CILabel()
        Me.lblTotTotal = New Azteca.Windows.Controls.CILabel()
        Me.pnlPicture = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.CiPicture1 = New Azteca.Windows.Controls.CIPicture()
        Me.picAzteca = New Azteca.Windows.Controls.CIPicture()
        Me.splitVerComandaSeleccion = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.pnlTitulos = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha3 = New Azteca.Windows.ColorWithAlpha()
        Me.cmdNotas = New Azteca.Windows.Controls.CIButton()
        Me.cmdSubir = New Azteca.Windows.Controls.CIButton()
        Me.cmdCancelar = New Azteca.Windows.Controls.CIButton()
        Me.cmdAceptar = New Azteca.Windows.Controls.CIButton()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.pnlDetalleComanda = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha10 = New Azteca.Windows.ColorWithAlpha()
        Me.pnlCategorias = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha11 = New Azteca.Windows.ColorWithAlpha()
        Me.lvwComanda = New Azteca.Windows.Controls.CIListView()
        Me.colArticulos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrecio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colImporte = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlBtnsHorListadoComanda = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha5 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha4 = New Azteca.Windows.ColorWithAlpha()
        Me.cmdQuitar = New Azteca.Windows.Controls.CIButton()
        Me.cmdBajar = New Azteca.Windows.Controls.CIButton()
        Me.cmdDisminuir = New Azteca.Windows.Controls.CIButton()
        Me.cmdNota = New Azteca.Windows.Controls.CIButton()
        Me.cmdAumentar = New Azteca.Windows.Controls.CIButton()
        Me.SplitSeleccionTituloCtrs = New System.Windows.Forms.SplitContainer()
        Me.pnlTituloPlatillos = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.pnlClrCmdaTit1 = New Azteca.Windows.ColorWithAlpha()
        Me.pnlClrCmdaTit2 = New Azteca.Windows.ColorWithAlpha()
        Me.lblPlatillos = New Azteca.Windows.Controls.CILabel()
        Me.SplitVerPlatillosCtroProdVsArticulos = New System.Windows.Forms.SplitContainer()
        Me.splitHorPlatillosEsquinaCtroProd = New System.Windows.Forms.SplitContainer()
        Me.pnlEsquina = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha6 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha7 = New Azteca.Windows.ColorWithAlpha()
        Me.lblCategorias = New Azteca.Windows.Controls.CILabel()
        Me.lblCentrosProduccion = New Azteca.Windows.Controls.CILabel()
        Me.pnlCentrosProduccion = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha8 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha9 = New Azteca.Windows.ColorWithAlpha()
        Me.pnlEspiral = New Azteca.Windows.Controls.CIPanel()
        Me.splitHorPlatillosCategoriasArticulos = New System.Windows.Forms.SplitContainer()
        Me.pnlArticulos = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha12 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha13 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.CiStatusBar1 = New Azteca.Windows.Controls.CIStatusBar()
        Me.ColorWithAlpha18 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha19 = New Azteca.Windows.ColorWithAlpha()
        Me.pnlTituloComanda.SuspendLayout()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.SplitHorImagenTitulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitHorImagenTitulos.Panel1.SuspendLayout()
        Me.SplitHorImagenTitulos.Panel2.SuspendLayout()
        Me.SplitHorImagenTitulos.SuspendLayout()
        CType(Me.splitVerImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitVerImagen.Panel1.SuspendLayout()
        Me.splitVerImagen.Panel2.SuspendLayout()
        Me.splitVerImagen.SuspendLayout()
        Me.pnlLogp.SuspendLayout()
        Me.pnlPicture.SuspendLayout()
        CType(Me.CiPicture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAzteca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitVerComandaSeleccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitVerComandaSeleccion.Panel1.SuspendLayout()
        Me.splitVerComandaSeleccion.Panel2.SuspendLayout()
        Me.splitVerComandaSeleccion.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.pnlTitulos.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.pnlDetalleComanda.SuspendLayout()
        Me.pnlBtnsHorListadoComanda.SuspendLayout()
        CType(Me.SplitSeleccionTituloCtrs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitSeleccionTituloCtrs.Panel1.SuspendLayout()
        Me.SplitSeleccionTituloCtrs.Panel2.SuspendLayout()
        Me.SplitSeleccionTituloCtrs.SuspendLayout()
        Me.pnlTituloPlatillos.SuspendLayout()
        CType(Me.SplitVerPlatillosCtroProdVsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitVerPlatillosCtroProdVsArticulos.Panel1.SuspendLayout()
        Me.SplitVerPlatillosCtroProdVsArticulos.Panel2.SuspendLayout()
        Me.SplitVerPlatillosCtroProdVsArticulos.SuspendLayout()
        CType(Me.splitHorPlatillosEsquinaCtroProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitHorPlatillosEsquinaCtroProd.Panel1.SuspendLayout()
        Me.splitHorPlatillosEsquinaCtroProd.Panel2.SuspendLayout()
        Me.splitHorPlatillosEsquinaCtroProd.SuspendLayout()
        Me.pnlEsquina.SuspendLayout()
        Me.pnlCentrosProduccion.SuspendLayout()
        CType(Me.splitHorPlatillosCategoriasArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitHorPlatillosCategoriasArticulos.Panel1.SuspendLayout()
        Me.splitHorPlatillosCategoriasArticulos.Panel2.SuspendLayout()
        Me.splitHorPlatillosCategoriasArticulos.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTituloComanda
        '
        Me.pnlTituloComanda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlTituloComanda.Border = False
        Me.pnlTituloComanda.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlTituloComanda.Colors.Add(Me.ColorWithAlpha14)
        Me.pnlTituloComanda.Colors.Add(Me.ColorWithAlpha15)
        Me.pnlTituloComanda.ContentPadding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.pnlTituloComanda.Controls.Add(Me.lblComanda)
        Me.pnlTituloComanda.CornerRadius = 30
        Me.pnlTituloComanda.Corners = CType((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight), Azteca.Windows.Corner)
        Me.pnlTituloComanda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTituloComanda.Gradient = True
        Me.pnlTituloComanda.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlTituloComanda.GradientOffset = 1.0!
        Me.pnlTituloComanda.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlTituloComanda.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlTituloComanda.Grayscale = False
        Me.pnlTituloComanda.Image = Nothing
        Me.pnlTituloComanda.ImageAlpha = 75
        Me.pnlTituloComanda.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlTituloComanda.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlTituloComanda.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlTituloComanda.Location = New System.Drawing.Point(0, 0)
        Me.pnlTituloComanda.Name = "pnlTituloComanda"
        Me.pnlTituloComanda.Rounded = True
        Me.pnlTituloComanda.Size = New System.Drawing.Size(378, 57)
        Me.pnlTituloComanda.TabIndex = 8
        '
        'ColorWithAlpha14
        '
        Me.ColorWithAlpha14.Alpha = 255
        Me.ColorWithAlpha14.Color = System.Drawing.Color.Olive
        Me.ColorWithAlpha14.Parent = Me.pnlTituloComanda
        '
        'ColorWithAlpha15
        '
        Me.ColorWithAlpha15.Alpha = 255
        Me.ColorWithAlpha15.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha15.Parent = Me.pnlTituloComanda
        '
        'lblComanda
        '
        Me.lblComanda.BackColor = System.Drawing.Color.Transparent
        Me.lblComanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComanda.ForeColor = System.Drawing.Color.Olive
        Me.lblComanda.Location = New System.Drawing.Point(0, 0)
        Me.lblComanda.Name = "lblComanda"
        Me.lblComanda.Size = New System.Drawing.Size(378, 71)
        Me.lblComanda.TabIndex = 3
        Me.lblComanda.Text = "Comanda"
        Me.lblComanda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlTitulo.Controls.Add(Me.SplitHorImagenTitulos)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTitulo.GradientColorA = System.Drawing.SystemColors.ControlLight
        Me.pnlTitulo.GradientColorB = System.Drawing.SystemColors.ControlDark
        Me.pnlTitulo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(957, 570)
        Me.pnlTitulo.TabIndex = 7
        Me.pnlTitulo.UseGradient = False
        '
        'SplitHorImagenTitulos
        '
        Me.SplitHorImagenTitulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SplitHorImagenTitulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitHorImagenTitulos.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitHorImagenTitulos.Location = New System.Drawing.Point(0, 0)
        Me.SplitHorImagenTitulos.Name = "SplitHorImagenTitulos"
        Me.SplitHorImagenTitulos.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitHorImagenTitulos.Panel1
        '
        Me.SplitHorImagenTitulos.Panel1.Controls.Add(Me.splitVerImagen)
        '
        'SplitHorImagenTitulos.Panel2
        '
        Me.SplitHorImagenTitulos.Panel2.Controls.Add(Me.splitVerComandaSeleccion)
        Me.SplitHorImagenTitulos.Size = New System.Drawing.Size(957, 570)
        Me.SplitHorImagenTitulos.SplitterDistance = 110
        Me.SplitHorImagenTitulos.SplitterWidth = 10
        Me.SplitHorImagenTitulos.TabIndex = 0
        '
        'splitVerImagen
        '
        Me.splitVerImagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.splitVerImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitVerImagen.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitVerImagen.Location = New System.Drawing.Point(0, 0)
        Me.splitVerImagen.Name = "splitVerImagen"
        '
        'splitVerImagen.Panel1
        '
        Me.splitVerImagen.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.splitVerImagen.Panel1.Controls.Add(Me.pnlLogp)
        '
        'splitVerImagen.Panel2
        '
        Me.splitVerImagen.Panel2.Controls.Add(Me.pnlPicture)
        Me.splitVerImagen.Size = New System.Drawing.Size(957, 110)
        Me.splitVerImagen.SplitterDistance = 379
        Me.splitVerImagen.SplitterWidth = 10
        Me.splitVerImagen.TabIndex = 0
        '
        'pnlLogp
        '
        Me.pnlLogp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlLogp.Border = True
        Me.pnlLogp.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlLogp.Colors.Add(Me.ColorWithAlpha16)
        Me.pnlLogp.Colors.Add(Me.ColorWithAlpha17)
        Me.pnlLogp.ContentPadding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.pnlLogp.Controls.Add(Me.lblTotCantidadTXT)
        Me.pnlLogp.Controls.Add(Me.lblTotTotalTXT)
        Me.pnlLogp.Controls.Add(Me.lblTotCantidad)
        Me.pnlLogp.Controls.Add(Me.lblTotTotal)
        Me.pnlLogp.CornerRadius = 30
        Me.pnlLogp.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlLogp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLogp.Gradient = True
        Me.pnlLogp.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlLogp.GradientOffset = 1.0!
        Me.pnlLogp.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlLogp.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlLogp.Grayscale = False
        Me.pnlLogp.Image = Nothing
        Me.pnlLogp.ImageAlpha = 75
        Me.pnlLogp.ImagePadding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.pnlLogp.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlLogp.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlLogp.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogp.Name = "pnlLogp"
        Me.pnlLogp.Rounded = True
        Me.pnlLogp.Size = New System.Drawing.Size(379, 110)
        Me.pnlLogp.TabIndex = 0
        '
        'ColorWithAlpha16
        '
        Me.ColorWithAlpha16.Alpha = 255
        Me.ColorWithAlpha16.Color = System.Drawing.Color.White
        Me.ColorWithAlpha16.Parent = Me.pnlPicture
        '
        'ColorWithAlpha17
        '
        Me.ColorWithAlpha17.Alpha = 255
        Me.ColorWithAlpha17.Color = System.Drawing.Color.White
        Me.ColorWithAlpha17.Parent = Me.pnlPicture
        '
        'lblTotCantidadTXT
        '
        Me.lblTotCantidadTXT.BackColor = System.Drawing.Color.Transparent
        Me.lblTotCantidadTXT.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotCantidadTXT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotCantidadTXT.Location = New System.Drawing.Point(200, 21)
        Me.lblTotCantidadTXT.Name = "lblTotCantidadTXT"
        Me.lblTotCantidadTXT.Size = New System.Drawing.Size(78, 26)
        Me.lblTotCantidadTXT.TabIndex = 37
        Me.lblTotCantidadTXT.Text = "0.00"
        Me.lblTotCantidadTXT.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblTotTotalTXT
        '
        Me.lblTotTotalTXT.BackColor = System.Drawing.Color.Transparent
        Me.lblTotTotalTXT.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotTotalTXT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotTotalTXT.Location = New System.Drawing.Point(200, 58)
        Me.lblTotTotalTXT.Name = "lblTotTotalTXT"
        Me.lblTotTotalTXT.Size = New System.Drawing.Size(78, 26)
        Me.lblTotTotalTXT.TabIndex = 36
        Me.lblTotTotalTXT.Text = "0.00"
        Me.lblTotTotalTXT.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblTotCantidad
        '
        Me.lblTotCantidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotCantidad.AutoSize = True
        Me.lblTotCantidad.BackColor = System.Drawing.Color.Transparent
        Me.lblTotCantidad.Font = New System.Drawing.Font("Arial Narrow", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotCantidad.ForeColor = System.Drawing.Color.Black
        Me.lblTotCantidad.Location = New System.Drawing.Point(91, 24)
        Me.lblTotCantidad.Name = "lblTotCantidad"
        Me.lblTotCantidad.Size = New System.Drawing.Size(78, 23)
        Me.lblTotCantidad.TabIndex = 35
        Me.lblTotCantidad.Text = "Cantidad"
        Me.lblTotCantidad.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblTotTotal
        '
        Me.lblTotTotal.AutoSize = True
        Me.lblTotTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotTotal.Font = New System.Drawing.Font("Arial Narrow", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotTotal.Location = New System.Drawing.Point(91, 60)
        Me.lblTotTotal.Name = "lblTotTotal"
        Me.lblTotTotal.Size = New System.Drawing.Size(49, 23)
        Me.lblTotTotal.TabIndex = 34
        Me.lblTotTotal.Text = "Total"
        Me.lblTotTotal.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'pnlPicture
        '
        Me.pnlPicture.BackColor = System.Drawing.Color.Transparent
        Me.pnlPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlPicture.Border = True
        Me.pnlPicture.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlPicture.Colors.Add(Me.ColorWithAlpha16)
        Me.pnlPicture.Colors.Add(Me.ColorWithAlpha17)
        Me.pnlPicture.ContentPadding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.pnlPicture.Controls.Add(Me.CiPicture1)
        Me.pnlPicture.Controls.Add(Me.picAzteca)
        Me.pnlPicture.CornerRadius = 30
        Me.pnlPicture.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPicture.Gradient = True
        Me.pnlPicture.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlPicture.GradientOffset = 1.0!
        Me.pnlPicture.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlPicture.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlPicture.Grayscale = False
        Me.pnlPicture.Image = Nothing
        Me.pnlPicture.ImageAlpha = 75
        Me.pnlPicture.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlPicture.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlPicture.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlPicture.Location = New System.Drawing.Point(0, 0)
        Me.pnlPicture.Name = "pnlPicture"
        Me.pnlPicture.Rounded = True
        Me.pnlPicture.Size = New System.Drawing.Size(568, 110)
        Me.pnlPicture.TabIndex = 2
        '
        'CiPicture1
        '
        Me.CiPicture1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CiPicture1.Image = CType(resources.GetObject("CiPicture1.Image"), System.Drawing.Image)
        Me.CiPicture1.Location = New System.Drawing.Point(24, 16)
        Me.CiPicture1.Name = "CiPicture1"
        Me.CiPicture1.Size = New System.Drawing.Size(317, 78)
        Me.CiPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CiPicture1.TabIndex = 3
        Me.CiPicture1.TabStop = False
        Me.CiPicture1.UIName = Nothing
        '
        'picAzteca
        '
        Me.picAzteca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picAzteca.Image = CType(resources.GetObject("picAzteca.Image"), System.Drawing.Image)
        Me.picAzteca.Location = New System.Drawing.Point(347, 16)
        Me.picAzteca.Name = "picAzteca"
        Me.picAzteca.Size = New System.Drawing.Size(209, 78)
        Me.picAzteca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAzteca.TabIndex = 2
        Me.picAzteca.TabStop = False
        Me.picAzteca.UIName = Nothing
        '
        'splitVerComandaSeleccion
        '
        Me.splitVerComandaSeleccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.splitVerComandaSeleccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitVerComandaSeleccion.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitVerComandaSeleccion.Location = New System.Drawing.Point(0, 0)
        Me.splitVerComandaSeleccion.Name = "splitVerComandaSeleccion"
        '
        'splitVerComandaSeleccion.Panel1
        '
        Me.splitVerComandaSeleccion.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'splitVerComandaSeleccion.Panel2
        '
        Me.splitVerComandaSeleccion.Panel2.Controls.Add(Me.SplitSeleccionTituloCtrs)
        Me.splitVerComandaSeleccion.Size = New System.Drawing.Size(957, 450)
        Me.splitVerComandaSeleccion.SplitterDistance = 378
        Me.splitVerComandaSeleccion.SplitterWidth = 10
        Me.splitVerComandaSeleccion.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlTituloComanda)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(378, 450)
        Me.SplitContainer1.SplitterDistance = 57
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.pnlTitulos)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(378, 389)
        Me.SplitContainer2.SplitterDistance = 78
        Me.SplitContainer2.TabIndex = 0
        '
        'pnlTitulos
        '
        Me.pnlTitulos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTitulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlTitulos.Border = False
        Me.pnlTitulos.BorderColor = System.Drawing.Color.White
        Me.pnlTitulos.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlTitulos.Colors.Add(Me.ColorWithAlpha3)
        Me.pnlTitulos.ContentPadding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.pnlTitulos.Controls.Add(Me.cmdNotas)
        Me.pnlTitulos.Controls.Add(Me.cmdSubir)
        Me.pnlTitulos.Controls.Add(Me.cmdCancelar)
        Me.pnlTitulos.Controls.Add(Me.cmdAceptar)
        Me.pnlTitulos.CornerRadius = 30
        Me.pnlTitulos.Corners = Azteca.Windows.Corner.None
        Me.pnlTitulos.Gradient = True
        Me.pnlTitulos.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlTitulos.GradientOffset = 1.0!
        Me.pnlTitulos.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlTitulos.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.TileFlipX
        Me.pnlTitulos.Grayscale = False
        Me.pnlTitulos.Image = Nothing
        Me.pnlTitulos.ImageAlpha = 75
        Me.pnlTitulos.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlTitulos.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlTitulos.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlTitulos.Location = New System.Drawing.Point(0, 1)
        Me.pnlTitulos.Name = "pnlTitulos"
        Me.pnlTitulos.Rounded = True
        Me.pnlTitulos.Size = New System.Drawing.Size(378, 76)
        Me.pnlTitulos.TabIndex = 10
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.White
        Me.ColorWithAlpha2.Parent = Me.pnlTitulos
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.White
        Me.ColorWithAlpha3.Parent = Me.pnlTitulos
        '
        'cmdNotas
        '
        Me.cmdNotas.BackColor = System.Drawing.Color.Transparent
        Me.cmdNotas.FlatAppearance.BorderSize = 0
        Me.cmdNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNotas.Image = CType(resources.GetObject("cmdNotas.Image"), System.Drawing.Image)
        Me.cmdNotas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNotas.Location = New System.Drawing.Point(114, 8)
        Me.cmdNotas.Name = "cmdNotas"
        Me.cmdNotas.Size = New System.Drawing.Size(79, 60)
        Me.cmdNotas.TabIndex = 3
        Me.cmdNotas.Text = "Nota General"
        Me.cmdNotas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdNotas.UseVisualStyleBackColor = False
        '
        'cmdSubir
        '
        Me.cmdSubir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdSubir.BackColor = System.Drawing.Color.Transparent
        Me.cmdSubir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdSubir.FlatAppearance.BorderSize = 0
        Me.cmdSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSubir.Image = CType(resources.GetObject("cmdSubir.Image"), System.Drawing.Image)
        Me.cmdSubir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSubir.Location = New System.Drawing.Point(287, 8)
        Me.cmdSubir.Name = "cmdSubir"
        Me.cmdSubir.Size = New System.Drawing.Size(78, 60)
        Me.cmdSubir.TabIndex = 5
        Me.cmdSubir.Text = "Subir"
        Me.cmdSubir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSubir.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.Transparent
        Me.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.cmdCancelar.FlatAppearance.BorderSize = 0
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCancelar.Location = New System.Drawing.Point(196, 8)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 60)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.Color.Transparent
        Me.cmdAceptar.FlatAppearance.BorderSize = 0
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAceptar.Location = New System.Drawing.Point(35, 8)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 60)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.pnlDetalleComanda)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.pnlBtnsHorListadoComanda)
        Me.SplitContainer3.Size = New System.Drawing.Size(378, 307)
        Me.SplitContainer3.SplitterDistance = 222
        Me.SplitContainer3.TabIndex = 0
        '
        'pnlDetalleComanda
        '
        Me.pnlDetalleComanda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlDetalleComanda.Border = False
        Me.pnlDetalleComanda.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlDetalleComanda.Colors.Add(Me.ColorWithAlpha10)
        Me.pnlDetalleComanda.Colors.Add(Me.ColorWithAlpha11)
        Me.pnlDetalleComanda.ContentPadding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.pnlDetalleComanda.Controls.Add(Me.lvwComanda)
        Me.pnlDetalleComanda.CornerRadius = 30
        Me.pnlDetalleComanda.Corners = Azteca.Windows.Corner.None
        Me.pnlDetalleComanda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetalleComanda.Gradient = True
        Me.pnlDetalleComanda.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlDetalleComanda.GradientOffset = 1.0!
        Me.pnlDetalleComanda.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlDetalleComanda.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlDetalleComanda.Grayscale = False
        Me.pnlDetalleComanda.Image = Nothing
        Me.pnlDetalleComanda.ImageAlpha = 75
        Me.pnlDetalleComanda.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlDetalleComanda.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlDetalleComanda.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlDetalleComanda.Location = New System.Drawing.Point(0, 0)
        Me.pnlDetalleComanda.Name = "pnlDetalleComanda"
        Me.pnlDetalleComanda.Rounded = True
        Me.pnlDetalleComanda.Size = New System.Drawing.Size(378, 222)
        Me.pnlDetalleComanda.TabIndex = 5
        '
        'ColorWithAlpha10
        '
        Me.ColorWithAlpha10.Alpha = 255
        Me.ColorWithAlpha10.Color = System.Drawing.SystemColors.ButtonHighlight
        Me.ColorWithAlpha10.Parent = Me.pnlDetalleComanda
        '
        'pnlCategorias
        '
        Me.pnlCategorias.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlCategorias.Border = True
        Me.pnlCategorias.BorderColor = System.Drawing.Color.White
        Me.pnlCategorias.Colors.Add(Me.ColorWithAlpha10)
        Me.pnlCategorias.Colors.Add(Me.ColorWithAlpha11)
        Me.pnlCategorias.ContentPadding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.pnlCategorias.CornerRadius = 30
        Me.pnlCategorias.Corners = Azteca.Windows.Corner.None
        Me.pnlCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCategorias.Gradient = True
        Me.pnlCategorias.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlCategorias.GradientOffset = 1.0!
        Me.pnlCategorias.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlCategorias.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlCategorias.Grayscale = False
        Me.pnlCategorias.Image = Nothing
        Me.pnlCategorias.ImageAlpha = 75
        Me.pnlCategorias.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlCategorias.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlCategorias.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlCategorias.Location = New System.Drawing.Point(0, 0)
        Me.pnlCategorias.Name = "pnlCategorias"
        Me.pnlCategorias.Rounded = True
        Me.pnlCategorias.Size = New System.Drawing.Size(483, 78)
        Me.pnlCategorias.TabIndex = 4
        '
        'ColorWithAlpha11
        '
        Me.ColorWithAlpha11.Alpha = 255
        Me.ColorWithAlpha11.Color = System.Drawing.SystemColors.ButtonHighlight
        Me.ColorWithAlpha11.Parent = Me.pnlDetalleComanda
        '
        'lvwComanda
        '
        Me.lvwComanda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwComanda.BackColor = System.Drawing.Color.White
        Me.lvwComanda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvwComanda.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colArticulos, Me.colCantidad, Me.colPrecio, Me.colImporte})
        Me.lvwComanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwComanda.FullRowSelect = True
        Me.lvwComanda.GridLines = True
        Me.lvwComanda.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwComanda.HideSelection = False
        Me.lvwComanda.HoverSelection = True
        Me.lvwComanda.Location = New System.Drawing.Point(4, 1)
        Me.lvwComanda.Name = "lvwComanda"
        Me.lvwComanda.Scrollable = False
        Me.lvwComanda.ShowGroups = False
        Me.lvwComanda.Size = New System.Drawing.Size(371, 222)
        Me.lvwComanda.TabIndex = 26
        Me.lvwComanda.UseCompatibleStateImageBehavior = False
        Me.lvwComanda.View = System.Windows.Forms.View.Details
        '
        'colArticulos
        '
        Me.colArticulos.Text = "Articulo"
        Me.colArticulos.Width = 200
        '
        'colCantidad
        '
        Me.colCantidad.Text = "#"
        Me.colCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colCantidad.Width = 30
        '
        'colPrecio
        '
        Me.colPrecio.Text = "$"
        Me.colPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colPrecio.Width = 61
        '
        'colImporte
        '
        Me.colImporte.Text = "Importe"
        '
        'pnlBtnsHorListadoComanda
        '
        Me.pnlBtnsHorListadoComanda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlBtnsHorListadoComanda.Border = False
        Me.pnlBtnsHorListadoComanda.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlBtnsHorListadoComanda.Colors.Add(Me.ColorWithAlpha5)
        Me.pnlBtnsHorListadoComanda.Colors.Add(Me.ColorWithAlpha4)
        Me.pnlBtnsHorListadoComanda.ContentPadding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.pnlBtnsHorListadoComanda.Controls.Add(Me.cmdQuitar)
        Me.pnlBtnsHorListadoComanda.Controls.Add(Me.cmdBajar)
        Me.pnlBtnsHorListadoComanda.Controls.Add(Me.cmdDisminuir)
        Me.pnlBtnsHorListadoComanda.Controls.Add(Me.cmdNota)
        Me.pnlBtnsHorListadoComanda.Controls.Add(Me.cmdAumentar)
        Me.pnlBtnsHorListadoComanda.CornerRadius = 30
        Me.pnlBtnsHorListadoComanda.Corners = CType((Azteca.Windows.Corner.BottomLeft Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlBtnsHorListadoComanda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBtnsHorListadoComanda.Gradient = True
        Me.pnlBtnsHorListadoComanda.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlBtnsHorListadoComanda.GradientOffset = 1.0!
        Me.pnlBtnsHorListadoComanda.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlBtnsHorListadoComanda.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlBtnsHorListadoComanda.Grayscale = False
        Me.pnlBtnsHorListadoComanda.Image = Nothing
        Me.pnlBtnsHorListadoComanda.ImageAlpha = 75
        Me.pnlBtnsHorListadoComanda.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlBtnsHorListadoComanda.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlBtnsHorListadoComanda.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlBtnsHorListadoComanda.Location = New System.Drawing.Point(0, 0)
        Me.pnlBtnsHorListadoComanda.Name = "pnlBtnsHorListadoComanda"
        Me.pnlBtnsHorListadoComanda.Rounded = True
        Me.pnlBtnsHorListadoComanda.Size = New System.Drawing.Size(378, 81)
        Me.pnlBtnsHorListadoComanda.TabIndex = 12
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 255
        Me.ColorWithAlpha5.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha5.Parent = Me.pnlBtnsHorListadoComanda
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.Olive
        Me.ColorWithAlpha4.Parent = Me.pnlBtnsHorListadoComanda
        '
        'cmdQuitar
        '
        Me.cmdQuitar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdQuitar.BackColor = System.Drawing.Color.Transparent
        Me.cmdQuitar.FlatAppearance.BorderSize = 0
        Me.cmdQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuitar.Image = CType(resources.GetObject("cmdQuitar.Image"), System.Drawing.Image)
        Me.cmdQuitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdQuitar.Location = New System.Drawing.Point(15, 10)
        Me.cmdQuitar.Name = "cmdQuitar"
        Me.cmdQuitar.Size = New System.Drawing.Size(78, 60)
        Me.cmdQuitar.TabIndex = 4
        Me.cmdQuitar.Text = "Quitar"
        Me.cmdQuitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdQuitar.UseVisualStyleBackColor = False
        '
        'cmdBajar
        '
        Me.cmdBajar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdBajar.BackColor = System.Drawing.Color.Transparent
        Me.cmdBajar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdBajar.FlatAppearance.BorderSize = 0
        Me.cmdBajar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBajar.Image = CType(resources.GetObject("cmdBajar.Image"), System.Drawing.Image)
        Me.cmdBajar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdBajar.Location = New System.Drawing.Point(298, 7)
        Me.cmdBajar.Name = "cmdBajar"
        Me.cmdBajar.Size = New System.Drawing.Size(78, 60)
        Me.cmdBajar.TabIndex = 6
        Me.cmdBajar.Text = "Bajar"
        Me.cmdBajar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdBajar.UseVisualStyleBackColor = False
        '
        'cmdDisminuir
        '
        Me.cmdDisminuir.BackColor = System.Drawing.Color.Transparent
        Me.cmdDisminuir.FlatAppearance.BorderSize = 0
        Me.cmdDisminuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDisminuir.Image = CType(resources.GetObject("cmdDisminuir.Image"), System.Drawing.Image)
        Me.cmdDisminuir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDisminuir.Location = New System.Drawing.Point(234, 7)
        Me.cmdDisminuir.Name = "cmdDisminuir"
        Me.cmdDisminuir.Size = New System.Drawing.Size(78, 60)
        Me.cmdDisminuir.TabIndex = 8
        Me.cmdDisminuir.Text = "Disminuir"
        Me.cmdDisminuir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDisminuir.UseVisualStyleBackColor = False
        '
        'cmdNota
        '
        Me.cmdNota.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdNota.BackColor = System.Drawing.Color.Transparent
        Me.cmdNota.FlatAppearance.BorderSize = 0
        Me.cmdNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNota.Image = CType(resources.GetObject("cmdNota.Image"), System.Drawing.Image)
        Me.cmdNota.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdNota.Location = New System.Drawing.Point(85, 10)
        Me.cmdNota.Name = "cmdNota"
        Me.cmdNota.Size = New System.Drawing.Size(78, 60)
        Me.cmdNota.TabIndex = 9
        Me.cmdNota.Text = "Indicaciones"
        Me.cmdNota.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdNota.UseVisualStyleBackColor = False
        '
        'cmdAumentar
        '
        Me.cmdAumentar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdAumentar.BackColor = System.Drawing.Color.Transparent
        Me.cmdAumentar.FlatAppearance.BorderSize = 0
        Me.cmdAumentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAumentar.Image = CType(resources.GetObject("cmdAumentar.Image"), System.Drawing.Image)
        Me.cmdAumentar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAumentar.Location = New System.Drawing.Point(161, 8)
        Me.cmdAumentar.Name = "cmdAumentar"
        Me.cmdAumentar.Size = New System.Drawing.Size(78, 60)
        Me.cmdAumentar.TabIndex = 7
        Me.cmdAumentar.Text = "Aumentar"
        Me.cmdAumentar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAumentar.UseVisualStyleBackColor = False
        '
        'SplitSeleccionTituloCtrs
        '
        Me.SplitSeleccionTituloCtrs.BackColor = System.Drawing.Color.White
        Me.SplitSeleccionTituloCtrs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitSeleccionTituloCtrs.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitSeleccionTituloCtrs.Location = New System.Drawing.Point(0, 0)
        Me.SplitSeleccionTituloCtrs.Name = "SplitSeleccionTituloCtrs"
        Me.SplitSeleccionTituloCtrs.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitSeleccionTituloCtrs.Panel1
        '
        Me.SplitSeleccionTituloCtrs.Panel1.Controls.Add(Me.pnlTituloPlatillos)
        '
        'SplitSeleccionTituloCtrs.Panel2
        '
        Me.SplitSeleccionTituloCtrs.Panel2.Controls.Add(Me.SplitVerPlatillosCtroProdVsArticulos)
        Me.SplitSeleccionTituloCtrs.Size = New System.Drawing.Size(569, 450)
        Me.SplitSeleccionTituloCtrs.SplitterDistance = 57
        Me.SplitSeleccionTituloCtrs.TabIndex = 0
        '
        'pnlTituloPlatillos
        '
        Me.pnlTituloPlatillos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlTituloPlatillos.Border = False
        Me.pnlTituloPlatillos.BorderColor = System.Drawing.Color.White
        Me.pnlTituloPlatillos.Colors.Add(Me.pnlClrCmdaTit1)
        Me.pnlTituloPlatillos.Colors.Add(Me.pnlClrCmdaTit2)
        Me.pnlTituloPlatillos.ContentPadding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.pnlTituloPlatillos.Controls.Add(Me.lblPlatillos)
        Me.pnlTituloPlatillos.CornerRadius = 30
        Me.pnlTituloPlatillos.Corners = CType((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight), Azteca.Windows.Corner)
        Me.pnlTituloPlatillos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTituloPlatillos.Gradient = True
        Me.pnlTituloPlatillos.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlTituloPlatillos.GradientOffset = 1.0!
        Me.pnlTituloPlatillos.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlTituloPlatillos.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlTituloPlatillos.Grayscale = False
        Me.pnlTituloPlatillos.Image = Nothing
        Me.pnlTituloPlatillos.ImageAlpha = 75
        Me.pnlTituloPlatillos.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlTituloPlatillos.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlTituloPlatillos.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlTituloPlatillos.Location = New System.Drawing.Point(0, 0)
        Me.pnlTituloPlatillos.Name = "pnlTituloPlatillos"
        Me.pnlTituloPlatillos.Rounded = True
        Me.pnlTituloPlatillos.Size = New System.Drawing.Size(569, 57)
        Me.pnlTituloPlatillos.TabIndex = 5
        '
        'pnlClrCmdaTit1
        '
        Me.pnlClrCmdaTit1.Alpha = 255
        Me.pnlClrCmdaTit1.Color = System.Drawing.Color.Olive
        Me.pnlClrCmdaTit1.Parent = Me.pnlTituloPlatillos
        '
        'pnlClrCmdaTit2
        '
        Me.pnlClrCmdaTit2.Alpha = 255
        Me.pnlClrCmdaTit2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlClrCmdaTit2.Parent = Me.pnlTituloPlatillos
        '
        'lblPlatillos
        '
        Me.lblPlatillos.BackColor = System.Drawing.Color.Transparent
        Me.lblPlatillos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPlatillos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatillos.ForeColor = System.Drawing.Color.Olive
        Me.lblPlatillos.Location = New System.Drawing.Point(0, 0)
        Me.lblPlatillos.Name = "lblPlatillos"
        Me.lblPlatillos.Size = New System.Drawing.Size(569, 57)
        Me.lblPlatillos.TabIndex = 3
        Me.lblPlatillos.Text = "Selección de platillos"
        Me.lblPlatillos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitVerPlatillosCtroProdVsArticulos
        '
        Me.SplitVerPlatillosCtroProdVsArticulos.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SplitVerPlatillosCtroProdVsArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitVerPlatillosCtroProdVsArticulos.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitVerPlatillosCtroProdVsArticulos.Location = New System.Drawing.Point(0, 0)
        Me.SplitVerPlatillosCtroProdVsArticulos.Name = "SplitVerPlatillosCtroProdVsArticulos"
        '
        'SplitVerPlatillosCtroProdVsArticulos.Panel1
        '
        Me.SplitVerPlatillosCtroProdVsArticulos.Panel1.Controls.Add(Me.splitHorPlatillosEsquinaCtroProd)
        '
        'SplitVerPlatillosCtroProdVsArticulos.Panel2
        '
        Me.SplitVerPlatillosCtroProdVsArticulos.Panel2.Controls.Add(Me.splitHorPlatillosCategoriasArticulos)
        Me.SplitVerPlatillosCtroProdVsArticulos.Size = New System.Drawing.Size(569, 389)
        Me.SplitVerPlatillosCtroProdVsArticulos.SplitterDistance = 82
        Me.SplitVerPlatillosCtroProdVsArticulos.TabIndex = 0
        '
        'splitHorPlatillosEsquinaCtroProd
        '
        Me.splitHorPlatillosEsquinaCtroProd.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.splitHorPlatillosEsquinaCtroProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitHorPlatillosEsquinaCtroProd.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitHorPlatillosEsquinaCtroProd.Location = New System.Drawing.Point(0, 0)
        Me.splitHorPlatillosEsquinaCtroProd.Name = "splitHorPlatillosEsquinaCtroProd"
        Me.splitHorPlatillosEsquinaCtroProd.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitHorPlatillosEsquinaCtroProd.Panel1
        '
        Me.splitHorPlatillosEsquinaCtroProd.Panel1.Controls.Add(Me.pnlEsquina)
        '
        'splitHorPlatillosEsquinaCtroProd.Panel2
        '
        Me.splitHorPlatillosEsquinaCtroProd.Panel2.Controls.Add(Me.pnlCentrosProduccion)
        Me.splitHorPlatillosEsquinaCtroProd.Size = New System.Drawing.Size(82, 389)
        Me.splitHorPlatillosEsquinaCtroProd.SplitterDistance = 78
        Me.splitHorPlatillosEsquinaCtroProd.TabIndex = 0
        '
        'pnlEsquina
        '
        Me.pnlEsquina.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pnlEsquina.Border = False
        Me.pnlEsquina.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlEsquina.Colors.Add(Me.ColorWithAlpha6)
        Me.pnlEsquina.Colors.Add(Me.ColorWithAlpha7)
        Me.pnlEsquina.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlEsquina.Controls.Add(Me.lblCategorias)
        Me.pnlEsquina.Controls.Add(Me.lblCentrosProduccion)
        Me.pnlEsquina.CornerRadius = 30
        Me.pnlEsquina.Corners = Azteca.Windows.Corner.None
        Me.pnlEsquina.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEsquina.Gradient = True
        Me.pnlEsquina.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnlEsquina.GradientOffset = 1.0!
        Me.pnlEsquina.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlEsquina.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlEsquina.Grayscale = False
        Me.pnlEsquina.Image = Nothing
        Me.pnlEsquina.ImageAlpha = 75
        Me.pnlEsquina.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlEsquina.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlEsquina.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlEsquina.Location = New System.Drawing.Point(0, 0)
        Me.pnlEsquina.Name = "pnlEsquina"
        Me.pnlEsquina.Rounded = True
        Me.pnlEsquina.Size = New System.Drawing.Size(82, 78)
        Me.pnlEsquina.TabIndex = 3
        '
        'ColorWithAlpha6
        '
        Me.ColorWithAlpha6.Alpha = 255
        Me.ColorWithAlpha6.Color = System.Drawing.SystemColors.ButtonHighlight
        Me.ColorWithAlpha6.Parent = Me.pnlEsquina
        '
        'ColorWithAlpha7
        '
        Me.ColorWithAlpha7.Alpha = 255
        Me.ColorWithAlpha7.Color = System.Drawing.SystemColors.ButtonHighlight
        Me.ColorWithAlpha7.Parent = Me.pnlEsquina
        '
        'lblCategorias
        '
        Me.lblCategorias.BackColor = System.Drawing.Color.Transparent
        Me.lblCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategorias.ForeColor = System.Drawing.Color.Olive
        Me.lblCategorias.Location = New System.Drawing.Point(4, 4)
        Me.lblCategorias.Name = "lblCategorias"
        Me.lblCategorias.Size = New System.Drawing.Size(75, 17)
        Me.lblCategorias.TabIndex = 3
        Me.lblCategorias.Text = "Categorias"
        Me.lblCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCentrosProduccion
        '
        Me.lblCentrosProduccion.BackColor = System.Drawing.Color.Transparent
        Me.lblCentrosProduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentrosProduccion.ForeColor = System.Drawing.Color.Olive
        Me.lblCentrosProduccion.Location = New System.Drawing.Point(3, 43)
        Me.lblCentrosProduccion.Name = "lblCentrosProduccion"
        Me.lblCentrosProduccion.Size = New System.Drawing.Size(74, 28)
        Me.lblCentrosProduccion.TabIndex = 2
        Me.lblCentrosProduccion.Text = "Centros de Produccion"
        Me.lblCentrosProduccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlCentrosProduccion
        '
        Me.pnlCentrosProduccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlCentrosProduccion.Border = True
        Me.pnlCentrosProduccion.BorderColor = System.Drawing.Color.White
        Me.pnlCentrosProduccion.Colors.Add(Me.ColorWithAlpha8)
        Me.pnlCentrosProduccion.Colors.Add(Me.ColorWithAlpha9)
        Me.pnlCentrosProduccion.ContentPadding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.pnlCentrosProduccion.Controls.Add(Me.pnlEspiral)
        Me.pnlCentrosProduccion.CornerRadius = 30
        Me.pnlCentrosProduccion.Corners = Azteca.Windows.Corner.BottomLeft
        Me.pnlCentrosProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCentrosProduccion.Gradient = True
        Me.pnlCentrosProduccion.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnlCentrosProduccion.GradientOffset = 1.0!
        Me.pnlCentrosProduccion.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlCentrosProduccion.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlCentrosProduccion.Grayscale = False
        Me.pnlCentrosProduccion.Image = Nothing
        Me.pnlCentrosProduccion.ImageAlpha = 75
        Me.pnlCentrosProduccion.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlCentrosProduccion.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlCentrosProduccion.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlCentrosProduccion.Location = New System.Drawing.Point(0, 0)
        Me.pnlCentrosProduccion.Name = "pnlCentrosProduccion"
        Me.pnlCentrosProduccion.Rounded = True
        Me.pnlCentrosProduccion.Size = New System.Drawing.Size(82, 307)
        Me.pnlCentrosProduccion.TabIndex = 3
        '
        'ColorWithAlpha8
        '
        Me.ColorWithAlpha8.Alpha = 255
        Me.ColorWithAlpha8.Color = System.Drawing.SystemColors.ButtonHighlight
        Me.ColorWithAlpha8.Parent = Me.pnlCentrosProduccion
        '
        'ColorWithAlpha9
        '
        Me.ColorWithAlpha9.Alpha = 255
        Me.ColorWithAlpha9.Color = System.Drawing.SystemColors.ButtonHighlight
        Me.ColorWithAlpha9.Parent = Me.pnlCentrosProduccion
        '
        'pnlEspiral
        '
        Me.pnlEspiral.BackgroundImage = CType(resources.GetObject("pnlEspiral.BackgroundImage"), System.Drawing.Image)
        Me.pnlEspiral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEspiral.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlEspiral.GradientColorA = System.Drawing.SystemColors.ControlLight
        Me.pnlEspiral.GradientColorB = System.Drawing.SystemColors.ControlDark
        Me.pnlEspiral.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnlEspiral.Location = New System.Drawing.Point(0, 0)
        Me.pnlEspiral.Name = "pnlEspiral"
        Me.pnlEspiral.Size = New System.Drawing.Size(46, 307)
        Me.pnlEspiral.TabIndex = 29
        Me.pnlEspiral.UseGradient = False
        Me.pnlEspiral.Visible = False
        '
        'splitHorPlatillosCategoriasArticulos
        '
        Me.splitHorPlatillosCategoriasArticulos.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.splitHorPlatillosCategoriasArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitHorPlatillosCategoriasArticulos.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitHorPlatillosCategoriasArticulos.Location = New System.Drawing.Point(0, 0)
        Me.splitHorPlatillosCategoriasArticulos.Name = "splitHorPlatillosCategoriasArticulos"
        Me.splitHorPlatillosCategoriasArticulos.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitHorPlatillosCategoriasArticulos.Panel1
        '
        Me.splitHorPlatillosCategoriasArticulos.Panel1.Controls.Add(Me.pnlCategorias)
        '
        'splitHorPlatillosCategoriasArticulos.Panel2
        '
        Me.splitHorPlatillosCategoriasArticulos.Panel2.Controls.Add(Me.pnlArticulos)
        Me.splitHorPlatillosCategoriasArticulos.Size = New System.Drawing.Size(483, 389)
        Me.splitHorPlatillosCategoriasArticulos.SplitterDistance = 78
        Me.splitHorPlatillosCategoriasArticulos.TabIndex = 0
        '
        'pnlArticulos
        '
        Me.pnlArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlArticulos.Border = True
        Me.pnlArticulos.BorderColor = System.Drawing.Color.DimGray
        Me.pnlArticulos.Colors.Add(Me.ColorWithAlpha12)
        Me.pnlArticulos.Colors.Add(Me.ColorWithAlpha13)
        Me.pnlArticulos.ContentPadding = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.pnlArticulos.CornerRadius = 30
        Me.pnlArticulos.Corners = Azteca.Windows.Corner.BottomRight
        Me.pnlArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlArticulos.Gradient = True
        Me.pnlArticulos.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlArticulos.GradientOffset = 1.0!
        Me.pnlArticulos.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlArticulos.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlArticulos.Grayscale = False
        Me.pnlArticulos.Image = Nothing
        Me.pnlArticulos.ImageAlpha = 75
        Me.pnlArticulos.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlArticulos.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlArticulos.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlArticulos.Location = New System.Drawing.Point(0, 0)
        Me.pnlArticulos.Name = "pnlArticulos"
        Me.pnlArticulos.Rounded = True
        Me.pnlArticulos.Size = New System.Drawing.Size(483, 307)
        Me.pnlArticulos.TabIndex = 1
        '
        'ColorWithAlpha12
        '
        Me.ColorWithAlpha12.Alpha = 255
        Me.ColorWithAlpha12.Color = System.Drawing.SystemColors.ButtonHighlight
        Me.ColorWithAlpha12.Parent = Me.pnlArticulos
        '
        'ColorWithAlpha13
        '
        Me.ColorWithAlpha13.Alpha = 255
        Me.ColorWithAlpha13.Color = System.Drawing.SystemColors.ButtonHighlight
        Me.ColorWithAlpha13.Parent = Me.pnlArticulos
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.SystemColors.Control
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'CiStatusBar1
        '
        Me.CiStatusBar1.Location = New System.Drawing.Point(0, 570)
        Me.CiStatusBar1.Name = "CiStatusBar1"
        Me.CiStatusBar1.Size = New System.Drawing.Size(957, 22)
        Me.CiStatusBar1.TabIndex = 2
        Me.CiStatusBar1.Text = "CiStatusBar1"
        '
        'ColorWithAlpha18
        '
        Me.ColorWithAlpha18.Alpha = 255
        Me.ColorWithAlpha18.Color = System.Drawing.SystemColors.ButtonFace
        Me.ColorWithAlpha18.Parent = Nothing
        '
        'ColorWithAlpha19
        '
        Me.ColorWithAlpha19.Alpha = 255
        Me.ColorWithAlpha19.Color = System.Drawing.SystemColors.ButtonFace
        Me.ColorWithAlpha19.Parent = Nothing
        '
        'ComandaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(957, 592)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.CiStatusBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "ComandaForm"
        Me.Text = "Comanda ..."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTituloComanda.ResumeLayout(False)
        Me.pnlTitulo.ResumeLayout(False)
        Me.SplitHorImagenTitulos.Panel1.ResumeLayout(False)
        Me.SplitHorImagenTitulos.Panel2.ResumeLayout(False)
        CType(Me.SplitHorImagenTitulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitHorImagenTitulos.ResumeLayout(False)
        Me.splitVerImagen.Panel1.ResumeLayout(False)
        Me.splitVerImagen.Panel2.ResumeLayout(False)
        CType(Me.splitVerImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitVerImagen.ResumeLayout(False)
        Me.pnlLogp.ResumeLayout(False)
        Me.pnlLogp.PerformLayout()
        Me.pnlPicture.ResumeLayout(False)
        CType(Me.CiPicture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAzteca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitVerComandaSeleccion.Panel1.ResumeLayout(False)
        Me.splitVerComandaSeleccion.Panel2.ResumeLayout(False)
        CType(Me.splitVerComandaSeleccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitVerComandaSeleccion.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.pnlTitulos.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.pnlDetalleComanda.ResumeLayout(False)
        Me.pnlBtnsHorListadoComanda.ResumeLayout(False)
        Me.SplitSeleccionTituloCtrs.Panel1.ResumeLayout(False)
        Me.SplitSeleccionTituloCtrs.Panel2.ResumeLayout(False)
        CType(Me.SplitSeleccionTituloCtrs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitSeleccionTituloCtrs.ResumeLayout(False)
        Me.pnlTituloPlatillos.ResumeLayout(False)
        Me.SplitVerPlatillosCtroProdVsArticulos.Panel1.ResumeLayout(False)
        Me.SplitVerPlatillosCtroProdVsArticulos.Panel2.ResumeLayout(False)
        CType(Me.SplitVerPlatillosCtroProdVsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitVerPlatillosCtroProdVsArticulos.ResumeLayout(False)
        Me.splitHorPlatillosEsquinaCtroProd.Panel1.ResumeLayout(False)
        Me.splitHorPlatillosEsquinaCtroProd.Panel2.ResumeLayout(False)
        CType(Me.splitHorPlatillosEsquinaCtroProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitHorPlatillosEsquinaCtroProd.ResumeLayout(False)
        Me.pnlEsquina.ResumeLayout(False)
        Me.pnlCentrosProduccion.ResumeLayout(False)
        Me.splitHorPlatillosCategoriasArticulos.Panel1.ResumeLayout(False)
        Me.splitHorPlatillosCategoriasArticulos.Panel2.ResumeLayout(False)
        CType(Me.splitHorPlatillosCategoriasArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitHorPlatillosCategoriasArticulos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTitulo As Azteca.Windows.Controls.CIPanel
    Friend WithEvents CiStatusBar1 As Azteca.Windows.Controls.CIStatusBar
    Friend WithEvents pnlClrCmdaTit1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents pnlClrCmdaTit2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha3 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha5 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha6 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha7 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha8 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha9 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha10 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha11 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha12 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha13 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents SplitHorImagenTitulos As System.Windows.Forms.SplitContainer
    Friend WithEvents splitVerComandaSeleccion As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitSeleccionTituloCtrs As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlTituloPlatillos As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents lblPlatillos As Azteca.Windows.Controls.CILabel
    Friend WithEvents SplitVerPlatillosCtroProdVsArticulos As System.Windows.Forms.SplitContainer
    Friend WithEvents splitHorPlatillosEsquinaCtroProd As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlEsquina As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents lblCategorias As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCentrosProduccion As Azteca.Windows.Controls.CILabel
    Friend WithEvents pnlCentrosProduccion As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents splitHorPlatillosCategoriasArticulos As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlCategorias As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents pnlArticulos As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents lvwComanda As Azteca.Windows.Controls.CIListView
    Friend WithEvents colArticulos As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPrecio As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlTituloComanda As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents lblComanda As Azteca.Windows.Controls.CILabel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlTitulos As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents cmdNotas As Azteca.Windows.Controls.CIButton
    Friend WithEvents cmdSubir As Azteca.Windows.Controls.CIButton
    Friend WithEvents cmdCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents cmdAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlDetalleComanda As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents pnlBtnsHorListadoComanda As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents cmdQuitar As Azteca.Windows.Controls.CIButton
    Friend WithEvents cmdBajar As Azteca.Windows.Controls.CIButton
    Friend WithEvents cmdDisminuir As Azteca.Windows.Controls.CIButton
    Friend WithEvents cmdNota As Azteca.Windows.Controls.CIButton
    Friend WithEvents cmdAumentar As Azteca.Windows.Controls.CIButton
    Friend WithEvents ColorWithAlpha14 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha15 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha16 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha17 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha18 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha19 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents splitVerImagen As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlLogp As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents pnlPicture As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents picAzteca As Azteca.Windows.Controls.CIPicture
    Friend WithEvents colImporte As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTotCantidadTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotTotalTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotCantidad As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotTotal As Azteca.Windows.Controls.CILabel
    Friend WithEvents pnlEspiral As Azteca.Windows.Controls.CIPanel
    Friend WithEvents CiPicture1 As Azteca.Windows.Controls.CIPicture
End Class
