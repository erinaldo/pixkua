Imports Microsoft.Reporting.WinForms

Public Class CriptaForm

    Private Sub txtPoblacion_InfoLoaded(sender As System.Object, e As System.EventArgs) Handles txtPoblacion.InfoLoaded
        Dim poblacion As Azteca.Kernel.General.PoblacionInfo = CType(txtPoblacion.PackageInfo, Azteca.Kernel.General.PoblacionInfo)
        lblEstadoInf.Text = poblacion.Estado
    End Sub

    Private Sub CriptaForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
        chkActivo.Checked = True
    End Sub

    Private Sub CriptaForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpFechaCenizas1.Value = DateTime.Today.AddYears(-100)
        dtpFechaCenizas2.Value = DateTime.Today.AddYears(-100)
        dtpFechaCenizas3.Value = DateTime.Today.AddYears(-100)
    End Sub

    Private Sub CriptaForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Try
            Dim CriptaInfo As CriptaInfo = CType(PackageInfo, CriptaInfo)
            With CriptaInfo
                'Datos Personales
                txtCorreo.Text = .Correo
                txtCalle.Text = .Calle
                txtNumExt.Text = .NumExt
                txtNumInt.Text = .NumInt
                txtColonia.Text = .Colonia
                txtCP.Text = .CP
                chkActivo.Checked = CBool(IIf(.Status = CatalogState.Active, True, False))
                txtPoblacion.Text = CStr(.IdPoblacion)
                txtPoblacion.LoadInfo()

                'Adicional
                txtNumeroCripta.Text = .NumeroCripta
                txtNombrePlaca.Text = .NombrePlaca
                txtTelefonoCasa.Text = .TelCasa
                txtCelular.Text = .Celular
                txtObservaciones.Text = .Observaciones
                chkPagado.Checked = .Pagado
                chkFN.Checked = .FN

                'Cenizas
                txtCenizasDe.Text = .CenizasDe1
                txtCenizasDe2.Text = .CenizasDe2
                txtCenizasDe3.Text = .CenizasDe3
                dtpFechaCenizas1.Value = .FechaDeposito1
                dtpFechaCenizas2.Value = .FechaDeposito2
                dtpFechaCenizas3.Value = .FechaDeposito3
                txtTitular.Text = .Titular
                txtBeneficiario.Text = .Beneficiario
                txtNumeroContrato.Text = .NumeroContrato
            End With

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub CriptaForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Try
            Dim CriptaInfo As CriptaInfo = CType(PackageInfo, CriptaInfo)
            With CriptaInfo
                'Datos Personales
                .Correo = txtCorreo.Text
                .Calle = txtCalle.Text
                .NumExt = txtNumExt.Text
                .NumInt = txtNumInt.Text
                .Colonia = txtColonia.Text
                .CP = txtCP.Text
                .Status = CType(IIf(chkActivo.Checked, CatalogState.Active, CatalogState.Inactive), CatalogState)
                .IdPoblacion = txtPoblacion.Key

                'Adicional
                .NumeroCripta = txtNumeroCripta.Text
                .NombrePlaca = txtNombrePlaca.Text
                .TelCasa = txtTelefonoCasa.Text
                .Celular = txtCelular.Text
                .Observaciones = txtObservaciones.Text
                .Pagado = chkPagado.Checked
                .FN = chkFN.Checked

                'Cenizas
                .CenizasDe1 = txtCenizasDe.Text
                .CenizasDe2 = txtCenizasDe2.Text
                .CenizasDe3 = txtCenizasDe3.Text
                .FechaDeposito1 = dtpFechaCenizas1.Value
                .FechaDeposito2 = dtpFechaCenizas2.Value
                .FechaDeposito3 = dtpFechaCenizas3.Value
                .Titular = txtTitular.Text
                .Beneficiario = txtBeneficiario.Text
                .NumeroContrato = txtNumeroContrato.Text

            End With

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdImprimir_Click(sender As System.Object, e As System.EventArgs) Handles cmdImprimir.Click
        Try
            'Cargar información del informe
            Dim CriptaSvc As New CriptaFacade
            Dim dtCriptas As New DataTable

            dtCriptas = CriptaSvc.GetCriptas(App.Session.SessionID)

            'Generar parametros
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
            'Configurar reporte
            Dim frmReport As New ReportForm
            With frmReport
                .LocalReport.ReportEmbeddedResource = "Azteca.Windows.Iglesia.CriptasRPT.rdlc"
                .LocalReport.DataSources.Add(New ReportDataSource("dtCriptas", dtCriptas))
                .LocalReport.SetParameters(Parametros)
                .Show("Lista de Criptas")
            End With


        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub
End Class