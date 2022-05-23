<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PolizaEditForm
    Inherits Azteca.Windows.Forms.BaseForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PolizaEditForm))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grdPoliza = New Azteca.Windows.Controls.CIDataGridView()
        Me.CiToolBar1 = New Azteca.Windows.Controls.CIToolBar()
        Me.btnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.colIdSegmento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiarioSegmento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiarioCuenta = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDiarioConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiarioCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiarioAbono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReferenciaDiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdPolizaDet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdPoliza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CiToolBar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdPoliza
        '
        Me.grdPoliza.AllowUserToAddRows = False
        Me.grdPoliza.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grdPoliza.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdPoliza.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.grdPoliza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPoliza.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdSegmento, Me.colDiarioSegmento, Me.colDiarioCuenta, Me.colDiarioConcepto, Me.colDiarioCargo, Me.colDiarioAbono, Me.colReferenciaDiario, Me.colIdPolizaDet})
        Me.grdPoliza.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPoliza.Location = New System.Drawing.Point(0, 25)
        Me.grdPoliza.Name = "grdPoliza"
        Me.grdPoliza.RowHeadersWidth = 25
        Me.grdPoliza.Size = New System.Drawing.Size(677, 519)
        Me.grdPoliza.TabIndex = 4
        '
        'CiToolBar1
        '
        Me.CiToolBar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnActualizar, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.btnCancelar})
        Me.CiToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.CiToolBar1.Name = "CiToolBar1"
        Me.CiToolBar1.Size = New System.Drawing.Size(677, 25)
        Me.CiToolBar1.TabIndex = 5
        Me.CiToolBar1.Text = "CiToolBar1"
        '
        'btnActualizar
        '
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(69, 22)
        Me.btnActualizar.Text = "Guardar"
        Me.btnActualizar.ToolTipText = "Entregar cantidad especificada"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Enabled = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(90, 25)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(113, 22)
        Me.btnCancelar.Text = "Cancelar Acción"
        '
        'colIdSegmento
        '
        Me.colIdSegmento.DataPropertyName = "IdSegmento"
        Me.colIdSegmento.Frozen = True
        Me.colIdSegmento.HeaderText = "#Seg"
        Me.colIdSegmento.Name = "colIdSegmento"
        Me.colIdSegmento.Width = 55
        '
        'colDiarioSegmento
        '
        Me.colDiarioSegmento.DataPropertyName = "Segmento"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colDiarioSegmento.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDiarioSegmento.Frozen = True
        Me.colDiarioSegmento.HeaderText = "Segmento"
        Me.colDiarioSegmento.Name = "colDiarioSegmento"
        Me.colDiarioSegmento.ReadOnly = True
        Me.colDiarioSegmento.Width = 90
        '
        'colDiarioCuenta
        '
        Me.colDiarioCuenta.DataPropertyName = "Cuenta"
        Me.colDiarioCuenta.Frozen = True
        Me.colDiarioCuenta.HeaderText = "Cuenta"
        Me.colDiarioCuenta.Name = "colDiarioCuenta"
        Me.colDiarioCuenta.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDiarioCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colDiarioCuenta.Width = 110
        '
        'colDiarioConcepto
        '
        Me.colDiarioConcepto.DataPropertyName = "Observaciones"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colDiarioConcepto.DefaultCellStyle = DataGridViewCellStyle3
        Me.colDiarioConcepto.Frozen = True
        Me.colDiarioConcepto.HeaderText = "Concepto"
        Me.colDiarioConcepto.Name = "colDiarioConcepto"
        Me.colDiarioConcepto.Width = 140
        '
        'colDiarioCargo
        '
        Me.colDiarioCargo.DataPropertyName = "Cargo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colDiarioCargo.DefaultCellStyle = DataGridViewCellStyle4
        Me.colDiarioCargo.Frozen = True
        Me.colDiarioCargo.HeaderText = "Cargo"
        Me.colDiarioCargo.Name = "colDiarioCargo"
        Me.colDiarioCargo.ReadOnly = True
        Me.colDiarioCargo.Width = 70
        '
        'colDiarioAbono
        '
        Me.colDiarioAbono.DataPropertyName = "Abono"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colDiarioAbono.DefaultCellStyle = DataGridViewCellStyle5
        Me.colDiarioAbono.Frozen = True
        Me.colDiarioAbono.HeaderText = "Abono"
        Me.colDiarioAbono.Name = "colDiarioAbono"
        Me.colDiarioAbono.ReadOnly = True
        Me.colDiarioAbono.Width = 70
        '
        'colReferenciaDiario
        '
        Me.colReferenciaDiario.DataPropertyName = "Referencia"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colReferenciaDiario.DefaultCellStyle = DataGridViewCellStyle6
        Me.colReferenciaDiario.Frozen = True
        Me.colReferenciaDiario.HeaderText = "Referencia"
        Me.colReferenciaDiario.Name = "colReferenciaDiario"
        Me.colReferenciaDiario.ReadOnly = True
        Me.colReferenciaDiario.Width = 90
        '
        'colIdPolizaDet
        '
        Me.colIdPolizaDet.DataPropertyName = "IdPolizaDet"
        Me.colIdPolizaDet.Frozen = True
        Me.colIdPolizaDet.HeaderText = "IdPolizaDet"
        Me.colIdPolizaDet.MinimumWidth = 2
        Me.colIdPolizaDet.Name = "colIdPolizaDet"
        Me.colIdPolizaDet.ReadOnly = True
        Me.colIdPolizaDet.Visible = False
        Me.colIdPolizaDet.Width = 2
        '
        'PolizaEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 544)
        Me.Controls.Add(Me.grdPoliza)
        Me.Controls.Add(Me.CiToolBar1)
        Me.Name = "PolizaEditForm"
        Me.Text = "Edición de la póliza..."
        CType(Me.grdPoliza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CiToolBar1.ResumeLayout(False)
        Me.CiToolBar1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdPoliza As Azteca.Windows.Controls.CIDataGridView
    Friend WithEvents CiToolBar1 As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents colIdSegmento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDiarioSegmento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDiarioCuenta As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDiarioConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDiarioCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDiarioAbono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colReferenciaDiario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIdPolizaDet As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
