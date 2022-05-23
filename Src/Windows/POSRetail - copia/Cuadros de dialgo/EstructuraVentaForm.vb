Imports Azteca.Windows.Controls

Public Class EstructuraVentaForm
    Dim ButtonPresionado As Boolean = False
    Dim ButtonMoveX As Integer
    Dim ButtonMoveY As Integer
    Dim IdPadre As Integer
    Private _IdentityEstCom As Integer = 0

    Public ReadOnly Property IdentityEstCom As Integer
        Get
            Return _IdentityEstCom
        End Get
    End Property
    Private Sub EstructuraVentaForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LoadChilds(0)
    End Sub

    Private Sub ButtonPlus_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs)
        Dim dr As ButtonPlus = CType(Sender, ButtonPlus)
        Dim drNivel As Azteca.Kernel.BusinessStructure.HierarchyDS.HierarchyRow = CType(dr.Tag, Azteca.Kernel.BusinessStructure.HierarchyDS.HierarchyRow)
        If drNivel.IsLeaf Then
            _IdentityEstCom = drNivel.Identity
            MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
        End If
        LoadChilds(drNivel.Identity)
    End Sub

    Private Sub cmdSubirNivel_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdSubirNivel.ClickButtonArea
        Dim EstvenFac As New EstructuraComercialFacade
        Dim EstCom As EstructuraComercialInfo = EstvenFac.GetDetail(App.Session.SessionID, IdPadre)
        LoadChilds(EstCom.IdPadre)
    End Sub

    Private Sub cmdCancelar_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdCancelar.ClickButtonArea
        MyBase.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub ButtonPlus_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        ButtonPresionado = False
        ButtonMoveX = 0
        ButtonMoveY = 0
    End Sub

    Private Sub ButtonPlus_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        'flowLytPnl.ScrollControlIntoView(CType(sender, ButtonPlus))
        ButtonPresionado = True
        Dim PanelPoint As System.Drawing.Point = flowLytPnl.PointToClient(MousePosition)
        ButtonMoveX = PanelPoint.X
        ButtonMoveY = PanelPoint.Y

    End Sub

    Private Sub ButtonPlus_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If ButtonPresionado Then
            If e.Button = System.Windows.Forms.MouseButtons.Left Then
                Dim PanelPoint = flowLytPnl.PointToClient(MousePosition)
                If ButtonMoveY < PanelPoint.Y Then
                    If flowLytPnl.VerticalScroll.Value - 2 > 0 Then flowLytPnl.VerticalScroll.Value -= 2
                Else
                    If flowLytPnl.VerticalScroll.Value + 2 < flowLytPnl.VerticalScroll.Maximum Then flowLytPnl.VerticalScroll.Value += 2
                End If
            End If
        End If
    End Sub


    Private Sub flowLytPnl_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles flowLytPnl.MouseDown
        'flowLytPnl.ScrollControlIntoView(CType(sender, ButtonPlus))
        ButtonPresionado = True
        ButtonMoveX = e.X
        ButtonMoveY = e.Y
    End Sub

    Private Sub flowLytPnl_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles flowLytPnl.MouseMove
        If ButtonPresionado Then
            If e.Button = System.Windows.Forms.MouseButtons.Left Then
                'Dim PanelPoint = flowLytPnl.PointToClient(MousePosition)
                If ButtonMoveY < e.Y Then
                    If flowLytPnl.VerticalScroll.Value - 2 > 0 Then flowLytPnl.VerticalScroll.Value -= 2
                Else
                    If flowLytPnl.VerticalScroll.Value + 2 < flowLytPnl.VerticalScroll.Maximum Then flowLytPnl.VerticalScroll.Value += 2
                End If
            End If
        End If
    End Sub

    Private Sub LoadChilds(Id As Integer)
        IdPadre = Id
        flowLytPnl.Controls.Clear()
        Dim Estven As New EstructuraComercialFacade
        Dim EstComTable As Azteca.Kernel.BusinessStructure.HierarchyDS.HierarchyDataTable = Estven.LoadChilds(App.Session.SessionID, App.DefaultCompany.Identity, Id)
        For Each drNivel As Azteca.Kernel.BusinessStructure.HierarchyDS.HierarchyRow In EstComTable
            newButton(drNivel.Identity, drNivel.Nombre, drNivel)
            cmdSubirNivel.Enabled = drNivel.IdPadre <> 0
            lblRuta.Text = drNivel.Path
        Next
    End Sub

    Private Sub newButton(Id As Integer, Texto As String, drNivel As Azteca.Kernel.BusinessStructure.HierarchyDS.HierarchyRow)
        Dim Button As ButtonPlus = New ButtonPlus
        Button.AutoLock = False
        Button.BorderColor = System.Drawing.Color.White

        Dim DesignerRectTracker1 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstructuraVentaForm))
        Dim CBlendItems1 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker2 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim DesignerRectTracker3 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim CBlendItems2 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()

        Button.AutoLock = False
        Button.BorderColor = System.Drawing.Color.Green
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Button.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Button.ColorFillBlend = CBlendItems1
        Button.ColorFillSolid = System.Drawing.SystemColors.Control
        Button.Corners.All = CType(30, Short)
        Button.Corners.LowerLeft = CType(30, Short)
        Button.Corners.LowerRight = CType(30, Short)
        Button.Corners.UpperLeft = CType(30, Short)
        Button.Corners.UpperRight = CType(30, Short)
        Button.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientLinear
        Button.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Button.FocalPoints.CenterPtX = 0.5!
        Button.FocalPoints.CenterPtY = 0.5!
        Button.FocalPoints.FocusPtX = 0.0!
        Button.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Button.FocusPtTracker = DesignerRectTracker2
        Button.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Button.ForeColor = System.Drawing.Color.White
        Button.Image = Nothing
        Button.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Button.ImageIndex = 0
        Button.ImageSize = New System.Drawing.Size(16, 16)
        Button.Location = New System.Drawing.Point(123, 3)
        Button.Name = "ButtonPlus1"
        Button.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        Button.SideImage = Nothing
        Button.SideImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Button.SideImageSize = New System.Drawing.Size(48, 48)
        Button.Size = New System.Drawing.Size(303, 90)
        Button.TabIndex = 0
        Button.Text = "Nodo de la estructura de venta"
        Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Button.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Button.TextMargin = New System.Windows.Forms.Padding(2)
        Button.TextShadowShow = False
        Button.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
        Button.UseMnemonic = True

        Button.Tag = drNivel
        Button.Text = Texto
        Button.Name = "ButtonPlus" & drNivel.Identity
        AddHandler Button.MouseDown, AddressOf ButtonPlus_MouseDown
        AddHandler Button.MouseMove, AddressOf ButtonPlus_MouseMove
        AddHandler Button.MouseUp, AddressOf ButtonPlus_MouseUp
        AddHandler Button.MouseUp, AddressOf ButtonPlus_MouseUp
        AddHandler Button.ClickButtonArea, AddressOf ButtonPlus_ClickButtonArea

        flowLytPnl.Controls.Add(Button)
    End Sub

    
   
  
End Class