<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CFDEmitidosForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CFDEmitidosForm))
        Me.tlbMenu = New Azteca.Windows.Controls.CIToolBar()
        Me.btnCargar = New System.Windows.Forms.ToolStripButton()
        Me.btnGenerar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.cboEmpresa = New Azteca.Windows.Controls.Security.EmpresasComboBox()
        Me.cboMes = New Azteca.Windows.Controls.CIComboBox()
        Me.nudAnio = New Azteca.Windows.Controls.CINumericUpDown()
        Me.bsComprobantes = New System.Windows.Forms.BindingSource(Me.components)
        Me.dlgFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.grdFacturas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.tlbMenu.SuspendLayout()
        CType(Me.nudAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlbMenu
        '
        Me.tlbMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tlbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCargar, Me.btnGenerar, Me.ToolStripSeparator1, Me.btnImprimir})
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(729, 39)
        Me.tlbMenu.TabIndex = 5
        Me.tlbMenu.Text = "CiToolBar1"
        '
        'btnCargar
        '
        Me.btnCargar.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.invoice_search32
        Me.btnCargar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(160, 36)
        Me.btnCargar.Text = "Buscar Comprobantes"
        '
        'btnGenerar
        '
        Me.btnGenerar.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.diskette_32
        Me.btnGenerar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(129, 36)
        Me.btnGenerar.Text = "Generar Informe"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnImprimir
        '
        Me.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(36, 36)
        Me.btnImprimir.Text = "Imprimir"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(20, 45)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(51, 13)
        Me.CiLabel1.TabIndex = 6
        Me.CiLabel1.Text = "Empresa:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(20, 73)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(30, 13)
        Me.CiLabel2.TabIndex = 7
        Me.CiLabel2.Text = "Mes:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(283, 73)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(29, 13)
        Me.CiLabel3.TabIndex = 8
        Me.CiLabel3.Text = "Año:"
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboEmpresa.ItemsTable = Nothing
        Me.cboEmpresa.Location = New System.Drawing.Point(77, 42)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(308, 21)
        Me.cboEmpresa.TabIndex = 9
        Me.cboEmpresa.UIName = Nothing
        '
        'cboMes
        '
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboMes.ItemsTable = Nothing
        Me.cboMes.Location = New System.Drawing.Point(77, 70)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(200, 21)
        Me.cboMes.TabIndex = 10
        Me.cboMes.UIName = Nothing
        '
        'nudAnio
        '
        Me.nudAnio.HighlightColor = System.Drawing.SystemColors.Info
        Me.nudAnio.Location = New System.Drawing.Point(318, 71)
        Me.nudAnio.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.nudAnio.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nudAnio.Name = "nudAnio"
        Me.nudAnio.Size = New System.Drawing.Size(67, 20)
        Me.nudAnio.TabIndex = 11
        Me.nudAnio.Value = New Decimal(New Integer() {2010, 0, 0, 0})
        '
        'bsComprobantes
        '
        Me.bsComprobantes.AllowNew = False
        '
        'grdFacturas
        '
        Me.grdFacturas.AllowUpdate = False
        Me.grdFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdFacturas.DataSource = Me.bsComprobantes
        Me.grdFacturas.FilterBar = True
        Me.grdFacturas.Images.Add(CType(resources.GetObject("grdFacturas.Images"), System.Drawing.Image))
        Me.grdFacturas.Location = New System.Drawing.Point(12, 113)
        Me.grdFacturas.Name = "grdFacturas"
        Me.grdFacturas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdFacturas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdFacturas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdFacturas.PrintInfo.PageSettings = CType(resources.GetObject("grdFacturas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdFacturas.Size = New System.Drawing.Size(705, 267)
        Me.grdFacturas.TabIndex = 14
        Me.grdFacturas.Text = "C1TrueDBGrid1"
        Me.grdFacturas.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        Me.grdFacturas.PropBag = resources.GetString("grdFacturas.PropBag")
        '
        'CFDEmitidosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 408)
        Me.Controls.Add(Me.grdFacturas)
        Me.Controls.Add(Me.nudAnio)
        Me.Controls.Add(Me.cboMes)
        Me.Controls.Add(Me.cboEmpresa)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.tlbMenu)
        Me.Name = "CFDEmitidosForm"
        Me.Text = "CFDEmitidosForm"
        Me.Controls.SetChildIndex(Me.tlbMenu, 0)
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.CiLabel2, 0)
        Me.Controls.SetChildIndex(Me.CiLabel3, 0)
        Me.Controls.SetChildIndex(Me.cboEmpresa, 0)
        Me.Controls.SetChildIndex(Me.cboMes, 0)
        Me.Controls.SetChildIndex(Me.nudAnio, 0)
        Me.Controls.SetChildIndex(Me.grdFacturas, 0)
        Me.tlbMenu.ResumeLayout(False)
        Me.tlbMenu.PerformLayout()
        CType(Me.nudAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnCargar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGenerar As System.Windows.Forms.ToolStripButton
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboEmpresa As Azteca.Windows.Controls.Security.EmpresasComboBox
    Friend WithEvents cboMes As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents nudAnio As Azteca.Windows.Controls.CINumericUpDown
    Friend WithEvents bsComprobantes As System.Windows.Forms.BindingSource
    Friend WithEvents dlgFolder As System.Windows.Forms.FolderBrowserDialog

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Friend WithEvents grdFacturas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
End Class
