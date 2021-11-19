Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "Username", TextBox1.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "Password", TextBox2.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "CurrentSetupState", "done")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
      "PackEnabled", "no")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "Wallpaper", "def2")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
      "", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
      "", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\Login",
     "", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
             "Browser", "https://www.bing.com")
        Form27.Show()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        Dim setup = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "CurrentSetupState", Nothing)
        Dim bk = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition Backup", "Backup", Nothing)
        If bk = "" Then
            'nothing
        Else
            If setup = "" Then
                Form6.Close()
                Me.Close()
                Form39.Show()
                Exit Sub
            End If
        End If
        If setup = "" Then
            Form6.Show()
        Else
            Me.Close()
            Form7.Show()
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "PFP", "3")
        Form4.Show()
        Form4.Label1.Text = "Set."
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
         "PFP", "1")
        Form4.Show()
        Form4.Label1.Text = "Set."
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "PFP", "4")
        Form4.Show()
        Form4.Label1.Text = "Set."
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "PFP", "2")
        Form4.Show()
        Form4.Label1.Text = "Set."
    End Sub

    Private Sub Form2_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "Username", TextBox3.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "Password", TextBox4.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "CurrentSetupState", "done")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
      "PackEnabled", "no")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "Wallpaper", "def2")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
      "", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
      "", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition Backup",
     "Backup", "1")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "CurrentSetupState", "done")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
             "Browser", "https://www.bing.com")
        backUp()
        Form27.Show()
    End Sub
    Private Sub backUp()
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition Backup",
      "Username", TextBox3.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition Backup",
        "Password", TextBox4.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition Backup",
        "CurrentSetupState", "done")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition Backup",
      "PackEnabled", "no")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition Backup",
        "Wallpaper", "def2")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition Backup",
      "Browser", "https://www.bing.com/")
    End Sub

    Private Sub pb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pb.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "PFP", "1")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition Backup",
       "PFP", "1")
        Form4.Show()
        Form4.Label1.Text = "Set."
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "PFP", "2")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition Backup",
     "PFP", "2")
        Form4.Show()
        Form4.Label1.Text = "Set."
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "PFP", "3")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition Backup",
     "PFP", "3")
        Form4.Show()
        Form4.Label1.Text = "Set."
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        End
        End
        End
    End Sub

    Private Sub TextBox3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox3.MouseClick
        TextBox3.Clear()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox4.MouseClick
        TextBox4.Clear()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class