Public Class Form7
    Dim n As Integer = 0
    Dim m As Integer = 0
    Private Sub Form7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        
    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        Dim pack = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "PackEnabled", Nothing)
        Panel1.BackColor = Color.FromArgb(190, 0, 0, 0)
        Dim setup = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Wallpaper", Nothing)
        If pack = "yes" Then
            Me.BackgroundImage = Image.FromFile(setup)
        End If
        If setup = "def" Then
            Me.BackgroundImage = My.Resources.def
        End If
        If setup = "rockwater" Then
            Me.BackgroundImage = My.Resources.rockwater
        End If
        If setup = "cliff" Then
            Me.BackgroundImage = My.Resources.cliff
        End If
        If setup = "def2" Then
            Me.BackgroundImage = My.Resources.webdefault
        End If
        If setup = "game" Then
            Me.BackgroundImage = My.Resources.gameon
        End If
        Dim ur = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Username", Nothing)
        Label5.Text = ur
        Dim pic = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "PFP", Nothing)
        If pic = "1" Then
            pb.Image = My.Resources._1
        End If
        If pic = "2" Then
            pb.Image = My.Resources._2
        End If
        If pic = "3" Then
            pb.Image = My.Resources._3
        End If
        If pic = "4" Then
            pb.Image = My.Resources._4
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Dim pwd = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Password", Nothing)
        If e.KeyCode = Keys.Enter Then
            If m = 1 Then
                Form4.Show()
                Form4.Label1.Text = "Olive OS is disabled."
                Exit Sub
            End If
            If TextBox1.Text = pwd Then
                Me.Close()
                Form8.Show()
            Else
                If n = 3 Then
                    Form4.Show()
                    Form4.Label1.Text = My.Resources.err
                    m = 1
                    Timer1.Start()
                    Exit Sub
                End If
                Form4.Show()
                Form4.Label1.Text = "Incorrect password."
                n += 1
            End If
        End If
    End Sub

    Private Sub TextBox1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.SizeChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 300 Then
            m = 0
            n = 0
            Timer1.Stop()
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Panel1.Hide()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        End
        End
        End
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Panel1.Hide()
        Me.Hide()
        Me.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Panel1.Show()
    End Sub
End Class