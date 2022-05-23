<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RacForm
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim Style121 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style122 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style123 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style124 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style125 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RacForm))
        Dim Style126 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style127 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style128 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style129 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style130 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style131 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style132 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style133 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style134 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style135 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style136 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style137 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style138 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style139 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style140 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style141 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style142 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style143 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style144 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.cboSegmentoNegocio = New Azteca.Windows.Controls.CIComboBox()
        Me.lblSegmentoNegocio = New Azteca.Windows.Controls.CILabel()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.gbxDetalle = New Azteca.Windows.Controls.CIGroupBox()
        Me.dropAfectador = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.grdRac = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsRacDet = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.bsEntidades = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAfectador = New System.Windows.Forms.BindingSource(Me.components)
        Me.dropEntidad = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.bsImportes = New System.Windows.Forms.BindingSource(Me.components)
        Me.dropImportes = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.gbxDetalle.SuspendLayout()
        CType(Me.dropAfectador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRacDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAfectador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropEntidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsImportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropImportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboSegmentoNegocio
        '
        Me.cboSegmentoNegocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSegmentoNegocio.FormattingEnabled = True
        Me.cboSegmentoNegocio.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboSegmentoNegocio.ItemsTable = Nothing
        Me.cboSegmentoNegocio.Location = New System.Drawing.Point(135, 43)
        Me.cboSegmentoNegocio.Name = "cboSegmentoNegocio"
        Me.cboSegmentoNegocio.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboSegmentoNegocio.Size = New System.Drawing.Size(329, 21)
        Me.cboSegmentoNegocio.TabIndex = 28
        Me.cboSegmentoNegocio.UIName = Nothing
        '
        'lblSegmentoNegocio
        '
        Me.lblSegmentoNegocio.AutoSize = True
        Me.lblSegmentoNegocio.Location = New System.Drawing.Point(31, 47)
        Me.lblSegmentoNegocio.Name = "lblSegmentoNegocio"
        Me.lblSegmentoNegocio.Size = New System.Drawing.Size(98, 13)
        Me.lblSegmentoNegocio.TabIndex = 27
        Me.lblSegmentoNegocio.Text = "Segmento Negocio"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(85, 23)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 25
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(135, 20)
        Me.txtNombre.MaxLength = 64
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(329, 20)
        Me.txtNombre.TabIndex = 26
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDetalle.Controls.Add(Me.dropImportes)
        Me.gbxDetalle.Controls.Add(Me.dropEntidad)
        Me.gbxDetalle.Controls.Add(Me.dropAfectador)
        Me.gbxDetalle.Controls.Add(Me.grdRac)
        Me.gbxDetalle.Location = New System.Drawing.Point(34, 68)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(758, 289)
        Me.gbxDetalle.TabIndex = 29
        Me.gbxDetalle.TabStop = False
        '
        'dropAfectador
        '
        Me.dropAfectador.AllowColMove = True
        Me.dropAfectador.AllowColSelect = True
        Me.dropAfectador.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.dropAfectador.AlternatingRows = False
        Me.dropAfectador.CaptionStyle = Style121
        Me.dropAfectador.ColumnCaptionHeight = 17
        Me.dropAfectador.ColumnFooterHeight = 17
        Me.dropAfectador.DataSource = Me.bsAfectador
        Me.dropAfectador.DisplayMember = "Afectador"
        Me.dropAfectador.EvenRowStyle = Style122
        Me.dropAfectador.FetchRowStyles = False
        Me.dropAfectador.FooterStyle = Style123
        Me.dropAfectador.HeadingStyle = Style124
        Me.dropAfectador.HighLightRowStyle = Style125
        Me.dropAfectador.Images.Add(CType(resources.GetObject("dropAfectador.Images"), System.Drawing.Image))
        Me.dropAfectador.Location = New System.Drawing.Point(6, 94)
        Me.dropAfectador.Name = "dropAfectador"
        Me.dropAfectador.OddRowStyle = Style126
        Me.dropAfectador.RecordSelectorStyle = Style127
        Me.dropAfectador.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropAfectador.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropAfectador.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropAfectador.ScrollTips = False
        Me.dropAfectador.Size = New System.Drawing.Size(323, 135)
        Me.dropAfectador.Style = Style128
        Me.dropAfectador.TabIndex = 48
        Me.dropAfectador.TabStop = False
        Me.dropAfectador.Text = "C1TrueDBDropdown1"
        Me.dropAfectador.ValueMember = "Abrev"
        Me.dropAfectador.ValueTranslate = True
        Me.dropAfectador.Visible = False
        Me.dropAfectador.PropBag = resources.GetString("dropAfectador.PropBag")
        '
        'grdRac
        '
        Me.grdRac.AllowAddNew = True
        Me.grdRac.DataSource = Me.bsRacDet
        Me.grdRac.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRac.IDCatalogField = "Id"
        Me.grdRac.Images.Add(CType(resources.GetObject("grdRac.Images"), System.Drawing.Image))
        Me.grdRac.Images.Add(CType(resources.GetObject("grdRac.Images1"), System.Drawing.Image))
        Me.grdRac.Location = New System.Drawing.Point(3, 16)
        Me.grdRac.Name = "grdRac"
        Me.grdRac.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdRac.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdRac.PreviewInfo.ZoomFactor = 75.0R
        Me.grdRac.PrintInfo.PageSettings = CType(resources.GetObject("grdRac.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdRac.ShowEditButton = False
        Me.grdRac.Size = New System.Drawing.Size(752, 270)
        Me.grdRac.TabIndex = 27
        Me.grdRac.PropBag = resources.GetString("grdRac.PropBag")
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(705, 368)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 30
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = Global.Azteca.Windows.Contabilidad.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(624, 368)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 29
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'dropEntidad
        '
        Me.dropEntidad.AllowColMove = True
        Me.dropEntidad.AllowColSelect = True
        Me.dropEntidad.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.dropEntidad.AlternatingRows = False
        Me.dropEntidad.CaptionStyle = Style129
        Me.dropEntidad.ColumnCaptionHeight = 17
        Me.dropEntidad.ColumnFooterHeight = 17
        Me.dropEntidad.DataSource = Me.bsEntidades
        Me.dropEntidad.DisplayMember = "Entidad"
        Me.dropEntidad.EvenRowStyle = Style130
        Me.dropEntidad.FetchRowStyles = False
        Me.dropEntidad.FooterStyle = Style131
        Me.dropEntidad.HeadingStyle = Style132
        Me.dropEntidad.HighLightRowStyle = Style133
        Me.dropEntidad.Images.Add(CType(resources.GetObject("dropEntidad.Images"), System.Drawing.Image))
        Me.dropEntidad.Location = New System.Drawing.Point(198, 94)
        Me.dropEntidad.Name = "dropEntidad"
        Me.dropEntidad.OddRowStyle = Style134
        Me.dropEntidad.RecordSelectorStyle = Style135
        Me.dropEntidad.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropEntidad.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropEntidad.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropEntidad.ScrollTips = False
        Me.dropEntidad.Size = New System.Drawing.Size(306, 135)
        Me.dropEntidad.Style = Style136
        Me.dropEntidad.TabIndex = 49
        Me.dropEntidad.TabStop = False
        Me.dropEntidad.Text = "C1TrueDBDropdown1"
        Me.dropEntidad.ValueMember = "IdEntidad"
        Me.dropEntidad.ValueTranslate = True
        Me.dropEntidad.Visible = False
        Me.dropEntidad.PropBag = resources.GetString("dropEntidad.PropBag")
        '
        'dropImportes
        '
        Me.dropImportes.AllowColMove = True
        Me.dropImportes.AllowColSelect = True
        Me.dropImportes.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.dropImportes.AlternatingRows = False
        Me.dropImportes.CaptionStyle = Style137
        Me.dropImportes.ColumnCaptionHeight = 17
        Me.dropImportes.ColumnFooterHeight = 17
        Me.dropImportes.DataSource = Me.bsImportes
        Me.dropImportes.DisplayMember = "Importe"
        Me.dropImportes.EvenRowStyle = Style138
        Me.dropImportes.FetchRowStyles = False
        Me.dropImportes.FooterStyle = Style139
        Me.dropImportes.HeadingStyle = Style140
        Me.dropImportes.HighLightRowStyle = Style141
        Me.dropImportes.Images.Add(CType(resources.GetObject("dropImportes.Images"), System.Drawing.Image))
        Me.dropImportes.Location = New System.Drawing.Point(465, 94)
        Me.dropImportes.Name = "dropImportes"
        Me.dropImportes.OddRowStyle = Style142
        Me.dropImportes.RecordSelectorStyle = Style143
        Me.dropImportes.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.dropImportes.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.dropImportes.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.dropImportes.ScrollTips = False
        Me.dropImportes.Size = New System.Drawing.Size(306, 135)
        Me.dropImportes.Style = Style144
        Me.dropImportes.TabIndex = 50
        Me.dropImportes.TabStop = False
        Me.dropImportes.Text = "C1TrueDBDropdown1"
        Me.dropImportes.ValueMember = "IdImporte"
        Me.dropImportes.ValueTranslate = True
        Me.dropImportes.Visible = False
        Me.dropImportes.PropBag = resources.GetString("dropImportes.PropBag")
        '
        'RacForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 403)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gbxDetalle)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cboSegmentoNegocio)
        Me.Controls.Add(Me.lblSegmentoNegocio)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "RacForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RacForm"
        Me.gbxDetalle.ResumeLayout(False)
        CType(Me.dropAfectador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRacDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAfectador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropEntidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsImportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropImportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboSegmentoNegocio As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents lblSegmentoNegocio As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents gbxDetalle As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdRac As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents bsEntidades As System.Windows.Forms.BindingSource
    Friend WithEvents bsAfectador As System.Windows.Forms.BindingSource
    Friend WithEvents bsRacDet As System.Windows.Forms.BindingSource
    Friend WithEvents dropAfectador As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents dropImportes As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents bsImportes As System.Windows.Forms.BindingSource
    Friend WithEvents dropEntidad As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
End Class
