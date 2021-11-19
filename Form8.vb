Public Class Form8
    Dim rp As Integer = 0
    Dim sh As Integer = 0
    Dim bt As Integer = 0
    Dim p As Integer = 0
    Dim u As Integer = 0
    Dim xy As String = ""
    Private f As String
    Dim m As Integer = 0
    Private g As String
    Private br As String
    Dim z As Integer = 0
    Dim xysave As String = ""
    Dim time As Integer = 0
    Private lk As String
    Dim l As Integer = 0
    Dim time2 As String = ""
    Private LastMoveTime As DateTime
    Private MouseTimeoutMilliseconds As Integer = 500
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        Timer8.Start()
        Timer7.Start()
        Timer1.Start()
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
                    Form4.Show()
                    Form4.Label1.Text = "We can't load your wallpaper."
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
        Timer5.Start()
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
#Region "USB EVENT"
    Private WM_DEVICECHANGE As Integer = &H219

    Public Enum WM_DEVICECHANGE_WPPARAMS As Integer
        DBT_CONFIGCHANGECANCELED = &H19
        DBT_CONFIGCHANGED = &H18
        DBT_CUSTOMEVENT = &H8006
        DBT_DEVICEARRIVAL = &H8000
        DBT_DEVICEQUERYREMOVE = &H8001
        DBT_DEVICEQUERYREMOVEFAILED = &H8002
        DBT_DEVICEREMOVECOMPLETE = &H8004
        DBT_DEVICEREMOVEPENDING = &H8003
        DBT_DEVICETYPESPECIFIC = &H8005
        DBT_DEVNODES_CHANGED = &H7
        DBT_QUERYCHANGECONFIG = &H17
        DBT_USERDEFINED = &HFFFF
    End Enum

    Private Structure DEV_BROADCAST_VOLUME
        Public dbcv_size As Int32
        Public dbcv_devicetype As Int32
        Public dbcv_reserved As Int32
        Public dbcv_unitmask As Int32
        Public dbcv_flags As Int16
    End Structure

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        Try
            If m.Msg = WM_DEVICECHANGE Then
                Dim Volume As DEV_BROADCAST_VOLUME
                Volume = DirectCast(Runtime.InteropServices.Marshal.PtrToStructure(m.LParam, GetType(DEV_BROADCAST_VOLUME)), DEV_BROADCAST_VOLUME)

                If Not GetDriveLetterFromMask(Volume.dbcv_unitmask).ToString.Trim = String.Empty Then

                    Dim DriveLetter As String = (GetDriveLetterFromMask(Volume.dbcv_unitmask) & ":\")

                    Select Case m.WParam

                        Case WM_DEVICECHANGE_WPPARAMS.DBT_DEVICEARRIVAL
                            If DriveLetter = "D:\" Then
                                usbHelper()
                            End If
                            If DriveLetter = "E:\" Then
                                
                            End If
                            My.Computer.Audio.Play(My.Resources.usb_insert, AudioPlayMode.Background)
                            '   Code When add USB

                        Case WM_DEVICECHANGE_WPPARAMS.DBT_DEVICEREMOVECOMPLETE
                            My.Computer.Audio.Play(My.Resources.usb_disconnect, AudioPlayMode.Background)

                            '   Code When Remove USB

                    End Select

                End If

            End If

        Catch ex As Exception
        End Try

        MyBase.WndProc(m)

    End Sub

    Private Function GetDriveLetterFromMask(ByRef Unit As Int32) As Char
        For i As Integer = 0 To 25
            If Unit = (2 ^ i) Then
                Return Chr(Asc("A") + i)
            End If
        Next
        Return ""
    End Function

#End Region

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
        Label1.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form10.Show()
        Panel1.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim admin = My.Computer.Registry.GetValue(
 "HKEY_CURRENT_USER\Software\Olive OS Web Edition\AdminControl", "WebApps", Nothing)
        If admin = "no" Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.warning
        Else
            Form21.Show()
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
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
        Try
            wb.Refresh()
            If l = 10 Then
                Timer1.Stop()
                lk = wb.Document.GetElementById("version").InnerText
                Dim ver = My.Computer.Registry.GetValue(
          "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Version", Nothing)
                If lk = ver Then
                    Timer8.Stop()
                Else
                    updates()
                    Timer8.Stop()
                End If
            Else
                l += 1
            End If
        Catch ex As Exception
            updateFail()
            Timer8.Stop()
        End Try
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
End Class