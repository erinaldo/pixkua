<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DefuncionForm
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtActa = New Azteca.Windows.Controls.CITextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPagina = New Azteca.Windows.Controls.CITextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLibro = New Azteca.Windows.Controls.CITextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaDefuncion = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFamiliaresSobreviven = New Azteca.Windows.Controls.CITextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCausaFallecimiento = New Azteca.Windows.Controls.CITextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSepultadoEn = New Azteca.Windows.Controls.CITextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkReconciliacion = New System.Windows.Forms.CheckBox()
        Me.chkViatico = New System.Windows.Forms.CheckBox()
        Me.chkUncionEnfermos = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtActaCivilDefuncion = New Azteca.Windows.Controls.CITextBox()
        Me.txtPoblacion = New Azteca.Windows.Controls.General.PoblacionSelector()
        Me.lblEstadoInf = New Azteca.Windows.Controls.CILabel()
        Me.lblEstado = New Azteca.Windows.Controls.CILabel()
        Me.txtSacerdote = New Azteca.Windows.Iglesia.SacerdoteSelector()
        Me.txtSolicitante = New Azteca.Windows.Iglesia.SolicitanteSelector()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(327, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "/"
        '
        'txtActa
        '
        Me.txtActa.Digits = True
        Me.txtActa.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtActa.Location = New System.Drawing.Point(354, 116)
        Me.txtActa.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtActa.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtActa.Name = "txtActa"
        Me.txtActa.RequiredField = True
        Me.txtActa.Size = New System.Drawing.Size(70, 20)
        Me.txtActa.TabIndex = 2
        Me.txtActa.UIName = "Serie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(351, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Acta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(217, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "/"
        '
        'txtPagina
        '
        Me.txtPagina.Digits = True
        Me.txtPagina.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPagina.Location = New System.Drawing.Point(243, 116)
        Me.txtPagina.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPagina.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPagina.Name = "txtPagina"
        Me.txtPagina.RequiredField = True
        Me.txtPagina.Size = New System.Drawing.Size(70, 20)
        Me.txtPagina.TabIndex = 1
        Me.txtPagina.UIName = "Serie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Pagina"
        '
        'txtLibro
        '
        Me.txtLibro.Digits = True
        Me.txtLibro.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtLibro.Location = New System.Drawing.Point(134, 116)
        Me.txtLibro.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLibro.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLibro.Name = "txtLibro"
        Me.txtLibro.RequiredField = True
        Me.txtLibro.Size = New System.Drawing.Size(70, 20)
        Me.txtLibro.TabIndex = 0
        Me.txtLibro.UIName = "Serie"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Libro"
        '
        'dtpFechaDefuncion
        '
        Me.dtpFechaDefuncion.Location = New System.Drawing.Point(134, 165)
        Me.dtpFechaDefuncion.Name = "dtpFechaDefuncion"
        Me.dtpFechaDefuncion.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaDefuncion.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Fecha"
        '
        'txtFamiliaresSobreviven
        '
        Me.txtFamiliaresSobreviven.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFamiliaresSobreviven.Location = New System.Drawing.Point(134, 220)
        Me.txtFamiliaresSobreviven.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFamiliaresSobreviven.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFamiliaresSobreviven.Multiline = True
        Me.txtFamiliaresSobreviven.Name = "txtFamiliaresSobreviven"
        Me.txtFamiliaresSobreviven.Size = New System.Drawing.Size(291, 36)
        Me.txtFamiliaresSobreviven.TabIndex = 5
        Me.txtFamiliaresSobreviven.UIName = "Serie"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 26)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Familiares" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que Sobreviven"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "Nombre del Difunto"
        '
        'txtCausaFallecimiento
        '
        Me.txtCausaFallecimiento.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCausaFallecimiento.Location = New System.Drawing.Point(133, 264)
        Me.txtCausaFallecimiento.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCausaFallecimiento.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCausaFallecimiento.Name = "txtCausaFallecimiento"
        Me.txtCausaFallecimiento.Size = New System.Drawing.Size(291, 20)
        Me.txtCausaFallecimiento.TabIndex = 6
        Me.txtCausaFallecimiento.UIName = "Serie"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 26)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Causa de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fallecimiento"
        '
        'txtSepultadoEn
        '
        Me.txtSepultadoEn.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSepultadoEn.Location = New System.Drawing.Point(133, 294)
        Me.txtSepultadoEn.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSepultadoEn.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSepultadoEn.Name = "txtSepultadoEn"
        Me.txtSepultadoEn.Size = New System.Drawing.Size(291, 20)
        Me.txtSepultadoEn.TabIndex = 7
        Me.txtSepultadoEn.UIName = "Serie"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 299)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "Lugar Sepultura"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 326)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Parroco"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 356)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 13)
        Me.Label12.TabIndex = 101
        Me.Label12.Text = "Poblacion Defunción"
        '
        'chkReconciliacion
        '
        Me.chkReconciliacion.AutoSize = True
        Me.chkReconciliacion.Location = New System.Drawing.Point(444, 220)
        Me.chkReconciliacion.Name = "chkReconciliacion"
        Me.chkReconciliacion.Size = New System.Drawing.Size(96, 17)
        Me.chkReconciliacion.TabIndex = 10
        Me.chkReconciliacion.Text = "Reconciliación"
        Me.chkReconciliacion.UseVisualStyleBackColor = True
        '
        'chkViatico
        '
        Me.chkViatico.AutoSize = True
        Me.chkViatico.Location = New System.Drawing.Point(444, 256)
        Me.chkViatico.Name = "chkViatico"
        Me.chkViatico.Size = New System.Drawing.Size(58, 17)
        Me.chkViatico.TabIndex = 11
        Me.chkViatico.Text = "Viatico"
        Me.chkViatico.UseVisualStyleBackColor = True
        '
        'chkUncionEnfermos
        '
        Me.chkUncionEnfermos.AutoSize = True
        Me.chkUncionEnfermos.Location = New System.Drawing.Point(444, 293)
        Me.chkUncionEnfermos.Name = "chkUncionEnfermos"
        Me.chkUncionEnfermos.Size = New System.Drawing.Size(122, 17)
        Me.chkUncionEnfermos.TabIndex = 12
        Me.chkUncionEnfermos.Text = "Uncion de Enfermos"
        Me.chkUncionEnfermos.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(441, 325)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Acta Civil de Defunción"
        '
        'txtActaCivilDefuncion
        '
        Me.txtActaCivilDefuncion.Digits = True
        Me.txtActaCivilDefuncion.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtActaCivilDefuncion.Location = New System.Drawing.Point(444, 349)
        Me.txtActaCivilDefuncion.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtActaCivilDefuncion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtActaCivilDefuncion.Name = "txtActaCivilDefuncion"
        Me.txtActaCivilDefuncion.Size = New System.Drawing.Size(115, 20)
        Me.txtActaCivilDefuncion.TabIndex = 14
        Me.txtActaCivilDefuncion.UIName = "Serie"
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
        Me.txtPoblacion.Location = New System.Drawing.Point(132, 352)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.RequiredField = True
        Me.txtPoblacion.Size = New System.Drawing.Size(292, 23)
        Me.txtPoblacion.TabIndex = 9
        Me.txtPoblacion.TextWidth = 70
        Me.txtPoblacion.UIName = Nothing
        '
        'lblEstadoInf
        '
        Me.lblEstadoInf.AutoSize = True
        Me.lblEstadoInf.Location = New System.Drawing.Point(129, 383)
        Me.lblEstadoInf.Name = "lblEstadoInf"
        Me.lblEstadoInf.Size = New System.Drawing.Size(46, 13)
        Me.lblEstadoInf.TabIndex = 110
        Me.lblEstadoInf.Text = "[Estado]"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(23, 383)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 109
        Me.lblEstado.Text = "Estado:"
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
        Me.txtSacerdote.Location = New System.Drawing.Point(133, 322)
        Me.txtSacerdote.Name = "txtSacerdote"
        Me.txtSacerdote.RequiredField = True
        Me.txtSacerdote.Size = New System.Drawing.Size(291, 23)
        Me.txtSacerdote.TabIndex = 8
        '
        'txtSolicitante
        '
        Me.txtSolicitante.AnySite = False
        Me.txtSolicitante.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtSolicitante.EditorAssembly = "Azteca.IglesiaWin"
        Me.txtSolicitante.EditorClass = "Azteca.Windows.Iglesia.SolicitantesForm"
        Me.txtSolicitante.EditorTitle = "Editar los datos del Solicitante..."
        Me.txtSolicitante.Key = 0
        Me.txtSolicitante.Linked = False
        Me.txtSolicitante.Location = New System.Drawing.Point(134, 191)
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.RequiredField = True
        Me.txtSolicitante.Size = New System.Drawing.Size(425, 23)
        Me.txtSolicitante.TabIndex = 4
        '
        'DefuncionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 440)
        Me.Controls.Add(Me.txtPoblacion)
        Me.Controls.Add(Me.lblEstadoInf)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.txtActaCivilDefuncion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.chkUncionEnfermos)
        Me.Controls.Add(Me.chkViatico)
        Me.Controls.Add(Me.chkReconciliacion)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSacerdote)
        Me.Controls.Add(Me.txtSepultadoEn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCausaFallecimiento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSolicitante)
        Me.Controls.Add(Me.txtFamiliaresSobreviven)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpFechaDefuncion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtActa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPagina)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLibro)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DefuncionForm"
        Me.Text = "DefuncionForm"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtLibro, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtPagina, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtActa, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaDefuncion, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.txtFamiliaresSobreviven, 0)
        Me.Controls.SetChildIndex(Me.txtSolicitante, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.txtCausaFallecimiento, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.txtSepultadoEn, 0)
        Me.Controls.SetChildIndex(Me.txtSacerdote, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.chkReconciliacion, 0)
        Me.Controls.SetChildIndex(Me.chkViatico, 0)
        Me.Controls.SetChildIndex(Me.chkUncionEnfermos, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.txtActaCivilDefuncion, 0)
        Me.Controls.SetChildIndex(Me.lblEstado, 0)
        Me.Controls.SetChildIndex(Me.lblEstadoInf, 0)
        Me.Controls.SetChildIndex(Me.txtPoblacion, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New DefuncionFacade
    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtActa As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPagina As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLibro As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDefuncion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFamiliaresSobreviven As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSolicitante As Azteca.Windows.Iglesia.SolicitanteSelector
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCausaFallecimiento As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSepultadoEn As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSacerdote As Azteca.Windows.Iglesia.SacerdoteSelector
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkReconciliacion As System.Windows.Forms.CheckBox
    Friend WithEvents chkViatico As System.Windows.Forms.CheckBox
    Friend WithEvents chkUncionEnfermos As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtActaCivilDefuncion As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtPoblacion As Azteca.Windows.Controls.General.PoblacionSelector
    Friend WithEvents lblEstadoInf As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblEstado As Azteca.Windows.Controls.CILabel
End Class
