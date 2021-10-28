Public Class Form21
    Dim mouse_move As System.Drawing.Point
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Form21_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
        "AppName1", TextBox1.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
        "AppLink1", TextBox2.Text)
        If CheckBox1.Checked = True Then
            Form24.Show()
            Timer1.Start()
        Else
            Form4.Show()
            Form4.Label1.Text = "Installation sucessful."
        End If
       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
        "AppName2", TextBox3.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
        "AppLink2", TextBox4.Text)
        If CheckBox2.Checked = True Then
            Form24.Show()
            Timer2.Start()
        Else
            Form4.Show()
            Form4.Label1.Text = "Installation sucessful."
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
        "AppName3", TextBox5.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
        "AppLink3", TextBox6.Text)
        If CheckBox3.Checked = True Then
            Form24.Show()
            Timer3.Start()
        Else
            Form4.Show()
            Form4.Label1.Text = "Installation sucessful."
        End If
       
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
        "AppName4", TextBox7.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
        "AppLink4", TextBox8.Text)
        If CheckBox4.Checked = True Then
            Form24.Show()
            Timer4.Start()
        Else
            Form4.Show()
            Form4.Label1.Text = "Installation sucessful."
        End If
      
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
        "AppName5", TextBox9.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
        "AppLink5", TextBox10.Text)
        If CheckBox5.Checked = True Then
            Form24.Show()
            Timer5.Start()
        Else
            Form4.Show()
            Form4.Label1.Text = "Installation sucessful."
        End If
      
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

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Form23.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Form24.Label2.Text = "yes" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
           "Edit1", "1")
            Form24.Close()
            Form4.Show()
            Form4.Label1.Text = "Permissions given."
            Timer1.Stop()
        End If
        If Form24.Label2.Text = "no" Then
            Form4.Show()
            Form4.Label1.Text = "Permissions were denied."
            Form24.Close()
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Form24.Label2.Text = "yes" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
           "Edit2", "1")
            Form24.Close()
            Form4.Show()
            Form4.Label1.Text = "Permissions given."
            Timer2.Stop()
        End If
        If Form24.Label2.Text = "no" Then
            Form4.Show()
            Form4.Label1.Text = "Permissions were denied."
            Form24.Close()
            Timer2.Stop()
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Form24.Label2.Text = "yes" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
           "Edit3", "1")
            Form24.Close()
            Form4.Show()
            Form4.Label1.Text = "Permissions given."
            Timer3.Stop()
        End If
        If Form24.Label2.Text = "no" Then
            Form4.Show()
            Form4.Label1.Text = "Permissions were denied."
            Form24.Close()
            Timer3.Stop()
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If Form24.Label2.Text = "yes" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
           "Edit4", "1")
            Form24.Close()
            Form4.Show()
            Form4.Label1.Text = "Permissions given."
            Timer4.Stop()
        End If
        If Form24.Label2.Text = "no" Then
            Form4.Show()
            Form4.Label1.Text = "Permissions were denied."
            Form24.Close()
            Timer4.Stop()
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        If Form24.Label2.Text = "yes" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
           "Edit5", "1")
            Form24.Close()
            Form4.Show()
            Form4.Label1.Text = "Permissions given."
            Timer5.Stop()
        End If
        If Form24.Label2.Text = "no" Then
            Form4.Show()
            Form4.Label1.Text = "Permissions were denied."
            Form24.Close()
            Timer5.Stop()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "Img1", OpenFileDialog1.FileName)
            Form4.Show()
            Form4.Label1.Text = "Upload complete."
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "Img2", OpenFileDialog1.FileName)
            Form4.Show()
            Form4.Label1.Text = "Upload complete."
        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "Img3", OpenFileDialog1.FileName)
            Form4.Show()
            Form4.Label1.Text = "Upload complete."
        End If
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "Img4", OpenFileDialog1.FileName)
            Form4.Show()
            Form4.Label1.Text = "Upload complete."
        End If
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition\WebApps",
          "Img5", OpenFileDialog1.FileName)
            Form4.Show()
            Form4.Label1.Text = "Upload complete."
        End If
    End Sub
End Class