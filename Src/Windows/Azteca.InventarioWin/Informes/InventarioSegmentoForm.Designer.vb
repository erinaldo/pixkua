<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventarioSegmentoForm
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
        Me.rdbTipo = New System.Windows.Forms.RadioButton()
        Me.rdbFamilia = New System.Windows.Forms.RadioButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.chkCostoMaterial = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkCostoLabor = New System.Windows.Forms.CheckBox()
        Me.chkCostoServicio = New System.Windows.Forms.CheckBox()
        Me.chkCostoCarga = New System.Windows.Forms.CheckBox()
        Me.chkSegmentoEspecifico = New System.Windows.Forms.CheckBox()
        Me.tlbMenu = New Azteca.Windows.Controls.AZToolBar()
        Me.btnImprimir = New C1.Win.C1Command.C1CommandLink()
        Me.tlbImprimir = New C1.Win.C1Command.C1Command()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.grpAlmacen = New Azteca.Windows.Controls.CIGroupBox()
        Me.chkFiltroAlmacen = New System.Windows.Forms.CheckBox()
        Me.cboArea = New Azteca.Windows.Inventario.AreasComboBox()
        Me.cboAlmacen = New Azteca.Windows.Inventario.AlmacenesComboBox()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.cboTipos = New Azteca.Windows.Inventario.TiposArticulosComboBox()
        Me.cboFamilias = New Azteca.Windows.Inventario.FamiliasComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAlmacen.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbTipo)
        Me.GroupBox1.Controls.Add(Me.rdbFamilia)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 66)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Segmento Articulo"
        '
        'rdbTipo
        '
        Me.rdbTipo.AutoSize = True
        Me.rdbTipo.Location = New System.Drawing.Point(150, 28)
        Me.rdbTipo.Name = "rdbTipo"
        Me.rdbTipo.Size = New System.Drawing.Size(46, 17)
        Me.rdbTipo.TabIndex = 1
        Me.rdbTipo.Text = "Tipo"
        Me.rdbTipo.UseVisualStyleBackColor = True
        '
        'rdbFamilia
        '
        Me.rdbFamilia.AutoSize = True
        Me.rdbFamilia.Checked = True
        Me.rdbFamilia.Location = New System.Drawing.Point(30, 28)
        Me.rdbFamilia.Name = "rdbFamilia"
        Me.rdbFamilia.Size = New System.Drawing.Size(57, 17)
        Me.rdbFamilia.TabIndex = 0
        Me.rdbFamilia.TabStop = True
        Me.rdbFamilia.Text = "Familia"
        Me.rdbFamilia.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(425, 340)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 14
        Me.LineShape2.X2 = 180
        Me.LineShape2.Y1 = 253
        Me.LineShape2.Y2 = 253
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 219
        Me.LineShape1.X2 = 372
        Me.LineShape1.Y1 = 252
        Me.LineShape1.Y2 = 252
        '
        'chkCostoMaterial
        '
        Me.chkCostoMaterial.AutoSize = True
        Me.chkCostoMaterial.Location = New System.Drawing.Point(223, 260)
        Me.chkCostoMaterial.Name = "chkCostoMaterial"
        Me.chkCostoMaterial.Size = New System.Drawing.Size(63, 17)
        Me.chkCostoMaterial.TabIndex = 2
        Me.chkCostoMaterial.Text = "Material"
        Me.chkCostoMaterial.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mostrar Costos"
        '
        'chkCostoLabor
        '
        Me.chkCostoLabor.AutoSize = True
        Me.chkCostoLabor.Location = New System.Drawing.Point(292, 260)
        Me.chkCostoLabor.Name = "chkCostoLabor"
        Me.chkCostoLabor.Size = New System.Drawing.Size(53, 17)
        Me.chkCostoLabor.TabIndex = 4
        Me.chkCostoLabor.Text = "Labor"
        Me.chkCostoLabor.UseVisualStyleBackColor = True
        '
        'chkCostoServicio
        '
        Me.chkCostoServicio.AutoSize = True
        Me.chkCostoServicio.Location = New System.Drawing.Point(223, 283)
        Me.chkCostoServicio.Name = "chkCostoServicio"
        Me.chkCostoServicio.Size = New System.Drawing.Size(64, 17)
        Me.chkCostoServicio.TabIndex = 5
        Me.chkCostoServicio.Text = "Servicio"
        Me.chkCostoServicio.UseVisualStyleBackColor = True
        '
        'chkCostoCarga
        '
        Me.chkCostoCarga.AutoSize = True
        Me.chkCostoCarga.Location = New System.Drawing.Point(292, 283)
        Me.chkCostoCarga.Name = "chkCostoCarga"
        Me.chkCostoCarga.Size = New System.Drawing.Size(54, 17)
        Me.chkCostoCarga.TabIndex = 6
        Me.chkCostoCarga.Text = "Carga"
        Me.chkCostoCarga.UseVisualStyleBackColor = True
        '
        'chkSegmentoEspecifico
        '
        Me.chkSegmentoEspecifico.AutoSize = True
        Me.chkSegmentoEspecifico.Location = New System.Drawing.Point(13, 230)
        Me.chkSegmentoEspecifico.Name = "chkSegmentoEspecifico"
        Me.chkSegmentoEspecifico.Size = New System.Drawing.Size(126, 17)
        Me.chkSegmentoEspecifico.TabIndex = 8
        Me.chkSegmentoEspecifico.Text = "Segmento Especifico"
        Me.chkSegmentoEspecifico.UseVisualStyleBackColor = True
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
        Me.tlbMenu.Size = New System.Drawing.Size(425, 34)
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
        'grpAlmacen
        '
        Me.grpAlmacen.Controls.Add(Me.chkFiltroAlmacen)
        Me.grpAlmacen.Controls.Add(Me.cboArea)
        Me.grpAlmacen.Controls.Add(Me.cboAlmacen)
        Me.grpAlmacen.Controls.Add(Me.CiLabel3)
        Me.grpAlmacen.Controls.Add(Me.CiLabel4)
        Me.grpAlmacen.Location = New System.Drawing.Point(13, 40)
        Me.grpAlmacen.Name = "grpAlmacen"
        Me.grpAlmacen.Size = New System.Drawing.Size(378, 97)
        Me.grpAlmacen.TabIndex = 13
        Me.grpAlmacen.TabStop = False
        '
        'chkFiltroAlmacen
        '
        Me.chkFiltroAlmacen.AutoSize = True
        Me.chkFiltroAlmacen.Location = New System.Drawing.Point(6, 0)
        Me.chkFiltroAlmacen.Name = "chkFiltroAlmacen"
        Me.chkFiltroAlmacen.Size = New System.Drawing.Size(113, 17)
        Me.chkFiltroAlmacen.TabIndex = 15
        Me.chkFiltroAlmacen.Text = "Filtrar por Almacen"
        Me.chkFiltroAlmacen.UseVisualStyleBackColor = True
        '
        'cboArea
        '
        Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArea.Enabled = False
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboArea.ItemsTable = Nothing
        Me.cboArea.Location = New System.Drawing.Point(93, 24)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.NoneItemText = "[Todos]"
        Me.cboArea.Size = New System.Drawing.Size(231, 21)
        Me.cboArea.TabIndex = 10
        Me.cboArea.UIName = Nothing
        '
        'cboAlmacen
        '
        Me.cboAlmacen.AddNoneItem = True
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.Enabled = False
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboAlmacen.ItemsTable = Nothing
        Me.cboAlmacen.Location = New System.Drawing.Point(93, 51)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.NoneItemText = "[Todos]"
        Me.cboAlmacen.Size = New System.Drawing.Size(231, 21)
        Me.cboAlmacen.TabIndex = 11
        Me.cboAlmacen.UIName = Nothing
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(20, 27)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(32, 13)
        Me.CiLabel3.TabIndex = 8
        Me.CiLabel3.Text = "Área:"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(20, 54)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(51, 13)
        Me.CiLabel4.TabIndex = 9
        Me.CiLabel4.Text = "Almacén:"
        '
        'cboTipos
        '
        Me.cboTipos.BackColor = System.Drawing.SystemColors.Window
        Me.cboTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipos.Enabled = False
        Me.cboTipos.FormattingEnabled = True
        Me.cboTipos.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTipos.ItemsTable = Nothing
        Me.cboTipos.Location = New System.Drawing.Point(13, 260)
        Me.cboTipos.Name = "cboTipos"
        Me.cboTipos.Size = New System.Drawing.Size(169, 21)
        Me.cboTipos.TabIndex = 10
        Me.cboTipos.UIName = Nothing
        Me.cboTipos.Visible = False
        '
        'cboFamilias
        '
        Me.cboFamilias.BackColor = System.Drawing.SystemColors.Window
        Me.cboFamilias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFamilias.Enabled = False
        Me.cboFamilias.FormattingEnabled = True
        Me.cboFamilias.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboFamilias.ItemsTable = Nothing
        Me.cboFamilias.Location = New System.Drawing.Point(13, 260)
        Me.cboFamilias.Name = "cboFamilias"
        Me.cboFamilias.Size = New System.Drawing.Size(169, 21)
        Me.cboFamilias.TabIndex = 9
        Me.cboFamilias.UIName = Nothing
        '
        'InventarioSegmentoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 340)
        Me.Controls.Add(Me.grpAlmacen)
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.cboTipos)
        Me.Controls.Add(Me.cboFamilias)
        Me.Controls.Add(Me.chkSegmentoEspecifico)
        Me.Controls.Add(Me.chkCostoCarga)
        Me.Controls.Add(Me.chkCostoServicio)
        Me.Controls.Add(Me.chkCostoLabor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkCostoMaterial)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "InventarioSegmentoForm"
        Me.Text = "InventarioSegmentoForm"
        Me.Controls.SetChildIndex(Me.ShapeContainer1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.chkCostoMaterial, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.chkCostoLabor, 0)
        Me.Controls.SetChildIndex(Me.chkCostoServicio, 0)
        Me.Controls.SetChildIndex(Me.chkCostoCarga, 0)
        Me.Controls.SetChildIndex(Me.chkSegmentoEspecifico, 0)
        Me.Controls.SetChildIndex(Me.cboFamilias, 0)
        Me.Controls.SetChildIndex(Me.cboTipos, 0)
        Me.Controls.SetChildIndex(Me.tlbMenu, 0)
        Me.Controls.SetChildIndex(Me.grpAlmacen, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAlmacen.ResumeLayout(False)
        Me.grpAlmacen.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbTipo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFamilia As System.Windows.Forms.RadioButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents chkCostoMaterial As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkCostoLabor As System.Windows.Forms.CheckBox
    Friend WithEvents chkCostoServicio As System.Windows.Forms.CheckBox
    Friend WithEvents chkCostoCarga As System.Windows.Forms.CheckBox
    Friend WithEvents chkSegmentoEspecifico As System.Windows.Forms.CheckBox
    Friend WithEvents cboFamilias As Azteca.Windows.Inventario.FamiliasComboBox
    Friend WithEvents cboTipos As Azteca.Windows.Inventario.TiposArticulosComboBox
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents btnImprimir As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents grpAlmacen As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents cboArea As Azteca.Windows.Inventario.AreasComboBox
    Friend WithEvents cboAlmacen As Azteca.Windows.Inventario.AlmacenesComboBox
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkFiltroAlmacen As System.Windows.Forms.CheckBox
    Private WithEvents tlbImprimir As C1.Win.C1Command.C1Command
End Class
