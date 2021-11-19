Imports System.IO
Public Class Form1
    Dim pathc As String
    Dim filec As String

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
       
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PlayButton()
        Timer1.Start()
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "Version", "3.0")
    End Sub
    Private Sub PlayButton()
        pathc = Path.Combine(Application.StartupPath, "web.mp4")
        If (Not File.Exists(pathc)) Then
            File.WriteAllBytes(pathc, My.Resources.web)
        End If
        filec = 1
        VideoMain()
    End Sub
    Private Sub VideoMain()
        AxWindowsMediaPlayer1.URL = pathc
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(9)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub Form1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        ProgressBar2.Value = 0
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        Timer1.Stop()
        Label1.Show()
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar2.Increment(1)
        If ProgressBar2.Value = 50 Then
            Label1.Text = "System Recovery will load in a moment..."
        End If
        If ProgressBar2.Value = 90 Then
            Label1.Text = "Done!"
        End If
        If ProgressBar2.Value = 100 Then
            Form36.Show()
            Me.Hide()
        End If
    End Sub
End Class
