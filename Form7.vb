Public Class Form7
    Dim n As Integer = 0
    Dim m As Integer = 0
    Dim d As String = 0
    Private Sub Form7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        
    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        Timer2.Start()
        Dim pack = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "PackEnabled", Nothing)
        Panel1.BackColor = Color.FromArgb(190, 0, 0, 0)
        Dim setup = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Wallpaper", Nothing)
        If pack = "yes" Then
            Try
                Me.BackgroundImage = Image.FromFile(setup)
            Catch ex As Exception
                Me.BackColor = Color.Black
            End Try
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
        user.Text = ur
        Dim pic = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "PFP", Nothing)
        If pic = "1" Then
            pb.Image = My.Resources.use1
        End If
      
        If pic = "3" Then
            pb.Image = My.Resources.use3
        End If
        If pic = "2" Then
            pb.Image = My.Resources.use2
        End If
    End Sub
    Private Sub comDate()
        d = DateTime.Now.ToString("MM")
        If d = "01" Then
            d = "January"
        End If
        If d = "02" Then
            d = "Febuary"
        End If
        If d = "03" Then
            d = "March"
        End If
        If d = "04" Then
            d = "April"
        End If
        If d = "05" Then
            d = "May"
        End If
        If d = "06" Then
            d = "June"
        End If
        If d = "07" Then
            d = "July"
        End If
        If d = "08" Then
            d = "August"
        End If
        If d = "09" Then
            d = "September"
        End If
        If d = "10" Then
            d = "October"
        End If
        If d = "11" Then
            d = "November"
        End If
        If d = "12" Then
            d = "December"
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb.KeyDown
        Dim pwd = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Password", Nothing)
        If e.KeyCode = Keys.Enter Then
            If m = 1 Then
                Form4.Show()
                Form4.Label1.Text = "Olive OS is disabled."
                Exit Sub
            End If
            If tb.Text = pwd Then
                Form8.Show()
                Me.Close()
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

    Private Sub TextBox1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tb.SizeChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb.TextChanged

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
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "On", "")
        End
        End
        End
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "On", "")
        Process.Start("C:\Program Files\Olive OS Web Edition\Olive OS Web Edition.exe")
        End
        End
        End
        Exit Sub
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Panel1.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles forgot.LinkClicked
        Dim ui = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\Login", "SetupState", Nothing)
        If ui = "" Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.dang
        Else
            Form32.Show()
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Panel1.Hide()
        Form4.Show()
        Form4.Label1.Text = "Enter password to return to Olive OS."
        Form37.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        comDate()
        time.Text = DateTime.Now.ToString("hh:mm tt")
        dateok.Text = Format(Now, "dddd") & ", " & d & " " & DateTime.Now.ToString("dd") & ", " & DateTime.Now.ToString("yyyy")
    End Sub

    Private Sub Form7_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        pb.Show()
        user.Show()
        forgot.Show()
        tb.Show()
        time.Hide()
        dateok.Hide()
    End Sub
End Class