Public Class Form22

    Private Sub Form22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mp As Point = MousePosition
        Me.Location = mp
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
    End Sub

    Private Sub Form22_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        If Form25.Visible = True Then
            'NOTHING
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Panel1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick
        If Label4.Text = "1" Then
            Form23.Show()
            Form23.label.Text = "1"
        End If
        If Label4.Text = "2" Then
            Form23.Show()
            Form23.label.Text = "2"
        End If
        If Label4.Text = "3" Then
            Form23.Show()
            Form23.label.Text = "3"
        End If
        If Label4.Text = "4" Then
            Form23.Show()
            Form23.label.Text = "4"
        End If
        If Label4.Text = "5" Then
            Form23.Show()
            Form23.label.Text = "5"
        End If
        If Label4.Text = "" Then
            Form4.Show()
            Form4.Label1.Text = "No app!"
        End If
    End Sub

    Private Sub Panel1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.MouseHover
        Panel1.BackColor = Color.LightGray
        Label1.BackColor = Color.LightGray
    End Sub

    Private Sub Panel1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.MouseLeave
        Panel1.BackColor = Color.White
        Label1.BackColor = Color.White
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.MouseHover
        Panel2.BackColor = Color.LightGray
        Label2.BackColor = Color.LightGray
    End Sub

    Private Sub Panel2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.MouseLeave
        Panel2.BackColor = Color.White
        Label2.BackColor = Color.White
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseClick
        Form10.Label11.Text = Label4.Text
        Form25.Show()
    End Sub

    Private Sub Panel3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.MouseHover
        Panel3.BackColor = Color.LightGray
        Label3.BackColor = Color.LightGray
    End Sub

    Private Sub Panel3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.MouseLeave
        Panel3.BackColor = Color.White
        Label3.BackColor = Color.White
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        If Label4.Text = "1" Then
            Form23.Show()
            Form23.label.Text = "1"
        End If
        If Label4.Text = "2" Then
            Form23.Show()
            Form23.label.Text = "2"
        End If
        If Label4.Text = "3" Then
            Form23.Show()
            Form23.label.Text = "3"
        End If
        If Label4.Text = "4" Then
            Form23.Show()
            Form23.label.Text = "4"
        End If
        If Label4.Text = "5" Then
            Form23.Show()
            Form23.label.Text = "5"
        End If
        If Label4.Text = "" Then
            Form4.Show()
            Form4.Label1.Text = "No app!"
        End If
    End Sub

    Private Sub Label1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseEnter
       
    End Sub

    Private Sub Label1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseHover
        Panel1.BackColor = Color.LightGray
        Label1.BackColor = Color.LightGray
    End Sub

    Private Sub Label1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseLeave
        Panel1.BackColor = Color.White
        Label1.BackColor = Color.White
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        
    End Sub

    Private Sub Label2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseEnter
        
    End Sub

    Private Sub Label2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseHover
        Panel2.BackColor = Color.LightGray
        Label2.BackColor = Color.LightGray
    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave
        Panel2.BackColor = Color.White
        Label2.BackColor = Color.White
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Form10.Label11.Text = Label4.Text
        Form25.Show()
    End Sub

    Private Sub Label3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseEnter
        
    End Sub

    Private Sub Label3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseHover
        Panel3.BackColor = Color.LightGray
        Label3.BackColor = Color.LightGray
    End Sub

    Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        Panel1.BackColor = Color.White
        Label1.BackColor = Color.White
    End Sub
End Class