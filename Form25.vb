Public Class Form25

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form22.Show()
        Form22.Label4.Text = Form10.Label11.Text
        If Form22.Label4.Text = "1" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "AppName1", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "AppLink1", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "Img1", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "site1", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "Edit1", "")
        End If
        If Form22.Label4.Text = "2" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
           "AppName2", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "AppLink2", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
           "Img2", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "site2", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "Edit2", "")
        End If
        If Form22.Label4.Text = "3" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "AppName3", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "AppLink3", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
           "Img3", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "site3", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "Edit3", "")
        End If
        If Form22.Label4.Text = "4" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "AppName4", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "AppLink4", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
           "Img4", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "site4", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "Edit4", "")
        End If
        If Form22.Label4.Text = "5" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "AppName5", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "AppLink5", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
           "Img5", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "site5", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "Edit5", "")
        End If
        Form4.Show()
        Form4.Label1.Text = "Uninstall complete."
        Form22.Close()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form22.Close()
    End Sub

    Private Sub Form25_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.error_snd, AudioPlayMode.Background)
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
    End Sub
End Class