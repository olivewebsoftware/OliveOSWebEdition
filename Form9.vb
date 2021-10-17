Imports System.Runtime.InteropServices
Imports System.Management
Imports System.IO
Public Class Form9
    Dim d As String = 0
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Form8.Close()
        Form7.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
        End
        End
        End
        End
    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        comDate()
        Label7.Text = Format(Now, "dddd") & ", " & d & " " & DateTime.Now.ToString("dd") & ", " & DateTime.Now.ToString("yyyy")
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
End Class