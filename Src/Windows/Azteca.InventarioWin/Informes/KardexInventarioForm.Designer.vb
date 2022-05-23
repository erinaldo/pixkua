<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KardexInventarioForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KardexInventarioForm))
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaIni = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaFin = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.dtpHoraIni = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.dtpHoraFin = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.grpPeriodo = New Azteca.Windows.Controls.CIGroupBox()
        Me.grpAlmacen = New Azteca.Windows.Controls.CIGroupBox()
        Me.cboAlmacen = New Azteca.Windows.Inventario.AlmacenesComboBox()
        Me.cboArea = New Azteca.Windows.Inventario.AreasComboBox()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.txtArticulo = New Azteca.Windows.Inventario.ArticuloStockSelector()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdImprimir = New C1.Win.C1Command.C1Command()
        Me.tlbMenu = New Azteca.Windows.Controls.AZToolBar()
        Me.btnImprimir = New C1.Win.C1Command.C1CommandLink()
        Me.grpPeriodo.SuspendLayout()
        Me.grpAlmacen.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(18, 54)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(51, 13)
        Me.CiLabel4.TabIndex = 13
        Me.CiLabel4.Text = "Almacén:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(18, 27)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(32, 13)
        Me.CiLabel3.TabIndex = 12
        Me.CiLabel3.Text = "Área:"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaIni.Location = New System.Drawing.Point(100, 22)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaIni.TabIndex = 18
        Me.dtpFechaIni.Value = New Date(2011, 6, 28, 0, 0, 0, 0)
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(18, 25)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(70, 13)
        Me.CiLabel1.TabIndex = 17
        Me.CiLabel1.Text = "Fecha Inicial:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaFin.Location = New System.Drawing.Point(100, 48)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaFin.TabIndex = 20
        Me.dtpFechaFin.Value = New Date(2011, 6, 28, 0, 0, 0, 0)
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(18, 50)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(65, 13)
        Me.CiLabel2.TabIndex = 19
        Me.CiLabel2.Text = "Fecha Final:"
        '
        'dtpHoraIni
        '
        Me.dtpHoraIni.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraIni.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpHoraIni.Location = New System.Drawing.Point(206, 22)
        Me.dtpHoraIni.Name = "dtpHoraIni"
        Me.dtpHoraIni.ShowUpDown = True
        Me.dtpHoraIni.Size = New System.Drawing.Size(100, 20)
        Me.dtpHoraIni.TabIndex = 21
        Me.dtpHoraIni.Value = New Date(2011, 6, 28, 0, 0, 0, 0)
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraFin.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpHoraFin.Location = New System.Drawing.Point(206, 50)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.ShowUpDown = True
        Me.dtpHoraFin.Size = New System.Drawing.Size(100, 20)
        Me.dtpHoraFin.TabIndex = 22
        Me.dtpHoraFin.Value = New Date(2011, 6, 28, 0, 0, 0, 0)
        '
        'grpPeriodo
        '
        Me.grpPeriodo.Controls.Add(Me.dtpFechaIni)
        Me.grpPeriodo.Controls.Add(Me.dtpHoraFin)
        Me.grpPeriodo.Controls.Add(Me.CiLabel1)
        Me.grpPeriodo.Controls.Add(Me.dtpHoraIni)
        Me.grpPeriodo.Controls.Add(Me.CiLabel2)
        Me.grpPeriodo.Controls.Add(Me.dtpFechaFin)
        Me.grpPeriodo.Location = New System.Drawing.Point(12, 42)
        Me.grpPeriodo.Name = "grpPeriodo"
        Me.grpPeriodo.Size = New System.Drawing.Size(386, 100)
        Me.grpPeriodo.TabIndex = 23
        Me.grpPeriodo.TabStop = False
        Me.grpPeriodo.Text = "Período"
        '
        'grpAlmacen
        '
        Me.grpAlmacen.Controls.Add(Me.cboAlmacen)
        Me.grpAlmacen.Controls.Add(Me.CiLabel3)
        Me.grpAlmacen.Controls.Add(Me.CiLabel4)
        Me.grpAlmacen.Controls.Add(Me.cboArea)
        Me.grpAlmacen.Location = New System.Drawing.Point(12, 148)
        Me.grpAlmacen.Name = "grpAlmacen"
        Me.grpAlmacen.Size = New System.Drawing.Size(386, 100)
        Me.grpAlmacen.TabIndex = 24
        Me.grpAlmacen.TabStop = False
        Me.grpAlmacen.Text = "Almacén:"
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboAlmacen.ItemsTable = Nothing
        Me.cboAlmacen.Location = New System.Drawing.Point(91, 51)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.NoneItemText = "[Todos]"
        Me.cboAlmacen.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboAlmacen.Size = New System.Drawing.Size(264, 21)
        Me.cboAlmacen.TabIndex = 15
        Me.cboAlmacen.UIName = Nothing
        '
        'cboArea
        '
        Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboArea.ItemsTable = Nothing
        Me.cboArea.Location = New System.Drawing.Point(91, 24)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.NoneItemText = "[Todos]"
        Me.cboArea.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboArea.Size = New System.Drawing.Size(264, 21)
        Me.cboArea.TabIndex = 14
        Me.cboArea.UIName = Nothing
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(30, 260)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(47, 13)
        Me.CiLabel5.TabIndex = 25
        Me.CiLabel5.Text = "Artículo:"
        '
        'txtArticulo
        '
        Me.txtArticulo.AnySite = False
        Me.txtArticulo.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtArticulo.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtArticulo.EditorAssembly = "Azteca.InventarioWin"
        Me.txtArticulo.EditorClass = "Azteca.Windows.Inventario.ArticulosStockForm"
        Me.txtArticulo.EditorTitle = "Editar Articulos de inventario..."
        Me.txtArticulo.Key = 0
        Me.txtArticulo.Linked = False
        Me.txtArticulo.Location = New System.Drawing.Point(103, 257)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtArticulo.Size = New System.Drawing.Size(264, 23)
        Me.txtArticulo.TabIndex = 26
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdImprimir)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Text = "Imprimir"
        '
        'tlbMenu
        '
        Me.tlbMenu.AccessibleName = "Tool Bar"
        Me.tlbMenu.AutoSize = False
        Me.tlbMenu.CommandHolder = Me.C1CommandHolder1
        Me.tlbMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnImprimir})
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.MinButtonSize = 32
        Me.tlbMenu.Movable = False
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(536, 34)
        Me.tlbMenu.Text = "AzToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'btnImprimir
        '
        Me.btnImprimir.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnImprimir.Command = Me.cmdImprimir
        '
        'KardexInventarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 345)
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.txtArticulo)
        Me.Controls.Add(Me.CiLabel5)
        Me.Controls.Add(Me.grpAlmacen)
        Me.Controls.Add(Me.grpPeriodo)
        Me.Name = "KardexInventarioForm"
        Me.Text = "KardexInventarioForm"
        Me.Controls.SetChildIndex(Me.grpPeriodo, 0)
        Me.Controls.SetChildIndex(Me.grpAlmacen, 0)
        Me.Controls.SetChildIndex(Me.CiLabel5, 0)
        Me.Controls.SetChildIndex(Me.txtArticulo, 0)
        Me.Controls.SetChildIndex(Me.tlbMenu, 0)
        Me.grpPeriodo.ResumeLayout(False)
        Me.grpPeriodo.PerformLayout()
        Me.grpAlmacen.ResumeLayout(False)
        Me.grpAlmacen.PerformLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LicenseModule = Kernel.Licensing.LicenseModule.Inventory
    End Sub
    Friend WithEvents cboAlmacen As Azteca.Windows.Inventario.AlmacenesComboBox
    Friend WithEvents cboArea As Azteca.Windows.Inventario.AreasComboBox
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaIni As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaFin As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpHoraIni As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents dtpHoraFin As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents grpPeriodo As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grpAlmacen As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtArticulo As Azteca.Windows.Inventario.ArticuloStockSelector
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdImprimir As C1.Win.C1Command.C1Command
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents btnImprimir As C1.Win.C1Command.C1CommandLink
End Class
