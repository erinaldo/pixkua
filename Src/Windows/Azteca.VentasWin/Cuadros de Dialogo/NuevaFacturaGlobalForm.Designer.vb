<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaFacturaGlobalForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevaFacturaGlobalForm))
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdGenerar = New C1.Win.C1Command.C1Command()
        Me.cmdCancelar = New C1.Win.C1Command.C1Command()
        Me.cmdCargar = New C1.Win.C1Command.C1Command()
        Me.tlbMenu = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.bsVentas = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdVentas = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.dtpFecha = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.cboCaja = New Azteca.Windows.Ventas.CajaCombobox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdGenerar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCancelar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCargar)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdGenerar
        '
        Me.cmdGenerar.Enabled = False
        Me.cmdGenerar.Image = CType(resources.GetObject("cmdGenerar.Image"), System.Drawing.Image)
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.ShortcutText = ""
        Me.cmdGenerar.Text = "Generar"
        Me.cmdGenerar.ToolTipText = "Generar factura global del período cargado"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.ShortcutText = ""
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdCargar
        '
        Me.cmdCargar.Image = CType(resources.GetObject("cmdCargar.Image"), System.Drawing.Image)
        Me.cmdCargar.Name = "cmdCargar"
        Me.cmdCargar.ShortcutText = ""
        Me.cmdCargar.Text = "Cargar"
        Me.cmdCargar.ToolTipText = "Cargar venta no facturada de la fecha seleccionada"
        '
        'tlbMenu
        '
        Me.tlbMenu.AccessibleName = "Tool Bar"
        Me.tlbMenu.AutoSize = False
        Me.tlbMenu.CommandHolder = Me.C1CommandHolder1
        Me.tlbMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink3, Me.C1CommandLink2, Me.C1CommandLink1})
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.MinButtonSize = 32
        Me.tlbMenu.Movable = False
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(772, 32)
        Me.tlbMenu.Text = "AzToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.cmdCargar
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.cmdGenerar
        Me.C1CommandLink2.SortOrder = 1
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.cmdCancelar
        Me.C1CommandLink1.SortOrder = 2
        '
        'grdVentas
        '
        Me.grdVentas.AllowUpdate = False
        Me.grdVentas.AlternatingRows = True
        Me.grdVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdVentas.ColumnFooters = True
        Me.grdVentas.DataSource = Me.bsVentas
        Me.grdVentas.FilterBar = True
        Me.grdVentas.Images.Add(CType(resources.GetObject("grdVentas.Images"), System.Drawing.Image))
        Me.grdVentas.Location = New System.Drawing.Point(0, 64)
        Me.grdVentas.Name = "grdVentas"
        Me.grdVentas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdVentas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdVentas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdVentas.PrintInfo.PageSettings = CType(resources.GetObject("grdVentas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdVentas.Size = New System.Drawing.Size(772, 440)
        Me.grdVentas.TabIndex = 5
        Me.grdVentas.Text = "AzTrueDBGrid1"
        Me.grdVentas.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        Me.grdVentas.PropBag = resources.GetString("grdVentas.PropBag")
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(12, 40)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(40, 13)
        Me.CiLabel1.TabIndex = 6
        Me.CiLabel1.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFecha.Location = New System.Drawing.Point(58, 37)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 7
        Me.dtpFecha.Value = New Date(2013, 4, 2, 0, 0, 0, 0)
        '
        'cboCaja
        '
        Me.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCaja.ItemsTable = Nothing
        Me.cboCaja.Location = New System.Drawing.Point(301, 37)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.Size = New System.Drawing.Size(213, 21)
        Me.cboCaja.TabIndex = 9
        Me.cboCaja.UIName = Nothing
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(264, 40)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(31, 13)
        Me.CiLabel2.TabIndex = 10
        Me.CiLabel2.Text = "Caja:"
        '
        'NuevaFacturaGlobalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 506)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.cboCaja)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.grdVentas)
        Me.Controls.Add(Me.tlbMenu)
        Me.Name = "NuevaFacturaGlobalForm"
        Me.Text = "Nueva Factura Global"
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdGenerar As C1.Win.C1Command.C1Command
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents bsVentas As System.Windows.Forms.BindingSource
    Friend WithEvents grdVentas As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFecha As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents cmdCancelar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdCargar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboCaja As Azteca.Windows.Ventas.CajaCombobox
End Class
