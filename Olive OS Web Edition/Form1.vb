
Imports System.IO
Public Class Form1
    Dim pathc As String
    Dim filec As String
    Dim bscrn As String = ""
    Dim r As Integer = 0


    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F4 Then
            Label4.Text = "1"
            MsgBox("")
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        checkForBootscreenAndScript()
        whyWontItListen()
        PlayButton()
        Timer1.Start()
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "Version", "15.0")
        Dim pwr = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition", "On", Nothing)
        If pwr = "1" Then
            Form58.Show()
            Me.Hide()
            Exit Sub
            Exit Sub
            Exit Sub
        End If
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "On", "1")
    End Sub
    Private Sub checkForBootscreenAndScript()
        Dim ref = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition", "RefreshFailed", Nothing)
        If ref = "1" Then
            Timer1.Stop()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            Timer1.Stop()
            Label2.Show()
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
      "RefreshFailed", "")
            Label2.Text = "The System Refresh you started was unable to complete." & vbNewLine & "Olive OS couldn't download the file that was required to" & vbNewLine & "refresh the system. Please run Olive OS as an administrator. You need to restart Olive OS."
            r = 1
            Timer1.Stop()
        End If
        Dim uip = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition\System", "Bootscreen", Nothing)
        If uip = "" Then
            'no bootscreen
        Else
            bscrn = uip
        End If
        Dim uip2 = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition\System", "Script", Nothing)
        If uip2 = "" Then
            'nothing
        Else
            Try
                Process.Start(uip2)
            Catch ex As Exception
                AxWindowsMediaPlayer1.Ctlcontrols.stop()
                Label2.Show()
                r = 1
                Timer2.Stop()
            End Try
        End If

    End Sub
    Private Sub PlayButton()
        If bscrn = "" Then
            'nothing
        Else
            pathc = bscrn
            filec = 1
            VideoMain()
            Exit Sub
        End If
        pathc = Path.Combine(Application.StartupPath, "web.mp4")
        If (Not File.Exists(pathc)) Then
            File.WriteAllBytes(pathc, My.Resources.web)
        End If
        filec = 1
        VideoMain()
    End Sub
    Private Sub whyWontItListen()
        Dim uip = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition", "UpdateInProgress", Nothing)
        If uip = "1" Then
            r = 1
            Form44.Show()
            Me.Hide()
            Me.Hide()
            Timer1.Stop()
            Exit Sub
        End If
    End Sub
    Private Sub VideoMain()
        Try
            AxWindowsMediaPlayer1.URL = pathc
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If r = 1 Then
            Timer1.Stop()
            Timer1.Stop()
        End If
        ProgressBar1.Increment(9)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Try
                Form2.Show()
            Catch ex As Exception
                Form43.Show()
                Form43.Label2.Text = ex.Message
            End Try
            Me.Hide()
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub Form1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        ProgressBar2.Value = 0
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        If Label2.Visible Then
            Label1.Text = "System Recovery was unable to start. Private Sub Timer2_Tick couldn't be accessed."
        End If
        Timer1.Stop()
        Label1.Show()
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If r = 1 Then
            Timer2.Stop()
            Exit Sub
        End If
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

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        Form36.Show()
        Me.Hide()
    End Sub
End Class
