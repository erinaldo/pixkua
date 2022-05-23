<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrasladoForm
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTemplo = New Azteca.Windows.Controls.CITextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumero = New Azteca.Windows.Controls.CITextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtExpediente = New Azteca.Windows.Controls.CITextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.dtpFechaExpedicion = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEsposa = New Azteca.Windows.Iglesia.SolicitanteSelector()
        Me.txtEsposo = New Azteca.Windows.Iglesia.SolicitanteSelector()
        Me.txtParroquiaCura = New Azteca.Windows.Iglesia.ParroquiaSelector()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Al Sr. cura de"
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Location = New System.Drawing.Point(120, 182)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(49, 13)
        Me.lblDomicilio.TabIndex = 96
        Me.lblDomicilio.Text = "Domicilio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Esposo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Esposa"
        '
        'txtTemplo
        '
        Me.txtTemplo.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTemplo.Location = New System.Drawing.Point(123, 269)
        Me.txtTemplo.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTemplo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTemplo.Name = "txtTemplo"
        Me.txtTemplo.Size = New System.Drawing.Size(359, 20)
        Me.txtTemplo.TabIndex = 145
        Me.txtTemplo.UIName = "Serie"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(25, 273)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 146
        Me.Label13.Text = "Templo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(364, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 154
        Me.Label1.Text = "/"
        '
        'txtNumero
        '
        Me.txtNumero.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumero.Location = New System.Drawing.Point(391, 113)
        Me.txtNumero.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumero.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.RequiredField = True
        Me.txtNumero.Size = New System.Drawing.Size(70, 20)
        Me.txtNumero.TabIndex = 149
        Me.txtNumero.UIName = "Serie"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(388, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "Numero"
        '
        'txtExpediente
        '
        Me.txtExpediente.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtExpediente.Location = New System.Drawing.Point(280, 113)
        Me.txtExpediente.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtExpediente.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtExpediente.Name = "txtExpediente"
        Me.txtExpediente.RequiredField = True
        Me.txtExpediente.Size = New System.Drawing.Size(70, 20)
        Me.txtExpediente.TabIndex = 148
        Me.txtExpediente.UIName = "Serie"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(276, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "Expediente"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Image = Global.Azteca.Windows.Iglesia.My.Resources.Resources.Print_16x16
        Me.cmdImprimir.Location = New System.Drawing.Point(386, 298)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(96, 30)
        Me.cmdImprimir.TabIndex = 155
        Me.cmdImprimir.Text = "Imprimir"
        Me.cmdImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'dtpFechaExpedicion
        '
        Me.dtpFechaExpedicion.Location = New System.Drawing.Point(123, 298)
        Me.dtpFechaExpedicion.Name = "dtpFechaExpedicion"
        Me.dtpFechaExpedicion.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaExpedicion.TabIndex = 156
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "Fecha Expedición"
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
        Me.txtEsposa.Location = New System.Drawing.Point(123, 238)
        Me.txtEsposa.Name = "txtEsposa"
        Me.txtEsposa.Size = New System.Drawing.Size(359, 23)
        Me.txtEsposa.TabIndex = 101
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
        Me.txtEsposo.Location = New System.Drawing.Point(123, 209)
        Me.txtEsposo.Name = "txtEsposo"
        Me.txtEsposo.Size = New System.Drawing.Size(359, 23)
        Me.txtEsposo.TabIndex = 99
        '
        'txtParroquiaCura
        '
        Me.txtParroquiaCura.AnySite = False
        Me.txtParroquiaCura.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtParroquiaCura.EditorAssembly = "Azteca.IglesiaWin"
        Me.txtParroquiaCura.EditorClass = "Azteca.Windows.Iglesia.ParroquiasForm"
        Me.txtParroquiaCura.EditorTitle = "Editar los datos de la Parroquia..."
        Me.txtParroquiaCura.Key = 0
        Me.txtParroquiaCura.Linked = False
        Me.txtParroquiaCura.Location = New System.Drawing.Point(123, 150)
        Me.txtParroquiaCura.Name = "txtParroquiaCura"
        Me.txtParroquiaCura.Size = New System.Drawing.Size(359, 23)
        Me.txtParroquiaCura.TabIndex = 94
        '
        'TrasladoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 364)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFechaExpedicion)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtExpediente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTemplo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtEsposa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEsposo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDomicilio)
        Me.Controls.Add(Me.txtParroquiaCura)
        Me.Controls.Add(Me.Label9)
        Me.Name = "TrasladoForm"
        Me.Text = "TrasladoForm"
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.txtParroquiaCura, 0)
        Me.Controls.SetChildIndex(Me.lblDomicilio, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtEsposo, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtEsposa, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.txtTemplo, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.txtExpediente, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.txtNumero, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.cmdImprimir, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaExpedicion, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New TrasladoFacade
    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtParroquiaCura As Azteca.Windows.Iglesia.ParroquiaSelector
    Friend WithEvents lblDomicilio As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEsposo As Azteca.Windows.Iglesia.SolicitanteSelector
    Friend WithEvents txtEsposa As Azteca.Windows.Iglesia.SolicitanteSelector
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTemplo As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtExpediente As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents dtpFechaExpedicion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
