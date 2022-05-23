<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditArticuloPresZonaForm
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditArticuloPresZonaForm))
        Me.tlbZonas = New Azteca.Windows.Controls.CIToolBar()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAgregarZona = New System.Windows.Forms.ToolStripButton()
        Me.lblCodigoDescr = New Azteca.Windows.Controls.CILabel()
        Me.grdZonas = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsZonas = New System.Windows.Forms.BindingSource(Me.components)
        Me.tlbZonas.SuspendLayout()
        CType(Me.grdZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlbZonas
        '
        Me.tlbZonas.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tlbZonas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuardar, Me.ToolStripSeparator1, Me.btnAgregarZona})
        Me.tlbZonas.Location = New System.Drawing.Point(0, 0)
        Me.tlbZonas.Name = "tlbZonas"
        Me.tlbZonas.Size = New System.Drawing.Size(627, 39)
        Me.tlbZonas.TabIndex = 2
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(135, 36)
        Me.btnGuardar.Text = "Guardar Cambios"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnAgregarZona
        '
        Me.btnAgregarZona.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.Zonas_add_32
        Me.btnAgregarZona.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregarZona.Name = "btnAgregarZona"
        Me.btnAgregarZona.Size = New System.Drawing.Size(115, 36)
        Me.btnAgregarZona.Text = "Agregar Zona"
        '
        'lblCodigoDescr
        '
        Me.lblCodigoDescr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodigoDescr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigoDescr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoDescr.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCodigoDescr.Location = New System.Drawing.Point(0, 39)
        Me.lblCodigoDescr.Name = "lblCodigoDescr"
        Me.lblCodigoDescr.Size = New System.Drawing.Size(627, 25)
        Me.lblCodigoDescr.TabIndex = 22
        Me.lblCodigoDescr.Text = "Codigo/Descripcion"
        Me.lblCodigoDescr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdZonas
        '
        Me.grdZonas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdZonas.DataSource = Me.bsZonas
        Me.grdZonas.FilterBar = True
        Me.grdZonas.IDCatalogField = "IdZonaVenta"
        Me.grdZonas.Images.Add(CType(resources.GetObject("grdZonas.Images"), System.Drawing.Image))
        Me.grdZonas.Location = New System.Drawing.Point(0, 67)
        Me.grdZonas.Name = "grdZonas"
        Me.grdZonas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdZonas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdZonas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdZonas.PrintInfo.PageSettings = CType(resources.GetObject("grdZonas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdZonas.Size = New System.Drawing.Size(627, 236)
        Me.grdZonas.TabIndex = 3
        Me.grdZonas.PropBag = resources.GetString("grdZonas.PropBag")
        '
        'EditArticuloPresZonaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 305)
        Me.Controls.Add(Me.lblCodigoDescr)
        Me.Controls.Add(Me.grdZonas)
        Me.Controls.Add(Me.tlbZonas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditArticuloPresZonaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Precios por Zona"
        Me.tlbZonas.ResumeLayout(False)
        Me.tlbZonas.PerformLayout()
        CType(Me.grdZonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsZonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlbZonas As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnAgregarZona As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdZonas As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents lblCodigoDescr As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsZonas As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
