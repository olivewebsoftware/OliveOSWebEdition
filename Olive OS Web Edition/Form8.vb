Public Class Form8
    Dim rp As Integer = 0
    Dim sh As Integer = 0
    Dim bt As Integer = 0
    Dim p As Integer = 0
    Dim u As Integer = 0
    Dim md As Integer = 0
    Dim xy As String = ""
    Private f As String
    Dim m As Integer = 0
    Private g As String
    Private br As String
    Dim z As Integer = 0
    Dim xysave As String = ""
    Dim time As Integer = 0
    Dim open As String = ""
    Private lk As String
    Dim l As Integer = 0
    Dim time2 As String = ""
    Private LastMoveTime As DateTime
    Private MouseTimeoutMilliseconds As Integer = 500
    Dim CuRWidth As Integer = 1600
    Dim CuRHeight As Integer = 900

    Private Sub Form8_ChangeUICues(sender As Object, e As System.Windows.Forms.UICuesEventArgs) Handles Me.ChangeUICues

    End Sub

    Private Sub Form8_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        Timer8.Start()
        Timer7.Start()
        Timer11.Start()
        Timer9.Start()
        Timer2.Start()
        Timer3.Start()
        web.Navigate("about:blank")
        web.Document.OpenNew(False)
        web.Document.Write(My.Resources.landing)
        web.Refresh()
        Timer4.Start()
        wb2.DocumentText = My.Resources.landing
        wb3.DocumentText = My.Resources.landing
        web.DocumentText = My.Resources.landing
        wb4.DocumentText = My.Resources.landing
        wb5.DocumentText = My.Resources.landing
        background()
        Dim setup = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Wallpaper", Nothing)
        Dim pack = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "PackEnabled", Nothing)
        Dim ui = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "ui", Nothing)
        Dim secure = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\Login", "SetupState", Nothing)
        If secure = "" Then
            securityQ()
        End If
        Try
            If setup = "def" Then
                Me.BackgroundImage = My.Resources.def
            End If
            If setup = "rockwater" Then
                Me.BackgroundImage = My.Resources.rockwater
            End If
            If setup = "cliff" Then
                Me.BackgroundImage = My.Resources.cliff
            End If
            If setup = "def2" Then
                Me.BackgroundImage = My.Resources.webdefault
            End If
            If setup = "game" Then
                Me.BackgroundImage = My.Resources.gameon
            End If
            If pack = "yes" Then
                Try
                    Me.BackgroundImage = Image.FromFile(setup)
                Catch ex As Exception
                    NoTheme()
                    Me.BackColor = Color.Black
                End Try
            End If
        Catch ex As Exception
            Form4.Show()
            Form4.Label1.Text = "We can't load your wallpaper."
        End Try

        Panel1.BackColor = Color.FromArgb(190, 0, 0, 0)
        Panel3.BackColor = Color.FromArgb(190, 0, 0, 0)
        Panel4.BackColor = Color.FromArgb(190, 0, 0, 0)
        Panel2.BackColor = Color.FromArgb(190, 128, 128, 128)
        Panel5.BackColor = Color.FromArgb(190, 0, 0, 0)
        Panel9.BackColor = Color.FromArgb(190, 0, 0, 0)
        sign.BackColor = Color.FromArgb(190, 0, 0, 0)
        n1.BackColor = Color.FromArgb(190, 0, 0, 0)
        n2.BackColor = Color.FromArgb(190, 0, 0, 0)
        n3.BackColor = Color.FromArgb(190, 0, 0, 0)
        n4.BackColor = Color.FromArgb(190, 0, 0, 0)
        If ui = "light" Then
            'label 6-14
            Label6.ForeColor = Color.Black
            Label7.ForeColor = Color.Black
            Label8.ForeColor = Color.Black
            Label9.ForeColor = Color.Black
            bat.ForeColor = Color.Black
            Label10.ForeColor = Color.Black
            Label11.ForeColor = Color.Black
            Label12.ForeColor = Color.Black
            Label13.ForeColor = Color.Black
            Label14.ForeColor = Color.Black
            Label15.ForeColor = Color.Black
            Panel1.BackColor = Color.FromArgb(190, 255, 255, 255)
            Panel3.BackColor = Color.FromArgb(190, 255, 255, 255)
            Panel4.BackColor = Color.FromArgb(190, 255, 255, 255)
            Panel9.BackColor = Color.FromArgb(190, 255, 255, 255)
            sign.BackColor = Color.FromArgb(190, 255, 255, 255)
            Panel5.BackColor = Color.FromArgb(190, 255, 255, 255)
            notif.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Label10.ForeColor = Color.Black
            n1.BackColor = Color.FromArgb(190, 255, 255, 255)
            n2.BackColor = Color.FromArgb(190, 255, 255, 255)
            n3.BackColor = Color.FromArgb(190, 255, 255, 255)
            n4.BackColor = Color.FromArgb(190, 255, 255, 255)
            n1.ForeColor = Color.FromArgb(190, 255, 255, 255)
            n2.ForeColor = Color.FromArgb(190, 255, 255, 255)
            n3.ForeColor = Color.FromArgb(190, 255, 255, 255)
            n4.ForeColor = Color.FromArgb(190, 255, 255, 255)
            Label2.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
            LinkLabel1.LinkColor = Color.Black
        End If
        loadApps()
        Timer5.Start()
    End Sub


    Private Sub loadApps()
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
        Dim img1 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "Img1", Nothing)
        Dim img2 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "Img2", Nothing)
        Dim img3 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "Img3", Nothing)
        Dim img4 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "Img4", Nothing)
        Dim img5 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "Img5", Nothing)
        Dim q As String = ""
        Dim w As String = ""
        Dim r As String = ""
        Dim t As String = ""
        Dim y As String = ""
        q = img1
        w = img2
        r = img3
        t = img4
        y = img5
        If web1 <> "" Then
            b1.Show()
            l1.Show()
            l1.Text = web1
        End If
        If web2 <> "" Then
            b2.Show()
            l2.Show()
            l2.Text = web2
        End If
        If web3 <> "" Then
            b3.Show()
            l3.Show()
            l3.Text = web3
        End If
        If web4 <> "" Then
            b4.Show()
            l4.Show()
            l4.Text = web4
        End If
        If web5 <> "" Then
            b5.Show()
            l5.Show()
            l5.Text = web5
        End If
        If img1 = "" Then
            'nothing
        Else
            b1.Image = Image.FromFile(q)
        End If
        If img2 = "" Then
            'nothing
        Else
            b2.Image = Image.FromFile(w)
        End If
        If img3 = "" Then
            'nothing
        Else
            b3.Image = Image.FromFile(r)
        End If
        If img4 = "" Then
            'nothing
        Else
            b4.Image = Image.FromFile(t)
        End If
        If img5 = "" Then
            'nothing
        Else
            b5.Image = Image.FromFile(y)
        End If
        Dim P1POSX = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "P1POS-X", Nothing)
        Dim P1POSY = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "P1POS-Y", Nothing)
        Dim P1POSX2 = My.Computer.Registry.GetValue(
    "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "P2POS-X", Nothing)
        Dim P1POSY2 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "P2POS-Y", Nothing)
        Dim P1POSX3 = My.Computer.Registry.GetValue(
    "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "P3POS-X", Nothing)
        Dim P1POSY3 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "P3POS-Y", Nothing)
        Dim P1POSX4 = My.Computer.Registry.GetValue(
    "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "P4POS-X", Nothing)
        Dim P1POSY4 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "P4POS-Y", Nothing)
        Dim P1POS5 = My.Computer.Registry.GetValue(
    "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "P5POS-X", Nothing)
        Dim P1POSY5 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "P5POS-Y", Nothing)
        p1.Location = New Point(P1POSX, P1POSY)
        p2.Location = New Point(P1POSX2, P1POSY2)
        p3.Location = New Point(P1POSX3, P1POSY3)
        p4.Location = New Point(P1POSX4, P1POSY4)
        p5.Location = New Point(P1POS5, P1POSY5)
        'load shortcuts
        Dim SP1POSX = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "SP1POS-X", Nothing)
        Dim SP1POSY = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "SP1POS-Y", Nothing)
        Dim SP1POSX2 = My.Computer.Registry.GetValue(
    "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "SP2POS-X", Nothing)
        Dim SP1POSY2 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "SP2POS-Y", Nothing)
        Dim SP1POSX3 = My.Computer.Registry.GetValue(
    "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "SP3POS-X", Nothing)
        Dim SP1POSY3 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "SP3POS-Y", Nothing)
        Dim SP1POSX4 = My.Computer.Registry.GetValue(
    "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "SP4POS-X", Nothing)
        Dim SP1POSY4 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "SP4POS-Y", Nothing)
        Dim SP1POS5 = My.Computer.Registry.GetValue(
    "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "SP5POS-X", Nothing)
        Dim SP1POSY5 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "SP5POS-Y", Nothing)
        sp1.Location = New Point(SP1POSX, SP1POSY)
        sp2.Location = New Point(SP1POSX2, SP1POSY2)
        sp3.Location = New Point(SP1POSX3, SP1POSY3)
        sp4.Location = New Point(SP1POSX4, SP1POSY4)
        sp5.Location = New Point(SP1POS5, SP1POSY5)
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
        If n1 <> "" Then
            sp1.Show()
            sl1.Show()
            s1.Show()
            sl1.Text = n1
        End If
        If n2 <> "" Then
            sp2.Show()
            sl2.Show()
            s2.Show()
            sl2.Text = n2
        End If
        If n3 <> "" Then
            sp3.Show()
            sl3.Show()
            s3.Show()
            sl3.Text = n3
        End If
        If n4 <> "" Then
            sp4.Show()
            sl4.Show()
            s4.Show()
            sl4.Text = n4
        End If
        If n5 <> "" Then
            sp5.Show()
            sl5.Show()
            s5.Show()
            sl5.Text = n5
        End If
    End Sub
    Private Sub NoTheme()
        If sh = 0 Then
            n1.Show()
            Label6.Text = "Wallpaper Error"
            Label7.Text = "No file was found."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 1 Then
            n2.Show()
            Label9.Text = "Wallpaper Error"
            Label8.Text = "No file was found."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 2 Then
            n3.Show()
            Label12.Text = "Wallpaper Error"
            Label11.Text = "No file was found."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 3 Then
            n4.Show()
            Label14.Text = "Wallpaper Error"
            Label13.Text = "No file was found."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
    End Sub
    Private Sub updates()
        If sh = 0 Then
            n1.Show()
            Label6.Text = "Updates are Ready"
            Label7.Text = "Updates are ready to be installed."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 1 Then
            n2.Show()
            Label9.Text = "Updates are Ready"
            Label8.Text = "Updates are ready to be installed."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 2 Then
            n3.Show()
            Label12.Text = "Updates are Ready"
            Label11.Text = "Updates are ready to be installed."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 3 Then
            n4.Show()
            Label14.Text = "Updates are Ready"
            Label13.Text = "Updates are ready to be installed."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
    End Sub
    Private Sub securityQ()
        If sh = 0 Then
            n1.Show()
            Label6.Text = "Don't get locked out!"
            Label7.Text = "Setup security questions in settings."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 1 Then
            n2.Show()
            Label9.Text = "Don't get locked out!"
            Label8.Text = "A new usb device was detected."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 2 Then
            n3.Show()
            Label12.Text = "Don't get locked out!"
            Label11.Text = "Setup security questions in settings."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 3 Then
            n4.Show()
            Label14.Text = "Don't get locked out!"
            Label13.Text = "Setup security questions in settings."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
    End Sub
    Private Sub background()
        Dim a1 = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "site1", Nothing)
        Dim a2 = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "site2", Nothing)
        Dim a3 = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "site3", Nothing)
        Dim a4 = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "site4", Nothing)
        Dim a5 = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "site5", Nothing)
        If a1 <> "" Then
            web.Navigate(a1)
            Exit Sub
        End If
        If a2 <> "" Then
            wb2.Navigate(a2)
            Exit Sub
        End If
        If a3 <> "" Then
            wb3.Navigate(a3)
        End If
        If a4 <> "" Then
            wb4.Navigate(a4)
        End If
        If a5 <> "" Then
            wb5.Navigate(a5)
        End If
    End Sub

    Private Sub Panel2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseClick
        Form9.Show()
    End Sub
    Private Sub usbHelper()
        If sh = 0 Then
            n1.Show()
            Label6.Text = "New USB Device"
            Label7.Text = "A new USB device was detected."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 1 Then
            n2.Show()
            Label9.Text = "New USB Device"
            Label8.Text = "A new usb device was detected."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 2 Then
            n3.Show()
            Label12.Text = "New USB Device"
            Label11.Text = "A new USB device was detected."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 3 Then
            n4.Show()
            Label14.Text = "New USB Device"
            Label13.Text = "A new USB device was detected."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
    End Sub

    Private Sub Panel2_PaddingChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.PaddingChanged

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Form9.Show()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form10.Show()
        Panel1.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form16.Show()
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Form13.Show()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Panel3.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Panel3.Hide()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Dim power2 As PowerStatus = SystemInformation.PowerStatus
        Dim percent2 As Single = power2.BatteryLifePercent
        Dim b As String = ""
        b = percent2 * 100
        Label10.Text = percent2 * 100 & "%"
        ProgressBar1.Value = b
        rp += 1
        If rp = 0 Then
            InternetConnection()
            If InternetConnection() = False Then
                Label5.Text = "Not Connected"
                rp = 0
            Else
                Label5.Text = "Connected"
                rp = 0
            End If
        End If
        If rp = 18 Then
            If InternetConnection() = False Then
                Label5.Text = "Not Connected"
                rp = 0
            Else
                Label5.Text = "Connected"
                rp = 0
            End If
        End If
        If power2.PowerLineStatus = PowerLineStatus.Online Then
            bat.Text = "Charging"
        Else
            bat.Text = "Not Charging"
        End If
        If bt = 0 Then
            showBatt()
        End If
       
    End Sub
    Private Sub showBatt()
        Dim power2 As PowerStatus = SystemInformation.PowerStatus
        Dim percent2 As Single = power2.BatteryLifePercent
        Dim b As String = ""
        b = percent2 * 100
        If bt = 0 Then
            If b < 21 Then
                battCritical()
                Exit Sub
            End If
            If b > 69 Then
                'nothing
            End If
            If b < 69 Then
                If sh = 0 Then
                    n1.Show()
                    Label6.Text = "Battery Low"
                    Label7.Text = "Consider charging your device."
                    Label2.Text = "Battery Low; please charge."
                    PictureBox1.Image = My.Resources.battlow
                    sh += 1
                    My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                    bt = 1
                    Exit Sub
                End If
                If sh = 1 Then
                    n2.Show()
                    Label9.Text = "Battery Low"
                    Label8.Text = "Consider charging your device."
                    Label2.Text = "Battery Low; please charge."
                    PictureBox1.Image = My.Resources.battlow
                    sh += 1
                    My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                    bt = 1
                    Exit Sub
                End If
                If sh = 2 Then
                    n3.Show()
                    Label12.Text = "Battery Low"
                    Label11.Text = "Consider charging your device."
                    Label2.Text = "Battery Low; please charge."
                    PictureBox1.Image = My.Resources.battlow
                    sh += 1
                    My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                    bt = 1
                    Exit Sub
                End If
                If sh = 3 Then
                    n4.Show()
                    Label14.Text = "Battery Low"
                    Label13.Text = "Consider charging your device."
                    Label2.Text = "Battery Low; please charge."
                    PictureBox1.Image = My.Resources.battlow
                    sh += 1
                    My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                    bt = 1
                    Exit Sub
                End If
                bt = 1
            End If
        End If
    End Sub
    Private Sub battCritical()
        Dim power2 As PowerStatus = SystemInformation.PowerStatus
        Dim percent2 As Single = power2.BatteryLifePercent
        Dim b As String = ""
        b = percent2 * 100
        If bt = 0 Then
            If b < 21 Then
                If sh = 0 Then
                    n1.Show()
                    Label6.Text = "Battery Critical"
                    Label7.Text = "Consider charging your device."
                    Label2.Text = "Battery Critical; please charge."
                    PictureBox1.Image = My.Resources.battcritical
                    sh += 1
                    My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                    bt = 1
                    Exit Sub
                End If
                If sh = 1 Then
                    n2.Show()
                    Label9.Text = "Battery Critical"
                    Label8.Text = "Consider charging your device."
                    Label2.Text = "Battery Critical; please charge."
                    PictureBox1.Image = My.Resources.battcritical
                    sh += 1
                    My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                    bt = 1
                    Exit Sub
                End If
                If sh = 2 Then
                    n3.Show()
                    Label12.Text = "Battery Critical"
                    Label11.Text = "Consider charging your device."
                    Label2.Text = "Battery Critical; please charge."
                    PictureBox1.Image = My.Resources.battcritical
                    sh += 1
                    My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                    bt = 1
                    Exit Sub
                End If
                If sh = 3 Then
                    n4.Show()
                    Label14.Text = "Battery Critical"
                    Label13.Text = "Consider charging your device."
                    Label2.Text = "Battery Critical; please charge."
                    PictureBox1.Image = My.Resources.battcritical
                    sh += 1
                    My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                    bt = 1
                    Exit Sub
                End If
                bt = 1
            End If
        End If
    End Sub
    Private Function InternetConnection() As Boolean
        Dim req As System.Net.WebRequest = System.Net.WebRequest.Create("http://www.google.com/")
        Dim resp As System.Net.WebResponse
        Try
            resp = req.GetResponse
            resp.Close()
            req = Nothing
            Return True
        Catch ex As Exception
            req = Nothing
            Return False
        End Try
    End Function

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Panel4.Hide()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Panel4.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim admin = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition\AdminControl", "Settings", Nothing)
        If admin = "no" Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.warning
        Else
            Form18.Show()
            Form18.TabControl1.SelectTab(2)
            Panel4.Hide()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim admin = My.Computer.Registry.GetValue(
 "HKEY_CURRENT_USER\Software\Olive OS Web Edition\AdminControl", "WebApps", Nothing)
        If admin = "no" Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.warning
        Else
            Form21.Show()
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form26.Show()
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Dim user = My.Computer.Registry.GetValue(
 "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Username", Nothing)
        Dim css = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition", "CurrentSetupState", Nothing)
        If user = "" Then
            Otheruser()
            Timer4.Stop()
        End If
        If css = "" Then
            Label16.Text = "1"
            needRepair()
        End If
    End Sub
    Private Sub needRepair()
        If sh = 0 Then
            n1.Show()
            Label6.Text = "Restart to Repair System"
            Label7.Text = "We found errors. Please restart."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Form28.Show()
            Exit Sub
        End If
        If sh = 1 Then
            n2.Show()
            Label9.Text = "Restart to Repair System"
            Label8.Text = "We found errors. Please restart."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Form28.Show()
            Exit Sub
        End If
        If sh = 2 Then
            n3.Show()
            Label12.Text = "Restart to Repair System"
            Label11.Text = "We found errors. Please restart."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Form28.Show()
            Exit Sub
        End If
        If sh = 3 Then
            n4.Show()
            Label14.Text = "Restart to Repair System"
            Label13.Text = "We found errors. Please restart."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Form28.Show()
            Exit Sub
        End If
    End Sub
    Private Sub Otheruser()
        If sh = 0 Then
            n1.Show()
            Label6.Text = "User Account Error"
            Label7.Text = "Please check your sign-in info."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Form28.Show()
            Exit Sub
        End If
        If sh = 1 Then
            n2.Show()
            Label9.Text = "User Account Error"
            Label8.Text = "Please check your sign-in info."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Form28.Show()
            Exit Sub
        End If
        If sh = 2 Then
            n3.Show()
            Label12.Text = "User Account Error"
            Label11.Text = "Please check your sign-in info."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Form28.Show()
            Exit Sub
        End If
        If sh = 3 Then
            n4.Show()
            Label14.Text = "User Account Error"
            Label13.Text = "Please check your sign-in info."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Form28.Show()
            Exit Sub
        End If
    End Sub


    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        Form17.Label7.Text = sh
        Label17.Text = sh
        If n1.Visible Then
            If sh < 1 Then
                sh += 1
            Else
                If sh > 1 Then
                    'nothing
                End If
            End If
        End If
        If n2.Visible Then
            If sh < 2 Then
                sh += 1
            Else
                If sh > 2 Then
                    'nothing
                End If
            End If
        End If
        If n3.Visible Then
            If sh < 3 Then
                sh += 1
            Else
                If sh > 3 Then
                    'nothing
                End If
            End If
        End If
        If n4.Visible Then
            If sh < 4 Then
                sh += 1
            Else
                If sh > 4 Then
                    'nothing
                End If
            End If
        End If
        Dim edit1 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "Edit1", Nothing)
        Dim edit2 = My.Computer.Registry.GetValue(
   "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "Edit2", Nothing)
        Dim edit3 = My.Computer.Registry.GetValue(
   "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "Edit3", Nothing)
        Dim edit4 = My.Computer.Registry.GetValue(
   "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "Edit4", Nothing)
        Dim edit5 = My.Computer.Registry.GetValue(
   "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "Edit5", Nothing)
        notif.Text = "Notifications " & "(" & sh & ")"
        If edit1 = "1" Then
            If p = 10 Then
                Try
                    If u = 10 Then
                        br = web.Document.GetElementById("notif").InnerText
                        If br = "" Then
                            Exit Sub
                        End If
                        f = web.Document.GetElementById("notif_title").InnerText
                        g = web.Document.GetElementById("notif_body").InnerText
                        z = 1
                    Else
                        u += 1
                    End If
                    If z = 1 Then
                        If n1.Visible Then
                            If n2.Visible Then
                                If n3.Visible Then
                                    If n4.Visible Then
                                        'no spots ready
                                    Else
                                        If m = 0 Then
                                            Label14.Text = g
                                            Label13.Text = f
                                            n4.Show()
                                            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                            m = 1
                                        Else
                                            'nothing
                                        End If
                                    End If
                                Else
                                    If m = 0 Then
                                        Label12.Text = g
                                        Label11.Text = f
                                        n3.Show()
                                        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                        m = 1
                                    Else
                                        'nothing
                                    End If
                                End If
                            Else
                                If m = 0 Then
                                    Label9.Text = g
                                    Label8.Text = f
                                    n2.Show()
                                    My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                    m = 1
                                Else
                                    'nothing
                                End If
                            End If
                        Else
                            If m = 0 Then
                                Label7.Text = g
                                Label6.Text = f
                                n1.Show()
                                My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                m = 1
                            Else
                                'nothing
                            End If

                        End If
                    End If
                Catch ex As Exception
                    Form4.Show()
                    Form4.Label1.Text = My.Resources.scripterr
                End Try
            Else
                p += 1
            End If
        End If
        If edit2 = "1" Then
            If p = 10 Then
                Try
                    If u = 10 Then
                        br = wb2.Document.GetElementById("notif").InnerText
                        If br = "" Then
                            Exit Sub
                        End If
                        f = wb2.Document.GetElementById("notif_title").InnerText
                        g = wb2.Document.GetElementById("notif_body").InnerText
                        z = 1
                    Else
                        u += 1
                    End If
                    If z = 1 Then
                        If n1.Visible Then
                            If n2.Visible Then
                                If n3.Visible Then
                                    If n4.Visible Then
                                        'no spots ready
                                    Else
                                        If m = 0 Then
                                            Label14.Text = g
                                            Label13.Text = f
                                            n4.Show()
                                            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                            m = 1
                                        Else
                                            'nothing
                                        End If
                                    End If
                                Else
                                    If m = 0 Then
                                        Label12.Text = g
                                        Label11.Text = f
                                        n3.Show()
                                        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                        m = 1
                                    Else
                                        'nothing
                                    End If
                                End If
                            Else
                                If m = 0 Then
                                    Label9.Text = g
                                    Label8.Text = f
                                    n2.Show()
                                    My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                    m = 1
                                Else
                                    'nothing
                                End If
                            End If
                        Else
                            If m = 0 Then
                                Label7.Text = g
                                Label6.Text = f
                                n1.Show()
                                My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                m = 1
                            Else
                                'nothing
                            End If

                        End If
                    End If
                Catch ex As Exception
                    Form4.Show()
                    Form4.Label1.Text = My.Resources.scripterr
                End Try
            Else
                p += 1
            End If
        End If
        If edit3 = "1" Then
            If p = 10 Then
                Try
                    If u = 10 Then
                        br = wb4.Document.GetElementById("notif").InnerText
                        If br = "" Then
                            Exit Sub
                        End If
                        f = wb4.Document.GetElementById("notif_title").InnerText
                        g = wb4.Document.GetElementById("notif_body").InnerText
                        z = 1
                    Else
                        u += 1
                    End If
                    If z = 1 Then
                        If n1.Visible Then
                            If n2.Visible Then
                                If n3.Visible Then
                                    If n4.Visible Then
                                        'no spots ready
                                    Else
                                        If m = 0 Then
                                            Label14.Text = g
                                            Label13.Text = f
                                            n4.Show()
                                            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                            m = 1
                                        Else
                                            'nothing
                                        End If
                                    End If
                                Else
                                    If m = 0 Then
                                        Label12.Text = g
                                        Label11.Text = f
                                        n3.Show()
                                        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                        m = 1
                                    Else
                                        'nothing
                                    End If
                                End If
                            Else
                                If m = 0 Then
                                    Label9.Text = g
                                    Label8.Text = f
                                    n2.Show()
                                    My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                    m = 1
                                Else
                                    'nothing
                                End If
                            End If
                        Else
                            If m = 0 Then
                                Label7.Text = g
                                Label6.Text = f
                                n1.Show()
                                My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                m = 1
                            Else
                                'nothing
                            End If

                        End If
                    End If
                Catch ex As Exception
                    Form4.Show()
                    Form4.Label1.Text = My.Resources.scripterr
                End Try
            Else
                p += 1
            End If
        End If
        If edit4 = "1" Then
            If p = 10 Then
                Try
                    If u = 10 Then
                        br = wb3.Document.GetElementById("notif").InnerText
                        If br = "" Then
                            Exit Sub
                        End If
                        f = wb3.Document.GetElementById("notif_title").InnerText
                        g = wb3.Document.GetElementById("notif_body").InnerText
                        z = 1
                    Else
                        u += 1
                    End If
                    If z = 1 Then
                        If n1.Visible Then
                            If n2.Visible Then
                                If n3.Visible Then
                                    If n4.Visible Then
                                        'no spots ready
                                    Else
                                        If m = 0 Then
                                            Label14.Text = g
                                            Label13.Text = f
                                            n4.Show()
                                            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                            m = 1
                                        Else
                                            'nothing
                                        End If
                                    End If
                                Else
                                    If m = 0 Then
                                        Label12.Text = g
                                        Label11.Text = f
                                        n3.Show()
                                        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                        m = 1
                                    Else
                                        'nothing
                                    End If
                                End If
                            Else
                                If m = 0 Then
                                    Label9.Text = g
                                    Label8.Text = f
                                    n2.Show()
                                    My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                    m = 1
                                Else
                                    'nothing
                                End If
                            End If
                        Else
                            If m = 0 Then
                                Label7.Text = g
                                Label6.Text = f
                                n1.Show()
                                My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                m = 1
                            Else
                                'nothing
                            End If

                        End If
                    End If
                Catch ex As Exception
                    Form4.Show()
                    Form4.Label1.Text = My.Resources.scripterr
                End Try
            Else
                p += 1
            End If
            If edit5 = "1" Then
                If p = 10 Then
                    Try
                        If u = 10 Then
                            br = wb5.Document.GetElementById("notif").InnerText
                            If br = "" Then
                                Exit Sub
                            End If
                            f = wb5.Document.GetElementById("notif_title").InnerText
                            g = wb5.Document.GetElementById("notif_body").InnerText
                            z = 1
                        Else
                            u += 1
                        End If
                        If z = 1 Then
                            If n1.Visible Then
                                If n2.Visible Then
                                    If n3.Visible Then
                                        If n4.Visible Then
                                            'no spots ready
                                        Else
                                            If m = 0 Then
                                                Label14.Text = g
                                                Label13.Text = f
                                                n4.Show()
                                                My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                                m = 1
                                            Else
                                                'nothing
                                            End If
                                        End If
                                    Else
                                        If m = 0 Then
                                            Label12.Text = g
                                            Label11.Text = f
                                            n3.Show()
                                            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                            m = 1
                                        Else
                                            'nothing
                                        End If
                                    End If
                                Else
                                    If m = 0 Then
                                        Label9.Text = g
                                        Label8.Text = f
                                        n2.Show()
                                        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                        m = 1
                                    Else
                                        'nothing
                                    End If
                                End If
                            Else
                                If m = 0 Then
                                    Label7.Text = g
                                    Label6.Text = f
                                    n1.Show()
                                    My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                    m = 1
                                Else
                                    'nothing
                                End If

                            End If
                        End If
                    Catch ex As Exception
                        Form4.Show()
                        Form4.Label1.Text = My.Resources.scripterr
                    End Try
                Else
                    p += 1
                End If
            End If
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        sh -= 1
        n1.Hide()
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        sh -= 1
        n2.Hide()
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        sh -= 1
        n3.Hide()
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        sh -= 1
        n4.Hide()
    End Sub

    Private Sub Form8_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        sign.Show()
        Timer6.Start()
        u += 1
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        If u = 2 Then
            Me.Close()
            Form7.Show()
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        u = 0
        sign.Hide()
    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        time += 1
        If time = 100 Then
            Form31.Show()
            time = 0
        End If
    End Sub

    Private Sub Form8_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        If LastMoveTime.AddMilliseconds(MouseTimeoutMilliseconds) < Now Then
            Timer7.Start()
        Else
            Timer7.Stop()
            time = 0
        End If
    End Sub

    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
            wb.Refresh()
            If l = 10 Then
            Timer1.Stop()
            Try
                lk = wb.Document.GetElementById("version").InnerText
            Catch ex As Exception
                updateFail()
                Timer8.Stop()
                Exit Sub
            End Try
                Dim ver = My.Computer.Registry.GetValue(
          "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Version", Nothing)
                If lk = ver Then
                    Timer8.Stop()
                Else
                    Try
                        Dim wc As New System.Net.WebClient
                        wc.DownloadFile("https://www.dropbox.com/s/99uixe84khj2qnx/UpdatePackage.exe?dl=1", "C:\Program Files\Olive OS Web Edition\Updates.exe")
                        Label18.Text = "1"
                        notifiU()
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
                         "UpdateQueued", "1")
                    Catch ex As Exception
                        noPri()
                    End Try
                    Timer8.Stop()
                End If
            Else
                l += 1
            End If
    End Sub
    Private Sub notifiU()
        If sh = 0 Then
            n1.Show()
            Label6.Text = "Software Update"
            Label7.Text = My.Resources.restart
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 1 Then
            n2.Show()
            Label9.Text = "Software Update"
            Label8.Text = My.Resources.restart
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 2 Then
            n3.Show()
            Label12.Text = "Software Update"
            Label11.Text = My.Resources.restart
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 3 Then
            n4.Show()
            Label14.Text = "Software Update"
            Label13.Text = My.Resources.restart
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
    End Sub
    Private Sub updateFail()
        If sh = 0 Then
            n1.Show()
            Label6.Text = "Update Failure"
            Label7.Text = "We can't connect to the update servers."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 1 Then
            n2.Show()
            Label9.Text = "Update Failure"
            Label8.Text = "We can't connect to the update servers."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 2 Then
            n3.Show()
            Label12.Text = "Update Failure"
            Label11.Text = "We can't connect to the update servers."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 3 Then
            n4.Show()
            Label14.Text = "Update Failure"
            Label13.Text = "We can't connect to the update servers."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
    End Sub
    Private Sub noPri()
        If sh = 0 Then
            n1.Show()
            Label6.Text = "Download Error"
            Label7.Text = My.Resources.why
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 1 Then
            n2.Show()
            Label9.Text = "Download Error"
            Label8.Text = My.Resources.why
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 2 Then
            n3.Show()
            Label12.Text = "Download Error"
            Label11.Text = My.Resources.why
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 3 Then
            n4.Show()
            Label14.Text = "Download Error"
            Label13.Text = My.Resources.why
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
    End Sub

    Private Sub Timer9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer9.Tick
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs)

    End Sub

    Private Sub web_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles web.DocumentCompleted

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Form40.Show()
    End Sub

    Private Sub p1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p1.MouseClick
      
    End Sub

    Private Sub p1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p1.MouseDown
        md = 1
    End Sub

    Private Sub p1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p1.MouseMove
        If md = 1 Then
            Dim xx As Integer = MousePosition.X
            Dim yy As Integer = MousePosition.Y
            Threading.Thread.Sleep(400)
            p1.Location = New Point(xx, yy)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
           "P1POS-X", p1.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "P1POS-Y", p1.Location.Y)
        End If
    End Sub

    Private Sub p1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p1.MouseUp
        md = 0
    End Sub
    Private Sub p2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p2.MouseDown
        md = 1
    End Sub

    Private Sub p2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p2.MouseMove
        If md = 1 Then
            Dim xx As Integer = MousePosition.X
            Dim yy As Integer = MousePosition.Y
            Threading.Thread.Sleep(400)
            p2.Location = New Point(xx, yy)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
         "P2POS-X", p2.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "P2POS-Y", p2.Location.Y)
        End If
    End Sub

    Private Sub p2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p2.MouseUp
        md = 0
    End Sub
    Private Sub p3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p3.MouseDown
        md = 1
    End Sub

    Private Sub p3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p3.MouseMove
        If md = 1 Then
            Dim xx As Integer = MousePosition.X
            Dim yy As Integer = MousePosition.Y
            Threading.Thread.Sleep(400)
            p3.Location = New Point(xx, yy)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
         "P3POS-X", p3.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "P3POS-Y", p3.Location.Y)
        End If
    End Sub

    Private Sub p3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p3.MouseUp
        md = 0
    End Sub
    Private Sub p4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p4.MouseDown
        md = 1
    End Sub

    Private Sub p4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p4.MouseMove
        If md = 1 Then
            Dim xx As Integer = MousePosition.X
            Dim yy As Integer = MousePosition.Y
            Threading.Thread.Sleep(400)
            p4.Location = New Point(xx, yy)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
         "P4POS-X", p4.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "P4POS-Y", p4.Location.Y)
        End If
    End Sub

    Private Sub p4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p4.MouseUp
        md = 0
    End Sub
    Private Sub p5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p5.MouseDown
        md = 1
    End Sub

    Private Sub p5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p5.MouseMove
        If md = 1 Then
            Dim xx As Integer = MousePosition.X
            Dim yy As Integer = MousePosition.Y
            Threading.Thread.Sleep(400)
            p5.Location = New Point(xx, yy)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
         "P5POS-X", p5.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "P5POS-Y", p5.Location.Y)
        End If
    End Sub

    Private Sub p5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles p5.MouseUp
        md = 0
    End Sub

    Private Sub p1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles p1.Paint

    End Sub

    Private Sub p2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles p2.Paint

    End Sub

    Private Sub b1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click
        Dim web1 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "MalwarePresent1", Nothing)
        If web1 = 1 Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.oof
            Exit Sub
        End If
        Form23.Show()
        Form23.label.Text = "1"
    End Sub

    Private Sub b2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b2.Click
        Dim web1 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "MalwarePresent1", Nothing)
        If web1 = 1 Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.oof
            Exit Sub
        End If
        Form23.Show()
        Form23.label.Text = "2"
    End Sub

    Private Sub b3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b3.Click
        Dim web1 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "MalwarePresent1", Nothing)
        If web1 = 1 Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.oof
            Exit Sub
        End If
        Form23.Show()
        Form23.label.Text = "3"
    End Sub

    Private Sub b4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b4.Click
        Dim web1 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "MalwarePresent1", Nothing)
        If web1 = 1 Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.oof
            Exit Sub
        End If
        Form23.Show()
        Form23.label.Text = "4"
    End Sub

    Private Sub b5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b5.Click
        Dim web1 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "MalwarePresent1", Nothing)
        If web1 = 1 Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.oof
            Exit Sub
        End If
        Form23.Show()
        Form23.label.Text = "5"
    End Sub

    Private Sub ContextMenuStrip2_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening
        Form22.Show()
        Form22.Label4.Text = "1"
    End Sub

    Private Sub ContextMenuStrip3_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip3.Opening
        Form22.Show()
        Form22.Label4.Text = "2"
    End Sub

    Private Sub ContextMenuStrip4_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip4.Opening
        Form22.Show()
        Form22.Label4.Text = "3"
    End Sub

    Private Sub ContextMenuStrip5_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip5.Opening
        Form22.Show()
        Form22.Label4.Text = "4"
    End Sub

    Private Sub ContextMenuStrip6_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip6.Opening
        Form22.Show()
        Form22.Label4.Text = "5"
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
       
    End Sub

    Private Sub Panel6_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel6.MouseClick
        Form16.Show()
    End Sub

    Private Sub Panel7_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel7.MouseClick
        Form26.Show()
    End Sub

    Private Sub Panel7_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Panel8_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel8.MouseClick
        Dim admin = My.Computer.Registry.GetValue(
 "HKEY_CURRENT_USER\Software\Olive OS Web Edition\AdminControl", "WebApps", Nothing)
        If admin = "no" Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.warning
        Else
            Form21.Show()
        End If
    End Sub

    Private Sub Panel8_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub ContextMenuStrip7_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip7.Opening
        Form22.Show()
        Form22.Label4.Text = "s1"
    End Sub

    Private Sub ContextMenuStrip8_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip8.Opening
        Form22.Show()
        Form22.Label4.Text = "s2"
    End Sub

    Private Sub ContextMenuStrip9_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip9.Opening
        Form22.Show()
        Form22.Label4.Text = "s3"
    End Sub

    Private Sub ContextMenuStrip10_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip10.Opening
        Form22.Show()
        Form22.Label4.Text = "s4"
    End Sub

    Private Sub ContextMenuStrip11_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip11.Opening
        Form22.Show()
        Form22.Label4.Text = "s5"
    End Sub

    Private Sub sp1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sp1.MouseDown
        md = 1
    End Sub

    Private Sub sp1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sp1.MouseMove
        If md = 1 Then
            Dim xx As Integer = MousePosition.X
            Dim yy As Integer = MousePosition.Y
            Threading.Thread.Sleep(400)
            sp1.Location = New Point(xx, yy)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
         "SP1POS-X", sp1.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "SP1POS-Y", sp1.Location.Y)
        End If
    End Sub

    Private Sub sp1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sp1.MouseUp
        md = 0
    End Sub

    Private Sub sp1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles sp1.Paint

    End Sub

    Private Sub p3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles p3.Paint

    End Sub

    Private Sub sp2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sp2.MouseDown
        md = 1
    End Sub

    Private Sub sp2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sp2.MouseMove
        If md = 1 Then
            Dim xx As Integer = MousePosition.X
            Dim yy As Integer = MousePosition.Y
            Threading.Thread.Sleep(400)
            sp2.Location = New Point(xx, yy)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
         "SP2POS-X", sp2.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "SP2POS-Y", sp2.Location.Y)
        End If
    End Sub

    Private Sub sp2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sp2.MouseUp
        md = 0
    End Sub

    Private Sub sp2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles sp2.Paint

    End Sub

    Private Sub sp3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sp3.MouseDown
        md = 1
    End Sub

    Private Sub sp3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sp3.MouseMove
        If md = 1 Then
            Dim xx As Integer = MousePosition.X
            Dim yy As Integer = MousePosition.Y
            Threading.Thread.Sleep(400)
            sp3.Location = New Point(xx, yy)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
         "SP3POS-X", sp3.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "SP3POS-Y", sp3.Location.Y)
        End If
    End Sub

    Private Sub sp3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sp3.MouseUp
        md = 0
    End Sub

    Private Sub sp3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles sp3.Paint

    End Sub

    Private Sub sp4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sp4.MouseDown
        md = 1
    End Sub

    Private Sub sp4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sp4.MouseMove
        If md = 1 Then
            Dim xx As Integer = MousePosition.X
            Dim yy As Integer = MousePosition.Y
            Threading.Thread.Sleep(400)
            sp4.Location = New Point(xx, yy)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
         "SP4POS-X", sp4.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "SP4POS-Y", sp4.Location.Y)
        End If
    End Sub

    Private Sub sp4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sp4.MouseUp
        md = 0
    End Sub

    Private Sub sp4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles sp4.Paint

    End Sub

    Private Sub sp5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sp5.MouseDown
        md = 1
    End Sub

    Private Sub sp5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sp5.MouseMove
        If md = 1 Then
            Dim xx As Integer = MousePosition.X
            Dim yy As Integer = MousePosition.Y
            Threading.Thread.Sleep(400)
            sp5.Location = New Point(xx, yy)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
         "SP5POS-X", sp5.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "SP5POS-Y", sp5.Location.Y)
        End If
    End Sub

    Private Sub sp5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sp5.MouseUp
        md = 0
    End Sub

    Private Sub sp5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles sp5.Paint

    End Sub

    Private Sub s1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s1.Click
        Form22.Show()
        Form22.Label4.Text = "s1"
        If Form22.Label4.Text = "s1" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s2" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s3" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s4" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s5" Then
            ProcessLink()
        End If
    End Sub
    Private Sub ProcessLink()
        If Form22.Label4.Text = "s1" Then
            Dim l1 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "ShortcutLink1", Nothing)
            open = l1
            Secured_OpenApp()
        End If
        If Form22.Label4.Text = "s2" Then
            Dim l2 = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "ShortcutLink2", Nothing)
            open = l2
            Secured_OpenApp()
        End If
        If Form22.Label4.Text = "s3" Then
            Dim l3 = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "ShortcutLink3", Nothing)
            open = l3
            Secured_OpenApp()
        End If
        If Form22.Label4.Text = "s4" Then
            Dim l4 = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "ShortcutLink4", Nothing)
            open = l4
            Secured_OpenApp()
        End If
        If Form22.Label4.Text = "s5" Then
            Dim l5 = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "ShortcutLink5", Nothing)
            open = l5
            Secured_OpenApp()
        End If
        Form22.Close()
    End Sub
    Private Sub Secured_OpenApp()
        If open = "web" Then
            Form16.Show()
        End If
        If open = "file" Then
            Form26.Show()
        End If
        If open = "calc" Then
            Form5.Show()
        End If
        If open = "textedit" Then
            Form3.Show()
        End If
        If open = "photo" Then
            Form11.Show()

        End If
        If open = "security" Then
            Form33.Show()
        End If
        If open = "music" Then
            Form14.Show()
        End If
        If open = "settings" Then
            Form18.Show()

        End If
        If open = "webapp" Then
            Form21.Show()

        End If
        If open = "help" Then
            Form45.Show()

        End If
    End Sub

    Private Sub s2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s2.Click
        Form22.Show()
        Form22.Label4.Text = "s2"
        If Form22.Label4.Text = "s1" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s2" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s3" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s4" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s5" Then
            ProcessLink()
        End If
    End Sub

    Private Sub s3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s3.Click
        Form22.Show()
        Form22.Label4.Text = "s3"
        If Form22.Label4.Text = "s1" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s2" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s3" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s4" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s5" Then
            ProcessLink()
        End If
    End Sub

    Private Sub s4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s4.Click
        Form22.Show()
        Form22.Label4.Text = "s4"
        If Form22.Label4.Text = "s1" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s2" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s3" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s4" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s5" Then
            ProcessLink()
        End If
    End Sub

    Private Sub s5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s5.Click
        Form22.Show()
        Form22.Label4.Text = "s5"
        If Form22.Label4.Text = "s1" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s2" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s3" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s4" Then
            ProcessLink()
        End If
        If Form22.Label4.Text = "s5" Then
            ProcessLink()
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Panel9.Show()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Panel9.Hide()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            PictureBox3.BackgroundImage = My.Resources.donoton
            Form48.Show()
            Form48.Label1.Text = "Do not disturb has been turned on."
            Panel9.Hide()
            Timer10.Start()

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            PictureBox3.BackgroundImage = My.Resources.donot
            Panel9.Hide()
            Timer5.Start()
            Timer10.Stop()
            Form48.Show()
            Form48.Label1.Text = "Do not disturb has been turned off."
        End If
    End Sub

    Private Sub Timer10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer10.Tick
        My.Computer.Audio.Play(My.Resources.silence, AudioPlayMode.BackgroundLoop)
        Timer5.Stop()
        notif.Text = "Notifications: Do Not Disturb"
    End Sub

    Private Sub ContextMenuStrip12_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip12.Opening
        Form49.Show()
    End Sub

    Private Sub Timer11_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer11.Tick
        Label1.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub Form8_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        
    End Sub

    Private Sub Panel6_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel6.Paint

    End Sub
End Class