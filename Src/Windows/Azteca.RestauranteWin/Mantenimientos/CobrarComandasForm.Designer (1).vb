<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CobrarComandasForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CobrarComandasForm))
        Me.gbxEncabezado = New System.Windows.Forms.GroupBox()
        Me.lblCliente = New Azteca.Windows.Controls.CILabel()
        Me.cboCaja = New Azteca.Windows.Ventas.CajaCombobox()
        Me.lblCaja = New Azteca.Windows.Controls.CILabel()
        Me.selCliente = New Azteca.Windows.Ventas.ClienteSelector()
        Me.lvwComandas = New Azteca.Windows.Controls.CIListView()
        Me.colCentroConsumo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMesa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMesero = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colObservaciones = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tlbMenu = New Azteca.Windows.Controls.CIToolBar()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimirComanda = New System.Windows.Forms.ToolStripButton()
        Me.btnCobrar = New System.Windows.Forms.ToolStripButton()
        Me.gbxEncabezado.SuspendLayout()
        Me.tlbMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxEncabezado
        '
        Me.gbxEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxEncabezado.Controls.Add(Me.lblCliente)
        Me.gbxEncabezado.Controls.Add(Me.cboCaja)
        Me.gbxEncabezado.Controls.Add(Me.lblCaja)
        Me.gbxEncabezado.Controls.Add(Me.selCliente)
        Me.gbxEncabezado.Location = New System.Drawing.Point(12, 49)
        Me.gbxEncabezado.Name = "gbxEncabezado"
        Me.gbxEncabezado.Size = New System.Drawing.Size(702, 91)
        Me.gbxEncabezado.TabIndex = 2
        Me.gbxEncabezado.TabStop = False
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(16, 55)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 5
        Me.lblCliente.Text = "Cliente"
        '
        'cboCaja
        '
        Me.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCaja.ItemsTable = Nothing
        Me.cboCaja.Location = New System.Drawing.Point(59, 24)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboCaja.Size = New System.Drawing.Size(246, 21)
        Me.cboCaja.TabIndex = 0
        Me.cboCaja.UIName = Nothing
        '
        'lblCaja
        '
        Me.lblCaja.AutoSize = True
        Me.lblCaja.Location = New System.Drawing.Point(25, 26)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(28, 13)
        Me.lblCaja.TabIndex = 4
        Me.lblCaja.Text = "Caja"
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
        Me.selCliente.Location = New System.Drawing.Point(61, 51)
        Me.selCliente.Name = "selCliente"
        Me.selCliente.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCliente.Size = New System.Drawing.Size(194, 23)
        Me.selCliente.TabIndex = 1
        '
        'lvwComandas
        '
        Me.lvwComandas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwComandas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCentroConsumo, Me.colMesa, Me.colMesero, Me.colObservaciones})
        Me.lvwComandas.FullRowSelect = True
        Me.lvwComandas.GridLines = True
        Me.lvwComandas.Location = New System.Drawing.Point(12, 152)
        Me.lvwComandas.Name = "lvwComandas"
        Me.lvwComandas.Size = New System.Drawing.Size(702, 319)
        Me.lvwComandas.TabIndex = 3
        Me.lvwComandas.UseCompatibleStateImageBehavior = False
        Me.lvwComandas.View = System.Windows.Forms.View.Details
        '
        'colCentroConsumo
        '
        Me.colCentroConsumo.Text = "Centro de Consumo"
        Me.colCentroConsumo.Width = 165
        '
        'colMesa
        '
        Me.colMesa.Text = "Mesa"
        Me.colMesa.Width = 85
        '
        'colMesero
        '
        Me.colMesero.Text = "Mesero"
        Me.colMesero.Width = 136
        '
        'colObservaciones
        '
        Me.colObservaciones.Text = "Observaciones"
        Me.colObservaciones.Width = 286
        '
        'tlbMenu
        '
        Me.tlbMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tlbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnConsultar, Me.ToolStripSeparator1, Me.btnImprimirComanda, Me.btnCobrar})
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(726, 39)
        Me.tlbMenu.TabIndex = 7
        Me.tlbMenu.Text = "CiToolBar1"
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(94, 36)
        Me.btnConsultar.Text = "Consultar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnImprimirComanda
        '
        Me.btnImprimirComanda.Image = CType(resources.GetObject("btnImprimirComanda.Image"), System.Drawing.Image)
        Me.btnImprimirComanda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimirComanda.Name = "btnImprimirComanda"
        Me.btnImprimirComanda.Size = New System.Drawing.Size(144, 36)
        Me.btnImprimirComanda.Text = "Imprimir Comanda"
        Me.btnImprimirComanda.ToolTipText = "Imprimir el ticket de la comanda"
        '
        'btnCobrar
        '
        Me.btnCobrar.Image = CType(resources.GetObject("btnCobrar.Image"), System.Drawing.Image)
        Me.btnCobrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(79, 36)
        Me.btnCobrar.Text = "Cobrar"
        Me.btnCobrar.ToolTipText = "Cobrar las comandas seleccionada"
        '
        'CobrarComandasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 479)
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.lvwComandas)
        Me.Controls.Add(Me.gbxEncabezado)
        Me.Name = "CobrarComandasForm"
        Me.Text = "CobrarComandasForm"
        Me.gbxEncabezado.ResumeLayout(False)
        Me.gbxEncabezado.PerformLayout()
        Me.tlbMenu.ResumeLayout(False)
        Me.tlbMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCaja As Azteca.Windows.Ventas.CajaCombobox
    Friend WithEvents selCliente As Azteca.Windows.Ventas.ClienteSelector
    Friend WithEvents gbxEncabezado As System.Windows.Forms.GroupBox
    Friend WithEvents lblCaja As Azteca.Windows.Controls.CILabel
    Friend WithEvents lvwComandas As Azteca.Windows.Controls.CIListView
    Friend WithEvents lblCliente As Azteca.Windows.Controls.CILabel
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnCobrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimirComanda As System.Windows.Forms.ToolStripButton
    Friend WithEvents colCentroConsumo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMesa As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMesero As System.Windows.Forms.ColumnHeader
    Friend WithEvents colObservaciones As System.Windows.Forms.ColumnHeader
End Class
