<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editPrecioForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editPrecioForm))
        Dim DesignerRectTracker1 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems1 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker2 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.pnlUsuario = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha3 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha4 = New Azteca.Windows.ColorWithAlpha()
        Me.txtPrecio = New Azteca.Windows.Controls.CITextBox()
        Me.lblCliente = New Azteca.Windows.Controls.CILabel()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.lblEtiqueta = New Azteca.Windows.Controls.CILabel()
        Me.cmdBuscarArt = New Azteca.Windows.Controls.ButtonPlus()
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
        Me.btnCancelar.Location = New System.Drawing.Point(186, 106)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 27
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
        Me.btnAceptar.Location = New System.Drawing.Point(105, 106)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 26
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'pnlUsuario
        '
        Me.pnlUsuario.BackColor = System.Drawing.Color.Transparent
        Me.pnlUsuario.Border = False
        Me.pnlUsuario.BorderColor = System.Drawing.Color.Olive
        Me.pnlUsuario.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlUsuario.Colors.Add(Me.ColorWithAlpha3)
        Me.pnlUsuario.Colors.Add(Me.ColorWithAlpha4)
        Me.pnlUsuario.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlUsuario.Controls.Add(Me.cmdBuscarArt)
        Me.pnlUsuario.Controls.Add(Me.txtPrecio)
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
        Me.pnlUsuario.Location = New System.Drawing.Point(4, 22)
        Me.pnlUsuario.Name = "pnlUsuario"
        Me.pnlUsuario.Rounded = True
        Me.pnlUsuario.Size = New System.Drawing.Size(343, 76)
        Me.pnlUsuario.TabIndex = 25
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWithAlpha1.Parent = Me.pnlUsuario
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha3.Parent = Me.pnlUsuario
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWithAlpha4.Parent = Me.pnlUsuario
        '
        'txtPrecio
        '
        Me.txtPrecio.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtPrecio.Digits = True
        Me.txtPrecio.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPrecio.Location = New System.Drawing.Point(109, 25)
        Me.txtPrecio.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrecio.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(146, 29)
        Me.txtPrecio.TabIndex = 4
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.Olive
        Me.lblCliente.Location = New System.Drawing.Point(50, 31)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(53, 16)
        Me.lblCliente.TabIndex = 3
        Me.lblCliente.Text = "Precio"
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha2.Parent = Me.pnlUsuario
        '
        'lblEtiqueta
        '
        Me.lblEtiqueta.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEtiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtiqueta.ForeColor = System.Drawing.Color.Olive
        Me.lblEtiqueta.Location = New System.Drawing.Point(0, 0)
        Me.lblEtiqueta.Name = "lblEtiqueta"
        Me.lblEtiqueta.Size = New System.Drawing.Size(353, 19)
        Me.lblEtiqueta.TabIndex = 28
        Me.lblEtiqueta.Text = "Editando el Precio . . ."
        Me.lblEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdBuscarArt
        '
        Me.cmdBuscarArt.AutoLock = False
        Me.cmdBuscarArt.BackColor = System.Drawing.Color.White
        Me.cmdBuscarArt.BorderColor = System.Drawing.Color.Olive
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdBuscarArt.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.cmdBuscarArt.ColorFillBlend = CBlendItems1
        Me.cmdBuscarArt.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.cmdBuscarArt.Corners.All = CType(10, Short)
        Me.cmdBuscarArt.Corners.LowerLeft = CType(10, Short)
        Me.cmdBuscarArt.Corners.LowerRight = CType(10, Short)
        Me.cmdBuscarArt.Corners.UpperLeft = CType(10, Short)
        Me.cmdBuscarArt.Corners.UpperRight = CType(10, Short)
        Me.cmdBuscarArt.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientPath
        Me.cmdBuscarArt.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdBuscarArt.FocalPoints.CenterPtX = 1.0!
        Me.cmdBuscarArt.FocalPoints.CenterPtY = 0.5675676!
        Me.cmdBuscarArt.FocalPoints.FocusPtX = 0.0!
        Me.cmdBuscarArt.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdBuscarArt.FocusPtTracker = DesignerRectTracker2
        Me.cmdBuscarArt.Font = New System.Drawing.Font("Arial Narrow", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscarArt.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdBuscarArt.Image = CType(resources.GetObject("cmdBuscarArt.Image"), System.Drawing.Image)
        Me.cmdBuscarArt.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdBuscarArt.ImageIndex = 0
        Me.cmdBuscarArt.Imagelist = Nothing
        Me.cmdBuscarArt.ImageSize = New System.Drawing.Size(32, 32)
        Me.cmdBuscarArt.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cmdBuscarArt.Location = New System.Drawing.Point(262, 20)
        Me.cmdBuscarArt.Name = "cmdBuscarArt"
        Me.cmdBuscarArt.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.cmdBuscarArt.SideImage = Nothing
        Me.cmdBuscarArt.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBuscarArt.SideImageSize = New System.Drawing.Size(48, 48)
        Me.cmdBuscarArt.Size = New System.Drawing.Size(46, 37)
        Me.cmdBuscarArt.TabIndex = 11
        Me.cmdBuscarArt.Text = ""
        Me.cmdBuscarArt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdBuscarArt.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.cmdBuscarArt.TextMargin = New System.Windows.Forms.Padding(2)
        Me.cmdBuscarArt.TextShadow = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdBuscarArt.TextShadowShow = False
        Me.cmdBuscarArt.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.cmdBuscarArt.UseMnemonic = True
        '
        'editPrecioForm
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(353, 133)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblEtiqueta)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.pnlUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.Name = "editPrecioForm"
        Me.pnlUsuario.ResumeLayout(False)
        Me.pnlUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents pnlUsuario As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents lblCliente As Azteca.Windows.Controls.CILabel
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha3 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents lblEtiqueta As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtPrecio As Azteca.Windows.Controls.CITextBox
    Friend WithEvents cmdBuscarArt As Azteca.Windows.Controls.ButtonPlus
End Class
