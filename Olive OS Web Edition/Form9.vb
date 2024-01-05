Imports System.Runtime.InteropServices
Imports System.Management
Imports System.IO
Public Class Form9
    Dim d As String = 0
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Form8.Close()
        Form41.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "On", "")
        End
        End
        End
        End
        End
    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form8.Label21.Text = "1" Then
            Button5.ForeColor = Color.Orange
            Button5.Text = "[!] Restart"
        End If
        Dim uq = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "UpdateQueued", Nothing)
        If uq = "1" Then
            Button5.Text = "[!] Restart"
            Button5.ForeColor = Color.Orange
            Form8.Label18.Text = "1"
        End If
        If Form8.Label18.Text = "1" Then
            Button5.Text = "[!] Restart"
            Button5.ForeColor = Color.Orange
        End If
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        Timer1.Start()
        comDate()
        Label7.Text = Format(Now, "dddd") & ", " & d & " " & DateTime.Now.ToString("dd") & ", " & DateTime.Now.ToString("yyyy")
        Dim ur = My.Computer.Registry.GetValue(
   "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Username", Nothing)
        Label4.Text = ur
        Dim pic = My.Computer.Registry.GetValue(
    "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "PFP", Nothing)
        If pic = "1" Then
            pb.Image = My.Resources.use2
        End If

        If pic = "3" Then
            pb.Image = My.Resources.use3
        End If
        If pic = "2" Then
            pb.Image = My.Resources.use2
        End If
        Dim power2 As PowerStatus = SystemInformation.PowerStatus
        Dim percent2 As Single = power2.BatteryLifePercent
        Label10.Text = percent2 * 100 & "%"
        Label11.Text = percent2 * 100
        ProgressBar1.Value = Label11.Text
        Dim ui = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "ui", Nothing)
        If ui = "light" Then
            'all labels EXCEPT label2
            Label1.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
            Label6.ForeColor = Color.Black
            Label7.ForeColor = Color.Black
            Label8.ForeColor = Color.Black
            Label9.ForeColor = Color.Black
            Label10.ForeColor = Color.Black
            Label11.ForeColor = Color.Black
            Me.BackColor = Color.White
        End If
    End Sub
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Dim SoundName As String

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    Const WM_APPCOMMAND As UInteger = &H319
    Const APPCOMMAND_VOLUME_UP As UInteger = &HA
    Const APPCOMMAND_VOLUME_DOWN As UInteger = &H9
    Const APPCOMMAND_VOLUME_MUTE As UInteger = &H8

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label6.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
    Private Sub comDate()
        d = DateTime.Now.ToString("MM")
        If d = "01" Then
            d = "January"
        End If
        If d = "02" Then
            d = "Febuary"
        End If
        If d = "03" Then
            d = "March"
        End If
        If d = "04" Then
            d = "April"
        End If
        If d = "05" Then
            d = "May"
        End If
        If d = "06" Then
            d = "June"
        End If
        If d = "07" Then
            d = "July"
        End If
        If d = "08" Then
            d = "August"
        End If
        If d = "09" Then
            d = "September"
        End If
        If d = "10" Then
            d = "October"
        End If
        If d = "11" Then
            d = "November"
        End If
        If d = "12" Then
            d = "December"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
        My.Computer.Audio.Play(My.Resources.vol_adj, AudioPlayMode.Background)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
        My.Computer.Audio.Play(My.Resources.vol_adj, AudioPlayMode.Background)
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_MUTE * &H10000)
        My.Computer.Audio.Play(My.Resources.vol_adj, AudioPlayMode.Background)
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Form8.Label18.Text = "1" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "On", "")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
           "UpdateComplete", "0")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
           "UpdateQueued", "0")
            Me.Close()
            Form8.Close()
            Process.Start("C:\Program Files\Olive OS Web Edition\Updates.exe")
            End
            End
            End
        End If
        If Form8.Label21.Text = "1" Then
            Form8.Close()
            Try
                Process.Start("C:\Program Files\Olive OS S\UpdateInstaller.exe")
            Catch ex As Exception
                Form59.Show()
                Form59.TabControl1.SelectTab(3)
                Exit Sub
            End Try
            Me.Close()
            End
            End
            End
            End
            End
        End If
        If Form8.Label16.Text = "1" Then
            Me.Close()
            Form8.Close()
            Form7.Close()
            Form39.Show()
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "On", "")
            Process.Start("C:\Program Files\Olive OS Web Edition\Olive OS Web Edition.exe")
            End
            End
            End
            Exit Sub
        End If
    End Sub
End Class