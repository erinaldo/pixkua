Public Class MeserosSelForm
    Dim BotonesX As Integer '= pnlMeseros.Width / 100
    Dim BotonesY As Integer '= pnlMeseros.Height / 100
    Private MeserosTable As DataTable

#Region "Implementacion de la forma"
    Private Sub LoginMeserosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Meseros As New MeseroFacade
        MeserosTable = Meseros.LoadDataButtons(App.Session.SessionID, App.DefaultSite.Identity)
        MostrarMeseros()
    End Sub

    Private Sub LoginMeserosForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Cuantos Botones caben en la pantalla ? = numLugares
        BotonesX = pnlMeseros.Width / 100
        BotonesY = pnlMeseros.Height / 100

        MostrarMeseros()
    End Sub

    Private Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

#Region "Botones Meseros"

    Private Sub MostrarMeseros()
        Dim Count As Integer = 0, MargenX As Integer = 0, X As Integer = 0

        If IsNothing(MeserosTable) Then Exit Sub

        pnlMeseros.Controls.Clear()
        Dim numMeseros As Integer = MeserosTable.Rows.Count
        'Ver donde va a comenzar a poner los botones en coord Y
        Dim Y As Integer = Math.Ceiling(numMeseros / BotonesX)
        Y = (BotonesY - 1) / 2
        Dim dv As New DataView(MeserosTable, "", "NombreCorto", DataViewRowState.CurrentRows)

        For Each dr As DataRowView In dv
            ''reiniciar cuando llego al extremo de la coordenada X
            If X >= BotonesX Then
                Y = Y + 1
                X = 0
            End If
            'Margen centrado de X
            If X = 0 Then
                If numMeseros - Count < BotonesX Then
                    MargenX = pnlMeseros.Width - ((numMeseros - Count) * 100)
                    MargenX = MargenX / 2
                Else
                    MargenX = pnlMeseros.Width - (BotonesX * 100)
                    MargenX = MargenX / 2
                End If
            End If

            Dim top As Integer = Y * 100, Left As Integer = (X * 100) + MargenX
            Dim Imagen As Byte()
            If IsDBNull(dr("Fotografia")) Then Imagen = Nothing Else Imagen = dr("Fotografia")

            addButtonMesero(dr("IdMesero"), dr("NombreCorto"), Imagen, top, Left)

            X = X + 1
            Count = Count + 1
        Next

        btnRegresar.Focus()
    End Sub

    Private Sub addButtonMesero(ByVal Id As Integer, ByVal NombreCorto As String, ByVal imagen As Byte(), ByVal Top As Integer, ByVal Left As Integer)
        Dim btnAdd As New Azteca.Windows.Controls.ButtonPlus
        Dim DesignerRectTracker1 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MeserosSelForm))
        Dim CBlendItems1 As Azteca.Windows.Controls.cBlendItems = New Azteca.Windows.Controls.cBlendItems()
        Dim DesignerRectTracker2 As Azteca.Windows.Controls.DesignerRectTracker = New Azteca.Windows.Controls.DesignerRectTracker()

        btnAdd.AutoLock = False
        btnAdd.BackColor = System.Drawing.Color.Transparent
        btnAdd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        btnAdd.CenterPtTracker = DesignerRectTracker1
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.White}
        CBlendItems1.iPoint = New Single() {0.0!, 0.9969136!, 1.0!}
        btnAdd.ColorFillBlend = CBlendItems1
        btnAdd.ColorFillSolid = System.Drawing.SystemColors.Control
        btnAdd.Corners.All = CType(10, Short)
        btnAdd.Corners.LowerLeft = CType(10, Short)
        btnAdd.Corners.LowerRight = CType(10, Short)
        btnAdd.Corners.UpperLeft = CType(10, Short)
        btnAdd.Corners.UpperRight = CType(10, Short)
        btnAdd.FillType = Azteca.Windows.Controls.ButtonPlus.eFillType.GradientLinear
        btnAdd.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        btnAdd.FocalPoints.CenterPtX = 0.5!
        btnAdd.FocalPoints.CenterPtY = 0.5!
        btnAdd.FocalPoints.FocusPtX = 0.0!
        btnAdd.FocalPoints.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        btnAdd.FocusPtTracker = DesignerRectTracker2
        btnAdd.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        btnAdd.ForeColor = System.Drawing.Color.Olive

        If imagen Is Nothing Then
            btnAdd.Image = Global.Azteca.Windows.My.Resources.Resources.Meseros_64
        Else
            Dim ms As New System.IO.MemoryStream(imagen)
            btnAdd.Image = System.Drawing.Image.FromStream(ms)
            btnAdd.ImageSize = New System.Drawing.Size(64, 64)
            ms.Close()
        End If

        btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        btnAdd.ImageIndex = 0
        btnAdd.ImageSize = New System.Drawing.Size(64, 64)
        btnAdd.Location = New System.Drawing.Point(Left, Top)
        btnAdd.Name = "btnAdd"
        btnAdd.Shape = Azteca.Windows.Controls.ButtonPlus.eShape.Rectangle
        btnAdd.SideImage = Nothing
        btnAdd.SideImageAlign = System.Drawing.ContentAlignment.TopCenter
        btnAdd.SideImageSize = New System.Drawing.Size(48, 48)
        btnAdd.Size = New System.Drawing.Size(90, 90)
        btnAdd.TabIndex = 0
        btnAdd.Text = NombreCorto
        btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        btnAdd.TextMargin = New System.Windows.Forms.Padding(2)
        btnAdd.TextShadow = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        btnAdd.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        btnAdd.UseMnemonic = True

        btnAdd.Tag = Id
        AddHandler btnAdd.Click, AddressOf clickMesero

        pnlMeseros.Controls.Add(btnAdd)

    End Sub

    Private Sub clickMesero(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Comanda As New ComandaInfo(App.Session.SessionID)
        Dim btn As Azteca.Windows.Controls.ButtonPlus = CType(sender, Azteca.Windows.Controls.ButtonPlus)
        Dim IdMesero As Integer = CInt(btn.Tag)
        Dim dv As New DataView(MeserosTable, "IdMesero=" & IdMesero, "", DataViewRowState.CurrentRows)

        Dim frmMesero As New MesseroLoginForm
        Dim Imagen As Byte()
        If IsDBNull(dv(0)("Fotografia")) Then Imagen = Nothing Else Imagen = dv(0)("Fotografia")

        Try

            If frmMesero.ShowDialog(CStr(dv(0)("Usuario")), CStr(dv(0)("Password")), Imagen) = System.Windows.Forms.DialogResult.OK Then
                Dim TerminoServicio As Boolean = False
                'Obtenemos las mesas de las zonas de consumo a las q tiene permiso el Mesero
                Dim frmMesa As New MesasSelForm
                If frmMesa.ShowDialog(IdMesero) = System.Windows.Forms.DialogResult.OK Then
                    Dim Result As DialogResult = System.Windows.Forms.DialogResult.Cancel
                    'Mostramos la comanda para la mesa seleccionada
                    Dim frmComanda As New ComandaForm
                    If frmMesa.IdComandaTit.Trim.Length > 0 Then
                        Result = frmComanda.ShowDialog(frmMesa.IdComandaTit)
                        Comanda = frmComanda.Comanda
                    Else
                        Comanda.IdMesa = frmMesa.IdMesa : Comanda.IdMesero = IdMesero : Comanda.IdSucursal = App.DefaultSite.Identity
                        Result = frmComanda.ShowDialog(Comanda)
                    End If

                    If Result = System.Windows.Forms.DialogResult.OK Then
                        Dim ComandaFac As New ComandaFacade
                        ComandaFac.Update(Comanda)
                        'Mandar a impresion todos los articulos q esten pendientes a sus diferentes centros de produccion
                        Context.PrintTicketPedimento(Comanda.Identity)
                    End If
                End If
            End If

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub
#End Region


End Class