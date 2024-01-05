Public Class Form31
    Dim r As Integer = 0
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim rn As New Random
        r = rn.Next(0, 4)
        If r = 1 Then
            Me.BackColor = Color.Gray
        End If
        If r = 2 Then
            Me.BackColor = Color.White
        End If
        If r = 3 Then
            Me.BackColor = Color.LightBlue
        End If
        If r = 4 Then
            Me.BackColor = Color.LimeGreen
        End If
    End Sub

    Private Sub Form31_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
    End Sub

    Private Sub Form31_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.Close()
    End Sub
End Class