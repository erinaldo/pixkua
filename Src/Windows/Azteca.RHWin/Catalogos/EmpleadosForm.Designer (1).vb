<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpleadosForm
    Inherits Azteca.Windows.Forms.BusinessForms.CatalogForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmpleadosForm))
        Me.lblNombreCorto = New Azteca.Windows.Controls.CILabel()
        Me.txtNombreCorto = New Azteca.Windows.Controls.CITextBox()
        Me.lblTurno = New Azteca.Windows.Controls.CILabel()
        Me.lblCodigoChecador = New Azteca.Windows.Controls.CILabel()
        Me.lblFechaInicio = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.iLstTabs = New System.Windows.Forms.ImageList(Me.components)
        Me.tabEmpleados = New Azteca.Windows.Controls.CITab()
        Me.tabGenerales = New System.Windows.Forms.TabPage()
        Me.txtApellidoM = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.txtCorreo = New Azteca.Windows.Controls.CITextBox()
        Me.txtCelular = New Azteca.Windows.Controls.CITextBox()
        Me.txtTelOficina = New Azteca.Windows.Controls.CITextBox()
        Me.txtTelCasa = New Azteca.Windows.Controls.CITextBox()
        Me.txtApellidoP = New Azteca.Windows.Controls.CITextBox()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.lblCorreo = New Azteca.Windows.Controls.CILabel()
        Me.lblCelular = New Azteca.Windows.Controls.CILabel()
        Me.lblTelOficina = New Azteca.Windows.Controls.CILabel()
        Me.lblTelCasa = New Azteca.Windows.Controls.CILabel()
        Me.lblApellidos = New Azteca.Windows.Controls.CILabel()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.chkActivo = New Azteca.Windows.Controls.CICheckBox()
        Me.dtpFechaNacimiento = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.lblfechaNacimiento = New Azteca.Windows.Controls.CILabel()
        Me.lblSexo = New Azteca.Windows.Controls.CILabel()
        Me.rbtnFemenino = New Azteca.Windows.Controls.CIRadioButton()
        Me.rbtnMasculino = New Azteca.Windows.Controls.CIRadioButton()
        Me.tabDomicilio = New System.Windows.Forms.TabPage()
        Me.txtNumInt = New Azteca.Windows.Controls.CITextBox()
        Me.lblNumInt = New Azteca.Windows.Controls.CILabel()
        Me.txtPoblacion = New Azteca.Windows.Controls.General.PoblacionSelector()
        Me.lblEstadoInf = New Azteca.Windows.Controls.CILabel()
        Me.lblEstado = New Azteca.Windows.Controls.CILabel()
        Me.txtCP = New Azteca.Windows.Controls.CITextBox()
        Me.txtColonia = New Azteca.Windows.Controls.CITextBox()
        Me.txtNumExt = New Azteca.Windows.Controls.CITextBox()
        Me.txtCalle = New Azteca.Windows.Controls.CITextBox()
        Me.lblPoblacion = New Azteca.Windows.Controls.CILabel()
        Me.lblCodigoPostal = New Azteca.Windows.Controls.CILabel()
        Me.lblNumExt = New Azteca.Windows.Controls.CILabel()
        Me.lblColonia = New Azteca.Windows.Controls.CILabel()
        Me.lblCalle = New Azteca.Windows.Controls.CILabel()
        Me.tabLaboral = New System.Windows.Forms.TabPage()
        Me.txtRFC = New Azteca.Windows.Controls.CITextBox()
        Me.lblRFC = New Azteca.Windows.Controls.CILabel()
        Me.txtCURP = New Azteca.Windows.Controls.CITextBox()
        Me.lblCURP = New Azteca.Windows.Controls.CILabel()
        Me.txtIMSS = New Azteca.Windows.Controls.CITextBox()
        Me.lblIMSS = New Azteca.Windows.Controls.CILabel()
        Me.lblHoraExtra = New Azteca.Windows.Controls.CILabel()
        Me.CiTextBox1 = New Azteca.Windows.Controls.CITextBox()
        Me.lblSueldo = New Azteca.Windows.Controls.CILabel()
        Me.txtSueldo = New Azteca.Windows.Controls.CITextBox()
        Me.lblPuesto = New Azteca.Windows.Controls.CILabel()
        Me.selPuesto = New Azteca.Windows.RH.PuestoSelector()
        Me.lblDepartamento = New Azteca.Windows.Controls.CILabel()
        Me.selDepartamento = New Azteca.Windows.RH.DepartamentoSelector()
        Me.dtpFechaIngreso = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.dtpFechaInicio = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.txtTitulo = New Azteca.Windows.Controls.CITextBox()
        Me.lblTitulo = New Azteca.Windows.Controls.CILabel()
        Me.tabChecador = New System.Windows.Forms.TabPage()
        Me.lblTurnoActual = New Azteca.Windows.Controls.CILabel()
        Me.CiButton1 = New Azteca.Windows.Controls.CIButton()
        Me.txtCodigoChecador = New Azteca.Windows.Controls.CITextBox()
        Me.tabFoto = New System.Windows.Forms.TabPage()
        Me.lbImagen = New Azteca.Windows.Controls.CILabel()
        Me.picEmpleado = New Azteca.Windows.Controls.CIPictureManager()
        Me.tabEmpleados.SuspendLayout()
        Me.tabGenerales.SuspendLayout()
        Me.tabDomicilio.SuspendLayout()
        Me.tabLaboral.SuspendLayout()
        Me.tabChecador.SuspendLayout()
        Me.tabFoto.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombreCorto
        '
        Me.lblNombreCorto.AutoSize = True
        Me.lblNombreCorto.Location = New System.Drawing.Point(33, 73)
        Me.lblNombreCorto.Name = "lblNombreCorto"
        Me.lblNombreCorto.Size = New System.Drawing.Size(71, 13)
        Me.lblNombreCorto.TabIndex = 21
        Me.lblNombreCorto.Text = "Nombre corto"
        '
        'txtNombreCorto
        '
        Me.txtNombreCorto.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombreCorto.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombreCorto.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombreCorto.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombreCorto.Location = New System.Drawing.Point(127, 69)
        Me.txtNombreCorto.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreCorto.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreCorto.Name = "txtNombreCorto"
        Me.txtNombreCorto.Size = New System.Drawing.Size(280, 20)
        Me.txtNombreCorto.TabIndex = 22
        Me.txtNombreCorto.UIName = "Nombre"
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Location = New System.Drawing.Point(33, 98)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(72, 13)
        Me.lblTurno.TabIndex = 23
        Me.lblTurno.Text = "Turno Default"
        '
        'lblCodigoChecador
        '
        Me.lblCodigoChecador.AutoSize = True
        Me.lblCodigoChecador.Location = New System.Drawing.Point(33, 48)
        Me.lblCodigoChecador.Name = "lblCodigoChecador"
        Me.lblCodigoChecador.Size = New System.Drawing.Size(88, 13)
        Me.lblCodigoChecador.TabIndex = 24
        Me.lblCodigoChecador.Text = "Código checador"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(39, 56)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(65, 13)
        Me.lblFechaInicio.TabIndex = 25
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(39, 81)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(75, 13)
        Me.CiLabel1.TabIndex = 26
        Me.CiLabel1.Text = "Fecha Ingreso"
        '
        'iLstTabs
        '
        Me.iLstTabs.ImageStream = CType(resources.GetObject("iLstTabs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLstTabs.TransparentColor = System.Drawing.Color.Transparent
        Me.iLstTabs.Images.SetKeyName(0, "mask_32.png")
        Me.iLstTabs.Images.SetKeyName(1, "administrator_32.png")
        Me.iLstTabs.Images.SetKeyName(2, "book_32.png")
        Me.iLstTabs.Images.SetKeyName(3, "hand_32.png")
        Me.iLstTabs.Images.SetKeyName(4, "home_32.png")
        '
        'tabEmpleados
        '
        Me.tabEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabEmpleados.Controls.Add(Me.tabGenerales)
        Me.tabEmpleados.Controls.Add(Me.tabDomicilio)
        Me.tabEmpleados.Controls.Add(Me.tabLaboral)
        Me.tabEmpleados.Controls.Add(Me.tabChecador)
        Me.tabEmpleados.Controls.Add(Me.tabFoto)
        Me.tabEmpleados.ImageList = Me.iLstTabs
        Me.tabEmpleados.Location = New System.Drawing.Point(12, 88)
        Me.tabEmpleados.Name = "tabEmpleados"
        Me.tabEmpleados.SelectedIndex = 0
        Me.tabEmpleados.Size = New System.Drawing.Size(593, 320)
        Me.tabEmpleados.TabIndex = 28
        '
        'tabGenerales
        '
        Me.tabGenerales.Controls.Add(Me.txtApellidoM)
        Me.tabGenerales.Controls.Add(Me.CiLabel2)
        Me.tabGenerales.Controls.Add(Me.txtCorreo)
        Me.tabGenerales.Controls.Add(Me.txtCelular)
        Me.tabGenerales.Controls.Add(Me.txtTelOficina)
        Me.tabGenerales.Controls.Add(Me.txtTelCasa)
        Me.tabGenerales.Controls.Add(Me.txtApellidoP)
        Me.tabGenerales.Controls.Add(Me.txtNombre)
        Me.tabGenerales.Controls.Add(Me.lblCorreo)
        Me.tabGenerales.Controls.Add(Me.lblCelular)
        Me.tabGenerales.Controls.Add(Me.lblTelOficina)
        Me.tabGenerales.Controls.Add(Me.lblTelCasa)
        Me.tabGenerales.Controls.Add(Me.lblApellidos)
        Me.tabGenerales.Controls.Add(Me.lblNombre)
        Me.tabGenerales.Controls.Add(Me.CiLabel5)
        Me.tabGenerales.Controls.Add(Me.selCuenta)
        Me.tabGenerales.Controls.Add(Me.chkActivo)
        Me.tabGenerales.Controls.Add(Me.dtpFechaNacimiento)
        Me.tabGenerales.Controls.Add(Me.lblfechaNacimiento)
        Me.tabGenerales.Controls.Add(Me.lblSexo)
        Me.tabGenerales.Controls.Add(Me.rbtnFemenino)
        Me.tabGenerales.Controls.Add(Me.rbtnMasculino)
        Me.tabGenerales.ImageIndex = 1
        Me.tabGenerales.Location = New System.Drawing.Point(4, 39)
        Me.tabGenerales.Name = "tabGenerales"
        Me.tabGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGenerales.Size = New System.Drawing.Size(585, 277)
        Me.tabGenerales.TabIndex = 0
        Me.tabGenerales.Text = "Datos Generales"
        Me.tabGenerales.UseVisualStyleBackColor = True
        '
        'txtApellidoM
        '
        Me.txtApellidoM.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtApellidoM.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtApellidoM.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtApellidoM.Location = New System.Drawing.Point(134, 59)
        Me.txtApellidoM.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtApellidoM.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtApellidoM.Name = "txtApellidoM"
        Me.txtApellidoM.RequiredField = True
        Me.txtApellidoM.Size = New System.Drawing.Size(186, 20)
        Me.txtApellidoM.TabIndex = 39
        Me.txtApellidoM.UIName = "Apellido Materno"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(41, 62)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(89, 13)
        Me.CiLabel2.TabIndex = 38
        Me.CiLabel2.Text = "Apellido Materno:"
        '
        'txtCorreo
        '
        Me.txtCorreo.CharacterCasing = Azteca.Windows.Controls.CaseType.Lower
        Me.txtCorreo.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCorreo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCorreo.Location = New System.Drawing.Point(134, 151)
        Me.txtCorreo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCorreo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(264, 20)
        Me.txtCorreo.TabIndex = 47
        Me.txtCorreo.UIName = Nothing
        '
        'txtCelular
        '
        Me.txtCelular.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCelular.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCelular.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCelular.Location = New System.Drawing.Point(134, 128)
        Me.txtCelular.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCelular.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(125, 20)
        Me.txtCelular.TabIndex = 45
        Me.txtCelular.UIName = Nothing
        '
        'txtTelOficina
        '
        Me.txtTelOficina.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtTelOficina.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtTelOficina.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTelOficina.Location = New System.Drawing.Point(134, 105)
        Me.txtTelOficina.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelOficina.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelOficina.Name = "txtTelOficina"
        Me.txtTelOficina.Size = New System.Drawing.Size(125, 20)
        Me.txtTelOficina.TabIndex = 43
        Me.txtTelOficina.UIName = Nothing
        '
        'txtTelCasa
        '
        Me.txtTelCasa.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtTelCasa.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtTelCasa.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTelCasa.Location = New System.Drawing.Point(134, 82)
        Me.txtTelCasa.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelCasa.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.Size = New System.Drawing.Size(125, 20)
        Me.txtTelCasa.TabIndex = 41
        Me.txtTelCasa.UIName = Nothing
        '
        'txtApellidoP
        '
        Me.txtApellidoP.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtApellidoP.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtApellidoP.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtApellidoP.Location = New System.Drawing.Point(134, 36)
        Me.txtApellidoP.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtApellidoP.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtApellidoP.Name = "txtApellidoP"
        Me.txtApellidoP.RequiredField = True
        Me.txtApellidoP.Size = New System.Drawing.Size(186, 20)
        Me.txtApellidoP.TabIndex = 37
        Me.txtApellidoP.UIName = "Apellido Paterno"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(134, 13)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(264, 20)
        Me.txtNombre.TabIndex = 35
        Me.txtNombre.UIName = "Nombre"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(41, 154)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(41, 13)
        Me.lblCorreo.TabIndex = 46
        Me.lblCorreo.Text = "Correo:"
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(41, 131)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(42, 13)
        Me.lblCelular.TabIndex = 44
        Me.lblCelular.Text = "Celular:"
        '
        'lblTelOficina
        '
        Me.lblTelOficina.AutoSize = True
        Me.lblTelOficina.Location = New System.Drawing.Point(41, 109)
        Me.lblTelOficina.Name = "lblTelOficina"
        Me.lblTelOficina.Size = New System.Drawing.Size(88, 13)
        Me.lblTelOficina.TabIndex = 42
        Me.lblTelOficina.Text = "Telefono Oficina:"
        '
        'lblTelCasa
        '
        Me.lblTelCasa.AutoSize = True
        Me.lblTelCasa.Location = New System.Drawing.Point(41, 85)
        Me.lblTelCasa.Name = "lblTelCasa"
        Me.lblTelCasa.Size = New System.Drawing.Size(79, 13)
        Me.lblTelCasa.TabIndex = 40
        Me.lblTelCasa.Text = "Telefono Casa:"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(41, 39)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(87, 13)
        Me.lblApellidos.TabIndex = 36
        Me.lblApellidos.Text = "Apellido Paterno:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(41, 16)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 34
        Me.lblNombre.Text = "Nombre:"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(41, 227)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(44, 13)
        Me.CiLabel5.TabIndex = 33
        Me.CiLabel5.Text = "Cuenta:"
        '
        'selCuenta
        '
        Me.selCuenta.AnySite = False
        Me.selCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selCuenta.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.selCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.selCuenta.EditorTitle = "Editar Cuenta..."
        Me.selCuenta.Key = 0
        Me.selCuenta.Linked = False
        Me.selCuenta.Location = New System.Drawing.Point(134, 222)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCuenta.Size = New System.Drawing.Size(386, 23)
        Me.selCuenta.TabIndex = 32
        Me.selCuenta.TextWidth = 100
        '
        'chkActivo
        '
        Me.chkActivo.AutoClear = False
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(134, 251)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 31
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(134, 199)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaNacimiento.TabIndex = 25
        '
        'lblfechaNacimiento
        '
        Me.lblfechaNacimiento.AutoSize = True
        Me.lblfechaNacimiento.Location = New System.Drawing.Point(41, 202)
        Me.lblfechaNacimiento.Name = "lblfechaNacimiento"
        Me.lblfechaNacimiento.Size = New System.Drawing.Size(93, 13)
        Me.lblfechaNacimiento.TabIndex = 24
        Me.lblfechaNacimiento.Text = "Fecha Nacimiento"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(41, 180)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(31, 13)
        Me.lblSexo.TabIndex = 23
        Me.lblSexo.Text = "Sexo"
        '
        'rbtnFemenino
        '
        Me.rbtnFemenino.AutoSize = True
        Me.rbtnFemenino.Location = New System.Drawing.Point(263, 176)
        Me.rbtnFemenino.Name = "rbtnFemenino"
        Me.rbtnFemenino.Size = New System.Drawing.Size(71, 17)
        Me.rbtnFemenino.TabIndex = 22
        Me.rbtnFemenino.Text = "Femenino"
        Me.rbtnFemenino.UseVisualStyleBackColor = True
        '
        'rbtnMasculino
        '
        Me.rbtnMasculino.AutoSize = True
        Me.rbtnMasculino.Checked = True
        Me.rbtnMasculino.Location = New System.Drawing.Point(137, 176)
        Me.rbtnMasculino.Name = "rbtnMasculino"
        Me.rbtnMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rbtnMasculino.TabIndex = 21
        Me.rbtnMasculino.TabStop = True
        Me.rbtnMasculino.Text = "Masculino"
        Me.rbtnMasculino.UseVisualStyleBackColor = True
        '
        'tabDomicilio
        '
        Me.tabDomicilio.Controls.Add(Me.txtNumInt)
        Me.tabDomicilio.Controls.Add(Me.lblNumInt)
        Me.tabDomicilio.Controls.Add(Me.txtPoblacion)
        Me.tabDomicilio.Controls.Add(Me.lblEstadoInf)
        Me.tabDomicilio.Controls.Add(Me.lblEstado)
        Me.tabDomicilio.Controls.Add(Me.txtCP)
        Me.tabDomicilio.Controls.Add(Me.txtColonia)
        Me.tabDomicilio.Controls.Add(Me.txtNumExt)
        Me.tabDomicilio.Controls.Add(Me.txtCalle)
        Me.tabDomicilio.Controls.Add(Me.lblPoblacion)
        Me.tabDomicilio.Controls.Add(Me.lblCodigoPostal)
        Me.tabDomicilio.Controls.Add(Me.lblNumExt)
        Me.tabDomicilio.Controls.Add(Me.lblColonia)
        Me.tabDomicilio.Controls.Add(Me.lblCalle)
        Me.tabDomicilio.ImageIndex = 4
        Me.tabDomicilio.Location = New System.Drawing.Point(4, 39)
        Me.tabDomicilio.Name = "tabDomicilio"
        Me.tabDomicilio.Size = New System.Drawing.Size(585, 277)
        Me.tabDomicilio.TabIndex = 4
        Me.tabDomicilio.Text = "Domicilio"
        Me.tabDomicilio.UseVisualStyleBackColor = True
        '
        'txtNumInt
        '
        Me.txtNumInt.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNumInt.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNumInt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumInt.Location = New System.Drawing.Point(352, 63)
        Me.txtNumInt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.Name = "txtNumInt"
        Me.txtNumInt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumInt.TabIndex = 28
        Me.txtNumInt.UIName = Nothing
        '
        'lblNumInt
        '
        Me.lblNumInt.AutoSize = True
        Me.lblNumInt.Location = New System.Drawing.Point(284, 66)
        Me.lblNumInt.Name = "lblNumInt"
        Me.lblNumInt.Size = New System.Drawing.Size(62, 13)
        Me.lblNumInt.TabIndex = 27
        Me.lblNumInt.Text = "No. Interior:"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.AnySite = False
        Me.txtPoblacion.AutoClear = False
        Me.txtPoblacion.AutoLock = False
        Me.txtPoblacion.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtPoblacion.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtPoblacion.EditorAssembly = "Azteca.Windows"
        Me.txtPoblacion.EditorClass = "Azteca.Windows.Forms.General.CatalogoPoblaciones"
        Me.txtPoblacion.EditorTitle = "Editar población..."
        Me.txtPoblacion.FieldName = Nothing
        Me.txtPoblacion.Key = 0
        Me.txtPoblacion.Linked = False
        Me.txtPoblacion.Location = New System.Drawing.Point(122, 141)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.RequiredField = True
        Me.txtPoblacion.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtPoblacion.Size = New System.Drawing.Size(300, 23)
        Me.txtPoblacion.TabIndex = 26
        Me.txtPoblacion.TextWidth = 70
        Me.txtPoblacion.UIName = Nothing
        '
        'lblEstadoInf
        '
        Me.lblEstadoInf.AutoSize = True
        Me.lblEstadoInf.Location = New System.Drawing.Point(121, 173)
        Me.lblEstadoInf.Name = "lblEstadoInf"
        Me.lblEstadoInf.Size = New System.Drawing.Size(46, 13)
        Me.lblEstadoInf.TabIndex = 25
        Me.lblEstadoInf.Text = "[Estado]"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(39, 173)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 24
        Me.lblEstado.Text = "Estado:"
        '
        'txtCP
        '
        Me.txtCP.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCP.Digits = True
        Me.txtCP.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCP.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCP.Location = New System.Drawing.Point(122, 115)
        Me.txtCP.MaxLength = 5
        Me.txtCP.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(70, 20)
        Me.txtCP.TabIndex = 23
        Me.txtCP.UIName = Nothing
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtColonia.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtColonia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtColonia.Location = New System.Drawing.Point(122, 89)
        Me.txtColonia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(300, 20)
        Me.txtColonia.TabIndex = 22
        Me.txtColonia.UIName = Nothing
        '
        'txtNumExt
        '
        Me.txtNumExt.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNumExt.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNumExt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumExt.Location = New System.Drawing.Point(122, 63)
        Me.txtNumExt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumExt.TabIndex = 21
        Me.txtNumExt.UIName = Nothing
        '
        'txtCalle
        '
        Me.txtCalle.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalle.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCalle.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCalle.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCalle.Location = New System.Drawing.Point(122, 37)
        Me.txtCalle.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(300, 20)
        Me.txtCalle.TabIndex = 20
        Me.txtCalle.UIName = Nothing
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.Location = New System.Drawing.Point(39, 146)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(57, 13)
        Me.lblPoblacion.TabIndex = 19
        Me.lblPoblacion.Text = "Población:"
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.Location = New System.Drawing.Point(39, 118)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(75, 13)
        Me.lblCodigoPostal.TabIndex = 18
        Me.lblCodigoPostal.Text = "Código Postal:"
        '
        'lblNumExt
        '
        Me.lblNumExt.AutoSize = True
        Me.lblNumExt.Location = New System.Drawing.Point(39, 66)
        Me.lblNumExt.Name = "lblNumExt"
        Me.lblNumExt.Size = New System.Drawing.Size(65, 13)
        Me.lblNumExt.TabIndex = 17
        Me.lblNumExt.Text = "No. Exterior:"
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Location = New System.Drawing.Point(39, 93)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(45, 13)
        Me.lblColonia.TabIndex = 16
        Me.lblColonia.Text = "Colonia:"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(39, 40)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(33, 13)
        Me.lblCalle.TabIndex = 15
        Me.lblCalle.Text = "Calle:"
        '
        'tabLaboral
        '
        Me.tabLaboral.Controls.Add(Me.txtRFC)
        Me.tabLaboral.Controls.Add(Me.lblRFC)
        Me.tabLaboral.Controls.Add(Me.txtCURP)
        Me.tabLaboral.Controls.Add(Me.lblCURP)
        Me.tabLaboral.Controls.Add(Me.txtIMSS)
        Me.tabLaboral.Controls.Add(Me.lblIMSS)
        Me.tabLaboral.Controls.Add(Me.lblHoraExtra)
        Me.tabLaboral.Controls.Add(Me.CiTextBox1)
        Me.tabLaboral.Controls.Add(Me.lblSueldo)
        Me.tabLaboral.Controls.Add(Me.txtSueldo)
        Me.tabLaboral.Controls.Add(Me.lblPuesto)
        Me.tabLaboral.Controls.Add(Me.selPuesto)
        Me.tabLaboral.Controls.Add(Me.lblDepartamento)
        Me.tabLaboral.Controls.Add(Me.selDepartamento)
        Me.tabLaboral.Controls.Add(Me.dtpFechaIngreso)
        Me.tabLaboral.Controls.Add(Me.dtpFechaInicio)
        Me.tabLaboral.Controls.Add(Me.CiLabel1)
        Me.tabLaboral.Controls.Add(Me.txtTitulo)
        Me.tabLaboral.Controls.Add(Me.lblTitulo)
        Me.tabLaboral.Controls.Add(Me.lblFechaInicio)
        Me.tabLaboral.ImageIndex = 2
        Me.tabLaboral.Location = New System.Drawing.Point(4, 39)
        Me.tabLaboral.Name = "tabLaboral"
        Me.tabLaboral.Size = New System.Drawing.Size(585, 277)
        Me.tabLaboral.TabIndex = 2
        Me.tabLaboral.Text = "Inf.Laboral"
        Me.tabLaboral.UseVisualStyleBackColor = True
        '
        'txtRFC
        '
        Me.txtRFC.BackColor = System.Drawing.SystemColors.Window
        Me.txtRFC.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtRFC.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtRFC.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRFC.Location = New System.Drawing.Point(134, 222)
        Me.txtRFC.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRFC.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(200, 20)
        Me.txtRFC.TabIndex = 41
        Me.txtRFC.UIName = "IMSS"
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Location = New System.Drawing.Point(39, 225)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(28, 13)
        Me.lblRFC.TabIndex = 40
        Me.lblRFC.Text = "RFC"
        '
        'txtCURP
        '
        Me.txtCURP.BackColor = System.Drawing.SystemColors.Window
        Me.txtCURP.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCURP.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCURP.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCURP.Location = New System.Drawing.Point(134, 198)
        Me.txtCURP.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCURP.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCURP.Name = "txtCURP"
        Me.txtCURP.Size = New System.Drawing.Size(200, 20)
        Me.txtCURP.TabIndex = 39
        Me.txtCURP.UIName = "IMSS"
        '
        'lblCURP
        '
        Me.lblCURP.AutoSize = True
        Me.lblCURP.Location = New System.Drawing.Point(39, 201)
        Me.lblCURP.Name = "lblCURP"
        Me.lblCURP.Size = New System.Drawing.Size(37, 13)
        Me.lblCURP.TabIndex = 38
        Me.lblCURP.Text = "CURP"
        '
        'txtIMSS
        '
        Me.txtIMSS.BackColor = System.Drawing.SystemColors.Window
        Me.txtIMSS.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtIMSS.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtIMSS.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtIMSS.Location = New System.Drawing.Point(134, 175)
        Me.txtIMSS.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIMSS.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIMSS.Name = "txtIMSS"
        Me.txtIMSS.Size = New System.Drawing.Size(200, 20)
        Me.txtIMSS.TabIndex = 37
        Me.txtIMSS.UIName = "IMSS"
        '
        'lblIMSS
        '
        Me.lblIMSS.AutoSize = True
        Me.lblIMSS.Location = New System.Drawing.Point(39, 178)
        Me.lblIMSS.Name = "lblIMSS"
        Me.lblIMSS.Size = New System.Drawing.Size(73, 13)
        Me.lblIMSS.TabIndex = 36
        Me.lblIMSS.Text = "Seguro Social"
        '
        'lblHoraExtra
        '
        Me.lblHoraExtra.AutoSize = True
        Me.lblHoraExtra.Location = New System.Drawing.Point(209, 154)
        Me.lblHoraExtra.Name = "lblHoraExtra"
        Me.lblHoraExtra.Size = New System.Drawing.Size(56, 13)
        Me.lblHoraExtra.TabIndex = 35
        Me.lblHoraExtra.Text = "Hora extra"
        '
        'CiTextBox1
        '
        Me.CiTextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.CiTextBox1.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.CiTextBox1.Digits = True
        Me.CiTextBox1.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.CiTextBox1.HighlightColor = System.Drawing.SystemColors.Info
        Me.CiTextBox1.Location = New System.Drawing.Point(269, 151)
        Me.CiTextBox1.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CiTextBox1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CiTextBox1.Name = "CiTextBox1"
        Me.CiTextBox1.Size = New System.Drawing.Size(65, 20)
        Me.CiTextBox1.TabIndex = 34
        Me.CiTextBox1.UIName = "Nombre"
        '
        'lblSueldo
        '
        Me.lblSueldo.AutoSize = True
        Me.lblSueldo.Location = New System.Drawing.Point(39, 154)
        Me.lblSueldo.Name = "lblSueldo"
        Me.lblSueldo.Size = New System.Drawing.Size(40, 13)
        Me.lblSueldo.TabIndex = 33
        Me.lblSueldo.Text = "Sueldo"
        '
        'txtSueldo
        '
        Me.txtSueldo.BackColor = System.Drawing.SystemColors.Window
        Me.txtSueldo.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtSueldo.Digits = True
        Me.txtSueldo.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtSueldo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSueldo.Location = New System.Drawing.Point(134, 151)
        Me.txtSueldo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSueldo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(65, 20)
        Me.txtSueldo.TabIndex = 32
        Me.txtSueldo.UIName = "Nombre"
        '
        'lblPuesto
        '
        Me.lblPuesto.AutoSize = True
        Me.lblPuesto.Location = New System.Drawing.Point(39, 130)
        Me.lblPuesto.Name = "lblPuesto"
        Me.lblPuesto.Size = New System.Drawing.Size(40, 13)
        Me.lblPuesto.TabIndex = 31
        Me.lblPuesto.Text = "Puesto"
        '
        'selPuesto
        '
        Me.selPuesto.AnySite = False
        Me.selPuesto.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selPuesto.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selPuesto.EditorAssembly = "Azteca.RHWin"
        Me.selPuesto.EditorClass = "Azteca.Windows.RH.PuestosForm"
        Me.selPuesto.EditorTitle = "Editar nodo de estructura comercial..."
        Me.selPuesto.Key = 0
        Me.selPuesto.Linked = False
        Me.selPuesto.Location = New System.Drawing.Point(134, 126)
        Me.selPuesto.Name = "selPuesto"
        Me.selPuesto.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selPuesto.Size = New System.Drawing.Size(386, 23)
        Me.selPuesto.TabIndex = 30
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(39, 106)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(74, 13)
        Me.lblDepartamento.TabIndex = 29
        Me.lblDepartamento.Text = "Departamento"
        '
        'selDepartamento
        '
        Me.selDepartamento.AnySite = False
        Me.selDepartamento.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selDepartamento.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selDepartamento.EditorAssembly = "Azteca.RHWin"
        Me.selDepartamento.EditorClass = "Azteca.Windows.RH.DepartamentosForm"
        Me.selDepartamento.EditorTitle = "Editar nodo de estructura comercial..."
        Me.selDepartamento.Key = 0
        Me.selDepartamento.Linked = False
        Me.selDepartamento.Location = New System.Drawing.Point(134, 102)
        Me.selDepartamento.Name = "selDepartamento"
        Me.selDepartamento.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selDepartamento.Size = New System.Drawing.Size(386, 23)
        Me.selDepartamento.TabIndex = 28
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(134, 78)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaIngreso.TabIndex = 27
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaInicio.Location = New System.Drawing.Point(134, 53)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaInicio.TabIndex = 26
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTitulo.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtTitulo.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtTitulo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTitulo.Location = New System.Drawing.Point(134, 28)
        Me.txtTitulo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTitulo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(280, 20)
        Me.txtTitulo.TabIndex = 25
        Me.txtTitulo.UIName = "Nombre"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(39, 31)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(33, 13)
        Me.lblTitulo.TabIndex = 24
        Me.lblTitulo.Text = "Titulo"
        '
        'tabChecador
        '
        Me.tabChecador.Controls.Add(Me.lblTurnoActual)
        Me.tabChecador.Controls.Add(Me.CiButton1)
        Me.tabChecador.Controls.Add(Me.txtCodigoChecador)
        Me.tabChecador.Controls.Add(Me.lblCodigoChecador)
        Me.tabChecador.Controls.Add(Me.lblTurno)
        Me.tabChecador.Controls.Add(Me.txtNombreCorto)
        Me.tabChecador.Controls.Add(Me.lblNombreCorto)
        Me.tabChecador.ImageIndex = 3
        Me.tabChecador.Location = New System.Drawing.Point(4, 39)
        Me.tabChecador.Name = "tabChecador"
        Me.tabChecador.Size = New System.Drawing.Size(585, 277)
        Me.tabChecador.TabIndex = 3
        Me.tabChecador.Text = "Inf. Checador"
        Me.tabChecador.UseVisualStyleBackColor = True
        '
        'lblTurnoActual
        '
        Me.lblTurnoActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTurnoActual.Location = New System.Drawing.Point(127, 94)
        Me.lblTurnoActual.Name = "lblTurnoActual"
        Me.lblTurnoActual.Size = New System.Drawing.Size(280, 21)
        Me.lblTurnoActual.TabIndex = 27
        Me.lblTurnoActual.Text = "Turno Default"
        Me.lblTurnoActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CiButton1
        '
        Me.CiButton1.Image = CType(resources.GetObject("CiButton1.Image"), System.Drawing.Image)
        Me.CiButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CiButton1.Location = New System.Drawing.Point(127, 121)
        Me.CiButton1.Name = "CiButton1"
        Me.CiButton1.Size = New System.Drawing.Size(280, 23)
        Me.CiButton1.TabIndex = 26
        Me.CiButton1.Text = "Programar Cambio de Turno"
        Me.CiButton1.UseVisualStyleBackColor = True
        '
        'txtCodigoChecador
        '
        Me.txtCodigoChecador.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigoChecador.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCodigoChecador.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCodigoChecador.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCodigoChecador.Location = New System.Drawing.Point(127, 45)
        Me.txtCodigoChecador.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodigoChecador.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodigoChecador.Name = "txtCodigoChecador"
        Me.txtCodigoChecador.Size = New System.Drawing.Size(147, 20)
        Me.txtCodigoChecador.TabIndex = 25
        Me.txtCodigoChecador.UIName = "Nombre"
        '
        'tabFoto
        '
        Me.tabFoto.Controls.Add(Me.lbImagen)
        Me.tabFoto.Controls.Add(Me.picEmpleado)
        Me.tabFoto.ImageIndex = 0
        Me.tabFoto.Location = New System.Drawing.Point(4, 39)
        Me.tabFoto.Name = "tabFoto"
        Me.tabFoto.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFoto.Size = New System.Drawing.Size(585, 277)
        Me.tabFoto.TabIndex = 1
        Me.tabFoto.Text = "Fotorafía"
        Me.tabFoto.UseVisualStyleBackColor = True
        '
        'lbImagen
        '
        Me.lbImagen.AutoSize = True
        Me.lbImagen.Location = New System.Drawing.Point(16, 25)
        Me.lbImagen.Name = "lbImagen"
        Me.lbImagen.Size = New System.Drawing.Size(54, 13)
        Me.lbImagen.TabIndex = 27
        Me.lbImagen.Text = "Fotografia"
        '
        'picEmpleado
        '
        Me.picEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picEmpleado.Image = Nothing
        Me.picEmpleado.Location = New System.Drawing.Point(75, 25)
        Me.picEmpleado.Name = "picEmpleado"
        Me.picEmpleado.Size = New System.Drawing.Size(125, 123)
        Me.picEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
        Me.picEmpleado.TabIndex = 0
        Me.picEmpleado.UIName = Nothing
        '
        'EmpleadosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 433)
        Me.Controls.Add(Me.tabEmpleados)
        Me.KeyMode = Azteca.Windows.Forms.BusinessForms.CatalogForm.UserKeyMode.UserDefined
        Me.Name = "EmpleadosForm"
        Me.Text = "EmpleadosForm"
        Me.Controls.SetChildIndex(Me.tabEmpleados, 0)
        Me.tabEmpleados.ResumeLayout(False)
        Me.tabGenerales.ResumeLayout(False)
        Me.tabGenerales.PerformLayout()
        Me.tabDomicilio.ResumeLayout(False)
        Me.tabDomicilio.PerformLayout()
        Me.tabLaboral.ResumeLayout(False)
        Me.tabLaboral.PerformLayout()
        Me.tabChecador.ResumeLayout(False)
        Me.tabChecador.PerformLayout()
        Me.tabFoto.ResumeLayout(False)
        Me.tabFoto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New EmpleadoFacade
    End Sub
    Friend WithEvents lblNombreCorto As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombreCorto As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblTurno As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCodigoChecador As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblFechaInicio As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents iLstTabs As System.Windows.Forms.ImageList
    Friend WithEvents tabEmpleados As Azteca.Windows.Controls.CITab
    Friend WithEvents tabGenerales As System.Windows.Forms.TabPage
    Friend WithEvents rbtnMasculino As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents tabFoto As System.Windows.Forms.TabPage
    Friend WithEvents lbImagen As Azteca.Windows.Controls.CILabel
    Friend WithEvents picEmpleado As Azteca.Windows.Controls.CIPictureManager
    Friend WithEvents rbtnFemenino As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents dtpFechaNacimiento As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents lblfechaNacimiento As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblSexo As Azteca.Windows.Controls.CILabel
    Friend WithEvents tabLaboral As System.Windows.Forms.TabPage
    Friend WithEvents dtpFechaIngreso As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents dtpFechaInicio As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents txtTitulo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblTitulo As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCURP As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblCURP As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtIMSS As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblIMSS As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblHoraExtra As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiTextBox1 As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblSueldo As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtSueldo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblPuesto As Azteca.Windows.Controls.CILabel
    Friend WithEvents selPuesto As Azteca.Windows.RH.PuestoSelector
    Friend WithEvents lblDepartamento As Azteca.Windows.Controls.CILabel
    Friend WithEvents selDepartamento As Azteca.Windows.RH.DepartamentoSelector
    Friend WithEvents tabChecador As System.Windows.Forms.TabPage
    Friend WithEvents lblTurnoActual As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiButton1 As Azteca.Windows.Controls.CIButton
    Friend WithEvents txtCodigoChecador As Azteca.Windows.Controls.CITextBox
    Friend WithEvents chkActivo As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents txtRFC As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblRFC As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents txtApellidoM As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCorreo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCelular As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtTelOficina As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtTelCasa As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtApellidoP As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblCorreo As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCelular As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTelOficina As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTelCasa As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblApellidos As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents tabDomicilio As System.Windows.Forms.TabPage
    Friend WithEvents txtPoblacion As Azteca.Windows.Controls.General.PoblacionSelector
    Friend WithEvents lblEstadoInf As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblEstado As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCP As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtColonia As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNumExt As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCalle As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblPoblacion As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCodigoPostal As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblNumExt As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblColonia As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCalle As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNumInt As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNumInt As Azteca.Windows.Controls.CILabel
End Class
