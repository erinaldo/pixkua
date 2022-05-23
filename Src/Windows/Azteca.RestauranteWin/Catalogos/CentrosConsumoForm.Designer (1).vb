<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CentrosConsumoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CentrosConsumoForm))
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.txtDescripcion = New Azteca.Windows.Controls.CITextBox()
        Me.lblDescripcion = New Azteca.Windows.Controls.CILabel()
        Me.gbxDetalle = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdMesas = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsMesa = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbMenu = New Azteca.Windows.Controls.CIToolBar()
        Me.btnNuevoArt = New System.Windows.Forms.ToolStripButton()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.lblCaja = New Azteca.Windows.Controls.CILabel()
        Me.cboCaja = New Azteca.Windows.Ventas.CajaCombobox()
        Me.gbxDetalle.SuspendLayout()
        CType(Me.grdMesas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMesa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(38, 157)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.lblCuenta.TabIndex = 33
        Me.lblCuenta.Text = "Cuenta"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtDescripcion.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtDescripcion.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDescripcion.Location = New System.Drawing.Point(85, 98)
        Me.txtDescripcion.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescripcion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(359, 20)
        Me.txtDescripcion.TabIndex = 35
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(16, 101)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 34
        Me.lblDescripcion.Text = "Descripcion"
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDetalle.Controls.Add(Me.grdMesas)
        Me.gbxDetalle.Controls.Add(Me.tbMenu)
        Me.gbxDetalle.Location = New System.Drawing.Point(0, 182)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(524, 232)
        Me.gbxDetalle.TabIndex = 36
        Me.gbxDetalle.TabStop = False
        '
        'grdMesas
        '
        Me.grdMesas.AlternatingRows = True
        Me.grdMesas.DataSource = Me.bsMesa
        Me.grdMesas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMesas.IDCatalogField = "IdMesa"
        Me.grdMesas.Images.Add(CType(resources.GetObject("grdMesas.Images"), System.Drawing.Image))
        Me.grdMesas.Location = New System.Drawing.Point(3, 55)
        Me.grdMesas.Name = "grdMesas"
        Me.grdMesas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdMesas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdMesas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdMesas.PrintInfo.PageSettings = CType(resources.GetObject("grdMesas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdMesas.ShowDeleteButton = False
        Me.grdMesas.ShowEditButton = False
        Me.grdMesas.Size = New System.Drawing.Size(518, 174)
        Me.grdMesas.TabIndex = 27
        Me.grdMesas.PropBag = resources.GetString("grdMesas.PropBag")
        '
        'tbMenu
        '
        Me.tbMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoArt})
        Me.tbMenu.Location = New System.Drawing.Point(3, 16)
        Me.tbMenu.Name = "tbMenu"
        Me.tbMenu.Size = New System.Drawing.Size(518, 39)
        Me.tbMenu.TabIndex = 28
        Me.tbMenu.Text = "CiToolBar1"
        '
        'btnNuevoArt
        '
        Me.btnNuevoArt.Image = CType(resources.GetObject("btnNuevoArt.Image"), System.Drawing.Image)
        Me.btnNuevoArt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevoArt.Name = "btnNuevoArt"
        Me.btnNuevoArt.Size = New System.Drawing.Size(107, 36)
        Me.btnNuevoArt.Text = "Incluir mesa"
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
        Me.selCuenta.Location = New System.Drawing.Point(85, 153)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCuenta.Size = New System.Drawing.Size(230, 23)
        Me.selCuenta.TabIndex = 32
        Me.selCuenta.TextWidth = 100
        '
        'lblCaja
        '
        Me.lblCaja.AutoSize = True
        Me.lblCaja.Location = New System.Drawing.Point(46, 129)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(28, 13)
        Me.lblCaja.TabIndex = 37
        Me.lblCaja.Text = "Caja"
        '
        'cboCaja
        '
        Me.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCaja.ItemsTable = Nothing
        Me.cboCaja.Location = New System.Drawing.Point(85, 126)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboCaja.Size = New System.Drawing.Size(359, 21)
        Me.cboCaja.TabIndex = 38
        Me.cboCaja.UIName = Nothing
        '
        'CentrosConsumoForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 439)
        Me.Controls.Add(Me.cboCaja)
        Me.Controls.Add(Me.lblCaja)
        Me.Controls.Add(Me.gbxDetalle)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.selCuenta)
        Me.Name = "CentrosConsumoForm"
        Me.Text = "CentrosConsumoForm"
        Me.Controls.SetChildIndex(Me.selCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblCuenta, 0)
        Me.Controls.SetChildIndex(Me.lblDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.gbxDetalle, 0)
        Me.Controls.SetChildIndex(Me.lblCaja, 0)
        Me.Controls.SetChildIndex(Me.cboCaja, 0)
        Me.gbxDetalle.ResumeLayout(False)
        Me.gbxDetalle.PerformLayout()
        CType(Me.grdMesas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMesa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbMenu.ResumeLayout(False)
        Me.tbMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New CentroConsumoFacade
    End Sub
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents txtDescripcion As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblDescripcion As Azteca.Windows.Controls.CILabel
    Friend WithEvents gbxDetalle As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdMesas As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents tbMenu As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnNuevoArt As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCaja As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboCaja As Azteca.Windows.Ventas.CajaCombobox
    Friend WithEvents bsMesa As System.Windows.Forms.BindingSource


End Class
