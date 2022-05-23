<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GastosForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DesignerRectTracker1 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GastosForm))
        Dim CBlendItems1 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker2 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim DesignerRectTracker3 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems2 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker4 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Me.lblDepartamento = New Azteca.Windows.Controls.CILabel()
        Me.lblConcepto = New Azteca.Windows.Controls.CILabel()
        Me.lblPresupuesto = New Azteca.Windows.Controls.CILabel()
        Me.lblCategoriaPresupuestal = New Azteca.Windows.Controls.CILabel()
        Me.gbxBeneficiario = New Azteca.Windows.Controls.CIGroupBox()
        Me.selBeneficiario = New Azteca.Windows.Tesoreria.BeneficiarioSelector()
        Me.selEmpleado = New Azteca.Windows.RH.EmpleadoSelector()
        Me.optOtro = New Azteca.Windows.Controls.CIRadioButton()
        Me.optProveedor = New Azteca.Windows.Controls.CIRadioButton()
        Me.optEmpleado = New Azteca.Windows.Controls.CIRadioButton()
        Me.gbxModalidad = New Azteca.Windows.Controls.CIGroupBox()
        Me.optComprobacion = New Azteca.Windows.Controls.CIRadioButton()
        Me.optReposicion = New Azteca.Windows.Controls.CIRadioButton()
        Me.lblBeneficiario = New Azteca.Windows.Controls.CILabel()
        Me.optModalidad = New Azteca.Windows.Controls.CILabel()
        Me.txtSubtotal = New Azteca.Windows.Controls.CITextBox()
        Me.lblSubtotal = New Azteca.Windows.Controls.CILabel()
        Me.lblImpuestos = New Azteca.Windows.Controls.CILabel()
        Me.lblRetenciones = New Azteca.Windows.Controls.CILabel()
        Me.txtObervaciones = New Azteca.Windows.Controls.CITextBox()
        Me.lblObservaciones = New Azteca.Windows.Controls.CILabel()
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.bsImpuestos = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsRetenciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtRetenciones = New Azteca.Windows.Controls.CILinkLabel()
        Me.txtImpuestos = New Azteca.Windows.Controls.CILinkLabel()
        Me.lblMoneda = New Azteca.Windows.Controls.CILabel()
        Me.cboMoneda = New Azteca.Windows.Contabilidad.DivisasComboBox()
        Me.lblComprobante = New Azteca.Windows.Controls.CILabel()
        Me.lblTotal = New Azteca.Windows.Controls.CILabel()
        Me.txtTotal = New Azteca.Windows.Controls.CILabel()
        Me.gbxCFD = New Azteca.Windows.Controls.CIGroupBox()
        Me.chkDigital = New Azteca.Windows.Controls.CICheckBox()
        Me.lblAprobacion = New Azteca.Windows.Controls.CILabel()
        Me.txtNumAprobacion = New Azteca.Windows.Controls.CITextBox()
        Me.lblNumAprobacion = New Azteca.Windows.Controls.CILabel()
        Me.upDownAnioAprobacion = New Azteca.Windows.Controls.CINumericUpDown()
        Me.lblAnioAprobacion = New Azteca.Windows.Controls.CILabel()
        Me.txtFactura = New Azteca.Windows.Controls.CITextBox()
        Me.txtSerie = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.lblSerie = New Azteca.Windows.Controls.CILabel()
        Me.lblProveedorServ = New Azteca.Windows.Controls.CILabel()
        Me.iLst32 = New System.Windows.Forms.ImageList(Me.components)
        Me.tabGastoDetalle = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagCajas = New C1.Win.C1Command.C1DockingTabPage()
        Me.pnlImpuestos = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.btnCloseImpuesto = New Azteca.Windows.Controls.ButtonPlus()
        Me.grdImpuetos = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.lblImpuestosTit = New Azteca.Windows.Controls.CILabel()
        Me.pnlRetenciones = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.btnCloseRetencion = New Azteca.Windows.Controls.ButtonPlus()
        Me.grdRetenciones = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.lblRetencionesTit = New Azteca.Windows.Controls.CILabel()
        Me.selProveedor = New Azteca.Windows.Compras.ProveedoresSelector()
        Me.selProveedorExpress = New Azteca.Windows.Compras.ProveedorExpressSelector()
        Me.cboDepartamento = New Azteca.Windows.Compras.DepartamentoComboBox()
        Me.cboConcepto = New Azteca.Windows.Compras.ConceptoGastosComboBox()
        Me.cboPresupuesto = New Azteca.Windows.Compras.PresupuestoComboBox()
        Me.gbxBeneficiario.SuspendLayout()
        Me.gbxModalidad.SuspendLayout()
        CType(Me.bsImpuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRetenciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCFD.SuspendLayout()
        CType(Me.upDownAnioAprobacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabGastoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGastoDetalle.SuspendLayout()
        Me.pagCajas.SuspendLayout()
        Me.pnlImpuestos.SuspendLayout()
        CType(Me.grdImpuetos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRetenciones.SuspendLayout()
        CType(Me.grdRetenciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.BackColor = System.Drawing.Color.Transparent
        Me.lblDepartamento.Location = New System.Drawing.Point(53, 146)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(74, 13)
        Me.lblDepartamento.TabIndex = 59
        Me.lblDepartamento.Text = "Departamento"
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.BackColor = System.Drawing.Color.Transparent
        Me.lblConcepto.Location = New System.Drawing.Point(53, 172)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(53, 13)
        Me.lblConcepto.TabIndex = 65
        Me.lblConcepto.Text = "Concepto"
        '
        'lblPresupuesto
        '
        Me.lblPresupuesto.AutoSize = True
        Me.lblPresupuesto.BackColor = System.Drawing.Color.Transparent
        Me.lblPresupuesto.Location = New System.Drawing.Point(399, 146)
        Me.lblPresupuesto.Name = "lblPresupuesto"
        Me.lblPresupuesto.Size = New System.Drawing.Size(66, 13)
        Me.lblPresupuesto.TabIndex = 42
        Me.lblPresupuesto.Text = "Presupuesto"
        '
        'lblCategoriaPresupuestal
        '
        Me.lblCategoriaPresupuestal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCategoriaPresupuestal.Location = New System.Drawing.Point(132, 193)
        Me.lblCategoriaPresupuestal.Name = "lblCategoriaPresupuestal"
        Me.lblCategoriaPresupuestal.Size = New System.Drawing.Size(487, 20)
        Me.lblCategoriaPresupuestal.TabIndex = 52
        Me.lblCategoriaPresupuestal.Text = "Categoria Presupuesto"
        Me.lblCategoriaPresupuestal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbxBeneficiario
        '
        Me.gbxBeneficiario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxBeneficiario.BackColor = System.Drawing.Color.Transparent
        Me.gbxBeneficiario.Controls.Add(Me.selBeneficiario)
        Me.gbxBeneficiario.Controls.Add(Me.selEmpleado)
        Me.gbxBeneficiario.Controls.Add(Me.selProveedor)
        Me.gbxBeneficiario.Controls.Add(Me.optOtro)
        Me.gbxBeneficiario.Controls.Add(Me.optProveedor)
        Me.gbxBeneficiario.Controls.Add(Me.optEmpleado)
        Me.gbxBeneficiario.Location = New System.Drawing.Point(133, 18)
        Me.gbxBeneficiario.Name = "gbxBeneficiario"
        Me.gbxBeneficiario.Size = New System.Drawing.Size(557, 71)
        Me.gbxBeneficiario.TabIndex = 62
        Me.gbxBeneficiario.TabStop = False
        '
        'selBeneficiario
        '
        Me.selBeneficiario.AnySite = False
        Me.selBeneficiario.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selBeneficiario.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selBeneficiario.EditorAssembly = "Azteca.TesoreriaWin"
        Me.selBeneficiario.EditorClass = "Azteca.Windows.Tesoreria.BeneficiariosForm"
        Me.selBeneficiario.EditorTitle = "Editar datos del Beneficiario..."
        Me.selBeneficiario.Key = 0
        Me.selBeneficiario.Linked = False
        Me.selBeneficiario.Location = New System.Drawing.Point(22, 42)
        Me.selBeneficiario.Name = "selBeneficiario"
        Me.selBeneficiario.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selBeneficiario.Size = New System.Drawing.Size(433, 23)
        Me.selBeneficiario.TabIndex = 91
        Me.selBeneficiario.Visible = False
        '
        'selEmpleado
        '
        Me.selEmpleado.AnySite = False
        Me.selEmpleado.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selEmpleado.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selEmpleado.EditorAssembly = "Azteca.RHWin"
        Me.selEmpleado.EditorClass = "Azteca.Windows.RH.EmpleadosForm"
        Me.selEmpleado.EditorTitle = "Editar datos de articulo..."
        Me.selEmpleado.Key = 0
        Me.selEmpleado.Linked = False
        Me.selEmpleado.Location = New System.Drawing.Point(23, 42)
        Me.selEmpleado.Name = "selEmpleado"
        Me.selEmpleado.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selEmpleado.Size = New System.Drawing.Size(433, 23)
        Me.selEmpleado.TabIndex = 4
        '
        'optOtro
        '
        Me.optOtro.AutoSize = True
        Me.optOtro.BackColor = System.Drawing.Color.Transparent
        Me.optOtro.Location = New System.Drawing.Point(350, 19)
        Me.optOtro.Name = "optOtro"
        Me.optOtro.Size = New System.Drawing.Size(45, 17)
        Me.optOtro.TabIndex = 2
        Me.optOtro.Text = "Otro"
        Me.optOtro.UseVisualStyleBackColor = False
        '
        'optProveedor
        '
        Me.optProveedor.AutoSize = True
        Me.optProveedor.BackColor = System.Drawing.Color.Transparent
        Me.optProveedor.Location = New System.Drawing.Point(188, 19)
        Me.optProveedor.Name = "optProveedor"
        Me.optProveedor.Size = New System.Drawing.Size(74, 17)
        Me.optProveedor.TabIndex = 1
        Me.optProveedor.Text = "Proveedor"
        Me.optProveedor.UseVisualStyleBackColor = False
        '
        'optEmpleado
        '
        Me.optEmpleado.AutoSize = True
        Me.optEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.optEmpleado.Checked = True
        Me.optEmpleado.Location = New System.Drawing.Point(18, 19)
        Me.optEmpleado.Name = "optEmpleado"
        Me.optEmpleado.Size = New System.Drawing.Size(72, 17)
        Me.optEmpleado.TabIndex = 0
        Me.optEmpleado.TabStop = True
        Me.optEmpleado.Text = "Empleado"
        Me.optEmpleado.UseVisualStyleBackColor = False
        '
        'gbxModalidad
        '
        Me.gbxModalidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxModalidad.BackColor = System.Drawing.Color.Transparent
        Me.gbxModalidad.Controls.Add(Me.optComprobacion)
        Me.gbxModalidad.Controls.Add(Me.optReposicion)
        Me.gbxModalidad.Location = New System.Drawing.Point(133, 94)
        Me.gbxModalidad.Name = "gbxModalidad"
        Me.gbxModalidad.Size = New System.Drawing.Size(557, 36)
        Me.gbxModalidad.TabIndex = 62
        Me.gbxModalidad.TabStop = False
        '
        'optComprobacion
        '
        Me.optComprobacion.AutoSize = True
        Me.optComprobacion.BackColor = System.Drawing.Color.Transparent
        Me.optComprobacion.Location = New System.Drawing.Point(188, 12)
        Me.optComprobacion.Name = "optComprobacion"
        Me.optComprobacion.Size = New System.Drawing.Size(93, 17)
        Me.optComprobacion.TabIndex = 4
        Me.optComprobacion.Text = "Comprobación"
        Me.optComprobacion.UseVisualStyleBackColor = False
        '
        'optReposicion
        '
        Me.optReposicion.AutoSize = True
        Me.optReposicion.BackColor = System.Drawing.Color.Transparent
        Me.optReposicion.Checked = True
        Me.optReposicion.Location = New System.Drawing.Point(18, 12)
        Me.optReposicion.Name = "optReposicion"
        Me.optReposicion.Size = New System.Drawing.Size(78, 17)
        Me.optReposicion.TabIndex = 3
        Me.optReposicion.TabStop = True
        Me.optReposicion.Text = "Reposicion"
        Me.optReposicion.UseVisualStyleBackColor = False
        '
        'lblBeneficiario
        '
        Me.lblBeneficiario.AutoSize = True
        Me.lblBeneficiario.BackColor = System.Drawing.Color.Transparent
        Me.lblBeneficiario.Location = New System.Drawing.Point(53, 38)
        Me.lblBeneficiario.Name = "lblBeneficiario"
        Me.lblBeneficiario.Size = New System.Drawing.Size(62, 13)
        Me.lblBeneficiario.TabIndex = 63
        Me.lblBeneficiario.Text = "Beneficiario"
        '
        'optModalidad
        '
        Me.optModalidad.AutoSize = True
        Me.optModalidad.BackColor = System.Drawing.Color.Transparent
        Me.optModalidad.Location = New System.Drawing.Point(53, 107)
        Me.optModalidad.Name = "optModalidad"
        Me.optModalidad.Size = New System.Drawing.Size(56, 13)
        Me.optModalidad.TabIndex = 64
        Me.optModalidad.Text = "Modalidad"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtSubtotal.Digits = True
        Me.txtSubtotal.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtSubtotal.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSubtotal.Location = New System.Drawing.Point(129, 345)
        Me.txtSubtotal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubtotal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.RequiredField = True
        Me.txtSubtotal.Size = New System.Drawing.Size(68, 20)
        Me.txtSubtotal.TabIndex = 65
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtotal.Location = New System.Drawing.Point(53, 349)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(46, 13)
        Me.lblSubtotal.TabIndex = 66
        Me.lblSubtotal.Text = "Subtotal"
        '
        'lblImpuestos
        '
        Me.lblImpuestos.AutoSize = True
        Me.lblImpuestos.BackColor = System.Drawing.Color.Transparent
        Me.lblImpuestos.Location = New System.Drawing.Point(200, 349)
        Me.lblImpuestos.Name = "lblImpuestos"
        Me.lblImpuestos.Size = New System.Drawing.Size(55, 13)
        Me.lblImpuestos.TabIndex = 67
        Me.lblImpuestos.Text = "Impuestos"
        '
        'lblRetenciones
        '
        Me.lblRetenciones.AutoSize = True
        Me.lblRetenciones.BackColor = System.Drawing.Color.Transparent
        Me.lblRetenciones.Location = New System.Drawing.Point(334, 350)
        Me.lblRetenciones.Name = "lblRetenciones"
        Me.lblRetenciones.Size = New System.Drawing.Size(67, 13)
        Me.lblRetenciones.TabIndex = 68
        Me.lblRetenciones.Text = "Retenciones"
        '
        'txtObervaciones
        '
        Me.txtObervaciones.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtObervaciones.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtObervaciones.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtObervaciones.Location = New System.Drawing.Point(129, 371)
        Me.txtObervaciones.MaxLength = 128
        Me.txtObervaciones.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObervaciones.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObervaciones.Name = "txtObervaciones"
        Me.txtObervaciones.Size = New System.Drawing.Size(490, 20)
        Me.txtObervaciones.TabIndex = 89
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.BackColor = System.Drawing.Color.Transparent
        Me.lblObservaciones.Location = New System.Drawing.Point(53, 374)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(78, 13)
        Me.lblObservaciones.TabIndex = 90
        Me.lblObservaciones.Text = "Observaciones"
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ColorWithAlpha1.Parent = Me.pnlImpuestos
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.White
        Me.ColorWithAlpha2.Parent = Me.pnlImpuestos
        '
        'txtRetenciones
        '
        Me.txtRetenciones.AutoLock = False
        Me.txtRetenciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRetenciones.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.txtRetenciones.Location = New System.Drawing.Point(407, 345)
        Me.txtRetenciones.Name = "txtRetenciones"
        Me.txtRetenciones.Size = New System.Drawing.Size(68, 21)
        Me.txtRetenciones.TabIndex = 86
        Me.txtRetenciones.TabStop = True
        Me.txtRetenciones.Text = "0.00"
        Me.txtRetenciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtImpuestos
        '
        Me.txtImpuestos.AutoLock = False
        Me.txtImpuestos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImpuestos.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.txtImpuestos.Location = New System.Drawing.Point(257, 345)
        Me.txtImpuestos.Name = "txtImpuestos"
        Me.txtImpuestos.Size = New System.Drawing.Size(70, 21)
        Me.txtImpuestos.TabIndex = 85
        Me.txtImpuestos.TabStop = True
        Me.txtImpuestos.Text = "0.00"
        Me.txtImpuestos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMoneda
        '
        Me.lblMoneda.AutoSize = True
        Me.lblMoneda.BackColor = System.Drawing.Color.Transparent
        Me.lblMoneda.Location = New System.Drawing.Point(399, 172)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(46, 13)
        Me.lblMoneda.TabIndex = 83
        Me.lblMoneda.Text = "Moneda"
        '
        'cboMoneda
        '
        Me.cboMoneda.AutoClear = False
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboMoneda.ItemsTable = Nothing
        Me.cboMoneda.Location = New System.Drawing.Point(464, 169)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.RequiredField = True
        Me.cboMoneda.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboMoneda.Size = New System.Drawing.Size(155, 21)
        Me.cboMoneda.TabIndex = 82
        Me.cboMoneda.UIName = Nothing
        '
        'lblComprobante
        '
        Me.lblComprobante.AutoSize = True
        Me.lblComprobante.BackColor = System.Drawing.Color.Transparent
        Me.lblComprobante.Location = New System.Drawing.Point(53, 241)
        Me.lblComprobante.Name = "lblComprobante"
        Me.lblComprobante.Size = New System.Drawing.Size(70, 13)
        Me.lblComprobante.TabIndex = 81
        Me.lblComprobante.Text = "Comprobante"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Location = New System.Drawing.Point(501, 350)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 72
        Me.lblTotal.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.AutoClear = True
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(538, 345)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(68, 20)
        Me.txtTotal.TabIndex = 71
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbxCFD
        '
        Me.gbxCFD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxCFD.BackColor = System.Drawing.Color.Transparent
        Me.gbxCFD.Controls.Add(Me.chkDigital)
        Me.gbxCFD.Controls.Add(Me.lblAprobacion)
        Me.gbxCFD.Controls.Add(Me.selProveedorExpress)
        Me.gbxCFD.Controls.Add(Me.txtNumAprobacion)
        Me.gbxCFD.Controls.Add(Me.lblNumAprobacion)
        Me.gbxCFD.Controls.Add(Me.upDownAnioAprobacion)
        Me.gbxCFD.Controls.Add(Me.lblAnioAprobacion)
        Me.gbxCFD.Controls.Add(Me.txtFactura)
        Me.gbxCFD.Controls.Add(Me.txtSerie)
        Me.gbxCFD.Controls.Add(Me.CiLabel1)
        Me.gbxCFD.Controls.Add(Me.lblSerie)
        Me.gbxCFD.Controls.Add(Me.lblProveedorServ)
        Me.gbxCFD.Location = New System.Drawing.Point(127, 225)
        Me.gbxCFD.Name = "gbxCFD"
        Me.gbxCFD.Size = New System.Drawing.Size(479, 94)
        Me.gbxCFD.TabIndex = 73
        Me.gbxCFD.TabStop = False
        '
        'chkDigital
        '
        Me.chkDigital.AutoLock = False
        Me.chkDigital.AutoSize = True
        Me.chkDigital.Enabled = False
        Me.chkDigital.Location = New System.Drawing.Point(56, 47)
        Me.chkDigital.Name = "chkDigital"
        Me.chkDigital.Size = New System.Drawing.Size(138, 17)
        Me.chkDigital.TabIndex = 83
        Me.chkDigital.Text = "Facturación Electronica"
        Me.chkDigital.UseVisualStyleBackColor = True
        '
        'lblAprobacion
        '
        Me.lblAprobacion.AutoSize = True
        Me.lblAprobacion.Location = New System.Drawing.Point(125, 71)
        Me.lblAprobacion.Name = "lblAprobacion"
        Me.lblAprobacion.Size = New System.Drawing.Size(64, 13)
        Me.lblAprobacion.TabIndex = 82
        Me.lblAprobacion.Text = "Aprobación:"
        '
        'txtNumAprobacion
        '
        Me.txtNumAprobacion.AutoClear = False
        Me.txtNumAprobacion.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNumAprobacion.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtNumAprobacion.Enabled = False
        Me.txtNumAprobacion.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumAprobacion.Location = New System.Drawing.Point(407, 68)
        Me.txtNumAprobacion.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumAprobacion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumAprobacion.Name = "txtNumAprobacion"
        Me.txtNumAprobacion.Size = New System.Drawing.Size(68, 20)
        Me.txtNumAprobacion.TabIndex = 80
        '
        'lblNumAprobacion
        '
        Me.lblNumAprobacion.AutoSize = True
        Me.lblNumAprobacion.Location = New System.Drawing.Point(380, 70)
        Me.lblNumAprobacion.Name = "lblNumAprobacion"
        Me.lblNumAprobacion.Size = New System.Drawing.Size(17, 13)
        Me.lblNumAprobacion.TabIndex = 79
        Me.lblNumAprobacion.Text = "#."
        '
        'upDownAnioAprobacion
        '
        Me.upDownAnioAprobacion.Enabled = False
        Me.upDownAnioAprobacion.HighlightColor = System.Drawing.SystemColors.Info
        Me.upDownAnioAprobacion.Location = New System.Drawing.Point(276, 68)
        Me.upDownAnioAprobacion.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.upDownAnioAprobacion.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.upDownAnioAprobacion.Name = "upDownAnioAprobacion"
        Me.upDownAnioAprobacion.Size = New System.Drawing.Size(68, 20)
        Me.upDownAnioAprobacion.TabIndex = 78
        Me.upDownAnioAprobacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.upDownAnioAprobacion.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'lblAnioAprobacion
        '
        Me.lblAnioAprobacion.AutoSize = True
        Me.lblAnioAprobacion.BackColor = System.Drawing.Color.Transparent
        Me.lblAnioAprobacion.Location = New System.Drawing.Point(238, 70)
        Me.lblAnioAprobacion.Name = "lblAnioAprobacion"
        Me.lblAnioAprobacion.Size = New System.Drawing.Size(26, 13)
        Me.lblAnioAprobacion.TabIndex = 76
        Me.lblAnioAprobacion.Text = "Año"
        '
        'txtFactura
        '
        Me.txtFactura.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtFactura.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtFactura.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFactura.Location = New System.Drawing.Point(407, 44)
        Me.txtFactura.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFactura.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.RequiredField = True
        Me.txtFactura.Size = New System.Drawing.Size(68, 20)
        Me.txtFactura.TabIndex = 75
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtSerie.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtSerie.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSerie.Location = New System.Drawing.Point(276, 43)
        Me.txtSerie.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSerie.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.RequiredField = True
        Me.txtSerie.Size = New System.Drawing.Size(68, 20)
        Me.txtSerie.TabIndex = 74
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(354, 43)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(43, 13)
        Me.CiLabel1.TabIndex = 67
        Me.CiLabel1.Text = "Factura"
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.BackColor = System.Drawing.Color.Transparent
        Me.lblSerie.Location = New System.Drawing.Point(239, 46)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(31, 13)
        Me.lblSerie.TabIndex = 66
        Me.lblSerie.Text = "Serie"
        '
        'lblProveedorServ
        '
        Me.lblProveedorServ.AutoSize = True
        Me.lblProveedorServ.Location = New System.Drawing.Point(17, 21)
        Me.lblProveedorServ.Name = "lblProveedorServ"
        Me.lblProveedorServ.Size = New System.Drawing.Size(56, 13)
        Me.lblProveedorServ.TabIndex = 66
        Me.lblProveedorServ.Text = "Proveedor"
        '
        'iLst32
        '
        Me.iLst32.ImageStream = CType(resources.GetObject("iLst32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLst32.TransparentColor = System.Drawing.Color.Transparent
        Me.iLst32.Images.SetKeyName(0, "payment_32.png")
        Me.iLst32.Images.SetKeyName(1, "collection_account_32.png")
        Me.iLst32.Images.SetKeyName(2, "paypal_32.png")
        '
        'tabGastoDetalle
        '
        Me.tabGastoDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabGastoDetalle.Controls.Add(Me.pagCajas)
        Me.tabGastoDetalle.ImageList = Me.iLst32
        Me.tabGastoDetalle.Location = New System.Drawing.Point(0, 90)
        Me.tabGastoDetalle.Name = "tabGastoDetalle"
        Me.tabGastoDetalle.SelectedIndex = 1
        Me.tabGastoDetalle.Size = New System.Drawing.Size(755, 458)
        Me.tabGastoDetalle.TabIndex = 70
        Me.tabGastoDetalle.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2003
        Me.tabGastoDetalle.VisualStyle = C1.Win.C1Command.VisualStyle.Office2003Blue
        Me.tabGastoDetalle.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2003Blue
        '
        'pagCajas
        '
        Me.pagCajas.Controls.Add(Me.pnlImpuestos)
        Me.pagCajas.Controls.Add(Me.pnlRetenciones)
        Me.pagCajas.Controls.Add(Me.txtObervaciones)
        Me.pagCajas.Controls.Add(Me.gbxBeneficiario)
        Me.pagCajas.Controls.Add(Me.lblObservaciones)
        Me.pagCajas.Controls.Add(Me.gbxCFD)
        Me.pagCajas.Controls.Add(Me.lblBeneficiario)
        Me.pagCajas.Controls.Add(Me.optModalidad)
        Me.pagCajas.Controls.Add(Me.txtRetenciones)
        Me.pagCajas.Controls.Add(Me.cboDepartamento)
        Me.pagCajas.Controls.Add(Me.txtImpuestos)
        Me.pagCajas.Controls.Add(Me.txtSubtotal)
        Me.pagCajas.Controls.Add(Me.cboConcepto)
        Me.pagCajas.Controls.Add(Me.gbxModalidad)
        Me.pagCajas.Controls.Add(Me.cboPresupuesto)
        Me.pagCajas.Controls.Add(Me.lblSubtotal)
        Me.pagCajas.Controls.Add(Me.lblCategoriaPresupuestal)
        Me.pagCajas.Controls.Add(Me.lblImpuestos)
        Me.pagCajas.Controls.Add(Me.lblConcepto)
        Me.pagCajas.Controls.Add(Me.lblDepartamento)
        Me.pagCajas.Controls.Add(Me.lblPresupuesto)
        Me.pagCajas.Controls.Add(Me.lblRetenciones)
        Me.pagCajas.Controls.Add(Me.lblMoneda)
        Me.pagCajas.Controls.Add(Me.txtTotal)
        Me.pagCajas.Controls.Add(Me.cboMoneda)
        Me.pagCajas.Controls.Add(Me.lblTotal)
        Me.pagCajas.Controls.Add(Me.lblComprobante)
        Me.pagCajas.ImageIndex = 0
        Me.pagCajas.Location = New System.Drawing.Point(1, 41)
        Me.pagCajas.Name = "pagCajas"
        Me.pagCajas.Size = New System.Drawing.Size(753, 416)
        Me.pagCajas.TabIndex = 0
        Me.pagCajas.Text = "Detalle del Gasto"
        '
        'pnlImpuestos
        '
        Me.pnlImpuestos.BackColor = System.Drawing.Color.Transparent
        Me.pnlImpuestos.Border = True
        Me.pnlImpuestos.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlImpuestos.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlImpuestos.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlImpuestos.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlImpuestos.Controls.Add(Me.btnCloseImpuesto)
        Me.pnlImpuestos.Controls.Add(Me.grdImpuetos)
        Me.pnlImpuestos.Controls.Add(Me.lblImpuestosTit)
        Me.pnlImpuestos.CornerRadius = 15
        Me.pnlImpuestos.Corners = CType(((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft), Azteca.Windows.Corner)
        Me.pnlImpuestos.Gradient = True
        Me.pnlImpuestos.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlImpuestos.GradientOffset = 1.0!
        Me.pnlImpuestos.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlImpuestos.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlImpuestos.Grayscale = False
        Me.pnlImpuestos.Image = Nothing
        Me.pnlImpuestos.ImageAlpha = 75
        Me.pnlImpuestos.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlImpuestos.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlImpuestos.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlImpuestos.Location = New System.Drawing.Point(133, 193)
        Me.pnlImpuestos.Name = "pnlImpuestos"
        Me.pnlImpuestos.Rounded = True
        Me.pnlImpuestos.Size = New System.Drawing.Size(210, 160)
        Me.pnlImpuestos.TabIndex = 108
        Me.pnlImpuestos.Visible = False
        '
        'btnCloseImpuesto
        '
        Me.btnCloseImpuesto.AutoLock = False
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnCloseImpuesto.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.btnCloseImpuesto.ColorFillBlend = CBlendItems1
        Me.btnCloseImpuesto.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.btnCloseImpuesto.Corners.All = CType(6, Short)
        Me.btnCloseImpuesto.Corners.LowerLeft = CType(6, Short)
        Me.btnCloseImpuesto.Corners.LowerRight = CType(6, Short)
        Me.btnCloseImpuesto.Corners.UpperLeft = CType(6, Short)
        Me.btnCloseImpuesto.Corners.UpperRight = CType(6, Short)
        Me.btnCloseImpuesto.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientLinear
        Me.btnCloseImpuesto.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnCloseImpuesto.FocalPoints.CenterPtX = 0.5652174!
        Me.btnCloseImpuesto.FocalPoints.CenterPtY = 0.6315789!
        Me.btnCloseImpuesto.FocalPoints.FocusPtX = 0.0!
        Me.btnCloseImpuesto.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnCloseImpuesto.FocusPtTracker = DesignerRectTracker2
        Me.btnCloseImpuesto.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCloseImpuesto.ForeColor = System.Drawing.Color.White
        Me.btnCloseImpuesto.Image = Nothing
        Me.btnCloseImpuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCloseImpuesto.ImageIndex = 0
        Me.btnCloseImpuesto.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnCloseImpuesto.Location = New System.Drawing.Point(172, 0)
        Me.btnCloseImpuesto.Name = "btnCloseImpuesto"
        Me.btnCloseImpuesto.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.btnCloseImpuesto.SideImage = Nothing
        Me.btnCloseImpuesto.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCloseImpuesto.SideImageSize = New System.Drawing.Size(48, 48)
        Me.btnCloseImpuesto.Size = New System.Drawing.Size(23, 19)
        Me.btnCloseImpuesto.TabIndex = 88
        Me.btnCloseImpuesto.Text = "X"
        Me.btnCloseImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCloseImpuesto.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.btnCloseImpuesto.TextMargin = New System.Windows.Forms.Padding(2)
        Me.btnCloseImpuesto.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnCloseImpuesto.UseMnemonic = True
        '
        'grdImpuetos
        '
        Me.grdImpuetos.DataSource = Me.bsImpuestos
        Me.grdImpuetos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdImpuetos.Images.Add(CType(resources.GetObject("grdImpuetos.Images"), System.Drawing.Image))
        Me.grdImpuetos.Location = New System.Drawing.Point(0, 20)
        Me.grdImpuetos.Name = "grdImpuetos"
        Me.grdImpuetos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdImpuetos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdImpuetos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdImpuetos.PrintInfo.PageSettings = CType(resources.GetObject("grdImpuetos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdImpuetos.Size = New System.Drawing.Size(210, 140)
        Me.grdImpuetos.TabIndex = 0
        Me.grdImpuetos.Text = "AzTrueDBGrid1"
        Me.grdImpuetos.PropBag = resources.GetString("grdImpuetos.PropBag")
        '
        'lblImpuestosTit
        '
        Me.lblImpuestosTit.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblImpuestosTit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpuestosTit.ForeColor = System.Drawing.Color.Red
        Me.lblImpuestosTit.Location = New System.Drawing.Point(0, 0)
        Me.lblImpuestosTit.Name = "lblImpuestosTit"
        Me.lblImpuestosTit.Size = New System.Drawing.Size(210, 20)
        Me.lblImpuestosTit.TabIndex = 87
        Me.lblImpuestosTit.Text = "Impuestos"
        Me.lblImpuestosTit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlRetenciones
        '
        Me.pnlRetenciones.BackColor = System.Drawing.Color.Transparent
        Me.pnlRetenciones.Border = True
        Me.pnlRetenciones.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlRetenciones.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlRetenciones.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlRetenciones.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlRetenciones.Controls.Add(Me.btnCloseRetencion)
        Me.pnlRetenciones.Controls.Add(Me.grdRetenciones)
        Me.pnlRetenciones.Controls.Add(Me.lblRetencionesTit)
        Me.pnlRetenciones.CornerRadius = 15
        Me.pnlRetenciones.Corners = CType(((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft), Azteca.Windows.Corner)
        Me.pnlRetenciones.Gradient = True
        Me.pnlRetenciones.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlRetenciones.GradientOffset = 1.0!
        Me.pnlRetenciones.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlRetenciones.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlRetenciones.Grayscale = False
        Me.pnlRetenciones.Image = Nothing
        Me.pnlRetenciones.ImageAlpha = 75
        Me.pnlRetenciones.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlRetenciones.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlRetenciones.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlRetenciones.Location = New System.Drawing.Point(407, 188)
        Me.pnlRetenciones.Name = "pnlRetenciones"
        Me.pnlRetenciones.Rounded = True
        Me.pnlRetenciones.Size = New System.Drawing.Size(222, 160)
        Me.pnlRetenciones.TabIndex = 110
        Me.pnlRetenciones.Visible = False
        '
        'btnCloseRetencion
        '
        Me.btnCloseRetencion.AutoLock = False
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnCloseRetencion.CenterPtTracker = DesignerRectTracker3
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))}
        CBlendItems2.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.btnCloseRetencion.ColorFillBlend = CBlendItems2
        Me.btnCloseRetencion.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.btnCloseRetencion.Corners.All = CType(6, Short)
        Me.btnCloseRetencion.Corners.LowerLeft = CType(6, Short)
        Me.btnCloseRetencion.Corners.LowerRight = CType(6, Short)
        Me.btnCloseRetencion.Corners.UpperLeft = CType(6, Short)
        Me.btnCloseRetencion.Corners.UpperRight = CType(6, Short)
        Me.btnCloseRetencion.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientLinear
        Me.btnCloseRetencion.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnCloseRetencion.FocalPoints.CenterPtX = 0.3913043!
        Me.btnCloseRetencion.FocalPoints.CenterPtY = 0.4210526!
        Me.btnCloseRetencion.FocalPoints.FocusPtX = 0.0!
        Me.btnCloseRetencion.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnCloseRetencion.FocusPtTracker = DesignerRectTracker4
        Me.btnCloseRetencion.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCloseRetencion.ForeColor = System.Drawing.Color.White
        Me.btnCloseRetencion.Image = Nothing
        Me.btnCloseRetencion.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCloseRetencion.ImageIndex = 0
        Me.btnCloseRetencion.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnCloseRetencion.Location = New System.Drawing.Point(184, 1)
        Me.btnCloseRetencion.Name = "btnCloseRetencion"
        Me.btnCloseRetencion.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.btnCloseRetencion.SideImage = Nothing
        Me.btnCloseRetencion.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCloseRetencion.SideImageSize = New System.Drawing.Size(48, 48)
        Me.btnCloseRetencion.Size = New System.Drawing.Size(23, 19)
        Me.btnCloseRetencion.TabIndex = 89
        Me.btnCloseRetencion.Text = "X"
        Me.btnCloseRetencion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCloseRetencion.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.btnCloseRetencion.TextMargin = New System.Windows.Forms.Padding(2)
        Me.btnCloseRetencion.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnCloseRetencion.UseMnemonic = True
        '
        'grdRetenciones
        '
        Me.grdRetenciones.DataSource = Me.bsRetenciones
        Me.grdRetenciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRetenciones.Images.Add(CType(resources.GetObject("grdRetenciones.Images"), System.Drawing.Image))
        Me.grdRetenciones.Location = New System.Drawing.Point(0, 21)
        Me.grdRetenciones.Name = "grdRetenciones"
        Me.grdRetenciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdRetenciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdRetenciones.PreviewInfo.ZoomFactor = 75.0R
        Me.grdRetenciones.PrintInfo.PageSettings = CType(resources.GetObject("grdRetenciones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdRetenciones.Size = New System.Drawing.Size(222, 139)
        Me.grdRetenciones.TabIndex = 0
        Me.grdRetenciones.Text = "AzTrueDBGrid1"
        Me.grdRetenciones.PropBag = resources.GetString("grdRetenciones.PropBag")
        '
        'lblRetencionesTit
        '
        Me.lblRetencionesTit.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRetencionesTit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetencionesTit.ForeColor = System.Drawing.Color.Red
        Me.lblRetencionesTit.Location = New System.Drawing.Point(0, 0)
        Me.lblRetencionesTit.Name = "lblRetencionesTit"
        Me.lblRetencionesTit.Size = New System.Drawing.Size(222, 21)
        Me.lblRetencionesTit.TabIndex = 87
        Me.lblRetencionesTit.Text = "Retenciones"
        Me.lblRetencionesTit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'selProveedor
        '
        Me.selProveedor.AnySite = False
        Me.selProveedor.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selProveedor.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selProveedor.EditorAssembly = "Azteca.ComprasWin"
        Me.selProveedor.EditorClass = "Azteca.Windows.Compras.ProveedoresForm"
        Me.selProveedor.EditorTitle = "Editar proveedores..."
        Me.selProveedor.Key = 0
        Me.selProveedor.Linked = False
        Me.selProveedor.Location = New System.Drawing.Point(22, 42)
        Me.selProveedor.Name = "selProveedor"
        Me.selProveedor.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selProveedor.Size = New System.Drawing.Size(434, 23)
        Me.selProveedor.TabIndex = 3
        Me.selProveedor.Visible = False
        '
        'selProveedorExpress
        '
        Me.selProveedorExpress.AnySite = False
        Me.selProveedorExpress.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selProveedorExpress.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selProveedorExpress.EditorAssembly = "Azteca.ComprasWin"
        Me.selProveedorExpress.EditorClass = "Azteca.Windows.Compras.ProveedoresExpressForm"
        Me.selProveedorExpress.EditorTitle = "Editar proveedores..."
        Me.selProveedorExpress.Key = 0
        Me.selProveedorExpress.Linked = False
        Me.selProveedorExpress.Location = New System.Drawing.Point(126, 16)
        Me.selProveedorExpress.Name = "selProveedorExpress"
        Me.selProveedorExpress.RequiredField = True
        Me.selProveedorExpress.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selProveedorExpress.ShowEditButton = True
        Me.selProveedorExpress.Size = New System.Drawing.Size(349, 23)
        Me.selProveedorExpress.TabIndex = 81
        Me.selProveedorExpress.TextWidth = 67
        '
        'cboDepartamento
        '
        Me.cboDepartamento.AutoClear = False
        Me.cboDepartamento.BackColor = System.Drawing.SystemColors.Window
        Me.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartamento.FormattingEnabled = True
        Me.cboDepartamento.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDepartamento.ItemsTable = Nothing
        Me.cboDepartamento.Location = New System.Drawing.Point(132, 143)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.RequiredField = True
        Me.cboDepartamento.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboDepartamento.Size = New System.Drawing.Size(262, 21)
        Me.cboDepartamento.TabIndex = 60
        Me.cboDepartamento.UIName = Nothing
        '
        'cboConcepto
        '
        Me.cboConcepto.AutoClear = False
        Me.cboConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConcepto.FormattingEnabled = True
        Me.cboConcepto.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboConcepto.ItemsTable = Nothing
        Me.cboConcepto.Location = New System.Drawing.Point(132, 168)
        Me.cboConcepto.Name = "cboConcepto"
        Me.cboConcepto.RequiredField = True
        Me.cboConcepto.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboConcepto.Size = New System.Drawing.Size(263, 21)
        Me.cboConcepto.TabIndex = 84
        Me.cboConcepto.UIName = Nothing
        '
        'cboPresupuesto
        '
        Me.cboPresupuesto.AutoClear = False
        Me.cboPresupuesto.BackColor = System.Drawing.SystemColors.Window
        Me.cboPresupuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPresupuesto.FormattingEnabled = True
        Me.cboPresupuesto.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboPresupuesto.ItemsTable = Nothing
        Me.cboPresupuesto.Location = New System.Drawing.Point(463, 143)
        Me.cboPresupuesto.Name = "cboPresupuesto"
        Me.cboPresupuesto.RequiredField = True
        Me.cboPresupuesto.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboPresupuesto.Size = New System.Drawing.Size(156, 21)
        Me.cboPresupuesto.TabIndex = 53
        Me.cboPresupuesto.UIName = Nothing
        '
        'GastosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 576)
        Me.CodeFieldLocation = New System.Drawing.Point(20, 61)
        Me.Controls.Add(Me.tabGastoDetalle)
        Me.Name = "GastosForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.tabGastoDetalle, 0)
        Me.gbxBeneficiario.ResumeLayout(False)
        Me.gbxBeneficiario.PerformLayout()
        Me.gbxModalidad.ResumeLayout(False)
        Me.gbxModalidad.PerformLayout()
        CType(Me.bsImpuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRetenciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCFD.ResumeLayout(False)
        Me.gbxCFD.PerformLayout()
        CType(Me.upDownAnioAprobacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabGastoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGastoDetalle.ResumeLayout(False)
        Me.pagCajas.ResumeLayout(False)
        Me.pagCajas.PerformLayout()
        Me.pnlImpuestos.ResumeLayout(False)
        CType(Me.grdImpuetos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRetenciones.ResumeLayout(False)
        CType(Me.grdRetenciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboDepartamento As Azteca.Windows.Compras.DepartamentoComboBox
    Friend WithEvents lblDepartamento As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboPresupuesto As Azteca.Windows.Compras.PresupuestoComboBox
    Friend WithEvents lblPresupuesto As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCategoriaPresupuestal As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblConcepto As Azteca.Windows.Controls.CILabel
    Friend WithEvents gbxBeneficiario As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents optOtro As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents optProveedor As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents optEmpleado As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents gbxModalidad As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents optComprobacion As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents optReposicion As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents lblBeneficiario As Azteca.Windows.Controls.CILabel
    Friend WithEvents optModalidad As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtSubtotal As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblSubtotal As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblImpuestos As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblRetenciones As Azteca.Windows.Controls.CILabel
    Friend WithEvents selProveedor As Azteca.Windows.Compras.ProveedoresSelector
    Friend WithEvents lblTotal As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtTotal As Azteca.Windows.Controls.CILabel
    Friend WithEvents iLst32 As System.Windows.Forms.ImageList
    Friend WithEvents lblComprobante As Azteca.Windows.Controls.CILabel
    Friend WithEvents gbxCFD As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents txtNumAprobacion As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNumAprobacion As Azteca.Windows.Controls.CILabel
    Friend WithEvents upDownAnioAprobacion As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents lblAnioAprobacion As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtFactura As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtSerie As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblSerie As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblProveedorServ As Azteca.Windows.Controls.CILabel

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New GastoFacade

        Me.SetDocumentType("Gasto")
        LicenseModule = Kernel.Licensing.LicenseModule.Purchasing
    End Sub
    Friend WithEvents lblMoneda As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboMoneda As Azteca.Windows.Contabilidad.DivisasComboBox
    Friend WithEvents selEmpleado As Azteca.Windows.RH.EmpleadoSelector
    Friend WithEvents cboConcepto As Azteca.Windows.Compras.ConceptoGastosComboBox
    Friend WithEvents txtRetenciones As Azteca.Windows.Controls.CILinkLabel
    Friend WithEvents txtImpuestos As Azteca.Windows.Controls.CILinkLabel
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents bsImpuestos As System.Windows.Forms.BindingSource
    Friend WithEvents bsRetenciones As System.Windows.Forms.BindingSource
    Friend WithEvents selProveedorExpress As Azteca.Windows.Compras.ProveedorExpressSelector
    Friend WithEvents chkDigital As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents lblAprobacion As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblObservaciones As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtObervaciones As Azteca.Windows.Controls.CITextBox
    Friend WithEvents selBeneficiario As Azteca.Windows.Tesoreria.BeneficiarioSelector
    Friend WithEvents tabGastoDetalle As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagCajas As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pnlImpuestos As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents btnCloseImpuesto As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents grdImpuetos As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents lblImpuestosTit As Azteca.Windows.Controls.CILabel
    Friend WithEvents pnlRetenciones As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents btnCloseRetencion As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents grdRetenciones As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents lblRetencionesTit As Azteca.Windows.Controls.CILabel
End Class
