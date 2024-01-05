Imports System.Collections.ObjectModel
Imports System.Text
Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation


Public Class Form18
    Dim l As Integer = 0
    Private lk As String
    Dim mouse_move As System.Drawing.Point
    Dim sh As Integer = Form8.Label17.Text
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
        getAppName()
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
            pb.Image = My.Resources.use1
        End If
      
        If pic = "3" Then
            pb.Image = My.Resources.use3
        End If
        If pic = "2" Then
            pb.Image = My.Resources.use2
        End If
        Label37.Text = "Physical MAC Address: " & getMacAddress()
        Label35.Text = "Link-local IPv6 Address: " & Dns.GetHostEntry(Dns.GetHostName).AddressList(0).ToString()
        GetIPAddress()
        Label36.Text = "Status: " & Form8.Label5.Text
    End Sub
    Private Sub getAppName()
        Dim web1 = My.Computer.Registry.GetValue(
   "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppName1", Nothing)
        Dim web2 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppName2", Nothing)
        Dim web3 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppName3", Nothing)
        Dim web4 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppName4", Nothing)
        Dim web5 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppName5", Nothing)
        If web1 = "" Then
            'nothing
        Else
            app1.Text = web1
        End If
        If web2 = "" Then
            'nothing
        Else
            app2.Text = web2
        End If
        If web3 = "" Then
            'nothing
        Else
            app3.Text = web3
        End If
        If web4 = "" Then
            'nothing
        Else
            app4.Text = web4
        End If
        If web5 = "" Then
            'nothing
        Else
            app5.Text = web5
        End If
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
        Dim admin = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition\AdminControl", "WebApps", Nothing)
        If admin = "no" Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.warning
        Else
            TabControl1.SelectTab(5)
        End If
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
        Try
            My.Computer.Registry.CurrentUser.DeleteSubKey(
   "SOFTWARE\Olive OS Web Edition\AdminControl")
            Form4.Show()
            Form4.Label1.Text = "Set. Reboot to apply changes."
        Catch ex As Exception
            Form4.Show()
            Form4.Label1.Text = "No specified value exists."
        End Try
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            Process.Start("Z:\")
        Catch ex As Exception
            Form4.Show()
            Form4.Label1.Text = "No network drive mapped."
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

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "PFP", "4")
        Form4.Show()
        Form4.Label1.Text = "Set."
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Select Case MsgBox("Are you sure you want to reset? This cannot be undone.", MsgBoxStyle.YesNo, "Confirm Reset.")
            Case MsgBoxResult.Yes
                Me.Close()
                Form8.Close()
                Form29.Show()
        End Select

    End Sub

    Private Sub LinkLabel9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        Process.Start("mailto://kk.online@mail.com?subject=Feature Request")
    End Sub

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Process.Start("mailto://kk.online@mail.com?subject=Feedback")
    End Sub

    Private Sub LinkLabel10_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        Form16.Show()
        Form16.webbr.Navigate("https://github.com/olivewebsoftware/OliveOSWebEdition")
    End Sub

    Private Sub wallpaper_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wallpaper.CheckedChanged

    End Sub

    Private Sub LinkLabel11_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        Form30.Show()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Me.Close()
        Form8.Close()
        Form7.Close()
        Form36.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If l = 10 Then
            Timer1.Stop()
            Try
                lk = wb.Document.GetElementById("version").InnerText
            Catch ex As Exception
                ListBox1.Items.Add("An internet connection was not detected. Please connect your device to the internet.")
            End Try
            Dim ver = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Version", Nothing)
            If lk = ver Then
                Label46.Text = "You are up to date."
            Else
                Label46.Text = "Updates need to be installed."
                Try
                    ListBox1.Items.Add("Download started...")
                    Dim wc As New System.Net.WebClient
                    wc.DownloadFile("https://www.dropbox.com/s/99uixe84khj2qnx/UpdatePackage.exe?dl=1", "C:\Program Files\Olive OS Web Edition\Updates.exe")
                    ListBox1.Items.Add("Sucessfully able to download files from server.")
                    ListBox1.Items.Add("Restart to finish installing updates.")
                    Form8.Label18.Text = "1"
                    Label46.Text = "Restart pending."
                    notifU()
                Catch ex As Exception
                    Form4.Show()
                    Form4.Label1.Text = "Cannot download. Please start" & vbNewLine & "Olive OS as an Administrator."
                End Try
            End If
        Else
            l += 1
        End If
    End Sub
    Private Sub notifU()
        If sh = 0 Then
            Form8.n1.Show()
            Form8.Label6.Text = "Software Update"
            Form8.Label7.Text = My.Resources.restart
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 1 Then
            Form8.n2.Show()
            Form8.Label9.Text = "Software Update"
            Form8.Label8.Text = My.Resources.restart
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 2 Then
            Form8.n3.Show()
            Form8.Label12.Text = "Software Update"
            Form8.Label11.Text = My.Resources.restart
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 3 Then
            Form8.n4.Show()
            Form8.Label14.Text = "Software Update"
            Form8.Label13.Text = My.Resources.restart
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Timer1.Start()
        Label46.Text = "Checking for updates..."
    End Sub

    Private Sub Panel6_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Form34.Show()
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox2.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
       "Edit4", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
      "Edit4", "")
        End If
    End Sub

    Private Sub LinkLabel12_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        Form21.Show()
    End Sub

    Private Sub Panel7_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Label48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label48.Click

    End Sub

    Private Sub LinkLabel13_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        Form16.Show()
        Me.Close()
        Form16.webbr.Navigate("https://olivewebsoftware.github.io/oliveweb/OliveWeb%20NEON%20Awesome.exe")
        Form16.TopMost = False
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If MsgBox("Are you sure you want to enable the kiosk mode?", MsgBoxStyle.YesNo, "Add kiosk?") = MsgBoxResult.Yes Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
           "KioskName", TextBox5.Text)
            Form4.Show()
            Form4.Label1.Text = "Set. Reboot to apply changes."
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub LinkLabel14_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel14.LinkClicked
        TabControl1.SelectTab(7)
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Me.Close()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "KioskName", "")
        Form4.Show()
        Form4.Label1.Text = "Deleted. Reboot to apply changes."
    End Sub

    Private Sub TabPage8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage8.Click

    End Sub

    Private Sub LinkLabel15_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel15.LinkClicked
        Form40.Show()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Form46.Show()
        Me.Close()
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
    "Refresh", "1")
        Form8.Close()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
       "Edit1", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
      "Edit1", "")
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
       "Edit2", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
      "Edit2", "")
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
       "Edit3", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
      "Edit3", "")
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
       "Edit5", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
      "Edit5", "")
        End If
    End Sub

    Private Sub LinkLabel16_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel16.LinkClicked
        Form10.Show()
    End Sub

    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        Form59.Show()
        Panel11.Hide()
        Me.Close()
    End Sub

    Private Sub LinkLabel18_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel18.LinkClicked
        Form59.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel17_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel17.LinkClicked
        Panel11.Hide()
    End Sub
End Class