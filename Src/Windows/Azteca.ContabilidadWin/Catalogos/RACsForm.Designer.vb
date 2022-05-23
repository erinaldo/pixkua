<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RACsForm
    Inherits Azteca.Windows.Forms.BusinessForms.CatalogForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RACsForm))
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.gbxDetalle = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdRac = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsRac = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbMenu = New Azteca.Windows.Controls.CIToolBar()
        Me.btnNuevoRac = New System.Windows.Forms.ToolStripButton()
        Me.colIdRacDet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAfectador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRojo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.lblPoliza = New Azteca.Windows.Controls.CILabel()
        Me.cboPoliza = New Azteca.Windows.Controls.CIComboBox()
        Me.lblSegmentoNegocio = New Azteca.Windows.Controls.CILabel()
        Me.cboSegmentoNegocio = New Azteca.Windows.Controls.CIComboBox()
        Me.gbxDetalle.SuspendLayout()
        CType(Me.grdRac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(109, 89)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 18
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(159, 86)
        Me.txtNombre.MaxLength = 64
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(397, 20)
        Me.txtNombre.TabIndex = 19
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDetalle.Controls.Add(Me.grdRac)
        Me.gbxDetalle.Controls.Add(Me.tbMenu)
        Me.gbxDetalle.Location = New System.Drawing.Point(0, 165)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(808, 240)
        Me.gbxDetalle.TabIndex = 22
        Me.gbxDetalle.TabStop = False
        '
        'grdRac
        '
        Me.grdRac.AlternatingRows = True
        Me.grdRac.DataSource = Me.bsRac
        Me.grdRac.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRac.IDCatalogField = "Id"
        Me.grdRac.Images.Add(CType(resources.GetObject("grdRac.Images"), System.Drawing.Image))
        Me.grdRac.Location = New System.Drawing.Point(3, 55)
        Me.grdRac.Name = "grdRac"
        Me.grdRac.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdRac.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdRac.PreviewInfo.ZoomFactor = 75.0R
        Me.grdRac.PrintInfo.PageSettings = CType(resources.GetObject("grdRac.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdRac.Size = New System.Drawing.Size(802, 182)
        Me.grdRac.TabIndex = 27
        Me.grdRac.PropBag = resources.GetString("grdRac.PropBag")
        '
        'tbMenu
        '
        Me.tbMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoRac})
        Me.tbMenu.Location = New System.Drawing.Point(3, 16)
        Me.tbMenu.Name = "tbMenu"
        Me.tbMenu.Size = New System.Drawing.Size(802, 39)
        Me.tbMenu.TabIndex = 28
        Me.tbMenu.Text = "CiToolBar1"
        '
        'btnNuevoRac
        '
        Me.btnNuevoRac.Image = CType(resources.GetObject("btnNuevoRac.Image"), System.Drawing.Image)
        Me.btnNuevoRac.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevoRac.Name = "btnNuevoRac"
        Me.btnNuevoRac.Size = New System.Drawing.Size(131, 36)
        Me.btnNuevoRac.Text = "Nuevo elemento"
        '
        'colIdRacDet
        '
        Me.colIdRacDet.DataPropertyName = "Id"
        Me.colIdRacDet.HeaderText = "IdRacDet"
        Me.colIdRacDet.MinimumWidth = 2
        Me.colIdRacDet.Name = "colIdRacDet"
        Me.colIdRacDet.ReadOnly = True
        Me.colIdRacDet.Width = 2
        '
        'colCuenta
        '
        Me.colCuenta.DataPropertyName = "Cuenta"
        Me.colCuenta.HeaderText = "Cuenta"
        Me.colCuenta.Name = "colCuenta"
        Me.colCuenta.ReadOnly = True
        Me.colCuenta.Width = 110
        '
        'colEntidad
        '
        Me.colEntidad.DataPropertyName = "Entidad"
        Me.colEntidad.HeaderText = "Entidad"
        Me.colEntidad.Name = "colEntidad"
        Me.colEntidad.ReadOnly = True
        Me.colEntidad.Width = 150
        '
        'colConcepto
        '
        Me.colConcepto.DataPropertyName = "Concepto"
        Me.colConcepto.HeaderText = "Concepto"
        Me.colConcepto.Name = "colConcepto"
        Me.colConcepto.ReadOnly = True
        Me.colConcepto.Width = 250
        '
        'colAfectador
        '
        Me.colAfectador.DataPropertyName = "Afectador"
        Me.colAfectador.HeaderText = "Afectador"
        Me.colAfectador.Name = "colAfectador"
        Me.colAfectador.ReadOnly = True
        Me.colAfectador.Width = 65
        '
        'colImporte
        '
        Me.colImporte.DataPropertyName = "Importe"
        Me.colImporte.HeaderText = "Importe"
        Me.colImporte.Name = "colImporte"
        Me.colImporte.ReadOnly = True
        '
        'colRojo
        '
        Me.colRojo.DataPropertyName = "Rojo"
        Me.colRojo.HeaderText = "Rojo"
        Me.colRojo.Name = "colRojo"
        Me.colRojo.ReadOnly = True
        Me.colRojo.Width = 30
        '
        'lblPoliza
        '
        Me.lblPoliza.AutoSize = True
        Me.lblPoliza.Location = New System.Drawing.Point(118, 114)
        Me.lblPoliza.Name = "lblPoliza"
        Me.lblPoliza.Size = New System.Drawing.Size(35, 13)
        Me.lblPoliza.TabIndex = 21
        Me.lblPoliza.Text = "Poliza"
        '
        'cboPoliza
        '
        Me.cboPoliza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPoliza.FormattingEnabled = True
        Me.cboPoliza.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboPoliza.ItemsTable = Nothing
        Me.cboPoliza.Location = New System.Drawing.Point(159, 111)
        Me.cboPoliza.Name = "cboPoliza"
        Me.cboPoliza.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboPoliza.Size = New System.Drawing.Size(397, 21)
        Me.cboPoliza.TabIndex = 20
        Me.cboPoliza.UIName = Nothing
        '
        'lblSegmentoNegocio
        '
        Me.lblSegmentoNegocio.AutoSize = True
        Me.lblSegmentoNegocio.Location = New System.Drawing.Point(55, 138)
        Me.lblSegmentoNegocio.Name = "lblSegmentoNegocio"
        Me.lblSegmentoNegocio.Size = New System.Drawing.Size(98, 13)
        Me.lblSegmentoNegocio.TabIndex = 23
        Me.lblSegmentoNegocio.Text = "Segmento Negocio"
        '
        'cboSegmentoNegocio
        '
        Me.cboSegmentoNegocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSegmentoNegocio.FormattingEnabled = True
        Me.cboSegmentoNegocio.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboSegmentoNegocio.ItemsTable = Nothing
        Me.cboSegmentoNegocio.Location = New System.Drawing.Point(159, 136)
        Me.cboSegmentoNegocio.Name = "cboSegmentoNegocio"
        Me.cboSegmentoNegocio.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboSegmentoNegocio.Size = New System.Drawing.Size(397, 21)
        Me.cboSegmentoNegocio.TabIndex = 24
        Me.cboSegmentoNegocio.UIName = Nothing
        '
        'RACsForm
        '
        Me.AllowRecordNavigation = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 430)
        Me.CodeFieldLocation = New System.Drawing.Point(24, 55)
        Me.Controls.Add(Me.cboSegmentoNegocio)
        Me.Controls.Add(Me.lblSegmentoNegocio)
        Me.Controls.Add(Me.gbxDetalle)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.cboPoliza)
        Me.Controls.Add(Me.lblPoliza)
        Me.Name = "RACsForm"
        Me.Text = "RACsForm"
        Me.Controls.SetChildIndex(Me.lblPoliza, 0)
        Me.Controls.SetChildIndex(Me.cboPoliza, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.lblNombre, 0)
        Me.Controls.SetChildIndex(Me.gbxDetalle, 0)
        Me.Controls.SetChildIndex(Me.lblSegmentoNegocio, 0)
        Me.Controls.SetChildIndex(Me.cboSegmentoNegocio, 0)
        Me.gbxDetalle.ResumeLayout(False)
        Me.gbxDetalle.PerformLayout()
        CType(Me.grdRac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbMenu.ResumeLayout(False)
        Me.tbMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents gbxDetalle As Azteca.Windows.Controls.CIGroupBox

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Facade = New RacFacade
        LicenseModule = Kernel.Licensing.LicenseModule.Accounting
    End Sub
    Friend WithEvents bsRac As System.Windows.Forms.BindingSource
    Friend WithEvents lblPoliza As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboPoliza As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents grdRac As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents tbMenu As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnNuevoRac As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblSegmentoNegocio As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboSegmentoNegocio As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents colIdRacDet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEntidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAfectador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRojo As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
