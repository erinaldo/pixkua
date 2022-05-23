<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SolicitantesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SolicitantesForm))
        Me.tabEmpleados = New Azteca.Windows.Controls.CITab()
        Me.tabGenerales = New System.Windows.Forms.TabPage()
        Me.txtNombreCorto = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
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
        Me.chkActivo = New Azteca.Windows.Controls.CICheckBox()
        Me.dtpFechaNacimiento = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.lblfechaNacimiento = New Azteca.Windows.Controls.CILabel()
        Me.lblSexo = New Azteca.Windows.Controls.CILabel()
        Me.rbtnFemenino = New Azteca.Windows.Controls.CIRadioButton()
        Me.rbtnMasculino = New Azteca.Windows.Controls.CIRadioButton()
        Me.TabBautismo = New System.Windows.Forms.TabPage()
        Me.chkCapturaManual = New System.Windows.Forms.CheckBox()
        Me.BautismoSel = New Azteca.Windows.Iglesia.BautismoSelector()
        Me.CiLabel14 = New Azteca.Windows.Controls.CILabel()
        Me.grpBautismo = New System.Windows.Forms.GroupBox()
        Me.CiLabel21 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel16 = New Azteca.Windows.Controls.CILabel()
        Me.txtNumInteriorBautismo = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel11 = New Azteca.Windows.Controls.CILabel()
        Me.lblEstadoBautismo = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel15 = New Azteca.Windows.Controls.CILabel()
        Me.txtCPBautismo = New Azteca.Windows.Controls.CITextBox()
        Me.txtColoniaBautismo = New Azteca.Windows.Controls.CITextBox()
        Me.txtNumExteriorBautismo = New Azteca.Windows.Controls.CITextBox()
        Me.txtCalleBautismo = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel17 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel18 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel19 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel20 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel13 = New Azteca.Windows.Controls.CILabel()
        Me.txtParroquiaBautismo = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel12 = New Azteca.Windows.Controls.CILabel()
        Me.PoblacionBautismoSel = New Azteca.Windows.Controls.General.PoblacionSelector()
        Me.dtpFechaBautismo = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.lblCURP = New Azteca.Windows.Controls.CILabel()
        Me.txtActaBautismo = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel10 = New Azteca.Windows.Controls.CILabel()
        Me.txtPaginaBautismo = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel9 = New Azteca.Windows.Controls.CILabel()
        Me.txtLibroBautismo = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.tabLaboral = New System.Windows.Forms.TabPage()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaAlta = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.txtAbuelosMaternos = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.txtAbuelosPaternos = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.txtNombreMadre = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtLugarNacimiento = New Azteca.Windows.Controls.CITextBox()
        Me.txtNombrePadre = New Azteca.Windows.Controls.CITextBox()
        Me.lblTitulo = New Azteca.Windows.Controls.CILabel()
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
        Me.tabFoto = New System.Windows.Forms.TabPage()
        Me.lbImagen = New Azteca.Windows.Controls.CILabel()
        Me.picEmpleado = New Azteca.Windows.Controls.CIPictureManager()
        Me.iLstTabs = New System.Windows.Forms.ImageList(Me.components)
        Me.tabEmpleados.SuspendLayout()
        Me.tabGenerales.SuspendLayout()
        Me.TabBautismo.SuspendLayout()
        Me.grpBautismo.SuspendLayout()
        Me.tabLaboral.SuspendLayout()
        Me.tabDomicilio.SuspendLayout()
        Me.tabFoto.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabEmpleados
        '
        Me.tabEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabEmpleados.Controls.Add(Me.tabGenerales)
        Me.tabEmpleados.Controls.Add(Me.TabBautismo)
        Me.tabEmpleados.Controls.Add(Me.tabLaboral)
        Me.tabEmpleados.Controls.Add(Me.tabDomicilio)
        Me.tabEmpleados.Controls.Add(Me.tabFoto)
        Me.tabEmpleados.ImageList = Me.iLstTabs
        Me.tabEmpleados.Location = New System.Drawing.Point(12, 90)
        Me.tabEmpleados.Name = "tabEmpleados"
        Me.tabEmpleados.SelectedIndex = 0
        Me.tabEmpleados.Size = New System.Drawing.Size(527, 372)
        Me.tabEmpleados.TabIndex = 32
        '
        'tabGenerales
        '
        Me.tabGenerales.Controls.Add(Me.txtNombreCorto)
        Me.tabGenerales.Controls.Add(Me.CiLabel3)
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
        Me.tabGenerales.Size = New System.Drawing.Size(519, 329)
        Me.tabGenerales.TabIndex = 0
        Me.tabGenerales.Text = "Datos Generales"
        Me.tabGenerales.UseVisualStyleBackColor = True
        '
        'txtNombreCorto
        '
        Me.txtNombreCorto.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombreCorto.Location = New System.Drawing.Point(134, 85)
        Me.txtNombreCorto.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreCorto.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreCorto.Name = "txtNombreCorto"
        Me.txtNombreCorto.Size = New System.Drawing.Size(264, 20)
        Me.txtNombreCorto.TabIndex = 3
        Me.txtNombreCorto.UIName = "Apellido Materno"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(41, 88)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(75, 13)
        Me.CiLabel3.TabIndex = 48
        Me.CiLabel3.Text = "Nombre Corto:"
        '
        'txtApellidoM
        '
        Me.txtApellidoM.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtApellidoM.Location = New System.Drawing.Point(134, 59)
        Me.txtApellidoM.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtApellidoM.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtApellidoM.Name = "txtApellidoM"
        Me.txtApellidoM.Size = New System.Drawing.Size(186, 20)
        Me.txtApellidoM.TabIndex = 2
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
        Me.txtCorreo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCorreo.Location = New System.Drawing.Point(134, 179)
        Me.txtCorreo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCorreo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(264, 20)
        Me.txtCorreo.TabIndex = 7
        Me.txtCorreo.UIName = Nothing
        '
        'txtCelular
        '
        Me.txtCelular.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCelular.Location = New System.Drawing.Point(134, 156)
        Me.txtCelular.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCelular.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(125, 20)
        Me.txtCelular.TabIndex = 6
        Me.txtCelular.UIName = Nothing
        '
        'txtTelOficina
        '
        Me.txtTelOficina.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTelOficina.Location = New System.Drawing.Point(134, 133)
        Me.txtTelOficina.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelOficina.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelOficina.Name = "txtTelOficina"
        Me.txtTelOficina.Size = New System.Drawing.Size(125, 20)
        Me.txtTelOficina.TabIndex = 5
        Me.txtTelOficina.UIName = Nothing
        '
        'txtTelCasa
        '
        Me.txtTelCasa.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTelCasa.Location = New System.Drawing.Point(134, 110)
        Me.txtTelCasa.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelCasa.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.Size = New System.Drawing.Size(125, 20)
        Me.txtTelCasa.TabIndex = 4
        Me.txtTelCasa.UIName = Nothing
        '
        'txtApellidoP
        '
        Me.txtApellidoP.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtApellidoP.Location = New System.Drawing.Point(134, 36)
        Me.txtApellidoP.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtApellidoP.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtApellidoP.Name = "txtApellidoP"
        Me.txtApellidoP.Size = New System.Drawing.Size(186, 20)
        Me.txtApellidoP.TabIndex = 1
        Me.txtApellidoP.UIName = "Apellido Paterno"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(134, 13)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(264, 20)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.UIName = "Nombre"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(41, 182)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(41, 13)
        Me.lblCorreo.TabIndex = 46
        Me.lblCorreo.Text = "Correo:"
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(41, 159)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(42, 13)
        Me.lblCelular.TabIndex = 44
        Me.lblCelular.Text = "Celular:"
        '
        'lblTelOficina
        '
        Me.lblTelOficina.AutoSize = True
        Me.lblTelOficina.Location = New System.Drawing.Point(41, 137)
        Me.lblTelOficina.Name = "lblTelOficina"
        Me.lblTelOficina.Size = New System.Drawing.Size(88, 13)
        Me.lblTelOficina.TabIndex = 42
        Me.lblTelOficina.Text = "Telefono Oficina:"
        '
        'lblTelCasa
        '
        Me.lblTelCasa.AutoSize = True
        Me.lblTelCasa.Location = New System.Drawing.Point(41, 113)
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
        'chkActivo
        '
        Me.chkActivo.AutoClear = False
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(134, 251)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 9
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(134, 227)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaNacimiento.TabIndex = 8
        '
        'lblfechaNacimiento
        '
        Me.lblfechaNacimiento.AutoSize = True
        Me.lblfechaNacimiento.Location = New System.Drawing.Point(41, 230)
        Me.lblfechaNacimiento.Name = "lblfechaNacimiento"
        Me.lblfechaNacimiento.Size = New System.Drawing.Size(93, 13)
        Me.lblfechaNacimiento.TabIndex = 24
        Me.lblfechaNacimiento.Text = "Fecha Nacimiento"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(41, 208)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(31, 13)
        Me.lblSexo.TabIndex = 23
        Me.lblSexo.Text = "Sexo"
        '
        'rbtnFemenino
        '
        Me.rbtnFemenino.AutoSize = True
        Me.rbtnFemenino.Location = New System.Drawing.Point(263, 204)
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
        Me.rbtnMasculino.Location = New System.Drawing.Point(137, 204)
        Me.rbtnMasculino.Name = "rbtnMasculino"
        Me.rbtnMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rbtnMasculino.TabIndex = 21
        Me.rbtnMasculino.TabStop = True
        Me.rbtnMasculino.Text = "Masculino"
        Me.rbtnMasculino.UseVisualStyleBackColor = True
        '
        'TabBautismo
        '
        Me.TabBautismo.Controls.Add(Me.chkCapturaManual)
        Me.TabBautismo.Controls.Add(Me.BautismoSel)
        Me.TabBautismo.Controls.Add(Me.CiLabel14)
        Me.TabBautismo.Controls.Add(Me.grpBautismo)
        Me.TabBautismo.ImageIndex = 7
        Me.TabBautismo.Location = New System.Drawing.Point(4, 39)
        Me.TabBautismo.Name = "TabBautismo"
        Me.TabBautismo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabBautismo.Size = New System.Drawing.Size(519, 329)
        Me.TabBautismo.TabIndex = 5
        Me.TabBautismo.Text = "Bautismo"
        Me.TabBautismo.UseVisualStyleBackColor = True
        '
        'chkCapturaManual
        '
        Me.chkCapturaManual.AutoSize = True
        Me.chkCapturaManual.Checked = True
        Me.chkCapturaManual.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCapturaManual.Location = New System.Drawing.Point(32, 63)
        Me.chkCapturaManual.Name = "chkCapturaManual"
        Me.chkCapturaManual.Size = New System.Drawing.Size(15, 14)
        Me.chkCapturaManual.TabIndex = 82
        Me.chkCapturaManual.UseVisualStyleBackColor = True
        '
        'BautismoSel
        '
        Me.BautismoSel.AnySite = False
        Me.BautismoSel.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.BautismoSel.EditorAssembly = "Azteca.IglesiaWin"
        Me.BautismoSel.EditorClass = "Azteca.Windows.Iglesia.BautismoForm"
        Me.BautismoSel.EditorTitle = "Editar los datos del Bautismo..."
        Me.BautismoSel.Enabled = False
        Me.BautismoSel.Key = 0
        Me.BautismoSel.Linked = False
        Me.BautismoSel.Location = New System.Drawing.Point(134, 20)
        Me.BautismoSel.Name = "BautismoSel"
        Me.BautismoSel.Size = New System.Drawing.Size(352, 23)
        Me.BautismoSel.TabIndex = 81
        '
        'CiLabel14
        '
        Me.CiLabel14.AutoSize = True
        Me.CiLabel14.Location = New System.Drawing.Point(60, 24)
        Me.CiLabel14.Name = "CiLabel14"
        Me.CiLabel14.Size = New System.Drawing.Size(53, 13)
        Me.CiLabel14.TabIndex = 80
        Me.CiLabel14.Text = "Bautismo:"
        '
        'grpBautismo
        '
        Me.grpBautismo.Controls.Add(Me.CiLabel21)
        Me.grpBautismo.Controls.Add(Me.CiLabel16)
        Me.grpBautismo.Controls.Add(Me.txtNumInteriorBautismo)
        Me.grpBautismo.Controls.Add(Me.CiLabel11)
        Me.grpBautismo.Controls.Add(Me.lblEstadoBautismo)
        Me.grpBautismo.Controls.Add(Me.CiLabel15)
        Me.grpBautismo.Controls.Add(Me.txtCPBautismo)
        Me.grpBautismo.Controls.Add(Me.txtColoniaBautismo)
        Me.grpBautismo.Controls.Add(Me.txtNumExteriorBautismo)
        Me.grpBautismo.Controls.Add(Me.txtCalleBautismo)
        Me.grpBautismo.Controls.Add(Me.CiLabel17)
        Me.grpBautismo.Controls.Add(Me.CiLabel18)
        Me.grpBautismo.Controls.Add(Me.CiLabel19)
        Me.grpBautismo.Controls.Add(Me.CiLabel20)
        Me.grpBautismo.Controls.Add(Me.CiLabel13)
        Me.grpBautismo.Controls.Add(Me.txtParroquiaBautismo)
        Me.grpBautismo.Controls.Add(Me.CiLabel12)
        Me.grpBautismo.Controls.Add(Me.PoblacionBautismoSel)
        Me.grpBautismo.Controls.Add(Me.dtpFechaBautismo)
        Me.grpBautismo.Controls.Add(Me.lblCURP)
        Me.grpBautismo.Controls.Add(Me.txtActaBautismo)
        Me.grpBautismo.Controls.Add(Me.CiLabel10)
        Me.grpBautismo.Controls.Add(Me.txtPaginaBautismo)
        Me.grpBautismo.Controls.Add(Me.CiLabel9)
        Me.grpBautismo.Controls.Add(Me.txtLibroBautismo)
        Me.grpBautismo.Controls.Add(Me.CiLabel8)
        Me.grpBautismo.Location = New System.Drawing.Point(40, 63)
        Me.grpBautismo.Name = "grpBautismo"
        Me.grpBautismo.Size = New System.Drawing.Size(446, 251)
        Me.grpBautismo.TabIndex = 53
        Me.grpBautismo.TabStop = False
        Me.grpBautismo.Text = "Captura Manual"
        '
        'CiLabel21
        '
        Me.CiLabel21.AutoSize = True
        Me.CiLabel21.Location = New System.Drawing.Point(216, 35)
        Me.CiLabel21.Name = "CiLabel21"
        Me.CiLabel21.Size = New System.Drawing.Size(12, 13)
        Me.CiLabel21.TabIndex = 99
        Me.CiLabel21.Text = "/"
        '
        'CiLabel16
        '
        Me.CiLabel16.AutoSize = True
        Me.CiLabel16.Location = New System.Drawing.Point(142, 35)
        Me.CiLabel16.Name = "CiLabel16"
        Me.CiLabel16.Size = New System.Drawing.Size(12, 13)
        Me.CiLabel16.TabIndex = 98
        Me.CiLabel16.Text = "/"
        '
        'txtNumInteriorBautismo
        '
        Me.txtNumInteriorBautismo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumInteriorBautismo.Location = New System.Drawing.Point(229, 145)
        Me.txtNumInteriorBautismo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInteriorBautismo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInteriorBautismo.Name = "txtNumInteriorBautismo"
        Me.txtNumInteriorBautismo.Size = New System.Drawing.Size(64, 20)
        Me.txtNumInteriorBautismo.TabIndex = 96
        Me.txtNumInteriorBautismo.UIName = Nothing
        '
        'CiLabel11
        '
        Me.CiLabel11.AutoSize = True
        Me.CiLabel11.Location = New System.Drawing.Point(161, 148)
        Me.CiLabel11.Name = "CiLabel11"
        Me.CiLabel11.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel11.TabIndex = 97
        Me.CiLabel11.Text = "No. Interior:"
        '
        'lblEstadoBautismo
        '
        Me.lblEstadoBautismo.AutoSize = True
        Me.lblEstadoBautismo.Location = New System.Drawing.Point(86, 227)
        Me.lblEstadoBautismo.Name = "lblEstadoBautismo"
        Me.lblEstadoBautismo.Size = New System.Drawing.Size(46, 13)
        Me.lblEstadoBautismo.TabIndex = 90
        Me.lblEstadoBautismo.Text = "[Estado]"
        '
        'CiLabel15
        '
        Me.CiLabel15.AutoSize = True
        Me.CiLabel15.Location = New System.Drawing.Point(3, 227)
        Me.CiLabel15.Name = "CiLabel15"
        Me.CiLabel15.Size = New System.Drawing.Size(43, 13)
        Me.CiLabel15.TabIndex = 95
        Me.CiLabel15.Text = "Estado:"
        '
        'txtCPBautismo
        '
        Me.txtCPBautismo.Digits = True
        Me.txtCPBautismo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCPBautismo.Location = New System.Drawing.Point(329, 120)
        Me.txtCPBautismo.MaxLength = 5
        Me.txtCPBautismo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCPBautismo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCPBautismo.Name = "txtCPBautismo"
        Me.txtCPBautismo.Size = New System.Drawing.Size(76, 20)
        Me.txtCPBautismo.TabIndex = 89
        Me.txtCPBautismo.UIName = Nothing
        '
        'txtColoniaBautismo
        '
        Me.txtColoniaBautismo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtColoniaBautismo.Location = New System.Drawing.Point(89, 174)
        Me.txtColoniaBautismo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColoniaBautismo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColoniaBautismo.Name = "txtColoniaBautismo"
        Me.txtColoniaBautismo.Size = New System.Drawing.Size(205, 20)
        Me.txtColoniaBautismo.TabIndex = 88
        Me.txtColoniaBautismo.UIName = Nothing
        '
        'txtNumExteriorBautismo
        '
        Me.txtNumExteriorBautismo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumExteriorBautismo.Location = New System.Drawing.Point(89, 145)
        Me.txtNumExteriorBautismo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExteriorBautismo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExteriorBautismo.Name = "txtNumExteriorBautismo"
        Me.txtNumExteriorBautismo.Size = New System.Drawing.Size(51, 20)
        Me.txtNumExteriorBautismo.TabIndex = 87
        Me.txtNumExteriorBautismo.UIName = Nothing
        '
        'txtCalleBautismo
        '
        Me.txtCalleBautismo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalleBautismo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCalleBautismo.Location = New System.Drawing.Point(89, 119)
        Me.txtCalleBautismo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalleBautismo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalleBautismo.Name = "txtCalleBautismo"
        Me.txtCalleBautismo.Size = New System.Drawing.Size(205, 20)
        Me.txtCalleBautismo.TabIndex = 86
        Me.txtCalleBautismo.UIName = Nothing
        '
        'CiLabel17
        '
        Me.CiLabel17.AutoSize = True
        Me.CiLabel17.Location = New System.Drawing.Point(299, 123)
        Me.CiLabel17.Name = "CiLabel17"
        Me.CiLabel17.Size = New System.Drawing.Size(24, 13)
        Me.CiLabel17.TabIndex = 94
        Me.CiLabel17.Text = "CP:"
        '
        'CiLabel18
        '
        Me.CiLabel18.AutoSize = True
        Me.CiLabel18.Location = New System.Drawing.Point(4, 148)
        Me.CiLabel18.Name = "CiLabel18"
        Me.CiLabel18.Size = New System.Drawing.Size(65, 13)
        Me.CiLabel18.TabIndex = 93
        Me.CiLabel18.Text = "No. Exterior:"
        '
        'CiLabel19
        '
        Me.CiLabel19.AutoSize = True
        Me.CiLabel19.Location = New System.Drawing.Point(4, 177)
        Me.CiLabel19.Name = "CiLabel19"
        Me.CiLabel19.Size = New System.Drawing.Size(45, 13)
        Me.CiLabel19.TabIndex = 92
        Me.CiLabel19.Text = "Colonia:"
        '
        'CiLabel20
        '
        Me.CiLabel20.AutoSize = True
        Me.CiLabel20.Location = New System.Drawing.Point(5, 122)
        Me.CiLabel20.Name = "CiLabel20"
        Me.CiLabel20.Size = New System.Drawing.Size(33, 13)
        Me.CiLabel20.TabIndex = 91
        Me.CiLabel20.Text = "Calle:"
        '
        'CiLabel13
        '
        Me.CiLabel13.AutoSize = True
        Me.CiLabel13.Location = New System.Drawing.Point(4, 96)
        Me.CiLabel13.Name = "CiLabel13"
        Me.CiLabel13.Size = New System.Drawing.Size(52, 13)
        Me.CiLabel13.TabIndex = 85
        Me.CiLabel13.Text = "Parroquia"
        '
        'txtParroquiaBautismo
        '
        Me.txtParroquiaBautismo.BackColor = System.Drawing.SystemColors.Window
        Me.txtParroquiaBautismo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtParroquiaBautismo.Location = New System.Drawing.Point(89, 93)
        Me.txtParroquiaBautismo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtParroquiaBautismo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtParroquiaBautismo.Name = "txtParroquiaBautismo"
        Me.txtParroquiaBautismo.Size = New System.Drawing.Size(316, 20)
        Me.txtParroquiaBautismo.TabIndex = 84
        Me.txtParroquiaBautismo.UIName = "IMSS"
        '
        'CiLabel12
        '
        Me.CiLabel12.AutoSize = True
        Me.CiLabel12.Location = New System.Drawing.Point(3, 204)
        Me.CiLabel12.Name = "CiLabel12"
        Me.CiLabel12.Size = New System.Drawing.Size(54, 13)
        Me.CiLabel12.TabIndex = 83
        Me.CiLabel12.Text = "Población"
        '
        'PoblacionBautismoSel
        '
        Me.PoblacionBautismoSel.AnySite = False
        Me.PoblacionBautismoSel.AutoClear = False
        Me.PoblacionBautismoSel.AutoLock = False
        Me.PoblacionBautismoSel.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.PoblacionBautismoSel.EditorAssembly = "Azteca.Windows"
        Me.PoblacionBautismoSel.EditorClass = "Azteca.Windows.Forms.General.CatalogoPoblaciones"
        Me.PoblacionBautismoSel.EditorTitle = "Editar población..."
        Me.PoblacionBautismoSel.FieldName = Nothing
        Me.PoblacionBautismoSel.Key = 0
        Me.PoblacionBautismoSel.Linked = False
        Me.PoblacionBautismoSel.Location = New System.Drawing.Point(88, 200)
        Me.PoblacionBautismoSel.Name = "PoblacionBautismoSel"
        Me.PoblacionBautismoSel.Size = New System.Drawing.Size(325, 23)
        Me.PoblacionBautismoSel.TabIndex = 82
        Me.PoblacionBautismoSel.TextWidth = 70
        Me.PoblacionBautismoSel.UIName = Nothing
        '
        'dtpFechaBautismo
        '
        Me.dtpFechaBautismo.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaBautismo.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaBautismo.Location = New System.Drawing.Point(89, 67)
        Me.dtpFechaBautismo.Name = "dtpFechaBautismo"
        Me.dtpFechaBautismo.Size = New System.Drawing.Size(193, 20)
        Me.dtpFechaBautismo.TabIndex = 80
        '
        'lblCURP
        '
        Me.lblCURP.AutoSize = True
        Me.lblCURP.Location = New System.Drawing.Point(5, 70)
        Me.lblCURP.Name = "lblCURP"
        Me.lblCURP.Size = New System.Drawing.Size(37, 13)
        Me.lblCURP.TabIndex = 81
        Me.lblCURP.Text = "Fecha"
        '
        'txtActaBautismo
        '
        Me.txtActaBautismo.BackColor = System.Drawing.SystemColors.Window
        Me.txtActaBautismo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtActaBautismo.Location = New System.Drawing.Point(232, 32)
        Me.txtActaBautismo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtActaBautismo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtActaBautismo.Name = "txtActaBautismo"
        Me.txtActaBautismo.Size = New System.Drawing.Size(50, 20)
        Me.txtActaBautismo.TabIndex = 3
        Me.txtActaBautismo.UIName = "Nombre"
        '
        'CiLabel10
        '
        Me.CiLabel10.AutoSize = True
        Me.CiLabel10.Location = New System.Drawing.Point(229, 16)
        Me.CiLabel10.Name = "CiLabel10"
        Me.CiLabel10.Size = New System.Drawing.Size(29, 13)
        Me.CiLabel10.TabIndex = 2
        Me.CiLabel10.Text = "Acta"
        '
        'txtPaginaBautismo
        '
        Me.txtPaginaBautismo.BackColor = System.Drawing.SystemColors.Window
        Me.txtPaginaBautismo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPaginaBautismo.Location = New System.Drawing.Point(160, 32)
        Me.txtPaginaBautismo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPaginaBautismo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPaginaBautismo.Name = "txtPaginaBautismo"
        Me.txtPaginaBautismo.Size = New System.Drawing.Size(50, 20)
        Me.txtPaginaBautismo.TabIndex = 2
        Me.txtPaginaBautismo.UIName = "Nombre"
        '
        'CiLabel9
        '
        Me.CiLabel9.AutoSize = True
        Me.CiLabel9.Location = New System.Drawing.Point(157, 16)
        Me.CiLabel9.Name = "CiLabel9"
        Me.CiLabel9.Size = New System.Drawing.Size(40, 13)
        Me.CiLabel9.TabIndex = 1
        Me.CiLabel9.Text = "Pagina"
        '
        'txtLibroBautismo
        '
        Me.txtLibroBautismo.BackColor = System.Drawing.SystemColors.Window
        Me.txtLibroBautismo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtLibroBautismo.Location = New System.Drawing.Point(89, 32)
        Me.txtLibroBautismo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLibroBautismo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLibroBautismo.Name = "txtLibroBautismo"
        Me.txtLibroBautismo.Size = New System.Drawing.Size(50, 20)
        Me.txtLibroBautismo.TabIndex = 0
        Me.txtLibroBautismo.UIName = "Nombre"
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(91, 16)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(30, 13)
        Me.CiLabel8.TabIndex = 0
        Me.CiLabel8.Text = "Libro"
        '
        'tabLaboral
        '
        Me.tabLaboral.Controls.Add(Me.CiLabel7)
        Me.tabLaboral.Controls.Add(Me.dtpFechaAlta)
        Me.tabLaboral.Controls.Add(Me.CiLabel6)
        Me.tabLaboral.Controls.Add(Me.txtAbuelosMaternos)
        Me.tabLaboral.Controls.Add(Me.CiLabel4)
        Me.tabLaboral.Controls.Add(Me.txtAbuelosPaternos)
        Me.tabLaboral.Controls.Add(Me.CiLabel5)
        Me.tabLaboral.Controls.Add(Me.txtNombreMadre)
        Me.tabLaboral.Controls.Add(Me.CiLabel1)
        Me.tabLaboral.Controls.Add(Me.txtLugarNacimiento)
        Me.tabLaboral.Controls.Add(Me.txtNombrePadre)
        Me.tabLaboral.Controls.Add(Me.lblTitulo)
        Me.tabLaboral.ImageIndex = 2
        Me.tabLaboral.Location = New System.Drawing.Point(4, 39)
        Me.tabLaboral.Name = "tabLaboral"
        Me.tabLaboral.Size = New System.Drawing.Size(519, 329)
        Me.tabLaboral.TabIndex = 2
        Me.tabLaboral.Text = "Inf. Familiar"
        Me.tabLaboral.UseVisualStyleBackColor = True
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(37, 135)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(105, 13)
        Me.CiLabel7.TabIndex = 50
        Me.CiLabel7.Text = "Lugar de Nacimiento"
        '
        'dtpFechaAlta
        '
        Me.dtpFechaAlta.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaAlta.Location = New System.Drawing.Point(157, 158)
        Me.dtpFechaAlta.Name = "dtpFechaAlta"
        Me.dtpFechaAlta.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaAlta.TabIndex = 4
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(37, 163)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(58, 13)
        Me.CiLabel6.TabIndex = 48
        Me.CiLabel6.Text = "Fecha Alta"
        '
        'txtAbuelosMaternos
        '
        Me.txtAbuelosMaternos.BackColor = System.Drawing.SystemColors.Window
        Me.txtAbuelosMaternos.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtAbuelosMaternos.Location = New System.Drawing.Point(157, 106)
        Me.txtAbuelosMaternos.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAbuelosMaternos.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAbuelosMaternos.Name = "txtAbuelosMaternos"
        Me.txtAbuelosMaternos.Size = New System.Drawing.Size(280, 20)
        Me.txtAbuelosMaternos.TabIndex = 3
        Me.txtAbuelosMaternos.UIName = "Nombre"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(39, 109)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(92, 13)
        Me.CiLabel4.TabIndex = 46
        Me.CiLabel4.Text = "Abuelos Maternos"
        '
        'txtAbuelosPaternos
        '
        Me.txtAbuelosPaternos.BackColor = System.Drawing.SystemColors.Window
        Me.txtAbuelosPaternos.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtAbuelosPaternos.Location = New System.Drawing.Point(157, 80)
        Me.txtAbuelosPaternos.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAbuelosPaternos.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAbuelosPaternos.Name = "txtAbuelosPaternos"
        Me.txtAbuelosPaternos.Size = New System.Drawing.Size(280, 20)
        Me.txtAbuelosPaternos.TabIndex = 2
        Me.txtAbuelosPaternos.UIName = "Nombre"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(39, 83)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(90, 13)
        Me.CiLabel5.TabIndex = 44
        Me.CiLabel5.Text = "Abuelos Paternos"
        '
        'txtNombreMadre
        '
        Me.txtNombreMadre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombreMadre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombreMadre.Location = New System.Drawing.Point(157, 54)
        Me.txtNombreMadre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreMadre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombreMadre.Name = "txtNombreMadre"
        Me.txtNombreMadre.Size = New System.Drawing.Size(280, 20)
        Me.txtNombreMadre.TabIndex = 1
        Me.txtNombreMadre.UIName = "Nombre"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(39, 57)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(103, 13)
        Me.CiLabel1.TabIndex = 42
        Me.CiLabel1.Text = "Nombre de la Madre"
        '
        'txtLugarNacimiento
        '
        Me.txtLugarNacimiento.BackColor = System.Drawing.SystemColors.Window
        Me.txtLugarNacimiento.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtLugarNacimiento.Location = New System.Drawing.Point(157, 132)
        Me.txtLugarNacimiento.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLugarNacimiento.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLugarNacimiento.Name = "txtLugarNacimiento"
        Me.txtLugarNacimiento.Size = New System.Drawing.Size(280, 20)
        Me.txtLugarNacimiento.TabIndex = 6
        Me.txtLugarNacimiento.UIName = "IMSS"
        '
        'txtNombrePadre
        '
        Me.txtNombrePadre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombrePadre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombrePadre.Location = New System.Drawing.Point(157, 28)
        Me.txtNombrePadre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombrePadre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombrePadre.Name = "txtNombrePadre"
        Me.txtNombrePadre.Size = New System.Drawing.Size(280, 20)
        Me.txtNombrePadre.TabIndex = 0
        Me.txtNombrePadre.UIName = "Nombre"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(39, 31)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(92, 13)
        Me.lblTitulo.TabIndex = 24
        Me.lblTitulo.Text = "Nombre del Padre"
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
        Me.tabDomicilio.Size = New System.Drawing.Size(519, 329)
        Me.tabDomicilio.TabIndex = 4
        Me.tabDomicilio.Text = "Domicilio"
        Me.tabDomicilio.UseVisualStyleBackColor = True
        '
        'txtNumInt
        '
        Me.txtNumInt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumInt.Location = New System.Drawing.Point(352, 63)
        Me.txtNumInt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.Name = "txtNumInt"
        Me.txtNumInt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumInt.TabIndex = 2
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
        Me.txtPoblacion.EditorAssembly = "Azteca.Windows"
        Me.txtPoblacion.EditorClass = "Azteca.Windows.Forms.General.CatalogoPoblaciones"
        Me.txtPoblacion.EditorTitle = "Editar población..."
        Me.txtPoblacion.FieldName = Nothing
        Me.txtPoblacion.Key = 0
        Me.txtPoblacion.Linked = False
        Me.txtPoblacion.Location = New System.Drawing.Point(122, 141)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(300, 23)
        Me.txtPoblacion.TabIndex = 5
        Me.txtPoblacion.TextWidth = 70
        Me.txtPoblacion.UIName = Nothing
        '
        'lblEstadoInf
        '
        Me.lblEstadoInf.AutoSize = True
        Me.lblEstadoInf.Location = New System.Drawing.Point(121, 173)
        Me.lblEstadoInf.Name = "lblEstadoInf"
        Me.lblEstadoInf.Size = New System.Drawing.Size(46, 13)
        Me.lblEstadoInf.TabIndex = 6
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
        Me.txtCP.Digits = True
        Me.txtCP.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCP.Location = New System.Drawing.Point(122, 115)
        Me.txtCP.MaxLength = 5
        Me.txtCP.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(70, 20)
        Me.txtCP.TabIndex = 4
        Me.txtCP.UIName = Nothing
        '
        'txtColonia
        '
        Me.txtColonia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtColonia.Location = New System.Drawing.Point(122, 89)
        Me.txtColonia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(300, 20)
        Me.txtColonia.TabIndex = 3
        Me.txtColonia.UIName = Nothing
        '
        'txtNumExt
        '
        Me.txtNumExt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumExt.Location = New System.Drawing.Point(122, 63)
        Me.txtNumExt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumExt.TabIndex = 1
        Me.txtNumExt.UIName = Nothing
        '
        'txtCalle
        '
        Me.txtCalle.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalle.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCalle.Location = New System.Drawing.Point(122, 37)
        Me.txtCalle.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(300, 20)
        Me.txtCalle.TabIndex = 0
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
        'tabFoto
        '
        Me.tabFoto.Controls.Add(Me.lbImagen)
        Me.tabFoto.Controls.Add(Me.picEmpleado)
        Me.tabFoto.ImageIndex = 0
        Me.tabFoto.Location = New System.Drawing.Point(4, 39)
        Me.tabFoto.Name = "tabFoto"
        Me.tabFoto.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFoto.Size = New System.Drawing.Size(519, 329)
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
        'iLstTabs
        '
        Me.iLstTabs.ImageStream = CType(resources.GetObject("iLstTabs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLstTabs.TransparentColor = System.Drawing.Color.Transparent
        Me.iLstTabs.Images.SetKeyName(0, "mask_32.png")
        Me.iLstTabs.Images.SetKeyName(1, "administrator_32.png")
        Me.iLstTabs.Images.SetKeyName(2, "book_32.png")
        Me.iLstTabs.Images.SetKeyName(3, "hand_32.png")
        Me.iLstTabs.Images.SetKeyName(4, "home_32.png")
        Me.iLstTabs.Images.SetKeyName(5, "Sacerdote.png")
        Me.iLstTabs.Images.SetKeyName(6, "Bautismo.png")
        Me.iLstTabs.Images.SetKeyName(7, "bautismoEucaristia.png")
        '
        'SolicitantesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 490)
        Me.Controls.Add(Me.tabEmpleados)
        Me.Name = "SolicitantesForm"
        Me.Text = "SolicitantesForm"
        Me.Controls.SetChildIndex(Me.tabEmpleados, 0)
        Me.tabEmpleados.ResumeLayout(False)
        Me.tabGenerales.ResumeLayout(False)
        Me.tabGenerales.PerformLayout()
        Me.TabBautismo.ResumeLayout(False)
        Me.TabBautismo.PerformLayout()
        Me.grpBautismo.ResumeLayout(False)
        Me.grpBautismo.PerformLayout()
        Me.tabLaboral.ResumeLayout(False)
        Me.tabLaboral.PerformLayout()
        Me.tabDomicilio.ResumeLayout(False)
        Me.tabDomicilio.PerformLayout()
        Me.tabFoto.ResumeLayout(False)
        Me.tabFoto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New SolicitanteFacade
    End Sub
    Friend WithEvents tabEmpleados As Azteca.Windows.Controls.CITab
    Friend WithEvents tabGenerales As System.Windows.Forms.TabPage
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
    Friend WithEvents chkActivo As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents dtpFechaNacimiento As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents lblfechaNacimiento As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblSexo As Azteca.Windows.Controls.CILabel
    Friend WithEvents rbtnFemenino As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rbtnMasculino As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents tabDomicilio As System.Windows.Forms.TabPage
    Friend WithEvents txtNumInt As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNumInt As Azteca.Windows.Controls.CILabel
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
    Friend WithEvents tabLaboral As System.Windows.Forms.TabPage
    Friend WithEvents txtLugarNacimiento As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNombrePadre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblTitulo As Azteca.Windows.Controls.CILabel
    Friend WithEvents tabFoto As System.Windows.Forms.TabPage
    Friend WithEvents lbImagen As Azteca.Windows.Controls.CILabel
    Friend WithEvents picEmpleado As Azteca.Windows.Controls.CIPictureManager
    Friend WithEvents iLstTabs As System.Windows.Forms.ImageList
    Friend WithEvents txtNombreCorto As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtAbuelosMaternos As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtAbuelosPaternos As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombreMadre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaAlta As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents TabBautismo As System.Windows.Forms.TabPage
    Friend WithEvents grpBautismo As System.Windows.Forms.GroupBox
    Friend WithEvents txtActaBautismo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel10 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtPaginaBautismo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel9 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtLibroBautismo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel14 As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkCapturaManual As System.Windows.Forms.CheckBox
    Friend WithEvents BautismoSel As Azteca.Windows.Iglesia.BautismoSelector
    Friend WithEvents CiLabel21 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel16 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNumInteriorBautismo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel11 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblEstadoBautismo As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel15 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCPBautismo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtColoniaBautismo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNumExteriorBautismo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCalleBautismo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel17 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel18 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel19 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel20 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel13 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtParroquiaBautismo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel12 As Azteca.Windows.Controls.CILabel
    Friend WithEvents PoblacionBautismoSel As Azteca.Windows.Controls.General.PoblacionSelector
    Friend WithEvents dtpFechaBautismo As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents lblCURP As Azteca.Windows.Controls.CILabel
End Class
