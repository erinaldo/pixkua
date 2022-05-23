<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UtilitarioCostosForm
    Inherits Azteca.Windows.Forms.BaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UtilitarioCostosForm))
        Me.tlbMenu = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.tlbActualizar = New C1.Win.C1Command.C1Command()
        Me.btnGuardar = New C1.Win.C1Command.C1CommandLink()
        Me.tlbGuardar = New C1.Win.C1Command.C1Command()
        Me.btnCerrar = New C1.Win.C1Command.C1CommandLink()
        Me.tlbCerrar = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.tlbInvertirSeleccion = New C1.Win.C1Command.C1Command()
        Me.btnRecalcular = New C1.Win.C1Command.C1CommandLink()
        Me.tlbRecalcular = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdProcesosCostos = New C1.Win.C1Command.C1ContextMenu()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdProcesarManoObra = New C1.Win.C1Command.C1Command()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkCalcularPorTipo = New System.Windows.Forms.CheckBox()
        Me.rdbFabricados = New System.Windows.Forms.RadioButton()
        Me.rdbComprados = New System.Windows.Forms.RadioButton()
        Me.chkMostrarSoloCambios = New System.Windows.Forms.CheckBox()
        Me.chkMostrarCategorias = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtArticulos = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmDetalleCalculo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DetalleDelCostoMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerDetalleDelServicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerDetalleDeCargaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerDetalleDeCargaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chkTodo = New System.Windows.Forms.CheckBox()
        Me.chkCancelado = New System.Windows.Forms.CheckBox()
        Me.chkCerrado = New System.Windows.Forms.CheckBox()
        Me.chkRetenido = New System.Windows.Forms.CheckBox()
        Me.chkAplicado = New System.Windows.Forms.CheckBox()
        Me.chkGuardado = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbFiltroTodos = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbFiltroComprados = New System.Windows.Forms.RadioButton()
        Me.rdgFiltroFabricados = New System.Windows.Forms.RadioButton()
        Me.chkUsarUltimaRecepcion = New System.Windows.Forms.CheckBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dtArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmDetalleCalculo.SuspendLayout()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlbMenu
        '
        Me.tlbMenu.AccessibleName = "Tool Bar"
        Me.tlbMenu.AutoSize = False
        Me.tlbMenu.Border.Width = 4
        Me.tlbMenu.CommandHolder = Nothing
        Me.tlbMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.btnGuardar, Me.btnCerrar, Me.C1CommandLink2, Me.btnRecalcular, Me.C1CommandLink3})
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.Margin = New System.Windows.Forms.Padding(14, 14, 22, 21)
        Me.tlbMenu.MinButtonSize = 32
        Me.tlbMenu.Movable = False
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(982, 35)
        Me.tlbMenu.Text = "AzToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.Command = Me.tlbActualizar
        Me.C1CommandLink1.Text = "Actualizar"
        Me.C1CommandLink1.ToolTipText = "Actualizar"
        '
        'tlbActualizar
        '
        Me.tlbActualizar.Image = Global.Azteca.Windows.Inventario.My.Resources.Resources.Actualizar_32x32
        Me.tlbActualizar.Name = "tlbActualizar"
        Me.tlbActualizar.ShortcutText = ""
        Me.tlbActualizar.Text = "New Command"
        '
        'btnGuardar
        '
        Me.btnGuardar.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Image
        Me.btnGuardar.Command = Me.tlbGuardar
        Me.btnGuardar.Delimiter = True
        Me.btnGuardar.SortOrder = 1
        Me.btnGuardar.ToolTipText = "Guardar el nuevo costo estandar"
        '
        'tlbGuardar
        '
        Me.tlbGuardar.Image = Global.Azteca.Windows.Inventario.My.Resources.Resources.Save32
        Me.tlbGuardar.Name = "tlbGuardar"
        Me.tlbGuardar.ShortcutText = ""
        Me.tlbGuardar.Text = "Guardar"
        Me.tlbGuardar.ToolTipText = "Guardar"
        '
        'btnCerrar
        '
        Me.btnCerrar.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Image
        Me.btnCerrar.Command = Me.tlbCerrar
        Me.btnCerrar.SortOrder = 2
        Me.btnCerrar.ToolTipText = "Cerrar"
        '
        'tlbCerrar
        '
        Me.tlbCerrar.Image = Global.Azteca.Windows.Inventario.My.Resources.Resources.Close_32
        Me.tlbCerrar.Name = "tlbCerrar"
        Me.tlbCerrar.ShortcutText = ""
        Me.tlbCerrar.ToolTipText = "Cerrar"
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.Command = Me.tlbInvertirSeleccion
        Me.C1CommandLink2.Delimiter = True
        Me.C1CommandLink2.SortOrder = 3
        Me.C1CommandLink2.ToolTipText = "Invertir Selección"
        '
        'tlbInvertirSeleccion
        '
        Me.tlbInvertirSeleccion.Image = Global.Azteca.Windows.Inventario.My.Resources.Resources.SeleccionarTodo_24x24
        Me.tlbInvertirSeleccion.Name = "tlbInvertirSeleccion"
        Me.tlbInvertirSeleccion.ShortcutText = ""
        Me.tlbInvertirSeleccion.Text = "Invertir Selección"
        '
        'btnRecalcular
        '
        Me.btnRecalcular.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Image
        Me.btnRecalcular.Command = Me.tlbRecalcular
        Me.btnRecalcular.SortOrder = 4
        Me.btnRecalcular.ToolTipText = "Recalcular Costos"
        '
        'tlbRecalcular
        '
        Me.tlbRecalcular.Image = Global.Azteca.Windows.Inventario.My.Resources.Resources.calculator_48x48
        Me.tlbRecalcular.Name = "tlbRecalcular"
        Me.tlbRecalcular.ShortcutText = ""
        Me.tlbRecalcular.Text = "New Command"
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.cmdProcesosCostos
        Me.C1CommandLink3.Delimiter = True
        Me.C1CommandLink3.SortOrder = 5
        '
        'cmdProcesosCostos
        '
        Me.cmdProcesosCostos.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink4})
        Me.cmdProcesosCostos.HideNonRecentLinks = False
        Me.cmdProcesosCostos.Image = Global.Azteca.Windows.Inventario.My.Resources.Resources.CerrarCorteInventario_32
        Me.cmdProcesosCostos.Name = "cmdProcesosCostos"
        Me.cmdProcesosCostos.ShortcutText = ""
        Me.cmdProcesosCostos.ShowToolTips = True
        Me.cmdProcesosCostos.Text = "Procesar Costos"
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.Command = Me.cmdProcesarManoObra
        Me.C1CommandLink4.Text = "Mano de Obra..."
        Me.C1CommandLink4.ToolTipText = "Procesar costo de mano de obra"
        '
        'cmdProcesarManoObra
        '
        Me.cmdProcesarManoObra.Name = "cmdProcesarManoObra"
        Me.cmdProcesarManoObra.ShortcutText = ""
        Me.cmdProcesarManoObra.Text = "New Command"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.tlbGuardar)
        Me.C1CommandHolder1.Commands.Add(Me.tlbCerrar)
        Me.C1CommandHolder1.Commands.Add(Me.tlbRecalcular)
        Me.C1CommandHolder1.Commands.Add(Me.tlbActualizar)
        Me.C1CommandHolder1.Commands.Add(Me.tlbInvertirSeleccion)
        Me.C1CommandHolder1.Commands.Add(Me.cmdProcesosCostos)
        Me.C1CommandHolder1.Commands.Add(Me.cmdProcesarManoObra)
        Me.C1CommandHolder1.Owner = Me
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.chkMostrarSoloCambios)
        Me.Panel1.Controls.Add(Me.chkMostrarCategorias)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(982, 77)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkCalcularPorTipo)
        Me.GroupBox3.Controls.Add(Me.rdbFabricados)
        Me.GroupBox3.Controls.Add(Me.rdbComprados)
        Me.GroupBox3.Location = New System.Drawing.Point(249, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 68)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cambiar tipo de calculo"
        '
        'chkCalcularPorTipo
        '
        Me.chkCalcularPorTipo.AutoSize = True
        Me.chkCalcularPorTipo.Location = New System.Drawing.Point(23, 21)
        Me.chkCalcularPorTipo.Name = "chkCalcularPorTipo"
        Me.chkCalcularPorTipo.Size = New System.Drawing.Size(220, 17)
        Me.chkCalcularPorTipo.TabIndex = 6
        Me.chkCalcularPorTipo.Text = "Calculo basado por un tipo de articulo fijo"
        Me.chkCalcularPorTipo.UseVisualStyleBackColor = True
        '
        'rdbFabricados
        '
        Me.rdbFabricados.AutoSize = True
        Me.rdbFabricados.Enabled = False
        Me.rdbFabricados.Location = New System.Drawing.Point(126, 49)
        Me.rdbFabricados.Name = "rdbFabricados"
        Me.rdbFabricados.Size = New System.Drawing.Size(72, 17)
        Me.rdbFabricados.TabIndex = 7
        Me.rdbFabricados.Text = "Fabricado"
        Me.rdbFabricados.UseVisualStyleBackColor = True
        '
        'rdbComprados
        '
        Me.rdbComprados.AutoSize = True
        Me.rdbComprados.Checked = True
        Me.rdbComprados.Enabled = False
        Me.rdbComprados.Location = New System.Drawing.Point(23, 49)
        Me.rdbComprados.Name = "rdbComprados"
        Me.rdbComprados.Size = New System.Drawing.Size(73, 17)
        Me.rdbComprados.TabIndex = 5
        Me.rdbComprados.TabStop = True
        Me.rdbComprados.Text = "Comprado"
        Me.rdbComprados.UseVisualStyleBackColor = True
        '
        'chkMostrarSoloCambios
        '
        Me.chkMostrarSoloCambios.AutoSize = True
        Me.chkMostrarSoloCambios.Location = New System.Drawing.Point(12, 41)
        Me.chkMostrarSoloCambios.Name = "chkMostrarSoloCambios"
        Me.chkMostrarSoloCambios.Size = New System.Drawing.Size(125, 17)
        Me.chkMostrarSoloCambios.TabIndex = 4
        Me.chkMostrarSoloCambios.Text = "Mostrar solo cambios"
        Me.chkMostrarSoloCambios.UseVisualStyleBackColor = True
        '
        'chkMostrarCategorias
        '
        Me.chkMostrarCategorias.AutoSize = True
        Me.chkMostrarCategorias.Location = New System.Drawing.Point(12, 15)
        Me.chkMostrarCategorias.Name = "chkMostrarCategorias"
        Me.chkMostrarCategorias.Size = New System.Drawing.Size(175, 17)
        Me.chkMostrarCategorias.TabIndex = 1
        Me.chkMostrarCategorias.Text = "Mostrar las categorias del costo"
        Me.chkMostrarCategorias.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtArticulos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(982, 351)
        Me.Panel2.TabIndex = 3
        Me.Panel2.TabStop = True
        '
        'dtArticulos
        '
        Me.dtArticulos.ContextMenuStrip = Me.cmDetalleCalculo
        Me.dtArticulos.DataSource = Me.bsArticulos
        Me.dtArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtArticulos.FilterBar = True
        Me.dtArticulos.Images.Add(CType(resources.GetObject("dtArticulos.Images"), System.Drawing.Image))
        Me.dtArticulos.Location = New System.Drawing.Point(0, 0)
        Me.dtArticulos.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.dtArticulos.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.Simple
        Me.dtArticulos.Name = "dtArticulos"
        Me.dtArticulos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.dtArticulos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.dtArticulos.PreviewInfo.ZoomFactor = 75.0R
        Me.dtArticulos.PrintInfo.PageSettings = CType(resources.GetObject("dtArticulos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.dtArticulos.Size = New System.Drawing.Size(982, 351)
        Me.dtArticulos.TabIndex = 0
        Me.dtArticulos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        Me.dtArticulos.PropBag = resources.GetString("dtArticulos.PropBag")
        '
        'cmDetalleCalculo
        '
        Me.cmDetalleCalculo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetalleDelCostoMaterialToolStripMenuItem, Me.VerDetalleDelServicioToolStripMenuItem, Me.VerDetalleDeCargaToolStripMenuItem, Me.VerDetalleDeCargaToolStripMenuItem1})
        Me.cmDetalleCalculo.Name = "cmDetalleCalculo"
        Me.cmDetalleCalculo.Size = New System.Drawing.Size(194, 92)
        '
        'DetalleDelCostoMaterialToolStripMenuItem
        '
        Me.DetalleDelCostoMaterialToolStripMenuItem.Name = "DetalleDelCostoMaterialToolStripMenuItem"
        Me.DetalleDelCostoMaterialToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.DetalleDelCostoMaterialToolStripMenuItem.Text = "Ver detalle del material"
        '
        'VerDetalleDelServicioToolStripMenuItem
        '
        Me.VerDetalleDelServicioToolStripMenuItem.Name = "VerDetalleDelServicioToolStripMenuItem"
        Me.VerDetalleDelServicioToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.VerDetalleDelServicioToolStripMenuItem.Text = "Ver detalle de labor"
        '
        'VerDetalleDeCargaToolStripMenuItem
        '
        Me.VerDetalleDeCargaToolStripMenuItem.Name = "VerDetalleDeCargaToolStripMenuItem"
        Me.VerDetalleDeCargaToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.VerDetalleDeCargaToolStripMenuItem.Text = "Ver detalle del servicio"
        '
        'VerDetalleDeCargaToolStripMenuItem1
        '
        Me.VerDetalleDeCargaToolStripMenuItem1.Name = "VerDetalleDeCargaToolStripMenuItem1"
        Me.VerDetalleDeCargaToolStripMenuItem1.Size = New System.Drawing.Size(193, 22)
        Me.VerDetalleDeCargaToolStripMenuItem1.Text = "Ver detalle de carga"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.chkTodo)
        Me.Panel3.Controls.Add(Me.chkCancelado)
        Me.Panel3.Controls.Add(Me.chkCerrado)
        Me.Panel3.Controls.Add(Me.chkRetenido)
        Me.Panel3.Controls.Add(Me.chkAplicado)
        Me.Panel3.Controls.Add(Me.chkGuardado)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.rdbFiltroTodos)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.rdbFiltroComprados)
        Me.Panel3.Controls.Add(Me.rdgFiltroFabricados)
        Me.Panel3.Controls.Add(Me.chkUsarUltimaRecepcion)
        Me.Panel3.Controls.Add(Me.dtpFechaFin)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.dtpFechaInicio)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 463)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(982, 137)
        Me.Panel3.TabIndex = 4
        '
        'chkTodo
        '
        Me.chkTodo.AutoSize = True
        Me.chkTodo.Location = New System.Drawing.Point(496, 86)
        Me.chkTodo.Name = "chkTodo"
        Me.chkTodo.Size = New System.Drawing.Size(51, 17)
        Me.chkTodo.TabIndex = 19
        Me.chkTodo.Text = "Todo"
        Me.chkTodo.UseVisualStyleBackColor = True
        '
        'chkCancelado
        '
        Me.chkCancelado.AutoSize = True
        Me.chkCancelado.Location = New System.Drawing.Point(496, 58)
        Me.chkCancelado.Name = "chkCancelado"
        Me.chkCancelado.Size = New System.Drawing.Size(77, 17)
        Me.chkCancelado.TabIndex = 18
        Me.chkCancelado.Text = "Cancelado"
        Me.chkCancelado.UseVisualStyleBackColor = True
        '
        'chkCerrado
        '
        Me.chkCerrado.AutoSize = True
        Me.chkCerrado.Location = New System.Drawing.Point(415, 87)
        Me.chkCerrado.Name = "chkCerrado"
        Me.chkCerrado.Size = New System.Drawing.Size(63, 17)
        Me.chkCerrado.TabIndex = 17
        Me.chkCerrado.Text = "Cerrado"
        Me.chkCerrado.UseVisualStyleBackColor = True
        '
        'chkRetenido
        '
        Me.chkRetenido.AutoSize = True
        Me.chkRetenido.Location = New System.Drawing.Point(415, 59)
        Me.chkRetenido.Name = "chkRetenido"
        Me.chkRetenido.Size = New System.Drawing.Size(69, 17)
        Me.chkRetenido.TabIndex = 16
        Me.chkRetenido.Text = "Retenido"
        Me.chkRetenido.UseVisualStyleBackColor = True
        '
        'chkAplicado
        '
        Me.chkAplicado.AutoSize = True
        Me.chkAplicado.Location = New System.Drawing.Point(333, 86)
        Me.chkAplicado.Name = "chkAplicado"
        Me.chkAplicado.Size = New System.Drawing.Size(67, 17)
        Me.chkAplicado.TabIndex = 15
        Me.chkAplicado.Text = "Aplicado"
        Me.chkAplicado.UseVisualStyleBackColor = True
        '
        'chkGuardado
        '
        Me.chkGuardado.AutoSize = True
        Me.chkGuardado.Location = New System.Drawing.Point(333, 58)
        Me.chkGuardado.Name = "chkGuardado"
        Me.chkGuardado.Size = New System.Drawing.Size(73, 17)
        Me.chkGuardado.TabIndex = 14
        Me.chkGuardado.Text = "Guardado"
        Me.chkGuardado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(330, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Considerar los siguientes estatus en documentos"
        '
        'rdbFiltroTodos
        '
        Me.rdbFiltroTodos.AutoSize = True
        Me.rdbFiltroTodos.Location = New System.Drawing.Point(809, 6)
        Me.rdbFiltroTodos.Name = "rdbFiltroTodos"
        Me.rdbFiltroTodos.Size = New System.Drawing.Size(55, 17)
        Me.rdbFiltroTodos.TabIndex = 13
        Me.rdbFiltroTodos.Text = "Todos"
        Me.rdbFiltroTodos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(333, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 2)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'rdbFiltroComprados
        '
        Me.rdbFiltroComprados.AutoSize = True
        Me.rdbFiltroComprados.Checked = True
        Me.rdbFiltroComprados.Location = New System.Drawing.Point(725, 6)
        Me.rdbFiltroComprados.Name = "rdbFiltroComprados"
        Me.rdbFiltroComprados.Size = New System.Drawing.Size(78, 17)
        Me.rdbFiltroComprados.TabIndex = 12
        Me.rdbFiltroComprados.TabStop = True
        Me.rdbFiltroComprados.Text = "Comprados"
        Me.rdbFiltroComprados.UseVisualStyleBackColor = True
        '
        'rdgFiltroFabricados
        '
        Me.rdgFiltroFabricados.AutoSize = True
        Me.rdgFiltroFabricados.Location = New System.Drawing.Point(642, 6)
        Me.rdgFiltroFabricados.Name = "rdgFiltroFabricados"
        Me.rdgFiltroFabricados.Size = New System.Drawing.Size(77, 17)
        Me.rdgFiltroFabricados.TabIndex = 11
        Me.rdgFiltroFabricados.Text = "Fabricados"
        Me.rdgFiltroFabricados.UseVisualStyleBackColor = True
        '
        'chkUsarUltimaRecepcion
        '
        Me.chkUsarUltimaRecepcion.AutoSize = True
        Me.chkUsarUltimaRecepcion.Location = New System.Drawing.Point(85, 113)
        Me.chkUsarUltimaRecepcion.Name = "chkUsarUltimaRecepcion"
        Me.chkUsarUltimaRecepcion.Size = New System.Drawing.Size(488, 17)
        Me.chkUsarUltimaRecepcion.TabIndex = 10
        Me.chkUsarUltimaRecepcion.Text = "Usar la última recepción en caso de no encontrar recepciones en el rango de fecha" & _
            "s especificado"
        Me.chkUsarUltimaRecepcion.UseVisualStyleBackColor = True
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Location = New System.Drawing.Point(85, 81)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaFin.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Fecha Final"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Location = New System.Drawing.Point(85, 55)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaInicio.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fecha Inicial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Opciones de Recepción"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 2)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'UtilitarioCostosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 600)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tlbMenu)
        Me.Name = "UtilitarioCostosForm"
        Me.Text = "Utilitario de Costos"
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmDetalleCalculo.ResumeLayout(False)
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents btnGuardar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnCerrar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnRecalcular As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkMostrarSoloCambios As System.Windows.Forms.CheckBox
    Friend WithEvents chkMostrarCategorias As System.Windows.Forms.CheckBox
    Friend WithEvents chkUsarUltimaRecepcion As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtArticulos As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents bsArticulos As System.Windows.Forms.BindingSource
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents rdbFabricados As System.Windows.Forms.RadioButton
    Friend WithEvents chkCalcularPorTipo As System.Windows.Forms.CheckBox
    Friend WithEvents rdbComprados As System.Windows.Forms.RadioButton
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbFiltroTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFiltroComprados As System.Windows.Forms.RadioButton
    Friend WithEvents rdgFiltroFabricados As System.Windows.Forms.RadioButton
    Friend WithEvents chkTodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkCancelado As System.Windows.Forms.CheckBox
    Friend WithEvents chkCerrado As System.Windows.Forms.CheckBox
    Friend WithEvents chkRetenido As System.Windows.Forms.CheckBox
    Friend WithEvents chkAplicado As System.Windows.Forms.CheckBox
    Friend WithEvents chkGuardado As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents tlbInvertirSeleccion As C1.Win.C1Command.C1Command
    Private WithEvents tlbCerrar As C1.Win.C1Command.C1Command
    Private WithEvents tlbRecalcular As C1.Win.C1Command.C1Command
    Private WithEvents tlbActualizar As C1.Win.C1Command.C1Command
    Friend WithEvents cmDetalleCalculo As System.Windows.Forms.ContextMenuStrip
    Private WithEvents tlbGuardar As C1.Win.C1Command.C1Command
    Friend WithEvents DetalleDelCostoMaterialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerDetalleDelServicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerDetalleDeCargaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerDetalleDeCargaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdProcesosCostos As C1.Win.C1Command.C1ContextMenu
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdProcesarManoObra As C1.Win.C1Command.C1Command
End Class
