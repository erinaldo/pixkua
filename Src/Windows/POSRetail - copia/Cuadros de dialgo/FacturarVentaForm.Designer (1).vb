<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturarVentaForm
    Inherits Azteca.Windows.Forms.BaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FacturarVentaForm))
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.pnlUsuario = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.lblTotCantidadTXT = New Azteca.Windows.Controls.CILabel()
        Me.lblTotTotalTXT = New Azteca.Windows.Controls.CILabel()
        Me.lblTotDescuentosTXT = New Azteca.Windows.Controls.CILabel()
        Me.lblTotImpuestoTXT = New Azteca.Windows.Controls.CILabel()
        Me.lblTotSubtotalTXT = New Azteca.Windows.Controls.CILabel()
        Me.lblTotCantidad = New Azteca.Windows.Controls.CILabel()
        Me.lblTotTotal = New Azteca.Windows.Controls.CILabel()
        Me.lblTotDescto = New Azteca.Windows.Controls.CILabel()
        Me.lblTotImpuestos = New Azteca.Windows.Controls.CILabel()
        Me.lblTotSubtotal = New Azteca.Windows.Controls.CILabel()
        Me.lblCliente = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.selVenta = New Azteca.Windows.Ventas.VentaSelector()
        Me.selCliente = New Azteca.Windows.Ventas.Retail.ClienteExpressSelector()
        Me.pnlUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(393, 304)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 2
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(312, 304)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'pnlUsuario
        '
        Me.pnlUsuario.BackColor = System.Drawing.Color.Transparent
        Me.pnlUsuario.Border = False
        Me.pnlUsuario.BorderColor = System.Drawing.Color.Olive
        Me.pnlUsuario.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlUsuario.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlUsuario.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlUsuario.Controls.Add(Me.lblTotCantidadTXT)
        Me.pnlUsuario.Controls.Add(Me.lblTotTotalTXT)
        Me.pnlUsuario.Controls.Add(Me.lblTotDescuentosTXT)
        Me.pnlUsuario.Controls.Add(Me.lblTotImpuestoTXT)
        Me.pnlUsuario.Controls.Add(Me.lblTotSubtotalTXT)
        Me.pnlUsuario.Controls.Add(Me.lblTotCantidad)
        Me.pnlUsuario.Controls.Add(Me.lblTotTotal)
        Me.pnlUsuario.Controls.Add(Me.lblTotDescto)
        Me.pnlUsuario.Controls.Add(Me.lblTotImpuestos)
        Me.pnlUsuario.Controls.Add(Me.lblTotSubtotal)
        Me.pnlUsuario.Controls.Add(Me.selCliente)
        Me.pnlUsuario.Controls.Add(Me.lblCliente)
        Me.pnlUsuario.CornerRadius = 30
        Me.pnlUsuario.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlUsuario.Gradient = True
        Me.pnlUsuario.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlUsuario.GradientOffset = 1.0!
        Me.pnlUsuario.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlUsuario.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlUsuario.Grayscale = False
        Me.pnlUsuario.Image = Nothing
        Me.pnlUsuario.ImageAlpha = 75
        Me.pnlUsuario.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlUsuario.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlUsuario.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlUsuario.Location = New System.Drawing.Point(24, 66)
        Me.pnlUsuario.Name = "pnlUsuario"
        Me.pnlUsuario.Rounded = True
        Me.pnlUsuario.Size = New System.Drawing.Size(444, 232)
        Me.pnlUsuario.TabIndex = 25
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Olive
        Me.ColorWithAlpha2.Parent = Me.pnlUsuario
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha1.Parent = Me.pnlUsuario
        '
        'lblTotCantidadTXT
        '
        Me.lblTotCantidadTXT.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotCantidadTXT.BackColor = System.Drawing.Color.Transparent
        Me.lblTotCantidadTXT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotCantidadTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotCantidadTXT.ForeColor = System.Drawing.Color.Black
        Me.lblTotCantidadTXT.Location = New System.Drawing.Point(118, 71)
        Me.lblTotCantidadTXT.Name = "lblTotCantidadTXT"
        Me.lblTotCantidadTXT.Size = New System.Drawing.Size(122, 16)
        Me.lblTotCantidadTXT.TabIndex = 43
        Me.lblTotCantidadTXT.Text = "0.00"
        Me.lblTotCantidadTXT.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblTotTotalTXT
        '
        Me.lblTotTotalTXT.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotTotalTXT.BackColor = System.Drawing.Color.Transparent
        Me.lblTotTotalTXT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotTotalTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotTotalTXT.ForeColor = System.Drawing.Color.Black
        Me.lblTotTotalTXT.Location = New System.Drawing.Point(117, 161)
        Me.lblTotTotalTXT.Name = "lblTotTotalTXT"
        Me.lblTotTotalTXT.Size = New System.Drawing.Size(122, 16)
        Me.lblTotTotalTXT.TabIndex = 42
        Me.lblTotTotalTXT.Text = "0.00"
        Me.lblTotTotalTXT.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblTotDescuentosTXT
        '
        Me.lblTotDescuentosTXT.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotDescuentosTXT.BackColor = System.Drawing.Color.Transparent
        Me.lblTotDescuentosTXT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotDescuentosTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotDescuentosTXT.ForeColor = System.Drawing.Color.Black
        Me.lblTotDescuentosTXT.Location = New System.Drawing.Point(118, 138)
        Me.lblTotDescuentosTXT.Name = "lblTotDescuentosTXT"
        Me.lblTotDescuentosTXT.Size = New System.Drawing.Size(121, 16)
        Me.lblTotDescuentosTXT.TabIndex = 41
        Me.lblTotDescuentosTXT.Text = "0.00"
        Me.lblTotDescuentosTXT.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblTotImpuestoTXT
        '
        Me.lblTotImpuestoTXT.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotImpuestoTXT.BackColor = System.Drawing.Color.Transparent
        Me.lblTotImpuestoTXT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotImpuestoTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotImpuestoTXT.ForeColor = System.Drawing.Color.Black
        Me.lblTotImpuestoTXT.Location = New System.Drawing.Point(118, 115)
        Me.lblTotImpuestoTXT.Name = "lblTotImpuestoTXT"
        Me.lblTotImpuestoTXT.Size = New System.Drawing.Size(122, 16)
        Me.lblTotImpuestoTXT.TabIndex = 40
        Me.lblTotImpuestoTXT.Text = "0.00"
        Me.lblTotImpuestoTXT.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblTotSubtotalTXT
        '
        Me.lblTotSubtotalTXT.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotSubtotalTXT.BackColor = System.Drawing.Color.Transparent
        Me.lblTotSubtotalTXT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotSubtotalTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotSubtotalTXT.ForeColor = System.Drawing.Color.Black
        Me.lblTotSubtotalTXT.Location = New System.Drawing.Point(118, 94)
        Me.lblTotSubtotalTXT.Name = "lblTotSubtotalTXT"
        Me.lblTotSubtotalTXT.Size = New System.Drawing.Size(122, 16)
        Me.lblTotSubtotalTXT.TabIndex = 39
        Me.lblTotSubtotalTXT.Text = "0.00"
        Me.lblTotSubtotalTXT.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblTotCantidad
        '
        Me.lblTotCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotCantidad.AutoSize = True
        Me.lblTotCantidad.BackColor = System.Drawing.Color.Transparent
        Me.lblTotCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotCantidad.Location = New System.Drawing.Point(25, 71)
        Me.lblTotCantidad.Name = "lblTotCantidad"
        Me.lblTotCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblTotCantidad.TabIndex = 38
        Me.lblTotCantidad.Text = "Cantidad"
        Me.lblTotCantidad.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblTotTotal
        '
        Me.lblTotTotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotTotal.AutoSize = True
        Me.lblTotTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotTotal.Location = New System.Drawing.Point(25, 161)
        Me.lblTotTotal.Name = "lblTotTotal"
        Me.lblTotTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotTotal.TabIndex = 37
        Me.lblTotTotal.Text = "Total"
        Me.lblTotTotal.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblTotDescto
        '
        Me.lblTotDescto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotDescto.AutoSize = True
        Me.lblTotDescto.BackColor = System.Drawing.Color.Transparent
        Me.lblTotDescto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotDescto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotDescto.Location = New System.Drawing.Point(25, 138)
        Me.lblTotDescto.Name = "lblTotDescto"
        Me.lblTotDescto.Size = New System.Drawing.Size(64, 13)
        Me.lblTotDescto.TabIndex = 36
        Me.lblTotDescto.Text = "Descuentos"
        Me.lblTotDescto.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblTotImpuestos
        '
        Me.lblTotImpuestos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotImpuestos.AutoSize = True
        Me.lblTotImpuestos.BackColor = System.Drawing.Color.Transparent
        Me.lblTotImpuestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotImpuestos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotImpuestos.Location = New System.Drawing.Point(25, 115)
        Me.lblTotImpuestos.Name = "lblTotImpuestos"
        Me.lblTotImpuestos.Size = New System.Drawing.Size(55, 13)
        Me.lblTotImpuestos.TabIndex = 35
        Me.lblTotImpuestos.Text = "Impuestos"
        Me.lblTotImpuestos.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblTotSubtotal
        '
        Me.lblTotSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotSubtotal.AutoSize = True
        Me.lblTotSubtotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotSubtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotSubtotal.Location = New System.Drawing.Point(25, 94)
        Me.lblTotSubtotal.Name = "lblTotSubtotal"
        Me.lblTotSubtotal.Size = New System.Drawing.Size(46, 13)
        Me.lblTotSubtotal.TabIndex = 34
        Me.lblTotSubtotal.Text = "Subtotal"
        Me.lblTotSubtotal.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.White
        Me.lblCliente.Location = New System.Drawing.Point(20, 16)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(56, 16)
        Me.lblCliente.TabIndex = 3
        Me.lblCliente.Text = "Cliente"
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel1.ForeColor = System.Drawing.Color.Olive
        Me.CiLabel1.Location = New System.Drawing.Point(44, 18)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(126, 16)
        Me.CiLabel1.TabIndex = 44
        Me.CiLabel1.Text = "Folio de la Venta"
        '
        'selVenta
        '
        Me.selVenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selVenta.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selVenta.EditorAssembly = "Azteca.VentasWin"
        Me.selVenta.EditorClass = "Azteca.Windows.Ventas.VendedoresForm"
        Me.selVenta.EditorTitle = "Editar datos de la Venta"
        Me.selVenta.Key = Nothing
        Me.selVenta.Linked = False
        Me.selVenta.Location = New System.Drawing.Point(47, 37)
        Me.selVenta.Name = "selVenta"
        Me.selVenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selVenta.ShowEditButton = True
        Me.selVenta.Size = New System.Drawing.Size(401, 23)
        Me.selVenta.TabIndex = 2
        Me.selVenta.TextWidth = 128
        '
        'selCliente
        '
        Me.selCliente.AnySite = False
        Me.selCliente.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selCliente.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selCliente.EditorAssembly = "Azteca.VentasWin"
        Me.selCliente.EditorClass = "Azteca.Windows.Ventas.ClientesForm"
        Me.selCliente.EditorTitle = "Editar datos de cliente..."
        Me.selCliente.Key = 0
        Me.selCliente.Linked = False
        Me.selCliente.Location = New System.Drawing.Point(23, 35)
        Me.selCliente.Name = "selCliente"
        Me.selCliente.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCliente.Size = New System.Drawing.Size(401, 23)
        Me.selCliente.TabIndex = 1
        '
        'FacturarVentaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(491, 340)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.selVenta)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.pnlUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FacturarVentaForm"
        Me.Text = "Facturación de Folio de Venta"
        Me.pnlUsuario.ResumeLayout(False)
        Me.pnlUsuario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents pnlUsuario As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents selCliente As Azteca.Windows.Ventas.Retail.ClienteExpressSelector
    Friend WithEvents lblCliente As Azteca.Windows.Controls.CILabel
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents lblTotCantidadTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotTotalTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotDescuentosTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotImpuestoTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotSubtotalTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotCantidad As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotTotal As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotDescto As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotImpuestos As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblTotSubtotal As Azteca.Windows.Controls.CILabel
    Friend WithEvents selVenta As Azteca.Windows.Ventas.VentaSelector
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
End Class
