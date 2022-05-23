<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PresupuestosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PresupuestosForm))
        Me.trvwDepartamentos = New Azteca.Windows.Controls.HierarchyViewer()
        Me.grdPresupuesto = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsPresupuesto = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbxPresupuesto = New Azteca.Windows.Controls.CIGroupBox()
        Me.lblNoPresupuesto = New System.Windows.Forms.Label()
        Me.gbxGlobal = New Azteca.Windows.Controls.CIGroupBox()
        Me.txtDisponible = New Azteca.Windows.Controls.CILabel()
        Me.txtApartado = New Azteca.Windows.Controls.CILabel()
        Me.txtUtilizado = New Azteca.Windows.Controls.CILabel()
        Me.lblDisponible = New Azteca.Windows.Controls.CILabel()
        Me.lblApartado = New Azteca.Windows.Controls.CILabel()
        Me.lblUtilizado = New Azteca.Windows.Controls.CILabel()
        Me.txtPresupuestado = New Azteca.Windows.Controls.CITextBox()
        Me.lblPresupuestado = New Azteca.Windows.Controls.CILabel()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.tbPresupuesto = New Azteca.Windows.Controls.CIToolBar()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.gbxDeptoPeriodo = New Azteca.Windows.Controls.CIGroupBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblPresupuestoEsta = New System.Windows.Forms.ToolStripLabel()
        Me.btnStatus = New System.Windows.Forms.ToolStripLabel()
        Me.cboPeriodo = New Azteca.Windows.Compras.PeriodoComboBox()
        Me.btnAutorizar = New System.Windows.Forms.ToolStripButton()
        CType(Me.grdPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPresupuesto.SuspendLayout()
        Me.gbxGlobal.SuspendLayout()
        Me.tbPresupuesto.SuspendLayout()
        Me.gbxDeptoPeriodo.SuspendLayout()
        Me.SuspendLayout()
        '
        'trvwDepartamentos
        '
        Me.trvwDepartamentos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvwDepartamentos.HideSelection = False
        Me.trvwDepartamentos.Location = New System.Drawing.Point(8, 54)
        Me.trvwDepartamentos.Name = "trvwDepartamentos"
        Me.trvwDepartamentos.Size = New System.Drawing.Size(224, 336)
        Me.trvwDepartamentos.TabIndex = 0
        '
        'grdPresupuesto
        '
        Me.grdPresupuesto.ColumnFooters = True
        Me.grdPresupuesto.DataSource = Me.bsPresupuesto
        Me.grdPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPresupuesto.Images.Add(CType(resources.GetObject("grdPresupuesto.Images"), System.Drawing.Image))
        Me.grdPresupuesto.Location = New System.Drawing.Point(10, 78)
        Me.grdPresupuesto.Name = "grdPresupuesto"
        Me.grdPresupuesto.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdPresupuesto.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdPresupuesto.PreviewInfo.ZoomFactor = 75.0R
        Me.grdPresupuesto.PrintInfo.PageSettings = CType(resources.GetObject("grdPresupuesto.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdPresupuesto.Size = New System.Drawing.Size(671, 309)
        Me.grdPresupuesto.TabIndex = 2
        Me.grdPresupuesto.Text = "AzTrueDBGrid1"
        Me.grdPresupuesto.Visible = False
        Me.grdPresupuesto.PropBag = resources.GetString("grdPresupuesto.PropBag")
        '
        'gbxPresupuesto
        '
        Me.gbxPresupuesto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxPresupuesto.BackColor = System.Drawing.SystemColors.Control
        Me.gbxPresupuesto.Controls.Add(Me.lblNoPresupuesto)
        Me.gbxPresupuesto.Controls.Add(Me.gbxGlobal)
        Me.gbxPresupuesto.Controls.Add(Me.grdPresupuesto)
        Me.gbxPresupuesto.Controls.Add(Me.lblDepartamento)
        Me.gbxPresupuesto.Controls.Add(Me.tbPresupuesto)
        Me.gbxPresupuesto.Location = New System.Drawing.Point(245, 14)
        Me.gbxPresupuesto.Name = "gbxPresupuesto"
        Me.gbxPresupuesto.Padding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.gbxPresupuesto.Size = New System.Drawing.Size(691, 397)
        Me.gbxPresupuesto.TabIndex = 3
        Me.gbxPresupuesto.TabStop = False
        '
        'lblNoPresupuesto
        '
        Me.lblNoPresupuesto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoPresupuesto.AutoEllipsis = True
        Me.lblNoPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoPresupuesto.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblNoPresupuesto.Location = New System.Drawing.Point(33, 233)
        Me.lblNoPresupuesto.Name = "lblNoPresupuesto"
        Me.lblNoPresupuesto.Size = New System.Drawing.Size(631, 20)
        Me.lblNoPresupuesto.TabIndex = 5
        Me.lblNoPresupuesto.Text = "No se administra Presupuesto para este departamento"
        Me.lblNoPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNoPresupuesto.Visible = False
        '
        'gbxGlobal
        '
        Me.gbxGlobal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxGlobal.Controls.Add(Me.txtDisponible)
        Me.gbxGlobal.Controls.Add(Me.txtApartado)
        Me.gbxGlobal.Controls.Add(Me.txtUtilizado)
        Me.gbxGlobal.Controls.Add(Me.lblDisponible)
        Me.gbxGlobal.Controls.Add(Me.lblApartado)
        Me.gbxGlobal.Controls.Add(Me.lblUtilizado)
        Me.gbxGlobal.Controls.Add(Me.txtPresupuestado)
        Me.gbxGlobal.Controls.Add(Me.lblPresupuestado)
        Me.gbxGlobal.Location = New System.Drawing.Point(30, 96)
        Me.gbxGlobal.Name = "gbxGlobal"
        Me.gbxGlobal.Size = New System.Drawing.Size(634, 179)
        Me.gbxGlobal.TabIndex = 6
        Me.gbxGlobal.TabStop = False
        Me.gbxGlobal.Visible = False
        '
        'txtDisponible
        '
        Me.txtDisponible.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtDisponible.Location = New System.Drawing.Point(280, 114)
        Me.txtDisponible.Name = "txtDisponible"
        Me.txtDisponible.Size = New System.Drawing.Size(107, 20)
        Me.txtDisponible.TabIndex = 7
        Me.txtDisponible.Text = "0.00"
        Me.txtDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtApartado
        '
        Me.txtApartado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtApartado.Location = New System.Drawing.Point(280, 90)
        Me.txtApartado.Name = "txtApartado"
        Me.txtApartado.Size = New System.Drawing.Size(107, 20)
        Me.txtApartado.TabIndex = 6
        Me.txtApartado.Text = "0.00"
        Me.txtApartado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUtilizado
        '
        Me.txtUtilizado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtUtilizado.Location = New System.Drawing.Point(280, 67)
        Me.txtUtilizado.Name = "txtUtilizado"
        Me.txtUtilizado.Size = New System.Drawing.Size(107, 20)
        Me.txtUtilizado.TabIndex = 5
        Me.txtUtilizado.Text = "0.00"
        Me.txtUtilizado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDisponible
        '
        Me.lblDisponible.AutoSize = True
        Me.lblDisponible.Location = New System.Drawing.Point(220, 117)
        Me.lblDisponible.Name = "lblDisponible"
        Me.lblDisponible.Size = New System.Drawing.Size(56, 13)
        Me.lblDisponible.TabIndex = 4
        Me.lblDisponible.Text = "Disponible"
        '
        'lblApartado
        '
        Me.lblApartado.AutoSize = True
        Me.lblApartado.Location = New System.Drawing.Point(226, 93)
        Me.lblApartado.Name = "lblApartado"
        Me.lblApartado.Size = New System.Drawing.Size(50, 13)
        Me.lblApartado.TabIndex = 3
        Me.lblApartado.Text = "Apartado"
        '
        'lblUtilizado
        '
        Me.lblUtilizado.AutoSize = True
        Me.lblUtilizado.Location = New System.Drawing.Point(229, 70)
        Me.lblUtilizado.Name = "lblUtilizado"
        Me.lblUtilizado.Size = New System.Drawing.Size(47, 13)
        Me.lblUtilizado.TabIndex = 2
        Me.lblUtilizado.Text = "Utilizado"
        '
        'txtPresupuestado
        '
        Me.txtPresupuestado.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtPresupuestado.Digits = True
        Me.txtPresupuestado.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtPresupuestado.Enabled = False
        Me.txtPresupuestado.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPresupuestado.Location = New System.Drawing.Point(280, 44)
        Me.txtPresupuestado.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPresupuestado.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPresupuestado.Name = "txtPresupuestado"
        Me.txtPresupuestado.Size = New System.Drawing.Size(107, 20)
        Me.txtPresupuestado.TabIndex = 1
        '
        'lblPresupuestado
        '
        Me.lblPresupuestado.AutoSize = True
        Me.lblPresupuestado.Location = New System.Drawing.Point(198, 47)
        Me.lblPresupuestado.Name = "lblPresupuestado"
        Me.lblPresupuestado.Size = New System.Drawing.Size(78, 13)
        Me.lblPresupuestado.TabIndex = 0
        Me.lblPresupuestado.Text = "Presupuestado"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.BackColor = System.Drawing.SystemColors.Control
        Me.lblDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDepartamento.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDepartamento.Location = New System.Drawing.Point(10, 52)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(671, 26)
        Me.lblDepartamento.TabIndex = 5
        Me.lblDepartamento.Text = "Departamento"
        Me.lblDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbPresupuesto
        '
        Me.tbPresupuesto.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbPresupuesto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnImprimir, Me.ToolStripSeparator2, Me.btnConsultar, Me.ToolStripSeparator1, Me.btnGuardar, Me.ToolStripSeparator3, Me.lblPresupuestoEsta, Me.btnStatus, Me.btnAutorizar})
        Me.tbPresupuesto.Location = New System.Drawing.Point(10, 13)
        Me.tbPresupuesto.Name = "tbPresupuesto"
        Me.tbPresupuesto.Size = New System.Drawing.Size(671, 39)
        Me.tbPresupuesto.TabIndex = 3
        Me.tbPresupuesto.Text = "CiToolBar1"
        '
        'btnImprimir
        '
        Me.btnImprimir.AccessibleDescription = "Imprimir"
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(89, 36)
        Me.btnImprimir.Text = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(94, 36)
        Me.btnConsultar.Text = "Consultar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 36)
        Me.btnGuardar.Text = "Guardar"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Location = New System.Drawing.Point(10, 12)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(43, 13)
        Me.lblPeriodo.TabIndex = 4
        Me.lblPeriodo.Text = "Periodo"
        '
        'gbxDeptoPeriodo
        '
        Me.gbxDeptoPeriodo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbxDeptoPeriodo.Controls.Add(Me.cboPeriodo)
        Me.gbxDeptoPeriodo.Controls.Add(Me.lblPeriodo)
        Me.gbxDeptoPeriodo.Controls.Add(Me.trvwDepartamentos)
        Me.gbxDeptoPeriodo.Location = New System.Drawing.Point(1, 14)
        Me.gbxDeptoPeriodo.Name = "gbxDeptoPeriodo"
        Me.gbxDeptoPeriodo.Size = New System.Drawing.Size(242, 397)
        Me.gbxDeptoPeriodo.TabIndex = 7
        Me.gbxDeptoPeriodo.TabStop = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'lblPresupuestoEsta
        '
        Me.lblPresupuestoEsta.Name = "lblPresupuestoEsta"
        Me.lblPresupuestoEsta.Size = New System.Drawing.Size(111, 36)
        Me.lblPresupuestoEsta.Text = "El presupuesto esta:"
        '
        'btnStatus
        '
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(0, 36)
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboPeriodo.ItemsTable = Nothing
        Me.cboPeriodo.Location = New System.Drawing.Point(6, 28)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboPeriodo.Size = New System.Drawing.Size(226, 21)
        Me.cboPeriodo.TabIndex = 1
        Me.cboPeriodo.UIName = Nothing
        '
        'btnAutorizar
        '
        Me.btnAutorizar.Image = CType(resources.GetObject("btnAutorizar.Image"), System.Drawing.Image)
        Me.btnAutorizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAutorizar.Name = "btnAutorizar"
        Me.btnAutorizar.Size = New System.Drawing.Size(91, 36)
        Me.btnAutorizar.Text = "Autorizar"
        '
        'PresupuestosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 428)
        Me.Controls.Add(Me.gbxDeptoPeriodo)
        Me.Controls.Add(Me.gbxPresupuesto)
        Me.Name = "PresupuestosForm"
        Me.Text = "PresupuestosForm"
        CType(Me.grdPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPresupuesto.ResumeLayout(False)
        Me.gbxPresupuesto.PerformLayout()
        Me.gbxGlobal.ResumeLayout(False)
        Me.gbxGlobal.PerformLayout()
        Me.tbPresupuesto.ResumeLayout(False)
        Me.tbPresupuesto.PerformLayout()
        Me.gbxDeptoPeriodo.ResumeLayout(False)
        Me.gbxDeptoPeriodo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents trvwDepartamentos As Azteca.Windows.Controls.HierarchyViewer
    Friend WithEvents cboPeriodo As Azteca.Windows.Compras.PeriodoComboBox
    Friend WithEvents grdPresupuesto As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents gbxPresupuesto As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents tbPresupuesto As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton

    Friend WithEvents gbxGlobal As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents txtDisponible As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtApartado As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtUtilizado As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblDisponible As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblApartado As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblUtilizado As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtPresupuestado As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblPresupuestado As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblNoPresupuesto As System.Windows.Forms.Label
    Friend WithEvents bsPresupuesto As System.Windows.Forms.BindingSource
    Friend WithEvents gbxDeptoPeriodo As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblPresupuestoEsta As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnStatus As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnAutorizar As System.Windows.Forms.ToolStripButton

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LicenseModule = Kernel.Licensing.LicenseModule.Purchasing
    End Sub
End Class
