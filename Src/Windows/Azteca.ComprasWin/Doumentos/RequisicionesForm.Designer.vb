<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequisicionesForm
    Inherits Azteca.Windows.Forms.BusinessForms.DocumentForm

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
        Me.optArticulo = New Azteca.Windows.Controls.CIRadioButton()
        Me.optServicio = New Azteca.Windows.Controls.CIRadioButton()
        Me.lblPresupuesto = New Azteca.Windows.Controls.CILabel()
        Me.txtObservaciones = New Azteca.Windows.Controls.CITextBox()
        Me.lbllObservaciones = New Azteca.Windows.Controls.CILabel()
        Me.lblCantidad = New Azteca.Windows.Controls.CILabel()
        Me.lblCentroRecepcion = New Azteca.Windows.Controls.CILabel()
        Me.lblRequisicionTipo = New Azteca.Windows.Controls.CILabel()
        Me.lblCategoriaPresupuestal = New Azteca.Windows.Controls.CILabel()
        Me.lblDepartamento = New Azteca.Windows.Controls.CILabel()
        Me.CiGroupBox1 = New Azteca.Windows.Controls.CIGroupBox()
        Me.txtCantidad = New Azteca.Windows.Inventario.QuantityEditor()
        Me.selArticuloStock = New Azteca.Windows.Inventario.ArticuloStockSelector()
        Me.cboUnidadMedida = New Azteca.Windows.Inventario.UnidadesMedidaComboBox()
        Me.cboCentrosRecep = New Azteca.Windows.Compras.CentrosRecepcionComboBox()
        Me.cboPresupuesto = New Azteca.Windows.Compras.PresupuestoComboBox()
        Me.cboDepartamento = New Azteca.Windows.Compras.DepartamentoComboBox()
        Me.cboTipoRequisicion = New Azteca.Windows.Compras.RequisicionesTiposComboBox()
        Me.selServicio = New Azteca.Windows.Compras.ServicioSelector()
        Me.cboCategoriaPresup = New Azteca.Windows.Compras.CategoriasPresupuestalesComboBox()
        Me.CiGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'optArticulo
        '
        Me.optArticulo.AutoSize = True
        Me.optArticulo.Checked = True
        Me.optArticulo.Location = New System.Drawing.Point(12, 24)
        Me.optArticulo.Name = "optArticulo"
        Me.optArticulo.Size = New System.Drawing.Size(63, 17)
        Me.optArticulo.TabIndex = 37
        Me.optArticulo.TabStop = True
        Me.optArticulo.Text = "Articulo:"
        Me.optArticulo.UseVisualStyleBackColor = True
        '
        'optServicio
        '
        Me.optServicio.AutoSize = True
        Me.optServicio.Location = New System.Drawing.Point(12, 47)
        Me.optServicio.Name = "optServicio"
        Me.optServicio.Size = New System.Drawing.Size(66, 17)
        Me.optServicio.TabIndex = 38
        Me.optServicio.Text = "Servicio:"
        Me.optServicio.UseVisualStyleBackColor = True
        '
        'lblPresupuesto
        '
        Me.lblPresupuesto.AutoSize = True
        Me.lblPresupuesto.Location = New System.Drawing.Point(20, 149)
        Me.lblPresupuesto.Name = "lblPresupuesto"
        Me.lblPresupuesto.Size = New System.Drawing.Size(69, 13)
        Me.lblPresupuesto.TabIndex = 42
        Me.lblPresupuesto.Text = "Presupuesto:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtObservaciones.Location = New System.Drawing.Point(23, 358)
        Me.txtObservaciones.MaxLength = 256
        Me.txtObservaciones.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObservaciones.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtObservaciones.Size = New System.Drawing.Size(576, 121)
        Me.txtObservaciones.TabIndex = 43
        Me.txtObservaciones.WordWrap = False
        '
        'lbllObservaciones
        '
        Me.lbllObservaciones.AutoSize = True
        Me.lbllObservaciones.Location = New System.Drawing.Point(23, 342)
        Me.lbllObservaciones.Name = "lbllObservaciones"
        Me.lbllObservaciones.Size = New System.Drawing.Size(81, 13)
        Me.lbllObservaciones.TabIndex = 44
        Me.lbllObservaciones.Text = "Observaciones:"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(12, 77)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(52, 13)
        Me.lblCantidad.TabIndex = 46
        Me.lblCantidad.Text = "Cantidad:"
        '
        'lblCentroRecepcion
        '
        Me.lblCentroRecepcion.AutoSize = True
        Me.lblCentroRecepcion.Location = New System.Drawing.Point(20, 176)
        Me.lblCentroRecepcion.Name = "lblCentroRecepcion"
        Me.lblCentroRecepcion.Size = New System.Drawing.Size(96, 13)
        Me.lblCentroRecepcion.TabIndex = 48
        Me.lblCentroRecepcion.Text = "Centro Recepción:"
        '
        'lblRequisicionTipo
        '
        Me.lblRequisicionTipo.AutoSize = True
        Me.lblRequisicionTipo.Location = New System.Drawing.Point(20, 95)
        Me.lblRequisicionTipo.Name = "lblRequisicionTipo"
        Me.lblRequisicionTipo.Size = New System.Drawing.Size(99, 13)
        Me.lblRequisicionTipo.TabIndex = 51
        Me.lblRequisicionTipo.Text = "Tipo de requisición:"
        '
        'lblCategoriaPresupuestal
        '
        Me.lblCategoriaPresupuestal.AutoSize = True
        Me.lblCategoriaPresupuestal.Location = New System.Drawing.Point(12, 104)
        Me.lblCategoriaPresupuestal.Name = "lblCategoriaPresupuestal"
        Me.lblCategoriaPresupuestal.Size = New System.Drawing.Size(117, 13)
        Me.lblCategoriaPresupuestal.TabIndex = 52
        Me.lblCategoriaPresupuestal.Text = "Categoria Presupuesto:"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(20, 122)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(77, 13)
        Me.lblDepartamento.TabIndex = 56
        Me.lblDepartamento.Text = "Departamento:"
        '
        'CiGroupBox1
        '
        Me.CiGroupBox1.Controls.Add(Me.txtCantidad)
        Me.CiGroupBox1.Controls.Add(Me.selArticuloStock)
        Me.CiGroupBox1.Controls.Add(Me.selServicio)
        Me.CiGroupBox1.Controls.Add(Me.lblCantidad)
        Me.CiGroupBox1.Controls.Add(Me.cboUnidadMedida)
        Me.CiGroupBox1.Controls.Add(Me.optServicio)
        Me.CiGroupBox1.Controls.Add(Me.optArticulo)
        Me.CiGroupBox1.Controls.Add(Me.cboCategoriaPresup)
        Me.CiGroupBox1.Controls.Add(Me.lblCategoriaPresupuestal)
        Me.CiGroupBox1.Location = New System.Drawing.Point(23, 200)
        Me.CiGroupBox1.Name = "CiGroupBox1"
        Me.CiGroupBox1.Size = New System.Drawing.Size(576, 139)
        Me.CiGroupBox1.TabIndex = 57
        Me.CiGroupBox1.TabStop = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(298, 74)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(133, 20)
        Me.txtCantidad.TabIndex = 55
        Me.txtCantidad.UIName = Nothing
        Me.txtCantidad.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'selArticuloStock
        '
        Me.selArticuloStock.AnySite = False
        Me.selArticuloStock.AutoLock = False
        Me.selArticuloStock.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selArticuloStock.EditorAssembly = "Azteca.InventarioWin"
        Me.selArticuloStock.EditorClass = "Azteca.Windows.Inventario.ArticulosStockForm"
        Me.selArticuloStock.EditorTitle = "Editar Articulos de inventario..."
        Me.selArticuloStock.Key = 0
        Me.selArticuloStock.Linked = False
        Me.selArticuloStock.Location = New System.Drawing.Point(133, 23)
        Me.selArticuloStock.Name = "selArticuloStock"
        Me.selArticuloStock.Size = New System.Drawing.Size(405, 23)
        Me.selArticuloStock.TabIndex = 39
        Me.selArticuloStock.TextWidth = 95
        Me.selArticuloStock.UIName = "Articulo"
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadMedida.FormattingEnabled = True
        Me.cboUnidadMedida.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboUnidadMedida.ItemsTable = Nothing
        Me.cboUnidadMedida.Location = New System.Drawing.Point(133, 74)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.Size = New System.Drawing.Size(159, 21)
        Me.cboUnidadMedida.TabIndex = 49
        Me.cboUnidadMedida.UIName = Nothing
        Me.cboUnidadMedida.Visible = False
        '
        'cboCentrosRecep
        '
        Me.cboCentrosRecep.AutoClear = False
        Me.cboCentrosRecep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCentrosRecep.FormattingEnabled = True
        Me.cboCentrosRecep.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCentrosRecep.ItemsTable = Nothing
        Me.cboCentrosRecep.Location = New System.Drawing.Point(156, 173)
        Me.cboCentrosRecep.Name = "cboCentrosRecep"
        Me.cboCentrosRecep.RequiredField = True
        Me.cboCentrosRecep.Size = New System.Drawing.Size(260, 21)
        Me.cboCentrosRecep.TabIndex = 47
        Me.cboCentrosRecep.UIName = Nothing
        '
        'cboPresupuesto
        '
        Me.cboPresupuesto.AutoClear = False
        Me.cboPresupuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPresupuesto.FormattingEnabled = True
        Me.cboPresupuesto.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboPresupuesto.ItemsTable = Nothing
        Me.cboPresupuesto.Location = New System.Drawing.Point(156, 146)
        Me.cboPresupuesto.Name = "cboPresupuesto"
        Me.cboPresupuesto.Size = New System.Drawing.Size(260, 21)
        Me.cboPresupuesto.TabIndex = 53
        Me.cboPresupuesto.UIName = Nothing
        '
        'cboDepartamento
        '
        Me.cboDepartamento.AutoClear = False
        Me.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartamento.FormattingEnabled = True
        Me.cboDepartamento.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDepartamento.ItemsTable = Nothing
        Me.cboDepartamento.Location = New System.Drawing.Point(156, 119)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Size = New System.Drawing.Size(171, 21)
        Me.cboDepartamento.TabIndex = 58
        Me.cboDepartamento.UIName = Nothing
        '
        'cboTipoRequisicion
        '
        Me.cboTipoRequisicion.AutoClear = False
        Me.cboTipoRequisicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoRequisicion.FormattingEnabled = True
        Me.cboTipoRequisicion.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTipoRequisicion.ItemsTable = Nothing
        Me.cboTipoRequisicion.Location = New System.Drawing.Point(156, 92)
        Me.cboTipoRequisicion.Name = "cboTipoRequisicion"
        Me.cboTipoRequisicion.RequiredField = True
        Me.cboTipoRequisicion.Size = New System.Drawing.Size(171, 21)
        Me.cboTipoRequisicion.TabIndex = 50
        Me.cboTipoRequisicion.UIName = Nothing
        '
        'selServicio
        '
        Me.selServicio.AnySite = False
        Me.selServicio.AutoLock = False
        Me.selServicio.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selServicio.EditorAssembly = "Azteca.ComprasWin"
        Me.selServicio.EditorClass = "Azteca.Windows.Compras.ServiciosForm"
        Me.selServicio.EditorTitle = "Editar servicios..."
        Me.selServicio.Enabled = False
        Me.selServicio.Key = 0
        Me.selServicio.Linked = False
        Me.selServicio.Location = New System.Drawing.Point(133, 47)
        Me.selServicio.Name = "selServicio"
        Me.selServicio.Size = New System.Drawing.Size(405, 23)
        Me.selServicio.TabIndex = 40
        Me.selServicio.TextWidth = 95
        '
        'cboCategoriaPresup
        '
        Me.cboCategoriaPresup.AutoLock = False
        Me.cboCategoriaPresup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoriaPresup.FormattingEnabled = True
        Me.cboCategoriaPresup.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCategoriaPresup.ItemsTable = Nothing
        Me.cboCategoriaPresup.Location = New System.Drawing.Point(135, 101)
        Me.cboCategoriaPresup.Name = "cboCategoriaPresup"
        Me.cboCategoriaPresup.Size = New System.Drawing.Size(296, 21)
        Me.cboCategoriaPresup.TabIndex = 54
        Me.cboCategoriaPresup.UIName = Nothing
        '
        'RequisicionesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 521)
        Me.CodeFieldLocation = New System.Drawing.Point(93, 61)
        Me.CodeFieldSize = New System.Drawing.Size(160, 20)
        Me.Controls.Add(Me.cboCentrosRecep)
        Me.Controls.Add(Me.lblCentroRecepcion)
        Me.Controls.Add(Me.cboPresupuesto)
        Me.Controls.Add(Me.lblPresupuesto)
        Me.Controls.Add(Me.cboDepartamento)
        Me.Controls.Add(Me.lblDepartamento)
        Me.Controls.Add(Me.cboTipoRequisicion)
        Me.Controls.Add(Me.lblRequisicionTipo)
        Me.Controls.Add(Me.lbllObservaciones)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.CiGroupBox1)
        Me.Name = "RequisicionesForm"
        Me.StatusFieldLocation = New System.Drawing.Point(320, 61)
        Me.Text = "RequisicionesForm"
        Me.Controls.SetChildIndex(Me.CiGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lbllObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblRequisicionTipo, 0)
        Me.Controls.SetChildIndex(Me.cboTipoRequisicion, 0)
        Me.Controls.SetChildIndex(Me.lblDepartamento, 0)
        Me.Controls.SetChildIndex(Me.cboDepartamento, 0)
        Me.Controls.SetChildIndex(Me.lblPresupuesto, 0)
        Me.Controls.SetChildIndex(Me.cboPresupuesto, 0)
        Me.Controls.SetChildIndex(Me.lblCentroRecepcion, 0)
        Me.Controls.SetChildIndex(Me.cboCentrosRecep, 0)
        Me.CiGroupBox1.ResumeLayout(False)
        Me.CiGroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New RequisicionFacade
        SetDocumentType("RequisicionCompra")
        LicenseModule = Kernel.Licensing.LicenseModule.Purchasing
    End Sub
    Friend WithEvents optArticulo As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents optServicio As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents selArticuloStock As Azteca.Windows.Inventario.ArticuloStockSelector
    Friend WithEvents selServicio As Azteca.Windows.Compras.ServicioSelector
    Friend WithEvents lblPresupuesto As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtObservaciones As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lbllObservaciones As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCantidad As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboCentrosRecep As Azteca.Windows.Compras.CentrosRecepcionComboBox
    Friend WithEvents lblCentroRecepcion As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboUnidadMedida As Azteca.Windows.Inventario.UnidadesMedidaComboBox
    Friend WithEvents cboTipoRequisicion As Azteca.Windows.Compras.RequisicionesTiposComboBox
    Friend WithEvents lblRequisicionTipo As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCategoriaPresupuestal As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboPresupuesto As Azteca.Windows.Compras.PresupuestoComboBox
    Friend WithEvents lblDepartamento As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiGroupBox1 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents cboCategoriaPresup As Azteca.Windows.Compras.CategoriasPresupuestalesComboBox
    Friend WithEvents cboDepartamento As Azteca.Windows.Compras.DepartamentoComboBox
    Friend WithEvents txtCantidad As Azteca.Windows.Inventario.QuantityEditor
End Class
