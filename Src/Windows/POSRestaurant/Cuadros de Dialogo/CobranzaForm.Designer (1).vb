<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CobranzaForm
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
        Dim DesignerRectTracker1 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems1 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker2 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim DesignerRectTracker3 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems2 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker4 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CobranzaForm))
        Me.colFormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlVenta = New Azteca.Windows.Controls.CIPanel()
        Me.pnlSubirBajar = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha7 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha8 = New Azteca.Windows.ColorWithAlpha()
        Me.lvwComanda = New Azteca.Windows.Controls.CIListView()
        Me.colArticulos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrecio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdFormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdFormaPago = New Azteca.Windows.Controls.CIDataGridView()
        Me.splitTituloDetalle = New System.Windows.Forms.SplitContainer()
        Me.pnlFormasPago = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha5 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha6 = New Azteca.Windows.ColorWithAlpha()
        Me.pnlTotales = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha3 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha4 = New Azteca.Windows.ColorWithAlpha()
        Me.lblCantidad = New Azteca.Windows.Controls.CILabel()
        Me.lblTotalPagar = New Azteca.Windows.Controls.CILabel()
        Me.lblTotTotalPagar = New Azteca.Windows.Controls.CILabel()
        Me.lblPropina = New Azteca.Windows.Controls.CILabel()
        Me.lblCambio = New Azteca.Windows.Controls.CILabel()
        Me.lblCambioTXT = New Azteca.Windows.Controls.CILabel()
        Me.lblPagado = New Azteca.Windows.Controls.CILabel()
        Me.lblPagoTXT = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.lblTotalTXT = New Azteca.Windows.Controls.CILabel()
        Me.pnlAzteca = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.splitDetalles = New System.Windows.Forms.SplitContainer()
        Me.AlphaGradientPanel1 = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.btnCobrar = New Azteca.Windows.Controls.ButtonPlus()
        Me.btnRegresar = New Azteca.Windows.Controls.ButtonPlus()
        Me.picAzteca = New Azteca.Windows.Controls.CIPicture()
        Me.cmdBajar = New Azteca.Windows.Controls.CIButton()
        Me.cmdSubir = New Azteca.Windows.Controls.CIButton()
        Me.txtCantidad = New Azteca.Windows.TextboxNumberTouch()
        Me.txtPropina = New Azteca.Windows.TextboxNumberTouch()
        Me.pnlVenta.SuspendLayout()
        Me.pnlSubirBajar.SuspendLayout()
        CType(Me.grdFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitTituloDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitTituloDetalle.Panel1.SuspendLayout()
        Me.splitTituloDetalle.Panel2.SuspendLayout()
        Me.splitTituloDetalle.SuspendLayout()
        Me.pnlTotales.SuspendLayout()
        Me.pnlAzteca.SuspendLayout()
        CType(Me.splitDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitDetalles.Panel1.SuspendLayout()
        Me.splitDetalles.Panel2.SuspendLayout()
        Me.splitDetalles.SuspendLayout()
        CType(Me.picAzteca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colFormaPago
        '
        Me.colFormaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFormaPago.DataPropertyName = "FormaPago"
        Me.colFormaPago.HeaderText = "Forma Pago"
        Me.colFormaPago.Name = "colFormaPago"
        Me.colFormaPago.ReadOnly = True
        '
        'pnlVenta
        '
        Me.pnlVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlVenta.Controls.Add(Me.pnlSubirBajar)
        Me.pnlVenta.Controls.Add(Me.lvwComanda)
        Me.pnlVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlVenta.GradientColorA = System.Drawing.SystemColors.ControlLight
        Me.pnlVenta.GradientColorB = System.Drawing.SystemColors.ControlDark
        Me.pnlVenta.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnlVenta.Location = New System.Drawing.Point(0, 0)
        Me.pnlVenta.Name = "pnlVenta"
        Me.pnlVenta.Size = New System.Drawing.Size(424, 180)
        Me.pnlVenta.TabIndex = 21
        Me.pnlVenta.UseGradient = False
        '
        'pnlSubirBajar
        '
        Me.pnlSubirBajar.BackColor = System.Drawing.Color.Transparent
        Me.pnlSubirBajar.Border = False
        Me.pnlSubirBajar.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlSubirBajar.Colors.Add(Me.ColorWithAlpha7)
        Me.pnlSubirBajar.Colors.Add(Me.ColorWithAlpha8)
        Me.pnlSubirBajar.ContentPadding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.pnlSubirBajar.Controls.Add(Me.cmdBajar)
        Me.pnlSubirBajar.Controls.Add(Me.cmdSubir)
        Me.pnlSubirBajar.CornerRadius = 20
        Me.pnlSubirBajar.Corners = Azteca.Windows.Corner.BottomRight
        Me.pnlSubirBajar.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlSubirBajar.Gradient = True
        Me.pnlSubirBajar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlSubirBajar.GradientOffset = 1.0!
        Me.pnlSubirBajar.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlSubirBajar.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlSubirBajar.Grayscale = False
        Me.pnlSubirBajar.Image = Nothing
        Me.pnlSubirBajar.ImageAlpha = 75
        Me.pnlSubirBajar.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlSubirBajar.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlSubirBajar.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlSubirBajar.Location = New System.Drawing.Point(325, 0)
        Me.pnlSubirBajar.Name = "pnlSubirBajar"
        Me.pnlSubirBajar.Rounded = True
        Me.pnlSubirBajar.Size = New System.Drawing.Size(99, 180)
        Me.pnlSubirBajar.TabIndex = 22
        '
        'ColorWithAlpha7
        '
        Me.ColorWithAlpha7.Alpha = 255
        Me.ColorWithAlpha7.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha7.Parent = Me.AlphaGradientPanel1
        '
        'ColorWithAlpha8
        '
        Me.ColorWithAlpha8.Alpha = 255
        Me.ColorWithAlpha8.Color = System.Drawing.Color.White
        Me.ColorWithAlpha8.Parent = Me.AlphaGradientPanel1
        '
        'lvwComanda
        '
        Me.lvwComanda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lvwComanda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvwComanda.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colArticulos, Me.colCantidad, Me.colPrecio})
        Me.lvwComanda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwComanda.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwComanda.FullRowSelect = True
        Me.lvwComanda.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwComanda.HideSelection = False
        Me.lvwComanda.HoverSelection = True
        Me.lvwComanda.Location = New System.Drawing.Point(0, 0)
        Me.lvwComanda.Name = "lvwComanda"
        Me.lvwComanda.Scrollable = False
        Me.lvwComanda.ShowGroups = False
        Me.lvwComanda.Size = New System.Drawing.Size(424, 180)
        Me.lvwComanda.TabIndex = 21
        Me.lvwComanda.UseCompatibleStateImageBehavior = False
        Me.lvwComanda.View = System.Windows.Forms.View.Details
        '
        'colArticulos
        '
        Me.colArticulos.Text = "Articulo"
        Me.colArticulos.Width = 202
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
        Me.colPrecio.Width = 67
        '
        'colMonto
        '
        Me.colMonto.DataPropertyName = "Monto"
        Me.colMonto.HeaderText = "Monto"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.ReadOnly = True
        '
        'colIdFormaPago
        '
        Me.colIdFormaPago.DataPropertyName = "IdFormaPago"
        Me.colIdFormaPago.HeaderText = "IdFormaPago"
        Me.colIdFormaPago.Name = "colIdFormaPago"
        Me.colIdFormaPago.ReadOnly = True
        Me.colIdFormaPago.Visible = False
        '
        'grdFormaPago
        '
        Me.grdFormaPago.AllowUserToAddRows = False
        Me.grdFormaPago.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdFormaPago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdFormaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdFormaPago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdFormaPago, Me.colFormaPago, Me.colMonto})
        Me.grdFormaPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFormaPago.Location = New System.Drawing.Point(99, 0)
        Me.grdFormaPago.MultiSelect = False
        Me.grdFormaPago.Name = "grdFormaPago"
        Me.grdFormaPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdFormaPago.Size = New System.Drawing.Size(339, 180)
        Me.grdFormaPago.TabIndex = 9
        '
        'splitTituloDetalle
        '
        Me.splitTituloDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.splitTituloDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitTituloDetalle.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitTituloDetalle.Location = New System.Drawing.Point(0, 0)
        Me.splitTituloDetalle.Name = "splitTituloDetalle"
        Me.splitTituloDetalle.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitTituloDetalle.Panel1
        '
        Me.splitTituloDetalle.Panel1.Controls.Add(Me.pnlFormasPago)
        Me.splitTituloDetalle.Panel1.Controls.Add(Me.pnlTotales)
        Me.splitTituloDetalle.Panel1.Controls.Add(Me.pnlAzteca)
        '
        'splitTituloDetalle.Panel2
        '
        Me.splitTituloDetalle.Panel2.Controls.Add(Me.splitDetalles)
        Me.splitTituloDetalle.Size = New System.Drawing.Size(866, 523)
        Me.splitTituloDetalle.SplitterDistance = 342
        Me.splitTituloDetalle.SplitterWidth = 1
        Me.splitTituloDetalle.TabIndex = 45
        '
        'pnlFormasPago
        '
        Me.pnlFormasPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlFormasPago.Border = False
        Me.pnlFormasPago.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlFormasPago.Colors.Add(Me.ColorWithAlpha5)
        Me.pnlFormasPago.Colors.Add(Me.ColorWithAlpha6)
        Me.pnlFormasPago.ContentPadding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.pnlFormasPago.CornerRadius = 40
        Me.pnlFormasPago.Corners = CType((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight), Azteca.Windows.Corner)
        Me.pnlFormasPago.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFormasPago.Gradient = True
        Me.pnlFormasPago.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlFormasPago.GradientOffset = 1.0!
        Me.pnlFormasPago.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlFormasPago.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlFormasPago.Grayscale = False
        Me.pnlFormasPago.Image = Nothing
        Me.pnlFormasPago.ImageAlpha = 75
        Me.pnlFormasPago.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlFormasPago.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlFormasPago.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlFormasPago.Location = New System.Drawing.Point(0, 248)
        Me.pnlFormasPago.Name = "pnlFormasPago"
        Me.pnlFormasPago.Rounded = True
        Me.pnlFormasPago.Size = New System.Drawing.Size(866, 92)
        Me.pnlFormasPago.TabIndex = 47
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 255
        Me.ColorWithAlpha5.Color = System.Drawing.Color.White
        Me.ColorWithAlpha5.Parent = Me.pnlFormasPago
        '
        'ColorWithAlpha6
        '
        Me.ColorWithAlpha6.Alpha = 255
        Me.ColorWithAlpha6.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha6.Parent = Me.pnlFormasPago
        '
        'pnlTotales
        '
        Me.pnlTotales.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlTotales.Border = True
        Me.pnlTotales.BorderColor = System.Drawing.Color.Olive
        Me.pnlTotales.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlTotales.Colors.Add(Me.ColorWithAlpha3)
        Me.pnlTotales.Colors.Add(Me.ColorWithAlpha4)
        Me.pnlTotales.ContentPadding = New System.Windows.Forms.Padding(10, 0, 10, 5)
        Me.pnlTotales.Controls.Add(Me.txtCantidad)
        Me.pnlTotales.Controls.Add(Me.txtPropina)
        Me.pnlTotales.Controls.Add(Me.lblCantidad)
        Me.pnlTotales.Controls.Add(Me.lblTotalPagar)
        Me.pnlTotales.Controls.Add(Me.lblTotTotalPagar)
        Me.pnlTotales.Controls.Add(Me.lblPropina)
        Me.pnlTotales.Controls.Add(Me.lblCambio)
        Me.pnlTotales.Controls.Add(Me.lblCambioTXT)
        Me.pnlTotales.Controls.Add(Me.lblPagado)
        Me.pnlTotales.Controls.Add(Me.lblPagoTXT)
        Me.pnlTotales.Controls.Add(Me.CiLabel2)
        Me.pnlTotales.Controls.Add(Me.lblTotalTXT)
        Me.pnlTotales.CornerRadius = 25
        Me.pnlTotales.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
                    Or Azteca.Windows.Corner.BottomLeft) _
                    Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlTotales.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTotales.Gradient = True
        Me.pnlTotales.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlTotales.GradientOffset = 1.0!
        Me.pnlTotales.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlTotales.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlTotales.Grayscale = False
        Me.pnlTotales.Image = Nothing
        Me.pnlTotales.ImageAlpha = 75
        Me.pnlTotales.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlTotales.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlTotales.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlTotales.Location = New System.Drawing.Point(0, 91)
        Me.pnlTotales.Name = "pnlTotales"
        Me.pnlTotales.Rounded = True
        Me.pnlTotales.Size = New System.Drawing.Size(866, 157)
        Me.pnlTotales.TabIndex = 46
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.White
        Me.ColorWithAlpha2.Parent = Me.pnlTotales
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha3.Parent = Me.pnlTotales
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.White
        Me.ColorWithAlpha4.Parent = Me.pnlTotales
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.BackColor = System.Drawing.Color.Transparent
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.Maroon
        Me.lblCantidad.Location = New System.Drawing.Point(631, 101)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(70, 16)
        Me.lblCantidad.TabIndex = 49
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblTotalPagar
        '
        Me.lblTotalPagar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalPagar.AutoSize = True
        Me.lblTotalPagar.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPagar.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotalPagar.Location = New System.Drawing.Point(293, 72)
        Me.lblTotalPagar.Name = "lblTotalPagar"
        Me.lblTotalPagar.Size = New System.Drawing.Size(102, 16)
        Me.lblTotalPagar.TabIndex = 11
        Me.lblTotalPagar.Text = "Total a pagar"
        '
        'lblTotTotalPagar
        '
        Me.lblTotTotalPagar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotTotalPagar.BackColor = System.Drawing.Color.Transparent
        Me.lblTotTotalPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotTotalPagar.ForeColor = System.Drawing.Color.Black
        Me.lblTotTotalPagar.Location = New System.Drawing.Point(288, 65)
        Me.lblTotTotalPagar.Name = "lblTotTotalPagar"
        Me.lblTotTotalPagar.Size = New System.Drawing.Size(335, 27)
        Me.lblTotTotalPagar.TabIndex = 12
        Me.lblTotTotalPagar.Text = "$150.00"
        Me.lblTotTotalPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPropina
        '
        Me.lblPropina.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPropina.AutoSize = True
        Me.lblPropina.BackColor = System.Drawing.Color.Transparent
        Me.lblPropina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPropina.ForeColor = System.Drawing.Color.Maroon
        Me.lblPropina.Location = New System.Drawing.Point(294, 42)
        Me.lblPropina.Name = "lblPropina"
        Me.lblPropina.Size = New System.Drawing.Size(62, 16)
        Me.lblPropina.TabIndex = 9
        Me.lblPropina.Text = "Propina"
        '
        'lblCambio
        '
        Me.lblCambio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCambio.AutoSize = True
        Me.lblCambio.BackColor = System.Drawing.Color.Transparent
        Me.lblCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCambio.ForeColor = System.Drawing.Color.Maroon
        Me.lblCambio.Location = New System.Drawing.Point(295, 133)
        Me.lblCambio.Name = "lblCambio"
        Me.lblCambio.Size = New System.Drawing.Size(61, 16)
        Me.lblCambio.TabIndex = 7
        Me.lblCambio.Text = "Cambio"
        '
        'lblCambioTXT
        '
        Me.lblCambioTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCambioTXT.BackColor = System.Drawing.Color.Transparent
        Me.lblCambioTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCambioTXT.ForeColor = System.Drawing.Color.Red
        Me.lblCambioTXT.Location = New System.Drawing.Point(288, 127)
        Me.lblCambioTXT.Name = "lblCambioTXT"
        Me.lblCambioTXT.Size = New System.Drawing.Size(335, 27)
        Me.lblCambioTXT.TabIndex = 8
        Me.lblCambioTXT.Text = "$0.00"
        Me.lblCambioTXT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPagado
        '
        Me.lblPagado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPagado.AutoSize = True
        Me.lblPagado.BackColor = System.Drawing.Color.Transparent
        Me.lblPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagado.ForeColor = System.Drawing.Color.Maroon
        Me.lblPagado.Location = New System.Drawing.Point(296, 102)
        Me.lblPagado.Name = "lblPagado"
        Me.lblPagado.Size = New System.Drawing.Size(45, 16)
        Me.lblPagado.TabIndex = 5
        Me.lblPagado.Text = "Pago"
        '
        'lblPagoTXT
        '
        Me.lblPagoTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPagoTXT.BackColor = System.Drawing.Color.Transparent
        Me.lblPagoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagoTXT.ForeColor = System.Drawing.Color.Green
        Me.lblPagoTXT.Location = New System.Drawing.Point(288, 96)
        Me.lblPagoTXT.Name = "lblPagoTXT"
        Me.lblPagoTXT.Size = New System.Drawing.Size(335, 27)
        Me.lblPagoTXT.TabIndex = 6
        Me.lblPagoTXT.Text = "$0.00"
        Me.lblPagoTXT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CiLabel2
        '
        Me.CiLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.BackColor = System.Drawing.Color.Transparent
        Me.CiLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel2.ForeColor = System.Drawing.Color.Maroon
        Me.CiLabel2.Location = New System.Drawing.Point(293, 10)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(44, 16)
        Me.CiLabel2.TabIndex = 3
        Me.CiLabel2.Text = "Total"
        '
        'lblTotalTXT
        '
        Me.lblTotalTXT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalTXT.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTXT.ForeColor = System.Drawing.Color.Black
        Me.lblTotalTXT.Location = New System.Drawing.Point(288, 3)
        Me.lblTotalTXT.Name = "lblTotalTXT"
        Me.lblTotalTXT.Size = New System.Drawing.Size(335, 27)
        Me.lblTotalTXT.TabIndex = 4
        Me.lblTotalTXT.Text = "$150.00"
        Me.lblTotalTXT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlAzteca
        '
        Me.pnlAzteca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlAzteca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlAzteca.Border = False
        Me.pnlAzteca.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlAzteca.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlAzteca.ContentPadding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.pnlAzteca.Controls.Add(Me.btnCobrar)
        Me.pnlAzteca.Controls.Add(Me.btnRegresar)
        Me.pnlAzteca.Controls.Add(Me.picAzteca)
        Me.pnlAzteca.CornerRadius = 30
        Me.pnlAzteca.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
                    Or Azteca.Windows.Corner.BottomLeft) _
                    Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlAzteca.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAzteca.Gradient = False
        Me.pnlAzteca.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlAzteca.GradientOffset = 1.0!
        Me.pnlAzteca.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlAzteca.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlAzteca.Grayscale = False
        Me.pnlAzteca.Image = Nothing
        Me.pnlAzteca.ImageAlpha = 75
        Me.pnlAzteca.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlAzteca.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlAzteca.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlAzteca.Location = New System.Drawing.Point(0, 0)
        Me.pnlAzteca.Name = "pnlAzteca"
        Me.pnlAzteca.Rounded = True
        Me.pnlAzteca.Size = New System.Drawing.Size(866, 91)
        Me.pnlAzteca.TabIndex = 45
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.SystemColors.ButtonHighlight
        Me.ColorWithAlpha1.Parent = Me.pnlAzteca
        '
        'splitDetalles
        '
        Me.splitDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitDetalles.Location = New System.Drawing.Point(0, 0)
        Me.splitDetalles.Name = "splitDetalles"
        '
        'splitDetalles.Panel1
        '
        Me.splitDetalles.Panel1.Controls.Add(Me.grdFormaPago)
        Me.splitDetalles.Panel1.Controls.Add(Me.AlphaGradientPanel1)
        '
        'splitDetalles.Panel2
        '
        Me.splitDetalles.Panel2.Controls.Add(Me.pnlVenta)
        Me.splitDetalles.Size = New System.Drawing.Size(866, 180)
        Me.splitDetalles.SplitterDistance = 438
        Me.splitDetalles.TabIndex = 10
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.AlphaGradientPanel1.Border = False
        Me.AlphaGradientPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha7)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha8)
        Me.AlphaGradientPanel1.ContentPadding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.AlphaGradientPanel1.CornerRadius = 20
        Me.AlphaGradientPanel1.Corners = Azteca.Windows.Corner.BottomLeft
        Me.AlphaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.AlphaGradientPanel1.Gradient = True
        Me.AlphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.AlphaGradientPanel1.GradientOffset = 1.0!
        Me.AlphaGradientPanel1.GradientSize = New System.Drawing.Size(0, 0)
        Me.AlphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.AlphaGradientPanel1.Grayscale = False
        Me.AlphaGradientPanel1.Image = Nothing
        Me.AlphaGradientPanel1.ImageAlpha = 75
        Me.AlphaGradientPanel1.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.AlphaGradientPanel1.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.AlphaGradientPanel1.ImageSize = New System.Drawing.Size(48, 48)
        Me.AlphaGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = True
        Me.AlphaGradientPanel1.Size = New System.Drawing.Size(99, 180)
        Me.AlphaGradientPanel1.TabIndex = 23
        '
        'btnCobrar
        '
        Me.btnCobrar.AutoLock = False
        Me.btnCobrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCobrar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnCobrar.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.RoyalBlue, System.Drawing.Color.Navy}
        CBlendItems1.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.btnCobrar.ColorFillBlend = CBlendItems1
        Me.btnCobrar.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnCobrar.Corners.All = CType(6, Short)
        Me.btnCobrar.Corners.LowerLeft = CType(6, Short)
        Me.btnCobrar.Corners.LowerRight = CType(6, Short)
        Me.btnCobrar.Corners.UpperLeft = CType(6, Short)
        Me.btnCobrar.Corners.UpperRight = CType(6, Short)
        Me.btnCobrar.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.Solid
        Me.btnCobrar.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnCobrar.FocalPoints.CenterPtX = 0.5!
        Me.btnCobrar.FocalPoints.CenterPtY = 0.5!
        Me.btnCobrar.FocalPoints.FocusPtX = 0.0!
        Me.btnCobrar.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnCobrar.FocusPtTracker = DesignerRectTracker2
        Me.btnCobrar.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCobrar.ForeColor = System.Drawing.Color.Gray
        Me.btnCobrar.Image = CType(resources.GetObject("btnCobrar.Image"), System.Drawing.Image)
        Me.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCobrar.ImageIndex = 0
        Me.btnCobrar.ImageSize = New System.Drawing.Size(48, 48)
        Me.btnCobrar.Location = New System.Drawing.Point(44, 8)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.btnCobrar.SideImage = Nothing
        Me.btnCobrar.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCobrar.SideImageSize = New System.Drawing.Size(48, 48)
        Me.btnCobrar.Size = New System.Drawing.Size(90, 74)
        Me.btnCobrar.TabIndex = 5
        Me.btnCobrar.Text = "Cobrar"
        Me.btnCobrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCobrar.TextMargin = New System.Windows.Forms.Padding(2)
        Me.btnCobrar.TextShadowShow = False
        Me.btnCobrar.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnCobrar.UseMnemonic = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegresar.AutoLock = False
        Me.btnRegresar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegresar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnRegresar.CenterPtTracker = DesignerRectTracker3
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.RoyalBlue, System.Drawing.Color.Navy}
        CBlendItems2.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.btnRegresar.ColorFillBlend = CBlendItems2
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
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnRegresar.FocusPtTracker = DesignerRectTracker4
        Me.btnRegresar.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegresar.ForeColor = System.Drawing.Color.Gray
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRegresar.ImageIndex = 0
        Me.btnRegresar.ImageSize = New System.Drawing.Size(48, 48)
        Me.btnRegresar.Location = New System.Drawing.Point(730, 11)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.btnRegresar.SideImage = Nothing
        Me.btnRegresar.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresar.SideImageSize = New System.Drawing.Size(48, 48)
        Me.btnRegresar.Size = New System.Drawing.Size(90, 69)
        Me.btnRegresar.TabIndex = 4
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRegresar.TextMargin = New System.Windows.Forms.Padding(2)
        Me.btnRegresar.TextShadowShow = False
        Me.btnRegresar.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnRegresar.UseMnemonic = True
        '
        'picAzteca
        '
        Me.picAzteca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.picAzteca.Image = CType(resources.GetObject("picAzteca.Image"), System.Drawing.Image)
        Me.picAzteca.Location = New System.Drawing.Point(286, 7)
        Me.picAzteca.Name = "picAzteca"
        Me.picAzteca.Size = New System.Drawing.Size(336, 75)
        Me.picAzteca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAzteca.TabIndex = 3
        Me.picAzteca.TabStop = False
        Me.picAzteca.UIName = Nothing
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
        Me.cmdBajar.Location = New System.Drawing.Point(8, 113)
        Me.cmdBajar.Name = "cmdBajar"
        Me.cmdBajar.Size = New System.Drawing.Size(72, 60)
        Me.cmdBajar.TabIndex = 6
        Me.cmdBajar.Text = "Bajar"
        Me.cmdBajar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdBajar.UseVisualStyleBackColor = False
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
        Me.cmdSubir.Location = New System.Drawing.Point(10, 26)
        Me.cmdSubir.Name = "cmdSubir"
        Me.cmdSubir.Size = New System.Drawing.Size(70, 60)
        Me.cmdSubir.TabIndex = 5
        Me.cmdSubir.Text = "Subir"
        Me.cmdSubir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSubir.UseVisualStyleBackColor = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCantidad.AutoSize = True
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.Location = New System.Drawing.Point(707, 94)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(252, 31)
        Me.txtCantidad.TabIndex = 51
        Me.txtCantidad.TextInfo = ""
        '
        'txtPropina
        '
        Me.txtPropina.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPropina.AutoSize = True
        Me.txtPropina.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPropina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPropina.Location = New System.Drawing.Point(457, 33)
        Me.txtPropina.Name = "txtPropina"
        Me.txtPropina.Size = New System.Drawing.Size(252, 31)
        Me.txtPropina.TabIndex = 50
        Me.txtPropina.TextInfo = ""
        '
        'CobranzaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 523)
        Me.ControlBox = False
        Me.Controls.Add(Me.splitTituloDetalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CobranzaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlVenta.ResumeLayout(False)
        Me.pnlSubirBajar.ResumeLayout(False)
        CType(Me.grdFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitTituloDetalle.Panel1.ResumeLayout(False)
        Me.splitTituloDetalle.Panel2.ResumeLayout(False)
        CType(Me.splitTituloDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitTituloDetalle.ResumeLayout(False)
        Me.pnlTotales.ResumeLayout(False)
        Me.pnlTotales.PerformLayout()
        Me.pnlAzteca.ResumeLayout(False)
        Me.splitDetalles.Panel1.ResumeLayout(False)
        Me.splitDetalles.Panel2.ResumeLayout(False)
        CType(Me.splitDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitDetalles.ResumeLayout(False)
        CType(Me.picAzteca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdBajar As Azteca.Windows.Controls.CIButton
    Friend WithEvents colFormaPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlVenta As Azteca.Windows.Controls.CIPanel
    Friend WithEvents cmdSubir As Azteca.Windows.Controls.CIButton
    Friend WithEvents lvwComanda As Azteca.Windows.Controls.CIListView
    Friend WithEvents colArticulos As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPrecio As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMonto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIdFormaPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdFormaPago As Azteca.Windows.Controls.CIDataGridView
    Friend WithEvents splitTituloDetalle As System.Windows.Forms.SplitContainer
    Friend WithEvents ColorWithAlpha5 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha6 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha3 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents splitDetalles As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlFormasPago As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents pnlTotales As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents lblTotalPagar As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotTotalPagar As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblPropina As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCambio As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCambioTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblPagado As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblPagoTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotalTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents pnlAzteca As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents btnCobrar As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents btnRegresar As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents picAzteca As Azteca.Windows.Controls.CIPicture
    Friend WithEvents lblCantidad As Azteca.Windows.Controls.CILabel
    Friend WithEvents pnlSubirBajar As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents txtCantidad As Azteca.Windows.TextboxNumberTouch
    Friend WithEvents txtPropina As Azteca.Windows.TextboxNumberTouch
    Friend WithEvents ColorWithAlpha7 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents AlphaGradientPanel1 As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha8 As Azteca.Windows.ColorWithAlpha

End Class
