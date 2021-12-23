Public Class Form51

    Private Sub Form51_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(190, 0, 0, 0)
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        Timer1.Start()
        Dim setup = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Wallpaper", Nothing)
        Dim pack = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "PackEnabled", Nothing)
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
                Me.BackColor = Color.Black
                    Exit Sub
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 50 Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
"P3POS-X", Form8.p3.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "P3POS-Y", Form8.p3.Location.Y)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "P4POS-X", Form8.p4.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "P4POS-Y", Form8.p4.Location.Y)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "P5POS-X", Form8.p5.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "P5POS-Y", Form8.p5.Location.Y)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "P1POS-X", Form8.p1.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "P1POS-Y", Form8.p1.Location.Y)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
           "SP2POS-X", Form8.sp2.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "SP2POS-Y", Form8.sp2.Location.Y)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "SP3POS-X", Form8.sp3.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "SP3POS-Y", Form8.sp3.Location.Y)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "SP4POS-X", Form8.sp4.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "SP4POS-Y", Form8.sp4.Location.Y)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "SP5POS-X", Form8.sp5.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "SP5POS-Y", Form8.sp5.Location.Y)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "SP1POS-X", Form8.sp1.Location.X)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "SP1POS-Y", Form8.sp1.Location.Y)
        End If
        If ProgressBar1.Value = 100 Then
            ProgressBar1.Value = 0
            Form8.Show()
            Form4.Show()
            Form4.Label1.Text = "Repair complete. Please restart."
            Me.Close()
            Timer1.Stop()
            Exit Sub
        End If
    End Sub
End Class