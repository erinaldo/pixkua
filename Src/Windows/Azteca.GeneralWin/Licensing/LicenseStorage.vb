Public NotInheritable Class LicenseStorage

    Private Const ACCOUNTING = "Contabilidad"
    Private Const INVENTORY = "Inventario"
    Private Const PURCHASING = "Compras"
    Private Const SALES = "Ventas"
    Private Const MAINTENANCE = "Mantenimiento"
    Private Const MANUFACTURING = "Produccion"
    Private Const DISTRIBUTION = "Distribucion"
    Private Const HUMAN_RESOURCES = "Recursos Humanos"


    Private Sub New()

    End Sub

    Private Shared Sub AddLicenseRow(ByVal licencias As LicenciasDS.LicenciasDataTable, ByVal licenseModule As Azteca.Kernel.Licensing.LicenseModule, ByVal moduleName As String)
        Dim LicManager As New Azteca.Kernel.Licensing.LicenseManager
        Dim drLicense As LicenciasDS.LicenciasRow = licencias.NewLicenciasRow
        With drLicense
            .Modulo = moduleName
            .CodigoRegistro = LicManager.LoadRegistrationCode(licenseModule).ToString.ToUpper
            .Licencia = Registry.GetValue("Licencias", moduleName, String.Empty)
            If .Licencia = String.Empty Then
                .Estatus = 1
            Else
                If LicManager.ValidateLicenseCode(licenseModule, .Licencia) Then
                    .Estatus = 2
                Else
                    .Estatus = 0
                End If
            End If
        End With
        licencias.AddLicenciasRow(drLicense)
    End Sub

    Public Shared Function LoadLicenses() As LicenciasDS.LicenciasDataTable
        Dim Licencias As New LicenciasDS.LicenciasDataTable
        AddLicenseRow(Licencias, Kernel.Licensing.LicenseModule.Accounting, ACCOUNTING)
        AddLicenseRow(Licencias, Kernel.Licensing.LicenseModule.Inventory, INVENTORY)
        AddLicenseRow(Licencias, Kernel.Licensing.LicenseModule.Purchasing, PURCHASING)
        AddLicenseRow(Licencias, Kernel.Licensing.LicenseModule.Sales, SALES)
        AddLicenseRow(Licencias, Kernel.Licensing.LicenseModule.Maintenance, MAINTENANCE)
        AddLicenseRow(Licencias, Kernel.Licensing.LicenseModule.Manufacturing, MANUFACTURING)
        AddLicenseRow(Licencias, Kernel.Licensing.LicenseModule.HumanResources, HUMAN_RESOURCES)
        AddLicenseRow(Licencias, Kernel.Licensing.LicenseModule.Distribution, DISTRIBUTION)
        Return Licencias
    End Function

    Public Shared Sub SaveLicenses(ByVal licenses As LicenciasDS.LicenciasDataTable)
        For Each drLicense As LicenciasDS.LicenciasRow In licenses
            Registry.SetValue("Licencias", drLicense.Modulo, drLicense.Licencia)
        Next
    End Sub

    Public Shared Sub CreateLicenseCache()
        App.Licenses.Clear()
        App.Licenses.Add(Kernel.Licensing.LicenseModule.Accounting, Registry.GetValue("Licencias", ACCOUNTING, String.Empty))
        App.Licenses.Add(Kernel.Licensing.LicenseModule.Inventory, Registry.GetValue("Licencias", INVENTORY, String.Empty))
        App.Licenses.Add(Kernel.Licensing.LicenseModule.Purchasing, Registry.GetValue("Licencias", PURCHASING, String.Empty))
        App.Licenses.Add(Kernel.Licensing.LicenseModule.Sales, Registry.GetValue("Licencias", SALES, String.Empty))
        App.Licenses.Add(Kernel.Licensing.LicenseModule.Maintenance, Registry.GetValue("Licencias", MAINTENANCE, String.Empty))
        App.Licenses.Add(Kernel.Licensing.LicenseModule.Manufacturing, Registry.GetValue("Licencias", MANUFACTURING, String.Empty))
        App.Licenses.Add(Kernel.Licensing.LicenseModule.HumanResources, Registry.GetValue("Licencias", HUMAN_RESOURCES, String.Empty))
        App.Licenses.Add(Kernel.Licensing.LicenseModule.Distribution, Registry.GetValue("Licencias", DISTRIBUTION, String.Empty))
    End Sub

End Class
