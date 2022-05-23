<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExistenciasForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExistenciasForm))
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.grpTipoInventario = New Azteca.Windows.Controls.CIGroupBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaFin = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.dtpFechaIni = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.rdbHistorico = New Azteca.Windows.Controls.CIRadioButton()
        Me.rdbActual = New Azteca.Windows.Controls.CIRadioButton()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.cboAlmacen = New Azteca.Windows.Inventario.AlmacenesComboBox()
        Me.cboArea = New Azteca.Windows.Inventario.AreasComboBox()
        Me.grpAlmacen = New Azteca.Windows.Controls.CIGroupBox()
        Me.tlbMenu = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdImprimir = New C1.Win.C1Command.C1Command()
        Me.btnImprimir = New C1.Win.C1Command.C1CommandLink()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkMostrarExistenciasCero = New System.Windows.Forms.CheckBox()
        Me.chkIncluirCostoEstandar = New System.Windows.Forms.CheckBox()
        Me.grpTipoInventario.SuspendLayout()
        Me.grpAlmacen.SuspendLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(41, 71)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(26, 13)
        Me.CiLabel1.TabIndex = 5
        Me.CiLabel1.Text = "Del:"
        '
        'grpTipoInventario
        '
        Me.grpTipoInventario.Controls.Add(Me.CiLabel2)
        Me.grpTipoInventario.Controls.Add(Me.dtpFechaFin)
        Me.grpTipoInventario.Controls.Add(Me.dtpFechaIni)
        Me.grpTipoInventario.Controls.Add(Me.rdbHistorico)
        Me.grpTipoInventario.Controls.Add(Me.rdbActual)
        Me.grpTipoInventario.Controls.Add(Me.CiLabel1)
        Me.grpTipoInventario.Location = New System.Drawing.Point(12, 42)
        Me.grpTipoInventario.Name = "grpTipoInventario"
        Me.grpTipoInventario.Size = New System.Drawing.Size(378, 99)
        Me.grpTipoInventario.TabIndex = 7
        Me.grpTipoInventario.TabStop = False
        Me.grpTipoInventario.Text = "Tipo de Inventario"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(179, 71)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(19, 13)
        Me.CiLabel2.TabIndex = 10
        Me.CiLabel2.Text = "Al:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Enabled = False
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaFin.Location = New System.Drawing.Point(204, 67)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaFin.TabIndex = 9
        Me.dtpFechaFin.Value = New Date(2011, 6, 28, 0, 0, 0, 0)
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Enabled = False
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaIni.Location = New System.Drawing.Point(73, 67)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaIni.TabIndex = 8
        Me.dtpFechaIni.Value = New Date(2011, 6, 28, 0, 0, 0, 0)
        '
        'rdbHistorico
        '
        Me.rdbHistorico.AutoSize = True
        Me.rdbHistorico.Location = New System.Drawing.Point(23, 42)
        Me.rdbHistorico.Name = "rdbHistorico"
        Me.rdbHistorico.Size = New System.Drawing.Size(66, 17)
        Me.rdbHistorico.TabIndex = 1
        Me.rdbHistorico.Text = "Histórico"
        Me.rdbHistorico.UseVisualStyleBackColor = True
        '
        'rdbActual
        '
        Me.rdbActual.AutoSize = True
        Me.rdbActual.Checked = True
        Me.rdbActual.Location = New System.Drawing.Point(23, 19)
        Me.rdbActual.Name = "rdbActual"
        Me.rdbActual.Size = New System.Drawing.Size(55, 17)
        Me.rdbActual.TabIndex = 0
        Me.rdbActual.TabStop = True
        Me.rdbActual.Text = "Actual"
        Me.rdbActual.UseVisualStyleBackColor = True
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
        'cboAlmacen
        '
        Me.cboAlmacen.AddNoneItem = True
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
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
        'cboArea
        '
        Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
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
        'grpAlmacen
        '
        Me.grpAlmacen.Controls.Add(Me.cboArea)
        Me.grpAlmacen.Controls.Add(Me.cboAlmacen)
        Me.grpAlmacen.Controls.Add(Me.CiLabel3)
        Me.grpAlmacen.Controls.Add(Me.CiLabel4)
        Me.grpAlmacen.Location = New System.Drawing.Point(12, 147)
        Me.grpAlmacen.Name = "grpAlmacen"
        Me.grpAlmacen.Size = New System.Drawing.Size(378, 97)
        Me.grpAlmacen.TabIndex = 12
        Me.grpAlmacen.TabStop = False
        Me.grpAlmacen.Text = "Almacén:"
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
        Me.tlbMenu.Size = New System.Drawing.Size(441, 34)
        Me.tlbMenu.Text = "AzToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
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
        Me.cmdImprimir.ShortcutText = ""
        Me.cmdImprimir.Text = "Imprimir"
        '
        'btnImprimir
        '
        Me.btnImprimir.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnImprimir.Command = Me.cmdImprimir
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkMostrarExistenciasCero)
        Me.GroupBox1.Controls.Add(Me.chkIncluirCostoEstandar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 66)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Propiedades"
        '
        'chkMostrarExistenciasCero
        '
        Me.chkMostrarExistenciasCero.AutoSize = True
        Me.chkMostrarExistenciasCero.Location = New System.Drawing.Point(204, 33)
        Me.chkMostrarExistenciasCero.Name = "chkMostrarExistenciasCero"
        Me.chkMostrarExistenciasCero.Size = New System.Drawing.Size(157, 17)
        Me.chkMostrarExistenciasCero.TabIndex = 1
        Me.chkMostrarExistenciasCero.Text = "Mostrar Existencias en Cero"
        Me.chkMostrarExistenciasCero.UseVisualStyleBackColor = True
        '
        'chkIncluirCostoEstandar
        '
        Me.chkIncluirCostoEstandar.AutoSize = True
        Me.chkIncluirCostoEstandar.Location = New System.Drawing.Point(23, 33)
        Me.chkIncluirCostoEstandar.Name = "chkIncluirCostoEstandar"
        Me.chkIncluirCostoEstandar.Size = New System.Drawing.Size(129, 17)
        Me.chkIncluirCostoEstandar.TabIndex = 0
        Me.chkIncluirCostoEstandar.Text = "Incluir Costo Estandar"
        Me.chkIncluirCostoEstandar.UseVisualStyleBackColor = True
        '
        'ExistenciasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 358)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.grpAlmacen)
        Me.Controls.Add(Me.grpTipoInventario)
        Me.Name = "ExistenciasForm"
        Me.Text = "ExistenciasForm"
        Me.Controls.SetChildIndex(Me.grpTipoInventario, 0)
        Me.Controls.SetChildIndex(Me.grpAlmacen, 0)
        Me.Controls.SetChildIndex(Me.tlbMenu, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.grpTipoInventario.ResumeLayout(False)
        Me.grpTipoInventario.PerformLayout()
        Me.grpAlmacen.ResumeLayout(False)
        Me.grpAlmacen.PerformLayout()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents grpTipoInventario As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents rdbHistorico As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbActual As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaFin As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents dtpFechaIni As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboArea As Azteca.Windows.Inventario.AreasComboBox
    Friend WithEvents cboAlmacen As Azteca.Windows.Inventario.AlmacenesComboBox

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LicenseModule = Kernel.Licensing.LicenseModule.Inventory
    End Sub
    Friend WithEvents grpAlmacen As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdImprimir As C1.Win.C1Command.C1Command
    Friend WithEvents btnImprimir As C1.Win.C1Command.C1CommandLink
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMostrarExistenciasCero As System.Windows.Forms.CheckBox
    Friend WithEvents chkIncluirCostoEstandar As System.Windows.Forms.CheckBox
End Class
