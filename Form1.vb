Imports System.IO
Public Class Form1
    Dim pathc As String
    Dim filec As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PlayButton()
        Timer1.Start()
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
            Form2.Show()
            Me.Hide()
            Timer1.Stop()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub
End Class
