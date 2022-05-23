Imports System.ComponentModel
Imports System.Configuration.Install
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.Data.SqlClient
Imports System.IO
Imports System.Xml

Public Class Installer
    Private InstallDirectory As String
    Private ApplicationDataFolder As String

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add initialization code after the call to InitializeComponent

    End Sub


    Public Overrides Sub Commit(ByVal savedState As System.Collections.IDictionary)
        InstallDirectory = Me.Context.Parameters("SOURCEDIR")
        Try
            ApplicationDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Pixkua\Database"
            If Not Directory.Exists(ApplicationDataFolder) Then Directory.CreateDirectory(ApplicationDataFolder)
            'Crear los códigos de registro para éste equipo
            Dim LicManager As New Azteca.Kernel.Licensing.LicenseManager
            LicManager.CreateRegistrationCodes()
            'Inicializar contexto de la aplicación
            Azteca.Windows.App.InitSystem("Pixkua")
            'Restaurar base de datos
            Dim frmRestore As New RestoreDBForm
            frmRestore.ShowDialog(InstallDirectory, ApplicationDataFolder)
            MyBase.Commit(savedState)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MyBase.Rollback(savedState)
        End Try
    End Sub

End Class
