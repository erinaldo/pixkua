<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContabilizacionConfigForm
    Inherits Azteca.Windows.Forms.BusinessForms.CatalogForm

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
        Me.lblVista = New Azteca.Windows.Controls.CILabel()
        Me.grdWorkflow = New Azteca.Windows.Controls.CIDataGridView()
        Me.colIdStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVariantes = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colRac = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colIdContabilizacionDocumentoDet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblWorkflow = New Azteca.Windows.Controls.CILabel()
        Me.cboVista = New Azteca.Windows.Controls.CIComboBox()
        CType(Me.grdWorkflow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVista
        '
        Me.lblVista.AutoSize = True
        Me.lblVista.Location = New System.Drawing.Point(14, 107)
        Me.lblVista.Name = "lblVista"
        Me.lblVista.Size = New System.Drawing.Size(75, 13)
        Me.lblVista.TabIndex = 2
        Me.lblVista.Text = "Vista Contable"
        '
        'grdWorkflow
        '
        Me.grdWorkflow.AllowUserToAddRows = False
        Me.grdWorkflow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdWorkflow.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.grdWorkflow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdWorkflow.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdStatus, Me.colStatus, Me.colVariantes, Me.colRac, Me.colIdContabilizacionDocumentoDet})
        Me.grdWorkflow.Location = New System.Drawing.Point(104, 133)
        Me.grdWorkflow.Name = "grdWorkflow"
        Me.grdWorkflow.Size = New System.Drawing.Size(550, 224)
        Me.grdWorkflow.TabIndex = 5
        '
        'colIdStatus
        '
        Me.colIdStatus.DataPropertyName = "IdStatus"
        Me.colIdStatus.Frozen = True
        Me.colIdStatus.HeaderText = "IdStatus"
        Me.colIdStatus.MinimumWidth = 2
        Me.colIdStatus.Name = "colIdStatus"
        Me.colIdStatus.ReadOnly = True
        Me.colIdStatus.Width = 2
        '
        'colStatus
        '
        Me.colStatus.DataPropertyName = "Status"
        Me.colStatus.Frozen = True
        Me.colStatus.HeaderText = "Estatus"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.Width = 160
        '
        'colVariantes
        '
        Me.colVariantes.DataPropertyName = "Variante"
        Me.colVariantes.FillWeight = 35.0!
        Me.colVariantes.Frozen = True
        Me.colVariantes.HeaderText = "Variante"
        Me.colVariantes.Name = "colVariantes"
        Me.colVariantes.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colVariantes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colVariantes.Width = 49
        '
        'colRac
        '
        Me.colRac.DataPropertyName = "Rac"
        Me.colRac.Frozen = True
        Me.colRac.HeaderText = "RAC"
        Me.colRac.Name = "colRac"
        Me.colRac.ReadOnly = True
        Me.colRac.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colRac.Width = 270
        '
        'colIdContabilizacionDocumentoDet
        '
        Me.colIdContabilizacionDocumentoDet.DataPropertyName = "IdContabilizacionDocumentoDet"
        Me.colIdContabilizacionDocumentoDet.Frozen = True
        Me.colIdContabilizacionDocumentoDet.HeaderText = "IdDet"
        Me.colIdContabilizacionDocumentoDet.MinimumWidth = 2
        Me.colIdContabilizacionDocumentoDet.Name = "colIdContabilizacionDocumentoDet"
        Me.colIdContabilizacionDocumentoDet.ReadOnly = True
        Me.colIdContabilizacionDocumentoDet.Width = 2
        '
        'lblWorkflow
        '
        Me.lblWorkflow.AutoSize = True
        Me.lblWorkflow.ForeColor = System.Drawing.Color.Blue
        Me.lblWorkflow.Location = New System.Drawing.Point(14, 138)
        Me.lblWorkflow.Name = "lblWorkflow"
        Me.lblWorkflow.Size = New System.Drawing.Size(83, 13)
        Me.lblWorkflow.TabIndex = 6
        Me.lblWorkflow.Text = "Flujo de Trabajo"
        '
        'cboVista
        '
        Me.cboVista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVista.FormattingEnabled = True
        Me.cboVista.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboVista.ItemsTable = Nothing
        Me.cboVista.Location = New System.Drawing.Point(105, 104)
        Me.cboVista.Name = "cboVista"
        Me.cboVista.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboVista.Size = New System.Drawing.Size(523, 21)
        Me.cboVista.TabIndex = 20
        Me.cboVista.UIName = Nothing
        '
        'ContabilizacionConfigForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 386)
        Me.Controls.Add(Me.cboVista)
        Me.Controls.Add(Me.lblWorkflow)
        Me.Controls.Add(Me.grdWorkflow)
        Me.Controls.Add(Me.lblVista)
        Me.Name = "ContabilizacionConfigForm"
        Me.Text = "ContabilizacionConfigForm"
        Me.Controls.SetChildIndex(Me.lblVista, 0)
        Me.Controls.SetChildIndex(Me.grdWorkflow, 0)
        Me.Controls.SetChildIndex(Me.lblWorkflow, 0)
        Me.Controls.SetChildIndex(Me.cboVista, 0)
        CType(Me.grdWorkflow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVista As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdWorkflow As Azteca.Windows.Controls.CIDataGridView
    Friend WithEvents lblWorkflow As Azteca.Windows.Controls.CILabel

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New ContabilizadorDocumentosFacade
        LicenseModule = Kernel.Licensing.LicenseModule.Accounting
    End Sub
    Friend WithEvents cboVista As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents colIdStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVariantes As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colRac As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colIdContabilizacionDocumentoDet As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
