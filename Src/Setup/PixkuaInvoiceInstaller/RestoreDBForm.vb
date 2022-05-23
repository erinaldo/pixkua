Imports System.Data.SqlClient
Imports System.IO
Imports System.Xml

Public Class RestoreDBForm
    Private InstallDirectory As String
    Private ApplicationDataFolder As String

    Private Function GetSQLConnectionString(includeDB As Boolean) As String
        Dim CnnStr As String = "Data Source=.\sqlexpress;"
        If includeDB Then CnnStr &= "Initial Catalog=Pixkua;"
        CnnStr &= "User ID=sa; Password=@zt3c@Swf"
        Return CnnStr
    End Function

    Private Function TestSQLConnection() As Boolean
        Dim CnnStr As String = GetSQLConnectionString(False)
        Dim Cnn As New SqlConnection(CnnStr)
        Try
            Cnn.Open()
            MessageBox.Show("La conexión ha sido exitosa.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al conectar con el servidor SQL Server." & ControlChars.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            Cnn.Close()
        End Try
        Return False
    End Function

    Private Sub SetSQLConennection()
        Dim CnnStr As String = GetSQLConnectionString(True)
        Dim ConfigFileName As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Pixkua\DataConfig.xml"
        'Verificar si existe el archivo de configuración de acceso a datos
        If Not File.Exists(ConfigFileName) Then
            Dim Writer As TextWriter = File.CreateText(ConfigFileName)
            Writer.Write(My.Resources.DataConfig)
            Writer.Close()
        End If
        Try
            'Cargar archivo de conexión a datos
            Dim DataConfig As New XmlDocument
            DataConfig.Load(ConfigFileName)
            'Establecer valor de cadena de conexión
            Dim CnnStrNode As XmlNode = DataConfig.SelectSingleNode("/DataConfiguration/ConnectionString")
            CnnStrNode.InnerText = CnnStr
            'Guardar cambio en archivo
            DataConfig.Save(ConfigFileName)
        Catch ex As Exception
            Throw New Exception("Error al establecer la configuración de conexión en el archivo: " & ConfigFileName, ex)
        End Try
    End Sub


    Private Function OpenConnection() As SqlConnection
        Dim CnnStr As String = GetSQLConnectionString(False)
        Dim Cnn As New SqlConnection(CnnStr)
        Try
            Cnn.Open()
            Return Cnn
        Catch ex As Exception
            Throw New Exception("Error al abrir la conexión al servidor SQL Server. " & ex.ToString)
        End Try
    End Function

    Private Sub DescomprimirBD()
        Dim BackupFile As String = ApplicationDataFolder & "\PixkuaClear.bak"
        If Not File.Exists(BackupFile) Then
            Dim ZipFile As String = InstallDirectory & "PixkuaClear.zip"
            Dim Zip As New Chilkat.Zip
            Zip.UnlockComponent("RICARDZIP_kn8STeEe3Lq6")

            '
            Dim success As Boolean = Zip.OpenZip(ZipFile)
            If Not success Then Throw New Exception("Error al abrir el archivo " & ZipFile & ". " & Zip.LastErrorText)
            Dim Count As Integer = Zip.Unzip(ApplicationDataFolder)
            If Count = -1 Then Throw New Exception("Error al descomprimir el archivo " & ZipFile & ". " & Zip.LastErrorText)
        End If
    End Sub

    Private Sub EnableCLR(cnn As SqlConnection)
        Dim comSetup As New SqlCommand("sp_configure 'clr enabled', 1;reconfigure;", cnn)
        comSetup.ExecuteNonQuery()
    End Sub

    Private Sub RestaurarBD()
        Try
            Dim Cnn As SqlConnection = OpenConnection()
            Dim BackupFile As String = ApplicationDataFolder & "\PixkuaClear.bak"
            Dim strCommand As String = "RESTORE DATABASE Pixkua FROM Disk='" & BackupFile & "' WITH " &
                " MOVE 'Pixkua' TO '" & ApplicationDataFolder & "\Pixkua.mdf'," &
                " MOVE 'Pixkua_log' TO '" & ApplicationDataFolder & "\Pixkua_log.ldf'"
            Dim comRestore As New SqlCommand(strCommand, Cnn)
            comRestore.CommandTimeout = 600
            comRestore.ExecuteNonQuery()
            'Habilitar el clr en el servidor
            EnableCLR(Cnn)
        Catch ex As Exception
            Throw New Exception("Error al restaurar la base de datos.", ex)
        End Try
    End Sub

    Public Overloads Function ShowDialog(installDir As String, dataFolder As String) As DialogResult
        Me.InstallDirectory = installDir
        Me.ApplicationDataFolder = dataFolder
        Return MyBase.ShowDialog()
    End Function


    Private Sub RestoreDBForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            'Descomprimir archivo que contiene la base de datos
            lblStatus.Text = "Descomprimiendo base de datos..."
            Application.DoEvents()
            DescomprimirBD()
            lblStatus.Text = "Restaurando base de datos..."
            Application.DoEvents()
            'Restaurar base de datos
            RestaurarBD()
            SetSQLConennection()
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            DialogResult = System.Windows.Forms.DialogResult.Cancel
        End Try
    End Sub
End Class