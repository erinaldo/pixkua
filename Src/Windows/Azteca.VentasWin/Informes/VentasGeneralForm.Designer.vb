<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentasGeneralForm
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
        Me.cboSucursal = New Azteca.Windows.Controls.Security.SucursalComboBox()
        Me.cboEmpresas = New Azteca.Windows.Controls.Security.EmpresasComboBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.chkFiltroSucursal = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tlbMenu = New Azteca.Windows.Controls.AZToolBar()
        Me.btnImprimir = New C1.Win.C1Command.C1CommandLink()
        Me.tlbIImprimir = New C1.Win.C1Command.C1Command()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.InformesDS1 = New Azteca.Business.Medicina.InformesDS()
        Me.ClienteSel = New Azteca.Windows.Ventas.ClienteSelector()
        Me.ArticuloSel = New Azteca.Windows.Ventas.ArticuloSelector()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InformesDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboSucursal
        '
        Me.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSucursal.Enabled = False
        Me.cboSucursal.FormattingEnabled = True
        Me.cboSucursal.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboSucursal.ItemsTable = Nothing
        Me.cboSucursal.Location = New System.Drawing.Point(93, 60)
        Me.cboSucursal.Name = "cboSucursal"
        Me.cboSucursal.Size = New System.Drawing.Size(242, 21)
        Me.cboSucursal.TabIndex = 11
        Me.cboSucursal.UIName = Nothing
        '
        'cboEmpresas
        '
        Me.cboEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresas.Enabled = False
        Me.cboEmpresas.FormattingEnabled = True
        Me.cboEmpresas.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboEmpresas.ItemsTable = Nothing
        Me.cboEmpresas.Location = New System.Drawing.Point(93, 30)
        Me.cboEmpresas.Name = "cboEmpresas"
        Me.cboEmpresas.Size = New System.Drawing.Size(242, 21)
        Me.cboEmpresas.TabIndex = 11
        Me.cboEmpresas.UIName = Nothing
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(36, 63)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(51, 13)
        Me.CiLabel2.TabIndex = 10
        Me.CiLabel2.Text = "Sucursal:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CiLabel1)
        Me.GroupBox1.Controls.Add(Me.chkFiltroSucursal)
        Me.GroupBox1.Controls.Add(Me.cboSucursal)
        Me.GroupBox1.Controls.Add(Me.cboEmpresas)
        Me.GroupBox1.Controls.Add(Me.CiLabel2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 108)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(37, 33)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(51, 13)
        Me.CiLabel1.TabIndex = 13
        Me.CiLabel1.Text = "Empresa:"
        '
        'chkFiltroSucursal
        '
        Me.chkFiltroSucursal.AutoSize = True
        Me.chkFiltroSucursal.Location = New System.Drawing.Point(6, 0)
        Me.chkFiltroSucursal.Name = "chkFiltroSucursal"
        Me.chkFiltroSucursal.Size = New System.Drawing.Size(92, 17)
        Me.chkFiltroSucursal.TabIndex = 0
        Me.chkFiltroSucursal.Text = "Filtro Sucursal"
        Me.chkFiltroSucursal.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ArticuloSel)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 70)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro Articulo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ClienteSel)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 289)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(381, 70)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtro Cliente"
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
        Me.tlbMenu.Size = New System.Drawing.Size(406, 34)
        Me.tlbMenu.Text = "AzToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'btnImprimir
        '
        Me.btnImprimir.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnImprimir.Command = Me.tlbIImprimir
        Me.btnImprimir.Text = "Imprimir Informe"
        '
        'tlbIImprimir
        '
        Me.tlbIImprimir.Image = Global.Azteca.Windows.Ventas.My.Resources.Resources.printer_32
        Me.tlbIImprimir.Name = "tlbIImprimir"
        Me.tlbIImprimir.ShortcutText = ""
        Me.tlbIImprimir.Text = "Imprimir Informe"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.tlbIImprimir)
        Me.C1CommandHolder1.Owner = Me
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(233, 62)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(160, 20)
        Me.dtpFechaFin.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Fecha Inicial"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(230, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Fecha Final"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(18, 62)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(160, 20)
        Me.dtpFechaIni.TabIndex = 31
        '
        'InformesDS1
        '
        Me.InformesDS1.DataSetName = "InformesDS"
        Me.InformesDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteSel
        '
        Me.ClienteSel.AnySite = False
        Me.ClienteSel.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.ClienteSel.EditorAssembly = "Azteca.VentasWin"
        Me.ClienteSel.EditorClass = "Azteca.Windows.Ventas.ClientesForm"
        Me.ClienteSel.EditorTitle = "Editar datos de cliente..."
        Me.ClienteSel.Enabled = False
        Me.ClienteSel.Key = 0
        Me.ClienteSel.Linked = False
        Me.ClienteSel.Location = New System.Drawing.Point(39, 32)
        Me.ClienteSel.Name = "ClienteSel"
        Me.ClienteSel.Size = New System.Drawing.Size(336, 23)
        Me.ClienteSel.TabIndex = 15
        '
        'ArticuloSel
        '
        Me.ArticuloSel.AnySite = False
        Me.ArticuloSel.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.ArticuloSel.EditorAssembly = "Azteca.VentasWin"
        Me.ArticuloSel.EditorClass = "Azteca.Windows.Ventas.ArticulosForm"
        Me.ArticuloSel.EditorTitle = "Editar datos de articulo..."
        Me.ArticuloSel.Enabled = False
        Me.ArticuloSel.Key = 0
        Me.ArticuloSel.Linked = False
        Me.ArticuloSel.Location = New System.Drawing.Point(39, 32)
        Me.ArticuloSel.Name = "ArticuloSel"
        Me.ArticuloSel.Size = New System.Drawing.Size(336, 23)
        Me.ArticuloSel.TabIndex = 15
        '
        'VentasGeneralForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 445)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpFechaIni)
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "VentasGeneralForm"
        Me.Text = "VentasGeneralForm"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.tlbMenu, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaIni, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaFin, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InformesDS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboSucursal As Azteca.Windows.Controls.Security.SucursalComboBox
    Friend WithEvents cboEmpresas As Azteca.Windows.Controls.Security.EmpresasComboBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents chkFiltroSucursal As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents btnImprimir As C1.Win.C1Command.C1CommandLink
    Friend WithEvents tlbIImprimir As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents ArticuloSel As Azteca.Windows.Ventas.ArticuloSelector
    Friend WithEvents ClienteSel As Azteca.Windows.Ventas.ClienteSelector
    Friend WithEvents InformesDS1 As Azteca.Business.Medicina.InformesDS
End Class
