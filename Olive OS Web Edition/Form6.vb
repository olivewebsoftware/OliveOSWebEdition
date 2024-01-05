Public Class Form6
    Dim s As Integer = 0
    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Select()
        Timer1.Start()
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        s += 1
        If s = 5 Then
            If InternetConnection() = True Then
                Me.Close()
            Else
                Form4.Show()
                Me.Close()
                Form4.Label1.Text = My.Resources.neterror
            End If
        End If
    End Sub
    Private Function InternetConnection() As Boolean
        Dim req As System.Net.WebRequest = System.Net.WebRequest.Create("http://www.google.com/")
        Dim resp As System.Net.WebResponse
        Try
            resp = req.GetResponse
            resp.Close()
            req = Nothing
            Return True
        Catch ex As Exception
            req = Nothing
            Return False
        End Try
    End Function
End Class