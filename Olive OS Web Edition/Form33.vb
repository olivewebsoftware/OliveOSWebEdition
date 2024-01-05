Public Class Form33
    'Mysophibia is prevented here :D
    Dim mouse_move As System.Drawing.Point
    Dim threats As Integer = 0
    Dim good As Integer = 0
    Dim app1 As Integer = 0
    Dim app2 As Integer = 0
    Dim app3 As Integer = 0
    Dim app4 As Integer = 0
    Dim app5 As Integer = 0
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

    Private Sub Form33_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Dim linker = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppLink1", Nothing)
        Dim linker2 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppLink2", Nothing)
        Dim linker3 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppLink3", Nothing)
        Dim linker4 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppLink4", Nothing)
        Dim linker5 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppLink5", Nothing)
        If ProgressBar1.Value = 100 Then
            If linker = "youareanidiot.cc" Then
                threats += 1
                app1 = 1
                ListBox1.Items.Add("Bad-Webapp:Trojan.JS.Youareanidiot")
            End If
            If linker = "mchelper.com" Then
                threats += 1
                app1 = 1
                ListBox1.Items.Add("Bad-Webapp:PuP.HTML.Mchelper")
            End If
            If linker = "hurr-durr.cc" Then
                threats += 1
                app1 = 1
                ListBox1.Items.Add("Bad-Webapp:Trojan.JS.Hurrdurr")
            End If
            If linker2 = "youareanidiot.cc" Then
                threats += 1
                app2 = 1
                ListBox1.Items.Add("Bad-Webapp:Trojan.JS.Youareanidiot")
            End If
            If linker2 = "mchelper.com" Then
                threats += 1
                app2 = 1
                ListBox1.Items.Add("Bad-Webapp:PuP.HTML.Mchelper")
            End If
            If linker2 = "hurr-durr.cc" Then
                threats += 1
                app2 = 1
                ListBox1.Items.Add("Bad-Webapp:Trojan.JS.Hurrdurr")
            End If
            If linker3 = "youareanidiot.cc" Then
                threats += 1
                app3 = 1
                ListBox1.Items.Add("Bad-Webapp:Trojan.JS.Youareanidiot")
            End If
            If linker3 = "mchelper.com" Then
                threats += 1
                app3 = 1
                ListBox1.Items.Add("Bad-Webapp:PuP.HTML.Mchelper")
            End If
            If linker3 = "hurr-durr.cc" Then
                threats += 1
                app3 = 1
                ListBox1.Items.Add("Bad-Webapp:Trojan.JS.Hurrdurr")
            End If
            If linker4 = "youareanidiot.cc" Then
                threats += 1
                app4 = 1
                ListBox1.Items.Add("Bad-Webapp:Trojan.JS.Youareanidiot")
            End If
            If linker4 = "mchelper.com" Then
                threats += 1
                app4 = 1
                ListBox1.Items.Add("Bad-Webapp:PuP.HTML.Mchelper")
            End If
            If linker4 = "hurr-durr.cc" Then
                threats += 1
                app4 = 1
                ListBox1.Items.Add("Bad-Webapp:Trojan.JS.Hurrdurr")
            End If
            If linker5 = "youareanidiot.cc" Then
                threats += 1
                app5 = 1
                ListBox1.Items.Add("Bad-Webapp:Trojan.JS.Youareanidiot")
            End If
            If linker5 = "mchelper.com" Then
                threats += 1
                app5 = 1
                ListBox1.Items.Add("Bad-Webapp:PuP.HTML.Mchelper")
            End If
            If linker5 = "hurr-durr.cc" Then
                threats += 1
                app5 = 1
                ListBox1.Items.Add("Bad-Webapp:Trojan.JS.Hurrdurr")
            End If
            If threats <> 0 Then
                updates()
                Button5.Enabled = True
                Button6.Enabled = True
                Label5.Text = My.Resources.scan
                PictureBox1.Image = My.Resources.not_protected
                Timer1.Stop()
                present()
            Else
                Label6.Text = "Scan For Malicious Webapps"
                updates2()
                Timer1.Stop()
            End If
        Else
            Label6.Text = "Scanning.. please wait."
        End If
    End Sub
    Private Sub present()
        If app1 = 1 Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
        "MalwarePresent1", "1")
        End If
        If app2 = 1 Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
        "MalwarePresent1", "2")
        End If
        If app3 = 1 Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
        "MalwarePresent1", "3")
        End If
        If app4 = 1 Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
        "MalwarePresent1", "4")
        End If
        If app5 = 5 Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
        "MalwarePresent1", "1")
        End If
    End Sub
    Private Sub updates()
        Dim sh As Integer = 0
        sh = Form17.Label7.Text
        If sh = 0 Then
            Form8.n1.Show()
            Form8.Label6.Text = "Malware Found"
            Form8.Label7.Text = "OliveWeb Security found malware."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 1 Then
            Form8.n2.Show()
            Form8.Label9.Text = "Malware Found"
            Form8.Label8.Text = "OliveWeb Security found malware."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 2 Then
            Form8.n3.Show()
            Form8.Label12.Text = "Malware Found"
            Form8.Label11.Text = "OliveWeb Security found malware."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 3 Then
            Form8.n4.Show()
            Form8.Label14.Text = "Malware Found"
            Form8.Label13.Text = "OliveWeb Security found malware."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
    End Sub
    Private Sub updates2()
        Dim sh As Integer = 0
        sh = Form17.Label7.Text
        If sh = 0 Then
            Form8.n1.Show()
            Form8.Label6.Text = "No Malware was Found"
            Form8.Label7.Text = "OliveWeb Security did not find malware."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 1 Then
            Form8.n2.Show()
            Form8.Label9.Text = "No Malware was Found"
            Form8.Label8.Text = "OliveWeb Security did not find malware."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 2 Then
            Form8.n3.Show()
            Form8.Label12.Text = "No Malware was Found"
            Form8.Label11.Text = "OliveWeb Security did not find malware."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 3 Then
            Form8.n4.Show()
            Form8.Label14.Text = "No Malware was Found"
            Form8.Label13.Text = "OliveWeb Security did not find malware."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TabControl1.SelectTab(3)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If app1 = 1 Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "AppName1", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "AppLink1", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
      "MalwarePresent1", "")
            Form4.Show()
            Form4.Label1.Text = "Removed."
        End If
        If app2 = 1 Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
           "AppName2", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "AppLink2", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
      "MalwarePresent2", "")
            Form4.Show()
            Form4.Label1.Text = "Removed."
        End If
        If app3 = 1 Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
           "AppName3", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "AppLink3", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
      "MalwarePresent3", "")
            Form4.Show()
            Form4.Label1.Text = "Removed."
        End If
        If app4 = 1 Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
           "AppName4", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "AppLink4", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
      "MalwarePresent4", "")
            Form4.Show()
            Form4.Label1.Text = "Removed."
        End If
        If app5 = 1 Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "AppName5", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
            "AppLink5", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
      "MalwarePresent5", "")
            Form4.Show()
            Form4.Label1.Text = "Removed."
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar2.Increment(1)
        Button4.PerformClick()
        Label9.Text = "Running security check..."
        If ProgressBar2.Value = 100 Then
            Dim pwd = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Password", Nothing)
            Dim sec = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Security", Nothing)
            Dim que = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\Login", "SetupState", Nothing)
            If que = "" Then
                ListBox2.Items.Add("Security Suggestion: Add security questions to your account.")
            Else
                good += 1
            End If
            If pwd = "" Then
                ListBox2.Items.Add("Security Suggestion: Add a password to your account.")
            Else
                good += 1
            End If
            If sec = "no" Then
                ListBox2.Items.Add("Security Sugesstion: Turn on browser security.")
            Else
                good += 1
            End If
            If good = 3 Then
                ListBox2.Items.Add("Everything looks good! No need to change anything at the moment.")
            End If
            Label9.Text = "Scan Complete."
            Timer2.Stop()
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Timer2.Start()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form4.Show()
        Form4.Label1.Text = "OliveWeb Security. All right reserved."
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Form4.Show()
        Form4.Label1.Text = "There was an error."
    End Sub
End Class