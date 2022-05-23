<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuentasForm
    Inherits BusinessForms.HierarchyForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CuentasForm))
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.lblTipo = New Azteca.Windows.Controls.CILabel()
        Me.lblPadre = New Azteca.Windows.Controls.CILabel()
        Me.chkActivo = New Azteca.Windows.Controls.CICheckBox()
        Me.txtNivel = New Azteca.Windows.Controls.CITextBox()
        Me.txtPath = New Azteca.Windows.Controls.CITextBox()
        Me.lblNivel = New Azteca.Windows.Controls.CILabel()
        Me.lblPath = New Azteca.Windows.Controls.CILabel()
        Me.imlCuentas = New System.Windows.Forms.ImageList(Me.components)
        Me.cboTipo = New Azteca.Windows.Controls.CIComboBox()
        Me.fileOpenDlg = New System.Windows.Forms.OpenFileDialog()
        Me.grpCuenta = New Azteca.Windows.Controls.CIGroupBox()
        Me.lblFlujo = New Azteca.Windows.Controls.CILabel()
        Me.selFlujo = New Azteca.Windows.Contabilidad.FlujoSelector()
        Me.cboOrden = New Azteca.Windows.Controls.CIComboBox()
        Me.lblOrden = New Azteca.Windows.Controls.CILabel()
        Me.selPadre = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.lblNoFlujo = New Azteca.Windows.Controls.CILabel()
        Me.grpCuenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(17, 22)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(53, 13)
        Me.lblNombre.TabIndex = 37
        Me.lblNombre.Text = "Concepto"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(85, 19)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(341, 20)
        Me.txtNombre.TabIndex = 16
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(17, 47)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblTipo.TabIndex = 40
        Me.lblTipo.Text = "Tipo"
        '
        'lblPadre
        '
        Me.lblPadre.AutoSize = True
        Me.lblPadre.Location = New System.Drawing.Point(17, 126)
        Me.lblPadre.Name = "lblPadre"
        Me.lblPadre.Size = New System.Drawing.Size(67, 13)
        Me.lblPadre.TabIndex = 43
        Me.lblPadre.Text = "Nodo Padre:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(247, 207)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 22
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtNivel
        '
        Me.txtNivel.AutoLock = False
        Me.txtNivel.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNivel.Digits = True
        Me.txtNivel.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNivel.Enabled = False
        Me.txtNivel.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNivel.Location = New System.Drawing.Point(86, 204)
        Me.txtNivel.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNivel.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.ReadOnly = True
        Me.txtNivel.Size = New System.Drawing.Size(65, 20)
        Me.txtNivel.TabIndex = 47
        '
        'txtPath
        '
        Me.txtPath.AutoLock = False
        Me.txtPath.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtPath.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtPath.Enabled = False
        Me.txtPath.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPath.Location = New System.Drawing.Point(85, 149)
        Me.txtPath.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPath.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPath.Multiline = True
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(341, 46)
        Me.txtPath.TabIndex = 45
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.Location = New System.Drawing.Point(18, 206)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(34, 13)
        Me.lblNivel.TabIndex = 46
        Me.lblNivel.Text = "Nivel:"
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(17, 154)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(32, 13)
        Me.lblPath.TabIndex = 44
        Me.lblPath.Text = "Path:"
        '
        'imlCuentas
        '
        Me.imlCuentas.ImageStream = CType(resources.GetObject("imlCuentas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlCuentas.TransparentColor = System.Drawing.Color.Transparent
        Me.imlCuentas.Images.SetKeyName(0, "chart_organisation.png")
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTipo.ItemsTable = Nothing
        Me.cboTipo.Location = New System.Drawing.Point(85, 44)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboTipo.Size = New System.Drawing.Size(162, 21)
        Me.cboTipo.TabIndex = 18
        Me.cboTipo.UIName = Nothing
        '
        'fileOpenDlg
        '
        Me.fileOpenDlg.FileName = "Cuentas"
        '
        'grpCuenta
        '
        Me.grpCuenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCuenta.Controls.Add(Me.lblFlujo)
        Me.grpCuenta.Controls.Add(Me.selFlujo)
        Me.grpCuenta.Controls.Add(Me.cboOrden)
        Me.grpCuenta.Controls.Add(Me.lblOrden)
        Me.grpCuenta.Controls.Add(Me.txtNombre)
        Me.grpCuenta.Controls.Add(Me.selPadre)
        Me.grpCuenta.Controls.Add(Me.lblPadre)
        Me.grpCuenta.Controls.Add(Me.cboTipo)
        Me.grpCuenta.Controls.Add(Me.lblTipo)
        Me.grpCuenta.Controls.Add(Me.chkActivo)
        Me.grpCuenta.Controls.Add(Me.lblNombre)
        Me.grpCuenta.Controls.Add(Me.txtNivel)
        Me.grpCuenta.Controls.Add(Me.lblPath)
        Me.grpCuenta.Controls.Add(Me.txtPath)
        Me.grpCuenta.Controls.Add(Me.lblNivel)
        Me.grpCuenta.Location = New System.Drawing.Point(256, 90)
        Me.grpCuenta.Name = "grpCuenta"
        Me.grpCuenta.Size = New System.Drawing.Size(432, 249)
        Me.grpCuenta.TabIndex = 48
        Me.grpCuenta.TabStop = False
        '
        'lblFlujo
        '
        Me.lblFlujo.AutoSize = True
        Me.lblFlujo.Location = New System.Drawing.Point(17, 101)
        Me.lblFlujo.Name = "lblFlujo"
        Me.lblFlujo.Size = New System.Drawing.Size(32, 13)
        Me.lblFlujo.TabIndex = 51
        Me.lblFlujo.Text = "Flujo:"
        '
        'selFlujo
        '
        Me.selFlujo.AnySite = False
        Me.selFlujo.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selFlujo.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selFlujo.EditorAssembly = "Azteca.ContabilidadWin"
        Me.selFlujo.EditorClass = "Azteca.Windows.Contabilidad.FlujoForm"
        Me.selFlujo.EditorTitle = "Editar nodo de Flujo..."
        Me.selFlujo.Key = 0
        Me.selFlujo.Linked = False
        Me.selFlujo.Location = New System.Drawing.Point(85, 96)
        Me.selFlujo.Name = "selFlujo"
        Me.selFlujo.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selFlujo.Size = New System.Drawing.Size(341, 23)
        Me.selFlujo.TabIndex = 50
        '
        'cboOrden
        '
        Me.cboOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrden.FormattingEnabled = True
        Me.cboOrden.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboOrden.ItemsTable = Nothing
        Me.cboOrden.Location = New System.Drawing.Point(85, 69)
        Me.cboOrden.Name = "cboOrden"
        Me.cboOrden.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboOrden.Size = New System.Drawing.Size(162, 21)
        Me.cboOrden.TabIndex = 48
        Me.cboOrden.UIName = Nothing
        '
        'lblOrden
        '
        Me.lblOrden.AutoSize = True
        Me.lblOrden.Location = New System.Drawing.Point(17, 72)
        Me.lblOrden.Name = "lblOrden"
        Me.lblOrden.Size = New System.Drawing.Size(36, 13)
        Me.lblOrden.TabIndex = 49
        Me.lblOrden.Text = "Orden"
        '
        'selPadre
        '
        Me.selPadre.AnySite = False
        Me.selPadre.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selPadre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selPadre.EditorAssembly = "Azteca.ContabilidadWin"
        Me.selPadre.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.selPadre.EditorTitle = "Editar Cuenta..."
        Me.selPadre.Key = 0
        Me.selPadre.Linked = False
        Me.selPadre.Location = New System.Drawing.Point(85, 122)
        Me.selPadre.Name = "selPadre"
        Me.selPadre.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selPadre.Size = New System.Drawing.Size(341, 23)
        Me.selPadre.TabIndex = 21
        Me.selPadre.TextWidth = 100
        '
        'lblNoFlujo
        '
        Me.lblNoFlujo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoFlujo.BackColor = System.Drawing.Color.LightGreen
        Me.lblNoFlujo.Location = New System.Drawing.Point(12, 346)
        Me.lblNoFlujo.Name = "lblNoFlujo"
        Me.lblNoFlujo.Size = New System.Drawing.Size(191, 23)
        Me.lblNoFlujo.TabIndex = 49
        Me.lblNoFlujo.Text = "*No todos los nodos hijos tienen el mismo flujo"
        Me.lblNoFlujo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CuentasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 405)
        Me.CodeFieldSize = New System.Drawing.Size(150, 20)
        Me.CodeFieldText = "Cuenta:"
        Me.Controls.Add(Me.lblNoFlujo)
        Me.Controls.Add(Me.grpCuenta)
        Me.KeyMode = Azteca.Windows.Forms.BusinessForms.CatalogForm.UserKeyMode.UserDefined
        Me.Name = "CuentasForm"
        Me.ShowIcon = False
        Me.Text = "Cuentas"
        Me.Controls.SetChildIndex(Me.grpCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblNoFlujo, 0)
        Me.grpCuenta.ResumeLayout(False)
        Me.grpCuenta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblTipo As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblPadre As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkActivo As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents txtNivel As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtPath As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNivel As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblPath As Azteca.Windows.Controls.CILabel
    Friend WithEvents imlCuentas As System.Windows.Forms.ImageList
    Friend WithEvents cboTipo As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents selPadre As Azteca.Windows.Contabilidad.CuentaSelector

    Private cmdImportacion As C1.Win.C1Command.C1Command
    Private cmdImportacionFile As C1.Win.C1Command.C1Command

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Facade = New Azteca.Business.Contabilidad.CuentaFacade
        Me.HierarchyFacade = New Azteca.Business.Contabilidad.CuentaFacade
        LicenseModule = Kernel.Licensing.LicenseModule.Accounting


        'Agregar botón para establecer accesos a los centros de costo
        cmdImportacion = New C1.Win.C1Command.C1Command
        cmdImportacion.ToolTipText = "Importar la informacion desde un origen de datos configurado"
        cmdImportacion.Image = My.Resources.invoice_config32
        Dim btnImportacion As New C1.Win.C1Command.C1CommandLink(cmdImportacion)
        ToolBar.CommandLinks.Add(btnImportacion)
        AddHandler cmdImportacion.Click, AddressOf btnImportacion_Click

        cmdImportacionFile = New C1.Win.C1Command.C1Command
        cmdImportacionFile.ToolTipText = "Importar la informacion desde un Archivo de cuentas con formato de contpaq"
        cmdImportacionFile.Image = My.Resources.invoice_config32
        Dim btnImportacionFile As New C1.Win.C1Command.C1CommandLink(cmdImportacionFile)
        ToolBar.CommandLinks.Add(btnImportacionFile)
        AddHandler cmdImportacionFile.Click, AddressOf btnImportacionFile_Click

    End Sub
    Friend WithEvents fileOpenDlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grpCuenta As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents cboOrden As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents lblOrden As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblFlujo As Azteca.Windows.Controls.CILabel
    Friend WithEvents selFlujo As Azteca.Windows.Contabilidad.FlujoSelector
    Friend WithEvents lblNoFlujo As Azteca.Windows.Controls.CILabel
End Class
