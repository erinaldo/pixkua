<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CapturaGastosForm
    Inherits System.Windows.Forms.Form

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
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CapturaGastosForm))
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim DesignerRectTracker3 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems2 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker4 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim DesignerRectTracker1 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems1 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker2 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Me.tlbMenu = New C1.Win.C1Command.C1ToolBar()
        Me.btnGuardar = New C1.Win.C1Command.C1CommandLink()
        Me.cmdGuardar = New C1.Win.C1Command.C1Command()
        Me.btnCancelar = New C1.Win.C1Command.C1CommandLink()
        Me.cmdCancelar = New C1.Win.C1Command.C1Command()
        Me.txtObervaciones = New Azteca.Windows.Controls.CITextBox()
        Me.lblObservaciones = New Azteca.Windows.Controls.CILabel()
        Me.lblPresupuesto = New Azteca.Windows.Controls.CILabel()
        Me.lblMoneda = New Azteca.Windows.Controls.CILabel()
        Me.cboMoneda = New Azteca.Windows.Contabilidad.DivisasComboBox()
        Me.gbxBeneficiario = New Azteca.Windows.Controls.CIGroupBox()
        Me.selBeneficiario = New Azteca.Windows.Tesoreria.BeneficiarioSelector()
        Me.selEmpleado = New Azteca.Windows.RH.EmpleadoSelector()
        Me.selProveedor = New Azteca.Windows.Compras.ProveedoresSelector()
        Me.optOtro = New Azteca.Windows.Controls.CIRadioButton()
        Me.optProveedor = New Azteca.Windows.Controls.CIRadioButton()
        Me.optEmpleado = New Azteca.Windows.Controls.CIRadioButton()
        Me.lblDepartamento = New Azteca.Windows.Controls.CILabel()
        Me.gbxModalidad = New Azteca.Windows.Controls.CIGroupBox()
        Me.optComprobacion = New Azteca.Windows.Controls.CIRadioButton()
        Me.optReposicion = New Azteca.Windows.Controls.CIRadioButton()
        Me.optModalidad = New Azteca.Windows.Controls.CILabel()
        Me.lblBeneficiario = New Azteca.Windows.Controls.CILabel()
        Me.cboConcepto = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsConceptos = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdGastos = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsGastos = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.bsImpuestos = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsRetenciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlImpuestos = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.btnCloseImpuesto = New Azteca.Windows.Controls.ButtonPlus()
        Me.grdImpuetos = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.lblImpuestosTit = New Azteca.Windows.Controls.CILabel()
        Me.pnlRetenciones = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.btnCloseRetencion = New Azteca.Windows.Controls.ButtonPlus()
        Me.grdRetenciones = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.lblRetencionesTit = New Azteca.Windows.Controls.CILabel()
        Me.gbxTitulo = New Azteca.Windows.Controls.CIGroupBox()
        Me.cboPresupuesto = New Azteca.Windows.Compras.PresupuestoComboBox()
        Me.cboDepartamento = New Azteca.Windows.Compras.DepartamentoComboBox()
        Me.gbxBeneficiario.SuspendLayout()
        Me.gbxModalidad.SuspendLayout()
        CType(Me.cboConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsImpuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRetenciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlImpuestos.SuspendLayout()
        CType(Me.grdImpuetos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRetenciones.SuspendLayout()
        CType(Me.grdRetenciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlbMenu
        '
        Me.tlbMenu.AccessibleName = "Tool Bar"
        Me.tlbMenu.AutoSize = False
        Me.tlbMenu.CommandHolder = Nothing
        Me.tlbMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnGuardar, Me.btnCancelar})
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.MinButtonSize = 32
        Me.tlbMenu.Movable = False
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(1257, 31)
        Me.tlbMenu.Text = "C1ToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.System
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.System
        '
        'btnGuardar
        '
        Me.btnGuardar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnGuardar.Command = Me.cmdGuardar
        Me.btnGuardar.Text = "Guardar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Image = Global.Azteca.Windows.Compras.My.Resources.Resources.filesave1
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.ShortcutText = ""
        Me.cmdGuardar.Text = "&Save"
        '
        'btnCancelar
        '
        Me.btnCancelar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnCancelar.Command = Me.cmdCancelar
        Me.btnCancelar.SortOrder = 1
        Me.btnCancelar.Text = "Cancelar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = Global.Azteca.Windows.Compras.My.Resources.Resources.Close_32
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.ShortcutText = ""
        Me.cmdCancelar.Text = "Cancelar"
        '
        'txtObervaciones
        '
        Me.txtObervaciones.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtObervaciones.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtObervaciones.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtObervaciones.Location = New System.Drawing.Point(6, 71)
        Me.txtObervaciones.MaxLength = 128
        Me.txtObervaciones.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObervaciones.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObervaciones.Multiline = True
        Me.txtObervaciones.Name = "txtObervaciones"
        Me.txtObervaciones.Size = New System.Drawing.Size(486, 22)
        Me.txtObervaciones.TabIndex = 4
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(30, 210)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(78, 13)
        Me.lblObservaciones.TabIndex = 8
        Me.lblObservaciones.Text = "Observaciones"
        '
        'lblPresupuesto
        '
        Me.lblPresupuesto.AutoSize = True
        Me.lblPresupuesto.Location = New System.Drawing.Point(273, 20)
        Me.lblPresupuesto.Name = "lblPresupuesto"
        Me.lblPresupuesto.Size = New System.Drawing.Size(66, 13)
        Me.lblPresupuesto.TabIndex = 1
        Me.lblPresupuesto.Text = "Presupuesto"
        '
        'lblMoneda
        '
        Me.lblMoneda.AutoSize = True
        Me.lblMoneda.Location = New System.Drawing.Point(30, 183)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(46, 13)
        Me.lblMoneda.TabIndex = 7
        Me.lblMoneda.Text = "Moneda"
        '
        'cboMoneda
        '
        Me.cboMoneda.AutoClear = False
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboMoneda.ItemsTable = Nothing
        Me.cboMoneda.Location = New System.Drawing.Point(6, 44)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.RequiredField = True
        Me.cboMoneda.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboMoneda.Size = New System.Drawing.Size(262, 21)
        Me.cboMoneda.TabIndex = 3
        Me.cboMoneda.UIName = Nothing
        '
        'gbxBeneficiario
        '
        Me.gbxBeneficiario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxBeneficiario.Controls.Add(Me.selBeneficiario)
        Me.gbxBeneficiario.Controls.Add(Me.selEmpleado)
        Me.gbxBeneficiario.Controls.Add(Me.selProveedor)
        Me.gbxBeneficiario.Controls.Add(Me.optOtro)
        Me.gbxBeneficiario.Controls.Add(Me.optProveedor)
        Me.gbxBeneficiario.Controls.Add(Me.optEmpleado)
        Me.gbxBeneficiario.Location = New System.Drawing.Point(115, 29)
        Me.gbxBeneficiario.Name = "gbxBeneficiario"
        Me.gbxBeneficiario.Size = New System.Drawing.Size(643, 71)
        Me.gbxBeneficiario.TabIndex = 1
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
        Me.selBeneficiario.Location = New System.Drawing.Point(23, 42)
        Me.selBeneficiario.Name = "selBeneficiario"
        Me.selBeneficiario.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selBeneficiario.Size = New System.Drawing.Size(469, 23)
        Me.selBeneficiario.TabIndex = 4
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
        Me.selEmpleado.TabIndex = 3
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
        'optOtro
        '
        Me.optOtro.AutoSize = True
        Me.optOtro.Location = New System.Drawing.Point(350, 19)
        Me.optOtro.Name = "optOtro"
        Me.optOtro.Size = New System.Drawing.Size(45, 17)
        Me.optOtro.TabIndex = 2
        Me.optOtro.Text = "Otro"
        Me.optOtro.UseVisualStyleBackColor = True
        '
        'optProveedor
        '
        Me.optProveedor.AutoSize = True
        Me.optProveedor.Location = New System.Drawing.Point(188, 19)
        Me.optProveedor.Name = "optProveedor"
        Me.optProveedor.Size = New System.Drawing.Size(74, 17)
        Me.optProveedor.TabIndex = 1
        Me.optProveedor.Text = "Proveedor"
        Me.optProveedor.UseVisualStyleBackColor = True
        '
        'optEmpleado
        '
        Me.optEmpleado.AutoSize = True
        Me.optEmpleado.Checked = True
        Me.optEmpleado.Location = New System.Drawing.Point(18, 19)
        Me.optEmpleado.Name = "optEmpleado"
        Me.optEmpleado.Size = New System.Drawing.Size(72, 17)
        Me.optEmpleado.TabIndex = 0
        Me.optEmpleado.TabStop = True
        Me.optEmpleado.Text = "Empleado"
        Me.optEmpleado.UseVisualStyleBackColor = True
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(30, 156)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(74, 13)
        Me.lblDepartamento.TabIndex = 6
        Me.lblDepartamento.Text = "Departamento"
        '
        'gbxModalidad
        '
        Me.gbxModalidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxModalidad.Controls.Add(Me.optComprobacion)
        Me.gbxModalidad.Controls.Add(Me.optReposicion)
        Me.gbxModalidad.Location = New System.Drawing.Point(115, 101)
        Me.gbxModalidad.Name = "gbxModalidad"
        Me.gbxModalidad.Size = New System.Drawing.Size(643, 36)
        Me.gbxModalidad.TabIndex = 4
        Me.gbxModalidad.TabStop = False
        '
        'optComprobacion
        '
        Me.optComprobacion.AutoSize = True
        Me.optComprobacion.Location = New System.Drawing.Point(188, 12)
        Me.optComprobacion.Name = "optComprobacion"
        Me.optComprobacion.Size = New System.Drawing.Size(93, 17)
        Me.optComprobacion.TabIndex = 1
        Me.optComprobacion.Text = "Comprobación"
        Me.optComprobacion.UseVisualStyleBackColor = True
        '
        'optReposicion
        '
        Me.optReposicion.AutoSize = True
        Me.optReposicion.Checked = True
        Me.optReposicion.Location = New System.Drawing.Point(18, 12)
        Me.optReposicion.Name = "optReposicion"
        Me.optReposicion.Size = New System.Drawing.Size(78, 17)
        Me.optReposicion.TabIndex = 0
        Me.optReposicion.TabStop = True
        Me.optReposicion.Text = "Reposicion"
        Me.optReposicion.UseVisualStyleBackColor = True
        '
        'optModalidad
        '
        Me.optModalidad.AutoSize = True
        Me.optModalidad.Location = New System.Drawing.Point(30, 115)
        Me.optModalidad.Name = "optModalidad"
        Me.optModalidad.Size = New System.Drawing.Size(56, 13)
        Me.optModalidad.TabIndex = 2
        Me.optModalidad.Text = "Modalidad"
        '
        'lblBeneficiario
        '
        Me.lblBeneficiario.AutoSize = True
        Me.lblBeneficiario.Location = New System.Drawing.Point(30, 48)
        Me.lblBeneficiario.Name = "lblBeneficiario"
        Me.lblBeneficiario.Size = New System.Drawing.Size(62, 13)
        Me.lblBeneficiario.TabIndex = 0
        Me.lblBeneficiario.Text = "Beneficiario"
        '
        'cboConcepto
        '
        Me.cboConcepto.AllowColMove = True
        Me.cboConcepto.AllowColSelect = True
        Me.cboConcepto.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboConcepto.AlternatingRows = True
        Me.cboConcepto.CaptionStyle = Style1
        Me.cboConcepto.ColumnCaptionHeight = 17
        Me.cboConcepto.ColumnFooterHeight = 17
        Me.cboConcepto.DataSource = Me.bsConceptos
        Me.cboConcepto.DisplayMember = "Concepto"
        Me.cboConcepto.EvenRowStyle = Style2
        Me.cboConcepto.ExtendRightColumn = True
        Me.cboConcepto.FetchRowStyles = False
        Me.cboConcepto.FooterStyle = Style3
        Me.cboConcepto.HeadingStyle = Style4
        Me.cboConcepto.HighLightRowStyle = Style5
        Me.cboConcepto.Images.Add(CType(resources.GetObject("cboConcepto.Images"), System.Drawing.Image))
        Me.cboConcepto.Location = New System.Drawing.Point(59, 266)
        Me.cboConcepto.Name = "cboConcepto"
        Me.cboConcepto.OddRowStyle = Style6
        Me.cboConcepto.RecordSelectorStyle = Style7
        Me.cboConcepto.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboConcepto.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboConcepto.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboConcepto.ScrollTips = False
        Me.cboConcepto.Size = New System.Drawing.Size(328, 147)
        Me.cboConcepto.Style = Style8
        Me.cboConcepto.TabIndex = 104
        Me.cboConcepto.TabStop = False
        Me.cboConcepto.Text = "C1TrueDBDropdown1"
        Me.cboConcepto.ValueMember = "IdGastoConcepto"
        Me.cboConcepto.ValueTranslate = True
        Me.cboConcepto.Visible = False
        Me.cboConcepto.PropBag = resources.GetString("cboConcepto.PropBag")
        '
        'grdGastos
        '
        Me.grdGastos.AllowAddNew = True
        Me.grdGastos.AllowDelete = True
        Me.grdGastos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdGastos.CellTips = C1.Win.C1TrueDBGrid.CellTipEnum.Anchored
        Me.grdGastos.ColumnFooters = True
        Me.grdGastos.DataSource = Me.bsGastos
        Me.grdGastos.Images.Add(CType(resources.GetObject("grdGastos.Images"), System.Drawing.Image))
        Me.grdGastos.Images.Add(CType(resources.GetObject("grdGastos.Images1"), System.Drawing.Image))
        Me.grdGastos.Images.Add(CType(resources.GetObject("grdGastos.Images2"), System.Drawing.Image))
        Me.grdGastos.Location = New System.Drawing.Point(2, 243)
        Me.grdGastos.Name = "grdGastos"
        Me.grdGastos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdGastos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdGastos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdGastos.PrintInfo.PageSettings = CType(resources.GetObject("grdGastos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdGastos.Size = New System.Drawing.Size(1254, 263)
        Me.grdGastos.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.GridNavigation
        Me.grdGastos.TabIndex = 9
        Me.grdGastos.Text = "AzTrueDBGrid1"
        Me.grdGastos.PropBag = resources.GetString("grdGastos.PropBag")
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdGuardar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCancelar)
        Me.C1CommandHolder1.Owner = Me
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
        Me.pnlImpuestos.Location = New System.Drawing.Point(691, 62)
        Me.pnlImpuestos.Name = "pnlImpuestos"
        Me.pnlImpuestos.Rounded = True
        Me.pnlImpuestos.Size = New System.Drawing.Size(210, 160)
        Me.pnlImpuestos.TabIndex = 107
        Me.pnlImpuestos.Visible = False
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.SystemColors.ActiveCaption
        Me.ColorWithAlpha1.Parent = Me.pnlRetenciones
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.SystemColors.ActiveCaptionText
        Me.ColorWithAlpha2.Parent = Me.pnlRetenciones
        '
        'btnCloseImpuesto
        '
        Me.btnCloseImpuesto.AutoLock = False
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnCloseImpuesto.CenterPtTracker = DesignerRectTracker3
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))}
        CBlendItems2.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.btnCloseImpuesto.ColorFillBlend = CBlendItems2
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
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnCloseImpuesto.FocusPtTracker = DesignerRectTracker4
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
        Me.pnlRetenciones.Location = New System.Drawing.Point(907, 62)
        Me.pnlRetenciones.Name = "pnlRetenciones"
        Me.pnlRetenciones.Rounded = True
        Me.pnlRetenciones.Size = New System.Drawing.Size(222, 160)
        Me.pnlRetenciones.TabIndex = 109
        Me.pnlRetenciones.Visible = False
        '
        'btnCloseRetencion
        '
        Me.btnCloseRetencion.AutoLock = False
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnCloseRetencion.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.btnCloseRetencion.ColorFillBlend = CBlendItems1
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
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnCloseRetencion.FocusPtTracker = DesignerRectTracker2
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
        'gbxTitulo
        '
        Me.gbxTitulo.Controls.Add(Me.cboPresupuesto)
        Me.gbxTitulo.Controls.Add(Me.cboDepartamento)
        Me.gbxTitulo.Controls.Add(Me.cboMoneda)
        Me.gbxTitulo.Controls.Add(Me.lblPresupuesto)
        Me.gbxTitulo.Controls.Add(Me.txtObervaciones)
        Me.gbxTitulo.Location = New System.Drawing.Point(115, 136)
        Me.gbxTitulo.Name = "gbxTitulo"
        Me.gbxTitulo.Size = New System.Drawing.Size(522, 100)
        Me.gbxTitulo.TabIndex = 5
        Me.gbxTitulo.TabStop = False
        '
        'cboPresupuesto
        '
        Me.cboPresupuesto.AutoClear = False
        Me.cboPresupuesto.BackColor = System.Drawing.SystemColors.Window
        Me.cboPresupuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPresupuesto.FormattingEnabled = True
        Me.cboPresupuesto.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboPresupuesto.ItemsTable = Nothing
        Me.cboPresupuesto.Location = New System.Drawing.Point(337, 17)
        Me.cboPresupuesto.Name = "cboPresupuesto"
        Me.cboPresupuesto.RequiredField = True
        Me.cboPresupuesto.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboPresupuesto.Size = New System.Drawing.Size(156, 21)
        Me.cboPresupuesto.TabIndex = 2
        Me.cboPresupuesto.UIName = Nothing
        '
        'cboDepartamento
        '
        Me.cboDepartamento.AutoClear = False
        Me.cboDepartamento.BackColor = System.Drawing.SystemColors.Window
        Me.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartamento.FormattingEnabled = True
        Me.cboDepartamento.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDepartamento.ItemsTable = Nothing
        Me.cboDepartamento.Location = New System.Drawing.Point(6, 17)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.RequiredField = True
        Me.cboDepartamento.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboDepartamento.Size = New System.Drawing.Size(262, 21)
        Me.cboDepartamento.TabIndex = 0
        Me.cboDepartamento.UIName = Nothing
        '
        'CapturaGastosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 507)
        Me.Controls.Add(Me.gbxTitulo)
        Me.Controls.Add(Me.pnlRetenciones)
        Me.Controls.Add(Me.lblDepartamento)
        Me.Controls.Add(Me.pnlImpuestos)
        Me.Controls.Add(Me.cboConcepto)
        Me.Controls.Add(Me.lblMoneda)
        Me.Controls.Add(Me.grdGastos)
        Me.Controls.Add(Me.gbxBeneficiario)
        Me.Controls.Add(Me.gbxModalidad)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.optModalidad)
        Me.Controls.Add(Me.lblBeneficiario)
        Me.Controls.Add(Me.tlbMenu)
        Me.Name = "CapturaGastosForm"
        Me.Text = "Captura de Gastos Multiples..."
        Me.gbxBeneficiario.ResumeLayout(False)
        Me.gbxBeneficiario.PerformLayout()
        Me.gbxModalidad.ResumeLayout(False)
        Me.gbxModalidad.PerformLayout()
        CType(Me.cboConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsImpuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRetenciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlImpuestos.ResumeLayout(False)
        CType(Me.grdImpuetos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRetenciones.ResumeLayout(False)
        CType(Me.grdRetenciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxTitulo.ResumeLayout(False)
        Me.gbxTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlbMenu As C1.Win.C1Command.C1ToolBar
    Friend WithEvents btnGuardar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnCancelar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents txtObervaciones As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblObservaciones As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboPresupuesto As Azteca.Windows.Compras.PresupuestoComboBox
    Friend WithEvents lblPresupuesto As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblMoneda As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboMoneda As Azteca.Windows.Contabilidad.DivisasComboBox
    Friend WithEvents gbxBeneficiario As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents selEmpleado As Azteca.Windows.RH.EmpleadoSelector
    Friend WithEvents selProveedor As Azteca.Windows.Compras.ProveedoresSelector
    Friend WithEvents optOtro As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents optProveedor As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents optEmpleado As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents lblDepartamento As Azteca.Windows.Controls.CILabel
    Friend WithEvents gbxModalidad As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents optComprobacion As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents optReposicion As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents cboDepartamento As Azteca.Windows.Compras.DepartamentoComboBox
    Friend WithEvents optModalidad As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblBeneficiario As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboConcepto As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents grdGastos As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents bsImpuestos As System.Windows.Forms.BindingSource
    Friend WithEvents bsRetenciones As System.Windows.Forms.BindingSource
    Friend WithEvents pnlImpuestos As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents grdImpuetos As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents lblImpuestosTit As Azteca.Windows.Controls.CILabel
    Private WithEvents cmdGuardar As C1.Win.C1Command.C1Command
    Private WithEvents cmdCancelar As C1.Win.C1Command.C1Command
    Private WithEvents bsGastos As System.Windows.Forms.BindingSource
    Private WithEvents bsConceptos As System.Windows.Forms.BindingSource
    Friend WithEvents pnlRetenciones As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents grdRetenciones As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents lblRetencionesTit As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnCloseImpuesto As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents btnCloseRetencion As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents gbxTitulo As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents selBeneficiario As Azteca.Windows.Tesoreria.BeneficiarioSelector
End Class
