
Public Class Registry

    Private Sub New()

    End Sub

    Public Shared Function getValue(ByVal section As String, ByVal key As String, ByVal def As String) As String
        Dim strTemp As String
        Dim SubKey As Microsoft.Win32.RegistryKey
        '
        SubKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(App.RegistryPath & section, True)
        If SubKey Is Nothing Then
            strTemp = def
            SubKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(App.RegistryPath & section)
            SubKey.SetValue(key, strTemp)
        Else
            strTemp = CStr(SubKey.GetValue(key, ""))
            If strTemp = "" Then strTemp = def
            SubKey.SetValue(key, strTemp)
        End If
        Return strTemp
    End Function

    Public Shared Sub setValue(ByVal section As String, ByVal key As String, ByVal value As String)
        Dim SubKey As Microsoft.Win32.RegistryKey
        '
        SubKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(App.RegistryPath & section, True)
        If SubKey Is Nothing Then
            SubKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(App.RegistryPath & section)
        End If
        SubKey.SetValue(Key, Value)
    End Sub
End Class
