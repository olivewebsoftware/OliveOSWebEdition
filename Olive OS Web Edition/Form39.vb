Public Class Form39
    Dim cl As Integer = 0
    Dim cn As Integer = 0
    Dim backup As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Label1.Text = "We are now checking Olive OS for errors. Please wait. Do not turn off your computer."
            Timer2.Start()
            Timer1.Stop()
        End If
    End Sub

    Private Sub Form39_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            If cl = 1 Then
                If cn = 1 Then
                    End
                    End
                    Exit Sub
                End If
                Timer2.Stop()
                Timer3.Stop()
                Me.Close()
                Form7.Show()
            End If
        End If
    End Sub

    Private Sub Form39_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        Try
            Dim setr = My.Computer.Registry.GetValue(
            "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "CurrentSetupState", Nothing)
            If setr = "" Then

            Else
                cl = 1
                Form4.Show()
                Form4.Label1.Text = My.Resources.sysrep
            End If
        Catch ex As Exception
            Form43.Show()
            Form43.Label2.Text = ex.Message
        End Try
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar2.Increment(1)
        Timer3.Start()
        If backup = 5 Then
            Dim bk = My.Computer.Registry.GetValue(
 "HKEY_CURRENT_USER\Software\Olive OS Web Edition Backup", "Backup", Nothing)
            Dim bk2 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition Backup", "Username", Nothing)
            Dim bk3 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition Backup", "Password", Nothing)
            Dim bk4 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition Backup", "Wallpaper", Nothing)
            Dim bk5 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition Backup", "PackEnabled", Nothing)
            Dim bk6 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition Backup", "Browser", Nothing)
            Dim bk7 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition Backup", "PFP", Nothing)
            Try
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
                "Username", bk2)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
                "Password", bk3)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
                "CurrentSetupState", "done")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
              "PackEnabled", bk5)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
                "Wallpaper", bk4)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
             "Browser", bk6)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
             "PFP", bk7)
            Catch ex As Exception
                Label1.Text = "System Repair failed to repair your computer. Press F1 to restart."
                Timer2.Stop()
                Timer3.Stop()
                cn = 1
                cl = 1
                Exit Sub
            End Try
        Else
            backup += 1
        End If
    End Sub
    Private Sub restore()
        Dim bk = My.Computer.Registry.GetValue(
 "HKEY_CURRENT_USER\Software\Olive OS Web Edition Backup", "Backup", Nothing)
        Dim bk2 = My.Computer.Registry.GetValue(
    "HKEY_CURRENT_USER\Software\Olive OS Web Edition Backup", "Username", Nothing)
        Dim bk3 = My.Computer.Registry.GetValue(
    "HKEY_CURRENT_USER\Software\Olive OS Web Edition Backup", "Password", Nothing)
        Dim bk4 = My.Computer.Registry.GetValue(
    "HKEY_CURRENT_USER\Software\Olive OS Web Edition Backup", "Wallpaper", Nothing)
        Dim bk5 = My.Computer.Registry.GetValue(
    "HKEY_CURRENT_USER\Software\Olive OS Web Edition Backup", "PackEnabled", Nothing)
        Dim bk6 = My.Computer.Registry.GetValue(
    "HKEY_CURRENT_USER\Software\Olive OS Web Edition Backup", "Browser", Nothing)
        Dim bk7 = My.Computer.Registry.GetValue(
 "HKEY_CURRENT_USER\Software\Olive OS Web Edition Backup", "PFP", Nothing)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
      "Username", bk2)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "Password", bk3)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "CurrentSetupState", "done")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
      "PackEnabled", bk5)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "Wallpaper", bk4)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
     "Browser", bk6)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
     "PFP", bk7)
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Label1.Text = "Repairing your system " & "(" & ProgressBar2.Value & "%" & ")"
        If ProgressBar2.Value = 100 Then
            cl = 1
            Label1.Text = "System Repair will continue after you restart. Press F1 to restart."
        End If
    End Sub
End Class