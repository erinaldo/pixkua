<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticulosProveedorForm
    Inherits Azteca.Windows.Forms.BaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArticulosProveedorForm))
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.lblProveedor = New Azteca.Windows.Controls.CILabel()
        Me.lblZona = New Azteca.Windows.Controls.CILabel()
        Me.grpProveedor = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdArticulos = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsArticulos = New System.Windows.Forms.BindingSource(Me.components)
        Me.tlbMenu = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdAgregarArticulo = New C1.Win.C1Command.C1Command()
        Me.cmdAceptar = New C1.Win.C1Command.C1Command()
        Me.cmdCancelar = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.grpProveedor.SuspendLayout()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(18, 20)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(59, 13)
        Me.CiLabel1.TabIndex = 35
        Me.CiLabel1.Text = "Proveedor:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(18, 44)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(35, 13)
        Me.CiLabel2.TabIndex = 36
        Me.CiLabel2.Text = "Zona:"
        '
        'lblProveedor
        '
        Me.lblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.Location = New System.Drawing.Point(83, 16)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(557, 21)
        Me.lblProveedor.TabIndex = 37
        Me.lblProveedor.Text = "Proveedor"
        Me.lblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblZona
        '
        Me.lblZona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZona.Location = New System.Drawing.Point(83, 40)
        Me.lblZona.Name = "lblZona"
        Me.lblZona.Size = New System.Drawing.Size(557, 21)
        Me.lblZona.TabIndex = 38
        Me.lblZona.Text = "Zona"
        Me.lblZona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpProveedor
        '
        Me.grpProveedor.Controls.Add(Me.lblProveedor)
        Me.grpProveedor.Controls.Add(Me.lblZona)
        Me.grpProveedor.Controls.Add(Me.CiLabel1)
        Me.grpProveedor.Controls.Add(Me.CiLabel2)
        Me.grpProveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpProveedor.Location = New System.Drawing.Point(0, 34)
        Me.grpProveedor.Name = "grpProveedor"
        Me.grpProveedor.Size = New System.Drawing.Size(803, 74)
        Me.grpProveedor.TabIndex = 39
        Me.grpProveedor.TabStop = False
        '
        'grdArticulos
        '
        Me.grdArticulos.AlternatingRows = True
        Me.grdArticulos.DataSource = Me.bsArticulos
        Me.grdArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdArticulos.FilterBar = True
        Me.grdArticulos.IDCatalogField = "IdArticuloStock"
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images"), System.Drawing.Image))
        Me.grdArticulos.Location = New System.Drawing.Point(0, 108)
        Me.grdArticulos.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdArticulos.Name = "grdArticulos"
        Me.grdArticulos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdArticulos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdArticulos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdArticulos.PrintInfo.PageSettings = CType(resources.GetObject("grdArticulos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdArticulos.Size = New System.Drawing.Size(803, 347)
        Me.grdArticulos.TabIndex = 34
        Me.grdArticulos.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdArticulos.PropBag = resources.GetString("grdArticulos.PropBag")
        '
        'tlbMenu
        '
        Me.tlbMenu.AccessibleName = "Tool Bar"
        Me.tlbMenu.AutoSize = False
        Me.tlbMenu.CommandHolder = Me.C1CommandHolder1
        Me.tlbMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink2, Me.C1CommandLink3})
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.MinButtonSize = 32
        Me.tlbMenu.Movable = False
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(803, 34)
        Me.tlbMenu.Text = "AzToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdAgregarArticulo)
        Me.C1CommandHolder1.Commands.Add(Me.cmdAceptar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCancelar)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdAgregarArticulo
        '
        Me.cmdAgregarArticulo.Image = CType(resources.GetObject("cmdAgregarArticulo.Image"), System.Drawing.Image)
        Me.cmdAgregarArticulo.Name = "cmdAgregarArticulo"
        Me.cmdAgregarArticulo.ShortcutText = ""
        Me.cmdAgregarArticulo.Text = "Agregar Artículo"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.ShortcutText = ""
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.ShortcutText = ""
        Me.cmdCancelar.Text = "Cancelar"
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.cmdAgregarArticulo
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.cmdAceptar
        Me.C1CommandLink2.Delimiter = True
        Me.C1CommandLink2.SortOrder = 1
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.cmdCancelar
        Me.C1CommandLink3.SortOrder = 2
        '
        'ArticulosProveedorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 455)
        Me.Controls.Add(Me.grdArticulos)
        Me.Controls.Add(Me.grpProveedor)
        Me.Controls.Add(Me.tlbMenu)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ArticulosProveedorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Administración de artículos vendidos por el proveedor"
        Me.grpProveedor.ResumeLayout(False)
        Me.grpProveedor.PerformLayout()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdArticulos As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblProveedor As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblZona As Azteca.Windows.Controls.CILabel
    Friend WithEvents grpProveedor As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdAgregarArticulo As C1.Win.C1Command.C1Command
    Friend WithEvents cmdAceptar As C1.Win.C1Command.C1Command
    Friend WithEvents cmdCancelar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Private WithEvents bsArticulos As System.Windows.Forms.BindingSource
End Class
