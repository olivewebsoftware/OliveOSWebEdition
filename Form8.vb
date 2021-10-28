Public Class Form8
    Dim rp As Integer = 0
    Dim sh As Integer = 0
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        Timer1.Start()
        Timer2.Start()
        Timer4.Start()
        Dim setup = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Wallpaper", Nothing)
        Dim pack = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "PackEnabled", Nothing)
        Dim ui = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "ui", Nothing)
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
            Me.BackgroundImage = Image.FromFile(setup)
        End If
        Panel1.BackColor = Color.FromArgb(190, 0, 0, 0)
        Panel3.BackColor = Color.FromArgb(190, 0, 0, 0)
        Panel4.BackColor = Color.FromArgb(190, 0, 0, 0)
        Panel2.BackColor = Color.FromArgb(190, 128, 128, 128)
        Panel5.BackColor = Color.FromArgb(190, 0, 0, 0)
        If ui = "light" Then
            Panel1.BackColor = Color.FromArgb(190, 255, 255, 255)
            Panel3.BackColor = Color.FromArgb(190, 255, 255, 255)
            Panel4.BackColor = Color.FromArgb(190, 255, 255, 255)
            Panel5.BackColor = Color.FromArgb(190, 255, 255, 255)
            notif.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Label10.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
            LinkLabel1.LinkColor = Color.Black
        End If
        n1.BackColor = Color.FromArgb(190, 0, 0, 0)
        n2.BackColor = Color.FromArgb(190, 0, 0, 0)
        n3.BackColor = Color.FromArgb(190, 0, 0, 0)
        n4.BackColor = Color.FromArgb(190, 0, 0, 0)
        Timer3.Start()
        Timer5.Start()
    End Sub

    Private Sub Panel2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseClick
        Form9.Show()
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
        If user = "" Then
            Form28.Show()
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
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
        notif.Text = "Notifications " & "(" & sh & ")"
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
        n3.Hide()
    End Sub
End Class