<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RacWorkflowForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RacWorkflowForm))
        Me.gbxCondiciones = New Azteca.Windows.Controls.CIGroupBox()
        Me.tabCombinaciones = New Azteca.Windows.Controls.CITab()
        Me.tabEntidades = New System.Windows.Forms.TabPage()
        Me.grdEntidades = New Azteca.Windows.Controls.CIDataGridView()
        Me.colSEL = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colEntidad = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tbEntidades = New Azteca.Windows.Controls.CIToolBar()
        Me.btnActualizarEntidad = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardarEntidad = New System.Windows.Forms.ToolStripButton()
        Me.lblEntidades = New Azteca.Windows.Controls.CILabel()
        Me.tabCombinacion = New System.Windows.Forms.TabPage()
        Me.grdFiltros = New Azteca.Windows.Controls.CIDataGridView()
        Me.colRac = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tbCombinacion = New Azteca.Windows.Controls.CIToolBar()
        Me.btnActualizarComb = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardarComb = New System.Windows.Forms.ToolStripButton()
        Me.lblFiltros = New Azteca.Windows.Controls.CILabel()
        Me.iLstTab = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.gbxCondiciones.SuspendLayout()
        Me.tabCombinaciones.SuspendLayout()
        Me.tabEntidades.SuspendLayout()
        CType(Me.grdEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbEntidades.SuspendLayout()
        Me.tabCombinacion.SuspendLayout()
        CType(Me.grdFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCombinacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxCondiciones
        '
        Me.gbxCondiciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxCondiciones.Controls.Add(Me.tabCombinaciones)
        Me.gbxCondiciones.Location = New System.Drawing.Point(29, 12)
        Me.gbxCondiciones.Name = "gbxCondiciones"
        Me.gbxCondiciones.Size = New System.Drawing.Size(591, 345)
        Me.gbxCondiciones.TabIndex = 3
        Me.gbxCondiciones.TabStop = False
        '
        'tabCombinaciones
        '
        Me.tabCombinaciones.Controls.Add(Me.tabEntidades)
        Me.tabCombinaciones.Controls.Add(Me.tabCombinacion)
        Me.tabCombinaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCombinaciones.ImageList = Me.iLstTab
        Me.tabCombinaciones.Location = New System.Drawing.Point(3, 16)
        Me.tabCombinaciones.Name = "tabCombinaciones"
        Me.tabCombinaciones.SelectedIndex = 0
        Me.tabCombinaciones.Size = New System.Drawing.Size(585, 326)
        Me.tabCombinaciones.TabIndex = 1
        '
        'tabEntidades
        '
        Me.tabEntidades.Controls.Add(Me.grdEntidades)
        Me.tabEntidades.Controls.Add(Me.tbEntidades)
        Me.tabEntidades.Controls.Add(Me.lblEntidades)
        Me.tabEntidades.ImageIndex = 0
        Me.tabEntidades.Location = New System.Drawing.Point(4, 39)
        Me.tabEntidades.Name = "tabEntidades"
        Me.tabEntidades.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEntidades.Size = New System.Drawing.Size(577, 283)
        Me.tabEntidades.TabIndex = 0
        Me.tabEntidades.Text = "Entidades "
        Me.tabEntidades.UseVisualStyleBackColor = True
        '
        'grdEntidades
        '
        Me.grdEntidades.AllowUserToAddRows = False
        Me.grdEntidades.AllowUserToDeleteRows = False
        Me.grdEntidades.BackgroundColor = System.Drawing.Color.White
        Me.grdEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEntidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSEL, Me.colEntidad})
        Me.grdEntidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdEntidades.Location = New System.Drawing.Point(3, 76)
        Me.grdEntidades.Name = "grdEntidades"
        Me.grdEntidades.Size = New System.Drawing.Size(571, 204)
        Me.grdEntidades.TabIndex = 2
        '
        'colSEL
        '
        Me.colSEL.DataPropertyName = "SEL"
        Me.colSEL.HeaderText = ""
        Me.colSEL.Name = "colSEL"
        Me.colSEL.Width = 30
        '
        'colEntidad
        '
        Me.colEntidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEntidad.DataPropertyName = "Entidad"
        Me.colEntidad.HeaderText = "Entidad"
        Me.colEntidad.Name = "colEntidad"
        Me.colEntidad.ReadOnly = True
        '
        'tbEntidades
        '
        Me.tbEntidades.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnActualizarEntidad, Me.btnGuardarEntidad})
        Me.tbEntidades.Location = New System.Drawing.Point(3, 37)
        Me.tbEntidades.Name = "tbEntidades"
        Me.tbEntidades.Size = New System.Drawing.Size(571, 39)
        Me.tbEntidades.TabIndex = 1
        Me.tbEntidades.Text = "CiToolBar1"
        '
        'btnActualizarEntidad
        '
        Me.btnActualizarEntidad.Image = CType(resources.GetObject("btnActualizarEntidad.Image"), System.Drawing.Image)
        Me.btnActualizarEntidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnActualizarEntidad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualizarEntidad.Name = "btnActualizarEntidad"
        Me.btnActualizarEntidad.Size = New System.Drawing.Size(95, 36)
        Me.btnActualizarEntidad.Text = "Actualizar"
        '
        'btnGuardarEntidad
        '
        Me.btnGuardarEntidad.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.diskette_32
        Me.btnGuardarEntidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnGuardarEntidad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardarEntidad.Name = "btnGuardarEntidad"
        Me.btnGuardarEntidad.Size = New System.Drawing.Size(85, 36)
        Me.btnGuardarEntidad.Text = "Guardar"
        '
        'lblEntidades
        '
        Me.lblEntidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEntidades.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEntidades.Location = New System.Drawing.Point(3, 3)
        Me.lblEntidades.Name = "lblEntidades"
        Me.lblEntidades.Size = New System.Drawing.Size(571, 34)
        Me.lblEntidades.TabIndex = 0
        Me.lblEntidades.Text = "Seleccione las entidades que combinadas determinarán el rac a aplicar"
        Me.lblEntidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabCombinacion
        '
        Me.tabCombinacion.Controls.Add(Me.grdFiltros)
        Me.tabCombinacion.Controls.Add(Me.tbCombinacion)
        Me.tabCombinacion.Controls.Add(Me.lblFiltros)
        Me.tabCombinacion.ImageIndex = 1
        Me.tabCombinacion.Location = New System.Drawing.Point(4, 39)
        Me.tabCombinacion.Name = "tabCombinacion"
        Me.tabCombinacion.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCombinacion.Size = New System.Drawing.Size(577, 283)
        Me.tabCombinacion.TabIndex = 1
        Me.tabCombinacion.Text = "Combinación"
        Me.tabCombinacion.UseVisualStyleBackColor = True
        '
        'grdFiltros
        '
        Me.grdFiltros.AllowUserToAddRows = False
        Me.grdFiltros.BackgroundColor = System.Drawing.Color.White
        Me.grdFiltros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdFiltros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRac})
        Me.grdFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFiltros.Location = New System.Drawing.Point(3, 76)
        Me.grdFiltros.Name = "grdFiltros"
        Me.grdFiltros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdFiltros.Size = New System.Drawing.Size(571, 204)
        Me.grdFiltros.TabIndex = 0
        '
        'colRac
        '
        Me.colRac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colRac.DataPropertyName = "Rac"
        Me.colRac.HeaderText = "Rac"
        Me.colRac.Name = "colRac"
        Me.colRac.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colRac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'tbCombinacion
        '
        Me.tbCombinacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnActualizarComb, Me.btnGuardarComb})
        Me.tbCombinacion.Location = New System.Drawing.Point(3, 37)
        Me.tbCombinacion.Name = "tbCombinacion"
        Me.tbCombinacion.Size = New System.Drawing.Size(571, 39)
        Me.tbCombinacion.TabIndex = 3
        Me.tbCombinacion.Text = "CiToolBar2"
        '
        'btnActualizarComb
        '
        Me.btnActualizarComb.Image = CType(resources.GetObject("btnActualizarComb.Image"), System.Drawing.Image)
        Me.btnActualizarComb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnActualizarComb.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualizarComb.Name = "btnActualizarComb"
        Me.btnActualizarComb.Size = New System.Drawing.Size(95, 36)
        Me.btnActualizarComb.Text = "Actualizar"
        '
        'btnGuardarComb
        '
        Me.btnGuardarComb.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.diskette_32
        Me.btnGuardarComb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnGuardarComb.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardarComb.Name = "btnGuardarComb"
        Me.btnGuardarComb.Size = New System.Drawing.Size(85, 36)
        Me.btnGuardarComb.Text = "Guardar"
        '
        'lblFiltros
        '
        Me.lblFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFiltros.Location = New System.Drawing.Point(3, 3)
        Me.lblFiltros.Name = "lblFiltros"
        Me.lblFiltros.Size = New System.Drawing.Size(571, 34)
        Me.lblFiltros.TabIndex = 2
        Me.lblFiltros.Text = "Configure los Racs por cada combinación generada"
        Me.lblFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'iLstTab
        '
        Me.iLstTab.ImageStream = CType(resources.GetObject("iLstTab.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iLstTab.TransparentColor = System.Drawing.Color.Transparent
        Me.iLstTab.Images.SetKeyName(0, "Entidades.png")
        Me.iLstTab.Images.SetKeyName(1, "stats_32.png")
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(545, 362)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Salir"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'RacWorkflowForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 397)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gbxCondiciones)
        Me.Name = "RacWorkflowForm"
        Me.Text = "Asignar las variantes de documento ..."
        Me.gbxCondiciones.ResumeLayout(False)
        Me.tabCombinaciones.ResumeLayout(False)
        Me.tabEntidades.ResumeLayout(False)
        Me.tabEntidades.PerformLayout()
        CType(Me.grdEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbEntidades.ResumeLayout(False)
        Me.tbEntidades.PerformLayout()
        Me.tabCombinacion.ResumeLayout(False)
        Me.tabCombinacion.PerformLayout()
        CType(Me.grdFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCombinacion.ResumeLayout(False)
        Me.tbCombinacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxCondiciones As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents tabCombinaciones As Azteca.Windows.Controls.CITab
    Friend WithEvents tabEntidades As System.Windows.Forms.TabPage
    Friend WithEvents tabCombinacion As System.Windows.Forms.TabPage
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents grdEntidades As Azteca.Windows.Controls.CIDataGridView
    Friend WithEvents tbEntidades As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnActualizarEntidad As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardarEntidad As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblEntidades As Azteca.Windows.Controls.CILabel
    Friend WithEvents colSEL As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colEntidad As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents tbCombinacion As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnActualizarComb As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardarComb As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblFiltros As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdFiltros As Azteca.Windows.Controls.CIDataGridView
    Friend WithEvents colRac As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents iLstTab As System.Windows.Forms.ImageList
End Class
