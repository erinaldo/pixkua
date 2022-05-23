<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaccionesInventarioForm
    Inherits Azteca.Windows.Forms.Forma

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rdbEmisionDev = New System.Windows.Forms.RadioButton()
        Me.rdbReciboDev = New System.Windows.Forms.RadioButton()
        Me.rdbEmision = New System.Windows.Forms.RadioButton()
        Me.rdbRecepcionOT = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.tbtnGuardar = New C1.Win.C1Command.C1Command()
        Me.tlbGuardar = New C1.Win.C1Command.C1Command()
        Me.tcmdCancelar = New C1.Win.C1Command.C1Command()
        Me.tlbProcesos = New C1.Win.C1Command.C1ToolBar()
        Me.tlbTop = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink8 = New C1.Win.C1Command.C1CommandLink()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTipoTransaccion = New Azteca.Windows.Controls.CITextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAlmacen = New Azteca.Windows.Controls.CITextBox()
        Me.txtCantidad = New Azteca.Windows.Controls.CITextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New Azteca.Windows.Controls.CITextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCantidadDisponible = New Azteca.Windows.Controls.CITextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCantidadTransito = New Azteca.Windows.Controls.CITextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCantidadRecibida = New Azteca.Windows.Controls.CITextBox()
        Me.lblCantidadRecibida = New System.Windows.Forms.Label()
        Me.txtCantidadRequerido = New Azteca.Windows.Controls.CITextBox()
        Me.lblCantidadRequerida = New System.Windows.Forms.Label()
        Me.cboInsumos = New Azteca.Windows.Produccion.InsumosLiberarComboBox(Me.components)
        Me.selOrdenTrabajo = New Azteca.Windows.Produccion.OrdenTrabajoSelector()
        Me.SelArticulo = New Azteca.Windows.Inventario.ArticuloStockSelector()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.rdbEmisionDev)
        Me.GroupBox1.Controls.Add(Me.rdbReciboDev)
        Me.GroupBox1.Controls.Add(Me.rdbEmision)
        Me.GroupBox1.Controls.Add(Me.rdbRecepcionOT)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 153)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.navigation_left_red
        Me.PictureBox3.Location = New System.Drawing.Point(9, 116)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.navigation_right_green
        Me.PictureBox4.Location = New System.Drawing.Point(6, 45)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.navigation_left_red
        Me.PictureBox2.Location = New System.Drawing.Point(9, 84)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.navigation_right_green
        Me.PictureBox1.Location = New System.Drawing.Point(6, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'rdbEmisionDev
        '
        Me.rdbEmisionDev.AutoSize = True
        Me.rdbEmisionDev.Location = New System.Drawing.Point(41, 119)
        Me.rdbEmisionDev.Name = "rdbEmisionDev"
        Me.rdbEmisionDev.Size = New System.Drawing.Size(126, 17)
        Me.rdbEmisionDev.TabIndex = 3
        Me.rdbEmisionDev.Text = "Emisión / Devolución"
        Me.rdbEmisionDev.UseVisualStyleBackColor = True
        '
        'rdbReciboDev
        '
        Me.rdbReciboDev.AutoSize = True
        Me.rdbReciboDev.Location = New System.Drawing.Point(41, 86)
        Me.rdbReciboDev.Name = "rdbReciboDev"
        Me.rdbReciboDev.Size = New System.Drawing.Size(124, 17)
        Me.rdbReciboDev.TabIndex = 2
        Me.rdbReciboDev.Text = "Recibo / Devolución"
        Me.rdbReciboDev.UseVisualStyleBackColor = True
        '
        'rdbEmision
        '
        Me.rdbEmision.AutoSize = True
        Me.rdbEmision.Location = New System.Drawing.Point(41, 50)
        Me.rdbEmision.Name = "rdbEmision"
        Me.rdbEmision.Size = New System.Drawing.Size(61, 17)
        Me.rdbEmision.TabIndex = 1
        Me.rdbEmision.Text = "Emisión"
        Me.rdbEmision.UseVisualStyleBackColor = True
        '
        'rdbRecepcionOT
        '
        Me.rdbRecepcionOT.AutoSize = True
        Me.rdbRecepcionOT.Checked = True
        Me.rdbRecepcionOT.Location = New System.Drawing.Point(41, 16)
        Me.rdbRecepcionOT.Name = "rdbRecepcionOT"
        Me.rdbRecepcionOT.Size = New System.Drawing.Size(113, 17)
        Me.rdbRecepcionOT.TabIndex = 0
        Me.rdbRecepcionOT.TabStop = True
        Me.rdbRecepcionOT.Text = "Recepción por OT"
        Me.rdbRecepcionOT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Orden de Trabajo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Articulo Stock"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.tbtnGuardar)
        Me.C1CommandHolder1.Commands.Add(Me.tlbGuardar)
        Me.C1CommandHolder1.Commands.Add(Me.tcmdCancelar)
        Me.C1CommandHolder1.Owner = Me
        '
        'tbtnGuardar
        '
        Me.tbtnGuardar.Name = "tbtnGuardar"
        Me.tbtnGuardar.ShortcutText = ""
        Me.tbtnGuardar.Text = "Consultar"
        '
        'tlbGuardar
        '
        Me.tlbGuardar.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.Save32
        Me.tlbGuardar.Name = "tlbGuardar"
        Me.tlbGuardar.ShortcutText = ""
        Me.tlbGuardar.Text = "Consultar"
        '
        'tcmdCancelar
        '
        Me.tcmdCancelar.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.Close_32
        Me.tcmdCancelar.Name = "tcmdCancelar"
        Me.tcmdCancelar.ShortcutText = ""
        Me.tcmdCancelar.Text = "Cerrar"
        '
        'tlbProcesos
        '
        Me.tlbProcesos.AccessibleName = "Tool Bar"
        Me.tlbProcesos.AutoSize = False
        Me.tlbProcesos.ButtonLookEnforceHorz = True
        Me.tlbProcesos.ButtonLookHorz = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.tlbProcesos.CommandHolder = Me.C1CommandHolder1
        Me.tlbProcesos.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.tlbTop, Me.C1CommandLink8})
        Me.tlbProcesos.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbProcesos.Location = New System.Drawing.Point(0, 0)
        Me.tlbProcesos.MinButtonSize = 32
        Me.tlbProcesos.Movable = False
        Me.tlbProcesos.Name = "tlbProcesos"
        Me.tlbProcesos.Size = New System.Drawing.Size(509, 33)
        Me.tlbProcesos.Text = "C1ToolBar3"
        Me.tlbProcesos.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbProcesos.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'tlbTop
        '
        Me.tlbTop.Command = Me.tlbGuardar
        Me.tlbTop.Text = "Guardar"
        '
        'C1CommandLink8
        '
        Me.C1CommandLink8.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Image
        Me.C1CommandLink8.Command = Me.tcmdCancelar
        Me.C1CommandLink8.Delimiter = True
        Me.C1CommandLink8.SortOrder = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTipoTransaccion)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtAlmacen)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(218, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 153)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'txtTipoTransaccion
        '
        Me.txtTipoTransaccion.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTipoTransaccion.Location = New System.Drawing.Point(66, 70)
        Me.txtTipoTransaccion.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoTransaccion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTipoTransaccion.Name = "txtTipoTransaccion"
        Me.txtTipoTransaccion.ReadOnly = True
        Me.txtTipoTransaccion.Size = New System.Drawing.Size(209, 20)
        Me.txtTipoTransaccion.TabIndex = 81
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Tipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Almacen"
        '
        'txtAlmacen
        '
        Me.txtAlmacen.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtAlmacen.Location = New System.Drawing.Point(66, 42)
        Me.txtAlmacen.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAlmacen.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.ReadOnly = True
        Me.txtAlmacen.Size = New System.Drawing.Size(209, 20)
        Me.txtAlmacen.TabIndex = 41
        '
        'txtCantidad
        '
        Me.txtCantidad.Digits = True
        Me.txtCantidad.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCantidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantidad.Location = New System.Drawing.Point(66, 13)
        Me.txtCantidad.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(61, 20)
        Me.txtCantidad.TabIndex = 78
        Me.txtCantidad.Text = "0"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDescripcion)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(269, 51)
        Me.GroupBox3.TabIndex = 77
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtDescripcion.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDescripcion.Location = New System.Drawing.Point(8, 19)
        Me.txtDescripcion.MaxLength = 128
        Me.txtDescripcion.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescripcion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(255, 27)
        Me.txtDescripcion.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cantidad"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtCantidadDisponible)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtCantidadTransito)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtCantidadRecibida)
        Me.GroupBox4.Controls.Add(Me.lblCantidadRecibida)
        Me.GroupBox4.Controls.Add(Me.txtCantidadRequerido)
        Me.GroupBox4.Controls.Add(Me.lblCantidadRequerida)
        Me.GroupBox4.Location = New System.Drawing.Point(326, 39)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(175, 121)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        '
        'txtCantidadDisponible
        '
        Me.txtCantidadDisponible.Digits = True
        Me.txtCantidadDisponible.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCantidadDisponible.Format = "n2"
        Me.txtCantidadDisponible.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantidadDisponible.Location = New System.Drawing.Point(91, 32)
        Me.txtCantidadDisponible.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidadDisponible.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantidadDisponible.Name = "txtCantidadDisponible"
        Me.txtCantidadDisponible.ReadOnly = True
        Me.txtCantidadDisponible.Size = New System.Drawing.Size(76, 20)
        Me.txtCantidadDisponible.TabIndex = 86
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(88, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Disponible"
        '
        'txtCantidadTransito
        '
        Me.txtCantidadTransito.Digits = True
        Me.txtCantidadTransito.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCantidadTransito.Format = "n2"
        Me.txtCantidadTransito.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantidadTransito.Location = New System.Drawing.Point(9, 31)
        Me.txtCantidadTransito.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidadTransito.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantidadTransito.Name = "txtCantidadTransito"
        Me.txtCantidadTransito.ReadOnly = True
        Me.txtCantidadTransito.Size = New System.Drawing.Size(76, 20)
        Me.txtCantidadTransito.TabIndex = 84
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "En Transito"
        '
        'txtCantidadRecibida
        '
        Me.txtCantidadRecibida.Digits = True
        Me.txtCantidadRecibida.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCantidadRecibida.Format = "n2"
        Me.txtCantidadRecibida.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantidadRecibida.Location = New System.Drawing.Point(91, 87)
        Me.txtCantidadRecibida.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidadRecibida.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantidadRecibida.Name = "txtCantidadRecibida"
        Me.txtCantidadRecibida.ReadOnly = True
        Me.txtCantidadRecibida.Size = New System.Drawing.Size(76, 20)
        Me.txtCantidadRecibida.TabIndex = 82
        '
        'lblCantidadRecibida
        '
        Me.lblCantidadRecibida.AutoSize = True
        Me.lblCantidadRecibida.Location = New System.Drawing.Point(88, 71)
        Me.lblCantidadRecibida.Name = "lblCantidadRecibida"
        Me.lblCantidadRecibida.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidadRecibida.TabIndex = 81
        Me.lblCantidadRecibida.Text = "Recibido"
        '
        'txtCantidadRequerido
        '
        Me.txtCantidadRequerido.Digits = True
        Me.txtCantidadRequerido.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtCantidadRequerido.Format = "n2"
        Me.txtCantidadRequerido.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantidadRequerido.Location = New System.Drawing.Point(9, 87)
        Me.txtCantidadRequerido.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidadRequerido.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantidadRequerido.Name = "txtCantidadRequerido"
        Me.txtCantidadRequerido.ReadOnly = True
        Me.txtCantidadRequerido.Size = New System.Drawing.Size(76, 20)
        Me.txtCantidadRequerido.TabIndex = 80
        '
        'lblCantidadRequerida
        '
        Me.lblCantidadRequerida.AutoSize = True
        Me.lblCantidadRequerida.Location = New System.Drawing.Point(6, 71)
        Me.lblCantidadRequerida.Name = "lblCantidadRequerida"
        Me.lblCantidadRequerida.Size = New System.Drawing.Size(50, 13)
        Me.lblCantidadRequerida.TabIndex = 80
        Me.lblCantidadRequerida.Text = "Deseada"
        '
        'cboInsumos
        '
        Me.cboInsumos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInsumos.FormattingEnabled = True
        Me.cboInsumos.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboInsumos.ItemsTable = Nothing
        Me.cboInsumos.Location = New System.Drawing.Point(14, 127)
        Me.cboInsumos.Name = "cboInsumos"
        Me.cboInsumos.Size = New System.Drawing.Size(264, 21)
        Me.cboInsumos.TabIndex = 72
        Me.cboInsumos.UIName = Nothing
        '
        'selOrdenTrabajo
        '
        Me.selOrdenTrabajo.AnySite = False
        Me.selOrdenTrabajo.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selOrdenTrabajo.EditorAssembly = "Azteca.ProduccionWin"
        Me.selOrdenTrabajo.EditorClass = "Azteca.Windows.Produccion.OrdenesTrabajoForm"
        Me.selOrdenTrabajo.EditorTitle = "Editar Orden de Trabajo..."
        Me.selOrdenTrabajo.Key = 0
        Me.selOrdenTrabajo.Linked = False
        Me.selOrdenTrabajo.Location = New System.Drawing.Point(12, 73)
        Me.selOrdenTrabajo.Name = "selOrdenTrabajo"
        Me.selOrdenTrabajo.Size = New System.Drawing.Size(231, 23)
        Me.selOrdenTrabajo.TabIndex = 2
        '
        'SelArticulo
        '
        Me.SelArticulo.AnySite = False
        Me.SelArticulo.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.SelArticulo.EditorAssembly = "Azteca.InventarioWin"
        Me.SelArticulo.EditorClass = "Azteca.Windows.Inventario.ArticulosStockForm"
        Me.SelArticulo.EditorTitle = "Editar Articulos de inventario..."
        Me.SelArticulo.Enabled = False
        Me.SelArticulo.Key = 0
        Me.SelArticulo.Linked = False
        Me.SelArticulo.Location = New System.Drawing.Point(12, 127)
        Me.SelArticulo.Name = "SelArticulo"
        Me.SelArticulo.Size = New System.Drawing.Size(231, 23)
        Me.SelArticulo.TabIndex = 1
        '
        'TransaccionesInventarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 356)
        Me.Controls.Add(Me.cboInsumos)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tlbProcesos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.selOrdenTrabajo)
        Me.Controls.Add(Me.SelArticulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "TransaccionesInventarioForm"
        Me.Text = "TransaccionesInventarioForm"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SelArticulo, 0)
        Me.Controls.SetChildIndex(Me.selOrdenTrabajo, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.tlbProcesos, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.cboInsumos, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbEmisionDev As System.Windows.Forms.RadioButton
    Friend WithEvents rdbReciboDev As System.Windows.Forms.RadioButton
    Friend WithEvents rdbEmision As System.Windows.Forms.RadioButton
    Friend WithEvents rdbRecepcionOT As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents selOrdenTrabajo As Azteca.Windows.Produccion.OrdenTrabajoSelector
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents tbtnGuardar As C1.Win.C1Command.C1Command
    Friend WithEvents tlbGuardar As C1.Win.C1Command.C1Command
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tlbProcesos As C1.Win.C1Command.C1ToolBar
    Friend WithEvents tlbTop As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink8 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion As Azteca.Windows.Controls.CITextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCantidad As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCantidadDisponible As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadTransito As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadRecibida As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblCantidadRecibida As System.Windows.Forms.Label
    Friend WithEvents txtCantidadRequerido As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblCantidadRequerida As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAlmacen As Azteca.Windows.Controls.CITextBox
    Friend WithEvents tcmdCancelar As C1.Win.C1Command.C1Command
    Friend WithEvents txtTipoTransaccion As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents SelArticulo As Azteca.Windows.Inventario.ArticuloStockSelector
    Friend WithEvents cboInsumos As Azteca.Windows.Produccion.InsumosLiberarComboBox
End Class
