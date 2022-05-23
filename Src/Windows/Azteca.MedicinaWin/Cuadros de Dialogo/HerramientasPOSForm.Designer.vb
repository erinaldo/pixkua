<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HerramientasPOSForm
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
        Dim DesignerRectTracker3 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems2 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker4 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim DesignerRectTracker1 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HerramientasPOSForm))
        Dim CBlendItems1 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker2 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Me.pnlTitulo = New Azteca.Windows.Controls.CIPanel()
        Me.lblTitulo = New Azteca.Windows.Controls.CILabel()
        Me.CiPanel1 = New Azteca.Windows.Controls.CIPanel()
        Me.cmdHerramientas = New Azteca.Windows.Controls.ButtonPlus()
        Me.cmdVentas = New Azteca.Windows.Controls.ButtonPlus()
        Me.pnlTitulo.SuspendLayout()
        Me.CiPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.GradientColorA = System.Drawing.SystemColors.ControlLight
        Me.pnlTitulo.GradientColorB = System.Drawing.SystemColors.ControlDark
        Me.pnlTitulo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(551, 64)
        Me.pnlTitulo.TabIndex = 0
        Me.pnlTitulo.UseGradient = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(551, 64)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Herramientas"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CiPanel1
        '
        Me.CiPanel1.Controls.Add(Me.cmdVentas)
        Me.CiPanel1.Controls.Add(Me.cmdHerramientas)
        Me.CiPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CiPanel1.GradientColorA = System.Drawing.SystemColors.ControlLight
        Me.CiPanel1.GradientColorB = System.Drawing.SystemColors.ControlDark
        Me.CiPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.CiPanel1.Location = New System.Drawing.Point(0, 64)
        Me.CiPanel1.Name = "CiPanel1"
        Me.CiPanel1.Size = New System.Drawing.Size(551, 228)
        Me.CiPanel1.TabIndex = 1
        Me.CiPanel1.UseGradient = False
        '
        'cmdHerramientas
        '
        Me.cmdHerramientas.AccessibleDescription = "  "
        Me.cmdHerramientas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdHerramientas.AutoLock = False
        Me.cmdHerramientas.BorderColor = System.Drawing.Color.Olive
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdHerramientas.CenterPtTracker = DesignerRectTracker3
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems2.iPoint = New Single() {0.0!, 1.0!}
        Me.cmdHerramientas.ColorFillBlend = CBlendItems2
        Me.cmdHerramientas.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.cmdHerramientas.Corners.All = CType(10, Short)
        Me.cmdHerramientas.Corners.LowerLeft = CType(10, Short)
        Me.cmdHerramientas.Corners.LowerRight = CType(10, Short)
        Me.cmdHerramientas.Corners.UpperLeft = CType(10, Short)
        Me.cmdHerramientas.Corners.UpperRight = CType(10, Short)
        Me.cmdHerramientas.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientPath
        Me.cmdHerramientas.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdHerramientas.FocalPoints.CenterPtX = 0.4318182!
        Me.cmdHerramientas.FocalPoints.CenterPtY = 0.3692308!
        Me.cmdHerramientas.FocalPoints.FocusPtX = 0.0!
        Me.cmdHerramientas.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = False
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdHerramientas.FocusPtTracker = DesignerRectTracker4
        Me.cmdHerramientas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHerramientas.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdHerramientas.Image = CType(resources.GetObject("cmdHerramientas.Image"), System.Drawing.Image)
        Me.cmdHerramientas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdHerramientas.ImageIndex = 0
        Me.cmdHerramientas.Imagelist = Nothing
        Me.cmdHerramientas.ImageSize = New System.Drawing.Size(32, 32)
        Me.cmdHerramientas.Location = New System.Drawing.Point(12, 15)
        Me.cmdHerramientas.Name = "cmdHerramientas"
        Me.cmdHerramientas.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.cmdHerramientas.SideImage = Nothing
        Me.cmdHerramientas.SideImageSize = New System.Drawing.Size(48, 48)
        Me.cmdHerramientas.Size = New System.Drawing.Size(88, 65)
        Me.cmdHerramientas.TabIndex = 39
        Me.cmdHerramientas.TabStop = False
        Me.cmdHerramientas.Text = "Resumen Fichas"
        Me.cmdHerramientas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdHerramientas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdHerramientas.TextMargin = New System.Windows.Forms.Padding(2)
        Me.cmdHerramientas.TextShadow = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdHerramientas.TextShadowShow = False
        Me.cmdHerramientas.UseMnemonic = True
        '
        'cmdVentas
        '
        Me.cmdVentas.AccessibleDescription = "  "
        Me.cmdVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdVentas.AutoLock = False
        Me.cmdVentas.BorderColor = System.Drawing.Color.Olive
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdVentas.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.cmdVentas.ColorFillBlend = CBlendItems1
        Me.cmdVentas.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.cmdVentas.Corners.All = CType(10, Short)
        Me.cmdVentas.Corners.LowerLeft = CType(10, Short)
        Me.cmdVentas.Corners.LowerRight = CType(10, Short)
        Me.cmdVentas.Corners.UpperLeft = CType(10, Short)
        Me.cmdVentas.Corners.UpperRight = CType(10, Short)
        Me.cmdVentas.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientPath
        Me.cmdVentas.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdVentas.FocalPoints.CenterPtX = 0.0!
        Me.cmdVentas.FocalPoints.CenterPtY = 0.0!
        Me.cmdVentas.FocalPoints.FocusPtX = 0.0!
        Me.cmdVentas.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.cmdVentas.FocusPtTracker = DesignerRectTracker2
        Me.cmdVentas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVentas.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdVentas.Image = CType(resources.GetObject("cmdVentas.Image"), System.Drawing.Image)
        Me.cmdVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdVentas.ImageIndex = 0
        Me.cmdVentas.Imagelist = Nothing
        Me.cmdVentas.ImageSize = New System.Drawing.Size(32, 32)
        Me.cmdVentas.Location = New System.Drawing.Point(106, 15)
        Me.cmdVentas.Name = "cmdVentas"
        Me.cmdVentas.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Me.cmdVentas.SideImage = Nothing
        Me.cmdVentas.SideImageSize = New System.Drawing.Size(48, 48)
        Me.cmdVentas.Size = New System.Drawing.Size(88, 65)
        Me.cmdVentas.TabIndex = 40
        Me.cmdVentas.TabStop = False
        Me.cmdVentas.Text = "Admon.  Ventas"
        Me.cmdVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdVentas.TextMargin = New System.Windows.Forms.Padding(2)
        Me.cmdVentas.TextShadow = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdVentas.TextShadowShow = False
        Me.cmdVentas.UseMnemonic = True
        '
        'HerramientasPOSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 292)
        Me.Controls.Add(Me.CiPanel1)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Name = "HerramientasPOSForm"
        Me.Text = "Herramientas"
        Me.pnlTitulo.ResumeLayout(False)
        Me.CiPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTitulo As Azteca.Windows.Controls.CIPanel
    Friend WithEvents lblTitulo As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiPanel1 As Azteca.Windows.Controls.CIPanel
    Friend WithEvents cmdHerramientas As Azteca.Windows.Controls.ButtonPlus
    Friend WithEvents cmdVentas As Azteca.Windows.Controls.ButtonPlus
End Class
