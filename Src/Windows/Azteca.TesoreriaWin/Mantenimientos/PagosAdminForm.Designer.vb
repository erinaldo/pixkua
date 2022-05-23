<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagosAdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PagosAdminForm))
        Me.grdPagos = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsPagos = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboCaja = New Azteca.Windows.Tesoreria.CajasComboBox()
        Me.lblCaja = New Azteca.Windows.Controls.CILabel()
        CType(Me.grdPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdPagos
        '
        Me.grdPagos.AlternatingRows = True
        Me.grdPagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPagos.DataSource = Me.bsPagos
        Me.grdPagos.FilterBar = True
        Me.grdPagos.Images.Add(CType(resources.GetObject("grdPagos.Images"), System.Drawing.Image))
        Me.grdPagos.Images.Add(CType(resources.GetObject("grdPagos.Images1"), System.Drawing.Image))
        Me.grdPagos.Location = New System.Drawing.Point(182, 64)
        Me.grdPagos.Name = "grdPagos"
        Me.grdPagos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdPagos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdPagos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdPagos.PrintInfo.PageSettings = CType(resources.GetObject("grdPagos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdPagos.RowHeight = 17
        Me.grdPagos.Size = New System.Drawing.Size(1044, 338)
        Me.grdPagos.TabIndex = 42
        Me.grdPagos.Text = "AzTrueDBGrid1"
        Me.grdPagos.PropBag = resources.GetString("grdPagos.PropBag")
        '
        'cboCaja
        '
        Me.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCaja.ItemsTable = Nothing
        Me.cboCaja.Location = New System.Drawing.Point(688, 38)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboCaja.Size = New System.Drawing.Size(259, 21)
        Me.cboCaja.TabIndex = 43
        Me.cboCaja.UIName = Nothing
        '
        'lblCaja
        '
        Me.lblCaja.AutoSize = True
        Me.lblCaja.BackColor = System.Drawing.Color.White
        Me.lblCaja.ForeColor = System.Drawing.Color.Black
        Me.lblCaja.Location = New System.Drawing.Point(652, 42)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(31, 13)
        Me.lblCaja.TabIndex = 44
        Me.lblCaja.Text = "Caja:"
        '
        'PagosAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 424)
        Me.Controls.Add(Me.cboCaja)
        Me.Controls.Add(Me.lblCaja)
        Me.Controls.Add(Me.grdPagos)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "PagosAdminForm"
        Me.Text = "PagosAdminForm"
        Me.Controls.SetChildIndex(Me.grdPagos, 0)
        Me.Controls.SetChildIndex(Me.lblCaja, 0)
        Me.Controls.SetChildIndex(Me.cboCaja, 0)
        CType(Me.grdPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DocumentFacade = New PagoFacade

        Dim ConfigFac As New Azteca.Kernel.Configuration.ConfigurationFacade
        Dim idDoc As Integer = CInt(ConfigFac.GetSystemParameter("Configuracion/Documentos/Tipos", "Pagos"))
        Me.DocumentTypeID = idDoc
        Me.DocumentBindingSource = bsPagos
    End Sub
    Friend WithEvents grdPagos As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents bsPagos As System.Windows.Forms.BindingSource
    Friend WithEvents cboCaja As Azteca.Windows.Tesoreria.CajasComboBox
    Friend WithEvents lblCaja As Azteca.Windows.Controls.CILabel

End Class
