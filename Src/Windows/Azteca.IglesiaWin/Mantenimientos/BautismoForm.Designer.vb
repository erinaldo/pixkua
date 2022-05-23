<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BautismoForm
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
        Me.cmdImprimirActa = New System.Windows.Forms.Button()
        Me.cmdImprimirConstancia = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLibro = New Azteca.Windows.Controls.CITextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPagina = New Azteca.Windows.Controls.CITextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtActa = New Azteca.Windows.Controls.CITextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLugar = New Azteca.Windows.Controls.CITextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFechaBautizo = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPadrinos = New Azteca.Windows.Controls.CITextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNotasaMarginales = New Azteca.Windows.Controls.CITextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtLugarRegistro = New Azteca.Windows.Controls.CITextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtNumActa = New Azteca.Windows.Controls.CITextBox()
        Me.txtLibroActa = New Azteca.Windows.Controls.CITextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNumOficina = New Azteca.Windows.Controls.CITextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chkIlegitimo = New System.Windows.Forms.CheckBox()
        Me.txtTenor = New Azteca.Windows.Controls.CITextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.chkMostrarListaSacerdotes = New System.Windows.Forms.CheckBox()
        Me.txtPBRO1 = New Azteca.Windows.Controls.CITextBox()
        Me.dtpFechaExpedicion = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtSacerdoteCertifica = New Azteca.Windows.Iglesia.SacerdoteSelector()
        Me.SolicitanteSel = New Azteca.Windows.Iglesia.SolicitanteSelector()
        Me.txtSacerdoteBautizo = New Azteca.Windows.Iglesia.SacerdoteSelector()
        Me.txtParroquia = New Azteca.Windows.Iglesia.ParroquiaSelector()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdImprimirActa
        '
        Me.cmdImprimirActa.Image = Global.Azteca.Windows.Iglesia.My.Resources.Resources.acta
        Me.cmdImprimirActa.Location = New System.Drawing.Point(113, 348)
        Me.cmdImprimirActa.Name = "cmdImprimirActa"
        Me.cmdImprimirActa.Size = New System.Drawing.Size(120, 30)
        Me.cmdImprimirActa.TabIndex = 15
        Me.cmdImprimirActa.Text = "Imp. Acta"
        Me.cmdImprimirActa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdImprimirActa.UseVisualStyleBackColor = True
        '
        'cmdImprimirConstancia
        '
        Me.cmdImprimirConstancia.Image = Global.Azteca.Windows.Iglesia.My.Resources.Resources.constancia
        Me.cmdImprimirConstancia.Location = New System.Drawing.Point(260, 348)
        Me.cmdImprimirConstancia.Name = "cmdImprimirConstancia"
        Me.cmdImprimirConstancia.Size = New System.Drawing.Size(111, 30)
        Me.cmdImprimirConstancia.TabIndex = 16
        Me.cmdImprimirConstancia.Text = "Imp. Constancia"
        Me.cmdImprimirConstancia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdImprimirConstancia.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Libro"
        '
        'txtLibro
        '
        Me.txtLibro.Digits = True
        Me.txtLibro.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtLibro.Location = New System.Drawing.Point(113, 123)
        Me.txtLibro.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLibro.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLibro.Name = "txtLibro"
        Me.txtLibro.RequiredField = True
        Me.txtLibro.Size = New System.Drawing.Size(70, 20)
        Me.txtLibro.TabIndex = 0
        Me.txtLibro.UIName = "Serie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Pagina"
        '
        'txtPagina
        '
        Me.txtPagina.Digits = True
        Me.txtPagina.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPagina.Location = New System.Drawing.Point(208, 123)
        Me.txtPagina.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPagina.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPagina.Name = "txtPagina"
        Me.txtPagina.RequiredField = True
        Me.txtPagina.Size = New System.Drawing.Size(70, 20)
        Me.txtPagina.TabIndex = 1
        Me.txtPagina.UIName = "Serie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "/"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(299, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Acta"
        '
        'txtActa
        '
        Me.txtActa.Digits = True
        Me.txtActa.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtActa.Location = New System.Drawing.Point(302, 123)
        Me.txtActa.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtActa.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtActa.Name = "txtActa"
        Me.txtActa.RequiredField = True
        Me.txtActa.Size = New System.Drawing.Size(70, 20)
        Me.txtActa.TabIndex = 2
        Me.txtActa.UIName = "Serie"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(284, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "/"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Certifica PBRO."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Lugar"
        '
        'txtLugar
        '
        Me.txtLugar.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtLugar.Location = New System.Drawing.Point(112, 186)
        Me.txtLugar.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLugar.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(259, 20)
        Me.txtLugar.TabIndex = 4
        Me.txtLugar.UIName = "Serie"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "En Parroquia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 242)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Fecha Bautismo"
        '
        'dtpFechaBautizo
        '
        Me.dtpFechaBautizo.Location = New System.Drawing.Point(112, 241)
        Me.dtpFechaBautizo.Name = "dtpFechaBautizo"
        Me.dtpFechaBautizo.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaBautizo.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Bautizó PBRO."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 298)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Bautizó a"
        '
        'txtPadrinos
        '
        Me.txtPadrinos.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPadrinos.Location = New System.Drawing.Point(444, 126)
        Me.txtPadrinos.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPadrinos.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPadrinos.Name = "txtPadrinos"
        Me.txtPadrinos.Size = New System.Drawing.Size(259, 20)
        Me.txtPadrinos.TabIndex = 11
        Me.txtPadrinos.UIName = "Serie"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(390, 129)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Padrinos"
        '
        'txtNotasaMarginales
        '
        Me.txtNotasaMarginales.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNotasaMarginales.Location = New System.Drawing.Point(444, 152)
        Me.txtNotasaMarginales.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNotasaMarginales.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNotasaMarginales.Multiline = True
        Me.txtNotasaMarginales.Name = "txtNotasaMarginales"
        Me.txtNotasaMarginales.Size = New System.Drawing.Size(259, 51)
        Me.txtNotasaMarginales.TabIndex = 12
        Me.txtNotasaMarginales.UIName = "Serie"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(388, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 26)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Notas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Marginales"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLugarRegistro)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtNumActa)
        Me.GroupBox1.Controls.Add(Me.txtLibroActa)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtNumOficina)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Location = New System.Drawing.Point(446, 238)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 118)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro Civil"
        '
        'txtLugarRegistro
        '
        Me.txtLugarRegistro.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtLugarRegistro.Location = New System.Drawing.Point(46, 76)
        Me.txtLugarRegistro.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLugarRegistro.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLugarRegistro.Name = "txtLugarRegistro"
        Me.txtLugarRegistro.Size = New System.Drawing.Size(207, 20)
        Me.txtLugarRegistro.TabIndex = 3
        Me.txtLugarRegistro.UIName = "Serie"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 79)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 13)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "Lugar"
        '
        'txtNumActa
        '
        Me.txtNumActa.Digits = True
        Me.txtNumActa.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumActa.Location = New System.Drawing.Point(199, 36)
        Me.txtNumActa.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumActa.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumActa.Name = "txtNumActa"
        Me.txtNumActa.Size = New System.Drawing.Size(52, 20)
        Me.txtNumActa.TabIndex = 2
        Me.txtNumActa.UIName = "Serie"
        '
        'txtLibroActa
        '
        Me.txtLibroActa.Digits = True
        Me.txtLibroActa.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtLibroActa.Location = New System.Drawing.Point(104, 36)
        Me.txtLibroActa.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLibroActa.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLibroActa.Name = "txtLibroActa"
        Me.txtLibroActa.Size = New System.Drawing.Size(52, 20)
        Me.txtLibroActa.TabIndex = 1
        Me.txtLibroActa.UIName = "Serie"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(171, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(12, 13)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "/"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Oficina"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(196, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "Acta Num."
        '
        'txtNumOficina
        '
        Me.txtNumOficina.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumOficina.Location = New System.Drawing.Point(9, 36)
        Me.txtNumOficina.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumOficina.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumOficina.Name = "txtNumOficina"
        Me.txtNumOficina.Size = New System.Drawing.Size(52, 20)
        Me.txtNumOficina.TabIndex = 0
        Me.txtNumOficina.UIName = "Serie"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(76, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(12, 13)
        Me.Label16.TabIndex = 63
        Me.Label16.Text = "/"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(101, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 13)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "Libro"
        '
        'chkIlegitimo
        '
        Me.chkIlegitimo.AutoSize = True
        Me.chkIlegitimo.Checked = True
        Me.chkIlegitimo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIlegitimo.Location = New System.Drawing.Point(444, 103)
        Me.chkIlegitimo.Name = "chkIlegitimo"
        Me.chkIlegitimo.Size = New System.Drawing.Size(64, 17)
        Me.chkIlegitimo.TabIndex = 10
        Me.chkIlegitimo.Text = "Ilegitimo"
        Me.chkIlegitimo.UseVisualStyleBackColor = True
        '
        'txtTenor
        '
        Me.txtTenor.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTenor.Location = New System.Drawing.Point(444, 212)
        Me.txtTenor.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTenor.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTenor.Name = "txtTenor"
        Me.txtTenor.Size = New System.Drawing.Size(259, 20)
        Me.txtTenor.TabIndex = 13
        Me.txtTenor.UIName = "Serie"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(390, 215)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 13)
        Me.Label20.TabIndex = 60
        Me.Label20.Text = "Tenor"
        '
        'chkMostrarListaSacerdotes
        '
        Me.chkMostrarListaSacerdotes.AutoSize = True
        Me.chkMostrarListaSacerdotes.Checked = True
        Me.chkMostrarListaSacerdotes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMostrarListaSacerdotes.Location = New System.Drawing.Point(92, 162)
        Me.chkMostrarListaSacerdotes.Name = "chkMostrarListaSacerdotes"
        Me.chkMostrarListaSacerdotes.Size = New System.Drawing.Size(15, 14)
        Me.chkMostrarListaSacerdotes.TabIndex = 61
        Me.chkMostrarListaSacerdotes.UseVisualStyleBackColor = True
        '
        'txtPBRO1
        '
        Me.txtPBRO1.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPBRO1.Location = New System.Drawing.Point(114, 159)
        Me.txtPBRO1.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPBRO1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPBRO1.Name = "txtPBRO1"
        Me.txtPBRO1.Size = New System.Drawing.Size(259, 20)
        Me.txtPBRO1.TabIndex = 3
        Me.txtPBRO1.UIName = "Serie"
        Me.txtPBRO1.Visible = False
        '
        'dtpFechaExpedicion
        '
        Me.dtpFechaExpedicion.Location = New System.Drawing.Point(113, 322)
        Me.dtpFechaExpedicion.Name = "dtpFechaExpedicion"
        Me.dtpFechaExpedicion.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaExpedicion.TabIndex = 9
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(13, 325)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(92, 13)
        Me.Label21.TabIndex = 64
        Me.Label21.Text = "Fecha Expedición"
        '
        'txtSacerdoteCertifica
        '
        Me.txtSacerdoteCertifica.AnySite = False
        Me.txtSacerdoteCertifica.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtSacerdoteCertifica.EditorAssembly = "Azteca.IglesiaWin"
        Me.txtSacerdoteCertifica.EditorClass = "Azteca.Windows.Iglesia.SacerdotesForm"
        Me.txtSacerdoteCertifica.EditorTitle = "Editar los datos del Sacerdote..."
        Me.txtSacerdoteCertifica.Key = 0
        Me.txtSacerdoteCertifica.Linked = False
        Me.txtSacerdoteCertifica.Location = New System.Drawing.Point(114, 156)
        Me.txtSacerdoteCertifica.Name = "txtSacerdoteCertifica"
        Me.txtSacerdoteCertifica.Size = New System.Drawing.Size(257, 23)
        Me.txtSacerdoteCertifica.TabIndex = 65
        '
        'SolicitanteSel
        '
        Me.SolicitanteSel.AnySite = False
        Me.SolicitanteSel.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.SolicitanteSel.EditorAssembly = "Azteca.IglesiaWin"
        Me.SolicitanteSel.EditorClass = "Azteca.Windows.Iglesia.SolicitantesForm"
        Me.SolicitanteSel.EditorTitle = "Editar los datos del Solicitante..."
        Me.SolicitanteSel.Key = 0
        Me.SolicitanteSel.Linked = False
        Me.SolicitanteSel.Location = New System.Drawing.Point(112, 293)
        Me.SolicitanteSel.Name = "SolicitanteSel"
        Me.SolicitanteSel.RequiredField = True
        Me.SolicitanteSel.Size = New System.Drawing.Size(259, 23)
        Me.SolicitanteSel.TabIndex = 8
        '
        'txtSacerdoteBautizo
        '
        Me.txtSacerdoteBautizo.AnySite = False
        Me.txtSacerdoteBautizo.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtSacerdoteBautizo.EditorAssembly = "Azteca.IglesiaWin"
        Me.txtSacerdoteBautizo.EditorClass = "Azteca.Windows.Iglesia.SacerdotesForm"
        Me.txtSacerdoteBautizo.EditorTitle = "Editar los datos del Sacerdote..."
        Me.txtSacerdoteBautizo.Key = 0
        Me.txtSacerdoteBautizo.Linked = False
        Me.txtSacerdoteBautizo.Location = New System.Drawing.Point(112, 267)
        Me.txtSacerdoteBautizo.Name = "txtSacerdoteBautizo"
        Me.txtSacerdoteBautizo.Size = New System.Drawing.Size(260, 23)
        Me.txtSacerdoteBautizo.TabIndex = 66
        '
        'txtParroquia
        '
        Me.txtParroquia.AnySite = False
        Me.txtParroquia.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtParroquia.EditorAssembly = "Azteca.IglesiaWin"
        Me.txtParroquia.EditorClass = "Azteca.Windows.Iglesia.ParroquiasForm"
        Me.txtParroquia.EditorTitle = "Editar los datos de la Parroquia..."
        Me.txtParroquia.Key = 0
        Me.txtParroquia.Linked = False
        Me.txtParroquia.Location = New System.Drawing.Point(112, 209)
        Me.txtParroquia.Name = "txtParroquia"
        Me.txtParroquia.Size = New System.Drawing.Size(259, 23)
        Me.txtParroquia.TabIndex = 67
        '
        'BautismoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 412)
        Me.Controls.Add(Me.txtParroquia)
        Me.Controls.Add(Me.txtSacerdoteBautizo)
        Me.Controls.Add(Me.txtSacerdoteCertifica)
        Me.Controls.Add(Me.dtpFechaExpedicion)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtPBRO1)
        Me.Controls.Add(Me.chkMostrarListaSacerdotes)
        Me.Controls.Add(Me.txtTenor)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.chkIlegitimo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNotasaMarginales)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtPadrinos)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmdImprimirConstancia)
        Me.Controls.Add(Me.cmdImprimirActa)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpFechaBautizo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtLugar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtActa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPagina)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLibro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SolicitanteSel)
        Me.Name = "BautismoForm"
        Me.Text = "BautismoForm"
        Me.Controls.SetChildIndex(Me.SolicitanteSel, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtLibro, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtPagina, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtActa, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.txtLugar, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaBautizo, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.cmdImprimirActa, 0)
        Me.Controls.SetChildIndex(Me.cmdImprimirConstancia, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.txtPadrinos, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.txtNotasaMarginales, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.chkIlegitimo, 0)
        Me.Controls.SetChildIndex(Me.Label20, 0)
        Me.Controls.SetChildIndex(Me.txtTenor, 0)
        Me.Controls.SetChildIndex(Me.chkMostrarListaSacerdotes, 0)
        Me.Controls.SetChildIndex(Me.txtPBRO1, 0)
        Me.Controls.SetChildIndex(Me.Label21, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaExpedicion, 0)
        Me.Controls.SetChildIndex(Me.txtSacerdoteCertifica, 0)
        Me.Controls.SetChildIndex(Me.txtSacerdoteBautizo, 0)
        Me.Controls.SetChildIndex(Me.txtParroquia, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New BautismoFacade
    End Sub
    Friend WithEvents cmdImprimirActa As System.Windows.Forms.Button
    Friend WithEvents cmdImprimirConstancia As System.Windows.Forms.Button
    Friend WithEvents SolicitanteSel As Azteca.Windows.Iglesia.SolicitanteSelector
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLibro As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPagina As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtActa As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLugar As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaBautizo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPadrinos As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNotasaMarginales As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLugarRegistro As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtNumActa As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtLibroActa As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtNumOficina As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chkIlegitimo As System.Windows.Forms.CheckBox
    Friend WithEvents txtTenor As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents chkMostrarListaSacerdotes As System.Windows.Forms.CheckBox
    Friend WithEvents txtPBRO1 As Azteca.Windows.Controls.CITextBox
    Friend WithEvents dtpFechaExpedicion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSacerdoteCertifica As Azteca.Windows.Iglesia.SacerdoteSelector
    Friend WithEvents txtSacerdoteBautizo As Azteca.Windows.Iglesia.SacerdoteSelector
    Friend WithEvents txtParroquia As Azteca.Windows.Iglesia.ParroquiaSelector
End Class
