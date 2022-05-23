<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MatrimonioForm
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
        Me.dtpFechaExpedicion = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtPBRO1 = New Azteca.Windows.Controls.CITextBox()
        Me.chkMostrarListaSacerdotes = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtActaIzq = New Azteca.Windows.Controls.CITextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPagina = New Azteca.Windows.Controls.CITextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLibro = New Azteca.Windows.Controls.CITextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdImprimirConstancia = New System.Windows.Forms.Button()
        Me.cmdImprimirActa = New System.Windows.Forms.Button()
        Me.txtContrajeonEn = New Azteca.Windows.Controls.CITextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtActaDer = New Azteca.Windows.Controls.CITextBox()
        Me.txtExpedienteDer = New Azteca.Windows.Controls.CITextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtExpedienteIzq = New Azteca.Windows.Controls.CITextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAsistio = New Azteca.Windows.Controls.CITextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTestigo1 = New Azteca.Windows.Controls.CITextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTestigo2 = New Azteca.Windows.Controls.CITextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPadrino1 = New Azteca.Windows.Controls.CITextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPadrino2 = New Azteca.Windows.Controls.CITextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTraslado = New Azteca.Windows.Controls.CITextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtEsposa = New Azteca.Windows.Iglesia.SolicitanteSelector()
        Me.txtParroquiaDe = New Azteca.Windows.Iglesia.ParroquiaSelector()
        Me.txtSacerdote = New Azteca.Windows.Iglesia.SacerdoteSelector()
        Me.txtEsposo = New Azteca.Windows.Iglesia.SolicitanteSelector()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpFechaExpedicion
        '
        Me.dtpFechaExpedicion.Location = New System.Drawing.Point(120, 315)
        Me.dtpFechaExpedicion.Name = "dtpFechaExpedicion"
        Me.dtpFechaExpedicion.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaExpedicion.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(20, 318)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(92, 13)
        Me.Label21.TabIndex = 114
        Me.Label21.Text = "Fecha Expedición"
        '
        'txtPBRO1
        '
        Me.txtPBRO1.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPBRO1.Location = New System.Drawing.Point(122, 234)
        Me.txtPBRO1.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPBRO1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPBRO1.Name = "txtPBRO1"
        Me.txtPBRO1.Size = New System.Drawing.Size(290, 20)
        Me.txtPBRO1.TabIndex = 112
        Me.txtPBRO1.UIName = "Serie"
        Me.txtPBRO1.Visible = False
        '
        'chkMostrarListaSacerdotes
        '
        Me.chkMostrarListaSacerdotes.AutoSize = True
        Me.chkMostrarListaSacerdotes.Checked = True
        Me.chkMostrarListaSacerdotes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMostrarListaSacerdotes.Location = New System.Drawing.Point(101, 236)
        Me.chkMostrarListaSacerdotes.Name = "chkMostrarListaSacerdotes"
        Me.chkMostrarListaSacerdotes.Size = New System.Drawing.Size(15, 14)
        Me.chkMostrarListaSacerdotes.TabIndex = 111
        Me.chkMostrarListaSacerdotes.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(372, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 110
        Me.Label11.Text = "Esposo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Suscrito:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(176, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "/"
        '
        'txtActaIzq
        '
        Me.txtActaIzq.Digits = True
        Me.txtActaIzq.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtActaIzq.Location = New System.Drawing.Point(92, 62)
        Me.txtActaIzq.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtActaIzq.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtActaIzq.Name = "txtActaIzq"
        Me.txtActaIzq.RequiredField = True
        Me.txtActaIzq.Size = New System.Drawing.Size(70, 20)
        Me.txtActaIzq.TabIndex = 98
        Me.txtActaIzq.UIName = "Serie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Actas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "/"
        '
        'txtPagina
        '
        Me.txtPagina.Digits = True
        Me.txtPagina.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPagina.Location = New System.Drawing.Point(202, 36)
        Me.txtPagina.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPagina.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPagina.Name = "txtPagina"
        Me.txtPagina.RequiredField = True
        Me.txtPagina.Size = New System.Drawing.Size(70, 20)
        Me.txtPagina.TabIndex = 97
        Me.txtPagina.UIName = "Serie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Pagina"
        '
        'txtLibro
        '
        Me.txtLibro.Digits = True
        Me.txtLibro.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtLibro.Location = New System.Drawing.Point(93, 36)
        Me.txtLibro.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLibro.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLibro.Name = "txtLibro"
        Me.txtLibro.RequiredField = True
        Me.txtLibro.Size = New System.Drawing.Size(70, 20)
        Me.txtLibro.TabIndex = 96
        Me.txtLibro.UIName = "Serie"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Libro"
        '
        'cmdImprimirConstancia
        '
        Me.cmdImprimirConstancia.Image = Global.Azteca.Windows.Iglesia.My.Resources.Resources.constancia
        Me.cmdImprimirConstancia.Location = New System.Drawing.Point(243, 378)
        Me.cmdImprimirConstancia.Name = "cmdImprimirConstancia"
        Me.cmdImprimirConstancia.Size = New System.Drawing.Size(111, 30)
        Me.cmdImprimirConstancia.TabIndex = 15
        Me.cmdImprimirConstancia.Text = "Imp. Constancia"
        Me.cmdImprimirConstancia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdImprimirConstancia.UseVisualStyleBackColor = True
        '
        'cmdImprimirActa
        '
        Me.cmdImprimirActa.Image = Global.Azteca.Windows.Iglesia.My.Resources.Resources.acta
        Me.cmdImprimirActa.Location = New System.Drawing.Point(119, 378)
        Me.cmdImprimirActa.Name = "cmdImprimirActa"
        Me.cmdImprimirActa.Size = New System.Drawing.Size(111, 30)
        Me.cmdImprimirActa.TabIndex = 14
        Me.cmdImprimirActa.Text = "Imp. Acta"
        Me.cmdImprimirActa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdImprimirActa.UseVisualStyleBackColor = True
        '
        'txtContrajeonEn
        '
        Me.txtContrajeonEn.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtContrajeonEn.Location = New System.Drawing.Point(454, 178)
        Me.txtContrajeonEn.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtContrajeonEn.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtContrajeonEn.Name = "txtContrajeonEn"
        Me.txtContrajeonEn.Size = New System.Drawing.Size(310, 20)
        Me.txtContrajeonEn.TabIndex = 8
        Me.txtContrajeonEn.UIName = "Serie"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(369, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "Contrajeron en:"
        '
        'txtActaDer
        '
        Me.txtActaDer.Digits = True
        Me.txtActaDer.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtActaDer.Location = New System.Drawing.Point(201, 62)
        Me.txtActaDer.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtActaDer.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtActaDer.Name = "txtActaDer"
        Me.txtActaDer.RequiredField = True
        Me.txtActaDer.Size = New System.Drawing.Size(70, 20)
        Me.txtActaDer.TabIndex = 131
        Me.txtActaDer.UIName = "Serie"
        '
        'txtExpedienteDer
        '
        Me.txtExpedienteDer.Digits = True
        Me.txtExpedienteDer.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtExpedienteDer.Location = New System.Drawing.Point(201, 88)
        Me.txtExpedienteDer.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtExpedienteDer.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtExpedienteDer.Name = "txtExpedienteDer"
        Me.txtExpedienteDer.Size = New System.Drawing.Size(70, 20)
        Me.txtExpedienteDer.TabIndex = 135
        Me.txtExpedienteDer.UIName = "Serie"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(176, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 134
        Me.Label8.Text = "/"
        '
        'txtExpedienteIzq
        '
        Me.txtExpedienteIzq.Digits = True
        Me.txtExpedienteIzq.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtExpedienteIzq.Location = New System.Drawing.Point(92, 88)
        Me.txtExpedienteIzq.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtExpedienteIzq.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtExpedienteIzq.Name = "txtExpedienteIzq"
        Me.txtExpedienteIzq.Size = New System.Drawing.Size(70, 20)
        Me.txtExpedienteIzq.TabIndex = 132
        Me.txtExpedienteIzq.UIName = "Serie"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 133
        Me.Label10.Text = "Expediente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 137
        Me.Label7.Text = "Parroco de:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(120, 289)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 139
        Me.Label9.Text = "Fecha "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(372, 140)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 13)
        Me.Label22.TabIndex = 141
        Me.Label22.Text = "Esposa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPagina)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtLibro)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtActaIzq)
        Me.GroupBox1.Controls.Add(Me.txtExpedienteDer)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtActaDer)
        Me.GroupBox1.Controls.Add(Me.txtExpedienteIzq)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 124)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Registro"
        '
        'txtAsistio
        '
        Me.txtAsistio.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtAsistio.Location = New System.Drawing.Point(120, 344)
        Me.txtAsistio.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAsistio.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAsistio.Name = "txtAsistio"
        Me.txtAsistio.Size = New System.Drawing.Size(200, 20)
        Me.txtAsistio.TabIndex = 5
        Me.txtAsistio.UIName = "Serie"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 347)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 144
        Me.Label13.Text = "Asistio"
        '
        'txtTestigo1
        '
        Me.txtTestigo1.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTestigo1.Location = New System.Drawing.Point(526, 236)
        Me.txtTestigo1.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTestigo1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTestigo1.Name = "txtTestigo1"
        Me.txtTestigo1.Size = New System.Drawing.Size(238, 20)
        Me.txtTestigo1.TabIndex = 9
        Me.txtTestigo1.UIName = "Serie"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(441, 239)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 146
        Me.Label14.Text = "1er. Testigo"
        '
        'txtTestigo2
        '
        Me.txtTestigo2.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTestigo2.Location = New System.Drawing.Point(526, 262)
        Me.txtTestigo2.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTestigo2.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTestigo2.Name = "txtTestigo2"
        Me.txtTestigo2.Size = New System.Drawing.Size(238, 20)
        Me.txtTestigo2.TabIndex = 10
        Me.txtTestigo2.UIName = "Serie"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(441, 265)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 13)
        Me.Label15.TabIndex = 148
        Me.Label15.Text = "2do. Testigo"
        '
        'txtPadrino1
        '
        Me.txtPadrino1.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPadrino1.Location = New System.Drawing.Point(526, 288)
        Me.txtPadrino1.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPadrino1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPadrino1.Name = "txtPadrino1"
        Me.txtPadrino1.Size = New System.Drawing.Size(238, 20)
        Me.txtPadrino1.TabIndex = 11
        Me.txtPadrino1.UIName = "Serie"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(441, 291)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 13)
        Me.Label16.TabIndex = 150
        Me.Label16.Text = "1er. Padrino"
        '
        'txtPadrino2
        '
        Me.txtPadrino2.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPadrino2.Location = New System.Drawing.Point(526, 314)
        Me.txtPadrino2.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPadrino2.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPadrino2.Name = "txtPadrino2"
        Me.txtPadrino2.Size = New System.Drawing.Size(238, 20)
        Me.txtPadrino2.TabIndex = 12
        Me.txtPadrino2.UIName = "Serie"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(441, 317)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 13)
        Me.Label17.TabIndex = 152
        Me.Label17.Text = "2do. Padrino"
        '
        'txtTraslado
        '
        Me.txtTraslado.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTraslado.Location = New System.Drawing.Point(526, 340)
        Me.txtTraslado.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTraslado.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTraslado.Multiline = True
        Me.txtTraslado.Name = "txtTraslado"
        Me.txtTraslado.Size = New System.Drawing.Size(238, 42)
        Me.txtTraslado.TabIndex = 13
        Me.txtTraslado.UIName = "Serie"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(441, 344)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 13)
        Me.Label19.TabIndex = 156
        Me.Label19.Text = "Traslado"
        '
        'txtEsposa
        '
        Me.txtEsposa.AnySite = False
        Me.txtEsposa.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtEsposa.EditorAssembly = "Azteca.IglesiaWin"
        Me.txtEsposa.EditorClass = "Azteca.Windows.Iglesia.SolicitantesForm"
        Me.txtEsposa.EditorTitle = "Editar los datos del Solicitante..."
        Me.txtEsposa.Key = 0
        Me.txtEsposa.Linked = False
        Me.txtEsposa.Location = New System.Drawing.Point(454, 140)
        Me.txtEsposa.Name = "txtEsposa"
        Me.txtEsposa.RequiredField = True
        Me.txtEsposa.Size = New System.Drawing.Size(310, 23)
        Me.txtEsposa.TabIndex = 7
        '
        'txtParroquiaDe
        '
        Me.txtParroquiaDe.AnySite = False
        Me.txtParroquiaDe.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtParroquiaDe.EditorAssembly = "Azteca.IglesiaWin"
        Me.txtParroquiaDe.EditorClass = "Azteca.Windows.Iglesia.ParroquiasForm"
        Me.txtParroquiaDe.EditorTitle = "Editar los datos de la Parroquia..."
        Me.txtParroquiaDe.Key = 0
        Me.txtParroquiaDe.Linked = False
        Me.txtParroquiaDe.Location = New System.Drawing.Point(120, 260)
        Me.txtParroquiaDe.Name = "txtParroquiaDe"
        Me.txtParroquiaDe.Size = New System.Drawing.Size(292, 23)
        Me.txtParroquiaDe.TabIndex = 2
        '
        'txtSacerdote
        '
        Me.txtSacerdote.AnySite = False
        Me.txtSacerdote.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtSacerdote.EditorAssembly = "Azteca.IglesiaWin"
        Me.txtSacerdote.EditorClass = "Azteca.Windows.Iglesia.SacerdotesForm"
        Me.txtSacerdote.EditorTitle = "Editar los datos del Sacerdote..."
        Me.txtSacerdote.Key = 0
        Me.txtSacerdote.Linked = False
        Me.txtSacerdote.Location = New System.Drawing.Point(121, 234)
        Me.txtSacerdote.Name = "txtSacerdote"
        Me.txtSacerdote.Size = New System.Drawing.Size(291, 23)
        Me.txtSacerdote.TabIndex = 1
        '
        'txtEsposo
        '
        Me.txtEsposo.AnySite = False
        Me.txtEsposo.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtEsposo.EditorAssembly = "Azteca.IglesiaWin"
        Me.txtEsposo.EditorClass = "Azteca.Windows.Iglesia.SolicitantesForm"
        Me.txtEsposo.EditorTitle = "Editar los datos del Solicitante..."
        Me.txtEsposo.Key = 0
        Me.txtEsposo.Linked = False
        Me.txtEsposo.Location = New System.Drawing.Point(454, 110)
        Me.txtEsposo.Name = "txtEsposo"
        Me.txtEsposo.RequiredField = True
        Me.txtEsposo.Size = New System.Drawing.Size(310, 23)
        Me.txtEsposo.TabIndex = 6
        '
        'MatrimonioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 448)
        Me.Controls.Add(Me.txtTraslado)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtPadrino2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtPadrino1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtTestigo2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTestigo1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtAsistio)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtEsposa)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtParroquiaDe)
        Me.Controls.Add(Me.txtContrajeonEn)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmdImprimirConstancia)
        Me.Controls.Add(Me.cmdImprimirActa)
        Me.Controls.Add(Me.txtSacerdote)
        Me.Controls.Add(Me.dtpFechaExpedicion)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtPBRO1)
        Me.Controls.Add(Me.chkMostrarListaSacerdotes)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEsposo)
        Me.Name = "MatrimonioForm"
        Me.Text = "MatrimonioForm"
        Me.Controls.SetChildIndex(Me.txtEsposo, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.chkMostrarListaSacerdotes, 0)
        Me.Controls.SetChildIndex(Me.txtPBRO1, 0)
        Me.Controls.SetChildIndex(Me.Label21, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaExpedicion, 0)
        Me.Controls.SetChildIndex(Me.txtSacerdote, 0)
        Me.Controls.SetChildIndex(Me.cmdImprimirActa, 0)
        Me.Controls.SetChildIndex(Me.cmdImprimirConstancia, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.txtContrajeonEn, 0)
        Me.Controls.SetChildIndex(Me.txtParroquiaDe, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.dtpFecha, 0)
        Me.Controls.SetChildIndex(Me.txtEsposa, 0)
        Me.Controls.SetChildIndex(Me.Label22, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.txtAsistio, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.txtTestigo1, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.txtTestigo2, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.txtPadrino1, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.txtPadrino2, 0)
        Me.Controls.SetChildIndex(Me.Label19, 0)
        Me.Controls.SetChildIndex(Me.txtTraslado, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New MatrimonioFacade
    End Sub
    Friend WithEvents txtSacerdote As Azteca.Windows.Iglesia.SacerdoteSelector
    Friend WithEvents dtpFechaExpedicion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtPBRO1 As Azteca.Windows.Controls.CITextBox
    Friend WithEvents chkMostrarListaSacerdotes As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtActaIzq As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPagina As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLibro As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEsposo As Azteca.Windows.Iglesia.SolicitanteSelector
    Friend WithEvents cmdImprimirConstancia As System.Windows.Forms.Button
    Friend WithEvents cmdImprimirActa As System.Windows.Forms.Button
    Friend WithEvents txtContrajeonEn As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtActaDer As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtExpedienteDer As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtExpedienteIzq As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtParroquiaDe As Azteca.Windows.Iglesia.ParroquiaSelector
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtEsposa As Azteca.Windows.Iglesia.SolicitanteSelector
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAsistio As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTestigo1 As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTestigo2 As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPadrino1 As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtPadrino2 As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTraslado As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label

End Class
