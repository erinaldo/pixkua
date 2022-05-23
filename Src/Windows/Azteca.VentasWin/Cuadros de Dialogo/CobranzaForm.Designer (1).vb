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
        Me.components = New System.ComponentModel.Container()
        Dim DesignerRectTracker3 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems2 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker4 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim DesignerRectTracker5 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems3 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker6 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim DesignerRectTracker7 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems4 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker8 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim DesignerRectTracker9 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems5 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker10 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim DesignerRectTracker11 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems6 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker12 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim DesignerRectTracker1 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CobranzaForm))
        Dim CBlendItems1 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker2 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Me.lblFormasPago = New Azteca.Windows.Controls.CILabel()
        Me.txtCantidad = New Azteca.Windows.Controls.CITextBox()
        Me.lblCantidad = New Azteca.Windows.Controls.CILabel()
        Me.grdFormaPago = New Azteca.Windows.Controls.CIDataGridView()
        Me.colIdFormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlUsuario = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.AlphaGradientPanel2 = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha3 = New Azteca.Windows.ColorWithAlpha()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.lblCambio = New Azteca.Windows.Controls.CILabel()
        Me.lblCambioTXT = New Azteca.Windows.Controls.CILabel()
        Me.lblPagado = New Azteca.Windows.Controls.CILabel()
        Me.lblPagoTXT = New Azteca.Windows.Controls.CILabel()
        Me.lblTotal = New Azteca.Windows.Controls.CILabel()
        Me.lblTotalTXT = New Azteca.Windows.Controls.CILabel()
        Me.AlphaGradientPanel1 = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha4 = New Azteca.Windows.ColorWithAlpha()
        Me.cmdValeDesp = New Azteca.Windows.Controls.ButtonPlus()
        Me.cmdOtro = New Azteca.Windows.Controls.ButtonPlus()
        Me.cmdCheque = New Azteca.Windows.Controls.ButtonPlus()
        Me.cmdTarjeta = New Azteca.Windows.Controls.ButtonPlus()
        Me.cmdEfectivo = New Azteca.Windows.Controls.ButtonPlus()
        Me.lblDetalle = New Azteca.Windows.Controls.CILabel()
        Me.txtReferencia = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.cboFormasPago = New Azteca.Windows.Ventas.FormasPagoComboBox()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdBuscarArt = New Azteca.Windows.Controls.ButtonPlus()
        CType(Me.grdFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUsuario.SuspendLayout()
        Me.AlphaGradientPanel2.SuspendLayout()
        Me.AlphaGradientPanel1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFormasPago
        '
        Me.lblFormasPago.AutoSize = True
        Me.lblFormasPago.Location = New System.Drawing.Point(29, 75)
        Me.lblFormasPago.Name = "lblFormasPago"
        Me.lblFormasPago.Size = New System.Drawing.Size(78, 13)
        Me.lblFormasPago.TabIndex = 1
        Me.lblFormasPago.Text = "Forma de pago"
        Me.lblFormasPago.Visible = False
        '
        'txtCantidad
        '
        Me.txtCantidad.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCantidad.Digits = True
        Me.txtCantidad.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantidad.Location = New System.Drawing.Point(113, 101)
        Me.txtCantidad.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(85, 22)
        Me.txtCantidad.TabIndex = 2
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(58, 104)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 3
        Me.lblCantidad.Text = "Cantidad"
        '
        'grdFormaPago
        '
        Me.grdFormaPago.AllowUserToAddRows = False
        Me.grdFormaPago.BackgroundColor = System.Drawing.Color.White
        Me.grdFormaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdFormaPago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdFormaPago, Me.colFormaPago, Me.colMonto})
        Me.grdFormaPago.Location = New System.Drawing.Point(113, 129)
        Me.grdFormaPago.MultiSelect = False
        Me.grdFormaPago.Name = "grdFormaPago"
        Me.grdFormaPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdFormaPago.Size = New System.Drawing.Size(296, 142)
        Me.grdFormaPago.TabIndex = 4
        '
        'colIdFormaPago
        '
        Me.colIdFormaPago.DataPropertyName = "IdFormaPago"
        Me.colIdFormaPago.HeaderText = "IdFormaPago"
        Me.colIdFormaPago.Name = "colIdFormaPago"
        Me.colIdFormaPago.ReadOnly = True
        Me.colIdFormaPago.Visible = False
        '
        'colFormaPago
        '
        Me.colFormaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFormaPago.DataPropertyName = "FormaPago"
        Me.colFormaPago.HeaderText = "Forma Pago"
        Me.colFormaPago.Name = "colFormaPago"
        Me.colFormaPago.ReadOnly = True
        '
        'colMonto
        '
        Me.colMonto.DataPropertyName = "Monto"
        Me.colMonto.HeaderText = "Monto"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.ReadOnly = True
        '
        'pnlUsuario
        '
        Me.pnlUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUsuario.BackColor = System.Drawing.Color.Transparent
        Me.pnlUsuario.Border = False
        Me.pnlUsuario.BorderColor = System.Drawing.Color.Olive
        Me.pnlUsuario.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlUsuario.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlUsuario.Colors.Add(Me.ColorWithAlpha3)
        Me.pnlUsuario.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlUsuario.Controls.Add(Me.lblCambio)
        Me.pnlUsuario.Controls.Add(Me.lblCambioTXT)
        Me.pnlUsuario.Controls.Add(Me.lblPagado)
        Me.pnlUsuario.Controls.Add(Me.lblPagoTXT)
        Me.pnlUsuario.Controls.Add(Me.lblTotal)
        Me.pnlUsuario.Controls.Add(Me.lblTotalTXT)
        Me.pnlUsuario.CornerRadius = 25
        Me.pnlUsuario.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlUsuario.Gradient = True
        Me.pnlUsuario.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlUsuario.GradientOffset = 1.0!
        Me.pnlUsuario.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlUsuario.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlUsuario.Grayscale = False
        Me.pnlUsuario.Image = Nothing
        Me.pnlUsuario.ImageAlpha = 75
        Me.pnlUsuario.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlUsuario.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlUsuario.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlUsuario.Location = New System.Drawing.Point(5, 35)
        Me.pnlUsuario.Name = "pnlUsuario"
        Me.pnlUsuario.Rounded = True
        Me.pnlUsuario.Size = New System.Drawing.Size(435, 121)
        Me.pnlUsuario.TabIndex = 23
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWithAlpha1.Parent = Me.AlphaGradientPanel1
        '
        'AlphaGradientPanel2
        '
        Me.AlphaGradientPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlphaGradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.AlphaGradientPanel2.Border = False
        Me.AlphaGradientPanel2.BorderColor = System.Drawing.Color.Olive
        Me.AlphaGradientPanel2.Colors.Add(Me.ColorWithAlpha1)
        Me.AlphaGradientPanel2.Colors.Add(Me.ColorWithAlpha2)
        Me.AlphaGradientPanel2.Colors.Add(Me.ColorWithAlpha3)
        Me.AlphaGradientPanel2.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.AlphaGradientPanel2.Controls.Add(Me.CiLabel3)
        Me.AlphaGradientPanel2.CornerRadius = 25
        Me.AlphaGradientPanel2.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.AlphaGradientPanel2.Gradient = True
        Me.AlphaGradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.AlphaGradientPanel2.GradientOffset = 1.0!
        Me.AlphaGradientPanel2.GradientSize = New System.Drawing.Size(0, 0)
        Me.AlphaGradientPanel2.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.AlphaGradientPanel2.Grayscale = False
        Me.AlphaGradientPanel2.Image = Nothing
        Me.AlphaGradientPanel2.ImageAlpha = 75
        Me.AlphaGradientPanel2.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.AlphaGradientPanel2.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.AlphaGradientPanel2.ImageSize = New System.Drawing.Size(48, 48)
        Me.AlphaGradientPanel2.Location = New System.Drawing.Point(-10, 4)
        Me.AlphaGradientPanel2.Name = "AlphaGradientPanel2"
        Me.AlphaGradientPanel2.Rounded = True
        Me.AlphaGradientPanel2.Size = New System.Drawing.Size(463, 25)
        Me.AlphaGradientPanel2.TabIndex = 24
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha2.Parent = Me.AlphaGradientPanel1
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWithAlpha3.Parent = Me.pnlUsuario
        '
        'CiLabel3
        '
        Me.CiLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel3.ForeColor = System.Drawing.Color.Black
        Me.CiLabel3.Location = New System.Drawing.Point(32, 5)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(362, 16)
        Me.CiLabel3.TabIndex = 9
        Me.CiLabel3.Text = "Establer la forma de pago"
        Me.CiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCambio
        '
        Me.lblCambio.AutoSize = True
        Me.lblCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCambio.ForeColor = System.Drawing.Color.Black
        Me.lblCambio.Location = New System.Drawing.Point(50, 81)
        Me.lblCambio.Name = "lblCambio"
        Me.lblCambio.Size = New System.Drawing.Size(61, 16)
        Me.lblCambio.TabIndex = 7
        Me.lblCambio.Text = "Cambio"
        '
        'lblCambioTXT
        '
        Me.lblCambioTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCambioTXT.ForeColor = System.Drawing.Color.Red
        Me.lblCambioTXT.Location = New System.Drawing.Point(36, 73)
        Me.lblCambioTXT.Name = "lblCambioTXT"
        Me.lblCambioTXT.Size = New System.Drawing.Size(342, 30)
        Me.lblCambioTXT.TabIndex = 8
        Me.lblCambioTXT.Text = "$0.00"
        Me.lblCambioTXT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPagado
        '
        Me.lblPagado.AutoSize = True
        Me.lblPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagado.ForeColor = System.Drawing.Color.Black
        Me.lblPagado.Location = New System.Drawing.Point(66, 51)
        Me.lblPagado.Name = "lblPagado"
        Me.lblPagado.Size = New System.Drawing.Size(45, 16)
        Me.lblPagado.TabIndex = 5
        Me.lblPagado.Text = "Pago"
        '
        'lblPagoTXT
        '
        Me.lblPagoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagoTXT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPagoTXT.Location = New System.Drawing.Point(36, 43)
        Me.lblPagoTXT.Name = "lblPagoTXT"
        Me.lblPagoTXT.Size = New System.Drawing.Size(342, 30)
        Me.lblPagoTXT.TabIndex = 6
        Me.lblPagoTXT.Text = "$0.00"
        Me.lblPagoTXT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(66, 20)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(44, 16)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total"
        '
        'lblTotalTXT
        '
        Me.lblTotalTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTXT.ForeColor = System.Drawing.Color.Black
        Me.lblTotalTXT.Location = New System.Drawing.Point(36, 12)
        Me.lblTotalTXT.Name = "lblTotalTXT"
        Me.lblTotalTXT.Size = New System.Drawing.Size(342, 30)
        Me.lblTotalTXT.TabIndex = 4
        Me.lblTotalTXT.Text = "$150.00"
        Me.lblTotalTXT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlphaGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.AlphaGradientPanel1.Border = False
        Me.AlphaGradientPanel1.BorderColor = System.Drawing.Color.Olive
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha1)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha2)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha4)
        Me.AlphaGradientPanel1.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.AlphaGradientPanel1.Controls.Add(Me.cmdBuscarArt)
        Me.AlphaGradientPanel1.Controls.Add(Me.cmdValeDesp)
        Me.AlphaGradientPanel1.Controls.Add(Me.cmdOtro)
        Me.AlphaGradientPanel1.Controls.Add(Me.cmdCheque)
        Me.AlphaGradientPanel1.Controls.Add(Me.cmdTarjeta)
        Me.AlphaGradientPanel1.Controls.Add(Me.cmdEfectivo)
        Me.AlphaGradientPanel1.Controls.Add(Me.lblDetalle)
        Me.AlphaGradientPanel1.Controls.Add(Me.txtReferencia)
        Me.AlphaGradientPanel1.Controls.Add(Me.CiLabel2)
        Me.AlphaGradientPanel1.Controls.Add(Me.cboFormasPago)
        Me.AlphaGradientPanel1.Controls.Add(Me.lblFormasPago)
        Me.AlphaGradientPanel1.Controls.Add(Me.grdFormaPago)
        Me.AlphaGradientPanel1.Controls.Add(Me.txtCantidad)
        Me.AlphaGradientPanel1.Controls.Add(Me.lblCantidad)
        Me.AlphaGradientPanel1.CornerRadius = 25
        Me.AlphaGradientPanel1.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
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
        Me.AlphaGradientPanel1.Location = New System.Drawing.Point(5, 161)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = True
        Me.AlphaGradientPanel1.Size = New System.Drawing.Size(435, 281)
        Me.AlphaGradientPanel1.TabIndex = 24
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWithAlpha4.Parent = Me.AlphaGradientPanel1
        '
        'cmdValeDesp
        '
        Me.cmdValeDesp.AutoLock = False
        Me.cmdValeDesp.BorderColor = System.Drawing.Color.White
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdValeDesp.CenterPtTracker = DesignerRectTracker3
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))}
        CBlendItems2.iPoint = New Single() {0.0!, 1.0!}
        Me.cmdValeDesp.ColorFillBlend = CBlendItems2
        Me.cmdValeDesp.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.cmdValeDesp.Corners.All = CType(10, Short)
        Me.cmdValeDesp.Corners.LowerLeft = CType(10, Short)
        Me.cmdValeDesp.Corners.LowerRight = CType(10, Short)
        Me.cmdValeDesp.Corners.UpperLeft = CType(10, Short)
        Me.cmdValeDesp.Corners.UpperRight = CType(10, Short)
        Me.cmdValeDesp.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientPath
        Me.cmdValeDesp.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdValeDesp.FocalPoints.CenterPtX = 0.5!
        Me.cmdValeDesp.FocalPoints.CenterPtY = 0.3571429!
        Me.cmdValeDesp.FocalPoints.FocusPtX = 0.0!
        Me.cmdValeDesp.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdValeDesp.FocusPtTracker = DesignerRectTracker4
        Me.cmdValeDesp.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdValeDesp.ForeColor = System.Drawing.Color.Black
        Me.cmdValeDesp.Image = CType(resources.GetObject("cmdValeDesp.Image"), System.Drawing.Image)
        Me.cmdValeDesp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdValeDesp.ImageIndex = 0
        Me.cmdValeDesp.Imagelist = Nothing
        Me.cmdValeDesp.ImageSize = New System.Drawing.Size(32, 32)
        Me.cmdValeDesp.Location = New System.Drawing.Point(259, 8)
        Me.cmdValeDesp.Name = "cmdValeDesp"
        Me.cmdValeDesp.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.cmdValeDesp.SideImage = Nothing
        Me.cmdValeDesp.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdValeDesp.SideImageSize = New System.Drawing.Size(48, 48)
        Me.cmdValeDesp.Size = New System.Drawing.Size(70, 57)
        Me.cmdValeDesp.TabIndex = 14
        Me.cmdValeDesp.TabStop = False
        Me.cmdValeDesp.Text = "Vale Desp.[F4]"
        Me.cmdValeDesp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdValeDesp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdValeDesp.TextMargin = New System.Windows.Forms.Padding(2)
        Me.cmdValeDesp.TextShadow = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdValeDesp.TextShadowShow = False
        Me.cmdValeDesp.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.cmdValeDesp.UseMnemonic = True
        '
        'cmdOtro
        '
        Me.cmdOtro.AutoLock = False
        Me.cmdOtro.BorderColor = System.Drawing.Color.White
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdOtro.CenterPtTracker = DesignerRectTracker5
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))}
        CBlendItems3.iPoint = New Single() {0.0!, 1.0!}
        Me.cmdOtro.ColorFillBlend = CBlendItems3
        Me.cmdOtro.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.cmdOtro.Corners.All = CType(10, Short)
        Me.cmdOtro.Corners.LowerLeft = CType(10, Short)
        Me.cmdOtro.Corners.LowerRight = CType(10, Short)
        Me.cmdOtro.Corners.UpperLeft = CType(10, Short)
        Me.cmdOtro.Corners.UpperRight = CType(10, Short)
        Me.cmdOtro.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientPath
        Me.cmdOtro.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOtro.FocalPoints.CenterPtX = 0.5142857!
        Me.cmdOtro.FocalPoints.CenterPtY = 0.368421!
        Me.cmdOtro.FocalPoints.FocusPtX = 0.0!
        Me.cmdOtro.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdOtro.FocusPtTracker = DesignerRectTracker6
        Me.cmdOtro.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.cmdOtro.ForeColor = System.Drawing.Color.Black
        Me.cmdOtro.Image = CType(resources.GetObject("cmdOtro.Image"), System.Drawing.Image)
        Me.cmdOtro.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdOtro.ImageIndex = 0
        Me.cmdOtro.Imagelist = Nothing
        Me.cmdOtro.ImageSize = New System.Drawing.Size(32, 32)
        Me.cmdOtro.Location = New System.Drawing.Point(335, 8)
        Me.cmdOtro.Name = "cmdOtro"
        Me.cmdOtro.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.cmdOtro.SideImage = Nothing
        Me.cmdOtro.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOtro.SideImageSize = New System.Drawing.Size(48, 48)
        Me.cmdOtro.Size = New System.Drawing.Size(70, 57)
        Me.cmdOtro.TabIndex = 13
        Me.cmdOtro.TabStop = False
        Me.cmdOtro.Text = "Otros[F5]"
        Me.cmdOtro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdOtro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdOtro.TextMargin = New System.Windows.Forms.Padding(2)
        Me.cmdOtro.TextShadow = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdOtro.TextShadowShow = False
        Me.cmdOtro.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.cmdOtro.UseMnemonic = True
        '
        'cmdCheque
        '
        Me.cmdCheque.AutoLock = False
        Me.cmdCheque.BorderColor = System.Drawing.Color.White
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdCheque.CenterPtTracker = DesignerRectTracker7
        CBlendItems4.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))}
        CBlendItems4.iPoint = New Single() {0.0!, 1.0!}
        Me.cmdCheque.ColorFillBlend = CBlendItems4
        Me.cmdCheque.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.cmdCheque.Corners.All = CType(10, Short)
        Me.cmdCheque.Corners.LowerLeft = CType(10, Short)
        Me.cmdCheque.Corners.LowerRight = CType(10, Short)
        Me.cmdCheque.Corners.UpperLeft = CType(10, Short)
        Me.cmdCheque.Corners.UpperRight = CType(10, Short)
        Me.cmdCheque.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientPath
        Me.cmdCheque.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdCheque.FocalPoints.CenterPtX = 0.5!
        Me.cmdCheque.FocalPoints.CenterPtY = 0.3571429!
        Me.cmdCheque.FocalPoints.FocusPtX = 0.0!
        Me.cmdCheque.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdCheque.FocusPtTracker = DesignerRectTracker8
        Me.cmdCheque.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.cmdCheque.ForeColor = System.Drawing.Color.Black
        Me.cmdCheque.Image = CType(resources.GetObject("cmdCheque.Image"), System.Drawing.Image)
        Me.cmdCheque.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCheque.ImageIndex = 0
        Me.cmdCheque.Imagelist = Nothing
        Me.cmdCheque.ImageSize = New System.Drawing.Size(32, 32)
        Me.cmdCheque.Location = New System.Drawing.Point(183, 8)
        Me.cmdCheque.Name = "cmdCheque"
        Me.cmdCheque.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.cmdCheque.SideImage = Nothing
        Me.cmdCheque.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCheque.SideImageSize = New System.Drawing.Size(48, 48)
        Me.cmdCheque.Size = New System.Drawing.Size(70, 57)
        Me.cmdCheque.TabIndex = 12
        Me.cmdCheque.TabStop = False
        Me.cmdCheque.Text = "Cheque[F3]"
        Me.cmdCheque.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdCheque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdCheque.TextMargin = New System.Windows.Forms.Padding(2)
        Me.cmdCheque.TextShadow = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdCheque.TextShadowShow = False
        Me.cmdCheque.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.cmdCheque.UseMnemonic = True
        '
        'cmdTarjeta
        '
        Me.cmdTarjeta.AutoLock = False
        Me.cmdTarjeta.BorderColor = System.Drawing.Color.White
        DesignerRectTracker9.IsActive = False
        DesignerRectTracker9.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker9.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdTarjeta.CenterPtTracker = DesignerRectTracker9
        CBlendItems5.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))}
        CBlendItems5.iPoint = New Single() {0.0!, 1.0!}
        Me.cmdTarjeta.ColorFillBlend = CBlendItems5
        Me.cmdTarjeta.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.cmdTarjeta.Corners.All = CType(10, Short)
        Me.cmdTarjeta.Corners.LowerLeft = CType(10, Short)
        Me.cmdTarjeta.Corners.LowerRight = CType(10, Short)
        Me.cmdTarjeta.Corners.UpperLeft = CType(10, Short)
        Me.cmdTarjeta.Corners.UpperRight = CType(10, Short)
        Me.cmdTarjeta.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientPath
        Me.cmdTarjeta.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdTarjeta.FocalPoints.CenterPtX = 1.0!
        Me.cmdTarjeta.FocalPoints.CenterPtY = 0.0!
        Me.cmdTarjeta.FocalPoints.FocusPtX = 0.0!
        Me.cmdTarjeta.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker10.IsActive = False
        DesignerRectTracker10.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker10.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdTarjeta.FocusPtTracker = DesignerRectTracker10
        Me.cmdTarjeta.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.cmdTarjeta.ForeColor = System.Drawing.Color.Black
        Me.cmdTarjeta.Image = CType(resources.GetObject("cmdTarjeta.Image"), System.Drawing.Image)
        Me.cmdTarjeta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdTarjeta.ImageIndex = 0
        Me.cmdTarjeta.Imagelist = Nothing
        Me.cmdTarjeta.ImageSize = New System.Drawing.Size(32, 32)
        Me.cmdTarjeta.Location = New System.Drawing.Point(107, 8)
        Me.cmdTarjeta.Name = "cmdTarjeta"
        Me.cmdTarjeta.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.cmdTarjeta.SideImage = Nothing
        Me.cmdTarjeta.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTarjeta.SideImageSize = New System.Drawing.Size(48, 48)
        Me.cmdTarjeta.Size = New System.Drawing.Size(70, 57)
        Me.cmdTarjeta.TabIndex = 11
        Me.cmdTarjeta.TabStop = False
        Me.cmdTarjeta.Text = "Tarjeta[F2]"
        Me.cmdTarjeta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdTarjeta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdTarjeta.TextMargin = New System.Windows.Forms.Padding(2)
        Me.cmdTarjeta.TextShadow = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdTarjeta.TextShadowShow = False
        Me.cmdTarjeta.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.cmdTarjeta.UseMnemonic = True
        '
        'cmdEfectivo
        '
        Me.cmdEfectivo.AutoLock = False
        Me.cmdEfectivo.BorderColor = System.Drawing.Color.White
        DesignerRectTracker11.IsActive = False
        DesignerRectTracker11.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker11.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdEfectivo.CenterPtTracker = DesignerRectTracker11
        CBlendItems6.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))}
        CBlendItems6.iPoint = New Single() {0.0!, 1.0!}
        Me.cmdEfectivo.ColorFillBlend = CBlendItems6
        Me.cmdEfectivo.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.cmdEfectivo.Corners.All = CType(10, Short)
        Me.cmdEfectivo.Corners.LowerLeft = CType(10, Short)
        Me.cmdEfectivo.Corners.LowerRight = CType(10, Short)
        Me.cmdEfectivo.Corners.UpperLeft = CType(10, Short)
        Me.cmdEfectivo.Corners.UpperRight = CType(10, Short)
        Me.cmdEfectivo.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientPath
        Me.cmdEfectivo.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdEfectivo.FocalPoints.CenterPtX = 0.4857143!
        Me.cmdEfectivo.FocalPoints.CenterPtY = 0.2280702!
        Me.cmdEfectivo.FocalPoints.FocusPtX = 0.0!
        Me.cmdEfectivo.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker12.IsActive = False
        DesignerRectTracker12.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker12.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdEfectivo.FocusPtTracker = DesignerRectTracker12
        Me.cmdEfectivo.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.cmdEfectivo.ForeColor = System.Drawing.Color.Black
        Me.cmdEfectivo.Image = CType(resources.GetObject("cmdEfectivo.Image"), System.Drawing.Image)
        Me.cmdEfectivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEfectivo.ImageIndex = 0
        Me.cmdEfectivo.Imagelist = Nothing
        Me.cmdEfectivo.ImageSize = New System.Drawing.Size(32, 32)
        Me.cmdEfectivo.Location = New System.Drawing.Point(31, 8)
        Me.cmdEfectivo.Name = "cmdEfectivo"
        Me.cmdEfectivo.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.cmdEfectivo.SideImage = Nothing
        Me.cmdEfectivo.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEfectivo.SideImageSize = New System.Drawing.Size(48, 48)
        Me.cmdEfectivo.Size = New System.Drawing.Size(70, 57)
        Me.cmdEfectivo.TabIndex = 10
        Me.cmdEfectivo.TabStop = False
        Me.cmdEfectivo.Text = "Efectivo[F1]"
        Me.cmdEfectivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdEfectivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdEfectivo.TextMargin = New System.Windows.Forms.Padding(2)
        Me.cmdEfectivo.TextShadow = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdEfectivo.TextShadowShow = False
        Me.cmdEfectivo.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.cmdEfectivo.UseMnemonic = True
        '
        'lblDetalle
        '
        Me.lblDetalle.AutoSize = True
        Me.lblDetalle.Location = New System.Drawing.Point(61, 129)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(40, 13)
        Me.lblDetalle.TabIndex = 7
        Me.lblDetalle.Text = "Detalle"
        '
        'txtReferencia
        '
        Me.txtReferencia.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtReferencia.Digits = True
        Me.txtReferencia.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtReferencia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtReferencia.Location = New System.Drawing.Point(307, 102)
        Me.txtReferencia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtReferencia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(100, 20)
        Me.txtReferencia.TabIndex = 5
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(249, 105)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(59, 13)
        Me.CiLabel2.TabIndex = 6
        Me.CiLabel2.Text = "Referencia"
        '
        'cboFormasPago
        '
        Me.cboFormasPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormasPago.FormattingEnabled = True
        Me.cboFormasPago.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboFormasPago.ItemsTable = Nothing
        Me.cboFormasPago.Location = New System.Drawing.Point(113, 72)
        Me.cboFormasPago.Name = "cboFormasPago"
        Me.cboFormasPago.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboFormasPago.Size = New System.Drawing.Size(292, 21)
        Me.cboFormasPago.TabIndex = 0
        Me.cboFormasPago.UIName = Nothing
        Me.cboFormasPago.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(307, 447)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(107, 25)
        Me.btnCancelar.TabIndex = 26
        Me.btnCancelar.Text = "Cancelar[Esc]"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 2
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(118, 447)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(101, 25)
        Me.btnAceptar.TabIndex = 25
        Me.btnAceptar.Text = "Aceptar[F12]"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cmdBuscarArt
        '
        Me.cmdBuscarArt.AutoLock = False
        Me.cmdBuscarArt.BackColor = System.Drawing.Color.White
        Me.cmdBuscarArt.BorderColor = System.Drawing.Color.Olive
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdBuscarArt.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.cmdBuscarArt.ColorFillBlend = CBlendItems1
        Me.cmdBuscarArt.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.cmdBuscarArt.Corners.All = CType(10, Short)
        Me.cmdBuscarArt.Corners.LowerLeft = CType(10, Short)
        Me.cmdBuscarArt.Corners.LowerRight = CType(10, Short)
        Me.cmdBuscarArt.Corners.UpperLeft = CType(10, Short)
        Me.cmdBuscarArt.Corners.UpperRight = CType(10, Short)
        Me.cmdBuscarArt.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientPath
        Me.cmdBuscarArt.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdBuscarArt.FocalPoints.CenterPtX = 1.0!
        Me.cmdBuscarArt.FocalPoints.CenterPtY = 0.5675676!
        Me.cmdBuscarArt.FocalPoints.FocusPtX = 0.0!
        Me.cmdBuscarArt.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdBuscarArt.FocusPtTracker = DesignerRectTracker2
        Me.cmdBuscarArt.Font = New System.Drawing.Font("Arial Narrow", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscarArt.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdBuscarArt.Image = CType(resources.GetObject("cmdBuscarArt.Image"), System.Drawing.Image)
        Me.cmdBuscarArt.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdBuscarArt.ImageIndex = 0
        Me.cmdBuscarArt.Imagelist = Nothing
        Me.cmdBuscarArt.ImageSize = New System.Drawing.Size(32, 32)
        Me.cmdBuscarArt.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cmdBuscarArt.Location = New System.Drawing.Point(201, 95)
        Me.cmdBuscarArt.Name = "cmdBuscarArt"
        Me.cmdBuscarArt.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.cmdBuscarArt.SideImage = Nothing
        Me.cmdBuscarArt.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBuscarArt.SideImageSize = New System.Drawing.Size(48, 48)
        Me.cmdBuscarArt.Size = New System.Drawing.Size(46, 33)
        Me.cmdBuscarArt.TabIndex = 15
        Me.cmdBuscarArt.Text = ""
        Me.cmdBuscarArt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdBuscarArt.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.cmdBuscarArt.TextMargin = New System.Windows.Forms.Padding(2)
        Me.cmdBuscarArt.TextShadow = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdBuscarArt.TextShadowShow = False
        Me.cmdBuscarArt.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.cmdBuscarArt.UseMnemonic = True
        '
        'CobranzaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(446, 477)
        Me.ControlBox = False
        Me.Controls.Add(Me.AlphaGradientPanel2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.AlphaGradientPanel1)
        Me.Controls.Add(Me.pnlUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.Name = "CobranzaForm"
        Me.ShowInTaskbar = False
        CType(Me.grdFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUsuario.ResumeLayout(False)
        Me.pnlUsuario.PerformLayout()
        Me.AlphaGradientPanel2.ResumeLayout(False)
        Me.AlphaGradientPanel1.ResumeLayout(False)
        Me.AlphaGradientPanel1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboFormasPago As Azteca.Windows.Ventas.FormasPagoComboBox
    Friend WithEvents lblFormasPago As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCantidad As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblCantidad As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdFormaPago As Azteca.Windows.Controls.CIDataGridView
    Friend WithEvents pnlUsuario As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents AlphaGradientPanel1 As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha3 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents lblCambio As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCambioTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblPagado As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblPagoTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotal As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotalTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtReferencia As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents AlphaGradientPanel2 As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblDetalle As Azteca.Windows.Controls.CILabel
    Friend WithEvents cmdOtro As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents cmdCheque As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents cmdTarjeta As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents cmdEfectivo As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents cmdValeDesp As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents colIdFormaPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFormaPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents cmdBuscarArt As Azteca.Windows.Controls.ButtonPlus
End Class
