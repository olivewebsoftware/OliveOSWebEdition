Public Class Form59
    Dim sh As Integer = Form8.Label17.Text
    Dim mouse_move As System.Drawing.Point
    Dim yt As Integer = 0
    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim wc As New System.Net.WebClient
        Try
            wc.DownloadFile("https://www.dropbox.com/s/y2vpu33r70u141t/Olive%20OS%20Upgrade.exe?dl=1", "C:\Program Files\Olive OS Web Edition\Updates.exe")
        Catch ex As Exception
            yt = 1
            BackgroundWorker1.Dispose()
        End Try
        System.Threading.Thread.Sleep("200")
        Try
            If yt = "1" Then
                BackgroundWorker1.Dispose()
            Else
                Process.Start("C:\Program Files\Olive OS Web Edition\Updates.exe")
            End If
        Catch ex As Exception
            yt = 1
        End Try
        BackgroundWorker1.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim setup = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "UpgradeFinished", Nothing)
        Try
            If setup = "yes" Then
                Timer1.Stop()
                TabControl1.SelectTab(2)
                Form8.Label21.Text = "1"
                notifU()
            End If
        Catch ex As Exception

        End Try
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
    Private Sub oops()
        If sh = 0 Then
            Form8.n1.Show()
            Form8.Label6.Text = "Upgrade Failed"
            Form8.Label7.Text = "Make sure that Olive OS" & vbNewLine & "was run as an Administrator" & vbNewLine & "before upgrading."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 1 Then
            Form8.n2.Show()
            Form8.Label9.Text = "Upgrade Failed"
            Form8.Label8.Text = "Make sure that Olive OS" & vbNewLine & "was run as an Administrator" & vbNewLine & "before upgrading."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 2 Then
            Form8.n3.Show()
            Form8.Label12.Text = "Upgrade Failed"
            Form8.Label11.Text = "Make sure that Olive OS" & vbNewLine & "was run as an Administrator" & vbNewLine & "before upgrading."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
        If sh = 3 Then
            Form8.n4.Show()
            Form8.Label14.Text = "Upgrade Failed"
            Form8.Label13.Text = "Make sure that Olive OS" & vbNewLine & "was run as an Administrator" & vbNewLine & "before upgrading."
            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
            Exit Sub
        End If
    End Sub

    Private Sub TabPage2_Click(sender As System.Object, e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TabControl1.SelectTab(1)
        Timer1.Start()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.youtube.com/watch?v=ggcBGzK39WE")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        BackgroundWorker1.Dispose()
        Me.Close()
        Form4.Show()
        Form4.Label1.Text = "Operation cancelled by user."
    End Sub

    Private Sub Form59_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        Timer2.Start()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Try
            Process.Start("C:\Program Files\Olive OS S\Olive OS S.exe")
            Form8.Close()
        Catch ex As Exception
            TabControl1.SelectTab(3)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
            "UpgradeFinished", "")
            Exit Sub
        End Try
        Me.Close()
        End
        End
        End
        End
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

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

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If yt = "1" Then
            oops()
            Me.Close()
        End If
    End Sub

    Private Sub TabPage4_Click(sender As System.Object, e As System.EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class