<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CentralesForm
    Inherits Azteca.Windows.Forms.BusinessForms.CatalogForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CentralesForm))
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.cboRemitente = New Azteca.Windows.Mail.RemitentesComboBox()
        Me.cboOperador = New Azteca.Windows.Controls.General.OperadorComboBox()
        Me.lblOperador = New Azteca.Windows.Controls.CILabel()
        Me.chkEnviarOC = New Azteca.Windows.Controls.CICheckBox()
        Me.chkNotificarOC = New Azteca.Windows.Controls.CICheckBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.cboZona = New Azteca.Windows.Compras.ZonasComboBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.cboCaja = New Azteca.Windows.Tesoreria.CajasComboBox()
        Me.imlCetrales = New System.Windows.Forms.ImageList(Me.components)
        Me.tabCentrales = New Azteca.Windows.Controls.AZDockingTab()
        Me.pagGeneral = New C1.Win.C1Command.C1DockingTabPage()
        Me.pagNotificaciones = New C1.Win.C1Command.C1DockingTabPage()
        CType(Me.tabCentrales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCentrales.SuspendLayout()
        Me.pagGeneral.SuspendLayout()
        Me.pagNotificaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(123, 37)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(346, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.UIName = "Nombre"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(23, 40)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'selCuenta
        '
        Me.selCuenta.AnySite = False
        Me.selCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.selCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.selCuenta.EditorTitle = "Editar Cuenta..."
        Me.selCuenta.Key = 0
        Me.selCuenta.Linked = False
        Me.selCuenta.Location = New System.Drawing.Point(123, 117)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.Size = New System.Drawing.Size(346, 23)
        Me.selCuenta.TabIndex = 7
        Me.selCuenta.TextWidth = 100
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(23, 122)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(44, 13)
        Me.lblCuenta.TabIndex = 6
        Me.lblCuenta.Text = "Cuenta:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(14, 24)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(141, 13)
        Me.CiLabel3.TabIndex = 0
        Me.CiLabel3.Text = "Remitente de notificaciones:"
        '
        'cboRemitente
        '
        Me.cboRemitente.AutoLock = False
        Me.cboRemitente.BackColor = System.Drawing.SystemColors.Window
        Me.cboRemitente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRemitente.FormattingEnabled = True
        Me.cboRemitente.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboRemitente.ItemsTable = Nothing
        Me.cboRemitente.Location = New System.Drawing.Point(161, 21)
        Me.cboRemitente.Name = "cboRemitente"
        Me.cboRemitente.Size = New System.Drawing.Size(227, 21)
        Me.cboRemitente.TabIndex = 1
        Me.cboRemitente.UIName = Nothing
        '
        'cboOperador
        '
        Me.cboOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperador.FormattingEnabled = True
        Me.cboOperador.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboOperador.ItemsTable = Nothing
        Me.cboOperador.Location = New System.Drawing.Point(161, 48)
        Me.cboOperador.Name = "cboOperador"
        Me.cboOperador.Size = New System.Drawing.Size(227, 21)
        Me.cboOperador.TabIndex = 3
        Me.cboOperador.UIName = Nothing
        '
        'lblOperador
        '
        Me.lblOperador.AutoSize = True
        Me.lblOperador.Location = New System.Drawing.Point(14, 51)
        Me.lblOperador.Name = "lblOperador"
        Me.lblOperador.Size = New System.Drawing.Size(114, 13)
        Me.lblOperador.TabIndex = 2
        Me.lblOperador.Text = "Operador destinatario :"
        '
        'chkEnviarOC
        '
        Me.chkEnviarOC.AutoSize = True
        Me.chkEnviarOC.Location = New System.Drawing.Point(161, 75)
        Me.chkEnviarOC.Name = "chkEnviarOC"
        Me.chkEnviarOC.Size = New System.Drawing.Size(153, 17)
        Me.chkEnviarOC.TabIndex = 4
        Me.chkEnviarOC.Text = "Enviar Ordenes de Compra"
        Me.chkEnviarOC.UseVisualStyleBackColor = True
        '
        'chkNotificarOC
        '
        Me.chkNotificarOC.AutoSize = True
        Me.chkNotificarOC.Location = New System.Drawing.Point(161, 98)
        Me.chkNotificarOC.Name = "chkNotificarOC"
        Me.chkNotificarOC.Size = New System.Drawing.Size(162, 17)
        Me.chkNotificarOC.TabIndex = 5
        Me.chkNotificarOC.Text = "Notificar Ordenes de Compra"
        Me.chkNotificarOC.UseVisualStyleBackColor = True
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(23, 93)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(79, 13)
        Me.CiLabel1.TabIndex = 4
        Me.CiLabel1.Text = "Caja de Pagos:"
        '
        'cboZona
        '
        Me.cboZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZona.FormattingEnabled = True
        Me.cboZona.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboZona.ItemsTable = Nothing
        Me.cboZona.Location = New System.Drawing.Point(123, 63)
        Me.cboZona.Name = "cboZona"
        Me.cboZona.RequiredField = True
        Me.cboZona.Size = New System.Drawing.Size(227, 21)
        Me.cboZona.TabIndex = 3
        Me.cboZona.UIName = "Zona de Compras"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(23, 66)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(94, 13)
        Me.CiLabel2.TabIndex = 2
        Me.CiLabel2.Text = "Zona de Compras:"
        '
        'cboCaja
        '
        Me.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCaja.ItemsTable = Nothing
        Me.cboCaja.Location = New System.Drawing.Point(123, 90)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.RequiredField = True
        Me.cboCaja.Size = New System.Drawing.Size(227, 21)
        Me.cboCaja.TabIndex = 5
        Me.cboCaja.UIName = "Caja para Pago"
        '
        'imlCetrales
        '
        Me.imlCetrales.ImageStream = CType(resources.GetObject("imlCetrales.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlCetrales.TransparentColor = System.Drawing.Color.Transparent
        Me.imlCetrales.Images.SetKeyName(0, "General")
        Me.imlCetrales.Images.SetKeyName(1, "Notificaciones")
        '
        'tabCentrales
        '
        Me.tabCentrales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabCentrales.Controls.Add(Me.pagGeneral)
        Me.tabCentrales.Controls.Add(Me.pagNotificaciones)
        Me.tabCentrales.ImageList = Me.imlCetrales
        Me.tabCentrales.Location = New System.Drawing.Point(12, 106)
        Me.tabCentrales.Name = "tabCentrales"
        Me.tabCentrales.SelectedIndex = 1
        Me.tabCentrales.Size = New System.Drawing.Size(531, 286)
        Me.tabCentrales.TabIndex = 62
        Me.tabCentrales.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.tabCentrales.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tabCentrales.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'pagGeneral
        '
        Me.pagGeneral.Controls.Add(Me.cboZona)
        Me.pagGeneral.Controls.Add(Me.lblNombre)
        Me.pagGeneral.Controls.Add(Me.CiLabel2)
        Me.pagGeneral.Controls.Add(Me.lblCuenta)
        Me.pagGeneral.Controls.Add(Me.txtNombre)
        Me.pagGeneral.Controls.Add(Me.selCuenta)
        Me.pagGeneral.Controls.Add(Me.CiLabel1)
        Me.pagGeneral.Controls.Add(Me.cboCaja)
        Me.pagGeneral.ImageIndex = 0
        Me.pagGeneral.Location = New System.Drawing.Point(1, 41)
        Me.pagGeneral.Name = "pagGeneral"
        Me.pagGeneral.Size = New System.Drawing.Size(529, 244)
        Me.pagGeneral.TabIndex = 0
        Me.pagGeneral.Text = "General"
        '
        'pagNotificaciones
        '
        Me.pagNotificaciones.Controls.Add(Me.CiLabel3)
        Me.pagNotificaciones.Controls.Add(Me.cboRemitente)
        Me.pagNotificaciones.Controls.Add(Me.chkNotificarOC)
        Me.pagNotificaciones.Controls.Add(Me.lblOperador)
        Me.pagNotificaciones.Controls.Add(Me.chkEnviarOC)
        Me.pagNotificaciones.Controls.Add(Me.cboOperador)
        Me.pagNotificaciones.ImageIndex = 1
        Me.pagNotificaciones.Location = New System.Drawing.Point(1, 41)
        Me.pagNotificaciones.Name = "pagNotificaciones"
        Me.pagNotificaciones.Size = New System.Drawing.Size(529, 244)
        Me.pagNotificaciones.TabIndex = 1
        Me.pagNotificaciones.Text = "Notificaciones"
        '
        'CentralesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 420)
        Me.Controls.Add(Me.tabCentrales)
        Me.Name = "CentralesForm"
        Me.Text = "CentralesForm"
        Me.Controls.SetChildIndex(Me.tabCentrales, 0)
        CType(Me.tabCentrales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCentrales.ResumeLayout(False)
        Me.pagGeneral.ResumeLayout(False)
        Me.pagGeneral.PerformLayout()
        Me.pagNotificaciones.ResumeLayout(False)
        Me.pagNotificaciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboRemitente As Azteca.Windows.Mail.RemitentesComboBox
    Friend WithEvents cboOperador As Azteca.Windows.Controls.General.OperadorComboBox
    Friend WithEvents lblOperador As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkEnviarOC As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents chkNotificarOC As Azteca.Windows.Controls.CICheckBox

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New CentralFacade
    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboCaja As Azteca.Windows.Tesoreria.CajasComboBox
    Friend WithEvents imlCetrales As System.Windows.Forms.ImageList
    Friend WithEvents cboZona As Azteca.Windows.Compras.ZonasComboBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents tabCentrales As Azteca.Windows.Controls.AZDockingTab
    Friend WithEvents pagGeneral As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pagNotificaciones As C1.Win.C1Command.C1DockingTabPage
End Class
