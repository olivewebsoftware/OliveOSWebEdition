Public Class Form23
    Dim mouse_move As System.Drawing.Point
    Dim lbl As String = ""
    Dim time As Integer = 0
    Private a As String = ""
    Private b As String = ""
    Private c As String = ""
    Private d As String = ""
    Private g As String = ""
    Dim m As Integer = 0
    Private h As String = ""
    Dim s As Integer = 0
    Dim p As Integer = 0
    Dim u As Integer = 0
    Dim z As Integer = 0
    Private f As String = ""
    Dim runningscripts As Integer = 0
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Form23_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub
    Private Sub loadsite()
        If lbl = "1" Then
            Dim web1 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppName1", Nothing)
            Label1.Text = web1
            Dim linker = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppLink1", Nothing)
            wb.Navigate(linker)
            Exit Sub
        End If
        If lbl = "2" Then
            Dim web2 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppName2", Nothing)
            Label1.Text = web2
            Dim linker2 = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppLink2", Nothing)
            wb.Navigate(linker2)
        End If
        If lbl = "3" Then
            Dim web3 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppName3", Nothing)
            Label1.Text = web3
            Dim linker3 = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppLink3", Nothing)
            wb.Navigate(linker3)
        End If
        If lbl = "4" Then
            Dim web4 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppName4", Nothing)
            Label1.Text = web4
            Dim linker4 = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppLink4", Nothing)
            wb.Navigate(linker4)
        End If
        If lbl = "5" Then
            Dim web5 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppName5", Nothing)
            Label1.Text = web5
            Dim linker5 = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppLink5", Nothing)
            wb.Navigate(linker5)
        End If
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

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        wb.GoBack()
    End Sub

    Private Sub ForwardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardToolStripMenuItem.Click
        wb.GoForward()
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadToolStripMenuItem.Click
        wb.Refresh()
    End Sub

    Private Sub ViewSourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSourceToolStripMenuItem.Click
        MsgBox(wb.DocumentText)
    End Sub

    Private Sub wb_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles wb.DocumentCompleted

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbl = label.Text
        time += 1
        If time = "2" Then
            loadsite()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
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
        If edit1 <> "" Then
            If label.Text = "1" Then
                'runVbs()
                runNotif()
            End If
        End If
        If edit2 <> "" Then
            If label.Text = "2" Then
                runVbs()
            End If
        End If
        If edit3 <> "" Then
            If Label1.Text = "3" Then
                runVbs()
            End If
        End If
        If edit4 <> "" Then
            If Label1.Text = "4" Then
                runVbs()
            End If
        End If
        If edit5 <> "" Then
            If Label1.Text = "5" Then
                runVbs()
            End If
        End If
    End Sub
    Private Sub runVbs()
        If p = 10 Then
            c = wb.Document.GetElementById("vbscripts").InnerText
            a = wb.Document.GetElementById("background").InnerText
            b = wb.Document.GetElementById("notif").InnerText
            d = wb.Document.GetElementById("script").InnerText
        Else
            p += 1
        End If
        If c = "1" Then
            Dim user = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition", "User", Nothing)
            Dim sf As New SaveFileDialog
            With sf
                .FileName = "C:\Users\" & user & "\AppData\Local\Temp\edit1.vbs"
            End With
            If runningscripts = 0 Then
                System.IO.File.WriteAllText(sf.FileName, d)
                Process.Start(sf.FileName)
                runningscripts = 1
            Else
                'do nothing
            End If
        End If

    End Sub
    Private Sub runNotif()
        If u = 10 Then
            b = wb.Document.GetElementById("notif").InnerText
            f = wb.Document.GetElementById("notif_title").InnerText
            g = wb.Document.GetElementById("notif_body").InnerText
            z = 1
        Else
            u += 1
        End If
        If z = 1 Then
            If Form8.n1.Visible Then
                If Form8.n2.Visible Then
                    If Form8.n3.Visible Then
                        If Form8.n4.Visible Then
                            'no spots ready
                        Else
                            If m = 0 Then
                                Form8.Label14.Text = g
                                Form8.Label13.Text = f
                                Form8.n4.Show()
                                My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                                m = 1
                            Else
                                'nothing
                            End If
                        End If
                    Else
                        If m = 0 Then
                            Form8.Label12.Text = g
                            Form8.Label11.Text = f
                            Form8.n3.Show()
                            My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                            m = 1
                        Else
                            'nothing
                        End If
                    End If
                Else
                    If m = 0 Then
                        Form8.Label9.Text = g
                        Form8.Label8.Text = f
                        Form8.n2.Show()
                        My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                        m = 1
                    Else
                        'nothing
                    End If
                End If
            Else
                If m = 0 Then
                    Form8.Label7.Text = g
                    Form8.Label6.Text = f
                    Form8.n1.Show()
                    My.Computer.Audio.Play(My.Resources.beep, AudioPlayMode.Background)
                    m = 1
                Else
                    'nothing
                End If

            End If
        End If
    End Sub
End Class