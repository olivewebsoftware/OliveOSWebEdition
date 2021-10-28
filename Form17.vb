Public Class Form17
    Dim mouse_move As System.Drawing.Point
    Dim a As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

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

    Private Sub AboutTaskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutTaskToolStripMenuItem.Click
        Form4.Show()
        Form4.Label1.Text = "App: " & ListBox1.SelectedItem
    End Sub

    Private Sub Form17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub seeTask()
        webapp()
    End Sub
    Private Sub webapp()
        If Form23.Visible Then
            If ListBox1.ToString.Contains("App: OLIVEWEB WEBAPP PLAYER 1.0") Then
                Exit Sub
            Else
                If a = 0 Then
                    a = 1
                    ListBox1.Items.Add("App: OLIVEWEB WEBAPP PLAYER 1.0")
                Else
                    Exit Sub
                End If
            End If
        Else
            a = 0
            ListBox1.Items.Remove("App: OLIVEWEB WEBAPP PLAYER 1.0")
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

        If TabControl1.SelectedTab Is TabPage2 Then
            Form4.Show()
            Form4.Label1.Text = "This task is critical to Olive OS."
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        seeTask()
    End Sub
End Class