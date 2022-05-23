<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmacionForm
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
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpFechaConfirmacion = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPadrino1 = New Azteca.Windows.Controls.CITextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtActa = New Azteca.Windows.Controls.CITextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPagina = New Azteca.Windows.Controls.CITextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLibro = New Azteca.Windows.Controls.CITextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSexo = New Azteca.Windows.Controls.CILabel()
        Me.rbtnFemenino = New Azteca.Windows.Controls.CIRadioButton()
        Me.rbtnMasculino = New Azteca.Windows.Controls.CIRadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSacerdote = New Azteca.Windows.Iglesia.SacerdoteSelector()
        Me.ParroquiaSel = New Azteca.Windows.Iglesia.ParroquiaSelector()
        Me.SolicitanteSel = New Azteca.Windows.Iglesia.SolicitanteSelector()
        Me.SuspendLayout()
        '
        'dtpFechaExpedicion
        '
        Me.dtpFechaExpedicion.Location = New System.Drawing.Point(121, 268)
        Me.dtpFechaExpedicion.Name = "dtpFechaExpedicion"
        Me.dtpFechaExpedicion.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaExpedicion.TabIndex = 8
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(20, 268)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(92, 13)
        Me.Label21.TabIndex = 89
        Me.Label21.Text = "Fecha Expedición"
        '
        'txtPBRO1
        '
        Me.txtPBRO1.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPBRO1.Location = New System.Drawing.Point(121, 161)
        Me.txtPBRO1.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPBRO1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPBRO1.Name = "txtPBRO1"
        Me.txtPBRO1.Size = New System.Drawing.Size(290, 20)
        Me.txtPBRO1.TabIndex = 87
        Me.txtPBRO1.UIName = "Serie"
        Me.txtPBRO1.Visible = False
        '
        'chkMostrarListaSacerdotes
        '
        Me.chkMostrarListaSacerdotes.AutoSize = True
        Me.chkMostrarListaSacerdotes.Checked = True
        Me.chkMostrarListaSacerdotes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMostrarListaSacerdotes.Location = New System.Drawing.Point(100, 163)
        Me.chkMostrarListaSacerdotes.Name = "chkMostrarListaSacerdotes"
        Me.chkMostrarListaSacerdotes.Size = New System.Drawing.Size(15, 14)
        Me.chkMostrarListaSacerdotes.TabIndex = 86
        Me.chkMostrarListaSacerdotes.UseVisualStyleBackColor = True
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Image = Global.Azteca.Windows.Iglesia.My.Resources.Resources.Print_16x16
        Me.cmdImprimir.Location = New System.Drawing.Point(315, 350)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(96, 30)
        Me.cmdImprimir.TabIndex = 11
        Me.cmdImprimir.Text = "Imprimir"
        Me.cmdImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 298)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Confirmo a"
        '
        'dtpFechaConfirmacion
        '
        Me.dtpFechaConfirmacion.Location = New System.Drawing.Point(120, 242)
        Me.dtpFechaConfirmacion.Name = "dtpFechaConfirmacion"
        Me.dtpFechaConfirmacion.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaConfirmacion.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Fecha Confirmación"
        '
        'txtPadrino1
        '
        Me.txtPadrino1.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPadrino1.Location = New System.Drawing.Point(120, 187)
        Me.txtPadrino1.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPadrino1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPadrino1.Name = "txtPadrino1"
        Me.txtPadrino1.Size = New System.Drawing.Size(291, 20)
        Me.txtPadrino1.TabIndex = 4
        Me.txtPadrino1.UIName = "Serie"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Padrino (a)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Conferida por:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(314, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "/"
        '
        'txtActa
        '
        Me.txtActa.Digits = True
        Me.txtActa.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtActa.Location = New System.Drawing.Point(341, 124)
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
        Me.Label4.Location = New System.Drawing.Point(338, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Acta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(204, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "/"
        '
        'txtPagina
        '
        Me.txtPagina.Digits = True
        Me.txtPagina.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPagina.Location = New System.Drawing.Point(230, 124)
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
        Me.Label2.Location = New System.Drawing.Point(226, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Pagina"
        '
        'txtLibro
        '
        Me.txtLibro.Digits = True
        Me.txtLibro.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtLibro.Location = New System.Drawing.Point(121, 124)
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
        Me.Label1.Location = New System.Drawing.Point(118, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Libro"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(20, 217)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(87, 13)
        Me.lblSexo.TabIndex = 92
        Me.lblSexo.Text = "Sexo del Padrino"
        '
        'rbtnFemenino
        '
        Me.rbtnFemenino.AutoSize = True
        Me.rbtnFemenino.Location = New System.Drawing.Point(249, 213)
        Me.rbtnFemenino.Name = "rbtnFemenino"
        Me.rbtnFemenino.Size = New System.Drawing.Size(71, 17)
        Me.rbtnFemenino.TabIndex = 6
        Me.rbtnFemenino.Text = "Femenino"
        Me.rbtnFemenino.UseVisualStyleBackColor = True
        '
        'rbtnMasculino
        '
        Me.rbtnMasculino.AutoSize = True
        Me.rbtnMasculino.Checked = True
        Me.rbtnMasculino.Location = New System.Drawing.Point(121, 213)
        Me.rbtnMasculino.Name = "rbtnMasculino"
        Me.rbtnMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rbtnMasculino.TabIndex = 5
        Me.rbtnMasculino.TabStop = True
        Me.rbtnMasculino.Text = "Masculino"
        Me.rbtnMasculino.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 324)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Parroquia"
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
        Me.txtSacerdote.Location = New System.Drawing.Point(120, 161)
        Me.txtSacerdote.Name = "txtSacerdote"
        Me.txtSacerdote.Size = New System.Drawing.Size(291, 23)
        Me.txtSacerdote.TabIndex = 3
        '
        'ParroquiaSel
        '
        Me.ParroquiaSel.AnySite = False
        Me.ParroquiaSel.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.ParroquiaSel.EditorAssembly = "Azteca.IglesiaWin"
        Me.ParroquiaSel.EditorClass = "Azteca.Windows.Iglesia.ParroquiasForm"
        Me.ParroquiaSel.EditorTitle = "Editar los datos de la Parroquia..."
        Me.ParroquiaSel.Key = 0
        Me.ParroquiaSel.Linked = False
        Me.ParroquiaSel.Location = New System.Drawing.Point(120, 321)
        Me.ParroquiaSel.Name = "ParroquiaSel"
        Me.ParroquiaSel.RequiredField = True
        Me.ParroquiaSel.Size = New System.Drawing.Size(291, 23)
        Me.ParroquiaSel.TabIndex = 10
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
        Me.SolicitanteSel.Location = New System.Drawing.Point(121, 294)
        Me.SolicitanteSel.Name = "SolicitanteSel"
        Me.SolicitanteSel.RequiredField = True
        Me.SolicitanteSel.Size = New System.Drawing.Size(290, 23)
        Me.SolicitanteSel.TabIndex = 9
        '
        'ConfirmacionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 417)
        Me.Controls.Add(Me.txtSacerdote)
        Me.Controls.Add(Me.ParroquiaSel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.rbtnFemenino)
        Me.Controls.Add(Me.rbtnMasculino)
        Me.Controls.Add(Me.dtpFechaExpedicion)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtPBRO1)
        Me.Controls.Add(Me.chkMostrarListaSacerdotes)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpFechaConfirmacion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPadrino1)
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
        Me.Name = "ConfirmacionForm"
        Me.Text = "ConfirmacionForm"
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
        Me.Controls.SetChildIndex(Me.txtPadrino1, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaConfirmacion, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.cmdImprimir, 0)
        Me.Controls.SetChildIndex(Me.chkMostrarListaSacerdotes, 0)
        Me.Controls.SetChildIndex(Me.txtPBRO1, 0)
        Me.Controls.SetChildIndex(Me.Label21, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaExpedicion, 0)
        Me.Controls.SetChildIndex(Me.rbtnMasculino, 0)
        Me.Controls.SetChildIndex(Me.rbtnFemenino, 0)
        Me.Controls.SetChildIndex(Me.lblSexo, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.ParroquiaSel, 0)
        Me.Controls.SetChildIndex(Me.txtSacerdote, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New ConfirmacionFacade
    End Sub
    Friend WithEvents dtpFechaExpedicion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtPBRO1 As Azteca.Windows.Controls.CITextBox
    Friend WithEvents chkMostrarListaSacerdotes As System.Windows.Forms.CheckBox
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaConfirmacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPadrino1 As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtActa As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPagina As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLibro As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SolicitanteSel As Azteca.Windows.Iglesia.SolicitanteSelector
    Friend WithEvents lblSexo As Azteca.Windows.Controls.CILabel
    Friend WithEvents rbtnFemenino As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rbtnMasculino As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ParroquiaSel As Azteca.Windows.Iglesia.ParroquiaSelector
    Friend WithEvents txtSacerdote As Azteca.Windows.Iglesia.SacerdoteSelector
End Class
