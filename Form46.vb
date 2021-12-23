Public Class Form46

    Private Sub Form46_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        Timer1.Start()
    End Sub
    Private Sub refreshNow()
        Try
            Dim wc As New System.Net.WebClient
            wc.DownloadFile("https://www.dropbox.com/s/o4cjk0m69t90fp1/Refresher.exe?dl=1", "C:\Program Files\Olive OS Web Edition\Refresher.exe")
            Me.Close()
            Process.Start("C:\Program Files\Olive OS Web Edition\Refresher.exe")
            End
            End
            End
        Catch ex As Exception
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "RefreshFailed", "1")
            Process.Start("C:\Program Files\Olive OS Web Edition\Olive OS Web Edition.exe")
            End
            End
            End
            Exit Sub
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            refreshNow()
        End If
    End Sub
End Class