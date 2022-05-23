<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImpresionCorteForm
    Inherits Azteca.Windows.Forms.BaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImpresionCorteForm))
        Me.dtpFechaIni = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.dtpFechaFin = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.lblCaja = New Azteca.Windows.Controls.CILabel()
        Me.lblDesde = New Azteca.Windows.Controls.CILabel()
        Me.lblHasta = New Azteca.Windows.Controls.CILabel()
        Me.tlbMenu = New Azteca.Windows.Controls.CIToolBar()
        Me.btnVerCortes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImpresionCorte = New System.Windows.Forms.ToolStripButton()
        Me.btnDetalleCorte = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.grdCortes = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsCortes = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalir = New Azteca.Windows.Controls.CIButton()
        Me.tlbMenu.SuspendLayout()
        CType(Me.grdCortes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCortes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaIni.Location = New System.Drawing.Point(74, 85)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(197, 20)
        Me.dtpFechaIni.TabIndex = 1
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaFin.Location = New System.Drawing.Point(352, 85)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(197, 20)
        Me.dtpFechaFin.TabIndex = 2
        '
        'lblCaja
        '
        Me.lblCaja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCaja.ForeColor = System.Drawing.Color.Red
        Me.lblCaja.Location = New System.Drawing.Point(30, 51)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(519, 23)
        Me.lblCaja.TabIndex = 14
        Me.lblCaja.Text = "Descripcion de la caja"
        Me.lblCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(30, 88)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(38, 13)
        Me.lblDesde.TabIndex = 15
        Me.lblDesde.Text = "Desde"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(311, 88)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(35, 13)
        Me.lblHasta.TabIndex = 16
        Me.lblHasta.Text = "Hasta"
        '
        'tlbMenu
        '
        Me.tlbMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tlbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnVerCortes, Me.ToolStripSeparator1, Me.btnImpresionCorte, Me.btnDetalleCorte, Me.ToolStripSeparator3})
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(589, 39)
        Me.tlbMenu.TabIndex = 17
        Me.tlbMenu.Text = "CiToolBar1"
        '
        'btnVerCortes
        '
        Me.btnVerCortes.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.Informe
        Me.btnVerCortes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVerCortes.Name = "btnVerCortes"
        Me.btnVerCortes.Size = New System.Drawing.Size(120, 36)
        Me.btnVerCortes.Text = "Lista de Cortes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnImpresionCorte
        '
        Me.btnImpresionCorte.Image = CType(resources.GetObject("btnImpresionCorte.Image"), System.Drawing.Image)
        Me.btnImpresionCorte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImpresionCorte.Name = "btnImpresionCorte"
        Me.btnImpresionCorte.Size = New System.Drawing.Size(131, 36)
        Me.btnImpresionCorte.Text = "Impresión  Corte"
        '
        'btnDetalleCorte
        '
        Me.btnDetalleCorte.Image = CType(resources.GetObject("btnDetalleCorte.Image"), System.Drawing.Image)
        Me.btnDetalleCorte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDetalleCorte.Name = "btnDetalleCorte"
        Me.btnDetalleCorte.Size = New System.Drawing.Size(123, 36)
        Me.btnDetalleCorte.Text = "Mostrar Detalle"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'grdCortes
        '
        Me.grdCortes.DataSource = Me.bsCortes
        Me.grdCortes.Images.Add(CType(resources.GetObject("grdCortes.Images"), System.Drawing.Image))
        Me.grdCortes.Location = New System.Drawing.Point(12, 121)
        Me.grdCortes.Name = "grdCortes"
        Me.grdCortes.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdCortes.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdCortes.PreviewInfo.ZoomFactor = 75.0R
        Me.grdCortes.PrintInfo.PageSettings = CType(resources.GetObject("grdCortes.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdCortes.Size = New System.Drawing.Size(565, 268)
        Me.grdCortes.TabIndex = 18
        Me.grdCortes.Text = "AzTrueDBGrid1"
        Me.grdCortes.PropBag = resources.GetString("grdCortes.PropBag")
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(472, 5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(78, 37)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'ImpresionCorteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 401)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.grdCortes)
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.lblHasta)
        Me.Controls.Add(Me.lblDesde)
        Me.Controls.Add(Me.lblCaja)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.dtpFechaIni)
        Me.Name = "ImpresionCorteForm"
        Me.Text = "Cortes relacionados con la caja..."
        Me.tlbMenu.ResumeLayout(False)
        Me.tlbMenu.PerformLayout()
        CType(Me.grdCortes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCortes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFechaIni As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents dtpFechaFin As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents lblCaja As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblDesde As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblHasta As Azteca.Windows.Controls.CILabel
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnVerCortes As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grdCortes As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsCortes As System.Windows.Forms.BindingSource
    Friend WithEvents btnImpresionCorte As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDetalleCorte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSalir As Azteca.Windows.Controls.CIButton
End Class
