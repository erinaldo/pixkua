<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TiposCambioForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.grdTiposCambio = New Azteca.Windows.Controls.CIDataGridView()
        Me.colDivisa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLastUpdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsTiposCambio = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblDivisaBase = New System.Windows.Forms.Label()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        CType(Me.grdTiposCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTiposCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(7, 14)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(66, 13)
        Me.CiLabel1.TabIndex = 5
        Me.CiLabel1.Text = "Divisa Base:"
        '
        'grdTiposCambio
        '
        Me.grdTiposCambio.AllowUserToAddRows = False
        Me.grdTiposCambio.AllowUserToDeleteRows = False
        Me.grdTiposCambio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdTiposCambio.AutoGenerateColumns = False
        Me.grdTiposCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTiposCambio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDivisa, Me.colCompra, Me.colVenta, Me.colLastUpdate})
        Me.grdTiposCambio.DataSource = Me.bsTiposCambio
        Me.grdTiposCambio.Location = New System.Drawing.Point(12, 35)
        Me.grdTiposCambio.Name = "grdTiposCambio"
        Me.grdTiposCambio.ReadOnly = True
        Me.grdTiposCambio.Size = New System.Drawing.Size(570, 273)
        Me.grdTiposCambio.TabIndex = 8
        '
        'colDivisa
        '
        Me.colDivisa.DataPropertyName = "Divisa"
        Me.colDivisa.HeaderText = "Divisa"
        Me.colDivisa.Name = "colDivisa"
        Me.colDivisa.ReadOnly = True
        Me.colDivisa.Width = 150
        '
        'colCompra
        '
        Me.colCompra.DataPropertyName = "PrecioCompra"
        DataGridViewCellStyle1.Format = "C4"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colCompra.DefaultCellStyle = DataGridViewCellStyle1
        Me.colCompra.HeaderText = "Compra"
        Me.colCompra.Name = "colCompra"
        Me.colCompra.ReadOnly = True
        Me.colCompra.Width = 80
        '
        'colVenta
        '
        Me.colVenta.DataPropertyName = "PrecioVenta"
        DataGridViewCellStyle2.Format = "C4"
        Me.colVenta.DefaultCellStyle = DataGridViewCellStyle2
        Me.colVenta.HeaderText = "Venta"
        Me.colVenta.Name = "colVenta"
        Me.colVenta.ReadOnly = True
        Me.colVenta.Width = 80
        '
        'colLastUpdate
        '
        Me.colLastUpdate.DataPropertyName = "LastUpdate"
        DataGridViewCellStyle3.Format = "dd/MM/yyyy HH:mm"
        DataGridViewCellStyle3.NullValue = "NUNCA"
        Me.colLastUpdate.DefaultCellStyle = DataGridViewCellStyle3
        Me.colLastUpdate.HeaderText = "Ultima Actualización"
        Me.colLastUpdate.Name = "colLastUpdate"
        Me.colLastUpdate.ReadOnly = True
        Me.colLastUpdate.Width = 150
        '
        'lblDivisaBase
        '
        Me.lblDivisaBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDivisaBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivisaBase.Location = New System.Drawing.Point(79, 9)
        Me.lblDivisaBase.Name = "lblDivisaBase"
        Me.lblDivisaBase.Size = New System.Drawing.Size(503, 23)
        Me.lblDivisaBase.TabIndex = 9
        Me.lblDivisaBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Owner = Me
        '
        'TiposCambioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 333)
        Me.Controls.Add(Me.lblDivisaBase)
        Me.Controls.Add(Me.grdTiposCambio)
        Me.Controls.Add(Me.CiLabel1)
        Me.Name = "TiposCambioForm"
        Me.Text = "TiposCambioForm"
        Me.Controls.SetChildIndex(Me.CiLabel1, 0)
        Me.Controls.SetChildIndex(Me.grdTiposCambio, 0)
        Me.Controls.SetChildIndex(Me.lblDivisaBase, 0)
        CType(Me.grdTiposCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTiposCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdTiposCambio As Azteca.Windows.Controls.CIDataGridView
    Friend WithEvents lblDivisaBase As System.Windows.Forms.Label
    Friend WithEvents colDivisa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLastUpdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Private WithEvents bsTiposCambio As System.Windows.Forms.BindingSource
End Class
