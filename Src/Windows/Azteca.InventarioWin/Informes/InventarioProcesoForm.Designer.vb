<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventarioProcesoForm
    Inherits Azteca.Windows.Forms.Forma

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tlbMenu = New Azteca.Windows.Controls.AZToolBar()
        Me.btnImprimir = New C1.Win.C1Command.C1CommandLink()
        Me.tlbImprimir = New C1.Win.C1Command.C1Command()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.chkTodo = New System.Windows.Forms.CheckBox()
        Me.chkCancelado = New System.Windows.Forms.CheckBox()
        Me.chkCerrado = New System.Windows.Forms.CheckBox()
        Me.chkRetenido = New System.Windows.Forms.CheckBox()
        Me.chkAplicado = New System.Windows.Forms.CheckBox()
        Me.chkGuardado = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkFiltroFechas = New System.Windows.Forms.CheckBox()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdbProductosFabricados = New System.Windows.Forms.RadioButton()
        Me.rdbInsumos = New System.Windows.Forms.RadioButton()
        Me.ArticuloSel = New Azteca.Windows.Inventario.ArticuloStockSelector()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ArticuloSel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 93)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro Especifico"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Articulo"
        '
        'tlbMenu
        '
        Me.tlbMenu.AccessibleName = "Tool Bar"
        Me.tlbMenu.AutoSize = False
        Me.tlbMenu.CommandHolder = Nothing
        Me.tlbMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnImprimir})
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.MinButtonSize = 32
        Me.tlbMenu.Movable = False
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(438, 34)
        Me.tlbMenu.Text = "AzToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'btnImprimir
        '
        Me.btnImprimir.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnImprimir.Command = Me.tlbImprimir
        Me.btnImprimir.Text = "Imprimir Informe"
        '
        'tlbImprimir
        '
        Me.tlbImprimir.Image = Global.Azteca.Windows.Inventario.My.Resources.Resources.fileprint
        Me.tlbImprimir.Name = "tlbImprimir"
        Me.tlbImprimir.ShortcutText = ""
        Me.tlbImprimir.Text = "Imprimir Informe"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.tlbImprimir)
        Me.C1CommandHolder1.Owner = Me
        '
        'chkTodo
        '
        Me.chkTodo.AutoSize = True
        Me.chkTodo.Checked = True
        Me.chkTodo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTodo.Location = New System.Drawing.Point(201, 366)
        Me.chkTodo.Name = "chkTodo"
        Me.chkTodo.Size = New System.Drawing.Size(51, 17)
        Me.chkTodo.TabIndex = 33
        Me.chkTodo.Text = "Todo"
        Me.chkTodo.UseVisualStyleBackColor = True
        '
        'chkCancelado
        '
        Me.chkCancelado.AutoSize = True
        Me.chkCancelado.Location = New System.Drawing.Point(201, 338)
        Me.chkCancelado.Name = "chkCancelado"
        Me.chkCancelado.Size = New System.Drawing.Size(77, 17)
        Me.chkCancelado.TabIndex = 32
        Me.chkCancelado.Text = "Cancelado"
        Me.chkCancelado.UseVisualStyleBackColor = True
        '
        'chkCerrado
        '
        Me.chkCerrado.AutoSize = True
        Me.chkCerrado.Location = New System.Drawing.Point(120, 367)
        Me.chkCerrado.Name = "chkCerrado"
        Me.chkCerrado.Size = New System.Drawing.Size(63, 17)
        Me.chkCerrado.TabIndex = 31
        Me.chkCerrado.Text = "Cerrado"
        Me.chkCerrado.UseVisualStyleBackColor = True
        '
        'chkRetenido
        '
        Me.chkRetenido.AutoSize = True
        Me.chkRetenido.Location = New System.Drawing.Point(120, 339)
        Me.chkRetenido.Name = "chkRetenido"
        Me.chkRetenido.Size = New System.Drawing.Size(69, 17)
        Me.chkRetenido.TabIndex = 30
        Me.chkRetenido.Text = "Retenido"
        Me.chkRetenido.UseVisualStyleBackColor = True
        '
        'chkAplicado
        '
        Me.chkAplicado.AutoSize = True
        Me.chkAplicado.Location = New System.Drawing.Point(38, 366)
        Me.chkAplicado.Name = "chkAplicado"
        Me.chkAplicado.Size = New System.Drawing.Size(67, 17)
        Me.chkAplicado.TabIndex = 29
        Me.chkAplicado.Text = "Aplicado"
        Me.chkAplicado.UseVisualStyleBackColor = True
        '
        'chkGuardado
        '
        Me.chkGuardado.AutoSize = True
        Me.chkGuardado.Location = New System.Drawing.Point(38, 338)
        Me.chkGuardado.Name = "chkGuardado"
        Me.chkGuardado.Size = New System.Drawing.Size(73, 17)
        Me.chkGuardado.TabIndex = 28
        Me.chkGuardado.Text = "Guardado"
        Me.chkGuardado.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Considerar los siguientes estatus en documentos"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(15, 330)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 2)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Enabled = False
        Me.dtpFechaFin.Location = New System.Drawing.Point(96, 60)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaFin.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Fecha Final"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkFiltroFechas)
        Me.GroupBox4.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 198)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(400, 100)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        '
        'chkFiltroFechas
        '
        Me.chkFiltroFechas.AutoSize = True
        Me.chkFiltroFechas.Location = New System.Drawing.Point(9, 0)
        Me.chkFiltroFechas.Name = "chkFiltroFechas"
        Me.chkFiltroFechas.Size = New System.Drawing.Size(306, 17)
        Me.chkFiltroFechas.TabIndex = 28
        Me.chkFiltroFechas.Text = "Considerar este rango de fechas en ordenes de producción"
        Me.chkFiltroFechas.UseVisualStyleBackColor = True
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Enabled = False
        Me.dtpFechaInicio.Location = New System.Drawing.Point(96, 34)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaInicio.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Fecha Inicial"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdbProductosFabricados)
        Me.GroupBox3.Controls.Add(Me.rdbInsumos)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 53)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de Producto"
        '
        'rdbProductosFabricados
        '
        Me.rdbProductosFabricados.AutoSize = True
        Me.rdbProductosFabricados.Location = New System.Drawing.Point(202, 19)
        Me.rdbProductosFabricados.Name = "rdbProductosFabricados"
        Me.rdbProductosFabricados.Size = New System.Drawing.Size(128, 17)
        Me.rdbProductosFabricados.TabIndex = 1
        Me.rdbProductosFabricados.Text = "Productos Fabricados"
        Me.rdbProductosFabricados.UseVisualStyleBackColor = True
        '
        'rdbInsumos
        '
        Me.rdbInsumos.AutoSize = True
        Me.rdbInsumos.Checked = True
        Me.rdbInsumos.Location = New System.Drawing.Point(96, 19)
        Me.rdbInsumos.Name = "rdbInsumos"
        Me.rdbInsumos.Size = New System.Drawing.Size(64, 17)
        Me.rdbInsumos.TabIndex = 0
        Me.rdbInsumos.TabStop = True
        Me.rdbInsumos.Text = "Insumos"
        Me.rdbInsumos.UseVisualStyleBackColor = True
        '
        'ArticuloSel
        '
        Me.ArticuloSel.AnySite = False
        Me.ArticuloSel.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.ArticuloSel.EditorAssembly = "Azteca.InventarioWin"
        Me.ArticuloSel.EditorClass = "Azteca.Windows.Inventario.ArticulosStockForm"
        Me.ArticuloSel.EditorTitle = "Editar Articulos de inventario..."
        Me.ArticuloSel.Key = 0
        Me.ArticuloSel.Linked = False
        Me.ArticuloSel.Location = New System.Drawing.Point(26, 44)
        Me.ArticuloSel.Name = "ArticuloSel"
        Me.ArticuloSel.Size = New System.Drawing.Size(231, 23)
        Me.ArticuloSel.TabIndex = 0
        '
        'InventarioProcesoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 420)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.chkTodo)
        Me.Controls.Add(Me.chkCancelado)
        Me.Controls.Add(Me.chkCerrado)
        Me.Controls.Add(Me.chkRetenido)
        Me.Controls.Add(Me.chkAplicado)
        Me.Controls.Add(Me.chkGuardado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "InventarioProcesoForm"
        Me.Text = "InventarioProcesoForm"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.tlbMenu, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.chkGuardado, 0)
        Me.Controls.SetChildIndex(Me.chkAplicado, 0)
        Me.Controls.SetChildIndex(Me.chkRetenido, 0)
        Me.Controls.SetChildIndex(Me.chkCerrado, 0)
        Me.Controls.SetChildIndex(Me.chkCancelado, 0)
        Me.Controls.SetChildIndex(Me.chkTodo, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ArticuloSel As Azteca.Windows.Inventario.ArticuloStockSelector
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents btnImprimir As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkTodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkCancelado As System.Windows.Forms.CheckBox
    Friend WithEvents chkCerrado As System.Windows.Forms.CheckBox
    Friend WithEvents chkRetenido As System.Windows.Forms.CheckBox
    Friend WithEvents chkAplicado As System.Windows.Forms.CheckBox
    Friend WithEvents chkGuardado As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFiltroFechas As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbProductosFabricados As System.Windows.Forms.RadioButton
    Friend WithEvents rdbInsumos As System.Windows.Forms.RadioButton
    Friend WithEvents tlbImprimir As C1.Win.C1Command.C1Command
End Class
