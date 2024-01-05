Public Class Form25

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form22.Show()
        Form22.Label4.Text = Form10.Label11.Text
        Dim u As Integer = 0
        Dim add As Integer = 0
        Dim added = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "ShortcutsAdded", Nothing)
        add = added
        If Form22.Label4.Text = "s1" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
    "Shortcut1", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
     "ShortcutLink1", "")
            u = add
            add -= 1
            u = add
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
      "ShortcutsAdded", u)
        End If
        If Form22.Label4.Text = "s2" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
   "Shortcut2", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
     "ShortcutLink2", "")
            u = add
            add -= 1
            u = add
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
      "ShortcutsAdded", u)
        End If
        If Form22.Label4.Text = "s3" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
   "Shortcut3", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
     "ShortcutLink3", "")
            u = add
            add -= 1
            u = add
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
      "ShortcutsAdded", u)

        End If
        If Form22.Label4.Text = "s4" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
   "Shortcut4", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
     "ShortcutLink4", "")
            u = add
            add -= 1
            u = add
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
      "ShortcutsAdded", u)
        End If
        If Form22.Label4.Text = "s5" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
   "Shortcut5", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
     "ShortcutLink5", "")
            u = add
            add -= 6
            u = add
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
      "ShortcutsAdded", u)
        End If
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
        Form4.Label1.Text = "Item removal complete."
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
        If Form10.Label11.Text = "s1" Then
            Label1.Text = "Remove shortcut?"
        End If
        If Form10.Label11.Text = "s2" Then
            Label1.Text = "Remove shortcut?"
        End If
        If Form10.Label11.Text = "s3" Then
            Label1.Text = "Remove shortcut?"
        End If
        If Form10.Label11.Text = "s4" Then
            Label1.Text = "Remove shortcut?"
        End If
        If Form10.Label11.Text = "s5" Then
            Label1.Text = "Remove shortcut?"
        End If
    End Sub
End Class