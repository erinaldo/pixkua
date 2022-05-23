Public Class PlaneacionSurtidoForm

    Private Sub grdCentrales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PlaneacionSurtidoForm_AddingItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.AddingItem
        Try
            Dim info As PlanSurtidoInfo = CType(PackageInfo, PlanSurtidoInfo)

            bsCajasCompletas.DataSource = info.CajasCompletas
            grdCajasCompletas.Rebind(True)

            txtCantSurtidores.Value = 5
            txtCantEmpacadores.Value = 2

            txtCantEmpacadores.Value = 0
            txtCantSurtidores.Value = 0
            dtpHoraInicio.Value = DateTime.Now
            dtpLineasReales.Value = DateTime.Today
            cboVersion.Text = ""
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
        

    End Sub

    Private Sub PlaneacionSurtidoForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim ConfiguracionFac As New Azteca.Kernel.Configuration.ConfigurationFacade
            Dim resAllow As String = ConfiguracionFac.GetSystemParameter("Configuracion/Seguridad/Politicas/CDU", App.Session.User.UserCode)
            Dim PlanFac As New PlanSurtidoFacade()

            bsOperadores.DataSource = PlanFac.GetListaOperadores(App.Session.SessionID, App.DefaultSite.Identity)
            cboOperadores.Rebind(True)
            txtCantSurtidores.Value = 5
            txtCantEmpacadores.Value = 2

            Dim AllowEditHour As Integer

            If (resAllow <> String.Empty) Then
                AllowEditHour = Integer.Parse(resAllow)
            Else
                AllowEditHour = 0
            End If

            If (AllowEditHour = 1) Then
                dtpHoraInicio.Enabled = True
            Else
                dtpHoraInicio.Enabled = False
            End If

            If (PackageInfo.Identity > 0) Then
                btnGenerarCajasCompletas.Enabled = False
            Else
                dtpHoraInicio.Value = DateTime.Now
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub PlaneacionSurtidoForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Try
            Dim info As PlanSurtidoInfo = CType(PackageInfo, PlanSurtidoInfo)

            txtReferencia.Text = info.Referencia
            cboVersion.Text = info.Version
            dtpHoraInicio.Value = info.HoraInicio
            dtpLineasReales.Value = info.LineasReales
            txtCantEmpacadores.Value = info.CantEmpacadores
            txtCantSurtidores.Value = info.CantSurtidores
            bsCajasCompletas.DataSource = info.CajasCompletas
            grdCajasCompletas.Rebind(True)

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub PlaneacionSurtidoForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Try
            grdCajasCompletas.UpdateData()
            Dim info As PlanSurtidoInfo = CType(PackageInfo, PlanSurtidoInfo)
            info.Referencia = txtReferencia.Text
            info.Version = 0
            info.HoraInicio = dtpHoraInicio.Value
            info.LineasReales = dtpLineasReales.Value
            info.CantEmpacadores = txtCantEmpacadores.Value
            info.CantSurtidores = txtCantSurtidores.Value
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarCajasCompletas.Click

        Try
            Dim info As PlanSurtidoInfo = CType(PackageInfo, PlanSurtidoInfo)
            Cursor = System.Windows.Forms.Cursors.WaitCursor

            If (info.Identity > 0 And info.CajasCompletas.Rows.Count > 0) Then
                MsgBox("No se permite re generar planes de surtido, favor de crear una nueva versión.", MsgBoxStyle.Information, "Información")
            Else
                GenerarPlan(info)
            End If

        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            Cursor = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub GenerarPlan(ByVal info As PlanSurtidoInfo)
        Dim PlanSurtidoFac = New PlanSurtidoFacade()
        Dim dtPlan As DataTable = PlanSurtidoFac.PlanSurtidoByArea(App.Session.SessionID, App.DefaultSite.Identity, dtpFechaInicial.Value, dtpFechaFinal.Value, dtpHoraInicio.Value, txtCantSurtidores.Value, txtCantEmpacadores.Value)

        For Each row As DataRow In dtPlan.Rows
            Dim newRow As PlanSurtidoDS.PlanesCajasCompletasRow = info.CajasCompletas.NewPlanesCajasCompletasRow()

            newRow.IdPlanSurtidoLine = row.Item("IdPlanSurtidoLine")
            newRow.IdPlanSurtido = row.Item("IdPlanSurtido")
            newRow.IdGrupoAreaSurtido = row.Item("IdGrupoAreaSurtido")
            newRow.IdAreaSurtido = row.Item("IdAreaSurtido")
            newRow.GrupoArea = row.Item("GrupoArea")
            newRow.AreaSurtido = row.Item("AreaSurtido")
            newRow.UsuarioAsignado = row.Item("UsuarioAsignado")
            newRow.CantCajaLineaOrdenado = row.Item("CantCajaLineaOrdenado")
            newRow.CapacidadHoraXUsuario = row.Item("CapacidadHoraXUsuario")
            newRow.CantUsuarios = row.Item("CantUsuarios")
            newRow.CantXHrUsuario = row.Item("CantXHrUsuario")
            newRow.Operario = row.Item("Operario")
            newRow.H7 = row.Item("H7")
            newRow.H8 = row.Item("H8")
            newRow.H9 = row.Item("H9")
            newRow.H10 = row.Item("H10")
            newRow.H11 = row.Item("H11")
            newRow.H12 = row.Item("H12")
            newRow.H13 = row.Item("H13")
            newRow.H14 = row.Item("H14")
            newRow.H15 = row.Item("H15")
            newRow.H16 = row.Item("H16")
            newRow.H17 = row.Item("H17")
            newRow.H18 = row.Item("H18")
            newRow.H19 = row.Item("H19")
            newRow.H20 = row.Item("H20")
            newRow.H21 = row.Item("H21")
            newRow.H22 = row.Item("H22")

            info.CajasCompletas.AddPlanesCajasCompletasRow(newRow)
            grdCajasCompletas.MoveLast()
        Next

        grdCajasCompletas.Columns("Grupo").SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.Descending
        grdCajasCompletas.Columns("Area de Surtido").SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.Descending
        grdCajasCompletas.UpdateData()


    End Sub

    Private Sub grdCajasCompletas_AfterColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdCajasCompletas.AfterColUpdate
        Try
            If (e.Column.Name = "Usuarios" Or e.Column.Name = "Operario") Then

                Dim HoraInicio As Integer = Integer.Parse(dtpHoraInicio.Value.ToString("HH")) 'La hora en la inicia el proceso de planeacion
                Dim MinutoInicio As Integer = Integer.Parse(dtpHoraInicio.Value.ToString("mm")) 'El minuto en el que inicio el proceso de planeacion
                Dim CantidadOrdenada As Decimal = Decimal.Parse(grdCajasCompletas.Columns("Cantidad").Text) 'La Cantidad ordenada desde la Bapi
                Dim Capacidad As Integer = Integer.Parse(grdCajasCompletas.Columns("Capacidad / Hr / Usuario").Text) 'La capacidad de procesamiento por hora por usuario
                Dim CantUsuarios As Integer = Integer.Parse(grdCajasCompletas.Columns("Usuarios").Text) 'La cantidad de usuarios que participaran en el surtido
                Dim CapacidadTotal As Integer = Capacidad * CantUsuarios 'La cantidad total de procesamiento de cajas o restos por hora
                Dim CantProcesada As Integer = 0 'La cantidad que se estara asignando por cada una de las columnas u horas

                Dim UsuarioAsignado As String = grdCajasCompletas.Columns("Usu. Asignado").Text
                Dim Operario As String = grdCajasCompletas.Columns("Operario").Text

                'Limipiamos las cantidades en la linea de tiempo de toda la fila
                For col = 7 To 22
                    grdCajasCompletas.Columns("H" + col.ToString()).Text() = "0"
                Next

                grdCajasCompletas.Columns("Hr / Usuario").Text = (Capacidad / CantUsuarios).ToString()

                Dim LastHour As Integer
                LastHour = FindLastHourOperador(UsuarioAsignado, Operario)
                If (LastHour > 0) Then
                    HoraInicio = LastHour
                End If

                While CantProcesada < CantidadOrdenada

                    'Obtenemos la cantidad final considerando la variabilidad del tiempo productivo
                    Dim CantUpdate As Integer = GetCantidadUpdate(HoraInicio, MinutoInicio, CapacidadTotal, CantidadOrdenada, CantProcesada)

                    'Si la cantidad obtenida revasa lo ordenado, establecer solo el remanente en la hora(columna) especificada
                    If ((CantUpdate + CantProcesada) > CantidadOrdenada) Then
                        CantUpdate += CantidadOrdenada - (CantUpdate + CantProcesada)
                    End If

                    grdCajasCompletas.Columns("H" + HoraInicio.ToString()).Text = CantUpdate.ToString()

                    'Se reinicializan las variables principales para establecer la cantidad de la siguiente columna
                    HoraInicio += 1
                    CantProcesada += CantUpdate
                    MinutoInicio = 0

                End While

                grdCajasCompletas.UpdateData()

            End If


        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub


    Private Function GetCantidadUpdate(ByVal horaInicio As Integer, ByVal minutoInicio As Integer, ByVal CapacidadTotal As Integer, ByVal cantidadOrdenada As Integer, ByVal cantProcesada As Integer) As Integer
        Dim CantUpdate As Integer = 0

        Dim MinutosComida As Integer = 40 'Se establecen los miuntos que tardan en la hora de comida o desayuno
        Dim MinutosCambioTurno As Integer = 20 'Se establecen los minutos que tardan en el cambio de turno
        Dim MinutosEntrada As Integer = 20 'Se considera la tolerancia de entrada del personal

        'Considerar los minutos en caso de que el usuario no ejecute el plan a una hora exacta, 
        'ejemplo: hora de ejecucion: 10:10am solo considerar 50 minutos como produtivos de esta hora inicio
        If (minutoInicio > 0 And (horaInicio <> 10 And horaInicio <> 15 And horaInicio <> 19 And horaInicio <> 22)) Then
            CapacidadTotal *= (60 - minutoInicio) / 60
        End If

        'En caso de que alguna hora conincida con la hora de comida o cambio de turno considerar solo los minutos productivos
        Select Case horaInicio
            Case 7
                CantUpdate = CapacidadTotal * ((60 - MinutosEntrada) / 60)
            Case 10
                CantUpdate = CapacidadTotal * ((60 - MinutosComida) / 60)
            Case 15
                CantUpdate = CapacidadTotal * ((60 - MinutosCambioTurno) / 60)
            Case 19
                CantUpdate = CapacidadTotal * ((60 - MinutosComida) / 60)
                'En caso de que llege a la ultima hora limite de turno establecer por default la cantidad restante del plan a las 22 horas
            Case 22
                CantUpdate = cantidadOrdenada - (cantProcesada - CapacidadTotal)
            Case Else
                CantUpdate = CapacidadTotal
        End Select

        Return CantUpdate
    End Function

    Private Function FindLastHourOperador(ByVal UsuarioAsignado As String, ByVal Operario As String)
        Dim LastHour As Integer = 0
        Dim LastHourMayor As Integer = 0

        For Each item As DataRow In CType(bsCajasCompletas.DataSource, DataTable).Select("UsuarioAsignado<>' " & UsuarioAsignado & " ' and Operario='" & Operario & "'")
            If (item("H7") > 0) Then
                LastHour = 7
            End If
            If (item("H8") > 0) Then
                LastHour = 8
            End If
            If (item("H9") > 0) Then
                LastHour = 9
            End If
            If (item("H10") > 0) Then
                LastHour = 10
            End If
            If (item("H11") > 0) Then
                LastHour = 11
            End If
            If (item("H12") > 0) Then
                LastHour = 12
            End If
            If (item("H13") > 0) Then
                LastHour = 13
            End If
            If (item("H14") > 0) Then
                LastHour = 14
            End If
            If (item("H15") > 0) Then
                LastHour = 15
            End If
            If (item("H16") > 0) Then
                LastHour = 16
            End If
            If (item("H17") > 0) Then
                LastHour = 17
            End If
            If (item("H18") > 0) Then
                LastHour = 18
            End If
            If (item("H19") > 0) Then
                LastHour = 19
            End If
            If (item("H20") > 0) Then
                LastHour = 20
            End If
            If (item("H21") > 0) Then
                LastHour = 21
            End If
            If (item("H22") > 0) Then
                LastHour = 22
            End If

            If (LastHour > LastHourMayor) Then
                LastHourMayor = LastHour
            End If
        Next

        LastHour = LastHourMayor

        Return LastHour
    End Function


End Class