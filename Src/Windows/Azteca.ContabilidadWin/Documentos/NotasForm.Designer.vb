<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotasForm
    Inherits Azteca.Windows.Forms.BusinessForms.DocumentForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotasForm))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.tabNota = New Azteca.Windows.Controls.CITab()
        Me.pagGeneral = New System.Windows.Forms.TabPage()
        Me.grpTotales = New Azteca.Windows.Controls.CIGroupBox()
        Me.cboDivisa = New Azteca.Windows.Contabilidad.DivisasComboBox()
        Me.CiLabel9 = New Azteca.Windows.Controls.CILabel()
        Me.lblTotal = New Azteca.Windows.Controls.CILabel()
        Me.lblImpuestos = New Azteca.Windows.Controls.CILabel()
        Me.lblSubTotal = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.grpReferencia = New Azteca.Windows.Controls.CIGroupBox()
        Me.txtSerieRef = New Azteca.Windows.Contabilidad.SerieSelector()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.txtFolioRef = New Azteca.Windows.Controls.CITextBox()
        Me.rdbVinculada = New Azteca.Windows.Controls.CIRadioButton()
        Me.rdbSinRef = New Azteca.Windows.Controls.CIRadioButton()
        Me.grpDatosNota = New Azteca.Windows.Controls.CIGroupBox()
        Me.rdbCredito = New Azteca.Windows.Controls.CIRadioButton()
        Me.lblFechaCFD = New Azteca.Windows.Controls.CILabel()
        Me.rdbCargo = New Azteca.Windows.Controls.CIRadioButton()
        Me.lblFechaCap = New Azteca.Windows.Controls.CILabel()
        Me.lblFolio = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.pagDatosFiscales = New System.Windows.Forms.TabPage()
        Me.btnCopiarDatos = New Azteca.Windows.Controls.CIButton()
        Me.grpDatosFiscales = New Azteca.Windows.Controls.CIGroupBox()
        Me.txtRazonSocial = New Azteca.Windows.Controls.CITextBox()
        Me.txtRFC = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel11 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel12 = New Azteca.Windows.Controls.CILabel()
        Me.txtCalle = New Azteca.Windows.Controls.CITextBox()
        Me.txtPoblacion = New Azteca.Windows.Controls.General.PoblacionSelector()
        Me.CiLabel13 = New Azteca.Windows.Controls.CILabel()
        Me.txtCP = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel14 = New Azteca.Windows.Controls.CILabel()
        Me.txtColonia = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel15 = New Azteca.Windows.Controls.CILabel()
        Me.txtNumInt = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel16 = New Azteca.Windows.Controls.CILabel()
        Me.txtNumExt = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel17 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel18 = New Azteca.Windows.Controls.CILabel()
        Me.grdDetalle = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsDetalle = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboImpuestos = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsImpuestos = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabNota.SuspendLayout()
        Me.pagGeneral.SuspendLayout()
        Me.grpTotales.SuspendLayout()
        Me.grpReferencia.SuspendLayout()
        Me.grpDatosNota.SuspendLayout()
        Me.pagDatosFiscales.SuspendLayout()
        Me.grpDatosFiscales.SuspendLayout()
        CType(Me.grdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboImpuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsImpuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.Location = New System.Drawing.Point(21, 48)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(119, 21)
        Me.CiLabel1.TabIndex = 37
        Me.CiLabel1.Text = "Serie y Folio:"
        Me.CiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabNota
        '
        Me.tabNota.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabNota.Controls.Add(Me.pagGeneral)
        Me.tabNota.Controls.Add(Me.pagDatosFiscales)
        Me.tabNota.Location = New System.Drawing.Point(12, 85)
        Me.tabNota.Name = "tabNota"
        Me.tabNota.SelectedIndex = 0
        Me.tabNota.Size = New System.Drawing.Size(686, 341)
        Me.tabNota.TabIndex = 38
        '
        'pagGeneral
        '
        Me.pagGeneral.Controls.Add(Me.grpTotales)
        Me.pagGeneral.Controls.Add(Me.grpReferencia)
        Me.pagGeneral.Controls.Add(Me.grpDatosNota)
        Me.pagGeneral.Location = New System.Drawing.Point(4, 22)
        Me.pagGeneral.Name = "pagGeneral"
        Me.pagGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.pagGeneral.Size = New System.Drawing.Size(678, 315)
        Me.pagGeneral.TabIndex = 0
        Me.pagGeneral.Text = "General"
        Me.pagGeneral.UseVisualStyleBackColor = True
        '
        'grpTotales
        '
        Me.grpTotales.Controls.Add(Me.cboDivisa)
        Me.grpTotales.Controls.Add(Me.CiLabel9)
        Me.grpTotales.Controls.Add(Me.lblTotal)
        Me.grpTotales.Controls.Add(Me.lblImpuestos)
        Me.grpTotales.Controls.Add(Me.lblSubTotal)
        Me.grpTotales.Controls.Add(Me.CiLabel6)
        Me.grpTotales.Controls.Add(Me.CiLabel5)
        Me.grpTotales.Controls.Add(Me.CiLabel4)
        Me.grpTotales.Location = New System.Drawing.Point(347, 14)
        Me.grpTotales.Name = "grpTotales"
        Me.grpTotales.Size = New System.Drawing.Size(295, 285)
        Me.grpTotales.TabIndex = 46
        Me.grpTotales.TabStop = False
        Me.grpTotales.Text = "Importes"
        '
        'cboDivisa
        '
        Me.cboDivisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivisa.FormattingEnabled = True
        Me.cboDivisa.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDivisa.ItemsTable = Nothing
        Me.cboDivisa.Location = New System.Drawing.Point(102, 19)
        Me.cboDivisa.Name = "cboDivisa"
        Me.cboDivisa.RequiredField = True
        Me.cboDivisa.Size = New System.Drawing.Size(150, 21)
        Me.cboDivisa.TabIndex = 46
        Me.cboDivisa.UIName = "Divisa"
        '
        'CiLabel9
        '
        Me.CiLabel9.AutoSize = True
        Me.CiLabel9.Location = New System.Drawing.Point(23, 22)
        Me.CiLabel9.Name = "CiLabel9"
        Me.CiLabel9.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel9.TabIndex = 45
        Me.CiLabel9.Text = "Divisa:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(102, 96)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(150, 21)
        Me.lblTotal.TabIndex = 44
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblImpuestos
        '
        Me.lblImpuestos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImpuestos.Location = New System.Drawing.Point(102, 71)
        Me.lblImpuestos.Name = "lblImpuestos"
        Me.lblImpuestos.Size = New System.Drawing.Size(150, 21)
        Me.lblImpuestos.TabIndex = 43
        Me.lblImpuestos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(102, 43)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(150, 21)
        Me.lblSubTotal.TabIndex = 42
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(23, 100)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(34, 13)
        Me.CiLabel6.TabIndex = 3
        Me.CiLabel6.Text = "Total:"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(23, 75)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(58, 13)
        Me.CiLabel5.TabIndex = 2
        Me.CiLabel5.Text = "Impuestos:"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(23, 47)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(56, 13)
        Me.CiLabel4.TabIndex = 1
        Me.CiLabel4.Text = "Sub Total:"
        '
        'grpReferencia
        '
        Me.grpReferencia.Controls.Add(Me.txtSerieRef)
        Me.grpReferencia.Controls.Add(Me.CiLabel8)
        Me.grpReferencia.Controls.Add(Me.CiLabel7)
        Me.grpReferencia.Controls.Add(Me.txtFolioRef)
        Me.grpReferencia.Controls.Add(Me.rdbVinculada)
        Me.grpReferencia.Controls.Add(Me.rdbSinRef)
        Me.grpReferencia.Location = New System.Drawing.Point(17, 155)
        Me.grpReferencia.Name = "grpReferencia"
        Me.grpReferencia.Size = New System.Drawing.Size(324, 144)
        Me.grpReferencia.TabIndex = 45
        Me.grpReferencia.TabStop = False
        Me.grpReferencia.Text = "Referencia"
        '
        'txtSerieRef
        '
        Me.txtSerieRef.AnySite = False
        Me.txtSerieRef.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtSerieRef.EditorAssembly = "Azteca.ContabilidadWin"
        Me.txtSerieRef.EditorClass = "Azteca.Windows.Contabilidad.SeriesForm"
        Me.txtSerieRef.EditorTitle = "Editar serie de comprobantes fiscales..."
        Me.txtSerieRef.Key = 0
        Me.txtSerieRef.Linked = False
        Me.txtSerieRef.Location = New System.Drawing.Point(85, 69)
        Me.txtSerieRef.Name = "txtSerieRef"
        Me.txtSerieRef.Size = New System.Drawing.Size(194, 23)
        Me.txtSerieRef.TabIndex = 17
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(47, 101)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(32, 13)
        Me.CiLabel8.TabIndex = 7
        Me.CiLabel8.Text = "Folio:"
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(45, 73)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(34, 13)
        Me.CiLabel7.TabIndex = 6
        Me.CiLabel7.Text = "Serie:"
        '
        'txtFolioRef
        '
        Me.txtFolioRef.Digits = True
        Me.txtFolioRef.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFolioRef.Location = New System.Drawing.Point(85, 98)
        Me.txtFolioRef.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFolioRef.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFolioRef.Name = "txtFolioRef"
        Me.txtFolioRef.Size = New System.Drawing.Size(102, 20)
        Me.txtFolioRef.TabIndex = 5
        '
        'rdbVinculada
        '
        Me.rdbVinculada.AutoSize = True
        Me.rdbVinculada.Location = New System.Drawing.Point(24, 42)
        Me.rdbVinculada.Name = "rdbVinculada"
        Me.rdbVinculada.Size = New System.Drawing.Size(198, 17)
        Me.rdbVinculada.TabIndex = 3
        Me.rdbVinculada.Text = "Vínculada al siguiente comprobante:"
        Me.rdbVinculada.UseVisualStyleBackColor = True
        '
        'rdbSinRef
        '
        Me.rdbSinRef.AutoSize = True
        Me.rdbSinRef.Checked = True
        Me.rdbSinRef.Location = New System.Drawing.Point(24, 19)
        Me.rdbSinRef.Name = "rdbSinRef"
        Me.rdbSinRef.Size = New System.Drawing.Size(91, 17)
        Me.rdbSinRef.TabIndex = 2
        Me.rdbSinRef.TabStop = True
        Me.rdbSinRef.Text = "No Vínculada"
        Me.rdbSinRef.UseVisualStyleBackColor = True
        '
        'grpDatosNota
        '
        Me.grpDatosNota.Controls.Add(Me.rdbCredito)
        Me.grpDatosNota.Controls.Add(Me.lblFechaCFD)
        Me.grpDatosNota.Controls.Add(Me.rdbCargo)
        Me.grpDatosNota.Controls.Add(Me.lblFechaCap)
        Me.grpDatosNota.Controls.Add(Me.lblFolio)
        Me.grpDatosNota.Controls.Add(Me.CiLabel1)
        Me.grpDatosNota.Controls.Add(Me.CiLabel3)
        Me.grpDatosNota.Controls.Add(Me.CiLabel2)
        Me.grpDatosNota.Location = New System.Drawing.Point(17, 14)
        Me.grpDatosNota.Name = "grpDatosNota"
        Me.grpDatosNota.Size = New System.Drawing.Size(324, 136)
        Me.grpDatosNota.TabIndex = 38
        Me.grpDatosNota.TabStop = False
        Me.grpDatosNota.Text = "Nota de Cargo"
        '
        'rdbCredito
        '
        Me.rdbCredito.AutoSize = True
        Me.rdbCredito.Location = New System.Drawing.Point(83, 19)
        Me.rdbCredito.Name = "rdbCredito"
        Me.rdbCredito.Size = New System.Drawing.Size(58, 17)
        Me.rdbCredito.TabIndex = 1
        Me.rdbCredito.Text = "Crédito"
        Me.rdbCredito.UseVisualStyleBackColor = True
        '
        'lblFechaCFD
        '
        Me.lblFechaCFD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFechaCFD.Location = New System.Drawing.Point(146, 92)
        Me.lblFechaCFD.Name = "lblFechaCFD"
        Me.lblFechaCFD.Size = New System.Drawing.Size(112, 21)
        Me.lblFechaCFD.TabIndex = 43
        Me.lblFechaCFD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rdbCargo
        '
        Me.rdbCargo.AutoSize = True
        Me.rdbCargo.Checked = True
        Me.rdbCargo.Location = New System.Drawing.Point(24, 19)
        Me.rdbCargo.Name = "rdbCargo"
        Me.rdbCargo.Size = New System.Drawing.Size(53, 17)
        Me.rdbCargo.TabIndex = 0
        Me.rdbCargo.TabStop = True
        Me.rdbCargo.Text = "Cargo"
        Me.rdbCargo.UseVisualStyleBackColor = True
        '
        'lblFechaCap
        '
        Me.lblFechaCap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFechaCap.Location = New System.Drawing.Point(146, 71)
        Me.lblFechaCap.Name = "lblFechaCap"
        Me.lblFechaCap.Size = New System.Drawing.Size(112, 21)
        Me.lblFechaCap.TabIndex = 42
        Me.lblFechaCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFolio
        '
        Me.lblFolio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFolio.Location = New System.Drawing.Point(146, 48)
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(112, 21)
        Me.lblFolio.TabIndex = 41
        Me.lblFolio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CiLabel3
        '
        Me.CiLabel3.Location = New System.Drawing.Point(21, 92)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(119, 21)
        Me.CiLabel3.TabIndex = 40
        Me.CiLabel3.Text = "Fecha Facturación:"
        Me.CiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CiLabel2
        '
        Me.CiLabel2.Location = New System.Drawing.Point(21, 71)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(119, 21)
        Me.CiLabel2.TabIndex = 39
        Me.CiLabel2.Text = "Fecha Captura:"
        Me.CiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pagDatosFiscales
        '
        Me.pagDatosFiscales.Controls.Add(Me.btnCopiarDatos)
        Me.pagDatosFiscales.Controls.Add(Me.grpDatosFiscales)
        Me.pagDatosFiscales.Location = New System.Drawing.Point(4, 22)
        Me.pagDatosFiscales.Name = "pagDatosFiscales"
        Me.pagDatosFiscales.Size = New System.Drawing.Size(678, 315)
        Me.pagDatosFiscales.TabIndex = 1
        Me.pagDatosFiscales.Text = "Datos Fiscales"
        Me.pagDatosFiscales.UseVisualStyleBackColor = True
        '
        'btnCopiarDatos
        '
        Me.btnCopiarDatos.Enabled = False
        Me.btnCopiarDatos.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.editcopy
        Me.btnCopiarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopiarDatos.Location = New System.Drawing.Point(15, 203)
        Me.btnCopiarDatos.Name = "btnCopiarDatos"
        Me.btnCopiarDatos.Size = New System.Drawing.Size(96, 23)
        Me.btnCopiarDatos.TabIndex = 46
        Me.btnCopiarDatos.Text = "Copiar Datos"
        Me.btnCopiarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCopiarDatos.UseVisualStyleBackColor = True
        '
        'grpDatosFiscales
        '
        Me.grpDatosFiscales.Controls.Add(Me.txtRazonSocial)
        Me.grpDatosFiscales.Controls.Add(Me.txtRFC)
        Me.grpDatosFiscales.Controls.Add(Me.CiLabel11)
        Me.grpDatosFiscales.Controls.Add(Me.CiLabel12)
        Me.grpDatosFiscales.Controls.Add(Me.txtCalle)
        Me.grpDatosFiscales.Controls.Add(Me.txtPoblacion)
        Me.grpDatosFiscales.Controls.Add(Me.CiLabel13)
        Me.grpDatosFiscales.Controls.Add(Me.txtCP)
        Me.grpDatosFiscales.Controls.Add(Me.CiLabel14)
        Me.grpDatosFiscales.Controls.Add(Me.txtColonia)
        Me.grpDatosFiscales.Controls.Add(Me.CiLabel15)
        Me.grpDatosFiscales.Controls.Add(Me.txtNumInt)
        Me.grpDatosFiscales.Controls.Add(Me.CiLabel16)
        Me.grpDatosFiscales.Controls.Add(Me.txtNumExt)
        Me.grpDatosFiscales.Controls.Add(Me.CiLabel17)
        Me.grpDatosFiscales.Controls.Add(Me.CiLabel18)
        Me.grpDatosFiscales.Location = New System.Drawing.Point(15, 14)
        Me.grpDatosFiscales.Name = "grpDatosFiscales"
        Me.grpDatosFiscales.Size = New System.Drawing.Size(470, 183)
        Me.grpDatosFiscales.TabIndex = 45
        Me.grpDatosFiscales.TabStop = False
        Me.grpDatosFiscales.Text = "Datos Fiscales"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRazonSocial.Location = New System.Drawing.Point(89, 45)
        Me.txtRazonSocial.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRazonSocial.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.RequiredField = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(367, 20)
        Me.txtRazonSocial.TabIndex = 3
        Me.txtRazonSocial.UIName = "Razón Social"
        '
        'txtRFC
        '
        Me.txtRFC.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtRFC.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRFC.Location = New System.Drawing.Point(89, 19)
        Me.txtRFC.MaxLength = 13
        Me.txtRFC.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRFC.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.RequiredField = True
        Me.txtRFC.Size = New System.Drawing.Size(141, 20)
        Me.txtRFC.TabIndex = 1
        Me.txtRFC.UIName = "RFC"
        '
        'CiLabel11
        '
        Me.CiLabel11.AutoSize = True
        Me.CiLabel11.Location = New System.Drawing.Point(10, 48)
        Me.CiLabel11.Name = "CiLabel11"
        Me.CiLabel11.Size = New System.Drawing.Size(73, 13)
        Me.CiLabel11.TabIndex = 2
        Me.CiLabel11.Text = "Razón Social:"
        '
        'CiLabel12
        '
        Me.CiLabel12.AutoSize = True
        Me.CiLabel12.Location = New System.Drawing.Point(10, 19)
        Me.CiLabel12.Name = "CiLabel12"
        Me.CiLabel12.Size = New System.Drawing.Size(31, 13)
        Me.CiLabel12.TabIndex = 0
        Me.CiLabel12.Text = "RFC:"
        '
        'txtCalle
        '
        Me.txtCalle.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalle.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCalle.Location = New System.Drawing.Point(89, 71)
        Me.txtCalle.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(367, 20)
        Me.txtCalle.TabIndex = 5
        Me.txtCalle.UIName = Nothing
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
        Me.txtPoblacion.Key = 0
        Me.txtPoblacion.Linked = False
        Me.txtPoblacion.Location = New System.Drawing.Point(89, 149)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.RequiredField = True
        Me.txtPoblacion.Size = New System.Drawing.Size(200, 23)
        Me.txtPoblacion.TabIndex = 15
        Me.txtPoblacion.TextWidth = 70
        Me.txtPoblacion.UIName = "Población"
        '
        'CiLabel13
        '
        Me.CiLabel13.AutoSize = True
        Me.CiLabel13.Location = New System.Drawing.Point(10, 74)
        Me.CiLabel13.Name = "CiLabel13"
        Me.CiLabel13.Size = New System.Drawing.Size(33, 13)
        Me.CiLabel13.TabIndex = 4
        Me.CiLabel13.Text = "Calle:"
        '
        'txtCP
        '
        Me.txtCP.Digits = True
        Me.txtCP.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCP.Location = New System.Drawing.Point(393, 123)
        Me.txtCP.MaxLength = 5
        Me.txtCP.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(63, 20)
        Me.txtCP.TabIndex = 13
        Me.txtCP.UIName = Nothing
        '
        'CiLabel14
        '
        Me.CiLabel14.AutoSize = True
        Me.CiLabel14.Location = New System.Drawing.Point(10, 123)
        Me.CiLabel14.Name = "CiLabel14"
        Me.CiLabel14.Size = New System.Drawing.Size(45, 13)
        Me.CiLabel14.TabIndex = 10
        Me.CiLabel14.Text = "Colonia:"
        '
        'txtColonia
        '
        Me.txtColonia.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtColonia.Location = New System.Drawing.Point(89, 123)
        Me.txtColonia.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(217, 20)
        Me.txtColonia.TabIndex = 11
        Me.txtColonia.UIName = Nothing
        '
        'CiLabel15
        '
        Me.CiLabel15.AutoSize = True
        Me.CiLabel15.Location = New System.Drawing.Point(10, 97)
        Me.CiLabel15.Name = "CiLabel15"
        Me.CiLabel15.Size = New System.Drawing.Size(65, 13)
        Me.CiLabel15.TabIndex = 6
        Me.CiLabel15.Text = "No. Exterior:"
        '
        'txtNumInt
        '
        Me.txtNumInt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumInt.Location = New System.Drawing.Point(236, 97)
        Me.txtNumInt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumInt.Name = "txtNumInt"
        Me.txtNumInt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumInt.TabIndex = 9
        Me.txtNumInt.UIName = Nothing
        '
        'CiLabel16
        '
        Me.CiLabel16.AutoSize = True
        Me.CiLabel16.Location = New System.Drawing.Point(168, 97)
        Me.CiLabel16.Name = "CiLabel16"
        Me.CiLabel16.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel16.TabIndex = 8
        Me.CiLabel16.Text = "No. Interior:"
        '
        'txtNumExt
        '
        Me.txtNumExt.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumExt.Location = New System.Drawing.Point(89, 97)
        Me.txtNumExt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExt.Name = "txtNumExt"
        Me.txtNumExt.Size = New System.Drawing.Size(70, 20)
        Me.txtNumExt.TabIndex = 7
        Me.txtNumExt.UIName = Nothing
        '
        'CiLabel17
        '
        Me.CiLabel17.AutoSize = True
        Me.CiLabel17.Location = New System.Drawing.Point(312, 123)
        Me.CiLabel17.Name = "CiLabel17"
        Me.CiLabel17.Size = New System.Drawing.Size(75, 13)
        Me.CiLabel17.TabIndex = 12
        Me.CiLabel17.Text = "Código Postal:"
        '
        'CiLabel18
        '
        Me.CiLabel18.AutoSize = True
        Me.CiLabel18.Location = New System.Drawing.Point(10, 151)
        Me.CiLabel18.Name = "CiLabel18"
        Me.CiLabel18.Size = New System.Drawing.Size(57, 13)
        Me.CiLabel18.TabIndex = 14
        Me.CiLabel18.Text = "Población:"
        '
        'grdDetalle
        '
        Me.grdDetalle.AllowAddNew = True
        Me.grdDetalle.AllowDelete = True
        Me.grdDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDetalle.DataSource = Me.bsDetalle
        Me.grdDetalle.Images.Add(CType(resources.GetObject("grdDetalle.Images"), System.Drawing.Image))
        Me.grdDetalle.Images.Add(CType(resources.GetObject("grdDetalle.Images1"), System.Drawing.Image))
        Me.grdDetalle.Location = New System.Drawing.Point(12, 428)
        Me.grdDetalle.Name = "grdDetalle"
        Me.grdDetalle.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDetalle.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDetalle.PreviewInfo.ZoomFactor = 75.0R
        Me.grdDetalle.PrintInfo.PageSettings = CType(resources.GetObject("grdDetalle.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDetalle.Size = New System.Drawing.Size(686, 174)
        Me.grdDetalle.TabIndex = 39
        Me.grdDetalle.Text = "AzTrueDBGrid1"
        Me.grdDetalle.PropBag = resources.GetString("grdDetalle.PropBag")
        '
        'cboImpuestos
        '
        Me.cboImpuestos.AllowColMove = True
        Me.cboImpuestos.AllowColSelect = True
        Me.cboImpuestos.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.cboImpuestos.AlternatingRows = False
        Me.cboImpuestos.CaptionStyle = Style1
        Me.cboImpuestos.ColumnCaptionHeight = 17
        Me.cboImpuestos.ColumnFooterHeight = 17
        Me.cboImpuestos.DataSource = Me.bsImpuestos
        Me.cboImpuestos.DisplayMember = "Abrev"
        Me.cboImpuestos.EvenRowStyle = Style2
        Me.cboImpuestos.ExtendRightColumn = True
        Me.cboImpuestos.FetchRowStyles = False
        Me.cboImpuestos.FooterStyle = Style3
        Me.cboImpuestos.HeadingStyle = Style4
        Me.cboImpuestos.HighLightRowStyle = Style5
        Me.cboImpuestos.Images.Add(CType(resources.GetObject("cboImpuestos.Images"), System.Drawing.Image))
        Me.cboImpuestos.Location = New System.Drawing.Point(282, 473)
        Me.cboImpuestos.Name = "cboImpuestos"
        Me.cboImpuestos.OddRowStyle = Style6
        Me.cboImpuestos.RecordSelectorStyle = Style7
        Me.cboImpuestos.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cboImpuestos.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.cboImpuestos.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboImpuestos.ScrollTips = False
        Me.cboImpuestos.Size = New System.Drawing.Size(203, 129)
        Me.cboImpuestos.Style = Style8
        Me.cboImpuestos.TabIndex = 40
        Me.cboImpuestos.TabStop = False
        Me.cboImpuestos.ValueMember = "IdImpuesto"
        Me.cboImpuestos.ValueTranslate = True
        Me.cboImpuestos.Visible = False
        Me.cboImpuestos.PropBag = resources.GetString("cboImpuestos.PropBag")
        '
        'NotasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 627)
        Me.Controls.Add(Me.cboImpuestos)
        Me.Controls.Add(Me.tabNota)
        Me.Controls.Add(Me.grdDetalle)
        Me.Name = "NotasForm"
        Me.Text = "NotasForm"
        Me.Controls.SetChildIndex(Me.grdDetalle, 0)
        Me.Controls.SetChildIndex(Me.tabNota, 0)
        Me.Controls.SetChildIndex(Me.cboImpuestos, 0)
        Me.tabNota.ResumeLayout(False)
        Me.pagGeneral.ResumeLayout(False)
        Me.grpTotales.ResumeLayout(False)
        Me.grpTotales.PerformLayout()
        Me.grpReferencia.ResumeLayout(False)
        Me.grpReferencia.PerformLayout()
        Me.grpDatosNota.ResumeLayout(False)
        Me.grpDatosNota.PerformLayout()
        Me.pagDatosFiscales.ResumeLayout(False)
        Me.grpDatosFiscales.ResumeLayout(False)
        Me.grpDatosFiscales.PerformLayout()
        CType(Me.grdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboImpuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsImpuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New NotaFacade
        SetDocumentType("Notas")
        LicenseModule = Kernel.Licensing.LicenseModule.Accounting
    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents tabNota As Azteca.Windows.Controls.CITab
    Friend WithEvents pagGeneral As System.Windows.Forms.TabPage
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents grpDatosNota As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents rdbCredito As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbCargo As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents grdDetalle As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsDetalle As System.Windows.Forms.BindingSource
    Friend WithEvents lblFechaCFD As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblFechaCap As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblFolio As Azteca.Windows.Controls.CILabel
    Friend WithEvents grpReferencia As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtFolioRef As Azteca.Windows.Controls.CITextBox
    Friend WithEvents rdbVinculada As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbSinRef As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents cboImpuestos As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents bsImpuestos As System.Windows.Forms.BindingSource
    Friend WithEvents txtSerieRef As Azteca.Windows.Contabilidad.SerieSelector
    Friend WithEvents pagDatosFiscales As System.Windows.Forms.TabPage
    Friend WithEvents btnCopiarDatos As Azteca.Windows.Controls.CIButton
    Friend WithEvents grpDatosFiscales As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents txtRazonSocial As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtRFC As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel11 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel12 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCalle As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtPoblacion As Azteca.Windows.Controls.General.PoblacionSelector
    Friend WithEvents CiLabel13 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCP As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel14 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtColonia As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel15 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNumInt As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel16 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNumExt As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel17 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel18 As Azteca.Windows.Controls.CILabel
    Friend WithEvents grpTotales As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents cboDivisa As Azteca.Windows.Contabilidad.DivisasComboBox
    Friend WithEvents CiLabel9 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotal As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblImpuestos As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblSubTotal As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
End Class
