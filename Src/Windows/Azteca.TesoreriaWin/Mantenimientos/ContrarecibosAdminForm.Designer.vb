<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContrarecibosAdminForm
    Inherits Azteca.Windows.Forms.BusinessForms.DocumentAdminForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContrarecibosAdminForm))
        Me.bsContrarecibos = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdRequisiciones = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.lblCaja = New Azteca.Windows.Controls.CILabel()
        Me.cboCaja = New Azteca.Windows.Tesoreria.CajasComboBox()
        CType(Me.bsContrarecibos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRequisiciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdRequisiciones
        '
        Me.grdRequisiciones.AlternatingRows = True
        Me.grdRequisiciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRequisiciones.DataSource = Me.bsContrarecibos
        Me.grdRequisiciones.FilterBar = True
        Me.grdRequisiciones.Images.Add(CType(resources.GetObject("grdRequisiciones.Images"), System.Drawing.Image))
        Me.grdRequisiciones.Images.Add(CType(resources.GetObject("grdRequisiciones.Images1"), System.Drawing.Image))
        Me.grdRequisiciones.Location = New System.Drawing.Point(183, 64)
        Me.grdRequisiciones.Name = "grdRequisiciones"
        Me.grdRequisiciones.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdRequisiciones.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdRequisiciones.PreviewInfo.ZoomFactor = 75.0R
        Me.grdRequisiciones.PrintInfo.PageSettings = CType(resources.GetObject("grdRequisiciones.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdRequisiciones.RowHeight = 17
        Me.grdRequisiciones.Size = New System.Drawing.Size(799, 335)
        Me.grdRequisiciones.TabIndex = 41
        Me.grdRequisiciones.Text = "AzTrueDBGrid1"
        Me.grdRequisiciones.PropBag = resources.GetString("grdRequisiciones.PropBag")
        '
        'lblCaja
        '
        Me.lblCaja.AutoSize = True
        Me.lblCaja.BackColor = System.Drawing.Color.Transparent
        Me.lblCaja.Location = New System.Drawing.Point(630, 43)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(31, 13)
        Me.lblCaja.TabIndex = 22
        Me.lblCaja.Text = "Caja:"
        '
        'cboCaja
        '
        Me.cboCaja.BackColor = System.Drawing.Color.White
        Me.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCaja.ItemsTable = Nothing
        Me.cboCaja.Location = New System.Drawing.Point(667, 38)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboCaja.Size = New System.Drawing.Size(210, 21)
        Me.cboCaja.TabIndex = 21
        Me.cboCaja.UIName = Nothing
        '
        'ContrarecibosAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 424)
        Me.Controls.Add(Me.grdRequisiciones)
        Me.Controls.Add(Me.cboCaja)
        Me.Controls.Add(Me.lblCaja)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "ContrarecibosAdminForm"
        Me.Text = "ContrarecibosAdminForm"
        Me.Controls.SetChildIndex(Me.lblCaja, 0)
        Me.Controls.SetChildIndex(Me.cboCaja, 0)
        Me.Controls.SetChildIndex(Me.grdRequisiciones, 0)
        CType(Me.bsContrarecibos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRequisiciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DocumentFacade = New ContrareciboFacade

        Dim ConfigFac As New Azteca.Kernel.Configuration.ConfigurationFacade
        Dim idDoc As Integer = CInt(ConfigFac.GetSystemParameter("Configuracion/Documentos/Tipos", "Contrarecibos"))
        Me.DocumentTypeID = idDoc
        Me.DocumentBindingSource = bsContrarecibos
    End Sub

    Friend WithEvents bsContrarecibos As System.Windows.Forms.BindingSource
    Friend WithEvents grdRequisiciones As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents lblCaja As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboCaja As Azteca.Windows.Tesoreria.CajasComboBox

End Class
