Public Class Form48

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(20)
        If ProgressBar1.Value = 100 Then
            Me.Close()
        End If
    End Sub

    Private Sub Form48_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class