Public Class InsumosOpcionalesForm
    Dim insumosOpcionalesTable As ProductosDS.InsumosOpcionalesDataTable
    Private _returnInsumosTable As ProductosDS.InsumosOpcionalesDataTable

    Public ReadOnly Property returnInsumosTable As ProductosDS.InsumosOpcionalesDataTable
        Get
            Return _returnInsumosTable
        End Get
    End Property

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal insumosOpcionales As ProductosDS.InsumosOpcionalesDataTable) As DialogResult
        insumosOpcionalesTable = insumosOpcionales
        InsumosShow()
        Return MyBase.ShowDialog(owner)
    End Function


    Private Sub InsumosShow()

        Dim CentroProdFac As New CentroProduccionFacade

        If IsNothing(insumosOpcionalesTable) Then Exit Sub

        pnlInsumos.Controls.Clear()

        Dim countY As Integer = 1

        'Ponemos el boton de anterior para los centros de produccion previos cuando se está paginando la lista
        'addPreviusButtonCentroProd(SizeBtn * (countY - 1), 0) : countY = countY + 1

        Dim dv As New DataView(insumosOpcionalesTable, "", "", System.Data.DataViewRowState.CurrentRows)

        ''''''Dim inicio As Integer = (centroProdPagina - 1) * centroProdCapacidad
        ''''''Dim Fin As Integer = inicio + centroProdCapacidad
        For i As Integer = 0 To dv.Count 'inicio To Fin - 1
            If i > insumosOpcionalesTable.Rows.Count - 1 Then Exit For

            'cada vez q se llene una linea de botones en Y, se resetea Y 
            'If countY > CentrosProduccionTable.Rows.Count Then countY = 1

            Dim Imagen As Byte()
            ''''''  If IsDBNull(dv(i)("Imagen")) Then
            Imagen = Nothing
            ''''''Else
            ''''''Imagen = dv(i)("Imagen")
            ''''''End If

            'Agrega el boton del centro de produccion
            addIngedientesExtra(dv(i)("IdInsumo"), dv(i)("Insumo"), Imagen, countY)

            countY = countY + 1
        Next
        'Ponemos el boton de siguiente para los Centros de produccion previos cuando se está paginando la lista 
        ''addNextButtonCentroProd(SizeBtn * (countY - 1), 0)
    End Sub

    Private Sub addIngedientesExtra(ByVal Id As Integer, ByVal Descripcion As String, ByVal imagen As Byte(), ByVal index As Integer)
        Dim multi As New MultiSeleccionButtonsControl
        'multi.ImageButton = imagen
        multi.Key = Id
        multi.Descripcion = Descripcion
        multi.Valor = 0 : multi.MostrarNumeric = False
        multi.Left = 1 : multi.Top = multi.Height * (index - 1)
        AddHandler multi.selectEvent, AddressOf SeleccionInsumo
        pnlInsumos.Controls.Add(multi)
    End Sub

    Private Sub SeleccionInsumo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim multi As MultiSeleccionButtonsControl = CType(sender, MultiSeleccionButtonsControl)

        If multi.Seleccionado Then
            multi.ImageButton = Nothing
            multi.Seleccionado = False
        Else
            multi.ImageButton = My.Resources.check_mark_24
            multi.Seleccionado = True
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        _returnInsumosTable = New ProductosDS.InsumosOpcionalesDataTable
        For Each item As MultiSeleccionButtonsControl In pnlInsumos.Controls
            If item.Seleccionado Then
                Dim drNew As ProductosDS.InsumosOpcionalesRow = _returnInsumosTable.NewInsumosOpcionalesRow
                With drNew
                    .IdInsumo = item.Key
                    .Insumo = item.Descripcion
                End With
                _returnInsumosTable.AddInsumosOpcionalesRow(drNew)
            End If
        Next
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

End Class