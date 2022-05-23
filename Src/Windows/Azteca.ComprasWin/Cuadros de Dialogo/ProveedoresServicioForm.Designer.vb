<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProveedoresServicioForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProveedoresServicioForm))
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdAgregarProveedor = New C1.Win.C1Command.C1Command()
        Me.cmdSetDefault = New C1.Win.C1Command.C1Command()
        Me.cmdAceptar = New C1.Win.C1Command.C1Command()
        Me.cmdCancelar = New C1.Win.C1Command.C1Command()
        Me.bsProveedores = New System.Windows.Forms.BindingSource(Me.components)
        Me.tlbMenu = New Azteca.Windows.Controls.AZToolBar()
        Me.btnAgregarProveedor = New C1.Win.C1Command.C1CommandLink()
        Me.btnSetDefault = New C1.Win.C1Command.C1CommandLink()
        Me.btnAceptar = New C1.Win.C1Command.C1CommandLink()
        Me.btnCancelar = New C1.Win.C1Command.C1CommandLink()
        Me.CiGroupBox1 = New Azteca.Windows.Controls.CIGroupBox()
        Me.lblServicio = New Azteca.Windows.Controls.CILabel()
        Me.lblZona = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.grdProveedores = New Azteca.Windows.Controls.DataGridViewCatalog()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CiGroupBox1.SuspendLayout()
        CType(Me.grdProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdAgregarProveedor)
        Me.C1CommandHolder1.Commands.Add(Me.cmdSetDefault)
        Me.C1CommandHolder1.Commands.Add(Me.cmdAceptar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCancelar)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdAgregarProveedor
        '
        Me.cmdAgregarProveedor.Image = CType(resources.GetObject("cmdAgregarProveedor.Image"), System.Drawing.Image)
        Me.cmdAgregarProveedor.Name = "cmdAgregarProveedor"
        Me.cmdAgregarProveedor.Text = "Agregar Proveedor"
        Me.cmdAgregarProveedor.ToolTipText = "Agregar proveedor que vende el mismo artículo"
        '
        'cmdSetDefault
        '
        Me.cmdSetDefault.Image = CType(resources.GetObject("cmdSetDefault.Image"), System.Drawing.Image)
        Me.cmdSetDefault.Name = "cmdSetDefault"
        Me.cmdSetDefault.Text = "Establecer Predeterminado"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Text = "Cancelar"
        '
        'tlbMenu
        '
        Me.tlbMenu.AccessibleName = "Tool Bar"
        Me.tlbMenu.AutoSize = False
        Me.tlbMenu.CommandHolder = Me.C1CommandHolder1
        Me.tlbMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnAgregarProveedor, Me.btnSetDefault, Me.btnAceptar, Me.btnCancelar})
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.MinButtonSize = 32
        Me.tlbMenu.Movable = False
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(727, 34)
        Me.tlbMenu.Text = "AzToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.System
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.System
        '
        'btnAgregarProveedor
        '
        Me.btnAgregarProveedor.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnAgregarProveedor.Command = Me.cmdAgregarProveedor
        '
        'btnSetDefault
        '
        Me.btnSetDefault.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnSetDefault.Command = Me.cmdSetDefault
        Me.btnSetDefault.SortOrder = 1
        Me.btnSetDefault.ToolTipText = "Establecer como proveedor predeterminado"
        '
        'btnAceptar
        '
        Me.btnAceptar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnAceptar.Command = Me.cmdAceptar
        Me.btnAceptar.Delimiter = True
        Me.btnAceptar.SortOrder = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnCancelar.Command = Me.cmdCancelar
        Me.btnCancelar.SortOrder = 3
        '
        'CiGroupBox1
        '
        Me.CiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CiGroupBox1.Controls.Add(Me.lblServicio)
        Me.CiGroupBox1.Controls.Add(Me.lblZona)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel1)
        Me.CiGroupBox1.Controls.Add(Me.CiLabel2)
        Me.CiGroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.CiGroupBox1.Name = "CiGroupBox1"
        Me.CiGroupBox1.Size = New System.Drawing.Size(703, 74)
        Me.CiGroupBox1.TabIndex = 41
        Me.CiGroupBox1.TabStop = False
        '
        'lblServicio
        '
        Me.lblServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicio.Location = New System.Drawing.Point(83, 16)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(557, 21)
        Me.lblServicio.TabIndex = 37
        Me.lblServicio.Text = "Servicio"
        Me.lblServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(18, 20)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(48, 13)
        Me.CiLabel1.TabIndex = 35
        Me.CiLabel1.Text = "Servicio:"
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
        'grdProveedores
        '
        Me.grdProveedores.AlternatingRows = True
        Me.grdProveedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProveedores.DataSource = Me.bsProveedores
        Me.grdProveedores.FilterBar = True
        Me.grdProveedores.IDCatalogField = "IdProveedor"
        Me.grdProveedores.Images.Add(CType(resources.GetObject("grdProveedores.Images"), System.Drawing.Image))
        Me.grdProveedores.Images.Add(CType(resources.GetObject("grdProveedores.Images1"), System.Drawing.Image))
        Me.grdProveedores.Location = New System.Drawing.Point(12, 120)
        Me.grdProveedores.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdProveedores.Name = "grdProveedores"
        Me.grdProveedores.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdProveedores.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdProveedores.PreviewInfo.ZoomFactor = 75.0R
        Me.grdProveedores.PrintInfo.PageSettings = CType(resources.GetObject("grdProveedores.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdProveedores.Size = New System.Drawing.Size(703, 306)
        Me.grdProveedores.TabIndex = 43
        Me.grdProveedores.Text = "DataGridViewCatalog1"
        Me.grdProveedores.PropBag = resources.GetString("grdProveedores.PropBag")
        '
        'ProveedoresServicioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 431)
        Me.Controls.Add(Me.grdProveedores)
        Me.Controls.Add(Me.CiGroupBox1)
        Me.Controls.Add(Me.tlbMenu)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProveedoresServicioForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Administración de proveedores proporcionando el servicio"
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CiGroupBox1.ResumeLayout(False)
        Me.CiGroupBox1.PerformLayout()
        CType(Me.grdProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdAgregarProveedor As C1.Win.C1Command.C1Command
    Friend WithEvents cmdSetDefault As C1.Win.C1Command.C1Command
    Friend WithEvents bsProveedores As System.Windows.Forms.BindingSource
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents btnAgregarProveedor As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnSetDefault As C1.Win.C1Command.C1CommandLink
    Friend WithEvents CiGroupBox1 As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents lblServicio As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblZona As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdProveedores As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents cmdAceptar As C1.Win.C1Command.C1Command
    Friend WithEvents cmdCancelar As C1.Win.C1Command.C1Command
    Friend WithEvents btnAceptar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnCancelar As C1.Win.C1Command.C1CommandLink
End Class
