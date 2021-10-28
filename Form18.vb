Imports System.Collections.ObjectModel
Imports System.Text
Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation


Public Class Form18
    Dim mouse_move As System.Drawing.Point

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

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Form18_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        Dim setup = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Username", Nothing)
        Dim admin = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition\AdminControl", "AdminName", Nothing)
        If admin <> "" Then
            LinkLabel5.Text = "Edit Admin Settings"
            Label26.Text = "This Device is Managed By: " & admin
        End If
        Label13.Text = setup
        Dim pic = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "PFP", Nothing)
        If pic = "1" Then
            pb.Image = My.Resources._1
        End If
        If pic = "2" Then
            pb.Image = My.Resources._2
        End If
        If pic = "3" Then
            pb.Image = My.Resources._3
        End If
        If pic = "4" Then
            pb.Image = My.Resources._4
        End If
        Label37.Text = "Physical MAC Address: " & getMacAddress()
        Label35.Text = "Link-local IPv6 Address: " & Dns.GetHostEntry(Dns.GetHostName).AddressList(0).ToString()
        GetIPAddress()
        Label36.Text = "Status: " & Form8.Label5.Text
    End Sub
    Private Sub GetIPAddress()
        Dim strHostName As String
        Dim strIPAddress As String
        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Label38.Text = "My IPv4 Address: " & strIPAddress
    End Sub
    Function getMacAddress()
        Dim nics() As NetworkInterface = _
              NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim admin = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition\AdminControl", "Settings", Nothing)
        If admin = "no" Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.warning
        Else
            TabControl1.SelectTab(2)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TabControl1.SelectTab(3)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim admin = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition\AdminControl", "AccountImage", Nothing)
        Dim admin2 = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition\AdminControl", "Wallpaper", Nothing)
        If admin = "no" Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.warning
        Else
            TabControl1.SelectTab(4)
        End If
        If admin2 = "no" Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.warning
        Else
            TabControl1.SelectTab(4)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TabControl1.SelectTab(5)
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Panel9.Hide()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Panel9.Hide()
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "Username", TextBox1.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "Password", TextBox2.Text)
        Form4.Show()
        Form4.Label1.Text = "Account details updated sucessfully."
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim admin = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition\AdminControl", "Password", Nothing)
        If admin = "no" Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.warning
        Else
            Form19.Show()
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Dim admin = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition\AdminControl", "AdminIsOn", Nothing)
        If admin = "yes" Then
            Form20.Show()
        Else
            TabControl1.SelectTab(6)
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If MsgBox("Are you sure you want to turn on administrator management?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
            "AdminIsOn", "yes")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
           "AdminName", TextBox3.Text)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
           "AdminPass", TextBox4.Text)
            'save the set restrictions
            If webapp.Checked = False Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
               "WebApps", "no")
            End If
            If wallpaper.Checked = False Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
               "Wallpaper", "no")
            End If
            If sysrecov.Checked = False Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
               "Recovery", "no")
            End If
            If actimage.Checked = False Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
               "AccountImage", "no")
            End If
            If paswrd.Checked = False Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
               "Password", "no")
            End If
            If syssettings.Checked = False Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
               "Settings", "no")
            End If
            If browserset.Checked = False Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
               "BrowserSettings", "no")
            End If
            If CheckBox1.Checked = False Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
               "TaskMgr", "no")
            End If
            Form4.Show()
            Form4.Label1.Text = "Set. Please reboot to apply changes."
        Else
            Form4.Show()
            Form4.Label1.Text = "Operation cancelled."
        End If
    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim admin = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition\AdminControl", "AccountImage", Nothing)
        If admin = "no" Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.warning
        Else
            TabControl1.SelectTab(4)
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
          "AdminName", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
          "AdminIsOn", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
             "WebApps", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
               "Wallpaper", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
              "Recovery", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
              "AccountImage", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
              "Passwird", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
               "Settings", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
               "BrowserSettings", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\AdminControl",
               "TaskMgr", "")
        Form4.Show()
        Form4.Label1.Text = "Set. Reboot to apply changes."
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            Process.Start("Z:\")
        Catch ex As Exception
            Form4.Show()
            Form4.Label1.Text = "No network drive was found."
        End Try
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Form16.Show()
        Form16.webbr.Navigate("https://olivewebsoftware.github.io/idkbro/credits.html")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form16.webbr.DocumentText = My.Resources.credits
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "ui", "")
        Form8.Close()
        Form8.Show()
    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "ui", "light")
        Form8.Close()
        Form8.Show()
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Form4.Show()
        Form4.Label1.Text = My.Resources.build
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
      "PFP", "1")
        Form4.Show()
        Form4.Label1.Text = "Set."
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "PFP", "2")
        Form4.Show()
        Form4.Label1.Text = "Set."
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "PFP", "3")
        Form4.Show()
        Form4.Label1.Text = "Set."
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "PFP", "4")
        Form4.Show()
        Form4.Label1.Text = "Set."
    End Sub
End Class