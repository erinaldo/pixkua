<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MeserosSelForm
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
        Dim DesignerRectTracker1 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MeserosSelForm))
        Dim CBlendItems1 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker2 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Me.pnlIdentificacion = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha1 = New Azteca.Windows.ColorWithAlpha()
        Me.AlphaGradientPanel1 = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha2 = New Azteca.Windows.ColorWithAlpha()
        Me.picTira = New Azteca.Windows.Controls.CIPicture()
        Me.lblCentroConsumo = New Azteca.Windows.Controls.CILabel()
        Me.pnlAzteca = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.btnRegresar = New Azteca.Windows.Controls.ButtonPlus()
        Me.picAzteca = New Azteca.Windows.Controls.CIPicture()
        Me.pnlMeseros = New Azteca.Windows.Controls.AlphaGradientPanel()
        Me.ColorWithAlpha3 = New Azteca.Windows.ColorWithAlpha()
        Me.ColorWithAlpha5 = New Azteca.Windows.ColorWithAlpha()
        Me.pnlIdentificacion.SuspendLayout()
        Me.AlphaGradientPanel1.SuspendLayout()
        CType(Me.picTira, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAzteca.SuspendLayout()
        CType(Me.picAzteca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlIdentificacion
        '
        Me.pnlIdentificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlIdentificacion.Border = False
        Me.pnlIdentificacion.BorderColor = System.Drawing.Color.White
        Me.pnlIdentificacion.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlIdentificacion.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlIdentificacion.ContentPadding = New System.Windows.Forms.Padding(10, 5, 10, 0)
        Me.pnlIdentificacion.Controls.Add(Me.lblCentroConsumo)
        Me.pnlIdentificacion.CornerRadius = 30
        Me.pnlIdentificacion.Corners = CType((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight), Azteca.Windows.Corner)
        Me.pnlIdentificacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlIdentificacion.Gradient = True
        Me.pnlIdentificacion.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlIdentificacion.GradientOffset = 1.0!
        Me.pnlIdentificacion.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlIdentificacion.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlIdentificacion.Grayscale = False
        Me.pnlIdentificacion.Image = Nothing
        Me.pnlIdentificacion.ImageAlpha = 75
        Me.pnlIdentificacion.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlIdentificacion.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlIdentificacion.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlIdentificacion.Location = New System.Drawing.Point(0, 97)
        Me.pnlIdentificacion.Name = "pnlIdentificacion"
        Me.pnlIdentificacion.Rounded = True
        Me.pnlIdentificacion.Size = New System.Drawing.Size(1080, 47)
        Me.pnlIdentificacion.TabIndex = 6
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.White
        Me.ColorWithAlpha1.Parent = Me.pnlAzteca
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AlphaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AlphaGradientPanel1.Border = False
        Me.AlphaGradientPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha1)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha2)
        Me.AlphaGradientPanel1.ContentPadding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.AlphaGradientPanel1.Controls.Add(Me.picTira)
        Me.AlphaGradientPanel1.CornerRadius = 30
        Me.AlphaGradientPanel1.Corners = Azteca.Windows.Corner.None
        Me.AlphaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AlphaGradientPanel1.Gradient = False
        Me.AlphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.AlphaGradientPanel1.GradientOffset = 1.0!
        Me.AlphaGradientPanel1.GradientSize = New System.Drawing.Size(0, 0)
        Me.AlphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.AlphaGradientPanel1.Grayscale = False
        Me.AlphaGradientPanel1.Image = Nothing
        Me.AlphaGradientPanel1.ImageAlpha = 75
        Me.AlphaGradientPanel1.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.AlphaGradientPanel1.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.AlphaGradientPanel1.ImageSize = New System.Drawing.Size(48, 48)
        Me.AlphaGradientPanel1.Location = New System.Drawing.Point(0, 144)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = True
        Me.AlphaGradientPanel1.Size = New System.Drawing.Size(1080, 97)
        Me.AlphaGradientPanel1.TabIndex = 25
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha2.Parent = Me.pnlAzteca
        '
        'picTira
        '
        Me.picTira.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picTira.Image = CType(resources.GetObject("picTira.Image"), System.Drawing.Image)
        Me.picTira.Location = New System.Drawing.Point(12, 3)
        Me.picTira.Name = "picTira"
        Me.picTira.Size = New System.Drawing.Size(1058, 90)
        Me.picTira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTira.TabIndex = 4
        Me.picTira.TabStop = False
        Me.picTira.UIName = Nothing
        '
        'lblCentroConsumo
        '
        Me.lblCentroConsumo.BackColor = System.Drawing.Color.Transparent
        Me.lblCentroConsumo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCentroConsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentroConsumo.ForeColor = System.Drawing.Color.Gray
        Me.lblCentroConsumo.Location = New System.Drawing.Point(0, 0)
        Me.lblCentroConsumo.Name = "lblCentroConsumo"
        Me.lblCentroConsumo.Size = New System.Drawing.Size(1080, 47)
        Me.lblCentroConsumo.TabIndex = 5
        Me.lblCentroConsumo.Text = "Identificación del Mesero"
        Me.lblCentroConsumo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlAzteca
        '
        Me.pnlAzteca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlAzteca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlAzteca.Border = False
        Me.pnlAzteca.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlAzteca.Colors.Add(Me.ColorWithAlpha1)
        Me.pnlAzteca.Colors.Add(Me.ColorWithAlpha2)
        Me.pnlAzteca.ContentPadding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.pnlAzteca.Controls.Add(Me.btnRegresar)
        Me.pnlAzteca.Controls.Add(Me.picAzteca)
        Me.pnlAzteca.CornerRadius = 30
        Me.pnlAzteca.Corners = CType((((Azteca.Windows.Corner.TopLeft Or Azteca.Windows.Corner.TopRight) _
            Or Azteca.Windows.Corner.BottomLeft) _
            Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlAzteca.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAzteca.Gradient = False
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
        Me.pnlAzteca.Size = New System.Drawing.Size(1080, 97)
        Me.pnlAzteca.TabIndex = 24
        '
        'btnRegresar
        '
        Me.btnRegresar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegresar.AutoLock = False
        Me.btnRegresar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegresar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnRegresar.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.RoyalBlue, System.Drawing.Color.Navy}
        CBlendItems1.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.btnRegresar.ColorFillBlend = CBlendItems1
        Me.btnRegresar.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnRegresar.Corners.All = CType(6, Short)
        Me.btnRegresar.Corners.LowerLeft = CType(6, Short)
        Me.btnRegresar.Corners.LowerRight = CType(6, Short)
        Me.btnRegresar.Corners.UpperLeft = CType(6, Short)
        Me.btnRegresar.Corners.UpperRight = CType(6, Short)
        Me.btnRegresar.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.Solid
        Me.btnRegresar.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnRegresar.FocalPoints.CenterPtX = 0.5!
        Me.btnRegresar.FocalPoints.CenterPtY = 0.5!
        Me.btnRegresar.FocalPoints.FocusPtX = 0.0!
        Me.btnRegresar.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btnRegresar.FocusPtTracker = DesignerRectTracker2
        Me.btnRegresar.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegresar.ForeColor = System.Drawing.Color.Green
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRegresar.ImageIndex = 0
        Me.btnRegresar.ImageSize = New System.Drawing.Size(48, 48)
        Me.btnRegresar.Location = New System.Drawing.Point(945, 10)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.btnRegresar.SideImage = Nothing
        Me.btnRegresar.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresar.SideImageSize = New System.Drawing.Size(48, 48)
        Me.btnRegresar.Size = New System.Drawing.Size(90, 80)
        Me.btnRegresar.TabIndex = 4
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRegresar.TextMargin = New System.Windows.Forms.Padding(2)
        Me.btnRegresar.TextShadowShow = False
        Me.btnRegresar.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnRegresar.UseMnemonic = True
        '
        'picAzteca
        '
        Me.picAzteca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.picAzteca.Image = CType(resources.GetObject("picAzteca.Image"), System.Drawing.Image)
        Me.picAzteca.Location = New System.Drawing.Point(393, 8)
        Me.picAzteca.Name = "picAzteca"
        Me.picAzteca.Size = New System.Drawing.Size(336, 83)
        Me.picAzteca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAzteca.TabIndex = 3
        Me.picAzteca.TabStop = False
        Me.picAzteca.UIName = Nothing
        '
        'pnlMeseros
        '
        Me.pnlMeseros.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlMeseros.Border = False
        Me.pnlMeseros.BorderColor = System.Drawing.Color.Olive
        Me.pnlMeseros.Colors.Add(Me.ColorWithAlpha3)
        Me.pnlMeseros.Colors.Add(Me.ColorWithAlpha5)
        Me.pnlMeseros.ContentPadding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.pnlMeseros.CornerRadius = 30
        Me.pnlMeseros.Corners = CType((Azteca.Windows.Corner.BottomLeft Or Azteca.Windows.Corner.BottomRight), Azteca.Windows.Corner)
        Me.pnlMeseros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMeseros.Gradient = True
        Me.pnlMeseros.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlMeseros.GradientOffset = 1.0!
        Me.pnlMeseros.GradientSize = New System.Drawing.Size(0, 0)
        Me.pnlMeseros.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.pnlMeseros.Grayscale = False
        Me.pnlMeseros.Image = Nothing
        Me.pnlMeseros.ImageAlpha = 75
        Me.pnlMeseros.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.pnlMeseros.ImagePosition = Azteca.Windows.ImagePosition.BottomRight
        Me.pnlMeseros.ImageSize = New System.Drawing.Size(48, 48)
        Me.pnlMeseros.Location = New System.Drawing.Point(0, 241)
        Me.pnlMeseros.Name = "pnlMeseros"
        Me.pnlMeseros.Rounded = True
        Me.pnlMeseros.Size = New System.Drawing.Size(1080, 305)
        Me.pnlMeseros.TabIndex = 7
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorWithAlpha3.Parent = Me.pnlMeseros
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 255
        Me.ColorWithAlpha5.Color = System.Drawing.Color.Olive
        Me.ColorWithAlpha5.Parent = Me.pnlMeseros
        '
        'MeserosSelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1080, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlMeseros)
        Me.Controls.Add(Me.AlphaGradientPanel1)
        Me.Controls.Add(Me.pnlIdentificacion)
        Me.Controls.Add(Me.pnlAzteca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "MeserosSelForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlIdentificacion.ResumeLayout(False)
        Me.AlphaGradientPanel1.ResumeLayout(False)
        CType(Me.picTira, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAzteca.ResumeLayout(False)
        CType(Me.picAzteca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlIdentificacion As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents pnlMeseros As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents ColorWithAlpha5 As Azteca.Windows.ColorWithAlpha
    Friend WithEvents pnlAzteca As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents picAzteca As Azteca.Windows.Controls.CIPicture
    Friend WithEvents AlphaGradientPanel1 As Azteca.Windows.Controls.AlphaGradientPanel
    Friend WithEvents picTira As Azteca.Windows.Controls.CIPicture
    Friend WithEvents lblCentroConsumo As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnRegresar As Azteca.Windows.Controls.ButtonPlus
End Class
