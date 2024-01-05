Public Class Form47
    Dim mouse_move As System.Drawing.Point
    Dim nne As Integer = 0
    Dim add As Integer = 0
    Dim n1 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Shortcut1", Nothing)
    Dim n2 = My.Computer.Registry.GetValue(
 "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Shortcut2", Nothing)
    Dim n3 = My.Computer.Registry.GetValue(
 "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Shortcut3", Nothing)
    Dim n4 = My.Computer.Registry.GetValue(
 "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Shortcut4", Nothing)
    Dim n5 = My.Computer.Registry.GetValue(
 "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Shortcut5", Nothing)
    Private Sub Form47_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        Dim added = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "ShortcutsAdded", Nothing)
        If added = 0 Then
            nne = 1
        Else
            add = added
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        Dim mouse_move As New System.Drawing.Point
        mouse_move = New Point(-e.X, e.Y)
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim u As Integer = 0
            If n1 = "" Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
     "Shortcut1", tb.Text)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
         "ShortcutLink1", tb1.Text)
                Form4.Show()
                Form4.Label1.Text = "Shortcut created."
                u = add
                add += 1
                u = add
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
          "ShortcutsAdded", u)
                Exit Sub
            Else
                If n2 = "" Then
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
     "Shortcut2", tb.Text)
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
             "ShortcutLink2", tb1.Text)
                    Form4.Show()
                    Form4.Label1.Text = "Shortcut created."
                    u = add
                    add += 1
                    u = add
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
              "ShortcutsAdded", u)
                    Exit Sub
                Else
                    If n3 = "" Then
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
     "Shortcut3", tb.Text)
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
                 "ShortcutLink3", tb1.Text)
                        Form4.Show()
                        Form4.Label1.Text = "Shortcut created."
                        u = add
                        add += 1
                        u = add
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
                  "ShortcutsAdded", u)
                        Exit Sub
                    Else
                        If n4 = "" Then
                            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
     "Shortcut4", tb.Text)
                            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
                     "ShortcutLink4", tb1.Text)
                            Form4.Show()
                            Form4.Label1.Text = "Shortcut created."
                            u = add
                            add += 1
                            u = add
                            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
                      "ShortcutsAdded", u)
                            Exit Sub
                        Else
                            If n5 = "" Then
                                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
    "Shortcut5", tb.Text)
                                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
                         "ShortcutLink5", tb1.Text)
                                Form4.Show()
                                Form4.Label1.Text = "Shortcut created."
                                u = add
                                add += 1
                                u = add
                                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
                          "ShortcutsAdded", u)
                                Exit Sub
                            Else
                                Form4.Show()
                                Form4.Label1.Text = My.Resources.uhh
                                System.Threading.Thread.Sleep(500)
                                Me.Close()
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
    End Sub

    Private Sub web_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles web.CheckedChanged
        tb.Text = "Web Browser"
        tb1.Text = "web"
    End Sub

    Private Sub file_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles file.CheckedChanged
        tb.Text = "Files"
        tb1.Text = "file"
    End Sub

    Private Sub calc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calc.CheckedChanged
        tb.Text = "Calculator"
        tb1.Text = "calc"
    End Sub

    Private Sub textedit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textedit.CheckedChanged
        tb.Text = "Text Editor"
        tb1.Text = "textedit"
    End Sub

    Private Sub photo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles photo.CheckedChanged
        tb.Text = "Photo Viewer"
        tb1.Text = "photo"
    End Sub

    Private Sub security_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles security.CheckedChanged
        tb.Text = "OliveWeb Security"
        tb1.Text = "security"
    End Sub

    Private Sub music_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles music.CheckedChanged
        tb.Text = "Music Player"
        tb1.Text = "music"
    End Sub

    Private Sub settings_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settings.CheckedChanged
        tb.Text = "Settings"
        tb1.Text = "settings"
    End Sub

    Private Sub webapp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles webapp.CheckedChanged
        tb.Text = "Webapp Installer"
        tb1.Text = "webapp"
    End Sub

    Private Sub help_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles help.CheckedChanged
        tb.Text = "Help"
        tb1.Text = "help"
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form8.Close()
        Form51.Show()
        Me.Close()
        Exit Sub
    End Sub
End Class