Imports Microsoft.Reporting.WinForms

Public Class InventarioSegmentoForm

    Private Sub InventarioSegmentoForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            cboFamilias.LoadList()
            cboTipos.LoadList()
            cboArea.LoadListByUsuario(App.Session.User.Identity)
        Catch ex As Exception
            MsgInfo.Show(ex)
            Me.Close()
        End Try

    End Sub

    Private Sub chkSegmentoEspecifico_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSegmentoEspecifico.CheckedChanged
        AplicarVisibleEnable()
    End Sub

    Private Sub rdbFamilia_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbFamilia.CheckedChanged
        AplicarVisibleEnable()
    End Sub

    Private Sub rdbTipo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbTipo.CheckedChanged
        Call AplicarVisibleEnable()
    End Sub

    Private Sub AplicarVisibleEnable()
        cboFamilias.Visible = rdbFamilia.Checked
        cboTipos.Visible = rdbTipo.Checked
        If (chkSegmentoEspecifico.Checked) Then
            cboFamilias.Enabled = rdbFamilia.Checked
            cboTipos.Enabled = rdbTipo.Checked
        Else
            cboFamilias.Enabled = False
            cboTipos.Enabled = False
        End If
    End Sub

    Private Sub cboArea_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboArea.SelectedIndexChanged
        If cboArea.SelectedIndex >= 0 Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                cboAlmacen.LoadListByArea(CInt(cboArea.SelectedValue), App.Session.User.Identity, TipoAccesoAlmacen.Lectura)
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub chkFiltroAlmacen_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFiltroAlmacen.CheckedChanged
        cboArea.Enabled = chkFiltroAlmacen.Checked
        cboAlmacen.Enabled = chkFiltroAlmacen.Checked
    End Sub

    Private Sub tlbImprimir_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles tlbImprimir.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            ImprimirInventarioSegmento()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub ImprimirInventarioSegmento()
        'Cargar información del informe
        Dim AlmacenSvc As New AlmacenFacade
        Dim dtInventario As New DataTable
        Dim IdArea As Integer
        Dim IdAlmacen As Integer
        Dim IdTipo As Integer
        Dim IdFamilia As Integer

        If (chkFiltroAlmacen.Checked) Then
            IdArea = CInt(cboArea.SelectedValue)
            IdAlmacen = CInt(cboAlmacen.SelectedValue)
        Else
            IdArea = 0
            IdAlmacen = 0
        End If

        If (chkSegmentoEspecifico.Checked And rdbFamilia.Checked) Then
            IdFamilia = CInt(cboFamilias.SelectedValue)
            IdTipo = 0
        ElseIf (chkSegmentoEspecifico.Checked And rdbTipo.Checked) Then
            IdFamilia = CInt(cboFamilias.SelectedValue)
            IdTipo = 0
        End If

        dtInventario = AlmacenSvc.GetInformeInventarioBySegmento(App.Session.SessionID, App.Session.User.Identity, App.DefaultSite.Identity, IdArea, IdAlmacen, IdTipo, IdFamilia)

        'Generar parametros
        Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
        Dim Segmento As String
        If (rdbFamilia.Checked) Then
            Segmento = "Familia"
        Else
            Segmento = "Tipo"
        End If
        Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
        Parametros.Add(New ReportParameter("Area", cboArea.Text))
        Parametros.Add(New ReportParameter("CostoMaterial", chkCostoMaterial.Checked.ToString))
        Parametros.Add(New ReportParameter("CostoLabor", chkCostoLabor.Checked.ToString))
        Parametros.Add(New ReportParameter("CostoServicio", chkCostoServicio.Checked.ToString))
        Parametros.Add(New ReportParameter("CostoCarga", chkCostoCarga.Checked.ToString))
        Parametros.Add(New ReportParameter("Agrupador", Segmento))
        'Configurar reporte
        Dim frmFacturas As New ReportForm
        frmFacturas.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Inventario.InventarioSegmentoRPT.rdlc"


        frmFacturas.LocalReport.DataSources.Add(New ReportDataSource("Inventario", dtInventario))
        frmFacturas.LocalReport.SetParameters(Parametros)
        frmFacturas.Show("Informe de Inventario por Segmento")
    End Sub
End Class