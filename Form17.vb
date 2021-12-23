
Public Class Form17
    Dim mouse_move As System.Drawing.Point
    Dim a As Integer = 0
    Dim sh As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

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

    Private Sub AboutTaskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutTaskToolStripMenuItem.Click

    End Sub

    Private Sub Form17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        sh = Label7.Text
        If Form18.Visible = True Then
            settingsbutton.Show()
            settingslabel.Show()
        Else
            settingsbutton.Hide()
            settingslabel.Hide()
        End If
        If Form16.Visible = True Then
            browserbutton.Show()
            browserlabel.Show()
        Else
            browserbutton.Hide()
            browserlabel.Hide()
        End If
        If Form21.Visible = True Then
            webappbutton.Show()
            webappinstallerbutton.Show()
        Else
            webappbutton.Hide()
            webappinstallerbutton.Hide()
        End If
        If Form28.Visible = True Then
            accountissuebutton.Show()
            accountissuelabel.Show()
        Else
            accountissuebutton.Hide()
            accountissuelabel.Hide()
        End If
        If Form23.Visible = True Then
            appplayerbutton.Show()
            appplayerlabel.Show()
        Else
            appplayerbutton.Hide()
            appplayerlabel.Hide()
        End If
        If Form10.Visible = True Then
            appscreenbutton.Show()
            appscreenlabel.Show()
        Else
            appscreenbutton.Hide()
            appscreenlabel.Hide()
        End If
        If Form12.Visible = True Then
            wallpaperbutton.Show()
            wallpaper.Show()
        Else
            wallpaperbutton.Hide()
            wallpaper.Hide()
        End If
        If Form3.Visible = True Then
            texteditor.Show()
            texteditorbutton.Show()
        Else
            texteditor.Hide()
            texteditorbutton.Hide()
        End If
        If Form11.Visible = True Then
            photoviewer.Show()
            photoviewerbutton.Show()
        Else
            photoviewer.Hide()
            photoviewerbutton.Hide()
        End If
        If Form14.Visible = True Then
            musicplayer.Show()
            musicplayerbutton.Show()
        Else
            musicplayer.Hide()
            musicplayerbutton.Hide()
        End If
        If Form5.Visible = True Then
            calculator.Show()
            calculatorbutton.Show()
        Else
            calculator.Hide()
            calculatorbutton.Hide()
        End If
        If Form26.Visible = True Then
            filesbutton.Show()
            files.Show()
        Else
            filesbutton.Hide()
            files.Hide()
        End If
        If Form8.web.DocumentTitle <> "Landing Page" Then
            p6.Text = Form8.web.DocumentTitle
        End If
        If Form8.wb2.DocumentTitle <> "Landing Page" Then
            p2.Text = Form8.wb2.DocumentTitle
        End If
        If Form8.wb3.DocumentTitle <> "Landing Page" Then
            p3.Text = Form8.wb3.DocumentTitle
        End If
        If Form8.wb4.DocumentTitle <> "Landing Page" Then
            p4.Text = Form8.wb4.DocumentTitle
        End If
        If Form8.wb5.DocumentTitle <> "Landing Page" Then
            p5.Text = Form8.wb5.DocumentTitle
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub settingsbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settingsbutton.Click
        Form18.Close()
    End Sub

    Private Sub browserbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browserbutton.Click
        Form16.Close()
    End Sub

    Private Sub appplayerbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles appplayerbutton.Click
        Form23.Close()
    End Sub

    Private Sub webappbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles webappbutton.Click
        Form21.Close()
    End Sub

    Private Sub accountissuebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles accountissuebutton.Click
        Form28.Close()
    End Sub

    Private Sub appscreenbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles appscreenbutton.Click
        Form10.Close()
    End Sub

    Private Sub wallpaperbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wallpaperbutton.Click
        Form12.Close()
    End Sub

    Private Sub photoviewerbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles photoviewerbutton.Click
        Form11.Close()
    End Sub

    Private Sub musicplayerbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles musicplayerbutton.Click
        Form14.Close()
    End Sub

    Private Sub texteditorbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles texteditorbutton.Click
        Form3.Close()
    End Sub

    Private Sub calculatorbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculatorbutton.Click
        Form5.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filesbutton.Click
        Form26.Close()
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form8.bat.Text = My.Resources.noserv
        Form8.Label2.Hide()
        Form8.Label10.Text = "---"
        Form8.Timer3.Stop()
        notif()
        Button2.Hide()
        Label2.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form8.Timer1.Stop()
        Form8.Label1.Text = "NaN"
        notif()
        Label3.Hide()
        Button3.Hide()
    End Sub
    Private Sub notif()
        If sh = 0 Then
            Form8.n1.Show()
            Form8.Label6.Text = "System Maintenance"
            Form8.Label7.Text = My.Resources.service
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 1 Then
            Form8.n2.Show()
            Form8.Label9.Text = "System Maintenance"
            Form8.Label8.Text = My.Resources.service
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 2 Then
            Form8.n3.Show()
            Form8.Label12.Text = "System Maintenance"
            Form8.Label11.Text = My.Resources.service
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 3 Then
            Form8.n4.Show()
            Form8.Label14.Text = "System Maintenance"
            Form8.Label13.Text = My.Resources.service
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        notif()
        Button4.Hide()
        Label4.Hide()
        Form8.Timer3.Stop()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        notif()
        Label5.Hide()
        Button5.Hide()
        Form8.Timer4.Stop()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form4.Show()
        Form4.Label1.Text = My.Resources.crash
        Form8.Panel5.Hide()
        Label6.Hide()
        Button6.Hide()
    End Sub

    Private Sub b1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click
        Form8.web.Navigate("about:blank")
    End Sub

    Private Sub b2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b2.Click
        Form8.wb2.Navigate("about:blank")
    End Sub

    Private Sub b3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b3.Click
        Form8.wb3.Navigate("about:blank")
    End Sub

    Private Sub b4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b4.Click
        Form8.wb4.Navigate("about:blank")
    End Sub

    Private Sub b5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b5.Click
        Form8.wb5.Navigate("about:blank")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        notif()
        Form8.Timer8.Stop()
        Label8.Hide()
        Button7.Hide()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        notif()
        Form8.Panel1.Hide()
        Form8.Panel5.Hide()
        Button8.Hide()
        Label10.Hide()
        Form8.p1.Hide()
        Form8.p2.Hide()
        Form8.p3.Hide()
        Form8.p4.Hide()
        Form8.p5.Hide()
    End Sub
End Class