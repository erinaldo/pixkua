<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoDomicilioForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DesignerRectTracker1 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidoDomicilioForm))
        Dim CBlendItems1 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker2 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim DesignerRectTracker3 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems2 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker4 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim DesignerRectTracker5 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems3 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker6 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Me.grdPedido = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha3 = New Azteca.Windows.ColorWithAlpha()
        Me.pnlLogp = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha6 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha7 = New Azteca.Windows.ColorWithAlpha()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.btnComanda = New Azteca.Windows.Controls.ButtonPlus()
        Me.lblTotCantidadTXT = New Azteca.Windows.Controls.CILabel()
        Me.lblTotTotalTXT = New Azteca.Windows.Controls.CILabel()
        Me.lvwComanda = New Azteca.Windows.Controls.CIListView()
        Me.colArticulos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrecio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colImporte = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTotCantidad = New Azteca.Windows.Controls.CILabel()
        Me.lblTotTotal = New Azteca.Windows.Controls.CILabel()
        Me.ColorWithAlpha4 = New Azteca.Windows.ColorWithAlpha()
        Me.pnlCliente = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.pnlDatosClientes = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.grdContactos = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.tlbContactos = New Azteca.Windows.Controls.CIToolBar()
        Me.btnNuevoContacto = New System.Windows.Forms.ToolStripButton()
        Me.ColorWithAlpha5 = New Azteca.Windows.ColorWithAlpha()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.lblClienteTitulo = New Azteca.Windows.Controls.CILabel()
        Me.lblCPtxt = New Azteca.Windows.Controls.CILabel()
        Me.lblColoniaTXT = New Azteca.Windows.Controls.CILabel()
        Me.lblCruzaConTXT = New Azteca.Windows.Controls.CILabel()
        Me.lblInteriorTXT = New Azteca.Windows.Controls.CILabel()
        Me.lblNumeroTXT = New Azteca.Windows.Controls.CILabel()
        Me.lblAtenionA = New Azteca.Windows.Controls.CILabel()
        Me.lblCalleTXT = New Azteca.Windows.Controls.CILabel()
        Me.lblCP = New Azteca.Windows.Controls.CILabel()
        Me.lblColonia = New Azteca.Windows.Controls.CILabel()
        Me.lblInterior = New Azteca.Windows.Controls.CILabel()
        Me.lblCliente = New Azteca.Windows.Controls.CILabel()
        Me.lblCruceCon = New Azteca.Windows.Controls.CILabel()
        Me.lblNumero = New Azteca.Windows.Controls.CILabel()
        Me.lblCalle = New Azteca.Windows.Controls.CILabel()
        Me.txtObservaciones = New Azteca.Windows.Controls.CITextBox()
        Me.lblObservaciones = New Azteca.Windows.Controls.CILabel()
        Me.pnlMesasTitulo = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.lblTitulo = New Azteca.Windows.Controls.CILabel()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCorreo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlMenuBotones = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.btnGuardar = New Azteca.Windows.Controls.ButtonPlus()
        Me.picAzteca = New Azteca.Windows.Controls.CIPicture()
        Me.btnRegresar = New Azteca.Windows.Controls.ButtonPlus()
        Me.bsContactos = New System.Windows.Forms.BindingSource(Me.components)
        Me.selCliente = New Azteca.Windows.Ventas.ClienteSelector()
        Me.grdPedido.SuspendLayout()
        Me.pnlLogp.SuspendLayout()
        Me.pnlCliente.SuspendLayout()
        Me.pnlDatosClientes.SuspendLayout()
        CType(Me.grdContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlbContactos.SuspendLayout()
        Me.pnlMesasTitulo.SuspendLayout()
        Me.pnlMenuBotones.SuspendLayout()
        CType(Me.picAzteca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdPedido
        '
        Me.grdPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdPedido.Border = True
        Me.grdPedido.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.grdPedido.Colors.Add(Me.ColorWithAlpha3)
        Me.grdPedido.Colors.Add(Me.ColorWithAlpha4)
        Me.grdPedido.Colors.Add(Me.ColorWithAlpha5)
        Me.grdPedido.ContentPadding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.grdPedido.Controls.Add(Me.txtObservaciones)
        Me.grdPedido.Controls.Add(Me.lblObservaciones)
        Me.grdPedido.Controls.Add(Me.pnlLogp)
        Me.grdPedido.Controls.Add(Me.pnlCliente)
        Me.grdPedido.CornerRadius = 20
        Me.grdPedido.Corners = CType((Azteca.Windows.Corner.BottomLeft Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.grdPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPedido.Gradient = True
        Me.grdPedido.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grdPedido.GradientOffset = 1.0!
        Me.grdPedido.GradientSize = New System.Drawing.Size(0, 0)
        Me.grdPedido.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.grdPedido.Grayscale = False
        Me.grdPedido.Image = Nothing
        Me.grdPedido.ImageAlpha = 75
        Me.grdPedido.ImagePadding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.grdPedido.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.grdPedido.ImageSize = New System.Drawing.Size(48, 48)
        Me.grdPedido.Location = New System.Drawing.Point(0, 153)
        Me.grdPedido.Name = "grdPedido"
        Me.grdPedido.Rounded = True
        Me.grdPedido.Size = New System.Drawing.Size(1054, 442)
        Me.grdPedido.TabIndex = 39
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.White
        Me.ColorWithAlpha3.Parent = Me.grdPedido
        '
        'pnlLogp
        '
        Me.pnlLogp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.pnlLogp.BackColor = System.Drawing.Color.Transparent
        Me.pnlLogp.Border = True
        Me.pnlLogp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlLogp.Colors.Add(Me.ColorWithAlpha3)
        Me.pnlLogp.Colors.Add(Me.ColorWithAlpha6)
        Me.pnlLogp.Colors.Add(Me.ColorWithAlpha7)
        Me.pnlLogp.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlLogp.Controls.Add(Me.CiLabel1)
        Me.pnlLogp.Controls.Add(Me.btnComanda)
        Me.pnlLogp.Controls.Add(Me.lblTotCantidadTXT)
        Me.pnlLogp.Controls.Add(Me.lblTotTotalTXT)
        Me.pnlLogp.Controls.Add(Me.lvwComanda)
        Me.pnlLogp.Controls.Add(Me.lblTotCantidad)
        Me.pnlLogp.Controls.Add(Me.lblTotTotal)
        Me.pnlLogp.CornerRadius = 20
        Me.pnlLogp.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
                    Or Azteca.Windows.Corner.BottomLeft) _
                    Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
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
        Me.pnlLogp.Location = New System.Drawing.Point(559, 11)
        Me.pnlLogp.Name = "pnlLogp"
        Me.pnlLogp.Rounded = True
        Me.pnlLogp.Size = New System.Drawing.Size(457, 381)
        Me.pnlLogp.TabIndex = 29
        '
        'ColorWithAlpha6
        '
        Me.ColorWithAlpha6.Alpha = 255
        Me.ColorWithAlpha6.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha6.Parent = Me.pnlLogp
        '
        'ColorWithAlpha7
        '
        Me.ColorWithAlpha7.Alpha = 255
        Me.ColorWithAlpha7.Color = System.Drawing.Color.White
        Me.ColorWithAlpha7.Parent = Me.pnlLogp
        '
        'CiLabel1
        '
        Me.CiLabel1.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CiLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CiLabel1.Location = New System.Drawing.Point(0, 0)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(457, 25)
        Me.CiLabel1.TabIndex = 40
        Me.CiLabel1.Text = "Datos del Pedido"
        Me.CiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnComanda
        '
        Me.btnComanda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnComanda.AutoLock = False
        Me.btnComanda.BackColor = System.Drawing.Color.Transparent
        Me.btnComanda.BorderColor = System.Drawing.Color.Silver
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnComanda.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.RoyalBlue, System.Drawing.Color.Navy}
        CBlendItems1.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.btnComanda.ColorFillBlend = CBlendItems1
        Me.btnComanda.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnComanda.Corners.All = CType(6, Short)
        Me.btnComanda.Corners.LowerLeft = CType(6, Short)
        Me.btnComanda.Corners.LowerRight = CType(6, Short)
        Me.btnComanda.Corners.UpperLeft = CType(6, Short)
        Me.btnComanda.Corners.UpperRight = CType(6, Short)
        Me.btnComanda.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.Solid
        Me.btnComanda.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnComanda.FocalPoints.CenterPtX = 0.5!
        Me.btnComanda.FocalPoints.CenterPtY = 0.5!
        Me.btnComanda.FocalPoints.FocusPtX = 0.0!
        Me.btnComanda.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnComanda.FocusPtTracker = DesignerRectTracker2
        Me.btnComanda.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnComanda.ForeColor = System.Drawing.Color.Gray
        Me.btnComanda.Image = CType(resources.GetObject("btnComanda.Image"), System.Drawing.Image)
        Me.btnComanda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnComanda.ImageIndex = 0
        Me.btnComanda.ImageSize = New System.Drawing.Size(48, 48)
        Me.btnComanda.Location = New System.Drawing.Point(332, 49)
        Me.btnComanda.Name = "btnComanda"
        Me.btnComanda.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.btnComanda.SideImage = Nothing
        Me.btnComanda.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnComanda.SideImageSize = New System.Drawing.Size(48, 48)
        Me.btnComanda.Size = New System.Drawing.Size(90, 72)
        Me.btnComanda.TabIndex = 39
        Me.btnComanda.Text = "Comanda"
        Me.btnComanda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnComanda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnComanda.TextMargin = New System.Windows.Forms.Padding(2)
        Me.btnComanda.TextShadowShow = False
        Me.btnComanda.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnComanda.UseMnemonic = True
        '
        'lblTotCantidadTXT
        '
        Me.lblTotCantidadTXT.BackColor = System.Drawing.Color.Transparent
        Me.lblTotCantidadTXT.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotCantidadTXT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotCantidadTXT.Location = New System.Drawing.Point(162, 51)
        Me.lblTotCantidadTXT.Name = "lblTotCantidadTXT"
        Me.lblTotCantidadTXT.Size = New System.Drawing.Size(122, 26)
        Me.lblTotCantidadTXT.TabIndex = 37
        Me.lblTotCantidadTXT.Text = "0.00"
        Me.lblTotCantidadTXT.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblTotTotalTXT
        '
        Me.lblTotTotalTXT.BackColor = System.Drawing.Color.Transparent
        Me.lblTotTotalTXT.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotTotalTXT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotTotalTXT.Location = New System.Drawing.Point(162, 85)
        Me.lblTotTotalTXT.Name = "lblTotTotalTXT"
        Me.lblTotTotalTXT.Size = New System.Drawing.Size(122, 26)
        Me.lblTotTotalTXT.TabIndex = 36
        Me.lblTotTotalTXT.Text = "0.00"
        Me.lblTotTotalTXT.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lvwComanda
        '
        Me.lvwComanda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lvwComanda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lvwComanda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvwComanda.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colArticulos, Me.colCantidad, Me.colPrecio, Me.colImporte})
        Me.lvwComanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwComanda.FullRowSelect = True
        Me.lvwComanda.GridLines = True
        Me.lvwComanda.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwComanda.HideSelection = False
        Me.lvwComanda.HoverSelection = True
        Me.lvwComanda.Location = New System.Drawing.Point(37, 154)
        Me.lvwComanda.Name = "lvwComanda"
        Me.lvwComanda.Scrollable = False
        Me.lvwComanda.ShowGroups = False
        Me.lvwComanda.Size = New System.Drawing.Size(385, 200)
        Me.lvwComanda.TabIndex = 27
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
        'lblTotCantidad
        '
        Me.lblTotCantidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotCantidad.AutoSize = True
        Me.lblTotCantidad.BackColor = System.Drawing.Color.Transparent
        Me.lblTotCantidad.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotCantidad.ForeColor = System.Drawing.Color.Black
        Me.lblTotCantidad.Location = New System.Drawing.Point(33, 49)
        Me.lblTotCantidad.Name = "lblTotCantidad"
        Me.lblTotCantidad.Size = New System.Drawing.Size(79, 24)
        Me.lblTotCantidad.TabIndex = 35
        Me.lblTotCantidad.Text = "Cantidad"
        Me.lblTotCantidad.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblTotTotal
        '
        Me.lblTotTotal.AutoSize = True
        Me.lblTotTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotTotal.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotTotal.Location = New System.Drawing.Point(33, 86)
        Me.lblTotTotal.Name = "lblTotTotal"
        Me.lblTotTotal.Size = New System.Drawing.Size(48, 24)
        Me.lblTotTotal.TabIndex = 34
        Me.lblTotTotal.Text = "Total"
        Me.lblTotTotal.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha4.Parent = Me.grdPedido
        '
        'pnlCliente
        '
        Me.pnlCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.pnlCliente.BackColor = System.Drawing.Color.Transparent
        Me.pnlCliente.Border = True
        Me.pnlCliente.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlCliente.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlCliente.Colors.Add(Me.ColorWithAlpha4)
        Me.pnlCliente.Colors.Add(Me.ColorWithAlpha5)
        Me.pnlCliente.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlCliente.Controls.Add(Me.CiLabel2)
        Me.pnlCliente.Controls.Add(Me.lblClienteTitulo)
        Me.pnlCliente.Controls.Add(Me.lblCPtxt)
        Me.pnlCliente.Controls.Add(Me.lblColoniaTXT)
        Me.pnlCliente.Controls.Add(Me.lblCruzaConTXT)
        Me.pnlCliente.Controls.Add(Me.lblInteriorTXT)
        Me.pnlCliente.Controls.Add(Me.lblNumeroTXT)
        Me.pnlCliente.Controls.Add(Me.pnlDatosClientes)
        Me.pnlCliente.Controls.Add(Me.lblAtenionA)
        Me.pnlCliente.Controls.Add(Me.lblCalleTXT)
        Me.pnlCliente.Controls.Add(Me.lblCP)
        Me.pnlCliente.Controls.Add(Me.lblColonia)
        Me.pnlCliente.Controls.Add(Me.lblInterior)
        Me.pnlCliente.Controls.Add(Me.lblCliente)
        Me.pnlCliente.Controls.Add(Me.lblCruceCon)
        Me.pnlCliente.Controls.Add(Me.selCliente)
        Me.pnlCliente.Controls.Add(Me.lblNumero)
        Me.pnlCliente.Controls.Add(Me.lblCalle)
        Me.pnlCliente.CornerRadius = 20
        Me.pnlCliente.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
                    Or Azteca.Windows.Corner.BottomLeft) _
                    Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlCliente.Gradient = True
        Me.pnlCliente.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlCliente.GradientOffset = 1.0!
        Me.pnlCliente.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlCliente.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlCliente.Grayscale = False
        Me.pnlCliente.Image = Nothing
        Me.pnlCliente.ImageAlpha = 75
        Me.pnlCliente.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlCliente.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlCliente.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlCliente.Location = New System.Drawing.Point(26, 11)
        Me.pnlCliente.Name = "pnlCliente"
        Me.pnlCliente.Rounded = True
        Me.pnlCliente.Size = New System.Drawing.Size(527, 381)
        Me.pnlCliente.TabIndex = 5
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.White
        Me.ColorWithAlpha1.Parent = Me.pnlMesasTitulo
        '
        'pnlDatosClientes
        '
        Me.pnlDatosClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.pnlDatosClientes.BackColor = System.Drawing.Color.Transparent
        Me.pnlDatosClientes.Border = True
        Me.pnlDatosClientes.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlDatosClientes.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlDatosClientes.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlDatosClientes.Controls.Add(Me.grdContactos)
        Me.pnlDatosClientes.Controls.Add(Me.tlbContactos)
        Me.pnlDatosClientes.CornerRadius = 20
        Me.pnlDatosClientes.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
                    Or Azteca.Windows.Corner.BottomLeft) _
                    Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlDatosClientes.Gradient = False
        Me.pnlDatosClientes.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlDatosClientes.GradientOffset = 1.0!
        Me.pnlDatosClientes.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlDatosClientes.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlDatosClientes.Grayscale = False
        Me.pnlDatosClientes.Image = Nothing
        Me.pnlDatosClientes.ImageAlpha = 75
        Me.pnlDatosClientes.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlDatosClientes.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlDatosClientes.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlDatosClientes.Location = New System.Drawing.Point(15, 157)
        Me.pnlDatosClientes.Name = "pnlDatosClientes"
        Me.pnlDatosClientes.Rounded = True
        Me.pnlDatosClientes.Size = New System.Drawing.Size(489, 197)
        Me.pnlDatosClientes.TabIndex = 2
        '
        'grdContactos
        '
        Me.grdContactos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdContactos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdContactos.IDCatalogField = "IdPersona"
        Me.grdContactos.Images.Add(CType(resources.GetObject("grdContactos.Images"), System.Drawing.Image))
        Me.grdContactos.Location = New System.Drawing.Point(0, 39)
        Me.grdContactos.Name = "grdContactos"
        Me.grdContactos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdContactos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdContactos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdContactos.PrintInfo.PageSettings = CType(resources.GetObject("grdContactos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdContactos.Size = New System.Drawing.Size(489, 158)
        Me.grdContactos.TabIndex = 2
        Me.grdContactos.PropBag = resources.GetString("grdContactos.PropBag")
        '
        'tlbContactos
        '
        Me.tlbContactos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tlbContactos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoContacto})
        Me.tlbContactos.Location = New System.Drawing.Point(0, 0)
        Me.tlbContactos.Name = "tlbContactos"
        Me.tlbContactos.Size = New System.Drawing.Size(489, 39)
        Me.tlbContactos.TabIndex = 3
        Me.tlbContactos.Text = "tlbContactos"
        '
        'btnNuevoContacto
        '
        Me.btnNuevoContacto.Enabled = False
        Me.btnNuevoContacto.Image = CType(resources.GetObject("btnNuevoContacto.Image"), System.Drawing.Image)
        Me.btnNuevoContacto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevoContacto.Name = "btnNuevoContacto"
        Me.btnNuevoContacto.Size = New System.Drawing.Size(130, 36)
        Me.btnNuevoContacto.Text = "Nuevo Contacto"
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 255
        Me.ColorWithAlpha5.Color = System.Drawing.Color.White
        Me.ColorWithAlpha5.Parent = Me.grdPedido
        '
        'CiLabel2
        '
        Me.CiLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(234, 184)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(58, 13)
        Me.CiLabel2.TabIndex = 18
        Me.CiLabel2.Text = "Atencion a"
        '
        'lblClienteTitulo
        '
        Me.lblClienteTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblClienteTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblClienteTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblClienteTitulo.Name = "lblClienteTitulo"
        Me.lblClienteTitulo.Size = New System.Drawing.Size(527, 25)
        Me.lblClienteTitulo.TabIndex = 17
        Me.lblClienteTitulo.Text = "Datos del cliente"
        Me.lblClienteTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCPtxt
        '
        Me.lblCPtxt.AutoSize = True
        Me.lblCPtxt.ForeColor = System.Drawing.Color.Blue
        Me.lblCPtxt.Location = New System.Drawing.Point(343, 116)
        Me.lblCPtxt.Name = "lblCPtxt"
        Me.lblCPtxt.Size = New System.Drawing.Size(30, 13)
        Me.lblCPtxt.TabIndex = 16
        Me.lblCPtxt.Text = "Calle"
        '
        'lblColoniaTXT
        '
        Me.lblColoniaTXT.AutoSize = True
        Me.lblColoniaTXT.ForeColor = System.Drawing.Color.Blue
        Me.lblColoniaTXT.Location = New System.Drawing.Point(82, 116)
        Me.lblColoniaTXT.Name = "lblColoniaTXT"
        Me.lblColoniaTXT.Size = New System.Drawing.Size(30, 13)
        Me.lblColoniaTXT.TabIndex = 15
        Me.lblColoniaTXT.Text = "Calle"
        '
        'lblCruzaConTXT
        '
        Me.lblCruzaConTXT.AutoSize = True
        Me.lblCruzaConTXT.ForeColor = System.Drawing.Color.Blue
        Me.lblCruzaConTXT.Location = New System.Drawing.Point(82, 92)
        Me.lblCruzaConTXT.Name = "lblCruzaConTXT"
        Me.lblCruzaConTXT.Size = New System.Drawing.Size(30, 13)
        Me.lblCruzaConTXT.TabIndex = 14
        Me.lblCruzaConTXT.Text = "Calle"
        '
        'lblInteriorTXT
        '
        Me.lblInteriorTXT.AutoSize = True
        Me.lblInteriorTXT.ForeColor = System.Drawing.Color.Blue
        Me.lblInteriorTXT.Location = New System.Drawing.Point(461, 67)
        Me.lblInteriorTXT.Name = "lblInteriorTXT"
        Me.lblInteriorTXT.Size = New System.Drawing.Size(30, 13)
        Me.lblInteriorTXT.TabIndex = 13
        Me.lblInteriorTXT.Text = "Calle"
        '
        'lblNumeroTXT
        '
        Me.lblNumeroTXT.AutoSize = True
        Me.lblNumeroTXT.ForeColor = System.Drawing.Color.Blue
        Me.lblNumeroTXT.Location = New System.Drawing.Point(343, 67)
        Me.lblNumeroTXT.Name = "lblNumeroTXT"
        Me.lblNumeroTXT.Size = New System.Drawing.Size(30, 13)
        Me.lblNumeroTXT.TabIndex = 12
        Me.lblNumeroTXT.Text = "Calle"
        '
        'lblAtenionA
        '
        Me.lblAtenionA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtenionA.AutoSize = True
        Me.lblAtenionA.Location = New System.Drawing.Point(12, 139)
        Me.lblAtenionA.Name = "lblAtenionA"
        Me.lblAtenionA.Size = New System.Drawing.Size(58, 13)
        Me.lblAtenionA.TabIndex = 3
        Me.lblAtenionA.Text = "Atencion a"
        '
        'lblCalleTXT
        '
        Me.lblCalleTXT.AutoSize = True
        Me.lblCalleTXT.ForeColor = System.Drawing.Color.Blue
        Me.lblCalleTXT.Location = New System.Drawing.Point(82, 67)
        Me.lblCalleTXT.Name = "lblCalleTXT"
        Me.lblCalleTXT.Size = New System.Drawing.Size(30, 13)
        Me.lblCalleTXT.TabIndex = 11
        Me.lblCalleTXT.Text = "Calle"
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Location = New System.Drawing.Point(310, 116)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(27, 13)
        Me.lblCP.TabIndex = 10
        Me.lblCP.Text = "C.P."
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Location = New System.Drawing.Point(31, 116)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(42, 13)
        Me.lblColonia.TabIndex = 9
        Me.lblColonia.Text = "Colonia"
        '
        'lblInterior
        '
        Me.lblInterior.AutoSize = True
        Me.lblInterior.Location = New System.Drawing.Point(416, 67)
        Me.lblInterior.Name = "lblInterior"
        Me.lblInterior.Size = New System.Drawing.Size(39, 13)
        Me.lblInterior.TabIndex = 8
        Me.lblInterior.Text = "Interior"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCliente.Location = New System.Drawing.Point(33, 38)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente"
        '
        'lblCruceCon
        '
        Me.lblCruceCon.AutoSize = True
        Me.lblCruceCon.Location = New System.Drawing.Point(16, 92)
        Me.lblCruceCon.Name = "lblCruceCon"
        Me.lblCruceCon.Size = New System.Drawing.Size(56, 13)
        Me.lblCruceCon.TabIndex = 7
        Me.lblCruceCon.Text = "Cruce con"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(293, 67)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(44, 13)
        Me.lblNumero.TabIndex = 6
        Me.lblNumero.Text = "Numero"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(42, 67)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(30, 13)
        Me.lblCalle.TabIndex = 5
        Me.lblCalle.Text = "Calle"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtObservaciones.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtObservaciones.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtObservaciones.Location = New System.Drawing.Point(126, 401)
        Me.txtObservaciones.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObservaciones.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(890, 20)
        Me.txtObservaciones.TabIndex = 31
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.BackColor = System.Drawing.Color.Transparent
        Me.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblObservaciones.Location = New System.Drawing.Point(42, 404)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(78, 13)
        Me.lblObservaciones.TabIndex = 30
        Me.lblObservaciones.Text = "Observaciones"
        '
        'pnlMesasTitulo
        '
        Me.pnlMesasTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlMesasTitulo.Border = True
        Me.pnlMesasTitulo.BorderColor = System.Drawing.Color.DarkGray
        Me.pnlMesasTitulo.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlMesasTitulo.ContentPadding = New System.Windows.Forms.Padding(10, 5, 10, 0)
        Me.pnlMesasTitulo.Controls.Add(Me.lblTitulo)
        Me.pnlMesasTitulo.CornerRadius = 30
        Me.pnlMesasTitulo.Corners = CType((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight), Azteca.Windows.Corner)
        Me.pnlMesasTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMesasTitulo.Gradient = False
        Me.pnlMesasTitulo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlMesasTitulo.GradientOffset = 1.0!
        Me.pnlMesasTitulo.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlMesasTitulo.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlMesasTitulo.Grayscale = False
        Me.pnlMesasTitulo.Image = Nothing
        Me.pnlMesasTitulo.ImageAlpha = 75
        Me.pnlMesasTitulo.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlMesasTitulo.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlMesasTitulo.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlMesasTitulo.Location = New System.Drawing.Point(0, 108)
        Me.pnlMesasTitulo.Name = "pnlMesasTitulo"
        Me.pnlMesasTitulo.Rounded = True
        Me.pnlMesasTitulo.Size = New System.Drawing.Size(1054, 45)
        Me.pnlMesasTitulo.TabIndex = 40
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Maroon
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1054, 45)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "Pedido a domicilio"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'colNombre
        '
        Me.colNombre.DataPropertyName = "Nombre"
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        '
        'colApellidos
        '
        Me.colApellidos.DataPropertyName = "Apellidos"
        Me.colApellidos.HeaderText = "Apellidos"
        Me.colApellidos.Name = "colApellidos"
        Me.colApellidos.Width = 150
        '
        'colCorreo
        '
        Me.colCorreo.DataPropertyName = "Correo"
        Me.colCorreo.HeaderText = "Correo"
        Me.colCorreo.Name = "colCorreo"
        '
        'pnlMenuBotones
        '
        Me.pnlMenuBotones.BackColor = System.Drawing.Color.Transparent
        Me.pnlMenuBotones.Border = False
        Me.pnlMenuBotones.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlMenuBotones.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlMenuBotones.ContentPadding = New System.Windows.Forms.Padding(10)
        Me.pnlMenuBotones.Controls.Add(Me.btnGuardar)
        Me.pnlMenuBotones.Controls.Add(Me.picAzteca)
        Me.pnlMenuBotones.Controls.Add(Me.btnRegresar)
        Me.pnlMenuBotones.CornerRadius = 20
        Me.pnlMenuBotones.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
                    Or Azteca.Windows.Corner.BottomLeft) _
                    Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlMenuBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMenuBotones.Gradient = False
        Me.pnlMenuBotones.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlMenuBotones.GradientOffset = 1.0!
        Me.pnlMenuBotones.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlMenuBotones.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlMenuBotones.Grayscale = False
        Me.pnlMenuBotones.Image = Nothing
        Me.pnlMenuBotones.ImageAlpha = 75
        Me.pnlMenuBotones.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlMenuBotones.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlMenuBotones.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlMenuBotones.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenuBotones.Name = "pnlMenuBotones"
        Me.pnlMenuBotones.Rounded = True
        Me.pnlMenuBotones.Size = New System.Drawing.Size(1054, 108)
        Me.pnlMenuBotones.TabIndex = 41
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.White
        Me.ColorWithAlpha2.Parent = Me.pnlMenuBotones
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.AutoLock = False
        Me.btnGuardar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnGuardar.CenterPtTracker = DesignerRectTracker3
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.RoyalBlue, System.Drawing.Color.Navy}
        CBlendItems2.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.btnGuardar.ColorFillBlend = CBlendItems2
        Me.btnGuardar.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGuardar.Corners.All = CType(6, Short)
        Me.btnGuardar.Corners.LowerLeft = CType(6, Short)
        Me.btnGuardar.Corners.LowerRight = CType(6, Short)
        Me.btnGuardar.Corners.UpperLeft = CType(6, Short)
        Me.btnGuardar.Corners.UpperRight = CType(6, Short)
        Me.btnGuardar.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.Solid
        Me.btnGuardar.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnGuardar.FocalPoints.CenterPtX = 0.5!
        Me.btnGuardar.FocalPoints.CenterPtY = 0.5!
        Me.btnGuardar.FocalPoints.FocusPtX = 0.0!
        Me.btnGuardar.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnGuardar.FocusPtTracker = DesignerRectTracker4
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.Gray
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.ImageIndex = 0
        Me.btnGuardar.ImageSize = New System.Drawing.Size(48, 48)
        Me.btnGuardar.Location = New System.Drawing.Point(67, 16)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.btnGuardar.SideImage = Nothing
        Me.btnGuardar.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.SideImageSize = New System.Drawing.Size(48, 48)
        Me.btnGuardar.Size = New System.Drawing.Size(90, 77)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnGuardar.TextMargin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.TextShadowShow = False
        Me.btnGuardar.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnGuardar.UseMnemonic = True
        '
        'picAzteca
        '
        Me.picAzteca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.picAzteca.Image = CType(resources.GetObject("picAzteca.Image"), System.Drawing.Image)
        Me.picAzteca.Location = New System.Drawing.Point(372, 8)
        Me.picAzteca.Name = "picAzteca"
        Me.picAzteca.Size = New System.Drawing.Size(330, 91)
        Me.picAzteca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAzteca.TabIndex = 6
        Me.picAzteca.TabStop = False
        Me.picAzteca.UIName = Nothing
        '
        'btnRegresar
        '
        Me.btnRegresar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegresar.AutoLock = False
        Me.btnRegresar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnRegresar.CenterPtTracker = DesignerRectTracker5
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.RoyalBlue, System.Drawing.Color.Navy}
        CBlendItems3.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.btnRegresar.ColorFillBlend = CBlendItems3
        Me.btnRegresar.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnRegresar.Corners.All = CType(6, Short)
        Me.btnRegresar.Corners.LowerLeft = CType(6, Short)
        Me.btnRegresar.Corners.LowerRight = CType(6, Short)
        Me.btnRegresar.Corners.UpperLeft = CType(6, Short)
        Me.btnRegresar.Corners.UpperRight = CType(6, Short)
        Me.btnRegresar.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.Solid
        Me.btnRegresar.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnRegresar.FocalPoints.CenterPtX = 0.5!
        Me.btnRegresar.FocalPoints.CenterPtY = 0.5!
        Me.btnRegresar.FocalPoints.FocusPtX = 0.0!
        Me.btnRegresar.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnRegresar.FocusPtTracker = DesignerRectTracker6
        Me.btnRegresar.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegresar.ForeColor = System.Drawing.Color.Gray
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRegresar.ImageIndex = 0
        Me.btnRegresar.ImageSize = New System.Drawing.Size(48, 48)
        Me.btnRegresar.Location = New System.Drawing.Point(891, 17)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.btnRegresar.SideImage = Nothing
        Me.btnRegresar.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresar.SideImageSize = New System.Drawing.Size(48, 48)
        Me.btnRegresar.Size = New System.Drawing.Size(90, 77)
        Me.btnRegresar.TabIndex = 1
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRegresar.TextMargin = New System.Windows.Forms.Padding(2)
        Me.btnRegresar.TextShadowShow = False
        Me.btnRegresar.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnRegresar.UseMnemonic = True
        '
        'selCliente
        '
        Me.selCliente.AnySite = False
        Me.selCliente.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selCliente.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selCliente.EditorAssembly = "Azteca.VentasWin"
        Me.selCliente.EditorClass = "Azteca.Windows.Ventas.ClientesForm"
        Me.selCliente.EditorTitle = "Editar datos de cliente..."
        Me.selCliente.Key = 0
        Me.selCliente.Linked = False
        Me.selCliente.Location = New System.Drawing.Point(85, 33)
        Me.selCliente.Name = "selCliente"
        Me.selCliente.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCliente.ShowEditButton = True
        Me.selCliente.Size = New System.Drawing.Size(219, 23)
        Me.selCliente.TabIndex = 0
        '
        'PedidoDomicilioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1054, 595)
        Me.Controls.Add(Me.grdPedido)
        Me.Controls.Add(Me.pnlMesasTitulo)
        Me.Controls.Add(Me.pnlMenuBotones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "PedidoDomicilioForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pédido a domicilio"
        Me.grdPedido.ResumeLayout(False)
        Me.grdPedido.PerformLayout()
        Me.pnlLogp.ResumeLayout(False)
        Me.pnlLogp.PerformLayout()
        Me.pnlCliente.ResumeLayout(False)
        Me.pnlCliente.PerformLayout()
        Me.pnlDatosClientes.ResumeLayout(False)
        Me.pnlDatosClientes.PerformLayout()
        CType(Me.grdContactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlbContactos.ResumeLayout(False)
        Me.tlbContactos.PerformLayout()
        Me.pnlMesasTitulo.ResumeLayout(False)
        Me.pnlMenuBotones.ResumeLayout(False)
        CType(Me.picAzteca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsContactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdPedido As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents pnlMesasTitulo As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents lblTitulo As Azteca.Windows.Controls.CILabel
    Friend WithEvents ColorWithAlpha3 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha5 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents pnlMenuBotones As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents picAzteca As Azteca.Windows.Controls.CIPicture
    Friend WithEvents btnRegresar As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents pnlCliente As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents pnlDatosClientes As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents grdContactos As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colApellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCorreo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tlbContactos As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnNuevoContacto As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblClienteTitulo As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCPtxt As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblColoniaTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCruzaConTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblInteriorTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblNumeroTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblAtenionA As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCalleTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCP As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblColonia As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblInterior As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCliente As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCruceCon As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCliente As Azteca.Windows.Ventas.ClienteSelector
    Friend WithEvents lblNumero As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCalle As Azteca.Windows.Controls.CILabel
    Friend WithEvents pnlLogp As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha6 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha7 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnComanda As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents lblTotCantidadTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotTotalTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents lvwComanda As Azteca.Windows.Controls.CIListView
    Friend WithEvents colArticulos As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPrecio As System.Windows.Forms.ColumnHeader
    Friend WithEvents colImporte As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTotCantidad As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotTotal As Azteca.Windows.Controls.CILabel
    Friend WithEvents bsContactos As System.Windows.Forms.BindingSource
    Friend WithEvents btnGuardar As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtObservaciones As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblObservaciones As Azteca.Windows.Controls.CILabel
End Class
