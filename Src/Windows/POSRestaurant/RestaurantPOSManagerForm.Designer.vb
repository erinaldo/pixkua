<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestaurantPOSManagerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOSManagerForm))
        Dim DesignerRectTracker1 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems1 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker2 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Me.cmdComidaRapida = New Azteca.Windows.Controls.CIButton()
        Me.cmdServicioDomicilio = New Azteca.Windows.Controls.CIButton()
        Me.cmdServicioMesa = New Azteca.Windows.Controls.CIButton()
        Me.pnlMenu = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha3 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha4 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha5 = New Azteca.Windows.ColorWithAlpha()
        Me.pnlreturn = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha6 = New Azteca.Windows.ColorWithAlpha()
        Me.btnSalir = New Azteca.Windows.Controls.ButtonPlus()
        Me.pnlAzteca = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.picAzteca = New Azteca.Windows.Controls.CIPicture()
        Me.pnlMenu.SuspendLayout()
        Me.pnlreturn.SuspendLayout()
        Me.pnlAzteca.SuspendLayout()
        CType(Me.picAzteca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdComidaRapida
        '
        Me.cmdComidaRapida.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdComidaRapida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdComidaRapida.ForeColor = System.Drawing.Color.White
        Me.cmdComidaRapida.Image = CType(resources.GetObject("cmdComidaRapida.Image"), System.Drawing.Image)
        Me.cmdComidaRapida.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdComidaRapida.Location = New System.Drawing.Point(290, 33)
        Me.cmdComidaRapida.Name = "cmdComidaRapida"
        Me.cmdComidaRapida.Size = New System.Drawing.Size(268, 227)
        Me.cmdComidaRapida.TabIndex = 5
        Me.cmdComidaRapida.Text = "Comida rápida"
        Me.cmdComidaRapida.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdComidaRapida.UseVisualStyleBackColor = False
        '
        'cmdServicioDomicilio
        '
        Me.cmdServicioDomicilio.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdServicioDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdServicioDomicilio.ForeColor = System.Drawing.Color.White
        Me.cmdServicioDomicilio.Image = CType(resources.GetObject("cmdServicioDomicilio.Image"), System.Drawing.Image)
        Me.cmdServicioDomicilio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdServicioDomicilio.Location = New System.Drawing.Point(564, 33)
        Me.cmdServicioDomicilio.Name = "cmdServicioDomicilio"
        Me.cmdServicioDomicilio.Size = New System.Drawing.Size(268, 227)
        Me.cmdServicioDomicilio.TabIndex = 4
        Me.cmdServicioDomicilio.Text = "Servicio a domicilio"
        Me.cmdServicioDomicilio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdServicioDomicilio.UseVisualStyleBackColor = False
        '
        'cmdServicioMesa
        '
        Me.cmdServicioMesa.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdServicioMesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdServicioMesa.ForeColor = System.Drawing.Color.White
        Me.cmdServicioMesa.Image = CType(resources.GetObject("cmdServicioMesa.Image"), System.Drawing.Image)
        Me.cmdServicioMesa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdServicioMesa.Location = New System.Drawing.Point(16, 33)
        Me.cmdServicioMesa.Name = "cmdServicioMesa"
        Me.cmdServicioMesa.Size = New System.Drawing.Size(268, 227)
        Me.cmdServicioMesa.TabIndex = 1
        Me.cmdServicioMesa.Text = "Servicio a su mesa"
        Me.cmdServicioMesa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdServicioMesa.UseVisualStyleBackColor = False
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlMenu.Border = False
        Me.pnlMenu.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlMenu.Colors.Add(Me.ColorWithAlpha3)
        Me.pnlMenu.Colors.Add(Me.ColorWithAlpha4)
        Me.pnlMenu.Colors.Add(Me.ColorWithAlpha5)
        Me.pnlMenu.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlMenu.Controls.Add(Me.cmdComidaRapida)
        Me.pnlMenu.Controls.Add(Me.cmdServicioDomicilio)
        Me.pnlMenu.Controls.Add(Me.cmdServicioMesa)
        Me.pnlMenu.CornerRadius = 20
        Me.pnlMenu.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMenu.Gradient = True
        Me.pnlMenu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlMenu.GradientOffset = 1.0!
        Me.pnlMenu.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlMenu.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlMenu.Grayscale = False
        Me.pnlMenu.Image = Nothing
        Me.pnlMenu.ImageAlpha = 75
        Me.pnlMenu.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlMenu.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlMenu.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlMenu.Location = New System.Drawing.Point(0, 100)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Rounded = True
        Me.pnlMenu.Size = New System.Drawing.Size(849, 309)
        Me.pnlMenu.TabIndex = 24
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha3.Parent = Me.pnlMenu
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.Olive
        Me.ColorWithAlpha4.Parent = Me.pnlMenu
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 255
        Me.ColorWithAlpha5.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha5.Parent = Me.pnlMenu
        '
        'pnlreturn
        '
        Me.pnlreturn.BackColor = System.Drawing.Color.Transparent
        Me.pnlreturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlreturn.Border = False
        Me.pnlreturn.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlreturn.Colors.Add(Me.ColorWithAlpha6)
        Me.pnlreturn.ContentPadding = New System.Windows.Forms.Padding(0)
        Me.pnlreturn.Controls.Add(Me.btnSalir)
        Me.pnlreturn.CornerRadius = 20
        Me.pnlreturn.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlreturn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlreturn.Gradient = False
        Me.pnlreturn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlreturn.GradientOffset = 1.0!
        Me.pnlreturn.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlreturn.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlreturn.Grayscale = False
        Me.pnlreturn.Image = Nothing
        Me.pnlreturn.ImageAlpha = 75
        Me.pnlreturn.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlreturn.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlreturn.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlreturn.Location = New System.Drawing.Point(0, 409)
        Me.pnlreturn.Name = "pnlreturn"
        Me.pnlreturn.Rounded = True
        Me.pnlreturn.Size = New System.Drawing.Size(849, 85)
        Me.pnlreturn.TabIndex = 23
        '
        'ColorWithAlpha6
        '
        Me.ColorWithAlpha6.Alpha = 255
        Me.ColorWithAlpha6.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha6.Parent = Me.pnlreturn
        '
        'btnSalir
        '
        Me.btnSalir.AutoLock = False
        Me.btnSalir.BorderColor = System.Drawing.Color.Olive
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnSalir.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.btnSalir.ColorFillBlend = CBlendItems1
        Me.btnSalir.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.btnSalir.Corners.All = CType(20, Short)
        Me.btnSalir.Corners.LowerLeft = CType(20, Short)
        Me.btnSalir.Corners.LowerRight = CType(20, Short)
        Me.btnSalir.Corners.UpperLeft = CType(20, Short)
        Me.btnSalir.Corners.UpperRight = CType(20, Short)
        Me.btnSalir.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientLinear
        Me.btnSalir.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnSalir.FocalPoints.CenterPtX = 0.5!
        Me.btnSalir.FocalPoints.CenterPtY = 0.5!
        Me.btnSalir.FocalPoints.FocusPtX = 0.0!
        Me.btnSalir.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnSalir.FocusPtTracker = DesignerRectTracker2
        Me.btnSalir.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.ForeColor = System.Drawing.Color.Olive
        Me.btnSalir.Image = Nothing
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.ImageIndex = 0
        Me.btnSalir.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnSalir.Location = New System.Drawing.Point(289, 8)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.btnSalir.SideImage = CType(resources.GetObject("btnSalir.SideImage"), System.Drawing.Image)
        Me.btnSalir.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.SideImageSize = New System.Drawing.Size(64, 64)
        Me.btnSalir.Size = New System.Drawing.Size(279, 71)
        Me.btnSalir.TabIndex = 24
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnSalir.TextMargin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.TextShadow = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnSalir.UseMnemonic = True
        '
        'pnlAzteca
        '
        Me.pnlAzteca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlAzteca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlAzteca.Border = False
        Me.pnlAzteca.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlAzteca.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlAzteca.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlAzteca.ContentPadding = New System.Windows.Forms.Padding(20, 5, 20, 8)
        Me.pnlAzteca.Controls.Add(Me.picAzteca)
        Me.pnlAzteca.CornerRadius = 30
        Me.pnlAzteca.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlAzteca.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAzteca.Gradient = True
        Me.pnlAzteca.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlAzteca.GradientOffset = 1.0!
        Me.pnlAzteca.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlAzteca.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlAzteca.Grayscale = False
        Me.pnlAzteca.Image = Nothing
        Me.pnlAzteca.ImageAlpha = 75
        Me.pnlAzteca.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlAzteca.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlAzteca.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlAzteca.Location = New System.Drawing.Point(0, 0)
        Me.pnlAzteca.Name = "pnlAzteca"
        Me.pnlAzteca.Rounded = True
        Me.pnlAzteca.Size = New System.Drawing.Size(849, 100)
        Me.pnlAzteca.TabIndex = 23
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.White
        Me.ColorWithAlpha1.Parent = Me.pnlAzteca
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.White
        Me.ColorWithAlpha2.Parent = Me.pnlAzteca
        '
        'picAzteca
        '
        Me.picAzteca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.picAzteca.Image = CType(resources.GetObject("picAzteca.Image"), System.Drawing.Image)
        Me.picAzteca.Location = New System.Drawing.Point(261, 7)
        Me.picAzteca.Name = "picAzteca"
        Me.picAzteca.Size = New System.Drawing.Size(336, 86)
        Me.picAzteca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAzteca.TabIndex = 3
        Me.picAzteca.TabStop = False
        Me.picAzteca.UIName = Nothing
        '
        'RestaurantPOSManagerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 494)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlreturn)
        Me.Controls.Add(Me.pnlAzteca)
        Me.Name = "RestaurantPOSManagerForm"
        Me.Text = "POS Restaurante"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlreturn.ResumeLayout(False)
        Me.pnlAzteca.ResumeLayout(False)
        CType(Me.picAzteca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdComidaRapida As Azteca.Windows.Controls.CIButton
    Friend WithEvents cmdServicioDomicilio As Azteca.Windows.Controls.CIButton
    Friend WithEvents cmdServicioMesa As Azteca.Windows.Controls.CIButton
    Friend WithEvents pnlMenu As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha5 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents pnlreturn As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents btnSalir As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents pnlAzteca As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents picAzteca As Azteca.Windows.Controls.CIPicture
    Friend WithEvents ColorWithAlpha6 As Azteca.Windows.ColorWithAlpha
End Class
