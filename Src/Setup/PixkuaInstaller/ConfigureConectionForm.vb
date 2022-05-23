Imports System.IO
Imports System.Xml
Imports System.Data.SqlClient

Public Class ConfigureConectionForm
    Private InstallDirectory As String
    Private ApplicationFolder As String

#Region "Metodos Privados"

    Private Function GetServerUrl() As String
        Dim url As String = String.Empty
        If rdbTCP.Checked Then
            url = "http://"
        Else
            url = "tcp://"
        End If
        url &= txtRemoteServer.Text.Trim & ":" & CInt(nudPuerto.Value).ToString & "/"
        'Si la conexión es http, concatenar el directorio virtual
        If rdbHTTP.Checked And txtDirVirtual.Text.Trim <> String.Empty Then
            url &= txtDirVirtual.Text.Trim & "/"
        End If
        Return url
    End Function

    Private Function GetSQLConnectionString() As String
        'Armar cadena de conexión
        Dim CnnStr As String = "Data Source=" & txtDatabaseServer.Text.Trim & ";Initial Catalog=" & txtDatabase.Text.Trim
        If rdbWindowsAuth.Checked Then
            CnnStr &= ";Integrated Security=SSPI"
        Else
            CnnStr &= ";User ID=" & txtUsuario.Text.Trim & ";Password=" & txtPassword.Text
        End If
        Return CnnStr
    End Function

    Private Function TestRemoteConnection() As Boolean
        Return False
    End Function

    Private Function TestSQLConnection() As Boolean
        Dim CnnStr As String = GetSQLConnectionString()
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
        Dim CnnStr As String = GetSQLConnectionString()
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

    Private Sub SetRemoteConnection()

    End Sub

#End Region

#Region "Implementacion"

    Public Overloads Function ShowDialog(ByVal installDirectory As String) As DialogResult
        Me.InstallDirectory = installDirectory
        Return MyBase.ShowDialog
    End Function

    Private Sub ConfigureConectionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ApplicationFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Pixkua"
        If Not Directory.Exists(ApplicationFolder) Then Directory.CreateDirectory(ApplicationFolder)
    End Sub

    Private Sub rdbNoRemoting_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbNoRemoting.CheckedChanged
        pnlNoRemoting.Visible = True
        pnlRemoting.Visible = False
    End Sub

    Private Sub rdbRemoting_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbRemoting.CheckedChanged
        pnlNoRemoting.Visible = False
        pnlRemoting.Visible = True
    End Sub

    Private Sub rdbWindowsAuth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbWindowsAuth.CheckedChanged
        txtUsuario.Enabled = False
        txtPassword.Enabled = False
    End Sub

    Private Sub rdbSQL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSQL.CheckedChanged
        txtUsuario.Enabled = True
        txtPassword.Enabled = True
    End Sub

    Private Sub rdbTCP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbTCP.CheckedChanged
        nudPuerto.Value = 8089
        txtDirVirtual.Enabled = False
        txtDirVirtual.Text = String.Empty
        cboFormato.SelectedIndex = 0
    End Sub

    Private Sub rdbHTTP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbHTTP.CheckedChanged
        nudPuerto.Value = 80
        txtDirVirtual.Enabled = True
        txtDirVirtual.Text = "Pixkua"
        cboFormato.SelectedIndex = 1
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            btnAceptar.Enabled = False
            btnCancelar.Enabled = False
            If rdbNoRemoting.Checked Then
                SetSQLConennection()
            Else
                SetRemoteConnection()
            End If
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnAceptar.Enabled = True
            btnCancelar.Enabled = True
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnTestSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestSQL.Click
        TestSQLConnection()
    End Sub

#End Region

End Class