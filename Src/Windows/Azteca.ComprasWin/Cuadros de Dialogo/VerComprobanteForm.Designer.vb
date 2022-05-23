<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerComprobanteForm
    Inherits System.Windows.Forms.Form

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
        Me.grpFactura = New Azteca.Windows.Controls.CIGroupBox()
        Me.lblEstatus = New Azteca.Windows.Controls.CILabel()
        Me.grdConceptos = New Azteca.Windows.Controls.CIDataGridView()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsConceptos = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTotal = New Azteca.Windows.Controls.CITextBox()
        Me.txtDesc = New Azteca.Windows.Controls.CITextBox()
        Me.txtImpRet = New Azteca.Windows.Controls.CITextBox()
        Me.txtImpTras = New Azteca.Windows.Controls.CITextBox()
        Me.txtSubTotal = New Azteca.Windows.Controls.CITextBox()
        Me.txtReceptor = New Azteca.Windows.Controls.CITextBox()
        Me.txtEmisor = New Azteca.Windows.Controls.CITextBox()
        Me.txtFactura = New Azteca.Windows.Controls.CITextBox()
        Me.txtFecha = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel10 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel9 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.grpFactura.SuspendLayout()
        CType(Me.grdConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpFactura
        '
        Me.grpFactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFactura.Controls.Add(Me.lblEstatus)
        Me.grpFactura.Controls.Add(Me.grdConceptos)
        Me.grpFactura.Controls.Add(Me.txtTotal)
        Me.grpFactura.Controls.Add(Me.txtDesc)
        Me.grpFactura.Controls.Add(Me.txtImpRet)
        Me.grpFactura.Controls.Add(Me.txtImpTras)
        Me.grpFactura.Controls.Add(Me.txtSubTotal)
        Me.grpFactura.Controls.Add(Me.txtReceptor)
        Me.grpFactura.Controls.Add(Me.txtEmisor)
        Me.grpFactura.Controls.Add(Me.txtFactura)
        Me.grpFactura.Controls.Add(Me.txtFecha)
        Me.grpFactura.Controls.Add(Me.CiLabel10)
        Me.grpFactura.Controls.Add(Me.CiLabel9)
        Me.grpFactura.Controls.Add(Me.CiLabel8)
        Me.grpFactura.Controls.Add(Me.CiLabel7)
        Me.grpFactura.Controls.Add(Me.CiLabel6)
        Me.grpFactura.Controls.Add(Me.CiLabel5)
        Me.grpFactura.Controls.Add(Me.CiLabel4)
        Me.grpFactura.Controls.Add(Me.CiLabel3)
        Me.grpFactura.Controls.Add(Me.CiLabel2)
        Me.grpFactura.Location = New System.Drawing.Point(12, 12)
        Me.grpFactura.Name = "grpFactura"
        Me.grpFactura.Size = New System.Drawing.Size(619, 297)
        Me.grpFactura.TabIndex = 10
        Me.grpFactura.TabStop = False
        Me.grpFactura.Text = "Datos de la factura"
        '
        'lblEstatus
        '
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.Location = New System.Drawing.Point(76, 105)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(277, 21)
        Me.lblEstatus.TabIndex = 26
        Me.lblEstatus.Text = "Comprobante Válido"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdConceptos
        '
        Me.grdConceptos.AllowUserToAddRows = False
        Me.grdConceptos.AllowUserToDeleteRows = False
        Me.grdConceptos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdConceptos.AutoGenerateColumns = False
        Me.grdConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdConceptos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodigo, Me.colDescr, Me.colCantidad, Me.colPrecio, Me.colImporte})
        Me.grdConceptos.DataSource = Me.bsConceptos
        Me.grdConceptos.Location = New System.Drawing.Point(14, 150)
        Me.grdConceptos.Name = "grdConceptos"
        Me.grdConceptos.ReadOnly = True
        Me.grdConceptos.Size = New System.Drawing.Size(589, 141)
        Me.grdConceptos.TabIndex = 10
        '
        'colCodigo
        '
        Me.colCodigo.DataPropertyName = "NumID"
        Me.colCodigo.HeaderText = "Código"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.ReadOnly = True
        Me.colCodigo.Width = 80
        '
        'colDescr
        '
        Me.colDescr.DataPropertyName = "Descripcion"
        Me.colDescr.HeaderText = "Descripción"
        Me.colDescr.Name = "colDescr"
        Me.colDescr.ReadOnly = True
        Me.colDescr.Width = 200
        '
        'colCantidad
        '
        Me.colCantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Format = "N0"
        Me.colCantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.colCantidad.HeaderText = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.ReadOnly = True
        Me.colCantidad.Width = 80
        '
        'colPrecio
        '
        Me.colPrecio.DataPropertyName = "ValorUnitario"
        DataGridViewCellStyle2.Format = "C"
        Me.colPrecio.DefaultCellStyle = DataGridViewCellStyle2
        Me.colPrecio.HeaderText = "Precio"
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.ReadOnly = True
        Me.colPrecio.Width = 80
        '
        'colImporte
        '
        Me.colImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle3.Format = "C"
        Me.colImporte.DefaultCellStyle = DataGridViewCellStyle3
        Me.colImporte.HeaderText = "Importe"
        Me.colImporte.Name = "colImporte"
        Me.colImporte.ReadOnly = True
        '
        'bsConceptos
        '
        Me.bsConceptos.AllowNew = False
        '
        'txtTotal
        '
        Me.txtTotal.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtTotal.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtTotal.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtTotal.Location = New System.Drawing.Point(497, 124)
        Me.txtTotal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(106, 20)
        Me.txtTotal.TabIndex = 25
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesc
        '
        Me.txtDesc.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtDesc.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtDesc.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtDesc.Location = New System.Drawing.Point(497, 98)
        Me.txtDesc.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDesc.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ReadOnly = True
        Me.txtDesc.Size = New System.Drawing.Size(106, 20)
        Me.txtDesc.TabIndex = 24
        Me.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpRet
        '
        Me.txtImpRet.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtImpRet.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtImpRet.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtImpRet.Location = New System.Drawing.Point(497, 72)
        Me.txtImpRet.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImpRet.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImpRet.Name = "txtImpRet"
        Me.txtImpRet.ReadOnly = True
        Me.txtImpRet.Size = New System.Drawing.Size(106, 20)
        Me.txtImpRet.TabIndex = 23
        Me.txtImpRet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImpTras
        '
        Me.txtImpTras.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtImpTras.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtImpTras.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtImpTras.Location = New System.Drawing.Point(497, 46)
        Me.txtImpTras.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImpTras.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImpTras.Name = "txtImpTras"
        Me.txtImpTras.ReadOnly = True
        Me.txtImpTras.Size = New System.Drawing.Size(106, 20)
        Me.txtImpTras.TabIndex = 22
        Me.txtImpTras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtSubTotal.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtSubTotal.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtSubTotal.Location = New System.Drawing.Point(497, 20)
        Me.txtSubTotal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubTotal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(106, 20)
        Me.txtSubTotal.TabIndex = 21
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtReceptor
        '
        Me.txtReceptor.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtReceptor.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtReceptor.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtReceptor.Location = New System.Drawing.Point(79, 75)
        Me.txtReceptor.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtReceptor.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtReceptor.Name = "txtReceptor"
        Me.txtReceptor.ReadOnly = True
        Me.txtReceptor.Size = New System.Drawing.Size(274, 20)
        Me.txtReceptor.TabIndex = 20
        '
        'txtEmisor
        '
        Me.txtEmisor.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtEmisor.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtEmisor.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtEmisor.Location = New System.Drawing.Point(79, 49)
        Me.txtEmisor.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEmisor.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEmisor.Name = "txtEmisor"
        Me.txtEmisor.ReadOnly = True
        Me.txtEmisor.Size = New System.Drawing.Size(274, 20)
        Me.txtEmisor.TabIndex = 19
        '
        'txtFactura
        '
        Me.txtFactura.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtFactura.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtFactura.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFactura.Location = New System.Drawing.Point(271, 23)
        Me.txtFactura.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFactura.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.ReadOnly = True
        Me.txtFactura.Size = New System.Drawing.Size(82, 20)
        Me.txtFactura.TabIndex = 18
        '
        'txtFecha
        '
        Me.txtFecha.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtFecha.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtFecha.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFecha.Location = New System.Drawing.Point(79, 23)
        Me.txtFecha.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFecha.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(134, 20)
        Me.txtFecha.TabIndex = 17
        '
        'CiLabel10
        '
        Me.CiLabel10.AutoSize = True
        Me.CiLabel10.Location = New System.Drawing.Point(457, 127)
        Me.CiLabel10.Name = "CiLabel10"
        Me.CiLabel10.Size = New System.Drawing.Size(34, 13)
        Me.CiLabel10.TabIndex = 16
        Me.CiLabel10.Text = "Total:"
        '
        'CiLabel9
        '
        Me.CiLabel9.AutoSize = True
        Me.CiLabel9.Location = New System.Drawing.Point(424, 101)
        Me.CiLabel9.Name = "CiLabel9"
        Me.CiLabel9.Size = New System.Drawing.Size(67, 13)
        Me.CiLabel9.TabIndex = 15
        Me.CiLabel9.Text = "Descuentos:"
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(382, 77)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(109, 13)
        Me.CiLabel8.TabIndex = 14
        Me.CiLabel8.Text = "Impuestos Retenidos:"
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(372, 52)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(119, 13)
        Me.CiLabel7.TabIndex = 13
        Me.CiLabel7.Text = "Impuestos Trasladados:"
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(435, 27)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(56, 13)
        Me.CiLabel6.TabIndex = 12
        Me.CiLabel6.Text = "Sub Total:"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(19, 78)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(54, 13)
        Me.CiLabel5.TabIndex = 11
        Me.CiLabel5.Text = "Receptor:"
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(32, 52)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(41, 13)
        Me.CiLabel4.TabIndex = 10
        Me.CiLabel4.Text = "Emisor:"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(34, 26)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(40, 13)
        Me.CiLabel3.TabIndex = 9
        Me.CiLabel3.Text = "Fecha:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(219, 26)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(46, 13)
        Me.CiLabel2.TabIndex = 8
        Me.CiLabel2.Text = "Factura:"
        '
        'VerComprobanteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 316)
        Me.Controls.Add(Me.grpFactura)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VerComprobanteForm"
        Me.Text = "Información de Comprobante Fiscal Digital"
        Me.grpFactura.ResumeLayout(False)
        Me.grpFactura.PerformLayout()
        CType(Me.grdConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bsConceptos As System.Windows.Forms.BindingSource
    Friend WithEvents grpFactura As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents lblEstatus As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdConceptos As Azteca.Windows.Controls.CIDataGridView
    Friend WithEvents colCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTotal As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtDesc As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtImpRet As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtImpTras As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtSubTotal As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtReceptor As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtEmisor As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtFactura As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtFecha As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel10 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel9 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
End Class
