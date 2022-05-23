Imports System.ComponentModel
Imports System.Configuration.Install
Imports System.Windows.Forms
Imports System.Diagnostics

Public Class Installer

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add initialization code after the call to InitializeComponent

    End Sub

    Public Overrides Sub Commit(ByVal savedState As System.Collections.IDictionary)
        Dim InstallType As String = Me.Context.Parameters("InstallType")
        Dim InstallDir As String = Me.Context.Parameters("SOURCEDIR")
        Try            
            'Crear los códigos de registro para éste equipo
            Dim LicManager As New Azteca.Kernel.Licensing.LicenseManager
            LicManager.CreateRegistrationCodes()
            'Inicializar contexto de la aplicación
            Azteca.Windows.App.InitSystem("Pixkua")            
            '
            If InstallType = "Full" Then
                'Restaurar bd
                Dim frmDatabase As New CreateDBForm
                frmDatabase.ShowDialog(InstallDir)
            Else
                'Decidir conexión a bd existente o crear una nueva
                Dim frmOptions As New DBOptionsForm
                frmOptions.ShowDialog(InstallDir)
            End If
            'Mostrar pantalla de registro de licencias
            Dim frmLicencias As New LicenciasForm
            frmLicencias.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        MyBase.Commit(savedState)
    End Sub



End Class
