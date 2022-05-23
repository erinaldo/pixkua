<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProveedoresCFDsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProveedoresCFDsForm))
        Me.lblProveedorServ = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaIni = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaFin = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.lblFechaIni = New Azteca.Windows.Controls.CILabel()
        Me.tbMenu = New Azteca.Windows.Controls.CIToolBar()
        Me.btnRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.grdComprobantes = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsComprobantes = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbxFiltros = New Azteca.Windows.Controls.CIGroupBox()
        Me.selProveedor = New Azteca.Windows.Compras.ProveedoresSelector()
        Me.tbMenu.SuspendLayout()
        CType(Me.grdComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProveedorServ
        '
        Me.lblProveedorServ.AutoSize = True
        Me.lblProveedorServ.Location = New System.Drawing.Point(22, 30)
        Me.lblProveedorServ.Name = "lblProveedorServ"
        Me.lblProveedorServ.Size = New System.Drawing.Size(56, 13)
        Me.lblProveedorServ.TabIndex = 67
        Me.lblProveedorServ.Text = "Proveedor"
        '
        'CiLabel1
        '
        Me.CiLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CiLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CiLabel1.Location = New System.Drawing.Point(0, 39)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(626, 21)
        Me.CiLabel1.TabIndex = 68
        Me.CiLabel1.Text = "Lista de Comprobantes Fiscales Digitales recibidos"
        Me.CiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaIni.Location = New System.Drawing.Point(90, 59)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(211, 20)
        Me.dtpFechaIni.TabIndex = 69
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(330, 63)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(65, 13)
        Me.CiLabel2.TabIndex = 72
        Me.CiLabel2.Text = "Fecha Final:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaFin.Location = New System.Drawing.Point(401, 59)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(210, 20)
        Me.dtpFechaFin.TabIndex = 71
        '
        'lblFechaIni
        '
        Me.lblFechaIni.AutoSize = True
        Me.lblFechaIni.Location = New System.Drawing.Point(14, 63)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(70, 13)
        Me.lblFechaIni.TabIndex = 70
        Me.lblFechaIni.Text = "Fecha Inicial:"
        '
        'tbMenu
        '
        Me.tbMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefrescar, Me.ToolStripSeparator1, Me.btnAceptar, Me.ToolStripSeparator3, Me.btnCancelar})
        Me.tbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tbMenu.Name = "tbMenu"
        Me.tbMenu.Size = New System.Drawing.Size(626, 39)
        Me.tbMenu.TabIndex = 73
        Me.tbMenu.Text = "CiToolBar1"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Image = CType(resources.GetObject("btnRefrescar.Image"), System.Drawing.Image)
        Me.btnRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(91, 36)
        Me.btnRefrescar.Text = "Refrescar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(84, 36)
        Me.btnAceptar.Text = "Aceptar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(89, 36)
        Me.btnCancelar.Text = "Cancelar"
        '
        'grdComprobantes
        '
        Me.grdComprobantes.AllowUpdate = False
        Me.grdComprobantes.AlternatingRows = True
        Me.grdComprobantes.DataSource = Me.bsComprobantes
        Me.grdComprobantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdComprobantes.FilterBar = True
        Me.grdComprobantes.Images.Add(CType(resources.GetObject("grdComprobantes.Images"), System.Drawing.Image))
        Me.grdComprobantes.Location = New System.Drawing.Point(0, 153)
        Me.grdComprobantes.Name = "grdComprobantes"
        Me.grdComprobantes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdComprobantes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdComprobantes.PreviewInfo.ZoomFactor = 75.0R
        Me.grdComprobantes.PrintInfo.PageSettings = CType(resources.GetObject("grdComprobantes.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdComprobantes.Size = New System.Drawing.Size(626, 294)
        Me.grdComprobantes.TabIndex = 74
        Me.grdComprobantes.Text = "AzTrueDBGrid1"
        Me.grdComprobantes.PropBag = resources.GetString("grdComprobantes.PropBag")
        '
        'gbxFiltros
        '
        Me.gbxFiltros.Controls.Add(Me.selProveedor)
        Me.gbxFiltros.Controls.Add(Me.lblProveedorServ)
        Me.gbxFiltros.Controls.Add(Me.lblFechaIni)
        Me.gbxFiltros.Controls.Add(Me.CiLabel2)
        Me.gbxFiltros.Controls.Add(Me.dtpFechaFin)
        Me.gbxFiltros.Controls.Add(Me.dtpFechaIni)
        Me.gbxFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbxFiltros.Location = New System.Drawing.Point(0, 60)
        Me.gbxFiltros.Name = "gbxFiltros"
        Me.gbxFiltros.Size = New System.Drawing.Size(626, 93)
        Me.gbxFiltros.TabIndex = 75
        Me.gbxFiltros.TabStop = False
        '
        'selProveedor
        '
        Me.selProveedor.AnySite = False
        Me.selProveedor.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selProveedor.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selProveedor.EditorAssembly = "Azteca.ComprasWin"
        Me.selProveedor.EditorClass = "Azteca.Windows.Compras.ProveedoresForm"
        Me.selProveedor.EditorTitle = "Editar proveedores..."
        Me.selProveedor.Key = 0
        Me.selProveedor.Linked = False
        Me.selProveedor.Location = New System.Drawing.Point(90, 30)
        Me.selProveedor.Name = "selProveedor"
        Me.selProveedor.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selProveedor.Size = New System.Drawing.Size(521, 23)
        Me.selProveedor.TabIndex = 0
        '
        'ProveedoresCFDsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 447)
        Me.Controls.Add(Me.grdComprobantes)
        Me.Controls.Add(Me.gbxFiltros)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.tbMenu)
        Me.Name = "ProveedoresCFDsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobantes Fiscales..."
        Me.tbMenu.ResumeLayout(False)
        Me.tbMenu.PerformLayout()
        CType(Me.grdComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxFiltros.ResumeLayout(False)
        Me.gbxFiltros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents selProveedor As Azteca.Windows.Compras.ProveedoresSelector
    Friend WithEvents lblProveedorServ As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaIni As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaFin As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents lblFechaIni As Azteca.Windows.Controls.CILabel
    Friend WithEvents tbMenu As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdComprobantes As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsComprobantes As System.Windows.Forms.BindingSource
    Friend WithEvents gbxFiltros As Azteca.Windows.Controls.CIGroupBox
End Class
