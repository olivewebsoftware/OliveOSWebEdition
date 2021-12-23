Public Class Form22
    Dim open As String = ""
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
        If Label4.Text = "s1" Then
            ProcessLink()
        End If
        If Label4.Text = "s2" Then
            ProcessLink()
        End If
        If Label4.Text = "s3" Then
            ProcessLink()
        End If
        If Label4.Text = "s4" Then
            ProcessLink()
        End If
        If Label4.Text = "s5" Then
            ProcessLink()
        End If
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

    Private Sub Panel2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseClick
        Form18.Show()
        Form18.TabControl1.SelectTab(5)
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
        If Label4.Text = "s1" Then
            ProcessLink()
        End If
        If Label4.Text = "s2" Then
            ProcessLink()
        End If
        If Label4.Text = "s3" Then
            ProcessLink()
        End If
        If Label4.Text = "s4" Then
            ProcessLink()
        End If
        If Label4.Text = "s5" Then
            ProcessLink()
        End If
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
    Private Sub ProcessLink()
        If Label4.Text = "s1" Then
            Dim l1 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "ShortcutLink1", Nothing)
            open = l1
            Secured_OpenApp()
        End If
        If Label4.Text = "s2" Then
            Dim l2 = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "ShortcutLink2", Nothing)
            open = l2
            Secured_OpenApp()
        End If
        If Label4.Text = "s3" Then
            Dim l3 = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "ShortcutLink3", Nothing)
            open = l3
            Secured_OpenApp()
        End If
        If Label4.Text = "s4" Then
            Dim l4 = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "ShortcutLink4", Nothing)
            open = l4
            Secured_OpenApp()
        End If
        If Label4.Text = "s5" Then
            Dim l5 = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "ShortcutLink5", Nothing)
            open = l5
            Secured_OpenApp()
        End If
    End Sub
    Private Sub Secured_OpenApp()
        If open = "web" Then
            Form16.Show()
            Me.Close()
        End If
        If open = "file" Then
            Form26.Show()
            Me.Close()
        End If
        If open = "calc" Then
            Form5.Show()
            Me.Close()
        End If
        If open = "textedit" Then
            Form3.Show()
            Me.Close()
        End If
        If open = "photo" Then
            Form11.Show()
            Me.Close()
        End If
        If open = "security" Then
            Form33.Show()
            Me.Close()
        End If
        If open = "music" Then
            Form14.Show()
            Me.Close()
        End If
        If open = "settings" Then
            Form18.Show()
            Me.Close()
        End If
        If open = "webapp" Then
            Form21.Show()
            Me.Close()
        End If
        If open = "help" Then
            Form45.Show()
            Me.Close()
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
        Form18.Show()
        Form18.TabControl1.SelectTab(5)
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