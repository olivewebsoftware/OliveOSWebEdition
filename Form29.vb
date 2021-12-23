Public Class Form29
    Dim q As Integer = 0
    Private Sub Form29_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If q = 0 Then
            q = 1
            Try
                Try
                    My.Computer.Registry.CurrentUser.DeleteSubKey(
    "SOFTWARE\Olive OS Web Edition\Login")
                Catch ex As Exception
                    'No security questions were present.
                End Try
                Try
                    My.Computer.Registry.CurrentUser.DeleteSubKey(
  "SOFTWARE\Olive OS Web Edition\System")
                Catch ex As Exception
                    'No OEM screen was set
                End Try
                My.Computer.Registry.CurrentUser.DeleteSubKey(
"SOFTWARE\Olive OS Web Edition\WebApps")
                My.Computer.Registry.CurrentUser.DeleteSubKey(
    "SOFTWARE\Olive OS Web Edition\AdminControl")
                My.Computer.Registry.CurrentUser.DeleteSubKey(
     "SOFTWARE\Olive OS Web Edition")
                My.Computer.Registry.CurrentUser.DeleteSubKey(
     "SOFTWARE\Olive OS Web Edition Backup")
            Catch ex As Exception
                MsgBox("Reset failed.")
                End
                End
                End
            End Try
        Else
            'do nothing
        End If
        If ProgressBar1.Value = 100 Then
            Me.Close()
            Timer1.Stop()
            Form2.Show()
        End If
    End Sub
End Class