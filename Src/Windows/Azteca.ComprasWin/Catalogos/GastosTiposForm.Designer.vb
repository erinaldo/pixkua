<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GastosTiposForm
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
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GastosTiposForm))
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.dropCategorias = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsCatPresup = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdConceptos = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsConceptos = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dropCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCatPresup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(9, 128)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(44, 13)
        Me.lblCuenta.TabIndex = 37
        Me.lblCuenta.Text = "Cuenta:"
        '
        'selCuenta
        '
        Me.selCuenta.AnySite = False
        Me.selCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selCuenta.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.selCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.selCuenta.EditorTitle = "Editar Cuenta..."
        Me.selCuenta.Key = 0
        Me.selCuenta.Linked = False
        Me.selCuenta.Location = New System.Drawing.Point(62, 125)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCuenta.Size = New System.Drawing.Size(420, 23)
        Me.selCuenta.TabIndex = 36
        Me.selCuenta.TextWidth = 100
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(62, 99)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(420, 20)
        Me.txtNombre.TabIndex = 35
        Me.txtNombre.UIName = "Nombre"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(9, 102)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 34
        Me.lblNombre.Text = "Nombre:"
        '
        'dropCategorias
        '
        Me.dropCategorias.AllowColMove = True
        Me.dropCategorias.AllowColSelect = True
        Me.dropCategorias.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.dropCategorias.AlternatingRows = True
        Me.dropCategorias.CaptionStyle = Style1
        Me.dropCategorias.ColumnCaptionHeight = 17
        Me.dropCategorias.ColumnFooterHeight = 17
        Me.dropCategorias.DataSource = Me.bsCatPresup
        Me.dropCategorias.DisplayMember = "Nombre"
        Me.dropCategorias.EvenRowStyle = Style2
        Me.dropCategorias.FetchRowStyles = False
        Me.dropCategorias.FooterStyle = Style3
        Me.dropCategorias.HeadingStyle = Style4
        Me.dropCategorias.HighLightRowStyle = Style5
        Me.dropCategorias.Images.Add(CType(resources.GetObject("dropCategorias.Images"), System.Drawing.Image))
        Me.dropCategorias.Location = New System.Drawing.Point(27, 235)
        Me.dropCategorias.Name = "dropCategorias"
        Me.dropCategorias.OddRowStyle = Style6
        Me.dropCategorias.RecordSelectorStyle = Style7
        Me.dropCategorias.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropCategorias.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropCategorias.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropCategorias.ScrollTips = False
        Me.dropCategorias.Size = New System.Drawing.Size(306, 135)
        Me.dropCategorias.Style = Style8
        Me.dropCategorias.TabIndex = 51
        Me.dropCategorias.TabStop = False
        Me.dropCategorias.Text = "C1TrueDBDropdown1"
        Me.dropCategorias.ValueMember = "IdCategoriaPresupuestal"
        Me.dropCategorias.ValueTranslate = True
        Me.dropCategorias.Visible = False
        Me.dropCategorias.PropBag = resources.GetString("dropCategorias.PropBag")
        '
        'grdConceptos
        '
        Me.grdConceptos.AllowAddNew = True
        Me.grdConceptos.DataSource = Me.bsConceptos
        Me.grdConceptos.IDCatalogField = "IdMesa"
        Me.grdConceptos.Images.Add(CType(resources.GetObject("grdConceptos.Images"), System.Drawing.Image))
        Me.grdConceptos.Images.Add(CType(resources.GetObject("grdConceptos.Images1"), System.Drawing.Image))
        Me.grdConceptos.Location = New System.Drawing.Point(12, 155)
        Me.grdConceptos.Name = "grdConceptos"
        Me.grdConceptos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdConceptos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdConceptos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdConceptos.PrintInfo.PageSettings = CType(resources.GetObject("grdConceptos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdConceptos.RowHeight = 17
        Me.grdConceptos.ShowEditButton = False
        Me.grdConceptos.Size = New System.Drawing.Size(947, 240)
        Me.grdConceptos.TabIndex = 27
        Me.grdConceptos.PropBag = resources.GetString("grdConceptos.PropBag")
        '
        'GastosTiposForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 423)
        Me.Controls.Add(Me.dropCategorias)
        Me.Controls.Add(Me.grdConceptos)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.selCuenta)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "GastosTiposForm"
        Me.Text = "GastosTiposForm"
        Me.Controls.SetChildIndex(Me.lblNombre, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.selCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblCuenta, 0)
        Me.Controls.SetChildIndex(Me.grdConceptos, 0)
        Me.Controls.SetChildIndex(Me.dropCategorias, 0)
        CType(Me.dropCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCatPresup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New GastoConceptoTipoFacade
    End Sub
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdConceptos As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents dropCategorias As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents bsCatPresup As System.Windows.Forms.BindingSource
    Friend WithEvents bsConceptos As System.Windows.Forms.BindingSource
End Class
