<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CertificadosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CertificadosForm))
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.txtNumCertificado = New Azteca.Windows.Controls.CITextBox()
        Me.lblValidTo = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.lblValidFrom = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.lblIssuer = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.tlbSeries = New Azteca.Windows.Controls.CIToolBar()
        Me.btnNuevaSerie = New System.Windows.Forms.ToolStripButton()
        Me.btnDesabilitarSerie = New System.Windows.Forms.ToolStripButton()
        Me.btnSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRegistrarFolios = New System.Windows.Forms.ToolStripButton()
        Me.grdSeries = New Azteca.Windows.Controls.CIDataGridView()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUltimoFolio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFolioLimite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsSeries = New System.Windows.Forms.BindingSource(Me.components)
        Me.imlCert = New System.Windows.Forms.ImageList(Me.components)
        Me.tabCertificados = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagGenerals = New C1.Win.C1Command.C1DockingTabPage()
        Me.btnConfigCert = New Azteca.Windows.Controls.AZButton()
        Me.grpFormatoCFD = New Azteca.Windows.Controls.CIGroupBox()
        Me.rdbCFDI = New Azteca.Windows.Controls.CIRadioButton()
        Me.rdbCFD = New Azteca.Windows.Controls.CIRadioButton()
        Me.pagSerie = New C1.Win.C1Command.C1DockingTabPage()
        Me.tlbSeries.SuspendLayout()
        CType(Me.grdSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabCertificados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCertificados.SuspendLayout()
        Me.pagGenerals.SuspendLayout()
        Me.grpFormatoCFD.SuspendLayout()
        Me.pagSerie.SuspendLayout()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(15, 42)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Nombre:"
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(15, 65)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(80, 13)
        Me.CiLabel7.TabIndex = 2
        Me.CiLabel7.Text = "No. Certificado:"
        '
        'txtNumCertificado
        '
        Me.txtNumCertificado.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumCertificado.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNumCertificado.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNumCertificado.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumCertificado.Location = New System.Drawing.Point(101, 62)
        Me.txtNumCertificado.MaxLength = 20
        Me.txtNumCertificado.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumCertificado.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumCertificado.Name = "txtNumCertificado"
        Me.txtNumCertificado.RequiredField = True
        Me.txtNumCertificado.Size = New System.Drawing.Size(133, 20)
        Me.txtNumCertificado.TabIndex = 3
        Me.txtNumCertificado.UIName = "Número Certificado"
        '
        'lblValidTo
        '
        Me.lblValidTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValidTo.Location = New System.Drawing.Point(228, 111)
        Me.lblValidTo.Name = "lblValidTo"
        Me.lblValidTo.Size = New System.Drawing.Size(152, 22)
        Me.lblValidTo.TabIndex = 8
        Me.lblValidTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(15, 116)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(51, 13)
        Me.CiLabel2.TabIndex = 6
        Me.CiLabel2.Text = "Vigencia:"
        '
        'lblValidFrom
        '
        Me.lblValidFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValidFrom.Location = New System.Drawing.Point(101, 111)
        Me.lblValidFrom.Name = "lblValidFrom"
        Me.lblValidFrom.Size = New System.Drawing.Size(121, 22)
        Me.lblValidFrom.TabIndex = 7
        Me.lblValidFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(15, 90)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(66, 13)
        Me.CiLabel3.TabIndex = 4
        Me.CiLabel3.Text = "Destinatario:"
        '
        'lblIssuer
        '
        Me.lblIssuer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIssuer.Location = New System.Drawing.Point(101, 85)
        Me.lblIssuer.Name = "lblIssuer"
        Me.lblIssuer.Size = New System.Drawing.Size(279, 22)
        Me.lblIssuer.TabIndex = 5
        Me.lblIssuer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(101, 39)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(279, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.UIName = "Nombre"
        '
        'tlbSeries
        '
        Me.tlbSeries.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tlbSeries.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevaSerie, Me.btnDesabilitarSerie, Me.btnSep3, Me.btnRegistrarFolios})
        Me.tlbSeries.Location = New System.Drawing.Point(0, 0)
        Me.tlbSeries.Name = "tlbSeries"
        Me.tlbSeries.Size = New System.Drawing.Size(494, 39)
        Me.tlbSeries.TabIndex = 1
        '
        'btnNuevaSerie
        '
        Me.btnNuevaSerie.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.series_add_32
        Me.btnNuevaSerie.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevaSerie.Name = "btnNuevaSerie"
        Me.btnNuevaSerie.Size = New System.Drawing.Size(114, 36)
        Me.btnNuevaSerie.Text = "Nueva Serie..."
        '
        'btnDesabilitarSerie
        '
        Me.btnDesabilitarSerie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDesabilitarSerie.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.Series_Lock_32
        Me.btnDesabilitarSerie.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDesabilitarSerie.Name = "btnDesabilitarSerie"
        Me.btnDesabilitarSerie.Size = New System.Drawing.Size(36, 36)
        Me.btnDesabilitarSerie.Text = "Deshabilitar Serie"
        Me.btnDesabilitarSerie.ToolTipText = "Bloquear serie"
        '
        'btnSep3
        '
        Me.btnSep3.Name = "btnSep3"
        Me.btnSep3.Size = New System.Drawing.Size(6, 39)
        '
        'btnRegistrarFolios
        '
        Me.btnRegistrarFolios.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.Notepad_32
        Me.btnRegistrarFolios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRegistrarFolios.Name = "btnRegistrarFolios"
        Me.btnRegistrarFolios.Size = New System.Drawing.Size(123, 36)
        Me.btnRegistrarFolios.Text = "Registrar Folios"
        '
        'grdSeries
        '
        Me.grdSeries.AllowUserToAddRows = False
        Me.grdSeries.AllowUserToDeleteRows = False
        Me.grdSeries.AutoGenerateColumns = False
        Me.grdSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSeries.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodigo, Me.colSerie, Me.colUltimoFolio, Me.colFolioLimite, Me.colEstatus})
        Me.grdSeries.DataSource = Me.bsSeries
        Me.grdSeries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSeries.Location = New System.Drawing.Point(0, 39)
        Me.grdSeries.Name = "grdSeries"
        Me.grdSeries.ReadOnly = True
        Me.grdSeries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSeries.Size = New System.Drawing.Size(494, 218)
        Me.grdSeries.TabIndex = 0
        '
        'colCodigo
        '
        Me.colCodigo.DataPropertyName = "Codigo"
        Me.colCodigo.HeaderText = "Código"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.ReadOnly = True
        Me.colCodigo.Width = 60
        '
        'colSerie
        '
        Me.colSerie.DataPropertyName = "Serie"
        Me.colSerie.HeaderText = "Serie"
        Me.colSerie.Name = "colSerie"
        Me.colSerie.ReadOnly = True
        Me.colSerie.Width = 60
        '
        'colUltimoFolio
        '
        Me.colUltimoFolio.DataPropertyName = "UltimoFolio"
        Me.colUltimoFolio.HeaderText = "Último Folio"
        Me.colUltimoFolio.Name = "colUltimoFolio"
        Me.colUltimoFolio.ReadOnly = True
        '
        'colFolioLimite
        '
        Me.colFolioLimite.DataPropertyName = "FolioLimite"
        Me.colFolioLimite.HeaderText = "Folio Límite"
        Me.colFolioLimite.Name = "colFolioLimite"
        Me.colFolioLimite.ReadOnly = True
        '
        'colEstatus
        '
        Me.colEstatus.DataPropertyName = "Estatus"
        Me.colEstatus.HeaderText = "Estatus"
        Me.colEstatus.Name = "colEstatus"
        Me.colEstatus.ReadOnly = True
        '
        'bsSeries
        '
        Me.bsSeries.AllowNew = False
        '
        'imlCert
        '
        Me.imlCert.ImageStream = CType(resources.GetObject("imlCert.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlCert.TransparentColor = System.Drawing.Color.Transparent
        Me.imlCert.Images.SetKeyName(0, "General")
        Me.imlCert.Images.SetKeyName(1, "Series")
        '
        'tabCertificados
        '
        Me.tabCertificados.Controls.Add(Me.pagGenerals)
        Me.tabCertificados.Controls.Add(Me.pagSerie)
        Me.tabCertificados.ImageList = Me.imlCert
        Me.tabCertificados.Location = New System.Drawing.Point(10, 98)
        Me.tabCertificados.Name = "tabCertificados"
        Me.tabCertificados.Size = New System.Drawing.Size(496, 299)
        Me.tabCertificados.TabIndex = 11
        Me.tabCertificados.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabCertificados.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabCertificados.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagGenerals
        '
        Me.pagGenerals.Controls.Add(Me.btnConfigCert)
        Me.pagGenerals.Controls.Add(Me.grpFormatoCFD)
        Me.pagGenerals.Controls.Add(Me.CiLabel1)
        Me.pagGenerals.Controls.Add(Me.lblValidFrom)
        Me.pagGenerals.Controls.Add(Me.CiLabel3)
        Me.pagGenerals.Controls.Add(Me.txtNumCertificado)
        Me.pagGenerals.Controls.Add(Me.CiLabel2)
        Me.pagGenerals.Controls.Add(Me.txtNombre)
        Me.pagGenerals.Controls.Add(Me.lblIssuer)
        Me.pagGenerals.Controls.Add(Me.CiLabel7)
        Me.pagGenerals.Controls.Add(Me.lblValidTo)
        Me.pagGenerals.ImageIndex = 0
        Me.pagGenerals.Location = New System.Drawing.Point(1, 41)
        Me.pagGenerals.Name = "pagGenerals"
        Me.pagGenerals.Size = New System.Drawing.Size(494, 257)
        Me.pagGenerals.TabIndex = 0
        Me.pagGenerals.Text = "General"
        '
        'btnConfigCert
        '
        Me.btnConfigCert.Image = CType(resources.GetObject("btnConfigCert.Image"), System.Drawing.Image)
        Me.btnConfigCert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfigCert.Location = New System.Drawing.Point(243, 136)
        Me.btnConfigCert.Name = "btnConfigCert"
        Me.btnConfigCert.Size = New System.Drawing.Size(137, 23)
        Me.btnConfigCert.TabIndex = 11
        Me.btnConfigCert.Text = "Configurar Certificado"
        Me.btnConfigCert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfigCert.UseVisualStyleBackColor = True
        '
        'grpFormatoCFD
        '
        Me.grpFormatoCFD.Controls.Add(Me.rdbCFDI)
        Me.grpFormatoCFD.Controls.Add(Me.rdbCFD)
        Me.grpFormatoCFD.Location = New System.Drawing.Point(101, 136)
        Me.grpFormatoCFD.Name = "grpFormatoCFD"
        Me.grpFormatoCFD.Size = New System.Drawing.Size(121, 73)
        Me.grpFormatoCFD.TabIndex = 10
        Me.grpFormatoCFD.TabStop = False
        Me.grpFormatoCFD.Text = "Formato CFD"
        '
        'rdbCFDI
        '
        Me.rdbCFDI.AutoSize = True
        Me.rdbCFDI.Location = New System.Drawing.Point(29, 42)
        Me.rdbCFDI.Name = "rdbCFDI"
        Me.rdbCFDI.Size = New System.Drawing.Size(49, 17)
        Me.rdbCFDI.TabIndex = 1
        Me.rdbCFDI.Text = "CFDI"
        Me.rdbCFDI.UseVisualStyleBackColor = True
        '
        'rdbCFD
        '
        Me.rdbCFD.AutoSize = True
        Me.rdbCFD.Checked = True
        Me.rdbCFD.Location = New System.Drawing.Point(29, 19)
        Me.rdbCFD.Name = "rdbCFD"
        Me.rdbCFD.Size = New System.Drawing.Size(46, 17)
        Me.rdbCFD.TabIndex = 0
        Me.rdbCFD.TabStop = True
        Me.rdbCFD.Text = "CFD"
        Me.rdbCFD.UseVisualStyleBackColor = True
        '
        'pagSerie
        '
        Me.pagSerie.Controls.Add(Me.grdSeries)
        Me.pagSerie.Controls.Add(Me.tlbSeries)
        Me.pagSerie.ImageIndex = 1
        Me.pagSerie.Location = New System.Drawing.Point(1, 41)
        Me.pagSerie.Name = "pagSerie"
        Me.pagSerie.Size = New System.Drawing.Size(494, 257)
        Me.pagSerie.TabIndex = 1
        Me.pagSerie.Text = "Series"
        '
        'CertificadosForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 433)
        Me.Controls.Add(Me.tabCertificados)
        Me.Name = "CertificadosForm"
        Me.Text = "CertificadosForm"
        Me.Controls.SetChildIndex(Me.tabCertificados, 0)
        Me.tlbSeries.ResumeLayout(False)
        Me.tlbSeries.PerformLayout()
        CType(Me.grdSeries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSeries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabCertificados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCertificados.ResumeLayout(False)
        Me.pagGenerals.ResumeLayout(False)
        Me.pagGenerals.PerformLayout()
        Me.grpFormatoCFD.ResumeLayout(False)
        Me.grpFormatoCFD.PerformLayout()
        Me.pagSerie.ResumeLayout(False)
        Me.pagSerie.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New CertificadoFacade
    End Sub

    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNumCertificado As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblValidTo As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblValidFrom As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblIssuer As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents imlCert As System.Windows.Forms.ImageList
    Friend WithEvents grdSeries As Azteca.Windows.Controls.CIDataGridView
    Friend WithEvents bsSeries As System.Windows.Forms.BindingSource
    Friend WithEvents tlbSeries As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnNuevaSerie As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDesabilitarSerie As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRegistrarFolios As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents colCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSerie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUltimoFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFolioLimite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabCertificados As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagGenerals As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagSerie As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents grpFormatoCFD As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents rdbCFDI As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbCFD As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents btnConfigCert As Azteca.Windows.Controls.AZButton
End Class
