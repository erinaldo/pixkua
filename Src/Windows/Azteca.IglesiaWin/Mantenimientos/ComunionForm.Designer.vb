<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComunionForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPagina = New Azteca.Windows.Controls.CITextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLibro = New Azteca.Windows.Controls.CITextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPadrinos = New Azteca.Windows.Controls.CITextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaExpedicion = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSacerdoteCelebra = New Azteca.Windows.Iglesia.SacerdoteSelector()
        Me.txtSolicitante = New Azteca.Windows.Iglesia.SolicitanteSelector()
        Me.txtParroquiaSacerdoteCer = New Azteca.Windows.Iglesia.ParroquiaSelector()
        Me.txtSacerdoteCertifica = New Azteca.Windows.Iglesia.SacerdoteSelector()
        Me.cmdImprimirConstancia = New System.Windows.Forms.Button()
        Me.cmdImprimirActa = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "/"
        '
        'txtPagina
        '
        Me.txtPagina.Digits = True
        Me.txtPagina.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPagina.Location = New System.Drawing.Point(218, 117)
        Me.txtPagina.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPagina.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPagina.Name = "txtPagina"
        Me.txtPagina.RequiredField = True
        Me.txtPagina.Size = New System.Drawing.Size(70, 20)
        Me.txtPagina.TabIndex = 168
        Me.txtPagina.UIName = "Serie"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(215, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 170
        Me.Label6.Text = "Pagina"
        '
        'txtLibro
        '
        Me.txtLibro.Digits = True
        Me.txtLibro.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtLibro.Location = New System.Drawing.Point(107, 117)
        Me.txtLibro.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLibro.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLibro.Name = "txtLibro"
        Me.txtLibro.RequiredField = True
        Me.txtLibro.Size = New System.Drawing.Size(67, 20)
        Me.txtLibro.TabIndex = 167
        Me.txtLibro.UIName = "Serie"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(103, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 169
        Me.Label8.Text = "Libro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "Es Suscrito"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 176
        Me.Label3.Text = "Parroco de"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 178
        Me.Label4.Text = "Solicitante"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 180
        Me.Label5.Text = "Asistío"
        '
        'txtPadrinos
        '
        Me.txtPadrinos.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPadrinos.Location = New System.Drawing.Point(107, 278)
        Me.txtPadrinos.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPadrinos.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPadrinos.Name = "txtPadrinos"
        Me.txtPadrinos.Size = New System.Drawing.Size(370, 20)
        Me.txtPadrinos.TabIndex = 181
        Me.txtPadrinos.UIName = "Serie"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 281)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 182
        Me.Label13.Text = "Padrinos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Fecha Bautismo"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(107, 310)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 184
        '
        'dtpFechaExpedicion
        '
        Me.dtpFechaExpedicion.Location = New System.Drawing.Point(107, 349)
        Me.dtpFechaExpedicion.Name = "dtpFechaExpedicion"
        Me.dtpFechaExpedicion.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaExpedicion.TabIndex = 186
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 351)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 185
        Me.Label9.Text = "Fecha Expedición"
        '
        'txtSacerdoteCelebra
        '
        Me.txtSacerdoteCelebra.AnySite = False
        Me.txtSacerdoteCelebra.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtSacerdoteCelebra.EditorAssembly = "Azteca.IglesiaWin"
        Me.txtSacerdoteCelebra.EditorClass = "Azteca.Windows.Iglesia.SacerdotesForm"
        Me.txtSacerdoteCelebra.EditorTitle = "Editar los datos del Sacerdote..."
        Me.txtSacerdoteCelebra.Key = 0
        Me.txtSacerdoteCelebra.Linked = False
        Me.txtSacerdoteCelebra.Location = New System.Drawing.Point(107, 243)
        Me.txtSacerdoteCelebra.Name = "txtSacerdoteCelebra"
        Me.txtSacerdoteCelebra.Size = New System.Drawing.Size(384, 23)
        Me.txtSacerdoteCelebra.TabIndex = 179
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
        Me.txtSolicitante.Location = New System.Drawing.Point(107, 214)
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.Size = New System.Drawing.Size(384, 23)
        Me.txtSolicitante.TabIndex = 177
        '
        'txtParroquiaSacerdoteCer
        '
        Me.txtParroquiaSacerdoteCer.AnySite = False
        Me.txtParroquiaSacerdoteCer.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtParroquiaSacerdoteCer.EditorAssembly = "Azteca.IglesiaWin"
        Me.txtParroquiaSacerdoteCer.EditorClass = "Azteca.Windows.Iglesia.ParroquiasForm"
        Me.txtParroquiaSacerdoteCer.EditorTitle = "Editar los datos de la Parroquia..."
        Me.txtParroquiaSacerdoteCer.Key = 0
        Me.txtParroquiaSacerdoteCer.Linked = False
        Me.txtParroquiaSacerdoteCer.Location = New System.Drawing.Point(107, 185)
        Me.txtParroquiaSacerdoteCer.Name = "txtParroquiaSacerdoteCer"
        Me.txtParroquiaSacerdoteCer.Size = New System.Drawing.Size(384, 23)
        Me.txtParroquiaSacerdoteCer.TabIndex = 175
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
        Me.txtSacerdoteCertifica.Location = New System.Drawing.Point(107, 156)
        Me.txtSacerdoteCertifica.Name = "txtSacerdoteCertifica"
        Me.txtSacerdoteCertifica.Size = New System.Drawing.Size(383, 23)
        Me.txtSacerdoteCertifica.TabIndex = 173
        '
        'cmdImprimirConstancia
        '
        Me.cmdImprimirConstancia.Image = Global.Azteca.Windows.Iglesia.My.Resources.Resources.constancia
        Me.cmdImprimirConstancia.Location = New System.Drawing.Point(366, 343)
        Me.cmdImprimirConstancia.Name = "cmdImprimirConstancia"
        Me.cmdImprimirConstancia.Size = New System.Drawing.Size(111, 30)
        Me.cmdImprimirConstancia.TabIndex = 188
        Me.cmdImprimirConstancia.Text = "Imp. Constancia"
        Me.cmdImprimirConstancia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdImprimirConstancia.UseVisualStyleBackColor = True
        '
        'cmdImprimirActa
        '
        Me.cmdImprimirActa.Image = Global.Azteca.Windows.Iglesia.My.Resources.Resources.acta
        Me.cmdImprimirActa.Location = New System.Drawing.Point(366, 307)
        Me.cmdImprimirActa.Name = "cmdImprimirActa"
        Me.cmdImprimirActa.Size = New System.Drawing.Size(111, 30)
        Me.cmdImprimirActa.TabIndex = 187
        Me.cmdImprimirActa.Text = "Imp. Acta"
        Me.cmdImprimirActa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdImprimirActa.UseVisualStyleBackColor = True
        '
        'ComunionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 406)
        Me.Controls.Add(Me.cmdImprimirConstancia)
        Me.Controls.Add(Me.cmdImprimirActa)
        Me.Controls.Add(Me.dtpFechaExpedicion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPadrinos)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSacerdoteCelebra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSolicitante)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtParroquiaSacerdoteCer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSacerdoteCertifica)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPagina)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLibro)
        Me.Controls.Add(Me.Label8)
        Me.Name = "ComunionForm"
        Me.Text = "ComunionForm"
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.txtLibro, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.txtPagina, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtSacerdoteCertifica, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtParroquiaSacerdoteCer, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtSolicitante, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtSacerdoteCelebra, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.txtPadrinos, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.dtpFecha, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaExpedicion, 0)
        Me.Controls.SetChildIndex(Me.cmdImprimirActa, 0)
        Me.Controls.SetChildIndex(Me.cmdImprimirConstancia, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New ComunionFacade
    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPagina As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLibro As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSacerdoteCertifica As Azteca.Windows.Iglesia.SacerdoteSelector
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtParroquiaSacerdoteCer As Azteca.Windows.Iglesia.ParroquiaSelector
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSolicitante As Azteca.Windows.Iglesia.SolicitanteSelector
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSacerdoteCelebra As Azteca.Windows.Iglesia.SacerdoteSelector
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPadrinos As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaExpedicion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdImprimirConstancia As System.Windows.Forms.Button
    Friend WithEvents cmdImprimirActa As System.Windows.Forms.Button
End Class
