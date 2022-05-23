Public Class PedidoDomicilioForm
    Private _Comanda As ComandaInfo

    Public Overloads Function showdialog(ByVal IdComandaTit As String) As DialogResult

        If IdComandaTit.Length = 0 Then
            _Comanda = New ComandaInfo(App.Session.SessionID)
        Else
            Dim ComandaFac As New ComandaFacade
            _Comanda = ComandaFac.GetDetail(App.Session.SessionID, IdComandaTit)
            fillComanda()
        End If

        Return MyBase.ShowDialog
    End Function

    Private Sub btnComanda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnComanda.Click
        Dim frm As New ComandaForm
        If frm.ShowDialog(_Comanda) = System.Windows.Forms.DialogResult.OK Then
            fillComanda()
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Not Validar() Then Exit Sub
        Try
            Dim ComandaFac As New ComandaFacade
            _Comanda.IdCliente = selCliente.Key : _Comanda.IdRepartidor = 0 : _Comanda.IdSucursal = App.DefaultSite.Identity : _Comanda.Observaciones = txtObservaciones.Text
            _Comanda = ComandaFac.Update(_Comanda)
            'Se manda imprimir todos los articulos pendientes de envio a su centro de produccion
            Context.PrintTicketPedimento(_Comanda.Identity)
            MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnNuevoContacto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoContacto.Click
        Try
            Dim Cliente As ClienteInfo = CType(selCliente.PackageInfo, ClienteInfo)
            Dim PersonaBase As Azteca.Kernel.General.PersonaInfo = fillDatosBasePersona(Cliente)

            Dim frmContacto As New Azteca.Windows.Forms.General.CatalogoPersonas
            frmContacto.StartPosition = FormStartPosition.CenterParent
            If frmContacto.ShowDialog(Me, PersonaBase, "Nuevo contacto") = System.Windows.Forms.DialogResult.OK Then
                Dim Contacto As Azteca.Kernel.General.PersonaInfo = CType(frmContacto.PackageInfo, Azteca.Kernel.General.PersonaInfo)
                With Contacto
                    Dim drContacto As Azteca.Business.Ventas.ClientesDS.ContactosRow = Cliente.Contactos.NewContactosRow
                    drContacto.IdPersona = .Identity
                    drContacto.Nombre = .Nombre
                    drContacto.Apellidos = .ApellidoP & " " & .ApellidoM
                    drContacto.Telefono = .TelOficina
                    drContacto.Celular = .Celular
                    drContacto.Correo = .Correo
                    Cliente.Contactos.AddContactosRow(drContacto)
                End With
                Dim ClienteFac As New ClienteFacade
                ClienteFac.Update(Cliente)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        MyBase.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub ServicioDomicilioForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        resetCliente()
        If _Comanda.IdCliente <> 0 Then selCliente.LoadInfo(_Comanda.IdCliente)
    End Sub

    Private Sub selCliente_InfoLoaded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCliente.LoadingInfo
        'Contactos
        Dim Cliente As ClienteInfo = CType(selCliente.PackageInfo, ClienteInfo)
        With Cliente
            'Domicilio
            lblCalleTXT.Text = .Calle
            lblNumeroTXT.Text = .NumExt
            lblInteriorTXT.Text = .NumInt
            lblColoniaTXT.Text = .Colonia
            lblCPtxt.Text = .CP
            ''lblPoblaciontxt.Text = CStr(.IdPoblacion)
            lblCruzaConTXT.Text = CStr(.IdPoblacion)
        End With
        btnNuevoContacto.Enabled = True
        bsContactos.DataSource = Cliente.Contactos
    End Sub

    Private Sub selCliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        resetCliente()
    End Sub


#Region "Metodos Privados"

    Private Sub resetCliente()
        lblCalleTXT.Text = "" : lblNumeroTXT.Text = "" : lblInteriorTXT.Text = "" : lblCruzaConTXT.Text = "" : lblColoniaTXT.Text = "" : lblCPtxt.Text = ""
        btnNuevoContacto.Enabled = False
    End Sub

    Private Sub fillComanda()
        Dim Partida As Integer = 0
        Dim Total As Decimal = 0
        Dim CantidadItems As Integer = 0

        lvwComanda.BeginUpdate()
        lvwComanda.Items.Clear()
        ''Dim vwOrdenes As New DataView(dtOrdenes, "", "Fecha DESC, SUCURSAL", DataViewRowState.CurrentRows)
        For Each dr As ComandaDS.ComandaDetRow In _Comanda.Details
            If Not dr.RowState = DataRowState.Deleted Then
                Dim Item As New ListViewItem(dr.Articulo, 2)
                Item.SubItems.Add(dr.Cantidad.ToString("#0"))
                Item.SubItems.Add(dr.PrecioNeto.ToString("#0.00"))
                Dim Importe As Decimal = dr.PrecioNeto * dr.Cantidad
                Item.SubItems.Add(Importe.ToString("#0.00"))

                Item.Tag = CType(dr, ComandaDS.ComandaDetRow)
                lvwComanda.Items.Add(Item)

                'Mostramos los ingredientes Extra
                Dim dvExtras As New DataView(_Comanda.IngredientesExtra, "IdArticulo=" & dr.IdArticulo, "Partida", DataViewRowState.CurrentRows)
                For Each drExtra As DataRowView In dvExtras
                    If Partida <> drExtra("Partida") Then
                        Dim ItemPartida As New ListViewItem(CStr("     Partida:" & drExtra("Partida")), 2)
                        lvwComanda.Items.Add(ItemPartida.Clone)
                    End If
                    Dim ItemExtra As New ListViewItem()
                    ItemExtra.BackColor = Color.Beige
                    ItemExtra.Text = "     " + "*" + CStr(drExtra("Insumo"))
                    lvwComanda.Items.Add(ItemExtra)
                    Partida = drExtra("Partida")
                Next
                Total = Total + Importe
                CantidadItems = CantidadItems + dr.Cantidad
            End If
        Next
        lvwComanda.EndUpdate()
        lblTotTotalTXT.Text = Total.ToString("#0.00")
        lblTotCantidadTXT.Text = CantidadItems.ToString("#0")
    End Sub

    Private Function fillDatosBasePersona(ByVal Cliente As ClienteInfo) As Azteca.Kernel.General.PersonaInfo
        Dim Persona As New Azteca.Kernel.General.PersonaInfo(App.Session.SessionID)
        With Persona
            .Calle = Cliente.Calle
            .Colonia = Cliente.Colonia
            .NumExt = Cliente.NumExt
            .NumInt = Cliente.NumInt
            .CP = Cliente.CP
            .IdPoblacion = Cliente.IdPoblacion
            .IdEmpresa = Cliente.IdEmpresa
            .IdSucursal = Cliente.IdSucursal
            .TelCasa = Cliente.Telefonos
            .Status = Kernel.BusinessStructure.CatalogState.Active
        End With
        Return Persona
    End Function

    Private Function Validar() As Boolean
        If _Comanda.Details.Rows.Count = 0 Then
            MessageBox.Show("Debe seleccionar al menos un platillo de la carta", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        If selCliente.Key = 0 Then
            MessageBox.Show("Debe seleccionar al cliente del pedido", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        Return True
    End Function

#End Region


    Private Sub selCliente_InfoLoaded(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles selCliente.LoadingInfo

    End Sub
End Class